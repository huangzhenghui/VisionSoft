using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Net;
using System.Net.Sockets;
using System.Threading.Tasks;
using MutualTools;
using System.Net.NetworkInformation;

namespace VisionCore.Comm.Tcp
{
    public class TSITcpClient
    {
        #region 字段、属性

        /// <summary>
        /// 目标服务器IP
        /// </summary>
        public string aimIP;

        /// <summary>
        /// 目标服务器端口
        /// </summary>
        public int aimPort;

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
        /// 接收到的数据
        /// </summary>
        public string receivedData = "";

        /// <summary>
        /// 部分数据
        /// </summary>
        public string partData = "";

        /// <summary>
        /// 客户端
        /// </summary>
        public TcpClient tcpClient;

        /// <summary>
        /// Tcp客户端监控连接/重连线程
        /// </summary>
        public Thread thClient;

        /// <summary>
        /// 锁
        /// </summary>
        public object lockObj = new object();

        #endregion

        #region 初始化

        /// <summary>
        /// 初始化
        /// </summary>
        public TSITcpClient(string aimIP, int aimPort, bool isOpen, string endData, bool isSendByHex, bool isReceiveByHex)
        {
            this.aimIP = aimIP;
            this.aimPort = aimPort;
            this.isOpen = isOpen;
            this.endData = endData;
            this.isSendByHex = isSendByHex;
            this.isReceiveByHex = isReceiveByHex;
        }

        #endregion

        #region 方法-客户端操作相关

        /// <summary>
        /// 连接
        /// </summary>
        public void Connect()
        {
            try
            {
                tcpClient = new TcpClient();
                thClient = new Thread(new ThreadStart(MinitorConnection));
                thClient.IsBackground = true;
                thClient.Start();
            }
            catch { }
        }

        /// <summary>
        /// 断开
        /// </summary>
        public void DisConnect()
        {
            if (thClient != null)
            {
                thClient.Abort();
            }

            if (tcpClient != null)
            {
                tcpClient.Close();
            }

            isConnected = false;
        }

        /// <summary>
        /// 监控连接情况/重连
        /// </summary>
        private void MinitorConnection()
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
                                tcpClient.Connect(IPAddress.Parse(aimIP), aimPort);
                                isConnected = CommRTools.CheckNetCableConn(aimIP);
                            }
                            catch (Exception ex)
                            {
                                tcpClient = new TcpClient();
                                isConnected = false;
                            }
                        }
                        else
                        {
                            if (!tcpClient.Client.Connected || !CommRTools.CheckNetCableConn(aimIP)) isConnected = false;
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
        /// 接收数据
        /// </summary>
        /// <param name="eComDataType"></param>
        public string ReceiveData()
        {
            lock (lockObj)
            {
                receivedData = "";
                string strData = "";

                try
                {
                    if (!CommRTools.CheckNetCableConn(aimIP) || tcpClient.Client == null) return "";
                    tcpClient.ReceiveTimeout = 100;

                    byte[] readBytes = new byte[1024];
                    if (isConnected)
                    {
                        bool isFor = true;
                        while (isFor)
                        {
                            int receiveByteNum = tcpClient.Client.Receive(readBytes);
                            if (receiveByteNum != 0)
                            {
                                string strRead = Encoding.Default.GetString(readBytes).Split('\0')[0];
                                int strNum = strRead.Length;
                                string endDataFinal = endData;
                                bool isContainsStr = false;

                                string[] strAssem = { "\\r\\n", "\\r", "\\n" };
                                for (int i = 0; i < strAssem.Length; i++)
                                {
                                    if (strRead.Contains(strAssem[i]))
                                    {
                                        isContainsStr = true;
                                        endDataFinal = strAssem[i];
                                        break;
                                    }
                                }

                                if (strRead.Contains(endData) || isContainsStr)
                                {
                                    int idx1 = strRead.IndexOf(endDataFinal);
                                    int idx2 = strRead.LastIndexOf(endDataFinal);
                                    strData = partData + strRead.Substring(0, idx1);
                                    switch (endDataFinal)
                                    {
                                        case "\r":
                                            partData = strRead.Substring(idx2 + 1, (strNum - idx2 - 1));
                                            break;
                                        case "\n":
                                            partData = strRead.Substring(idx2 + 1, (strNum - idx2 - 1));
                                            break;
                                        case "\r\n":
                                            partData = strRead.Substring(idx2 + 1, (strNum - idx2 - 1));
                                            break;
                                        case "\\r":
                                            partData = strRead.Substring(idx2 + 1, (strNum - idx2 - 2));
                                            break;
                                        case "\\n":
                                            partData = strRead.Substring(idx2 + 1, (strNum - idx2 - 2));
                                            break;
                                        case "\\r\\n":
                                            partData = strRead.Substring(idx2 + 1, (strNum - idx2 - 4));
                                            break;
                                    }
                                }
                                else
                                {
                                    partData += strRead.Substring(0, strNum);
                                }
                            }
                            else
                            {
                                isConnected = false;
                            }
                            break;
                        }

                        if (isReceiveByHex)
                        {
                            receivedData = TypeConvert.StrToHexStr(strData);
                        }
                        else
                        {
                            receivedData = strData;
                        }
                    }
                }
                catch (Exception ex) { }

                return receivedData;
            }
        }

        /// <summary>
        /// 发送数据
        /// </summary>
        public bool SendData(string msg)
        {
            try
            {
                byte[] bytes;

                if (isSendByHex) msg = TypeConvert.HexStrToStr(msg);
                msg += endData;
                bytes = Encoding.Default.GetBytes(msg);
                tcpClient.Client.Send(bytes);

                return true;
            }
            catch(Exception ex)
            {
                return false;
            }
        }

        #endregion
    }
}
