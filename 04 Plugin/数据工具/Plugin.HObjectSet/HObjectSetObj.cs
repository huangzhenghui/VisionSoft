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

namespace Plugin.HObjectSet
{
    [Category("数据工具")]
    [DisplayName("对象集合")]
    [Serializable]
    public class HObjectSetObj : ObjBase
    {
        #region 字段、属性

        /// <summary>
        /// 图像名称
        /// </summary>
        public string mImages = "";

        /// <summary>
        /// 区域筛选类
        /// </summary>
        public HObjectSet_Info hObjectSet_Info = new HObjectSet_Info();

        /// <summary>
        /// 输入区域1对象
        /// </summary>
        public HObject inputReg1 = new HObject();

        /// <summary>
        /// 输入区域2对象
        /// </summary>
        public HObject inputReg2 = new HObject();

        /// <summary>
        /// 显示形态
        /// </summary>
        public string showDraw = "margin";

        /// <summary>
        /// 显示颜色
        /// </summary>
        public string showColor = "#00FF00";
        
        /// <summary>
        /// 中间值
        /// </summary>
        public string inputReg1Name = "", inputReg2Name = "";

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
                HObject hObjSet = new HObject();

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
                HOperatorSet.ConcatObj(inputReg1, inputReg2, out hObjSet);

                //数据更新
                hObjectSet_Info.hObjSet = hObjSet;

                //主界面窗体显示
                WindowShowHObj();

                //保存对象
                SetVarList(ref mSloVar, new DataCell(ModInfo.Name, ModInfo.Encode, DataType.单量, DataMode.对象集合, ConstVar.HObjectSet, ModInfo.Plugin, "0", 1, hObjectSet_Info, DataAtrr.全局变量));

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
        }

        #endregion

        #region 方法-窗体相关

        /// <summary>
        /// 显示窗体
        /// </summary>
        /// <param name="baseMod"></param>
        public override void RunForm(ObjBase baseMod)
        {
            new HObjectSetForm((HObjectSetObj)baseMod).ShowDialog();
        }

        /// <summary>
        /// 在主窗体的图像窗口显示HObject对象
        /// </summary>
        public void WindowShowHObj()
        {
            if (isShowReg)
            {
                HRoi resultRegion = new HRoi(ModInfo.Encode, ModInfo.Name, ModInfo.Remarks, HRoiType.检测结果, showColor, hObjectSet_Info.hObjSet);
                mRImage.ShowHRoi(resultRegion);
            }
        }

        #endregion
    }
}
