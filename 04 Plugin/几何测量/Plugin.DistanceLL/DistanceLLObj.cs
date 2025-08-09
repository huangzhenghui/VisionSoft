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

namespace Plugin.DistanceLL
{
    [Category("几何测量")]
    [DisplayName("线线距离")]
    [Serializable]
    public class DistanceLLObj : ObjBase
    {
        #region 字段、属性

        /// <summary>
        /// 图像名称
        /// </summary>
        public string mImages = "";

        /// <summary>
        /// 信息输出
        /// </summary>
        public DistanceLL_Info distanceLL_Info = new DistanceLL_Info();

        /// <summary>
        /// 线1起点Row坐标
        /// </summary>
        [NonSerialized]
        public HTuple beginRowL1 = new HTuple();

        /// <summary>
        /// 线1起点Column坐标
        /// </summary>
        [NonSerialized]
        public HTuple beginColL1 = new HTuple();

        /// <summary>
        /// 线1终点Row坐标
        /// </summary>
        [NonSerialized]
        public HTuple endRowL1 = new HTuple();

        /// <summary>
        /// 线1终点Column坐标
        /// </summary>
        [NonSerialized]
        public HTuple endColL1 = new HTuple();

        /// <summary>
        /// 线2起点Row坐标
        /// </summary>
        [NonSerialized]
        public HTuple beginRowL2 = new HTuple();

        /// <summary>
        /// 线2起点Column坐标
        /// </summary>
        [NonSerialized]
        public HTuple beginColL2 = new HTuple();

        /// <summary>
        /// 线2终点Row坐标
        /// </summary>
        [NonSerialized]
        public HTuple endRowL2 = new HTuple();

        /// <summary>
        /// 线2终点Column坐标
        /// </summary>
        [NonSerialized]
        public HTuple endColL2 = new HTuple();

        /// <summary>
        /// 取值模式
        /// </summary>
        public ValueMode valueMode = ValueMode.平均值;

        /// <summary>
        /// 点位大小
        /// </summary>
        public int pointSize = 50;

        /// <summary>
        /// 线1颜色
        /// </summary>
        public string line1Color = "#0099FF";

        /// <summary>
        /// 线2颜色
        /// </summary>
        public string line2Color = "#FF9900";

        /// <summary>
        /// 点1颜色
        /// </summary>
        public string point1Color = "#66FFFF";

        /// <summary>
        /// 点2颜色
        /// </summary>
        public string point2Color = "#FFFF00";

        /// <summary>
        /// 中间变量
        /// </summary>
        public string strBeginRowL1 = "200", strBeginColL1 = "200", strEndRowL1 = "200", strEndColL1 = "600", strBeginRowL2 = "400", strBeginColL2 = "200", strEndRowL2 = "400", strEndColL2 = "600";

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
                CalcDistLL(isUsePixelPrec, mRImage.PixelPrec, beginRowL1, beginColL1, endRowL1, endColL1, beginRowL2, beginColL2, endRowL2, endColL2, pointSize, out hObjAssem, out distAssem);

                //状态更新
                exeResult = "执行成功";

                //更新数据
                distanceLL_Info.distAssem = distAssem;
                distanceLL_Info.hObjAssem = hObjAssem;

                //主界面窗体显示
                WindowShowROI();

                //保存对象
                SetVarList(ref mSloVar, new DataCell(ModInfo.Name, ModInfo.Encode, DataType.单量, DataMode.线线距离, ConstVar.DistanceLL, ModInfo.Plugin, "0", 1, distanceLL_Info, DataAtrr.全局变量));

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
            new DistanceLLForm((DistanceLLObj)baseMod).ShowDialog();
        }

        /// <summary>
        /// 在主窗体的图像窗口显示区域
        /// </summary>
        public void WindowShowROI()
        {
            if (isShowData)
            {
                HText text;
                string strInfo = TypeConvert.HTupleToString(distanceLL_Info.distAssem);
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
                HObject line1 = new HObject();
                HObject line2 = new HObject();
                HObject l1Assem = new HObject();
                HObject point1 = new HObject();
                HObject point2 = new HObject();
                HObject verLine = new HObject();

                int len = beginRowL1.Length;
                HTuple line1Idx = HTuple.TupleGenSequence(1, len, 1);
                HOperatorSet.SelectObj(distanceLL_Info.hObjAssem, out line1, line1Idx);
                HRoi inputLine1 = new HRoi(ModInfo.Encode, ModInfo.Name, ModInfo.Remarks, HRoiType.输入直线, line1Color, new HObject(line1));
                mRImage.ShowHRoi(inputLine1);

                HOperatorSet.SelectObj(distanceLL_Info.hObjAssem, out line1, len + 1);
                HRoi inputLine2 = new HRoi(ModInfo.Encode, ModInfo.Name, ModInfo.Remarks, HRoiType.输入直线, line1Color, new HObject(line2));
                mRImage.ShowHRoi(inputLine2);

                int num = distanceLL_Info.hObjAssem.CountObj();
                HTuple point1Idx = HTuple.TupleGenSequence(len + 2, num, 3);
                HOperatorSet.SelectObj(distanceLL_Info.hObjAssem, out point1, point1Idx);
                HRoi point1Result = new HRoi(ModInfo.Encode, ModInfo.Name, ModInfo.Remarks, HRoiType.输入点位, point1Color, new HObject(point1));
                mRImage.ShowHRoi(point1Result);

                HTuple point2Idx = HTuple.TupleGenSequence(len + 3, num, 3);
                HOperatorSet.SelectObj(distanceLL_Info.hObjAssem, out point2, point2Idx);
                HRoi point2Result = new HRoi(ModInfo.Encode, ModInfo.Name, ModInfo.Remarks, HRoiType.投影点位, point2Color, new HObject(point2));
                mRImage.ShowHRoi(point2Result);

                HTuple lineIdx = HTuple.TupleGenSequence(len + 4, num, 3);
                HOperatorSet.SelectObj(distanceLL_Info.hObjAssem, out verLine, lineIdx);
                HRoi linesResult = new HRoi(ModInfo.Encode, ModInfo.Name, ModInfo.Remarks, HRoiType.输出直线, resultColor, new HObject(verLine));
                mRImage.ShowHRoi(linesResult);
            }
        }

        #endregion

        #region 方法-数据相关

        /// <summary>
        /// 初始化输出变量
        /// </summary>
        public override void InitOutputInfo()
        {
            distanceLL_Info.distAssem = new HTuple();
            distanceLL_Info.hObjAssem = new HObject();
        }

        /// <summary>
        /// 如果数据内容是链接，则由GetLinkValue得到链接的值
        /// </summary>
        public void GetData()
        {
            try
            {
                beginRowL1 = Var.AcqValue_HTuple(strBeginRowL1, mSysVar, mSloVar);
                beginColL1 = Var.AcqValue_HTuple(strBeginColL1, mSysVar, mSloVar);
                endRowL1 = Var.AcqValue_HTuple(strEndRowL1, mSysVar, mSloVar);
                endColL1 = Var.AcqValue_HTuple(strEndColL1, mSysVar, mSloVar);
                beginRowL2 = Var.AcqValue_HTuple(strBeginRowL2, mSysVar, mSloVar);
                beginColL2 = Var.AcqValue_HTuple(strBeginColL2, mSysVar, mSloVar);
                endRowL2 = Var.AcqValue_HTuple(strEndRowL2, mSysVar, mSloVar);
                endColL2 = Var.AcqValue_HTuple(strEndColL2, mSysVar, mSloVar);
            }
            catch { }
        }

        #endregion

        #region 方法-算法相关

        /// <summary>
        /// 计算线线距离
        /// </summary>
        public void CalcDistLL(bool isUsePixelPrec, double pixelPrec, HTuple beginRowL1, HTuple beginColL1, HTuple endRowL1, HTuple endColL1, HTuple beginRowL2, HTuple beginColL2, HTuple endRowL2, HTuple endColL2, HTuple pointSize, out HObject hObjAssem, out HTuple distAssem)
        {
            hObjAssem = new HObject();
            distAssem = new HTuple();

            for (int i = 0; i < beginRowL1.Length; i++)
            {
                HTuple dist1 = new HTuple();
                HTuple dist2 = new HTuple();
                HTuple dist3 = new HTuple();
                HTuple distResult = new HTuple();
                HTuple pointR = new HTuple();
                HTuple pointC = new HTuple();
                HTuple projR = new HTuple();
                HTuple projC = new HTuple();
                HObject line1 = new HObject();
                HObject line2 = new HObject();
                HObject point = new HObject();
                HObject verLine = new HObject();

                HOperatorSet.DistancePl(beginRowL1.TupleSelect(i), beginColL1.TupleSelect(i), beginRowL2, beginColL2, endRowL2, endColL2, out dist1);
                HOperatorSet.DistancePl((beginRowL1.TupleSelect(i) + endRowL1.TupleSelect(i)) / 2, (beginColL1.TupleSelect(i) + endColL1.TupleSelect(i)) / 2, beginRowL2, beginColL2, endRowL2, endColL2, out dist2);
                HOperatorSet.DistancePl(endRowL1.TupleSelect(i), endColL1.TupleSelect(i), beginRowL2, beginColL2, endRowL2, endColL2, out dist3);

                switch (valueMode)
                {
                    case ValueMode.最大值:
                        if (dist1 >= dist3)
                        {
                            distResult = dist1;
                            pointR = beginRowL1.TupleSelect(i);
                            pointC = beginColL1.TupleSelect(i);
                        }
                        else
                        {
                            distResult = dist3;
                            pointR = endRowL1.TupleSelect(i);
                            pointC = endColL1.TupleSelect(i);
                        }
                        break;
                    case ValueMode.平均值:
                        distResult = dist2;
                        pointR = (beginRowL1.TupleSelect(i) + endRowL1.TupleSelect(i)) / 2;
                        pointC = (beginColL1.TupleSelect(i) + endColL1.TupleSelect(i)) / 2;
                        break;
                    case ValueMode.最小值:
                        if (dist1 >= dist3)
                        {
                            distResult = dist3;
                            pointR = endRowL1.TupleSelect(i);
                            pointC = endColL1.TupleSelect(i);
                        }
                        else
                        {
                            distResult = dist1;
                            pointR = beginRowL1.TupleSelect(i);
                            pointC = beginColL1.TupleSelect(i);
                        }
                        break;
                }

                distAssem.Append(distResult);

                HOperatorSet.GenContourPolygonXld(out line1, beginRowL1.TupleSelect(i).TupleConcat(endRowL1.TupleSelect(i)), beginColL1.TupleSelect(i).TupleConcat(endColL1.TupleSelect(i)));
                HOperatorSet.GenContourPolygonXld(out line2, beginRowL2.TupleConcat(endRowL2), beginColL2.TupleConcat(endColL2));
                HOperatorSet.ProjectionPl(pointR, pointC, beginRowL2, beginColL2, endRowL2, endColL2, out projR, out projC);
                HOperatorSet.GenCrossContourXld(out point, pointR.TupleConcat(projR), pointC.TupleConcat(projC), pointSize, 0.785398);
                HOperatorSet.GenContourPolygonXld(out verLine, pointR.TupleConcat(projR), pointC.TupleConcat(projC));

                if (!hObjAssem.IsInitialized())
                {
                    HOperatorSet.ConcatObj(line1, line2, out hObjAssem);
                    HOperatorSet.ConcatObj(hObjAssem, point, out hObjAssem);
                    HOperatorSet.ConcatObj(hObjAssem, verLine, out hObjAssem);
                }
                else
                {
                    HOperatorSet.ConcatObj(hObjAssem, line1, out hObjAssem);
                    HOperatorSet.ConcatObj(hObjAssem, line2, out hObjAssem);
                    HOperatorSet.ConcatObj(hObjAssem, point, out hObjAssem);
                    HOperatorSet.ConcatObj(hObjAssem, verLine, out hObjAssem);
                }
            }

            if (isUsePixelPrec)
            {
                distAssem = distAssem * pixelPrec;
            }
        }

        #endregion
    }
}
