using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Plugin.NinePointsCalib
{
    public partial class CalibResultForm : Form
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
        /// 结果
        /// </summary>
        public string result = "";

        /// <summary>
        /// X向缩放
        /// </summary>
        public string sx = "";

        /// <summary>
        /// Y向缩放
        /// </summary>
        public string sy = "";

        /// <summary>
        /// RMS
        /// </summary>
        public string RMS = "";

        #endregion

        #region 初始化

        /// <summary>
        /// 初始化
        /// </summary>
        public CalibResultForm()
        {
            InitializeComponent();
        }

        #endregion

        #region 方法-窗体相关

        /// <summary>
        /// 结果显示
        /// </summary>
        public void ShowResult()
        {
            switch (result)
            {
                case "标定未执行":
                    lblResult.ForeColor = Color.LightSalmon;
                    lblResult.SymbolColor = Color.LightSalmon;
                    lblResult.Symbol = 61736;
                    lblResult.Text = "标定未执行";
                    break;
                case "标定成功":
                    lblResult.ForeColor = Color.LightSeaGreen;
                    lblResult.SymbolColor = Color.LightSeaGreen;
                    lblResult.Symbol = 61452;
                    lblResult.Text = "标定成功";
                    break;
                case "标定失败":
                    lblResult.ForeColor = Color.FromArgb(245, 20, 50);
                    lblResult.SymbolColor = Color.FromArgb(245, 20, 50);
                    lblResult.Symbol = 61453;
                    lblResult.Text = "标定失败";
                    break;
            }
            lblPrecisionX.Text = sx;
            lblPrecisionY.Text = sy;
            lblRMS.Text = RMS;
        }

        #endregion

        #region 事件-移动窗体

        /// <summary>
        /// 获取鼠标按下时坐标
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FrmAddVar_MouseDown(object sender, MouseEventArgs e)
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
        private void FrmAddVar_MouseMove(object sender, MouseEventArgs e)
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
        private void FrmAddVar_MouseUp(object sender, MouseEventArgs e)
        {
            if (leftFlag)
            {
                leftFlag = false;
            }
        }

        #endregion

        #region 事件-窗体控件

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void uibt_Close_Click(object sender, EventArgs e)
        {
            btnClose.PerformClick();
        }

        #endregion

        #region 事件-窗体控件

        private void CalibResultForm_Shown(object sender, EventArgs e)
        {
            ShowResult();
        }

        #endregion

    }
}
