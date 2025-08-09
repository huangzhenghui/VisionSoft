using System;
using HalconDotNet;
using System.Collections;

namespace RexView
{

    /// <summary>
    /// ��ͼ�����ӵ�HALCON����
    /// </summary>
    public class HObjectEntry
    {
        /// <summary>
        /// ΪHObj����ͼ�εĹ�ϣ�б�
        /// </summary>
        public Hashtable gContext;

        /// <summary>
        /// Halcon����
        /// </summary>
        public HObject HObj;

        /// <summary>
        /// ��ʼ��
        /// </summary>
        /// <param name="obj"></param>
        /// <param name="gc"></param>
        public HObjectEntry(HObject obj, Hashtable gc)
        {
            gContext = gc;
            HObj = obj;
        }

        /// <summary>
        /// ������Ա����
        /// </summary>
        public void Clear()
        {
            gContext.Clear();
            HObj.Dispose();
        }

    }
}
