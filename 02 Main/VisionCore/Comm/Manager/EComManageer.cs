using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace VisionCore
{
    public delegate void SetEComDg(ECom eCom, EComOperate eComType);
    [Serializable]
    public class EComManageer
    {
        /// <summary>
        /// 设置设备的事件
        /// </summary>
        public static event SetEComDg SetEComEvent;

        /// <summary>
        /// 设备集合
        /// </summary>
        private static Dictionary<string, ECom> s_ECommunacationDic = new Dictionary<string, ECom>();

        /// <summary>
        /// 反序列化后刷新
        /// </summary>
        /// <param name="eComList"></param>
        public static void SetEcomList(List<ECom> eComList)
        {
            foreach (string key in s_ECommunacationDic.Keys)
            {
                s_ECommunacationDic[key].DisConnect();
            }
            s_ECommunacationDic.Clear();
            if (eComList != null)
            {
                foreach (ECom eCom in eComList)
                {
                    s_ECommunacationDic[eCom.DeviceName] = eCom;
                    eCom.IsConnected = false;
                    //根据开启状态来连接
                    if (eCom.IsOpen)
                    {
                        eCom.Connect();
                    }
                    else
                    {
                        eCom.DisConnect();
                    }
                    SetEComEvent(eCom, EComOperate.Add);
                }
            }

            StartRefreshConnState();
        }

        /// <summary>
        /// 获取通讯设备
        /// </summary>
        /// <param name="DeviceName"></param>
        /// <returns></returns>
        public static ECom GetECommunacation(string DeviceName)
        {
            if (s_ECommunacationDic.ContainsKey(DeviceName))
            {
                return s_ECommunacationDic[DeviceName];
            }
            return null;
        }

        /// <summary>
        /// 创建设备
        /// </summary>
        /// <param name="communicationModel"></param>
        /// <returns></returns>
        public static string CreateECom(CommunicationModel communicationModel,string DeviceName)
        {
            ECom ec = new ECom();
            ec.CommunicationModel = communicationModel;
            ec.DeviceName = DeviceName;
            ec.lockObj = new object();
            s_ECommunacationDic[DeviceName] = ec;

            return DeviceName;
        }

        /// <summary>
        /// 刷新设备连接状态
        /// </summary>
        public static void StartRefreshConnState()
        {
            Thread thRefreshConnState = new Thread(new ThreadStart(() =>
            {
                while (true)
                {
                    foreach (ECom item in Sol.mSol.mEComList)
                    {
                        lock (item.lockObj)
                        {
                            switch (item.CommunicationModel)
                            {
                                case CommunicationModel.TcpServer:
                                    if (item.tSITcpServer != null) item.IsConnected = item.tSITcpServer.isConnected;
                                    break;
                                case CommunicationModel.TcpClient:
                                    if (item.tSITcpClient != null) item.IsConnected = item.tSITcpClient.isConnected;
                                    break;
                                case CommunicationModel.SerialPort:
                                    if (item.tSISerialPort != null) item.IsConnected = item.tSISerialPort.isConnected;
                                    break;
                            }
                        }
                    }

                    Thread.Sleep(50);
                }
            }));

            thRefreshConnState.IsBackground = true;
            thRefreshConnState.Start();
        }
    }
}
