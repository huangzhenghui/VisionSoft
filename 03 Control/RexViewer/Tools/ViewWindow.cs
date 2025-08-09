using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using HalconDotNet;
using RexConst;
using RexView;
using RexView.Model;
using System.Collections;
using MutualTools;

namespace RexView
{
    /// <summary>
    /// Halcon窗口显示类
    /// </summary>
    public class ViewWindow : IViewWindow
    {
        #region 字段、属性

        public HWndCtrl _hWndControl;
        public ROIController _roiController;

        #endregion

        #region 初始化

        public ViewWindow(HWindowControl window)
        {
            this._hWndControl = new HWndCtrl(window);
            this._roiController = new ROIController();
            this._hWndControl.SetROIController(_roiController);
            this._hWndControl.SetViewState(HWndCtrl.MODE_VIEW_NONE);
        }

        #endregion

        #region 方法-ROI相关

        /// <summary>
        /// 清空所有显示内容
        /// </summary>
        public void ClearWindow()
        {
            _hWndControl.ClearList();       //清空显示image
            _hWndControl.ClearHObjectList();//清空hobjectList
        }

        /// <summary>
        /// 显示图片
        /// </summary>
        /// <param name="img"></param>
        public void DisplayImage(HObject img)
        {
            _hWndControl.addImageShow(img);    //添加背景图片         
            _roiController.ResetVar();         //清空roi容器,不让roi显示                                   
            _roiController.ResetWindowImage(); //显示图片
        }

        /// <summary>
        /// 是否开启缩放事件
        /// </summary>
        /// <param name="flag"></param>
        public void SetDrawModel(bool flag)
        {
            _hWndControl.drawModel = flag;
        }

        /// <summary>
        /// 重新显示窗体内容(图像+区域)
        /// </summary>
        public void ResetWindowImage()
        {
            _hWndControl.ResetWindow();
            _roiController.ResetWindowImage();
        }

        /// <summary>
        /// 鼠标离开事件，鼠标离开窗口再返回时,图表随着鼠标移动
        /// </summary>
        public void Mouseleave()
        {
            _hWndControl.RaiseMouseup();
        }

        /// <summary>
        /// 设置HALCON窗口中的鼠标事件的视图模式-缩放
        /// </summary>
        public void ZoomWindowImage()
        {
            this._roiController.ZoomWindowImage();
        }

        /// <summary>
        /// 设置HALCON窗口中的鼠标事件的视图模式-移动
        /// </summary>
        public void MoveWindowImage()
        {
            this._roiController.MoveWindowImage();
        }

        /// <summary>
        /// 设置HALCON窗口中的鼠标事件的视图模式-无
        /// </summary>
        public void NoneWindowImage()
        {
            this._roiController.NoneWindowImage();
        }

        /// <summary>
        /// 在指定位置生成ROI-Point
        /// </summary>
        /// <param name="name"></param>
        /// <param name="beginRow"></param>
        /// <param name="beginCol"></param>
        /// <param name="rois"></param>
        public void GenPoint(string name, double beginRow, double beginCol, ref Dictionary<string, ROI> rois)
        {
            this._roiController.GenPoint(name, beginRow, beginCol, ref rois);
        }

        /// <summary>
        /// 在指定位置生成ROI-Circle
        /// </summary>
        /// <param name="name"></param>
        /// <param name="row"></param>
        /// <param name="col"></param>
        /// <param name="radius"></param>
        /// <param name="rois"></param>
        public void GenCircle(string name, double row, double col, double radius, ref Dictionary<string,ROI> rois, string color)
        {
            this._roiController.GenCircle(name, row, col, radius, ref rois, color);
        }

        /// <summary>
        /// 在指定位置生成ROI-CircleArc
        /// </summary>
        /// <param name="name"></param>
        /// <param name="row"></param>
        /// <param name="col"></param>
        /// <param name="radius"></param>
        /// <param name="rois"></param>
        public void GenCircleArc(string name, double row, double col, double radius, ref Dictionary<string,ROI> rois)
        {
            this._roiController.GenCircleArc(name, row, col, radius, ref rois);
        }

        /// <summary>
        /// 在指定位置生成FindCircle
        /// </summary>
        /// <param name="name"></param>
        /// <param name="row"></param>
        /// <param name="col"></param>
        /// <param name="radius"></param>
        /// <param name="rois"></param>
        public void GenFindCircle(string name, double row, double col, double radius, double startAngle, double endAngle, string pointOrder, int rectNum, double length1, double length2, ref Dictionary<string, ROI> rois, string projectColor, string meaRectColor)
        {
            _roiController.GenFindCircle(name, row, col, radius, startAngle, endAngle, pointOrder, rectNum, length1, length2, ref rois, projectColor, meaRectColor);
        }

        /// <summary>
        /// 在指定位置生成FindLine
        /// </summary>
        /// <param name="name"></param>
        /// <param name="row"></param>
        /// <param name="col"></param>
        /// <param name="radius"></param>
        /// <param name="rois"></param>
        public void GenFindLine(string name, double rowBegin, double colBegin, double rowEnd,double colEnd, int rectNum, double length1, double length2, ref Dictionary<string, ROI> rois, string projectColor, string meaRectColor)
        {
            _roiController.GenFindLine(name, rowBegin, colBegin, rowEnd, colEnd, rectNum, length1, length2, ref rois, projectColor, meaRectColor);
        }

        /// <summary>
        /// 在指定位置生成ROI-Line
        /// </summary>
        /// <param name="name"></param>
        /// <param name="beginRow"></param>
        /// <param name="beginCol"></param>
        /// <param name="endRow"></param>
        /// <param name="endCol"></param>
        /// <param name="rois"></param>
        public void GenLine(string name, double beginRow, double beginCol, double endRow, double endCol, ref Dictionary<string,ROI> rois)
        {
            this._roiController.GenLine(name, beginRow, beginCol, endRow, endCol, ref rois);
        }

        /// <summary>
        /// 在指定位置生成ROI-Rectangle1
        /// </summary>
        /// <param name="name"></param>
        /// <param name="row1"></param>
        /// <param name="col1"></param>
        /// <param name="row2"></param>
        /// <param name="col2"></param>
        /// <param name="rois"></param>
        public void GenRect1(string name, double row1, double col1, double row2, double col2, ref Dictionary<string, ROI> rois, string color)
        {
            this._roiController.GenRect1(name, row1, col1, row2, col2, ref rois, color);
       }

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
        public void GenRect2(string name, double row, double col, double phi, double length1, double length2, ref Dictionary<string, ROI> rois, string color)
        {
            this._roiController.GenRect2(name, row, col, phi, length1, length2, ref rois, color);
        }

        /// <summary>
        /// 获取当前选中ROI信息(包括对象、名称、索引)
        /// </summary>
        /// <param name="name"></param>
        /// <param name="index"></param>
        /// <returns></returns>
        public ROI GetActiveROIInfo(out string name, out string index)
        {
            ROI resual = _roiController.GetActiveROIInfo(out name, out  index);
            return resual;
        }

        /// <summary>
        /// 获取当前选中ROI信息(包括对象、数据、索引)
        /// </summary>
        /// <param name="data"></param>
        /// <param name="index"></param>
        /// <returns></returns>
        public ROI GetActiveROIInfo(out List<double> data, out string index)
        {
            ROI roi = this._roiController.GetActiveROIInfo(out data, out index);
            return roi;
        }

        /// <summary>
        /// 选择ROI
        /// </summary>
        /// <param name="index"></param>
        public void SelectROI(string index)
        {
            this._roiController.SelectROI(index);
        }

        /// <summary>
        /// 选择ROI
        /// </summary>
        /// <param name="rois"></param>
        /// <param name="index"></param>
        public void SelectROI(Dictionary<string,ROI> rois, string index)
        {
            foreach (KeyValuePair<string, ROI> roi in rois)
            {
                this._hWndControl.ResetAll();
                this._hWndControl.Repaint();
                HTuple m_roiData = null;
                m_roiData = rois[index].GetModelData();
                switch (rois[index].Type)
                {
                    case ROIType.Rectangle1:
                        if (m_roiData != null)
                        {
                            _roiController.DisplayRect1(roi.Key,rois[index].Color, m_roiData[0].D, m_roiData[1].D, m_roiData[2].D, m_roiData[3].D);
                        }
                        break;
                    case ROIType.Rectangle2:
                        if (m_roiData != null)
                        {
                            _roiController.DisplayRect2(roi.Key,rois[index].Color, m_roiData[0].D, m_roiData[1].D, m_roiData[2].D, m_roiData[3].D, m_roiData[4].D);
                        }
                        break;
                    case ROIType.Circle:
                        if (m_roiData != null)
                        {
                            _roiController.DisplayCircle(roi.Key,rois[index].Color, m_roiData[0].D, m_roiData[1].D, m_roiData[2].D);
                        }
                        break;
                    case ROIType.Line:
                        if (m_roiData != null)
                        {
                            _roiController.DisplayLine(roi.Key,rois[index].Color, m_roiData[0].D, m_roiData[1].D, m_roiData[2].D, m_roiData[3].D);
                        }
                        break;
                    default:
                        break;
                }
            }
        }

        /// <summary>
        /// 窗口显示ROI区域
        /// </summary>
        /// <param name="name"></param>
        /// <param name="roi"></param>
        public void DispROI(string name,ROI roi)
        {
            if (roi == null)
            {
                return;
            }
            HTuple m_roiData = roi.GetModelData();
                switch (roi.Type)
                {
                case ROIType.Point:
                    if (m_roiData != null)
                    {
                        this._roiController.DisplayPoint(name, roi.Color, m_roiData[0].D, m_roiData[1].D);
                    }
                    break;
                case ROIType.Circle:
                        if (m_roiData != null)
                        {
                            this._roiController.DisplayCircle(name, roi.Color, m_roiData[0].D, m_roiData[1].D, m_roiData[2].D);
                        }
                        break;
                    case ROIType.Line:
                        if (m_roiData != null)
                        {
                            this._roiController.DisplayLine(name, roi.Color, m_roiData[0].D, m_roiData[1].D, m_roiData[2].D, m_roiData[3].D);
                        }
                        break;
                case ROIType.Rectangle1:
                    if (m_roiData != null)
                    {
                        this._roiController.DisplayRect1(name, roi.Color, m_roiData[0].D, m_roiData[1].D, m_roiData[2].D, m_roiData[3].D);
                    }
                    break;
                case ROIType.Rectangle2:
                    if (m_roiData != null)
                    {
                        this._roiController.DisplayRect2(name, roi.Color, m_roiData[0].D, m_roiData[1].D, m_roiData[2].D, m_roiData[3].D, m_roiData[4].D);
                    }
                    break;
                case ROIType.FindLine:
                    if (m_roiData != null)
                    {
                        this._roiController.DisplayFindLine(name, roi.Color, roi.meaRectColor, m_roiData[0].D, m_roiData[1].D, m_roiData[2].D, m_roiData[3].D, Convert.ToInt32(m_roiData[4].D), m_roiData[5].D, m_roiData[6].D);
                    }
                    break;
                case ROIType.FindCircle:
                    if (m_roiData != null)
                    {
                        this._roiController.DisplayFindCircle(name, roi.Color, roi.meaRectColor, m_roiData[0].D, m_roiData[1].D, m_roiData[2].D, m_roiData[3].D, m_roiData[4].D, m_roiData[5].S, Convert.ToInt32(m_roiData[6].D), m_roiData[7].D, m_roiData[8].D);
                    }
                    break;
            }
        }

        /// <summary>
        /// 删除当前选中ROI 
        /// </summary>
        /// <param name="rois"></param>
        public void RemoveActiveROI(ref Dictionary<string, ROI> rois)
        {
            this._roiController.RemoveActiveROI(ref rois);
        }

        /// <summary>
        /// 保存ROI
        /// </summary>
        /// <param name="rois"></param>
        /// <param name="fileNmae"></param>
        public void SaveROI(Dictionary<string,ROI> rois, string fileNmae)
        {
            List<ROIInfo> m_RoiData = new List<ROIInfo>();
            foreach(KeyValuePair<string, ROI> kvp in rois)
            {
                m_RoiData.Add(new ROIInfo(kvp.Key, kvp.Value));
            }
            SerializationTools.Save(m_RoiData, fileNmae);
        }

        /// <summary>
        /// 加载ROI
        /// </summary>
        /// <param name="fileName"></param>
        /// <param name="rois"></param>
        public void LoadROI(string fileName, out Dictionary<string, ROI> rois)
        {
            rois = new Dictionary<string, ROI>();
            //List<ROIInfo> m_RoiData = new List<ROIInfo>();
            //m_RoiData = (List<ROIInfo>)SerializeHelper.Load(m_RoiData.GetType(), fileName);
            //for (int i = 0; i < m_RoiData.Count; i++)
            //{
            //    switch (m_RoiData[i].Name)
            //    {
            //        case "Rectangle1":
            //            this._roiController.genRect1("",m_RoiData[i].Rectangle1.Row1, m_RoiData[i].Rectangle1.Column1,m_RoiData[i].Rectangle1.Row2, m_RoiData[i].Rectangle1.Column2, ref rois);
            //            break;
            //        case "Rectangle2":
            //            this._roiController.genRect2(m_RoiData[i].Rectangle2.Row, m_RoiData[i].Rectangle2.Column,
            //                m_RoiData[i].Rectangle2.Phi, m_RoiData[i].Rectangle2.Lenth1, m_RoiData[i].Rectangle2.Lenth2, ref rois);
            //            rois.Last().Color = m_RoiData[i].Rectangle2.Color;
            //            break;
            //        case "Circle":
            //            this._roiController.genCircle(m_RoiData[i].Circle.Row, m_RoiData[i].Circle.Column, m_RoiData[i].Circle.Radius, ref rois);
            //            rois.Last().Color = m_RoiData[i].Circle.Color;
            //            break;
            //        case "Line":
            //            this._roiController.genLine(m_RoiData[i].Line.RowBegin, m_RoiData[i].Line.ColumnBegin,
            //                m_RoiData[i].Line.RowEnd, m_RoiData[i].Line.ColumnEnd, ref rois);
            //            rois.Last().Color = m_RoiData[i].Line.Color;
            //            break;
            //        default:
            //            break;
            //    }
            //}
            //this._hWndControl.ResetAll();
            //this._hWndControl.Repaint();
        }

        /// <summary>
        /// 显示HObject对象
        /// </summary>
        /// <param name="obj"></param>
        /// <param name="color"></param>
        public void DispHobject(HObject obj, string color)
        {
            _hWndControl.DispObj(obj, color);
        }

        /// <summary>
        /// 显示HObject对象
        /// </summary>
        /// <param name="obj"></param>
        /// <param name="color"></param>
        public void DispHobjGroup(HObject obj)
        {
            _hWndControl.DispObj(obj);
        }

        /// <summary>
        /// 显示HText对象
        /// </summary>
        /// <param name="MeasROIText"></param>
        public void DispText(HText MeasROIText)
        {
            _hWndControl.DispObj(MeasROIText);
        }

        #endregion
    }
}
