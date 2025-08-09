using System;
using System.Linq;
using System.Windows.Forms;
using VisionCore;
using System.IO;
using Ookii.Dialogs.WinForms;
using System.Collections.Generic;
using RexConst;
using Rex.UI;
using RexView;
using System.Drawing;
using HalconDotNet;
using RexHelps;
using RexControl;
using static System.Net.Mime.MediaTypeNames;
using System.Drawing.Text;
using RexControl.MyControls;

namespace Plugin.CaptureImage
{
    public partial class CaptureImageForm : FormBase
    {
        #region 字段、属性

        /// <summary>
        /// 采集图像模块对象
        /// </summary>
        CaptureImageObj mObj;

        /// <summary>
        /// DataGridView选中行的索引号
        /// </summary>
        public int dgvCurCellIndex;

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
        public CaptureImageForm(CaptureImageObj Obj) : base(Obj)
        {
            InitializeComponent();
            mObj = Obj;

            rbImage.ForeColor = Color.FromArgb(100, 100, 100);
            rbFolder.ForeColor = Color.FromArgb(100, 100, 100);
            rbCam.ForeColor = Color.FromArgb(100, 100, 100);
            chxForRead.ForeColor = Color.FromArgb(100, 100, 100);
            chxUsePiexlPrec.ForeColor = Color.FromArgb(100, 100, 100);
            chxShowData.ForeColor = Color.FromArgb(100, 100, 100);
            btnZeroIdx.FillColor = Color.AliceBlue;
            btnZeroIdx.RectColor = Color.AliceBlue;
            btnZeroIdx.ForeColor = Color.FromArgb(100, 100, 100);
            btnZeroIdx.ForeHoverColor = Color.FromArgb(100, 100, 100);
            btnZeroIdx.ForePressColor = Color.FromArgb(100, 100, 100);
            btnZeroIdx.FillHoverColor = Color.LightBlue;
            btnZeroIdx.FillPressColor = Color.LightBlue;
            btnZeroIdx.RectPressColor = Color.LightBlue;
            btnZeroIdx.RectHoverColor = Color.LightBlue;
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
            //显示图像
            if (mObj.captureImage_Info.imageObj == null || !mObj.captureImage_Info.imageObj.IsInitialized()) return;
            mWindowH.HobjectToHimage(mObj.captureImage_Info.imageObj);
        }

        /// <summary>
        /// 显示HObject对象
        /// </summary>
        public void ShowHObj()
        {
            if (mObj.captureImage_Info.imageObj == null || !mObj.captureImage_Info.imageObj.IsInitialized()) return;

            //绘制文本
            string text;
            if (mObj.prefix != "")
            {
                text = mObj.prefix + ":" + mObj.mRImage.Name;
            }
            else
            {
                text = mObj.mRImage.Name;
            }

            ShowTool.SetFont(mWindowH.hControl.HalconWindow, mObj.fontSize, mObj.fontType, "false", "false");
            ShowTool.SetMsg(mWindowH.hControl.HalconWindow, text, "window", 10, 10, mObj.resultColor, "false");
        }

        /// <summary>
        /// 显示输入HObject
        /// </summary>
        public void ShowInputHObj()
        {
            try
            {
                switch (mObj.imageSource)
                {
                    case ImageSource.指定图像:
                        mObj.mRImage = RImage.ReadRImage(mObj.mImagePath);
                        break;
                    case ImageSource.文件目录:
                        if (mObj.mFileInfo == null) return;
                        mObj.mRImage = RImage.ReadRImage(mObj.mFileInfo[mObj.index]);
                        int count = mObj.mFileInfo.Count;
                        if (mObj.mForRead)
                        {
                            ++mObj.index;
                            if (mObj.index > count - 1)
                            {
                                mObj.index = 0;
                            }
                        }
                        InitFile(mObj.mFolderPath);
                        break;
                    case ImageSource.相机采集:
                        if (mObj.mCamerasBase != null && mObj.mCamerasBase.mConnected)
                        {
                            mObj.mCamerasBase.CaptureImage(true);
                            mObj.mRImage = (RImage)mObj.mCamerasBase.Image;
                            mObj.mRImage.Name = mObj.mCamerasBase.mCamName;
                        }
                        else
                        {
                            mObj.mRImage = null;
                            mObj.mCamerasBase.EventWait.Set();
                        }
                        break;
                }

                if (mObj.mRImage == null || !mObj.mRImage.IsInitialized()) return;
                mWindowH.HobjectToHimage(mObj.mRImage);
            }
            catch { }
        }

        #endregion

        #region 方法-模块相关

        /// <summary>
        /// 将窗体的值保存到模块对象中
        /// </summary>
        public override void FormToObj()
        {
            //Tab1
            if (rbImage.Checked)
            {
                mObj.imageSource = ImageSource.指定图像;
            }
            else if (rbFolder.Checked)
            {
                mObj.imageSource = ImageSource.文件目录;
            }
            else if (rbCam.Checked)
            {
                mObj.imageSource = ImageSource.相机采集;
            }

            mObj.mImagePath = tbxImagePath.Text;
            mObj.mFolderPath = tbxFolderPath.Text;
            mObj.mForRead = chxForRead.Checked;
            mObj.mCamerasBase = mObj.mCamera.FirstOrDefault(c => c.mCamName == cbxSelectCam.Text);
            mObj.mCamName = cbxSelectCam.Text;

            //Tab2
            mObj.imgProcMode = (ImgProcMode)Enum.Parse(typeof(ImgProcMode), cbxImgProcMode.SelectedText);
            mObj.isUsePixelProc = chxUsePiexlPrec.Checked;
            mObj.strPixelPrec = ldPiexlPrec.TextInfo.Trim();

            //Tab3
            mObj.screenIndex = cbxSelectScreen.SelectedIndex;
            mObj.isShowData = chxShowData.Checked;
            mObj.X = Convert.ToDouble(tbxX.TextInfo.Trim());
            mObj.Y = Convert.ToDouble(tbxY.TextInfo.Trim());
            mObj.fontSize = Convert.ToInt32(tbxFontSize.TextInfo.Trim());
            mObj.fontType = cbxFontStye.Text.Trim();
            mObj.prefix = tbxPrefix.Text.Trim();
            mObj.resultColor = ColorTranslator.ToHtml(cpColor.Value);
        }

        /// <summary>
        /// 将模块对象中的值加载到窗体中
        /// </summary>
        public override void ObjToForm()
        {
            //Tab1
            if (mObj.imageSource == ImageSource.指定图像)
            {
                rbImage.Checked = true;
            }
            else if (mObj.imageSource == ImageSource.文件目录)
            {
                rbFolder.Checked = true;
            }
            else if (mObj.imageSource == ImageSource.相机采集)
            {
                rbCam.Checked = true;
            }

            tbxImagePath.Text = mObj.mImagePath;
            chxForRead.Checked = mObj.mForRead;
            tbxFolderPath.Text = mObj.mFolderPath;

            List<string> camNamList = new List<string>(mObj.mCamera.Select(c => c.mCamName).ToList());
            cbxSelectCam.DataSource = camNamList;
            cbxSelectCam.DisplayMember = "mCamName";
            cbxSelectCam.Text = mObj.mCamName;
            cbxSelectScreen.SelectedIndex = mObj.mScreen;

            //Tab2
            cbxImgProcMode.Text = mObj.imgProcMode.ToString();
            chxUsePiexlPrec.Checked = mObj.isUsePixelProc;
            ldPiexlPrec.TextInfo = mObj.strPixelPrec;

            //Tab3
            cbxSelectScreen.SelectedIndex = mObj.screenIndex;
            chxShowData.Checked = mObj.isShowData;
            tbxX.TextInfo = mObj.X.ToString();
            tbxY.TextInfo = mObj.Y.ToString();
            tbxFontSize.TextInfo = mObj.fontSize.ToString();
            cbxFontStye.Text = mObj.fontType;
            tbxPrefix.Text = mObj.prefix.ToString();
            cpColor.Value = ColorTranslator.FromHtml(mObj.resultColor);
        }

        /// <summary>
        /// 初始化文件
        /// </summary>
        /// <param name="path"></param>
        private void InitFile(string path)
        {
            if (Directory.Exists(path))          
            {
                var filess = Directory.GetFiles(path, "*.*", SearchOption.AllDirectories).Where(s => s.EndsWith(".jpg") || s.EndsWith(".gif") || s.EndsWith(".png") || s.EndsWith(".bmp") || s.EndsWith(".jpg") || s.EndsWith(".he") || s.EndsWith(".tiff"));
                mObj.mFileInfo = filess.ToList();
                dgvImage.Rows.Clear();
                if (mObj.mFileInfo.Count > 0)
                {
                    for (int i = 0; i < mObj.mFileInfo.Count; ++i)
                    {
                        dgvImage.Rows.Add();
                        dgvImage.Rows[i].Cells[0].Value = i;
                        dgvImage.Rows[i].Cells[1].Value = mObj.mFileInfo[i];
                    }
                }
            }
        }

        #endregion

        #region 事件-按钮控件
        /// <summary>
        /// 保存设置
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public override void btn_Save_Click(object sender, EventArgs e)
        {
            FormToObj();
        }

        /// <summary>
        /// 执行模块
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
        /// 取消
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public override void btn_Cancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        /// <summary>
        /// 操作区按钮点击事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public void cliAreaBtn_Click(object sender,EventArgs e)
        {
            Button btn = sender as Button;
            switch (btn.Name)
            {
                case "btnImagePath":
                    OpenFileDialog openFileDialog = new OpenFileDialog();
                    openFileDialog.Multiselect = true;
                    openFileDialog.Title = "请选择文件";
                    openFileDialog.Filter = "所有文件(*.*)|*.*";
                    if (openFileDialog.ShowDialog() == DialogResult.OK)
                    {
                        tbxImagePath.Text = openFileDialog.FileName;
                    }
                    mObj.index = 0;
                    break;
                case "btnFolderPath":
                    FolderBrowserDialog folderBrowserDialog = new FolderBrowserDialog();
                    if (folderBrowserDialog.ShowDialog() == DialogResult.OK)
                    {
                        tbxFolderPath.Text = folderBrowserDialog.SelectedPath;
                        InitFile(folderBrowserDialog.SelectedPath);
                        mObj.index = 0;
                    }
                    break;
            }

            FormToObj();
            ShowInputHObj();
        }

        /// <summary>
        /// 索引置零
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnZeroIdx_Click(object sender, EventArgs e)
        {
            mObj.index = 0;
        }

        #endregion

        #region 事件-窗体控件

        /// <summary>
        /// 加载窗体事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CameraForm_Load(object sender, EventArgs e)
        {
            FontFamily[] fontFamilies;
            cbxFontStye.Items.Clear();
            InstalledFontCollection installedFontCollection = new InstalledFontCollection();
            fontFamilies = installedFontCollection.Families;
            int count = fontFamilies.Length;
            for (int j = 0; j < count; ++j)
            {
                cbxFontStye.Items.Add(fontFamilies[j].Name);
            }

            ShowInputHObj();
        }

        #endregion

        #region 事件-Combobox控件

        /// <summary>
        /// 相机选择发生变化执行事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cbxSelectCam_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbxSelectCam.SelectedIndex < 0) { return; }
            mObj.mCamerasBase = mObj.mCamera.FirstOrDefault(c => c.mCamName == cbxSelectCam.Text);
        }

        #endregion

        #region 事件-RadioButton控件

        /// <summary>
        /// 图片来源发生变化执行事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="value"></param>
        private void rb_ValueChanged(object sender, bool value)
        {
            if (rbImage.Checked)
            {
                pnlImage.Visible = true;
                pnlCatalog.Visible = false;
                pnlCam.Visible = false;
            }
            else if (rbFolder.Checked)
            {
                pnlImage.Visible = false;
                pnlCatalog.Visible = true;
                pnlCam.Visible = false;
            }
            else if (rbCam.Checked)
            {
                pnlImage.Visible = false;
                pnlCatalog.Visible = false;
                pnlCam.Visible = true;
            }
        }

        #endregion

        #region 事件-DataGridView控件

        /// <summary>
        /// 图像列表点击事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dgvImage_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            mObj.index = dgvImage.CurrentRow.Index;
            dgvCurCellIndex = dgvImage.CurrentRow.Index;
            btn_Run.PerformClick();
        }

        #endregion

        #region 事件-MyLinkData控件

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
                    case "ldPiexlPrec":
                        ldPiexlPrec.TextInfo = m_IntStr[0] + ":" + m_IntStr[1];
                        break;
                }
            }
        }

        #endregion

        #region 事件-CheckBox事件

        /// <summary>
        /// 启用像素当量事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="value"></param>
        private void chxUsePiexlPrec_ValueChanged(object sender, bool value)
        {
            if (chxUsePiexlPrec.Checked)
            {
                lblPixelProc.Visible = true;
                ldPiexlPrec.Visible = true;
            }
            else
            {
                lblPixelProc.Visible = false;
                ldPiexlPrec.Visible = false;
            }
        }

        #endregion

        private void tableLayoutPanel4_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
