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

namespace Plugin.NinePointsCalib
{
    [Category("定位工具")]
    [DisplayName("九点标定")]
    [Serializable]
    public class NinePointsCalibObj : ObjBase
    {
        #region 字段、属性

        /// <summary>
        /// 信息输出类
        /// </summary>
        public NinePointsCalib_Info ninePointsCalib_Info = new NinePointsCalib_Info();
     
        /// <summary>
        /// 矩阵点数
        /// </summary>
        public int pointsNum = 9;

        /// <summary>
        /// 误差下限
        /// </summary>
        public double RMSMin = 0;

        /// <summary>
        /// 误差上限
        /// </summary>
        public double RMSMax = 1;

        /// <summary>
        /// 保存路径
        /// </summary>
        public string savePath = "";

        /// <summary>
        /// 标定结果
        /// </summary>
        public string result = "标定未执行";

        /// <summary>
        /// 像素当量-X
        /// </summary>
        public string precisionX = "";

        /// <summary>
        /// 像素当量-Y
        /// </summary>
        public string precisionY = "";

        /// <summary>
        /// RMS误差
        /// </summary>
        public string RMS = "";

        /// <summary>
        /// 图像坐标-Row
        /// </summary>
        public HTuple imgRow = new HTuple();

        /// <summary>
        /// 图像坐标-Col
        /// </summary>
        public HTuple imgCol = new HTuple();

        /// <summary>
        /// 机械坐标-Row
        /// </summary>
        public HTuple physicalRow = new HTuple();

        /// <summary>
        /// 机械坐标-Col
        /// </summary>
        public HTuple physicalCol = new HTuple();

        /// <summary>
        /// 坐标中间值
        /// </summary>
        public List<string> imgRowName = new List<string>(), imgColName = new List<string>(), physicalRowName = new List<string>(), physicalColName = new List<string>();

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
                //更新数据
                GetData();

                HTuple mat = new HTuple();
                HTuple sx = new HTuple();
                HTuple sy = new HTuple();
                HTuple phi = new HTuple();
                HTuple theta = new HTuple();
                HTuple tx = new HTuple();
                HTuple ty = new HTuple();
                HOperatorSet.VectorToHomMat2d(imgRow, imgCol, physicalRow, physicalCol, out mat);
                HOperatorSet.HomMat2dToAffinePar(mat, out sx, out sy, out phi, out theta, out tx, out ty);
                double rms = AlgorithmRTools.CalRMS(mat, imgRow, imgCol, physicalRow, physicalCol);

                precisionX = sx.ToString();
                precisionY = sy.ToString();
                RMS = rms.ToString();

                if (rms >= RMSMin && rms <= RMSMax)
                {
                    result = "标定成功";
                    HOperatorSet.WriteTuple(mat, savePath);
                }
                else
                {
                    result = "标定失败";
                }

                //保存对象
                SetVarList(ref mSloVar, new DataCell(ModInfo.Name, ModInfo.Encode, DataType.单量, DataMode.九点标定, ConstVar.NinePointsCalib, ModInfo.Plugin, "0", 1, ninePointsCalib_Info, DataAtrr.全局变量));

                Log.Info(Sol.mSol.mProjList[ModInfo.Index].mProjInfo.Name + ": " + ModInfo.Name + ":" + "执行成功");
                ModInfo.State = ModState.OK;
                return true;
            }
            catch (Exception ex)
            {
                Log.Error(Sol.mSol.mProjList[ModInfo.Index].mProjInfo.Name + ": " + ModInfo.Name + ":" + "执行失败(" + "原因：" + ex.Message + ")");
                ModInfo.State = ModState.NG;
                return false;
            }
        }

        /// <summary>
        /// 显示窗体
        /// </summary>
        /// <param name="baseMod"></param>
        public override void RunForm(ObjBase baseMod)
        {
            new NinePointsCalibForm((NinePointsCalibObj)baseMod).ShowDialog();
        }

        #endregion

        #region 方法-数据相关

        /// <summary>
        /// 如果数据内容是链接，则由GetLinkValue得到链接的值
        /// </summary>
        public void GetData()
        {
            imgRow = new HTuple();
            imgCol = new HTuple();
            physicalRow = new HTuple();
            physicalCol = new HTuple();

            for (int i = 0; i < imgRowName.Count; i++)
            {
                if (imgRowName[i].Contains(":"))
                {
                    imgRow.Append(double.Parse((string)Var.GetLinkValue(mSysVar, mSloVar, imgRowName[i])));
                }
                else
                {
                    imgRow.Append(imgRowName[i].ToDouble());
                }
            }

            for (int i = 0; i < imgColName.Count; i++)
            {
                if (imgColName[i].Contains(":"))
                {
                    imgCol.Append(double.Parse((string)Var.GetLinkValue(mSysVar, mSloVar, imgColName[i])));
                }
                else
                {
                    imgCol.Append(imgColName[i].ToDouble());
                }
            }

            for (int i = 0; i < physicalRowName.Count; i++)
            {
                if (physicalRowName[i].Contains(":"))
                {
                    physicalRow.Append(double.Parse((string)Var.GetLinkValue(mSysVar, mSloVar, physicalRowName[i])));
                }
                else
                {
                    physicalRow.Append(physicalRowName[i].ToDouble());
                }
            }

            for (int i = 0; i < physicalColName.Count; i++)
            {
                if (physicalColName[i].Contains(":"))
                {
                    physicalCol.Append(double.Parse((string)Var.GetLinkValue(mSysVar, mSloVar, physicalColName[i])));
                }
                else
                {
                    physicalCol.Append(physicalColName[i].ToDouble());
                }
            }
        }

        #endregion
    }
}
