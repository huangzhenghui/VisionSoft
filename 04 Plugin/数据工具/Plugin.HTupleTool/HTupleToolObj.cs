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

namespace Plugin.HTupleTool
{
    [Category("数据工具")]
    [DisplayName("元组工具")]
    [Serializable]
    public class HTupleToolObj : ObjBase
    {
        #region 字段、属性

        /// <summary>
        /// 信息输出
        /// </summary>
        public HTupleTool_Info hTupleTool_Info = new HTupleTool_Info();

        /// <summary>
        /// 运算方式
        /// </summary>
        public string operateMode = "元素个数";

        /// <summary>
        /// 元素1
        /// </summary>
        [NonSerialized]
        public HTuple elem1 = new HTuple();

        /// <summary>
        /// 元素2
        /// </summary>
        [NonSerialized]
        public HTuple elem2 = new HTuple();

        /// <summary>
        /// 索引
        /// </summary>
        [NonSerialized]
        public HTuple idx = new HTuple();

        /// <summary>
        /// 中间值
        /// </summary>
        public string strElem1 = "0", strElem2 = "0", strIdx = "0";

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
                HTuple result = new HTuple();

                //获取数据
                GetData();

                //执行算法
                switch (operateMode)
                {
                    case "绝对值": 
                        HOperatorSet.TupleAbs(elem1, out result);
                        break;
                    case "元素选择":
                        HOperatorSet.TupleSelect(elem1, idx, out result);
                        break;
                    case "元素求和":
                        HOperatorSet.TupleSum(elem1, out result);
                        break;
                    case "元组求和":
                        HOperatorSet.TupleAdd(elem1, elem2, out result);
                        break;
                    case "元组求差":
                        HOperatorSet.TupleSub(elem1, elem2, out result);
                        break;
                    case "元组求积":
                        HOperatorSet.TupleMult(elem1, elem2, out result);
                        break;
                    case "元组求商":
                        HOperatorSet.TupleDiv(elem1, elem2, out result);
                        break;
                    case "角度转换":
                        HOperatorSet.TupleDeg(elem1, out result);
                        break;
                    case "弧度转换":
                        HOperatorSet.TupleRad(elem1, out result);
                        break;
                    case "整数转换":
                        HOperatorSet.TupleInt(elem1, out result);
                        break;
                    case "浮点数转换":
                        HOperatorSet.TupleReal(elem1, out result);
                        break;
                    case "平均值":
                        HOperatorSet.TupleMean(elem1, out result);
                        break;
                    case "中值":
                        HOperatorSet.TupleMedian(elem1, out result);
                        break;
                    case "算数平方根":
                        HOperatorSet.TupleSqrt(elem1, out result);
                        break;
                    case "标准差":
                        HOperatorSet.TupleDeviation(elem1, out result);
                        break;
                    case "集合":
                        HOperatorSet.TupleConcat(elem1, elem2, out result);
                        break;
                    case "并集":
                        HOperatorSet.TupleUnion(elem1, elem2, out result);
                        break;
                    case "差集":
                        HOperatorSet.TupleDifference(elem1, elem2, out result);
                        break;
                    case "交集":
                        HOperatorSet.TupleIntersection(elem1, elem2, out result);
                        break;
                    case "余弦":
                        HOperatorSet.TupleCos(elem1, out result);
                        break;
                    case "反余弦":
                        HOperatorSet.TupleAcos(elem1, out result);
                        break;
                    case "正弦":
                        HOperatorSet.TupleSin(elem1, out result);
                        break;
                    case "反正弦":
                        HOperatorSet.TupleAsin(elem1, out result);
                        break;
                    case "正切":
                        HOperatorSet.TupleTan(elem1, out result);
                        break;
                    case "反正切":
                        HOperatorSet.TupleAtan(elem1, out result);
                        break;
                    case "判断元组相等":
                        HOperatorSet.TupleEqual(elem1, elem2, out result);
                        break;
                    case "判断元素相等":
                        HOperatorSet.TupleEqualElem(elem1, elem2, out result);
                        break;
                    case "位置查找":
                        HOperatorSet.TupleFind(elem1, elem2, out result);
                        break;
                    case "反转":
                        HOperatorSet.TupleInverse(elem1, out result);
                        break;
                    case "最小元素(1个元组)":
                        HOperatorSet.TupleMin(elem1, out result);
                        break;
                    case "最小元素(2个元组)":
                        HOperatorSet.TupleMin2(elem1, elem2, out result);
                        break;
                    case "最大元素(1个元组)":
                        HOperatorSet.TupleMax(elem1, out result);
                        break;
                    case "最大元素(2个元组)":
                        HOperatorSet.TupleMax2(elem1, elem2, out result);
                        break;
                    case "元素个数":
                        HOperatorSet.TupleLength(elem1, out result);
                        break;
                    case "插入":
                        HOperatorSet.TupleInsert(elem1, idx, elem2, out result);
                        break;
                    case "移除":
                        HOperatorSet.TupleRemove(elem1, idx, out result);
                        break;
                    case "替换":
                        HOperatorSet.TupleReplace(elem1, idx, elem2, out result);
                        break;
                    case "元组排序(返回元组)":
                        HOperatorSet.TupleSort(elem1, out result);
                        break;
                    case "元组排序(返回索引)":
                        HOperatorSet.TupleSortIndex(elem1, out result);
                        break;
                }

                exeResult = "执行成功";

                //数据更新
                hTupleTool_Info.result = result;

                //主界面窗体显示
                WindowShowHObj();

                //保存对象
                SetVarList(ref mSloVar, new DataCell(ModInfo.Name, ModInfo.Encode, DataType.单量, DataMode.元组工具, ConstVar.HTupleTool, ModInfo.Plugin, "0", 1, hTupleTool_Info, DataAtrr.全局变量));

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

        #region 方法-数据相关

        /// <summary>
        /// 初始化输出变量
        /// </summary>
        public override void InitOutputInfo()
        {
            hTupleTool_Info.result = new HTuple();
        }

        /// <summary>
        /// 如果数据内容是链接，则由GetLinkValue得到链接的值
        /// </summary>
        public void GetData()
        {
            try
            {
                elem1 = Var.AcqValue_HTuple(strElem1, mSysVar, mSloVar);
                elem2 = Var.AcqValue_HTuple(strElem2, mSysVar, mSloVar);
                idx = Var.AcqValue_HTuple(strIdx, mSysVar, mSloVar);
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
            new HTupleToolForm((HTupleToolObj)baseMod).ShowDialog();
        }

        /// <summary>
        /// 在主窗体的图像窗口显示HObject对象
        /// </summary>
        public void WindowShowHObj(){ }

        #endregion
    }
}
