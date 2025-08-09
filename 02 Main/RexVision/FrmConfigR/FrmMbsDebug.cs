using Rex.UI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using VisionCore;

namespace TSIVision.FrmConfigR
{
    public partial class FrmMbsDebug : Form
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
        /// 接收线程
        /// </summary>
        Thread thReceive;

        /// <summary>
        /// 复原窗体委托
        /// </summary>
        public Action actRestoreFrm;

        #endregion

        #region 初始化

        /// <summary>
        /// 初始化
        /// </summary>
        public FrmMbsDebug()
        {
            InitializeComponent();
            tbxReceive.Style = UIStyle.Blue;
            tbxReceive.FillColor = Color.MintCream;
            tbxReceive.RectColor = Color.MintCream;
            tbxSend.Style = UIStyle.Blue;
            tbxSend.FillColor = Color.MintCream;
            tbxSend.RectColor = Color.MintCream;

            foreach (Control item in Controls)
            {
                item.DoubleBuffered(true);
            }
        }

        #endregion

        #region 事件-实现窗体移动功能

        /// <summary>
        /// 获取鼠标按下时坐标
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Frm_MouseDown(object sender, MouseEventArgs e)
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
        private void Frm_MouseMove(object sender, MouseEventArgs e)
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
        private void Frm_MouseUp(object sender, MouseEventArgs e)
        {
            if (leftFlag)
            {
                leftFlag = false;
            }
        }

        #endregion

        #region 事件-按钮控件

        /// <summary>
        /// 工具栏按钮事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void toolbarBtn_Click(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            switch (btn.Name)
            {
                case "btnClose":
                    actRestoreFrm();
                    Close();
                    break;
            }
        }

        /// <summary>
        /// 工作区按钮事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cliAreaBtn_Click(object sender, EventArgs e)
        {
            UIButton btn = sender as UIButton;
            switch (btn.Text)
            {
                case "发送":
                    ECom.mMbs.SendData(tbxSend.Text);
                    break;
                case "清空":
                    tbxReceive.Text = "";
                    tbxSend.Text = "";
                    break;
            }
        }

        #endregion
    }
}
