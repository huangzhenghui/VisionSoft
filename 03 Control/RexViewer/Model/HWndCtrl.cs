using HalconDotNet;
using RexConst;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace RexView
{
    #region 委托

    public delegate void FuncDelegate();
    public delegate void IconicDelegate(int val);

    #endregion

    /// <summary>
    ///这个类作为HALCON窗口的包装类,负责可视化
    /// </summary>
    public class HWndCtrl
    {
        #region 字段、属性

        /// <summary>
        /// 显示ROI
        /// </summary>
        public const int MODE_INCLUDE_ROI = 1;

        /// <summary>
        /// 不显示ROI
        /// </summary>
		public const int MODE_EXCLUDE_ROI = 2;

        /// <summary>
        /// 对鼠标事件不执行任何操作
        /// </summary>
        public const int MODE_VIEW_NONE = 10;

        /// <summary>
        /// 缩放在鼠标事件上执行
        /// </summary>
        public const int MODE_VIEW_ZOOM = 11;

        /// <summary>
        /// 在鼠标事件上执行移动
        /// </summary>
        public const int MODE_VIEW_MOVE = 12;

        /// <summary>
        /// 对鼠标事件进行放大
        /// </summary>
        public const int MODE_VIEW_ZOOMWINDOW = 13;

        /// <summary>
        /// 擦除
        /// </summary>
        public const int MODE_ERASER = 14;

        /// <summary>
        /// 喷涂
        /// </summary>
        public const int MODE_PAINT = 15;

        /// <summary>
        /// 设置ROI模式的常数:ROI正符号
        /// </summary>
        public const int MODE_ROI_POS = 21;

        /// <summary>
        /// 设置ROI模式的常数:负的ROI符号
        /// </summary>
        public const int MODE_ROI_NEG = 22;

        /// <summary>
        /// 设置ROI模式的常数:没有模型区域计算为所有ROI对象的总和
        /// </summary>
        public const int MODE_ROI_NONE = 23;

        /// <summary>
        /// 描述为新图像发出信号的委托消息
        /// </summary>
        public const int EVENT_UPDATE_IMAGE = 31;

        /// <summary>
        /// 常量描述从文件中读取图像时发出错误信号的委托消息 
        /// </summary>
        public const int ERR_READING_IMG = 32;

        /// <summary>
        /// 常量在定义图形上下文时，将委托消息描述为信号错误
        /// </summary>
        public const int ERR_DEFINING_GC = 33;

        /// <summary>
        /// 描述模型区域更新的常数
        /// </summary>
        public const int EVENT_UPDATE_ROI = 50;
        public const int EVENT_CHANGED_ROI_SIGN = 51;

        /// <summary>
        /// 描述模型区域更新的常数
        /// </summary>
        public const int EVENT_MOVING_ROI = 52;
        public const int EVENT_DELETED_ACTROI = 53;
        public const int EVENT_DELETED_ALL_ROIS = 54;
        public const int EVENT_ACTIVATED_ROI = 55;
        public const int EVENT_CREATED_ROI = 56;

        /// <summary> 
        /// 可以放置在图形上的HALCON对象的最大数量,堆栈不丢失
        /// </summary>
        private const int MAXNUMOBJLIST = 50;

        /// <summary>
        /// 对窗体的操作状态
        /// </summary>
        private int ViewState;

        /// <summary>
        /// 鼠标是否按下
        /// </summary>
        private bool MousePressed = false;

        /// <summary>
        /// 起始点X、Y
        /// </summary>
        private double StartX, StartY;

        /// <summary>
        /// HALCON窗口
        /// </summary>
        public HWindowControl ViewPort;

        /// <summary>
        /// ROIController的实例
        /// </summary>
        private ROIController ROIManager;

        /// <summary>
        /// 显示ROI
        /// </summary>
        private int DispROI;

        /// <summary>
        /// 是否绘制
        /// </summary>
        public bool drawModel = false;

        /// <summary>
        /// 窗体宽度
        /// </summary>
        public int WindowWidth;

        /// <summary>
        /// 窗体高度
        /// </summary>
        public int WindowHeight;

        /// <summary>
        /// 图像宽度
        /// </summary>
        public int ImageWidth;

        /// <summary>
        /// 图像高度
        /// </summary>
        public int ImageHeight;

        /// <summary> 
        /// 图像坐标，用于描述HALCON窗口中显示的图像部分 
        /// </summary>
        private double ImgRow1, ImgCol1, ImgRow2, ImgCol2;

        /// <summary>
        /// 抛出异常时的错误消息
        /// </summary>
        public string ExceptionText = "";

        /// <summary>
        /// 委托发送通知消息到其他类 
        /// </summary>
        public FuncDelegate AddInfoDelegate;

        /// <summary>
        /// 通知HWndCtrl实例的失败任务 
        /// </summary>
        public IconicDelegate NotifyIconObserver;

        /// <summary>
        /// Halcon窗口
        /// </summary>
        private HWindow ZoomWindow;

        /// <summary> 
        /// 缩放操作
        /// </summary>
        private double ZoomWndFactor, ZoomAddOn;

        /// <summary>
        /// 缩放尺寸
        /// </summary>
        private int ZoomWndSize;

        /// <summary> 
        /// 绘制到HALCON窗口的HALCON对象列表 
        /// </summary>
        private ArrayList HObjImageList;

        /// <summary>
        /// 用于描述图形上下文的实例
        /// </summary>
        private GraphicsContext mGC;

        /// <summary>
        /// HObjectEntry对象列表
        /// </summary>
        public List<HObjectEntry> HObjList;

        /// <summary>
        /// HObjectWithColor对象列表
        /// </summary>
        private List<HObjectWithColor> hObjectList = new List<HObjectWithColor>();

        /// <summary>
        /// HObj组
        /// </summary>
        public HObject HObjGroup;

        /// <summary>
        /// HText对象列表
        /// </summary>
        private List<HText> roiTextList = new List<HText>();

        /// <summary>
        /// 显示形态
        /// </summary>
        public string showDraw = "margin";

        /// <summary>
        /// 是否适应窗体
        /// </summary>
        public bool isFitWindow = true;

        #endregion

        #region 初始化

        /// <summary>
        /// 初始化
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

        #region 事件-Halcon窗口控件

        /// <summary>
        /// MouseWheel事件
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
        /// MouseDown事件
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
        /// 鼠标抬起事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void MouseUp(object sender, HMouseEventArgs e)
        {
            //关闭缩放事件
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
        /// 鼠标移动事件
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
            else if (ViewState == MODE_VIEW_MOVE)//平移图像
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
            else if (ViewState == MODE_VIEW_ZOOMWINDOW)//局部放大
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

        #region 方法-Halcon窗口控件相关

        /// <summary>
        /// 根据图像大小，右上角和右下角
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
        /// 设置HALCON窗口中的鼠标事件的视图模式(缩放，移动或无)
        /// </summary>
        /// <param name="mode"></param>
        public void SetViewState(int mode)
        {
            ViewState = mode;
            if (ROIManager != null)
                ROIManager.ResetROI();
        }

        /// <summary>
        /// 异常信息
        /// </summary>
        /// <param name="message"></param>
        private void ExceptionGC(string message)
        {
            ExceptionText = message;
            NotifyIconObserver(ERR_DEFINING_GC);
        }

        /// <summary>
        ///重置相关参数
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
        /// 缩放图像
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
                //超过一定缩放比例就不在缩放
                ResetWindow();
                return;
            }
            if (ZoomWndFactor > 5 && _zoomWndFactor > ZoomWndFactor)
            {
                //超过一定缩放比例就不在缩放
                ResetWindow();
                return;
            }
            ZoomWndFactor = _zoomWndFactor;

            Repaint();
        }

        /// <summary>
        /// 移动图像
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
        /// 缩放
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
        /// 自适应窗口
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

            //缩放比例为1
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
        /// 鼠标离开事件，鼠标离开窗口再返回时,图表随着鼠标移动
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
        /// 重新显示窗体内容(图像+区域)
        /// </summary>
        public void Repaint()
        {
             Repaint(ViewPort.HalconWindow);
        }

        /// <summary>
        /// 重新显示窗体内容(图像+区域)
        /// </summary>
        /// <param name="window">Halcon窗口</param>
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

                //显示图片
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

                //显示region
                ShowHObjectList();
                ShowHObjectGroup();
                if (ROIManager != null && (DispROI == MODE_INCLUDE_ROI))
                {
                    ROIManager.PaintData(window, entry.HObj);
                }
                HSystem.SetSystem("flush_graphic", "true");

                //注释了下面语句,会导致窗口无法实现缩放和拖动
                window.SetColor("#" + string.Format(ViewPort.BorderColor.R.ToString("x2") + ViewPort.BorderColor.G.ToString("x2") + ViewPort.BorderColor.B.ToString("x2")));
                window.DispLine(-100.0, -100.0, -101.0, -101.0);
            }
            catch { }
        }

        /// <summary>
        /// 添加设定显示的图像
        /// </summary>
        /// <param name="img"></param>
        public void AddIconicVar(HObject img)
        {
            //先把HObjImageList给全部释放了,源代码 会出现内存泄漏问题
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

            //每当传入背景图的时候 都清空HObjectList
            ClearHObjectList();
            if (HObjImageList.Count > MAXNUMOBJLIST)
            {
                //需要自己手动释放
                ((HObjectEntry)HObjImageList[0]).Clear();
                HObjImageList.RemoveAt(1);
            }
        }

        /// <summary>
        /// 清除图像列表
        /// </summary>
        public void ClearList()
        {
            HObjImageList.Clear();
        }

        /// <summary>
        /// 为ROIController对象设置HWndCtrl对象
        /// </summary>
        /// <param name="rC"></param>
        protected internal void SetROIController(ROIController rC)
        {
            ROIManager = rC;
            rC.SetViewController(this);
            SetViewState(HWndCtrl.MODE_VIEW_NONE);
        }

        /// <summary>
        /// 添加设定显示的图像
        /// </summary>
        /// <param name="image"></param>
        protected internal void addImageShow(HObject image)
        {
            AddIconicVar(image);
        }

        /// <summary>
        /// 显示HObject对象
        /// </summary>
        /// <param name="hObj"></param>
        /// <param name="color"></param>
        public void DispObj(HObject hObj, string color)
        {
            lock (this)
            {
                try
                {
                    //显示指定的颜色
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

                    //恢复默认的红色
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
        /// 显示HText对象
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
        /// 每次传入新的背景Image时,清空hObjectList,避免内存没有被释放
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
        /// 将hObjectList中的HObject,按照先后顺序显示出来
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

                        //恢复默认的红色
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
