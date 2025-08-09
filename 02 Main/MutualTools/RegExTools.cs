using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace MutualTools
{
    public class RegExTools
    {
        /// <summary>
        /// 检验输入值是否是整数
        /// </summary>
        /// <param name="str"></param>
        /// <returns></returns>
        public static bool RegExInt(string str)
        {
            string pattern = @"^\d*$";
            bool isMatch = Regex.IsMatch(str, pattern);
            return isMatch;
        }

        /// <summary>
        /// 检验输入内容是否为IP地址
        /// </summary>
        /// <param name="str"></param>
        /// <returns></returns>
        public static bool RegExIP(string str)
        {
            if (string.IsNullOrEmpty(str) || str.Length < 7 || str.Length > 15) return false;
            const string pattern = @"^\d{1,3}[\.]\d{1,3}[\.]\d{1,3}[\.]\d{1,3}$";
            bool isMatch = Regex.IsMatch(str, pattern);
            return isMatch;
        }

        /// <summary>
        /// 检验输入值是否是整数或小数
        /// </summary>
        /// <param name="str"></param>
        /// <returns></returns>
        public static bool RegExInt_Deouble(string str)
        {
            string pattern = "^-?\\d+$|^(-?\\d+)(\\.\\d+)?$";
            bool isMatch = Regex.IsMatch(str, pattern);
            return isMatch;
        }

        /// <summary>
        /// 判断输入值是否是数字
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public static bool RegExNum(string value)
        {
            bool result = true;

            try
            {
                double num = double.Parse(value);
            }
            catch
            {
                result = false;
            }

            return result;
        }
    }
}
