using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.Serialization;
using VisionCore;

namespace Plugin.Judge
{
    [Category("逻辑工具")]
    [DisplayName("条件判断")]
    [Serializable]
    public class JudgeObj : ObjBase
    {
        #region 字段、属性

        /// <summary>
        /// 条件判断类
        /// </summary>
        public Judge_Info judge_Info = new Judge_Info();

        /// <summary>
        /// 条件序号
        /// </summary>
        public string condIdx = "条件1";

        /// <summary>
        /// 条件逻辑
        /// </summary>
        public string logic = "与";

        /// <summary>
        /// 对比条件1
        /// </summary>
        public FuncType funcType1;

        /// <summary>
        /// 对比数据1
        /// </summary>
        public string funcData1 = "";

        /// <summary>
        /// 对比标准1
        /// </summary>
        public string funcStd1 = "";

        /// <summary>
        /// 对比条件2
        /// </summary>
        public FuncType funcType2;

        /// <summary>
        /// 对比数据2
        /// </summary>
        public string funcData2 = "";

        /// <summary>
        /// 对比标准2
        /// </summary>
        public string funcStd2 = "";

        /// <summary>
        /// 对比条件3
        /// </summary>
        public FuncType funcType3;

        /// <summary>
        /// 对比数据3
        /// </summary>
        public string funcData3 = "";

        /// <summary>
        /// 对比标准3
        /// </summary>
        public string funcStd3 = "";

        /// <summary>
        /// 对比条件4
        /// </summary>
        public FuncType funcType4;

        /// <summary>
        /// 对比数据4
        /// </summary>
        public string funcData4 = "";

        /// <summary>
        /// 对比标准4
        /// </summary>
        public string funcStd4 = "";

        /// <summary>
        /// 中间值
        /// </summary>
        public String funcData1Med = "", funcStd1Med = "", funcData2Med = "", funcStd2Med = "", funcData3Med = "", funcStd3Med = "", funcData4Med = "", funcStd4Med = "";

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
                List<string> assem = new List<string>();
                string result1 = "", result2 = "", result3 = "", result4 = "";

                GetData();

                if (funcData1 != "" && funcStd1 != "")
                {
                    switch (funcType1)
                    {
                        case 0://等于
                            result1 = (funcData1 == funcStd1).ToString();
                            break;
                        case (FuncType)1://不等于
                            result1 = (funcData1 != funcStd1).ToString();
                            break;
                        case (FuncType)2://大于
                            result1 = (double.Parse(funcData1) > double.Parse(funcStd1)).ToString();
                            break;
                        case (FuncType)3://大于等于
                            result1 = (double.Parse(funcData1) >= double.Parse(funcStd1)).ToString();
                            break;
                        case (FuncType)4://小于
                            result1 = (double.Parse(funcData1) < double.Parse(funcStd1)).ToString();
                            break;
                        case (FuncType)5://小于等于
                            result1 = (double.Parse(funcData1) <= double.Parse(funcStd1)).ToString();
                            break;
                        case (FuncType)6://包含
                            result1 = (funcData1.Contains(funcStd1)).ToString();
                            break;
                        case (FuncType)7://不包含
                            result1 = (!funcData1.Contains(funcStd1)).ToString();
                            break;
                    }
                }

                if (funcData2 != "" && funcStd2 != "")
                {
                    switch (funcType2)
                    {
                        case 0://等于
                            result2 = (funcData2 == funcStd2).ToString();
                            break;
                        case (FuncType)1://不等于
                            result2 = (funcData2 != funcStd2).ToString();
                            break;
                        case (FuncType)2://大于
                            result2 = (double.Parse(funcData2) > double.Parse(funcStd2)).ToString();
                            break;
                        case (FuncType)3://大于等于
                            result2 = (double.Parse(funcData2) >= double.Parse(funcStd2)).ToString();
                            break;
                        case (FuncType)4://小于
                            result2 = (double.Parse(funcData2) < double.Parse(funcStd2)).ToString();
                            break;
                        case (FuncType)5://小于等于
                            result2 = (double.Parse(funcData2) <= double.Parse(funcStd2)).ToString();
                            break;
                        case (FuncType)6://包含
                            result2 = (funcData2.Contains(funcStd2)).ToString();
                            break;
                        case (FuncType)7://不包含
                            result2 = (!funcData2.Contains(funcStd2)).ToString();
                            break;
                    }
                }

                if (funcData3 != "" && funcStd3 != "")
                {
                    switch (funcType3)
                    {
                        case 0://等于
                            result3 = (funcData3 == funcStd3).ToString();
                            break;
                        case (FuncType)1://不等于
                            result3 = (funcData3 != funcStd3).ToString();
                            break;
                        case (FuncType)2://大于
                            result3 = (double.Parse(funcData3) > double.Parse(funcStd3)).ToString();
                            break;
                        case (FuncType)3://大于等于
                            result3 = (double.Parse(funcData3) >= double.Parse(funcStd3)).ToString();
                            break;
                        case (FuncType)4://小于
                            result3 = (double.Parse(funcData3) < double.Parse(funcStd3)).ToString();
                            break;
                        case (FuncType)5://小于等于
                            result3 = (double.Parse(funcData3) <= double.Parse(funcStd3)).ToString();
                            break;
                        case (FuncType)6://包含
                            result3 = (funcData3.Contains(funcStd3)).ToString();
                            break;
                        case (FuncType)7://不包含
                            result3 = (!funcData3.Contains(funcStd3)).ToString();
                            break;
                    }
                }

                if (funcData4 != "" && funcStd4 != "")
                {
                    switch (funcType4)
                    {
                        case 0://等于
                            result4 = (funcData4 == funcStd4).ToString();
                            break;
                        case (FuncType)1://不等于
                            result4 = (funcData4 != funcStd4).ToString();
                            break;
                        case (FuncType)2://大于
                            result4 = (double.Parse(funcData4) > double.Parse(funcStd4)).ToString();
                            break;
                        case (FuncType)3://大于等于
                            result4 = (double.Parse(funcData4) >= double.Parse(funcStd4)).ToString();
                            break;
                        case (FuncType)4://小于
                            result4 = (double.Parse(funcData4) < double.Parse(funcStd4)).ToString();
                            break;
                        case (FuncType)5://小于等于
                            result4 = (double.Parse(funcData4) <= double.Parse(funcStd4)).ToString();
                            break;
                        case (FuncType)6://包含
                            result4 = (funcData3.Contains(funcStd4)).ToString();
                            break;
                        case (FuncType)7://不包含
                            result4 = (!funcData3.Contains(funcStd4)).ToString();
                            break;
                    }
                }

                if (result1 != "") assem.Add(result1);
                if (result2 != "") assem.Add(result2);
                if (result3 != "") assem.Add(result3);
                if (result4 != "") assem.Add(result4);

                if (assem.Contains("False"))
                {
                    judge_Info.result = false;
                }
                else
                {
                    judge_Info.result = true;
                }

                SetVarList(ref mSloVar, new DataCell(ModInfo.Name, ModInfo.Encode, DataType.单量, DataMode.条件判断, ConstVar.Judge, ModInfo.Plugin, "0", 1, judge_Info, DataAtrr.全局变量));
              
                Log.Info(Sol.mSol.mProjList[ModInfo.Index].mProjInfo.Name + ": " + ModInfo.Name + ":" + judge_Info.result);
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
            if (funcData1Med.Contains(":"))
            {
                funcData1 = (string)Var.GetLinkValue(mSysVar, mSloVar, funcData1Med);
            }
            else
            {
                funcData1 = funcData1Med;
            }

            if (funcStd1Med.Contains(":"))
            {
                funcStd1 = (string)Var.GetLinkValue(mSysVar, mSloVar, funcStd1Med);
            }
            else
            {
                funcStd1 = funcStd1Med;
            }

            if (funcData2Med.Contains(":"))
            {
                funcData2 = (string)Var.GetLinkValue(mSysVar, mSloVar, funcData2Med);
            }
            else
            {
                funcData2 = funcData2Med;
            }

            if (funcStd2Med.Contains(":"))
            {
                funcStd2 = (string)Var.GetLinkValue(mSysVar, mSloVar, funcStd2Med);
            }
            else
            {
                funcStd2 = funcStd2Med;
            }

            if (funcData3Med.Contains(":"))
            {
                funcData3 = (string)Var.GetLinkValue(mSysVar, mSloVar, funcData3Med);
            }
            else
            {
                funcData3 = funcData3Med;
            }

            if (funcStd3Med.Contains(":"))
            {
                funcStd3 = (string)Var.GetLinkValue(mSysVar, mSloVar, funcStd3Med);
            }
            else
            {
                funcStd3 = funcStd3Med;
            }

            if (funcData4Med.Contains(":"))
            {
                funcData4 = (string)Var.GetLinkValue(mSysVar, mSloVar, funcData4Med);
            }
            else
            {
                funcData4 = funcData4Med;
            }

            if (funcStd4Med.Contains(":"))
            {
                funcStd4 = (string)Var.GetLinkValue(mSysVar, mSloVar, funcStd4Med);
            }
            else
            {
                funcStd4 = funcStd4Med;
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
            new JudgeForm((JudgeObj)baseMod).ShowDialog();
        }

        #endregion

    }
}
