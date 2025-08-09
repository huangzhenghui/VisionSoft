using HalconDotNet;
using Plugin.CreateROI;
using RexConst;
using RexView;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VisionCore;

namespace Plugin.ContourExt
{
    [Category("检测识别")]
    [DisplayName("轮廓提取")]
    [Serializable]
    public class ContourExtObj : ObjBase
    {
        #region 字段、属性

        /// <summary>
        /// 图像名称
        /// </summary>
        public string mImages = "";

        /// <summary>
        /// 信息输出
        /// </summary>
        public ContourExt_Info contourExt_Info = new ContourExt_Info();

        /// <summary>
        /// 边缘算法
        /// </summary>
        public string filter = "canny";

        /// <summary>
        /// 滤波系数
        /// </summary>
        public double alpha = 1.0;

        /// <summary>
        /// 阈值下限
        /// </summary>
        public int low = 10;

        /// <summary>
        /// 阈值上限
        /// </summary>
        public int high = 30;

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
                //声明变量
                HObject outContour = new HObject();

                //初始化输出变量
                InitOutputInfo();

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
                HOperatorSet.EdgesSubPix(mRImage, out outContour, filter, alpha, low, high);

                //状态更新
                exeResult = "执行成功";

                //更新数据
                contourExt_Info.contourObj = outContour;
                contourExt_Info.contourNum = outContour.CountObj();

                //主界面窗体显示
                WindowShowROI();

                //保存对象
                SetVarList(ref mSloVar, new DataCell(ModInfo.Name, ModInfo.Encode, DataType.单量, DataMode.轮廓提取, ConstVar.ContourExt, ModInfo.Plugin, "0", 1, contourExt_Info, DataAtrr.全局变量));

                Log.Info(ModInfo.Name + ":" + "轮廓提取成功");
                ModInfo.State = ModState.OK;
                return true;
            }
            catch (Exception ex)
            {
                Log.Error(ModInfo.Name + ":" + ex.Message);
                ModInfo.State = ModState.NG;
                mRImageResult = null;
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
            new ContourExtForm((ContourExtObj)baseMod).ShowDialog();
        }

        /// <summary>
        /// 在主窗体的图像窗口显示区域
        /// </summary>
        public void WindowShowROI()
        {
            if (isShowReg)
            {
                HRoi contours = new HRoi(ModInfo.Encode, ModInfo.Name, ModInfo.Remarks, HRoiType.输出直线, resultColor, new HObject(contourExt_Info.contourObj));
                mRImage.ShowHRoi(contours);
            }
        }

        #endregion

        #region 方法-数据相关

        /// <summary>
        /// 初始化输出变量
        /// </summary>
        public override void InitOutputInfo()
        {
            contourExt_Info.contourNum = new HTuple();
            contourExt_Info.contourObj = new HObject();
        }

        /// <summary>
        /// 如果数据内容是链接，则由GetLinkValue得到链接的值
        /// </summary>
        public void GetData() { }

        #endregion
    }
}
