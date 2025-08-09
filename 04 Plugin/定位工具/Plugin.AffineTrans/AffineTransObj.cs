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
using System.IO;
using System.Linq;
using System.Reflection;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.XPath;
using VisionCore;

namespace Plugin.AffineTrans
{
    [Category("定位工具")]
    [DisplayName("仿射变换")]
    [Serializable]
    public class AffineTransObj : ObjBase
    {
        #region 字段、属性

        /// <summary>
        /// 图像名称
        /// </summary>
        public string mImages = "";

        /// <summary>
        /// 仿射变换类
        /// </summary>
        public AffineTrans_Info affineTrans_Info = new AffineTrans_Info();

        /// <summary>
        /// 矩阵来源
        /// </summary>
        public string matrixSource = "参数创建";

        /// <summary>
        /// 矩阵类型
        /// </summary>
        public string matrixType = "平移/旋转";

        /// <summary>
        /// 原始点Row坐标
        /// </summary>
        [NonSerialized]
        public HTuple oldRow = new HTuple();

        /// <summary>
        /// 原始点Column坐标
        /// </summary>
        [NonSerialized]
        public HTuple oldCol = new HTuple();

        /// <summary>
        /// 原始点角度
        /// </summary>
        [NonSerialized]
        public HTuple oldA = new HTuple();

        /// <summary>
        /// 目标点Row坐标
        /// </summary>
        [NonSerialized]
        public HTuple aimRow = new HTuple();

        /// <summary>
        /// 目标点Column坐标
        /// </summary>
        [NonSerialized]
        public HTuple aimCol = new HTuple();

        /// <summary>
        /// 目标点角度
        /// </summary>
        [NonSerialized]
        public HTuple aimA = new HTuple();

        /// <summary>
        /// Row方向偏移量
        /// </summary>
        [NonSerialized]
        public HTuple offsetRow = new HTuple();

        /// <summary>
        /// Col方向偏移量
        /// </summary>
        [NonSerialized]
        public HTuple offsetCol = new HTuple();

        /// <summary>
        /// 中心点Row坐标
        /// </summary>
        [NonSerialized]
        public HTuple centerRow = new HTuple();

        /// <summary>
        /// 中心点Col坐标
        /// </summary>
        [NonSerialized]
        public HTuple centerCol = new HTuple();

        /// <summary>
        /// 旋转角度
        /// </summary>
        [NonSerialized]
        public HTuple angle = new HTuple();

        /// <summary>
        /// Row方向缩放因子
        /// </summary>
        [NonSerialized]
        public HTuple rowScale = new HTuple();

        /// <summary>
        /// Col方向缩放因子
        /// </summary>
        [NonSerialized]
        public HTuple colScale = new HTuple();

        /// <summary>
        /// 固定点Row坐标
        /// </summary>
        [NonSerialized]
        public HTuple fixRow = new HTuple();

        /// <summary>
        /// 固定点Col坐标
        /// </summary>
        [NonSerialized]
        public HTuple fixCol = new HTuple();

        /// <summary>
        /// 矩阵路径
        /// </summary>
        public string matPath = "";

        /// <summary>
        /// 左矩阵路径
        /// </summary>
        public string matLPath = "";

        /// <summary>
        /// 右矩阵路径
        /// </summary>
        public string matRPath = "";

        /// <summary>
        /// 仿射因素
        /// </summary>
        public string factor = "图像";

        /// <summary>
        /// 输入对象
        /// </summary>
        [NonSerialized]
        public HObject inputHObj = new HObject();

        /// <summary>
        /// 输入点Row坐标
        /// </summary>
        [NonSerialized]
        public HTuple pointRow = new HTuple();

        /// <summary>
        /// 输入点Col坐标
        /// </summary>
        [NonSerialized]
        public HTuple pointCol = new HTuple();

        /// <summary>
        /// 窗体索引
        /// </summary>
        public int screenIndex = 1;

        /// <summary>
        /// 显示颜色
        /// </summary>
        public string showColor = "#00FF00";

        /// <summary>
        /// 是否保存
        /// </summary>
        public bool isSave = true;

        /// <summary>
        /// 保存路径
        /// </summary>
        public string savePath = "";

        /// <summary>
        /// 中间值
        /// </summary>
        public string strOldRow = "0", strOldCol = "0", strOldA = "0", strAimRow = "0", strAimCol = "0", strAimA = "0", strOffsetRow = "0", strOffsetCol = "0", strCenterRow = "0", strCenterCol = "0",
                      strAngle = "0", strRowScale = "1", strColScale = "1", strFixRow = "0", strFixCol = "0", strInputHObj = "", strPointRow = "0", strPointCol = "0";

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
                HTuple mat = new HTuple();
                HTuple resultPointRow = new HTuple();
                HTuple resultPointCol = new HTuple();
                RImage resultImg = new RImage();
                HObject resultObj = new HObject();

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
                AffineTrans(out mat, out resultImg, out resultObj, out resultPointRow, out resultPointCol);

                //状态更新
                exeResult = "执行成功";

                //更新数据
                affineTrans_Info.affineMat = mat;
                affineTrans_Info.resultImg = resultImg;
                affineTrans_Info.resultObj = resultObj;
                affineTrans_Info.resultPointRow = resultPointRow;
                affineTrans_Info.resultPointCol = resultPointCol;

                //主界面窗体显示
                WindowShowHObj();

                //保存对象
                SetVarList(ref mSloVar, new DataCell(ModInfo.Name, ModInfo.Encode, DataType.单量, DataMode.仿射变换, ConstVar.AffineMatrix, ModInfo.Plugin, "0", 1, affineTrans_Info, DataAtrr.全局变量));

                Log.Info(Sol.mSol.mProjList[ModInfo.Index].mProjInfo.Name + ": " + ModInfo.Name + ":" + "执行成功");
                ModInfo.State = ModState.OK;
                return true;
            }
            catch (Exception ex)
            {
                exeResult = "执行失败";
                Log.Error(Sol.mSol.mProjList[ModInfo.Index].mProjInfo.Name + ": " + ModInfo.Name + ":" + "执行失败(" + "原因：" + ex.Message + ")");
                ModInfo.State = ModState.NG;
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
            new AffineTransForm((AffineTransObj)baseMod).ShowDialog();
        }

        /// <summary>
        /// 在主窗体的图像窗口显示HObject对象
        /// </summary>
        public void WindowShowHObj()
        {
            if (!isShowReg) return;

            switch (factor)
            {
                case "图像":
                    affineTrans_Info.resultImg.mHRoi.Clear();
                    affineTrans_Info.resultImg.mHText.Clear();
                    affineTrans_Info.resultImg.Screen = screenIndex;
                    break;
                case "轮廓":
                    HRoi resultContour = new HRoi(ModInfo.Encode, ModInfo.Name, ModInfo.Remarks, HRoiType.检测结果, showColor, affineTrans_Info.resultObj);
                    mRImage.ShowHRoi(resultContour);
                    break;
                case "区域":
                    HRoi resultRegion = new HRoi(ModInfo.Encode, ModInfo.Name, ModInfo.Remarks, HRoiType.检测结果, showColor, affineTrans_Info.resultObj);
                    mRImage.ShowHRoi(resultRegion);
                    break;
                case "点位":
                    HRoi resultPoint = new HRoi(ModInfo.Encode, ModInfo.Name, ModInfo.Remarks, HRoiType.检测结果, showColor, affineTrans_Info.resultObj);
                    mRImage.ShowHRoi(resultPoint);
                    break;
            }
        }

        #endregion

        #region 方法-数据相关

        /// <summary>
        /// 初始化输出变量
        /// </summary>
        public override void InitOutputInfo()
        {
            affineTrans_Info.affineMat = new HTuple();
            affineTrans_Info.resultPointRow = new HTuple();
            affineTrans_Info.resultPointCol = new HTuple();
            affineTrans_Info.resultImg = new RImage();
            affineTrans_Info.resultObj = new HObject();
        }

        /// <summary>
        /// 如果数据内容是链接，则由GetLinkValue得到链接的值
        /// </summary>
        public void GetData()
        {
            try
            {
                oldRow = Var.AcqValue_HTuple(strOldRow, mSysVar, mSloVar);
                oldCol = Var.AcqValue_HTuple(strOldCol, mSysVar, mSloVar);
                oldA = Var.AcqValue_HTuple(strOldA, mSysVar, mSloVar);
                aimRow = Var.AcqValue_HTuple(strAimRow, mSysVar, mSloVar);
                aimCol = Var.AcqValue_HTuple(strAimCol, mSysVar, mSloVar);
                aimA = Var.AcqValue_HTuple(strAimA, mSysVar, mSloVar);
                offsetRow = Var.AcqValue_HTuple(strOffsetRow, mSysVar, mSloVar);
                offsetCol = Var.AcqValue_HTuple(strOffsetCol, mSysVar, mSloVar);
                centerRow = Var.AcqValue_HTuple(strCenterRow, mSysVar, mSloVar);
                centerCol = Var.AcqValue_HTuple(strCenterCol, mSysVar, mSloVar);
                angle = Var.AcqValue_HTuple(strAngle, mSysVar, mSloVar);
                rowScale = Var.AcqValue_HTuple(strRowScale, mSysVar, mSloVar);
                colScale = Var.AcqValue_HTuple(strColScale, mSysVar, mSloVar);
                fixRow = Var.AcqValue_HTuple(strFixRow, mSysVar, mSloVar);
                fixCol = Var.AcqValue_HTuple(strFixCol, mSysVar, mSloVar);
                pointRow = Var.AcqValue_HTuple(strPointRow, mSysVar, mSloVar);
                pointCol = Var.AcqValue_HTuple(strPointCol, mSysVar, mSloVar);
                switch (factor)
                {
                    case"点位":
                        HTuple width = new HTuple();
                        HTuple height = new HTuple();
                        HOperatorSet.GetImageSize(mRImage, out width, out height);
                        HOperatorSet.GenCrossContourXld(out inputHObj, pointRow, pointCol, 0.02 * width, 0.785398);
                        break;
                    case "区域":
                        inputHObj = Var.AcqValue_HObject(strInputHObj, mSysVar, mSloVar);
                        break;
                    case "轮廓":
                        inputHObj = Var.AcqValue_HObject(strInputHObj, mSysVar, mSloVar);
                        break;
                }
            }
            catch { }
        }

        #endregion

        #region 方法-算法相关

        public void AffineTrans(out HTuple mat, out RImage resultImg, out HObject resultObj, out HTuple resultPointRow, out HTuple resultPointCol)
        {
            mat = new HTuple();
            resultPointRow = new HTuple();
            resultPointCol = new HTuple();
            resultImg = new RImage();
            resultObj = new HObject();
            HTuple matLeft = new HTuple();
            HTuple matRight = new HTuple();
            HTuple outPointRow = new HTuple();
            HTuple outPointCol = new HTuple();
            HTuple width = new HTuple();
            HTuple height = new HTuple();

            HOperatorSet.HomMat2dIdentity(out mat);
            HOperatorSet.HomMat2dIdentity(out matLeft);
            HOperatorSet.HomMat2dIdentity(out matRight);

            switch (matrixType)
            {
                case "九点标定":
                    HOperatorSet.ReadTuple(matPath, out mat);
                    break;
                case "平移/旋转":
                    switch (matrixSource)
                    {
                        case "参数创建":
                            HOperatorSet.VectorAngleToRigid(oldRow, oldCol, oldA, aimRow, aimCol, aimA, out mat);
                            break;
                        case "文件读取":
                            HOperatorSet.ReadTuple(matPath, out mat);
                            break;
                    }
                    break;
                case "平移":
                    switch (matrixSource)
                    {
                        case "参数创建":
                            HOperatorSet.HomMat2dTranslate(mat, offsetRow, offsetCol, out mat);
                            break;
                        case "文件读取":
                            HOperatorSet.ReadTuple(matPath, out mat);
                            break;
                    }
                    break;
                case "旋转":
                    switch (matrixSource)
                    {
                        case "参数创建":
                            HOperatorSet.HomMat2dRotate(mat, angle, centerRow, centerCol, out mat);
                            break;
                        case "文件读取":
                            HOperatorSet.ReadTuple(matPath, out mat);
                            break;
                    }
                    break;
                case "缩放":
                    switch (matrixSource)
                    {
                        case "参数创建":
                            HOperatorSet.HomMat2dScale(mat, rowScale, colScale, fixRow, fixCol, out mat);
                            break;
                        case "文件读取":
                            HOperatorSet.ReadTuple(matPath, out mat);
                            break;
                    }
                    break;
                case "反转":
                    HOperatorSet.ReadTuple(matPath, out mat);
                    break;
                case "相乘":
                    HOperatorSet.ReadTuple(matLPath, out matLeft);
                    HOperatorSet.ReadTuple(matRPath, out matRight);
                    HOperatorSet.HomMat2dCompose(matLeft, matRight, out mat);
                    break;
            }

            switch (factor)
            {
                case "图像":
                    HObject img;
                    HOperatorSet.GenEmptyObj(out img);
                    affineTrans_Info.resultImg = new RImage();
                    HOperatorSet.AffineTransImage(mRImage, out img, mat, "constant", "false");
                    RImage.HObjToRImage(img, ref resultImg);
                    break;
                case "轮廓":
                    HOperatorSet.AffineTransContourXld(inputHObj, out resultObj, mat);
                    break;
                case "区域":
                    HOperatorSet.AffineTransRegion(inputHObj, out resultObj, mat, "nearest_neighbor");
                    break;
                case "点位":
                    HOperatorSet.GetImageSize(mRImage, out width, out height);
                    HOperatorSet.AffineTransPoint2d(mat, pointRow, pointCol, out resultPointRow, out resultPointCol);
                    HOperatorSet.GenCrossContourXld(out resultObj, resultPointRow, resultPointCol, 0.02 * width, 0.785398);
                    break;
                default:
                    break;
            }

            //文件保存
            if (isSave)
            {
                if (matrixSource == "创建")
                {
                    HOperatorSet.WriteTuple(mat, savePath);
                }
            }
            else
            {
                if (matrixSource == "创建" && File.Exists(savePath))
                {
                    HOperatorSet.DeleteFile(savePath);
                }
            }
        }

        #endregion
    }
}
