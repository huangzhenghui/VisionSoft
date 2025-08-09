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

namespace Plugin.PartRectangle
{
    [Category("检测识别")]
    [DisplayName("等分矩形")]
    [Serializable]
    public class PartRectangleObj : ObjBase
    {
        #region 字段、属性

        /// <summary>
        /// 图像名称
        /// </summary>
        public string mImages = "";

        /// <summary>
        /// 信息输出
        /// </summary>
        public PartRectangle_Info partRectangle_Info = new PartRectangle_Info();

        /// <summary>
        /// 矩形宽度
        /// </summary>
        public int width = 15;

        /// <summary>
        /// 矩形高度
        /// </summary>
        public int height = 30;

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
        public bool isShowResult = true;

        /// <summary>
        /// 显示形态
        /// </summary>
        public string showDraw = "margin";


        /// <summary>
        /// 结果颜色
        /// </summary>
        public string resultColor = "#00FF00";

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
                HOperatorSet.PartitionRectangle(inputReg, out outReg, width, height);

                //输出数据更新
                partRectangle_Info.resultReg = outReg;

                //主界面窗体显示
                WindowShowHObj();

                //保存对象
                SetVarList(ref mSloVar, new DataCell(ModInfo.Name, ModInfo.Encode, DataType.单量, DataMode.等分矩形, ConstVar.PartRectangle, ModInfo.Plugin, "0", 1, partRectangle_Info, DataAtrr.全局变量));

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
            new PartRectangleForm((PartRectangleObj)baseMod).ShowDialog();
        }

        /// <summary>
        /// 在主窗体的图像窗口显示HObject对象
        /// </summary>
        public void WindowShowHObj()
        {
            if (mRImage != null)
            {
                if (isShowResult)
                {
                    HRoi roiResult = new HRoi(ModInfo.Encode, ModInfo.Name, ModInfo.Remarks, HRoiType.检测结果, resultColor, new HObject(partRectangle_Info.resultReg));
                    mRImage.ShowHRoi(roiResult);
                }
            }
        }

        #endregion
    }
}
