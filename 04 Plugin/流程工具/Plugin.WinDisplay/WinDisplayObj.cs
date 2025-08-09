using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing.Text;
using System.Drawing;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using VisionCore;
using Rex.UI;

namespace Plugin.WinDisplay
{
    [Category("流程工具")]
    [DisplayName("弹窗显示")]
    [Serializable]
    public class WinDisplayObj : ObjBase
    {
        #region 字段、属性

        /// <summary>
        /// 字体样式
        /// </summary>
        public string fontType = "华文新魏";

        /// <summary>
        /// 字体大小
        /// </summary>
        public int fontSize = 11;

        /// <summary>
        /// 字体颜色
        /// </summary>
        public string fontColor = "#181870";

        /// <summary>
        /// 字体大小
        /// </summary>
        public string winColor = "#F0FFFF";

        /// <summary>
        /// 弹窗内容
        /// </summary>
        public string winMessage = "请输入弹窗内容...";

        /// <summary>
        /// 弹窗对象
        /// </summary>
        [NonSerialized]
        public FrmMessageBox frmMessageBox;

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
                frmMessageBox = new FrmMessageBox(winMessage, fontType, fontSize, fontColor, winColor);
                frmMessageBox.ShowDialog();

                Log.Info(Sol.mSol.mProjList[ModInfo.Index].mProjInfo.Name + ": " + ModInfo.Name + ":" + "执行成功!");
                ModInfo.State = ModState.OK;
                return true;
            }
            catch(Exception ex)
            {
                Log.Info(Sol.mSol.mProjList[ModInfo.Index].mProjInfo.Name + ": " + ModInfo.Name + ":" + ex.Message);
                ModInfo.State = ModState.NG;
                return false;
            }
        }

        #endregion

        #region 方法-窗体显示

        /// <summary>
        /// 显示窗体
        /// </summary>
        /// <param name="baseMod"></param>
        public override void RunForm(ObjBase baseMod)
        {
            new WinDisplayForm((WinDisplayObj)baseMod).ShowDialog();
        }

        #endregion
    }
}
