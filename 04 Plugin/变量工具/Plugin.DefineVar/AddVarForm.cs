using DockContrl;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Plugin.DefineVar
{
    public delegate void DeliveryVal(string[] info);

    public partial class AddVarForm : DockForm
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
        /// 传值委托字段
        /// </summary>
        public DeliveryVal deliveryVal;

        /// <summary>
        /// 传递信息
        /// </summary>
        public string[] delveryInfo = new string[4];

        #endregion

        #region 初始化

        public AddVarForm(DeliveryVal deliveryVal)
        {
            this.deliveryVal = deliveryVal;
            InitializeComponent();
        }

        public AddVarForm(DeliveryVal deliveryVal,string[] info)
        {
            this.deliveryVal = deliveryVal;
            InitializeComponent();
            cbxVarType.Text = info[0];
            tbxVarName.Text = info[1];
            tbxValue.Text = info[2];
            tbxComment.Text = info[3];
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

        /// <summary>
        /// 取消
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void uibt_NO_Click(object sender, EventArgs e)
        {
            Close();
        }

        /// <summary>
        /// 确定
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void uibt_OK_Click(object sender, EventArgs e)
        {
            delveryInfo[0] = cbxVarType.Text;
            delveryInfo[1] = tbxVarName.Text;
            delveryInfo[2] = tbxValue.Text;
            delveryInfo[3] = tbxComment.Text;
            deliveryVal(delveryInfo);
        }

        #endregion
    }
}
