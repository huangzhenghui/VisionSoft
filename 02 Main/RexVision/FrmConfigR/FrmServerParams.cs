using MutualTools;
using NPOI.SS.UserModel;
using Rex.UI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using VisionCore;

namespace TSIVision.FrmConfigR
{
    public partial class FrmServerParams : Form
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
        /// 服务器列表
        /// </summary>
        public static UIDataGridView dgvServerList;

        /// <summary>
        /// 显示服务器调试窗体
        /// </summary>
        public static FrmServerDebug frmServerDebug;

        /// <summary>
        /// 是否更改设备
        /// </summary>
        public bool isChangeCom = true;

        #endregion

        #region 初始化

        public FrmServerParams()
        {
            InitializeComponent();
            tbxName.RectColor = Color.AliceBlue;
            tbxName.FillColor = Color.AliceBlue;
            tbxLocIP.RectColor = Color.AliceBlue;
            tbxLocIP.FillColor = Color.AliceBlue;
            tbxLocPort.RectColor = Color.AliceBlue;
            tbxLocPort.FillColor = Color.AliceBlue;
        }

        #endregion

        #region 方法-显示服务端参数

        /// <summary>
        /// 显示服务器参数
        /// </summary>
        public void DispServerParams()
        {
            swOpen.Active = ECom.mServer.IsOpen;
            tbxName.Text = ECom.mServer.DeviceName;
            tbxLocIP.Text = ECom.mServer.IP;
            tbxLocPort.Text = ECom.mServer.Port.ToString();
            switch (ECom.mServer.EndData)
            {
                case "\n":
                    cbxEndData.Text = "\\n";
                    break;
                case "\r":
                    cbxEndData.Text = "\\r";
                    break;
                case "\r\n":
                    cbxEndData.Text = "\\r\\n";
                    break;
            }

            if (!ECom.mServer.IsSendByHex)
            {
                cbxSendMode.Text = "字符";
            }
            else
            {
                cbxSendMode.Text = "十六进制";
            }

            if (!ECom.mServer.IsReceivedByHex)
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
        public void ChangeImg(Image img1, Image img2, Image img3, Image img4, Image img5, Image img6)
        {
            pbxJudge1.BackgroundImage = img1;
            pbxJudge2.BackgroundImage = img2;
            pbxJudge3.BackgroundImage = img3;
            pbxJudge4.BackgroundImage = img4;
            pbxJudge5.BackgroundImage = img5;
            pbxJudge6.BackgroundImage = img6;
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
                pbxJudge1.BackgroundImage = null;
                pbxJudge2.BackgroundImage = null;
                pbxJudge3.BackgroundImage = null;
            }

            pbxJudge4.BackgroundImage = null;
            pbxJudge5.BackgroundImage = null;
            pbxJudge6.BackgroundImage = null;
        }

        /// <summary>
        /// 移动窗体
        /// </summary>
        public void RestoreFrm()
        {
            Location = new Point(806, 342);
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
                    if (tbxName.Text == "")
                    {
                        pbxJudge1.BackgroundImage = Properties.Resources.Fail;
                        isEmpty = false;
                    }
                    else
                    {
                        pbxJudge1.BackgroundImage = Properties.Resources.Undetermined;
                    }

                    if (tbxLocIP.Text == "")
                    {
                        pbxJudge2.BackgroundImage = Properties.Resources.Fail;
                        isEmpty = false;
                    }
                    else
                    {
                        pbxJudge2.BackgroundImage = Properties.Resources.Undetermined;
                    }

                    if (tbxLocalPort.Text == "")
                    {
                        pbxJudge3.BackgroundImage = Properties.Resources.Fail;
                        isEmpty = false;
                    }
                    else
                    {
                        pbxJudge3.BackgroundImage = Properties.Resources.Undetermined;
                    }

                    if (!isEmpty)
                    {
                        ShowResult(true, false, "参数为空", true, 61453, Color.Crimson);
                        return;
                    }

                    //判断IP是否为本机IP

                    List<string> ipList = new List<string>();
                    IPGlobalProperties computerProperties = IPGlobalProperties.GetIPGlobalProperties();
                    NetworkInterface[] nics = NetworkInterface.GetAllNetworkInterfaces();
                    foreach (NetworkInterface adapter in nics)
                    {
                        IPInterfaceProperties properties = adapter.GetIPProperties();
                        IPAddress ip = properties.UnicastAddresses[properties.UnicastAddresses.Count - 1].Address;
                        ipList.Add(ip.ToString());
                    }

                    string iPAddress = ipList.FirstOrDefault(c => c.ToString() == tbxLocIP.Text);
                    if (iPAddress == null)
                    {
                        ChangeImg(Properties.Resources.Undetermined, Properties.Resources.Fail, Properties.Resources.Undetermined, Properties.Resources.Success, Properties.Resources.Success, Properties.Resources.Success);
                        ShowResult(true, false, "非本机IP", true, 61453, Color.Crimson);
                        return;
                    }

                    //判断端口是否超出上限

                    if (Convert.ToDouble(tbxLocalPort.Text) > 65535)
                    {
                        ChangeImg(Properties.Resources.Undetermined, Properties.Resources.Undetermined, Properties.Resources.Fail, Properties.Resources.Success, Properties.Resources.Success, Properties.Resources.Success);
                        ShowResult(true, false, "端口超上限", true, 61453, Color.Crimson);
                        return;
                    }

                    //检测是否修改连接设置

                    if (ECom.mServer.DeviceName == tbxName.Text.Trim() && ECom.mServer.IP == tbxLocIP.Text.Trim() && ECom.mServer.Port.ToString() == tbxLocPort.Text.Trim())
                    {
                        string endData1 = "\n";
                        switch (cbxEndData.Text)
                        {
                            case "\\n":
                                ECom.mServer.EndData = "\n";
                                break;
                            case "\\r":
                                ECom.mServer.EndData = "\r";
                                break;
                            case "\\r\\n":
                                ECom.mServer.EndData = "\r\n";
                                break;
                        }

                        bool isByHexS1 = false;
                        bool isByHexR1 = false;
                        if (cbxSendMode.Text == "十六进制") isByHexS1 = true;
                        if (cbxReceiveMode.Text == "十六进制") isByHexR1 = true;
                        FrmConfigComm.ChangeCom(CommunicationModel.TcpServer, tbxName.Text.Trim(), new CommParams(tbxLocIP.Text, Convert.ToInt32(tbxLocPort.Text), endData1, isByHexS1, isByHexR1));
                        ChangeImg(Properties.Resources.Success, Properties.Resources.Success, Properties.Resources.Success, Properties.Resources.Success, Properties.Resources.Success, Properties.Resources.Success);
                        isChangeCom = false;
                        return;
                    }

                    //判断服务器名称是否已经存在

                    int index1 = Sol.mSol.mEComList.FindIndex(c => c.DeviceName == tbxName.Text.Trim() && c.CommunicationModel == CommunicationModel.TcpServer);
                    if (index1 >= 0)
                    {
                        ChangeImg(Properties.Resources.Undetermined, Properties.Resources.Undetermined, Properties.Resources.Undetermined, Properties.Resources.Success, Properties.Resources.Success, Properties.Resources.Success);
                        ShowResult(true, true, "名称重复", true, 61453, Color.Crimson);
                        return;
                    }

                    int index2 = Sol.mSol.mEComList.FindIndex(c => ((c.IP == tbxLocIP.Text.Trim()) && (c.Port.ToString() == tbxLocalPort.Text.Trim())));
                    if (index2 >= 0)
                    {
                        ChangeImg(Properties.Resources.Undetermined, Properties.Resources.Undetermined, Properties.Resources.Undetermined, Properties.Resources.Success, Properties.Resources.Success, Properties.Resources.Success);
                        ShowResult(true, true, "IP/端口重复", true, 61453, Color.Crimson);
                        return;
                    }
                  
                    string endData2 = "\n";
                    switch (cbxEndData.Text)
                    {
                        case "\\n":
                            ECom.mServer.EndData = "\n";
                            break;
                        case "\\r":
                            ECom.mServer.EndData = "\r";
                            break;
                        case "\\r\\n":
                            ECom.mServer.EndData = "\r\n";
                            break;
                    }

                    bool isByHexS2 = false;
                    bool isByHexR2 = false;
                    if (cbxSendMode.Text == "十六进制") isByHexS2 = true;
                    if (cbxReceiveMode.Text == "十六进制") isByHexR2 = true;
                    FrmConfigComm.ChangeCom(CommunicationModel.TcpServer, tbxName.Text.Trim(), new CommParams(tbxLocIP.Text, Convert.ToInt32(tbxLocPort.Text), endData2, isByHexS2, isByHexR2));
                    ChangeImg(Properties.Resources.Success, Properties.Resources.Success, Properties.Resources.Success, Properties.Resources.Success, Properties.Resources.Success, Properties.Resources.Success);
                    ShowResult(true, false, "修改成功", true, 61452, Color.LightSeaGreen);
                    break;
                case "btnClose":
                    if (frmServerDebug != null) frmServerDebug.Close();
                    Close();
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
            if (frmServerDebug == null || frmServerDebug.IsDisposed)
            {
                frmServerDebug = new FrmServerDebug();
                frmServerDebug.actRestoreFrm += RestoreFrm;
            }

            Point mouseOff = new Point(Location.X + Width + 1, Location.Y - 30);
            frmServerDebug.Location = mouseOff;
            frmServerDebug.StartPosition = FormStartPosition.Manual;
            frmServerDebug.Show();
        }

        /// <summary>
        /// 开启/关闭连接
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void swOpen_Click(object sender, EventArgs e)
        {
            if (ECom.mServer == null) return;
            if (!swOpen.Active)
            {
                ECom.mServer.IsOpen = true;
                ECom.mServer.tSITcpServer.isOpen = true;
                ECom.mServer.Connect();
            }
            else
            {
                ECom.mServer.IsOpen = false;
                ECom.mServer.tSITcpServer.isOpen = false;
                ECom.mServer.DisConnect();
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

                string endDataSign = "\n";
                switch (cbxEndData.Text.Trim())
                {
                    case "\\r":
                        endDataSign = "\r";
                        break;
                    case "\\n":
                        endDataSign = "\n";
                        break;
                    case "\\r\\n":
                        endDataSign = "\r\n";
                        break;
                }

                int index = Sol.mSol.mEComList.FindIndex(c => c.DeviceName == ECom.mServer.DeviceName && c.CommunicationModel == CommunicationModel.TcpServer);
                FrmConfigComm.ChangeCom(CommunicationModel.TcpServer, tbxName.Text.Trim(), new CommParams(tbxLocIP.Text, Convert.ToInt32(tbxLocPort.Text), endDataSign, isSendByHex, isReceiveByHex));
                ChangeImg(Properties.Resources.Success, Properties.Resources.Success, Properties.Resources.Success, Properties.Resources.Success, Properties.Resources.Success, Properties.Resources.Success);
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
                        ChangeImg(Properties.Resources.Fail, Properties.Resources.Success, Properties.Resources.Success, Properties.Resources.Success, Properties.Resources.Success, Properties.Resources.Success);
                        ShowResult(true, true, "名称重复", true, 61453, Color.Crimson);
                        break;
                    case "IP/端口重复":
                        ChangeImg(Properties.Resources.Fail, Properties.Resources.Success, Properties.Resources.Success, Properties.Resources.Success, Properties.Resources.Success, Properties.Resources.Success);
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
        private void FrmServerParams_LocationChanged(object sender, EventArgs e)
        {
            if (frmServerDebug == null) return;
            Point point = new Point();
            point.X = Location.X + Width + 1;
            point.Y = Location.Y - 30;
            frmServerDebug.Location = point;
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

        #region 事件-Switch控件

        /// <summary>
        /// 值改变隐藏控件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="value"></param>
        private void swOpen_ValueChanged(object sender, bool value)
        {
            HideCtrls(true);
        }

        #endregion

        #region 事件-限制TextBox输入格式

        /// <summary>
        /// 限制输入，只允许输入数字和小数点
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tbxInputNumAndDot_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != '\b' && e.KeyChar != '.')
            {
                e.Handled = true;
            }
        }

        /// <summary>
        /// 限制输入，只允许输入数字
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tbxInputNum_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != '\b')
            {
                e.Handled = true;
            }
        }

        #endregion

        #region 事件-将TextBox设置为IP格式

        private void tbxLocIP_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Back) return;
            String text = tbxLocIP.Text;
            string[] subs = text.Split('.');
            bool update = false;
            int index = 0;
            foreach (var sub in subs)
            {
                Debug.WriteLine($"Substring: {sub}");

                if (sub != String.Empty)
                {
                    if (Convert.ToUInt16(sub) > 255)
                    {
                        subs[index] = "255";
                        update = true;
                    }
                }
                else
                {
                    update = true;
                }

                if ((subs.Length == (index + 1)) && (sub.Length >= 3))
                {
                    update = true;
                }
                index++;
            }

            if (update)
            {
                tbxLocIP.Text = "";

                index = 0;
                foreach (var sub in subs)
                {
                    if (sub == String.Empty)
                        continue;
                    if (index < 3)
                    {
                        tbxLocIP.Text += String.Format("{0}.", sub);
                    }
                    else if (index == 3)
                    {
                        tbxLocIP.Text += String.Format("{0}", sub);
                    }
                    if (index >= 4)
                    {
                        update = true;
                    }
                    index++;
                }
                tbxLocIP.SelectionStart = tbxLocIP.Text.Length;//设置光标在末尾   
            }
        }

        private void tbxLocIP_Click(object sender, EventArgs e)
        {
            String text = tbxLocIP.Text;

            if (tbxLocIP.SelectionStart >= text.Length) return;
            int offset_start = text.LastIndexOf('.', tbxLocIP.SelectionStart, tbxLocIP.SelectionStart);
            Debug.WriteLine("offset_start:{0}", offset_start);

            if (offset_start == -1)
            {
                tbxLocIP.SelectionStart = 0;
            }
            else
            {
                tbxLocIP.SelectionStart = offset_start + 1;
            }

            int offset_end = text.IndexOf('.', tbxLocIP.SelectionStart, tbxLocIP.Text.Length - tbxLocIP.SelectionStart);
            Debug.WriteLine("offset_end:{0}", offset_end);

            if (offset_end == -1)
            {
                tbxLocIP.SelectionLength = tbxLocIP.Text.Length - tbxLocIP.SelectionStart;
            }
            else
            {
                tbxLocIP.SelectionLength = offset_end - tbxLocIP.SelectionStart;
            }
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
            if (ECom.mServer == null) { return; }
            if (ECom.mServer.IsConnected)
            {
                lbConnState.Color = Color.MediumSpringGreen;
            }
            else
            {
                lbConnState.Color = Color.Crimson;
            }
        }

        #endregion
    }
}
