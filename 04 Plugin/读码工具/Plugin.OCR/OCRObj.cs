using HalconDotNet;
using Plugin.CreateROI;
using Rex.UI;
using RexConst;
using RexView;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using VisionCore;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Plugin.OCR
{
    [Category("读码工具")]
    [DisplayName("字符识别")]
    [Serializable]
    public class OCRObj : ObjBase
    {
        #region 字段、属性

        /// <summary>
        /// 图像名称
        /// </summary>
        public string mImages = "";

        /// <summary>
        /// 信息输出
        /// </summary>
        public OCR_Info OCR_Info = new OCR_Info();

        /// <summary>
        /// 文件来源
        /// </summary>
        public string fileScource = "读取";

        /// <summary>
        /// 文件读取路径
        /// </summary>
        public string fileRPath = "";

        /// <summary>
        /// 文件创建路径
        /// </summary>
        public string fileCPath = "";

        /// <summary>
        /// 字符区域
        /// </summary>
        [NonSerialized]
        public HObject characterReg = new HObject();

        /// <summary>
        /// 字符名称
        /// </summary>
        public HTuple characterName = new HTuple();

        /// <summary>
        /// 处理图像
        /// </summary>
        [NonSerialized]
        public RImage procImage = new RImage();

        /// <summary>
        /// 处理区域
        /// </summary>
        [NonSerialized]
        public HObject procReg = new HObject();

        /// <summary>
        /// 是否保存
        /// </summary>
        public bool isSave = true;

        /// <summary>
        /// 保存路径
        /// </summary>
        public string savePath = "";

        /// <summary>
        /// 中间值
        /// </summary>
        public string characterRegName = "", procImageName = "", procRegName = "";

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
                HTuple OCRHandle = new HTuple();
                HTuple error = new HTuple();
                HTuple errorLog = new HTuple();
                HTuple OCRdata = new HTuple();
                HTuple confidence = new HTuple();
                HObject hImg = new HObject();

                //设置可绘制区域的大小
                HOperatorSet.SetSystem("width", 20000);
                HOperatorSet.SetSystem("height", 20000);

                //加载训练图像
                if ((RImage)Var.GetImage(mSloVar, mImages) == null)
                {
                    Log.Error(Sol.mSol.mProjList[ModInfo.Index].mProjInfo.Name + ": " + ModInfo.Name + ":" + "执行失败(原因：未输入训练图像)");
                    ModInfo.State = ModState.NG;
                    return false;
                }
                else
                {
                    mRImage = (RImage)Var.GetImage(mSloVar, mImages);
                }

                //加载处理图像
                if ((RImage)Var.GetImage(mSloVar, procImageName) == null)
                {
                    Log.Error(Sol.mSol.mProjList[ModInfo.Index].mProjInfo.Name + ": " + ModInfo.Name + ":" + "执行失败(原因：未输入处理图像)");
                    ModInfo.State = ModState.NG;
                    return false;
                }
                else
                {
                    procImage = (RImage)Var.GetImage(mSloVar, procImageName);
                }

                //获取数据
                GetData();

                //执行算法
                switch (fileScource)
                {
                    case "创建":
                        //训练mlp分类器
                        HOperatorSet.WriteOcrTrainf(characterReg, mRImage, characterName, fileCPath);
                        HOperatorSet.CreateOcrClassMlp(8, 10, "constant", "default", characterName, 80, "none", 10, 42, out OCRHandle);
                        HOperatorSet.TrainfOcrClassMlp(OCRHandle, fileCPath, 200, 1, 0.01, out error, out errorLog);

                        //OCR识别
                        HOperatorSet.DoOcrMultiClassMlp(procReg, procImage, OCRHandle, out OCRdata, out confidence);
                        break;
                    case "读取":
                        //训练文件读取
                        HOperatorSet.ReadOcrClassMlp(fileRPath, out OCRHandle);

                        //OCR识别
                        HOperatorSet.DoOcrMultiClassMlp(procReg, procImage, OCRHandle, out OCRdata, out confidence);
                        break;
                }

                //文件保存
                if (!isSave && File.Exists(fileCPath) && fileScource == "创建")
                {
                    HOperatorSet.DeleteFile(fileCPath);
                }

                //更新数据
                OCR_Info.OCRData = OCRdata;
                OCR_Info.confData = confidence;

                //主界面窗体显示
                WindowShowROI();

                //保存对象
                SetVarList(ref mSloVar, new DataCell(ModInfo.Name, ModInfo.Encode, DataType.单量, DataMode.OCR识别, ConstVar.OCR, ModInfo.Plugin, "0", 1, OCR_Info, DataAtrr.全局变量));

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
            new OCRForm((OCRObj)baseMod).ShowDialog();
        }

        /// <summary>
        /// 在主窗体的图像窗口显示区域
        /// </summary>
        public void WindowShowROI()
        {
            if (procImage != null)
            {
                if (isShowReg)
                {
                    //绘制文本
                    HText hText;
                    string info = "";
                    string text = "";

                    for (int i = 0; i < OCR_Info.OCRData.Length; i++)
                    {
                        if (i == 0)
                        {
                            info = OCR_Info.OCRData[i];
                        }
                        else
                        {
                            info = info +  OCR_Info.OCRData[i];
                        }

                    }

                    if (prefix != "")
                    {
                        text = prefix + ":" + info;
                    }
                    else
                    {
                        text = info;
                    }

                    if (prefix != "")
                    {
                        hText = new HText(ModInfo.Encode, ModInfo.Name, ModInfo.Remarks, HRoiType.文字显示, resultColor, prefix + ":" + text, fontType, Y, X, fontSize, mRImage, false);
                    }
                    else
                    {
                        hText = new HText(ModInfo.Encode, ModInfo.Name, ModInfo.Remarks, HRoiType.文字显示, resultColor, text, fontType, Y, X, fontSize, mRImage, false);
                    }

                    procImage.ShowHText(hText);
                }
            }
        }

        #endregion

        #region 方法-数据相关

        /// <summary>
        /// 如果数据内容是链接，则由GetLinkValue得到链接的值
        /// </summary>
        public void GetData()
        {
            if (characterRegName.Contains(":"))
            {
                characterReg = (HObject)Var.GetLinkValue(mSysVar, mSloVar, characterRegName);
            }

            if (procRegName.Contains(":"))
            {
                procReg = (HObject)Var.GetLinkValue(mSysVar, mSloVar, procRegName);
            }
        }

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
