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

namespace Plugin.CropImage
{
    [Category("图像处理")]
    [DisplayName("图像裁剪")]
    [Serializable]
    public class CropImageObj : ObjBase
    {
        #region 字段、属性

        /// <summary>
        /// 图像名称
        /// </summary>
        public string mImages = "";

        /// <summary>
        /// 信息输出
        /// </summary>
        public CropImage_Info cropImage_Info = new CropImage_Info();

        /// <summary>
        /// 输入区域
        /// </summary>
        [NonSerialized]
        public HObject region = new HObject();

        /// <summary>
        /// 窗体索引
        /// </summary>
        public int screenIndex = 0;

        /// <summary>
        /// 中间值
        /// </summary>
        public string regionName = "";

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
                HObject img = new HObject();
                RImage rImg = new RImage();

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
                HOperatorSet.ReduceDomain(mRImage, region, out img);
                HOperatorSet.CropDomain(img, out img);
                RImage.HObjToRImage(img, ref rImg);
                cropImage_Info.imageObj = rImg;

                //主界面窗体显示
                WindowShowROI();

                //保存对象
                SetVarList(ref mSloVar, new DataCell(ModInfo.Name, ModInfo.Encode, DataType.单量, DataMode.图像剪切, ConstVar.CropImage, ModInfo.Plugin, "0", 1, cropImage_Info, DataAtrr.全局变量));

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
            new CropImageForm((CropImageObj)baseMod).ShowDialog();
        }

        /// <summary>
        /// 在主窗体的图像窗口显示区域
        /// </summary>
        public void WindowShowROI()
        {
            if (cropImage_Info.imageObj != null && isShowReg)
            {
                cropImage_Info.imageObj.mHRoi.Clear();
                cropImage_Info.imageObj.mHText.Clear();
                cropImage_Info.imageObj.Screen = screenIndex;
            }
        }

        #endregion

        #region 方法-数据相关

        /// <summary>
        /// 如果数据内容是链接，则由GetLinkValue得到链接的值
        /// </summary>
        public void GetData()
        {
            if (regionName.Contains(":"))
            {
                region = (HObject)Var.GetLinkValue(mSysVar, mSloVar, regionName);
            }
        }

        #endregion
    }
}
