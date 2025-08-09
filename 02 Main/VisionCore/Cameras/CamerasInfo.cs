using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
namespace VisionCore
{
    #region 结构体-相机信息

    /// <summary>
    /// 相机信息结构体，用来存放相机信息
    /// </summary>
    [Serializable]
    public struct CamerasInfo
    {
        /// <summary>
        /// 相机信息
        /// </summary>
        public object m_CamInfo;

        /// <summary>
        /// 相机名称
        /// </summary>
        public string m_CamName { set; get; }

        /// <summary>
        /// 相机序列号
        /// </summary>
        public string m_SerialNO { set; get; }

        /// <summary>
        /// 相机IP地址
        /// </summary>
        public string m_CameraIP { set; get; }

        /// <summary>
        /// 相机曝光
        /// </summary>
        public float m_ExposureTime { set; get; }

        /// <summary>
        /// 相机增益
        /// </summary>
        public float m_Gain { set; get; }

        /// <summary>
        /// 图像宽度
        /// </summary>
        public int m_Width { set; get; }

        /// <summary>
        /// 图像高度
        /// </summary>
        public int m_Height { set; get; }

        /// <summary>
        /// 相机备注
        /// </summary>
        public string m_MaskName { set; get; }

        /// <summary>
        /// 相机连接状态
        /// </summary>
        public bool m_Connected { set; get; }
    }

    #endregion

    #region 枚举-触发方式

    /// <summary>
    /// 触发模式
    /// </summary>
    [Serializable]
    public enum TrigMode
    {
        内触发 = 0,
        软触发
    }

    #endregion

    #region 枚举-曝光模式

    /// <summary>
    /// 曝光模式
    /// </summary>
    [Serializable]
    public enum ExposureMode
    {
        内曝光 = 0, //内部设置曝光时间
        外曝光,    //电平信号设置曝光时间
    }

    #endregion

    #region 枚举-触发模式

    /// <summary>
    /// 触发模式
    /// </summary>
    [Serializable]
    public enum ChangType
    {
        曝光,
        触发,
        宽度,
        高度,
        增益
    }

    #endregion

    #region 枚举-调整模式

    /// <summary>
    /// 调整模式
    /// </summary>
    [Serializable]
    public enum ImageAdjust
    {
        None = 0,
        垂直镜像,
        水平镜像,
        顺时针90度,
        逆时针90度,
        旋转180度
    }

    #endregion
}
