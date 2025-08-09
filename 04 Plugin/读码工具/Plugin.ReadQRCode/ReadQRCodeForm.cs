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

namespace Plugin.ReadQRCode
{
    public partial class ReadQRCodeForm : FormBase
    {
        #region 字段、属性

        /// <summary>
        /// 模块对象
        /// </summary>
        ReadQRCodeObj mObj = new ReadQRCodeObj();

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
        public ReadQRCodeForm(ReadQRCodeObj Obj) : base(Obj)
        {
            InitializeComponent();
            chxShowReg.ForeColor = Color.FromArgb(100, 100, 100);
            chxShowData.ForeColor = Color.FromArgb(100, 100, 100);
            tbxTimeOut.FillColor = Color.AliceBlue;
            tbxTimeOut.RectColor = Color.AliceBlue;
            tbxTimeOut.ForeColor = Color.FromArgb(100, 100, 100);
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
            if (mObj.readQRCode_Info.qrCodeReg != null)
            {
                //绘制显示图形
                HOperatorSet.DispObj(mObj.readQRCode_Info.qrCodeReg, mWindowH.HWindowHalconID);
                mWindowH.DispObj(mObj.readQRCode_Info.qrCodeReg, mObj.resultColor);
            }

            //绘制文本
            string text;
            if (mObj.prefix != "")
            {
                text = mObj.prefix + ":" + mObj.readQRCode_Info.qrCodeData;
            }
            else
            {
                text = mObj.readQRCode_Info.qrCodeData;
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
            //tab1
            mObj.mImages = ldImage.TextInfo.Trim();
            mObj.mode = cbxMode.Text;
            mObj.codeType = cbxCodeType.Text;
            mObj.polarity = cbxPolarity.Text;
            mObj.robustness = cbxRobustness.Text;
            mObj.timeOut = double.Parse(tbxTimeOut.Text.Trim());

            //tab2
            mObj.isShowReg = chxShowReg.Checked;
            mObj.isShowData = chxShowData.Checked;
            mObj.X = double.Parse(tbxX.TextInfo.Trim());
            mObj.Y = double.Parse(tbxY.TextInfo.Trim());
            mObj.fontSize = int.Parse(tbxFontSize.TextInfo.Trim());
            mObj.fontType = cbxFontStye.Text;
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
            cbxMode.Text = mObj.mode;
            cbxCodeType.Text = mObj.codeType;
            cbxPolarity.Text = mObj.polarity;
            cbxRobustness.Text = mObj.robustness;
            tbxTimeOut.Text = mObj.timeOut.ToString();

            //Tab2
            chxShowReg.Checked = mObj.isShowReg;
            chxShowData.Checked = mObj.isShowData;
            tbxX.TextInfo = mObj.X.ToString();
            tbxY.TextInfo = mObj.Y.ToString();
            tbxFontSize.TextInfo = mObj.fontSize.ToString();
            cbxFontStye.Text = mObj.fontType;
            tbxPrefix.Text = mObj.prefix.ToString();
            cpColor.Value = ColorTranslator.FromHtml(mObj.resultColor);
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
            ShowImage();
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
        /// 窗体加载事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ReadBarcodeForm_Load(object sender, EventArgs e)
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
        }

        #endregion
    }
}
