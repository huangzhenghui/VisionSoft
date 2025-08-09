using System;
using System.Collections.Generic;
using HalconDotNet;
using System.Drawing;
using System.Runtime.Serialization;
using RexConst;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Runtime.InteropServices;
using RexHelps;
using System.ComponentModel;
using SharpDX;
using System.Xml.Linq;

namespace VisionCore
{
    #region 图像采集

    /// <summary>
    /// 图像采集
    /// </summary>
    [Serializable]
    public class CaptureImage_Info
    {
        /// <summary>
        /// 图像对象
        /// </summary>
        [Description("图像")]
        [NonSerialized]
        public RImage imageObj;
    }

    #endregion

    #region 图像增强

    /// <summary>
    /// 图像增强
    /// </summary>
    [Serializable]
    public class EmphasisImage_Info
    {
        /// <summary>
        /// 图像对象
        /// </summary>
        [NonSerialized]
        [Description("图像")]
        public RImage imageObj;
    }

    #endregion

    #region 灰度缩放

    /// <summary>
    /// 灰度缩放
    /// </summary>
    [Serializable]
    public class ScaleGray_Info
    {
        /// <summary>
        /// 图像对象
        /// </summary>
        [NonSerialized]
        [Description("图像")]
        public RImage imageObj = new RImage();
    }

    #endregion

    #region 掩膜抠图

    /// <summary>
    /// 灰度缩放
    /// </summary>
    [Serializable]
    public class ReduceImage_Info
    {
        /// <summary>
        /// 图像对象
        /// </summary>
        [Description("图像")]
        [NonSerialized]
        public RImage imageObj;
    }

    #endregion

    #region 图像裁剪

    /// <summary>
    /// 灰度缩放
    /// </summary>
    [Serializable]
    public class CropImage_Info
    {
        /// <summary>
        /// 图像对象
        /// </summary>
        [NonSerialized]
        [Description("图像")]
        public RImage imageObj = new RImage();
    }

    #endregion

    #region 创建区域

    [Serializable]
    public class CreateROI_Info
    {
        /// <summary>
        /// 图像对象
        /// </summary>
        [NonSerialized]
        [Description("区域")]
        public HObject regionObj;
    }

    #endregion

    #region 阈值分割

    /// <summary>
    /// 阈值分割
    /// </summary>
    [Serializable]
    public class ThresholdSeg_Info
    {
        /// <summary>
        /// 输出区域
        /// </summary>
        [NonSerialized]
        [Description("区域")]
        public HObject regionObj;
    }

    #endregion

    #region 区域连通

    /// <summary>
    /// 区域连通
    /// </summary>
    [Serializable]
    public class ConnectReg_Info
    {
        /// <summary>
        /// 输出区域
        /// </summary>
        [NonSerialized]
        [Description("区域")]
        public HObject regionObj;

        /// <summary>
        /// 输出区域数量
        /// </summary>
        [Description("区域数量")]
        public int regNum;
    }

    #endregion

    #region 区域筛选

    /// <summary>
    /// 区域筛选
    /// </summary>
    [Serializable]
    public class RegionSel_Info
    {
        /// <summary>
        /// 输出区域
        /// </summary>
        [NonSerialized]
        [Description("区域")]
        public HObject regionObj;

        /// <summary>
        /// 输出区域数量
        /// </summary>
        [Description("区域数量")]
        public int regNum;
    }

    #endregion

    #region 对象选择

    /// <summary>
    /// 对象选择
    /// </summary>
    [Serializable]
    public class HObjectSel_Info
    {
        /// <summary>
        /// 选中对象
        /// </summary>
        [NonSerialized]
        [Description("选中对象")]
        public HObject hObjSelected = new HObject();
    }

    #endregion

    #region 对象集合

    /// <summary>
    /// 对象集合
    /// </summary>
    [Serializable]
    public class HObjectSet_Info
    {
        /// <summary>
        /// 集合
        /// </summary>
        [NonSerialized]
        [Description("集合")]
        public HObject hObjSet = new HObject();
    }

    #endregion

    #region 元组工具

    /// <summary>
    /// 元组工具
    /// </summary>
    [Serializable]
    public class HTupleTool_Info
    {
        /// <summary>
        /// 结果
        /// </summary>
        [Description("结果")]
        [NonSerialized]
        public HTuple result;
    }

    #endregion

    #region 区域处理

    /// <summary>
    /// 区域筛选
    /// </summary>
    [Serializable]
    public class ProcessReg_Info
    {
        /// <summary>
        /// 输出区域
        /// </summary>
        [NonSerialized]
        [Description("区域")]
        public HObject regionObj;
    }

    #endregion

    #region 区域运算

    /// <summary>
    /// 区域筛选
    /// </summary>
    [Serializable]
    public class OperateReg_Info
    {
        /// <summary>
        /// 输出区域
        /// </summary>
        [NonSerialized]
        [Description("区域")]
        public HObject regionObj;
    }

    #endregion

    #region 区域填充

    /// <summary>
    /// 区域填充
    /// </summary>
    [Serializable]
    public class FillUpReg_Info
    {
        /// <summary>
        /// 输出区域
        /// </summary>
        [NonSerialized]
        [Description("区域")]
        public HObject regionObj;
    }

    #endregion

    #region 外接区域

    /// <summary>
    /// 外接区域
    /// </summary>
    [Serializable]
    public class ExternalReg_Info
    {
        /// <summary>
        /// 输出区域
        /// </summary>
        [NonSerialized]
        [Description("区域")]
        public HObject regionObj;

        /// <summary>
        /// 水平矩形起点Row
        /// </summary>
        [Description("水平矩形起点Row")]
        public double[] rect1BeginR;

        /// <summary>
        /// 水平矩形起点Col
        /// </summary>
        [Description("水平矩形起点Col")]
        public double[] rect1BeginC;

        /// <summary>
        /// 水平矩形终点Row
        /// </summary>
        [Description("水平矩形终点Row")]
        public double[] rect1EndR;

        /// <summary>
        /// 水平矩形终点Col
        /// </summary>
        [Description("水平矩形终点Col")]
        public double[] rect1EndC;

        /// <summary>
        /// 任意矩形中心点Row
        /// </summary>
        [Description("任意矩形中心点Row")]
        public double[] rect2CenterR;

        /// <summary>
        /// 任意矩形中心点Col
        /// </summary>
        [Description("任意矩形中心点Col")]
        public double[] rect2CenterC;

        /// <summary>
        /// 任意矩形角度
        /// </summary>
        [Description("任意矩形角度")]
        public double[] rect2Phi;

        /// <summary>
        /// 任意矩形长半轴
        /// </summary>
        [Description("任意矩形长半轴")]
        public double[] rect2Length1;

        /// <summary>
        /// 任意矩形短半轴
        /// </summary>
        [Description("任意矩形短半轴")]
        public double[] rect2Length2;

        /// <summary>
        /// 圆心Row坐标
        /// </summary>
        [Description("圆心Row")]
        public double[] circleCenterR;

        /// <summary>
        /// 圆心Col坐标
        /// </summary>
        [Description("圆心Col")]
        public double[] circleCenterC;

        /// <summary>
        /// 圆半径
        /// </summary>
        [Description("圆半径")]
        public double[] circleRadius;
    }

    #endregion

    #region 内接区域

    /// <summary>
    /// 内接区域
    /// </summary>
    [Serializable]
    public class InternalReg_Info
    {
        /// <summary>
        /// 输出区域
        /// </summary>
        [NonSerialized]
        [Description("区域")]
        public HObject regionObj;

        /// <summary>
        /// 水平矩形起点Row
        /// </summary>
        [Description("水平矩形起点Row")]
        public double[] rect1BeginR;

        /// <summary>
        /// 水平矩形起点Col
        /// </summary>
        [Description("水平矩形起点Col")]
        public double[] rect1BeginC;

        /// <summary>
        /// 水平矩形终点Row
        /// </summary>
        [Description("水平矩形终点Row")]
        public double[] rect1EndR;

        /// <summary>
        /// 水平矩形终点Col
        /// </summary>
        [Description("水平矩形终点Col")]
        public double[] rect1EndC;

        /// <summary>
        /// 圆心Row坐标
        /// </summary>
        [Description("圆心Row")]
        public double[] circleCenterR;

        /// <summary>
        /// 圆心Col坐标
        /// </summary>
        [Description("圆心Col")]
        public double[] circleCenterC;

        /// <summary>
        /// 圆半径
        /// </summary>
        [Description("圆半径")]
        public double[] circleRadius;
    }

    #endregion

    #region 区域信息

    /// <summary>
    /// 区域信息
    /// </summary>
    [Serializable]
    public class RegionInfo_Info
    {
        /// <summary>
        /// 查询结果
        /// </summary>
        [Description("结果")]
        public double[] result;

        /// <summary>
        /// 平均值
        /// </summary>
        [Description("平均值")]
        public double resultAvg;

        /// <summary>
        /// 最小值
        /// </summary>
        [Description("最小值")]
        public double resultMin;

        /// <summary>
        /// 最大值
        /// </summary>
        [Description("最大值")]
        public double resultMax;
    }

    #endregion

    #region 边缘提取

    /// <summary>
    /// 边缘提取
    /// </summary>
    [Serializable]
    public class EdgeDetection_Info
    {
        /// <summary>
        /// 图像对象
        /// </summary>
        [NonSerialized]
        [Description("图像")]
        public RImage imageObj = new RImage();
    }

    #endregion

    #region 轮廓提取

    /// <summary>
    /// 轮廓提取
    /// </summary>
    [Serializable]
    public class ContourExt_Info
    {
        /// <summary>
        /// 轮廓对象
        /// </summary>
        [Description("轮廓")]
        [NonSerialized]
        public HObject contourObj;

        /// <summary>
        /// 轮廓数量
        /// </summary>
        [Description("轮廓数量")]
        [NonSerialized]
        public HTuple contourNum;
    }

    #endregion

    #region 轮廓筛选

    /// <summary>
    /// 轮廓筛选
    /// </summary>
    [Serializable]
    public class ContourSel_Info
    {
        /// <summary>
        /// 轮廓对象
        /// </summary>
        [Description("轮廓")]
        [NonSerialized]
        public HObject contourObj;

        /// <summary>
        /// 轮廓数量
        /// </summary>
        [NonSerialized]
        public HTuple contourNum;
    }

    #endregion

    #region 找线工具

    /// <summary>
    /// 找线工具
    /// </summary>
    [Serializable]
    public class FindLine_Info
    {
        /// <summary>
        /// 拟合点位
        /// </summary>
        [Description("拟合点位")]
        [NonSerialized]
        public HObject fittedPointObj;

        /// <summary>
        /// 过滤点位
        /// </summary>
        [Description("过滤点位")]
        [NonSerialized]
        public HObject removedPointObj;

        /// <summary>
        /// 直线轮廓
        /// </summary>
        [Description("直线")]
        [NonSerialized]
        public HObject lineObj;

        /// <summary>
        /// 拟合点位Row坐标集合
        /// </summary>
        [Description("拟合点位Row")]
        [NonSerialized]
        public HTuple pointRows;

        /// <summary>
        /// 拟合点位Column坐标集合
        /// </summary>
        [Description("拟合点位Col")]
        [NonSerialized]
        public HTuple pointCols;

        /// <summary>
        /// 直线起点Row坐标
        /// </summary>
        [Description("直线起点Row")]
        [NonSerialized]
        public HTuple lineBeginRow;

        /// <summary>
        /// 直线起点Col坐标
        /// </summary>
        [Description("直线起点Col")]
        public HTuple lineBeginCol;

        /// <summary>
        /// 直线终点Row坐标
        /// </summary>
        [Description("直线终点Row")]
        [NonSerialized]
        public HTuple lineEndRow;

        /// <summary>
        /// 直线起点Col坐标
        /// </summary>
        [Description("直线终点Col")]
        [NonSerialized]
        public HTuple lineEndCol;
    }

    #endregion

    #region 找圆工具

    /// <summary>
    /// 找圆工具
    /// </summary>
    [Serializable]
    public class FindCircle_Info
    {
        /// <summary>
        /// 拟合点位
        /// </summary>
        [Description("拟合点位")]
        [NonSerialized]
        public HObject fittedPointObj;

        /// <summary>
        /// 过滤点位
        /// </summary>
        [Description("过滤点位")]
        [NonSerialized]
        public HObject removedPointObj;

        /// <summary>
        /// 圆/圆弧
        /// </summary>
        [Description("圆/圆弧")]
        [NonSerialized]
        public HObject circleObj;

        /// <summary>
        /// 拟合点位Row坐标集合
        /// </summary>
        [Description("拟合点位Row")]
        [NonSerialized]
        public HTuple pointRows;

        /// <summary>
        /// 拟合点位Column坐标集合
        /// </summary>
        [Description("拟合点位Col")]
        [NonSerialized]
        public HTuple pointCols;

        /// <summary>
        /// 圆中心点Row坐标
        /// </summary>
        [Description("圆中心Row")]
        [NonSerialized]
        public HTuple circleCenterRow;

        /// <summary>
        /// 圆中心点Column坐标
        /// </summary>
        [Description("圆中心Col")]
        [NonSerialized]
        public HTuple circleCenterCol;

        /// <summary>
        /// 圆半径
        /// </summary>
        [Description("圆半径")]
        [NonSerialized]
        public HTuple circleRadius;
    }

    #endregion

    #region 点点距离

    /// <summary>
    /// 点点距离
    /// </summary>
    [Serializable]
    public class DistancePP_Info
    {
        /// <summary>
        /// 距离
        /// </summary>
        [Description("距离")]
        [NonSerialized]
        public HTuple distAssem;

        /// <summary>
        /// 显示对象
        /// </summary>
        [Description("显示对象")]
        [NonSerialized]
        public HObject hObjAssem;
    }

    #endregion

    #region 点线距离

    /// <summary>
    /// 点线距离
    /// </summary>
    [Serializable]
    public class DistancePL_Info
    {
        /// <summary>
        /// 距离
        /// </summary>
        [Description("距离")]
        [NonSerialized]
        public HTuple distAssem;

        /// <summary>
        /// 显示对象
        /// </summary>
        [Description("显示对象")]
        [NonSerialized]
        public HObject hObjAssem;
    }

    #endregion

    #region 线线距离

    /// <summary>
    /// 点线距离
    /// </summary>
    [Serializable]
    public class DistanceLL_Info
    {
        /// <summary>
        /// 距离
        /// </summary>
        [Description("距离")]
        [NonSerialized]
        public HTuple distAssem;

        /// <summary>
        /// 显示对象
        /// </summary>
        [Description("显示对象")]
        [NonSerialized]
        public HObject hObjAssem;
    }

    #endregion

    #region 拟合圆弧

    /// <summary>
    /// 点线距离
    /// </summary>
    [Serializable]
    public class FitCircle_Info
    {
        /// <summary>
        /// 圆/圆弧
        /// </summary>
        [Description("圆/圆弧")]
        [NonSerialized]
        public HObject circleObj;

        /// <summary>
        /// 圆中心点Row坐标
        /// </summary>
        [Description("圆中心Row")]
        [NonSerialized]
        public HTuple circleCenterRow;

        /// <summary>
        /// 圆中心点Column坐标
        /// </summary>
        [Description("圆中心Col")]
        [NonSerialized]
        public HTuple circleCenterCol;

        /// <summary>
        /// 圆半径
        /// </summary>
        [Description("圆半径")]
        [NonSerialized]
        public HTuple circleRadius;
    }

    #endregion

    #region 线线交点

    /// <summary>
    /// 线线交点
    /// </summary>
    [Serializable]
    public class IntersectLL_Info
    {
        /// <summary>
        /// 交点对象
        /// </summary>
        [NonSerialized]
        [Description("交点")]
        public HObject pointObj;

        /// <summary>
        /// 交点Row坐标
        /// </summary>
        [Description("交点Row")]
        public double pointRow = 0;

        /// <summary>
        /// 交点Col坐标
        /// </summary>
        [Description("交点Col")]
        public double pointCol = 0;
    }

    #endregion

    #region 点线投影

    /// <summary>
    /// 线线交点
    /// </summary>
    [Serializable]
    public class ProjectionPL_Info
    {
        /// <summary>
        /// 投影对象
        /// </summary>
        [NonSerialized]
        [Description("投影")]
        public HObject pointObj;

        /// <summary>
        /// 投影Row坐标
        /// </summary>
        [Description("投影Row")]
        public double pointRow = 0;

        /// <summary>
        /// 投影Col坐标
        /// </summary>
        [Description("投影Col")]
        public double pointCol = 0;
    }

    #endregion

    #region 直线构建

    /// <summary>
    /// 直线构建
    /// </summary>
    [Serializable]
    public class CreateLine_Info
    {
        /// <summary>
        /// 直线对象
        /// </summary>
        [Description("直线")]
        public HObject lineObj;

        /// <summary>
        /// 直线起点Row
        /// </summary>
        [Description("起点Row")]
        public double lineBeginR = 100;

        /// <summary>
        /// 直线起点Col
        /// </summary>
        [Description("起点Col")]
        public double lineBeginC = 100;

        /// <summary>
        /// 直线终点Row
        /// </summary>
        [Description("终点Row")]
        public double lineEndR = 500;

        /// <summary>
        /// 直线终点Col
        /// </summary>
        [Description("终点Col")]
        public double lineEndC = 100;
    }

    #endregion

    #region 直线构建

    /// <summary>
    /// 点位构建
    /// </summary>
    [Serializable]
    public class CreatePoint_Info
    {
        /// <summary>
        /// 点位对象
        /// </summary>
        [Description("点位")]
        public HObject pointObj;

        /// <summary>
        /// 点位Row
        /// </summary>
        [Description("点位Row")]
        public double[] pointR;

        /// <summary>
        /// 点位Col
        /// </summary>
        [Description("点位Col")]
        public double[] pointC;
    }

    #endregion

    #region 创建模板

    /// <summary>
    /// 创建模板
    /// </summary>
    [Serializable]
    public class CreateModel_Info
    {
        /// <summary>
        /// 模板句柄
        /// </summary>
        [Description("模板句柄")]
        [NonSerialized]
        public HTuple modelHandle;

        /// <summary>
        /// 模板对象
        /// </summary>
        [Description("模板对象")]
        [NonSerialized]
        public HObject modelObj;

        /// <summary>
        /// 模板中心Row坐标
        /// </summary>
        [Description("模板中心Row")]
        [NonSerialized]
        public HTuple modelMidR;

        /// <summary>
        /// 模板中心Column坐标
        /// </summary>
        [Description("模板中心Col")]
        [NonSerialized]
        public HTuple modelMidC;

        /// <summary>
        /// 模板角度
        /// </summary>
        [Description("模板角度")]
        [NonSerialized]
        public HTuple modelAngle;
    }

    #endregion

    #region 查找模板

    /// <summary>
    /// 查找模板
    /// </summary>
    [Serializable]
    public class FindModel_Info
    {

        /// <summary>
        /// 模板轮廓
        /// </summary>
        [Description("匹配结果对象")]
        [NonSerialized]
        public HObject resultObj;

        /// <summary>
        /// 匹配结果Row坐标
        /// </summary>
        [Description("匹配结果中心Row")]
        [NonSerialized]
        public HTuple resultMidR;

        /// <summary>
        /// 匹配结果Column坐标
        /// </summary>
        [Description("匹配结果中心Col")]
        [NonSerialized]
        public HTuple resultMidC;

        /// <summary>
        /// 匹配结果角度
        /// </summary>
        [Description("匹配结果角度")]
        [NonSerialized]
        public HTuple resultAngle;

        /// <summary>
        /// 匹配结果分数
        /// </summary>
        [Description("匹配结果分数")]
        [NonSerialized]
        public HTuple resultScore;

        /// <summary>
        /// 匹配结果数量
        /// </summary>
        [Description("匹配结果数量")]
        [NonSerialized]
        public HTuple resultNum;
    }

    #endregion

    #region 仿射变换

    /// <summary>
    /// 仿射变换
    /// </summary>
    [Serializable]
    public class AffineTrans_Info
    {
        /// <summary>
        /// 仿射结果图像
        /// </summary>
        [Description("仿射结果图像")]
        [NonSerialized]
        public RImage resultImg;

        /// <summary>
        /// 仿射结果对象
        /// </summary>
        [Description("仿射结果对象")]
        [NonSerialized]
        public HObject resultObj;

        /// <summary>
        /// 仿射矩阵
        /// </summary>
        [Description("仿射矩阵")]
        [NonSerialized]
        public HTuple affineMat;

        /// <summary>
        /// 仿射结果点位Row
        /// </summary>
        [Description("仿射结果点位Row")]
        [NonSerialized]
        public HTuple resultPointRow;

        /// <summary>
        /// 仿射结果点位Col
        /// </summary>
        [Description("仿射结果点位Col")]
        [NonSerialized]
        public HTuple resultPointCol;
    }

    #endregion

    #region 九点标定

    /// <summary>
    /// 九点标定
    /// </summary>
    [Serializable]
    public class NinePointsCalib_Info
    {
        /// <summary>
        /// 九点标定矩阵
        /// </summary>
        [NonSerialized]
        [Description("标定矩阵")]
        public HTuple calibMatrix = new HTuple();
    }

    #endregion

    #region 模块单元输出数据结构体

    /// <summary>
    /// 模块单元输出数据结构体
    /// </summary>
    [Serializable]
    public struct DataCell
    {
        /// <summary>
        /// 模块名称
        /// </summary>
        public string mModName { set; get; }

        /// <summary>
        /// 单元编号
        /// </summary>
        public int mModIndex { set; get; }

        /// <summary>
        /// 变量分类-单量、数组
        /// </summary>
        public DataType mDataType { set; get; }

        /// <summary>
        /// 变量类型-图像，矩形，圆，矩阵等
        /// </summary>
        public DataMode mDataMode { set; get; }

        /// <summary>
        /// 变量名称
        /// </summary>
        public string mDataName { set; get; }

        /// <summary>
        /// 变量注释
        /// </summary>
        public string mDataTip { set; get; }

        /// <summary>
        /// 变量的值-输出对象
        /// </summary>
        public object mDataValue { set; get; }

        /// <summary>
        /// 变量初值
        /// </summary>
        public string mDataInit;

        /// <summary>
        /// 变量个数
        /// </summary>
        public int mDataNum;

        /// <summary>
        /// 变量属性
        /// </summary>
        public DataAtrr mDataAtrr;

        /// <summary>
        /// 模块初始化
        /// </summary>
        /// <param name="_ModName">模块名称</param>
        /// <param name="_Index">单元编号</param>
        /// <param name="_Type">数据分类，单量or数组</param>
        /// <param name="_Mode">数据类型</param>
        /// <param name="_Name">名称</param>
        /// <param name="_Tip">注释</param>
        /// <param name="_InitValue">初始值</param>
        /// <param name="_Num">数量</param>
        /// <param name="_Value">值</param>
        /// <param name="_Atrr">变量归属</param>
        public DataCell(string _ModName, int _Index, DataType _Type, DataMode _Mode, string _Name, string _Tip, string _InitValue, int _Num, object _Value, DataAtrr _Atrr)
        {
            mModName = _ModName;
            mModIndex = _Index;
            mDataType = _Type;
            mDataMode = _Mode;
            mDataName = _Name;
            mDataTip = _Tip;
            mDataInit = _InitValue;
            mDataNum = _Num;
            mDataValue = _Value;
            mDataAtrr = _Atrr;
        }
    }

    #endregion

    #region 控件全局变量

    /// <summary>
    /// 控件全局变量
    /// </summary>
    [Serializable]
    public struct CtrlVar
    {
        /// <summary>
        /// 变量类型
        /// </summary>
        public string CtrlType { set; get; }

        /// <summary>
        /// 变量名称
        /// </summary>
        public string CtrlName { set; get; }

        /// <summary>
        /// 变量的值
        /// </summary>
        public string CtrlValue { set; get; }

        /// <summary>
        /// 变量的值链接
        /// </summary>
        public string CtrlValueInit { set; get; }

        /// <summary>
        /// 变量注释
        /// </summary>
        public string CtrlTip { set; get; }

        /// <summary>
        /// 控件全局变量初始化
        /// </summary>
        /// <param name="ctrlType"></param>
        /// <param name="ctrlName"></param>
        /// <param name="ctrlValue"></param>
        /// <param name="ctrlTip"></param>
        public CtrlVar(string ctrlType, string ctrlName, string ctrlValue, string ctrlValueInit, string ctrlTip)
        {
            CtrlType = ctrlType;
            CtrlName = ctrlName;
            CtrlValue = ctrlValue;
            CtrlValueInit = ctrlValueInit;
            CtrlTip = ctrlTip;
        }
    }

    #endregion

    #region 变量设置

    /// <summary>
    /// 变量设置
    /// </summary>
    [Serializable]
    public class Char_Info
    {
        /// <summary>
        /// 名称
        /// </summary>
        public string Name { set; get; }

        /// <summary>
        /// 链接1
        /// </summary>
        public string Link1 { set; get; }

        /// <summary>
        /// 运算符号
        /// </summary>
        public string CharType { set; get; }

        /// <summary>
        /// 链接2
        /// </summary>
        public string Link2 { set; get; }

        /// <summary>
        /// 结果
        /// </summary>
        public string Result { set; get; }

        /// <summary>
        /// 变量设置信息初始化
        /// </summary>
        public Char_Info() { }

        /// <summary>
        /// 变量设置信息初始化
        /// </summary>
        /// <param name="_Index"></param>
        /// <param name="_Name"></param>
        /// <param name="_Link1"></param>
        /// <param name="_CharType"></param>
        /// <param name="_Link2"></param>
        /// <param name="_Result"></param>
        /// <param name="_Remark"></param>
        public Char_Info(string _Name, string _Link1, string _CharType, string _Link2,string _Result)
        {
            Name = _Name;
            Link1 = _Link1;
            CharType = _CharType;
            Link2 =_Link2;
            Result = _Result;
        }
    }

    #endregion

    #region 表头设置

    /// <summary>
    /// 表头设置
    /// </summary>
    [Serializable]
    public class SetHeader_Info
    {
        /// <summary>
        /// 标题1
        /// </summary>
        public string Title1 { set; get; }

        /// <summary>
        /// 标题2
        /// </summary>
        public string Title2 { set; get; }

        /// <summary>
        /// 标题3
        /// </summary>
        public string Title3 { set; get; }

        /// <summary>
        /// 标题4
        /// </summary>
        public string Title4 { set; get; }

        /// <summary>
        /// 标题5
        /// </summary>
        public string Title5 { set; get; }

        /// <summary>
        /// 标题6
        /// </summary>
        public string Title6 { set; get; }

        /// <summary>
        /// 标题7
        /// </summary>
        public string Title7 { set; get; }

        /// <summary>
        /// 标题8
        /// </summary>
        public string Title8 { set; get; }

        /// <summary>
        /// 标题9
        /// </summary>
        public string Title9 { set; get; }

        /// <summary>
        /// 标题10
        /// </summary>
        public string Title10 { set; get; }

        /// <summary>
        /// 标题11
        /// </summary>
        public string Title11 { set; get; }

        /// <summary>
        /// 标题12
        /// </summary>
        public string Title12 { set; get; }

        /// <summary>
        /// 标题13
        /// </summary>
        public string Title13 { set; get; }

        /// <summary>
        /// 标题14
        /// </summary>
        public string Title14 { set; get; }

        /// <summary>
        /// 标题15
        /// </summary>
        public string Title15 { set; get; }

        /// <summary>
        /// 标题16
        /// </summary>
        public string Title16 { set; get; }

        /// <summary>
        /// 标题17
        /// </summary>
        public string Title17 { set; get; }

        /// <summary>
        /// 标题18
        /// </summary>
        public string Title18 { set; get; }

        /// <summary>
        /// 标题19
        /// </summary>
        public string Title19 { set; get; }

        /// <summary>
        /// 标题20
        /// </summary>
        public string Title20 { set; get; }

        /// <summary>
        /// 标题21
        /// </summary>
        public string Title21 { set; get; }

        /// <summary>
        /// 标题22
        /// </summary>
        public string Title22 { set; get; }

        /// <summary>
        /// 标题23
        /// </summary>
        public string Title23 { set; get; }

        /// <summary>
        /// 标题24
        /// </summary>
        public string Title24 { set; get; }

        /// <summary>
        /// 标题25
        /// </summary>
        public string Title25 { set; get; }

        /// <summary>
        /// 标题26
        /// </summary>
        public string Title26 { set; get; }

        /// <summary>
        /// 标题27
        /// </summary>
        public string Title27 { set; get; }

        /// <summary>
        /// 标题28
        /// </summary>
        public string Title28 { set; get; }

        /// <summary>
        /// 标题29
        /// </summary>
        public string Title29 { set; get; }

        /// <summary>
        /// 标题30
        /// </summary>
        public string Title30 { set; get; }

        /// <summary>
        /// 标题31
        /// </summary>
        public string Title31 { set; get; }

        /// <summary>
        /// 标题32
        /// </summary>
        public string Title32 { set; get; }

        /// <summary>
        /// 标题33
        /// </summary>
        public string Title33 { set; get; }

        /// <summary>
        /// 标题34
        /// </summary>
        public string Title34 { set; get; }

        /// <summary>
        /// 标题35
        /// </summary>
        public string Title35 { set; get; }

        /// <summary>
        /// 标题36
        /// </summary>
        public string Title36 { set; get; }

        /// <summary>
        /// 标题37
        /// </summary>
        public string Title37 { set; get; }

        /// <summary>
        /// 标题38
        /// </summary>
        public string Title38 { set; get; }

        /// <summary>
        /// 标题39
        /// </summary>
        public string Title39 { set; get; }

        /// <summary>
        /// 标题40
        /// </summary>
        public string Title40 { set; get; }

        /// <summary>
        /// 标题41
        /// </summary>
        public string Title41 { set; get; }

        /// <summary>
        /// 标题42
        /// </summary>
        public string Title42 { set; get; }

        /// <summary>
        /// 标题43
        /// </summary>
        public string Title43 { set; get; }

        /// <summary>
        /// 标题44
        /// </summary>
        public string Title44 { set; get; }

        /// <summary>
        /// 标题45
        /// </summary>
        public string Title45 { set; get; }

        /// <summary>
        /// 标题46
        /// </summary>
        public string Title46 { set; get; }

        /// <summary>
        /// 标题47
        /// </summary>
        public string Title47 { set; get; }

        /// <summary>
        /// 标题48
        /// </summary>
        public string Title48 { set; get; }

        /// <summary>
        /// 标题49
        /// </summary>
        public string Title49 { set; get; }

        /// <summary>
        /// 标题50
        /// </summary>
        public string Title50 { set; get; }

        /// <summary>
        /// 标题51
        /// </summary>
        public string Title51 { set; get; }

        /// <summary>
        /// 标题52
        /// </summary>
        public string Title52 { set; get; }

        /// <summary>
        /// 标题53
        /// </summary>
        public string Title53 { set; get; }

        /// <summary>
        /// 标题54
        /// </summary>
        public string Title54 { set; get; }

        /// <summary>
        /// 标题55
        /// </summary>
        public string Title55 { set; get; }

        /// <summary>
        /// 标题56
        /// </summary>
        public string Title56 { set; get; }

        /// <summary>
        /// 标题57
        /// </summary>
        public string Title57 { set; get; }

        /// <summary>
        /// 标题58
        /// </summary>
        public string Title58 { set; get; }

        /// <summary>
        /// 标题59
        /// </summary>
        public string Title59 { set; get; }

        /// <summary>
        /// 标题60
        /// </summary>
        public string Title60 { set; get; }

        /// <summary>
        /// 标题61
        /// </summary>
        public string Title61 { set; get; }

        /// <summary>
        /// 标题62
        /// </summary>
        public string Title62 { set; get; }

        /// <summary>
        /// 标题63
        /// </summary>
        public string Title63 { set; get; }

        /// <summary>
        /// 标题64
        /// </summary>
        public string Title64 { set; get; }

        /// <summary>
        /// 标题65
        /// </summary>
        public string Title65 { set; get; }

        /// <summary>
        /// 标题66
        /// </summary>
        public string Title66 { set; get; }

        /// <summary>
        /// 标题67
        /// </summary>
        public string Title67 { set; get; }

        /// <summary>
        /// 标题68
        /// </summary>
        public string Title68 { set; get; }

        /// <summary>
        /// 标题69
        /// </summary>
        public string Title69 { set; get; }

        /// <summary>
        /// 标题70
        /// </summary>
        public string Title70 { set; get; }

        /// <summary>
        /// 标题71
        /// </summary>
        public string Title71 { set; get; }

        /// <summary>
        /// 标题72
        /// </summary>
        public string Title72 { set; get; }

        /// <summary>
        /// 标题73
        /// </summary>
        public string Title73 { set; get; }

        /// <summary>
        /// 标题74
        /// </summary>
        public string Title74 { set; get; }

        /// <summary>
        /// 标题75
        /// </summary>
        public string Title75 { set; get; }

        /// <summary>
        /// 标题76
        /// </summary>
        public string Title76 { set; get; }

        /// <summary>
        /// 标题77
        /// </summary>
        public string Title77 { set; get; }

        /// <summary>
        /// 标题78
        /// </summary>
        public string Title78 { set; get; }

        /// <summary>
        /// 标题79
        /// </summary>
        public string Title79 { set; get; }

        /// <summary>
        /// 标题80
        /// </summary>
        public string Title80 { set; get; }

        /// <summary>
        /// 标题81
        /// </summary>
        public string Title81 { set; get; }

        /// <summary>
        /// 标题82
        /// </summary>
        public string Title82 { set; get; }

        /// <summary>
        /// 标题83
        /// </summary>
        public string Title83 { set; get; }

        /// <summary>
        /// 标题84
        /// </summary>
        public string Title84 { set; get; }

        /// <summary>
        /// 标题85
        /// </summary>
        public string Title85 { set; get; }

        /// <summary>
        /// 标题86
        /// </summary>
        public string Title86 { set; get; }

        /// <summary>
        /// 标题87
        /// </summary>
        public string Title87 { set; get; }

        /// <summary>
        /// 标题88
        /// </summary>
        public string Title88 { set; get; }

        /// <summary>
        /// 标题89
        /// </summary>
        public string Title89 { set; get; }

        /// <summary>
        /// 标题90
        /// </summary>
        public string Title90 { set; get; }

        /// <summary>
        /// 标题91
        /// </summary>
        public string Title91 { set; get; }

        /// <summary>
        /// 标题92
        /// </summary>
        public string Title92 { set; get; }

        /// <summary>
        /// 标题93
        /// </summary>
        public string Title93 { set; get; }

        /// <summary>
        /// 标题94
        /// </summary>
        public string Title94 { set; get; }

        /// <summary>
        /// 标题95
        /// </summary>
        public string Title95 { set; get; }

        /// <summary>
        /// 标题96
        /// </summary>
        public string Title96 { set; get; }

        /// <summary>
        /// 标题97
        /// </summary>
        public string Title97 { set; get; }

        /// <summary>
        /// 标题98
        /// </summary>
        public string Title98 { set; get; }

        /// <summary>
        /// 标题99
        /// </summary>
        public string Title99 { set; get; }

        /// <summary>
        /// 标题100
        /// </summary>
        public string Title100 { set; get; }
    }

    #endregion

    #region 数据显示

    /// <summary>
    /// 表头设置
    /// </summary>
    [Serializable]
    public class ShowData_Info
    {
        /// <summary>
        /// 数据1
        /// </summary>
        public string Data1 { set; get; }

        /// <summary>
        /// 数据2
        /// </summary>
        public string Data2 { set; get; }

        /// <summary>
        /// 数据3
        /// </summary>
        public string Data3 { set; get; }

        /// <summary>
        /// 数据4
        /// </summary>
        public string Data4 { set; get; }

        /// <summary>
        /// 数据5
        /// </summary>
        public string Data5 { set; get; }

        /// <summary>
        /// 数据6
        /// </summary>
        public string Data6 { set; get; }

        /// <summary>
        /// 数据7
        /// </summary>
        public string Data7 { set; get; }

        /// <summary>
        /// 数据8
        /// </summary>
        public string Data8 { set; get; }

        /// <summary>
        /// 数据9
        /// </summary>
        public string Data9 { set; get; }

        /// <summary>
        /// 数据10
        /// </summary>
        public string Data10 { set; get; }

        /// <summary>
        /// 数据11
        /// </summary>
        public string Data11 { set; get; }

        /// <summary>
        /// 数据12
        /// </summary>
        public string Data12 { set; get; }

        /// <summary>
        /// 数据13
        /// </summary>
        public string Data13 { set; get; }

        /// <summary>
        /// 数据14
        /// </summary>
        public string Data14 { set; get; }

        /// <summary>
        /// 数据15
        /// </summary>
        public string Data15 { set; get; }

        /// <summary>
        /// 数据16
        /// </summary>
        public string Data16 { set; get; }

        /// <summary>
        /// 数据17
        /// </summary>
        public string Data17 { set; get; }

        /// <summary>
        /// 数据18
        /// </summary>
        public string Data18 { set; get; }

        /// <summary>
        /// 数据19
        /// </summary>
        public string Data19 { set; get; }

        /// <summary>
        /// 数据20
        /// </summary>
        public string Data20 { set; get; }

        /// <summary>
        /// 数据21
        /// </summary>
        public string Data21 { set; get; }

        /// <summary>
        /// 数据22
        /// </summary>
        public string Data22 { set; get; }

        /// <summary>
        /// 数据23
        /// </summary>
        public string Data23 { set; get; }

        /// <summary>
        /// 数据24
        /// </summary>
        public string Data24 { set; get; }

        /// <summary>
        /// 数据25
        /// </summary>
        public string Data25 { set; get; }

        /// <summary>
        /// 数据26
        /// </summary>
        public string Data26 { set; get; }

        /// <summary>
        /// 数据27
        /// </summary>
        public string Data27 { set; get; }

        /// <summary>
        /// 数据28
        /// </summary>
        public string Data28 { set; get; }

        /// <summary>
        /// 数据29
        /// </summary>
        public string Data29 { set; get; }

        /// <summary>
        /// 数据30
        /// </summary>
        public string Data30 { set; get; }

        /// <summary>
        /// 数据31
        /// </summary>
        public string Data31 { set; get; }

        /// <summary>
        /// 数据32
        /// </summary>
        public string Data32 { set; get; }

        /// <summary>
        /// 数据33
        /// </summary>
        public string Data33 { set; get; }

        /// <summary>
        /// 数据34
        /// </summary>
        public string Data34 { set; get; }

        /// <summary>
        /// 数据35
        /// </summary>
        public string Data35 { set; get; }

        /// <summary>
        /// 数据36
        /// </summary>
        public string Data36 { set; get; }

        /// <summary>
        /// 数据37
        /// </summary>
        public string Data37 { set; get; }

        /// <summary>
        /// 数据38
        /// </summary>
        public string Data38 { set; get; }

        /// <summary>
        /// 数据39
        /// </summary>
        public string Data39 { set; get; }

        /// <summary>
        /// 数据40
        /// </summary>
        public string Data40 { set; get; }

        /// <summary>
        /// 数据41
        /// </summary>
        public string Data41 { set; get; }

        /// <summary>
        /// 数据42
        /// </summary>
        public string Data42 { set; get; }

        /// <summary>
        /// 数据43
        /// </summary>
        public string Data43 { set; get; }

        /// <summary>
        /// 数据44
        /// </summary>
        public string Data44 { set; get; }

        /// <summary>
        /// 数据45
        /// </summary>
        public string Data45 { set; get; }

        /// <summary>
        /// 数据46
        /// </summary>
        public string Data46 { set; get; }

        /// <summary>
        /// 数据47
        /// </summary>
        public string Data47 { set; get; }

        /// <summary>
        /// 数据48
        /// </summary>
        public string Data48 { set; get; }

        /// <summary>
        /// 数据49
        /// </summary>
        public string Data49 { set; get; }

        /// <summary>
        /// 数据50
        /// </summary>
        public string Data50 { set; get; }

        /// <summary>
        /// 数据51
        /// </summary>
        public string Data51 { set; get; }

        /// <summary>
        /// 数据52
        /// </summary>
        public string Data52 { set; get; }

        /// <summary>
        /// 数据53
        /// </summary>
        public string Data53 { set; get; }

        /// <summary>
        /// 数据54
        /// </summary>
        public string Data54 { set; get; }

        /// <summary>
        /// 数据55
        /// </summary>
        public string Data55 { set; get; }

        /// <summary>
        /// 数据56
        /// </summary>
        public string Data56 { set; get; }

        /// <summary>
        /// 数据57
        /// </summary>
        public string Data57 { set; get; }

        /// <summary>
        /// 数据58
        /// </summary>
        public string Data58 { set; get; }

        /// <summary>
        /// 数据59
        /// </summary>
        public string Data59 { set; get; }

        /// <summary>
        /// 数据60
        /// </summary>
        public string Data60 { set; get; }

        /// <summary>
        /// 数据61
        /// </summary>
        public string Data61 { set; get; }

        /// <summary>
        /// 数据62
        /// </summary>
        public string Data62 { set; get; }

        /// <summary>
        /// 数据63
        /// </summary>
        public string Data63 { set; get; }

        /// <summary>
        /// 数据64
        /// </summary>
        public string Data64 { set; get; }

        /// <summary>
        /// 数据65
        /// </summary>
        public string Data65 { set; get; }

        /// <summary>
        /// 数据66
        /// </summary>
        public string Data66 { set; get; }

        /// <summary>
        /// 数据67
        /// </summary>
        public string Data67 { set; get; }

        /// <summary>
        /// 数据68
        /// </summary>
        public string Data68 { set; get; }

        /// <summary>
        /// 数据69
        /// </summary>
        public string Data69 { set; get; }

        /// <summary>
        /// 数据70
        /// </summary>
        public string Data70 { set; get; }

        /// <summary>
        /// 数据71
        /// </summary>
        public string Data71 { set; get; }

        /// <summary>
        /// 数据72
        /// </summary>
        public string Data72 { set; get; }

        /// <summary>
        /// 数据73
        /// </summary>
        public string Data73 { set; get; }

        /// <summary>
        /// 数据74
        /// </summary>
        public string Data74 { set; get; }

        /// <summary>
        /// 数据75
        /// </summary>
        public string Data75 { set; get; }

        /// <summary>
        /// 数据76
        /// </summary>
        public string Data76 { set; get; }

        /// <summary>
        /// 数据77
        /// </summary>
        public string Data77 { set; get; }

        /// <summary>
        /// 数据78
        /// </summary>
        public string Data78 { set; get; }

        /// <summary>
        /// 数据79
        /// </summary>
        public string Data79 { set; get; }

        /// <summary>
        /// 数据80
        /// </summary>
        public string Data80 { set; get; }

        /// <summary>
        /// 数据81
        /// </summary>
        public string Data81 { set; get; }

        /// <summary>
        /// 数据82
        /// </summary>
        public string Data82 { set; get; }

        /// <summary>
        /// 数据83
        /// </summary>
        public string Data83 { set; get; }

        /// <summary>
        /// 数据84
        /// </summary>
        public string Data84 { set; get; }

        /// <summary>
        /// 数据85
        /// </summary>
        public string Data85 { set; get; }

        /// <summary>
        /// 数据86
        /// </summary>
        public string Data86 { set; get; }

        /// <summary>
        /// 数据87
        /// </summary>
        public string Data87 { set; get; }

        /// <summary>
        /// 数据88
        /// </summary>
        public string Data88 { set; get; }

        /// <summary>
        /// 数据89
        /// </summary>
        public string Data89 { set; get; }

        /// <summary>
        /// 数据90
        /// </summary>
        public string Data90 { set; get; }

        /// <summary>
        /// 数据91
        /// </summary>
        public string Data91 { set; get; }

        /// <summary>
        /// 数据92
        /// </summary>
        public string Data92 { set; get; }

        /// <summary>
        /// 数据93
        /// </summary>
        public string Data93 { set; get; }

        /// <summary>
        /// 数据94
        /// </summary>
        public string Data94 { set; get; }

        /// <summary>
        /// 数据95
        /// </summary>
        public string Data95 { set; get; }

        /// <summary>
        /// 数据96
        /// </summary>
        public string Data96 { set; get; }

        /// <summary>
        /// 数据97
        /// </summary>
        public string Data97 { set; get; }

        /// <summary>
        /// 数据98
        /// </summary>
        public string Data98 { set; get; }

        /// <summary>
        /// 数据99
        /// </summary>
        public string Data99 { set; get; }

        /// <summary>
        /// 数据100
        /// </summary>
        public string Data100 { set; get; }
    }

    #endregion

    #region 条件判断

    /// <summary>
    /// 条件判断
    /// </summary>
    [Serializable]
    public class Judge_Info
    {
        /// <summary>
        /// 判断结果
        /// </summary>
        [Description("判断结果")]
        public bool result;
    }

    #endregion

    #region OCR识别

    /// <summary>
    /// OCR识别
    /// </summary>
    [Serializable]
    public class OCR_Info
    {
        /// <summary>
        /// 识别结果
        /// </summary>
        [Description("识别结果")]
        public HTuple OCRData = new HTuple();

        /// <summary>
        /// 置信度
        /// </summary>
        [Description("置信度")]
        public HTuple confData = new HTuple();
    }

    #endregion

    #region 读一维码

    /// <summary>
    /// 读一维码
    /// </summary>
    [Serializable]
    public class ReadBarcode_Info
    {
        /// <summary>
        /// 条码结果
        /// </summary>
        [Description("条码结果")]
        public HTuple barcodeData = new HTuple();

        /// <summary>
        /// 条码区域
        /// </summary>
        [NonSerialized]
        [Description("条码区域")]
        public HObject barcodeReg = new HObject();
    }

    #endregion

    #region 读二维码

    /// <summary>
    /// 读二维码
    /// </summary>
    [Serializable]
    public class ReadQRCode_Info
    {
        /// <summary>
        /// 条码结果
        [Description("条码结果")]
        public HTuple qrCodeData = new HTuple();

        /// <summary>
        /// 条码区域
        /// </summary>
        [NonSerialized]
        [Description("条码区域")]
        public HObject qrCodeReg = new HObject();
    }

    #endregion

    #region 形状转换

    /// <summary>
    /// 形状转换
    /// </summary>
    [Serializable]
    public class ShapeTrans_Info
    {
        /// <summary>
        /// 转换结果
        /// </summary>
        [NonSerialized]
        [Description("转换结果")]
        public HObject resultReg = new HObject();
    }

    #endregion

    #region 等分矩形

    /// <summary>
    /// 等分矩形
    /// </summary>
    [Serializable]
    public class PartRectangle_Info
    {
        /// <summary>
        /// 转换结果
        /// </summary>
        [Description("执行结果")]
        public HObject resultReg = new HObject();
    }

    #endregion

    #region 区域排序

    /// <summary>
    /// 区域排序
    /// </summary>
    [Serializable]
    public class SortReg_Info
    {
        /// <summary>
        /// 排序结果
        /// </summary>
        [Description("排序结果")]
        public HObject resultReg = new HObject();
    }

    #endregion

    #region 灰度信息

    /// <summary>
    /// 区域信息
    /// </summary>
    [Serializable]
    public class GrayInfo_Info
    {
        /// <summary>
        /// 灰度均值
        /// </summary>
        [Description("灰度均值")]
        public HTuple mean = new HTuple();

        /// <summary>
        /// 灰度方差
        /// </summary>
        [Description("灰度方差")]
        public HTuple deviation = new HTuple();
    }

    #endregion

    #region 视觉脚本

    /// <summary>
    /// 区域信息
    /// </summary>
    [Serializable]
    public class HalconScript_Info
    {
        /// <summary>
        /// 输出元组
        /// </summary>
        [Description("输出元组")]
        public HTuple outputHTuple;

        /// <summary>
        /// 输出对象
        /// </summary>
        [NonSerialized]
        [Description("输出对象")]
        public HObject outputHObject;
    }

    #endregion

    #region 文件读取

    /// <summary>
    /// 区域信息
    /// </summary>
    [Serializable]
    public class ReadFile_Info
    {
        /// <summary>
        /// 输出元组
        /// </summary>
        [Description("元组数据")]
        [NonSerialized]
        public HTuple data_HTuple;
    }

    #endregion
}
