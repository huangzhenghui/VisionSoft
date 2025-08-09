using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Xml.Serialization;

namespace RexView
{
    [Serializable]
    public class Rectangle2
    {
        #region 字段、属性

        /// <summary>
        /// 中心点Row
        /// </summary>
        [XmlElement(ElementName = "Row")]
        public double Row { get; set; }

        /// <summary>
        /// 中心点Column
        /// </summary>
        [XmlElement(ElementName = "Column")]
        public double Column { get; set; }

        /// <summary>
        /// 区域角度Phi
        /// </summary>
        [XmlElement(ElementName = "Phi")]
        public double Phi { get; set; }

        /// <summary>
        /// 长半轴Length1
        /// </summary>
        [XmlElement(ElementName = "Lenth1")]
        public double Lenth1 { get; set; }

        /// <summary>
        /// 短半轴Length2
        /// </summary>
        [XmlElement(ElementName = "Lenth2")]
        public double Lenth2 { get; set; }

        /// <summary>
        /// 区域颜色
        /// </summary>
        [XmlElement(ElementName = "Color")]
        public string Color { get; set; } = "yellow";

        #endregion

        #region 初始化

        /// <summary>
        /// 旋转矩形2
        /// </summary>
        /// <param name="row">中心点Row</param>
        /// <param name="column">中心点Column</param>
        /// <param name="phi">区域角度Phi</param>
        /// <param name="lenth1">长半轴</param>
        /// <param name="lenth2">短半轴</param>
        public Rectangle2(double row, double column, double phi, double lenth1, double lenth2)
        {
            Row = row;
            Column = column;
            Phi = phi;
            Lenth1 = lenth1;
            Lenth2 = lenth2;
        }

        #endregion
    }
}
