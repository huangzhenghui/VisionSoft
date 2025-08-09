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
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.XPath;
using VisionCore;

namespace Plugin.CreateModel
{
    [Category("定位工具")]
    [DisplayName("创建模板")]
    [Serializable]
    public class CreateModelObj : ObjBase
    {
        #region 字段、属性

        /// <summary>
        /// 图像名称
        /// </summary>
        public string mImages = "";

        /// <summary>
        /// 信息输出
        /// </summary>
        public CreateModel_Info createModel_Info = new CreateModel_Info();

        /// <summary>
        /// 模板因素
        /// </summary>
        public string factor = "形状";

        /// <summary>
        /// 模板区域
        /// </summary>
        [NonSerialized]
        public HObject modRegion;

        /// <summary>
        /// 模板轮廓
        /// </summary>
        [NonSerialized]
        public HObject modContour;

        /// <summary>
        /// 轮廓精度
        /// </summary>
        public string precision = "亚像素";

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
        /// 角度步长
        /// </summary>
        public double angleStep = Math.PI / 36;

        /// <summary>
        /// 最小缩放
        /// </summary>
        public double scaleMin = 0.8;

        /// <summary>
        /// 最大缩放
        /// </summary>
        public double scaleMax = 1.2;

        /// <summary>
        /// 缩放步长
        /// </summary>
        public double scaleStep = 0.1;

        /// <summary>
        /// 优化方法
        /// </summary>
        public string optimization = "auto";

        /// <summary>
        /// 最小对比度
        /// </summary>
        public double minContrast = 5;

        /// <summary>
        /// 对比度
        /// </summary>
        public string contrast = "auto";

        /// <summary>
        /// 匹配规则
        /// </summary>
        public string metric = "ignore_global_polarity";

        /// <summary>
        /// 模板名称
        /// </summary>
        public string modelName = "模板";

        /// <summary>
        /// 模板保存路径
        /// </summary>
        public string modelPath = Application.StartupPath + "\\Model";

        /// <summary>
        /// 中间变量
        /// </summary>
        public string strModRegion = "", strModContour = "";

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
                HTuple modelMidR = new HTuple();
                HTuple modelMidC = new HTuple();
                HTuple modelA = new HTuple();
                HTuple modID = new HTuple();
                HObject modelObj = new HObject();

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
                CreateModel(out modelMidR, out modelMidC, out modelA, out modelObj, out modID);

                //状态更新
                exeResult = "执行成功";

                //更新数据
                createModel_Info.modelMidR = modelMidR;
                createModel_Info.modelMidC = modelMidC;
                createModel_Info.modelAngle = modelA;
                createModel_Info.modelHandle = modID;

                //主界面窗体显示
                WindowShowROI();

                //保存对象
                SetVarList(ref mSloVar, new DataCell(ModInfo.Name, ModInfo.Encode, DataType.单量, DataMode.创建模板, ConstVar.Model, ModInfo.Plugin, "0", 1, createModel_Info, DataAtrr.全局变量));

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
            new CreateModelForm((CreateModelObj)baseMod).ShowDialog();
        }

        /// <summary>
        /// 在主窗体的图像窗口显示区域
        /// </summary>
        public void WindowShowROI() { }

        #endregion

        #region 方法-数据相关

        /// <summary>
        /// 初始化输出变量
        /// </summary>
        public override void InitOutputInfo()
        {
            createModel_Info.modelMidR = new HTuple();
            createModel_Info.modelMidC = new HTuple();
            createModel_Info.modelAngle = new HTuple();
            createModel_Info.modelObj = new HObject();
        }

        /// <summary>
        /// 如果数据内容是链接，则由GetLinkValue得到链接的值
        /// </summary>
        public void GetData()
        {
            try
            {
                modRegion = Var.AcqValue_HObject(strModRegion, mSysVar, mSloVar);
                modContour = Var.AcqValue_HObject(strModContour, mSysVar, mSloVar);
            }
            catch { }
        }

        #endregion

        #region 方法-算法相关

        public void CreateModel(out HTuple modelMidR, out HTuple modelMidC, out HTuple modelA, out HObject modelObj, out HTuple modID)
        {
            modelMidR = new HTuple();
            modelMidC = new HTuple();
            modelA = new HTuple();
            modID = new HTuple();
            modelObj = new HObject();
            HTuple modelRad = new HTuple();
            HTuple score = new HTuple();
            HTuple scale = new HTuple();
            HObject modObj = new HObject();
            HTuple mat2D = new HTuple();

            if (factor == "相关性")
            {
                HObject imgReduced = new HObject();
                HOperatorSet.ReduceDomain(mRImage, modRegion, out imgReduced);
                HOperatorSet.CreateNccModel(imgReduced, numLevels, angleStart, angleExtent, angleStep, metric, out modID);
                HOperatorSet.FindNccModel(mRImage, modID, -Math.PI / 8, Math.PI / 4, 0.8, 1, 0.5, "true", numLevels, out modelMidR, out modelMidC, out modelRad, out score);
                HOperatorSet.GetNccModelRegion(out modObj, modID);
                HOperatorSet.HomMat2dIdentity(out mat2D);
                HOperatorSet.HomMat2dTranslate(mat2D, modelMidR, modelMidC, out mat2D);
                HOperatorSet.HomMat2dRotate(mat2D, modelA, modelMidR, modelMidC, out mat2D);
                HOperatorSet.AffineTransRegion(modObj, out modelObj, mat2D, "nearest_neighbor");
            }
            else
            {
                switch (precision)
                {
                    case "像素":
                        HOperatorSet.CreateScaledShapeModel(modContour, numLevels, angleStart, angleExtent, angleStep, scaleMin, scaleMax, scaleStep, optimization, metric, contrast, minContrast, out modID);
                        break;
                    case "亚像素":
                        HOperatorSet.CreateScaledShapeModelXld(modContour, 2, angleStart, angleExtent, angleStep, scaleMin, scaleMax, scaleStep, optimization, metric, minContrast, out modID);
                        break;
                }

                HOperatorSet.FindScaledShapeModel(mRImage, modID, -Math.PI / 8, Math.PI / 4, 0.8, 1.2, 0.8, 1, 0.5, "least_squares", 2, 0.8, out modelMidR, out modelMidC, out modelRad, out scale, out score);
                HOperatorSet.GetShapeModelContours(out modObj, modID, 1);
                HOperatorSet.HomMat2dIdentity(out mat2D);
                HOperatorSet.HomMat2dTranslate(mat2D, modelMidR, modelMidC, out mat2D);
                HOperatorSet.HomMat2dRotate(mat2D, modelRad, modelMidR, modelMidC, out mat2D);
                HOperatorSet.HomMat2dScale(mat2D, scale, scale, modelMidR, modelMidC, out mat2D);
                HOperatorSet.AffineTransContourXld(modObj, out modelObj, mat2D);
            }

            modelA = modelRad;

            //保存路径
            string[] assem = modelPath.Split("\\");
            string modSavePath = "";
            string coordSavePath = "";
            for (int i = 0; i < assem.Length; i++)
            {
                modSavePath = modSavePath + assem[i] + "/";
                coordSavePath = coordSavePath + assem[i] + "/";
            }

            //保存模板
            if (factor == "相关性")
            {
                modSavePath = modSavePath + modelName + ".ncm";
                coordSavePath = coordSavePath + modelName + "_点位";
            }
            else
            {
                modSavePath = modSavePath + modelName + ".shm";
                coordSavePath = coordSavePath + modelName + "_点位";
            }

            HTuple coord = new HTuple();
            HOperatorSet.TupleConcat(modelMidR, modelMidC, out coord);
            HOperatorSet.TupleConcat(coord, modelA, out coord);
            HOperatorSet.WriteShapeModel(modID, modSavePath);
            HOperatorSet.WriteTuple(coord, coordSavePath);
        }

        #endregion
    }
}
