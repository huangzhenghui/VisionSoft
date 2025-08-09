using HalconDotNet;
using Plugin.CreateROI;
using Rex.UI;
using RexConst;
using RexView;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using VisionCore;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Plugin.CreateLine
{
    [Category("几何构建")]
    [DisplayName("直线构建")]
    [Serializable]
    public class CreateLineObj : ObjBase
    {
        #region 字段、属性

        /// <summary>
        /// 图像名称
        /// </summary>
        public string mImages = "";

        /// <summary>
        /// 点点距离类
        /// </summary>
        public CreateLine_Info createLine_Info = new CreateLine_Info();

        /// <summary>
        /// 直线样式
        /// </summary>
        public string lineType = "普通";

        /// <summary>
        /// 直线起点Row坐标
        /// </summary>
        public double beginRow = 100;

        /// <summary>
        /// 直线起点Column坐标
        /// </summary>
        public double beginCol = 100;

        /// <summary>
        /// 直线终点Row坐标
        /// </summary>
        public double endRow = 200;

        /// <summary>
        /// 直线终点Column坐标
        /// </summary>
        public double endCol = 600;

        /// <summary>
        /// 结果颜色
        /// </summary>
        public string resultColor = "#00FF00";

        /// <summary>
        /// 箭头宽度
        /// </summary>
        public int arrowWidth = 15;

        /// <summary>
        /// 中间变量
        /// </summary>
        public string strBeginRow = "100", strBeginCol = "100", strEndRow = "200", strEndCol = "600";

        #endregion

        #region 方法-模块相关

        /// <summary>
        /// 运行模块
        /// </summary>
        /// <returns></returns>
        public override bool RunObj()
        {
            try
            {
                //设置可绘制区域的大小
                HOperatorSet.SetSystem("width", 20000);
                HOperatorSet.SetSystem("height", 20000);

                //初始化输出变量
                InitOutput();

                //加载图像
                if ((RImage)Var.GetImage(mSloVar, mImages) == null)
                {
                    ModInfo.State = ModState.NG;
                    return false;
                }
                else
                {
                    mRImage = (RImage)Var.GetImage(mSloVar, mImages);
                }

                //获取数据
                GetData();

                //执行算法
                switch (lineType)
                {
                    case "普通":
                        HOperatorSet.GenContourPolygonXld(out createLine_Info.lineObj, (new HTuple(beginRow)).TupleConcat(endRow), (new HTuple(beginCol)).TupleConcat(endCol));
                        break;
                    case "箭头":
                        gen_arrow_contour_xld(out createLine_Info.lineObj, beginRow, beginCol, endRow, endCol, arrowWidth, arrowWidth);
                        break;
                }

                //更新数据
                createLine_Info.lineBeginR = beginRow;
                createLine_Info.lineBeginC = beginCol;
                createLine_Info.lineEndR = endRow;
                createLine_Info.lineEndC = endCol;

                //主界面窗体显示
                WindowShowROI();

                //保存对象
                SetVarList(ref mSloVar, new DataCell(ModInfo.Name, ModInfo.Encode, DataType.单量, DataMode.直线构建, ConstVar.CreateLine, ModInfo.Plugin, "0", 1, createLine_Info, DataAtrr.全局变量));

                Log.Info(ModInfo.Name + ":" + "执行成功");
                ModInfo.State = ModState.OK;
                return true;

            }
            catch (Exception ex)
            {
                Log.Error(ModInfo.Name + ":" + ex.Message);
                ModInfo.State = ModState.NG;
                mRImageResult = null;
                return false;
            }
        }

        #endregion

        #region 方法-窗体相关

        /// <summary>
        /// 显示窗体
        /// </summary>
        /// <param name="baseMod"></param>
        public override void RunForm(ObjBase baseMod)
        {
            new CreateLineForm((CreateLineObj)baseMod).ShowDialog();
        }

        /// <summary>
        /// 在主窗体的图像窗口显示区域
        /// </summary>
        public void WindowShowROI()
        {
            if (mRImage != null)
            {
                if (isShowReg)
                {
                    HObject point, objAssem;
                    HOperatorSet.GenEmptyObj(out point);
                    HOperatorSet.GenEmptyObj(out objAssem);

                    HOperatorSet.GenCrossContourXld(out point, new HTuple(beginRow).TupleConcat(endRow), new HTuple(beginCol).TupleConcat(endCol), 15, 0.785398);
                    HOperatorSet.ConcatObj(point, createLine_Info.lineObj, out objAssem);
                    HRoi roiResult = new HRoi(ModInfo.Encode, ModInfo.Name, ModInfo.Remarks, HRoiType.检测结果, resultColor, new HObject(objAssem));
                    mRImage.ShowHRoi(roiResult);
                }
            }
        }

        #endregion

        #region 方法-数据相关

        /// <summary>
        /// 如果数据内容是链接，则由GetLinkValue得到链接的值，赋值给double类型数据
        /// </summary>
        public void GetData()
        {
            try
            {
                if (strBeginCol.Contains(":"))
                {
                    beginCol = Convert.ToDouble(Var.GetLinkValue(mSysVar, mSloVar, strBeginCol));
                }
                else
                {

                    beginCol = strBeginCol.ToDouble();
                }

                if (strBeginRow.Contains(":"))
                {
                    beginRow = Convert.ToDouble(Var.GetLinkValue(mSysVar, mSloVar, strBeginRow));
                }
                else
                {
                    beginRow = strBeginRow.ToDouble();
                }

                if (strEndCol.Contains(":"))
                {
                    endCol = Convert.ToDouble(Var.GetLinkValue(mSysVar, mSloVar, strEndCol));
                }
                else
                {
                    endCol = strEndCol.ToDouble();
                }

                if (strEndRow.Contains(":"))
                {
                    endRow = Convert.ToDouble(Var.GetLinkValue(mSysVar, mSloVar, strEndRow));
                }
                else
                {
                    endRow = strEndRow.ToDouble();
                }
            }
            catch { }
        }

        /// <summary>
        /// 初始化模块输出对象的变量
        /// </summary>
        public void InitOutput()
        {
            HOperatorSet.GenEmptyObj(out createLine_Info.lineObj);
        }

        #endregion

        #region 方法-算法相关

        /// <summary>
        /// 生成箭头直线
        /// </summary>
        /// <param name="ho_Arrow"></param>
        /// <param name="hv_Row1"></param>
        /// <param name="hv_Column1"></param>
        /// <param name="hv_Row2"></param>
        /// <param name="hv_Column2"></param>
        /// <param name="hv_HeadLength"></param>
        /// <param name="hv_HeadWidth"></param>
        public void gen_arrow_contour_xld(out HObject ho_Arrow, HTuple hv_Row1, HTuple hv_Column1, HTuple hv_Row2, HTuple hv_Column2, HTuple hv_HeadLength, HTuple hv_HeadWidth)
        {
            // Stack for temporary objects 
            HObject[] OTemp = new HObject[20];

            // Local iconic variables 

            HObject ho_TempArrow = null;

            // Local control variables 

            HTuple hv_Length = new HTuple(), hv_ZeroLengthIndices = new HTuple();
            HTuple hv_DR = new HTuple(), hv_DC = new HTuple(), hv_HalfHeadWidth = new HTuple();
            HTuple hv_RowP1 = new HTuple(), hv_ColP1 = new HTuple();
            HTuple hv_RowP2 = new HTuple(), hv_ColP2 = new HTuple();
            HTuple hv_Index = new HTuple();
            // Initialize local and output iconic variables 
            HOperatorSet.GenEmptyObj(out ho_Arrow);
            HOperatorSet.GenEmptyObj(out ho_TempArrow);

            //Init
            ho_Arrow.Dispose();
            HOperatorSet.GenEmptyObj(out ho_Arrow);
            //
            //Calculate the arrow length
            hv_Length.Dispose();
            HOperatorSet.DistancePp(hv_Row1, hv_Column1, hv_Row2, hv_Column2, out hv_Length);
            //
            //Mark arrows with identical start and end point
            //(set Length to -1 to avoid division-by-zero exception)
            hv_ZeroLengthIndices.Dispose();
            using (HDevDisposeHelper dh = new HDevDisposeHelper())
            {
                hv_ZeroLengthIndices = hv_Length.TupleFind(
                    0);
            }
            if ((int)(new HTuple(hv_ZeroLengthIndices.TupleNotEqual(-1))) != 0)
            {
                if (hv_Length == null)
                    hv_Length = new HTuple();
                hv_Length[hv_ZeroLengthIndices] = -1;
            }
            //
            //Calculate auxiliary variables.
            hv_DR.Dispose();
            using (HDevDisposeHelper dh = new HDevDisposeHelper())
            {
                hv_DR = (1.0 * (hv_Row2 - hv_Row1)) / hv_Length;
            }
            hv_DC.Dispose();
            using (HDevDisposeHelper dh = new HDevDisposeHelper())
            {
                hv_DC = (1.0 * (hv_Column2 - hv_Column1)) / hv_Length;
            }
            hv_HalfHeadWidth.Dispose();
            using (HDevDisposeHelper dh = new HDevDisposeHelper())
            {
                hv_HalfHeadWidth = hv_HeadWidth / 2.0;
            }
            //
            //Calculate end points of the arrow head.
            hv_RowP1.Dispose();
            using (HDevDisposeHelper dh = new HDevDisposeHelper())
            {
                hv_RowP1 = (hv_Row1 + ((hv_Length - hv_HeadLength) * hv_DR)) + (hv_HalfHeadWidth * hv_DC);
            }
            hv_ColP1.Dispose();
            using (HDevDisposeHelper dh = new HDevDisposeHelper())
            {
                hv_ColP1 = (hv_Column1 + ((hv_Length - hv_HeadLength) * hv_DC)) - (hv_HalfHeadWidth * hv_DR);
            }
            hv_RowP2.Dispose();
            using (HDevDisposeHelper dh = new HDevDisposeHelper())
            {
                hv_RowP2 = (hv_Row1 + ((hv_Length - hv_HeadLength) * hv_DR)) - (hv_HalfHeadWidth * hv_DC);
            }
            hv_ColP2.Dispose();
            using (HDevDisposeHelper dh = new HDevDisposeHelper())
            {
                hv_ColP2 = (hv_Column1 + ((hv_Length - hv_HeadLength) * hv_DC)) + (hv_HalfHeadWidth * hv_DR);
            }
            //
            //Finally create output XLD contour for each input point pair
            for (hv_Index = 0; (int)hv_Index <= (int)((new HTuple(hv_Length.TupleLength())) - 1); hv_Index = (int)hv_Index + 1)
            {
                if ((int)(new HTuple(((hv_Length.TupleSelect(hv_Index))).TupleEqual(-1))) != 0)
                {
                    //Create_ single points for arrows with identical start and end point
                    using (HDevDisposeHelper dh = new HDevDisposeHelper())
                    {
                        ho_TempArrow.Dispose();
                        HOperatorSet.GenContourPolygonXld(out ho_TempArrow, hv_Row1.TupleSelect(hv_Index),
                            hv_Column1.TupleSelect(hv_Index));
                    }
                }
                else
                {
                    //Create arrow contour
                    using (HDevDisposeHelper dh = new HDevDisposeHelper())
                    {
                        ho_TempArrow.Dispose();
                        HOperatorSet.GenContourPolygonXld(out ho_TempArrow, ((((((((((hv_Row1.TupleSelect(
                            hv_Index))).TupleConcat(hv_Row2.TupleSelect(hv_Index)))).TupleConcat(
                            hv_RowP1.TupleSelect(hv_Index)))).TupleConcat(hv_Row2.TupleSelect(hv_Index)))).TupleConcat(
                            hv_RowP2.TupleSelect(hv_Index)))).TupleConcat(hv_Row2.TupleSelect(hv_Index)),
                            ((((((((((hv_Column1.TupleSelect(hv_Index))).TupleConcat(hv_Column2.TupleSelect(
                            hv_Index)))).TupleConcat(hv_ColP1.TupleSelect(hv_Index)))).TupleConcat(
                            hv_Column2.TupleSelect(hv_Index)))).TupleConcat(hv_ColP2.TupleSelect(
                            hv_Index)))).TupleConcat(hv_Column2.TupleSelect(hv_Index)));
                    }
                }
                {
                    HObject ExpTmpOutVar_0;
                    HOperatorSet.ConcatObj(ho_Arrow, ho_TempArrow, out ExpTmpOutVar_0);
                    ho_Arrow.Dispose();
                    ho_Arrow = ExpTmpOutVar_0;
                }
            }
            ho_TempArrow.Dispose();

            hv_Length.Dispose();
            hv_ZeroLengthIndices.Dispose();
            hv_DR.Dispose();
            hv_DC.Dispose();
            hv_HalfHeadWidth.Dispose();
            hv_RowP1.Dispose();
            hv_ColP1.Dispose();
            hv_RowP2.Dispose();
            hv_ColP2.Dispose();
            hv_Index.Dispose();

            return;
        }

        #endregion
    }
}
