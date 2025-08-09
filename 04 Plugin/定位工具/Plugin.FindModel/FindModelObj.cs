using HalconDotNet;
using MutualTools;
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

namespace Plugin.FindModel
{
    [Category("定位工具")]
    [DisplayName("查找模板")]
    [Serializable]
    public class FindModelObj : ObjBase
    {
        #region 字段、属性

        /// <summary>
        /// 图像名称
        /// </summary>
        public string mImages = "";

        /// <summary>
        /// 信息输出
        /// </summary>
        public FindModel_Info findModel_Info = new FindModel_Info();

        /// <summary>
        /// 模板因素
        /// </summary>
        public string factor = "形状";

        /// <summary>
        /// 模板路径
        /// </summary>
        public string modelPath;

        /// <summary>
        /// 模板句柄
        /// </summary>
        public HTuple modelHandle;

        /// <summary>
        /// 金字塔层数
        /// </summary>
        public int numLevels = 0;

        /// <summary>
        /// 起始角度
        /// </summary>
        public double angleStart = -Math.PI / 2;

        /// <summary>
        /// 角度范围
        /// </summary>
        public double angleExtent = Math.PI;

        /// <summary>
        /// 最小分数
        /// </summary>
        public double minScore = 0.7;

        /// <summary>
        /// 匹配数量
        /// </summary>
        public int numMatches = 1;

        /// <summary>
        /// 最大重叠
        /// </summary>
        public double maxOverlap = 0.5;

        /// <summary>
        /// 是否采用亚像素
        /// </summary>
        public string isSubPixel = "true";

        /// <summary>
        /// 最小缩放
        /// </summary>
        public double scaleMin = 0.8;

        /// <summary>
        /// 最大缩放
        /// </summary>
        public double scaleMax = 1.2;

        /// <summary>
        /// 贪婪程度
        /// </summary>
        public double greediness = 0.9;

        /// <summary>
        /// 插值算法
        /// </summary>
        public string interAlgo = "least_squares";

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
                HObject imgReduced;
                HOperatorSet.GenEmptyObj(out imgReduced);
                HTuple resultMidR = new HTuple();
                HTuple resultMidC = new HTuple();
                HTuple resultAngle = new HTuple();
                HTuple resultScale = new HTuple();
                HTuple resultScore = new HTuple();
                HTuple resultNum = new HTuple();
                HObject resultObj = new HObject();

                //初始化输出变量
                InitOutputInfo();

                //设置可绘制区域的大小
                HOperatorSet.SetSystem("width", 20000);
                HOperatorSet.SetSystem("height", 20000);

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
                FindModel(factor, out resultMidR, out resultMidC, out resultAngle, out resultScore, out resultNum, out resultObj);

                //状态更新
                exeResult = "执行成功";

                //更新数据
                findModel_Info.resultMidR = resultMidR;
                findModel_Info.resultMidC = resultMidC;
                findModel_Info.resultAngle = resultAngle;
                findModel_Info.resultScore = resultScore;
                findModel_Info.resultNum = resultNum;
                findModel_Info.resultObj = resultObj;

                //主界面窗体显示
                WindowShowHObj();

                //保存对象
                SetVarList(ref mSloVar, new DataCell(ModInfo.Name, ModInfo.Encode, DataType.单量, DataMode.查找模板, ConstVar.Model, ModInfo.Plugin, "0", 1, findModel_Info, DataAtrr.全局变量));

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
            new FindModelForm((FindModelObj)baseMod).ShowDialog();
        }

        /// <summary>
        /// 在主窗体的图像窗口显示区域
        /// </summary>
        public void WindowShowHObj()
        {
            if (isShowData)
            {
                HText text;
                string strInfo = TypeConvert.HTupleToString(findModel_Info.resultNum);
                if (prefix != "")
                {
                    text = new HText(ModInfo.Encode, ModInfo.Name, ModInfo.Remarks, HRoiType.文字显示, fontColor, prefix + ":" + strInfo, fontType, Y, X, fontSize, mRImage, false);
                }
                else
                {
                    text = new HText(ModInfo.Encode, ModInfo.Name, ModInfo.Remarks, HRoiType.文字显示, fontColor, strInfo, fontType, Y, X, fontSize, mRImage, false);
                }

                mRImage.ShowHText(text);
            }

            if (isShowReg)
            {
                HRoi linesResult = new HRoi(ModInfo.Encode, ModInfo.Name, ModInfo.Remarks, HRoiType.轮廓, resultColor, new HObject(findModel_Info.resultObj));
                mRImage.ShowHRoi(linesResult);
            }
        }

        #endregion

        #region 方法-数据相关

        /// <summary>
        /// 初始化输出变量
        /// </summary>
        public override void InitOutputInfo()
        {
            findModel_Info.resultMidR = new HTuple();
            findModel_Info.resultMidC = new HTuple();
            findModel_Info.resultAngle = new HTuple();
            findModel_Info.resultScore = new HTuple();
            findModel_Info.resultNum = new HTuple();
        }

        /// <summary>
        /// 如果数据内容是链接，则由GetLinkValue得到链接的值
        /// </summary>
        public void GetData()
        {
            try
            {
                HTuple modelID = new HTuple();
                switch (factor)
                {
                    case"相关性":
                        HOperatorSet.ReadNccModel(modelPath, out modelID);
                        break;
                    case "形状":
                        HOperatorSet.ReadShapeModel(modelPath, out modelID);
                        break;
                }

                modelHandle = modelID;
            }
            catch { }
        }

        #endregion

        #region 方法-算法相关

        public void FindModel(string factor, out HTuple resultMidR, out HTuple resultMidC, out HTuple resultAngle, out HTuple resultScore, out HTuple resultNum, out HObject resultObj)
        {
            resultMidR = new HTuple();
            resultMidC = new HTuple();
            resultAngle = new HTuple();
            resultScore = new HTuple();
            resultNum = new HTuple();
            resultObj = new HObject();
            HTuple resultScale = new HTuple();
            HTuple mat2D = new HTuple();
            HObject modelObj = new HObject();
            HObject modelObjTrans = new HObject();

            if (factor == "相关性")
            {
                HOperatorSet.FindNccModel(mRImage, modelHandle, angleStart, angleExtent, minScore, numMatches, maxOverlap, isSubPixel, numLevels, out resultMidR, out resultMidC, out resultAngle, out resultScore);
                HOperatorSet.GetNccModelRegion(out modelObj, modelHandle);
            }
            else
            {
                HOperatorSet.FindScaledShapeModel(mRImage, modelHandle, angleStart, angleExtent, scaleMin, scaleMax, minScore, numMatches, maxOverlap, interAlgo, numLevels, greediness, out resultMidR, out resultMidC, out resultAngle, out resultScale, out resultScore);
                HOperatorSet.GetShapeModelContours(out modelObj, modelHandle, 1);
            }

            //仿射模板到匹配位置
            if (factor == "相关性")
            {
                for (int i = 0; i < resultScore.Length; i++)
                {
                    HOperatorSet.HomMat2dIdentity(out mat2D);
                    HOperatorSet.HomMat2dTranslate(mat2D, resultMidR[i], resultMidC[i], out mat2D);
                    HOperatorSet.HomMat2dRotate(mat2D, resultAngle[i], resultMidR[i], resultMidC[i], out mat2D);
                    HOperatorSet.AffineTransRegion(modelObj, out modelObjTrans, mat2D, "nearest_neighbor");
                    if (!resultObj.IsInitialized())
                    {
                        resultObj = modelObjTrans;
                    }
                    else
                    {
                        HOperatorSet.ConcatObj(resultObj, modelObjTrans, out resultObj);
                    }
                }
            }
            else
            {
                for (int i = 0; i < resultScore.Length; i++)
                {
                    HOperatorSet.HomMat2dIdentity(out mat2D);
                    HOperatorSet.HomMat2dTranslate(mat2D, resultMidR[i], resultMidC[i], out mat2D);
                    HOperatorSet.HomMat2dRotate(mat2D, resultAngle[i], resultMidR[i], resultMidC[i], out mat2D);
                    HOperatorSet.HomMat2dScale(mat2D, resultScale[i], resultScale[i], resultMidR[i], resultMidC[i], out mat2D);
                    HOperatorSet.AffineTransContourXld(modelObj, out modelObjTrans, mat2D);
                    if (!resultObj.IsInitialized())
                    {
                        resultObj = modelObjTrans;
                    }
                    else
                    {
                        HOperatorSet.ConcatObj(resultObj, modelObjTrans, out resultObj);
                    }
                }
            }

            resultNum = resultObj.CountObj();
        }

        #endregion
    }
}
