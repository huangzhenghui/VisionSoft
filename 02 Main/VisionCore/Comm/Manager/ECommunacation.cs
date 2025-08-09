using Rex.UI;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO.Ports;
using System.Net;
using System.Net.Sockets;
using System.Reflection.Emit;
using System.Runtime.Serialization;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using VisionCore.Comm.Modbus;
using VisionCore.Comm.SerialPortR;
using VisionCore.Comm.Tcp;

namespace VisionCore
{
    #region 枚举

    /// <summary>
    /// 通讯模式
    /// </summary>
    public enum CommunicationModel
    {
        TcpClient = 0,//客户端
        TcpServer = 1,//服务端
        SerialPort = 2,//串口
        Mbs=3//Mbs
    }

    #endregion

    #region 委托

    /// <summary>
    /// 接收字符串的委托
    /// </summary>
    /// <param name="str"></param>
    public delegate void ReceiveString(string str);

    #endregion

    /// <summary>
    /// 通讯类
    /// </summary>
    [Serializable]
    public class ECom
    {
        #region 字段、属性-网口参数

        /// <summary>
        /// 服务器列表
        /// </summary>
        public static List<ECom> serverList = new List<ECom>();

        /// <summary>
        /// 当前编辑的服务器
        /// </summary>
        public static ECom mServer;

        /// <summary>
        /// 当前服务器的测试客户端
        /// </summary>
        public static string mServerClient = "All(0)";

        /// <summary>
        /// 客户端列表
        /// </summary>
        public static List<ECom> clientList = new List<ECom>();

        /// <summary>
        /// 当前编辑的客户端
        /// </summary>
        public static ECom mClient;

        /// <summary>
        /// IP
        /// </summary>
        public string IP { get; set; }

        /// <summary>
        /// 端口号
        /// </summary>
        public int Port { get; set; }

        /// <summary>
        /// TCP服务端
        /// </summary>
        [NonSerialized]
        public TSITcpServer tSITcpServer;

        /// <summary>
        /// TCP客户端
        /// </summary>
        [NonSerialized]
        public TSITcpClient tSITcpClient;

        #endregion

        #region 字段、属性-串口参数

        /// <summary>
        /// 串口列表
        /// </summary>
        public static List<ECom> serialPortList = new List<ECom>();

        /// <summary>
        /// 当前串口
        /// </summary>
        public static ECom mSerialPort;

        /// <summary>
        /// 串口号
        /// </summary>
        public string SerialPortNum { get; set; }

        /// <summary>
        /// 波特率
        /// </summary>
        public int BaudRate { get; set; }

        /// <summary>
        /// 校验位
        /// </summary>
        public Parity CheckBits { get; set; }

        /// <summary>
        /// 数据位
        /// </summary>
        public int DataBits { get; set; }

        /// <summary>
        /// 停止位
        /// </summary>
        public StopBits ShutBits { get; set; }

        /// <summary>
        /// 串口
        /// </summary>
        [NonSerialized]
        public TSISerialPort tSISerialPort;

        #endregion

        #region 字段、属性-Mbs参数

        /// <summary>
        /// Mbs列表
        /// </summary>
        public static List<ECom> mbsList = new List<ECom>();

        /// <summary>
        /// 当前Mbs
        /// </summary>
        public static ECom mMbs;

        /// <summary>
        /// Mbs
        /// </summary>
        [NonSerialized]
        public TSIModbusTcp tSIModbusTcp;

        #endregion

        #region 字段、属性-共有

        /// <summary>
        /// 刷新设备连接状态的线程
        /// </summary>
        [NonSerialized]
        public Thread thRefreshConnState;

        /// <summary>
        /// 设备名称
        /// </summary>
        public string DeviceName { get; set; }

        /// <summary>
        /// 接收信息区域
        /// </summary>
        public static UITextBox RecMsgReg { get; set; }

        /// <summary>
        /// 数据接收状态，true-接收到数据，false-未接收到数据，为防止Timer重复接收
        /// </summary>
        public static bool RecState;

        /// <summary>
        /// 收到的数据
        /// </summary>
        public string readData = "";

        /// <summary>
        /// 部分数据
        /// </summary>
        public string partData = "";

        /// <summary>
        /// 内部名称
        /// </summary>
        public string Key { get; set; }

        /// <summary>
        /// 通讯模式
        /// </summary>
        public CommunicationModel CommunicationModel { get; set; } = CommunicationModel.TcpServer;

        /// <summary>
        /// 是否开启连接或监听
        /// </summary>
        public bool IsOpen { get; set; } = true;

        /// <summary>
        /// 是否连接或监听
        /// </summary>
        public bool IsConnected { get; set; } = false;

        /// <summary>
        /// 结束字符
        /// </summary>
        public string EndData { get; set; } = "\n";

        /// <summary>
        /// 是否使用十六进制发送
        /// </summary>
        public bool IsSendByHex { get; set; }

        /// <summary>
        /// 是否使用十六进制接收
        /// </summary>
        public bool IsReceivedByHex { get; set; }

        /// <summary>
        /// 锁
        /// </summary>
        public Object lockObj;

        #endregion

        #region 方法-通讯相关

        /// <summary>
        /// 连接
        /// </summary>
        /// <returns></returns>
        public void Connect()
        {
            lock (lockObj)
            {
                if (IsConnected == true) return;//已经连接 则不执行
                switch (CommunicationModel)
                {
                    case CommunicationModel.TcpServer:
                        tSITcpServer = new TSITcpServer(IP, Port, IsOpen, EndData, IsSendByHex, IsReceivedByHex);
                        tSITcpServer.Open();
                        break;
                    case CommunicationModel.TcpClient:
                        tSITcpClient = new TSITcpClient(IP, Port, IsOpen, EndData, IsSendByHex, IsReceivedByHex);
                        tSITcpClient.Connect();
                        break;
                    case CommunicationModel.SerialPort:
                        tSISerialPort = new TSISerialPort(SerialPortNum, BaudRate, CheckBits, DataBits, ShutBits, IsOpen, IsSendByHex, IsReceivedByHex);
                        tSISerialPort.Open();
                        break;
                    case CommunicationModel.Mbs:
                        tSIModbusTcp = new TSIModbusTcp(IP, Port, IsOpen, IsSendByHex, IsReceivedByHex);
                        tSIModbusTcp.Connect();
                        break;
                }
            }
        }

        /// <summary>
        /// 断开连接
        /// </summary>
        public void DisConnect()
        {
            lock (lockObj)
            {
                IsConnected = false;
                switch (CommunicationModel)
                {
                    case CommunicationModel.TcpServer:
                        if (tSITcpServer != null) tSITcpServer.Close();
                        break;
                    case CommunicationModel.TcpClient:
                        if (tSITcpClient != null) tSITcpClient.DisConnect();
                        break;
                    case CommunicationModel.SerialPort:
                        if (tSISerialPort != null) tSISerialPort.Close();
                        break;
                    case CommunicationModel.Mbs:
                        if (tSIModbusTcp != null) tSIModbusTcp.DisConnect();
                        break;
                }
            }
        }

        /// <summary>
        /// 服务端接收数据
        /// </summary>
        /// <param name="clientInfo"></param>
        public bool ReceiveData(ClientInfo clientInfo)
        {
            if (tSITcpServer == null) return false;
            int idx = tSITcpServer.clientInfoList.FindIndex(c => c.clientIP == clientInfo.clientIP && c.clientPort == clientInfo.clientPort);
            clientInfo.receivedData = "";
            bool isOK = tSITcpServer.RecClientMsg(clientInfo);
            return isOK;
        }

        /// <summary>
        /// 非服务端接收数据
        /// </summary>
        public void ReceiveData()
        {
            switch (CommunicationModel)
            {
                case CommunicationModel.TcpClient:
                    if (tSITcpClient == null) return;
                    readData = "";
                    readData = tSITcpClient.ReceiveData();
                    break;
                case CommunicationModel.SerialPort:
                    if (tSISerialPort == null) return;
                    readData = "";
                    readData = tSISerialPort.ReceiveData();
                    break;
            }
        }

        /// <summary>
        /// 服务端发送数据
        /// </summary>
        /// <param name="clientInfo"></param>
        /// <param name="str"></param>
        /// <returns></returns>
        public bool SendData(ClientInfo clientInfo, string str)
        {
            bool flag = false;
            if (tSITcpServer == null) return false;
            flag = tSITcpServer.SendData(clientInfo, str);
            return flag;
        }

        /// <summary>
        /// 非服务端发送数据
        /// </summary>
        /// <param name="str"></param>
        /// <returns></returns>
        public bool SendData(string str)
        {
            bool flag = false;
            if (IsConnected == false)
            {
                return false;
            }

            switch (CommunicationModel)
            {
                case CommunicationModel.TcpClient:
                    if (tSITcpClient == null) return false;
                    flag = tSITcpClient.SendData(str);
                    break;
                case CommunicationModel.SerialPort:
                    if (tSISerialPort == null) return false;
                    flag = tSISerialPort.SendData(str);
                    break;
            }

            return flag;
        }

        #endregion
    }
}
