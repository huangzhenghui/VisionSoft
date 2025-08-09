using HalconDotNet;
using Plugin.CreateROI;
using Rex.UI;
using RexConst;
using RexControl.MyControls;
using RexView;
using RexView.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using VisionCore;
using static System.Net.Mime.MediaTypeNames;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace Plugin.AffineTrans
{
    public partial class AffineTransForm : FormBase
    {
        #region 字段、属性

        /// <summary>
        /// 模块对象
        /// </summary>
        AffineTransObj mObj;

        /// <summary>
        /// 计时器
        /// </summary>
        public HTimer timerObj = new HTimer();

        /// <summary>
        /// 耗时
        /// </summary>
        public double costTime = 0;

        #endregion

        #region 初始化

        /// <summary>
        /// 初始化
        /// </summary>
        /// <param name="Obj"></param>
        public AffineTransForm(AffineTransObj Obj) : base(Obj)
        {
            InitializeComponent();
            chx1Show.ForeColor = Color.FromArgb(100, 100, 100);
            chx2Show.ForeColor = Color.FromArgb(100, 100, 100);
            mObj = Obj;
        }

        #endregion

        #region 方法-窗口显示相关

        /// <summary>
        /// 窗口显示
        /// </summary>
        protected void FormDisplay()
        {
            ShowImage();
            ShowHObj();
        }

        /// <summary>
        /// 显示图像
        /// </summary>
        public void ShowImage()
        {
            //获取图像
            mObj.mImages = ldImage.TextInfo;
            if (mObj.mImages == "") return;
            mObj.mRImage = (RImage)Var.GetImage(mObj.mSloVar, mObj.mImages);

            //显示图像
            if (mObj.mRImage == null || !mObj.mRImage.IsInitialized()) return;
            mWindowH.HobjectToHimage(mObj.mRImage);

            //设置可绘制区域的大小
            HOperatorSet.SetSystem("width", 20000);
            HOperatorSet.SetSystem("height", 20000);

            return;
        }

        /// <summary>
        /// 显示输出HObject对象
        /// </summary>
        public void ShowOutputHObj()
        {
            try
            {
                switch (mObj.factor)
                {
                    case "图像":
                        //显示图像
                        mWindowH.ClearWindow();
                        if (mObj.affineTrans_Info.resultImg == null || !mObj.affineTrans_Info.resultImg.IsInitialized()) return;
                        mWindowH.HobjectToHimage(mObj.affineTrans_Info.resultImg);
                        break;
                    default:
                        //声明变量
                        HObject contours = new HObject();

                        //获取HObject
                        if (mObj.mRImage == null || !mObj.mRImage.IsInitialized()) return;
                        if (mObj.affineTrans_Info.resultObj == null || !mObj.affineTrans_Info.resultObj.IsInitialized()) return;
                        contours = mObj.affineTrans_Info.resultObj;

                        //显示HObject
                        HOperatorSet.SetLineWidth(mWindowH.HWindowHalconID, 1.45);
                        HOperatorSet.SetColored(mWindowH.HWindowHalconID, 12);
                        HOperatorSet.DispObj(contours, mWindowH.HWindowHalconID);
                        mWindowH.DispObj(contours);
                        break;
                }
            }
            catch { }
        }

        /// <summary>
        /// 显示输入HObject
        /// </summary>
        public void ShowInputHObj()
        {
            try
            {
                switch (mObj.factor)
                {
                    case "图像":
                        ShowImage();
                        break;
                    default:
                        if (mObj.mRImage == null || !mObj.mRImage.IsInitialized()) return;
                        if (mObj.inputHObj != null && mObj.inputHObj.IsInitialized())
                        {
                            HOperatorSet.SetColored(mWindowH.HWindowHalconID, 12);
                            HOperatorSet.DispObj(mObj.inputHObj, mWindowH.HWindowHalconID);
                            mWindowH.DispObj(mObj.inputHObj);
                        }
                        break;
                }

            }
            catch { }
        }

        /// <summary>
        /// 显示HObject对象
        /// </summary>
        public void ShowHObj()
        {
            switch (mObj.factor)
            {
                case "图像":
                    if (mObj.affineTrans_Info.resultImg != null && mObj.affineTrans_Info.resultImg.IsInitialized())
                    {
                        ShowOutputHObj();
                    }
                    else
                    {
                        ShowInputHObj();
                    }
                    break;
                default:
                    if (mObj.affineTrans_Info.resultObj != null && mObj.affineTrans_Info.resultObj.IsInitialized())
                    {
                        ShowOutputHObj();
                    }
                    else
                    {
                        ShowInputHObj();
                    }
                    break;
            }
        }

        #endregion

        #region 方法-对象保存加载相关

        /// <summary>
        /// 将窗体的值保存到模块对象中
        /// </summary>
        public override void FormToObj()
        {
            //tab1
            mObj.mImages = ldImage.TextInfo.Trim();
            mObj.matrixSource = cbxSource.Text;
            mObj.matrixType = cbxType.Text;
            mObj.strOldCol = ldOldX.TextInfo.Trim();
            mObj.strOldRow = ldOldY.TextInfo.Trim();
            mObj.strOldA = ldOldA.TextInfo.Trim();
            mObj.strAimCol = ldAimX.TextInfo.Trim();
            mObj.strAimRow = ldAimY.TextInfo.Trim();
            mObj.strAimA = ldAimA.TextInfo.Trim();
            mObj.strOffsetCol = ldOffsetX.TextInfo.Trim();
            mObj.strOffsetRow = ldOffsetY.TextInfo.Trim();
            mObj.strCenterCol = ldCenterX.TextInfo.Trim();
            mObj.strCenterRow = ldCenterY.TextInfo.Trim();
            mObj.strAngle = ldRotateA.TextInfo.Trim();
            mObj.strColScale = ldXScale.TextInfo.Trim();
            mObj.strColScale = ldYScale.TextInfo.Trim(); 
            mObj.strFixCol = ldFixPointX.TextInfo.Trim();
            mObj.strFixRow = ldFixPointY.TextInfo.Trim();
            mObj.matPath = tbxMatPath.Text.Trim();
            mObj.matLPath = tbxLMatPath.Text.Trim();
            mObj.matRPath = tbxRMatPath.Text.Trim();

            //tab2
            mObj.factor = cbxFactor.Text;
            switch (mObj.factor)
            {
                case "点位":
                    mObj.strPointCol = ldX.TextInfo.Trim();
                    mObj.strPointRow = ldY.TextInfo.Trim();
                    break;
                case "轮廓":
                    mObj.strInputHObj = ldContour.TextInfo.Trim();
                    break;
                case "区域":
                    mObj.strInputHObj = ldRegion.TextInfo.Trim();
                    break;
            }

            //Tab3
            switch (mObj.factor)
            {
                case "图像":
                    mObj.isShowReg = chx1Show.Checked;
                    break;
                default:
                    mObj.isShowReg = chx2Show.Checked;
                    break;
            }

            mObj.screenIndex = cbxSelectScreen.SelectedIndex;
            mObj.showColor = ColorTranslator.ToHtml(cpColor.Value);
            mObj.isSave = chxSave.Checked;
            mObj.savePath = tbxSavePath.Text.Trim();

            mObj.GetData();
        }

        /// <summary>
        /// 将模块对象中的值加载到窗体中
        /// </summary>
        public override void ObjToForm()
        {
            HTuple degOld = new HTuple();
            HTuple degAim = new HTuple();

            //Tab1
            ldImage.TextInfo = mObj.mImages;
            cbxSource.Text = mObj.matrixSource;
            cbxType.Text = mObj.matrixType;
            ldOldX.TextInfo = mObj.strOldCol;
            ldOldY.TextInfo = mObj.strOldRow;
            ldOldA.TextInfo = mObj.strOldA;
            ldAimX.TextInfo = mObj.strAimCol;
            ldAimY.TextInfo = mObj.strAimRow;
            ldAimA.TextInfo = mObj.strAimA;
            ldOffsetX.TextInfo = mObj.strOffsetCol;
            ldOffsetY.TextInfo = mObj.strOffsetRow;
            ldCenterX.TextInfo = mObj.strCenterCol;
            ldCenterY.TextInfo = mObj.strCenterRow;
            ldRotateA.TextInfo = mObj.strAngle;
            ldXScale.TextInfo = mObj.strColScale;
            ldYScale.TextInfo = mObj.strRowScale;
            ldFixPointX.TextInfo = mObj.strFixCol;
            ldFixPointY.TextInfo = mObj.strFixRow;
            tbxMatPath.Text = mObj.matPath;
            tbxLMatPath.Text = mObj.matLPath;
            tbxRMatPath.Text = mObj.matRPath;

            //Tab2
            cbxFactor.Text = mObj.factor;
            ldRegion.TextInfo = mObj.strInputHObj;
            ldContour.TextInfo = mObj.strInputHObj;
            ldX.TextInfo = mObj.strPointCol;
            ldY.TextInfo = mObj.strPointRow;

            //Tab3
            chx1Show.Checked = mObj.isShowReg;
            cbxSelectScreen.SelectedIndex = mObj.screenIndex;
            chx2Show.Checked = mObj.isShowReg;
            cpColor.Value = ColorTranslator.FromHtml(mObj.showColor);
            chxSave.Checked = mObj.isSave;
            tbxSavePath.Text = mObj.savePath;
        }

        #endregion

        #region 事件-按钮控件

        /// <summary>
        /// 执行
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public override void btn_Run_Click(object sender, EventArgs e)
        {
            FormToObj();

            timerObj.Start(); // 启动计时器
            mObj.RunObj();
            timerObj.Stop();  // 停止计时器

            ObjToForm();
            FormDisplay();

            costTime = timerObj.GetMilliSecond;
            lblTime.Text = "耗时:" + costTime.ToString("F2") + "ms";
        }

        /// <summary>
        /// 保存
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public override void btn_Save_Click(object sender, EventArgs e)
        {
            FormToObj();
        }

        /// <summary>
        /// 取消
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public override void btn_Cancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        /// <summary>
        /// 矩阵路径链接
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnMatPathLink_Click(object sender, EventArgs e)
        {
            OpenFileDialog fileDialog = new OpenFileDialog();
            fileDialog.Multiselect = true;
            fileDialog.Title = "请选择文件";
            fileDialog.Filter = "所有文件(*.*)|*.*";
            if (fileDialog.ShowDialog() == DialogResult.OK)
            {
                tbxMatPath.Text = fileDialog.FileName;
            }
        }

        /// <summary>
        /// 左矩阵路径链接
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnLMatPathLink_Click(object sender, EventArgs e)
        {
            OpenFileDialog fileDialog = new OpenFileDialog();
            fileDialog.Multiselect = true;
            fileDialog.Title = "请选择文件";
            fileDialog.Filter = "所有文件(*.*)|*.*";
            if (fileDialog.ShowDialog() == DialogResult.OK)
            {
                tbxLMatPath.Text = fileDialog.FileName;
            }
        }

        /// <summary>
        /// 右矩阵路径链接
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnRMatPathLink_Click(object sender, EventArgs e)
        {
            OpenFileDialog fileDialog = new OpenFileDialog();
            fileDialog.Multiselect = true;
            fileDialog.Title = "请选择文件";
            fileDialog.Filter = "所有文件(*.*)|*.*";
            if (fileDialog.ShowDialog() == DialogResult.OK)
            {
                tbxRMatPath.Text = fileDialog.FileName;
            }
        }

        /// <summary>
        /// 保存路径链接
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSavePathLink_Click(object sender, EventArgs e)
        {
            SaveFileDialog fileDialog = new SaveFileDialog();
            fileDialog.Title = "请选择文件";
            fileDialog.Filter = "所有文件(*.*)|*.*";
            if (fileDialog.ShowDialog() == DialogResult.OK)
            {
                tbxSavePath.Text = fileDialog.FileName;
            }
        }

        #endregion

        #region 事件-窗体控件

        /// <summary>
        /// 窗体加载
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void AffineTransForm_Load(object sender, EventArgs e)
        {
            switch (cbxType.Text)
            {
                case "九点标定":
                    pnl1.Visible = false;
                    pnl2.Visible = false;
                    pnl3.Visible = false;
                    pnl4.Visible = false;
                    pnl5.Visible = true;
                    pnl6.Visible = false;
                    cbxSource.SelectedIndex = 1;
                    cbxSource.ReadOnly = true;
                    cbxSource.RectColor = Color.DarkGray;
                    cbxFactor.SelectedIndex = 1;
                    cbxFactor.ReadOnly = true;
                    cbxFactor.RectColor = Color.DarkGray;
                    break;
                case "平移/旋转":
                    switch (cbxSource.Text)
                    {
                        case "参数创建":
                            pnl1.Visible = true;
                            pnl5.Visible = false;
                            break;
                        case "文件读取":
                            pnl1.Visible = false;
                            pnl5.Visible = true;
                            break;
                    }

                    pnl2.Visible = false;
                    pnl3.Visible = false;
                    pnl4.Visible = false;
                    pnl6.Visible = false;
                    cbxSource.ReadOnly = false;
                    cbxSource.RectColor = Color.CornflowerBlue;
                    cbxFactor.ReadOnly = false;
                    cbxFactor.RectColor = Color.CornflowerBlue;
                    break;
                case "平移":
                    switch (cbxSource.Text)
                    {
                        case "参数创建":
                            pnl2.Visible = true;
                            pnl5.Visible = false;
                            break;
                        case "文件读取":
                            pnl2.Visible = false;
                            pnl5.Visible = true;
                            break;
                    }

                    pnl1.Visible = false;
                    pnl3.Visible = false;
                    pnl4.Visible = false;
                    pnl6.Visible = false;
                    cbxSource.ReadOnly = false;
                    cbxSource.RectColor = Color.CornflowerBlue;
                    cbxFactor.ReadOnly = false;
                    cbxFactor.RectColor = Color.CornflowerBlue;
                    break;
                case "旋转":
                    switch (cbxSource.Text)
                    {
                        case "参数创建":
                            pnl3.Visible = true;
                            pnl5.Visible = false;
                            break;
                        case "文件读取":
                            pnl3.Visible = false;
                            pnl5.Visible = true;
                            break;
                    }

                    pnl1.Visible = false;
                    pnl2.Visible = false;
                    pnl4.Visible = false;
                    pnl6.Visible = false;
                    cbxSource.ReadOnly = false;
                    cbxSource.RectColor = Color.CornflowerBlue;
                    cbxFactor.ReadOnly = false;
                    cbxFactor.RectColor = Color.CornflowerBlue;
                    break;
                case "缩放":
                    switch (cbxSource.Text)
                    {
                        case "参数创建":
                            pnl4.Visible = true;
                            pnl5.Visible = false;
                            break;
                        case "文件读取":
                            pnl4.Visible = false;
                            pnl5.Visible = true;
                            break;
                    }

                    pnl1.Visible = false;
                    pnl2.Visible = false;
                    pnl3.Visible = false;
                    pnl6.Visible = false;
                    cbxSource.ReadOnly = false;
                    cbxSource.RectColor = Color.CornflowerBlue;
                    cbxFactor.ReadOnly = false;
                    cbxFactor.RectColor = Color.CornflowerBlue;
                    break;
                case "反转":
                    pnl1.Visible = false;
                    pnl2.Visible = false;
                    pnl3.Visible = false;
                    pnl4.Visible = false;
                    pnl5.Visible = true;
                    pnl6.Visible = false;
                    cbxSource.SelectedIndex = 1;
                    cbxSource.ReadOnly = true;
                    cbxSource.RectColor = Color.DarkGray;
                    cbxFactor.ReadOnly = false;
                    cbxFactor.RectColor = Color.CornflowerBlue;
                    break;
                case "相乘":
                    pnl1.Visible = false;
                    pnl2.Visible = false;
                    pnl3.Visible = false;
                    pnl4.Visible = false;
                    pnl5.Visible = false;
                    pnl6.Visible = true;
                    cbxSource.SelectedIndex = 1;
                    cbxSource.ReadOnly = true;
                    cbxSource.RectColor = Color.DarkGray;
                    cbxFactor.ReadOnly = false;
                    cbxFactor.RectColor = Color.CornflowerBlue;
                    break;
            }

            switch (cbxFactor.Text)
            {
                case "点位":
                    pnlPointInfo.Visible = true;
                    pnlRegionInfo.Visible = false;
                    pnlContourInfo.Visible = false;
                    pnl1Show.Visible = false;
                    pnl2Show.Visible = true;
                    break;
                case "区域":
                    pnlPointInfo.Visible = false;
                    pnlRegionInfo.Visible = true;
                    pnlContourInfo.Visible = false;
                    pnl1Show.Visible = false;
                    pnl2Show.Visible = true;
                    break;
                case "轮廓":
                    pnlPointInfo.Visible = false;
                    pnlRegionInfo.Visible = false;
                    pnlContourInfo.Visible = true;
                    pnl1Show.Visible = false;
                    pnl2Show.Visible = true;
                    break;
                default:
                    pnlPointInfo.Visible = false;
                    pnlRegionInfo.Visible = false;
                    pnlContourInfo.Visible = false;
                    pnl1Show.Visible = true;
                    pnl2Show.Visible = false;
                    break;
            }

            ShowImage();
            ShowHObj();
        }

        #endregion

        #region 事件-ComboBox控件

        /// <summary>
        /// 仿射对象选择改变
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cbxSelect_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (cbxFactor.Text)
            {
                case "点位":
                    pnlPointInfo.Visible = true;
                    pnlRegionInfo.Visible = false;
                    pnlContourInfo.Visible = false;
                    pnl1Show.Visible = false;
                    pnl2Show.Visible = true;
                    break;
                case "区域":
                    pnlPointInfo.Visible = false;
                    pnlRegionInfo.Visible = true;
                    pnlContourInfo.Visible = false;
                    pnl1Show.Visible = false;
                    pnl2Show.Visible = true;
                    break;
                case "轮廓":
                    pnlPointInfo.Visible = false;
                    pnlRegionInfo.Visible = false;
                    pnlContourInfo.Visible = true;
                    pnl1Show.Visible = false;
                    pnl2Show.Visible = true;
                    break;
                default:
                    pnlPointInfo.Visible = false;
                    pnlRegionInfo.Visible = false;
                    pnlContourInfo.Visible = false;
                    pnl1Show.Visible = true;
                    pnl2Show.Visible = false;
                    break;
            }
        }

        /// <summary>
        /// 矩阵类型选择改变
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cbxType_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (cbxType.Text)
            {
                case "九点标定":
                    pnl1.Visible = false;
                    pnl2.Visible = false;
                    pnl3.Visible = false;
                    pnl4.Visible = false;
                    pnl5.Visible = true;
                    pnl6.Visible = false;
                    cbxSource.SelectedIndex = 1;
                    cbxSource.ReadOnly = true;
                    cbxSource.RectColor = Color.DarkGray;
                    cbxFactor.SelectedIndex = 1;
                    cbxFactor.ReadOnly = true;
                    cbxFactor.RectColor = Color.DarkGray;
                    break;
                case "平移/旋转":
                    switch (cbxSource.Text)
                    {
                        case "参数创建":
                            pnl1.Visible = true;
                            pnl5.Visible = false;
                            break;
                        case "文件读取":
                            pnl1.Visible = false;
                            pnl5.Visible = true;
                            break;
                    }

                    pnl2.Visible = false;
                    pnl3.Visible = false;
                    pnl4.Visible = false;
                    pnl6.Visible = false;
                    cbxSource.ReadOnly = false;
                    cbxSource.RectColor = Color.CornflowerBlue;
                    cbxFactor.ReadOnly = false;
                    cbxFactor.RectColor = Color.CornflowerBlue;
                    break;
                case "平移":
                    switch (cbxSource.Text)
                    {
                        case "参数创建":
                            pnl2.Visible = true;
                            pnl5.Visible = false;
                            break;
                        case "文件读取":
                            pnl2.Visible = false;
                            pnl5.Visible = true;
                            break;
                    }

                    pnl1.Visible = false;
                    pnl3.Visible = false;
                    pnl4.Visible = false;
                    pnl6.Visible = false;
                    cbxSource.ReadOnly = false;
                    cbxSource.RectColor = Color.CornflowerBlue;
                    cbxFactor.ReadOnly = false;
                    cbxFactor.RectColor = Color.CornflowerBlue;
                    break;
                case "旋转":
                    switch (cbxSource.Text)
                    {
                        case "参数创建":
                            pnl3.Visible = true;
                            pnl5.Visible = false;
                            break;
                        case "文件读取":
                            pnl3.Visible = false;
                            pnl5.Visible = true;
                            break;
                    }
                    pnl1.Visible = false;
                    pnl2.Visible = false;
                    pnl4.Visible = false;
                    pnl6.Visible = false;
                    cbxSource.ReadOnly = false;
                    cbxSource.RectColor = Color.CornflowerBlue;
                    cbxFactor.ReadOnly = false;
                    cbxFactor.RectColor = Color.CornflowerBlue;
                    break;
                case "缩放":
                    switch (cbxSource.Text)
                    {
                        case "参数创建":
                            pnl4.Visible = true;
                            pnl5.Visible = false;
                            break;
                        case "文件读取":
                            pnl4.Visible = false;
                            pnl5.Visible = true;
                            break;
                    }
                    pnl1.Visible = false;
                    pnl2.Visible = false;
                    pnl3.Visible = false;
                    pnl6.Visible = false;
                    cbxSource.ReadOnly = false;
                    cbxSource.RectColor = Color.CornflowerBlue;
                    cbxFactor.ReadOnly = false;
                    cbxFactor.RectColor = Color.CornflowerBlue;
                    break;
                case "反转":
                    pnl1.Visible = false;
                    pnl2.Visible = false;
                    pnl3.Visible = false;
                    pnl4.Visible = false;
                    pnl5.Visible = true;
                    pnl6.Visible = false;
                    cbxSource.SelectedIndex = 1;
                    cbxSource.ReadOnly = true;
                    cbxSource.RectColor = Color.DarkGray;
                    cbxFactor.ReadOnly = false;
                    cbxFactor.RectColor = Color.CornflowerBlue;
                    break;
                case "相乘":
                    pnl1.Visible = false;
                    pnl2.Visible = false;
                    pnl3.Visible = false;
                    pnl4.Visible = false;
                    pnl5.Visible = false;
                    pnl6.Visible = true;
                    cbxSource.SelectedIndex = 1;
                    cbxSource.ReadOnly = true;
                    cbxSource.RectColor = Color.DarkGray;
                    cbxFactor.ReadOnly = false;
                    cbxFactor.RectColor = Color.CornflowerBlue;
                    break;
            }
        }

        /// <summary>
        /// 矩阵来源选择改变
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cbxSource_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (cbxSource.Text)
            {
                case "参数创建":
                    switch (cbxType.Text)
                    {
                        case "平移/旋转":
                            pnl1.Visible = true;
                            pnl2.Visible = false;
                            pnl3.Visible = false;
                            pnl4.Visible = false;
                            pnl5.Visible = false;
                            pnl6.Visible = false;
                            break;
                        case "平移":
                            pnl1.Visible = false;
                            pnl2.Visible = true;
                            pnl3.Visible = false;
                            pnl4.Visible = false;
                            pnl5.Visible = false;
                            pnl6.Visible = false;
                            break;
                        case "旋转":
                            pnl1.Visible = false;
                            pnl2.Visible = false;
                            pnl3.Visible = true;
                            pnl4.Visible = false;
                            pnl5.Visible = false;
                            pnl6.Visible = false;
                            break;
                        case "缩放":
                            pnl1.Visible = false;
                            pnl2.Visible = false;
                            pnl3.Visible = false;
                            pnl4.Visible = true;
                            pnl5.Visible = false;
                            pnl6.Visible = false;
                            break;
                    }
                    break;
                case "文件读取":
                    switch (cbxType.Text)
                    {
                        case "相乘":
                            pnl1.Visible = false;
                            pnl2.Visible = false;
                            pnl3.Visible = false;
                            pnl4.Visible = false;
                            pnl5.Visible = false;
                            pnl6.Visible = true;
                            break;
                        default:
                            pnl1.Visible = false;
                            pnl2.Visible = false;
                            pnl3.Visible = false;
                            pnl4.Visible = false;
                            pnl5.Visible = true;
                            pnl6.Visible = false;
                            break;
                    }
                    break;
            }
        }

        #endregion

        #region 事件-MyLinkData控件

        /// <summary>
        /// 图像链接
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ldImage_LinkData(object sender, EventArgs e)
        {
            PluginDataLinkForm LikeDataForm = new PluginDataLinkForm(mObj.ProjName, mObj.ModInfo.Name);
            LikeDataForm.dataType = "RImage";
            LikeDataForm.ShowDialog();
            if (LikeDataForm.m_OutLinkData.Length > 3)
            {
                string[] m_IntStr = LikeDataForm.m_OutLinkData.Split('|');
                ldImage.TextInfo = m_IntStr[0] + ":" + m_IntStr[1];
            }

            mObj.mImages = ldImage.TextInfo.Trim();
            ShowImage();
            ShowHObj();
        }

        /// <summary>
        /// 数据链接
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ldData_LinkData(object sender, EventArgs e)
        {
            MyLinkData myLinkData = sender as MyLinkData;
            PluginDataLinkForm LikeDataForm = new PluginDataLinkForm(mObj.ProjName, mObj.ModInfo.Name);
            switch (myLinkData.Name)
            {
                case "ldContour":
                    LikeDataForm.dataType = "HObject";
                    LikeDataForm.ShowDialog();
                    if (LikeDataForm.m_OutLinkData.Length > 3)
                    {
                        string[] m_IntStr = LikeDataForm.m_OutLinkData.Split('|');
                        ldContour.TextInfo = m_IntStr[0] + ":" + m_IntStr[1];
                    }
                    break;
                case "ldRegion":
                    LikeDataForm.dataType = "HObject";
                    LikeDataForm.ShowDialog();
                    if (LikeDataForm.m_OutLinkData.Length > 3)
                    {
                        string[] m_IntStr = LikeDataForm.m_OutLinkData.Split('|');
                        ldRegion.TextInfo = m_IntStr[0] + ":" + m_IntStr[1];
                    }
                    break;
                case "ldOldX":
                    LikeDataForm.dataType = "int" + "|" + "double" + "|" + "HTuple";
                    LikeDataForm.ShowDialog();
                    if (LikeDataForm.m_OutLinkData.Length > 3)
                    {
                        string[] m_IntStr = LikeDataForm.m_OutLinkData.Split('|');
                        ldOldX.TextInfo = m_IntStr[0] + ":" + m_IntStr[1];
                    }
                    break;
                case "ldOldY":
                    LikeDataForm.dataType = "int" + "|" + "double" + "|" + "HTuple";
                    LikeDataForm.ShowDialog();
                    if (LikeDataForm.m_OutLinkData.Length > 3)
                    {
                        string[] m_IntStr = LikeDataForm.m_OutLinkData.Split('|');
                        ldOldY.TextInfo = m_IntStr[0] + ":" + m_IntStr[1];
                    }
                    break;
                case "ldOldA":
                    LikeDataForm.dataType = "int" + "|" + "double" + "|" + "HTuple";
                    LikeDataForm.ShowDialog();
                    if (LikeDataForm.m_OutLinkData.Length > 3)
                    {
                        string[] m_IntStr = LikeDataForm.m_OutLinkData.Split('|');
                        ldOldA.TextInfo = m_IntStr[0] + ":" + m_IntStr[1];
                    }
                    break;
                case "ldAimX":
                    LikeDataForm.dataType = "int" + "|" + "double" + "|" + "HTuple";
                    LikeDataForm.ShowDialog();
                    if (LikeDataForm.m_OutLinkData.Length > 3)
                    {
                        string[] m_IntStr = LikeDataForm.m_OutLinkData.Split('|');
                        ldAimX.TextInfo = m_IntStr[0] + ":" + m_IntStr[1];
                    }
                    break;
                case "ldAimY":
                    LikeDataForm.dataType = "int" + "|" + "double" + "|" + "HTuple";
                    LikeDataForm.ShowDialog();
                    if (LikeDataForm.m_OutLinkData.Length > 3)
                    {
                        string[] m_IntStr = LikeDataForm.m_OutLinkData.Split('|');
                        ldAimY.TextInfo = m_IntStr[0] + ":" + m_IntStr[1];
                    }
                    break;
                case "ldAimA":
                    LikeDataForm.dataType = "int" + "|" + "double" + "|" + "HTuple";
                    LikeDataForm.ShowDialog();
                    if (LikeDataForm.m_OutLinkData.Length > 3)
                    {
                        string[] m_IntStr = LikeDataForm.m_OutLinkData.Split('|');
                        ldAimA.TextInfo = m_IntStr[0] + ":" + m_IntStr[1];
                    }
                    break;
                case "ldOffsetX":
                    LikeDataForm.dataType = "int" + "|" + "double" + "|" + "HTuple";
                    LikeDataForm.ShowDialog();
                    if (LikeDataForm.m_OutLinkData.Length > 3)
                    {
                        string[] m_IntStr = LikeDataForm.m_OutLinkData.Split('|');
                        ldOffsetX.TextInfo = m_IntStr[0] + ":" + m_IntStr[1];
                    }
                    break;
                case "ldOffsetY":
                    LikeDataForm.dataType = "int" + "|" + "double" + "|" + "HTuple";
                    LikeDataForm.ShowDialog();
                    if (LikeDataForm.m_OutLinkData.Length > 3)
                    {
                        string[] m_IntStr = LikeDataForm.m_OutLinkData.Split('|');
                        ldOffsetY.TextInfo = m_IntStr[0] + ":" + m_IntStr[1];
                    }
                    break;
                case "ldCenterX":
                    LikeDataForm.dataType = "int" + "|" + "double" + "|" + "HTuple";
                    LikeDataForm.ShowDialog();
                    if (LikeDataForm.m_OutLinkData.Length > 3)
                    {
                        string[] m_IntStr = LikeDataForm.m_OutLinkData.Split('|');
                        ldCenterX.TextInfo = m_IntStr[0] + ":" + m_IntStr[1];
                    }
                    break;
                case "ldCenterY":
                    LikeDataForm.dataType = "int" + "|" + "double" + "|" + "HTuple";
                    LikeDataForm.ShowDialog();
                    if (LikeDataForm.m_OutLinkData.Length > 3)
                    {
                        string[] m_IntStr = LikeDataForm.m_OutLinkData.Split('|');
                        ldCenterY.TextInfo = m_IntStr[0] + ":" + m_IntStr[1];
                    }
                    break;
                case "ldRotateA":
                    LikeDataForm.dataType = "int" + "|" + "double" + "|" + "HTuple";
                    LikeDataForm.ShowDialog();
                    if (LikeDataForm.m_OutLinkData.Length > 3)
                    {
                        string[] m_IntStr = LikeDataForm.m_OutLinkData.Split('|');
                        ldRotateA.TextInfo = m_IntStr[0] + ":" + m_IntStr[1];
                    }
                    break;
                case "ldXScale":
                    LikeDataForm.dataType = "int" + "|" + "double" + "|" + "HTuple";
                    LikeDataForm.ShowDialog();
                    if (LikeDataForm.m_OutLinkData.Length > 3)
                    {
                        string[] m_IntStr = LikeDataForm.m_OutLinkData.Split('|');
                        ldXScale.TextInfo = m_IntStr[0] + ":" + m_IntStr[1];
                    }
                    break;
                case "ldYScale":
                    LikeDataForm.dataType = "int" + "|" + "double" + "|" + "HTuple";
                    LikeDataForm.ShowDialog();
                    if (LikeDataForm.m_OutLinkData.Length > 3)
                    {
                        string[] m_IntStr = LikeDataForm.m_OutLinkData.Split('|');
                        ldYScale.TextInfo = m_IntStr[0] + ":" + m_IntStr[1];
                    }
                    break;
                case "ldFixPointX":
                    LikeDataForm.dataType = "int" + "|" + "double" + "|" + "HTuple";
                    LikeDataForm.ShowDialog();
                    if (LikeDataForm.m_OutLinkData.Length > 3)
                    {
                        string[] m_IntStr = LikeDataForm.m_OutLinkData.Split('|');
                        ldFixPointX.TextInfo = m_IntStr[0] + ":" + m_IntStr[1];
                    }
                    break;
                case "ldFixPointY":
                    LikeDataForm.dataType = "int" + "|" + "double" + "|" + "HTuple";
                    LikeDataForm.ShowDialog();
                    if (LikeDataForm.m_OutLinkData.Length > 3)
                    {
                        string[] m_IntStr = LikeDataForm.m_OutLinkData.Split('|');
                        ldFixPointY.TextInfo = m_IntStr[0] + ":" + m_IntStr[1];
                    }
                    break;
                case "ldX":
                    LikeDataForm.dataType = "int" + "|" + "int[]" + "|" + "double" + "|" + "double[]" + "|" + "HTuple";
                    LikeDataForm.ShowDialog();
                    if (LikeDataForm.m_OutLinkData.Length > 3)
                    {
                        string[] m_IntStr = LikeDataForm.m_OutLinkData.Split('|');
                        ldX.TextInfo = m_IntStr[0] + ":" + m_IntStr[1];
                    }
                    break;
                case "ldY":
                    LikeDataForm.dataType = "int" + "|" + "int[]" + "|" + "double" + "|" + "double[]" + "|" + "HTuple";
                    LikeDataForm.ShowDialog();
                    if (LikeDataForm.m_OutLinkData.Length > 3)
                    {
                        string[] m_IntStr = LikeDataForm.m_OutLinkData.Split('|');
                        ldY.TextInfo = m_IntStr[0] + ":" + m_IntStr[1];
                    }
                    break;
            }
        }

        #endregion
    }
}
