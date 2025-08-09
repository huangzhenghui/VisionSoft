using HalconDotNet;
using MutualTools;
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
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using VisionCore;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace Plugin.FindCircle
{
    public partial class FindCircleForm : FormBase
    {
        #region 字段、属性

        /// <summary>
        /// 模块对象
        /// </summary>
        FindCircleObj mObj;

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
        public FindCircleForm(FindCircleObj Obj) : base(Obj)
        {
            InitializeComponent();
            mObj = Obj;
            mWindowH.hControl.MouseUp += Hwindow_MouseUp;

            tbxLowLimit.FillColor = Color.AliceBlue;
            tbxLowLimit.RectColor = Color.AliceBlue;
            tbxLowLimit.ForeColor = Color.FromArgb(100, 100, 100);
            tbxUpLimit.FillColor = Color.AliceBlue;
            tbxUpLimit.RectColor = Color.AliceBlue;
            tbxUpLimit.ForeColor = Color.FromArgb(100, 100, 100);
            tbxPointSize.FillColor = Color.AliceBlue;
            tbxPointSize.RectColor = Color.AliceBlue;
            tbxPointSize.ForeColor = Color.FromArgb(100, 100, 100);
            lblSign.SymbolColor = Color.CornflowerBlue;
            btnFitImg.FillColor = Color.AliceBlue;
            btnFitImg.RectColor = Color.AliceBlue;
            btnFitImg.ForeColor = Color.FromArgb(100, 100, 100);
            btnFitImg.ForeHoverColor = Color.FromArgb(100, 100, 100);
            btnFitImg.ForePressColor = Color.FromArgb(100, 100, 100);
            btnFitImg.FillHoverColor = Color.LightBlue;
            btnFitImg.FillPressColor = Color.LightBlue;
            btnFitImg.RectPressColor = Color.LightBlue;
            btnFitImg.RectHoverColor = Color.LightBlue;
            chxShowPoint.ForeColor = Color.FromArgb(100, 100, 100);
            chxShowCircle.ForeColor = Color.FromArgb(100, 100, 100);
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
        /// 显示HObject
        /// </summary>
        public void ShowHObj()
        {
            if (mObj.mRImage == null || !mObj.mRImage.IsInitialized()) return;
            mWindowH.HobjectToHimage(mObj.mRImage);

            HOperatorSet.SetSystem("width", 20000);
            HOperatorSet.SetSystem("height", 20000);

            if (cbxInterfaceMode.SelectedText == "编辑状态")
            {
                mWindowH.WindowH.DispROI(mObj.ModInfo.Name + ROIType.FindCircle, mRoiList[mObj.ModInfo.Name + ROIType.FindCircle]);
            }
            else
            {
                if (FindCircleObj.fittedPointCopy != null && FindCircleObj.fittedPointCopy.IsInitialized())
                {
                    HObject hObj = FindCircleObj.fittedPointCopy.Clone();
                    HOperatorSet.SetLineWidth(mWindowH.HWindowHalconID, 1.45);
                    HOperatorSet.SetColor(mWindowH.HWindowHalconID, mObj.fittedPointColor);
                    HOperatorSet.DispObj(hObj, mWindowH.HWindowHalconID);
                    mWindowH.DispObj(hObj, mObj.fittedPointColor);
                }

                if (FindCircleObj.fittedPointCopy != null && FindCircleObj.removedPointCopy.IsInitialized())
                {
                    HObject hObj = FindCircleObj.removedPointCopy.Clone();
                    HOperatorSet.SetLineWidth(mWindowH.HWindowHalconID, 1.45);
                    HOperatorSet.SetColor(mWindowH.HWindowHalconID, mObj.removedPointColor);
                    HOperatorSet.DispObj(hObj, mWindowH.HWindowHalconID);
                    mWindowH.DispObj(hObj, mObj.removedPointColor);
                }

                if (FindCircleObj.fittedPointCopy != null && FindCircleObj.lineCopy.IsInitialized())
                {
                    HObject hObj = FindCircleObj.lineCopy.Clone();
                    HOperatorSet.SetLineWidth(mWindowH.HWindowHalconID, 1.45);
                    HOperatorSet.SetColor(mWindowH.HWindowHalconID, mObj.resultColor);
                    HOperatorSet.DispObj(hObj, mWindowH.HWindowHalconID);
                    mWindowH.DispObj(hObj, mObj.resultColor);
                }
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
            mObj.strMidR = (height / 2).ToString();
            mObj.strMidC = (width / 2).ToString();
            mObj.strRadius = (height / 6).ToString();

            mObj.GetData();
            ObjToForm();
        }

        /// <summary>
        /// 生成ROI
        /// </summary>
        public void GenROI()
        {
            ShowImage();
            if (mObj.mRImage == null || !mObj.mRImage.IsInitialized()) return;
            mWindowH.WindowH.GenFindCircle(mObj.ModInfo.Name + ROIType.FindCircle, mObj.midR, mObj.midC, mObj.radius, mObj.startAngle * Math.PI / 180, mObj.endAngle * Math.PI / 180, mObj.pointOrder, mObj.measureNum, mObj.length1, mObj.length2, ref mRoiList, mObj.projectColor, mObj.meaRectColor);
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
            mObj.strMidR = ldCenterY.TextInfo.Trim();
            mObj.strMidC = ldCenterX.TextInfo.Trim();
            mObj.strRadius = ldRadius.TextInfo.Trim();
            mObj.strStartAngle = ldStartAngle.TextInfo.Trim();
            mObj.strEndAngle = ldEndAngle.TextInfo.Trim();
            mObj.length1 = Convert.ToDouble(tbxLength1.TextInfo.Trim());
            mObj.length2 = Convert.ToDouble(tbxLength2.TextInfo.Trim());
            mObj.sigma = Convert.ToDouble(tbxSigma.TextInfo.Trim());
            mObj.contrast = Convert.ToInt32(tbxContrast.TextInfo.Trim());

            //tab2
            mObj.select = cbxSelect.Text.Trim();
            mObj.transition = cbxTransition.Text.Trim();
            mObj.measureNum = Convert.ToInt32(tbxMeasureNum.TextInfo.Trim());
            mObj.lowLimit = Convert.ToInt32(tbxLowLimit.Text.Trim());
            mObj.upLimit = Convert.ToInt32(tbxUpLimit.Text.Trim());

            //tab3
            mObj.projectColor = ColorTranslator.ToHtml(cpProjection.Value);
            mObj.meaRectColor = ColorTranslator.ToHtml(cpMeasureRect.Value);
            mObj.isShowPoint = chxShowPoint.Checked;
            mObj.isShowReg = chxShowCircle.Checked;
            mObj.pointSize = Convert.ToInt32(tbxPointSize.Text.Trim());
            mObj.fittedPointColor = ColorTranslator.ToHtml(cpPoint.Value);
            mObj.removedPointColor = "#FF0000";
            mObj.resultColor = ColorTranslator.ToHtml(cpCircle.Value);

            mObj.GetData();
        }

        /// <summary>
        /// 将模块对象中的值加载到窗体中
        /// </summary>
        public override void ObjToForm()
        {
            //tab1
            ldImage.TextInfo = mObj.mImages;
            ldCenterX.TextInfo = mObj.strMidC;
            ldCenterY.TextInfo = mObj.strMidR;
            ldRadius.TextInfo = mObj.strRadius;
            ldStartAngle.TextInfo = mObj.strStartAngle;
            ldEndAngle.TextInfo = mObj.strEndAngle;
            tbxLength1.TextInfo = mObj.length1.ToString();
            tbxLength2.TextInfo = mObj.length2.ToString();
            tbxSigma.TextInfo = mObj.sigma.ToString();
            tbxContrast.TextInfo = mObj.contrast.ToString();

            //tab2
            cbxSelect.Text = mObj.select.ToString();
            cbxTransition.Text = mObj.transition.ToString();
            tbxMeasureNum.TextInfo = mObj.measureNum.ToString();
            tbxLowLimit.Text = mObj.lowLimit.ToString();
            tbxUpLimit.Text = mObj.upLimit.ToString();

            //tab3
            cpProjection.Value = ColorTranslator.FromHtml(mObj.projectColor);
            cpMeasureRect.Value = ColorTranslator.FromHtml(mObj.meaRectColor);
            chxShowPoint.Checked = mObj.isShowPoint;
            chxShowCircle.Checked = mObj.isShowReg;
            tbxPointSize.Text = mObj.pointSize.ToString();
            cpPoint.Value = ColorTranslator.FromHtml(mObj.fittedPointColor);
            cpCircle.Value = ColorTranslator.FromHtml(mObj.resultColor);
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
        private void FindCircleForm_Load(object sender, EventArgs e)
        {
            GenROI();
            ShowHObj();
            ObjToForm();
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

            ldCenterX.TextInfo = ((ROIFindCircle)roi).midC.ToString();
            ldCenterY.TextInfo = ((ROIFindCircle)roi).midR.ToString();
            ldRadius.TextInfo = ((ROIFindCircle)roi).radius.ToString();
            ldStartAngle.TextInfo = (((ROIFindCircle)roi).startAngle / Math.PI * 180).ToString();
            ldEndAngle.TextInfo = (((ROIFindCircle)roi).endAngle / Math.PI * 180).ToString();
            tbxLength1.TextInfo = ((ROIFindCircle)roi).length1.ToString();
            tbxLength2.TextInfo = ((ROIFindCircle)roi).length2.ToString();
        }

        #endregion

        #region 事件-ComboBox控件

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

            mObj.mImages = ldImage.TextInfo.Trim();
            if (mObj.mImages == "") return;
            mObj.mRImage = (RImage)Var.GetImage(mObj.mSloVar, mObj.mImages);

            if (mObj.mRImage == null || !mObj.mRImage.IsInitialized()) return;
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
                    case "ldCenterX":
                        ldCenterX.TextInfo = m_IntStr[0] + ":" + m_IntStr[1];
                        break;
                    case "ldCenterY":
                        ldCenterY.TextInfo = m_IntStr[0] + ":" + m_IntStr[1];
                        break;
                    case "ldRadius":
                        ldRadius.TextInfo = m_IntStr[0] + ":" + m_IntStr[1];
                        break;
                    case "ldStartAngle":
                        ldStartAngle.TextInfo = m_IntStr[0] + ":" + m_IntStr[1];
                        break;
                    case "ldEndAngle":
                        ldEndAngle.TextInfo = m_IntStr[0] + ":" + m_IntStr[1];
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
