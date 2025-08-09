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

namespace Plugin.PartRectangle
{
    public partial class PartRectangleForm : FormBase
    {
        #region 字段、属性

        /// <summary>
        /// 模块对象
        /// </summary>
        PartRectangleObj mObj;

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
        public PartRectangleForm(PartRectangleObj Obj) : base(Obj)
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
            //绘制显示图形
            HOperatorSet.SetDraw(mWindowH.HWindowHalconID, mObj.showDraw);
            HOperatorSet.SetColored(mWindowH.hControl.HalconWindow, 12);

            if (mObj.partRectangle_Info.resultReg != null)
            {
                HOperatorSet.DispObj(mObj.partRectangle_Info.resultReg, mWindowH.HWindowHalconID);
                mWindowH.DispObj(mObj.partRectangle_Info.resultReg);
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
            mObj.inputRegName = ldRegion.TextInfo.Trim();
            mObj.width = int.Parse(tbxWidth.TextInfo.Trim());
            mObj.height = int.Parse(tbxHeight.TextInfo.Trim());

            //Tab2
            mObj.isShowResult = chxShowResult.Checked;
            mObj.showDraw = cbxDraw.Text;
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
            ldRegion.TextInfo = mObj.inputRegName;
            tbxWidth.TextInfo = mObj.width.ToString();
            tbxHeight.TextInfo = mObj.height.ToString();

            //Tab2
            chxShowResult.Checked = mObj.isShowResult;
            cbxDraw.Text = mObj.showDraw;
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

        #region 事件-ComboBox控件

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
        private void ShapeTransForm_Load(object sender, EventArgs e)
        {
            mWindowH.Draw = (ShowDraw)Enum.Parse(typeof(ShowDraw), cbxDraw.Text);
        }

        #endregion
    }
}
