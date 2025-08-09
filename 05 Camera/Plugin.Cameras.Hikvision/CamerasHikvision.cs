using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Imaging;
using System.Windows.Forms;
using System.Runtime.Serialization;
using System.ComponentModel;
using VisionCore;
using MvCamCtrl.NET;
using System.Runtime.InteropServices;
using System.IO;
using System.Collections;
using System.Net;
using static MvCamCtrl.NET.MyCamera;
using HalconDotNet;
using System.Threading;
using MutualTools;
using TSIVision.FrmConfigR;

namespace Plugin.Cameras.Hikvision
{
    [Category("Hikvision相机")]
    [DisplayName("Hikvision相机")]
    [Serializable]
    public class CamerasHikvision : CamerasBase
    {
        #region 字段、属性

        /// <summary>
        /// 执行失败
        /// </summary>
        [NonSerialized]
        public const int CO_FAIL = -1;

        /// <summary>
        /// 执行OK
        /// </summary>
        [NonSerialized]
        public const int CO_OK = 0;

        /// <summary>
        /// 海康相机SDK的类对象
        /// </summary>
        [NonSerialized]
        private MyCamera mMyCamera = new MyCamera();

        /// <summary>
        /// 选中海康相机信息
        /// </summary>
        [NonSerialized]
        private MV_CC_DEVICE_INFO curHikInfo;

        /// <summary>
        /// 图像采集委托
        /// </summary>
        [NonSerialized]
        public cbOutputExdelegate ImageCallback;

        /// <summary>
        /// 提供一组方法和属性，可用于准确地测量运行时间
        /// </summary>
        [NonSerialized]
        public Stopwatch mStopwatch = new Stopwatch();

        #endregion

        #region 初始化

        /// <summary>
        /// 初始化
        /// </summary>
        public CamerasHikvision() : base(){ }

        #endregion

        #region 方法-搜索相机

        /// <summary>
        /// 搜索相机，并放入Combobox中
        /// </summary>
        /// <returns></returns>
        public override List<CamerasInfo> SearchCameras()
        {
            List<CamerasInfo>  camInfoList = new List<CamerasInfo>();//相机信息结构体列表
            MV_CC_DEVICE_INFO_LIST hikInfoList = new MV_CC_DEVICE_INFO_LIST();//海康相机信息列表
            if (MV_CC_EnumDevices_NET(MV_GIGE_DEVICE | MV_USB_DEVICE, ref hikInfoList) != 0)
            {
                MessageBox.Show("查找设备失败");
                return camInfoList;
            }
            //在窗体列表中显示设备名
            for (int i = 0; i < hikInfoList.nDeviceNum; i++)
            {
                CamerasInfo camInfo = new CamerasInfo();
                MV_CC_DEVICE_INFO hikInfo = (MV_CC_DEVICE_INFO)Marshal.PtrToStructure(hikInfoList.pDeviceInfo[i], typeof(MV_CC_DEVICE_INFO));
                if (hikInfo.nTLayerType == MV_GIGE_DEVICE)
                {
                    IntPtr buffer = Marshal.UnsafeAddrOfPinnedArrayElement(hikInfo.SpecialInfo.stGigEInfo, 0);
                    MV_GIGE_DEVICE_INFO gigeInfo = (MV_GIGE_DEVICE_INFO)Marshal.PtrToStructure(buffer, typeof(MV_GIGE_DEVICE_INFO));
                    if (gigeInfo.chModelName.Split('-')[0]!="MV")
                    {
                        continue;
                    }
                    camInfo.m_CamName = gigeInfo.chUserDefinedName;
                    camInfo.m_SerialNO = gigeInfo.chSerialNumber;
                    camInfo.m_CameraIP = TypeConvert.UintToIP(gigeInfo.nCurrentIp);
                    camInfo.m_Connected = false;
                }
                else if (hikInfo.nTLayerType == MyCamera.MV_USB_DEVICE)
                {
                    IntPtr buffer = Marshal.UnsafeAddrOfPinnedArrayElement(hikInfo.SpecialInfo.stUsb3VInfo, 0);
                    MV_USB3_DEVICE_INFO usbInfo = (MV_USB3_DEVICE_INFO)Marshal.PtrToStructure(buffer, typeof(MV_USB3_DEVICE_INFO));
                    if (usbInfo.chModelName.Split('-')[0] != "MV")
                    {
                        continue;
                    }
                    camInfo.m_CamName = usbInfo.chUserDefinedName;
                    camInfo.m_SerialNO = usbInfo.chSerialNumber;
                    camInfo.m_CameraIP = "USB";
                    camInfo.m_Connected = false;
                }
                camInfoList.Add(camInfo);
            }
            return camInfoList;
        }

        #endregion

        #region 方法-设置相机连接与断开

        /// <summary>
        /// 在连接相机前先获取相机信息
        /// </summary>
        /// <param name="m_SerialNO"></param>
        public override void AcqCamInfo(string serialNO)
        {
            mTrigState = false;
            MV_CC_DEVICE_INFO_LIST hikInfoList = new MV_CC_DEVICE_INFO_LIST();
            if (MV_CC_EnumDevices_NET(MV_GIGE_DEVICE | MV_USB_DEVICE, ref hikInfoList) != 0) return;
            for (int i = 0; i < hikInfoList.nDeviceNum; i++)
            {
                MV_CC_DEVICE_INFO hikInfo = (MV_CC_DEVICE_INFO)Marshal.PtrToStructure(hikInfoList.pDeviceInfo[i], typeof(MV_CC_DEVICE_INFO));
                if (hikInfo.nTLayerType == MV_GIGE_DEVICE)
                {
                    IntPtr buffer = Marshal.UnsafeAddrOfPinnedArrayElement(hikInfo.SpecialInfo.stGigEInfo, 0);
                    MV_GIGE_DEVICE_INFO gigeInfo = (MV_GIGE_DEVICE_INFO)Marshal.PtrToStructure(buffer, typeof(MV_GIGE_DEVICE_INFO));
                    if (gigeInfo.chSerialNumber == serialNO)
                    {
                        curHikInfo = hikInfo;
                        break;
                    }
                }
                else if (hikInfo.nTLayerType == MyCamera.MV_USB_DEVICE)
                {
                    IntPtr buffer = Marshal.UnsafeAddrOfPinnedArrayElement(hikInfo.SpecialInfo.stUsb3VInfo, 0);
                    MV_USB3_DEVICE_INFO usbInfo = (MV_USB3_DEVICE_INFO)Marshal.PtrToStructure(buffer, typeof(MV_USB3_DEVICE_INFO));
                    if (usbInfo.chSerialNumber == serialNO)
                    {
                        curHikInfo = hikInfo;
                        break;
                    }
                }
            }
        }

        /// <summary>
        /// 监控相机连接状态
        /// </summary>
        public override void MoniCamConn()
        {
            while (true)
            {
                try
                {
                    if (mMyCamera == null)
                    {
                        continue;
                    }

                    float connState = 0;
                    int result = GetFloatValue("ResultingFrameRate", ref connState);
                    if (result == 0)
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
                        if (mMyCamera == null)
                        {
                            continue;
                        }

                        if (isApply == true && mConnected == false)
                        {
                            if (onlyDisp)
                            {
                                Log.Info(mCamName + ":断开连接");
                                onlyDisp = false;
                            }

                            int result;
                            AcqCamInfo(mSerialNo);
                            mMyCamera.MV_CC_CreateDevice_NET(ref curHikInfo);
                            result = mMyCamera.MV_CC_OpenDevice_NET();
                            if (result == 0)
                            {
                                mConnected = true;
                                onlyDisp = true;
                                Log.Info(mCamName + ":重连成功");

                                //重连成功则重新注册回调函数
                                ImageCallback = new cbOutputExdelegate(ImageCallbackFunc);
                                mMyCamera.MV_CC_RegisterImageCallBackEx_NET(ImageCallback, IntPtr.Zero);
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
            try
            {
                // 如果相机已经连接先断开
                base.ConnectDev();
                DisConnectDev();

                //获取相机信息
                AcqCamInfo(mSerialNo);

                //连接相机
                int nRet = -1;
                if (null == mMyCamera)
                {
                    mMyCamera = new MyCamera();
                }
                nRet = mMyCamera.MV_CC_CreateDevice_NET(ref curHikInfo);
                nRet = mMyCamera.MV_CC_OpenDevice_NET();

                //若相机连接失败则返回
                if (MV_OK != nRet)
                {
                    mMyCamera.MV_CC_DestroyDevice_NET();
                    mConnected = false;
                    Log.Info(mCamName + ":连接失败");
                    return;
                }

                //注册回调函数
                if (!isRegisterImageCallBack)
                {
                    ImageCallback = new cbOutputExdelegate(ImageCallbackFunc);
                    mMyCamera.MV_CC_RegisterImageCallBackEx_NET(ImageCallback, IntPtr.Zero);
                    isRegisterImageCallBack = true;
                }

                GetCamParams();
                mConnected = true;
                Log.Info(mCamName + ":连接成功");
            }
            catch
            {
                mConnected = false;
            }
            finally
            {
                //启动相机监控与重连线程
                if (!isStartMoniCamConn)
                {
                    thMoniCamConn = new Thread(MoniCamConn);//实时监控相机连接
                    thReConnCam = new Thread(ReConnCam);//重连相机
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
            if (mConnected)
            {
                int nRet = mMyCamera.MV_CC_CloseDevice_NET();
                if (MV_OK != nRet)
                {
                    return;
                }
                mConnected = false;
                mTrigState = false;
                isRegisterImageCallBack = false;
            }
        }

        #endregion

        #region 方法-相机采图

        /// <summary>
        /// 相机采图
        /// </summary>
        /// <param name="byHand">触发方式标志位，true为软触发，false为内触发。</param>
        /// <returns></returns>
        public override bool CaptureImage(bool byHand)
        {
            try
            {
                int nRet = 0;
                bool result;
                if (byHand)
                {
                    result = SetTriggerMode(TrigMode.软触发);
                    if (result ==false)
                    {
                        Log.Info(mCamName + ":采图失败：设置触发模式失败");
                        return false;
                    }
                }
                else
                {
                    result = SetTriggerMode(TrigMode.内触发);
                    if (result == false)
                    {
                        if (FrmCCamDebug.hWnd != null)
                        {
                            FrmCCamDebug.hWnd.label.Text = "采图失败：设置触发模式失败";
                        }

                        Log.Info(mCamName + ":采图失败：设置触发模式失败");
                        return false;
                    }
                }

                if (!mTrigState)
                {
                    nRet = mMyCamera.MV_CC_StartGrabbing_NET();
                    if (nRet != MV_OK)
                    {
                        if (FrmCCamDebug.hWnd != null)
                        {
                            FrmCCamDebug.hWnd.label.Text = "采图失败：打开采集模式失败";
                        }

                        Log.Info(mCamName + ":采图失败：打开采集模式失败");
                        return false;
                    }
                }

                if (FrmCCamDebug.hWnd!=null)
                {
                    FrmCCamDebug.hWnd.label.Text = "采图中...";
                }

                mTrigState = true;

                if (byHand)
                {
                    nRet = mMyCamera.MV_CC_SetCommandValue_NET("TriggerSoftware");
                    if (nRet != MV_OK)
                    {
                        Log.Info(mCamName + ":采图失败：触发采图失败");
                        return false;
                    }

                    SignalWait.Reset();
                    SignalWait.WaitOne();
                    Log.Info(mCamName + ":采图成功");
                }

                return true;
            }
            catch(Exception ex)
            {
                if (FrmCCamDebug.hWnd != null)
                {
                    FrmCCamDebug.hWnd.label.Text = "采图失败：" + ex.Message;
                }

                Log.Info(mCamName + ":采图失败");
                return false;
            }
        }

        /// <summary>
        /// 停止采集
        /// </summary>
        public override void StopCapture()
        {
            int nRet = mMyCamera.MV_CC_StopGrabbing_NET();
            if (nRet != MV_OK)
            {
                mTrigState = true;
            }
            mTrigState = false;
        }

        /// <summary>
        /// 图像采集回调函数
        /// </summary>
        /// <param name="pData"></param>
        /// <param name="pFrameInfo"></param>
        /// <param name="pUser"></param>
        private void ImageCallbackFunc(IntPtr pData, ref MV_FRAME_OUT_INFO_EX pFrameInfo, IntPtr pUser)
        {
            try
            {
                if (pFrameInfo.enPixelType == MvGvspPixelType.PixelType_Gvsp_Mono8)
                {
                    Image.GenImage1("byte", pFrameInfo.nWidth, pFrameInfo.nHeight, pData);
                }
                else
                {
                    Image = new HImage("byte", pFrameInfo.nWidth, pFrameInfo.nHeight, pData);
                }

                if (Image!=null && FrmCCamDebug.isDisplayImg)
                {
                    FrmCCamDebug.hWnd.Image = Image;
                }

                SignalWait.Set();
            }
            catch
            {
                SignalWait.Set();
            }
        }

        #endregion

        #region 方法-设置相机参数

        /// <summary>
        /// 设置相机参数
        /// </summary>
        public override void SetCamParams()
        {
            SetStringValue("DeviceUserID", mCamName);
            SetStringValue("DeviceSerialNumber", mSerialNo);
            SetIntValue("GevCurrentIPAddress", TypeConvert.IPToUint(mCameraIP));
            SetFloatValue("ExposureTime", mExposeTime);
            SetFloatValue("Gain", mGain);
            SetIntValue("Width", (uint)mWidth);
            SetIntValue("Height", (uint)mHeight);
        }

        /// <summary>
        /// 设置Int型参数值
        /// </summary>
        /// <param name="strKey">参数键值</param>
        /// <param name="nValue">返回值</param>
        /// <returns></returns>
        public int SetIntValue(string strKey, UInt32 nValue)
        {
            int nRet = mMyCamera.MV_CC_SetIntValue_NET(strKey, nValue);
            if (MyCamera.MV_OK != nRet)
            {
                return CO_FAIL;
            }
            return CO_OK;
        }

        /// <summary>
        /// 设置Float型参数值
        /// </summary>
        /// <param name="strKey">参数键值</param>
        /// <param name="fValue">返回值</param>
        /// <returns></returns>
        public int SetFloatValue(string strKey, float fValue)
        {
            int nRet = mMyCamera.MV_CC_SetFloatValue_NET(strKey, fValue);
            if (MyCamera.MV_OK != nRet)
            {
                return CO_FAIL;
            }
            return CO_OK;
        }

        /// <summary>
        /// 设置Enum型参数值
        /// </summary>
        /// <param name="strKey">参数键值</param>
        /// <param name="nValue">返回值</param>
        /// <returns></returns>
        public int SetEnumValue(string strKey, UInt32 nValue)
        {
            //m_pCSI为相机对象
            int nRet = mMyCamera.MV_CC_SetEnumValue_NET(strKey, nValue);
            if (MyCamera.MV_OK != nRet)
            {
                return CO_FAIL;
            }
            return CO_OK;
        }

        /// <summary>
        /// 设置Bool型参数值
        /// </summary>
        /// <param name="strKey">参数键值</param>
        /// <param name="bValue">返回值</param>
        /// <returns></returns>
        public int SetBoolValue(string strKey, bool bValue)
        {
            int nRet = mMyCamera.MV_CC_SetBoolValue_NET(strKey, bValue);
            if (MyCamera.MV_OK != nRet)
            {
                return CO_FAIL;
            }
            return CO_OK;
        }

        /// <summary>
        /// 设置String型参数值
        /// </summary>
        /// <param name="strKey">参数键值</param>
        /// <param name="strValue">返回值</param>
        /// <returns></returns>
        public int SetStringValue(string strKey, string strValue)
        {
            int nRet = mMyCamera.MV_CC_SetStringValue_NET(strKey, strValue);
            if (MyCamera.MV_OK != nRet)
            {
                return CO_FAIL;
            }
            return CO_OK;
        }

        /// <summary>
        /// 设置触发方式
        /// </summary>
        /// <param name="mode">触发方式</param>
        /// <returns></returns>
        public override bool SetTriggerMode(TrigMode mode)
        {
            int nRet = 0;
            if (mode == TrigMode.内触发)
                nRet = mMyCamera.MV_CC_SetEnumValue_NET("TriggerMode", 0);
            else
                nRet = mMyCamera.MV_CC_SetEnumValue_NET("TriggerMode", 1);

            switch (mode)
            {
                case TrigMode.内触发:
                    break;
                case TrigMode.软触发:
                    {
                        nRet = mMyCamera.MV_CC_SetEnumValue_NET("TriggerSource", 7);
                        break;
                    }
            }
            if (nRet != MV_OK)
                return false;
            else
                return true;
        }

        #endregion

        #region 方法-获取相机参数

        /// <summary>
        /// 获取相机参数
        /// </summary>
        public override void GetCamParams()
        {
            string id = "";
            string sn = "";
            uint ip = 0;
            float exposureTime = 0;
            float gain = 0;
            uint triggerMode = 0;
            uint width = 0;
            uint height = 0;

            int result1 = GetStringValue("DeviceUserID", ref id);
            int result2 = GetStringValue("DeviceSerialNumber", ref sn);
            int result3 = GetIntValue("GevCurrentIPAddress", ref ip);
            int result4 = GetFloatValue("ExposureTime", ref exposureTime);
            int result5 = GetFloatValue("Gain", ref gain);
            int result6 = GetIntValue("Width", ref width);
            int result7 = GetIntValue("Height", ref height);
            int result8 = GetEnumValue("TriggerMode", ref triggerMode);

            if (result1!=0|| result2 != 0|| result3 != 0|| result4 != 0|| result5 != 0|| result6 != 0|| result7 != 0|| result8 != 0)
            {
                return;
            }

            mCamName = id;
            mSerialNo = sn;
            mCameraIP = TypeConvert.UintToIP(ip);
            mExposeTime = exposureTime;
            mGain = gain;
            mWidth = (int)width;
            mHeight = (int)height;
        }

        /// <summary>
        /// 获取Int型参数值
        /// </summary>
        /// <param name="strKey">参数键值</param>
        /// <param name="pnValue">返回值</param>
        /// <returns></returns>
        public int GetIntValue(string strKey, ref UInt32 pnValue)
        {

            MyCamera.MVCC_INTVALUE stParam = new MyCamera.MVCC_INTVALUE();
            int nRet = mMyCamera.MV_CC_GetIntValue_NET(strKey, ref stParam);
            if (MyCamera.MV_OK != nRet)
            {
                return CO_FAIL;
            }

            pnValue = stParam.nCurValue;

            return CO_OK;
        }

        /// <summary>
        /// 获取Float型参数值
        /// </summary>
        /// <param name="strKey">参数键值</param>
        /// <param name="pfValue">返回值</param>
        /// <returns></returns>
        public int GetFloatValue(string strKey, ref float pfValue)
        {
            MyCamera.MVCC_FLOATVALUE stParam = new MyCamera.MVCC_FLOATVALUE();
            int nRet = mMyCamera.MV_CC_GetFloatValue_NET(strKey, ref stParam);
            if (MyCamera.MV_OK != nRet)
            {
                return CO_FAIL;
            }

            pfValue = stParam.fCurValue;

            return CO_OK;
        }

        /// <summary>
        /// 获取Enum型参数值
        /// </summary>
        /// <param name="strKey">参数键值</param>
        /// <param name="pnValue">返回值</param>
        /// <returns></returns>
        public int GetEnumValue(string strKey, ref UInt32 pnValue)
        {
            MyCamera.MVCC_ENUMVALUE stParam = new MyCamera.MVCC_ENUMVALUE();
            int nRet = mMyCamera.MV_CC_GetEnumValue_NET(strKey, ref stParam);
            if (MyCamera.MV_OK != nRet)
            {
                return CO_FAIL;
            }

            pnValue = stParam.nCurValue;

            return CO_OK;
        }

        /// <summary>
        /// 获取Bool型参数值
        /// </summary>
        /// <param name="strKey">参数键值</param>
        /// <param name="pbValue">返回值</param>
        /// <returns></returns>
        public int GetBoolValue(string strKey, ref bool pbValue)
        {
            int nRet = mMyCamera.MV_CC_GetBoolValue_NET(strKey, ref pbValue);
            if (MyCamera.MV_OK != nRet)
            {
                return CO_FAIL;
            }

            return CO_OK;
        }

        /// <summary>
        /// 获取String型参数值
        /// </summary>
        /// <param name="strKey">参数键值</param>
        /// <param name="strValue">返回值</param>
        /// <returns></returns>
        public int GetStringValue(string strKey, ref string strValue)
        {
            MyCamera.MVCC_STRINGVALUE stParam = new MyCamera.MVCC_STRINGVALUE();
            int nRet = mMyCamera.MV_CC_GetStringValue_NET(strKey, ref stParam);
            if (MyCamera.MV_OK != nRet)
            {
                return CO_FAIL;
            }

            strValue = stParam.chCurValue;

            return CO_OK;
        }

        #endregion
    }
}