using Rex.UI;
using RexHelps;
using TSIVision;

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
    public partial class FrmConfigSys : Form
    {
        #region 字段、属性

        public static int OrgQty = 0;//原有相机窗口数量
        public static int NewQty = 0;//更改相机窗口数量
        public static RIni mRini = new RIni(Application.StartupPath + "\\Config.ini");//配置文件地址

        #endregion

        #region 初始化
        public FrmConfigSys()
        {
            InitializeComponent();

            rb_1.RadioButtonColor = Color.Navy;
            rb_2.RadioButtonColor = Color.Navy;
            rb_3.RadioButtonColor = Color.Navy;
            rb_4.RadioButtonColor = Color.Navy;
            rb_5.RadioButtonColor = Color.Navy;
            rb_6.RadioButtonColor = Color.Navy;
            rb_7.RadioButtonColor = Color.Navy;
            rb_8.RadioButtonColor = Color.Navy;
            rb_9.RadioButtonColor = Color.Navy;

            
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

        #endregion

        #region 方法-读取配置文件

        /// <summary>
        /// 读取配置文件(作用于控件)
        /// </summary>
        public void ReadConfig()
        {
            //基本设置
            ui_OpenStart.Checked = bool.Parse(mRini.ReadValue("Config", "mOpenStart", "true"));
            ui_StartLoadProj.Checked = bool.Parse(mRini.ReadValue("Config", "mStartLoadProj", "true"));
            ui_AutoRun.Checked = bool.Parse(mRini.ReadValue("Config", "mAutoRun", "true"));
            ui_AutoSaveProj.Checked = bool.Parse(mRini.ReadValue("Config", "mAutoSaveProj", "true"));

            //文件设置
            tbxLoadProjPath.Text = mRini.ReadValue("Config", "mLoadProjPath", "");
            tbxSaveProjPath.Text = mRini.ReadValue("Config", "mSaveProjPath", "");
            tbxSaveLogPath.Text = mRini.ReadValue("Config", "mSaveLogPath", "");
            tbxSaveImgPath.Text = mRini.ReadValue("Config", "mSaveImgPath", "");
            tbxSaveDataPath.Text = mRini.ReadValue("Config", "mSaveDataPath", "");

            //相机窗口设置
            NewQty = int.Parse(mRini.ReadValue("Config", "mScreenNum", "0"));

            if (NewQty == 0) { rb_1.Checked = true; }
            if (NewQty == 1) { rb_2.Checked = true; }
            if (NewQty == 2) { rb_3.Checked = true; }
            if (NewQty == 3) { rb_4.Checked = true; }
            if (NewQty == 4) { rb_5.Checked = true; }
            if (NewQty == 5) { rb_6.Checked = true; }
            if (NewQty == 6) { rb_7.Checked = true; }
            if (NewQty == 7) { rb_8.Checked = true; }
            if (NewQty == 8) { rb_9.Checked = true; }

            //运行设置
            tbxLogDay.Text = mRini.ReadValue("Config", "mLogSaveDay", "10");
            tbxRunInterval.Text = mRini.ReadValue("Config", "mRunInterval", "100");
            tbxNetInterval.Text = mRini.ReadValue("Config", "mNetInterval", "100");
        }

        #endregion

        #region 事件-按钮控件

        /// <summary>
        /// 保存设置
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void uiPnl_Click(object sender, EventArgs e)
        {
            UITitlePanel uITitlePanel = sender as UITitlePanel;
            switch (uITitlePanel.Text)
            {
                case "基本设置":
                    if (MessageBox.Show("是否保存设置？", "保存", MessageBoxButtons.OKCancel) == DialogResult.OK)
                    {
                        Sol.mOpenStart = ui_OpenStart.Checked;
                        Sol.mStartLoadProj = ui_StartLoadProj.Checked;
                        Sol.mAutoRun = ui_AutoRun.Checked;
                        Sol.mAutoSaveProj = ui_AutoSaveProj.Checked;

                        mRini.WriteValue("Config", "mOpenStart", ui_OpenStart.Checked.ToString());
                        mRini.WriteValue("Config", "mStartLoadProj", ui_StartLoadProj.Checked.ToString());
                        mRini.WriteValue("Config", "mAutoRun", ui_AutoRun.Checked.ToString());
                        mRini.WriteValue("Config", "mAutoSaveProj", ui_AutoSaveProj.Checked.ToString());
                    }
                    break;
                case "文件设置":
                    if (MessageBox.Show("是否保存设置？", "保存", MessageBoxButtons.OKCancel) == DialogResult.OK)
                    {
                        Sol.mLoadProjPath = tbxLoadProjPath.Text.Trim();
                        Sol.mSaveProjPath = tbxSaveProjPath.Text.Trim();
                        Sol.mSaveLogPath = tbxSaveLogPath.Text.Trim();
                        Sol.mSaveImgPath = tbxSaveImgPath.Text.Trim();
                        Sol.mSaveDataPath = tbxSaveDataPath.Text.Trim();

                        mRini.WriteValue("Config", "mLoadProjPath", tbxLoadProjPath.Text.Trim());
                        mRini.WriteValue("Config", "mSaveProjPath", tbxSaveProjPath.Text.Trim());
                        mRini.WriteValue("Config", "mSaveLogPath", tbxSaveLogPath.Text.Trim());
                        mRini.WriteValue("Config", "mSaveImgPath", tbxSaveImgPath.Text.Trim());
                        mRini.WriteValue("Config", "mSaveDataPath", tbxSaveDataPath.Text.Trim());
                    }
                    break;
                case "相机窗口设置":
                    if (MessageBox.Show("是否保存设置？", "保存", MessageBoxButtons.OKCancel) == DialogResult.OK)
                    {
                        Sol.mSol.mScreenNum = NewQty;
                        FormMain.mMainShow.CanvasSet(NewQty);

                        mRini.WriteValue("Config", "mScreenNum", NewQty.ToString());
                    }
                    else
                    {
                        NewQty = OrgQty;
                    }
                    break;
                case "运行设置":
                    if (MessageBox.Show("是否保存设置？", "保存", MessageBoxButtons.OKCancel) == DialogResult.OK)
                    {
                        Sol.mLogSaveDay = int.Parse(tbxLogDay.Text.Trim());
                        Sol.mRunInterval = int.Parse(tbxRunInterval.Text.Trim());
                        Sol.mNetInterval = int.Parse(tbxNetInterval.Text.Trim());

                        mRini.WriteValue("Config", "mLogSaveDay", tbxLogDay.Text.Trim());
                        mRini.WriteValue("Config", "mRunInterval", tbxRunInterval.Text.Trim());
                        mRini.WriteValue("Config", "mNetInterval", tbxNetInterval.Text.Trim());
                    }
                    break;
                default:
                    break;
            }
        }

        /// <summary>
        /// 相机窗口数量选择
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="value"></param>
        private void rb_Click(object sender, EventArgs e)
        {
            UIRadioButton uIRadioButton = sender as UIRadioButton;
            switch (uIRadioButton.Name)
            {
                case "rb_1":
                    NewQty = 0;
                    rb_1.Checked = true;
                    rb_2.Checked = false;
                    rb_3.Checked = false;
                    rb_4.Checked = false;
                    rb_5.Checked = false;
                    rb_6.Checked = false;
                    rb_7.Checked = false;
                    rb_8.Checked = false;
                    rb_9.Checked = false;
                    break;
                case "rb_2":
                    NewQty = 1;
                    rb_1.Checked = false;
                    rb_2.Checked = true;
                    rb_3.Checked = false;
                    rb_4.Checked = false;
                    rb_5.Checked = false;
                    rb_6.Checked = false;
                    rb_7.Checked = false;
                    rb_8.Checked = false;
                    rb_9.Checked = false;
                    break;
                case "rb_3":
                    NewQty = 2;
                    rb_1.Checked = false;
                    rb_2.Checked = false;
                    rb_3.Checked = true;
                    rb_4.Checked = false;
                    rb_5.Checked = false;
                    rb_6.Checked = false;
                    rb_7.Checked = false;
                    rb_8.Checked = false;
                    rb_9.Checked = false;
                    break;
                case "rb_4":
                    NewQty = 3;
                    rb_1.Checked = false;
                    rb_2.Checked = false;
                    rb_3.Checked = false;
                    rb_4.Checked = true;
                    rb_5.Checked = false;
                    rb_6.Checked = false;
                    rb_7.Checked = false;
                    rb_8.Checked = false;
                    rb_9.Checked = false;
                    break;
                case "rb_5":
                    NewQty = 4;
                    rb_1.Checked = false;
                    rb_2.Checked = false;
                    rb_3.Checked = false;
                    rb_4.Checked = false;
                    rb_5.Checked = true;
                    rb_6.Checked = false;
                    rb_7.Checked = false;
                    rb_8.Checked = false;
                    rb_9.Checked = false;
                    break;
                case "rb_6":
                    NewQty = 5;
                    rb_1.Checked = false;
                    rb_2.Checked = false;
                    rb_3.Checked = false;
                    rb_4.Checked = false;
                    rb_5.Checked = false;
                    rb_6.Checked = true;
                    rb_7.Checked = false;
                    rb_8.Checked = false;
                    rb_9.Checked = false;
                    break;
                case "rb_7":
                    NewQty = 6;
                    rb_1.Checked = false;
                    rb_2.Checked = false;
                    rb_3.Checked = false;
                    rb_4.Checked = false;
                    rb_5.Checked = false;
                    rb_6.Checked = false;
                    rb_7.Checked = true;
                    rb_8.Checked = false;
                    rb_9.Checked = false;
                    break;
                case "rb_8":
                    NewQty = 7;
                    rb_1.Checked = false;
                    rb_2.Checked = false;
                    rb_3.Checked = false;
                    rb_4.Checked = false;
                    rb_5.Checked = false;
                    rb_6.Checked = false;
                    rb_7.Checked = false;
                    rb_8.Checked = true;
                    rb_9.Checked = false;
                    break;
                case "rb_9":
                    NewQty = 8;
                    rb_1.Checked = false;
                    rb_2.Checked = false;
                    rb_3.Checked = false;
                    rb_4.Checked = false;
                    rb_5.Checked = false;
                    rb_6.Checked = false;
                    rb_7.Checked = false;
                    rb_8.Checked = false;
                    rb_9.Checked = true;
                    break;
                default:
                    break;
            }
        }

        /// <summary>
        /// 选择文件路径
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSelectPath_Click(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            switch (btn.Name)
            {
                case "btnLoadProjPath":
                    {
                        OpenFileDialog fileDialog = new OpenFileDialog();
                        fileDialog.Multiselect = true;
                        fileDialog.Title = "请选择文件";
                        fileDialog.Filter = "所有文件(*.*)|*.*";
                        if (fileDialog.ShowDialog() == DialogResult.OK)
                        {
                            tbxLoadProjPath.Text = fileDialog.FileName;
                        }
                        break;
                    }
                case "btnSaveProjPath":
                    {
                        OpenFileDialog fileDialog = new OpenFileDialog();
                        fileDialog.Multiselect = true;
                        fileDialog.Title = "请选择文件";
                        fileDialog.Filter = "所有文件(*.*)|*.*";
                        if (fileDialog.ShowDialog() == DialogResult.OK)
                        {
                            tbxSaveProjPath.Text = fileDialog.FileName;
                        }
                        break;
                    }
                case "btnSaveLogPath":
                    {
                        FolderBrowserDialog dialog = new FolderBrowserDialog();
                        dialog.Description = "请选择文件夹";
                        if (dialog.ShowDialog() == DialogResult.OK)
                        {
                            tbxSaveLogPath.Text = dialog.SelectedPath;
                        }
                        break;
                    }
                case "btnSaveImgPath":
                    {
                        FolderBrowserDialog dialog = new FolderBrowserDialog();
                        dialog.Description = "请选择文件夹";
                        if (dialog.ShowDialog() == DialogResult.OK)
                        {
                            tbxSaveImgPath.Text = dialog.SelectedPath;
                        }
                        break;
                    }
                case "btnSaveDataPath":
                    {
                        FolderBrowserDialog dialog = new FolderBrowserDialog();
                        dialog.Description = "请选择文件夹";
                        if (dialog.ShowDialog() == DialogResult.OK)
                        {
                            tbxSaveDataPath.Text = dialog.SelectedPath;
                        }
                        break;
                    }
                default:
                    break;
            }
        }

        /// <summary>
        /// 时间加减设置
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnPlusAndSub_Click(object sender, EventArgs e)
        {
            if (tbxImgDay.Text == "") tbxImgDay.Text = "0";
            if (tbxLogDay.Text == "") tbxImgDay.Text = "0";
            if (tbxRunInterval.Text == "") tbxImgDay.Text = "0";
            if (tbxNetInterval.Text == "") tbxImgDay.Text = "0";

            int tbx1Value = int.Parse(tbxImgDay.Text);
            int tbx2Value = int.Parse(tbxLogDay.Text);
            int tbx3Value = int.Parse(tbxRunInterval.Text);
            int tbx4Value = int.Parse(tbxNetInterval.Text);
            Button btn = sender as Button;
            switch (btn.Name)
            {
                case "btn1Plus":
                    if (tbx1Value < 0)
                    {
                        tbx1Value = 0;
                        tbxImgDay.Text = "0";
                        return;
                    }
                    tbxImgDay.Text = (++tbx1Value).ToString();
                    break;
                case "btn1Sub":
                    if (tbx1Value < 0)
                    {
                        tbx1Value = 0;
                        tbxImgDay.Text = "0";
                        return;
                    }
                    tbxImgDay.Text = (--tbx1Value).ToString();
                    break;
                case "btn2Plus":
                    if (tbx2Value < 0)
                    {
                        tbx2Value = 0;
                        tbxLogDay.Text = "0";
                        return;
                    }
                    tbxLogDay.Text = (++tbx2Value).ToString();
                    break;
                case "btn2Sub":
                    if (tbx2Value < 0)
                    {
                        tbx2Value = 0;
                        tbxLogDay.Text = "0";
                        return;
                    }
                    tbxLogDay.Text = (--tbx2Value).ToString();
                    break;
                case "btn3Plus":
                    if (tbx3Value < 0)
                    {
                        tbx3Value = 0;
                        tbxRunInterval.Text = "0";
                        return;
                    }
                    tbxRunInterval.Text = (++tbx3Value).ToString();
                    break;
                case "btn3Sub":
                    if (tbx3Value < 0)
                    {
                        tbx3Value = 0;
                        tbxRunInterval.Text = "0";
                        return;
                    }
                    tbxRunInterval.Text = (--tbx3Value).ToString();
                    break;
                case "btn4Plus":
                    if (tbx4Value < 0)
                    {
                        tbx4Value = 0;
                        tbxNetInterval.Text = "0";
                        return;
                    }
                    tbxNetInterval.Text = (++tbx4Value).ToString();
                    break;
                case "btn4Sub":
                    if (tbx4Value < 0)
                    {
                        tbx4Value = 0;
                        tbxNetInterval.Text = "0";
                        return;
                    }
                    tbxNetInterval.Text = (--tbx4Value).ToString();
                    break;
                default:
                    break;
            }
        }

        #endregion
    }
}