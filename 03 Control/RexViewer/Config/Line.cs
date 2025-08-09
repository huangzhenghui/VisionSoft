using System;
using System.Xml.Serialization;
namespace RexView
{
    [Serializable]
    public class Line
    {
        #region 字段、属性

        /// <summary>
        /// 起点Row
        /// </summary>
        [XmlElement(ElementName = "RowBegin")]
        public double RowBegin { get; set; }

        /// <summary>
        /// 起点Column
        /// </summary>
        [XmlElement(ElementName = "ColumnBegin")]
        public double ColumnBegin { get; set; }

        /// <summary>
        /// 终点Row
        /// </summary>
        [XmlElement(ElementName = "RowEnd")]
        public double RowEnd { get; set; }

        /// <summary>
        /// 终点Column
        /// </summary>
        [XmlElement(ElementName = "ColumnEnd")]
        public double ColumnEnd { get; set; }

        /// <summary>
        /// 区域颜色
        /// </summary>
        [XmlElement(ElementName = "Color")]
        public string Color { get; set; } = "yellow";

        #endregion

        #region 初始化

        /// <summary>
        /// 直线
        /// </summary>
        /// <param name="rowBegin">起始点Row</param>
        /// <param name="columnBegin">起始点Column</param>
        /// <param name="rowEnd">终点Row</param>
        /// <param name="columnEnd">终点Column</param>
        public Line(double rowBegin, double columnBegin, double rowEnd, double columnEnd)
        {
            RowBegin = rowBegin;
            ColumnBegin = columnBegin;
            RowEnd = rowEnd;
            ColumnEnd = columnEnd;
        }

        #endregion
    }
}
