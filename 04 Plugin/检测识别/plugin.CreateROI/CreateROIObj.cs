using HalconDotNet;
using System;
using System.ComponentModel;
using System.Runtime.Serialization;
using VisionCore;


using RexConst;
using RexView;
using System.Collections.Generic;
using System.Linq;
using System.Drawing;
using MutualTools;

namespace Plugin.CreateROI
{
    [Category("检测识别")]
    [DisplayName("创建区域")]
    [Serializable]
    public class CreateROIObj : ObjBase
    {
        #region 字段、属性

        /// <summary>
        /// 图像名称
        /// </summary>
        public string mImages = "";

        /// <summary>
        /// 信息输出
        /// </summary>
        public CreateROI_Info createROI_Info = new CreateROI_Info();

        /// <summary>
        /// 区域形状
        /// </summary>
        public ROIType mROIType = ROIType.Rectangle2;

        /// <summary>
        /// 中心点Row坐标
        /// </summary>
        [NonSerialized]
        public HTuple centerRow = new HTuple();

        /// <summary>
        /// 中心点Col坐标
        /// </summary>
        [NonSerialized]
        public HTuple centerCol = new HTuple();

        /// <summary>
        /// 矩形角度
        /// </summary>
        [NonSerialized]
        public HTuple phi = new HTuple();

        /// <summary>
        /// 长半轴
        /// </summary>
        [NonSerialized]
        public HTuple length1 = new HTuple();

        /// <summary>
        /// 短半轴
        /// </summary>
        [NonSerialized]
        public HTuple length2 = new HTuple();

        /// <summary>
        /// 圆半径
        /// </summary>
        [NonSerialized]
        public HTuple radius = new HTuple();

        /// <summary>
        /// 编辑状态下ROI颜色
        /// </summary>
        public string ROIEditColor = "#00FF00";

        /// <summary>
        /// 结果区域克隆
        /// </summary>
        public static HObject regCopy = new HObject();

        //中间变量
        public string strCenterRow = "400", strCenterCol = "400", strPhi = "0", strLength1 = "120", strLength2 = "60", strRadius = "100";

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
                //变量声明
                HObject region = new HObject();

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
                switch (mROIType)
                {
                    case ROIType.Rectangle2:
                        HOperatorSet.GenRectangle2(out region, centerRow, centerCol, phi.TupleRad(), length1, length2);
                        break;
                    case ROIType.Circle:
                        HOperatorSet.GenCircle(out region, centerRow, centerCol, radius);
                        break;
                }

                //更新数据
                createROI_Info.regionObj = region;
                regCopy = region.Clone();

                //主界面窗体显示
                WindowShowROI();

                //保存对象
                SetVarList(ref mSloVar, new DataCell(ModInfo.Name, ModInfo.Encode, DataType.单量, DataMode.创建区域, ConstVar.CreateROI, ModInfo.Plugin, "0", 1, createROI_Info, DataAtrr.全局变量));
                     
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

        #region 方法-数据相关

        /// <summary>
        /// 初始化输出变量
        /// </summary>
        public override void InitOutputInfo()
        {
            createROI_Info.regionObj = new HObject();
        }

        /// <summary>
        /// 如果数据内容是链接，则由GetLinkValue得到链接的值
        /// </summary>
        public void GetData()
        {
            try
            {
                centerRow = Var.AcqValue_HTuple(strCenterRow, mSysVar, mSloVar);
                centerCol = Var.AcqValue_HTuple(strCenterCol, mSysVar, mSloVar);
                phi = Var.AcqValue_HTuple(strPhi, mSysVar, mSloVar);
                length1 = Var.AcqValue_HTuple(strLength1, mSysVar, mSloVar);
                length2 = Var.AcqValue_HTuple(strLength2, mSysVar, mSloVar);
                radius = Var.AcqValue_HTuple(strRadius, mSysVar, mSloVar);
            }
            catch{ }
        }

        #endregion

        #region 方法-窗体相关

        /// <summary>
        /// 显示窗体
        /// </summary>
        /// <param name="baseMod"></param>
        public override void RunForm(ObjBase baseMod)
        {
          new CreateROIForm((CreateROIObj)baseMod).ShowDialog();
        }

        /// <summary>
        /// 在主窗体的图像窗口显示HObject对象
        /// </summary>
        public void WindowShowROI()
        {
            if (isShowReg)
            {
                switch (mROIType)
                {
                    case ROIType.Rectangle2:
                        HObject rect2;
                        HOperatorSet.GenRectangle2(out rect2, centerRow, centerCol, phi.TupleRad(), length1, length2);
                        HRoi Rect2ROI = new HRoi(ModInfo.Encode, ModInfo.Name, ModInfo.Remarks, HRoiType.检测范围, resultColor, new HObject(rect2));
                        mRImage.ShowHRoi(Rect2ROI);
                        break;
                    case ROIType.Circle:
                        HObject circle;
                        HOperatorSet.GenCircle(out circle, centerRow, centerCol, radius);
                        HRoi CircleROI = new HRoi(ModInfo.Encode, ModInfo.Name, ModInfo.Remarks, HRoiType.检测范围, resultColor, new HObject(circle));
                        mRImage.ShowHRoi(CircleROI);
                        break;
                }
            }
        }

        #endregion
    }
}
