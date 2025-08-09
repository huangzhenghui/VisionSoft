using System;
using System.ComponentModel;
using System.Runtime.Serialization;
using VisionCore;

namespace Plugin.ForEnd
{
    [Category("逻辑工具")]
    [DisplayName("循环结束")]
    [Serializable]
    public class ForEndObj : ObjBase
    {
        #region 方法-模块相关

        /// <summary>
        /// 运行模块
        /// </summary>
        /// <returns></returns>
        public override bool RunObj()
        {
           string mNowStr = Var.GetLinkData(mSloVar, ModInfo.Name.Replace("结束","开始")+":"+"Result").Split('|')[2];
            Log.Info(Sol.mSol.mProjList[ModInfo.Index].mProjInfo.Name + ": " + ModInfo.Name + ":" + mNowStr);
            ModInfo.State = ModState.OK;
            return true;
        }

        #endregion

        #region 方法-窗体相关

        /// <summary>
        /// 显示窗体
        /// </summary>
        /// <param name="baseMod"></param>
        public override void RunForm(ObjBase baseMod)
        {
           new ForEndForm((ForEndObj)baseMod).ShowDialog();
        }

        #endregion
    }
}
