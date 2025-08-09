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
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using VisionCore;
using static System.Net.Mime.MediaTypeNames;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace Plugin.ThresholdSeg
{
    public partial class ThresholdSegForm : FormBase
    {
        #region 字段、属性

        /// <summary>
        /// 模块对象
        /// </summary>
        ThresholdSegObj mObj;

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
        public ThresholdSegForm(ThresholdSegObj Obj) : base(Obj)
        {
            InitializeComponent();
            chxShow.ForeColor = Color.FromArgb(100, 100, 100);
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
            if (mObj.mImages == null) return;
            mObj.mRImage = (RImage)Var.GetImage(mObj.mSloVar, mObj.mImages);

            //显示图像
            if (mObj.mRImage == null) return;
            mWindowH.HobjectToHimage(mObj.mRImage);
        }

        /// <summary>
        /// 显示HObject对象
        /// </summary>
        public void ShowHObj()
        {
            HOperatorSet.SetDraw(mWindowH.HWindowHalconID, mObj.showDraw);
            HOperatorSet.DispObj(mObj.thresholdSeg_Info.regionObj, mWindowH.HWindowHalconID);
            mWindowH.DispObj(mObj.thresholdSeg_Info.regionObj, mObj.showColor);
        }

        #endregion

        #region 方法-对象保存加载相关

        /// <summary>
        /// 将窗体的值保存到模块对象中
        /// </summary>
        public override void FormToObj()
        {
            //Tab1
            mObj.mImages = ldImage.TextInfo.Trim();
            mObj.mode = cbxMode.Text;
            mObj.thresholdMinName = ld1ThresholdMin.TextInfo.Trim();
            mObj.thresholdMaxName = ld1ThresholdMax.TextInfo.Trim();
            mObj.filterImageName = ld2FilterImage.TextInfo.Trim();
            mObj.offset = tbx2Offset.TextInfo.Trim().ToDouble();
            mObj.maskWidth = tbx3MaskWidth.TextInfo.Trim().ToDouble();
            mObj.maskHeight = tbx3Mask3Height.TextInfo.Trim().ToDouble();
            mObj.stdDevScale = tbx3StdDevScale.TextInfo.Trim().ToDouble();
            mObj.absThreshold = tbx3AbsThreshold.TextInfo.Trim().ToDouble();

            if (mObj.mode == "动态")
            {
                mObj.regFeature = cbx2RegFeature.Text;
            }
            else if(mObj.mode == "局部")
            {
                mObj.regFeature = cbx3RegFeature.Text;
            }

            //Tab2
            mObj.isShowReg = chxShow.Checked;
            mObj.showDraw = cbxDraw.Text;
            mObj.showColor = ColorTranslator.ToHtml(cpColor.Value);

            mObj.GetData();
        }

        /// <summary>
        /// 将模块对象中的值加载到窗体中
        /// </summary>
        public override void ObjToForm()
        {
            //Tab1
            ldImage.TextInfo = mObj.mImages;
            cbxMode.Text = mObj.mode;
            ld1ThresholdMin.TextInfo = mObj.thresholdMinName;
            ld1ThresholdMax.TextInfo = mObj.thresholdMaxName;
            ld2FilterImage.TextInfo = mObj.filterImageName;
            tbx2Offset.TextInfo = mObj.offset.ToString();
            tbx3MaskWidth.TextInfo = mObj.maskWidth.ToString();
            tbx3Mask3Height.TextInfo = mObj.maskHeight.ToString();
            tbx3StdDevScale.TextInfo = mObj.stdDevScale.ToString();
            tbx3AbsThreshold.TextInfo = mObj.absThreshold.ToString();
            cbx2RegFeature.Text = mObj.regFeature;
            cbx3RegFeature.Text = mObj.regFeature;

            //Tab2
            chxShow.Checked = mObj.isShowReg;
            cbxDraw.Text = mObj.showDraw;
            cpColor.Value = ColorTranslator.FromHtml(mObj.showColor);
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
                MyLinkData myLinkData = sender as MyLinkData;
                switch (myLinkData.Name) 
                {
                    case "ldImage":
                        ldImage.TextInfo = m_IntStr[0] + ":" + m_IntStr[1];
                        mObj.mImages = ldImage.TextInfo.Trim();
                        ShowImage();
                        break;
                    case "ld2FilterImage":
                        ld2FilterImage.TextInfo = m_IntStr[0] + ":" + m_IntStr[1];
                        break;
                    default:
                        break;
                }
            }
        }

        /// <summary>
        /// double类型数据链接
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ldDouble_LinkData(object sender, EventArgs e)
        {
            PluginDataLinkForm LikeDataForm = new PluginDataLinkForm(mObj.ProjName, mObj.ModInfo.Name);
            LikeDataForm.dataType = "Double";
            LikeDataForm.ShowDialog();
            if (LikeDataForm.m_OutLinkData.Length > 3)
            {
                string[] m_IntStr = LikeDataForm.m_OutLinkData.Split('|');
                MyLinkData myLinkData = sender as MyLinkData;
                switch (myLinkData.Name)
                {
                    case "ld1ThresholdMin":
                        ld1ThresholdMin.TextInfo = m_IntStr[0] + ":" + m_IntStr[1];
                        break;
                    case "ld1ThresholdMax":
                        ld1ThresholdMax.TextInfo = m_IntStr[0] + ":" + m_IntStr[1];
                        break;
                    default:
                        break;
                }
            }
        }

        #endregion

        #region 事件-ComboBox控件

        /// <summary>
        /// 模式选中值改变
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cbxSelect_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (cbxMode.Text)
            {
                case "动态":
                    pnlThreshold.Visible = false;
                    pnlDynThreshold.Visible = true;
                    pnlVarThreshold.Visible = false;
                    break;
                case "局部":
                    pnlThreshold.Visible = false;
                    pnlDynThreshold.Visible = false;
                    pnlVarThreshold.Visible = true;
                    break;
                default:
                    pnlThreshold.Visible = true;
                    pnlDynThreshold.Visible = false;
                    pnlVarThreshold.Visible = false;
                    break;
            }
        }

        /// <summary>
        /// 形态选中值改变
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cbxDraw_SelectedIndexChanged(object sender, EventArgs e)
        {
            mWindowH.Draw = (ShowDraw)Enum.Parse(typeof(ShowDraw), cbxDraw.Text);
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

        #endregion

        #region 事件-窗口控件

        /// <summary>
        /// 窗体加载
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ThresholdSegForm_Load(object sender, EventArgs e)
        {
            mWindowH.Draw = (ShowDraw)Enum.Parse(typeof(ShowDraw), cbxDraw.Text);

            switch (cbxMode.Text)
            {
                case "动态":
                    pnlThreshold.Visible = false;
                    pnlDynThreshold.Visible = true;
                    pnlVarThreshold.Visible = false;
                    break;
                case "局部":
                    pnlThreshold.Visible = false;
                    pnlDynThreshold.Visible = false;
                    pnlVarThreshold.Visible = true;
                    break;
                default:
                    pnlThreshold.Visible = true;
                    pnlDynThreshold.Visible = false;
                    pnlVarThreshold.Visible = false;
                    break;
            }
        }

        #endregion
    }
}
