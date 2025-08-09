using System;
using System.Linq;
using System.Windows.Forms;
using System.Collections.Generic;
using RexConst;
using System.Drawing;
using VisionCore;
using NPOI.POIFS.FileSystem;
using NPOI.HSSF.UserModel;
using NPOI.SS.UserModel;
using System.IO;
using System.Threading;
using TSIVision.FrmHomeR;
using TSIVision.FrmConfigR;
using Rex.UI;
using System.Diagnostics;
using TSIVision.FrmVarR;
using MutualTools;
using WeifenLuo.WinFormsUI.Docking;
using VisionCore.Core.Project;
using TSIVision.Properties;

namespace TSIVision
{
    public partial class FormMain : DockContent
    {
        #region 字段、属性

        Thread thGetSystemInfo;//获取系统信息线程
        string userType;//登录用户类型
        string CPUUR;//CPU利用率
        string RAMUR;//内存利用率
        string diskUR;//磁盘利用率
        string systemTime;//系统时间
        DateTime startTime;//程序开启时间
        DateTime endTime;//程序结束时间
        string runInterval;//程序运行时长
        public static int isMaiFrmClose = 0;//关闭窗体后的的执行操作的标志位，初始化为0，关闭软件为1，重启软件为2
        public static FrmProj frmProj;
        public static Panel MainPanel;
        public static Panel pnlFrmObj;//用于加载窗体
        private bool leftFlag;//鼠标是否为左键
        private Point mouseOff;//鼠标移动位置变量
        public static event SetEComDg SetEComEvent;
        public static DateTime RunStartTime = DateTime.Now;//运行起始时间
        public static FrmShow mMainShow = null;//父窗体
        private List<Form> mFormList = new List<Form>();//子窗体
        //public static FrmHomeCate frmHomeCate = new FrmHomeCate();//Home界面分类窗体
        public static FrmHome frmHome = new FrmHome();//Home界面分类窗体
        public static FrmConfigSys frmConfigSys = new FrmConfigSys();//系统配置界面窗体
        public static FrmConfigCam frmConfigCam = new FrmConfigCam();//相机配置界面窗体
        public static FrmConfigComm frmConfigComm = new FrmConfigComm();//通讯配置界面窗体
      
        public static FrmVar frmVar = new FrmVar();//全局变量界面窗体
      

        #endregion

        #region 初始化

        public FormMain()
        {
            InitializeComponent();
            SetStyle(ControlStyles.DoubleBuffer, true);// 双缓冲
            SetStyle(ControlStyles.UserPaint, true);
            SetStyle(ControlStyles.ResizeRedraw, true);
            SetStyle(ControlStyles.AllPaintingInWmPaint, true);
            SetStyle(ControlStyles.OptimizedDoubleBuffer, true);
            SetStyle(ControlStyles.SupportsTransparentBackColor, true);
            pnlFrmObj = pnlFrm;
            ProjDelegate.deliverySolName += ShowSolName;
            this.WindowState = FormWindowState.Maximized;
        }

        #endregion

        #region 方法-窗体相关

        /// <summary>
        /// 子窗体加载
        /// </summary>
        private void ShowUIForm()
        {
            try
            {
                mMainShow = new FrmShow();
                mFormList.Add(mMainShow);
                foreach (Form form in mFormList)
                {
                    form.TopLevel = false;
                    MainPanel.Controls.Add(form);
                    form.Show();
                }
                mMainShow.Dock = DockStyle.Fill;
                mMainShow.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "提示", MessageBoxButtons.OK, MessageBoxIcon.Hand);
            }
        }

        /// <summary>
        /// 显示图像
        /// </summary>
        /// <param name="name"></param>
        /// <param name="image"></param>
        protected void ShowImgae(string name, RImage image)
        {
            if (image != null)
            {
                if (image.Screen <= 0) return;
                mMainShow?.Invoke(new Action(() => { mMainShow.ScreenShow(image); }));
            }
        }

        /// <summary>
        /// 清空图像窗口
        /// </summary>
        protected void ClearWindow()
        {
            mMainShow?.Invoke(new Action(() => { mMainShow.ScreenClear(); }));
        }

        /// <summary>
        /// 清空日志窗口
        /// </summary>
        protected void ClearLog()
        {
            mMainShow?.Invoke(new Action(() => { mMainShow.LogClear(); }));
        }

        /// <summary>
        /// 动态绘制监控控件
        /// </summary>
        public static void DynDrawCtrls()
        {
            if (Sol.mSol == null) return;
            foreach (CtrlVar ctrlVar in Sol.mSol.ctrlVarColl)
            {
                switch (ctrlVar.CtrlType)
                {
                    case "执行监控控件":
                        FrmVar.DynDrawCtrls(ctrlVar.CtrlType, ctrlVar.CtrlName, ctrlVar.CtrlValueInit, 6);
                        break;
                    case "数据监控控件":
                        FrmVar.DynDrawCtrls(ctrlVar.CtrlType, ctrlVar.CtrlName, ctrlVar.CtrlValueInit, 4);
                        break;
                    case "线程监控控件":
                        FrmVar.DynDrawCtrls(ctrlVar.CtrlType, ctrlVar.CtrlName, ctrlVar.CtrlValueInit, 6);
                        break;
                    default:
                        break;
                }
            }
        }

        /// <summary>
        /// 显示项目名称
        /// </summary>
        public void ShowSolName(string solName)
        {
            ts_ProjPath.Text = "     " + solName + "     ";
        }

        #endregion

        #region 方法-项目操作相关

        /// <summary>
        /// 新建项目
        /// </summary>
        public void CreateProj()
        {
            if (Sol.mSol == null)
            {
                Sol.mSol = new Sol();
            }
            else
            {
                if (MessageBox.Show("是否保存当前项目?", "消息", MessageBoxButtons.YesNoCancel) == DialogResult.Yes)
                {
                    if (mSaveFile.ShowDialog() == DialogResult.OK)
                    {
                        try
                        {
                            Sol.mSaveProjPath = mSaveFile.FileName;
                            Sol.SaveData(mSaveFile.FileName, Sol.mSol);
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.Message, "提示", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                        }
                    }
                }
            }

            ShowMsg.SendClearWindow();
            ClearLog();

            Sol.mSol.Dispose();
            Sol.mSol = new Sol();
            Sol.mSol.mScreenNum = 3;

            if (Sol.mSol != null)
            {
                mMainShow.SetProj();
                mMainShow.CanvasSet(Sol.mSol.mScreenNum);
            }

            Log.Info("项目: " + Sol.mSol.Name + "(路径: " + Sol.mSaveProjPath + ")" + "新建成功!");
        }

        /// <summary>
        /// 打开项目
        /// </summary>
        /// <param name="msg"></param>
        private void OpenProj(string msg)
        {
            Sol.mLoadProjPath = FrmConfigSys.mRini.ReadValue("Config", "mLoadProjPath", "");
            if (Sol.mSol != null)
            {
                Sol.mSol.CloseProj();
                SetEComEvent(null, EComOperate.Clear);
            }
            Sol.IsStop = true;
            Sol.mSol = Sol.ReadData(Sol.mLoadProjPath);
            if (Sol.mSol != null)
            {
                Sol.mSol.InitCameraStatus();
                Sol.mSol.InitCommStatus();
                mMainShow.SetProj();
                mMainShow.CanvasSet(Sol.mSol.mScreenNum);
                if (bool.Parse(FrmConfigSys.mRini.ReadValue("Config", "mOpenStart", "false")))
                {
                    if (msg.Equals("AutoStart"))
                    {
                        if (Sol.mSol.mProjList.Count>0& Sol.mSol.mProjList[0].mObjBase.Count>0)
                        {
                            Sol.StartRun();
                        }
                    }
                }
            }
            else
            {
                Sol.mSol = new Sol();
            }
        }

        #endregion

        #region 方法-显示系统信息

        /// <summary>
        /// 显示系统信息
        /// </summary>
        private void DispSystemInfo()
        {
            while (true)
            {
                try
                {
                    userType = "工程师";
                    endTime = DateTime.Now;
                    TimeSpan timeSpan = endTime.Subtract(startTime);
                    CPUUR = "CPU:" + GetSystemInfo.GetCPUUR();
                    RAMUR = "内存:" + GetSystemInfo.GetRAMUR();
                    diskUR = "D盘:" + GetSystemInfo.GetDiskUR("D");
                    runInterval = "运行:" + timeSpan.Days.ToString() + "天" + timeSpan.Hours.ToString() + "时" + timeSpan.Minutes.ToString() + "分" + timeSpan.Seconds.ToString() + "秒";
                    systemTime = GetSystemInfo.GetSystemTime();

                    this.BeginInvoke(new Action(() =>
                    {
                        tsUserType.Text = userType;
                        tsCPUUR.Text = CPUUR;
                        tsRAMUR.Text = RAMUR;
                        tsDiskUR.Text = diskUR;
                        tsRunTime.Text = runInterval;
                        tsSystemTime.Text = systemTime;
                    }));

                    Thread.Sleep(200);
                }
                catch { }
            }
        }

        #endregion

        #region 方法-界面刷新

        /// <summary>
        /// 界面刷新
        /// </summary>
        public void InterfaceRefresh()
        {
            //变量界面
            frmVar.RefreshVarList();

            //Home界面
         
            DynDrawCtrls();
        }

        /// <summary>
        /// 隐藏子窗体
        /// </summary>
        public void HideChlidForm()
        {
            if (frmConfigComm.frmServerMenu.Visible || frmConfigComm.frmClientMenu.Visible || frmConfigComm.frmSerialPortMenu.Visible)
            {
                frmConfigComm.frmServerMenu.Hide();
                frmConfigComm.frmClientMenu.Hide();
                frmConfigComm.frmSerialPortMenu.Hide();
            }
        }

        #endregion

        #region 方法-监控控件数据显示

        /// <summary>
        /// 监控控件显示
        /// </summary>
        /// <param name = "name" ></ param >
        /// < param name="image"></param>
        public void ShowCtrlInfo()
        {
            try 
            {
                Invoke(new Action(() =>
                {
                    for (int i = 0; i < Sol.mSol.ctrlVarColl.Count; i++)
                    {
                        string val = Convert.ToString(Sol.mSol.mSysVar.FirstOrDefault(c => c.mDataName == Sol.mSol.ctrlVarColl[i].CtrlValue).mDataValue);
                        Label lbl = FrmVar.labels.FirstOrDefault(c => c.Name == Sol.mSol.ctrlVarColl[i].CtrlName);
                        if (lbl != null)
                        {
                            if (val != "")
                            {
                                lbl.Text = val;
                            }
                            else
                            {
                                lbl.Text = "——";
                            }

                        }
                    }
                }));
            }
            catch { }
        }

        #endregion

        #region 事件-按钮控件

        /// <summary>
        /// 展开文件和视图设置下拉列表
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnList_Click(object sender, EventArgs e)
        {
           
        }

        /// <summary>
        /// 设置文件和视图
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                ToolStripMenuItem tsMenuItem = sender as ToolStripMenuItem;
                switch (tsMenuItem.Text)
                {
                    case "新建项目":
                        CreateProj();
                        InterfaceRefresh();
                        break;
                    case "打开项目":
                        if (mOpenFile.ShowDialog() == DialogResult.OK)
                        {
                            FrmConfigSys.mRini.WriteValue("Config", "mLoadProjPath", mOpenFile.FileName);
                            OpenProj("");
                        }
                        InterfaceRefresh();
                        break;
                    case "保存项目":
                        mSaveFile.FileName = Sol.mSol.Name + ".RV";
                        if (mSaveFile.ShowDialog() == DialogResult.OK)
                        {
                            Sol.SaveData(mSaveFile.FileName, Sol.mSol);
                            Sol.mSaveProjPath = mSaveFile.FileName;
                        }
                        break;
                    case "项目另存":
                        if (Sol.mSol != null)
                        {
                            mSaveFile.FileName = Sol.mSol.Name + ".RV";
                            if (mSaveFile.ShowDialog() == DialogResult.OK)
                            {
                                Sol.mSaveProjPath = mSaveFile.FileName;
                                Sol.SaveData(mSaveFile.FileName, Sol.mSol);
                            }
                        }
                        break;
                    case "保存布局":
                        mMainShow.ShowUI(tsMenuItem.Text);
                        break;
                    case "工具显示":
                        mMainShow.ShowUI(tsMenuItem.Text);
                        break;
                    case "流程显示":
                        mMainShow.ShowUI(tsMenuItem.Text);
                        break;
                    case "图像显示":
                        mMainShow.ShowUI(tsMenuItem.Text);
                        break;
                    case "通讯显示":
                        mMainShow.ShowUI(tsMenuItem.Text);
                        break;
                    case "数据显示":
                        mMainShow.ShowUI(tsMenuItem.Text);
                        break;
                    case "日志显示":
                        mMainShow.ShowUI(tsMenuItem.Text);
                        break;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "提示");
            }
        }

        /// <summary>
        /// 窗口最小化
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnMin_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        /// <summary>
        /// 窗口最大化
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnMax_Click(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Normal)
            {
                this.MaximizedBounds = Screen.PrimaryScreen.Bounds;
                btnMax.Image = Resources.min;
                this.WindowState = FormWindowState.Maximized;
            }
            else if (this.WindowState == FormWindowState.Maximized)
            {
                btnMax.Image = Resources.max;
                this.WindowState = FormWindowState.Normal;
            }
        }

        /// <summary>
        /// 关闭软件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnClose_Click(object sender, EventArgs e)
        {
            //子窗体关闭
            frmConfigComm.frmServerMenu.Close();
            frmConfigComm.frmClientMenu.Close();
            frmConfigComm.frmSerialPortMenu.Close();

            //主窗体关闭
            Close();
        }

        /// <summary>
        /// 主界面按钮Click事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ToolStripButton_Click(object sender, EventArgs e)
        {
            HideChlidForm();
            ToolStripButton tsbt = sender as ToolStripButton;
            if (Sol.mSol == null)
            {
                bool IsNewOpen = tsbt.Text.Contains("新建项目") || tsbt.Text.Contains("打开项目");
                if (!IsNewOpen)
                {
                    MessageBox.Show($"项目为空!", "提示", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                    return;
                }
            }
            switch (tsbt.Text)
            {
                case "新建项目":
                    CreateProj();
                    InterfaceRefresh();
                    break;
                case "打开项目":
                    if (mOpenFile.ShowDialog() == DialogResult.OK)
                    {
                        FrmConfigSys.mRini.WriteValue("Config", "mLoadProjPath", mOpenFile.FileName);
                        OpenProj("");
                    }
                    InterfaceRefresh();
                    break;
                case "保存项目":
                    mSaveFile.FileName = Sol.mSol.Name + ".RV";
                    if (mSaveFile.ShowDialog() == DialogResult.OK)
                    {
                        Sol.SaveData(mSaveFile.FileName, Sol.mSol);
                        Sol.mSaveProjPath = mSaveFile.FileName;
                    }
                    break;

                case "主界面":
                  
                    FrmRTools.ShowFrm(pnlFrm, frmHome);
                    break;
             
                case "配置":
                
                    FrmRTools.ShowFrm(pnlFrm, frmConfigSys);
                    break;
                case "全局变量":
                  
                    FrmRTools.ShowFrm(pnlFrm, frmVar);
                    break;
                case "相机设置":

                    FrmRTools.ShowFrm(pnlFrm, frmConfigCam);
                    break;
                case "通讯设置":

                    FrmRTools.ShowFrm(pnlFrm, frmConfigComm);
                    break;
                case "用户登录":
                    //isMaiFrmClose = 2;
                    //this.Close();
                    break;
                case "帮助":
                    break;
                case "单次运行":
                    Sol.OnceRun();
                    break;
                case "循环运行":
                    Sol.StartRun();
                    break;
                case "停止运行":
                    Sol.StopRun();
                    break;
            }
        }

        /// <summary>
        /// 按钮获取焦点
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tsbtButton_MouseEnter(object sender, EventArgs e)
        {
            Focus();
        }

        #endregion

        #region 事件-窗体控件

        /// <summary>
        /// 主窗体加载
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FormMain_Load(object sender, EventArgs e)
        {
            //获取系统信息
            startTime = DateTime.Now;
            thGetSystemInfo = new Thread(DispSystemInfo);
            thGetSystemInfo.Start();
         

            //注册日志系统
         
            Log.RegisterLog();
           

            //加载插件
          
            PluginCamService.InitPlugin();
            PluginToolService.InitPlugin();
            frmConfigSys.ReadConfig();
           

            //加载窗体
          
            //FrmRTools.ShowFrm(pnlFrmCate, frmHomeCate);
            FrmRTools.ShowFrm(pnlFrm, frmHome);
            ShowUIForm();

            //打开项目
           
            OpenProj("");
            DynDrawCtrls();
            mMainShow.CanvasSet(FrmConfigSys.NewQty);
            ShowMsg.ShowRImageEvent += ShowImgae;
            ShowMsg.ClearWindowEvent += ClearWindow;
            ShowMsg.ShowCrtlInfoEvent += ShowCtrlInfo;

            ////控件信息显示
            ts_ProjPath.Text = "    " + Sol.mSol.Name + "     ";

           
        }

        /// <summary>
        /// 窗体关闭-ING
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FormMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (Sol.mSol != null)
            {
                if (!Sol.mProjSave)
                {
                    if (MessageBox.Show("当前项目未保存,是否关闭?", "消息", MessageBoxButtons.OKCancel) == DialogResult.OK)
                    {
                        Sol.mSol.CloseProj();
                    }
                    else
                    {
                        e.Cancel = true;
                    }
                }
            }

            thGetSystemInfo.Abort();
            frmProj.Dispose();
            Dispose();
            Environment.Exit(0);
        }

        /// <summary>
        /// 获取鼠标按下时坐标
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FormMain_MouseDown(object sender, MouseEventArgs e)
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
        private void FormMain_MouseMove(object sender, MouseEventArgs e)
        {
            if (leftFlag)
            {
                Point mouseSet = Control.MousePosition;//获得移动后鼠标的坐标
                mouseSet.Offset(-mouseOff.X, -mouseOff.Y);//设置移动后的位置
                Location = mouseSet;
                this.WindowState = FormWindowState.Normal;
                btnMax.Image = Resources.max;

            }
        }

        /// <summary>
        /// 鼠标抬起将标志位置为false
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FormMain_MouseUp(object sender, MouseEventArgs e)
        {
            if (leftFlag)
            {
                leftFlag = false;
            }
        }

        /// <summary>
        /// 最大化
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void pnlHeadline_DoubleClick(object sender, EventArgs e)
        {
            btnMax.PerformClick();
        }


        #endregion

        #region 工具栏
        private void button1_Click(object sender, EventArgs e)
        {
            Point point = new Point(0, button1.Height);
            Files.Show(button1, point);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Point point = new Point(0, button2.Height);
            View.Show(button2, point);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Point point = new Point(0, button3.Height);
            Set.Show(button3, point);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Point point = new Point(0, button4.Height);
            Help.Show(button4, point);
        }
        #endregion
        private void pnlFrm_Paint(object sender, PaintEventArgs e)
        {

        }

     

        private void toolStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void pnlHeadline_Paint(object sender, PaintEventArgs e)
        {
           
        }
    }
}
