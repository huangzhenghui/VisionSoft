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

namespace Plugin.RegionInfo
{
    public partial class RegionInfoForm : FormBase
    {
        #region 字段、属性

        /// <summary>
        /// 模块对象
        /// </summary>
        RegionInfoObj mObj;

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
        public RegionInfoForm(RegionInfoObj Obj) : base(Obj)
        {
            InitializeComponent();
            chxShowResult.ForeColor = Color.FromArgb(100, 100, 100);
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
            HOperatorSet.SetDraw(mWindowH.HWindowHalconID, "margin");
            HOperatorSet.SetColored(mWindowH.HWindowHalconID, 12);

            //绘制文本
            string showText = "";
            for (int i = 0; i < mObj.regionInfo_Info.result.Length; i++)
            {
                if (i == 0)
                {
                    showText = mObj.regionInfo_Info.result[i].ToString("F2");
                }
                else
                {
                    showText = showText + "," + mObj.regionInfo_Info.result[i].ToString("F2");
                }

                //绘制HObj
                HOperatorSet.DispObj(mObj.inputReg, mWindowH.HWindowHalconID);
                mWindowH.DispObj(mObj.inputReg);

                ShowTool.SetFont(mWindowH.hControl.HalconWindow, mObj.fontSize, "mono", "false", "false");
                ShowTool.SetMsg(mWindowH.hControl.HalconWindow, mObj.prefix + ":" + showText, "image", mObj.X, mObj.Y, mObj.resultColor, "false");
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
            mObj.feature = cbxFeature.Text;
            mObj.inputRegName = ldRegion.TextInfo.Trim();

            //Tab2
            mObj.isShowResult = chxShowResult.Checked;
            mObj.X = tbxX.TextInfo.Trim().ToDouble();
            mObj.Y = tbxY.TextInfo.Trim().ToDouble();
            mObj.fontSize = tbxFontSize.TextInfo.Trim().ToInt();
            mObj.prefix = tbxPrefix.Text.Trim();
            mObj.resultColor = ColorTranslator.ToHtml(cpColor.Value);

            mObj.GetData();
        }

        /// <summary>
        /// 将模块对象中的值加载到窗体中
        /// </summary>
        public override void ObjToForm()
        {
            //Tab1
            ldImage.TextInfo = mObj.mImages;
            cbxFeature.Text = mObj.feature;
            ldRegion.TextInfo = mObj.inputRegName;

            //Tab2
            chxShowResult.Checked = mObj.isShowResult;
            tbxX.TextInfo = mObj.X.ToString();
            tbxY.TextInfo = mObj.Y.ToString();
            tbxFontSize.TextInfo = mObj.fontSize.ToString();
            tbxPrefix.Text = mObj.prefix.ToString();
            cpColor.Value = ColorTranslator.FromHtml(mObj.resultColor);
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
                case "ldRegion":
                    LikeDataForm.dataType = "HObject";
                    LikeDataForm.ShowDialog();
                    if (LikeDataForm.m_OutLinkData.Length > 3)
                    {
                        string[] m_IntStr = LikeDataForm.m_OutLinkData.Split('|');
                        ldRegion.TextInfo = m_IntStr[0] + ":" + m_IntStr[1];
                    }
                    break;
            }
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
    }
}
