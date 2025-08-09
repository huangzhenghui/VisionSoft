using MutualTools;
using Rex.UI;
using RexControl.MyControls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO.Ports;
using System.Linq;
using System.Net;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using VisionCore;
using VisionCore.Comm.Tcp;

namespace TSIVision.FrmConfigR
{
    public partial class FrmConfigComm : Form
    {
        #region 字段、属性

        /// <summary>
        /// 对主界面设备控件进行操作事件
        /// </summary>
        public static event SetEComDg SetEComEvent;

        /// <summary>
        /// 服务器设置菜单界面
        /// </summary>
        public FrmServerMenu frmServerMenu = new FrmServerMenu();

        /// <summary>
        /// 客户端设置菜单界面
        /// </summary>
        public FrmClientMenu frmClientMenu = new FrmClientMenu();

        /// <summary>
        /// 串口设置菜单界面
        /// </summary>
        public FrmSerialPortMenu frmSerialPortMenu = new FrmSerialPortMenu();

        /// <summary>
        /// 串口参数设置子界面1
        /// </summary>
        public static FrmSerialPortParams_1 frmSerialPortParams_1;

        /// <summary>
        /// 串口参数设置子界面2
        /// </summary>
        public static FrmSerialPortParams_2 frmSerialPortParams_2;

        /// <summary>
        /// Mbs设置菜单界面
        /// </summary>
        public FrmMbsMenu frmMbsMenu = new FrmMbsMenu();

        public static FrmMbsParams_1 frmMbsParams_1;

        /// <summary>
        /// DataGridView服务器选中行的索引号
        /// </summary>
        public static int dgv1CurCellIndex = 0;

        /// <summary>
        /// DataGridView客户端选中行的索引号
        /// </summary>
        public static int dgv2CurCellIndex = 0;

        /// <summary>
        /// DataGridView串口选中行的索引号
        /// </summary>
        public static int dgv3CurCellIndex = 0;

        /// <summary>
        /// DataGridViewMbs选中行的索引号
        /// </summary>
        public static int dgv4CurCellIndex = 0;

        /// <summary>
        /// 锁
        /// </summary>
        public static object lockObj = new object();

        #endregion

        #region 初始化

        public FrmConfigComm()
        {
            InitializeComponent();
            frmClientMenu.dgClearClientParams += ClearFormInfo;
            frmServerMenu.dgClearServerParams += ClearFormInfo;
            frmSerialPortMenu.dgClearSerialPortParams += ClearFormInfo;
            frmMbsMenu.dgClearMbsParams += ClearFormInfo;
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

        #region 方法-设备操作

        /// <summary>
        /// 添加设备
        /// </summary>
        /// <param name="CommMode"></param>
        private void AddComm(string CommMode)
        {
            string mDeviceName = "";//设备名称
            ECom eCommunacation = new ECom();
            switch (CommMode)
            {
                case "TCP服务端":
                    mDeviceName = EComManageer.CreateECom(CommunicationModel.TcpServer, tbxServerName.Text.Trim());
                    eCommunacation = EComManageer.GetECommunacation(mDeviceName);
                    eCommunacation.DeviceName = mDeviceName;
                    eCommunacation.IP = frmServerMenu.tbxLocalIP.Text;
                    eCommunacation.Port = Convert.ToInt32(frmServerMenu.tbxLocalPort.Text);
                    Sol.mSol.mEComList.Add(eCommunacation);
                    eCommunacation.Connect();
                    SetEComEvent(eCommunacation, EComOperate.Add);
                    CommTypeClassify();
                    dgvServerList.AutoGenerateColumns = false;
                    dgvServerList.DataSource = ECom.serverList.ToList();
                    break;
                case "TCP客户端":
                    mDeviceName = EComManageer.CreateECom(CommunicationModel.TcpClient, tbxClientName.Text.Trim());
                    eCommunacation = EComManageer.GetECommunacation(mDeviceName);
                    eCommunacation.DeviceName = mDeviceName;
                    eCommunacation.IP = frmClientMenu.tbxAimIP.Text;
                    eCommunacation.Port = Convert.ToInt32(frmClientMenu.tbxAimPort.Text);
                    Sol.mSol.mEComList.Add(eCommunacation);
                    eCommunacation.Connect();
                    SetEComEvent(eCommunacation, EComOperate.Add);
                    CommTypeClassify();
                    dgvClientList.AutoGenerateColumns = false;
                    dgvClientList.DataSource = ECom.clientList.ToList();
                    break;
                case "串口通讯":
                    mDeviceName = EComManageer.CreateECom(CommunicationModel.SerialPort, tbxSerialPortName.Text.Trim());
                    eCommunacation = EComManageer.GetECommunacation(mDeviceName);
                    eCommunacation.DeviceName = mDeviceName;
                    eCommunacation.SerialPortNum = frmSerialPortMenu.cbxSerialPortNum.Text;
                    eCommunacation.BaudRate = Convert.ToInt32(frmSerialPortMenu.cbxBaudRate.Text);
                    eCommunacation.CheckBits = (Parity)Enum.Parse(typeof(Parity), frmSerialPortMenu.cbxCheckBits.Text);
                    eCommunacation.DataBits = Convert.ToInt32(frmSerialPortMenu.cbxDataBits.Text);
                    eCommunacation.ShutBits = (StopBits)Enum.Parse(typeof(StopBits), frmSerialPortMenu.cbxStopBits.Text);
                    Sol.mSol.mEComList.Add(eCommunacation);
                    eCommunacation.Connect();
                    SetEComEvent(eCommunacation, EComOperate.Add);
                    CommTypeClassify();
                    dgvSerialPortList.AutoGenerateColumns = false;
                    dgvSerialPortList.DataSource = ECom.serialPortList.ToList();
                    break;
                case "Mbs":
                    mDeviceName = EComManageer.CreateECom(CommunicationModel.Mbs, tbxMbsName.Text.Trim());
                    eCommunacation = EComManageer.GetECommunacation(mDeviceName);
                    eCommunacation.DeviceName = mDeviceName;
                    eCommunacation.IP = frmMbsMenu.tbxAimIP.Text;
                    eCommunacation.Port = Convert.ToInt32(frmMbsMenu.tbxAimPort.Text);
                    Sol.mSol.mEComList.Add(eCommunacation);
                    eCommunacation.Connect();
                    SetEComEvent(eCommunacation, EComOperate.Add);
                    CommTypeClassify();
                    dgvMbsList.AutoGenerateColumns = false;
                    dgvMbsList.DataSource = ECom.mbsList.ToList();
                    break;
            }
            CommTypeClassify();
        }

        /// <summary>
        /// 更改设备
        /// </summary>
        public static void ChangeCom(CommunicationModel commModel, string deviceName, CommParams commParams)
        {
            switch (commModel)
            {
                case CommunicationModel.TcpServer:
                    ECom.mServer.DeviceName = deviceName;
                    ECom.mServer.IP = commParams.IP;
                    ECom.mServer.Port = commParams.port;
                    ECom.mServer.EndData = commParams.endData;
                    ECom.mServer.IsSendByHex = commParams.isSendByHex;
                    ECom.mServer.IsReceivedByHex = commParams.isReceivedByHex;

                    ECom.mServer.DisConnect();
                    ECom.mServer.Connect();
                    break;
                case CommunicationModel.TcpClient:
                    ECom.mClient.DeviceName = deviceName;
                    ECom.mClient.IP = commParams.IP;
                    ECom.mClient.Port = commParams.port;
                    ECom.mClient.EndData = commParams.endData;
                    ECom.mClient.IsSendByHex = commParams.isSendByHex;
                    ECom.mClient.IsReceivedByHex = commParams.isReceivedByHex;
                
                    ECom.mClient.DisConnect();
                    ECom.mClient.Connect();
                    break;
                case CommunicationModel.SerialPort:
                    ECom.mSerialPort.DeviceName = deviceName;
                    ECom.mSerialPort.SerialPortNum = commParams.serialPortNum;
                    ECom.mSerialPort.BaudRate = commParams.baudRate;
                    ECom.mSerialPort.CheckBits = commParams.checkBits;
                    ECom.mSerialPort.DataBits = commParams.dataBits;
                    ECom.mSerialPort.ShutBits = commParams.shutBits;
                    ECom.mSerialPort.EndData = commParams.endData;
                    ECom.mSerialPort.IsSendByHex = commParams.isSendByHex;
                    ECom.mSerialPort.IsReceivedByHex = commParams.isReceivedByHex;

                    ECom.mSerialPort.DisConnect();
                    ECom.mSerialPort.Connect();
                    break;
                case CommunicationModel.Mbs:
                    ECom.mMbs.DeviceName = deviceName;
                    ECom.mMbs.IP = commParams.IP;
                    ECom.mMbs.Port = commParams.port;
                    ECom.mMbs.EndData = commParams.endData;
                    ECom.mMbs.IsSendByHex = commParams.isSendByHex;
                    ECom.mMbs.IsReceivedByHex = commParams.isReceivedByHex;

                    ECom.mMbs.DisConnect();
                    ECom.mMbs.Connect();
                    break;
            }

            CommTypeClassify();
        }

        /// <summary>
        /// 删除设备
        /// </summary>
        /// <param name="CommMode"></param>
        public void RemoveComm(string CommMode)
        {
            switch (CommMode)
            {
                case "TCP服务端":
                    ECom.mServer = ECom.serverList[dgv1CurCellIndex];
                    ECom.mServer.DisConnect();
                    Sol.mSol.mEComList.Remove(ECom.mServer);
                    SetEComEvent(ECom.mServer, EComOperate.Remove);
                    dgvServerList.DataSource = ECom.serverList.ToList();
                    if (dgv1CurCellIndex >= 1) --dgv1CurCellIndex;
                    break;
                case "TCP客户端":
                    ECom.mClient = ECom.clientList[dgv2CurCellIndex];
                    ECom.mClient.DisConnect();
                    Sol.mSol.mEComList.Remove(ECom.mClient);
                    SetEComEvent(ECom.mClient, EComOperate.Remove);
                    dgvClientList.DataSource = ECom.clientList.ToList();
                    if (dgv2CurCellIndex >= 1) --dgv2CurCellIndex;
                    break;
                case "串口通讯":
                    ECom.mSerialPort = ECom.serialPortList[dgv3CurCellIndex];
                    ECom.mSerialPort.DisConnect();
                    Sol.mSol.mEComList.Remove(ECom.mSerialPort);
                    SetEComEvent(ECom.mSerialPort, EComOperate.Remove);
                    dgvSerialPortList.DataSource = ECom.serialPortList.ToList();
                    if (dgv3CurCellIndex >= 1) --dgv3CurCellIndex;
                    break;
                case "Mbs":
                    ECom.mMbs = ECom.mbsList[dgv4CurCellIndex];
                    ECom.mMbs.DisConnect();
                    Sol.mSol.mEComList.Remove(ECom.mMbs);
                    SetEComEvent(ECom.mMbs, EComOperate.Remove);
                    dgvMbsList.DataSource = ECom.mbsList.ToList();
                    if (dgv4CurCellIndex >= 1) --dgv4CurCellIndex;
                    break;
            }

            CommTypeClassify();
        }

        /// <summary>
        /// 将通讯列表中的项进行分类,作刷新使用
        /// </summary>
        public static void CommTypeClassify()
        {
            lock (lockObj)
            {
                ECom.serverList.Clear();
                ECom.clientList.Clear();
                ECom.serialPortList.Clear();
                ECom.mbsList.Clear();
                foreach (ECom item in Sol.mSol.mEComList)
                {
                    switch (item.CommunicationModel)
                    {
                        case CommunicationModel.TcpServer:
                            ECom.serverList.Add(item);
                            break;
                        case CommunicationModel.TcpClient:
                            ECom.clientList.Add(item);
                            break;
                        case CommunicationModel.SerialPort:
                            ECom.serialPortList.Add(item);
                            break;
                        case CommunicationModel.Mbs:
                            ECom.mbsList.Add(item);
                            break;
                    }
                }

                if (ECom.serverList.Count != 0) ECom.mServer = ECom.serverList[dgv1CurCellIndex];
                if (ECom.clientList.Count != 0) ECom.mClient = ECom.clientList[dgv2CurCellIndex];
                if (ECom.serialPortList.Count != 0) ECom.mSerialPort = ECom.serialPortList[dgv3CurCellIndex];
                if (ECom.mbsList.Count != 0) ECom.mMbs = ECom.mbsList[dgv4CurCellIndex];
            }
        }

        #endregion

        #region 方法-更改信息

        /// <summary>
        /// 更改状态图像
        /// </summary>
        /// <param name="img1"></param>
        /// <param name="img2"></param>
        /// <param name="img3"></param>
        public void ChangeImg(CommunicationModel commModel, Image img1, Image img2, Image img3, Image img4 = null, Image img5 = null, Image img6 = null)
        {
            switch (commModel)
            {
                case CommunicationModel.TcpServer:
                    pbxJudge1.BackgroundImage = img1;
                    frmServerMenu.pbxJudge1.BackgroundImage = img2;
                    frmServerMenu.pbxJudge2.BackgroundImage = img3;
                    break;
                case CommunicationModel.TcpClient:
                    pbxJudge2.BackgroundImage = img1;
                    frmClientMenu.pbxJudge1.BackgroundImage = img2;
                    frmClientMenu.pbxJudge2.BackgroundImage = img3;
                    break;
                case CommunicationModel.SerialPort:
                    pbxJudge3.BackgroundImage = img1;
                    frmSerialPortMenu.pbxJudge1.BackgroundImage = img2;
                    frmSerialPortMenu.pbxJudge2.BackgroundImage = img3;
                    frmSerialPortMenu.pbxJudge3.BackgroundImage = img4;
                    frmSerialPortMenu.pbxJudge4.BackgroundImage = img5;
                    frmSerialPortMenu.pbxJudge5.BackgroundImage = img6;
                    break;
                case CommunicationModel.Mbs:
                    pbxJudge4.BackgroundImage = img1;
                    frmMbsMenu.pbxJudge1.BackgroundImage = img2;
                    frmMbsMenu.pbxJudge2.BackgroundImage = img3;
                    break;
            }
        }

        /// <summary>
        /// 隐藏子窗体
        /// </summary>
        public void HideChlidForm()
        {
            if (frmServerMenu.Visible || frmClientMenu.Visible || frmSerialPortMenu.Visible || frmMbsMenu.Visible)
            {
                frmServerMenu.Hide();
                frmClientMenu.Hide();
                frmSerialPortMenu.Hide();
                frmMbsMenu.Hide();
            }
        }

        /// <summary>
        /// 清除窗体信息
        /// </summary>
        public void ClearFormInfo(CommunicationModel commModel)
        {
            switch (commModel)
            {
                case CommunicationModel.TcpServer:
                    tbxServerName.Text = "";
                    frmServerMenu.tbxLocalIP.Text = "0.0.0.0";
                    frmServerMenu.tbxLocalPort.Text = "";
                    pbxJudge1.BackgroundImage = null;
                    frmServerMenu.pbxJudge1.BackgroundImage = null;
                    frmServerMenu.pbxJudge2.BackgroundImage = null;
                    frmServerMenu.Hide();
                    break;
                case CommunicationModel.TcpClient:
                    tbxClientName.Text = "";
                    frmClientMenu.tbxAimIP.Text = "0.0.0.0";
                    frmClientMenu.tbxAimPort.Text = "";
                    pbxJudge2.BackgroundImage = null;
                    frmClientMenu.pbxJudge1.BackgroundImage = null;
                    frmClientMenu.pbxJudge2.BackgroundImage = null;
                    frmClientMenu.Hide();
                    break;
                case CommunicationModel.SerialPort:
                    tbxSerialPortName.Text = "";
                    frmSerialPortMenu.cbxSerialPortNum.Text = "";
                    frmSerialPortMenu.cbxBaudRate.Text = "";
                    frmSerialPortMenu.cbxCheckBits.Text = "";
                    frmSerialPortMenu.cbxDataBits.Text = "";
                    frmSerialPortMenu.cbxStopBits.Text = "";
                    frmSerialPortMenu.cbxSerialPortNum.SelectedItem = null;
                    frmSerialPortMenu.cbxBaudRate.SelectedItem = null;
                    frmSerialPortMenu.cbxCheckBits.SelectedItem = null;
                    frmSerialPortMenu.cbxDataBits.SelectedItem = null;
                    frmSerialPortMenu.cbxStopBits.SelectedItem = null;
                    pbxJudge3.BackgroundImage = null;
                    frmSerialPortMenu.pbxJudge1.BackgroundImage = null;
                    frmSerialPortMenu.pbxJudge2.BackgroundImage = null;
                    frmSerialPortMenu.pbxJudge3.BackgroundImage = null;
                    frmSerialPortMenu.pbxJudge4.BackgroundImage = null;
                    frmSerialPortMenu.pbxJudge5.BackgroundImage = null;
                    frmSerialPortMenu.Hide();
                    break;
                case CommunicationModel.Mbs:
                    tbxMbsName.Text = "";
                    frmMbsMenu.tbxAimIP.Text = "0.0.0.0";
                    frmMbsMenu.tbxAimPort.Text = "";
                    pbxJudge4.BackgroundImage = null;
                    frmMbsMenu.pbxJudge1.BackgroundImage = null;
                    frmMbsMenu.pbxJudge2.BackgroundImage = null;
                    frmMbsMenu.Hide();
                    break;
            }

        }

        #endregion

        #region 事件-DataGridView控件

        /// <summary>
        /// 服务器列表选中服务器所执行的事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dgvServerList_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvServerList.CurrentCell == null) { return; }
            FrmServerParams.dgvServerList = dgvServerList;
            string serverName = (string)dgvServerList.Rows[dgvServerList.CurrentCell.RowIndex].Cells[0].Value;
            int index = Sol.mSol.mEComList.FindIndex(c => c.DeviceName == serverName);
            ECom.mServer = Sol.mSol.mEComList[index];
            dgv1CurCellIndex = dgvServerList.CurrentCell.RowIndex;
        }

        /// <summary>
        /// 客户端列表选中的客户端所执行的事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dgvClientList_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvClientList.CurrentCell == null) { return; }
            FrmClientParams.dgvClientList = dgvClientList;
            string clientName = (string)dgvClientList.Rows[dgvClientList.CurrentCell.RowIndex].Cells[0].Value;
            int index = Sol.mSol.mEComList.FindIndex(c => c.DeviceName == clientName);
            ECom.mClient = Sol.mSol.mEComList[index];
            dgv2CurCellIndex = dgvClientList.CurrentCell.RowIndex;
        }

        /// <summary>
        /// 串口列表选中的串口所执行的事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dgvSerialPortList_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvSerialPortList.CurrentCell == null) { return; }
            FrmSerialPortParams.dgvSerialPortList = dgvSerialPortList;
            string serialPortName = (string)dgvSerialPortList.Rows[dgvSerialPortList.CurrentCell.RowIndex].Cells[0].Value;
            int index = Sol.mSol.mEComList.FindIndex(c => c.DeviceName == serialPortName);
            ECom.mSerialPort = Sol.mSol.mEComList[index];
            dgv3CurCellIndex = dgvSerialPortList.CurrentCell.RowIndex;
        }

        /// <summary>
        /// 鼠标按下界面不刷新
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dgvList_MouseDown(object sender, MouseEventArgs e)
        {
            timer1.Enabled = false;
        }

        /// <summary>
        /// 鼠标抬起界面恢复刷新
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dgvList_MouseUp(object sender, MouseEventArgs e)
        {
            timer1.Enabled = true;
        }

        /// <summary>
        /// 双击服务器列表单元格事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dgvServerList_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            string serverName = (string)dgvServerList.Rows[dgvServerList.CurrentCell.RowIndex].Cells[0].Value;
            ECom eCom = Sol.mSol.mEComList.Find(c => c.DeviceName == serverName);
            ClearFormInfo(CommunicationModel.TcpServer);
            tbxServerName.Text = eCom.DeviceName;
            frmServerMenu.tbxLocalIP.Text = eCom.IP.ToString();
            frmServerMenu.tbxLocalPort.Text = eCom.Port.ToString();
            btnServerMenu.PerformClick();
        }

        /// <summary>
        /// 双击客户端列表单元格事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dgvClientList_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            string clientName = (string)dgvClientList.Rows[dgvClientList.CurrentCell.RowIndex].Cells[0].Value;
            ECom eCom = Sol.mSol.mEComList.Find(c => c.DeviceName == clientName);
            ClearFormInfo(CommunicationModel.TcpServer);
            tbxClientName.Text = eCom.DeviceName;
            frmClientMenu.tbxAimIP.Text = eCom.IP.ToString();
            frmClientMenu.tbxAimPort.Text = eCom.Port.ToString();
            btnClientMenu.PerformClick();
        }

        /// <summary>
        /// 双击串口列表单元格事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dgvSerialPortList_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            string serialPortName = (string)dgvSerialPortList.Rows[dgvSerialPortList.CurrentCell.RowIndex].Cells[0].Value;
            ECom eCom = Sol.mSol.mEComList.Find(c => c.DeviceName == serialPortName);
            ClearFormInfo(CommunicationModel.SerialPort);
            tbxSerialPortName.Text = eCom.DeviceName;
            frmSerialPortMenu.cbxSerialPortNum.Text = eCom.SerialPortNum;
            frmSerialPortMenu.cbxBaudRate.Text = eCom.BaudRate.ToString();
            frmSerialPortMenu.cbxCheckBits.Text = eCom.CheckBits.ToString();
            frmSerialPortMenu.cbxDataBits.Text = eCom.DataBits.ToString();
            frmSerialPortMenu.cbxStopBits.Text = eCom.ShutBits.ToString();
            btnSerialPortMenu.PerformClick();
        }

        #endregion

        #region 事件-DataGridView控件单元格重绘

        /// <summary>
        /// DataGridView单元格重绘
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dgv_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
        {
            DataGridView dgv = sender as DataGridView;
            var g = e.Graphics;

            if (e.RowIndex < 0)
            {
                if (Enumerable.Range(0, 50).Contains(e.ColumnIndex))
                {
                    Brush bg = new SolidBrush(dgv.ColumnHeadersDefaultCellStyle.BackColor); // 背景色
                    Brush fg = new SolidBrush(dgv.ColumnHeadersDefaultCellStyle.ForeColor); // 前景色

                    //绘制背景色
                    if ((e.PaintParts & DataGridViewPaintParts.Background) == DataGridViewPaintParts.Background)
                        g.FillRectangle(bg, e.CellBounds); // 

                    if ((e.PaintParts & DataGridViewPaintParts.ContentBackground) == DataGridViewPaintParts.ContentBackground)
                        g.FillRectangle(bg, e.CellBounds); // 

                    if ((e.PaintParts & DataGridViewPaintParts.ContentForeground) == DataGridViewPaintParts.ContentForeground)
                    {
                        var col = dgv.Columns[e.ColumnIndex];
                        var text = col?.HeaderText ?? "";
                        var sizeF = g.MeasureString(text, dgv.ColumnHeadersDefaultCellStyle.Font); // 测量绘制列标题文本尺寸
                        var x = e.CellBounds.X + (e.CellBounds.Width - sizeF.Width) / 2.07f; // 获取 Left
                        var y = e.CellBounds.Y + (e.CellBounds.Height - sizeF.Height) / 3f; // 获取 Top

                        g.DrawString(text, dgv.ColumnHeadersDefaultCellStyle.Font, fg, x, y); // 绘制列标题
                    }
                    e.Handled = true;
                }
            }
        }

        #endregion

        #region 事件-Timer控件

        /// <summary>
        /// 刷新DataGridView数据
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void timer1_Tick(object sender, EventArgs e)
        {
            try
            {
                CommTypeClassify();

                dgvServerList.AutoGenerateColumns = false;
                dgvClientList.AutoGenerateColumns = false;
                dgvSerialPortList.AutoGenerateColumns = false;
                dgvMbsList.AutoGenerateColumns = false;
                dgvServerList.DataSource = ECom.serverList.ToList();
                dgvClientList.DataSource = ECom.clientList.ToList();
                dgvSerialPortList.DataSource = ECom.serialPortList.ToList();
                dgvMbsList.DataSource = ECom.mbsList.ToList();
                if (dgvServerList.Rows.Count > dgv1CurCellIndex) dgvServerList.Rows[dgv1CurCellIndex].Selected = true;
                if (dgvClientList.Rows.Count > dgv2CurCellIndex) dgvClientList.Rows[dgv2CurCellIndex].Selected = true;
                if (dgvSerialPortList.Rows.Count > dgv3CurCellIndex) dgvSerialPortList.Rows[dgv3CurCellIndex].Selected = true;
                if (dgvMbsList.Rows.Count > dgv2CurCellIndex) dgvMbsList.Rows[dgv4CurCellIndex].Selected = true;
            }
            catch { }
        }

        #endregion

        #region 事件-按钮控件

        /// <summary>
        /// 服务端点击按钮事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnServer_Click(object sender, EventArgs e)
        {
            UIButton uiBtn = sender as UIButton;
            MsgForm msgForm = new MsgForm();
            int x = Screen.PrimaryScreen.Bounds.Width / 2 - msgForm.Width / 2 + 31;
            int y = Screen.PrimaryScreen.Bounds.Height / 2 - msgForm.Height / 3;
            bool isEmpty = true;

            if (uiBtn.Name != "btnAddServer")
            {
                HideChlidForm();
            }

            switch (uiBtn.Name)
            {
                case "btnAddServer":

                    //判断输入内容是否为空

                    if (tbxServerName.Text == "")
                    {
                        pbxJudge1.BackgroundImage = Properties.Resources.Fail;
                        isEmpty = false;
                    }
                    else
                    {
                        pbxJudge1.BackgroundImage = Properties.Resources.Undetermined;
                    }

                    if (frmServerMenu.tbxLocalIP.Text == "")
                    {
                        frmServerMenu.pbxJudge1.BackgroundImage = Properties.Resources.Fail;
                        isEmpty = false;
                    }
                    else
                    {
                        frmServerMenu.pbxJudge1.BackgroundImage = Properties.Resources.Undetermined;
                    }

                    if (frmServerMenu.tbxLocalPort.Text == "")
                    {
                        frmServerMenu.pbxJudge2.BackgroundImage = Properties.Resources.Fail;
                        isEmpty = false;
                    }
                    else
                    {
                        frmServerMenu.pbxJudge2.BackgroundImage = Properties.Resources.Undetermined;
                    }

                    if (!isEmpty)
                    {
                        btnServerMenu.PerformClick();
                        msgForm.ShowMsg("参数内容不能为空", x, y);
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

                    string iPAddress = ipList.FirstOrDefault(c => c.ToString() == frmServerMenu.tbxLocalIP.Text);
                    if (iPAddress == null)
                    {
                        ChangeImg(CommunicationModel.TcpServer, Properties.Resources.Undetermined, Properties.Resources.Fail, Properties.Resources.Undetermined);
                        btnServerMenu.PerformClick();
                        msgForm.ShowMsg("本机中不存在该IP", x, y);
                        return;
                    }

                    //判断端口是否超出上限

                    if (Convert.ToDouble(frmServerMenu.tbxLocalPort.Text) > 65535)
                    {
                        ChangeImg(CommunicationModel.TcpServer, Properties.Resources.Undetermined, Properties.Resources.Undetermined, Properties.Resources.Fail);
                        btnServerMenu.PerformClick();
                        msgForm.ShowMsg("端口号超出上限", x, y);
                        return;
                    }

                    //判断服务器名称是否已经存在

                    int index1 = Sol.mSol.mEComList.FindIndex(c => c.DeviceName == tbxServerName.Text.Trim() && c.CommunicationModel == CommunicationModel.TcpServer);
                    if (index1 >= 0)
                    {
                        ChangeImg(CommunicationModel.TcpServer, Properties.Resources.Undetermined, Properties.Resources.Undetermined, Properties.Resources.Undetermined);
                        btnServerMenu.PerformClick();

                        if (msgForm.ShowMsg("该设备名称已存在，是否替换", x, y))
                        {
                            ChangeCom(CommunicationModel.TcpServer, tbxServerName.Text.Trim(), new CommParams(frmServerMenu.tbxLocalIP.Text, Convert.ToInt32(frmServerMenu.tbxLocalPort.Text), ECom.mServer.EndData, ECom.mServer.IsSendByHex, ECom.mServer.IsReceivedByHex));
                            ChangeImg(CommunicationModel.TcpServer, Properties.Resources.Success, Properties.Resources.Success, Properties.Resources.Success);
                            msgForm.ShowMsg("替换成功", x, y);
                            ClearFormInfo(CommunicationModel.TcpServer);
                        }
                        else
                        {
                            ChangeImg(CommunicationModel.TcpServer, Properties.Resources.Fail, Properties.Resources.Undetermined, Properties.Resources.Undetermined);
                        }
                        return;
                    }

                    //判断服务器IP/端口是否已经存在

                    int index2 = Sol.mSol.mEComList.FindIndex(c => ((c.IP == frmServerMenu.tbxLocalIP.Text.Trim()) && (c.Port.ToString() == frmServerMenu.tbxLocalPort.Text.Trim())));
                    if (index2 >= 0)
                    {
                        ChangeImg(CommunicationModel.TcpServer, Properties.Resources.Undetermined, Properties.Resources.Undetermined, Properties.Resources.Undetermined);
                        btnServerMenu.PerformClick();

                        if (msgForm.ShowMsg("该设备IP地址与端口号已存在，是否替换", x, y))
                        {
                            ChangeCom(CommunicationModel.TcpServer, tbxServerName.Text.Trim(), new CommParams(frmServerMenu.tbxLocalIP.Text, Convert.ToInt32(frmServerMenu.tbxLocalPort.Text), ECom.mServer.EndData, ECom.mServer.IsSendByHex, ECom.mServer.IsReceivedByHex));
                            ChangeImg(CommunicationModel.TcpServer, Properties.Resources.Success, Properties.Resources.Success, Properties.Resources.Success);
                            msgForm.ShowMsg("替换成功", x, y);
                            ClearFormInfo(CommunicationModel.TcpServer);
                        }
                        else
                        {
                            ChangeImg(CommunicationModel.TcpServer, Properties.Resources.Undetermined, Properties.Resources.Fail, Properties.Resources.Fail);
                        }
                        return;
                    }

                    ChangeImg(CommunicationModel.TcpServer, Properties.Resources.Success, Properties.Resources.Success, Properties.Resources.Success);
                    AddComm("TCP服务端");
                    msgForm.ShowMsg("添加成功", x, y);
                    ClearFormInfo(CommunicationModel.TcpServer);
                    break;
                case "btnRemoveServer":
                    if (dgvServerList.CurrentCell == null)
                    {
                        msgForm.ShowMsg("设备列表为空", x, y);
                        break;
                    }

                    RemoveComm("TCP服务端");
                    break;
                case "btn1PageChange":
                    if (ECom.mServer == null)
                    {
                        msgForm.ShowMsg("设备列表为空", x, y);
                        break;
                    }
                    FrmServerParams.dgvServerList = dgvServerList;
                    string serverName = (string)dgvServerList.Rows[dgv1CurCellIndex].Cells[0].Value;
                    int index = Sol.mSol.mEComList.FindIndex(c => c.DeviceName == serverName);
                    ECom.mServer = Sol.mSol.mEComList[index];
                    FrmServerParams frmServerParams = new FrmServerParams();
                    frmServerParams.DispServerParams();
                    frmServerParams.Location = new Point(806, 342);
                    frmServerParams.StartPosition = FormStartPosition.Manual;
                    frmServerParams.ShowDialog();
                    break;
            }

            ClearFormInfo(CommunicationModel.TcpServer);
        }

        /// <summary>
        /// 客户端点击按钮事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnClient_Click(object sender, EventArgs e)
        {
            UIButton uiBtn = sender as UIButton;
            MsgForm msgForm = new MsgForm();
            int x = Screen.PrimaryScreen.Bounds.Width / 2 - msgForm.Width / 2 + 31;
            int y = Screen.PrimaryScreen.Bounds.Height / 2 - msgForm.Height / 3;
            bool isEmpty = true;

            if (uiBtn.Name != "btnAddClient")
            {
                HideChlidForm();
            }

            switch (uiBtn.Name)
            {
                case "btnAddClient":
                    //判断输入内容是否为空

                    if (tbxClientName.Text == "")
                    {
                        pbxJudge2.BackgroundImage = Properties.Resources.Fail;
                        isEmpty = false;
                    }
                    else
                    {
                        pbxJudge2.BackgroundImage = Properties.Resources.Undetermined;
                    }

                    if (frmClientMenu.tbxAimIP.Text == "")
                    {
                        frmClientMenu.pbxJudge1.BackgroundImage = Properties.Resources.Fail;
                        isEmpty = false;
                    }
                    else
                    {
                        frmClientMenu.pbxJudge1.BackgroundImage = Properties.Resources.Undetermined;
                    }

                    if (frmClientMenu.tbxAimPort.Text == "")
                    {
                        frmClientMenu.pbxJudge2.BackgroundImage = Properties.Resources.Fail;
                        isEmpty = false;
                    }
                    else
                    {
                        frmClientMenu.pbxJudge2.BackgroundImage = Properties.Resources.Undetermined;
                    }

                    if (!isEmpty)
                    {
                        btnClientMenu.PerformClick();
                        msgForm.ShowMsg("参数内容不能为空", x, y);
                        return;
                    }

                    //判断端口是否超出上限

                    if (Convert.ToDouble(frmClientMenu.tbxAimPort.Text) > 65535)
                    {
                        ChangeImg(CommunicationModel.TcpClient, Properties.Resources.Undetermined, Properties.Resources.Undetermined, Properties.Resources.Fail);
                        btnClientMenu.PerformClick();
                        msgForm.ShowMsg("端口号超出上限", x, y);
                        return;
                    }

                    //判断客户端名称是否已经存在

                    int index1 = Sol.mSol.mEComList.FindIndex(c => c.DeviceName == tbxClientName.Text.Trim() && c.CommunicationModel == CommunicationModel.TcpClient);
                    if (index1 >= 0)
                    {
                        ChangeImg(CommunicationModel.TcpClient, Properties.Resources.Undetermined, Properties.Resources.Undetermined, Properties.Resources.Undetermined);
                        btnClientMenu.PerformClick();

                        if (msgForm.ShowMsg("该设备名称已存在，是否替换", x, y))
                        {
                            ChangeCom(CommunicationModel.TcpClient, tbxClientName.Text.Trim(), new CommParams(frmClientMenu.tbxAimIP.Text, Convert.ToInt32(frmClientMenu.tbxAimPort.Text), ECom.mClient.EndData, ECom.mClient.IsSendByHex, ECom.mClient.IsReceivedByHex));
                            ChangeImg(CommunicationModel.TcpClient, Properties.Resources.Success, Properties.Resources.Success, Properties.Resources.Success);
                            msgForm.ShowMsg("替换成功", x, y);
                            ClearFormInfo(CommunicationModel.TcpClient);
                        }
                        else
                        {
                            ChangeImg(CommunicationModel.TcpClient, Properties.Resources.Fail, Properties.Resources.Undetermined, Properties.Resources.Undetermined);
                        }
                        return;
                    }

                    //判断客户端IP/端口是否已经存在

                    int index2 = Sol.mSol.mEComList.FindIndex(c => ((c.IP == frmClientMenu.tbxAimIP.Text.Trim()) && (c.Port.ToString() == frmClientMenu.tbxAimPort.Text.Trim())));
                    if (index2 >= 0)
                    {
                        ChangeImg(CommunicationModel.TcpClient, Properties.Resources.Undetermined, Properties.Resources.Undetermined, Properties.Resources.Undetermined);
                        btnClientMenu.PerformClick();

                        if (msgForm.ShowMsg("该设备IP地址与端口号已存在，是否替换", x, y))
                        {
                            ChangeCom(CommunicationModel.TcpClient, tbxClientName.Text.Trim(), new CommParams(frmClientMenu.tbxAimIP.Text, Convert.ToInt32(frmClientMenu.tbxAimPort.Text), ECom.mClient.EndData, ECom.mClient.IsSendByHex, ECom.mClient.IsReceivedByHex));
                            ChangeImg(CommunicationModel.TcpClient, Properties.Resources.Success, Properties.Resources.Success, Properties.Resources.Success);
                            msgForm.ShowMsg("替换成功", x, y);
                            ClearFormInfo(CommunicationModel.TcpClient);
                        }
                        else
                        {
                            ChangeImg(CommunicationModel.TcpClient, Properties.Resources.Undetermined, Properties.Resources.Fail, Properties.Resources.Fail);
                        }
                        return;
                    }

                    ChangeImg(CommunicationModel.TcpClient, Properties.Resources.Success, Properties.Resources.Success, Properties.Resources.Success);
                    AddComm("TCP客户端");
                    msgForm.ShowMsg("添加成功", x, y);
                    ClearFormInfo(CommunicationModel.TcpClient);
                    break;
                case "btnRemoveClient":
                    if (dgvClientList.CurrentCell == null)
                    {
                        msgForm.ShowMsg("设备列表为空", x, y);
                        break;
                    }
                    RemoveComm("TCP客户端");
                    break;
                case "btn2PageChange":
                    if (dgvClientList.CurrentCell == null)
                    {
                        msgForm.ShowMsg("设备列表为空", x, y);
                        break;
                    }
                    FrmClientParams.dgvClientList = dgvClientList;
                    string clientName = (string)dgvClientList.Rows[dgv2CurCellIndex].Cells[0].Value;
                    int index = Sol.mSol.mEComList.FindIndex(c => c.DeviceName == clientName);
                    ECom.mClient = Sol.mSol.mEComList[index];
                    FrmClientParams frmClientParams = new FrmClientParams();
                    frmClientParams.DispClientParams();
                    frmClientParams.Location = new Point(806, 342);
                    frmClientParams.StartPosition = FormStartPosition.Manual;
                    frmClientParams.ShowDialog();
                    break;
            }

            ClearFormInfo(CommunicationModel.TcpClient);
        }

        /// <summary>
        /// 串口点击按钮事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnSerialPort_Click(object sender, EventArgs e)
        {
            UIButton uiBtn = sender as UIButton;
            MsgForm msgForm = new MsgForm();
            int x = Screen.PrimaryScreen.Bounds.Width / 2 - msgForm.Width / 2 + 31;
            int y = Screen.PrimaryScreen.Bounds.Height / 2 - msgForm.Height / 3;
            bool isEmpty = true;

            if (uiBtn.Name != "btnAddSerialPort")
            {
                HideChlidForm();
            }

            switch (uiBtn.Name)
            {
                case "btnAddSerialPort":
                    if (tbxSerialPortName.Text == "")
                    {
                        pbxJudge3.BackgroundImage = Properties.Resources.Fail;
                        isEmpty = false;
                    }
                    else
                    {
                        pbxJudge3.BackgroundImage = Properties.Resources.Undetermined;
                    }

                    if (frmSerialPortMenu.cbxSerialPortNum.Text == "")
                    {
                        frmSerialPortMenu.pbxJudge1.BackgroundImage = Properties.Resources.Fail;
                        isEmpty = false;
                    }
                    else
                    {
                        frmSerialPortMenu.pbxJudge1.BackgroundImage = Properties.Resources.Undetermined;
                    }

                    if (frmSerialPortMenu.cbxBaudRate.Text == "")
                    {
                        frmSerialPortMenu.pbxJudge2.BackgroundImage = Properties.Resources.Fail;
                        isEmpty = false;
                    }
                    else
                    {
                        frmSerialPortMenu.pbxJudge2.BackgroundImage = Properties.Resources.Success;
                    }

                    if (frmSerialPortMenu.cbxCheckBits.Text == "")
                    {
                        frmSerialPortMenu.pbxJudge3.BackgroundImage = Properties.Resources.Fail;
                        isEmpty = false;
                    }
                    else
                    {
                        frmSerialPortMenu.pbxJudge3.BackgroundImage = Properties.Resources.Success;
                    }

                    if (frmSerialPortMenu.cbxDataBits.Text == "")
                    {
                        frmSerialPortMenu.pbxJudge4.BackgroundImage = Properties.Resources.Fail;
                        isEmpty = false;
                    }
                    else
                    {
                        frmSerialPortMenu.pbxJudge4.BackgroundImage = Properties.Resources.Success;
                    }

                    if (frmSerialPortMenu.cbxStopBits.Text == "")
                    {
                        frmSerialPortMenu.pbxJudge5.BackgroundImage = Properties.Resources.Fail;
                        isEmpty = false;
                    }
                    else
                    {
                        frmSerialPortMenu.pbxJudge5.BackgroundImage = Properties.Resources.Success;
                    }

                    if (!isEmpty)
                    {
                        btnSerialPortMenu.PerformClick();
                        msgForm.ShowMsg("参数内容不能为空", x, y);
                        return;
                    }

                    //判断串口名称是否已经存在

                    int index1 = Sol.mSol.mEComList.FindIndex(c => c.DeviceName == tbxSerialPortName.Text.Trim() && c.CommunicationModel == CommunicationModel.SerialPort);
                    if (index1 >= 0)
                    {
                        ChangeImg(CommunicationModel.SerialPort, Properties.Resources.Undetermined, Properties.Resources.Undetermined, Properties.Resources.Undetermined, Properties.Resources.Undetermined, Properties.Resources.Undetermined, Properties.Resources.Undetermined);
                        btnSerialPortMenu.PerformClick();

                        if (msgForm.ShowMsg("该设备名称已存在，是否替换", x, y))
                        {
                            CommParams commParams = new CommParams(frmSerialPortMenu.cbxSerialPortNum.Text, Convert.ToInt32(frmSerialPortMenu.cbxBaudRate.Text), (Parity)Enum.Parse(typeof(Parity), frmSerialPortMenu.cbxCheckBits.Text), Convert.ToInt32(frmSerialPortMenu.cbxDataBits.Text), (StopBits)Enum.Parse(typeof(StopBits), frmSerialPortMenu.cbxStopBits.Text), ECom.mSerialPort.IsSendByHex, ECom.mSerialPort.IsReceivedByHex);
                            ChangeCom(CommunicationModel.SerialPort, tbxSerialPortName.Text.Trim(), commParams);
                            ChangeImg(CommunicationModel.SerialPort, Properties.Resources.Success, Properties.Resources.Success, Properties.Resources.Success, Properties.Resources.Success, Properties.Resources.Success, Properties.Resources.Success);
                            msgForm.ShowMsg("替换成功", x, y);
                            ClearFormInfo(CommunicationModel.SerialPort);
                        }
                        else
                        {
                            ChangeImg(CommunicationModel.TcpClient, Properties.Resources.Fail, Properties.Resources.Undetermined, Properties.Resources.Success, Properties.Resources.Success, Properties.Resources.Success, Properties.Resources.Success);
                        }
                        break;
                    }

                    //判断串口号是否已经存在

                    int index2 = Sol.mSol.mEComList.FindIndex(c => (c.SerialPortNum == frmSerialPortMenu.cbxSerialPortNum.Text));
                    if (index2 >= 0)
                    {
                        ChangeImg(CommunicationModel.SerialPort, Properties.Resources.Undetermined, Properties.Resources.Undetermined, Properties.Resources.Success, Properties.Resources.Success, Properties.Resources.Success, Properties.Resources.Success);
                        btnSerialPortMenu.PerformClick();

                        if (msgForm.ShowMsg("该设备串口号已存在，是否替换", x, y))
                        {
                            CommParams commParams = new CommParams(frmSerialPortMenu.cbxSerialPortNum.Text, Convert.ToInt32(frmSerialPortMenu.cbxBaudRate.Text), (Parity)Enum.Parse(typeof(Parity), frmSerialPortMenu.cbxCheckBits.Text), Convert.ToInt32(frmSerialPortMenu.cbxDataBits.Text), (StopBits)Enum.Parse(typeof(StopBits), frmSerialPortMenu.cbxStopBits.Text), ECom.mSerialPort.IsSendByHex, ECom.mSerialPort.IsReceivedByHex);
                            ChangeCom(CommunicationModel.SerialPort, tbxSerialPortName.Text.Trim(), commParams);
                            ChangeImg(CommunicationModel.SerialPort, Properties.Resources.Success, Properties.Resources.Success, Properties.Resources.Success, Properties.Resources.Success, Properties.Resources.Success, Properties.Resources.Success);
                            msgForm.ShowMsg("替换成功", x, y);
                            ClearFormInfo(CommunicationModel.SerialPort);
                        }
                        else
                        {
                            ChangeImg(CommunicationModel.SerialPort, Properties.Resources.Undetermined, Properties.Resources.Fail, Properties.Resources.Success, Properties.Resources.Success, Properties.Resources.Success, Properties.Resources.Success);
                        }
                        break;
                    }

                    ChangeImg(CommunicationModel.SerialPort, Properties.Resources.Success, Properties.Resources.Success, Properties.Resources.Success, Properties.Resources.Success, Properties.Resources.Success, Properties.Resources.Success);
                    AddComm("串口通讯");
                    msgForm.ShowMsg("添加成功", x, y);
                    ClearFormInfo(CommunicationModel.SerialPort);
                    break;
                case "btnRemoveSerialPort":
                    if (dgvSerialPortList.CurrentCell == null)
                    {
                        msgForm.ShowMsg("设备列表为空", x, y);
                        break;
                    }
                    RemoveComm("串口通讯");
                    break;
                case "btn3PageChange":
                    if (ECom.mSerialPort == null)
                    {
                        msgForm.ShowMsg("设备列表为空", x, y);
                        break;
                    }
                    FrmSerialPortParams.dgvSerialPortList = dgvSerialPortList;
                    string serialPortName = (string)dgvSerialPortList.Rows[dgv3CurCellIndex].Cells[0].Value;
                    int index = Sol.mSol.mEComList.FindIndex(c => c.DeviceName == serialPortName);
                    ECom.mSerialPort = Sol.mSol.mEComList[index];
                    frmSerialPortParams_1 = new FrmSerialPortParams_1();
                    frmSerialPortParams_2 = new FrmSerialPortParams_2();
                    frmSerialPortParams_1.DispSerialPortParams_1();
                    frmSerialPortParams_2.DispSerialPortParams_2();
                    FrmSerialPortParams frmSerialPortParams = new FrmSerialPortParams();
                    frmSerialPortParams.DispSerialPortParams();
                    frmSerialPortParams.Location = new Point(uiPnl.Width / 2 - 20, uiPnl.Height / 2);
                    frmSerialPortParams.StartPosition = FormStartPosition.Manual;
                    frmSerialPortParams.ShowDialog();
                    break;
            }

            ClearFormInfo(CommunicationModel.SerialPort);
        }

        /// <summary>
        /// 客户端点击按钮事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnMbs_Click(object sender, EventArgs e)
        {
            UIButton uiBtn = sender as UIButton;
            MsgForm msgForm = new MsgForm();
            int x = Screen.PrimaryScreen.Bounds.Width / 2 - msgForm.Width / 2 + 31;
            int y = Screen.PrimaryScreen.Bounds.Height / 2 - msgForm.Height / 3;
            bool isEmpty = true;

            if (uiBtn.Name != "btnAddMbsPort")
            {
                HideChlidForm();
            }

            switch (uiBtn.Name)
            {
                case "btnAddMbs":
                    //判断输入内容是否为空

                    if (tbxMbsName.Text == "")
                    {
                        pbxJudge4.BackgroundImage = Properties.Resources.Fail;
                        isEmpty = false;
                    }
                    else
                    {
                        pbxJudge4.BackgroundImage = Properties.Resources.Undetermined;
                    }

                    if (frmMbsMenu.tbxAimIP.Text == "")
                    {
                        frmMbsMenu.pbxJudge1.BackgroundImage = Properties.Resources.Fail;
                        isEmpty = false;
                    }
                    else
                    {
                        frmMbsMenu.pbxJudge1.BackgroundImage = Properties.Resources.Undetermined;
                    }

                    if (frmMbsMenu.tbxAimPort.Text == "")
                    {
                        frmMbsMenu.pbxJudge2.BackgroundImage = Properties.Resources.Fail;
                        isEmpty = false;
                    }
                    else
                    {
                        frmMbsMenu.pbxJudge2.BackgroundImage = Properties.Resources.Undetermined;
                    }

                    if (!isEmpty)
                    {
                        btnMbsMenu.PerformClick();
                        msgForm.ShowMsg("参数内容不能为空", x, y);
                        return;
                    }

                    //判断端口是否超出上限

                    if (Convert.ToDouble(frmMbsMenu.tbxAimPort.Text) > 65535)
                    {
                        ChangeImg(CommunicationModel.Mbs, Properties.Resources.Undetermined, Properties.Resources.Undetermined, Properties.Resources.Fail);
                        btnMbsMenu.PerformClick();
                        msgForm.ShowMsg("端口号超出上限", x, y);
                        return;
                    }

                    //判断Mbs名称是否已经存在

                    int index1 = Sol.mSol.mEComList.FindIndex(c => c.DeviceName == tbxMbsName.Text.Trim() && c.CommunicationModel == CommunicationModel.Mbs);
                    if (index1 >= 0)
                    {
                        ChangeImg(CommunicationModel.Mbs, Properties.Resources.Undetermined, Properties.Resources.Undetermined, Properties.Resources.Undetermined);
                        btnMbsMenu.PerformClick();

                        if (msgForm.ShowMsg("该设备名称已存在，是否替换", x, y))
                        {
                            ChangeCom(CommunicationModel.Mbs, tbxMbsName.Text.Trim(), new CommParams(frmMbsMenu.tbxAimIP.Text, Convert.ToInt32(frmMbsMenu.tbxAimPort.Text), ECom.mMbs.EndData, ECom.mMbs.IsSendByHex, ECom.mMbs.IsReceivedByHex));
                            ChangeImg(CommunicationModel.Mbs, Properties.Resources.Success, Properties.Resources.Success, Properties.Resources.Success);
                            msgForm.ShowMsg("替换成功", x, y);
                            ClearFormInfo(CommunicationModel.TcpClient);
                        }
                        else
                        {
                            ChangeImg(CommunicationModel.TcpClient, Properties.Resources.Fail, Properties.Resources.Undetermined, Properties.Resources.Undetermined);
                        }
                        return;
                    }

                    //判断客户端IP/端口是否已经存在

                    int index2 = Sol.mSol.mEComList.FindIndex(c => ((c.IP == frmMbsMenu.tbxAimIP.Text.Trim()) && (c.Port.ToString() == frmMbsMenu.tbxAimPort.Text.Trim())));
                    if (index2 >= 0)
                    {
                        ChangeImg(CommunicationModel.Mbs, Properties.Resources.Undetermined, Properties.Resources.Undetermined, Properties.Resources.Undetermined);
                        btnMbsMenu.PerformClick();

                        if (msgForm.ShowMsg("该设备IP地址与端口号已存在，是否替换", x, y))
                        {
                            ChangeCom(CommunicationModel.Mbs, tbxMbsName.Text.Trim(), new CommParams(frmMbsMenu.tbxAimIP.Text, Convert.ToInt32(frmMbsMenu.tbxAimPort.Text), ECom.mMbs.EndData, ECom.mMbs.IsSendByHex, ECom.mMbs.IsReceivedByHex));
                            ChangeImg(CommunicationModel.Mbs, Properties.Resources.Success, Properties.Resources.Success, Properties.Resources.Success);
                            msgForm.ShowMsg("替换成功", x, y);
                            ClearFormInfo(CommunicationModel.Mbs);
                        }
                        else
                        {
                            ChangeImg(CommunicationModel.Mbs, Properties.Resources.Undetermined, Properties.Resources.Fail, Properties.Resources.Fail);
                        }
                        return;
                    }

                    ChangeImg(CommunicationModel.Mbs, Properties.Resources.Success, Properties.Resources.Success, Properties.Resources.Success);
                    AddComm("Mbs");
                    msgForm.ShowMsg("添加成功", x, y);
                    ClearFormInfo(CommunicationModel.Mbs);
                    break;
                case "btnRemoveMbs":
                    if (dgvMbsList.CurrentCell == null)
                    {
                        msgForm.ShowMsg("设备列表为空", x, y);
                        break;
                    }
                    RemoveComm("Mbs");
                    break;
                case "btn4PageChange":
                    if (dgvMbsList.CurrentCell == null)
                    {
                        msgForm.ShowMsg("设备列表为空", x, y);
                        break;
                    }
                    FrmMbsParams.dgvMbsList = dgvMbsList;
                    string mbsName = (string)dgvMbsList.Rows[dgv4CurCellIndex].Cells[0].Value;
                    int index = Sol.mSol.mEComList.FindIndex(c => c.DeviceName == mbsName);
                    ECom.mMbs = Sol.mSol.mEComList[index];
                    frmMbsParams_1 = new FrmMbsParams_1();
                    //frmMbsParams_1.DispMbsParams_1();
                    FrmMbsParams frmMbsParams = new FrmMbsParams();
                    frmMbsParams.DispMbsParams();
                    frmMbsParams.Location = new Point(806, 342);
                    frmMbsParams.StartPosition = FormStartPosition.Manual;
                    frmMbsParams.ShowDialog();
                    break;
            }

            ClearFormInfo(CommunicationModel.TcpClient);
        }

        /// <summary>
        /// 展开服务器的IP和端口设置菜单
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnServerMenu_Click(object sender, EventArgs e)
        {
            //显示服务器设置窗体
            Point mouseOff = btnServerMenu.PointToScreen(new Point(0, 0));
            frmServerMenu.Location = new Point(mouseOff.X + btnServerMenu.Width / 2, mouseOff.Y + btnServerMenu.Height / 2);
            frmServerMenu.StartPosition = FormStartPosition.Manual;
            frmServerMenu.Show();
        }

        /// <summary>
        /// 展开客户端的IP和端口设置菜单
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnClientMenu_Click(object sender, EventArgs e)
        {
            //显示客户端设置窗体
            Point mouseOff = btnClientMenu.PointToScreen(new Point(0, 0));
            frmClientMenu.Location = new Point(mouseOff.X + btnClientMenu.Width / 2, mouseOff.Y + btnClientMenu.Height / 2);
            frmClientMenu.StartPosition = FormStartPosition.Manual;
            frmClientMenu.Show();
        }

        /// <summary>
        /// 展开串口的设置菜单
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSerialPortMenu_Click(object sender, EventArgs e)
        {
            //显示串口设置窗体
            Point mouseOff = btnSerialPortMenu.PointToScreen(new Point(0, 0));
            frmSerialPortMenu.Location = new Point(mouseOff.X + btnSerialPortMenu.Width / 2, mouseOff.Y + btnSerialPortMenu.Height / 2);
            frmSerialPortMenu.StartPosition = FormStartPosition.Manual;
            frmSerialPortMenu.Show();
        }

        /// <summary>
        /// 展开Mbs的IP和端口设置菜单
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnMbsMenu_Click(object sender, EventArgs e)
        {
            //显示客户端设置窗体
            Point mouseOff = btnMbsMenu.PointToScreen(new Point(0, 0));
            frmMbsMenu.Location = new Point(mouseOff.X + btnMbsMenu.Width / 2, mouseOff.Y + btnMbsMenu.Height / 2);
            frmMbsMenu.StartPosition = FormStartPosition.Manual;
            frmMbsMenu.Show();
        }

        #endregion

        #region 事件-窗体控件

        /// <summary>
        /// 更改选项卡时隐藏子窗体
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void uiTabControl_SelectedIndexChanged(object sender, EventArgs e)
        {
            HideChlidForm();
        }

        #endregion
    }
}
