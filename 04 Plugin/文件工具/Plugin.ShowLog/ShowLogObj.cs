using HalconDotNet;
using Plugin.CreateROI;
using Rex.UI;
using RexConst;
using RexView;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using VisionCore;
using VisionCore.Core.Project;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static VisionCore.Core.Project.ProjDelegate;

namespace Plugin.ShowLog
{
    [Category("文件工具")]
    [DisplayName("日志显示")]
    [Serializable]
    public class ShowLogObj : ObjBase
    {
        #region 字段、属性

        /// <summary>
        /// 日志等级
        /// </summary>
        public string logLevel = "提示";

        /// <summary>
        /// 日志内容
        /// </summary>
        public string logInfo = "";

        /// <summary>
        /// 中间值
        /// </summary>
        public string logInfoName = "";

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
                //获取数据
                GetData();

                //执行算法
                switch (logLevel)
                {
                    case"调试":
                        Log.Debug(logInfo);
                        break;
                    case "提示":
                        Log.Info(logInfo);
                        break;
                    case "警告":
                        Log.Warn(logInfo);
                        break;
                    case "报错":
                        Log.Error(logInfo);
                        break;
                    case "异常":
                        Log.Fatal(logInfo);
                        break;
                }

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
        /// 显示窗体
        /// </summary>
        /// <param name="baseMod"></param>
        public override void RunForm(ObjBase baseMod)
        {
            new ShowLogForm((ShowLogObj)baseMod).ShowDialog();
        }

        #endregion

        #region 方法-数据相关

        /// <summary>
        /// 如果数据内容是链接，则由GetLinkValue得到链接的值
        /// </summary>
        public void GetData()
        {
            if (logInfoName.Contains(":"))
            {
                logInfo = (string)Var.GetLinkValue(mSysVar, mSloVar, logInfoName);
            }
            else
            {
                logInfo = logInfoName;
            }
        }

        #endregion
    }
}
