using System;
using HalconDotNet;
using System.Collections;

namespace RexView
{

    /// <summary>
    /// 将图形链接到HALCON对象
    /// </summary>
    public class HObjectEntry
    {
        /// <summary>
        /// 为HObj定义图形的哈希列表
        /// </summary>
        public Hashtable gContext;

        /// <summary>
        /// Halcon对象
        /// </summary>
        public HObject HObj;

        /// <summary>
        /// 初始化
        /// </summary>
        /// <param name="obj"></param>
        /// <param name="gc"></param>
        public HObjectEntry(HObject obj, Hashtable gc)
        {
            gContext = gc;
            HObj = obj;
        }

        /// <summary>
        /// 清除类成员变量
        /// </summary>
        public void Clear()
        {
            gContext.Clear();
            HObj.Dispose();
        }

    }
}
