using HalconDotNet;
using Plugin.CreateROI;
using Rex.UI;
using RexConst;
using RexControl;
using RexView;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing.Printing;
using System.Linq;
using System.Reflection;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.XPath;
using VisionCore;

namespace Plugin.ProcessReg
{
    [Category("检测识别")]
    [DisplayName("区域运算")]
    [Serializable]
    public class OperateRegObj : ObjBase
    {
        #region 字段、属性

        /// <summary>
        /// 图像名称
        /// </summary>
        public string mImages = "";

        /// <summary>
        /// 区域筛选类
        /// </summary>
        public OperateReg_Info operateReg_Info = new OperateReg_Info();

        /// <summary>
        /// 运算方式
        /// </summary>
        public string operateMode = "求差";

        /// <summary>
        /// 输入区域1对象
        /// </summary>
        public HObject inputReg1;

        /// <summary>
        /// 输入区域1名称
        /// </summary>
        public string inputReg1Name;

        /// <summary>
        /// 输入区域2对象
        /// </summary>
        public HObject inputReg2;

        /// <summary>
        /// 输入区域2名称
        /// </summary>
        public string inputReg2Name;

        /// <summary>
        /// 输入区域对象
        /// </summary>
        public HObject inputReg;

        /// <summary>
        /// 输入区域名称
        /// </summary>
        public string inputRegName;

        /// <summary>
        /// 是否显示HObject对象
        /// </summary>
        public bool isShowHObj = true;

        /// <summary>
        /// 显示形态
        /// </summary>
        public string showDraw = "margin";

        /// <summary>
        /// 显示颜色
        /// </summary>
        public string showColor = "#00FF00";

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
                HTuple regionNum = new HTuple();
                InitOutput();

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

                GetData();

                //执行算法
                switch (operateMode)
                {
                    case "求差":
                        HOperatorSet.Difference(inputReg1, inputReg2, out operateReg_Info.regionObj);
                        break;
                    case "求和(Two)":
                        HOperatorSet.Union2(inputReg1, inputReg2, out operateReg_Info.regionObj);
                        break;
                    case "求和(One)":
                        HOperatorSet.Union1(inputReg, out operateReg_Info.regionObj);
                        break;
                    case "交集":
                        HOperatorSet.Intersection(inputReg1, inputReg2, out operateReg_Info.regionObj);
                        break;
                    case "集合":
                        HOperatorSet.ConcatObj(inputReg1, inputReg2, out operateReg_Info.regionObj);
                        break;
                    default:
                        break;
                }

                //主界面窗体显示
                WindowShowHObj();

                //保存对象
                SetVarList(ref mSloVar, new DataCell(ModInfo.Name, ModInfo.Encode, DataType.单量, DataMode.区域运算, ConstVar.OperateReg, ModInfo.Plugin, "0", 1, operateReg_Info, DataAtrr.全局变量));

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
        /// 如果数据内容是链接，则由GetLinkValue得到链接的值
        /// </summary>
        public void GetData()
        {
            if (inputReg1Name.Contains(":"))
            {
                inputReg1 = (HObject)Var.GetLinkValue(mSysVar, mSloVar, inputReg1Name);
            }

            if (inputReg2Name.Contains(":"))
            {
                inputReg2 = (HObject)Var.GetLinkValue(mSysVar, mSloVar, inputReg2Name);
            }

            if (inputRegName.Contains(":"))
            {
                inputReg = (HObject)Var.GetLinkValue(mSysVar, mSloVar, inputRegName);
            }
        }

        /// <summary>
        /// 初始化模块输出对象的变量
        /// </summary>
        public void InitOutput()
        {
            HOperatorSet.GenEmptyObj(out operateReg_Info.regionObj);
        }

        #endregion

        #region 方法-窗体相关

        /// <summary>
        /// 显示窗体
        /// </summary>
        /// <param name="baseMod"></param>
        public override void RunForm(ObjBase baseMod)
        {
            new OperateRegForm((OperateRegObj)baseMod).ShowDialog();
        }

        /// <summary>
        /// 在主窗体的图像窗口显示HObject对象
        /// </summary>
        public void WindowShowHObj()
        {
            if (isShowHObj)
            {
                HRoi resultRegion = new HRoi(ModInfo.Encode, ModInfo.Name, ModInfo.Remarks, HRoiType.检测结果, showColor, operateReg_Info.regionObj);
                mRImage.ShowHRoi(resultRegion);
            }
        }

        #endregion
    }
}
