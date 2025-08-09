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

namespace Plugin.DistancePP
{
    [Category("几何测量")]
    [DisplayName("点点距离")]
    [Serializable]
    public class DistancePPObj : ObjBase
    {
        #region 字段、属性

        /// <summary>
        /// 图像名称
        /// </summary>
        public string mImages = "";

        /// <summary>
        /// 信息输出
        /// </summary>
        public DistancePP_Info distancePP_Info = new DistancePP_Info();

        /// <summary>
        /// 点1Row坐标
        /// </summary>
        [NonSerialized]
        public HTuple point1Row = new HTuple();

        /// <summary>
        /// 点1Column坐标
        /// </summary>
        [NonSerialized]
        public HTuple point1Col = new HTuple();

        /// <summary>
        /// 点2Row坐标
        /// </summary>
        [NonSerialized]
        public HTuple point2Row = new HTuple();

        /// <summary>
        /// 点2Column坐标
        /// </summary>
        [NonSerialized]
        public HTuple point2Col = new HTuple();

        /// <summary>
        /// 点位大小
        /// </summary>
        public int pointSize = 50;

        /// <summary>
        /// 点位1颜色
        /// </summary>
        public string point1Color = "#66FFFF";

        /// <summary>
        /// 点位2颜色
        /// </summary>
        public string point2Color = "#FFFF00";

        /// <summary>
        /// 中间变量
        /// </summary>
        public string strPoint1Row = "100", strPoint1Col = "100", strPoint2Row = "200", strPoint2Col = "600";

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
                CalcDistPL(isUsePixelPrec, mRImage.PixelPrec, point1Row, point1Col, point2Row, point2Col, pointSize, out hObjAssem, out distAssem);

                //状态更新
                exeResult = "执行成功";

                //更新数据
                distancePP_Info.distAssem = distAssem;
                distancePP_Info.hObjAssem = hObjAssem;

                //主界面窗体显示
                WindowShowROI();

                //保存对象
                SetVarList(ref mSloVar, new DataCell(ModInfo.Name, ModInfo.Encode, DataType.单量, DataMode.点点距离, ConstVar.DistancePP, ModInfo.Plugin, "0", 1, distancePP_Info, DataAtrr.全局变量));

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
            new DistancePPForm((DistancePPObj)baseMod).ShowDialog();
        }

        /// <summary>
        /// 在主窗体的图像窗口显示区域
        /// </summary>
        public void WindowShowROI()
        {
            if (isShowData)
            {
                HText text;
                string strInfo = TypeConvert.HTupleToString(distancePP_Info.distAssem);
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
                HObject point1 = new HObject();
                HObject point2 = new HObject();
                HObject line = new HObject();

                int num = distancePP_Info.hObjAssem.CountObj();
                HTuple point1Idx = HTuple.TupleGenSequence(2, (num - 1) / 2 + 1, 1);
                HOperatorSet.SelectObj(distancePP_Info.hObjAssem, out point1, point1Idx);
                HRoi point1Result = new HRoi(ModInfo.Encode, ModInfo.Name, ModInfo.Remarks, HRoiType.输入点位, point1Color, new HObject(point1));
                mRImage.ShowHRoi(point1Result);

                HOperatorSet.SelectObj(distancePP_Info.hObjAssem, out point2, 1);
                HRoi point2Result = new HRoi(ModInfo.Encode, ModInfo.Name, ModInfo.Remarks, HRoiType.目标点位, point2Color, new HObject(point2));
                mRImage.ShowHRoi(point2Result);

                HTuple lineIdx = HTuple.TupleGenSequence((num - 1) / 2 + 1, num, 1);
                HOperatorSet.SelectObj(distancePP_Info.hObjAssem, out line, lineIdx);
                HRoi linesResult = new HRoi(ModInfo.Encode, ModInfo.Name, ModInfo.Remarks, HRoiType.输出直线, resultColor, new HObject(line));
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
            distancePP_Info.distAssem = new HTuple();
            distancePP_Info.hObjAssem = new HObject();
        }

        /// <summary>
        /// 如果数据内容是链接，则由GetLinkValue得到链接的值
        /// </summary>
        public void GetData()
        {
            try
            {
                point1Row = Var.AcqValue_HTuple(strPoint1Row, mSysVar, mSloVar);
                point1Col = Var.AcqValue_HTuple(strPoint1Col, mSysVar, mSloVar);
                point2Row = Var.AcqValue_HTuple(strPoint2Row, mSysVar, mSloVar);
                point2Col = Var.AcqValue_HTuple(strPoint2Col, mSysVar, mSloVar);
            }
            catch { }
        }

        #endregion

        #region 方法-算法相关

        /// <summary>
        /// 计算点线距离
        /// </summary>
        public void CalcDistPL(bool isUsePixelPrec, double pixelPrec, HTuple point1Row, HTuple point1Col, HTuple point2Row, HTuple point2Col, HTuple pointSize, out HObject hObjAssem, out HTuple distAssem)
        {
            HObject point1 = new HObject();
            HObject point2 = new HObject();
            HObject line = new HObject();

            hObjAssem = new HObject();
            distAssem = new HTuple();

            for (int i = 0; i < point1Row.Length; i++)
            {
                HTuple dist = new HTuple();
                HOperatorSet.DistancePp(point1Row.TupleSelect(i), point1Col.TupleSelect(i), point2Row, point2Col, out dist);
                distAssem.Append(dist);
            }

            if (isUsePixelPrec)
            {
                distAssem = distAssem * pixelPrec;
            }

            HOperatorSet.GenCrossContourXld(out point1, point1Row, point1Col, pointSize, 0.785398);
            HOperatorSet.GenCrossContourXld(out point2, point2Row, point2Col, pointSize, 0.785398);

            for (int i = 0; i < point1Row.Length; i++)
            {
                HObject linePP = new HObject();
                HOperatorSet.GenContourPolygonXld(out linePP, point1Row.TupleSelect(i).TupleConcat(point2Row), point1Col.TupleSelect(i).TupleConcat(point2Col));

                if (!line.IsInitialized())
                {
                    line = linePP;
                }
                else
                {
                    HOperatorSet.ConcatObj(line, linePP, out line);
                }
            }

            HOperatorSet.ConcatObj(point2, point1, out hObjAssem);
            HOperatorSet.ConcatObj(hObjAssem, line, out hObjAssem);
        }

        #endregion
    }
}
