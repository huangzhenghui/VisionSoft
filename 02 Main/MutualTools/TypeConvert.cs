using HalconDotNet;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Globalization;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace MutualTools
{
    public class TypeConvert
    {
        /// <summary>
        /// uint类型数据转换成IP地址
        /// </summary>
        /// <param name="ipCode"></param>
        /// <returns></returns>
        public static string UintToIP(UInt32 ipCode)
        {
            byte a = (byte)((ipCode & 0xFF000000) >> 0x18);//24
            byte b = (byte)((ipCode & 0x00FF0000) >> 0x10);//16
            byte c = (byte)((ipCode & 0x0000FF00) >> 0x8);//8
            byte d = (byte)(ipCode & 0x000000FF);
            string ipStr = String.Format(" {0}.{1}.{2}.{3} ", a, b, c, d);
            return ipStr;
        }

        /// <summary>
        /// IP地址转换成uint类型数据
        /// </summary>
        /// <param name="ipStr"></param>
        /// <returns></returns>
        public static UInt32 IPToUint(string ipStr)
        {
            string[] ip = ipStr.Split('.');
            uint ipCode = 0xFFFFFF00 | byte.Parse(ip[3]);
            ipCode = ipCode & 0xFFFF00FF | (uint.Parse(ip[2]) << 0x8);
            ipCode = ipCode & 0xFF00FFFF | (uint.Parse(ip[1]) << 0x10);
            ipCode = ipCode & 0x00FFFFFF | (uint.Parse(ip[0]) << 0x18);
            return ipCode;
        }

        /// <summary>
        /// 将字符串转换为IP
        /// </summary>
        /// <param name="str"></param>
        /// <returns></returns>
        private static IPAddress ConvertIPAddress(string str)
        {
            IPAddress tmpIp;
            if (IPAddress.TryParse(str, out tmpIp))
            {
                return IPAddress.Parse(str);
            }
            else
            {
                return IPAddress.Parse("0, 0, 0, 0");
            }
        }

        /// <summary>
        /// string类型转Htuple
        /// </summary>
        /// <param name="str"></param>
        /// <returns></returns>
        public static HTuple StringToHTuple(string str)
        {
            HTuple result = new HTuple();
            string[] strAssem = str.Split(',');
            for (int i = 0; i < strAssem.Length; i++)
            {
                if (!strAssem[i].Contains("\"") && RegExTools.RegExNum(strAssem[i]))
                {
                    result.Append(new HTuple(Convert.ToDouble(strAssem[i])));
                }
                else
                {
                    result.Append(new HTuple(strAssem[i].Replace("\"", "")));
                }
            }

            return result;
        }

        /// <summary>
        /// HTuple类型转string类型
        /// </summary>
        /// <param name="str"></param>
        /// <returns></returns>
        public static string HTupleToString(HTuple tuple)
        {
            if (tuple == null) return "";
            string result = "";
            for (int i = 0; i < tuple.Length; i++)
            {
                if (i == 0)
                {
                    result = tuple.ToSArr()[0];
                }
                else
                {
                    result = result + ", " + tuple.ToSArr()[i];
                }
            }
            return result;
        }

        /// <summary>
        /// 普通字符串转十六进制字符串
        /// </summary>
        /// <param name="mStr"></param>
        /// <returns></returns>
        public static string StrToHexStr(string mStr) 
        {
            string str = BitConverter.ToString(Encoding.Default.GetBytes(mStr)).Replace("-", " ");
            return str;
        }

        /// <summary>
        /// 十六进制字符串转普通字符串
        /// </summary>
        /// <param name="hexStr">十六进制字符串</param>
        /// <returns></returns>
        public static string HexStrToStr(string hexStr)
        {
            try
            {
                hexStr = hexStr.Replace(" ", "");
                if (hexStr.Length <= 0) return "";
                byte[] vBytes = new byte[hexStr.Length / 2];
                for (int i = 0; i < hexStr.Length; i += 2)
                    if (!byte.TryParse(hexStr.Substring(i, 2), NumberStyles.HexNumber, null, out vBytes[i / 2]))
                        vBytes[i / 2] = 0;
                return Encoding.Default.GetString(vBytes);
            }
            catch (Exception)
            {
                return "";
            }
        }

        /// <summary>
        /// 其他类型数组转换成List<string>
        /// </summary>
        /// <param name="shortAssem"></param>
        /// <returns></returns>
        public static List<string> AssemToStrList<T>(T[] assem)
        {
            List<string> strList = new List<string>();
            foreach (T item in assem)
            {
                strList.Add(item.ToString());
            }

            return strList;
        }

        public static T[] StrAssemToAssem<T>(string[] strAssem)
        {
            T[] assem = new T[strAssem.Length];
            for (int i = 0; i < strAssem.Length; i++)
            {
                var converter = TypeDescriptor.GetConverter(typeof(T));//TWeight是自定义的一个泛型类型
                assem[i] = (T)converter.ConvertTo(strAssem[i], typeof(T));
            }

            return assem;
        }
    }
}
