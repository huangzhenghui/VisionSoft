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

namespace Plugin.FitCircle
{
    [Category("几何测量")]
    [DisplayName("拟合圆弧")]
    [Serializable]
    public class FitCircleObj : ObjBase
    {
        #region 字段、属性

        /// <summary>
        /// 图像名称
        /// </summary>
        public string mImages = "";

        /// <summary>
        /// 信息输出
        /// </summary>
        public FitCircle_Info fitCircle_Info = new FitCircle_Info();

        /// <summary>
        /// 点Row坐标
        /// </summary>
        [NonSerialized]
        public HTuple pointRow = new HTuple();

        /// <summary>
        /// 点Column坐标
        /// </summary>
        [NonSerialized]
        public HTuple pointCol = new HTuple();

        /// <summary>
        /// 绘制圆模式
        /// </summary>
        public DrawCircleMode drawCircleMode = DrawCircleMode.圆;

        /// <summary>
        /// 点位大小
        /// </summary>
        public int pointSize = 50;

        /// <summary>
        /// 点位颜色
        /// </summary>
        public string pointColor = "#66FFFF";

        /// <summary>
        /// 中间变量
        /// </summary>
        public string strPointRow = "100", strPointCol = "100";

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
                FitCircle(isUsePixelPrec, mRImage.PixelPrec, pointRow, pointCol, out HObject circle, out HTuple midR, out HTuple midC, out HTuple radius);

                //状态更新
                exeResult = "执行成功";

                //更新数据
                fitCircle_Info.circleCenterRow = midR;
                fitCircle_Info.circleCenterCol = midC;
                fitCircle_Info.circleRadius = radius;
                fitCircle_Info.circleObj = circle;

                //主界面窗体显示
                WindowShowROI();

                //保存对象
                SetVarList(ref mSloVar, new DataCell(ModInfo.Name, ModInfo.Encode, DataType.单量, DataMode.拟合圆弧, ConstVar.DistancePP, ModInfo.Plugin, "0", 1, fitCircle_Info, DataAtrr.全局变量));

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
            new FitCircleForm((FitCircleObj)baseMod).ShowDialog();
        }

        /// <summary>
        /// 在主窗体的图像窗口显示区域
        /// </summary>
        public void WindowShowROI()
        {
            if (isShowData)
            {
                HText text;
                string strInfo = TypeConvert.HTupleToString(fitCircle_Info.circleCenterRow.TupleConcat(fitCircle_Info.circleCenterCol).TupleConcat(fitCircle_Info.circleRadius));
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
                HRoi circleResult = new HRoi(ModInfo.Encode, ModInfo.Name, ModInfo.Remarks, HRoiType.输出圆, resultColor, new HObject(fitCircle_Info.circleObj));
                mRImage.ShowHRoi(circleResult);
            }
        }

        #endregion

        #region 方法-数据相关

        /// <summary>
        /// 初始化输出变量
        /// </summary>
        public override void InitOutputInfo()
        {
            fitCircle_Info.circleCenterRow = new HTuple();
            fitCircle_Info.circleCenterCol = new HTuple();
            fitCircle_Info.circleRadius = new HTuple();
            fitCircle_Info.circleObj = new HObject();
        }

        /// <summary>
        /// 如果数据内容是链接，则由GetLinkValue得到链接的值
        /// </summary>
        public void GetData()
        {
            try
            {
                pointRow = Var.AcqValue_HTuple(strPointRow, mSysVar, mSloVar);
                pointCol = Var.AcqValue_HTuple(strPointCol, mSysVar, mSloVar);
            }
            catch { }
        }

        #endregion

        #region 方法-算法相关

        /// <summary>
        /// 拟合圆
        /// </summary>
        /// <param name="isUsePixelPrec"></param>
        /// <param name="pixelPrec"></param>
        /// <param name="pointRow"></param>
        /// <param name="pointCol"></param>
        /// <param name="circle"></param>
        /// <param name="midR"></param>
        /// <param name="midC"></param>
        /// <param name="radius"></param>
        public void FitCircle(bool isUsePixelPrec, double pixelPrec, HTuple pointRow, HTuple pointCol, out HObject circle, out HTuple midR, out HTuple midC, out HTuple radius)
        {
            midR = new HTuple();
            midC = new HTuple();
            radius = new HTuple();
            circle = new HObject();

            HTuple startA = new HTuple();
            HTuple endA = new HTuple();
            HObject contour = new HObject();
            HTuple pointOrder = new HTuple();

            //设置可绘制区域的大小
            HOperatorSet.SetSystem("width", 20000);
            HOperatorSet.SetSystem("height", 20000);

            HOperatorSet.GenContourPolygonXld(out contour, pointRow, pointCol);
            HOperatorSet.FitCircleContourXld(contour, "geotukey", -1, 0, 0, 3, 2, out midR, out midC, out radius, out startA, out endA, out pointOrder);

            switch (drawCircleMode)
            {
                case DrawCircleMode.圆弧:
                    HOperatorSet.GenCircleContourXld(out circle, midR, midC, radius, startA, endA, pointOrder, 1);
                    break;
                case DrawCircleMode.圆:
                    HOperatorSet.GenCircleContourXld(out circle, midR, midC, radius, 0, 2 * Math.PI, "positive", 1);
                    break;
            }

            if (isUsePixelPrec)
            {
                radius = radius * pixelPrec;
            }
        }

        #endregion
    }
}
