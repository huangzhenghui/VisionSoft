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

namespace Plugin.ShapeTrans
{
    [Category("检测识别")]
    [DisplayName("形状转换")]
    [Serializable]
    public class ShapeTransObj : ObjBase
    {
        #region 字段、属性

        /// <summary>
        /// 图像名称
        /// </summary>
        public string mImages = "";

        /// <summary>
        /// 信息输出
        /// </summary>
        public ShapeTrans_Info shapeTrans_Info = new ShapeTrans_Info();

        /// <summary>
        /// 转换类型
        /// </summary>
        public string transType = "convex";

        /// <summary>
        /// 输入区域对象
        /// </summary>
        public HObject inputReg = new HObject();

        /// <summary>
        /// 输入区域名称
        /// </summary>
        public string inputRegName = "";

        /// <summary>
        /// 是否显示结果
        /// </summary>
        public bool isShowReg = true;

        /// <summary>
        /// 显示形态
        /// </summary>
        public string showDraw = "margin";

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
                HObject outReg = new HObject();

                //设置可绘制区域的大小
                HOperatorSet.SetSystem("width", 20000);
                HOperatorSet.SetSystem("height", 20000);

                GetData();

                //执行算法
                HOperatorSet.ShapeTrans(inputReg, out outReg, transType);

                //输出数据更新
                shapeTrans_Info.resultReg = outReg;

                //主界面窗体显示
                WindowShowHObj();

                //保存对象
                SetVarList(ref mSloVar, new DataCell(ModInfo.Name, ModInfo.Encode, DataType.单量, DataMode.形状转换, ConstVar.ShapeTrans, ModInfo.Plugin, "0", 1, shapeTrans_Info, DataAtrr.全局变量));

                Log.Info(Sol.mSol.mProjList[ModInfo.Index].mProjInfo.Name + ": " + ModInfo.Name + ":" + "执行成功");
                ModInfo.State = ModState.OK;
                return true;
            }
            catch (Exception ex)
            {
                Log.Info(Sol.mSol.mProjList[ModInfo.Index].mProjInfo.Name + ": " + ModInfo.Name + ":" + ex.Message);
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
            if (mImages.Contains(":"))
            {
                mRImage = (RImage)Var.GetImage(mSloVar, mImages);
            }

            if (inputRegName.Contains(":"))
            {
                inputReg = (HObject)Var.GetLinkValue(mSysVar, mSloVar, inputRegName);
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
            new ShapeTransForm((ShapeTransObj)baseMod).ShowDialog();
        }

        /// <summary>
        /// 在主窗体的图像窗口显示HObject对象
        /// </summary>
        public void WindowShowHObj()
        {
            if (mRImage != null)
            {
                if (isShowReg)
                {
                    HRoi roiResult = new HRoi(ModInfo.Encode, ModInfo.Name, ModInfo.Remarks, HRoiType.检测结果, resultColor, new HObject(shapeTrans_Info.resultReg));
                    mRImage.ShowHRoi(roiResult);
                }
            }
        }

        #endregion
    }
}
