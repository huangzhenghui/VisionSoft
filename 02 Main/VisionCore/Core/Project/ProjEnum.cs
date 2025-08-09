using RexHelps;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO.Ports;
using System.Linq;
using System.Text;
namespace VisionCore
{
    #region 系统枚举类型集合

    /// <summary>
    /// 数据类型，图像、区域等
    /// </summary>
    public enum DataMode         ///复数全部用list来存储
    {
        图像采集,
        图像增强,
        灰度缩放,
        掩膜抠图,
        图像剪切,
        边缘检测,
        轮廓提取,
        轮廓筛选,
        对象选择,
        对象集合,
        元组工具,
        创建区域,   
        找圆工具,
        找线工具,   
        拟合圆弧,
        点点距离,
        点线距离,
        线线距离,
        线线交点,
        点线投影,
        直线构建,
        创建模板,
        查找模板,
        仿射变换,
        九点标定,
        阈值分割,
        区域连通,
        区域筛选,
        区域处理,
        区域运算,
        区域填充,
        外接区域,
        内接区域,
        区域信息,
        形状转换,
        等分矩形,
        区域排序,
        灰度信息,
        表头设置,
        数据显示,
        条件判断,
        读一维码,
        读二维码,
        OCR识别,
        视觉工具,
        文件读取,

        整型,
        整型数组,
        双精度,
        双精度数组,
        布尔型,
        布尔型数组,
        字符串,
        字符串数组
    }

    /// <summary>
    /// 变量分类
    /// </summary>
    public enum DataType
    {
        单量 = 0,
        数组,
    }

    /// <summary>
    /// 变量归属
    /// </summary>
    public enum DataAtrr
    {
        全局变量,   ///全局变量，但无需保存
        系统变量,   ///系统变量，需要保存到本地
        数据队列,
    }

    /// <summary>
    /// 图像源 
    /// </summary>
    public enum ImageSource
    {
        指定图像,
        文件目录,
        相机采集
    }

    /// <summary>
    /// 图像处理方式
    /// </summary>
    public enum ImgProcMode
    {
        无,
        旋转90度,
        旋转180度,
        旋转270度,
        X镜像,
        Y镜像
    }

    /// <summary>
    /// 界面模式
    /// </summary>
    public enum InterfaceMode
    { 
        编辑状态,
        运行结果
    }

    /// <summary>
    /// 对比极性类型
    /// </summary>
    public enum FuncType
    {
        [EnumDescription("=")]
        等于,
        [EnumDescription("!=")]
        不等于,
        [EnumDescription(">")]
        大于,
        [EnumDescription(">=")]
        大于等于,
        [EnumDescription("<")]
        小于,
        [EnumDescription("<=")]
        小于等于,
        [EnumDescription("<")]
        包含,
        [EnumDescription("<=")]
        不包含
    }

    /// <summary>
    /// 运算符号
    /// </summary>
    public enum CharType
    {
        加,
        减,
        乘,
        除
    }

    /// <summary>
    /// 取值模式
    /// </summary>
    public enum ValueMode
    {
        最大值,
        最小值,
        平均值
    }

    /// <summary>
    /// 绘制圆模式
    /// </summary>
    public enum DrawCircleMode 
    { 
        圆弧,
        圆
    }

    /// <summary>
    /// 提取类型
    /// </summary>
    public enum PullType
    {
        全部点位,
        剔除提取
    }

    /// <summary>
    /// 图片滤波方法
    /// </summary>
    public enum FilterMode
    {
        无,
        中值滤波,
        均值滤波,
        高斯滤波,
        平滑滤波
    }

    /// <summary>
    /// 运行模式
    /// </summary>
    [Serializable]
    public enum RunMode
    {
        单次执行,
        循环执行,
        停止执行,
        主动执行
    }

    /// <summary>
    /// 运行方式
    /// </summary>
    [Serializable]
    public enum RunType
    {
        主动执行,
        调用时执行
    }

    /// <summary>
    /// 连接模式
    /// </summary>
    public enum EnviMode
    {
        联机模式,
        脱机模式
    }

    /// <summary>
    /// 循环模式
    /// </summary>
    public enum ForMode
    {
        有限,
        无限
    }

    /// <summary>ECom操作：
    /// 加载，增加，删除
    /// </summary>
    public enum EComOperate
    {
        Add, 
        Load,
        Remove,
        Clear
    }

    /// <summary>
    /// 通讯类型
    /// </summary>
    public enum EComType
    {
        TCP服务器,
        TCP客户端,
        串口通讯
    }

    /// <summary>
    /// 通讯数据类型
    /// </summary>
    public enum EComDataType
    {
        字符串,
        文件
    }

    /// <summary>
    /// 修改模式
    /// </summary>
    public enum ChangeMode
    {
        添加,
        删减
    }

    /// <summary>
    /// PLC数据格式
    /// </summary>
    public enum PLCDataFormat
    {
        ABCD,
        BADC,
        CDAB,
        DCBA
    }

    /// <summary>
    /// PLC数据类型
    /// </summary>
    public enum PLCDataType
    {
        短整型,
        无符号短整型,
        单精度,
        字符串
    }

    /// <summary>
    /// 文件类型
    /// </summary>
    public enum FileType
    {
        T_HTuple,
    }

    #endregion

    #region 系统数据类集合

    public static class ConstVar
    {
        //图像输出
        public const string CaptureImage = "CaptureImage";
        public const string EmphasisImg = "EmphasisImg";
        public const string ScaleGray = "ScaleGray";
        public const string ReduceImage = "ReduceImage";
        public const string CropImage = "CropImage";
        public const string EdgeDetection = "EdgeDetection";
        public const string HObjectSel = " HObjectSel";
        public const string HObjectSet = " HObjectSet";
        public const string HTupleTool = " HTupleTool";
        public const string CreateROI = "创建区域";
        public const string FillCircle = "找圆";
        public const string FillLine = "找线";
        public const string For = "For";
        public const string ContourExt = "ContourExt";
        public const string ContourSel = "ContourSel";
        public const string DistancePL = "DistancePL";
        public const string DistancePP = "DistancePP";
        public const string DistanceLL = "DistanceLL";
        public const string ProjectionPL = "ProjectionPL";
        public const string IntersectLL = "IntersectLL";
        public const string Model = "Model";
        public const string AffineMatrix = "AffineMatrix";
        public const string NinePointsCalib = "NinePointsCalib";
        public const string ConnectReg = "ConnectReg";
        public const string RegionSel = "RegionSel";
        public const string ProcessReg = "ProcessReg";
        public const string OperateReg = "OperateReg";
        public const string FillUpReg = "FillUpReg";
        public const string CreateLine = "CreateLine";
        public const string ExternalReg = "ExternalReg";
        public const string InternalReg = "InternalReg";
        public const string RegionInfo = "RegionInfo";
        public const string ShapeTrans = "ShapeTrans";
        public const string PartRectangle = "PartRectangle";
        public const string SortReg = "SortReg";
        public const string GrayInfo = "GrayInfo";
        public const string SetHeader = "SetHeader";
        public const string ShowData = "ShowData";
        public const string Judge = "Judge";
        public const string If = "If";
        public const string Else = "Else";
        public const string OCR = "OCR";
        public const string ReadBarcode = "ReadBarcode";
        public const string ReadQRCode = "ReadQRCode";
        public const string HalconScript = "HalconScript";
    }

    public class CommParams
    {
        /// <summary>
        /// IP
        /// </summary>
        public string IP;

        /// <summary>
        /// 端口
        /// </summary>
        public int port;

        /// <summary>
        /// 串口号
        /// </summary>
        public string serialPortNum;

        /// <summary>
        /// 波特率
        /// </summary>
        public int baudRate;

        /// <summary>
        /// 校验位
        /// </summary>
        public Parity checkBits;

        /// <summary>
        /// 数据位
        /// </summary>
        public int dataBits;

        /// <summary>
        /// 停止位
        /// </summary>
        public StopBits shutBits;

        /// <summary>
        /// 结束字符
        /// </summary>
        public string endData;

        /// <summary>
        /// 是否以十六禁止发送
        /// </summary>
        public bool isSendByHex;

        /// <summary>
        /// 是否以十六进制接收
        /// </summary>
        public bool isReceivedByHex;

        /// <summary>
        /// 初始化
        /// </summary>
        /// <param name="IP"></param>
        /// <param name="port"></param>
        /// <param name="endData"></param>
        /// <param name="isSendByHex"></param>
        /// <param name="isReceivedByHex"></param>
        public CommParams(string IP, int port, string endData, bool isSendByHex, bool isReceivedByHex)
        {
            this.IP = IP;
            this.port = port;
            this.endData = endData;
            this.isSendByHex = isSendByHex;
            this.isReceivedByHex = isReceivedByHex;
        }

        public CommParams(string serialPortNum, int baudRate, Parity checkBits, int dataBits, StopBits shutBits, bool isSendByHex, bool isReceivedByHex)
        {
            this.serialPortNum = serialPortNum;
            this.baudRate = baudRate;
            this.checkBits = checkBits;
            this.dataBits = dataBits;
            this.shutBits = shutBits;
            this.isSendByHex = isSendByHex;
            this.isReceivedByHex = isReceivedByHex;
        }
    }

    #endregion
}