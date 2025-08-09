using HalconDotNet;
using Plugin.CreateROI;
using Rex.UI;
using RexConst;
using RexControl;
using RexForm;
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

namespace Plugin.GrayInfo
{
    [Category("检测识别")]
    [DisplayName("灰度信息")]
    [Serializable]
    public class GrayInfoObj : ObjBase
    {
        #region 字段、属性

        /// <summary>
        /// 图像名称
        /// </summary>
        public string mImages = "";

        /// <summary>
        /// 信息输出
        /// </summary>
        public GrayInfo_Info grayInfo_Info = new GrayInfo_Info();

        /// <summary>
        /// 输入区域对象
        /// </summary>
        public HObject inputReg = new HObject();

        /// <summary>
        /// 输入区域名称
        /// </summary>
        public string inputRegName = "";

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
                HTuple grayMean = new HTuple();
                HTuple grayDeviation = new HTuple();

                //设置可绘制区域的大小
                HOperatorSet.SetSystem("width", 20000);
                HOperatorSet.SetSystem("height", 20000);

                GetData();

                //执行算法
                HOperatorSet.Intensity(inputReg, mRImage, out grayMean, out grayDeviation);

                //输出数据更新
                grayInfo_Info.mean = grayMean;
                grayInfo_Info.deviation = grayDeviation;

                //主界面窗体显示
                WindowShowHObj();

                //保存对象
                SetVarList(ref mSloVar, new DataCell(ModInfo.Name, ModInfo.Encode, DataType.单量, DataMode.灰度信息, ConstVar.GrayInfo, ModInfo.Plugin, "0", 1, grayInfo_Info, DataAtrr.全局变量));

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
            new GrayInfoForm((GrayInfoObj)baseMod).ShowDialog();
        }

        /// <summary>
        /// 在主窗体的图像窗口显示HObject对象
        /// </summary>
        public void WindowShowHObj()
        {
            if (mRImage != null)
            {
                if (isShowData)
                {
                    string str1 = "", str2 = "", str = "";
                    HText text;

                    for (int i = 0; i < grayInfo_Info.mean.Length; i++)
                    {
                        if (i == 0)
                        {
                            str1 = "灰度均值" + ":" + grayInfo_Info.mean[i].D.ToString("F4");
                            str2 = "灰度方差" + ":" + grayInfo_Info.deviation[i].D.ToString("F4");
                        }
                        else
                        {
                            str1 = str1 + "," + grayInfo_Info.mean[i].D.ToString("F4");
                            str2 = str2 + "," + grayInfo_Info.deviation[i].D.ToString("F4");
                        }
                    }

                    str = str1 + "\n" + str2;
                    text = new HText(ModInfo.Encode, ModInfo.Name, ModInfo.Remarks, HRoiType.文字显示, resultColor, str, fontType, X, Y, fontSize, mRImage, false);
                    mRImage.ShowHText(text);
                }
            }
        }

        #endregion
    }
}
