using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml.Serialization;

namespace RexView
{
    [Serializable]
    public class Circle
    {
        #region 字段、属性

        /// <summary>
        /// 圆心Row
        /// </summary>
        [XmlElement(ElementName = "Row")]
        public double Row { get; set; }

        /// <summary>
        /// 圆心Column
        /// </summary>
        [XmlElement(ElementName = "Column")]
        public double Column { get; set; }

        /// <summary>
        /// 半径
        /// </summary>
        [XmlElement(ElementName = "Radius")]
        public double Radius { get; set; }

        /// <summary>
        /// 区域颜色
        /// </summary>
        [XmlElement(ElementName = "Color")]
        public string Color { get; set; } = "yellow";

        #endregion

        #region 初始化

        /// <summary>
        /// 圆
        /// </summary>
        /// <param name="row">圆心Row</param>
        /// <param name="column">圆心Column</param>
        /// <param name="radius">半径</param>
        public Circle(double row, double column, double radius)
        {
            Row = row;
            Column = column;
            Radius = radius;
        }

        #endregion
    }
}
