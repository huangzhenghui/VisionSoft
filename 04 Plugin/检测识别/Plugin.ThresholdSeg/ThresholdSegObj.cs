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

namespace Plugin.ThresholdSeg
{
    [Category("检测识别")]
    [DisplayName("阈值分割")]
    [Serializable]
    public class ThresholdSegObj : ObjBase
    {
        #region 字段、属性

        /// <summary>
        /// 图像名称
        /// </summary>
        public string mImages = "";

        /// <summary>
        /// 阈值分割类
        /// </summary>
        public ThresholdSeg_Info thresholdSeg_Info = new ThresholdSeg_Info();

        /// <summary>
        /// 输出区域名称
        /// </summary>
        public string regionName = "";

        /// <summary>
        /// 模式选择
        /// </summary>
        public string mode = "普通";

        /// <summary>
        /// 阈值下限
        /// </summary>
        public double thresholdMin = 128;

        /// <summary>
        /// 阈值下限名称
        /// </summary>
        public string thresholdMinName = "128";

        /// <summary>
        /// 阈值上限
        /// </summary>
        public double thresholdMax = 255;

        /// <summary>
        /// 阈值下限名称
        /// </summary>
        public string thresholdMaxName = "255";

        /// <summary>
        /// 滤波图像
        /// </summary>
        public HObject filterImage;

        /// <summary>
        /// 滤波图像名称
        /// </summary>
        public string filterImageName = "";

        /// <summary>
        /// 阈值偏差
        /// </summary>
        public double offset = 5;

        /// <summary>
        /// 区域特征
        /// </summary>
        public string regFeature = "dark";

        /// <summary>
        /// 掩模宽度
        /// </summary>
        public double maskWidth = 15;

        /// <summary>
        /// 掩模高度
        /// </summary>
        public double maskHeight = 15;

        /// <summary>
        /// 方差因子
        /// </summary>
        public double stdDevScale = 0.2;

        /// <summary>
        /// 平均差值
        /// </summary>
        public double absThreshold = 2;

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
                HObject thrReg = new HObject();

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
                switch (mode)
                {
                    case "普通":
                        HOperatorSet.Threshold(mRImage, out thrReg, thresholdMin, thresholdMax);
                        break;
                    case "动态":
                        HOperatorSet.DynThreshold(mRImage, filterImage, out thrReg, offset, regFeature);
                        break;
                    case "局部":
                        HOperatorSet.VarThreshold(mRImage, out thrReg, maskWidth, maskHeight, stdDevScale, absThreshold, regFeature);
                        break;
                    default:
                        break;
                }

                if (mRImage.maskReg != null)
                {
                    HObject diffReg = new HObject();
                    HOperatorSet.Difference(thrReg, mRImage.maskReg, out diffReg);
                    thresholdSeg_Info.regionObj = diffReg;
                }

                //主界面窗体显示
                WindowShowHObj();

                //保存对象
                SetVarList(ref mSloVar, new DataCell(ModInfo.Name, ModInfo.Encode, DataType.单量, DataMode.阈值分割, ConstVar.AffineMatrix, ModInfo.Plugin, "0", 1, thresholdSeg_Info, DataAtrr.全局变量));

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
            if (thresholdMinName.Contains(":"))
            {
                thresholdMin = (double)Var.GetLinkValue(mSysVar, mSloVar, thresholdMinName);
            }
            else
            {
                thresholdMin = thresholdMinName.ToDouble();
            }

            if (thresholdMaxName.Contains(":"))
            {
                thresholdMax = (double)Var.GetLinkValue(mSysVar, mSloVar, thresholdMaxName);
            }
            else
            {
                thresholdMax = thresholdMaxName.ToDouble();
            }

            if (filterImageName.Contains(":"))
            {
                filterImage = (RImage)Var.GetImage(mSloVar, filterImageName);
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
            new ThresholdSegForm((ThresholdSegObj)baseMod).ShowDialog();
        }

        /// <summary>
        /// 在主窗体的图像窗口显示HObject对象
        /// </summary>
        public void WindowShowHObj()
        {
            if (isShowReg)
            {
                HRoi resultRegion = new HRoi(ModInfo.Encode, ModInfo.Name, ModInfo.Remarks, HRoiType.检测结果, showColor, thresholdSeg_Info.regionObj);
                mRImage.ShowHRoi(resultRegion);
            }
        }

        #endregion
    }
}
