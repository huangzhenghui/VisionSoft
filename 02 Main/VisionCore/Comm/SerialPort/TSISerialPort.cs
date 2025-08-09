using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO.Ports;
using System.Threading;
using MutualTools;

namespace VisionCore.Comm.SerialPortR
{
    public class TSISerialPort
    {
        #region 字段、属性

        /// <summary>
        /// 串口号
        /// </summary>
        public string serialPorttName;

        /// <summary>
        /// 波特率
        /// </summary>
        public int baudRate;

        /// <summary>
        /// 校验位
        /// </summary>
        public Parity checkBits;

        /// <summary>
        /// 数据位
        /// </summary>
        public int dataBits;

        /// <summary>
        /// 停止位
        /// </summary>
        public StopBits stopBits;

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
        /// 接收到的数据
        /// </summary>
        public string receivedData = "";

        /// <summary>
        /// 串口
        /// </summary>
        public SerialPort serialPort;

        /// <summary>
        /// 串口监控/重连工作线程
        /// </summary>
        public Thread thSerialPort;

        /// <summary>
        /// 锁
        /// </summary>
        public object lockObj = new object();

        #endregion

        #region 初始化

        /// <summary>
        /// 初始化
        /// </summary>
        /// <param name="serialPorttName"></param>
        /// <param name="baudRate"></param>
        /// <param name="checkBits"></param>
        /// <param name="dataBits"></param>
        /// <param name="stopBits"></param>
        /// <param name="isOpen"></param>
        /// <param name="endData"></param>
        /// <param name="isSendByHex"></param>
        /// <param name="isReceiveByHex"></param>
        public TSISerialPort(string serialPorttName, int baudRate, Parity checkBits, int dataBits, StopBits stopBits, bool isOpen, bool isSendByHex, bool isReceiveByHex)
        {
            this.serialPorttName = serialPorttName;
            this.baudRate = baudRate;
            this.checkBits = checkBits;
            this.dataBits = dataBits;
            this.stopBits = stopBits;
            this.isOpen = isOpen;
            this.isSendByHex = isSendByHex;
            this.isReceiveByHex = isReceiveByHex;
        }

        #endregion

        #region 方法-串口操作相关

        /// <summary>
        /// 开启
        /// </summary>
        public void Open()
        {
            try
            {
                serialPort = new SerialPort(serialPorttName, baudRate, checkBits, dataBits, stopBits);
                thSerialPort = new Thread(new ThreadStart(MinitorOpen));
                thSerialPort.IsBackground = true;
                thSerialPort.Start();
            }
            catch { }
        }

        /// <summary>
        /// 关闭
        /// </summary>
        public void Close()
        {
            if (thSerialPort != null)
            {
                thSerialPort.Abort();
            }

            if (serialPort != null)
            {
                serialPort.Close();
            }

            isConnected = false;
        }

        /// <summary>
        /// 监控开启情况/重开
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
                                serialPort.Open();
                                isConnected = serialPort.IsOpen;
                            }
                            catch (Exception ex)
                            {
                                serialPort = new SerialPort(serialPorttName, baudRate, checkBits, dataBits, stopBits);
                                isConnected = false;
                            }
                        }
                        else
                        {
                            if (!serialPort.IsOpen) isConnected = false;
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
                    if (!serialPort.IsOpen) return "";
                    serialPort.ReadTimeout = 100;

                    int len = 1024;
                    byte[] readBytes = new byte[len];
                    if (isConnected)
                    {
                        int receiveByteNum = serialPort.Read(readBytes, 0, len);
                        if (receiveByteNum != 0)
                        {
                            strData = Encoding.Default.GetString(readBytes).Split('\0')[0];

                        }
                        else
                        {
                            isConnected = false;
                        }
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
                msg += CommRTools.XORCheck(msg);
                if (isSendByHex) msg = TypeConvert.HexStrToStr(msg);
                bytes = Encoding.Default.GetBytes(msg);
                serialPort.Write(bytes, 0, bytes.Length);

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
