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

namespace Plugin.EdgeDetection
{
    [Category("检测识别")]
    [DisplayName("边缘检测")]
    [Serializable]
    public class EdgeDetectionObj : ObjBase
    {
        #region 字段、属性

        /// <summary>
        /// 图像名称
        /// </summary>
        public string mImages = "";

        /// <summary>
        /// 输出信息
        /// </summary>
        public EdgeDetection_Info edgeDetection_Info = new EdgeDetection_Info();

        /// <summary>
        /// 滤波器类型
        /// </summary>
        public string filterType;

        /// <summary>
        /// 掩模大小
        /// </summary>
        public string size;

        /// <summary>
        /// 窗体索引
        /// </summary>
        public int mScreen = 1;

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
                HObject outImage;
                HOperatorSet.GenEmptyObj(out outImage);
                mRImageResult = new RImage();
                mRImageResult.mHRoi.Clear();
                mRImageResult.mHText.Clear();
                mRImageResult.Screen = mScreen;

                if ((RImage)Var.GetImage(mSloVar, mImages) == null)
                {
                    ModInfo.State = ModState.NG;
                    return false;
                }
                else
                {
                    mRImage = (RImage)Var.GetImage(mSloVar, mImages);
                }

                HOperatorSet.SobelAmp(mRImage, out outImage, filterType, Convert.ToDouble(size));
                RImage.HObjToRImage(outImage, ref mRImageResult);

                //保存数据
                edgeDetection_Info.imageObj = mRImageResult;
                SetVarList(ref mSloVar, new DataCell(ModInfo.Name, ModInfo.Encode, DataType.单量, DataMode.边缘检测, ConstVar.EdgeDetection, ModInfo.Plugin, "0", 1, edgeDetection_Info, DataAtrr.全局变量));
            }
            catch(Exception ex)
            {
                Log.Error(ModInfo.Name + ":" + ex.Message);
                ModInfo.State = ModState.NG;
                mRImageResult = null;
                return false;
            }

            Log.Error(ModInfo.Name + ":" + "执行成功");
            ModInfo.State = ModState.OK;
            return true;
        }

        #endregion

        #region 方法-窗体相关

        /// <summary>
        /// 显示窗体
        /// </summary>
        /// <param name="baseMod"></param>
        public override void RunForm(ObjBase baseMod)
        {
            new EdgeDetectionForm((EdgeDetectionObj)baseMod).ShowDialog();
        }

        #endregion
    }
}
