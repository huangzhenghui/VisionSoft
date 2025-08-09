using System;
using System.ComponentModel;
using System.Runtime.Serialization;
using VisionCore;

namespace Plugin.IFEnd
{
    [Category("逻辑工具")]
    [DisplayName("结束")]
    [Serializable]
    public class IFEndObj : ObjBase
    {
        #region 方法-模块相关

        /// <summary>
        /// 运行模块
        /// </summary>
        /// <returns></returns>
        public override bool RunObj()
        {
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
            new IFEndForm((IFEndObj)baseMod).ShowDialog();
        }

        #endregion
    }
}
