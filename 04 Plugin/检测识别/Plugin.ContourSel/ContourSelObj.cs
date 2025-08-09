using HalconDotNet;
using MutualTools;
using Plugin.CreateROI;
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

namespace Plugin.ContourSel
{
    [Category("检测识别")]
    [DisplayName("轮廓筛选")]
    [Serializable]
    public class ContourSelObj : ObjBase
    {
        #region 字段、属性

        /// <summary>
        /// 图像名称
        /// </summary>
        public string mImages = "";

        /// <summary>
        /// 信息输出
        /// </summary>
        public ContourSel_Info contourSel_Info = new ContourSel_Info();

        /// <summary>
        /// 输入轮廓
        /// </summary>
        [NonSerialized]
        public HObject inputContour;

        /// <summary>
        /// 筛选特征
        /// </summary>
        public string feature = "rect2_len1";

        /// <summary>
        /// 特征下限
        /// </summary>
        public double min = 50.0;

        /// <summary>
        /// 特征上限
        /// </summary>
        public double max = 200.0;

        /// <summary>
        /// 中间值
        /// </summary>
        public string strInputContour = "";

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
                HObject outContour = new HObject();

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
                HOperatorSet.SelectShapeXld(inputContour, out outContour, feature, "and", min, max);

                //状态更新
                exeResult = "执行成功";

                //更新数据
                contourSel_Info.contourObj = outContour;
                contourSel_Info.contourNum = outContour.CountObj();

                //主界面窗体显示
                WindowShowROI();

                //保存对象
                SetVarList(ref mSloVar, new DataCell(ModInfo.Name, ModInfo.Encode, DataType.单量, DataMode.轮廓筛选, ConstVar.ContourSel, ModInfo.Plugin, "0", 1, contourSel_Info, DataAtrr.全局变量));

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
            new ContourSelForm((ContourSelObj)baseMod).ShowDialog();
        }

        /// <summary>
        /// 在主窗体的图像窗口显示区域
        /// </summary>
        public void WindowShowROI()
        {
            if (isShowReg)
            {
                HRoi linesResult = new HRoi(ModInfo.Encode, ModInfo.Name, ModInfo.Remarks, HRoiType.输出直线, resultColor, new HObject(contourSel_Info.contourObj));
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
            contourSel_Info.contourNum = new HTuple();
            contourSel_Info.contourObj = new HObject();
        }

        /// <summary>
        /// 如果数据内容是链接，则由GetLinkValue得到链接的值
        /// </summary>
        public void GetData()
        {
            try
            {
                try
                {
                    inputContour = Var.AcqValue_HObject(strInputContour, mSysVar, mSloVar);
                }
                catch { }
            }
            catch { }
        }

        #endregion
    }
}
