using System;
using System.ComponentModel;
using System.Windows.Forms;
using HalconDotNet;
using RexConst;
using System.Diagnostics;
using System.IO;
using System.Collections.Generic;
using System.Globalization;
using System.Drawing;

namespace RexView
{
    public enum ShowDraw
    {
        margin,
        fill
    }

    /// <summary>
    /// 窗口控件
    /// </summary>
    public partial class HWindow_HE : UserControl
    {
        #region 私有变量定义.
        private HWindow /**/                 hv_window;                      //halcon窗体控件的句柄 this.mCtrl_HWindow.HalconWindow;
        private ContextMenuStrip /**/        hv_MenuStrip;                   //右键菜单控件
        // 窗体控件右键菜单内容
        ToolStripMenuItem fit_strip;//自适应
        ToolStripMenuItem saveImg_strip;//保存图像
        ToolStripMenuItem saveWindow_strip;//保存截图
        ToolStripMenuItem barVisible_strip;//显示状态
        ToolStripMenuItem blnCross_strip;//显示十字
        ToolStripMenuItem histogram_strip;
        public HImage  /**/                 hv_image;                      //缩放时操作的图片  此处千万不要使用hv_image = new HImage(),不然在生成控件dll的时候,会导致无法序列化
        public int /**/                     hv_imageWidth, hv_imageHeight; //图片宽,高
        public string /**/                  str_imgSize;                   //图片尺寸大小 5120X3840
        public bool    /**/                 drawModel = false;             //绘制模式下,不允许缩放和鼠标右键菜单
        #endregion
        public ViewWindow WindowH;  
        public HWindowControl hControl;  
        public double positionX, positionY;

        [Description("双击事件"), Category("自定义")]
        public event EventHandler DoubleClickEvent;

        [Description("鼠标滚动事件"), Category("自定义")]

        public static bool IsDesignMode()
        {
            bool returnFlag = false;
            return returnFlag;
        }

        public ShowDraw draw;
        [Description("显示形态"), Category("自定义")]
        [DefaultValue(ShowDraw.margin)]
        public ShowDraw Draw
        {
            get
            {
                return draw;
            }

            set
            {
                draw = value;
            }
        }

        /// <summary>
        /// 初始化控件
        /// </summary>
        public HWindow_HE()
        {
            InitializeComponent();
            WindowH = new ViewWindow(mCtrl_HWindow);
            hControl = this.mCtrl_HWindow;
            if (LicenseManager.UsageMode == LicenseUsageMode.Designtime)
            {
                return;
            }

            hv_window = this.mCtrl_HWindow.HalconWindow;
            fit_strip = new ToolStripMenuItem("适应图像显示");
            fit_strip.Click += new EventHandler((s, e) => DispImageFit(mCtrl_HWindow));
            barVisible_strip = new ToolStripMenuItem("显示图像信息");
            barVisible_strip.CheckOnClick = true;
            barVisible_strip.CheckedChanged += new EventHandler(barVisible_strip_CheckedChanged);
            blnCross_strip = new ToolStripMenuItem("显示隐藏十字");
            blnCross_strip.CheckOnClick = true;
            m_CtrlHStatusLabelCtrl.Visible = true;
            m_CtrlHStatusLabelCtrl.Text = "W:--,H:--" + "    " + "X:--,Y:--" + "    " + "Val:--";
            mCtrl_HWindow.Height = this.Height;
            saveImg_strip = new ToolStripMenuItem("保存原始图像");
            saveImg_strip.Click += new EventHandler((s, e) => SaveImage());
            saveWindow_strip = new ToolStripMenuItem("保存缩略图像");
            saveWindow_strip.Click += new EventHandler((s, e) => SaveWindowDump());
            histogram_strip = new ToolStripMenuItem("显示直方图(H)");
            histogram_strip.CheckOnClick = true;
            histogram_strip.Checked = false;
            hv_MenuStrip = new ContextMenuStrip();
            hv_MenuStrip.Items.Add(fit_strip);
            hv_MenuStrip.Items.Add(barVisible_strip);
            hv_MenuStrip.Items.Add(blnCross_strip);
            hv_MenuStrip.Items.Add(new ToolStripSeparator());
            hv_MenuStrip.Items.Add(saveImg_strip);
            hv_MenuStrip.Items.Add(saveWindow_strip);
            barVisible_strip.Enabled = true;
            fit_strip.Enabled = false;
            histogram_strip.Enabled = false;
            saveImg_strip.Enabled = false;
            saveWindow_strip.Enabled = false;
            mCtrl_HWindow.ContextMenuStrip = hv_MenuStrip;
            mCtrl_HWindow.SizeChanged += new EventHandler((s, e) => DispImageFit(mCtrl_HWindow));
        }

        /// <summary>
        /// 绘制模式下,不允许缩放和鼠标右键菜单
        /// </summary>
        public bool DrawModel
        {
            get { return drawModel; }
            set
            {
                //缩放控制
                WindowH.SetDrawModel(value);
                //绘制模式 不现实右键
                if (value == true)
                {
                    mCtrl_HWindow.ContextMenuStrip = null;
                }
                else
                {
                    //恢复
                    mCtrl_HWindow.ContextMenuStrip = hv_MenuStrip;
                }
                drawModel = value;
            }
        }

        /// <summary>
        /// 设置image,初始化控件参数
        /// </summary>
        public HImage Image
        {
            get { return this.hv_image; }
            set
            {
                if (value != null)
                {
                    if (this.hv_image != null)
                    {
                        this.hv_image.Dispose();
                    }
                    this.hv_image = value;
                    hv_image.GetImageSize(out hv_imageWidth, out hv_imageHeight);
                    str_imgSize = String.Format("W:{0},H:{1}", hv_imageWidth, hv_imageHeight);
                    try
                    {
                        barVisible_strip.Enabled = true;
                        fit_strip.Enabled = true;
                        histogram_strip.Enabled = true;
                        saveImg_strip.Enabled = true;
                        saveWindow_strip.Enabled = true;
                    }
                    catch (Exception)
                    {
                    }
                    WindowH.DisplayImage(hv_image);
                    PaintCross();
                }
            }
        }

        /// <summary>
        /// 获得halcon窗体控件的句柄
        /// </summary>
        public HTuple HWindowHalconID
        {
            get { return this.mCtrl_HWindow.HalconWindow; }
        }
        public HWindowControl getHWindowControl()
        {
            return this.mCtrl_HWindow;
        }

        private void PaintCross()
        {
            if (blnCross_strip.Checked)
            {
                //显示十字线
                HXLDCont xldCross = new HXLDCont();
                mCtrl_HWindow.HalconWindow.SetColor("green");
                HRegion hRegion = new HRegion(0, 0, (HTuple)hv_imageHeight, (HTuple)hv_imageWidth);
                HOperatorSet.AreaCenter(hRegion, out HTuple _Area, out HTuple _ROW, out HTuple _COL);
                _ROW = hv_imageHeight / 2;
                _COL = hv_imageWidth / 2;
                //小十字
                mCtrl_HWindow.HalconWindow.DispLine(_ROW - 5, _COL, _ROW + 5, _COL);
                mCtrl_HWindow.HalconWindow.DispLine(_ROW, _COL - 5, _ROW, _COL + 5);
                //大十字-横
                mCtrl_HWindow.HalconWindow.DispLine((double)_ROW, (double)_COL + 50, (double)_ROW, (double)_COL * 2);
                mCtrl_HWindow.HalconWindow.DispLine((double)_ROW, 0, (double)_ROW, (double)_COL - 50);
                //大十字-竖
                mCtrl_HWindow.HalconWindow.DispLine(0, (double)_COL, (double)_ROW - 50, (double)_COL);
                mCtrl_HWindow.HalconWindow.DispLine((double)_ROW+50, (double)_COL, (double)_ROW*2, (double)_COL);
            }
        }

        /// <summary>
        /// 状态条 显示/隐藏 CheckedChanged事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void barVisible_strip_CheckedChanged(object sender, EventArgs e)
        {
            ToolStripMenuItem strip = sender as ToolStripMenuItem;
            this.SuspendLayout();
            if (strip.Checked)
            {
                m_CtrlHStatusLabelCtrl.Visible = true;
                mCtrl_HWindow.HMouseMove += HWindowControl_HMouseMove;
            }
            else
            {
                m_CtrlHStatusLabelCtrl.Visible = false;
                mCtrl_HWindow.HMouseMove -= HWindowControl_HMouseMove;
            }
            this.ResumeLayout(false);
            this.PerformLayout();
        }
        public void showStatusBar()
        {
            barVisible_strip.Checked = true;
        }
        /// <summary>
        /// 保存窗体截图到本地
        /// </summary>
        private void SaveWindowDump()
        {
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Filter = "PNG图像|*.png|BMP图像|*.bmp|JPG图像|*.jpg";//|所有文件|*.*
            sfd.FilterIndex = 1;
            if (sfd.ShowDialog() == DialogResult.OK)
            {
                if (string.IsNullOrEmpty(sfd.FileName)) { return; }
                HOperatorSet.DumpWindow(hv_window, Path.GetExtension(sfd.FileName).Replace(".", ""), sfd.FileName);//截取窗口图 
            }
        }
        /// <summary>
        /// 保存原始图片到本地
        /// </summary>
        private void SaveImage()
        {
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Filter = "PNG图像|*.png|BMP图像|*.bmp|JPG图像|*.jpg";//|所有文件|*.*
            sfd.FilterIndex = 1;
            if (sfd.ShowDialog() == DialogResult.OK)
            {
                if (string.IsNullOrEmpty(sfd.FileName)) { return; }
                FileInfo _FileInfo = new FileInfo(sfd.FileName);
                HOperatorSet.WriteImage(hv_image, Path.GetExtension(sfd.FileName).Replace(".", ""), 0, sfd.FileName);

            }
        }
        /// <summary>
        /// 图片适应大小显示在窗体
        /// </summary>
        /// <param name="hw_Ctrl">halcon窗体控件</param>
        private void DispImageFit(HWindowControl hw_Ctrl)
        {
            try
            {
                this.WindowH.ResetWindowImage();
                PaintCross();
            }
            catch { }
        }

        /// <summary>
        /// 鼠标在空间窗体里滑动,显示鼠标所在位置的灰度值
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void HWindowControl_HMouseMove(object sender, HMouseEventArgs e)
        {
            if (hv_image != null)
            {
                try
                {
                    PaintCross();
                    string str_value;
                    HOperatorSet.CountChannels(hv_image, out HTuple channel_count);
                    hv_window.GetMpositionSubPix(out positionY, out positionX, out int button_state);
                    string str_position = string.Format("X: {0:0000}, Y: {1:0000}", positionX, positionY);
                    bool _isXOut = (positionX < 0 || positionX >= hv_imageWidth);
                    bool _isYOut = (positionY < 0 || positionY >= hv_imageHeight);
                    if (!_isXOut && !_isYOut)
                    {
                        if (channel_count == 1)
                        {
                            double grayVal = hv_image.GetGrayval((int)positionY, (int)positionX);
                            str_value = string.Format("Val: {0:000.0}", grayVal);
                        }
                        else if (channel_count == 3)
                        {
                            HImage _RedChannel = hv_image.AccessChannel(1);
                            HImage _GreenChannel = hv_image.AccessChannel(2);
                            HImage _BlueChannel = hv_image.AccessChannel(3);
                            double grayValRed = _RedChannel.GetGrayval((int)positionY, (int)positionX);
                            double grayValGreen = _GreenChannel.GetGrayval((int)positionY, (int)positionX);
                            double grayValBlue = _BlueChannel.GetGrayval((int)positionY, (int)positionX);
                            _RedChannel.Dispose();
                            _GreenChannel.Dispose();
                            _BlueChannel.Dispose();
                            str_value = String.Format("|  {0:000.0}, {1:000.0}, {2:000.0}", "R:" + grayValRed, "G:" + grayValGreen, "B:" + grayValBlue);
                        }
                        else
                        {
                            str_value = "";
                        }
                        m_CtrlHStatusLabelCtrl.Text = str_imgSize + "    " + str_position + "    " + str_value;
                    }

                }
                catch { }
            }
            else
            {
                m_CtrlHStatusLabelCtrl.Text = "W:--,H:--" + "    " + "X:--,Y:--" + "    " + "Val:--";
            }
        }

        public void ClearWindow()
        {
            try
            {
                this.Invoke(new Action(() =>
                        {
                            barVisible_strip.Enabled = false;
                            fit_strip.Enabled = false;
                            saveImg_strip.Enabled = false;
                            saveWindow_strip.Enabled = false;
                            WindowH.ClearWindow();
                            PaintCross();
                        }));
            }
            catch { }
        }

        /// <summary>
        /// Hobject转换为的临时Himage,显示背景图
        /// </summary>
        /// <param name="hobject">传递Hobject,必须为图像</param>
        public void HobjectToHimage(HObject hobject)
        {
            m_CtrlHStatusLabelCtrl.Visible = true;
            ClearWindow();
            if (hobject == null || !hobject.IsInitialized()) return;
            Image = new HImage(hobject);
        }

        #region 缩放后,再次显示传入的HObject

        /// <summary>
        /// 默认红颜色显示
        /// </summary>
        /// <param name="hObj">传入的region.xld,image</param>

        public void DispObj(HObject hObj)
        {
            lock (this)
            {
                WindowH._hWndControl.showDraw = Draw.ToString();
                WindowH.DispHobjGroup(hObj);
            }
        }

        /// <summary>
        /// 重新开辟内存保存 防止被传入的HObject在其他地方dispose后,不能重现
        /// </summary>
        /// <param name="hObj">传入的region.xld,image</param>
        /// <param name="color">颜色</param>
        public void DispObj(HObject hObj, string color)
        {
            lock (this)
            {
                WindowH._hWndControl.showDraw = Draw.ToString();
                WindowH.DispHobject(hObj, color);
            }
        }

        #endregion

        /// <summary>
        /// 鼠标离开事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void mCtrl_HWindow_MouseLeave(object sender, EventArgs e)
        {
            //避免鼠标离开窗口,再返回的时候,图表随着鼠标移动
            WindowH.Mouseleave();
        }

        /// <summary>
        /// 显示图像
        /// </summary>
        /// <param name="he"></param>
        public void ShowHImage(RImage hobject)
        {
            try
            {
                HTuple width = new HTuple();
                HTuple height = new HTuple();

                if (hobject == null) return;
                WindowH.ClearWindow();
                WindowH._hWndControl.showDraw = Draw.ToString();
                HobjectToHimage(hobject);

                foreach (HRoi roi in hobject.mHRoi)
                {
                    if (roi != null)
                    {
                        lock (this)
                        {
                            WindowH.DispHobject(roi.hobject, roi.drawColor);
                        }
                    }
                    else
                    {
                        if (roi != null && roi.hobject.IsInitialized())
                        {
                            DispObj(roi.hobject, roi.drawColor);
                        }
                    }
                }

                foreach (HText roi in hobject.mHText)
                {
                    if (roi != null && roi.roiType == HRoiType.文字显示)
                    {
                        lock (this)
                        {
                            WindowH.DispText(roi);
                        }
                    }
                    else
                    {
                        if (roi != null && roi.hobject.IsInitialized())
                        {
                            DispObj(roi.hobject, roi.drawColor);
                        }
                    }
                }
            }
            catch { }
        }
    }
}
