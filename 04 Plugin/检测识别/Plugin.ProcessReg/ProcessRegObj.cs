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
    [DisplayName("区域处理")]
    [Serializable]
    public class ProcessRegObj : ObjBase
    {
        #region 字段、属性

        /// <summary>
        /// 图像名称
        /// </summary>
        public string mImages = "";

        /// <summary>
        /// 区域筛选类
        /// </summary>
        public ProcessReg_Info processReg_Info = new ProcessReg_Info();

        /// <summary>
        /// 输入区域对象
        /// </summary>
        public HObject inputReg;

        /// <summary>
        /// 输入区域名称
        /// </summary>
        public string inputRegName;

        /// <summary>
        /// 处理方式
        /// </summary>
        public string processMode = "腐蚀";

        /// <summary>
        /// 结构元素形状
        /// </summary>
        public string shape = "圆";

        /// <summary>
        /// 半径
        /// </summary>
        public double radius = 3.5;

        /// <summary>
        /// 宽
        /// </summary>
        public double width = 10;

        /// <summary>
        /// 高
        /// </summary>
        public double height = 10;

        /// <summary>
        /// 结构元素对象
        /// </summary>
        public HObject elementObj;

        /// <summary>
        /// 结构元素名称
        /// </summary>
        public string elementName = "";

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

                //设置可绘制区域的大小
                HOperatorSet.SetSystem("width", 20000);
                HOperatorSet.SetSystem("height", 20000);

                //初始化输出变量
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
                switch (processMode)
                {
                    case "腐蚀":
                        if (shape == "圆")
                        {
                            HOperatorSet.ErosionCircle(inputReg, out processReg_Info.regionObj, radius);
                        }
                        else if (shape == "矩形1")
                        {
                            HOperatorSet.ErosionRectangle1(inputReg, out processReg_Info.regionObj, width, height);
                        }
                        else if (shape == "自定义")
                        {
                            HOperatorSet.Erosion1(inputReg, elementObj, out processReg_Info.regionObj, 1);
                        }
                        break;
                    case "膨胀":
                        if (shape == "圆")
                        {
                            HOperatorSet.DilationCircle(inputReg, out processReg_Info.regionObj, radius);
                        }
                        else if (shape == "矩形1")
                        {
                            HOperatorSet.DilationRectangle1(inputReg, out processReg_Info.regionObj, width, height);
                        }
                        else if (shape == "自定义")
                        {
                            HOperatorSet.Dilation1(inputReg, elementObj, out processReg_Info.regionObj, 1);
                        }
                        break;
                    case "开运算":
                        if (shape == "圆")
                        {
                            HOperatorSet.OpeningCircle(inputReg, out processReg_Info.regionObj, radius);
                        }
                        else if (shape == "矩形1")
                        {
                            HOperatorSet.OpeningRectangle1(inputReg, out processReg_Info.regionObj, width, height);
                        }
                        else if (shape == "自定义")
                        {
                            HOperatorSet.Opening(inputReg, elementObj, out processReg_Info.regionObj);
                        }
                        break;
                    case "闭运算":
                        if (shape == "圆")
                        {
                            HOperatorSet.ClosingCircle(inputReg, out processReg_Info.regionObj, radius);
                        }
                        else if (shape == "矩形1")
                        {
                            HOperatorSet.ClosingRectangle1(inputReg, out processReg_Info.regionObj, width, height);
                        }
                        else if (shape == "自定义")
                        {
                            HOperatorSet.Closing(inputReg, elementObj, out processReg_Info.regionObj);
                        }
                        break;
                    default:
                        break;
                }

                //主界面窗体显示
                WindowShowHObj();

                //保存对象
                SetVarList(ref mSloVar, new DataCell(ModInfo.Name, ModInfo.Encode, DataType.单量, DataMode.区域处理, ConstVar.ProcessReg, ModInfo.Plugin, "0", 1, processReg_Info, DataAtrr.全局变量));

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
            if (inputRegName.Contains(":"))
            {
                inputReg = (HObject)Var.GetLinkValue(mSysVar, mSloVar, inputRegName);
            }

            if (elementName.Contains(":"))
            {
                elementObj = (HObject)Var.GetLinkValue(mSysVar, mSloVar, elementName);
            }
        }

        /// <summary>
        /// 初始化模块输出对象的变量
        /// </summary>
        public void InitOutput()
        {
            HOperatorSet.GenEmptyObj(out processReg_Info.regionObj);
        }

        #endregion

        #region 方法-窗体相关

        /// <summary>
        /// 显示窗体
        /// </summary>
        /// <param name="baseMod"></param>
        public override void RunForm(ObjBase baseMod)
        {
            new ProcessRegForm((ProcessRegObj)baseMod).ShowDialog();
        }

        /// <summary>
        /// 在主窗体的图像窗口显示HObject对象
        /// </summary>
        public void WindowShowHObj()
        {
            if (isShowHObj)
            {
                HRoi resultRegion = new HRoi(ModInfo.Encode, ModInfo.Name, ModInfo.Remarks, HRoiType.检测结果, showColor, processReg_Info.regionObj);
                mRImage.ShowHRoi(resultRegion);
            }
        }

        #endregion
    }
}
