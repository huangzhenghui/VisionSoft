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
        #region �ֶΡ�����

        ///<summary>
        ///��Ϳ����
        ///</summary>
        public HRegion BrushRegion;

        ///<summary>
        ///��Ĥ����
        ///</summary>
        public HRegion MaskRegion;

        /// <summary>
        /// ������ĿǰΪֹ���д�����ROI������б�
        /// </summary>
        public Dictionary<string, ROI> ROIList;

        /// <summary> 
        /// ROI����
        /// </summary>
        private ROI ROIMode;

        /// <summary> 
        /// ROI��ʽ 
        /// </summary>
        private int ROIState;

        /// <summary> 
        /// ROI���� 
        /// </summary>
        public string ROIName;

        /// <summary>
        /// ROI���� 
        /// </summary>
        public HRegion ROIModel;

        /// <summary>
        /// ���X
        /// </summary>
        private double currX;

        /// <summary>
        /// ���Y
        /// </summary>
        private double currY;

        /// <summary>
        /// �����ROI����
        /// </summary>
        public string ActiveROIId;

        /// <summary>
        /// ɾ����ROI����
        /// </summary>
        public string DeleteROIId;

        /// <summary>
        /// ���������ɫ 
        /// </summary>
        private string ActiveCol = "cyan";

        /// <summary> 
        /// ����С����ɫ 
        /// </summary>
        private string ActiveROICol = "red";

        /// <summary>
        /// HWndCtrl����
        /// </summary>
        public HWndCtrl viewController;

        #endregion

        #region ��ʼ��

        /// <summary>
        /// ��ʼ��
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

        #region ����-ROI���

        /// <summary>
        /// ����HWndCtrl����
        /// </summary>
        public void SetViewController(HWndCtrl view)
        {
            viewController = view;
        }

        /// <summary>
        /// ��ȡ�����ROI����
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
        /// ��ȡ�����ROI����
        /// </summary>
        /// <returns></returns>
        public string GetActiveROIId()
        {
            return ActiveROIId;
        }

        /// <summary> 
        /// ����ROI��ʽ 
        /// </summary>
        public void SetROIShape(ROI r)
        {
            ROIMode = r;
            ROIMode.SetOperatorFlag(ROIState);
        }

        /// <summary>
        /// �Ƴ������ROI
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
        /// ������е�ROI
        /// </summary>
        public void ResetVar()
        {
            ROIList.Clear();
            ActiveROIId = "";
            ROIModel = null;
            ROIMode = null;
        }
        
        /// <summary>
        /// ��λROI
        /// </summary>
        public void ResetROI()
        {
            ActiveROIId = "";
            ROIMode = null;
        }

        /// <summary>
        /// ��ROIList�е����ж�����Ƶ�HALCON������ 
        /// </summary>
        /// <param name="window">HALCON����</param>
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
        /// MouseDown�¼�
        /// </summary>
        /// <param name="imgX">���X���꣬���򣬼�Column����</param>
        /// <param name="imgY">���Y���꣬���򣬼�Row����</param>
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
        /// MouseMove�¼�
        /// </summary>
        /// <param name="newX">���X���꣬���򣬼�Column����</param>
        /// <param name="newY">���Y���꣬���򣬼�Row����</param>
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
        /// ��ָ��λ����ʾROI-Rectangle1
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
        /// ��ָ��λ����ʾROI-Rectangle2
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
        /// ��ָ��λ����ʾROI-FindLine
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
        /// ��ָ��λ����ʾROI-FindLine
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
        /// ��ָ��λ������ROI-Circle
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
        /// ��ָ��λ����ʾROI-Line 
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
        /// ��ָ��λ����ʾROI-Point
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
        /// ��ָ��λ������ROI-Rectangle1
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
        /// ��ָ��λ������ROI-Rectangle2
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
        /// ��ָ��λ������ROI-Circle
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
        /// ��ָ��λ������ROI-CircleAre
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
        /// ��ָ��λ��������Բģ��
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
        /// ��ָ��λ����������ģ��
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
        /// ��ָ��λ������ROI-Line
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
        /// ��ָ��λ������ROI-Point
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
        /// ��ȡ��ǰѡ��ROI��Ϣ(�����������ơ�����)
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
        /// ��ȡ��ǰѡ��ROI��Ϣ(�����������ݡ�����)
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
        /// ɾ����ǰѡ��ROI 
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
        /// ѡ��ROI
        /// </summary>
        /// <param name="index"></param>
        protected internal void SelectROI(string index)
        {
            ActiveROIId = index;
            viewController.Repaint();
        }

        /// <summary>
        /// ������ʾ��������(ͼ��+����)
        /// </summary>
        protected internal void ResetWindowImage()
        {
            viewController.Repaint();
        }

        /// <summary>
        /// ����HALCON�����е�����¼�����ͼģʽ-����
        /// </summary>
        protected internal void ZoomWindowImage()
        {
            viewController.SetViewState(HWndCtrl.MODE_VIEW_ZOOM);
        }

        /// <summary>
        /// ����HALCON�����е�����¼�����ͼģʽ-�ƶ�
        /// </summary>
        protected internal void MoveWindowImage()
        {
            viewController.SetViewState(HWndCtrl.MODE_VIEW_MOVE);
        }

        /// <summary>
        /// ����HALCON�����е�����¼�����ͼģʽ-��
        /// </summary>
        protected internal void NoneWindowImage()
        {
            viewController.SetViewState(HWndCtrl.MODE_VIEW_NONE);
        }

        #endregion
    }
}
