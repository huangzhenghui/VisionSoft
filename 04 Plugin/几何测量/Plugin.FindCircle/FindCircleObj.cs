using HalconDotNet;
using MutualTools;
using Plugin.CreateROI;
using Rex.UI;
using RexConst;
using RexView;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using VisionCore;

namespace Plugin.FindCircle
{
    [Category("几何测量")]
    [DisplayName("找圆工具")]
    [Serializable]
    public class FindCircleObj : ObjBase
    {
        #region 字段、属性

        /// <summary>
        /// 图像名称
        /// </summary>
        public string mImages = "";

        /// <summary>
        /// 信息输出
        /// </summary>
        public FindCircle_Info findCircleInfo = new FindCircle_Info();

        /// <summary>
        /// 投影圆中心点Row
        /// </summary>
        [NonSerialized]
        public HTuple midR = new HTuple();

        /// <summary>
        /// 投影圆中心点Column
        /// </summary>
        [NonSerialized]
        public HTuple midC = new HTuple();

        /// <summary>
        /// 投影圆半径
        /// </summary>
        [NonSerialized]
        public HTuple radius = new HTuple();

        /// <summary>
        /// 投影圆起始角度
        /// </summary>
        [NonSerialized]
        public HTuple startAngle = new HTuple();

        /// <summary>
        /// 投影圆终止角度
        /// </summary>
        [NonSerialized]
        public HTuple endAngle = new HTuple();

        /// <summary>
        /// 方向
        /// </summary>
        public HTuple pointOrder = "positive";

        /// <summary>
        /// 测量矩形长半轴
        /// </summary>
        public double length1 = 50;

        /// <summary>
        /// 测量矩形短半轴
        /// </summary>
        public double length2 = 25;

        /// <summary>
        /// 平滑系数(double)
        /// </summary>
        public double sigma = 1;

        /// <summary>
        /// 对比度(double)
        /// </summary>
        public double contrast = 30;

        /// <summary>
        /// 先后选择：'all','first','last'
        /// </summary>
        public string select = "all";

        /// <summary>
        /// 明暗变化'all', 'negative', 'positive'
        /// </summary>
        public string transition = "all";

        /// <summary>
        /// 测量矩形数量(int)
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
        /// 圆结果克隆
        /// </summary>
        [NonSerialized]
        public static HObject lineCopy = new HObject();

        /// <summary>
        /// 中间值
        /// </summary>
        public string strMidR = "600", strMidC = "600", strRadius = "150", strStartAngle = "45", strEndAngle = "135";

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
                HTuple midRowCircle = new HTuple();
                HTuple midColCircle = new HTuple();
                HTuple radiusCircle = new HTuple();
                HTuple startACircle = new HTuple();
                HTuple endACircle = new HTuple();

                HObject fittedPoints = new HObject();
                HObject removedPoints = new HObject();
                HObject resultCircle = new HObject();

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
                HOperatorSet.TupleConcat(paramName, "start_phi", out paramName);
                HOperatorSet.TupleConcat(paramName, "end_phi", out paramName);
                HOperatorSet.TupleConcat(paramName, "measure_select", out paramName);
                HOperatorSet.TupleConcat(paramName, "measure_transition", out paramName);
                HOperatorSet.TupleConcat(paramName, "num_measures", out paramName);
                HOperatorSet.TupleConcat(paramValue, startAngle.TupleRad(), out paramValue);
                HOperatorSet.TupleConcat(paramValue, endAngle.TupleRad(), out paramValue);
                HOperatorSet.TupleConcat(paramValue, select, out paramValue);
                HOperatorSet.TupleConcat(paramValue, transition, out paramValue);
                HOperatorSet.TupleConcat(paramValue, measureNum, out paramValue);

                //执行算法
                FindCircle(mRImage, midR, midC, radius, startAngle, endAngle, length1, length2, sigma, contrast, paramName, paramValue, lowLimit, upLimit, pointSize, out fittedPoints, out removedPoints, out resultCircle, out fittedRows, out fittedCols, out midRowCircle, out midColCircle, out radiusCircle);

                //更新数据
                findCircleInfo.fittedPointObj = fittedPoints;
                findCircleInfo.removedPointObj = removedPoints;
                findCircleInfo.circleObj = resultCircle;
                findCircleInfo.pointRows = fittedRows;
                findCircleInfo.pointCols = fittedCols;
                findCircleInfo.circleCenterRow = midRowCircle;
                findCircleInfo.circleCenterCol = midColCircle;
                findCircleInfo.circleRadius = radiusCircle;

                if (fittedPoints != null && fittedPoints.IsInitialized()) fittedPointCopy = fittedPoints.Clone();
                if (removedPoints != null && removedPoints.IsInitialized()) removedPointCopy = removedPoints.Clone();
                if (resultCircle != null && resultCircle.IsInitialized()) lineCopy = resultCircle.Clone();

                //主界面窗体显示
                WindowShowROI();

                //保存对象
                SetVarList(ref mSloVar, new DataCell(ModInfo.Name, ModInfo.Encode, DataType.单量, DataMode.找圆工具, ConstVar.FillCircle, ModInfo.Plugin, "0", 1, findCircleInfo, DataAtrr.全局变量));

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
            new FindCircleForm((FindCircleObj)baseMod).ShowDialog();
        }

        /// <summary>
        /// 在主窗体的图像窗口显示区域
        /// </summary>
        public void WindowShowROI()
        {
            if (isShowPoint)
            {
                HRoi fittedPointResult = new HRoi(ModInfo.Encode, ModInfo.Name, ModInfo.Remarks, HRoiType.输出点位, fittedPointColor, new HObject(findCircleInfo.fittedPointObj));
                mRImage.ShowHRoi(fittedPointResult);

                HRoi removedPointResult = new HRoi(ModInfo.Encode, ModInfo.Name, ModInfo.Remarks, HRoiType.过滤点位, removedPointColor, new HObject(findCircleInfo.removedPointObj));
                mRImage.ShowHRoi(removedPointResult);
            }

            if (isShowReg)
            {
                HRoi lineResult = new HRoi(ModInfo.Encode, ModInfo.Name, ModInfo.Remarks, HRoiType.输出圆, resultColor, new HObject(findCircleInfo.circleObj));
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
            findCircleInfo.fittedPointObj = new HObject();
            findCircleInfo.removedPointObj = new HObject();
            findCircleInfo.circleObj = new HObject();
            findCircleInfo.pointRows = new HTuple();
            findCircleInfo.pointCols = new HTuple();
            findCircleInfo.circleCenterRow = new HTuple();
            findCircleInfo.circleCenterCol = new HTuple();
            findCircleInfo.circleRadius = new HTuple();
        }

        /// <summary>
        /// 如果数据内容是链接，则由GetLinkValue得到链接的值
        /// </summary>
        public void GetData()
        {
            try
            {
                midR = Var.AcqValue_HTuple(strMidR, mSysVar, mSloVar);
                midC = Var.AcqValue_HTuple(strMidC, mSysVar, mSloVar);
                radius = Var.AcqValue_HTuple(strRadius, mSysVar, mSloVar);
                startAngle = Var.AcqValue_HTuple(strStartAngle, mSysVar, mSloVar);
                endAngle = Var.AcqValue_HTuple(strEndAngle, mSysVar, mSloVar);
            }
            catch { }
        }

        #endregion

        #region 方法-算法相关

        /// <summary>
        /// 找圆算法
        /// </summary>
        /// <param name="pointRows"></param>
        /// <param name="pointCols"></param>
        /// <param name="xldPoint"></param>
        /// <param name="circle"></param>
        /// <param name="circleCenter"></param>
        /// <param name="circleCenterRow"></param>
        /// <param name="circleCenterCol"></param>
        /// <returns></returns>
        public void FindCircle(HObject img, HTuple midR, HTuple midC, HTuple radius, HTuple startAngle, HTuple endAngle, HTuple length1, HTuple length2, HTuple sigma, HTuple contrast, HTuple paramName, HTuple paramValue, int lowLimit, int upLimit, HTuple pointSize, out HObject fittedPoints, out HObject removedPoints, out HObject resultCircle, out HTuple fittedRows, out HTuple fittedCols, out HTuple midRowCircle, out HTuple midColCircle, out HTuple radiusCircle)
        {
            int posIdx1, posIdx2;

            HTuple metrologyHandle = new HTuple();
            HTuple index = new HTuple();
            HObject contour1 = new HObject();
            HObject contour2 = new HObject();
            HObject contour3 = new HObject();
            HObject contour4 = new HObject();
            HTuple rows = new HTuple();
            HTuple cols = new HTuple();
            HTuple midRFitCircle = new HTuple();
            HTuple midCFitCircle = new HTuple();
            HTuple radiusFitCircle = new HTuple();
            HTuple startAFitCircle = new HTuple();
            HTuple endAFitCircle = new HTuple();
            HTuple pointOrder1 = new HTuple();
            HTuple pointOrder2 = new HTuple();
            HTuple distPCMin = new HTuple();
            HTuple distPCMax = new HTuple();
            HTuple idxSorted = new HTuple();
            HTuple idxRemoved = new HTuple();
            HTuple removedRows = new HTuple();
            HTuple removedCols = new HTuple();
            HTuple midRowFitLine = new HTuple();
            HTuple beginColFitLine = new HTuple();
            HTuple endRowFitLine = new HTuple();
            HTuple endColFitLine = new HTuple();
            HTuple startACircle = new HTuple();
            HTuple endACircle = new HTuple();

            fittedRows = new HTuple();
            fittedCols = new HTuple();
            midRowCircle = new HTuple();
            midColCircle = new HTuple();
            radiusCircle = new HTuple();
            fittedPoints = new HObject();
            removedPoints = new HObject();
            resultCircle = new HObject();


            HOperatorSet.CreateMetrologyModel(out metrologyHandle);
            HOperatorSet.AddMetrologyObjectCircleMeasure(metrologyHandle, midR, midC, radius, length1, length2, sigma, contrast, paramName, paramValue, out index);
            HOperatorSet.ApplyMetrologyModel(img, metrologyHandle);
            HOperatorSet.GetMetrologyObjectMeasures(out contour1, metrologyHandle, "all", "all", out rows, out cols);
            HOperatorSet.GenContourPolygonXld(out contour2, rows, cols);
            HOperatorSet.FitCircleContourXld(contour2, "geotukey", -1, 1.5, 0, 3, 2, out midRFitCircle, out midCFitCircle, out radiusFitCircle, out startAFitCircle, out endAFitCircle, out pointOrder1);
            HOperatorSet.GenCircleContourXld(out contour3, midRFitCircle, midCFitCircle, radiusFitCircle, startAFitCircle, endAFitCircle, pointOrder1, 1);
            HOperatorSet.DistancePc(contour3, rows, cols, out distPCMin, out distPCMax);
            HOperatorSet.TupleSortIndex(distPCMin, out idxSorted);
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
            HOperatorSet.GenContourPolygonXld(out contour4, fittedRows, fittedCols);
            HOperatorSet.FitCircleContourXld(contour4, "geotukey", -1, 1.5, 0, 3, 2, out midRowCircle, out midColCircle, out radiusCircle, out startACircle, out endACircle, out pointOrder2);
            HOperatorSet.GenCircleContourXld(out resultCircle, midRowCircle, midColCircle, radiusCircle, startAngle.TupleRad(), endAngle.TupleRad(), pointOrder2, 1);
            HOperatorSet.ClearMetrologyModel(metrologyHandle);
        }

        #endregion
    }
}
