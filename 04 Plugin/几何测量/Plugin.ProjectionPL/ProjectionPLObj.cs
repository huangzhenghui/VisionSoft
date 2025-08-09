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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Plugin.ProjectionPL
{
    [Category("几何测量")]
    [DisplayName("点线投影")]
    [Serializable]
    public class ProjectionPLObj : ObjBase
    {
        #region 字段、属性

        /// <summary>
        /// 图像名称
        /// </summary>
        public string mImages = "";

        /// <summary>
        /// 信息输出
        /// </summary>
        public ProjectionPL_Info projectionPL_Info = new ProjectionPL_Info();

        /// <summary>
        /// 点Row坐标
        /// </summary>
        public double pointRow = 100;

        /// <summary>
        /// 点Column坐标
        /// </summary>
        public double pointCol = 100;

        /// <summary>
        /// 直线起点Row坐标
        /// </summary>
        public double beginRow = 200;

        /// <summary>
        /// 直线起点Col坐标
        /// </summary>
        public double beginCol = 200;

        /// <summary>
        /// 直线终点Row坐标
        /// </summary>
        public double endRow = 200;

        /// <summary>
        /// 直线终点Col坐标
        /// </summary>
        public double endCol = 600;

        /// <summary>
        /// 是否显示点
        /// </summary>
        public bool isShowPoint = true;

        /// <summary>
        /// 是否显示数据
        /// </summary>
        public bool isShowData = true;

        /// <summary>
        /// 结果显示X坐标
        /// </summary>
        public double X = 10;

        /// <summary>
        /// 结果显示Y坐标
        /// </summary>
        public double Y = 10;

        /// <summary>
        /// 字体大小
        /// </summary>
        public int fontSize = 15;

        /// <summary>
        /// 点大小
        /// </summary>
        public int pointSize = 15;

        /// <summary>
        /// 前缀
        /// </summary>
        public string prefix = "";

        /// <summary>
        /// 结果颜色
        /// </summary>
        public string resultColor = "#00FF00";

        /// <summary>
        /// 测量结果
        /// </summary>
        public double distancePP;

        /// <summary>
        /// 中间变量
        /// </summary>
        public string pointRowName = "100", pointColName = "100", beginRowName = "200", beginColName = "200", endRowName= "200", endColName = "600";

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
                HTuple projRow = new HTuple();
                HTuple projCol = new HTuple();

                HObject projObj;
                HOperatorSet.GenEmptyObj(out projObj);

                //设置可绘制区域的大小
                HOperatorSet.SetSystem("width", 20000);
                HOperatorSet.SetSystem("height", 20000);

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
                HOperatorSet.ProjectionPl(pointRow, pointCol, beginRow, beginCol, endRow, endCol, out projRow, out projCol);
                HOperatorSet.GenCrossContourXld(out projObj, projRow, projCol, pointSize, 0.785398);

                //更新数据
                projectionPL_Info.pointObj = projObj;
                projectionPL_Info.pointRow = projRow;
                projectionPL_Info.pointCol = projCol;

                //主界面窗体显示
                WindowShowROI();

                //保存对象
                SetVarList(ref mSloVar, new DataCell(ModInfo.Name, ModInfo.Encode, DataType.单量, DataMode.点线投影, ConstVar.ProjectionPL, ModInfo.Plugin, "0", 1, projectionPL_Info, DataAtrr.全局变量));

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
            new ProjectionPLForm((ProjectionPLObj)baseMod).ShowDialog();
        }

        /// <summary>
        /// 在主窗体的图像窗口显示区域
        /// </summary>
        public void WindowShowROI()
        {
            HObject point;
            HOperatorSet.GenEmptyObj(out point);

            if (mRImage != null)
            {
                if (isShowPoint)
                {
                    HRoi roiResult = new HRoi(ModInfo.Encode, ModInfo.Name, ModInfo.Remarks, HRoiType.检测结果, resultColor, new HObject(projectionPL_Info.pointObj));
                    mRImage.ShowHRoi(roiResult);
                }

                if (isShowData)
                {
                    HText text = new HText(ModInfo.Encode, ModInfo.Name, ModInfo.Remarks, HRoiType.文字显示, resultColor, prefix + ":" + " X:" + projectionPL_Info.pointCol.ToString("F4") + " Y:" + projectionPL_Info.pointRow.ToString("F4"), "mono", 5, 5, fontSize, mRImage, false);
                    mRImage.ShowHText(text);
                }
            }
        }

        #endregion

        #region 方法-数据相关

        /// <summary>
        /// 如果数据内容是链接，则由GetLinkValue得到链接的值，赋值给double类型数据
        /// </summary>
        public void GetData()
        {
            try
            {
                if (pointColName.Contains(":"))
                {
                    pointCol = Convert.ToDouble(Var.GetLinkValue(mSysVar, mSloVar, pointColName));
                }
                else
                {

                    pointCol = pointColName.ToDouble();
                }

                if (pointRowName.Contains(":"))
                {
                    pointRow = Convert.ToDouble(Var.GetLinkValue(mSysVar, mSloVar, pointRowName));
                }
                else
                {
                    pointRow = pointRowName.ToDouble();
                }

                if (beginColName.Contains(":"))
                {
                    beginCol = Convert.ToDouble(Var.GetLinkValue(mSysVar, mSloVar, beginColName));
                }
                else
                {

                    beginCol = beginColName.ToDouble();
                }

                if (beginRowName.Contains(":"))
                {
                    beginRow = Convert.ToDouble(Var.GetLinkValue(mSysVar, mSloVar, beginRowName));
                }
                else
                {
                    beginRow = beginRowName.ToDouble();
                }

                if (endColName.Contains(":"))
                {
                    endCol = Convert.ToDouble(Var.GetLinkValue(mSysVar, mSloVar, endColName));
                }
                else
                {
                    endCol = endColName.ToDouble();
                }

                if (endRowName.Contains(":"))
                {
                    endRow = Convert.ToDouble(Var.GetLinkValue(mSysVar, mSloVar, endRowName));
                }
                else
                {
                    endRow = endRowName.ToDouble();
                }
            }
            catch { }
        }

        /// <summary>
        /// 初始化模块输出对象的变量
        /// </summary>
        public void InitOutput()
        {
            HOperatorSet.GenEmptyObj(out projectionPL_Info.pointObj);
        }

        #endregion
    }
}
