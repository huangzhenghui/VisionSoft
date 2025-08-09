using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Text;
using System.Threading.Tasks;
using VisionCore;
namespace Plugin.SetVar
{
    [Category("变量工具")]
    [DisplayName("变量设置")]
    [Serializable]
    public class SetVarObj : ObjBase
    {
        #region 字段、属性

        /// <summary>
        /// 保存信息
        /// </summary>
        public List<Char_Info> mChar_Info = new List<Char_Info>();

        #endregion

        #region 方法-模块相关

        /// <summary>
        /// 执行
        /// </summary>
        /// <returns></returns>
        public override bool RunObj()
        {
            try
            {
                string Link1 = string.Empty;
                string Link2 = string.Empty;
                foreach (var info in mChar_Info)
                {
                    if(info.Link1.Contains("全局变量"))
                    {
                        Link1 = Convert.ToString(Var.GetLinkValue(mSysVar, mSloVar, info.Link1)).Replace("\"", "");
                    }
                    else
                    {
                        if (info.Link1.Contains(":"))
                        {
                            Link1 = Convert.ToString(Var.GetLinkValue(mSysVar, mSloVar, info.Link1)).Replace("\"", "");
                        }
                        else
                        {
                            Link1 = info.Link1.Trim();
                        }
                    }

                    if (info.Link2.Contains("全局变量"))
                    {
                        Link2 = Convert.ToString(Var.GetLinkValue(mSysVar, mSloVar, info.Link2)).Replace("\"", "");
                    }
                    else 
                    {
                        if (info.Link2.Contains(":"))

                        {
                            Link2 = Convert.ToString(Var.GetLinkValue(mSysVar, mSloVar, info.Link2)).Replace("\"", "");
                        }
                        else
                        {
                            Link2 = info.Link2.Trim();
                        }
                    }

                    if (Link1 == "" || Link1 == "[]") Link1 = "——";
                    if (Link2 == "" || Link2 == "[]") Link2 = "——";

                    switch (info.CharType)
                    {
                        case "加":
                            info.Result = (double.Parse(Link1) + double.Parse(Link2)).ToString();
                            break;
                        case "减":
                            info.Result = (double.Parse(Link1) - double.Parse(Link2)).ToString();
                            break;
                        case "乘":
                            info.Result = (double.Parse(Link1) * double.Parse(Link2)).ToString();
                            break;
                        case "除":
                            info.Result = (double.Parse(Link1) / double.Parse(Link2)).ToString();
                            break;
                        case "赋值":
                            info.Result = Link1;
                            break;
                        case "连接":
                            info.Result = Link1 + Link2;
                            break;
                    }
                }

                //修改变量值
                foreach (var info in mChar_Info)
                {
                    List<DataCell> globalVar = Sol.mSol.mSysVar.FindAll(c => c.mDataName.ToString() == info.Name.Split(':')[1]);
                    if (globalVar.Count == 1)
                    {
                        DataCell dataCell1 = globalVar[0];
                        dataCell1.mDataValue = info.Result;
                        SetVarList(ref mSysVar, dataCell1);
                    }

                    List<DataCell> localVar = mSloVar.FindAll(c => c.mDataName.ToString() == info.Name.Split(':')[1]);
                    if (localVar.Count == 1)
                    {
                        DataCell dataCell2 = localVar[0];
                        dataCell2.mDataValue = info.Result;
                        SetVarList(ref mSloVar, dataCell2);
                    }
                }

                Log.Info(Sol.mSol.mProjList[ModInfo.Index].mProjInfo.Name + ":" + ModInfo.Name + ":" + "OK");
                ModInfo.State = ModState.OK;
                return ModInfo.Result = true;
            }
            catch (Exception ex)
            {
                Log.Info(Sol.mSol.mProjList[ModInfo.Index].mProjInfo.Name + ":" + ModInfo.Name + ":" + ex.Message);
                ModInfo.State = ModState.OK;
                return ModInfo.Result = false;
            }
        }

        #endregion

        #region 方法-窗体相关

        public override void RunForm(ObjBase baseMod)
        {
            new SetVarForm((SetVarObj)baseMod).ShowDialog();
        }

        #endregion
    }
}
