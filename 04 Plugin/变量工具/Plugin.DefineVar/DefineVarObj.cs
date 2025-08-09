using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using VisionCore;
namespace Plugin.DefineVar
{
    [Category("变量工具")]
    [DisplayName("变量定义")]
    [Serializable]
    public class DefineVarObj : ObjBase
    {
        #region 字段、属性

        /// <summary>
        /// 局部变量列表
        /// </summary>
        public List<DataCell> mVarList = new List<DataCell>();

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
                if (mVarList.Count>0)
                {
                    foreach(DataCell data in mVarList)
                    {
                        SetVarList(ref mSloVar, data);
                    }
                }
                Log.Info(Sol.mSol.mProjList[ModInfo.Index].mProjInfo.Name + ":" + ModInfo.Name + ":" + "OK");
                ModInfo.State = ModState.OK;
                return ModInfo.Result = true;
            }
            catch(Exception ex)
            {
                Log.Error(Sol.mSol.mProjList[ModInfo.Index].mProjInfo.Name + ":" + ModInfo.Name + ":" + "NG" + " " + ex.Message);
                ModInfo.State = ModState.NG;
                return ModInfo.Result = false;
            }
        }

        #endregion

        #region 方法-窗体相关

        /// <summary>
        /// 窗体显示
        /// </summary>
        /// <param name="baseMod"></param>
        public override void RunForm(ObjBase baseMod)
        {
           new DefineVarForm((DefineVarObj)baseMod).ShowDialog();
        }

        #endregion
    }
}
