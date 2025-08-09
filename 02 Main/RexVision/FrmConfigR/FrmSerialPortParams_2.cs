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
using System.Xml.Linq;
using VisionCore;

namespace TSIVision.FrmConfigR
{
    public partial class FrmSerialPortParams_2 : Form
    {
        #region 初始化

        public FrmSerialPortParams_2()
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
        /// 显示子界面2串口参数
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public void DispSerialPortParams_2()
        {
            cbxCheckBits.Text = ECom.mSerialPort.CheckBits.ToString();
            cbxDataBits.Text = ECom.mSerialPort.DataBits.ToString();
            cbxStopBits.Text = ECom.mSerialPort.ShutBits.ToString();
        }

        #endregion

        #region 方法-将数据保存到变量中

        /// <summary>
        /// 将数据保存到变量中
        /// </summary>
        public void SaveData()
        {
            ECom.mSerialPort.CheckBits = (Parity)Enum.Parse(typeof(Parity), cbxCheckBits.Text);
            ECom.mSerialPort.DataBits = Convert.ToInt32(cbxDataBits.Text);
            ECom.mSerialPort.ShutBits = (StopBits)Enum.Parse(typeof(StopBits), cbxStopBits.Text);
        }

        #endregion

        #region 方法-显示数据是否符合要求

        /// <summary>
        /// 显示数据是否符合要求
        /// </summary>
        public bool DispResult()
        {
            bool isSave = true;
            if (cbxCheckBits.Text != "")
            {
                pbxJudge1.BackgroundImage = Properties.Resources.Success;
            }
            else
            {
                isSave = false;
                pbxJudge1.BackgroundImage = Properties.Resources.Fail;
            }

            if (cbxDataBits.Text != "")
            {
                pbxJudge2.BackgroundImage = Properties.Resources.Success;
            }
            else
            {
                isSave = false;
                pbxJudge2.BackgroundImage = Properties.Resources.Fail;
            }

            if (cbxStopBits.Text != "")
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
    }
}
