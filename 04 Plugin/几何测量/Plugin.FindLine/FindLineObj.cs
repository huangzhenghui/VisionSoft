 using HalconDotNet;
using MutualTools;
using Plugin.CreateROI;
using Rex.UI;
using RexConst;
using RexView;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using VisionCore;

namespace Plugin.FindLine
{
    [Category("几何测量")]
    [DisplayName("找线工具")]
    [Serializable]
    public class FindLineObj : ObjBase
    {
        #region 字段、属性

        /// <summary>
        /// 图像名称
        /// </summary>
        public string mImages = "";

        /// <summary>
        /// 信息输出
        /// </summary>
        public FindLine_Info findLineInfo = new FindLine_Info();

        /// <summary>
        /// 投影直线起点Row
        /// </summary>
        [NonSerialized]
        public HTuple rowBegin = new HTuple();

        /// <summary>
        /// 投影直线起点Column
        /// </summary>
        [NonSerialized]
        public HTuple colBegin = new HTuple();

        /// <summary>
        /// 投影直线终点Row
        /// </summary>
        [NonSerialized]
        public HTuple rowEnd = new HTuple();

        /// <summary>
        /// 投影直线终点Column
        /// </summary>
        [NonSerialized]
        public HTuple colEnd = new HTuple();

        /// <summary>
        /// 测量矩形长半轴
        /// </summary>
        public double length1 = 50;

        /// <summary>
        /// 测量矩形短半轴
        /// </summary>
        public double length2 = 25;

        /// <summary>
        /// 平滑系数
        /// </summary>
        public double sigma = 1;

        /// <summary>
        /// 对比度
        /// </summary>
        public int contrast = 30;

        /// <summary>
        /// 先后选择：'all','first','last'
        /// </summary>
        public string select = "all";

        /// <summary>
        /// 明暗变化'all', 'negative', 'positive'
        /// </summary>
        public string transition = "all";

        /// <summary>
        /// 测量矩形数量
        /// </summary>
        public int measureNum = 20;

        /// <summary>
        /// 测量矩形
        /// </summary>
        [NonSerialized]
        public HObject rectsCheck = new HObject();

        /// <summary>
        /// 点位筛选下限值
        /// </summary>
        public int lowLimit = 5;

        /// <summary>
        /// 点位筛选上限值
        /// </summary>
        public int upLimit = 95;

        /// <summary>
        /// 投影颜色
        /// </summary>
        public string projectColor = "#9300d3";

        /// <summary>
        /// 测量矩形颜色
        /// </summary>
        public string meaRectColor = "#5959AB";

        /// <summary>
        /// 是否显示点位
        /// </summary>
        public bool isShowPoint = true;

        /// <summary>
        /// 点位大小
        /// </summary>
        public int pointSize = 50;

        /// <summary>
        /// 拟合点位颜色
        /// </summary>
        public string fittedPointColor = "#00FF00";

        /// <summary>
        /// 过滤点位颜色
        /// </summary>
        public string removedPointColor = "#FF0000";

        /// <summary>
        /// 拟合点位克隆
        /// </summary>
        [NonSerialized]
        public static HObject fittedPointCopy = new HObject();

        /// <summary>
        /// 过滤点位克隆
        /// </summary>
        [NonSerialized]
        public static HObject removedPointCopy = new HObject();

        /// <summary>
        /// 直线结果克隆
        /// </summary>
        [NonSerialized]
        public static HObject lineCopy = new HObject();

        /// <summary>
        /// 中间值
        /// </summary>
        public string strRowBegin = "200", strColBegin = "200", strRowEnd = "200", strColEnd = "600";

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
                //声明变量
                HTuple paramName = new HTuple();
                HTuple paramValue = new HTuple();
                HTuple fittedRows = new HTuple();
                HTuple fittedCols = new HTuple();
                HTuple beginRowLine = new HTuple();
                HTuple beginColLine = new HTuple();
                HTuple endRowLine = new HTuple();
                HTuple endColLine = new HTuple();

                HObject fittedPoints = new HObject();
                HObject removedPoints = new HObject();
                HObject resultLine = new HObject();

                //初始化输出变量
                InitOutputInfo();

                //设置可绘制区域的大小
                HOperatorSet.SetSystem("width", 20000);
                HOperatorSet.SetSystem("height", 20000);

                //加载图像
                if ((RImage)Var.GetImage(mSloVar, mImages) == null)
                {
                    Log.Error(Sol.mSol.mProjList[ModInfo.Index].mProjInfo.Name + ": " + ModInfo.Name + ":" + "执行失败(原因：无输入图像)");
                    ModInfo.State = ModState.NG;
                    return false;
                }
                else
                {
                    mRImage = (RImage)Var.GetImage(mSloVar, mImages);
                }

                //获取数据
                GetData();

                //设置参数
                HOperatorSet.TupleConcat(paramName, "measure_select", out paramName);
                HOperatorSet.TupleConcat(paramName, "measure_transition", out paramName);
                HOperatorSet.TupleConcat(paramName, "num_measures", out paramName);
                HOperatorSet.TupleConcat(paramValue, select, out paramValue);
                HOperatorSet.TupleConcat(paramValue, transition, out paramValue);
                HOperatorSet.TupleConcat(paramValue, measureNum, out paramValue);

                //执行算法
                FindLine(mRImage, rowBegin, colBegin, rowEnd, colEnd, length1, length2, sigma, contrast, paramName, paramValue, lowLimit, upLimit, pointSize, out fittedPoints, out removedPoints, out resultLine, out fittedRows, out fittedCols, out beginRowLine, out beginColLine, out endRowLine, out endColLine);

                //更新数据
                findLineInfo.fittedPointObj = fittedPoints;
                findLineInfo.removedPointObj = removedPoints;
                findLineInfo.lineObj = resultLine;
                findLineInfo.pointRows = fittedRows;
                findLineInfo.pointCols = fittedCols;
                findLineInfo.lineBeginRow = beginRowLine;
                findLineInfo.lineBeginCol = beginColLine;
                findLineInfo.lineEndRow = endRowLine;
                findLineInfo.lineEndCol = endColLine;

                if (fittedPoints != null && fittedPoints.IsInitialized()) fittedPointCopy = fittedPoints.Clone();
                if (removedPoints != null && removedPoints.IsInitialized()) removedPointCopy = removedPoints.Clone();
                if (resultLine != null && resultLine.IsInitialized()) lineCopy = resultLine.Clone();

                //主界面窗体显示
                WindowShowROI();

                //保存对象
                SetVarList(ref mSloVar, new DataCell(ModInfo.Name, ModInfo.Encode, DataType.单量, DataMode.找线工具, ConstVar.FillLine, ModInfo.Plugin, "0", 1, findLineInfo, DataAtrr.全局变量));

                Log.Info(Sol.mSol.mProjList[ModInfo.Index].mProjInfo.Name + ": " + ModInfo.Name + ":" + "执行成功");
                ModInfo.State = ModState.OK;
                return true;
            }
            catch (Exception ex)
            {
                Log.Error(Sol.mSol.mProjList[ModInfo.Index].mProjInfo.Name + ": " + ModInfo.Name + ":" + "执行失败(" + "原因：" + ex.Message + ")");
                ModInfo.State = ModState.NG;
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
            new FindLineForm((FindLineObj)baseMod).ShowDialog();
        }

        /// <summary>
        /// 在主窗体的图像窗口显示区域
        /// </summary>
        public void WindowShowROI()
        {
            if (isShowPoint)
            {
                HRoi fittedPointResult = new HRoi(ModInfo.Encode, ModInfo.Name, ModInfo.Remarks, HRoiType.输出点位, fittedPointColor, new HObject(findLineInfo.fittedPointObj));
                mRImage.ShowHRoi(fittedPointResult);

                HRoi removedPointResult = new HRoi(ModInfo.Encode, ModInfo.Name, ModInfo.Remarks, HRoiType.过滤点位, removedPointColor, new HObject(findLineInfo.removedPointObj));
                mRImage.ShowHRoi(removedPointResult);
            }

            if (isShowReg)
            {
                HRoi lineResult = new HRoi(ModInfo.Encode, ModInfo.Name, ModInfo.Remarks, HRoiType.输出直线, resultColor, new HObject(findLineInfo.lineObj));
                mRImage.ShowHRoi(lineResult);
            }
        }

        #endregion

        #region 方法-数据相关

        /// <summary>
        /// 初始化输出变量
        /// </summary>
        public override void InitOutputInfo()
        {
            findLineInfo.fittedPointObj = new HObject();
            findLineInfo.removedPointObj = new HObject();
            findLineInfo.lineObj = new HObject();
            findLineInfo.pointRows = new HTuple();
            findLineInfo.pointCols = new HTuple();
            findLineInfo.lineBeginRow = new HTuple();
            findLineInfo.lineBeginCol = new HTuple();
            findLineInfo.lineEndRow = new HTuple();
            findLineInfo.lineEndCol = new HTuple();
        }

        /// <summary>
        /// 如果数据内容是链接，则由GetLinkValue得到链接的值
        /// </summary>
        public void GetData()
        {
            try
            {
                rowBegin = Var.AcqValue_HTuple(strRowBegin, mSysVar, mSloVar);
                colBegin = Var.AcqValue_HTuple(strColBegin, mSysVar, mSloVar);
                rowEnd = Var.AcqValue_HTuple(strRowEnd, mSysVar, mSloVar);
                colEnd = Var.AcqValue_HTuple(strColEnd, mSysVar, mSloVar);
            }
            catch{ }
        }

        #endregion

        #region 方法-算法相关

        /// <summary>
        /// 找线函数
        /// </summary>
        /// <param name="img"></param>
        /// <param name="rowBegin"></param>
        /// <param name="colBegin"></param>
        /// <param name="rowEnd"></param>
        /// <param name="colEnd"></param>
        /// <param name="length1"></param>
        /// <param name="length2"></param>
        /// <param name="sigma"></param>
        /// <param name="constrast"></param>
        /// <param name="paramName"></param>
        /// <param name="paramValue"></param>
        /// <param name="lowLimit"></param>
        /// <param name="upLimit"></param>
        /// <param name="pointSize"></param>
        /// <param name="fittedPoints"></param>
        /// <param name="removedPoints"></param>
        /// <param name="resultLine"></param>
        /// <param name="fittedRows"></param>
        /// <param name="fittedCols"></param>
        /// <param name="beginRowLine"></param>
        /// <param name="beginColLine"></param>
        /// <param name="endRowLine"></param>
        /// <param name="endColLine"></param>
        /// <returns></returns>
        public void FindLine(HObject img, HTuple rowBegin, HTuple colBegin, HTuple rowEnd, HTuple colEnd, HTuple length1, HTuple length2, HTuple sigma, HTuple contrast, HTuple paramName, HTuple paramValue, int lowLimit, int upLimit, HTuple pointSize, out HObject fittedPoints, out HObject removedPoints, out HObject resultLine, out HTuple fittedRows, out HTuple fittedCols, out HTuple beginRowLine, out HTuple beginColLine, out HTuple endRowLine, out HTuple endColLine)
        {
            int posIdx1, posIdx2;

            HTuple metrologyHandle = new HTuple();
            HTuple index = new HTuple();
            HObject contour1 = new HObject();
            HObject contour2 = new HObject();
            HObject contour3 = new HObject();
            HTuple rows = new HTuple();
            HTuple cols = new HTuple();
            HTuple beginRowFitLine = new HTuple();
            HTuple beginColFitLine = new HTuple();
            HTuple endRowFitLine = new HTuple();
            HTuple endColFitLine = new HTuple();
            HTuple nr = new HTuple();
            HTuple nc = new HTuple();
            HTuple dist = new HTuple();
            HTuple distPL = new HTuple();
            HTuple idxSorted = new HTuple();
            HTuple idxRemoved = new HTuple();
            HTuple removedRows = new HTuple();
            HTuple removedCols = new HTuple();

            fittedRows = new HTuple();
            fittedCols = new HTuple();
            beginRowLine = new HTuple();
            beginColLine = new HTuple();
            endRowLine = new HTuple();
            endColLine = new HTuple();
            fittedPoints = new HObject();
            removedPoints = new HObject();
            resultLine = new HObject();

            HOperatorSet.CreateMetrologyModel(out metrologyHandle);
            HOperatorSet.AddMetrologyObjectLineMeasure(metrologyHandle, rowBegin, colBegin, rowEnd, colEnd, length1, length2, sigma, contrast, paramName, paramValue, out index);
            HOperatorSet.ApplyMetrologyModel(img, metrologyHandle);
            HOperatorSet.GetMetrologyObjectMeasures(out contour1, metrologyHandle, "all", "all", out rows, out cols);
            HOperatorSet.GenContourPolygonXld(out contour2, rows, cols);
            HOperatorSet.FitLineContourXld(contour2, "drop", -1, 0, 0, 2, out beginRowFitLine, out beginColFitLine, out endRowFitLine, out endColFitLine, out nr, out nc, out dist);
            HOperatorSet.DistancePl(rows, cols, beginRowFitLine, beginColFitLine, endRowFitLine, endColFitLine, out distPL);
            HOperatorSet.TupleSortIndex(distPL, out idxSorted);
            posIdx1 = (int)(0.01 * lowLimit * idxSorted.Length) - 1;
            posIdx2 = (int)(0.01 * upLimit * idxSorted.Length);

            int removeCount = (int)(0.01 * (100 - (upLimit - lowLimit)) * idxSorted.Length);
            if (removeCount < 0.5 * idxSorted.Length)
            {
                for (int i = posIdx2; i < idxSorted.Length; i++)
                {
                    HOperatorSet.TupleConcat(idxRemoved, idxSorted[i], out idxRemoved);
                }

                for (int i = 0; i < posIdx1 + 1; i++)
                {
                    HOperatorSet.TupleConcat(idxRemoved, idxSorted[i], out idxRemoved);
                }

                HOperatorSet.TupleRemove(rows, idxRemoved, out fittedRows);
                HOperatorSet.TupleRemove(cols, idxRemoved, out fittedCols);

                HOperatorSet.TupleSelect(rows, idxRemoved, out removedRows);
                HOperatorSet.TupleSelect(cols, idxRemoved, out removedCols);
            }
            else
            {
                fittedRows = rows;
                fittedCols = cols;
            }

            HOperatorSet.GenCrossContourXld(out fittedPoints, fittedRows, fittedCols, pointSize, 0.785398);
            HOperatorSet.GenCrossContourXld(out removedPoints, removedRows, removedCols, pointSize, 0.785398);
            HOperatorSet.GenContourPolygonXld(out contour3, fittedRows, fittedCols);
            HOperatorSet.FitLineContourXld(contour3, "drop", -1, 0, 0, 2, out beginRowLine, out beginColLine, out endRowLine, out endColLine, out nr, out nc, out dist);
            HOperatorSet.GenContourPolygonXld(out resultLine, beginRowLine.TupleConcat(endRowLine), beginColLine.TupleConcat(endColLine));
            HOperatorSet.ClearMetrologyModel(metrologyHandle);
        }

        #endregion
    }
}
