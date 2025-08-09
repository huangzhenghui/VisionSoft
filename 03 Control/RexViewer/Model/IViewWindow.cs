using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using HalconDotNet;
using RexView;

namespace RexView.Model
{
    /// <summary>
    /// Halcon窗口显示接口函数
    /// </summary>
    interface IViewWindow
    {
        #region Halcon窗口显示接口函数

        /// <summary>
        /// 显示图像
        /// </summary>
        /// <param name="img"></param>
        void DisplayImage(HObject img);

        /// <summary>
        /// 重新显示窗体内容(图像+区域)
        /// </summary>
        void ResetWindowImage();

        /// <summary>
        /// 设置HALCON窗口中的鼠标事件的视图模式-缩放
        /// </summary>
        void ZoomWindowImage();

        /// <summary>
        /// 设置HALCON窗口中的鼠标事件的视图模式-移动
        /// </summary>
        void MoveWindowImage();

        /// <summary>
        /// 设置HALCON窗口中的鼠标事件的视图模式-无
        /// </summary>
        void NoneWindowImage();

        /// <summary>
        /// 在指定位置生成ROI-Point
        /// </summary>
        /// <param name="name"></param>
        /// <param name="row"></param>
        /// <param name="col"></param>
        /// <param name="rois"></param>
        void GenPoint(string name, double row, double col, ref Dictionary<string, ROI> rois);

        /// <summary>
        /// 在指定位置生成ROI-Circle
        /// </summary>
        /// <param name="name"></param>
        /// <param name="row"></param>
        /// <param name="col"></param>
        /// <param name="radius"></param>
        /// <param name="rois"></param>
        void GenCircle(string name, double row, double col, double radius, ref Dictionary<string, ROI> rois, string color);

        /// <summary>
        /// 在指定位置生成ROI-CircleArc
        /// </summary>
        /// <param name="name"></param>
        /// <param name="row"></param>
        /// <param name="col"></param>
        /// <param name="radius"></param>
        /// <param name="rois"></param>
        void GenCircleArc(string name, double row, double col, double radius, ref Dictionary<string, ROI> rois);

        /// <summary>
        /// 在指定位置生成ROI-Line
        /// </summary>
        /// <param name="name"></param>
        /// <param name="beginRow"></param>
        /// <param name="beginCol"></param>
        /// <param name="endRow"></param>
        /// <param name="endCol"></param>
        /// <param name="rois"></param>
        void GenLine(string name, double beginRow, double beginCol, double endRow, double endCol, ref Dictionary<string, ROI> rois);

        /// <summary>
        /// 在指定位置生成ROI-Rectangle1
        /// </summary>
        /// <param name="name"></param>
        /// <param name="row1"></param>
        /// <param name="col1"></param>
        /// <param name="row2"></param>
        /// <param name="col2"></param>
        /// <param name="rois"></param>
        void GenRect1(string name, double row1, double col1, double row2, double col2, ref Dictionary<string, ROI> rois, string color);

        /// <summary>
        /// 在指定位置生成ROI-Rectangle2
        /// </summary>
        /// <param name="name"></param>
        /// <param name="row"></param>
        /// <param name="col"></param>
        /// <param name="phi"></param>
        /// <param name="length1"></param>
        /// <param name="length2"></param>
        /// <param name="rois"></param>
        void GenRect2(string name, double row, double col, double phi, double length1, double length2, ref Dictionary<string, ROI> rois, string color);

        /// <summary>
        /// 获取当前选中ROI信息(包括对象、名称、索引)
        /// </summary>
        /// <param name="name"></param>
        /// <param name="index"></param>
        /// <returns></returns>
        ROI GetActiveROIInfo(out string name, out string index);

        /// <summary>
        /// 获取当前选中ROI信息(包括对象、数据、索引)
        /// </summary>
        /// <param name="data"></param>
        /// <param name="index"></param>
        /// <returns></returns>
        ROI GetActiveROIInfo(out List<double> data, out string index);

        /// <summary>
        /// 选择ROI
        /// </summary>
        /// <param name="index"></param>
        void SelectROI(string index);

        /// <summary>
        /// 选择ROI
        /// </summary>
        /// <param name="rois"></param>
        /// <param name="index"></param>
        void SelectROI(Dictionary<string, ROI> rois, string index);

        /// <summary>
        /// 删除当前选中ROI 
        /// </summary>
        /// <param name="rois"></param>
        void RemoveActiveROI(ref Dictionary<string, ROI> rois);

        /// <summary>
        /// 保存ROI
        /// </summary>
        /// <param name="rois"></param>
        /// <param name="fileNmae"></param>
        void SaveROI(Dictionary<string, ROI> rois, string fileNmae);

        /// <summary>
        /// 加载ROI
        /// </summary>
        /// <param name="fileName"></param>
        /// <param name="rois"></param>
        void LoadROI(string fileName, out Dictionary<string, ROI> rois);

        #endregion
    }
}
