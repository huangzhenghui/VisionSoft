using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Plugin.WinDisplay
{
    public partial class FrmMessageBox : Form
    {
        #region 字段、属性

        /// <summary>
        /// 鼠标是否为左键
        /// </summary>
        private bool leftFlag;

        /// <summary>
        /// 鼠标移动位置变量
        /// </summary>
        private Point mouseOff;

        /// <summary>
        /// 显示信息
        /// </summary>
        public string msg;

        /// <summary>
        /// 字体样式
        /// </summary>
        string fontType;

        /// <summary>
        /// 字体大小
        /// </summary>
        int fontSize;

        /// <summary>
        /// 字体颜色
        /// </summary>
        string fontColor;

        /// <summary>
        /// 窗体颜色
        /// </summary>
        string winColor;

        #endregion

        #region 初始化

        /// <summary>
        /// 初始化
        /// </summary>
        /// <param name="msg"></param>
        public FrmMessageBox(string msg, string fontType, int fontSize, string fontColor, string winColor)
        {
            InitializeComponent();
            this.msg = msg;
            this.fontType = fontType;
            this.fontSize = fontSize;
            this.fontColor = fontColor;
            this.winColor = winColor;
            lblMessage.Text = msg;
            lblMessage.Font = new Font(fontType, fontSize, FontStyle.Regular);
            lblMessage.ForeColor = ColorTranslator.FromHtml(fontColor);
            BackColor = ColorTranslator.FromHtml(winColor);
            btnClose.BackColor = ColorTranslator.FromHtml(winColor);
        }

        #endregion

        #region 事件-实现窗体移动功能

        /// <summary>
        /// 获取鼠标按下时坐标
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FormBase_MouseDown(object sender, MouseEventArgs e)
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
        private void FormBase_MouseMove(object sender, MouseEventArgs e)
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
        private void FormBase_MouseUp(object sender, MouseEventArgs e)
        {
            if (leftFlag)
            {
                leftFlag = false;
            }
        }

        #endregion

        #region 事件-按钮控件

        /// <summary>
        /// 关闭
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        #endregion
    }
}
