using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using VisionCore;
using System.Diagnostics;
using RexConst;
using RexHelps;
using Rex.UI;
using RexView;
using System.Windows.Forms;
using HalconDotNet;
using System.Security.Cryptography;
using System.Drawing;
using RexControl.MyControls;
using static System.Net.Mime.MediaTypeNames;
using RexControl;

namespace Plugin.CreateROI
{ 
    public partial class CreateROIForm : FormBase
    {
        #region 字段、属性

        /// <summary>
        /// 模块对象
        /// </summary>
        CreateROIObj mObj;

        /// <summary> 
        /// 区域列表 
        /// </summary>
        Dictionary<string, ROI> mRoiList = new Dictionary<string, ROI>();

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
        public CreateROIForm(CreateROIObj Obj) : base(Obj)
        {
            InitializeComponent();
            mObj = Obj;
            mWindowH.hControl.MouseUp += Hwindow_MouseUp;

            chxShowROI.ForeColor = Color.FromArgb(100, 100, 100);
            btnFitImg.FillColor = Color.AliceBlue;
            btnFitImg.RectColor = Color.AliceBlue;
            btnFitImg.ForeColor = Color.FromArgb(100, 100, 100);
            btnFitImg.ForeHoverColor = Color.FromArgb(100, 100, 100);
            btnFitImg.ForePressColor = Color.FromArgb(100, 100, 100);
            btnFitImg.FillHoverColor = Color.LightBlue;
            btnFitImg.FillPressColor = Color.LightBlue;
            btnFitImg.RectPressColor = Color.LightBlue;
            btnFitImg.RectHoverColor = Color.LightBlue;
            cbxInterfaceMode.Text = "编辑状态";
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
        }

        /// <summary>
        /// 显示HObject对象
        /// </summary>
        public void ShowHObj()
        {
            if (mObj.mRImage == null || !mObj.mRImage.IsInitialized()) return;
            mWindowH.HobjectToHimage(mObj.mRImage);

            HOperatorSet.SetSystem("width", 20000);
            HOperatorSet.SetSystem("height", 20000);

            if (cbxInterfaceMode.SelectedText == "编辑状态")
            {
                switch (mObj.mROIType)
                {
                    case ROIType.Rectangle2:
                        mWindowH.WindowH.DispROI(mObj.ModInfo.Name + ROIType.Rectangle2, mRoiList[mObj.ModInfo.Name + ROIType.Rectangle2]);
                        break;
                    case ROIType.Circle:
                        mWindowH.WindowH.DispROI(mObj.ModInfo.Name + ROIType.Circle, mRoiList[mObj.ModInfo.Name + ROIType.Circle]);
                        break;
                }
            }
            else
            {
                //绘制显示图形
                mWindowH.HobjectToHimage(mObj.mRImage);
                if (!CreateROIObj.regCopy.IsInitialized()) return;
                HObject hObj = CreateROIObj.regCopy.Clone();
                HOperatorSet.SetColor(mWindowH.HWindowHalconID, mObj.resultColor);
                HOperatorSet.DispObj(hObj, mWindowH.HWindowHalconID);
                mWindowH.DispObj(hObj, mObj.resultColor);
            }
        }

        /// <summary>
        /// 初始化ROI参数
        /// </summary>
        public void InitVar()
        {
            HTuple width = new HTuple();
            HTuple height = new HTuple();
            HOperatorSet.GetImageSize(mObj.mRImage, out width, out height);
            mObj.strCenterRow = (height / 2).ToString();
            mObj.strCenterCol = (width / 2).ToString();
            mObj.strPhi = "0";
            mObj.strLength1 = (width / 8).ToString();
            mObj.strLength2 = (height / 8).ToString();
            mObj.strRadius = (width / 8).ToString();

            mObj.GetData();
            ObjToForm();
        }

        /// <summary>
        /// 生成ROI
        /// </summary>
        public void GenROI()
        {
            //加载时生成ROI
            ShowImage();
            if (mObj.mRImage == null || !mObj.mRImage.IsInitialized()) return;
            switch (mObj.mROIType)
            {
                case ROIType.Rectangle2:
                    mWindowH.WindowH.GenRect2(mObj.ModInfo.Name + ROIType.Rectangle2, mObj.centerRow, mObj.centerCol, mObj.phi.TupleRad(), mObj.length1, mObj.length2, ref mRoiList, mObj.ROIEditColor);
                    break;
                case ROIType.Circle:
                    mWindowH.WindowH.GenCircle(mObj.ModInfo.Name + ROIType.Circle, mObj.centerRow, mObj.centerCol, mObj.radius, ref mRoiList, mObj.ROIEditColor);
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
            mObj.mImages = ldImage.TextInfo;
            switch (cbxROIShape.SelectedText)
            {
                case "矩形":
                    mObj.mROIType = ROIType.Rectangle2;
                    mObj.strCenterRow = ldRect2CenterY.TextInfo.Trim();
                    mObj.strCenterCol = ldRect2CenterX.TextInfo.Trim();
                    mObj.strPhi = ldRect2Phi.TextInfo.Trim();
                    mObj.strLength1 = ldRect2Length1.TextInfo.Trim();
                    mObj.strLength2 = ldRect2Length2.TextInfo.Trim();
                    break;
                case "圆形":
                    mObj.mROIType = ROIType.Circle;
                    mObj.strCenterRow = ldCircleCenterY.TextInfo.Trim();
                    mObj.strCenterCol = ldCircleCenterX.TextInfo.Trim();
                    mObj.strRadius = ldCircleRadius.TextInfo.Trim();
                    break;
            }

            //tab2
            mObj.isShowReg = chxShowROI.Checked;
            mObj.ROIEditColor = ColorTranslator.ToHtml(cpROIEditColor.Value);
            mObj.resultColor = ColorTranslator.ToHtml(cpResultColor.Value);

            mObj.GetData();
        }

        /// <summary>
        /// 将模块对象中的值加载到窗体中
        /// </summary>
        public override void ObjToForm()
        {
            //tab1
            ldImage.TextInfo = mObj.mImages;
            switch (mObj.mROIType)
            {
                case ROIType.Rectangle2:
                    cbxROIShape.Text = "矩形";
                    break;
                case ROIType.Circle:
                    cbxROIShape.Text = "圆形";
                    break;
            }

            ldRect2CenterX.TextInfo = mObj.strCenterCol;
            ldRect2CenterY.TextInfo = mObj.strCenterRow;
            ldRect2Phi.TextInfo = mObj.strPhi;
            ldRect2Length1.TextInfo = mObj.strLength1;
            ldRect2Length2.TextInfo = mObj.strLength2;
            ldCircleCenterX.TextInfo = mObj.strCenterCol;
            ldCircleCenterY.TextInfo = mObj.strCenterRow;
            ldCircleRadius.TextInfo = mObj.strRadius;

            //tab2
            chxShowROI.Checked = mObj.isShowReg;
            cpROIEditColor.Value = ColorTranslator.FromHtml(mObj.ROIEditColor);
            cpResultColor.Value = ColorTranslator.FromHtml(mObj.resultColor);
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
        /// 适应图像
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnFitImg_Click(object sender, EventArgs e)
        {
            InitVar();
            GenROI();
            ShowHObj();
        }

        #endregion

        #region 事件-窗体控件

        /// <summary>
        /// 窗体加载
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CreateROIForm_Load(object sender, EventArgs e)
        {
            ROI_ValueChanged(sender, e);
        }

        #endregion

        #region 事件-HWindow_HE控件

        /// <summary>
        /// 图像窗体鼠标抬起事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Hwindow_MouseUp(object sender, MouseEventArgs e)
        {
            HTuple deg = new HTuple();
            ROI roi = mWindowH.WindowH.GetActiveROIInfo(out string info, out string index);
            if (index.Length < 1) return;
            mRoiList[index] = roi;

            if (mObj.mROIType == ROIType.Rectangle2)
            {
                ldRect2CenterX.TextInfo = ((ROIRectangle2)roi).midC.ToString();
                ldRect2CenterY.TextInfo = ((ROIRectangle2)roi).midR.ToString();
                HOperatorSet.TupleDeg(((ROIRectangle2)roi).phi, out deg);
                ldRect2Phi.TextInfo = Math.Round((double)deg, 2).ToString();
                ldRect2Length1.TextInfo = ((ROIRectangle2)roi).length1.ToString();
                ldRect2Length2.TextInfo = ((ROIRectangle2)roi).length2.ToString();
            }
            else
            {
                ldCircleCenterX.TextInfo = ((ROICircle)roi).midC.ToString();
                ldCircleCenterY.TextInfo = ((ROICircle)roi).midR.ToString();
                ldCircleRadius.TextInfo = ((ROICircle)roi).Radius.ToString();
            }
        }

        #endregion

        #region 事件-ComboBox控件

        /// <summary>
        /// 区域形状选择发生变化时执行的事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="value"></param>
        private void ROI_ValueChanged(object sender, EventArgs e)
        {
            if (cbxROIShape.SelectedText == "矩形")
            {
                mObj.mROIType = ROIType.Rectangle2;
                pnlRect2Params.Visible = true;
                pnlCircleParams.Visible = false;
            }
            else
            {
                mObj.mROIType = ROIType.Circle;
                pnlRect2Params.Visible = false;
                pnlCircleParams.Visible = true;
            }

            GenROI();
            ShowHObj();
            ObjToForm();
        }

        /// <summary>
        /// 颜色改变重新绘制ROI
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="value"></param>
        private void cpColor_ValueChanged(object sender, Color value)
        {
            if (cbxInterfaceMode.SelectedText == "编辑状态")
            {
                FormToObj();
                GenROI();
                ShowHObj();
            }
        }

        /// <summary>
        /// 界面模式改变重新加载界面
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cbxInterfaceMode_SelectedValueChanged(object sender, EventArgs e)
        {
            FormToObj();
            GenROI();
            ShowHObj();
        }

        #endregion

        #region 事件-MyLinkData控件

        /// <summary>
        /// image型数据链接
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

            mObj.mImages = ldImage.TextInfo;
            if (mObj.mImages == "") return;
            mObj.mRImage = (RImage)Var.GetImage(mObj.mSloVar, mObj.mImages);

            if (!mObj.mRImage.IsInitialized()) return;
            InitVar();
            GenROI();
        }

        /// <summary>
        /// 数据链接
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ldData_LinkData(object sender, EventArgs e)
        {
            PluginDataLinkForm LikeDataForm = new PluginDataLinkForm(mObj.ProjName, mObj.ModInfo.Name);
            LikeDataForm.dataType = "int" + "|" + "double" + "|" + "HTuple";
            LikeDataForm.ShowDialog();
            if (LikeDataForm.m_OutLinkData.Length > 3)
            {
                string[] m_IntStr = LikeDataForm.m_OutLinkData.Split('|');
                MyLinkData myLinkData = sender as MyLinkData;
                switch (myLinkData.Name)
                {
                    case "ldRect2CenterX":
                        ldRect2CenterX.TextInfo = m_IntStr[0] + ":" + m_IntStr[1];
                        break;
                    case "ldRect2CenterY":
                        ldRect2CenterY.TextInfo = m_IntStr[0] + ":" + m_IntStr[1];
                        break;
                    case "ldRect2Phi":
                        ldRect2Phi.TextInfo = m_IntStr[0] + ":" + m_IntStr[1];
                        break;
                    case "ldRect2Length1":
                        ldRect2Length1.TextInfo = m_IntStr[0] + ":" + m_IntStr[1];
                        break;
                    case "ldRect2Length2":
                        ldRect2Length2.TextInfo = m_IntStr[0] + ":" + m_IntStr[1];
                        break;
                    case "ldCircleCenterX":
                        ldCircleCenterX.TextInfo = m_IntStr[0] + ":" + m_IntStr[1];
                        break;
                    case "ldCircleCenterY":
                        ldCircleCenterY.TextInfo = m_IntStr[0] + ":" + m_IntStr[1];
                        break;
                    case "ldCircleRadius":
                        ldCircleRadius.TextInfo = m_IntStr[0] + ":" + m_IntStr[1];
                        break;
                }
            }
            FormToObj();
        }

        /// <summary>
        /// 数据变化实时执行程序
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ldData_RealTimeExe(object sender, EventArgs e)
        {
            MyLinkData myLinkData = sender as MyLinkData;
            FormToObj();
            GenROI();
        }

        #endregion
    }
}
