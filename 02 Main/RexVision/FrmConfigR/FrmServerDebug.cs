using MutualTools;
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
using VisionCore;
using VisionCore.Comm.Tcp;

namespace TSIVision.FrmConfigR
{
    public partial class FrmServerDebug : Form
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
        /// 接收线程列表
        /// </summary>
        public Thread thReceive;

        /// <summary>
        /// 复原窗体委托
        /// </summary>
        public Action actRestoreFrm;

        #endregion

        #region 初始化

        public FrmServerDebug()
        {
            InitializeComponent();
            ECom.RecMsgReg = tbxReceive;
            tbxReceive.Style = UIStyle.Blue;
            tbxReceive.FillColor = Color.MintCream;
            tbxReceive.RectColor = Color.MintCream;
            tbxSend.Style = UIStyle.Blue;
            tbxSend.FillColor = Color.MintCream;
            tbxSend.RectColor = Color.MintCream;

            foreach (Control item in Controls)
            {
                item.DoubleBuffered(true);
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

        #region 事件-ComboBox控件

        /// <summary>
        /// 选择测试对象
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cbxTestObj_SelectedValueChanged(object sender, EventArgs e)
        {
            ECom.mServerClient = cbxTestObj.SelectedText;
        }

        #endregion

        # region 事件-按钮控件
        /// <summary>
        /// 工具栏按钮事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void toolbarBtn_Click(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            switch (btn.Name)
            {
                case "btnClose":
                    actRestoreFrm();
                    Close();
                    break;
            }
        }

        /// <summary>
        /// 工作区按钮事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cliAreaBtn_Click(object sender, EventArgs e)
        {
            UIButton btn = sender as UIButton;
            switch (btn.Text)
            {
                case "发送":
                    if (ECom.mServerClient.Contains("All"))
                    {
                        foreach (ClientInfo clientInfo in ECom.mServer.tSITcpServer.clientInfoList)
                        {
                            ECom.mServer.SendData(clientInfo, tbxSend.Text);
                        }
                    }
                    else
                    {
                        foreach (ClientInfo clientInfo in ECom.mServer.tSITcpServer.clientInfoList)
                        {
                            if (clientInfo.clientIP == ECom.mServerClient.Split(':')[0] && clientInfo.clientPort == Convert.ToInt32(ECom.mServerClient.Split(':')[1]))
                            {
                                ECom.mServer.SendData(clientInfo, tbxSend.Text);
                                break;
                            }
                        }
                    }
                    break;
                case "清空":
                    tbxReceive.Text = "";
                    tbxSend.Text = "";
                    break;
            }
        }

        #endregion

        #region 事件-窗体控件

        /// <summary>
        /// 窗体显示时时创建接收信息线程
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FrmServerDebug_Shown(object sender, EventArgs e)
        {
            thReceive = new Thread(new ThreadStart(() =>
            {
                while (true)
                {
                    List<ClientInfo> clientInfoList = ECom.mServer.tSITcpServer.clientInfoList;
                    List<ClientInfo> removeList = new List<ClientInfo>();

                    List<AutoResetEvent> thWaitList = new List<AutoResetEvent>();
                    for (int i = 0; i < clientInfoList.Count; i++)
                    {
                        if (!clientInfoList[i].isRecOver) continue;
                        ClientInfo clientInfo = clientInfoList[i];
                        AutoResetEvent thWait = new AutoResetEvent(false);
                        thWaitList.Add(thWait);

                        Thread thRec = new Thread(new ThreadStart(() =>
                        {
                            try
                            {
                                clientInfo.isRecOver = false;
                                if (!ECom.mServer.ReceiveData(clientInfo)) removeList.Add(clientInfo);
                                clientInfo.isRecOver = true;

                                if (ECom.mServerClient.Contains("All"))
                                {
                                    string msg = clientInfo.receivedData;
                                    if (msg != "")
                                    {
                                        Invoke(new Action(() =>
                                        {
                                            tbxReceive.AppendText(DateTime.Now.ToString("yyyy-MM-dd") + "  " + DateTime.Now.ToString("HH:mm:ss") + "\r\n");
                                            tbxReceive.AppendText(msg + "\r\n" + "\r\n");
                                        }));
                                    }
                                }
                                else
                                {
                                    if (clientInfo.clientIP == ECom.mServerClient.Split(':')[0] && clientInfo.clientPort == Convert.ToInt32(ECom.mServerClient.Split(':')[1]))
                                    {
                                        string msg = clientInfo.receivedData;
                                        if (msg != "")
                                        {
                                            Invoke(new Action(() =>
                                            {
                                                tbxReceive.AppendText(DateTime.Now.ToString("yyyy-MM-dd") + "  " + DateTime.Now.ToString("HH:mm:ss") + "\r\n");
                                                tbxReceive.AppendText(msg + "\r\n" + "\r\n");
                                            }));
                                        }
                                    }
                                }
                            }
                            catch { }
                           
                            thWait.Set();
                        }));
                        thRec.IsBackground = true;
                        thRec.Start();
                    }

                    if (thWaitList.Count != 0) WaitHandle.WaitAll(thWaitList.ToArray());

                    for (int i = 0; i < removeList.Count; i++)
                    {
                        ECom.mServer.tSITcpServer.RemoveClient(removeList[i]);
                    }

                    Thread.Sleep(10);
                }
            }));
            thReceive.IsBackground = true;
            thReceive.Start();
        }

        /// <summary>
        /// 窗体关闭
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FrmServerDebug_FormClosed(object sender, FormClosedEventArgs e)
        {
            thReceive.Abort();
        }

        #endregion

        private void timer1_Tick(object sender, EventArgs e)
        {
            List<ClientInfo> clientInfoList = ECom.mServer.tSITcpServer.clientInfoList;

            cbxTestObj.Items.Clear();
            cbxTestObj.Items.Add("All" + "(" + clientInfoList.Count + ")");

            for (int i = 0; i < clientInfoList.Count; i++)
            {
                string info = clientInfoList[i].clientIP + ":" + clientInfoList[i].clientPort;
                if (!cbxTestObj.Items.Contains(info)) cbxTestObj.Items.Add(info);
            }

            if (!cbxTestObj.Items.Contains(cbxTestObj.Text)) cbxTestObj.SelectedIndex = 0;
        }
    }
}
