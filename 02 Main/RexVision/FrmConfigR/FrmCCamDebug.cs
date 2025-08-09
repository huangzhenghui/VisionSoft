using Rex.UI;
using RexView;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using VisionCore;
using WeifenLuo.WinFormsUI.Docking;

namespace TSIVision.FrmConfigR
{
    public partial class FrmCCamDebug : Form
    {
        #region 字段、属性

        /// <summary>
        /// 鼠标是否为左键
        /// </summary>
        private bool leftFlag;

        /// <summary>
        /// 鼠标移动位置变量
        /// </summary>
        private Point mouseOff;

        /// <summary>
        /// 是否显示图像
        /// </summary>
        public static Boolean isDisplayImg;

        /// <summary>
        /// 图像显示窗口
        /// </summary>
        public static HWindow_Fit hWnd;

        /// <summary>
        /// DataGridView对象
        /// </summary>
        public static UIDataGridView dgvCamList;

        /// <summary>
        /// 相机名称
        /// </summary>
        public static UITextBox tbxName;

        /// <summary>
        /// 相机序列号
        /// </summary>
        public static UITextBox tbxSN;

        /// <summary>
        /// 相机IP地址
        /// </summary>
        public static UITextBox tbxIP;

        /// <summary>
        /// 相机曝光
        /// </summary>
        public static UITextBox tbxExposure;

        /// <summary>
        /// 相机增益
        /// </summary>
        public static UITextBox tbxGain;

        /// <summary>
        /// 图片宽度
        /// </summary>
        public static UITextBox tbxWidth;

        /// <summary>
        /// 图片高度
        /// </summary>
        public static UITextBox tbxHeight;

        #endregion

        #region 初始化

        public FrmCCamDebug()
        {
            InitializeComponent();
            hWnd = mWindow;
        }

        #endregion

        #region 方法-防止窗体闪烁

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

        #endregion

        #region 事件-按钮控件

        /// <summary>
        /// 工具栏按钮事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_Click(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            switch (btn.Name)
            {
                case "btnClose":
                    this.Close();
                    this.Dispose();
                    break;
                case "btnCamParams":
                    //清空TextBox中内容
                    tbxName.Text = "";
                    tbxSN.Text = "";
                    tbxIP.Text = "";
                    tbxExposure.Text = "";
                    tbxGain.Text = "";

                    //将相机属性值赋给TextBox
                    if (CamerasBase.mCamerasBase == null)
                    {
                        MessageBox.Show("当前未连接相机！");
                        return;
                    }

                    tbxName.Text = CamerasBase.mCamerasBase.mCamName;
                    tbxSN.Text = CamerasBase.mCamerasBase.mSerialNo;
                    tbxIP.Text = CamerasBase.mCamerasBase.mCameraIP;
                    tbxExposure.Text = CamerasBase.mCamerasBase.mExposeTime.ToString();
                    tbxGain.Text = CamerasBase.mCamerasBase.mGain.ToString();
                    tbxWidth.Text = CamerasBase.mCamerasBase.mWidth.ToString();
                    tbxHeight.Text = CamerasBase.mCamerasBase.mHeight.ToString();

                    //显示参数窗体
                    Point mouseOff = new Point(Control.MousePosition.X, Control.MousePosition.Y);
                    FrmConfigCam.frmCCamParams.Location = mouseOff;
                    FrmConfigCam.frmCCamParams.StartPosition = FormStartPosition.Manual;
                    FrmConfigCam.frmCCamParams.ShowDialog();
                    break;
                default:
                    break;
            }
        }

        /// <summary>
        /// 功能按钮事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void uibtn_Click(object sender, EventArgs e)
        {
            UIButton uibtn = sender as UIButton;
            switch (uibtn.Name)
            {
                case "btnConnect":
                    CamerasBase.mCamerasBase.isReConnCam = false;
                    while (true)
                    {
                        if (CamerasBase.mCamerasBase.isExeOver)
                        {
                            break;
                        }
                        Thread.Sleep(50);
                    }

                    if (CamerasBase.mCamerasBase == null) 
                    { 
                        return; 
                    }

                    CamerasBase.mCamerasBase.ConnectDev();
                    if (CamerasBase.mCamerasBase.mConnected == true)
                    {
                        CamerasBase.mCamerasBase.isApply = true;
                        btnConnect.Enabled = false;
                        btnTrigger.Enabled = true;
                        btnStop.Enabled = false;
                        btnDisconnect.Enabled = true;
                        mWindow.label.ForeColor = Color.ForestGreen;
                        mWindow.label.Text = "相机已连接";
                    }
                    else
                    {
                        mWindow.label.ForeColor = Color.Crimson;
                        mWindow.label.Text = "相机未连接";
                    }

                    CamerasBase.mCamerasBase.isReConnCam = true;
                    break;
                case "btnTrigger":
                    CamerasBase.mCamerasBase.isReConnCam = false;
                    while (true)
                    {
                        if (CamerasBase.mCamerasBase.isExeOver)
                        {
                            break;
                        }
                        Thread.Sleep(50);
                    }

                    if (CamerasBase.mCamerasBase == null) 
                    { 
                        return; 
                    }

                    if (CamerasBase.mCamerasBase.mConnected == false)
                    {
                        MessageBox.Show("相机未连接！");
                        return;
                    }

                    isDisplayImg = true;
                    CamerasBase.mCamerasBase.CaptureImage(false);
                    mWindow.Enabled = true;
                    btnConnect.Enabled = false;
                    btnTrigger.Enabled = false;
                    btnStop.Enabled = true;
                    btnDisconnect.Enabled = true;
                    mWindow.label.ForeColor = Color.MidnightBlue;
                    CamerasBase.mCamerasBase.isReConnCam = true;
                    break;
                case "btnStop":
                    CamerasBase.mCamerasBase.isReConnCam = false;
                    while (true)
                    {
                        if (CamerasBase.mCamerasBase.isExeOver)
                        {
                            break;
                        }
                        Thread.Sleep(50);
                    }

                    if (CamerasBase.mCamerasBase == null)
                    {
                        return;
                    }

                    if (CamerasBase.mCamerasBase.mConnected==true && CamerasBase.mCamerasBase.mTrigState == true)
                    {
                        CamerasBase.mCamerasBase.StopCapture();
                        btnConnect.Enabled = false;
                        btnTrigger.Enabled = true;
                        btnStop.Enabled = false;
                        btnDisconnect.Enabled = true;
                    }
                    CamerasBase.mCamerasBase.isReConnCam = true;
                    break;
                case "btnDisconnect":
                    CamerasBase.mCamerasBase.isReConnCam = false;
                    while (true)
                    {
                        if (CamerasBase.mCamerasBase.isExeOver)
                        {
                            break;
                        }
                        Thread.Sleep(50);
                    }

                    if (CamerasBase.mCamerasBase == null)
                    {
                        return;
                    }

                    if (CamerasBase.mCamerasBase.mConnected == true)
                    {
                        if (CamerasBase.mCamerasBase.mTrigState)
                        {
                            CamerasBase.mCamerasBase.StopCapture();
                        }
                        CamerasBase.mCamerasBase.DisConnectDev();
                        CamerasBase.mCamerasBase.isApply = false;
                        mWindow.Image = null;
                        mWindow.HWindowID.ClearWindow();
                        btnConnect.Enabled = true;
                        btnTrigger.Enabled = false;
                        btnStop.Enabled = false;
                        btnDisconnect.Enabled = false;
                        mWindow.label.ForeColor = Color.Crimson;
                        mWindow.label.Text = "相机未连接";
                    }
                    CamerasBase.mCamerasBase.isReConnCam = true;
                    break;
                default:
                    break;
            }
        }

        #endregion

        #region 事件-窗体控件
        /// <summary>
        /// 关闭窗体时停止采集
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FrmCCamDebug_FormClosed(object sender, FormClosedEventArgs e)
        {
            if(CamerasBase.mCamerasBase.mTrigState == true)
            {
                CamerasBase.mCamerasBase.StopCapture();
            }
        }

        /// <summary>
        /// 加载窗体时设置按钮状态
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FrmCCamDebug_Load(object sender, EventArgs e)
        {
            if (CamerasBase.mCamerasBase == null) return;
            if (CamerasBase.mCamerasBase.mConnected == true)
            {
                btnConnect.Enabled = false;
                btnTrigger.Enabled = true;
                btnStop.Enabled = false;
                btnDisconnect.Enabled = true;
                mWindow.label.ForeColor = Color.ForestGreen;
                mWindow.label.Text = "相机已连接";
            }
            else
            {
                btnConnect.Enabled = true;
                btnTrigger.Enabled = false;
                btnStop.Enabled = false;
                btnDisconnect.Enabled = false;
                mWindow.label.ForeColor = Color.Crimson;
                mWindow.label.Text = "相机未连接";
            }
        }

        #endregion

        #region 事件-实现窗体移动功能

        /// <summary>
        /// 获取鼠标按下时坐标
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FrmCCamDebug_MouseDown(object sender, MouseEventArgs e)
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
        private void FrmCCamDebug_MouseMove(object sender, MouseEventArgs e)
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
        private void FrmCCamDebug_MouseUp(object sender, MouseEventArgs e)
        {
            if (leftFlag)
            {
                leftFlag = false;
            }
        }

        #endregion
    }
}
