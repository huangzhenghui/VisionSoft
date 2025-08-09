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
using VisionCore;

namespace TSIVision.FrmConfigR
{
    public partial class FrmMbsParams : Form
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
        /// Mbs列表
        /// </summary>
        public static UIDataGridView dgvMbsList;

        /// <summary>
        /// Mbs调试窗体
        /// </summary>
        public static FrmMbsDebug frmMbsDebug;

        /// <summary>
        /// 是否更改设备
        /// </summary>
        public bool isChangeCom = true;

        #endregion

        public FrmMbsParams()
        {
            InitializeComponent();
            tbxName.RectColor = Color.AliceBlue;
            tbxName.FillColor = Color.AliceBlue;
            tbxAimIP.RectColor = Color.AliceBlue;
            tbxAimIP.FillColor = Color.AliceBlue;
            tbxAimPort.RectColor = Color.AliceBlue;
            tbxAimPort.FillColor = Color.AliceBlue;
        }

        #region 方法-窗体相关

        /// <summary>
        /// 移动窗体
        /// </summary>
        public void RestoreFrm()
        {
            Location = new Point(806, 342);
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
        private void btnToolBar_Click(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            switch (btn.Name)
            {
                case "btnSave":
                    //bool isEmpty = true;
                    //if (frmParams1.tbxName.Text == "")
                    //{
                    //    frmParams1.pbxJudge1.BackgroundImage = Properties.Resources.Fail;
                    //    isEmpty = false;
                    //}
                    //else
                    //{
                    //    frmParams1.pbxJudge1.BackgroundImage = Properties.Resources.Undetermined;
                    //}

                    //if (frmParams1.cbxSerialPortNum.Text == "")
                    //{
                    //    frmParams1.pbxJudge2.BackgroundImage = Properties.Resources.Fail;
                    //    isEmpty = false;
                    //}
                    //else
                    //{
                    //    frmParams1.pbxJudge2.BackgroundImage = Properties.Resources.Undetermined;
                    //}

                    //if (frmParams1.cbxBaudRate.Text == "")
                    //{
                    //    frmParams1.pbxJudge3.BackgroundImage = Properties.Resources.Fail;
                    //    isEmpty = false;
                    //}
                    //else
                    //{
                    //    frmParams1.pbxJudge3.BackgroundImage = Properties.Resources.Success;
                    //}

                    //if (frmParams2.cbxCheckBits.Text == "")
                    //{
                    //    frmParams2.pbxJudge1.BackgroundImage = Properties.Resources.Fail;
                    //    isEmpty = false;
                    //}
                    //else
                    //{
                    //    frmParams2.pbxJudge1.BackgroundImage = Properties.Resources.Success;
                    //}

                    //if (frmParams2.cbxDataBits.Text == "")
                    //{
                    //    frmParams2.pbxJudge2.BackgroundImage = Properties.Resources.Fail;
                    //    isEmpty = false;
                    //}
                    //else
                    //{
                    //    frmParams2.pbxJudge2.BackgroundImage = Properties.Resources.Success;
                    //}

                    //if (frmParams2.cbxStopBits.Text == "")
                    //{
                    //    frmParams2.pbxJudge3.BackgroundImage = Properties.Resources.Fail;
                    //    isEmpty = false;
                    //}
                    //else
                    //{
                    //    frmParams2.pbxJudge3.BackgroundImage = Properties.Resources.Success;
                    //}

                    //if (!isEmpty)
                    //{
                    //    ShowResult(true, false, "参数为空", true, 61453, Color.Crimson);
                    //    return;
                    //}

                    ////检测是否修改连接设置

                    //if (ECom.mSerialPort.DeviceName == frmParams1.tbxName.Text.Trim() && ECom.mSerialPort.SerialPortNum == frmParams1.cbxSerialPortNum.Text.Trim() && ECom.mSerialPort.BaudRate.ToString() == frmParams1.cbxBaudRate.Text
                    //    && ECom.mSerialPort.CheckBits.ToString() == frmParams2.cbxCheckBits.Text && ECom.mSerialPort.DataBits.ToString() == frmParams2.cbxDataBits.Text && ECom.mSerialPort.ShutBits.ToString() == frmParams2.cbxStopBits.Text)
                    //{
                    //    bool isByHexS1 = false;
                    //    bool isByHexR1 = false;
                    //    if (cbxSendMode.Text == "十六进制") isByHexS1 = true;
                    //    if (cbxReceiveMode.Text == "十六进制") isByHexR1 = true;
                    //    CommParams commParams1 = new CommParams(frmParams1.cbxSerialPortNum.Text, Convert.ToInt32(frmParams1.cbxBaudRate.Text), (Parity)Enum.Parse(typeof(Parity), frmParams2.cbxCheckBits.Text), Convert.ToInt32(frmParams2.cbxDataBits.Text), (StopBits)Enum.Parse(typeof(StopBits), frmParams2.cbxStopBits.Text), isByHexS1, isByHexR1);
                    //    FrmConfigComm.ChangeCom(CommunicationModel.SerialPort, frmParams1.tbxName.Text.Trim(), commParams1);
                    //    ChangeImg(Properties.Resources.Success, Properties.Resources.Success, Properties.Resources.Success, Properties.Resources.Success, Properties.Resources.Success, Properties.Resources.Success, Properties.Resources.Success, Properties.Resources.Success);
                    //    isChangeCom = false;
                    //    return;
                    //}

                    ////判断客户端名称是否已经存在

                    //int index1 = Sol.mSol.mEComList.FindIndex(c => c.DeviceName == frmParams1.tbxName.Text.Trim() && c.CommunicationModel == CommunicationModel.SerialPort);
                    //if (index1 >= 0)
                    //{
                    //    ChangeImg(Properties.Resources.Undetermined, Properties.Resources.Undetermined, Properties.Resources.Success, Properties.Resources.Success, Properties.Resources.Success, Properties.Resources.Success, Properties.Resources.Success, Properties.Resources.Success);
                    //    ShowResult(true, true, "名称重复", true, 61453, Color.Crimson);
                    //    return;
                    //}

                    //int index2 = Sol.mSol.mEComList.FindIndex(c => ((c.SerialPortNum == frmParams1.cbxSerialPortNum.Text.Trim())));
                    //if (index2 >= 0)
                    //{
                    //    ChangeImg(Properties.Resources.Undetermined, Properties.Resources.Undetermined, Properties.Resources.Success, Properties.Resources.Success, Properties.Resources.Success, Properties.Resources.Success, Properties.Resources.Success, Properties.Resources.Success);
                    //    ShowResult(true, true, "串口号重复", true, 61453, Color.Crimson);
                    //    return;
                    //}

                    //bool isByHexS2 = false;
                    //bool isByHexR2 = false;
                    //if (cbxSendMode.Text == "十六进制") isByHexS2 = true;
                    //if (cbxReceiveMode.Text == "十六进制") isByHexR2 = true;
                    //CommParams commParams2 = new CommParams(frmParams1.cbxSerialPortNum.Text, Convert.ToInt32(frmParams1.cbxBaudRate.Text), (Parity)Enum.Parse(typeof(Parity), frmParams2.cbxCheckBits.Text), Convert.ToInt32(frmParams2.cbxDataBits.Text), (StopBits)Enum.Parse(typeof(StopBits), frmParams2.cbxStopBits.Text), isByHexS2, isByHexR2);
                    //FrmConfigComm.ChangeCom(CommunicationModel.TcpClient, frmParams1.tbxName.Text.Trim(), commParams2);
                    //ChangeImg(Properties.Resources.Success, Properties.Resources.Success, Properties.Resources.Success, Properties.Resources.Success, Properties.Resources.Success, Properties.Resources.Success, Properties.Resources.Success, Properties.Resources.Success);
                    //ShowResult(true, false, "修改成功", true, 61452, Color.LightSeaGreen);
                    break;
                case "btnClose":
                    try
                    {
                        if (frmMbsDebug != null) frmMbsDebug.Close();
                        Close();
                    }
                    catch { }

                    break;
            }
        }

        /// <summary>
        /// 打开调试界面
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnPageChange_Click(object sender, EventArgs e)
        {
            //隐藏控件
            //HideCtrls(true);

            //显示服务器调试窗体
            int startPosX = 860;
            int startPosY = 342;
            Location = new Point(startPosX - 360, startPosY);
            if (frmMbsDebug == null || frmMbsDebug.IsDisposed)
            {
                frmMbsDebug = new FrmMbsDebug();
                frmMbsDebug.actRestoreFrm += RestoreFrm;
            }

            Point mouseOff = new Point(Location.X + Width + 1, Location.Y - 30);
            frmMbsDebug.Location = mouseOff;
            frmMbsDebug.StartPosition = FormStartPosition.Manual;
            frmMbsDebug.Show();
        }

        #endregion



        #region 方法-显示串口参数
        /// <summary>
        /// 默认加载界面1
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public void DispMbsParams()
        {
            FrmRTools.ShowFrm(pnlParams, FrmConfigComm.frmMbsParams_1);
            swOpen.Active = ECom.mMbs.IsOpen;
        }

        #endregion

        /// <summary>
        /// 切换参数页
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnParamsPage_Click(object sender, EventArgs e)
        {

        }
    }
}
