using HalconDotNet;
using MutualTools;
using Rex.UI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Plugin.DistancePP
{
    public partial class ResultForm : Form
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

        #endregion

        #region 初始化

        /// <summary>
        /// 初始化
        /// </summary>
        public ResultForm()
        {
            InitializeComponent();
            tbxResult.Style = UIStyle.Blue;
            tbxResult.FillColor = Color.AliceBlue;
            tbxResult.RectColor = Color.AliceBlue;
        }

        #endregion

        #region 方法-窗体相关

        /// <summary>
        /// 结果显示
        /// </summary>
        public void ShowResult(string result, HTuple hTuple)
        {
            switch (result)
            {
                case "模块未执行":
                    lblResult.ForeColor = Color.LightSalmon;
                    lblResult.SymbolColor = Color.LightSalmon;
                    lblResult.Symbol = 61736;
                    lblResult.Text = "模块未执行";
                    break;
                case "执行成功":
                    lblResult.ForeColor = Color.LightSeaGreen;
                    lblResult.SymbolColor = Color.LightSeaGreen;
                    lblResult.Symbol = 61452;
                    lblResult.Text = "执行成功";
                    break;
                case "执行失败":
                    lblResult.ForeColor = Color.FromArgb(245, 20, 50);
                    lblResult.SymbolColor = Color.FromArgb(245, 20, 50);
                    lblResult.Symbol = 61453;
                    lblResult.Text = "执行失败";
                    break;
            }

            tbxResult.TextAlignment = ContentAlignment.TopLeft;

            HTuple info = new HTuple();
            string str = TypeConvert.HTupleToString(hTuple);
            HTuple strAssem = str.Split(',');
            for (int i = 0; i < strAssem.Length; i++)
            {
                if (i == 0)
                {
                    info = strAssem[i];
                }
                else
                {
                    info = info + "\r\n" + strAssem[i];
                }
            }

            tbxResult.Text = info;
        }

        #endregion

        #region 事件-移动窗体

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

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void uibt_Close_Click(object sender, EventArgs e)
        {
            Close();
        }

        #endregion
    }
}
