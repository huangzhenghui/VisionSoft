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
using System.Drawing.Text;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using VisionCore;
using static System.Net.Mime.MediaTypeNames;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace Plugin.OCR
{
    public partial class OCRForm : FormBase
    {
        #region 字段、属性

        /// <summary>
        /// 模块对象
        /// </summary>
        OCRObj mObj;

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
        public OCRForm(OCRObj Obj) : base(Obj)
        {
            InitializeComponent();
            mObj = Obj;

            tbxCharacterName.RectColor = Color.AliceBlue;
            tbxCharacterName.FillColor = Color.AliceBlue;
            tbxCharacterName.ForeColor = Color.FromArgb(100, 100, 100);
            chxShow.ForeColor = Color.FromArgb(100, 100, 100);
            chxDelFile.ForeColor = Color.FromArgb(100, 100, 100);
        }

        #endregion

        #region 方法-窗口显示相关

        /// <summary>
        /// 窗口显示
        /// </summary>
        protected void FormDisplay()
        {
            ShowProcImg();
            ShowHObj();
        }

        /// <summary>
        /// 显示处理图像
        /// </summary>
        public void ShowProcImg()
        {
            //获取图像
            mObj.procImageName = ldProcImage.TextInfo;
            if (mObj.procImageName == null) return;
            mObj.procImage = (RImage)Var.GetImage(mObj.mSloVar, mObj.procImageName);

            //显示图像
            if (mObj.procImage == null) return;
            mWindowH.HobjectToHimage(mObj.procImage);
        }

        /// <summary>
        /// 显示训练图像
        /// </summary>
        public void ShowTrainImage()
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
            HOperatorSet.SetColored(mWindowH.hControl.HalconWindow, 12);
            if (mObj.procReg != null)
            {
                //绘制显示图形
                HOperatorSet.DispObj(mObj.procReg, mWindowH.HWindowHalconID);
                mWindowH.DispObj(mObj.procReg);
            }

            //绘制文本
            string info = "";
            string text = "";

            for (int i = 0; i < mObj.OCR_Info.OCRData.Length; i++)
            {
                if (i == 0)
                {
                    info = mObj.OCR_Info.OCRData[i];
                }
                else
                {
                    info = info + " " + mObj.OCR_Info.OCRData[i];
                }

            }

            if (mObj.prefix != "")
            {
                text = mObj.prefix + ":" + info;
            }
            else
            {
                text = info;
            }

            ShowTool.SetFont(mWindowH.hControl.HalconWindow, mObj.fontSize, mObj.fontType, "false", "false");
            ShowTool.SetMsg(mWindowH.hControl.HalconWindow, text, "window", 10, 10, mObj.resultColor, "false");
        }

        #endregion

        #region 方法-对象保存加载相关

        /// <summary>
        /// 将窗体的值保存到模块对象中
        /// </summary>
        public override void FormToObj()
        {
            HTuple word = new HTuple();

            //tab1
            mObj.mImages = ldImage.TextInfo.Trim();
            mObj.fileScource = cbxFileSource.Text.Trim();
            mObj.fileRPath = tbxFileRPath.Text.Trim();
            mObj.fileCPath = tbxFileCPath.Text.Trim();
            mObj.characterRegName = ldCharacterReg.TextInfo.Trim();

            string[] str = tbxCharacterName.Text.Trim().Split(',');
            for (int i = 0; i < str.Length; i++)
            {
                word.Append(str[i]);
            }
            mObj.characterName = word;

            //tab2
            mObj.procImageName = ldProcImage.TextInfo.Trim();
            mObj.procRegName = ldProcIReg.TextInfo.Trim();

            //tab3
            mObj.isShowData = chxShow.Checked;
            mObj.X = double.Parse(tbxX.TextInfo.Trim());
            mObj.Y = double.Parse(tbxY.TextInfo.Trim());
            mObj.fontSize = int.Parse(tbxFontSize.TextInfo.Trim());
            mObj.fontType = cbxFontStye.Text;
            mObj.prefix = tbxPrefix.Text.Trim();
            mObj.resultColor = ColorTranslator.ToHtml(cpColor.Value);
            mObj.isSave = chxDelFile.Checked;

            mObj.GetData();
        }

        /// <summary>
        /// 将模块对象中的值加载到窗体中
        /// </summary>
        public override void ObjToForm()
        {
            string word = "";

            //Tab1
            ldImage.TextInfo = mObj.mImages;
            cbxFileSource.Text = mObj.fileScource;
            tbxFileRPath.Text = mObj.fileRPath;
            tbxFileCPath.Text = mObj.fileCPath;
            ldCharacterReg.TextInfo = mObj.characterRegName;

            for (int i = 0; i < mObj.characterName.Length; i++)
            {
                if (i == 0)
                {
                    word = mObj.characterName[i];
                }
                else
                {
                    word = word + "," + mObj.characterName[i];
                }
            }
            tbxCharacterName.Text = word;

            //tab2
            ldProcImage.TextInfo = mObj.procImageName;
            ldProcIReg.TextInfo = mObj.procRegName;

            //Tab3
            chxShow.Checked = mObj.isShowData;
            tbxX.TextInfo = mObj.X.ToString();
            tbxY.TextInfo = mObj.Y.ToString();
            tbxFontSize.TextInfo = mObj.fontSize.ToString();
            cbxFontStye.Text = mObj.fontType;
            tbxPrefix.Text = mObj.prefix.ToString();
            cpColor.Value = ColorTranslator.FromHtml(mObj.resultColor);
            chxDelFile.Checked = mObj.isSave;
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
            MyLinkData myLinkData = sender as MyLinkData;
            PluginDataLinkForm LikeDataForm = new PluginDataLinkForm(mObj.ProjName, mObj.ModInfo.Name);
            LikeDataForm.dataType = "RImage";
            LikeDataForm.ShowDialog();
            if (LikeDataForm.m_OutLinkData.Length > 3)
            {
                string[] m_IntStr = LikeDataForm.m_OutLinkData.Split('|');
                switch (myLinkData.Name)
                {
                    case "ldImage":
                        ldImage.TextInfo = m_IntStr[0] + ":" + m_IntStr[1];
                        ShowTrainImage();
                        break;
                    case "ldProcImage":
                        ldProcImage.TextInfo = m_IntStr[0] + ":" + m_IntStr[1];
                        break;
                }
            }
        }

        /// <summary>
        /// HObject型数据链接
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ldHObject_LinkData(object sender, EventArgs e)
        {
            MyLinkData myLinkData = sender as MyLinkData;
            PluginDataLinkForm LikeDataForm = new PluginDataLinkForm(mObj.ProjName, mObj.ModInfo.Name);
            LikeDataForm.dataType = "HObject";
            LikeDataForm.ShowDialog();
            if (LikeDataForm.m_OutLinkData.Length > 3)
            {
                string[] m_IntStr = LikeDataForm.m_OutLinkData.Split('|');
                switch (myLinkData.Name)
                {
                    case "ldCharacterReg":
                        ldCharacterReg.TextInfo = m_IntStr[0] + ":" + m_IntStr[1];
                        break;
                    case "ldProcImage":
                        ldProcImage.TextInfo = m_IntStr[0] + ":" + m_IntStr[1];
                        break;
                    case "ldProcIReg":
                        ldProcIReg.TextInfo = m_IntStr[0] + ":" + m_IntStr[1];
                        break;
                }
            }
            FormToObj();
        }

        #endregion

        #region 事件-ComboBox事件

        /// <summary>
        /// 训练文件来源改变
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cbxFileSource_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (cbxFileSource.Text)
            {
                case "创建":
                    pnl1.Visible = false;
                    pnl2.Visible = true;
                    break;
                case "读取":
                    pnl1.Visible = true;
                    pnl2.Visible = false;
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

        /// <summary>
        /// 文件读取路径链接
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnFileRPathLink_Click(object sender, EventArgs e)
        {
            OpenFileDialog fileDialog = new OpenFileDialog();
            fileDialog.Title = "请选择文件";
            fileDialog.Filter = "所有文件(*.*)|*.*|训练文件(*.trf)|*.trf";
            if (fileDialog.ShowDialog() == DialogResult.OK)
            {
                tbxFileRPath.Text = fileDialog.FileName;
            }
        }

        /// <summary>
        /// 文件创建路径链接
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnFileCPathLink_Click(object sender, EventArgs e)
        {
            SaveFileDialog fileDialog = new SaveFileDialog();
            fileDialog.Title = "请选择文件";
            fileDialog.Filter = "所有文件(*.*)|*.*|训练文件(*.trf)|*.trf";
            if (fileDialog.ShowDialog() == DialogResult.OK)
            {
                tbxFileCPath.Text = fileDialog.FileName;
            }
        }

        #endregion

        #region 事件-窗体控件

        /// <summary>
        /// 窗体加载
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void OCRForm_Load(object sender, EventArgs e)
        {
            switch (cbxFileSource.Text)
            {
                case "创建":
                    pnl1.Visible = false;
                    pnl2.Visible = true;
                    break;
                case "读取":
                    pnl1.Visible = true;
                    pnl2.Visible = false;
                    break;
            }

            FontFamily[] fontFamilies;
            cbxFontStye.Items.Clear();
            InstalledFontCollection installedFontCollection = new InstalledFontCollection();
            fontFamilies = installedFontCollection.Families;
            int count = fontFamilies.Length;
            for (int j = 0; j < count; ++j)
            {
                cbxFontStye.Items.Add(fontFamilies[j].Name);
            }
        }

        #endregion
    }
}
