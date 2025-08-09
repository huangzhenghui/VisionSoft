using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using VisionCore;

namespace Plugin.RunProj
{
    [Category("流程工具")]
    [DisplayName("执行流程")]
    [Serializable]
    public class RunProjObj : ObjBase
    {
        #region 字段、属性

        /// <summary>
        /// 流程信息
        /// </summary>
        public List<Proj> mRunProj = new List<Proj>();

        /// <summary>
        /// 执行流程索引
        /// </summary>
        public int projIndex = 0;

        #endregion

        #region 方法-模块相关

        /// <summary>
        /// 模块相关
        /// </summary>
        /// <returns></returns>
        public override bool RunObj()
        {
            try
            {
                Sol.OnceRun(projIndex);

                Log.Info(Sol.mSol.mProjList[ModInfo.Index].mProjInfo.Name + ": " + ModInfo.Name + ":" + "执行成功");
                ModInfo.State = ModState.OK;
                return true;
            }
            catch (Exception ex)
            {
                Log.Error(Sol.mSol.mProjList[ModInfo.Index].mProjInfo.Name + ": " + ModInfo.Name + ":" + "执行失败(" + "原因：" + ex.Message + ")");
                ModInfo.State = ModState.NG;
                return false;
            }
        }

        #endregion

        #region 方法-窗体相关

        /// <summary>
        /// 运行窗体
        /// </summary>
        /// <param name="baseMod"></param>
        public override void RunForm(ObjBase baseMod)
        {
            new RunProjForm((RunProjObj)baseMod).ShowDialog();
        }

        #endregion
    }
}
