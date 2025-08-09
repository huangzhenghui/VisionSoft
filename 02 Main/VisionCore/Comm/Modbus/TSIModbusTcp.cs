using HslCommunication;
using HslCommunication.ModBus;
using MutualTools;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace VisionCore.Comm.Modbus
{
    public class TSIModbusTcp
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
        /// 是否以十六进制发送
        /// </summary>
        public bool isSendByHex = false;

        /// <summary>
        /// 是否以十六进制接收
        /// </summary>
        public bool isReceiveByHex = false;

        /// <summary>
        /// PLC数据类型
        /// </summary>
        public PLCDataFormat dataFormat = PLCDataFormat.ABCD;

        /// <summary>
        /// 读寄存器首地址
        /// </summary>
        public string addressR = "D0";

        /// <summary>
        /// 写寄存器首地址
        /// </summary>
        public string addressW = "D0";

        /// <summary>
        /// 读取数据长度
        /// </summary>
        public ushort dataLength = 10;

        /// <summary>
        /// 数据列表
        /// </summary>
        public List<string> receivedData = new List<string>();

        /// <summary>
        /// ModbusTcp
        /// </summary>
        public ModbusTcpNet modbusTcpNet;

        /// <summary>
        /// ModbusTcp监控连接/重连线程
        /// </summary>
        public Thread thModbusTcp;

        /// <summary>
        /// 锁
        /// </summary>
        public object lockObj = new object();

        #endregion

        #region 初始化

        /// <summary>
        /// 初始化
        /// </summary>
        public TSIModbusTcp(string aimIP, int aimPort, bool isOpen, bool isSendByHex, bool isReceiveByHex)
        {
            this.aimIP = aimIP;
            this.aimPort = aimPort;
            this.isOpen = isOpen;
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
                modbusTcpNet = new ModbusTcpNet(aimIP, aimPort);
                thModbusTcp = new Thread(new ThreadStart(MinitorConnection));
                thModbusTcp.IsBackground = true;
                thModbusTcp.Start();
            }
            catch { }
        }

        /// <summary>
        /// 断开
        /// </summary>
        public void DisConnect()
        {
            if (thModbusTcp != null)
            {
                thModbusTcp.Abort();
            }

            if (modbusTcpNet != null)
            {
                modbusTcpNet.ConnectClose();
            }

            isConnected = false;
        }

        /// <summary>
        /// 监控连接情况/重连
        /// </summary>
        public void MinitorConnection()
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
                                modbusTcpNet.ConnectServer();
                                isConnected = CommRTools.CheckNetCableConn(aimIP);
                            }
                            catch (Exception ex)
                            {
                                modbusTcpNet = new ModbusTcpNet(aimIP, aimPort);
                                isConnected = false;
                            }
                        }
                        else
                        {
                            if (!CommRTools.CheckNetCableConn(aimIP)) isConnected = false;
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

        public List<string> ReceiveData(PLCDataType pLCDataType)
        {
            lock (lockObj)
            {
                receivedData = new List<string>();

                try
                {
                    List<string> dataList = new List<string>();
                    switch (pLCDataType)
                    {
                        case PLCDataType.短整型:
                            OperateResult<short[]> shortR = modbusTcpNet.ReadInt16(addressR, dataLength);
                            dataList = TypeConvert.AssemToStrList(shortR.Content);
                            break;
                        case PLCDataType.无符号短整型:
                            OperateResult<ushort[]> ushortR = modbusTcpNet.ReadUInt16(addressR, dataLength);
                            dataList = TypeConvert.AssemToStrList(ushortR.Content);
                            break;
                        case PLCDataType.单精度:
                            OperateResult<float[]> floatR = modbusTcpNet.ReadFloat(addressR, dataLength);
                            dataList = TypeConvert.AssemToStrList(floatR.Content);
                            break;
                        case PLCDataType.字符串:
                            OperateResult<string> stringR = modbusTcpNet.ReadString(addressR, dataLength);
                            dataList.Add(stringR.Content);
                            break;
                    }

                    foreach (string item in dataList)
                    {
                        if (isReceiveByHex)
                        {
                            receivedData.Add(TypeConvert.StrToHexStr(item));
                        }
                        else
                        {
                            receivedData.Add(item);
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
        public bool SendData(PLCDataType pLCDataType, string[] msg)
        {
            try
            {
                if (isSendByHex)
                {
                    for (int i = 0; i < msg.Length; i++)
                    {
                        msg[i] = TypeConvert.HexStrToStr(msg[i]);
                    }
                }

                switch (pLCDataType)
                {
                    case PLCDataType.短整型:
                        modbusTcpNet.Write(addressW, TypeConvert.StrAssemToAssem<short>(msg));
                        break;
                    case PLCDataType.无符号短整型:
                        modbusTcpNet.Write(addressW, TypeConvert.StrAssemToAssem<ushort>(msg));
                        break;
                    case PLCDataType.单精度:
                        modbusTcpNet.Write(addressW, TypeConvert.StrAssemToAssem<float>(msg));
                        break;
                    case PLCDataType.字符串:
                        modbusTcpNet.Write(addressW, msg[0]);
                        break;
                }

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
