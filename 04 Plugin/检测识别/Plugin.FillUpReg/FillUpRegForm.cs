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

namespace Plugin.FillUpReg
{
    public partial class FillUpRegForm : FormBase
    {
        #region 字段、属性

        /// <summary>
        /// 模块对象
        /// </summary>
        FillUpRegObj mObj;

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
        public FillUpRegForm(FillUpRegObj Obj) : base(Obj)
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
            HOperatorSet.SetColored(mWindowH.hControl.HalconWindow, 12);
            if (mObj.fillUpReg_Info.regionObj != null)
            {
                HOperatorSet.DispObj(mObj.fillUpReg_Info.regionObj, mWindowH.HWindowHalconID);
                mWindowH.DispObj(mObj.fillUpReg_Info.regionObj);
            }
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
            mObj.fillUpMode = cbxMode.Text;
            if (mObj.fillUpMode == "孔洞填充")
            {
                mObj.inputRegName = ld1Region.TextInfo.Trim();
            }
            else
            {
                mObj.inputRegName = ld2Region.TextInfo.Trim();
                mObj.feature = cbx2Feature.Text;
                mObj.min = tbx2Min.TextInfo.Trim().ToDouble();
                mObj.max = tbx2Max.TextInfo.Trim().ToDouble();
            }

            //Tab2
            mObj.isShowHObj = chxShow.Checked;
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
            cbxMode.Text = mObj.fillUpMode;
            ld1Region.TextInfo = mObj.inputRegName;
            ld2Region.TextInfo = mObj.inputRegName;
            cbx2Feature.Text = mObj.feature;
            tbx2Min.TextInfo = mObj.min.ToString();
            tbx2Max.TextInfo = mObj.max.ToString();

            //Tab2
            chxShow.Checked = mObj.isShowHObj;
            cbxDraw.Text = mObj.showDraw;
            cpColor.Value = ColorTranslator.FromHtml(mObj.showColor);
        }

        #endregion

        #region 事件-MyLinkData控件

        /// <summary>
        /// LinkData控件数据链接
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ldData_LinkData(object sender, EventArgs e)
        {
            MyLinkData myLinkData = sender as MyLinkData;
            PluginDataLinkForm LikeDataForm = new PluginDataLinkForm(mObj.ProjName, mObj.ModInfo.Name);
            switch (myLinkData.Name)
            {
                case "ldImage":
                    LikeDataForm.dataType = "RImage";
                    LikeDataForm.ShowDialog();
                    if (LikeDataForm.m_OutLinkData.Length > 3)
                    {
                        string[] m_IntStr = LikeDataForm.m_OutLinkData.Split('|');
                        ldImage.TextInfo = m_IntStr[0] + ":" + m_IntStr[1];
                        mObj.mImages = ldImage.TextInfo.Trim();
                        ShowImage();
                    }
                    break;
                case "ld1Region":
                    LikeDataForm.dataType = "HObject";
                    LikeDataForm.ShowDialog();
                    if (LikeDataForm.m_OutLinkData.Length > 3)
                    {
                        string[] m_IntStr = LikeDataForm.m_OutLinkData.Split('|');
                        ld1Region.TextInfo = m_IntStr[0] + ":" + m_IntStr[1];
                    }
                    break;
                case "ld2Region":
                    LikeDataForm.dataType = "HObject";
                    LikeDataForm.ShowDialog();
                    if (LikeDataForm.m_OutLinkData.Length > 3)
                    {
                        string[] m_IntStr = LikeDataForm.m_OutLinkData.Split('|');
                        ld2Region.TextInfo = m_IntStr[0] + ":" + m_IntStr[1];
                    }
                    break;
            }
        }

        #endregion

        #region 事件-ComboBox控件

        /// <summary>
        /// 模板因素选择
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cbxSelect_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbxMode.SelectedText == "孔洞填充")
            {
                pnl2Params.Visible = false;
                pnl1Params.Visible = true;
            }
            else
            {
                pnl2Params.Visible = true;
                pnl1Params.Visible = false;
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

        #region 事件-窗体控件

        /// <summary>
        /// 窗体加载
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FillUpRegForm_Load(object sender, EventArgs e)
        {
            mWindowH.Draw = (ShowDraw)Enum.Parse(typeof(ShowDraw), cbxDraw.Text);

            if (cbxMode.SelectedText == "孔洞填充")
            {
                pnl2Params.Visible = false;
                pnl1Params.Visible = true;
            }
            else
            {
                pnl2Params.Visible = true;
                pnl1Params.Visible = false;
            }
        }

        #endregion
    }
}
