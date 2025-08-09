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

namespace Plugin.Delay
{
    [Category("流程工具")]
    [DisplayName("流程延时")]
    [Serializable]
    public class DelayObj : ObjBase
    {
        #region 字段、属性

        [NonSerialized]
        public AutoResetEvent mEventWait = new AutoResetEvent(false);//采集信号

        /// <summary>
        /// 默认延时
        /// </summary>
        public int mDelayTime = 500;

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
                mEventWait.Reset();
                Task<bool> longTask = new Task<bool>(() => WaitTimeTask(mDelayTime));
                longTask.Start();
                mEventWait.WaitOne();
                ModInfo.State = ModState.OK;
                return true;
            }
            catch
            {
                ModInfo.State = ModState.NG;
                return false;
            }
        }

        /// <summary>
        /// 延时线程
        /// </summary>
        /// <param name="mDelayTime"></param>
        /// <param name="token"></param>
        /// <returns></returns>
        private bool WaitTimeTask(int mDelayTime)
        {
            Thread.Sleep(mDelayTime);
            mEventWait.Set();
            Log.Info(Sol.mSol.mProjList[ModInfo.Index].mProjInfo.Name + ":" + ModInfo.Name + ":" + mDelayTime + "ms");
            return true;
        }

        #endregion

        #region 方法-窗体显示

        /// <summary>
        /// 显示窗体
        /// </summary>
        /// <param name="baseMod"></param>
        public override void RunForm(ObjBase baseMod)
        {
            new DelayForm((DelayObj)baseMod).ShowDialog();
        }

        #endregion

        /// <summary>
        /// 信息赋值
        /// </summary>
        public override void SetInfo() 
        {
            mEventWait = new AutoResetEvent(false);//采集信号
        }
    }
}
