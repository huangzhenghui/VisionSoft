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

namespace Plugin.CreatePoint
{
    [Category("几何构建")]
    [DisplayName("点位构建")]
    [Serializable]
    public class CreatePointObj : ObjBase
    {
        #region 字段、属性

        /// <summary>
        /// 图像名称
        /// </summary>
        public string mImages = "";

        /// <summary>
        /// 信息输出
        /// </summary>
        public CreatePoint_Info createPoint_Info = new CreatePoint_Info();

        /// <summary>
        /// 点位Row坐标
        /// </summary>
        public HTuple pointRow = new HTuple();

        /// <summary>
        /// 点位Column坐标
        /// </summary>
        public HTuple pointCol = new HTuple();

        /// <summary>
        /// 十字宽度
        /// </summary>
        public int crossWidth = 15;

        /// <summary>
        /// 中间变量
        /// </summary>
        public string pointRowName = "100", pointColName = "100";

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
                HOperatorSet.GenCrossContourXld(out pointObj, pointRow, pointCol, crossWidth, 0.785398);

                //更新数据信息
                createPoint_Info.pointObj = pointObj;
                createPoint_Info.pointR = pointRow;
                createPoint_Info.pointC = pointCol;

                //主界面窗体显示
                WindowShowROI();

                //保存对象
                SetVarList(ref mSloVar, new DataCell(ModInfo.Name, ModInfo.Encode, DataType.单量, DataMode.直线构建, ConstVar.CreateLine, ModInfo.Plugin, "0", 1, createPoint_Info, DataAtrr.全局变量));

                Log.Info(ModInfo.Name + ":" + "点位构建成功");
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
            new CreatePointForm((CreatePointObj)baseMod).ShowDialog();
        }

        /// <summary>
        /// 在主窗体的图像窗口显示区域
        /// </summary>
        public void WindowShowROI()
        {
            if (mRImage != null)
            {
                if (isShowReg)
                {
                    HRoi roiResult = new HRoi(ModInfo.Encode, ModInfo.Name, ModInfo.Remarks, HRoiType.检测结果, resultColor, new HObject(createPoint_Info.pointObj));
                    mRImage.ShowHRoi(roiResult);
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
                pointRow = new HTuple();
                pointCol = new HTuple();

                if (pointColName.Contains(":"))
                {
                    switch (Var.GetLinkValue(mSysVar, mSloVar, pointColName).GetType().Name)
                    {
                        case "Double[]":
                            pointCol = new HTuple((double[])Var.GetLinkValue(mSysVar, mSloVar, pointColName));
                            break;
                        case "Int[]":
                            pointCol = new HTuple((int[])Var.GetLinkValue(mSysVar, mSloVar, pointColName));
                            break;
                        default:
                            pointCol = new HTuple(Var.GetLinkValue(mSysVar, mSloVar, pointColName));
                            break;
                    }
                }
                else
                {
                    string[] strCol = pointColName.Split(',');
                    for (int i = 0; i < strCol.Length; i++)
                    {
                        pointCol[i] = strCol[i].ToDouble();
                    }
                }

                if (pointRowName.Contains(":"))
                {
                    switch(Var.GetLinkValue(mSysVar, mSloVar, pointRowName).GetType().Name)
                    {
                        case "Double[]":
                            pointRow = new HTuple((double[])Var.GetLinkValue(mSysVar, mSloVar, pointRowName));
                            break;
                        case "Int[]":
                            pointRow = new HTuple((int[])Var.GetLinkValue(mSysVar, mSloVar, pointRowName));
                            break;
                        default:
                            pointRow = new HTuple(Var.GetLinkValue(mSysVar, mSloVar, pointRowName));
                            break;
                    }
                }
                else
                {
                    string[] strRow = pointRowName.Split(',');
                    for (int i = 0; i < strRow.Length; i++)
                    {
                        pointRow[i] = strRow[i].ToDouble();
                    }
                }
            }
            catch(Exception ex) 
            {
                MessageBox.Show(ex.Message);
            }
        }

        /// <summary>
        /// 初始化模块输出对象的变量
        /// </summary>
        public void InitOutput()
        {
            HOperatorSet.GenEmptyObj(out createPoint_Info.pointObj);
        }

        #endregion
    }
}
