using HalconDotNet;
using Plugin.CreateROI;
using Rex.UI;
using RexConst;
using RexView;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using VisionCore;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Plugin.EmphasizeImage
{
    [Category("图像处理")]
    [DisplayName("图像增强")]
    [Serializable]
    public class EmphasizeImageObj : ObjBase
    {
        #region 字段、属性

        /// <summary>
        /// 图像名称
        /// </summary>
        public string mImages = "";

        /// <summary>
        /// 信息输出
        /// </summary>
        public EmphasisImage_Info emphasisImage_Info = new EmphasisImage_Info();

        /// <summary>
        /// 掩模宽度
        /// </summary>
        public int maskWidth = 7;

        /// <summary>
        /// 掩模高度
        /// </summary>
        public int maskHeight = 7;

        /// <summary>
        /// 增强因子
        /// </summary>
        public double factor = 1;

        /// <summary>
        /// 窗体索引
        /// </summary>
        public int screenIndex = 0;

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
                HObject img;
                HOperatorSet.GenEmptyObj(out img);

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

                //获取数据
                GetData();

                //执行算法
                HOperatorSet.Emphasize(mRImage, out img, maskWidth, maskHeight, factor);
                RImage.HObjToRImage(img, ref emphasisImage_Info.imageObj);

                //主界面窗体显示
                WindowShowROI();

                //保存对象
                SetVarList(ref mSloVar, new DataCell(ModInfo.Name, ModInfo.Encode, DataType.单量, DataMode.图像增强, ConstVar.EmphasisImg, ModInfo.Plugin, "0", 1, emphasisImage_Info, DataAtrr.全局变量));

                Log.Info(Sol.mSol.mProjList[ModInfo.Index].mProjInfo.Name + ": " + ModInfo.Name + ":" + "执行成功");
                ModInfo.State = ModState.OK;
                return true;

            }
            catch (Exception ex)
            {
                Log.Error(Sol.mSol.mProjList[ModInfo.Index].mProjInfo.Name + ": " + ModInfo.Name + ":" + "执行失败(" + "原因：" + ex.Message + ")");
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
            new EmphasizeImageForm((EmphasizeImageObj)baseMod).ShowDialog();
        }

        /// <summary>
        /// 在主窗体的图像窗口显示区域
        /// </summary>
        public void WindowShowROI()
        {
            if (emphasisImage_Info.imageObj != null)
            {
                emphasisImage_Info.imageObj.mHRoi.Clear();
                emphasisImage_Info.imageObj.mHText.Clear();
                emphasisImage_Info.imageObj.Screen = screenIndex;
            }
        }

        #endregion

        #region 方法-数据相关

        /// <summary>
        /// 如果数据内容是链接，则由GetLinkValue得到链接的值，赋值给double类型数据
        /// </summary>
        public void GetData(){ }

        /// <summary>
        /// 初始化模块输出对象的变量
        /// </summary>
        public void InitOutput()
        {
            emphasisImage_Info.imageObj = new RImage();
        }

        #endregion
    }
}
