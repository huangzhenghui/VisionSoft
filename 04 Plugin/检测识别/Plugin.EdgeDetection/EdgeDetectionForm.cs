using Plugin.CreateROI;
using Rex.UI;
using RexConst;
using RexControl.MyControls;
using RexView;
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

namespace Plugin.EdgeDetection
{
    public partial class EdgeDetectionForm : FormBase
    {
        /// <summary>
        /// 模块对象
        /// </summary>
        EdgeDetectionObj mObj;

        #region 初始化

        /// <summary>
        /// 初始化
        /// </summary>
        /// <param name="Obj"></param>
        public EdgeDetectionForm(EdgeDetectionObj Obj) : base(Obj)
        {
            InitializeComponent();
            mObj = Obj;
        }

        #endregion

        /// <summary>
        /// 初始化图像
        /// </summary>
        protected void InitImage()
        {
            mObj.mImages = ldImage.TextInfo;
            if (mObj.mImages == null) return;
            mObj.mRImage = (RImage)Var.GetImage(mObj.mSloVar, mObj.mImages);
            ShowHRoi();
        }

        /// <summary>
        /// 将窗体的值保存到模块对象中
        /// </summary>
        public override void FormToObj()
        {
            mObj.mImages = ldImage.TextInfo.Trim();
            if (cbxFilterType.Text.Trim() == "")
            {
                cbxFilterType.SelectedIndex = 0;
            }

            if (cbxSize.Text.Trim() == "")
            {
                cbxSize.SelectedIndex = 0;
            }

            if (cbxSelectScreen.Text == "")
            {
                cbxSelectScreen.SelectedIndex = 0;
            }

            mObj.filterType = cbxFilterType.Text.Trim();
            mObj.size = cbxSize.Text.Trim();
            mObj.mScreen = cbxSelectScreen.SelectedIndex;
        }

        /// <summary>
        /// 将模块对象中的值加载到窗体中
        /// </summary>
        public override void ObjToForm()
        {
            ldImage.TextInfo = mObj.mImages;
            cbxFilterType.Text = mObj.filterType;
            cbxSize.Text = mObj.size;
            cbxSelectScreen.SelectedIndex = mObj.mScreen;
        }

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
            FormToObj();
            InitImage();
        }

        #region 事件-按钮控件

        /// <summary>
        /// 执行
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public override void btn_Run_Click(object sender, EventArgs e)
        {
            FormToObj();
            mObj.RunObj();
            ObjToForm();
            ShowHRoi();
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

        /// <summary>
        /// 窗体加载
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void EdgeDetectionForm_Load(object sender, EventArgs e)
        {
            InitImage();
        }

        #region 事件-ComboBox控件

        /// <summary>
        /// ComboBox选择发生变化时执行的事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="value"></param>
        private void ComboBox_ValueChanged(object sender, EventArgs e)
        {
            MyComboBox myLinkData = sender as MyComboBox;
            switch (myLinkData.Name)
            {
                case "cbxFilterType":
                    mObj.filterType = cbxFilterType.Text.Trim();
                    break;
                case "cbxSize":
                    mObj.size = cbxSize.Text.Trim();
                    break;
                default:
                    break;
            }
            InitImage();
            ObjToForm();
        }

        #endregion

        /// <summary>
        /// 显示当前图片
        /// </summary>
        public void ShowHRoi()
        {
            if (mObj.mRImage != null)
            {
                mWindowH.HobjectToHimage(mObj.mRImage);
            }

            if (mObj.mRImageResult != null)
            {
                mWindowH.HobjectToHimage(mObj.mRImageResult);
            }
        }
    }
}
