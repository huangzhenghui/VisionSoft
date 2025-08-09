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

namespace Plugin.ScaleGray
{
    [Category("图像处理")]
    [DisplayName("灰度缩放")]
    [Serializable]
    public class ScaleGrayObj : ObjBase
    {
        #region 字段、属性

        /// <summary>
        /// 图像名称
        /// </summary>
        public string mImages = "";

        /// <summary>
        /// 信息输出
        /// </summary>
        public ScaleGray_Info scaleGray_Info = new ScaleGray_Info();

        /// <summary>
        /// 缩放因子
        /// </summary>
        public int scaleFactor = 5;

        /// <summary>
        /// 偏移差量
        /// </summary>
        public int offset = -500;

        /// <summary>
        /// 是否显示
        /// </summary>
        public bool isShow = true;

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
                HOperatorSet.ScaleImage(mRImage, out img, scaleFactor, -offset);
                RImage.HObjToRImage(img, ref scaleGray_Info.imageObj);

                //主界面窗体显示
                WindowShowROI();

                //保存对象
                SetVarList(ref mSloVar, new DataCell(ModInfo.Name, ModInfo.Encode, DataType.单量, DataMode.灰度缩放, ConstVar.ScaleGray, ModInfo.Plugin, "0", 1, scaleGray_Info, DataAtrr.全局变量));

                Log.Info(ModInfo.Name + ":" + "执行成功");
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
            new ScaleGrayForm((ScaleGrayObj)baseMod).ShowDialog();
        }

        /// <summary>
        /// 在主窗体的图像窗口显示区域
        /// </summary>
        public void WindowShowROI()
        {
            if (scaleGray_Info.imageObj != null && isShow)
            {
                scaleGray_Info.imageObj.mHRoi.Clear();
                scaleGray_Info.imageObj.mHText.Clear();
                scaleGray_Info.imageObj.Screen = screenIndex;
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
            scaleGray_Info.imageObj = new RImage();
        }

        #endregion
    }
}
