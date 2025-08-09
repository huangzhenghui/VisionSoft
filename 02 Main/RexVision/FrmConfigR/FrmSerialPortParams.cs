using MutualTools;
using Rex.UI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using VisionCore;

namespace TSIVision.FrmConfigR
{
    public partial class FrmSerialPortParams : Form
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
        /// 串口列表
        /// </summary>
        public static UIDataGridView dgvSerialPortList;

        /// <summary>
        /// 显示串口调试窗体
        /// </summary>
        public static FrmSerialPortDebug frmSerialPortDebug;

        /// <summary>
        /// 参数设置窗体1
        /// </summary>
        public FrmSerialPortParams_1 frmParams1;

        /// <summary>
        /// 参数设置窗体2
        /// </summary>
        public FrmSerialPortParams_2 frmParams2;

        /// <summary>
        /// 是否更改设备
        /// </summary>
        public bool isChangeCom = true;

        #endregion

        #region 初始化

        public FrmSerialPortParams()
        {
            InitializeComponent();
            frmParams1 = FrmConfigComm.frmSerialPortParams_1;
            frmParams2 = FrmConfigComm.frmSerialPortParams_2;
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

        #endregion

        #region 方法-显示串口参数
        /// <summary>
        /// 默认加载界面1
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public void DispSerialPortParams()
        {
            FrmRTools.ShowFrm(pnlParams, FrmConfigComm.frmSerialPortParams_1);
            swOpen.Active = ECom.mSerialPort.IsOpen;

            if (!ECom.mSerialPort.IsSendByHex)
            {
                cbxSendMode.Text = "字符";
            }
            else
            {
                cbxSendMode.Text = "十六进制";
            }

            if (!ECom.mSerialPort.IsReceivedByHex)
            {
                cbxReceiveMode.Text = "字符";
            }
            else
            {
                cbxReceiveMode.Text = "十六进制";
            }
        }

        #endregion

        #region 方法-窗体相关

        /// <summary>
        /// 更改状态图像
        /// </summary>
        /// <param name="img1"></param>
        /// <param name="img2"></param>
        /// <param name="img3"></param>
        public void ChangeImg(Image img1, Image img2, Image img3, Image img4, Image img5, Image img6, Image img7, Image img8)
        {
            FrmConfigComm.frmSerialPortParams_1.pbxJudge1.BackgroundImage = img1;
            FrmConfigComm.frmSerialPortParams_1.pbxJudge2.BackgroundImage = img2;
            FrmConfigComm.frmSerialPortParams_1.pbxJudge3.BackgroundImage = img3;
            FrmConfigComm.frmSerialPortParams_2.pbxJudge1.BackgroundImage = img4;
            FrmConfigComm.frmSerialPortParams_2.pbxJudge2.BackgroundImage = img5;
            FrmConfigComm.frmSerialPortParams_2.pbxJudge3.BackgroundImage = img6;
            pbxJudge4.BackgroundImage = img7;
            pbxJudge5.BackgroundImage = img8;
        }

        /// <summary>
        /// 显示执行结果
        /// </summary>
        /// <param name="isCtrl1Show"></param>
        /// <param name="isCtrl2Show"></param>
        /// <param name="content"></param>
        /// <param name="isReplace"></param>
        /// <param name="symbol"></param>
        /// <param name="color"></param>
        public void ShowResult(bool isCtrl1Show, bool isCtrl2Show, string content, bool isReplace, int symbol, Color color)
        {
            if (isCtrl1Show)
            {
                lblMsg.Visible = true;
                lblMsg.Text = content;
                lblMsg.Symbol = symbol;
                lblMsg.SymbolColor = color;
                lblMsg.ForeColor = color;
            }
            else
            {
                lblMsg.Visible = false;
            }

            if (isCtrl2Show)
            {
                btnYes.Visible = true;
                btnNo.Visible = true;

                if (isReplace)
                {
                    btnYes.Checked = true;
                    btnNo.Checked = true;
                }
                else
                {
                    btnYes.Checked = false;
                    btnNo.Checked = false;
                }
            }
            else
            {
                btnYes.Visible = false;
                btnNo.Visible = false;
            }
        }

        /// <summary>
        /// 隐藏控件
        /// </summary>
        public void HideCtrls(bool isHideBtn)
        {
            if (isHideBtn)
            {
                lblMsg.Visible = false;
                btnYes.Visible = false;
                btnNo.Visible = false;
                FrmConfigComm.frmSerialPortParams_1.pbxJudge1.BackgroundImage = null;
                FrmConfigComm.frmSerialPortParams_1.pbxJudge2.BackgroundImage = null;
                FrmConfigComm.frmSerialPortParams_1.pbxJudge3.BackgroundImage = null;
                FrmConfigComm.frmSerialPortParams_2.pbxJudge1.BackgroundImage = null;
                FrmConfigComm.frmSerialPortParams_2.pbxJudge2.BackgroundImage = null;
                FrmConfigComm.frmSerialPortParams_2.pbxJudge3.BackgroundImage = null;
            }

            pbxJudge4.BackgroundImage = null;
            pbxJudge4.BackgroundImage = null;
            pbxJudge5.BackgroundImage = null;
        }

        /// <summary>
        /// 移动窗体
        /// </summary>
        public void RestoreFrm()
        {
            Location = new Point(806, 342);
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

        #region 事件-按钮控件

        /// <summary>
        /// 工具栏按钮事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnToolBar_Click(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            switch (btn.Name)
            {
                case "btnSave":
                    bool isEmpty = true;
                    if (frmParams1.tbxName.Text == "")
                    {
                        frmParams1.pbxJudge1.BackgroundImage = Properties.Resources.Fail;
                        isEmpty = false;
                    }
                    else
                    {
                        frmParams1.pbxJudge1.BackgroundImage = Properties.Resources.Undetermined;
                    }

                    if (frmParams1.cbxSerialPortNum.Text == "")
                    {
                        frmParams1.pbxJudge2.BackgroundImage = Properties.Resources.Fail;
                        isEmpty = false;
                    }
                    else
                    {
                        frmParams1.pbxJudge2.BackgroundImage = Properties.Resources.Undetermined;
                    }

                    if (frmParams1.cbxBaudRate.Text == "")
                    {
                        frmParams1.pbxJudge3.BackgroundImage = Properties.Resources.Fail;
                        isEmpty = false;
                    }
                    else
                    {
                        frmParams1.pbxJudge3.BackgroundImage = Properties.Resources.Success;
                    }

                    if (frmParams2.cbxCheckBits.Text == "")
                    {
                        frmParams2.pbxJudge1.BackgroundImage = Properties.Resources.Fail;
                        isEmpty = false;
                    }
                    else
                    {
                        frmParams2.pbxJudge1.BackgroundImage = Properties.Resources.Success;
                    }

                    if (frmParams2.cbxDataBits.Text == "")
                    {
                        frmParams2.pbxJudge2.BackgroundImage = Properties.Resources.Fail;
                        isEmpty = false;
                    }
                    else
                    {
                        frmParams2.pbxJudge2.BackgroundImage = Properties.Resources.Success;
                    }

                    if (frmParams2.cbxStopBits.Text == "")
                    {
                        frmParams2.pbxJudge3.BackgroundImage = Properties.Resources.Fail;
                        isEmpty = false;
                    }
                    else
                    {
                        frmParams2.pbxJudge3.BackgroundImage = Properties.Resources.Success;
                    }

                    if (!isEmpty)
                    {
                        ShowResult(true, false, "参数为空", true, 61453, Color.Crimson);
                        return;
                    }

                    //检测是否修改连接设置

                    if (ECom.mSerialPort.DeviceName == frmParams1.tbxName.Text.Trim() && ECom.mSerialPort.SerialPortNum == frmParams1.cbxSerialPortNum.Text.Trim() && ECom.mSerialPort.BaudRate.ToString() == frmParams1.cbxBaudRate.Text
                        && ECom.mSerialPort.CheckBits.ToString() == frmParams2.cbxCheckBits.Text && ECom.mSerialPort.DataBits.ToString() == frmParams2.cbxDataBits.Text && ECom.mSerialPort.ShutBits.ToString() == frmParams2.cbxStopBits.Text)
                    {
                        bool isByHexS1 = false;
                        bool isByHexR1 = false;
                        if (cbxSendMode.Text == "十六进制") isByHexS1 = true;
                        if (cbxReceiveMode.Text == "十六进制") isByHexR1 = true;
                        CommParams commParams1 = new CommParams(frmParams1.cbxSerialPortNum.Text, Convert.ToInt32(frmParams1.cbxBaudRate.Text), (Parity)Enum.Parse(typeof(Parity), frmParams2.cbxCheckBits.Text), Convert.ToInt32(frmParams2.cbxDataBits.Text), (StopBits)Enum.Parse(typeof(StopBits), frmParams2.cbxStopBits.Text), isByHexS1, isByHexR1);
                        FrmConfigComm.ChangeCom(CommunicationModel.SerialPort, frmParams1.tbxName.Text.Trim(), commParams1);
                        ChangeImg(Properties.Resources.Success, Properties.Resources.Success, Properties.Resources.Success, Properties.Resources.Success, Properties.Resources.Success, Properties.Resources.Success, Properties.Resources.Success, Properties.Resources.Success);
                        isChangeCom = false;
                        return;
                    }

                    //判断客户端名称是否已经存在

                    int index1 = Sol.mSol.mEComList.FindIndex(c => c.DeviceName == frmParams1.tbxName.Text.Trim() && c.CommunicationModel == CommunicationModel.SerialPort);
                    if (index1 >= 0)
                    {
                        ChangeImg(Properties.Resources.Undetermined, Properties.Resources.Undetermined, Properties.Resources.Success, Properties.Resources.Success, Properties.Resources.Success, Properties.Resources.Success, Properties.Resources.Success, Properties.Resources.Success);
                        ShowResult(true, true, "名称重复", true, 61453, Color.Crimson);
                        return;
                    }

                    int index2 = Sol.mSol.mEComList.FindIndex(c => ((c.SerialPortNum == frmParams1.cbxSerialPortNum.Text.Trim())));
                    if (index2 >= 0)
                    {
                        ChangeImg(Properties.Resources.Undetermined, Properties.Resources.Undetermined, Properties.Resources.Success, Properties.Resources.Success, Properties.Resources.Success, Properties.Resources.Success, Properties.Resources.Success, Properties.Resources.Success);
                        ShowResult(true, true, "串口号重复", true, 61453, Color.Crimson);
                        return;
                    }

                    bool isByHexS2 = false;
                    bool isByHexR2 = false;
                    if (cbxSendMode.Text == "十六进制") isByHexS2 = true;
                    if (cbxReceiveMode.Text == "十六进制") isByHexR2 = true;
                    CommParams commParams2 = new CommParams(frmParams1.cbxSerialPortNum.Text, Convert.ToInt32(frmParams1.cbxBaudRate.Text), (Parity)Enum.Parse(typeof(Parity), frmParams2.cbxCheckBits.Text), Convert.ToInt32(frmParams2.cbxDataBits.Text), (StopBits)Enum.Parse(typeof(StopBits), frmParams2.cbxStopBits.Text), isByHexS2, isByHexR2);
                    FrmConfigComm.ChangeCom(CommunicationModel.TcpClient, frmParams1.tbxName.Text.Trim(), commParams2);
                    ChangeImg(Properties.Resources.Success, Properties.Resources.Success, Properties.Resources.Success, Properties.Resources.Success, Properties.Resources.Success, Properties.Resources.Success, Properties.Resources.Success, Properties.Resources.Success);
                    ShowResult(true, false, "修改成功", true, 61452, Color.LightSeaGreen);
                    break;
                case "btnClose":
                    try
                    {
                        if (frmSerialPortDebug != null) frmSerialPortDebug.Close();
                        Close();
                    }
                    catch { }

                    break;
            }
        }

        /// <summary>
        /// 打开调试界面
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnPageChange_Click(object sender, EventArgs e)
        {
            //隐藏控件
            HideCtrls(true);

            //显示服务器调试窗体
            int startPosX = 860;
            int startPosY = 342;
            Location = new Point(startPosX - 360, startPosY);
            if (frmSerialPortDebug == null || frmSerialPortDebug.IsDisposed)
            {
                frmSerialPortDebug = new FrmSerialPortDebug();
                frmSerialPortDebug.actRestoreFrm += RestoreFrm;
            }

            Point mouseOff = new Point(Location.X + Width + 1, Location.Y - 30);
            frmSerialPortDebug.Location = mouseOff;
            frmSerialPortDebug.StartPosition = FormStartPosition.Manual;
            frmSerialPortDebug.Show();
        }

        /// <summary>
        /// 切换参数页
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnParamsPage_Click(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            switch (btn.Name)
            {
                case "page1":
                    FrmRTools.ShowFrm(pnlParams, frmParams1);
                    break;
                case "page2":
                    FrmRTools.ShowFrm(pnlParams, frmParams2);
                    break;
                default:
                    break;
            }
        }

        /// <summary>
        /// 替换
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnYes_Click(object sender, EventArgs e)
        {
            if (btnYes.Checked)
            {
                bool isSendByHex = false;
                bool isReceiveByHex = false;
                if (cbxSendMode.Text == "十六进制") isSendByHex = true;
                if (cbxReceiveMode.Text == "十六进制") isSendByHex = true;

                CommParams commParams1 = new CommParams(frmParams1.cbxSerialPortNum.Text, Convert.ToInt32(frmParams1.cbxBaudRate.Text), (Parity)Enum.Parse(typeof(Parity),frmParams2.cbxCheckBits.Text),
                                                        Convert.ToInt32(frmParams2.cbxDataBits.Text), (StopBits)Enum.Parse(typeof(StopBits),frmParams2.cbxStopBits.Text), isSendByHex, isReceiveByHex);
                FrmConfigComm.ChangeCom(CommunicationModel.SerialPort, frmParams1.tbxName.Text.Trim(), commParams1);
                ChangeImg(Properties.Resources.Success, Properties.Resources.Success, Properties.Resources.Success, Properties.Resources.Success, Properties.Resources.Success, Properties.Resources.Success, Properties.Resources.Success, Properties.Resources.Success);
                ShowResult(true, false, "替换成功", true, 61452, Color.LightSeaGreen);

                isChangeCom = true;
            }
        }

        /// <summary>
        /// 取消
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnNo_Click(object sender, EventArgs e)
        {
            if (btnNo.Checked)
            {
                switch (lblMsg.Text)
                {
                    case "名称重复":
                        ChangeImg(Properties.Resources.Fail, Properties.Resources.Success, Properties.Resources.Success, Properties.Resources.Success, Properties.Resources.Success, Properties.Resources.Success, Properties.Resources.Success, Properties.Resources.Success);
                        ShowResult(true, true, "名称重复", true, 61453, Color.Crimson);
                        break;
                    case "IP/端口重复":
                        ChangeImg(Properties.Resources.Fail, Properties.Resources.Success, Properties.Resources.Success, Properties.Resources.Success, Properties.Resources.Success, Properties.Resources.Success, Properties.Resources.Success, Properties.Resources.Success);
                        ShowResult(true, true, "名称已存在", true, 61453, Color.Crimson);
                        break;
                }
            }
        }

        /// <summary>
        /// 鼠标离开保存按钮则隐藏控件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSave_MouseLeave(object sender, EventArgs e)
        {
            HideCtrls(!isChangeCom);
        }

        #endregion

        #region 事件-窗体控件

        /// <summary>
        /// 窗体位置改变
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FrmSerialPortParams_LocationChanged(object sender, EventArgs e)
        {
            if (frmSerialPortDebug == null) return;
            Point point = new Point();
            point.X = Location.X + Width + 1;
            point.Y = Location.Y - 30;
            frmSerialPortDebug.Location = point;
        }

        #endregion

        #region 事件-Switch控件

        /// <summary>
        /// 根据Switch控件值变化情况来创建服务器
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void swConnect_ValueChanged(object sender, bool value)
        {
            HideCtrls(true);
        }

        #endregion

        #region 事件-Timer控件

        /// <summary>
        /// 刷新连接状态
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void timer1_Tick(object sender, EventArgs e)
        {
            if (ECom.mSerialPort == null) { return; }
            if (ECom.mSerialPort.IsConnected)
            {
                lbConnState.Color = Color.MediumSpringGreen;
            }
            else
            {
                lbConnState.Color = Color.Crimson;
            }
        }

        #endregion

        private void swOpen_Click(object sender, EventArgs e)
        {
            if (ECom.mSerialPort == null) return;
            if (!swOpen.Active)
            {
                ECom.mSerialPort.IsOpen = true;
                ECom.mSerialPort.tSISerialPort.isOpen = true;
                ECom.mSerialPort.Connect();
            }
            else
            {
                ECom.mSerialPort.IsOpen = false;
                ECom.mSerialPort.tSISerialPort.isOpen = false;
                ECom.mSerialPort.DisConnect();
            }
        }
    }
}
