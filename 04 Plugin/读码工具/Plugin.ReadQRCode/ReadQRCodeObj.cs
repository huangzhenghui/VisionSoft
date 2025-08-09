using HalconDotNet;
using Plugin.CreateROI;
using Rex.UI;
using RexConst;
using RexView;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using VisionCore;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Plugin.ReadQRCode
{
    [Category("读码工具")]
    [DisplayName("读二维码")]
    [Serializable]
    public class ReadQRCodeObj : ObjBase
    {
        #region 字段、属性

        /// <summary>
        /// 图像名称
        /// </summary>
        public string mImages = "";

        /// <summary>
        /// 信息输出
        /// </summary>
        public ReadQRCode_Info readQRCode_Info = new ReadQRCode_Info();

        /// <summary>
        /// 读码模式
        /// </summary>
        public string mode = "maximum_recognition";

        /// <summary>
        /// 读码类型
        /// </summary>
        public string codeType = "QR Code";

        /// <summary>
        /// 极性
        /// </summary>
        public string polarity = "any";

        /// <summary>
        /// 稳定性
        /// </summary>
        public string robustness = "high";

        /// <summary>
        /// 超时时长
        /// </summary>
        public double timeOut = 1000;

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
                HTuple hData = new HTuple();
                HObject hImg;
                HObject hReg;
                HOperatorSet.GenEmptyObj(out hImg);
                HOperatorSet.GenEmptyObj(out hReg);

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
                HOperatorSet.Rgb1ToGray(mRImage, out hImg);

                //执行算法
                ReadQRCode(hImg, out hReg, mode, codeType, polarity, robustness, timeOut, out hData);

                //更新数据
                readQRCode_Info.qrCodeData = hData;
                readQRCode_Info.qrCodeReg = hReg;

                //主界面窗体显示
                WindowShowROI();

                //保存对象
                SetVarList(ref mSloVar, new DataCell(ModInfo.Name, ModInfo.Encode, DataType.单量, DataMode.读二维码, ConstVar.ReadQRCode, ModInfo.Plugin, "0", 1, readQRCode_Info, DataAtrr.全局变量));

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

        #region 方法-窗体相关

        /// <summary>
        /// 显示窗体
        /// </summary>
        /// <param name="baseMod"></param>
        public override void RunForm(ObjBase baseMod)
        {
            new ReadQRCodeForm((ReadQRCodeObj)baseMod).ShowDialog();
        }

        /// <summary>
        /// 在主窗体的图像窗口显示区域/轮廓/信息等
        /// </summary>
        public void WindowShowROI()
        {
            if (mRImage != null)
            {
                if (isShowReg)
                {
                    HRoi roiResult = new HRoi(ModInfo.Encode, ModInfo.Name, ModInfo.Remarks, HRoiType.检测结果, resultColor, new HObject(readQRCode_Info.qrCodeReg));
                    mRImage.ShowHRoi(roiResult);
                }

                if (isShowData)
                {
                    HText text;
                    if (prefix != "")
                    {
                        text = new HText(ModInfo.Encode, ModInfo.Name, ModInfo.Remarks, HRoiType.文字显示, resultColor, prefix + ":" + readQRCode_Info.qrCodeData, fontType, Y, X, fontSize, mRImage, false);
                    }
                    else
                    {
                        text = new HText(ModInfo.Encode, ModInfo.Name, ModInfo.Remarks, HRoiType.文字显示, resultColor, readQRCode_Info.qrCodeData, fontType, Y, X, fontSize, mRImage, false);
                    }
                    mRImage.ShowHText(text);
                }
            }
        }

        #endregion

        #region 方法-数据相关

        /// <summary>
        /// 如果数据内容是链接，则由GetLinkValue得到链接的值
        /// </summary>
        public void GetData(){ }

        #endregion

        #region 方法-算法相关

        public void ReadQRCode(HObject ho_Image, out HObject ho_SymbolXLDs, HTuple hv_Mode,HTuple hv_Codetype, HTuple hv_Polarity, HTuple hv_Robustness, HTuple hv_TimeOut, out HTuple hv_DecodedDataStrings)
        {
            HTuple hv_DataCodeHandle = new HTuple(), hv_ResultHandles = new HTuple();
            HOperatorSet.GenEmptyObj(out ho_SymbolXLDs);
            hv_DecodedDataStrings = new HTuple();
            hv_DataCodeHandle.Dispose();

            HOperatorSet.CreateDataCode2dModel(hv_Codetype, new HTuple(), new HTuple(), out hv_DataCodeHandle);
            HOperatorSet.SetDataCode2dParam(hv_DataCodeHandle, "default_parameters", hv_Mode);
            HOperatorSet.SetDataCode2dParam(hv_DataCodeHandle, "polarity", hv_Polarity);
            HOperatorSet.SetDataCode2dParam(hv_DataCodeHandle, "small_modules_robustness", hv_Robustness);
            HOperatorSet.SetDataCode2dParam(hv_DataCodeHandle, "timeout", hv_TimeOut);
            ho_SymbolXLDs.Dispose(); hv_ResultHandles.Dispose(); hv_DecodedDataStrings.Dispose();
            HOperatorSet.FindDataCode2d(ho_Image, out ho_SymbolXLDs, hv_DataCodeHandle, new HTuple(), new HTuple(), out hv_ResultHandles, out hv_DecodedDataStrings);
            HOperatorSet.ClearDataCode2dModel(hv_DataCodeHandle);

            hv_DataCodeHandle.Dispose();
            hv_ResultHandles.Dispose();
        }

        #endregion
    }
}
