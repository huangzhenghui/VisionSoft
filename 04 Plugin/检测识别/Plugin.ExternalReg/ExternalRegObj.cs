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

namespace Plugin.ExternalReg
{
    [Category("检测识别")]
    [DisplayName("外接区域")]
    [Serializable]
    public class ExternalRegObj : ObjBase
    {
        #region 字段、属性

        /// <summary>
        /// 图像名称
        /// </summary>
        public string mImages = "";

        /// <summary>
        /// 信息输出
        /// </summary>
        public ExternalReg_Info externalReg_Info = new ExternalReg_Info();

        /// <summary>
        /// 形状
        /// </summary>
        public string shape = "水平矩形";

        /// <summary>
        /// 输入区域对象
        /// </summary>
        public HObject inputReg;

        /// <summary>
        /// 输入区域名称
        /// </summary>
        public string inputRegName = "";

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
                HTuple rect1BeginR = new HTuple();
                HTuple rect1BeginC = new HTuple();
                HTuple rect1EndR = new HTuple();
                HTuple rect1EndC = new HTuple();
                HTuple rect2CenterR = new HTuple();
                HTuple rect2CenterC = new HTuple();
                HTuple rect2Phi = new HTuple();
                HTuple rect2Length1 = new HTuple();
                HTuple rect2Length2 = new HTuple();
                HTuple circleCenterR = new HTuple();
                HTuple circleCenterC = new HTuple();
                HTuple circleRadius = new HTuple();

                HObject rect1Obj, rect2Obj, circleObj;
                HOperatorSet.GenEmptyObj(out rect1Obj);
                HOperatorSet.GenEmptyObj(out rect2Obj);
                HOperatorSet.GenEmptyObj(out circleObj);

                //设置可绘制区域的大小
                HOperatorSet.SetSystem("width", 20000);
                HOperatorSet.SetSystem("height", 20000);

                //初始化输出信息
                InitOutput();

                //加载图像
                if ((RImage)Var.GetImage(mSloVar, mImages) == null)
                {
                    ModInfo.State = ModState.NG;
                    return false;
                }
                else
                {
                    mRImage = (RImage)Var.GetImage(mSloVar, mImages);
                }

                GetData();

                //执行算法
                switch (shape)
                {
                    case "水平矩形":
                        HOperatorSet.SmallestRectangle1(inputReg, out rect1BeginR, out rect1BeginC, out rect1EndR, out rect1EndC);
                        HOperatorSet.GenRectangle1(out rect1Obj, rect1BeginR, rect1BeginC, rect1EndR, rect1EndC);
                        break;
                    case "任意矩形":
                        HOperatorSet.SmallestRectangle2(inputReg, out rect2CenterR, out rect2CenterC, out rect2Phi, out rect2Length1, out rect2Length2);
                        HOperatorSet.GenRectangle2(out rect2Obj, rect2CenterR, rect2CenterC, rect2Phi, rect2Length1, rect2Length2);
                        break;
                    case "圆形":
                        HOperatorSet.SmallestCircle(inputReg, out circleCenterR, out circleCenterC, out circleRadius);
                        HOperatorSet.GenCircle(out circleObj, circleCenterR, circleCenterC, circleRadius);
                        break;
                    default:
                        break;
                }

                //输出数据更新
                externalReg_Info.rect1BeginR = rect1BeginR;
                externalReg_Info.rect1BeginC = rect1BeginC;
                externalReg_Info.rect1EndR = rect1EndR;
                externalReg_Info.rect1EndC = rect1EndC;
                externalReg_Info.rect2CenterR = rect2CenterR;
                externalReg_Info.rect2CenterC = rect2CenterC;
                externalReg_Info.rect2Phi = rect2Phi;
                externalReg_Info.rect2Length1 = rect2Length1;
                externalReg_Info.rect2Length2 = rect2Length2;
                externalReg_Info.circleCenterR = circleCenterR;
                externalReg_Info.circleCenterC = circleCenterC;
                externalReg_Info.circleRadius = circleRadius;

                switch (shape)
                {
                    case "水平矩形":
                        externalReg_Info.regionObj = rect1Obj;
                        break;
                    case "任意矩形":
                        externalReg_Info.regionObj = rect2Obj;
                        break;
                    case "圆形":
                        externalReg_Info.regionObj = circleObj;
                        break;
                    default:
                        break;
                }

                //主界面窗体显示
                WindowShowHObj();

                //保存对象
                SetVarList(ref mSloVar, new DataCell(ModInfo.Name, ModInfo.Encode, DataType.单量, DataMode.外接区域, ConstVar.ExternalReg, ModInfo.Plugin, "0", 1, externalReg_Info, DataAtrr.全局变量));

                Log.Info(ModInfo.Name + ":" + "外接区域成功");
                ModInfo.State = ModState.OK;
                return true;
            }
            catch (Exception ex)
            {
                Log.Error(ModInfo.Name + ":" + ex.Message);
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
        }

        /// <summary>
        /// 初始化模块输出对象的变量
        /// </summary>
        public void InitOutput()
        {
            HOperatorSet.GenEmptyObj(out externalReg_Info.regionObj);
        }

        #endregion

        #region 方法-窗体相关

        /// <summary>
        /// 显示窗体
        /// </summary>
        /// <param name="baseMod"></param>
        public override void RunForm(ObjBase baseMod)
        {
            new ExternalRegForm((ExternalRegObj)baseMod).ShowDialog();
        }

        /// <summary>
        /// 在主窗体的图像窗口显示HObject对象
        /// </summary>
        public void WindowShowHObj()
        {
            if (isShowHObj)
            {
                HRoi resultRegion = new HRoi(ModInfo.Encode, ModInfo.Name, ModInfo.Remarks, HRoiType.检测结果, showColor, externalReg_Info.regionObj);
                mRImage.ShowHRoi(resultRegion);
            }
        }

        #endregion
    }
}
