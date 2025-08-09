using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using HalconDotNet;
using System.Threading;
using System.Runtime.Serialization;
using System.Windows.Forms;
using RexConst;
namespace VisionCore
{
    public delegate void ImageGrabcallback(HImage img);
    [Serializable]
    public class CamerasBase
    {
        #region 字段、属性

        /// <summary>
        /// 等待采图信号
        /// </summary>
        [NonSerialized]
        public AutoResetEvent EventWait = new AutoResetEvent(false);

        /// <summary>
        /// 软触发时收到采图信号-同步
        /// </summary>
        [NonSerialized]
        public AutoResetEvent SignalWait = new AutoResetEvent(false);

        /// <summary>
        /// 软触发时收到采图信号-异步
        /// </summary>
        [NonSerialized]
        public AutoResetEvent GetSignalWait = new AutoResetEvent(false);

        /// <summary>
        /// 采集图像委托
        /// </summary>
        [NonSerialized]
        public static ImageGrabcallback ImageGrab = null;

        /// <summary>
        /// 注册采图回调函数标志位
        /// </summary>
        public bool isRegisterImageCallBack = false;

        /// <summary>
        /// 监控相机连接情况线程
        /// </summary>
        [NonSerialized]
        public Thread thMoniCamConn;

        /// <summary>
        /// 相机重连线程
        /// </summary>
        [NonSerialized]
        public Thread thReConnCam;

        /// <summary>
        /// 相机重连一个循环执行结束标志位
        /// </summary>
        [NonSerialized]
        public bool isExeOver;

        /// <summary>
        /// 开启相机监控标志位,防止多次注册函数
        /// <summary>
        [NonSerialized]
        public bool isStartMoniCamConn;

        /// <summary>
        /// 当前相机
        /// </summary>
        [NonSerialized]
        public static CamerasBase mCamerasBase;

        /// <summary>
        /// 相机列表
        /// </summary>
        [NonSerialized]
        public static List<CamerasBase> mCamerasList;

        /// <summary>
        /// 重连相机标志位
        /// <summary>
        [NonSerialized]
        public bool isReConnCam;

        /// <summary>
        /// 图像变量
        /// </summary>
        [NonSerialized]
        public HImage Image = new RImage();

        /// <summary>
        /// 相机信息结构体
        /// </summary>
        public CamerasInfo camInfo;

        /// <summary>
        /// 相机名称
        /// </summary>
        public string mCamName { set; get; }

        /// <summary>
        /// 相机序列号
        /// </summary>
        public string mSerialNo { set; get; }

        /// <summary>
        /// 相机IP地址
        /// </summary>
        public string mCameraIP { set; get; }

        /// <summary>
        /// 相机是否启用
        /// </summary>
        public bool isApply { set; get; }

        /// <summary>
        /// 相机连接状态
        /// </summary>
        public bool mConnected { set; get; } = false;

        /// <summary>
        /// 相机采集状态
        /// </summary>
        public bool mTrigState { set; get; } = false;

        /// <summary>
        /// 图像宽度
        /// </summary>
        public int mWidth { set; get; } = 0;

        /// <summary>
        /// 图像宽度最大值
        /// </summary>
        public int mWidthMax { set; get; } = 0;

        /// <summary>
        /// 图像高度
        /// </summary>
        public int mHeight { set; get; } = 0;

        /// <summary>
        /// 图像高度最大值
        /// </summary>
        public int mHeightMax { set; get; } = 0;

        /// <summary>
        /// 相机曝光时间
        /// </summary>
        public float mExposeTime { set; get; } = 0;

        /// <summary>
        /// 相机曝光时间最大值
        /// </summary>
        public float mExposeTimeMax { set; get; } = 0;

        /// <summary>
        /// 相机曝光时间最小值
        /// </summary>
        public float mExposeTimeMin{ set; get; } = 0;

        /// <summary>
        /// 相机增益
        /// </summary>
        public float mGain { set; get; } = 0;

        /// <summary>
        /// 相机增益最大值
        /// </summary>
        public float mGainMax { set; get; } = 0;

        /// <summary>
        /// 相机增益最小值
        /// </summary>
        public float mGainMin { set; get; } = 0;

        /// <summary>
        /// 相机采图帧率
        /// </summary>
        public string mFramerate { set; get; } = "0";

        #endregion

        #region 初始化

        public CamerasBase() { }

        #endregion

        #region 虚方法-搜索相机

        /// <summary>
        /// 搜索相机
        /// </summary>
        public virtual List<CamerasInfo> SearchCameras() { return null; }

        #endregion

        #region 虚方法-获取相机信息

        /// <summary>
        /// 在连接相机前先获取相机信息
        /// </summary>
        /// <param name="m_SerialNO"></param>
        public virtual void AcqCamInfo(string m_SerialNO) { }

        #endregion

        #region 虚方法-设置相机连接与断开

        /// <summary>
        /// 监控相机连接状态
        /// </summary>
        public virtual void MoniCamConn() { }

        /// <summary>
        /// 重连相机
        /// </summary>
        public virtual void ReConnCam() { }

        /// <summary>
        /// 连接相机
        /// </summary>
        public virtual void ConnectDev() { }

        /// <summary>
        /// 断开相机
        /// </summary>
        public virtual void DisConnectDev() { }

        #endregion

        #region 虚方法-设置相机采图

        /// <summary>
        /// 设置相机采图
        /// </summary>
        /// <param name="byHand">触发方式标志位</param>
        /// <returns></returns>
        public virtual bool CaptureImage(bool byHand) { return true; }

        public virtual void StopCapture() { }

        #endregion

        #region 虚方法-设置相机参数

        /// <summary>
        /// 设置相机参数
        /// </summary>
        public virtual void SetCamParams() { }

        /// <summary>
        /// 设置触发方式
        /// </summary>
        /// <param name="mode">触发方式</param>
        /// <returns></returns>
        public virtual bool SetTriggerMode(TrigMode mode)
        {
            return true;
        }

        #endregion

        #region 虚方法-获取相机参数

        /// <summary>
        /// 获取相机参数参数
        /// </summary>
        public virtual void GetCamParams() { }

        #endregion
    }
}
