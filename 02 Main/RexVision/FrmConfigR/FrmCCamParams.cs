using MutualTools;
using NPOI.SS.UserModel;
using Rex.UI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using VisionCore;

namespace TSIVision.FrmConfigR
{
    public partial class FrmCCamParams : Form
    {
        private bool leftFlag;//鼠标是否为左键
        private Point mouseOff;//鼠标移动位置变量

        public FrmCCamParams()
        {
            InitializeComponent();
            FrmCCamDebug.tbxName = tbxName;
            FrmCCamDebug.tbxSN = tbxSN;
            FrmCCamDebug.tbxIP = tbxIP;
            FrmCCamDebug.tbxExposure = tbxExposure;
            FrmCCamDebug.tbxGain = tbxGain;
            FrmCCamDebug.tbxWidth = tbxWidth;
            FrmCCamDebug.tbxHeight = tbxHeight;

            tbxName.FillColor = Color.AliceBlue;
            tbxName.FillDisableColor = Color.AliceBlue;
            tbxName.RectColor = Color.AliceBlue;
            tbxName.RectDisableColor= Color.AliceBlue;
            tbxSN.FillColor = Color.AliceBlue;
            tbxSN.FillDisableColor = Color.AliceBlue;
            tbxSN.RectColor = Color.AliceBlue;
            tbxSN.RectDisableColor = Color.AliceBlue;
            tbxIP.FillColor = Color.AliceBlue;
            tbxIP.FillDisableColor = Color.AliceBlue;
            tbxIP.RectColor = Color.AliceBlue;
            tbxIP.RectDisableColor = Color.AliceBlue;
            tbxExposure.FillColor = Color.AliceBlue;
            tbxExposure.FillDisableColor = Color.AliceBlue;
            tbxExposure.RectColor = Color.AliceBlue;
            tbxExposure.RectDisableColor = Color.AliceBlue;
            tbxGain.FillColor = Color.AliceBlue;
            tbxGain.FillColor = Color.AliceBlue;
            tbxGain.RectColor = Color.AliceBlue;
            tbxGain.RectDisableColor = Color.AliceBlue;
            tbxWidth.FillColor = Color.AliceBlue;
            tbxWidth.FillColor = Color.AliceBlue;
            tbxWidth.RectColor = Color.AliceBlue;
            tbxWidth.RectDisableColor = Color.AliceBlue;
            tbxHeight.FillColor = Color.AliceBlue;
            tbxHeight.FillColor = Color.AliceBlue;
            tbxHeight.RectColor = Color.AliceBlue;
            tbxHeight.RectDisableColor = Color.AliceBlue;
        }

        /// <summary>
        /// 重写CreateParams方法，以防止窗体闪烁
        /// </summary>
        protected override CreateParams CreateParams
        {
            get
            {
                CreateParams paras = base.CreateParams;
                paras.ExStyle |= 0x02000000;
                return paras;
            }
        }

        /// <summary>
        /// 设置所有控件双缓存绘制，以防止闪烁
        /// </summary>
        /// <param name="fatherControl"></param>
        public static void SetDoubleBuffer(Control fatherControl)
        {
            foreach (Control control in fatherControl.Controls)
            {
                control.DoubleBuffered(true);
            }
        }

        #region 事件-移动窗体

        /// <summary>
        /// 获取鼠标按下时坐标
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FrmCCamParams_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                mouseOff = new Point(e.X, e.Y);//获得当前鼠标的坐标
                leftFlag = true;
            }
        }

        /// <summary>
        /// 将窗体跟随鼠标移动
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FrmCCamParams_MouseMove(object sender, MouseEventArgs e)
        {
            if (leftFlag)
            {
                Point mouseSet = Control.MousePosition;//获得移动后鼠标的坐标
                mouseSet.Offset(-mouseOff.X, -mouseOff.Y);//设置移动后的位置
                Location = mouseSet;
            }
        }

        /// <summary>
        /// 鼠标抬起将标志位置为false
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FrmCCamParams_MouseUp(object sender, MouseEventArgs e)
        {
            if (leftFlag)
            {
                leftFlag = false;
            }
        }

        #endregion

        private void btn_Click(object sender,EventArgs e)
        {
            bool isSave = true;
            Button btn = sender as Button;
            switch (btn.Name)
            {
                case "btnSave":
                    if (CamerasBase.mCamerasBase.mConnected==false)
                    {
                        MessageBox.Show("相机未连接，参数保存失败！");
                        return;
                    }

                    bool result1 = RegExTools.RegExIP(tbxIP.Text.Trim());
                    bool result2 = RegExTools.RegExNum(tbxExposure.Text.Trim());
                    bool result3 = RegExTools.RegExInt_Deouble(tbxGain.Text.Trim());
                    pbxJudge1.BackgroundImage = Properties.Resources.Success;
                    pbxJudge2.BackgroundImage = Properties.Resources.Success;

                    if (result1 == true)
                    {
                        pbxJudge3.BackgroundImage = Properties.Resources.Success;
                    }
                    else
{
                        isSave = false;
                        pbxJudge3.BackgroundImage = Properties.Resources.Fail;
                    }

                    if (result2 == true)
                    {
                        pbxJudge4.BackgroundImage = Properties.Resources.Success;
                    }
                    else
                    {
                        isSave = false;
                        pbxJudge4.BackgroundImage = Properties.Resources.Fail;
                    }

                    if (result3 == true)
                    {
                        pbxJudge5.BackgroundImage = Properties.Resources.Success;
                    }
                    else
                    {
                        isSave = false;
                        pbxJudge5.BackgroundImage = Properties.Resources.Fail;
                    }

                    pbxJudge6.BackgroundImage = Properties.Resources.Success;
                    pbxJudge7.BackgroundImage = Properties.Resources.Success;

                    if (isSave)
                    {
                        CamerasBase.mCamerasBase.mCamName = tbxName.Text;
                        CamerasBase.mCamerasBase.mSerialNo = tbxSN.Text;
                        CamerasBase.mCamerasBase.mCameraIP = tbxIP.Text;
                        CamerasBase.mCamerasBase.mExposeTime = float.Parse(tbxExposure.Text);
                        CamerasBase.mCamerasBase.mGain = float.Parse(tbxGain.Text);
                        CamerasBase.mCamerasBase.mWidth = int.Parse(tbxWidth.Text);
                        CamerasBase.mCamerasBase.mHeight = int.Parse(tbxHeight.Text);
                        CamerasBase.mCamerasBase.SetCamParams();
                    }

                    break;
                case "btnClose":
                    this.Hide();
                    break;
                default:
                    break;
            }
        }
    }
}
