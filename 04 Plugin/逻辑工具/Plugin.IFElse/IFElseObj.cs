using System;
using System.ComponentModel;
using System.Runtime.Serialization;
using VisionCore;

namespace Plugin.IFElse
{
    [Category("逻辑工具")]
    [DisplayName("否则")]
    [Serializable]
    public class IFElseObj : ObjBase
    {
        #region 字段、属性

        /// <summary>
        /// bool型输入数据
        /// </summary>
        public bool data = false;

        /// <summary>
        /// 中间值
        /// </summary>
        public string dataMed = "";

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

                SetVarList(ref mSloVar, new DataCell(ModInfo.Name, ModInfo.Encode, DataType.单量, DataMode.布尔型, ConstVar.Else, ModInfo.Plugin, "0", 1, data, DataAtrr.全局变量));
             
                Log.Info(Sol.mSol.mProjList[ModInfo.Index].mProjInfo.Name + ": " + ModInfo.Name + ":" + data);
                ModInfo.State = ModState.OK;

                if (data)
                {
                    ModInfo.Result = true;
                }
                else
                {
                    ModInfo.Result = false;
                }
                return ModInfo.Result;
            }
            catch (Exception ex)
            {
                Log.Info(Sol.mSol.mProjList[ModInfo.Index].mProjInfo.Name + ": " + ModInfo.Name + ":" + ex.Message);
                ModInfo.State = ModState.NG;
                return ModInfo.Result = false;
            }
        }

        #endregion

        #region 方法-数据相关

        public void GetData()
        {
            if (dataMed.Contains(":"))
            {
                data = (bool)Var.GetLinkValue(mSysVar, mSloVar, dataMed);
            }
            else
            {
                switch (dataMed.ToLower())
                {
                    case "true":
                        data = true;
                        break;
                    case "false":
                        data = false;
                        break;
                }
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
            new IFElseForm((IFElseObj)baseMod).ShowDialog();
        }

        #endregion
    }
}
