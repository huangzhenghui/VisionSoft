using HalconDotNet;
namespace RexView
{
    /// <summary>
    /// 显示Xld和Region(带有颜色)
    /// </summary>
    class HObjectWithColor
    {
        #region 字段、属性

        /// <summary>
        /// 颜色
        /// </summary>
        public string Color { get; set; }

        /// <summary>
        /// HObject对象
        /// </summary>
        public HObject HObject { get; set; }

        #endregion

        #region 初始化

        /// <summary>
        /// 初始化
        /// </summary>
        /// <param name="_hbj">类型</param>
        /// <param name="_color">颜色</param>
        public HObjectWithColor(HObject _hbj, string _color)
        {
            HObject = _hbj;
            Color = _color;
        }

        #endregion
    }
}
