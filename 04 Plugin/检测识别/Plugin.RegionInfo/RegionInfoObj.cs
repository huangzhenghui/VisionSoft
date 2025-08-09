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

namespace Plugin.RegionInfo
{
    [Category("检测识别")]
    [DisplayName("区域信息")]
    [Serializable]
    public class RegionInfoObj : ObjBase
    {
        #region 字段、属性

        /// <summary>
        /// 图像名称
        /// </summary>
        public string mImages = "";

        /// <summary>
        /// 信息输出
        /// </summary>
        public RegionInfo_Info regionInfo_Info = new RegionInfo_Info();

        /// <summary>
        /// 查询特征
        /// </summary>
        public string feature = "area";

        /// <summary>
        /// 输入区域对象
        /// </summary>
        public HObject inputReg;

        /// <summary>
        /// 输入区域名称
        /// </summary>
        public string inputRegName = "";

        /// <summary>
        /// 是否显示数据
        /// </summary>
        public bool isShowResult = true;

        /// <summary>
        /// 结果显示X坐标
        /// </summary>
        public double X = 10;

        /// <summary>
        /// 结果显示Y坐标
        /// </summary>
        public double Y = 10;

        /// <summary>
        /// 字体大小
        /// </summary>
        public int fontSize = 15;

        /// <summary>
        /// 前缀
        /// </summary>
        public string prefix = "";

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
                HTuple value = new HTuple();

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
                HOperatorSet.RegionFeatures(inputReg, feature, out value);

                //输出数据更新
                regionInfo_Info.result = value;
                regionInfo_Info.resultAvg = value.TupleSum() / value.Length;
                regionInfo_Info.resultMax = value.TupleMax();
                regionInfo_Info.resultMin = value.TupleMin();

                //主界面窗体显示
                WindowShowHObj();

                //保存对象
                SetVarList(ref mSloVar, new DataCell(ModInfo.Name, ModInfo.Encode, DataType.单量, DataMode.区域信息, ConstVar.InternalReg, ModInfo.Plugin, "0", 1, regionInfo_Info, DataAtrr.全局变量));

                Log.Info(ModInfo.Name + ":" + "区域信息查询成功");
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
        public void InitOutput() { }

        #endregion

        #region 方法-窗体相关

        /// <summary>
        /// 显示窗体
        /// </summary>
        /// <param name="baseMod"></param>
        public override void RunForm(ObjBase baseMod)
        {
            new RegionInfoForm((RegionInfoObj)baseMod).ShowDialog();
        }

        /// <summary>
        /// 在主窗体的图像窗口显示HObject对象
        /// </summary>
        public void WindowShowHObj()
        {
            if (isShowResult)
            {
                string showText = "";
                for (int i = 0; i < regionInfo_Info.result.Length; i++)
                {
                    if (i == 0)
                    {
                        showText = regionInfo_Info.result[i].ToString("F4");
                    }
                    else
                    {
                        showText = showText + "," + regionInfo_Info.result[i].ToString("F4");
                    }
                }

                HText text = new HText(ModInfo.Encode, ModInfo.Name, ModInfo.Remarks, HRoiType.文字显示, resultColor, prefix + ":" + showText, "mono", X, Y, fontSize, mRImage, false);
                mRImage.ShowHText(text);
            }
        }

        #endregion
    }
}
