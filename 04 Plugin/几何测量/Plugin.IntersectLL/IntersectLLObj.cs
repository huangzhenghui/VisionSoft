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

namespace Plugin.IntersectLL
{
    [Category("几何测量")]
    [DisplayName("线线交点")]
    [Serializable]
    public class IntersectLLObj : ObjBase
    {
        #region 字段、属性

        /// <summary>
        /// 图像名称
        /// </summary>
        public string mImages = "";

        /// <summary>
        /// 信息输出
        /// </summary>
        public IntersectLL_Info intersectLL_Info = new IntersectLL_Info();

        /// <summary>
        /// 直线1起点Row坐标
        /// </summary>
        public double l1BeginRow = 100;

        /// <summary>
        /// 直线1起点Column坐标
        /// </summary>
        public double l1BeginCol = 100;

        /// <summary>
        /// 直线1终点Row坐标
        /// </summary>
        public double l1EndRow = 100;

        /// <summary>
        /// 直线1终点Column坐标
        /// </summary>
        public double l1EndCol = 600;

        /// <summary>
        /// 直线2起点Row坐标
        /// </summary>
        public double l2BeginRow = 100;

        /// <summary>
        /// 直线2起点Column坐标
        /// </summary>
        public double l2BeginCol = 100;

        /// <summary>
        /// 直线2终点Row坐标
        /// </summary>
        public double l2EndRow = 600;

        /// <summary>
        /// 直线2终点Column坐标
        /// </summary>
        public double l2EndCol = 100;

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
        public string l1BeginRowName = "100", l1BeginColName = "100", l1EndRowName = "100", l1EndColName = "600", l2BeginRowName = "100", l2BeginColName = "100", l2EndRowName = "600", l2EndColName = "100";

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
                HTuple pointR = new HTuple();
                HTuple pointC = new HTuple();
                HTuple isOverlapping = new HTuple();

                HObject pointObj;
                HOperatorSet.GenEmptyObj(out pointObj);

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
                HOperatorSet.IntersectionLines(l1BeginRow, l1BeginCol, l1EndRow, l1EndCol, l2BeginRow, l2BeginCol, l2EndRow, l2EndCol, out pointR, out pointC, out isOverlapping);
                HOperatorSet.GenCrossContourXld(out pointObj, intersectLL_Info.pointRow, intersectLL_Info.pointCol, pointSize, 0.785398);

                //更新数据
                intersectLL_Info.pointObj = pointObj;
                intersectLL_Info.pointRow = pointR;
                intersectLL_Info.pointCol = pointC;

                //主界面窗体显示
                WindowShowROI();

                //保存对象
                SetVarList(ref mSloVar, new DataCell(ModInfo.Name, ModInfo.Encode, DataType.单量, DataMode.线线交点, ConstVar.IntersectLL, ModInfo.Plugin, "0", 1, intersectLL_Info, DataAtrr.全局变量));

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
            new IntersectLLForm((IntersectLLObj)baseMod).ShowDialog();
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
                    HOperatorSet.GenCrossContourXld(out point, intersectLL_Info.pointRow, intersectLL_Info.pointCol, pointSize, 0.785398);
                    HRoi roiResult = new HRoi(ModInfo.Encode, ModInfo.Name, ModInfo.Remarks, HRoiType.检测结果, resultColor, new HObject(point));
                    mRImage.ShowHRoi(roiResult);
                }

                if (isShowData)
                {
                    HText text = new HText(ModInfo.Encode, ModInfo.Name, ModInfo.Remarks, HRoiType.文字显示, resultColor, prefix + ":" + " X:" + intersectLL_Info.pointCol.ToString() + " Y:" + intersectLL_Info.pointRow.ToString(), "mono", Y, X, fontSize, mRImage, false);
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
                if (l1BeginColName.Contains(":"))
                {
                    l1BeginCol = Convert.ToDouble(Var.GetLinkValue(mSysVar, mSloVar, l1BeginColName));
                }
                else
                {

                    l1BeginCol = l1BeginColName.ToDouble();
                }

                if (l1BeginRowName.Contains(":"))
                {
                    l1BeginRow = Convert.ToDouble(Var.GetLinkValue(mSysVar, mSloVar, l1BeginRowName));
                }
                else
                {
                    l1BeginRow = l1BeginRowName.ToDouble();
                }

                if (l1EndColName.Contains(":"))
                {
                    l1EndCol = Convert.ToDouble(Var.GetLinkValue(mSysVar, mSloVar, l1EndColName));
                }
                else
                {

                    l1EndCol = l1EndColName.ToDouble();
                }

                if (l1EndRowName.Contains(":"))
                {
                    l1EndRow = Convert.ToDouble(Var.GetLinkValue(mSysVar, mSloVar, l1EndRowName));
                }
                else
                {
                    l1EndRow = l1EndRowName.ToDouble();
                }

                if (l2BeginColName.Contains(":"))
                {
                    l2BeginCol = Convert.ToDouble(Var.GetLinkValue(mSysVar, mSloVar, l2BeginColName));
                }
                else
                {

                    l2BeginCol = l2BeginColName.ToDouble();
                }

                if (l2BeginRowName.Contains(":"))
                {
                    l2BeginRow = Convert.ToDouble(Var.GetLinkValue(mSysVar, mSloVar, l2BeginRowName));
                }
                else
                {
                    l2BeginRow = l2BeginRowName.ToDouble();
                }

                if (l2EndColName.Contains(":"))
                {
                    l2EndCol = Convert.ToDouble(Var.GetLinkValue(mSysVar, mSloVar, l2EndColName));
                }
                else
                {

                    l2EndCol = l2EndColName.ToDouble();
                }

                if (l2EndRowName.Contains(":"))
                {
                    l2EndRow = Convert.ToDouble(Var.GetLinkValue(mSysVar, mSloVar, l2EndRowName));
                }
                else
                {
                    l2EndRow = l2EndRowName.ToDouble();
                }
            }
            catch { }
        }

        /// <summary>
        /// 初始化模块输出对象的变量
        /// </summary>
        public void InitOutput()
        {
            HOperatorSet.GenEmptyObj(out intersectLL_Info.pointObj);
        }

        #endregion
    }
}
