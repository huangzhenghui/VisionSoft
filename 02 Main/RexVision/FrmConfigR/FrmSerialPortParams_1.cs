using RexHelps;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using VisionCore;

namespace TSIVision.FrmConfigR
{
    public partial class FrmSerialPortParams_1 : Form
    {
        #region 初始化

        /// <summary>
        /// 初始化
        /// </summary>
        public FrmSerialPortParams_1()
        {
            InitializeComponent();
        }

        #endregion

        #region 方法-防止窗体闪烁

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

        #endregion

        #region 方法-参数显示

        /// <summary>
        /// 显示子界面1串口参数
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public void DispSerialPortParams_1()
        {
            tbxName.Text = ECom.mSerialPort.DeviceName;
            cbxSerialPortNum.Text = ECom.mSerialPort.SerialPortNum;
            cbxBaudRate.Text = ECom.mSerialPort.BaudRate.ToString();
        }

        #endregion

        #region 方法-将数据保存到变量中

        /// <summary>
        /// 将数据保存到变量中
        /// </summary>
        public void SaveData()
        {
            ECom.mSerialPort.DeviceName = tbxName.Text;
            ECom.mSerialPort.SerialPortNum = cbxSerialPortNum.Text;
            ECom.mSerialPort.BaudRate = Convert.ToInt32(cbxBaudRate.Text);
        }

        #endregion

        #region 方法-显示数据是否符合要求

        /// <summary>
        /// 显示数据是否符合要求
        /// </summary>
        public bool DispResult()
        {
            bool isSave = true;
            if (tbxName.Text!="")
            {
                pbxJudge1.BackgroundImage = Properties.Resources.Success;
            }
            else
            {
                isSave = false;
                pbxJudge1.BackgroundImage = Properties.Resources.Fail;
            }

            if (cbxSerialPortNum.Text!="")
            {
                pbxJudge2.BackgroundImage = Properties.Resources.Success;
            }
            else
            {
                isSave = false;
                pbxJudge2.BackgroundImage = Properties.Resources.Fail;
            }

            if (cbxBaudRate.Text != "")
            {
                pbxJudge3.BackgroundImage = Properties.Resources.Success;
            }
            else
            {
                isSave = false;
                pbxJudge3.BackgroundImage = Properties.Resources.Fail;
            }
            return isSave;
        }

        #endregion

        #region 事件-Timer控件

        /// <summary>
        /// 更新串口号信息
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void timer1_Tick(object sender, EventArgs e)
        {
            string[] serialPortNumAssem = SerialPort.GetPortNames();
            foreach (string serialPortNum in serialPortNumAssem)
            {
                if (!cbxSerialPortNum.Items.Contains(serialPortNum)) cbxSerialPortNum.Items.Add(serialPortNum);
            }
        }

        #endregion
    }
}
