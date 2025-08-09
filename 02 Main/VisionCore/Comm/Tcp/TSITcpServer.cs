using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Net;
using System.Net.Sockets;
using System.Threading.Tasks;
using System.Threading;
using MutualTools;
using System.Net.NetworkInformation;

namespace VisionCore.Comm.Tcp
{
    /// <summary>
    /// 客户端信息类
    /// </summary>
    public class ClientInfo
    {
        /// <summary>
        /// 客户端
        /// </summary>
        public Socket client;

        /// <summary>
        /// 客户端IP
        /// </summary>
        public string clientIP;

        /// <summary>
        /// 客户端端口
        /// </summary>
        public int clientPort;

        /// <summary>
        /// 接收到的的数据
        /// </summary>
        public string receivedData;

        /// <summary>
        /// 部分数据
        /// </summary>
        public string partData;

        /// <summary>
        /// 是否接收完成
        /// </summary>
        public bool isRecOver = true;

        /// <summary>
        /// 初始化
        /// </summary>
        /// <param name="client"></param>
        /// <param name="clientIP"></param>
        /// <param name="clientPort"></param>
        /// <param name="receivedData"></param>
        /// <param name="partData"></param>
        public ClientInfo(Socket client, string clientIP, int clientPort, string receivedData, string partData)
        {
            this.client = client;
            this.clientIP = clientIP;
            this.clientPort = clientPort;
            this.receivedData = receivedData;
            this.partData = partData;
        }
    }

    public class TSITcpServer
    {
        #region 字段、属性

        /// <summary>
        /// 本地IP
        /// </summary>
        public string localIP;

        /// <summary>
        /// 本地端口
        /// </summary>
        public int localPort;

        /// <summary>
        /// 是否开启
        /// </summary>
        public bool isOpen = true;

        /// <summary>
        /// 是否已连接
        /// </summary>
        public bool isConnected = false;

        /// <summary>
        /// 结束字符
        /// </summary>
        public string endData = "\n";

        /// <summary>
        /// 是否以十六进制发送
        /// </summary>
        public bool isSendByHex = false;

        /// <summary>
        /// 是否以十六进制接收
        /// </summary>
        public bool isReceiveByHex = false;

        /// <summary>
        /// 客户端信息列表
        /// </summary>
        public List<ClientInfo> clientInfoList = new List<ClientInfo>();

        /// <summary>
        /// 服务端
        /// </summary>
        public Socket tcpServer;

        /// <summary>
        /// Tcp服务端监控/重连线程
        /// </summary>
        public Thread thServer;

        /// <summary>
        /// Tcp服务端监听线程
        /// </summary>
        public Thread thServerListen;

        /// <summary>
        /// 锁
        /// </summary>
        public object lockObj = new object();

        #endregion

        #region 初始化

        /// <summary>
        /// 初始化
        /// </summary>
        public TSITcpServer(string localIP, int localPort, bool isOpen, string endData, bool isSendByHex, bool isReceiveByHex)
        {
            this.localIP = localIP;
            this.localPort = localPort;
            this.isOpen = isOpen;
            this.endData = endData;
            this.isSendByHex = isSendByHex;
            this.isReceiveByHex = isReceiveByHex;
        }

        #endregion

        #region 方法-服务端操作相关

        /// <summary>
        /// 开启
        /// </summary>
        public void Open()
        {
            try
            {
                tcpServer = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
                tcpServer.Bind(new IPEndPoint(IPAddress.Parse(localIP), localPort));
                tcpServer.Listen(10);
                isConnected = true;
            }
            catch 
            {
                isConnected = false;
            }

            try
            {
                thServer = new Thread(new ThreadStart(MinitorOpen));
                thServerListen = new Thread(new ThreadStart(Listening));
                thServer.IsBackground = true;
                thServerListen.IsBackground = true;
                thServer.Start();
                thServerListen.Start();
            }
            catch { }
        }

        /// <summary>
        /// 关闭
        /// </summary>
        public void Close()
        {
            if (thServer != null)
            {
                thServer.Abort();
                thServerListen.Abort();
            }

            if (tcpServer != null)
            {
                tcpServer.Close();
            }

            for (int i = 0; i < clientInfoList.Count; i++)
            {
                clientInfoList.RemoveAt(i);
            }

            isConnected = false;
        }

        /// <summary>
        /// 监听
        /// </summary>
        public void Listening()
        {
            Socket client = null;

            while (true)
            {
                if (isOpen)
                {
                    try
                    {
                        client = tcpServer.Accept();
                        Thread.Sleep(10);
                        clientInfoList.Add(new ClientInfo(client, ((IPEndPoint)client.RemoteEndPoint).Address.ToString(), Convert.ToInt32(((IPEndPoint)client.RemoteEndPoint).Port), "", ""));
                    }
                    catch (Exception) { }
                }
            }
        }

        /// <summary>
        /// 监控服务器开启情况/重开
        /// </summary>
        private void MinitorOpen()
        {
            while (true)
            {
                lock (lockObj)
                {
                    if (isOpen)
                    {
                        if (!isConnected)
                        {
                            try
                            {
                                tcpServer.Bind(new IPEndPoint(IPAddress.Parse(localIP), localPort));
                                isConnected = CommRTools.CheckNetCableConn(localIP);
                            }
                            catch (Exception ex)
                            {
                                tcpServer = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
                                isConnected = false;
                            }
                        }
                        else
                        {
                            if (!tcpServer.IsBound) isConnected = false;
                        }
                    }
                    else
                    {
                        isConnected = false;
                    }
                }
                   
                Thread.Sleep(1000);
            }
        }

        /// <summary>
        /// 服务器接收客户端信息
        /// </summary>
        /// <param name="obj"></param>
        public bool RecClientMsg(ClientInfo clientInfo)
        {
            lock (lockObj)
            {
                clientInfo.receivedData = "";
                string strData = "";

                try
                {
                    if (!CommRTools.CheckNetCableConn(clientInfo.clientIP) || clientInfo.client == null) return false;
                    clientInfo.client.ReceiveTimeout = 200;

                    byte[] readBytes = new byte[1024];
                    if (isConnected)
                    {
                        bool isFor = true;
                        while (isFor)
                        {
                            int receiveByteNum = clientInfo.client.Receive(readBytes);
                            if (receiveByteNum != 0)
                            {
                                string strRead = Encoding.Default.GetString(readBytes).Split('\0')[0];
                                int strNum = strRead.Length;
                                string endDataFinal = endData;
                                bool isContainsStr = false;

                                string[] strAssem = { "\\r\\n", "\\r", "\\n" };
                                for (int j = 0; j < strAssem.Length; j++)
                                {
                                    if (strRead.Contains(strAssem[j]))
                                    {
                                        isContainsStr = true;
                                        endDataFinal = strAssem[j];
                                        break;
                                    }
                                }

                                if (strRead.Contains(endData) || isContainsStr)
                                {
                                    int idx1 = strRead.IndexOf(endData);
                                    int idx2 = strRead.LastIndexOf(endData);
                                    strData = clientInfo.partData + strRead.Substring(0, idx1);
                                    switch (endDataFinal)
                                    {
                                        case "\r":
                                            clientInfo.partData = strRead.Substring(idx2 + 1, (strNum - idx2 - 1));
                                            break;
                                        case "\n":
                                            clientInfo.partData = strRead.Substring(idx2 + 1, (strNum - idx2 - 1));
                                            break;
                                        case "\r\n":
                                            clientInfo.partData = strRead.Substring(idx2 + 1, (strNum - idx2 - 1));
                                            break;
                                        case "\\r":
                                            clientInfo.partData = strRead.Substring(idx2 + 1, (strNum - idx2 - 2));
                                            break;
                                        case "\\n":
                                            clientInfo.partData = strRead.Substring(idx2 + 1, (strNum - idx2 - 2));
                                            break;
                                        case "\\r\\n":
                                            clientInfo.partData = strRead.Substring(idx2 + 1, (strNum - idx2 - 4));
                                            break;
                                    }
                                }
                                else
                                {
                                    clientInfo.partData += strRead.Substring(0, strNum);
                                }
                            }
                            else
                            {
                                return false;
                            }
                            break;
                        }

                        if (isReceiveByHex)
                        {
                            clientInfo.receivedData = TypeConvert.StrToHexStr(strData);
                        }
                        else
                        {
                            clientInfo.receivedData = strData;
                        }
                    }
                }
                catch (Exception ex) { }

                return true;
            }
        }

        /// <summary>
        /// 剔除客户端
        /// </summary>
        /// <param name="socket"></param>
        public void RemoveClient(ClientInfo clientInfo)
        {
            if (clientInfo.client != null)
            {
                clientInfo.client.Close();
                clientInfoList.Remove(clientInfo);
            }
        }

        /// <summary>
        /// 发送数据
        /// </summary>
        /// <param name="ip">IP地址</param>
        /// <param name="port">端口号</param>
        /// <param name="strData">发送字符串</param>
        public bool SendData(ClientInfo clientInfo, string msg)
        {
            try
            {
                byte[] bytes;

                if (isSendByHex) msg = TypeConvert.HexStrToStr(msg);
                msg += endData;
                bytes = Encoding.Default.GetBytes(msg);
                clientInfo.client.Send(bytes);

                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        #endregion
    }
}
