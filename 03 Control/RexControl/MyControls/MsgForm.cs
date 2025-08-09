using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RexControl.MyControls
{
    public partial class MsgForm : Form
    {
        /// <summary>
        /// 鼠标是否为左键
        /// </summary>
        private bool leftFlag;

        /// <summary>
        /// 鼠标移动位置变量
        /// </summary>
        private Point mouseOff;

        /// <summary>
        /// 弹窗状态 OK/NO
        /// </summary>
        public bool state = false;

        public MsgForm()
        {
            InitializeComponent();
        }

        #region 事件-实现窗体移动功能

        /// <summary>
        /// 获取鼠标按下时坐标
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FrmCCamDebug_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                mouseOff = new Point(e.X, e.Y);//获得当前鼠标的坐标
                leftFlag = true;
            }
        }

        /// <summary>
        /// 将窗体跟随鼠标移动
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FrmCCamDebug_MouseMove(object sender, MouseEventArgs e)
        {
            if (leftFlag)
            {
                Point mouseSet = Control.MousePosition;//获得移动后鼠标的坐标
                mouseSet.Offset(-mouseOff.X, -mouseOff.Y);//设置移动后的位置
                Location = mouseSet;
            }
        }

        /// <summary>
        /// 鼠标抬起将标志位置为false
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FrmCCamDebug_MouseUp(object sender, MouseEventArgs e)
        {
            if (leftFlag)
            {
                leftFlag = false;
            }
        }

        #endregion

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnNO_Click(object sender, EventArgs e)
        {
            state = false;
            btnClose.PerformClick();
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            state = true;
            btnClose.PerformClick();
        }

        /// <summary>
        /// 弹窗显示
        /// </summary>
        /// <param name="text"></param>
        public bool ShowMsg(string text, int x, int y)
        {
            lblContent.Text = text;
            Point mouseOff = new Point(x, y);
            Location = new Point(mouseOff.X, mouseOff.Y);
            StartPosition = FormStartPosition.Manual;
            ShowDialog();
            return state;
        }
    }
}
