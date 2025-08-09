using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml.Serialization;

namespace RexView
{
    [Serializable]
    public class Rectangle1
    {
        #region 字段、属性

        /// <summary>
        /// 起点Row
        /// </summary>
        [XmlElement(ElementName = "Row1")]
        public double Row1 { get; set; }

        /// <summary>
        /// 起点Column
        /// </summary>
        [XmlElement(ElementName = "Column1")]
        public double Column1 { get; set; }

        /// <summary>
        /// 终点Row
        /// </summary>
        [XmlElement(ElementName = "Row2")]
        public double Row2 { get; set; }

        /// <summary>
        /// 终点Column
        /// </summary>
        [XmlElement(ElementName = "Column2")]
        public double Column2 { get; set; }

        /// <summary>
        /// 区域颜色
        /// </summary>
        [XmlElement(ElementName = "Color")]
        public string Color { get; set; } = "yellow";

        #endregion

        #region 初始化

        /// <summary>
        /// 矩形
        /// </summary>
        /// <param name="row1">起始点Row</param>
        /// <param name="column1">起始点Column</param>
        /// <param name="row2">终点Row</param>
        /// <param name="column2">终点Column</param>
        public Rectangle1(double row1, double column1, double row2, double column2)
        {
           Row1 = row1;
           Column1 = column1;
           Row2 = row2;
           Column2 = column2;
        }

        #endregion
    }
}
