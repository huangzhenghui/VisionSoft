using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using VisionCore;
using System.IO;
using RexConst;
using System.Windows.Forms;
using HalconDotNet;
using System.Collections.Generic;
using System.Collections;
using System.Drawing;
using MutualTools;

namespace Plugin.CaptureImage
{
    [Category("图像处理")]
    [DisplayName("图像采集")]
    [Serializable]
    public class CaptureImageObj : ObjBase
    {
        #region 字段、属性

        /// <summary>
        /// 输出对象
        /// </summary>
        public CaptureImage_Info captureImage_Info = new CaptureImage_Info();

        /// <summary>
        /// 图像索引
        /// </summary>
        public int index = 0;

        /// <summary>
        /// 窗体索引
        /// </summary>
        public int mScreen = 1;

        /// <summary>
        /// 循环读取
        /// </summary>
        public bool mForRead = true;

        /// <summary>
        /// 相机名称
        /// </summary>
        public string mCamName="None";

        /// <summary>
        /// 图像路径
        /// </summary>
        public string mImagePath=@"D:\img";

        /// <summary>
        /// 文件夹路径
        /// </summary>
        public string mFolderPath = @"D:\img";

        /// <summary>
        /// 路径集合
        /// </summary>
        public List<string> mFileInfo = new List<string>();

        /// <summary>
        /// 图像源
        /// </summary>
        public ImageSource imageSource = ImageSource.指定图像;

        /// <summary>
        /// 图像处理方式
        /// </summary>
        public ImgProcMode imgProcMode = ImgProcMode.无;

        /// <summary>
        /// 是否使用像素精度
        /// </summary>
        public bool isUsePixelProc = false;

        /// <summary>
        /// 选中的相机对象
        /// </summary>
        public CamerasBase mCamerasBase = new CamerasBase();

        /// <summary>
        /// 窗体索引
        /// </summary>
        public int screenIndex = 0;

        /// <summary>
        /// 中间值
        /// </summary>
        public string strPixelPrec = "0.01";

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
                //初始化输出变量
                InitOutputInfo();

                //执行算法
                switch (imageSource)
                {
                    case ImageSource.指定图像:
                        mRImage = RImage.ReadRImage(mImagePath);
                        break;
                    case ImageSource.文件目录:
                        if (mFileInfo == null) return false;
                        mRImage = RImage.ReadRImage(mFileInfo[index]);
                        int count = mFileInfo.Count;
                        if (mForRead)
                        {
                            ++index;
                            if (index > count - 1)
                            {
                                index = 0;
                            }
                        }
                        break;
                    case ImageSource.相机采集:
                        if (mCamerasBase != null && mCamerasBase.mConnected)
                        {
                            mCamerasBase.CaptureImage(true);
                            mRImage = (RImage)mCamerasBase.Image;
                            mRImage.Name = mCamerasBase.mCamName;
                        }
                        else
                        {
                            mRImage = null;
                            mCamerasBase.EventWait.Set();
                        }
                        break;
                }

                if (mRImage == null)
                {
                    Log.Error(Sol.mSol.mProjList[ModInfo.Index].mProjInfo.Name + ": " + ModInfo.Name + ":" + "执行失败(原因：未读取到图像)");
                    ModInfo.State = ModState.NG;
                    return false;
                }

                HObject img = new HObject();

                switch (imgProcMode)
                {
                    case ImgProcMode.无:
                        img = mRImage;
                        break;
                    case ImgProcMode.旋转90度:
                        HOperatorSet.RotateImage(mRImage, out img, 90, "constant");
                        break;
                    case ImgProcMode.旋转180度:
                        HOperatorSet.RotateImage(mRImage, out img, 180, "constant");
                        break;
                    case ImgProcMode.旋转270度:
                        HOperatorSet.RotateImage(mRImage, out img, 270, "constant");
                        break;
                    case ImgProcMode.X镜像:
                        HOperatorSet.MirrorImage(mRImage, out img, "column");
                        break;
                    case ImgProcMode.Y镜像:
                        HOperatorSet.MirrorImage(mRImage, out img, "row");
                        break;
                }

                //更新数据
                captureImage_Info.imageObj = new RImage(img);

                //主界面窗体显示
                WindowShowROI();

                //保存对象
                SetVarList(ref mSloVar, new DataCell(ModInfo.Name, ModInfo.Encode, DataType.单量, DataMode.图像采集, ConstVar.CaptureImage, ModInfo.Plugin, "0", 1, captureImage_Info, DataAtrr.全局变量));

                Log.Info(Sol.mSol.mProjList[ModInfo.Index].mProjInfo.Name + ": " + ModInfo.Name + ":" + "执行成功");
                ModInfo.State = ModState.OK;
                return true;
            }
            catch (Exception ex)
            {
                mRImage = null;
                ModInfo.State = ModState.NG;
                Log.Error(Sol.mSol.mProjList[ModInfo.Index].mProjInfo.Name + ": " + ModInfo.Name + ":" + ex.Message);
                return  false;
            }
        }

        #endregion

        #region 方法-窗体相关

        /// <summary>
        /// 窗体显示
        /// </summary>
        /// <param name="BaseMod"></param>
        public override void RunForm(ObjBase BaseMod)
        {
          new CaptureImageForm((CaptureImageObj)BaseMod).ShowDialog();
        }

        /// <summary>
        /// 在主窗体的图像窗口显示区域/轮廓/信息等
        /// </summary>
        public void WindowShowROI()
        {
            if (mRImage != null && mRImage.IsInitialized())
            {
                captureImage_Info.imageObj.Screen = screenIndex;

                if (isShowData)
                {
                    HText text;
                    if (prefix != "")
                    {
                        text = new HText(ModInfo.Encode, ModInfo.Name, ModInfo.Remarks, HRoiType.文字显示, resultColor, prefix + ":" + mRImage.Name, fontType, Y, X, fontSize, captureImage_Info.imageObj, false);
                    }
                    else
                    {
                        text = new HText(ModInfo.Encode, ModInfo.Name, ModInfo.Remarks, HRoiType.文字显示, resultColor, mRImage.Name, fontType, Y, X, fontSize, captureImage_Info.imageObj, false);
                    }
                    captureImage_Info.imageObj.ShowHText(text);
                }
            }
        }

        #endregion

        #region 方法-数据相关

        /// <summary>
        /// 初始化输出变量
        /// </summary>
        public override void InitOutputInfo()
        {
            captureImage_Info.imageObj = new RImage();
        }

        /// <summary>
        /// 如果数据内容是链接，则由GetLinkValue得到链接的值
        /// </summary>
        public void GetData()
        {
            try
            {
                if (strPixelPrec.Contains(":"))
                {
                    mRImage.PixelPrec = new HTuple(Var.GetLinkValue(mSysVar, mSloVar, strPixelPrec)).TupleNumber();
                }
                else
                {
                    if (TypeConvert.StringToHTuple(strPixelPrec).TupleIsNumber() == 0) throw new Exception("异常");
                    mRImage.PixelPrec = TypeConvert.StringToHTuple(strPixelPrec);
                }
            }
            catch { }
        }

        #endregion
    }
}
