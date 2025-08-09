using HalconDotNet;
using RexConst;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace RexView
{
    #region ί��

    public delegate void FuncDelegate();
    public delegate void IconicDelegate(int val);

    #endregion

    /// <summary>
    ///�������ΪHALCON���ڵİ�װ��,������ӻ�
    /// </summary>
    public class HWndCtrl
    {
        #region �ֶΡ�����

        /// <summary>
        /// ��ʾROI
        /// </summary>
        public const int MODE_INCLUDE_ROI = 1;

        /// <summary>
        /// ����ʾROI
        /// </summary>
		public const int MODE_EXCLUDE_ROI = 2;

        /// <summary>
        /// ������¼���ִ���κβ���
        /// </summary>
        public const int MODE_VIEW_NONE = 10;

        /// <summary>
        /// ����������¼���ִ��
        /// </summary>
        public const int MODE_VIEW_ZOOM = 11;

        /// <summary>
        /// ������¼���ִ���ƶ�
        /// </summary>
        public const int MODE_VIEW_MOVE = 12;

        /// <summary>
        /// ������¼����зŴ�
        /// </summary>
        public const int MODE_VIEW_ZOOMWINDOW = 13;

        /// <summary>
        /// ����
        /// </summary>
        public const int MODE_ERASER = 14;

        /// <summary>
        /// ��Ϳ
        /// </summary>
        public const int MODE_PAINT = 15;

        /// <summary>
        /// ����ROIģʽ�ĳ���:ROI������
        /// </summary>
        public const int MODE_ROI_POS = 21;

        /// <summary>
        /// ����ROIģʽ�ĳ���:����ROI����
        /// </summary>
        public const int MODE_ROI_NEG = 22;

        /// <summary>
        /// ����ROIģʽ�ĳ���:û��ģ���������Ϊ����ROI������ܺ�
        /// </summary>
        public const int MODE_ROI_NONE = 23;

        /// <summary>
        /// ����Ϊ��ͼ�񷢳��źŵ�ί����Ϣ
        /// </summary>
        public const int EVENT_UPDATE_IMAGE = 31;

        /// <summary>
        /// �����������ļ��ж�ȡͼ��ʱ���������źŵ�ί����Ϣ 
        /// </summary>
        public const int ERR_READING_IMG = 32;

        /// <summary>
        /// �����ڶ���ͼ��������ʱ����ί����Ϣ����Ϊ�źŴ���
        /// </summary>
        public const int ERR_DEFINING_GC = 33;

        /// <summary>
        /// ����ģ��������µĳ���
        /// </summary>
        public const int EVENT_UPDATE_ROI = 50;
        public const int EVENT_CHANGED_ROI_SIGN = 51;

        /// <summary>
        /// ����ģ��������µĳ���
        /// </summary>
        public const int EVENT_MOVING_ROI = 52;
        public const int EVENT_DELETED_ACTROI = 53;
        public const int EVENT_DELETED_ALL_ROIS = 54;
        public const int EVENT_ACTIVATED_ROI = 55;
        public const int EVENT_CREATED_ROI = 56;

        /// <summary> 
        /// ���Է�����ͼ���ϵ�HALCON������������,��ջ����ʧ
        /// </summary>
        private const int MAXNUMOBJLIST = 50;

        /// <summary>
        /// �Դ���Ĳ���״̬
        /// </summary>
        private int ViewState;

        /// <summary>
        /// ����Ƿ���
        /// </summary>
        private bool MousePressed = false;

        /// <summary>
        /// ��ʼ��X��Y
        /// </summary>
        private double StartX, StartY;

        /// <summary>
        /// HALCON����
        /// </summary>
        public HWindowControl ViewPort;

        /// <summary>
        /// ROIController��ʵ��
        /// </summary>
        private ROIController ROIManager;

        /// <summary>
        /// ��ʾROI
        /// </summary>
        private int DispROI;

        /// <summary>
        /// �Ƿ����
        /// </summary>
        public bool drawModel = false;

        /// <summary>
        /// ������
        /// </summary>
        public int WindowWidth;

        /// <summary>
        /// ����߶�
        /// </summary>
        public int WindowHeight;

        /// <summary>
        /// ͼ����
        /// </summary>
        public int ImageWidth;

        /// <summary>
        /// ͼ��߶�
        /// </summary>
        public int ImageHeight;

        /// <summary> 
        /// ͼ�����꣬��������HALCON��������ʾ��ͼ�񲿷� 
        /// </summary>
        private double ImgRow1, ImgCol1, ImgRow2, ImgCol2;

        /// <summary>
        /// �׳��쳣ʱ�Ĵ�����Ϣ
        /// </summary>
        public string ExceptionText = "";

        /// <summary>
        /// ί�з���֪ͨ��Ϣ�������� 
        /// </summary>
        public FuncDelegate AddInfoDelegate;

        /// <summary>
        /// ֪ͨHWndCtrlʵ����ʧ������ 
        /// </summary>
        public IconicDelegate NotifyIconObserver;

        /// <summary>
        /// Halcon����
        /// </summary>
        private HWindow ZoomWindow;

        /// <summary> 
        /// ���Ų���
        /// </summary>
        private double ZoomWndFactor, ZoomAddOn;

        /// <summary>
        /// ���ųߴ�
        /// </summary>
        private int ZoomWndSize;

        /// <summary> 
        /// ���Ƶ�HALCON���ڵ�HALCON�����б� 
        /// </summary>
        private ArrayList HObjImageList;

        /// <summary>
        /// ��������ͼ�������ĵ�ʵ��
        /// </summary>
        private GraphicsContext mGC;

        /// <summary>
        /// HObjectEntry�����б�
        /// </summary>
        public List<HObjectEntry> HObjList;

        /// <summary>
        /// HObjectWithColor�����б�
        /// </summary>
        private List<HObjectWithColor> hObjectList = new List<HObjectWithColor>();

        /// <summary>
        /// HObj��
        /// </summary>
        public HObject HObjGroup;

        /// <summary>
        /// HText�����б�
        /// </summary>
        private List<HText> roiTextList = new List<HText>();

        /// <summary>
        /// ��ʾ��̬
        /// </summary>
        public string showDraw = "margin";

        /// <summary>
        /// �Ƿ���Ӧ����
        /// </summary>
        public bool isFitWindow = true;

        #endregion

        #region ��ʼ��

        /// <summary>
        /// ��ʼ��
        /// </summary>
        /// <param name="view"></param>
        protected internal HWndCtrl(HWindowControl view)
        {
            ViewPort = view;
            ViewState = MODE_VIEW_NONE;
            WindowWidth = ViewPort.Size.Width;
            WindowHeight = ViewPort.Size.Height;
            ZoomWndFactor = (double)ImageWidth / ViewPort.Width;
            ZoomAddOn = Math.Pow(0.9, 5);
            ZoomWndSize = 150;
            DispROI = MODE_INCLUDE_ROI;
            ViewPort.HMouseUp += new HMouseEventHandler(this.MouseUp);
            ViewPort.HMouseDown += new HMouseEventHandler(this. MouseDown);
            ViewPort.HMouseWheel += new HMouseEventHandler(this.MouseWheel);
            ViewPort.HMouseMove += new HMouseEventHandler(this.MouseMoved);
            HObjImageList = new ArrayList(20);
            mGC = new GraphicsContext();
            mGC.gcNotification = new GCDelegate(ExceptionGC);
        }

        #endregion

        #region �¼�-Halcon���ڿؼ�

        /// <summary>
        /// MouseWheel�¼�
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void MouseWheel(object sender, HMouseEventArgs e)
        {
            if (drawModel)
            {
                return;
            }
            double scale;
            if (e.Delta > 0)
                scale = 0.9;
            else
                scale = 1 / 0.9;
            ZoomImage(e.X, e.Y, scale);
        }

        /// <summary>
        /// MouseDown�¼�
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void MouseDown(object sender, HMouseEventArgs e)
        {
            if (drawModel) return;
            ViewPort.Cursor = System.Windows.Forms.Cursors.Hand;
            ViewState = MODE_VIEW_MOVE;
            MousePressed = true;
            string ActiveROIId = "";
            if (ROIManager != null && (DispROI == MODE_INCLUDE_ROI))
            {
                ActiveROIId = ROIManager.MouseDownAction(e.X, e.Y);
            }
            switch (ViewState)
            {
                case MODE_VIEW_MOVE:
                    StartX = e.X;
                    StartY = e.Y;
                    break;
                case MODE_VIEW_NONE:
                    break;
                case MODE_VIEW_ZOOMWINDOW:
                    ActivateZoomWindow((int)e.X, (int)e.Y);
                    break;
                default:
                    break;
            }
        }

        /// <summary>
        /// ���̧���¼�
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void MouseUp(object sender, HMouseEventArgs e)
        {
            //�ر������¼�
            if (drawModel)
            {
                return;
            }

            MousePressed = false;

            if (ROIManager != null && (ROIManager.ActiveROIId.Length > 0) && (DispROI == MODE_INCLUDE_ROI))
            {

            }
            else if (ViewState == MODE_VIEW_ZOOMWINDOW)
            {
                ZoomWindow.Dispose();
            }
        }

        /// <summary>
        /// ����ƶ��¼�
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void MouseMoved(object sender, HMouseEventArgs e)
        {
            if (drawModel) { return; }
            double MotionX, MotionY, PosX, PosY, ZoomZone;
            if (!MousePressed) return;
            if (ROIManager != null && (ROIManager.ActiveROIId.Length > 0) && (DispROI == MODE_INCLUDE_ROI))
            {
                ROIManager.MouseMoveAction(e.X, e.Y);
            }
            else if (ViewState == MODE_VIEW_MOVE)//ƽ��ͼ��
            {
                MotionX = (e.X - StartX);
                MotionY = (e.Y - StartY);

                if (((int)MotionX != 0) || ((int)MotionY != 0))
                {
                    MoveImage(MotionX, MotionY);
                    StartX = e.X - MotionX;
                    StartY = e.Y - MotionY;
                }
            }
            else if (ViewState == MODE_VIEW_ZOOMWINDOW)//�ֲ��Ŵ�
            {
                HSystem.SetSystem("flush_graphic", "false");
                ZoomWindow.ClearWindow();
                PosX = ((e.X - ImgCol1) / (ImgCol2 - ImgCol1)) * ViewPort.Width;
                PosY = ((e.Y - ImgRow1) / (ImgRow2 - ImgRow1)) * ViewPort.Height;
                ZoomZone = (ZoomWndSize / 2) * ZoomWndFactor * ZoomAddOn;
                ZoomWindow.SetWindowExtents((int)(PosY - (ZoomWndSize / 2)), (int)(PosX - (ZoomWndSize / 2)), ZoomWndSize, ZoomWndSize);
                ZoomWindow.SetPart((int)(e.Y - ZoomZone), (int)(e.X - ZoomZone), (int)(e.Y + ZoomZone), (int)(e.X + ZoomZone));
                Repaint(ZoomWindow);
                HSystem.SetSystem("flush_graphic", "true");
                ZoomWindow.DispLine(-100.0, -100.0, -100.0, -100.0);
            }
        }

        #endregion

        #region ����-Halcon���ڿؼ����

        /// <summary>
        /// ����ͼ���С�����ϽǺ����½�
        /// </summary>
        private void SetImagePart(int r1, int c1, int r2, int c2)
        {
            ImgRow1 = r1;
            ImgCol1 = c1;
            ImgRow2 = ImageHeight = r2;
            ImgCol2 = ImageWidth = c2;

            Rectangle rect = ViewPort.ImagePart;
            rect.X = (int)ImgCol1;
            rect.Y = (int)ImgRow1;
            rect.Height = (int)ImageHeight;
            rect.Width = (int)ImageWidth;
            ViewPort.ImagePart = rect;
        }

        /// <summary>
        /// ����HALCON�����е�����¼�����ͼģʽ(���ţ��ƶ�����)
        /// </summary>
        /// <param name="mode"></param>
        public void SetViewState(int mode)
        {
            ViewState = mode;
            if (ROIManager != null)
                ROIManager.ResetROI();
        }

        /// <summary>
        /// �쳣��Ϣ
        /// </summary>
        /// <param name="message"></param>
        private void ExceptionGC(string message)
        {
            ExceptionText = message;
            NotifyIconObserver(ERR_DEFINING_GC);
        }

        /// <summary>
        ///������ز���
        /// </summary>
        protected internal void ResetAll()
        {
            ImgRow1 = 0;
            ImgCol1 = 0;
            ImgRow2 = ImageHeight;
            ImgCol2 = ImageWidth;

            ZoomWndFactor = (double)ImageWidth / ViewPort.Width;

            System.Drawing.Rectangle rect = ViewPort.ImagePart;
            rect.X = (int)ImgCol1;
            rect.Y = (int)ImgRow1;
            rect.Width = (int)ImageWidth;
            rect.Height = (int)ImageHeight;
            ViewPort.ImagePart = rect;

            if (ROIManager != null) ROIManager.ResetVar();
        }

        /// <summary>
        /// ����ͼ��
        /// </summary>
        /// <param name="x"></param>
        /// <param name="y"></param>
        /// <param name="scale"></param>
        private void ZoomImage(double x, double y, double scale)
        {
            if (drawModel)
            {
                return;
            }
            double lengthC, lengthR, percentC, percentR;
            int lenC, lenR;
            percentC = (x - ImgCol1) / (ImgCol2 - ImgCol1);
            percentR = (y - ImgRow1) / (ImgRow2 - ImgRow1);

            lengthC = (ImgCol2 - ImgCol1) * scale;
            lengthR = (ImgRow2 - ImgRow1) * scale;

            ImgCol1 = x - lengthC * percentC;
            ImgCol2 = x + lengthC * (1 - percentC);

            ImgRow1 = y - lengthR * percentR;
            ImgRow2 = y + lengthR * (1 - percentR);

            lenC = (int)Math.Round(lengthC);
            lenR = (int)Math.Round(lengthR);

            System.Drawing.Rectangle rect = ViewPort.ImagePart;
            rect.X = (int)Math.Round(ImgCol1);
            rect.Y = (int)Math.Round(ImgRow1);
            rect.Width = (lenC > 0) ? lenC : 1;
            rect.Height = (lenR > 0) ? lenR : 1;

            ViewPort.ImagePart = rect;

            double _zoomWndFactor = 1;
            _zoomWndFactor = scale * ZoomWndFactor;

            if (ZoomWndFactor < 0.001 && _zoomWndFactor < ZoomWndFactor)
            {
                //����һ�����ű����Ͳ�������
                ResetWindow();
                return;
            }
            if (ZoomWndFactor > 5 && _zoomWndFactor > ZoomWndFactor)
            {
                //����һ�����ű����Ͳ�������
                ResetWindow();
                return;
            }
            ZoomWndFactor = _zoomWndFactor;

            Repaint();
        }

        /// <summary>
        /// �ƶ�ͼ��
        /// </summary>
        /// <param name="MotionX"></param>
        /// <param name="MotionY"></param>
        private void MoveImage(double MotionX, double MotionY)
        {
            ImgRow1 += -MotionY;
            ImgRow2 += -MotionY;

            ImgCol1 += -MotionX;
            ImgCol2 += -MotionX;

            System.Drawing.Rectangle rect = ViewPort.ImagePart;
            rect.X = (int)Math.Round(ImgCol1);
            rect.Y = (int)Math.Round(ImgRow1);
            ViewPort.ImagePart = rect;

            Repaint();
        }

        /// <summary>
        /// ����
        /// </summary>
        /// <param name="X"></param>
        /// <param name="Y"></param>
        private void ActivateZoomWindow(int X, int Y)
        {
            double posX, posY;
            int ZoomZone;

            if (ZoomWindow != null)
                ZoomWindow.Dispose();

            HOperatorSet.SetSystem("border_width", 10);
            ZoomWindow = new HWindow();
            ZoomWindow.SetColor("white");

            posX = ((X - ImgCol1) / (ImgCol2 - ImgCol1)) * ViewPort.Width;
            posY = ((Y - ImgRow1) / (ImgRow2 - ImgRow1)) * ViewPort.Height;

            ZoomZone = (int)((ZoomWndSize / 2) * ZoomWndFactor * ZoomAddOn);
            ZoomWindow.OpenWindow((int)(posY - (ZoomWndSize / 2)), (int)(posX - (ZoomWndSize / 2)), (int)ZoomWndSize, (int)ZoomWndSize,
                                   ViewPort.HalconID, "visible", "");
            ZoomWindow.SetPart(Y - ZoomZone, X - ZoomZone, Y + ZoomZone, X + ZoomZone);
            Repaint(ZoomWindow);
        }

        /// <summary>
        /// ����Ӧ����
        /// </summary>
        protected internal void ResetWindow()
        {
            if (ImageHeight == 0)
            {
                return;
            }
            double ratio_win = (double)ViewPort.WindowSize.Width / (double)ViewPort.WindowSize.Height;
            double ratio_img = (double)ImageWidth / (double)ImageHeight;

            int _beginRow, _begin_Col, _endRow, _endCol;
            //
            if (ratio_win >= ratio_img)
            {
                _beginRow = 0;
                _endRow = ImageHeight - 1;
                _begin_Col = (int)(-ImageWidth * (ratio_win / ratio_img - 1d) / 2d);
                _endCol = (int)(ImageWidth + ImageWidth * (ratio_win / ratio_img - 1d) / 2d);
            }
            else
            {
                _begin_Col = 0;
                _endCol = ImageWidth - 1;
                _beginRow = (int)(-ImageHeight * (ratio_img / ratio_win - 1d) / 2d);
                _endRow = (int)(ImageHeight + ImageHeight * (ratio_img / ratio_win - 1d) / 2d);
            }

            //���ű���Ϊ1
            ZoomWndFactor = 1;

            Rectangle rect = ViewPort.ImagePart;
            rect.X = (int)_begin_Col;
            rect.Y = (int)_beginRow;
            rect.Width = (int)_endCol - _begin_Col;
            rect.Height = (int)_endRow - _beginRow;
            ViewPort.ImagePart = rect;

            ImgRow1 = _beginRow;
            ImgCol1 = _begin_Col;
            ImgRow2 = _endRow;
            ImgCol2 = _endCol;
        }

        /// <summary>
        /// ����뿪�¼�������뿪�����ٷ���ʱ,ͼ����������ƶ�
        /// </summary>
        public void RaiseMouseup()
        {
            MousePressed = false;

            if (ViewState == MODE_VIEW_ZOOMWINDOW)
            {
                ZoomWindow.Dispose();
            }
        }

        /// <summary>
        /// ������ʾ��������(ͼ��+����)
        /// </summary>
        public void Repaint()
        {
             Repaint(ViewPort.HalconWindow);
        }

        /// <summary>
        /// ������ʾ��������(ͼ��+����)
        /// </summary>
        /// <param name="window">Halcon����</param>
        public void Repaint(HWindow window)
        {
            try
            {
                window.SetDraw("fill");
                window.SetColor("#" + string.Format(ViewPort.BorderColor.R.ToString("x2") + ViewPort.BorderColor.G.ToString("x2") + ViewPort.BorderColor.B.ToString("x2")));
                HSystem.SetSystem("flush_graphic", "false");
                window.DispRectangle1((HTuple)(-25000), -25000, 25000, 25000);
                window.SetDraw(showDraw);
                HOperatorSet.SetLineWidth(window, 1.45);
                HObjectEntry entry = new HObjectEntry(new HObject(), new Hashtable());

                //��ʾͼƬ
                for (int i = 0; i < HObjImageList.Count; i++)
                {
                    entry = (HObjectEntry)HObjImageList[i];
                    mGC.ApplyContext(window, entry.gContext);

                    if (isFitWindow)
                    {
                        ResetWindow();
                        isFitWindow = false;
                    }

                    window.DispObj(entry.HObj);
                }

                //��ʾregion
                ShowHObjectList();
                ShowHObjectGroup();
                if (ROIManager != null && (DispROI == MODE_INCLUDE_ROI))
                {
                    ROIManager.PaintData(window, entry.HObj);
                }
                HSystem.SetSystem("flush_graphic", "true");

                //ע�����������,�ᵼ�´����޷�ʵ�����ź��϶�
                window.SetColor("#" + string.Format(ViewPort.BorderColor.R.ToString("x2") + ViewPort.BorderColor.G.ToString("x2") + ViewPort.BorderColor.B.ToString("x2")));
                window.DispLine(-100.0, -100.0, -101.0, -101.0);
            }
            catch { }
        }

        /// <summary>
        /// ����趨��ʾ��ͼ��
        /// </summary>
        /// <param name="img"></param>
        public void AddIconicVar(HObject img)
        {
            //�Ȱ�HObjImageList��ȫ���ͷ���,Դ���� ������ڴ�й©����
            for (int i = 0; i < HObjImageList.Count; i++)
            {
                ((HObjectEntry)HObjImageList[i]).Clear();
            }
            if (img == null) return;
            HOperatorSet.GetObjClass(img, out HTuple classValue);
            if (!classValue.S.Equals(classValue))
            { return; }
            if ((HImage)img is HImage)
            {
                ((HImage)img).GetImagePointer1(out string s, out int w, out int h);

                ClearList();
                if (w != ImageWidth || h != ImageHeight)
                {
                    ImageWidth = w;
                    ImageHeight = h;
                    ZoomWndFactor = (double)ImageWidth / ViewPort.Width;
                    SetImagePart(0, 0, h, w);
                }
            }
            HObjectEntry entry = new HObjectEntry((HImage)img, mGC.copyContextList());
            HObjImageList.Add(entry);

            //ÿ�����뱳��ͼ��ʱ�� �����HObjectList
            ClearHObjectList();
            if (HObjImageList.Count > MAXNUMOBJLIST)
            {
                //��Ҫ�Լ��ֶ��ͷ�
                ((HObjectEntry)HObjImageList[0]).Clear();
                HObjImageList.RemoveAt(1);
            }
        }

        /// <summary>
        /// ���ͼ���б�
        /// </summary>
        public void ClearList()
        {
            HObjImageList.Clear();
        }

        /// <summary>
        /// ΪROIController��������HWndCtrl����
        /// </summary>
        /// <param name="rC"></param>
        protected internal void SetROIController(ROIController rC)
        {
            ROIManager = rC;
            rC.SetViewController(this);
            SetViewState(HWndCtrl.MODE_VIEW_NONE);
        }

        /// <summary>
        /// ����趨��ʾ��ͼ��
        /// </summary>
        /// <param name="image"></param>
        protected internal void addImageShow(HObject image)
        {
            AddIconicVar(image);
        }

        /// <summary>
        /// ��ʾHObject����
        /// </summary>
        /// <param name="hObj"></param>
        /// <param name="color"></param>
        public void DispObj(HObject hObj, string color)
        {
            lock (this)
            {
                try
                {
                    //��ʾָ������ɫ
                    if (color != null)
                    {
                        HOperatorSet.SetColor(ViewPort.HalconWindow, color);
                    }
                    else
                    {
                        HOperatorSet.SetColor(ViewPort.HalconWindow, "red");
                    }

                    if (hObj != null && hObj.IsInitialized())
                    {
                        HOperatorSet.SetLineWidth(ViewPort.HalconWindow, 1.45);
                        hObjectList.Add(new HObjectWithColor(hObj, color));
                        ViewPort.HalconWindow.DispObj(hObj);
                    }

                    //�ָ�Ĭ�ϵĺ�ɫ
                    HOperatorSet.SetColor(ViewPort.HalconWindow, "red");
                }
                catch { }
            }
        }

        public void DispObj(HObject HObjGroup)
        {
            this.HObjGroup = HObjGroup;
        }

        /// <summary>
        /// ��ʾHText����
        /// </summary>
        /// <param name="roiText"></param>
        public void DispObj(HText roiText)
        {
            lock (this)
            {
                roiTextList.Add(roiText);
                ShowTool.SetFont(ViewPort.HalconWindow, roiText.size, roiText.font, "false", "false");
                ShowTool.SetMsg(ViewPort.HalconWindow, roiText.text, "window", roiText.row, roiText.col, roiText.drawColor, "false");
            }
        }

        /// <summary>
        /// ÿ�δ����µı���Imageʱ,���hObjectList,�����ڴ�û�б��ͷ�
        /// </summary>
        public void ClearHObjectList()
        {
            foreach (HObjectWithColor hObjectWithColor in hObjectList)
            {
                hObjectWithColor.HObject.Dispose();
            }

            hObjectList.Clear();
            HObjGroup = null;
            roiTextList.Clear();
        }

        /// <summary>
        /// ��hObjectList�е�HObject,�����Ⱥ�˳����ʾ����
        /// </summary>
        private void ShowHObjectList()
        {
            try
            {
                foreach (HObjectWithColor hObjectWithColor in hObjectList)
                {
                    if (hObjectWithColor.Color != null)
                    {
                        HOperatorSet.SetColor(ViewPort.HalconWindow, hObjectWithColor.Color);
                    }
                    else
                    {
                        HOperatorSet.SetColor(ViewPort.HalconWindow, "red");
                    }

                    if (hObjectWithColor != null && hObjectWithColor.HObject.IsInitialized())
                    {
                        ViewPort.HalconWindow.DispObj(hObjectWithColor.HObject);

                        //�ָ�Ĭ�ϵĺ�ɫ
                        HOperatorSet.SetColor(ViewPort.HalconWindow, "red");
                    }
                }

                foreach (HText roiText in roiTextList)
                {
                    ShowTool.SetFont(ViewPort.HalconWindow, roiText.size, roiText.font, "false", "false");
                    ShowTool.SetMsg(ViewPort.HalconWindow, roiText.text, "window", roiText.row, roiText.col, roiText.drawColor, "false");
                }
            }
            catch { }
        }

        public void ShowHObjectGroup()
        {
            if (HObjGroup == null) return;
            HOperatorSet.SetColored(ViewPort.HalconWindow, 12);
            ViewPort.HalconWindow.DispObj(HObjGroup);
        }

        #endregion
    }
}
