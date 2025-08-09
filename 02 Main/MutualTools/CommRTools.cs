using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;

namespace MutualTools
{
    public class CommRTools
    {
        /// <summary>
        /// 检查网线是否连接
        /// </summary>
        /// <param name="IP"></param>
        /// <returns></returns>
        public static bool CheckNetCableConn(string IP)
        {
            try
            {
                Ping ping = new Ping();
                PingReply pingReply = ping.Send(IP);

                bool result;
                if (pingReply.Status == IPStatus.Success)
                {
                    result = true;
                }
                else
                {
                    result = false;
                }

                return result;
            }
            catch
            {
                return false;
            }
        }

        /// <summary>
        /// 异或校验字
        /// </summary>
        /// <param name="data"></param>
        /// <returns></returns>
        public static string XORCheck(string data)
        {
            byte value = 0;
            foreach (char item in data)
            {
                value ^= (byte)item;
            }

            return Convert.ToString(value, 16).ToUpper();
        }
    }
}
