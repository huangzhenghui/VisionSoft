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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Plugin.DistancePl
{
    [Category("几何测量")]
    [DisplayName("点线距离")]
    [Serializable]
    public class DistancePlObj : ObjBase
    {
        #region 字段、属性

        /// <summary>
        /// 图像名称
        /// </summary>
        public string mImages = "";

        /// <summary>
        /// 信息输出
        /// </summary>
        public DistancePL_Info distancePL_Info = new DistancePL_Info();

        /// <summary>
        /// 点Row坐标
        /// </summary>
        [NonSerialized]
        public HTuple pointsRow = new HTuple();

        /// <summary>
        /// 点Column坐标
        /// </summary>
        [NonSerialized]
        public HTuple pointsCol = new HTuple();

        /// <summary>
        /// 直线起点Row坐标
        /// </summary>
        [NonSerialized]
        public HTuple beginRow = new HTuple();

        /// <summary>
        /// 直线起点Col坐标
        /// </summary>
        [NonSerialized]
        public HTuple beginCol = new HTuple();

        /// <summary>
        /// 直线终点Row坐标
        /// </summary>
        [NonSerialized]
        public HTuple endRow = new HTuple();

        /// <summary>
        /// 直线终点Row坐标
        /// </summary>
        [NonSerialized]
        public HTuple endCol = new HTuple();

        /// <summary>
        /// 模式
        /// </summary>
        public string mode = "标量模式";

        /// <summary>
        /// 点位大小
        /// </summary>
        public int pointSize = 50;

        /// <summary>
        /// 点位颜色
        /// </summary>
        public string pointColor = "#9300d3";

        /// <summary>
        /// 直线颜色
        /// </summary>
        public string lineColor = "#5959AB";

        /// <summary>
        /// 中间变量
        /// </summary>
        public string strPointsRow = "100", strPointsCol = "100", strBeginRow = "200", strBeginCol = "200", strEndRow = "200", strEndCol = "600";

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
                HTuple distAssem = new HTuple();
                HObject hObjAssem = new HObject();

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

                //执行算法
                CalcDistPL(mode, isUsePixelPrec, mRImage.PixelPrec, pointsRow, pointsCol, beginRow, beginCol, endRow, endCol, pointSize, out hObjAssem, out distAssem);

                //状态更新
                exeResult = "执行成功";

                //更新数据
                distancePL_Info.distAssem = distAssem;
                distancePL_Info.hObjAssem = hObjAssem;

                //主界面窗体显示
                WindowShowROI();

                //保存对象
                SetVarList(ref mSloVar, new DataCell(ModInfo.Name, ModInfo.Encode, DataType.单量, DataMode.点线距离, ConstVar.DistancePL, ModInfo.Plugin, "0", 1, distancePL_Info, DataAtrr.全局变量));

                Log.Info(Sol.mSol.mProjList[ModInfo.Index].mProjInfo.Name + ": " + ModInfo.Name + ":" + "执行成功");
                ModInfo.State = ModState.OK;
                return true;
            }
            catch (Exception ex)
            {
                exeResult = "执行失败";
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
            new DistancePlForm((DistancePlObj)baseMod).ShowDialog();
        }

        /// <summary>
        /// 在主窗体的图像窗口显示区域
        /// </summary>
        public void WindowShowROI()
        {
            if (isShowData)
            {
                HText text;
                string strInfo = TypeConvert.HTupleToString(distancePL_Info.distAssem);
                if (prefix != "")
                {
                    text = new HText(ModInfo.Encode, ModInfo.Name, ModInfo.Remarks, HRoiType.文字显示, fontColor, prefix + ":" + strInfo, fontType, Y, X, fontSize, mRImage, false);
                }
                else
                {
                    text = new HText(ModInfo.Encode, ModInfo.Name, ModInfo.Remarks, HRoiType.文字显示, fontColor, strInfo, fontType, Y, X, fontSize, mRImage, false);
                }

                mRImage.ShowHText(text);
            }

            if (isShowReg)
            {
                HObject line = new HObject();
                HObject points = new HObject();
                HObject verticalLines = new HObject();

                HOperatorSet.SelectObj(distancePL_Info.hObjAssem, out line, 1);
                HRoi lineResult = new HRoi(ModInfo.Encode, ModInfo.Name, ModInfo.Remarks, HRoiType.输入直线, lineColor, new HObject(line));
                mRImage.ShowHRoi(lineResult);

                int num = distancePL_Info.hObjAssem.CountObj();
                HTuple pointsIdx = HTuple.TupleGenSequence(2, (num - 1) / 2 + 1, 1);
                HOperatorSet.SelectObj(distancePL_Info.hObjAssem, out points, pointsIdx);
                HRoi pointsResult = new HRoi(ModInfo.Encode, ModInfo.Name, ModInfo.Remarks, HRoiType.输入点位, pointColor, new HObject(points));
                mRImage.ShowHRoi(pointsResult);

                HTuple verticalLinesIdx = HTuple.TupleGenSequence((num - 1) / 2 + 1, num, 1);
                HOperatorSet.SelectObj(distancePL_Info.hObjAssem, out verticalLines, verticalLinesIdx);
                HRoi verticalLinesResult = new HRoi(ModInfo.Encode, ModInfo.Name, ModInfo.Remarks, HRoiType.输出直线, resultColor, new HObject(verticalLines));
                mRImage.ShowHRoi(verticalLinesResult);
            }
        }

        /// <summary>
        /// 绘制延长线
        /// </summary>
        public void DrawExLine(HTuple beginRow, HTuple beginCol, HTuple endRow, HTuple endCol, out HObject contour)
        {
            double k, b;
            HTuple width = new HTuple();
            HTuple height = new HTuple();
            HTuple rows = new HTuple();
            HTuple cols = new HTuple();

            contour = new HObject();

            HOperatorSet.GetImageSize(mRImage, out width, out height);
            if (endRow.D == beginRow.D)
            {
                rows = (new HTuple(beginRow)).TupleConcat(endRow);
                cols = (new HTuple(0)).TupleConcat(width);
            }
            else
            {
                //求直线函数时，以Row或Col哪个为自变量或因变量都无所谓,是直线的两个不同形式的函数
                k = (endCol - beginCol).D / (endRow - beginRow).D;
                b = (endCol - k * endRow).D;
                beginRow = 0;
                if (beginCol >= 0 && beginCol <= width)
                {
                    beginCol = k * beginRow + b;
                }
                else
                {
                    beginCol = 0;
                    beginRow = (beginCol - b) / k;
                }

                endRow = height - 1;
                endCol = k * endRow + b;
                if (endCol >= 0 && endCol <= width)
                {
                    endCol = k * endRow + b;
                }
                else
                {
                    endCol = width - 1;
                    endRow = (endCol - b) / k;
                }

                rows = (new HTuple(beginRow)).TupleConcat(endRow);
                cols = (new HTuple(beginCol)).TupleConcat(endCol);
            }

            HOperatorSet.GenContourPolygonXld(out contour, rows, cols);
        }

        #endregion

        #region 方法-数据相关

        /// <summary>
        /// 初始化输出变量
        /// </summary>
        public override void InitOutputInfo()
        {
            distancePL_Info.distAssem = new HTuple();
        }

        /// <summary>
        /// 如果数据内容是链接，则由GetLinkValue得到链接的值
        /// </summary>
        public void GetData()
        {
            try
            {
                pointsRow = Var.AcqValue_HTuple(strPointsRow, mSysVar, mSloVar);
                pointsCol = Var.AcqValue_HTuple(strPointsCol, mSysVar, mSloVar);
                beginRow = Var.AcqValue_HTuple(strBeginRow, mSysVar, mSloVar);
                beginCol = Var.AcqValue_HTuple(strBeginCol, mSysVar, mSloVar);
                endRow = Var.AcqValue_HTuple(strEndRow, mSysVar, mSloVar);
                endCol = Var.AcqValue_HTuple(strEndCol, mSysVar, mSloVar);
            }
            catch { }
        }

        #endregion

        #region 方法-算法相关

        /// <summary>
        /// 计算点线距离
        /// </summary>
        /// <param name="mode"></param>
        /// <param name="isUsePixelPrec"></param>
        /// <param name="pixelPrec"></param>
        /// <param name="pointsRow"></param>
        /// <param name="pointsCol"></param>
        /// <param name="beginRow"></param>
        /// <param name="beginCol"></param>
        /// <param name="endRow"></param>
        /// <param name="endCol"></param>
        /// <param name="pointSize"></param>
        /// <param name="hObjAssem"></param>
        /// <param name="distAssem"></param>
        public void CalcDistPL(string mode, bool isUsePixelPrec, double pixelPrec, HTuple pointsRow, HTuple pointsCol, HTuple beginRow, HTuple beginCol, HTuple endRow, HTuple endCol, HTuple pointSize, out HObject hObjAssem, out HTuple distAssem)
        {
            HObject points = new HObject();
            HObject line = new HObject();
            HObject verticalLines = new HObject();

            hObjAssem = new HObject();
            distAssem = new HTuple();

            if (beginRow.D == endRow.D)
            {
                double x = beginRow;
                switch (mode)
                {
                    case "标量模式":
                        for (int i = 0; i < pointsRow.Length; i++)
                        {
                            double dist = Math.Abs(pointsRow[i] - x);
                            distAssem.Append(dist);
                        }
                        break;
                    case "矢量模式":
                        for (int i = 0; i < pointsRow.Length; i++)
                        {
                            double dist = pointsRow[i] - x;
                            distAssem.Append(dist);
                        }
                        break;
                }
            }
            else
            {
                //求直线函数时，以Row或Col哪个为自变量或因变量都无所谓,是直线的两个不同形式的函数
                double k = (endCol - beginCol).D / (endRow - beginRow).D;
                double b = (beginCol - k * beginRow).D;

                switch (mode)
                {
                    case "标量模式":
                        for (int i = 0; i < pointsRow.Length; i++)
                        {
                            double dist = (Math.Abs((double)(k * pointsRow[i] - pointsCol[i] + b))) / (double)Math.Sqrt(1 + k * k);
                            distAssem.Append(dist);
                        }
                        break;
                    case "矢量模式":
                        for (int i = 0; i < pointsRow.Length; i++)
                        {
                            double dist = (double)(k * pointsRow[i] - pointsCol[i] + b) / Math.Sqrt(1 + k * k);
                            distAssem.Append(dist);
                        }
                        break;
                }
            }

            if (isUsePixelPrec)
            {
                distAssem = distAssem * pixelPrec;
            }

            HOperatorSet.GenCrossContourXld(out points, pointsRow, pointsCol, pointSize, 0.785398);
            DrawExLine(beginRow, beginCol, endRow, endCol, out line);

            for (int i = 0; i < pointsRow.Length; i++)
            {
                HTuple projRow = new HTuple();
                HTuple projCol = new HTuple();
                HObject linePP = new HObject();

                HOperatorSet.ProjectionPl(pointsRow[i].D, pointsCol[i].D, beginRow, beginCol, endRow, endCol, out projRow, out projCol);
                HOperatorSet.GenContourPolygonXld(out linePP, new HTuple(pointsRow[i].D, projRow.D), new HTuple(pointsCol[i].D, projCol.D));

                if (!verticalLines.IsInitialized())
                {
                    verticalLines = linePP;
                }
                else
                {
                    HOperatorSet.ConcatObj(verticalLines, linePP, out verticalLines);
                }
            }

            HOperatorSet.ConcatObj(line, points, out hObjAssem);
            HOperatorSet.ConcatObj(hObjAssem, verticalLines, out hObjAssem);
        }

        #endregion
    }
}
