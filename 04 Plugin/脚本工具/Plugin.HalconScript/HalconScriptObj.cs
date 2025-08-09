using HalconDotNet;
using MutualTools;
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

namespace Plugin.HalconScript
{
    [Category("脚本工具")]
    [DisplayName("视觉脚本")]
    [Serializable]
    public class HalconScriptObj : ObjBase
    {
        #region 字段、属性

        /// <summary>
        /// 图像名称
        /// </summary>
        public string mImages = "";

        /// <summary>
        /// 信息输出
        /// </summary>
        public HalconScript_Info halconScript_Info = new HalconScript_Info();

        /// <summary>
        /// 引擎工具
        /// </summary>
        [NonSerialized]
        public HDevEngine myEngine;

        /// <summary>
        /// 脚本类型
        /// </summary>
        public string scriptType = "Hdvp文件(.hdvp)";

        /// <summary>
        /// 文件读取路径
        /// </summary>
        public string fileRPath = "";

        /// <summary>
        /// 输入对象
        /// </summary>
        [NonSerialized]
        public HObject inputHObject = new HObject();

        /// <summary>
        /// 输入元组
        /// </summary>
        public HTuple inputHTuple = new HTuple();

        /// <summary>
        /// 中间值
        /// </summary>
        public string inputHObjectName = "", inputHTupleName = "";

        /// <summary>
        /// 创建引擎标志位
        /// </summary>
        public bool isCreateEngine = false;

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
                HObject outputHobject = new HObject();
                HTuple outputHTuple = new HTuple();

                //设置可绘制区域的大小
                HOperatorSet.SetSystem("width", 20000);
                HOperatorSet.SetSystem("height", 20000);

                //加载图像
                if ((RImage)Var.GetImage(mSloVar, mImages) == null)
                {
                    Log.Error(Sol.mSol.mProjList[ModInfo.Index].mProjInfo.Name + ": " + ModInfo.Name + ":" + "执行失败(原因：未输入图像)");
                    InitOutputInfo();
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
                switch (scriptType)
                {
                    case "Hdvp文件(.hdvp)":
                        string[] strAssem = fileRPath.Split("\\");
                        string folderPath = "";
                        for (int i = 0; i < strAssem.Length - 1; i++)
                        {
                            if (i == 0)
                            {
                                folderPath = strAssem[0];
                            }
                            else
                            {
                                folderPath = folderPath + "\\" + strAssem[i];
                            }
                        }

                        string procedureName = strAssem[strAssem.Length - 1].Split('.')[0];
                        HDevProcedure procedure = new HDevProcedure(procedureName);
                        HDevProcedureCall procedureCall = new HDevProcedureCall(procedure);
                        HObject img = new HObject();
                        HOperatorSet.ReadImage(out img, @"D:\测试图像\石英玻璃\石英玻璃.jpg");
                        procedureCall.SetInputIconicParamObject("InputHObject", img);
                        procedureCall.SetInputIconicParamObject("InputHObject", inputHObject);
                        procedureCall.SetInputCtrlParamTuple("InputHTuple", inputHTuple);
    

                        procedureCall.Execute();//运行函数
                        outputHobject = procedureCall.GetOutputIconicParamObject("OutputHObject");
                        outputHTuple = procedureCall.GetOutputCtrlParamTuple("OutputHTuple");
                        break;
                }

                //更新数据
                halconScript_Info.outputHObject = outputHobject;
                halconScript_Info.outputHTuple = outputHTuple;

                //主界面窗体显示
                WindowShowROI();

                //保存对象
                SetVarList(ref mSloVar, new DataCell(ModInfo.Name, ModInfo.Encode, DataType.单量, DataMode.视觉工具, ConstVar.HalconScript, ModInfo.Plugin, "0", 1, halconScript_Info, DataAtrr.全局变量));

                Log.Info(Sol.mSol.mProjList[ModInfo.Index].mProjInfo.Name + ": " + ModInfo.Name + ":" + "执行成功");
                ModInfo.State = ModState.OK;
                return true;
            }
            catch (Exception ex)
            {
                Log.Error(Sol.mSol.mProjList[ModInfo.Index].mProjInfo.Name + ": " + ModInfo.Name + ":" + "执行失败(" + "原因：" + ex.Message + ")");
                InitOutputInfo();
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
            new HalconScriptForm((HalconScriptObj)baseMod).ShowDialog();
        }

        /// <summary>
        /// 在主窗体的图像窗口显示区域
        /// </summary>
        public void WindowShowROI()
        {
            if (mRImage != null)
            {
                if (isShowReg)
                {
                    HRoi roiResult = new HRoi(ModInfo.Encode, ModInfo.Name, ModInfo.Remarks, HRoiType.检测结果, resultColor, new HObject(halconScript_Info.outputHObject));
                    mRImage.ShowHRoi(roiResult);
                }

                if (isShowData)
                {
                    //绘制文本
                    HText hText;
                    string text;

                    if (prefix != "")
                    {
                        text = prefix + ":" + TypeConvert.HTupleToString(halconScript_Info.outputHTuple);
                        hText = new HText(ModInfo.Encode, ModInfo.Name, ModInfo.Remarks, HRoiType.文字显示, resultColor, prefix + ":" + text, fontType, Y, X, fontSize, mRImage, false);
                    }
                    else
                    {
                        text = TypeConvert.HTupleToString(halconScript_Info.outputHTuple);
                        hText = new HText(ModInfo.Encode, ModInfo.Name, ModInfo.Remarks, HRoiType.文字显示, resultColor, text, fontType, Y, X, fontSize, mRImage, false);
                    }

                    mRImage.ShowHText(hText);
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
            if (inputHObjectName.Contains(":"))
            {
                inputHObject = (HObject)Var.GetLinkValue(mSysVar, mSloVar, inputHObjectName);
            }
            else 
            {
                HOperatorSet.GenEmptyObj(out inputHObject);
            }

            if (inputHTupleName.Contains(":"))
            {
                inputHTuple = (HTuple)Var.GetLinkValue(mSysVar, mSloVar, inputHTupleName);
            }
            else
            {
                inputHTuple = TypeConvert.StringToHTuple(inputHTupleName);
            }
        }

        /// <summary>
        /// 信息赋值
        /// </summary>
        public override void SetInfo() 
        {
            string[] strAssem = fileRPath.Split("\\");
            string folderPath = "";
            for (int i = 0; i < strAssem.Length - 1; i++)
            {
                if (i == 0)
                {
                    folderPath = strAssem[0];
                }
                else
                {
                    folderPath = folderPath + "\\" + strAssem[i];
                }
            }

            string procedurePath = folderPath;

            myEngine = new HDevEngine();
            myEngine.SetProcedurePath(procedurePath);
        }

        /// <summary>
        /// 初始化输出信息
        /// </summary>
        public override void InitOutputInfo()
        {
            halconScript_Info.outputHObject = new HObject();
            halconScript_Info.outputHTuple = new HTuple();
        }

        #endregion
    }
}
