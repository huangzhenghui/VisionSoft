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

namespace Plugin.ReadBarcode
{
    [Category("读码工具")]
    [DisplayName("读一维码")]
    [Serializable]
    public class ReadBarcodeObj : ObjBase
    {
        #region 字段、属性

        /// <summary>
        /// 图像名称
        /// </summary>
        public string mImages = "";

        /// <summary>
        /// 信息输出
        /// </summary>
        public ReadBarcode_Info readBarcode_Info = new ReadBarcode_Info();

        /// <summary>
        /// 模块尺寸
        /// </summary>
        public double elementSizeMin = 1.5;

        /// <summary>
        /// 校验字符
        /// </summary>
        public string checkChar = "present";

        /// <summary>
        /// 对比阈值
        /// </summary>
        public double contrastMin = 25;

        /// <summary>
        /// 读码数目
        /// </summary>
        public int resultNum = 2;

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

                //执行算法
                BarCodeDecoding(mRImage, out hReg, elementSizeMin, checkChar, contrastMin, "true", "true", 5, 2, 2, 1, resultNum, timeOut, out hData);

                //更新数据
                readBarcode_Info.barcodeData = hData;
                readBarcode_Info.barcodeReg = hReg;

                //主界面窗体显示
                WindowShowROI();

                //保存对象
                SetVarList(ref mSloVar, new DataCell(ModInfo.Name, ModInfo.Encode, DataType.单量, DataMode.读一维码, ConstVar.ReadBarcode, ModInfo.Plugin, "0", 1, readBarcode_Info, DataAtrr.全局变量));

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
            new ReadBarcodeForm((ReadBarcodeObj)baseMod).ShowDialog();
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
                    HRoi roiResult = new HRoi(ModInfo.Encode, ModInfo.Name, ModInfo.Remarks, HRoiType.检测结果, resultColor, new HObject(readBarcode_Info.barcodeReg));
                    mRImage.ShowHRoi(roiResult);
                }

                if (isShowData)
                {
                    HText text;
                    if (prefix != "")
                    {
                        text = new HText(ModInfo.Encode, ModInfo.Name, ModInfo.Remarks, HRoiType.文字显示, resultColor, prefix + ":" + readBarcode_Info.barcodeData, fontType, Y, X, fontSize, mRImage, false);
                    }
                    else
                    {
                        text = new HText(ModInfo.Encode, ModInfo.Name, ModInfo.Remarks, HRoiType.文字显示, resultColor, readBarcode_Info.barcodeData, fontType, Y, X, fontSize, mRImage, false);
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

        /// <summary>
        /// 解一维码
        /// </summary>
        /// <param name="ho_DecodedImage">输入图像</param>
        /// <param name="ho_DecodedRegions">结果区域</param>
        /// <param name="hv_ElementSizeMin">最小模块尺寸</param>
        /// <param name="hv_CheckChar">检验字符</param>
        /// <param name="hv_ContrastMin">最小对比度</param>
        /// <param name="hv_ElementSizeVariable">是否允许条码有形变</param>
        /// <param name="hv_MajorityVoting">是否选择所有扫描线的大部分解码后的结果作为整体结果</param>
        /// <param name="hv_MeasThreshAbs">边缘阈值变化</param>
        /// <param name="hv_MinCodeLength">最小解码字符数</param>
        /// <param name="hv_MinIdenticalScanlines">读取到相同数据最少扫描线数目</param>
        /// <param name="hv_Persistence">是否存储中间结果</param>
        /// <param name="hv_StopAfterResultNum">解码成功的条码数目</param>
        /// <param name="hv_TimeOut">超时时长</param>
        /// <param name="hv_DecodedResults">读码结果</param>
        public void BarCodeDecoding(HObject ho_DecodedImage, out HObject ho_DecodedRegions,HTuple hv_ElementSizeMin, HTuple hv_CheckChar, HTuple hv_ContrastMin, HTuple hv_ElementSizeVariable,
                                    HTuple hv_MajorityVoting, HTuple hv_MeasThreshAbs, HTuple hv_MinCodeLength, HTuple hv_MinIdenticalScanlines, HTuple hv_Persistence, HTuple hv_StopAfterResultNum,
                                    HTuple hv_TimeOut, out HTuple hv_DecodedResults)
        {
            // Local iconic variables 

            // Local control variables 

            HTuple hv_GenParamName = new HTuple(), hv_GenParamValue = new HTuple();
            HTuple hv_BarCodeHandle = new HTuple();
            // Initialize local and output iconic variables 
            HOperatorSet.GenEmptyObj(out ho_DecodedRegions);
            hv_DecodedResults = new HTuple();
            try
            {
                //**参数名称
                hv_GenParamName.Dispose();
                hv_GenParamName = "element_size_min";
                using (HDevDisposeHelper dh = new HDevDisposeHelper())
                {
                    {
                        HTuple
                          ExpTmpLocalVar_GenParamName = hv_GenParamName.TupleConcat(
                            "check_char");
                        hv_GenParamName.Dispose();
                        hv_GenParamName = ExpTmpLocalVar_GenParamName;
                    }
                }
                using (HDevDisposeHelper dh = new HDevDisposeHelper())
                {
                    {
                        HTuple
                          ExpTmpLocalVar_GenParamName = hv_GenParamName.TupleConcat(
                            "contrast_min");
                        hv_GenParamName.Dispose();
                        hv_GenParamName = ExpTmpLocalVar_GenParamName;
                    }
                }
                using (HDevDisposeHelper dh = new HDevDisposeHelper())
                {
                    {
                        HTuple
                          ExpTmpLocalVar_GenParamName = hv_GenParamName.TupleConcat(
                            "element_size_variable");
                        hv_GenParamName.Dispose();
                        hv_GenParamName = ExpTmpLocalVar_GenParamName;
                    }
                }
                using (HDevDisposeHelper dh = new HDevDisposeHelper())
                {
                    {
                        HTuple
                          ExpTmpLocalVar_GenParamName = hv_GenParamName.TupleConcat(
                            "majority_voting");
                        hv_GenParamName.Dispose();
                        hv_GenParamName = ExpTmpLocalVar_GenParamName;
                    }
                }
                using (HDevDisposeHelper dh = new HDevDisposeHelper())
                {
                    {
                        HTuple
                          ExpTmpLocalVar_GenParamName = hv_GenParamName.TupleConcat(
                            "meas_thresh_abs");
                        hv_GenParamName.Dispose();
                        hv_GenParamName = ExpTmpLocalVar_GenParamName;
                    }
                }
                using (HDevDisposeHelper dh = new HDevDisposeHelper())
                {
                    {
                        HTuple
                          ExpTmpLocalVar_GenParamName = hv_GenParamName.TupleConcat(
                            "min_code_length");
                        hv_GenParamName.Dispose();
                        hv_GenParamName = ExpTmpLocalVar_GenParamName;
                    }
                }
                using (HDevDisposeHelper dh = new HDevDisposeHelper())
                {
                    {
                        HTuple
                          ExpTmpLocalVar_GenParamName = hv_GenParamName.TupleConcat(
                            "min_identical_scanlines");
                        hv_GenParamName.Dispose();
                        hv_GenParamName = ExpTmpLocalVar_GenParamName;
                    }
                }
                using (HDevDisposeHelper dh = new HDevDisposeHelper())
                {
                    {
                        HTuple
                          ExpTmpLocalVar_GenParamName = hv_GenParamName.TupleConcat(
                            "persistence");
                        hv_GenParamName.Dispose();
                        hv_GenParamName = ExpTmpLocalVar_GenParamName;
                    }
                }
                using (HDevDisposeHelper dh = new HDevDisposeHelper())
                {
                    {
                        HTuple
                          ExpTmpLocalVar_GenParamName = hv_GenParamName.TupleConcat(
                            "stop_after_result_num");
                        hv_GenParamName.Dispose();
                        hv_GenParamName = ExpTmpLocalVar_GenParamName;
                    }
                }
                using (HDevDisposeHelper dh = new HDevDisposeHelper())
                {
                    {
                        HTuple
                          ExpTmpLocalVar_GenParamName = hv_GenParamName.TupleConcat(
                            "timeout");
                        hv_GenParamName.Dispose();
                        hv_GenParamName = ExpTmpLocalVar_GenParamName;
                    }
                }
                //**参数值
                hv_GenParamValue.Dispose();
                hv_GenParamValue = new HTuple(hv_ElementSizeMin);
                using (HDevDisposeHelper dh = new HDevDisposeHelper())
                {
                    {
                        HTuple
                          ExpTmpLocalVar_GenParamValue = hv_GenParamValue.TupleConcat(
                            hv_CheckChar);
                        hv_GenParamValue.Dispose();
                        hv_GenParamValue = ExpTmpLocalVar_GenParamValue;
                    }
                }
                using (HDevDisposeHelper dh = new HDevDisposeHelper())
                {
                    {
                        HTuple
                          ExpTmpLocalVar_GenParamValue = hv_GenParamValue.TupleConcat(
                            hv_ContrastMin);
                        hv_GenParamValue.Dispose();
                        hv_GenParamValue = ExpTmpLocalVar_GenParamValue;
                    }
                }
                using (HDevDisposeHelper dh = new HDevDisposeHelper())
                {
                    {
                        HTuple
                          ExpTmpLocalVar_GenParamValue = hv_GenParamValue.TupleConcat(
                            hv_ElementSizeVariable);
                        hv_GenParamValue.Dispose();
                        hv_GenParamValue = ExpTmpLocalVar_GenParamValue;
                    }
                }
                using (HDevDisposeHelper dh = new HDevDisposeHelper())
                {
                    {
                        HTuple
                          ExpTmpLocalVar_GenParamValue = hv_GenParamValue.TupleConcat(
                            hv_MajorityVoting);
                        hv_GenParamValue.Dispose();
                        hv_GenParamValue = ExpTmpLocalVar_GenParamValue;
                    }
                }
                using (HDevDisposeHelper dh = new HDevDisposeHelper())
                {
                    {
                        HTuple
                          ExpTmpLocalVar_GenParamValue = hv_GenParamValue.TupleConcat(
                            hv_MeasThreshAbs);
                        hv_GenParamValue.Dispose();
                        hv_GenParamValue = ExpTmpLocalVar_GenParamValue;
                    }
                }
                using (HDevDisposeHelper dh = new HDevDisposeHelper())
                {
                    {
                        HTuple
                          ExpTmpLocalVar_GenParamValue = hv_GenParamValue.TupleConcat(
                            hv_MinCodeLength);
                        hv_GenParamValue.Dispose();
                        hv_GenParamValue = ExpTmpLocalVar_GenParamValue;
                    }
                }
                using (HDevDisposeHelper dh = new HDevDisposeHelper())
                {
                    {
                        HTuple
                          ExpTmpLocalVar_GenParamValue = hv_GenParamValue.TupleConcat(
                            hv_MinIdenticalScanlines);
                        hv_GenParamValue.Dispose();
                        hv_GenParamValue = ExpTmpLocalVar_GenParamValue;
                    }
                }
                using (HDevDisposeHelper dh = new HDevDisposeHelper())
                {
                    {
                        HTuple
                          ExpTmpLocalVar_GenParamValue = hv_GenParamValue.TupleConcat(
                            hv_Persistence);
                        hv_GenParamValue.Dispose();
                        hv_GenParamValue = ExpTmpLocalVar_GenParamValue;
                    }
                }
                using (HDevDisposeHelper dh = new HDevDisposeHelper())
                {
                    {
                        HTuple
                          ExpTmpLocalVar_GenParamValue = hv_GenParamValue.TupleConcat(
                            hv_StopAfterResultNum);
                        hv_GenParamValue.Dispose();
                        hv_GenParamValue = ExpTmpLocalVar_GenParamValue;
                    }
                }
                using (HDevDisposeHelper dh = new HDevDisposeHelper())
                {
                    {
                        HTuple
                          ExpTmpLocalVar_GenParamValue = hv_GenParamValue.TupleConcat(
                            hv_TimeOut);
                        hv_GenParamValue.Dispose();
                        hv_GenParamValue = ExpTmpLocalVar_GenParamValue;
                    }
                }

                hv_BarCodeHandle.Dispose();
                HOperatorSet.CreateBarCodeModel(new HTuple(), new HTuple(), out hv_BarCodeHandle);
                HOperatorSet.SetBarCodeParam(hv_BarCodeHandle, hv_GenParamName, hv_GenParamValue);
                ho_DecodedRegions.Dispose(); hv_DecodedResults.Dispose();
                HOperatorSet.FindBarCode(ho_DecodedImage, out ho_DecodedRegions, hv_BarCodeHandle,
                    "auto", out hv_DecodedResults);
                HOperatorSet.ClearBarCodeModel(hv_BarCodeHandle);

                hv_GenParamName.Dispose();
                hv_GenParamValue.Dispose();
                hv_BarCodeHandle.Dispose();

                return;
            }
            catch (HalconException HDevExpDefaultException)
            {

                hv_GenParamName.Dispose();
                hv_GenParamValue.Dispose();
                hv_BarCodeHandle.Dispose();

                throw HDevExpDefaultException;
            }
        }

        #endregion
    }
}
