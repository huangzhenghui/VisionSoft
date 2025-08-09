using System;
using System.Collections.Generic;
using Basler.Pylon;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Imaging;
using System.Windows.Forms;
using System.Runtime.Serialization;
using System.ComponentModel;
using VisionCore;
using System.Threading;
using System.Collections.Concurrent;
using TSIVision.FrmConfigR;

namespace Plugin.Cameras.Basler
{
    [Category("Basler相机")]
    [DisplayName("Basler相机")]
    [Serializable]
    public class CamerasBasler : CamerasBase
    {
        #region 字段、属性

        /// <summary>
        /// basler相机类的对象
        /// </summary>
        [NonSerialized]
        private Camera mCamera;

        /// <summary>
        /// 进程对象
        /// </summary>
        [NonSerialized]
        Process process;

        /// <summary>
        /// 计时器
        /// </summary>
        [NonSerialized]
        private Stopwatch mStopwatch = new Stopwatch();

        /// <summary>
        /// Sfnc2_0_0,说明是USB3的相机
        /// </summary>
        [NonSerialized]
        static Version Sfnc2_0_0 = new Version(2, 0, 0);

        #endregion

        #region 初始化

        public CamerasBasler() : base() { }

        #endregion

        #region 方法-搜索相机

        /// <summary>
        /// 搜索相机，并放入ComboBox中
        /// </summary>
        public override List<CamerasInfo> SearchCameras()
        {
            List<CamerasInfo> camInfoList = new List<CamerasInfo>();
            List<ICameraInfo> baslerInfoList = CameraFinder.Enumerate();
            foreach (ICameraInfo item in baslerInfoList)
            {
                if (item[CameraInfoKey.ModelName].Split('-')[0].ToCharArray()[0]!='a')
                {
                    continue;
                }
                CamerasInfo camInfo = new CamerasInfo();
                camInfo.m_SerialNO = item[CameraInfoKey.SerialNumber];
                try
                {
                    camInfo.m_CameraIP = item[CameraInfoKey.DeviceIpAddress];
                }
                catch
                {
                    camInfo.m_CameraIP = "00:00:00:00";
                }
                camInfo.m_CamName = item[CameraInfoKey.UserDefinedName];
                camInfo.m_Connected = false;
                camInfoList.Add(camInfo);
            }
            return camInfoList;
        }

        #endregion

        #region 方法-设置相机连接与断开

        /// <summary>
        /// 监控相机连接状态
        /// </summary>
        public override void MoniCamConn()
        {
            while (true)
            {
                try
                {
                    if (mCamera == null)
                    {
                        continue;
                    }

                    DeviceAccessibilityInfo result = CameraFinder.GetDeviceAccessibilityInfo(mCamera.CameraInfo);
                    if (result == DeviceAccessibilityInfo.Opened)
                    {
                        mConnected = true;
                    }
                    else
                    {
                        mConnected = false;
                    }
                }
                catch
                {
                    mConnected = false;
                }
                Thread.Sleep(50);
            }
        }

        /// <summary>
        /// 重连相机
        /// </summary>
        public override void ReConnCam()
        {
            bool onlyDisp = true;
            while (true)
            {
                isExeOver = false;
                while (isReConnCam)
                {
                    try
                    {
                        if (mCamera == null)
                        {
                            mCamera = new Camera(mSerialNo);
                        }

                        if (mCamera != null && isApply == true && mConnected == false)
                        {
                            if (onlyDisp)
                            {
                                Log.Info(mCamName + ":断开连接");
                                onlyDisp = false;
                            }

                            mCamera = new Camera(mSerialNo);
                            mCamera.Open();

                            DeviceAccessibilityInfo result = CameraFinder.GetDeviceAccessibilityInfo(mCamera.CameraInfo);
                            if (result == DeviceAccessibilityInfo.Opened)
                            {
                                mConnected = true;
                                onlyDisp = true;
                                Log.Info(mCamName + ":重连成功");

                                //重连成功则重新注册回调函数
                                mCamera.StreamGrabber.ImageGrabbed += OnImageGrabbed;
                                mCamera.StreamGrabber.GrabStarted += OnGrabStarted;
                                mCamera.StreamGrabber.GrabStopped += OnGrabStopped;
                            }
                            else
                            {
                                mConnected = false;
                            }
                        }
                    }
                    catch
                    {
                        mConnected = false;
                    }
                }
                isExeOver = true;
            }
        }

        /// <summary>
        /// 连接相机
        /// </summary>
        public override void ConnectDev()
        {
            if (mConnected) { return; }
            try
            {
                //连接相机
                mCamera = new Camera(mSerialNo);
                DeviceAccessibilityInfo result1 = CameraFinder.GetDeviceAccessibilityInfo(mCamera.CameraInfo);
                mCamera.Open();
                DeviceAccessibilityInfo result = CameraFinder.GetDeviceAccessibilityInfo(mCamera.CameraInfo);

                if (result == DeviceAccessibilityInfo.Opened)
                {
                    //注册回调函数
                    if (!isRegisterImageCallBack)
                    {
                        mCamera.StreamGrabber.ImageGrabbed += OnImageGrabbed;
                        mCamera.StreamGrabber.GrabStarted += OnGrabStarted;
                        mCamera.StreamGrabber.GrabStopped += OnGrabStopped;
                        isRegisterImageCallBack = true;
                    }

                    GetCamParams();
                    mConnected = true;
                }
                else
                {
                    mConnected = false;
                }
            }
            catch
            {
                mConnected = false;
            }
            finally
            {
                //启动相机监控线程和重连线程
                if (!isStartMoniCamConn)
                {
                    thMoniCamConn = new Thread(MoniCamConn);
                    thReConnCam = new Thread(ReConnCam);//重连相机线程
                    thMoniCamConn.IsBackground = true;
                    thReConnCam.IsBackground = true;
                    thMoniCamConn.Start();
                    thReConnCam.Start();
                    isReConnCam = true;
                    isStartMoniCamConn = true;
                }
            }
        }

        /// <summary>
        /// 断开相机
        /// </summary>
        public override void DisConnectDev()
        {
            if (mCamera == null) return;
            DeviceAccessibilityInfo result = CameraFinder.GetDeviceAccessibilityInfo(mCamera.CameraInfo);
            if (result != DeviceAccessibilityInfo.NotReachable)
            {
                mCamera.Close();
            }
            mCamera = null;
            mConnected = false;
            isRegisterImageCallBack = false;
        }

        #endregion

        #region 方法-设置相机采图

        /// <summary>
        /// 采集图像
        /// </summary>
        /// <param name="byHand">是否手动采图</param>
        public override bool CaptureImage(bool byHand)
        {
            try
            {
                if (mCamera == null || mConnected == false)
                {
                    if (mCamera == null || mConnected == false)
                    {
                        if (FrmCCamDebug.hWnd != null)
                        {
                            FrmCCamDebug.hWnd.label.Text = "采图失败：无相机对象";
                        }

                        Log.Info(mCamName + ":采图失败：无相机对象");
                        return false;
                    }
                }

                DeviceAccessibilityInfo result = CameraFinder.GetDeviceAccessibilityInfo(mCamera.CameraInfo);
                if (result != DeviceAccessibilityInfo.Opened)
                {
                    if (FrmCCamDebug.hWnd != null)
                    {
                        FrmCCamDebug.hWnd.label.Text = "采图失败：相机未连接";
                    }

                    Log.Info(mCamName + ":采图失败：相机未连接");
                    return false;
                }

                if (byHand)
                {
                    SetTriggerMode(TrigMode.软触发);
                    mCamera.Parameters[PLCamera.AcquisitionMode].SetValue(PLCamera.AcquisitionMode.SingleFrame);
                    mCamera.StreamGrabber.Start(1, GrabStrategy.OneByOne, GrabLoop.ProvidedByStreamGrabber);
                    mTrigState = true;
                }
                else
                {
                    SetTriggerMode(TrigMode.内触发);
                    mCamera.Parameters[PLCamera.AcquisitionMode].SetValue(PLCamera.AcquisitionMode.Continuous);
                    mCamera.StreamGrabber.Start(GrabStrategy.OneByOne, GrabLoop.ProvidedByStreamGrabber);
                    mTrigState = true;
                }

                SignalWait.Reset();
                SignalWait.WaitOne();

                if (FrmCCamDebug.hWnd != null)
                {
                    FrmCCamDebug.hWnd.label.Text = "采图中...";
                }

                Log.Info(mCamName + ":采图成功");
                return true;
            }
            catch(Exception ex)
            {
                mTrigState = false;
                StopGrab();

                if (FrmCCamDebug.hWnd != null)
                {
                    FrmCCamDebug.hWnd.label.Text = "采图失败：" + ex.Message;
                }

                Log.Info(mCamName + ":采图失败：" + ex.Message);
                return false;
            }
        }

        /// <summary>
        /// 停止采集
        /// </summary>
        public override void StopCapture()
        {
            StopGrab();
            mTrigState = false;
        }

        /// <summary>
        /// 停止采集
        /// </summary>
        public void StopGrab()
        {
            if (mCamera!=null)
            {
                try
                {
                    mCamera.StreamGrabber.Stop();
                }
                catch{ }
            }
        }

        /// <summary>
        /// 图像采集回调函数
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void OnImageGrabbed(Object sender, ImageGrabbedEventArgs e)
        {
            try
            {
                IGrabResult mResult = e.GrabResult;
                if (mResult.IsValid)
                {
                    if (!mStopwatch.IsRunning || mStopwatch.ElapsedMilliseconds > 33)
                    {
                        mStopwatch.Restart();
                        PixelDataConverter mConverter = new PixelDataConverter();
                        Bitmap bitmap = new Bitmap(mResult.Width, mResult.Height, PixelFormat.Format32bppRgb);
                        BitmapData bmpData = bitmap.LockBits(new Rectangle(0, 0, bitmap.Width, bitmap.Height), ImageLockMode.ReadWrite, bitmap.PixelFormat);
                        IntPtr ptrBmp = bmpData.Scan0;
                        mConverter.Convert(ptrBmp, bmpData.Stride * bitmap.Height, mResult);
                        try
                        {
                            Image.GenImage1("byte", mResult.Width, mResult.Height, ptrBmp);
                        }
                        catch { }
                      
                        if (Image != null && FrmCCamDebug.isDisplayImg)
                        {
                            FrmCCamDebug.hWnd.Image = Image;
                        }
                    }
                }
            }
            catch{ }
            finally
            {
                SignalWait.Set();
                e.DisposeGrabResultIfClone();
            }
        }

        #endregion

        #region 方法-设置相机参数

        /// <summary> 
        /// 相机参数设置
        /// </summary>
        public override void SetCamParams()
        {
            SetExposureTime((long)mExposeTime);
            SetGain((long)mGain);
            SetWidth();
            SetHeight();
        }

        /// <summary>
        /// 设置宽度
        /// </summary>
        public void SetWidth()
        {
            if (mWidth > 100 & mWidth <= mWidthMax)
            {
                mCamera.Parameters[PLCamera.Width].SetValue(mWidth);
            }
        }

        /// <summary>
        /// 设置高度
        /// </summary>
        public void SetHeight()
        {
            if (mHeight > 100 & mHeight <= mHeightMax)
            {
                mCamera.Parameters[PLCamera.Height].SetValue(mHeight);
            }
        }

        /// <summary>
        /// 设置增益
        /// </summary>
        public void SetGain(long value)
        {
            try
            {
                //一些相机可能有自动功能启用。若要将增益值设置为特定值，
                //增益自动功能必须首先被禁用(如果增益自动可用)。
                mCamera.Parameters[PLCamera.GainAuto].TrySetValue(PLCamera.GainAuto.Off); //如果GainAuto是可写的，则设置为Off。
                if (mCamera.GetSfncVersion() < Sfnc2_0_0)
                {
                    //一些参数有限制。您可以使用GetIncrement/GetMinimum/GetMaximum来确保您设置了一个有效的值。
                    //在以前的SFNC版本中，GainRaw是一个整数形参。
                    //整型参数的数据，设置之前，需要进行有效值整合，否则可能会报错
                    //long mGainMin = mCamera.Parameters[PLCamera.GainRaw].GetMinimum();
                    //long mGainMax = mCamera.Parameters[PLCamera.GainRaw].GetMaximum();
                    long incr = mCamera.Parameters[PLCamera.GainRaw].GetIncrement();
                    if (value < (long)mGainMin)
                    {
                        value = (long)mGainMin;
                    }
                    else if (value > mGainMax)
                    {
                        value = (long)mGainMax;
                    }
                    else
                    {
                        value = (long)mGainMin + (((value - (long)mGainMin) / incr) * incr);
                    }
                    mCamera.Parameters[PLCamera.GainRaw].SetValue(value);
                    //或者，在这里，如果需要，我们让pylon修正值。
                    //mCamera.Parameters[PLCamera.GainRaw].SetValue(value, IntegerValueCorrection.Nearest);
                }
                else //用于SFNC 2.0摄像机，例如USB3视觉摄像机
                {
                    //在SFNC 2.0中，增益是一个浮动参数。
                    mCamera.Parameters[PLUsbCamera.Gain].SetValue(value);
                }
                mGain = value;
            }
            catch { }
        }

        /// <summary>
        /// 设置相机曝光时间
        /// </summary>
        public void SetExposureTime(long value)
        {
            try
            {
                //一些相机可能有自动功能启用。将曝光时间值设置为一个特定的值，
                //曝光自动功能必须首先被禁用(如果曝光自动可用)。
                mCamera.Parameters[PLCamera.ExposureAuto].TrySetValue(PLCamera.ExposureAuto.Off);//曝光自动设置为关闭，如果它是可写的。
                mCamera.Parameters[PLCamera.ExposureMode].TrySetValue(PLCamera.ExposureMode.Timed); ;//如果它是可写的，将ExposureMode设置为定时。
                if (mCamera.GetSfncVersion() < Sfnc2_0_0)
                {
                    //在以前SFNC版本,ExposureTimeRaw是一个整数参数,单位,单位us
                    //整型参数的数据，设置之前，需要进行有效值整合，否则可能会报错
                    //long mGainMin = mCamera.Parameters[PLCamera.ExposureTimeRaw].GetMinimum();
                    //long mGainMax = mCamera.Parameters[PLCamera.ExposureTimeRaw].GetMaximum();
                    long incr = mCamera.Parameters[PLCamera.ExposureTimeRaw].GetIncrement();
                    if (value < (long)mExposeTimeMin)
                    {
                        value = (long)mExposeTimeMin;
                    }
                    else if (value > (long)mExposeTimeMax)
                    {
                        value = (long)mExposeTimeMax;
                    }
                    else
                    {
                        value = (long)mExposeTimeMin + (((value - (long)mExposeTimeMin) / incr) * incr);
                    }
                    mCamera.Parameters[PLCamera.ExposureTimeRaw].SetValue(value);
                }
                else // 用于SFNC 2.0摄像机，例如USB3视觉摄像机
                {
                    // 在SFNC 2.0中，ExposureTimeRaw被重命名为ExposureTime，是一个浮动参数, 单位us.
                    mCamera.Parameters[PLUsbCamera.ExposureTime].SetValue(value);
                }
                mExposeTime = value;
            }
            catch { }
        }

        /// <summary>
        /// 设置触发模式
        /// </summary>
        public override bool SetTriggerMode(TrigMode _TrigMode)
        {
            try
            {
                if (mCamera == null) return false;
                DeviceAccessibilityInfo result = CameraFinder.GetDeviceAccessibilityInfo(mCamera.CameraInfo);
                if (result != DeviceAccessibilityInfo.Opened) return false;

                //如果是实时采集 则先停止
                if (mCamera.StreamGrabber.IsGrabbing && mCamera.Parameters[PLCamera.AcquisitionMode].GetValue() == PLCamera.AcquisitionMode.Continuous)
                {
                    StopGrab();
                }
                switch (_TrigMode)
                {
                    case TrigMode.内触发:
                        {
                            mCamera.Parameters[PLCamera.TriggerMode].SetValue(PLCamera.TriggerMode.Off);
                            mCamera.Parameters[PLCamera.TriggerSource].SetValue(PLCamera.TriggerSource.Software);
                            break;
                        }
                    case TrigMode.软触发:
                        {
                            mCamera.Parameters[PLCamera.TriggerMode].SetValue(PLCamera.TriggerMode.Off);
                            mCamera.Parameters[PLCamera.TriggerSource].SetValue(PLCamera.TriggerSource.Software);
                            break;
                        }
                }
                return true;
            }
            catch
            {
                StopGrab();
                return false;
            }
        }

        #endregion

        #region 方法-获取相机参数

        /// <summary>
        /// 获取相机参数
        /// </summary>
        public override void GetCamParams()
        {
            try
            {
                string camName = mCamera.CameraInfo[CameraInfoKey.UserDefinedName];
                string serialNo= mCamera.CameraInfo[CameraInfoKey.SerialNumber];
                string cameraIP = mCamera.CameraInfo[CameraInfoKey.DeviceIpAddress];
                float exposeTime = (float)mCamera.Parameters[PLGigECamera.ExposureTimeAbs].GetValue();
                float gain = (long)mCamera.Parameters[PLGigECamera.GainRaw].GetValue()-51;
                int width = (int)mCamera.Parameters[PLCamera.Width].GetValue();
                int height = (int)mCamera.Parameters[PLCamera.Height].GetValue();

                mCamName = camName;
                mSerialNo = serialNo;
                mCameraIP = cameraIP;
                mExposeTime = exposeTime;
                mGain = gain;
                mWidth = width;
                mHeight = height;
            }
            catch { }
        }

        #endregion

        #region 事件-相机事件

        /// <summary>
        /// 重连相机
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void OnConnectionLost(Object sender, EventArgs e)
        {
            DisConnectDev();
        }

        /// <summary>
        /// 开始采图时重置秒表
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void OnGrabStarted(Object sender, EventArgs e)
        {
            if (mStopwatch==null)
            {
                mStopwatch = new Stopwatch();
            }
            mStopwatch.Reset();
        }

        /// <summary>
        /// 采图结束时重置秒表
        /// </summary>
        private void OnGrabStopped(Object sender, GrabStopEventArgs e)
        {
            mStopwatch.Reset();
        }

        #endregion
    }
}