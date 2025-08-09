using System;
using System.Collections.Generic;
using System.ComponentModel;
using HalconDotNet;

namespace RexView
{
    /// <summary>
    ///这个ROI类是一个基类
    /// </summary>    
    [Serializable]
    public class ROI
    {
        #region 字段、属性

        /// <summary>
        /// ROI颜色 
        /// </summary>
        [Description("ROI颜色")]
        public string Color = "yellow";

        /// <summary>
        /// 测量矩形颜色 
        /// </summary>
        [Description("ROI颜色")]
        public string meaRectColor = "cyan";

        /// <summary> 
        /// ROI类型
        /// </summary>
        [Description("ROI类型")]
        public ROIType Type;

        /// <summary>
        /// 中心点Row坐标
        /// </summary>
        [Description("中心点Row")]
        public double midR;

        /// <summary>
        /// 中心点Column坐标
        /// </summary>
        [Description("中心点Column")]
        public double midC;

        /// <summary>
        /// 操作句柄数目
        /// </summary>
        [Description("操作句柄数目")]
        protected int NumHandles;

        /// <summary>
        /// 激活句柄索引
        /// </summary>
        [Description("激活句柄索引")]
        protected int ActiveHandleId;

        /// <summary>
        /// ROI线条样式
        /// </summary>
        [Description("ROI线条样式")]
        public HTuple FlagLineStyle;

        /// <summary>
        /// 常数为正ROI标志
        /// </summary>
        [Description("正ROI标志")]
        public const int POSITIVE_FLAG = HWndCtrl.MODE_ROI_POS;

        /// <summary>
        /// 常数为负ROI标志
        /// </summary>
        [Description("负ROI标志")]
        public const int NEGATIVE_FLAG = HWndCtrl.MODE_ROI_NEG;

        /// <summary> 
        /// 标记定义ROI为“正”或“负”
        /// </summary>
        [Description("ROI方向")]
        protected int OperatorFlag;

        /// <summary> 
        /// "+"方式的直线 
        /// </summary>
        [Description(" + 方式的直线 ")]
        protected HTuple posOperation = new HTuple();

        /// <summary> 
        /// "-"方式的虚线
        /// </summary>
        [Description(" - 方式的直线")]
        protected HTuple negOperation = new HTuple(new int[] { 2, 2 });

        #endregion

        #region ROI操作相关

        /// <summary>
        /// 创建直线
        /// </summary>
        /// <param name="beginRow"></param>
        /// <param name="beginCol"></param>
        /// <param name="endRow"></param>
        /// <param name="endCol"></param>
        public virtual void CreateLine(double beginRow, double beginCol, double endRow, double endCol) { }

        /// <summary>
        /// 创建坐标线
        /// </summary>
        /// <param name="beginRow"></param>
        /// <param name="beginCol"></param>
        /// <param name="endRow"></param>
        /// <param name="endCol"></param>
        public virtual void CreateCoordLine(double beginRow, double beginCol, double endRow, double endCol) { }

        /// <summary>
        /// 创建圆
        /// </summary>
        /// <param name="row"></param>
        /// <param name="col"></param>
        /// <param name="radius"></param>
        public virtual void CreateCircle(double row, double col, double radius, string color) { }

        /// <summary>
        /// 创建圆弧
        /// </summary>
        /// <param name="row"></param>
        /// <param name="col"></param>
        /// <param name="radius"></param>
        public virtual void CreateCircleAre(double row, double col, double radius) { }

        /// <summary>
        /// 创建找圆模型
        /// </summary>
        /// <param name="row"></param>
        /// <param name="col"></param>
        /// <param name="radius"></param>
        /// <param name="hObj"></param>
        public virtual void CreateFindCircle(double row, double col, double radius, double startAngle, double endAngle, string pointOrder, int rectNum, double length1, double length2, string projectColor, string meaRectColor) { }

        /// <summary>
        /// 创建找线模型
        /// </summary>
        /// <param name="row"></param>
        /// <param name="col"></param>
        /// <param name="radius"></param>
        /// <param name="hObj"></param>
        public virtual void CreateFindLine(double rowBeign, double colBeign, double rowEnd, double colEnd, int rectNum, double length1, double length2, string projectColor, string meaRectColor) { }

        /// <summary>
        /// 创建矩形Rect1
        /// </summary>
        /// <param name="row1"></param>
        /// <param name="col1"></param>
        /// <param name="row2"></param>
        /// <param name="col2"></param>
        public virtual void CreateRectangle1(double row1, double col1, double row2, double col2, string color) { }

        /// <summary>
        /// 创建矩形Rect2
        /// </summary>
        /// <param name="row"></param>
        /// <param name="col"></param>
        /// <param name="phi"></param>
        /// <param name="length1"></param>
        /// <param name="length2"></param>
        public virtual void CreateRectangle2(double row, double col, double phi, double length1, double length2, string color) { }

        /// <summary>
        /// 创建点
        /// </summary>
        /// <param name="row"></param>
        /// <param name="col"></param>
        public virtual void CreatePoint(double row, double col) { }

        /// <summary>
        /// 在鼠标位置创建一个新的ROI区域
        /// </summary>
        public virtual void CreateROI(double midX, double midY) { }

        /// <summary>
        /// 将ROI绘制到Halcon的窗口中
        /// </summary>
        public virtual void Draw(HWindow window, HObject hObj) { }

        /// <summary>
        /// 计算鼠标与ROI操作句柄距离,返回激活的句柄ID
        /// </summary>
        /// <param name="x">鼠标X坐标，即Row方向</param>
        /// <param name="y">鼠标Y坐标，即Column方向</param>
        /// <returns>激活的句柄ID</returns>
        public virtual double DistToClosestHandle(double x, double y){return 0.0;}

        /// <summary>
        /// 显示激活的操作句柄
        /// </summary>
        /// <param name="window">Halcon窗口</param>
        public virtual void DisplayActive(HWindow window, HObject hObj) { }

        /// <summary>
        /// 根据选中的操作句柄执行相关操作
        /// </summary>
        /// <param name="newX">鼠标位置的X坐标，是横向，即Column</param>
        /// <param name="newY">鼠标位置的Y坐标，是纵向，即Row</param>
        public virtual void moveByHandle(double x, double y) { }

        /// <summary>
        /// 获取XLD轮廓
        /// </summary>
        /// <returns></returns>
        public virtual HXLDCont GetXLD() { return null; }

        /// <summary>
        /// 获取ROI区域
        /// </summary>
        public virtual HRegion GetRegion(){return null;}

        /// <summary>
        /// 从起点得到距离
        /// </summary>
        public virtual double GetDistanceFromStartPoint(double row, double col){return 0.0;}

        /// <summary>
        /// 获取ROI信息
        /// </summary>
        /// <returns></returns>
        public virtual HTuple GetModelData(){return null;}

        /// <summary>
        /// 获取ROI定义的句柄数目
        /// </summary>
        public int GetNumHandles(){return NumHandles;}

        /// <summary>
        /// 获取ROI的活动句柄,返回索引
        /// </summary>
        public int GetActHandleIdx(){return ActiveHandleId;}

        /// <summary>
        /// 获取ROI区域对象，对象线的样式：+|- 
        /// </summary>
        public int GetOperatorFlag(){return OperatorFlag;}

        /// <summary>
        /// 设置ROI区域对象，对象线的样式：+|- 
        /// </summary>
        public void SetOperatorFlag(int flag)
        {
            OperatorFlag = flag;
            switch (OperatorFlag)
            {
                case POSITIVE_FLAG:
                    FlagLineStyle = posOperation;
                    break;
                case NEGATIVE_FLAG:
                    FlagLineStyle = negOperation;
                    break;
                default:
                    FlagLineStyle = posOperation;
                    break;
            }
        }

        #endregion
    }
}
