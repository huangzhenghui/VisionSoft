using RexConst;
using HalconDotNet;
using System;
using System.Diagnostics;
using System.Windows.Forms;
using System.Collections.Generic;

namespace VisionCore
{
    public class ShowMsg
    {
        /// <summary>
        /// 声明委托
        /// </summary>
        /// <param name="name"></param>
        /// <param name="hImage"></param>
        public delegate void ShowRImageDg(string name, RImage hImage);
        public delegate void ClearWindowDg();
        public delegate void ShowCrtlInfo();
        public static ShowRImageDg ShowRImageEvent;
        public static ClearWindowDg ClearWindowEvent;
        public static ShowCrtlInfo ShowCrtlInfoEvent;

        /// <summary>
        /// 通知显示框显示指定的图像
        /// </summary>
        /// <param name="name">名称</param>
        /// <param name="img">图像</param>
        public static void SendImage(string name, RImage hImage)
        {
            ShowRImageEvent?.BeginInvoke(name, hImage, null, null);
        }

        /// <summary>
        /// 通知窗口清空内容
        /// </summary>
        public static void SendClearWindow()
        {
            ClearWindowEvent?.Invoke();
        }

        /// <summary>
        /// 通知监控控件显示数据信息
        /// </summary>
        /// <param name="str"></param>
        public static void SendCrtlInfo()
        {
            ShowCrtlInfoEvent?.BeginInvoke(null, null);
        }
    }
}
