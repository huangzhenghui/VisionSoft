using MutualTools;
using TSIVision;
using TSIVision.FrmLoginR;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TSIVision.FrmConfigR
{
    public partial class FrmConfigCate : Form
    {
        #region 初始化

        public FrmConfigCate()
        {
            InitializeComponent();
        }

        #endregion

        #region 方法-窗体相关

        /// <summary>
        /// 重写CreateParams方法，以防止窗体闪烁
        /// </summary>
        protected override CreateParams CreateParams
        {
            get
            {
                CreateParams paras = base.CreateParams;
                paras.ExStyle |= 0x02000000;
                return paras;
            }
        }

        /// <summary>
        /// 隐藏子窗体
        /// </summary>
        public void HideChlidForm()
        {
            if (FormMain.frmConfigComm.frmServerMenu.Visible || FormMain.frmConfigComm.frmClientMenu.Visible || FormMain.frmConfigComm.frmSerialPortMenu.Visible)
            {
                FormMain.frmConfigComm.frmServerMenu.Hide();
                FormMain.frmConfigComm.frmClientMenu.Hide();
                FormMain.frmConfigComm.frmSerialPortMenu.Hide();
            }
        }

        #endregion

        #region 事件-按钮控件

        private void btn_Click(object sender, EventArgs e)
        {
            HideChlidForm();
            Button btn = sender as Button;
            switch (btn.Name)
            {
                case "btnConfigSys":
                    FrmRTools.ShowFrm(FormMain.pnlFrmObj, FormMain.frmConfigSys);
                    break;
                case "btnConfigCam":
                    FrmRTools.ShowFrm(FormMain.pnlFrmObj, FormMain.frmConfigCam);
                    break;
                case "btnConfigComm":
                    FrmRTools.ShowFrm(FormMain.pnlFrmObj, FormMain.frmConfigComm);
                    break;
                default:
                    break;
            }
        }

        #endregion
    }
}
