using System;
using HalconDotNet;
using System.Collections;
using System.Collections.Generic;
using RexView.Model;

namespace RexView
{
    public delegate void FuncROIDelegate();

    public class ROIController
    {
        #region 字段、属性

        ///<summary>
        ///喷涂区域
        ///</summary>
        public HRegion BrushRegion;

        ///<summary>
        ///掩膜区域
        ///</summary>
        public HRegion MaskRegion;

        /// <summary>
        /// 包含到目前为止所有创建的ROI对象的列表
        /// </summary>
        public Dictionary<string, ROI> ROIList;

        /// <summary> 
        /// ROI类型
        /// </summary>
        private ROI ROIMode;

        /// <summary> 
        /// ROI样式 
        /// </summary>
        private int ROIState;

        /// <summary> 
        /// ROI名称 
        /// </summary>
        public string ROIName;

        /// <summary>
        /// ROI区域 
        /// </summary>
        public HRegion ROIModel;

        /// <summary>
        /// 鼠标X
        /// </summary>
        private double currX;

        /// <summary>
        /// 鼠标Y
        /// </summary>
        private double currY;

        /// <summary>
        /// 激活的ROI索引
        /// </summary>
        public string ActiveROIId;

        /// <summary>
        /// 删除的ROI索引
        /// </summary>
        public string DeleteROIId;

        /// <summary>
        /// 激活边线颜色 
        /// </summary>
        private string ActiveCol = "cyan";

        /// <summary> 
        /// 激活小框颜色 
        /// </summary>
        private string ActiveROICol = "red";

        /// <summary>
        /// HWndCtrl对象
        /// </summary>
        public HWndCtrl viewController;

        #endregion

        #region 初始化

        /// <summary>
        /// 初始化
        /// </summary>
        protected internal ROIController()
        {
            ROIState = HWndCtrl.MODE_ROI_NONE;
            ROIModel = new HRegion();
            ROIList = new Dictionary<string, ROI>();
            ActiveROIId = DeleteROIId = "";
            currX = currY = -1;
        }

        #endregion

        #region 方法-ROI相关

        /// <summary>
        /// 设置HWndCtrl对象
        /// </summary>
        public void SetViewController(HWndCtrl view)
        {
            viewController = view;
        }

        /// <summary>
        /// 获取激活的ROI对象
        /// </summary>
        /// <returns></returns>
        public ROI GetActiveROI()
        {
            try
            {
                if (ActiveROIId.Length>0)
                    foreach (KeyValuePair<string, ROI> kvp in ROIList)
                    {
                        if (kvp.Key.Equals(ActiveROIId))
                        {
                            return kvp.Value;
                        }
                    }
                return null;
            }
            catch (Exception)
            {
                return null;
            }
        }

        /// <summary>
        /// 获取激活的ROI索引
        /// </summary>
        /// <returns></returns>
        public string GetActiveROIId()
        {
            return ActiveROIId;
        }

        /// <summary> 
        /// 设置ROI样式 
        /// </summary>
        public void SetROIShape(ROI r)
        {
            ROIMode = r;
            ROIMode.SetOperatorFlag(ROIState);
        }

        /// <summary>
        /// 移除激活的ROI
        /// </summary>
        public void RemoveActive()
        {
            if (ActiveROIId.Length>0)
            {
                ROIList.Remove(ActiveROIId);
                DeleteROIId = ActiveROIId;
                ActiveROIId = "";
                viewController.Repaint();
            }
        }

        /// <summary>
        /// 清除所有的ROI
        /// </summary>
        public void ResetVar()
        {
            ROIList.Clear();
            ActiveROIId = "";
            ROIModel = null;
            ROIMode = null;
        }
        
        /// <summary>
        /// 复位ROI
        /// </summary>
        public void ResetROI()
        {
            ActiveROIId = "";
            ROIMode = null;
        }

        /// <summary>
        /// 将ROIList中的所有对象绘制到HALCON窗口中 
        /// </summary>
        /// <param name="window">HALCON窗口</param>
        public void PaintData(HWindow window,HObject hObj)
        {
            window.SetDraw("margin");
            window.SetLineWidth(1.45);

            if (ROIList.Count > 0)
            {
                foreach(KeyValuePair<string,ROI> kvp in ROIList)
                {
                    window.SetColor(kvp.Value.Color);
                    window.SetLineStyle(kvp.Value.FlagLineStyle);
                    kvp.Value.Draw(window, hObj);
                }

                if (ActiveROIId.Length>0)
                {
                    window.SetColor(ActiveCol);
                    window.SetLineStyle(ROIList[ActiveROIId].FlagLineStyle);
                    ROIList[ActiveROIId].Draw(window, hObj);

                    window.SetColor(ActiveROICol);
                    ROIList[ActiveROIId].DisplayActive(window, hObj);
                }
            }
        }

        /// <summary>
        /// MouseDown事件
        /// </summary>
        /// <param name="imgX">鼠标X坐标，横向，即Column坐标</param>
        /// <param name="imgY">鼠标Y坐标，纵向，即Row坐标</param>
        /// <returns></returns>
        public string MouseDownAction(double imgX, double imgY)
        {
            string idxROI = "";
            double max = 10000, dist = 0;
            double epsilon = 36.0;          

            if (ROIMode != null)   
            {
                ROIMode.CreateROI(imgX, imgY);
                ROIList.Add(ROIName, ROIMode);
                ROIMode = null;
                ActiveROIId = "";
                viewController.Repaint();
            }
            else if (ROIList.Count > 0) 
            {
                ActiveROIId = "";
                foreach (KeyValuePair<string, ROI> kvp in ROIList)
                {
                    dist = kvp.Value.DistToClosestHandle(imgX, imgY);
                    if ((dist < max) && (dist < epsilon))
                    {
                        max = dist;
                        idxROI = kvp.Key;
                    }
                }
                if (idxROI.Length>0)
                {
                    ActiveROIId = idxROI;
                }

                viewController.Repaint();
            }
            return ActiveROIId;
        }

        /// <summary>
        /// MouseMove事件
        /// </summary>
        /// <param name="newX">鼠标X坐标，横向，即Column坐标</param>
        /// <param name="newY">鼠标Y坐标，纵向，即Row坐标</param>
        public void MouseMoveAction(double newX, double newY)
        {
            try
            {
                if ((newX == currX) && (newY == currY))
                    return;

                ROIList[ActiveROIId].moveByHandle(newX, newY);
                viewController.Repaint();
                currX = newX;
                currY = newY;
            }
            catch { }

        }

        /// <summary>
        /// 在指定位置显示ROI-Rectangle1
        /// </summary>
        /// <param name="name"></param>
        /// <param name="color"></param>
        /// <param name="row1"></param>
        /// <param name="col1"></param>
        /// <param name="row2"></param>
        /// <param name="col2"></param>
        public void DisplayRect1(string name,string color, double row1, double col1, double row2, double col2)
        {
            SetROIShape(new ROIRectangle1());
            if (ROIMode != null)	
            {
                ROIMode.CreateRectangle1(row1, col1, row2, col2, color);
                ROIMode.Type = ROIType.Rectangle1;
                ROIMode.Color = color;
                ROIList.Remove(name);
                ROIList.Add(name, ROIMode);
                ROIMode = null;
                ActiveROIId = "";
                viewController.Repaint();
            }
        }

        /// <summary>
        /// 在指定位置显示ROI-Rectangle2
        /// </summary>
        /// <param name="name"></param>
        /// <param name="color"></param>
        /// <param name="row"></param>
        /// <param name="col"></param>
        /// <param name="phi"></param>
        /// <param name="length1"></param>
        /// <param name="length2"></param>
        public void DisplayRect2(string name, string color, double row, double col, double phi, double length1, double length2)
        {
            SetROIShape(new ROIRectangle2());

            if (ROIMode != null)
            {
                ROIMode.CreateRectangle2(row, col, phi, length1, length2, color);
                ROIMode.Type = ROIType.Rectangle2;
                ROIMode.Color = color;
                ROIList.Remove(name);
                ROIList.Add(name, ROIMode);
                ROIMode = null;
                ActiveROIId = "";
                viewController.Repaint();
            }
        }

        /// <summary>
        /// 在指定位置显示ROI-FindLine
        /// </summary>
        /// <param name="name"></param>
        /// <param name="color"></param>
        /// <param name="row"></param>
        /// <param name="col"></param>
        /// <param name="phi"></param>
        /// <param name="length1"></param>
        /// <param name="length2"></param>
        public void DisplayFindLine(string name, string projectColor, string meaRectColor, double rowBegin, double colBegin, double rowEnd, double colEnd, int rectNum, double length1, double length2)
        {
            SetROIShape(new ROIFindLine());

            if (ROIMode != null)
            {
                ROIMode.CreateFindLine(rowBegin, colBegin, rowEnd, colEnd, rectNum, length1, length2, projectColor, meaRectColor);
                ROIMode.Type = ROIType.FindLine;
                ROIMode.Color = projectColor;
                ROIMode.meaRectColor = meaRectColor;
                ROIList.Remove(name);
                ROIList.Add(name, ROIMode);
                ROIMode = null;
                ActiveROIId = "";
                viewController.Repaint();
            }
        }

        /// <summary>
        /// 在指定位置显示ROI-FindLine
        /// </summary>
        /// <param name="name"></param>
        /// <param name="projectColor"></param>
        /// <param name="meaRectColor"></param>
        /// <param name="row"></param>
        /// <param name="col"></param>
        /// <param name="radius"></param>
        /// <param name="startAngle"></param>
        /// <param name="endAngle"></param>
        /// <param name="pointOrder"></param>
        /// <param name="rowCenter"></param>
        /// <param name="colCenter"></param>
        /// <param name="phi"></param>
        /// <param name="length1"></param>
        /// <param name="length2"></param>
        public void DisplayFindCircle(string name, string projectColor, string meaRectColor, double row, double col, double radius, double startAngle, double endAngle, string pointOrder, int rectNum, double length1, double length2)
        {
            SetROIShape(new ROIFindCircle());

            if (ROIMode != null)
            {
                ROIMode.CreateFindCircle(row, col, radius, startAngle, endAngle, pointOrder, rectNum, length1, length2, projectColor, meaRectColor);
                ROIMode.Type = ROIType.FindCircle;
                ROIMode.Color = projectColor;
                ROIMode.meaRectColor = meaRectColor;
                ROIList.Remove(name);
                ROIList.Add(name, ROIMode);
                ROIMode = null;
                ActiveROIId = "";
                viewController.Repaint();
            }
        }

        /// <summary>
        /// 在指定位置生成ROI-Circle
        /// </summary>
        /// <param name="name"></param>
        /// <param name="color"></param>
        /// <param name="row"></param>
        /// <param name="col"></param>
        /// <param name="radius"></param>
        public void DisplayCircle(string name, string color, double row, double col, double radius)
        {
            SetROIShape(new ROICircle());

            if (ROIMode != null)	
            {
                ROIMode.CreateCircle(row, col, radius, color);
                ROIMode.Type = ROIType.Circle;
                ROIMode.Color = color;
                ROIList.Remove(name);
                ROIList.Add(name, ROIMode);
                ROIMode = null;
                ActiveROIId = "";
                viewController.Repaint();
            }
        }

        /// <summary>
        /// 在指定位置显示ROI-Line 
        /// </summary>
        /// <param name="name"></param>
        /// <param name="color"></param>
        /// <param name="beginRow"></param>
        /// <param name="beginCol"></param>
        /// <param name="endRow"></param>
        /// <param name="endCol"></param>
        public void DisplayLine(string name, string color, double beginRow, double beginCol, double endRow, double endCol)
        {
            ROIMode = new ROILine();
            if (ROIMode != null)			 
            {
                ROIMode.CreateLine(beginRow, beginCol, endRow, endCol);
                ROIMode.Type = ROIType.Line;
                ROIMode.Color = color;
                ROIList.Remove(name);
                ROIList.Add(name, ROIMode);
                ROIMode = null;
                ActiveROIId = "";
                viewController.Repaint();
            }
        }

        /// <summary>
        /// 在指定位置显示ROI-Point
        /// </summary>
        /// <param name="name"></param>
        /// <param name="color"></param>
        /// <param name="row"></param>
        /// <param name="col"></param>
        public void DisplayPoint(string name, string color, double row, double col)
        {
            SetROIShape(new ROICircle());

            if (ROIMode != null)			
            {
                ROIMode.CreatePoint(row, col);
                ROIMode.Type = ROIType.Point;
                ROIMode.Color = color;
                ROIList.Remove(name);
                ROIList.Add(name, ROIMode);
                ROIMode = null;
                ActiveROIId = "";
                viewController.Repaint();
            }
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
        protected internal void GenRect1(string name, double row1, double col1, double row2, double col2, ref Dictionary<string,ROI> rois, string color)
        {
            SetROIShape(new ROIRectangle1());
            if (rois == null)
            {
                rois = new Dictionary<string, ROI>();
            }

            if (ROIMode != null)		
            {
                ROIMode.CreateRectangle1(row1, col1, row2, col2, color);
                ROIMode.Type = ROIType.Rectangle1;
                rois.Remove(name);         
                ROIList.Remove(name);
                rois.Add(name, ROIMode);
                ROIList.Add(name, ROIMode);
                ROIMode = null;
                ActiveROIId = "";
                viewController.Repaint();
            }
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
        protected internal void GenRect2(string name, double row, double col, double phi, double length1, double length2, ref Dictionary<string,ROI> rois, string color)
        {
            SetROIShape(new ROIRectangle2());

            if (rois == null)
            {
                rois = new Dictionary<string,ROI>();
            }

            if (ROIMode != null)
            {
                ROIMode.CreateRectangle2(row, col, phi, length1, length2, color);
                ROIMode.Type = ROIType.Rectangle2;
                rois.Remove(name);
                ROIList.Remove(name);
                rois.Add(name, ROIMode);
                ROIList.Add(name, ROIMode);
                ROIMode = null;
                ActiveROIId = "";
                viewController.Repaint();
            }
        }

        /// <summary>
        /// 在指定位置生成ROI-Circle
        /// </summary>
        /// <param name="name"></param>
        /// <param name="row"></param>
        /// <param name="col"></param>
        /// <param name="radius"></param>
        /// <param name="rois"></param>
        protected internal void GenCircle(string name, double row, double col, double radius, ref Dictionary<string,ROI> rois, string color)
        {
            SetROIShape(new ROICircle());
            if (rois == null)
            {
                rois = new Dictionary<string,ROI>();
            }
            if (ROIMode != null) 
            {
                ROIMode.CreateCircle(row, col, radius, color);
                ROIMode.Type = ROIType.Circle;
                rois.Remove(name);
                ROIList.Remove(name);
                rois.Add(name, ROIMode);
                ROIList.Add(name, ROIMode);
                ROIMode = null;
                ActiveROIId = "";
                viewController.Repaint();
            }
        }

        /// <summary>
        /// 在指定位置生成ROI-CircleAre
        /// </summary>
        /// <param name="name"></param>
        /// <param name="row"></param>
        /// <param name="col"></param>
        /// <param name="radius"></param>
        /// <param name="rois"></param>
        protected internal void GenCircleArc(string name, double row, double col, double radius, ref Dictionary<string,ROI> rois)
        {
            SetROIShape(new ROICircularArc());
            if (rois == null)
            {
                rois = new Dictionary<string,ROI>();
            }
            if (ROIMode != null) 
            {
                ROIMode.CreateCircleAre(row, col, radius);
                ROIMode.Type = ROIType.CircleArc;
                rois.Remove(name);
                ROIList.Remove(name);
                rois.Add(name, ROIMode);
                ROIList.Add(name, ROIMode);
                ROIMode = null;
                ActiveROIId = "";
                viewController.Repaint();
            }
        }

        /// <summary>
        /// 在指定位置生成找圆模型
        /// </summary>
        /// <param name="name"></param>
        /// <param name="row"></param>
        /// <param name="col"></param>
        /// <param name="radius"></param>
        /// <param name="rois"></param>
        protected internal void GenFindCircle(string name, double row, double col, double radius, double startAngle, double endAngle, string pointOrder, int rectNum, double length1, double length2, ref Dictionary<string, ROI> rois, string projectColor, string meaRectColor)
        {
            SetROIShape(new ROIFindCircle());
            if (rois == null)
            {
                rois = new Dictionary<string, ROI>();
            }
            if (ROIMode != null)
            {
                ROIMode.CreateFindCircle(row, col, radius, startAngle, endAngle, pointOrder, rectNum, length1, length2, projectColor, meaRectColor);
                ROIMode.Type = ROIType.FindCircle;
                rois.Remove(name);
                ROIList.Remove(name);
                rois.Add(name, ROIMode);
                ROIList.Add(name, ROIMode);
                ROIMode = null;
                ActiveROIId = "";
                viewController.Repaint();
            }
        }

        /// <summary>
        /// 在指定位置生成找线模型
        /// </summary>
        /// <param name="name"></param>
        /// <param name="row"></param>
        /// <param name="col"></param>
        /// <param name="radius"></param>
        /// <param name="rois"></param>
        protected internal void GenFindLine(string name, double rowBegin, double colBegin, double rowEnd, double colEnd, int rectNum, double length1, double length2, ref Dictionary<string, ROI> rois, string projectColor, string meaRectColor)
        {
            SetROIShape(new ROIFindLine());
            if (rois == null)
            {
                rois = new Dictionary<string, ROI>();
            }
            if (ROIMode != null)
            {
                ROIMode.CreateFindLine(rowBegin, colBegin, rowEnd, colEnd, rectNum, length1, length2, projectColor, meaRectColor);
                ROIMode.Type = ROIType.FindLine;
                rois.Remove(name);
                ROIList.Remove(name);
                rois.Add(name, ROIMode);
                ROIList.Add(name, ROIMode);
                ROIMode = null;
                ActiveROIId = "";
                viewController.Repaint();
            }
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
        protected internal void GenLine(string name, double beginRow, double beginCol, double endRow, double endCol, ref Dictionary<string,ROI> rois)
        {
            SetROIShape(new ROILine());

            if (rois == null)
            {
                rois = new Dictionary<string,ROI>();
            }

            if (ROIMode != null)
            {
                ROIMode.CreateLine(beginRow, beginCol, endRow, endCol);
                ROIMode.Type = ROIType.Line;
                rois.Remove(name);
                ROIList.Remove(name);
                rois.Add(name, ROIMode);
                ROIList.Add(name, ROIMode);
                ROIMode = null;
                ActiveROIId = "";
                viewController.Repaint();
            }
        }

        /// <summary>
        /// 在指定位置生成ROI-Point
        /// </summary>
        /// <param name="name"></param>
        /// <param name="row"></param>
        /// <param name="col"></param>
        /// <param name="rois"></param>
        protected internal void GenPoint(string name, double row, double col ,ref Dictionary<string, ROI> rois)
        {
            SetROIShape(new ROIPoint());
            if (rois == null)
            {
                rois = new Dictionary<string, ROI>();
            }
            if (ROIMode != null)
            {
                ROIMode.CreatePoint(row, col);
                ROIMode.Type = ROIType.Point;
                rois.Remove(name);
                ROIList.Remove(name);
                rois.Add(name, ROIMode);
                ROIList.Add(name, ROIMode);
                ROIMode = null;
                ActiveROIId = "";
                viewController.Repaint();
            }
        }

        /// <summary>
        /// 获取当前选中ROI信息(包括对象、名称、索引)
        /// </summary>
        /// <param name="name"></param>
        /// <param name="index"></param>
        /// <returns></returns>
        protected internal ROI GetActiveROIInfo(out string name, out string index)
        {
            name = "";
            string activeROIIdx = GetActiveROIId();
            index = activeROIIdx;
            if (activeROIIdx.Length>0)
            {
                ROI region = GetActiveROI();
                name = region.GetType().ToString();
                switch (name.Split('.')[1])
                {
                    case "ROIPoint":
                        region.Type = ROIType.Point;
                        break;
                    case "ROILine":
                        region.Type = ROIType.Line;
                        break;
                    case "ROICircle":
                        region.Type = ROIType.Circle;
                        break;
                    case "FindCircle":
                        region.Type = ROIType.FindCircle;
                        break;
                    case "ROIRectangle1":
                        region.Type = ROIType.Rectangle1;
                        break;
                    case "ROIRectangle2":
                        region.Type = ROIType.Rectangle2;
                        break;
                }
                return region;
            }
            else
            {
                return null;
            }
        }

        /// <summary>
        /// 获取当前选中ROI信息(包括对象、数据、索引)
        /// </summary>
        /// <param name="data"></param>
        /// <param name="index"></param>
        /// <returns></returns>
        protected internal ROI GetActiveROIInfo(out List<double> data, out string index)
        {
            try
            {
                index = GetActiveROIId();
                data = new List<double>();
                if (index.Length>0)
                {
                    ROI region = this.GetActiveROI();
                    Type type = region.GetType();
                    HTuple smallest = region.GetModelData();
                    for (int i = 0; i < smallest.Length; i++)
                    {
                        data.Add(smallest[i].D);
                    }
                    return region;
                }
                else
                {
                    return null;
                }

            }
            catch (Exception)
            {
                data = null;
                index = "";
                return null;
            }
        }

        /// <summary>
        /// 删除当前选中ROI 
        /// </summary>
        /// <param name="roi"></param>
        protected internal void RemoveActiveROI(ref Dictionary<string, ROI> roi)
        {
            try
            {
                string activeROIIdx = this.GetActiveROIId();
                if (activeROIIdx.Length>0)
                {
                    RemoveActive();
                    roi.Remove(activeROIIdx);
                }
            }
            catch { }
        }

        /// <summary>
        /// 选择ROI
        /// </summary>
        /// <param name="index"></param>
        protected internal void SelectROI(string index)
        {
            ActiveROIId = index;
            viewController.Repaint();
        }

        /// <summary>
        /// 重新显示窗体内容(图像+区域)
        /// </summary>
        protected internal void ResetWindowImage()
        {
            viewController.Repaint();
        }

        /// <summary>
        /// 设置HALCON窗口中的鼠标事件的视图模式-缩放
        /// </summary>
        protected internal void ZoomWindowImage()
        {
            viewController.SetViewState(HWndCtrl.MODE_VIEW_ZOOM);
        }

        /// <summary>
        /// 设置HALCON窗口中的鼠标事件的视图模式-移动
        /// </summary>
        protected internal void MoveWindowImage()
        {
            viewController.SetViewState(HWndCtrl.MODE_VIEW_MOVE);
        }

        /// <summary>
        /// 设置HALCON窗口中的鼠标事件的视图模式-无
        /// </summary>
        protected internal void NoneWindowImage()
        {
            viewController.SetViewState(HWndCtrl.MODE_VIEW_NONE);
        }

        #endregion
    }
}
