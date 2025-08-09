using HalconDotNet;
using Plugin.CreateROI;
using Rex.UI;
using RexConst;
using RexView;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using VisionCore;
using RexHelps;
using System.IO;
using RexForm;

namespace Plugin.SaveImage
{
    [Category("图像处理")]
    [DisplayName("图像保存")]
    [Serializable]
    public class SaveImageObj : ObjBase
    {
        #region 字段、属性

        /// <summary>
        /// 图像样式
        /// </summary>
        public int imgType = 1;

        /// <summary>
        /// 图像链接
        /// </summary>
        public string mImages = "";

        /// <summary>
        /// 文件夹名称
        /// </summary>
        public string fileName = "";

        /// <summary>
        /// 图像名称
        /// </summary>
        public string imgName = "";

        /// <summary>
        /// 存储格式
        /// </summary>
        public string storeFormat = "";

        /// <summary>
        /// INI文件操作类
        /// </summary>
        public static RIni mRini = new RIni(Application.StartupPath + "\\Config.ini");//配置文件地址

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
                //获取数据
                GetData();

                string overallpath = mRini.ReadValue("Config", "mSaveImgPath", "");
                string firstPath = overallpath + "\\" + DateTime.Now.ToString("yyyyMMd");
                string secondPath = firstPath + "\\" + fileName;
                string imgPath = "";

                if (imgName != "")
                {
                    imgPath = secondPath + "\\" + imgName + "_" + DateTime.Now.ToString("HHmmss");
                }
                else
                {
                    imgPath = secondPath + "\\" + DateTime.Now.ToString("HHmmss");
                }

                if (!Directory.Exists(secondPath))
                {
                    Directory.CreateDirectory(secondPath); //在指定路径中创建所有目录。
                }

                switch (imgType)
                {
                    case 0:
                        HOperatorSet.WriteImage(mRImage, storeFormat, 0, imgPath);
                        break;
                    case 1:
                        HObject hObj;
                        HOperatorSet.GenEmptyObj(out hObj);
                        HWindow hv_window = ViewDic.GetView(mRImage.Screen).hControl.HalconWindow;
                        HOperatorSet.DumpWindowImage(out hObj, hv_window);
                        HOperatorSet.WriteImage(hObj, storeFormat, 0, imgPath);
                        break;
                }


                Log.Info(Sol.mSol.mProjList[ModInfo.Index].mProjInfo.Name + ": " + ModInfo.Name + ":" + "图像保存成功");
                ModInfo.State = ModState.OK;
                return true;
            }
            catch (Exception ex)
            {
                Log.Info(Sol.mSol.mProjList[ModInfo.Index].mProjInfo.Name + ": " + ModInfo.Name + ":" + ex.Message);
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
            try
            {
                if (mImages.Contains(":"))
                {
                    mRImage = (RImage)Var.GetImage(mSloVar, mImages);
                }
            }
            catch { }
        }

        #endregion

        #region 方法-窗体相关

        /// <summary>
        /// 显示窗体
        /// </summary>
        /// <param name="baseMod"></param>
        public override void RunForm(ObjBase baseMod)
        {
            new SaveImageForm((SaveImageObj)baseMod).ShowDialog();
        }

        #endregion
    }
}
