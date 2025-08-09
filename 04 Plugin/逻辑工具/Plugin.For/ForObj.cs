using System;
using System.ComponentModel;
using System.Runtime.Serialization;
using VisionCore;
using Plugin;

namespace Plugin.For
{
    [Category("逻辑工具")]
    [DisplayName("循环开始")]
    [Serializable]
    public class ForObj : ObjBase
    {
        #region 字段、属性

        /// <summary>
        /// 循环方式
        /// </summary>
        public ForMode forMode = ForMode.有限;

        /// <summary>
        /// 循环总数
        /// </summary>
        public int forNum = 2;

        /// <summary>
        /// 当前次数
        /// </summary>
        public int nowNum = 0;

        /// <summary>
        /// 中间值
        /// </summary>
        public string strForNum = "2";

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
                GetData();

                switch (forMode)
                {
                    case ForMode.有限:
                        {
                            SetVarList(ref mSloVar, new DataCell(ModInfo.Name, ModInfo.Encode, DataType.单量, DataMode.整型, ConstVar.For, ModInfo.Plugin, "0", 1, nowNum, DataAtrr.全局变量));
                            Log.Info(Sol.mSol.mProjList[ModInfo.Index].mProjInfo.Name + ": " + ModInfo.Name + ":" + nowNum);
                            ModInfo.State = ModState.OK;

                            if (nowNum < Convert.ToInt32(forNum) - 1)
                            {
                                ++nowNum;
                                break;
                            }
                            else
                            {
                                nowNum = 0;
                                return ModInfo.Result = true;
                            }
                        }
                    case ForMode.无限:
                        {
                            nowNum = 0;
                            SetVarList(ref mSloVar, new DataCell(ModInfo.Name, ModInfo.Encode, DataType.单量, DataMode.整型, ConstVar.For, ModInfo.Plugin, "0", 1, nowNum, DataAtrr.全局变量));
                            Log.Info(Sol.mSol.mProjList[ModInfo.Index].mProjInfo.Name + ": " + ModInfo.Name + ":" + nowNum);
                            ModInfo.State = ModState.OK;
                            break;
                        }
                }
            }
            catch (Exception ex)
            {
                nowNum = 0;
                Log.Info(Sol.mSol.mProjList[ModInfo.Index].mProjInfo.Name + ": " + ModInfo.Name + ":" + ex.Message);
                ModInfo.State = ModState.NG;
            }

            return ModInfo.Result = false;
        }

        #endregion

        #region 方法-窗体相关

        /// <summary>
        /// 显示窗体
        /// </summary>
        /// <param name="baseMod"></param>
        public override void RunForm(ObjBase baseMod)
        {
            new ForForm((ForObj)baseMod).ShowDialog();
        }

        #endregion

        #region 数据相关

        /// <summary>
        /// 如果数据内容是链接，则由GetLinkValue得到链接的值
        /// </summary>
        public void GetData()
        {
            try
            {
                forNum = Convert.ToInt32(IsNumber(strForNum) ? strForNum : Var.GetLinkData(mSysVar, strForNum).Split('|')[2]);
            }
            catch { }
        }

        #endregion
    }
}
