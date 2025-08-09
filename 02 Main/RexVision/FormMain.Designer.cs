using WeifenLuo.WinFormsUI.Docking;

namespace TSIVision
{
    partial class FormMain
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            this.mOpenFile = new System.Windows.Forms.OpenFileDialog();
            this.mSaveFile = new System.Windows.Forms.SaveFileDialog();
            this.tbPanel5 = new System.Windows.Forms.TableLayoutPanel();
            this.panel9 = new System.Windows.Forms.Panel();
            this.panel10 = new System.Windows.Forms.Panel();
            this.tbPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tb_ShowLog = new System.Windows.Forms.TextBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.panel2 = new System.Windows.Forms.Panel();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.tbPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.panel7 = new System.Windows.Forms.Panel();
            this.toolStrip2 = new System.Windows.Forms.ToolStrip();
            this.toolStripButton10 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton11 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton12 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton13 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton14 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton15 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton16 = new System.Windows.Forms.ToolStripComboBox();
            this.panel5 = new System.Windows.Forms.Panel();
            this.tbPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.MainSS = new System.Windows.Forms.StatusStrip();
            this.tsUserType = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel2 = new System.Windows.Forms.ToolStripStatusLabel();
            this.tsCPUUR = new System.Windows.Forms.ToolStripStatusLabel();
            this.tsRAMUR = new System.Windows.Forms.ToolStripStatusLabel();
            this.tsDiskUR = new System.Windows.Forms.ToolStripStatusLabel();
            this.tsRunTime = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.ts_ProjPath = new System.Windows.Forms.ToolStripStatusLabel();
            this.tsSystemTime = new System.Windows.Forms.ToolStripStatusLabel();
            this.panel8 = new System.Windows.Forms.Panel();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripLabel6 = new System.Windows.Forms.ToolStripLabel();
            this.tsbtHome = new System.Windows.Forms.ToolStripButton();
            this.tsbtConfig = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton2 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton3 = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButton4 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton5 = new System.Windows.Forms.ToolStripButton();
            this.tsbtVarSet = new System.Windows.Forms.ToolStripButton();
            this.tsbtLogin = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.tsbtOnceRun = new System.Windows.Forms.ToolStripButton();
            this.tsbtCycle = new System.Windows.Forms.ToolStripButton();
            this.tsbtStop = new System.Windows.Forms.ToolStripButton();
            this.toolStripLabel2 = new System.Windows.Forms.ToolStripLabel();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.pnlFrm = new System.Windows.Forms.Panel();
            this.pnlHeadline = new System.Windows.Forms.Panel();
            this.panel17 = new System.Windows.Forms.Panel();
            this.btnMin = new System.Windows.Forms.Button();
            this.panel13 = new System.Windows.Forms.Panel();
            this.btnMax = new System.Windows.Forms.Button();
            this.panel16 = new System.Windows.Forms.Panel();
            this.button4 = new System.Windows.Forms.Button();
            this.panel15 = new System.Windows.Forms.Panel();
            this.button3 = new System.Windows.Forms.Button();
            this.panel11 = new System.Windows.Forms.Panel();
            this.button2 = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.panel14 = new System.Windows.Forms.Panel();
            this.btnClose = new System.Windows.Forms.Button();
            this.panel12 = new System.Windows.Forms.Panel();
            this.btnList = new System.Windows.Forms.Button();
            this.Files = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.打开项目ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.保存项目ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.项目另存ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.退出程序ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.View = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem4 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem5 = new System.Windows.Forms.ToolStripMenuItem();
            this.通讯显示ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.数据显示ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.日志显示ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Set = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.系统设置ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.画布设置ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.参数设置ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.导入ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.导出ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Help = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.屏幕键盘ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.关于软件ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.帮助与反馈ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.调试助手ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel5.SuspendLayout();
            this.tbPanel4.SuspendLayout();
            this.MainSS.SuspendLayout();
            this.panel8.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.pnlHeadline.SuspendLayout();
            this.panel17.SuspendLayout();
            this.panel13.SuspendLayout();
            this.panel16.SuspendLayout();
            this.panel15.SuspendLayout();
            this.panel11.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel14.SuspendLayout();
            this.panel12.SuspendLayout();
            this.Files.SuspendLayout();
            this.View.SuspendLayout();
            this.Set.SuspendLayout();
            this.Help.SuspendLayout();
            this.SuspendLayout();
            // 
            // mOpenFile
            // 
            this.mOpenFile.Filter = "工程文件|*.RV";
            // 
            // mSaveFile
            // 
            this.mSaveFile.Filter = "工程文件|*.RV";
            // 
            // tbPanel5
            // 
            this.tbPanel5.Location = new System.Drawing.Point(0, 0);
            this.tbPanel5.Name = "tbPanel5";
            this.tbPanel5.Size = new System.Drawing.Size(200, 100);
            this.tbPanel5.TabIndex = 0;
            // 
            // panel9
            // 
            this.panel9.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel9.Location = new System.Drawing.Point(3, 3);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(255, 79);
            this.panel9.TabIndex = 0;
            // 
            // panel10
            // 
            this.panel10.Location = new System.Drawing.Point(0, 0);
            this.panel10.Name = "panel10";
            this.panel10.Size = new System.Drawing.Size(200, 100);
            this.panel10.TabIndex = 0;
            // 
            // tbPanel1
            // 
            this.tbPanel1.Location = new System.Drawing.Point(0, 0);
            this.tbPanel1.Name = "tbPanel1";
            this.tbPanel1.Size = new System.Drawing.Size(200, 100);
            this.tbPanel1.TabIndex = 0;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.Size = new System.Drawing.Size(200, 100);
            this.tableLayoutPanel2.TabIndex = 0;
            // 
            // panel3
            // 
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(200, 100);
            this.panel3.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 100);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // panel4
            // 
            this.panel4.Location = new System.Drawing.Point(0, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(200, 100);
            this.panel4.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Location = new System.Drawing.Point(0, 0);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Size = new System.Drawing.Size(200, 100);
            this.tabPage1.TabIndex = 0;
            // 
            // tb_ShowLog
            // 
            this.tb_ShowLog.Location = new System.Drawing.Point(0, 0);
            this.tb_ShowLog.Name = "tb_ShowLog";
            this.tb_ShowLog.Size = new System.Drawing.Size(100, 25);
            this.tb_ShowLog.TabIndex = 0;
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(0, 0);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Size = new System.Drawing.Size(200, 100);
            this.tabPage2.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(200, 100);
            this.panel2.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.Location = new System.Drawing.Point(0, 0);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(200, 100);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            // 
            // tbPanel3
            // 
            this.tbPanel3.Location = new System.Drawing.Point(0, 0);
            this.tbPanel3.Name = "tbPanel3";
            this.tbPanel3.Size = new System.Drawing.Size(200, 100);
            this.tbPanel3.TabIndex = 0;
            // 
            // panel6
            // 
            this.panel6.Location = new System.Drawing.Point(0, 0);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(200, 100);
            this.panel6.TabIndex = 0;
            // 
            // panel7
            // 
            this.panel7.Location = new System.Drawing.Point(0, 0);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(200, 100);
            this.panel7.TabIndex = 0;
            // 
            // toolStrip2
            // 
            this.toolStrip2.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip2.Location = new System.Drawing.Point(0, 0);
            this.toolStrip2.Name = "toolStrip2";
            this.toolStrip2.Size = new System.Drawing.Size(100, 25);
            this.toolStrip2.TabIndex = 0;
            // 
            // toolStripButton10
            // 
            this.toolStripButton10.Name = "toolStripButton10";
            this.toolStripButton10.Size = new System.Drawing.Size(23, 23);
            // 
            // toolStripButton11
            // 
            this.toolStripButton11.Name = "toolStripButton11";
            this.toolStripButton11.Size = new System.Drawing.Size(23, 23);
            // 
            // toolStripButton12
            // 
            this.toolStripButton12.Name = "toolStripButton12";
            this.toolStripButton12.Size = new System.Drawing.Size(23, 23);
            // 
            // toolStripButton13
            // 
            this.toolStripButton13.Name = "toolStripButton13";
            this.toolStripButton13.Size = new System.Drawing.Size(23, 23);
            // 
            // toolStripButton14
            // 
            this.toolStripButton14.Name = "toolStripButton14";
            this.toolStripButton14.Size = new System.Drawing.Size(23, 23);
            // 
            // toolStripButton15
            // 
            this.toolStripButton15.Name = "toolStripButton15";
            this.toolStripButton15.Size = new System.Drawing.Size(23, 23);
            // 
            // toolStripButton16
            // 
            this.toolStripButton16.Name = "toolStripButton16";
            this.toolStripButton16.Size = new System.Drawing.Size(121, 28);
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.tbPanel4);
            this.panel5.Controls.Add(this.pnlHeadline);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel5.Location = new System.Drawing.Point(0, 0);
            this.panel5.Margin = new System.Windows.Forms.Padding(0);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(1459, 809);
            this.panel5.TabIndex = 19;
            // 
            // tbPanel4
            // 
            this.tbPanel4.AutoScroll = true;
            this.tbPanel4.AutoScrollMargin = new System.Drawing.Size(1, 1);
            this.tbPanel4.AutoScrollMinSize = new System.Drawing.Size(1, 1);
            this.tbPanel4.BackColor = System.Drawing.Color.White;
            this.tbPanel4.ColumnCount = 1;
            this.tbPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tbPanel4.Controls.Add(this.MainSS, 0, 2);
            this.tbPanel4.Controls.Add(this.panel8, 0, 0);
            this.tbPanel4.Controls.Add(this.tableLayoutPanel1, 0, 1);
            this.tbPanel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbPanel4.Location = new System.Drawing.Point(0, 34);
            this.tbPanel4.Margin = new System.Windows.Forms.Padding(0);
            this.tbPanel4.Name = "tbPanel4";
            this.tbPanel4.RowCount = 3;
            this.tbPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 39F));
            this.tbPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tbPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tbPanel4.Size = new System.Drawing.Size(1459, 775);
            this.tbPanel4.TabIndex = 22;
            // 
            // MainSS
            // 
            this.MainSS.BackColor = System.Drawing.Color.White;
            this.MainSS.GripMargin = new System.Windows.Forms.Padding(0);
            this.MainSS.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.MainSS.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsUserType,
            this.toolStripStatusLabel2,
            this.tsCPUUR,
            this.tsRAMUR,
            this.tsDiskUR,
            this.tsRunTime,
            this.toolStripStatusLabel1,
            this.ts_ProjPath,
            this.tsSystemTime});
            this.MainSS.Location = new System.Drawing.Point(0, 750);
            this.MainSS.Name = "MainSS";
            this.MainSS.Padding = new System.Windows.Forms.Padding(1, 0, 19, 0);
            this.MainSS.Size = new System.Drawing.Size(1459, 25);
            this.MainSS.SizingGrip = false;
            this.MainSS.Stretch = false;
            this.MainSS.TabIndex = 21;
            this.MainSS.Text = "statusStrip1";
            // 
            // tsUserType
            // 
            this.tsUserType.Font = new System.Drawing.Font("隶书", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tsUserType.Margin = new System.Windows.Forms.Padding(0, 2, 0, 2);
            this.tsUserType.Name = "tsUserType";
            this.tsUserType.Size = new System.Drawing.Size(89, 21);
            this.tsUserType.Text = "Not LogIn";
            // 
            // toolStripStatusLabel2
            // 
            this.toolStripStatusLabel2.BackColor = System.Drawing.Color.Transparent;
            this.toolStripStatusLabel2.Name = "toolStripStatusLabel2";
            this.toolStripStatusLabel2.Size = new System.Drawing.Size(13, 19);
            this.toolStripStatusLabel2.Text = " ";
            // 
            // tsCPUUR
            // 
            this.tsCPUUR.BackColor = System.Drawing.Color.Transparent;
            this.tsCPUUR.Font = new System.Drawing.Font("隶书", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tsCPUUR.Margin = new System.Windows.Forms.Padding(0, 2, 2, 2);
            this.tsCPUUR.Name = "tsCPUUR";
            this.tsCPUUR.Size = new System.Drawing.Size(71, 21);
            this.tsCPUUR.Text = "CPU：0%";
            this.tsCPUUR.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // tsRAMUR
            // 
            this.tsRAMUR.BackColor = System.Drawing.Color.Transparent;
            this.tsRAMUR.Font = new System.Drawing.Font("隶书", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tsRAMUR.Margin = new System.Windows.Forms.Padding(0, 2, 2, 2);
            this.tsRAMUR.Name = "tsRAMUR";
            this.tsRAMUR.Size = new System.Drawing.Size(80, 21);
            this.tsRAMUR.Text = "内存：0%";
            this.tsRAMUR.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // tsDiskUR
            // 
            this.tsDiskUR.BackColor = System.Drawing.Color.Transparent;
            this.tsDiskUR.Font = new System.Drawing.Font("隶书", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tsDiskUR.Margin = new System.Windows.Forms.Padding(0, 2, 2, 2);
            this.tsDiskUR.Name = "tsDiskUR";
            this.tsDiskUR.Size = new System.Drawing.Size(71, 21);
            this.tsDiskUR.Text = "D盘：0%";
            this.tsDiskUR.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // tsRunTime
            // 
            this.tsRunTime.BackColor = System.Drawing.Color.Transparent;
            this.tsRunTime.Font = new System.Drawing.Font("隶书", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tsRunTime.Margin = new System.Windows.Forms.Padding(0, 2, 2, 2);
            this.tsRunTime.Name = "tsRunTime";
            this.tsRunTime.Size = new System.Drawing.Size(107, 21);
            this.tsRunTime.Text = "运行：0.00H";
            this.tsRunTime.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.BackColor = System.Drawing.Color.Transparent;
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(17, 19);
            this.toolStripStatusLabel1.Text = "  ";
            // 
            // ts_ProjPath
            // 
            this.ts_ProjPath.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.ts_ProjPath.Name = "ts_ProjPath";
            this.ts_ProjPath.Size = new System.Drawing.Size(903, 19);
            this.ts_ProjPath.Spring = true;
            // 
            // tsSystemTime
            // 
            this.tsSystemTime.Font = new System.Drawing.Font("隶书", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tsSystemTime.Margin = new System.Windows.Forms.Padding(0, 2, 0, 2);
            this.tsSystemTime.Name = "tsSystemTime";
            this.tsSystemTime.Size = new System.Drawing.Size(80, 21);
            this.tsSystemTime.Text = "NowTimer";
            this.tsSystemTime.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // panel8
            // 
            this.panel8.BackColor = System.Drawing.Color.White;
            this.panel8.Controls.Add(this.toolStrip1);
            this.panel8.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel8.Location = new System.Drawing.Point(0, 0);
            this.panel8.Margin = new System.Windows.Forms.Padding(0);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(1459, 39);
            this.panel8.TabIndex = 19;
            // 
            // toolStrip1
            // 
            this.toolStrip1.BackColor = System.Drawing.Color.White;
            this.toolStrip1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.toolStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip1.ImeMode = System.Windows.Forms.ImeMode.HangulFull;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripLabel6,
            this.tsbtHome,
            this.tsbtConfig,
            this.toolStripSeparator2,
            this.toolStripButton1,
            this.toolStripButton2,
            this.toolStripButton3,
            this.toolStripSeparator3,
            this.toolStripButton4,
            this.toolStripButton5,
            this.tsbtVarSet,
            this.tsbtLogin,
            this.toolStripSeparator4,
            this.tsbtOnceRun,
            this.tsbtCycle,
            this.tsbtStop,
            this.toolStripLabel2,
            this.toolStripLabel1});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Padding = new System.Windows.Forms.Padding(0);
            this.toolStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.toolStrip1.Size = new System.Drawing.Size(1459, 39);
            this.toolStrip1.Stretch = true;
            this.toolStrip1.TabIndex = 10;
            this.toolStrip1.Text = "toolStrip1";
            this.toolStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.toolStrip1_ItemClicked);
            // 
            // toolStripLabel6
            // 
            this.toolStripLabel6.AutoSize = false;
            this.toolStripLabel6.Name = "toolStripLabel6";
            this.toolStripLabel6.Size = new System.Drawing.Size(1, 38);
            // 
            // tsbtHome
            // 
            this.tsbtHome.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.tsbtHome.CheckOnClick = true;
            this.tsbtHome.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbtHome.Image = ((System.Drawing.Image)(resources.GetObject("tsbtHome.Image")));
            this.tsbtHome.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsbtHome.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbtHome.Margin = new System.Windows.Forms.Padding(1);
            this.tsbtHome.Name = "tsbtHome";
            this.tsbtHome.Size = new System.Drawing.Size(36, 37);
            this.tsbtHome.Text = "主界面";
            this.tsbtHome.Click += new System.EventHandler(this.ToolStripButton_Click);
            this.tsbtHome.MouseEnter += new System.EventHandler(this.tsbtButton_MouseEnter);
            // 
            // tsbtConfig
            // 
            this.tsbtConfig.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.tsbtConfig.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbtConfig.Image = ((System.Drawing.Image)(resources.GetObject("tsbtConfig.Image")));
            this.tsbtConfig.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsbtConfig.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbtConfig.Margin = new System.Windows.Forms.Padding(1);
            this.tsbtConfig.Name = "tsbtConfig";
            this.tsbtConfig.Size = new System.Drawing.Size(36, 37);
            this.tsbtConfig.Text = "配置";
            this.tsbtConfig.Click += new System.EventHandler(this.ToolStripButton_Click);
            this.tsbtConfig.MouseEnter += new System.EventHandler(this.tsbtButton_MouseEnter);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 39);
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton1.Image")));
            this.toolStripButton1.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Margin = new System.Windows.Forms.Padding(0, 1, 0, 1);
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(36, 37);
            this.toolStripButton1.Text = "新建项目";
            this.toolStripButton1.Click += new System.EventHandler(this.ToolStripButton_Click);
            this.toolStripButton1.MouseEnter += new System.EventHandler(this.tsbtButton_MouseEnter);
            // 
            // toolStripButton2
            // 
            this.toolStripButton2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton2.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton2.Image")));
            this.toolStripButton2.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.toolStripButton2.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton2.Margin = new System.Windows.Forms.Padding(0, 1, 0, 1);
            this.toolStripButton2.Name = "toolStripButton2";
            this.toolStripButton2.Size = new System.Drawing.Size(36, 37);
            this.toolStripButton2.Text = "打开项目";
            this.toolStripButton2.Click += new System.EventHandler(this.ToolStripButton_Click);
            this.toolStripButton2.MouseEnter += new System.EventHandler(this.tsbtButton_MouseEnter);
            // 
            // toolStripButton3
            // 
            this.toolStripButton3.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton3.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton3.Image")));
            this.toolStripButton3.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.toolStripButton3.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton3.Name = "toolStripButton3";
            this.toolStripButton3.Size = new System.Drawing.Size(36, 36);
            this.toolStripButton3.Text = "保存项目";
            this.toolStripButton3.Click += new System.EventHandler(this.ToolStripButton_Click);
            this.toolStripButton3.MouseEnter += new System.EventHandler(this.tsbtButton_MouseEnter);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 39);
            // 
            // toolStripButton4
            // 
            this.toolStripButton4.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton4.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton4.Image")));
            this.toolStripButton4.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.toolStripButton4.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton4.Name = "toolStripButton4";
            this.toolStripButton4.Size = new System.Drawing.Size(36, 36);
            this.toolStripButton4.Text = "相机设置";
            this.toolStripButton4.Click += new System.EventHandler(this.ToolStripButton_Click);
            this.toolStripButton4.MouseEnter += new System.EventHandler(this.tsbtButton_MouseEnter);
            // 
            // toolStripButton5
            // 
            this.toolStripButton5.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton5.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton5.Image")));
            this.toolStripButton5.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.toolStripButton5.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton5.Name = "toolStripButton5";
            this.toolStripButton5.Size = new System.Drawing.Size(36, 36);
            this.toolStripButton5.Text = "通讯设置";
            this.toolStripButton5.Click += new System.EventHandler(this.ToolStripButton_Click);
            this.toolStripButton5.MouseEnter += new System.EventHandler(this.tsbtButton_MouseEnter);
            // 
            // tsbtVarSet
            // 
            this.tsbtVarSet.BackColor = System.Drawing.Color.Transparent;
            this.tsbtVarSet.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.tsbtVarSet.CheckOnClick = true;
            this.tsbtVarSet.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbtVarSet.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.tsbtVarSet.Image = ((System.Drawing.Image)(resources.GetObject("tsbtVarSet.Image")));
            this.tsbtVarSet.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsbtVarSet.ImageTransparentColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            this.tsbtVarSet.Margin = new System.Windows.Forms.Padding(1);
            this.tsbtVarSet.Name = "tsbtVarSet";
            this.tsbtVarSet.Size = new System.Drawing.Size(32, 37);
            this.tsbtVarSet.Text = "全局变量";
            this.tsbtVarSet.Click += new System.EventHandler(this.ToolStripButton_Click);
            this.tsbtVarSet.MouseEnter += new System.EventHandler(this.tsbtButton_MouseEnter);
            // 
            // tsbtLogin
            // 
            this.tsbtLogin.BackColor = System.Drawing.Color.Transparent;
            this.tsbtLogin.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.tsbtLogin.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbtLogin.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.tsbtLogin.Image = ((System.Drawing.Image)(resources.GetObject("tsbtLogin.Image")));
            this.tsbtLogin.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsbtLogin.ImageTransparentColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            this.tsbtLogin.Margin = new System.Windows.Forms.Padding(1);
            this.tsbtLogin.Name = "tsbtLogin";
            this.tsbtLogin.Size = new System.Drawing.Size(32, 37);
            this.tsbtLogin.Text = "用户登录";
            this.tsbtLogin.Click += new System.EventHandler(this.ToolStripButton_Click);
            this.tsbtLogin.MouseEnter += new System.EventHandler(this.tsbtButton_MouseEnter);
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(6, 39);
            // 
            // tsbtOnceRun
            // 
            this.tsbtOnceRun.BackColor = System.Drawing.Color.Transparent;
            this.tsbtOnceRun.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.tsbtOnceRun.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbtOnceRun.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.tsbtOnceRun.Image = ((System.Drawing.Image)(resources.GetObject("tsbtOnceRun.Image")));
            this.tsbtOnceRun.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsbtOnceRun.ImageTransparentColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            this.tsbtOnceRun.Margin = new System.Windows.Forms.Padding(1);
            this.tsbtOnceRun.Name = "tsbtOnceRun";
            this.tsbtOnceRun.Size = new System.Drawing.Size(36, 37);
            this.tsbtOnceRun.Text = "单次运行";
            this.tsbtOnceRun.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.tsbtOnceRun.ToolTipText = "单次运行";
            this.tsbtOnceRun.Click += new System.EventHandler(this.ToolStripButton_Click);
            this.tsbtOnceRun.MouseEnter += new System.EventHandler(this.tsbtButton_MouseEnter);
            // 
            // tsbtCycle
            // 
            this.tsbtCycle.BackColor = System.Drawing.Color.Transparent;
            this.tsbtCycle.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.tsbtCycle.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbtCycle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.tsbtCycle.Image = ((System.Drawing.Image)(resources.GetObject("tsbtCycle.Image")));
            this.tsbtCycle.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsbtCycle.ImageTransparentColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            this.tsbtCycle.Margin = new System.Windows.Forms.Padding(1);
            this.tsbtCycle.Name = "tsbtCycle";
            this.tsbtCycle.Size = new System.Drawing.Size(36, 37);
            this.tsbtCycle.Text = "循环运行";
            this.tsbtCycle.ToolTipText = "循环运行";
            this.tsbtCycle.Click += new System.EventHandler(this.ToolStripButton_Click);
            this.tsbtCycle.MouseEnter += new System.EventHandler(this.tsbtButton_MouseEnter);
            // 
            // tsbtStop
            // 
            this.tsbtStop.BackColor = System.Drawing.Color.Transparent;
            this.tsbtStop.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.tsbtStop.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbtStop.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.tsbtStop.Image = ((System.Drawing.Image)(resources.GetObject("tsbtStop.Image")));
            this.tsbtStop.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsbtStop.ImageTransparentColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            this.tsbtStop.Margin = new System.Windows.Forms.Padding(1);
            this.tsbtStop.Name = "tsbtStop";
            this.tsbtStop.Size = new System.Drawing.Size(36, 37);
            this.tsbtStop.Text = "停止运行";
            this.tsbtStop.Click += new System.EventHandler(this.ToolStripButton_Click);
            this.tsbtStop.MouseEnter += new System.EventHandler(this.tsbtButton_MouseEnter);
            // 
            // toolStripLabel2
            // 
            this.toolStripLabel2.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolStripLabel2.Font = new System.Drawing.Font("宋体", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.toolStripLabel2.Name = "toolStripLabel2";
            this.toolStripLabel2.Size = new System.Drawing.Size(179, 36);
            this.toolStripLabel2.Text = "                             ";
            this.toolStripLabel2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.toolStripLabel2.ToolTipText = " ";
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolStripLabel1.Font = new System.Drawing.Font("微软雅黑", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(0, 36);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 6.427376F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 27F));
            this.tableLayoutPanel1.Controls.Add(this.pnlFrm, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 39);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1459, 711);
            this.tableLayoutPanel1.TabIndex = 22;
            // 
            // pnlFrm
            // 
            this.pnlFrm.BackColor = System.Drawing.Color.White;
            this.pnlFrm.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlFrm.Location = new System.Drawing.Point(0, 0);
            this.pnlFrm.Margin = new System.Windows.Forms.Padding(0);
            this.pnlFrm.Name = "pnlFrm";
            this.pnlFrm.Size = new System.Drawing.Size(1459, 711);
            this.pnlFrm.TabIndex = 25;
            this.pnlFrm.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlFrm_Paint);
            // 
            // pnlHeadline
            // 
            this.pnlHeadline.BackColor = System.Drawing.Color.Navy;
            this.pnlHeadline.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlHeadline.Controls.Add(this.panel17);
            this.pnlHeadline.Controls.Add(this.panel13);
            this.pnlHeadline.Controls.Add(this.panel16);
            this.pnlHeadline.Controls.Add(this.panel15);
            this.pnlHeadline.Controls.Add(this.panel11);
            this.pnlHeadline.Controls.Add(this.panel1);
            this.pnlHeadline.Controls.Add(this.panel14);
            this.pnlHeadline.Controls.Add(this.panel12);
            this.pnlHeadline.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlHeadline.Location = new System.Drawing.Point(0, 0);
            this.pnlHeadline.Margin = new System.Windows.Forms.Padding(0);
            this.pnlHeadline.Name = "pnlHeadline";
            this.pnlHeadline.Size = new System.Drawing.Size(1459, 34);
            this.pnlHeadline.TabIndex = 21;
            this.pnlHeadline.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlHeadline_Paint);
            this.pnlHeadline.DoubleClick += new System.EventHandler(this.pnlHeadline_DoubleClick);
            this.pnlHeadline.MouseDown += new System.Windows.Forms.MouseEventHandler(this.FormMain_MouseDown);
            this.pnlHeadline.MouseMove += new System.Windows.Forms.MouseEventHandler(this.FormMain_MouseMove);
            this.pnlHeadline.MouseUp += new System.Windows.Forms.MouseEventHandler(this.FormMain_MouseUp);
            // 
            // panel17
            // 
            this.panel17.Controls.Add(this.btnMin);
            this.panel17.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel17.Location = new System.Drawing.Point(1355, 0);
            this.panel17.Margin = new System.Windows.Forms.Padding(4);
            this.panel17.Name = "panel17";
            this.panel17.Size = new System.Drawing.Size(34, 32);
            this.panel17.TabIndex = 4;
            // 
            // btnMin
            // 
            this.btnMin.BackColor = System.Drawing.Color.Navy;
            this.btnMin.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnMin.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnMin.FlatAppearance.BorderColor = System.Drawing.Color.RoyalBlue;
            this.btnMin.FlatAppearance.BorderSize = 0;
            this.btnMin.FlatAppearance.CheckedBackColor = System.Drawing.Color.RoyalBlue;
            this.btnMin.FlatAppearance.MouseDownBackColor = System.Drawing.Color.RoyalBlue;
            this.btnMin.FlatAppearance.MouseOverBackColor = System.Drawing.Color.RoyalBlue;
            this.btnMin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMin.Image = ((System.Drawing.Image)(resources.GetObject("btnMin.Image")));
            this.btnMin.Location = new System.Drawing.Point(0, 0);
            this.btnMin.Margin = new System.Windows.Forms.Padding(4);
            this.btnMin.Name = "btnMin";
            this.btnMin.Size = new System.Drawing.Size(34, 32);
            this.btnMin.TabIndex = 1;
            this.btnMin.UseVisualStyleBackColor = false;
            this.btnMin.Click += new System.EventHandler(this.btnMin_Click);
            // 
            // panel13
            // 
            this.panel13.Controls.Add(this.btnMax);
            this.panel13.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel13.Location = new System.Drawing.Point(1389, 0);
            this.panel13.Margin = new System.Windows.Forms.Padding(4);
            this.panel13.Name = "panel13";
            this.panel13.Size = new System.Drawing.Size(34, 32);
            this.panel13.TabIndex = 3;
            // 
            // btnMax
            // 
            this.btnMax.BackColor = System.Drawing.Color.Navy;
            this.btnMax.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnMax.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnMax.FlatAppearance.BorderColor = System.Drawing.Color.RoyalBlue;
            this.btnMax.FlatAppearance.BorderSize = 0;
            this.btnMax.FlatAppearance.CheckedBackColor = System.Drawing.Color.RoyalBlue;
            this.btnMax.FlatAppearance.MouseDownBackColor = System.Drawing.Color.RoyalBlue;
            this.btnMax.FlatAppearance.MouseOverBackColor = System.Drawing.Color.RoyalBlue;
            this.btnMax.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMax.Image = ((System.Drawing.Image)(resources.GetObject("btnMax.Image")));
            this.btnMax.Location = new System.Drawing.Point(0, 0);
            this.btnMax.Margin = new System.Windows.Forms.Padding(4);
            this.btnMax.Name = "btnMax";
            this.btnMax.Size = new System.Drawing.Size(34, 32);
            this.btnMax.TabIndex = 2;
            this.btnMax.UseVisualStyleBackColor = false;
            this.btnMax.Click += new System.EventHandler(this.btnMax_Click);
            // 
            // panel16
            // 
            this.panel16.Controls.Add(this.button4);
            this.panel16.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel16.Location = new System.Drawing.Point(277, 0);
            this.panel16.Margin = new System.Windows.Forms.Padding(4);
            this.panel16.Name = "panel16";
            this.panel16.Size = new System.Drawing.Size(79, 32);
            this.panel16.TabIndex = 5;
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.Transparent;
            this.button4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button4.FlatAppearance.BorderColor = System.Drawing.Color.RoyalBlue;
            this.button4.FlatAppearance.BorderSize = 0;
            this.button4.FlatAppearance.CheckedBackColor = System.Drawing.Color.RoyalBlue;
            this.button4.FlatAppearance.MouseDownBackColor = System.Drawing.Color.RoyalBlue;
            this.button4.FlatAppearance.MouseOverBackColor = System.Drawing.Color.RoyalBlue;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Font = new System.Drawing.Font("等线", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button4.ForeColor = System.Drawing.Color.White;
            this.button4.Location = new System.Drawing.Point(0, 0);
            this.button4.Margin = new System.Windows.Forms.Padding(4);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(79, 32);
            this.button4.TabIndex = 4;
            this.button4.Text = "帮助";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // panel15
            // 
            this.panel15.Controls.Add(this.button3);
            this.panel15.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel15.Location = new System.Drawing.Point(198, 0);
            this.panel15.Margin = new System.Windows.Forms.Padding(4);
            this.panel15.Name = "panel15";
            this.panel15.Size = new System.Drawing.Size(79, 32);
            this.panel15.TabIndex = 4;
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.Transparent;
            this.button3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button3.FlatAppearance.BorderColor = System.Drawing.Color.RoyalBlue;
            this.button3.FlatAppearance.BorderSize = 0;
            this.button3.FlatAppearance.CheckedBackColor = System.Drawing.Color.RoyalBlue;
            this.button3.FlatAppearance.MouseDownBackColor = System.Drawing.Color.RoyalBlue;
            this.button3.FlatAppearance.MouseOverBackColor = System.Drawing.Color.RoyalBlue;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("等线", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button3.ForeColor = System.Drawing.Color.White;
            this.button3.Location = new System.Drawing.Point(0, 0);
            this.button3.Margin = new System.Windows.Forms.Padding(4);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(79, 32);
            this.button3.TabIndex = 3;
            this.button3.Text = "设置";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // panel11
            // 
            this.panel11.Controls.Add(this.button2);
            this.panel11.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel11.Location = new System.Drawing.Point(119, 0);
            this.panel11.Margin = new System.Windows.Forms.Padding(4);
            this.panel11.Name = "panel11";
            this.panel11.Size = new System.Drawing.Size(79, 32);
            this.panel11.TabIndex = 3;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Transparent;
            this.button2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button2.FlatAppearance.BorderColor = System.Drawing.Color.RoyalBlue;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatAppearance.CheckedBackColor = System.Drawing.Color.RoyalBlue;
            this.button2.FlatAppearance.MouseDownBackColor = System.Drawing.Color.RoyalBlue;
            this.button2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.RoyalBlue;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("等线", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Location = new System.Drawing.Point(0, 0);
            this.button2.Margin = new System.Windows.Forms.Padding(4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(79, 32);
            this.button2.TabIndex = 2;
            this.button2.Text = "视图";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.button1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(40, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(79, 32);
            this.panel1.TabIndex = 2;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Transparent;
            this.button1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.RoyalBlue;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatAppearance.CheckedBackColor = System.Drawing.Color.RoyalBlue;
            this.button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.RoyalBlue;
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.RoyalBlue;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("等线", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(0, 0);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(79, 32);
            this.button1.TabIndex = 1;
            this.button1.Text = "文件";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // panel14
            // 
            this.panel14.Controls.Add(this.btnClose);
            this.panel14.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel14.Location = new System.Drawing.Point(1423, 0);
            this.panel14.Margin = new System.Windows.Forms.Padding(4);
            this.panel14.Name = "panel14";
            this.panel14.Size = new System.Drawing.Size(34, 32);
            this.panel14.TabIndex = 2;
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.Navy;
            this.btnClose.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnClose.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnClose.FlatAppearance.BorderColor = System.Drawing.Color.Red;
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Red;
            this.btnClose.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Image = ((System.Drawing.Image)(resources.GetObject("btnClose.Image")));
            this.btnClose.Location = new System.Drawing.Point(0, 0);
            this.btnClose.Margin = new System.Windows.Forms.Padding(4);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(34, 32);
            this.btnClose.TabIndex = 3;
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // panel12
            // 
            this.panel12.Controls.Add(this.btnList);
            this.panel12.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel12.Location = new System.Drawing.Point(0, 0);
            this.panel12.Margin = new System.Windows.Forms.Padding(4);
            this.panel12.Name = "panel12";
            this.panel12.Size = new System.Drawing.Size(40, 32);
            this.panel12.TabIndex = 0;
            // 
            // btnList
            // 
            this.btnList.BackColor = System.Drawing.Color.Transparent;
            this.btnList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnList.FlatAppearance.BorderColor = System.Drawing.Color.RoyalBlue;
            this.btnList.FlatAppearance.BorderSize = 0;
            this.btnList.FlatAppearance.CheckedBackColor = System.Drawing.Color.RoyalBlue;
            this.btnList.FlatAppearance.MouseDownBackColor = System.Drawing.Color.RoyalBlue;
            this.btnList.FlatAppearance.MouseOverBackColor = System.Drawing.Color.RoyalBlue;
            this.btnList.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnList.Image = ((System.Drawing.Image)(resources.GetObject("btnList.Image")));
            this.btnList.Location = new System.Drawing.Point(0, 0);
            this.btnList.Margin = new System.Windows.Forms.Padding(4);
            this.btnList.Name = "btnList";
            this.btnList.Size = new System.Drawing.Size(40, 32);
            this.btnList.TabIndex = 0;
            this.btnList.UseVisualStyleBackColor = false;
            // 
            // Files
            // 
            this.Files.BackColor = System.Drawing.Color.White;
            this.Files.Font = new System.Drawing.Font("等线", 9F);
            this.Files.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.Files.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1,
            this.打开项目ToolStripMenuItem,
            this.保存项目ToolStripMenuItem,
            this.项目另存ToolStripMenuItem,
            this.退出程序ToolStripMenuItem});
            this.Files.Name = "contextMenuStrip1";
            this.Files.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.Files.Size = new System.Drawing.Size(135, 114);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.BackColor = System.Drawing.Color.Lavender;
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(134, 22);
            this.toolStripMenuItem1.Text = "新建项目";
            this.toolStripMenuItem1.Click += new System.EventHandler(this.ToolStripMenuItem_Click);
            // 
            // 打开项目ToolStripMenuItem
            // 
            this.打开项目ToolStripMenuItem.Name = "打开项目ToolStripMenuItem";
            this.打开项目ToolStripMenuItem.Size = new System.Drawing.Size(134, 22);
            this.打开项目ToolStripMenuItem.Text = "打开项目";
            this.打开项目ToolStripMenuItem.Click += new System.EventHandler(this.ToolStripMenuItem_Click);
            // 
            // 保存项目ToolStripMenuItem
            // 
            this.保存项目ToolStripMenuItem.Name = "保存项目ToolStripMenuItem";
            this.保存项目ToolStripMenuItem.Size = new System.Drawing.Size(134, 22);
            this.保存项目ToolStripMenuItem.Text = "保存项目";
            this.保存项目ToolStripMenuItem.Click += new System.EventHandler(this.ToolStripMenuItem_Click);
            // 
            // 项目另存ToolStripMenuItem
            // 
            this.项目另存ToolStripMenuItem.Name = "项目另存ToolStripMenuItem";
            this.项目另存ToolStripMenuItem.Size = new System.Drawing.Size(134, 22);
            this.项目另存ToolStripMenuItem.Text = "项目另存";
            this.项目另存ToolStripMenuItem.Click += new System.EventHandler(this.ToolStripMenuItem_Click);
            // 
            // 退出程序ToolStripMenuItem
            // 
            this.退出程序ToolStripMenuItem.Name = "退出程序ToolStripMenuItem";
            this.退出程序ToolStripMenuItem.Size = new System.Drawing.Size(134, 22);
            this.退出程序ToolStripMenuItem.Text = "退出程序";
            // 
            // View
            // 
            this.View.BackColor = System.Drawing.Color.White;
            this.View.Font = new System.Drawing.Font("等线", 9F);
            this.View.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.View.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem2,
            this.toolStripMenuItem3,
            this.toolStripMenuItem4,
            this.toolStripMenuItem5,
            this.通讯显示ToolStripMenuItem,
            this.数据显示ToolStripMenuItem,
            this.日志显示ToolStripMenuItem});
            this.View.Name = "contextMenuStrip1";
            this.View.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.View.Size = new System.Drawing.Size(135, 158);
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.BackColor = System.Drawing.Color.Lavender;
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(134, 22);
            this.toolStripMenuItem2.Tag = "";
            this.toolStripMenuItem2.Text = "保存布局";
            this.toolStripMenuItem2.Click += new System.EventHandler(this.ToolStripMenuItem_Click);
            // 
            // toolStripMenuItem3
            // 
            this.toolStripMenuItem3.Name = "toolStripMenuItem3";
            this.toolStripMenuItem3.Size = new System.Drawing.Size(134, 22);
            this.toolStripMenuItem3.Text = "工具显示";
            this.toolStripMenuItem3.Click += new System.EventHandler(this.ToolStripMenuItem_Click);
            // 
            // toolStripMenuItem4
            // 
            this.toolStripMenuItem4.Name = "toolStripMenuItem4";
            this.toolStripMenuItem4.Size = new System.Drawing.Size(134, 22);
            this.toolStripMenuItem4.Text = "流程显示";
            this.toolStripMenuItem4.Click += new System.EventHandler(this.ToolStripMenuItem_Click);
            // 
            // toolStripMenuItem5
            // 
            this.toolStripMenuItem5.Name = "toolStripMenuItem5";
            this.toolStripMenuItem5.Size = new System.Drawing.Size(134, 22);
            this.toolStripMenuItem5.Text = "图像显示";
            this.toolStripMenuItem5.Click += new System.EventHandler(this.ToolStripMenuItem_Click);
            // 
            // 通讯显示ToolStripMenuItem
            // 
            this.通讯显示ToolStripMenuItem.Name = "通讯显示ToolStripMenuItem";
            this.通讯显示ToolStripMenuItem.Size = new System.Drawing.Size(134, 22);
            this.通讯显示ToolStripMenuItem.Text = "通讯显示";
            this.通讯显示ToolStripMenuItem.Click += new System.EventHandler(this.ToolStripMenuItem_Click);
            // 
            // 数据显示ToolStripMenuItem
            // 
            this.数据显示ToolStripMenuItem.Name = "数据显示ToolStripMenuItem";
            this.数据显示ToolStripMenuItem.Size = new System.Drawing.Size(134, 22);
            this.数据显示ToolStripMenuItem.Text = "数据显示";
            this.数据显示ToolStripMenuItem.Click += new System.EventHandler(this.ToolStripMenuItem_Click);
            // 
            // 日志显示ToolStripMenuItem
            // 
            this.日志显示ToolStripMenuItem.Name = "日志显示ToolStripMenuItem";
            this.日志显示ToolStripMenuItem.Size = new System.Drawing.Size(134, 22);
            this.日志显示ToolStripMenuItem.Text = "日志显示";
            this.日志显示ToolStripMenuItem.Click += new System.EventHandler(this.ToolStripMenuItem_Click);
            // 
            // Set
            // 
            this.Set.BackColor = System.Drawing.Color.White;
            this.Set.Font = new System.Drawing.Font("等线", 9F);
            this.Set.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.Set.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.系统设置ToolStripMenuItem,
            this.画布设置ToolStripMenuItem,
            this.参数设置ToolStripMenuItem});
            this.Set.Name = "contextMenuStrip1";
            this.Set.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.Set.Size = new System.Drawing.Size(135, 70);
            // 
            // 系统设置ToolStripMenuItem
            // 
            this.系统设置ToolStripMenuItem.Name = "系统设置ToolStripMenuItem";
            this.系统设置ToolStripMenuItem.Size = new System.Drawing.Size(134, 22);
            this.系统设置ToolStripMenuItem.Text = "系统设置";
            this.系统设置ToolStripMenuItem.Click += new System.EventHandler(this.ToolStripMenuItem_Click);
            // 
            // 画布设置ToolStripMenuItem
            // 
            this.画布设置ToolStripMenuItem.Name = "画布设置ToolStripMenuItem";
            this.画布设置ToolStripMenuItem.Size = new System.Drawing.Size(134, 22);
            this.画布设置ToolStripMenuItem.Text = "画布设置";
            this.画布设置ToolStripMenuItem.Click += new System.EventHandler(this.ToolStripMenuItem_Click);
            // 
            // 参数设置ToolStripMenuItem
            // 
            this.参数设置ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.导入ToolStripMenuItem,
            this.导出ToolStripMenuItem});
            this.参数设置ToolStripMenuItem.Name = "参数设置ToolStripMenuItem";
            this.参数设置ToolStripMenuItem.Size = new System.Drawing.Size(134, 22);
            this.参数设置ToolStripMenuItem.Text = "参数设置";
            // 
            // 导入ToolStripMenuItem
            // 
            this.导入ToolStripMenuItem.Name = "导入ToolStripMenuItem";
            this.导入ToolStripMenuItem.Size = new System.Drawing.Size(118, 26);
            this.导入ToolStripMenuItem.Text = "导入";
            this.导入ToolStripMenuItem.Click += new System.EventHandler(this.ToolStripMenuItem_Click);
            // 
            // 导出ToolStripMenuItem
            // 
            this.导出ToolStripMenuItem.Name = "导出ToolStripMenuItem";
            this.导出ToolStripMenuItem.Size = new System.Drawing.Size(118, 26);
            this.导出ToolStripMenuItem.Text = "导出";
            this.导出ToolStripMenuItem.Click += new System.EventHandler(this.ToolStripMenuItem_Click);
            // 
            // Help
            // 
            this.Help.BackColor = System.Drawing.Color.White;
            this.Help.Font = new System.Drawing.Font("等线", 9F);
            this.Help.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.Help.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.屏幕键盘ToolStripMenuItem,
            this.调试助手ToolStripMenuItem,
            this.关于软件ToolStripMenuItem,
            this.帮助与反馈ToolStripMenuItem});
            this.Help.Name = "contextMenuStrip1";
            this.Help.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.Help.Size = new System.Drawing.Size(150, 92);
            // 
            // 屏幕键盘ToolStripMenuItem
            // 
            this.屏幕键盘ToolStripMenuItem.Name = "屏幕键盘ToolStripMenuItem";
            this.屏幕键盘ToolStripMenuItem.Size = new System.Drawing.Size(149, 22);
            this.屏幕键盘ToolStripMenuItem.Text = "屏幕键盘";
            // 
            // 关于软件ToolStripMenuItem
            // 
            this.关于软件ToolStripMenuItem.Name = "关于软件ToolStripMenuItem";
            this.关于软件ToolStripMenuItem.Size = new System.Drawing.Size(149, 22);
            this.关于软件ToolStripMenuItem.Text = "关于软件";
            this.关于软件ToolStripMenuItem.Click += new System.EventHandler(this.ToolStripMenuItem_Click);
            // 
            // 帮助与反馈ToolStripMenuItem
            // 
            this.帮助与反馈ToolStripMenuItem.Name = "帮助与反馈ToolStripMenuItem";
            this.帮助与反馈ToolStripMenuItem.Size = new System.Drawing.Size(149, 22);
            this.帮助与反馈ToolStripMenuItem.Text = "帮助与反馈";
            this.帮助与反馈ToolStripMenuItem.Click += new System.EventHandler(this.ToolStripMenuItem_Click);
            // 
            // 调试助手ToolStripMenuItem
            // 
            this.调试助手ToolStripMenuItem.Name = "调试助手ToolStripMenuItem";
            this.调试助手ToolStripMenuItem.Size = new System.Drawing.Size(149, 22);
            this.调试助手ToolStripMenuItem.Text = "调试助手";
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1459, 809);
            this.Controls.Add(this.panel5);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FormMain";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormMain_FormClosing);
            this.Load += new System.EventHandler(this.FormMain_Load);
            this.panel5.ResumeLayout(false);
            this.tbPanel4.ResumeLayout(false);
            this.tbPanel4.PerformLayout();
            this.MainSS.ResumeLayout(false);
            this.MainSS.PerformLayout();
            this.panel8.ResumeLayout(false);
            this.panel8.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.pnlHeadline.ResumeLayout(false);
            this.panel17.ResumeLayout(false);
            this.panel13.ResumeLayout(false);
            this.panel16.ResumeLayout(false);
            this.panel15.ResumeLayout(false);
            this.panel11.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel14.ResumeLayout(false);
            this.panel12.ResumeLayout(false);
            this.Files.ResumeLayout(false);
            this.View.ResumeLayout(false);
            this.Set.ResumeLayout(false);
            this.Help.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.OpenFileDialog mOpenFile;
        private System.Windows.Forms.SaveFileDialog mSaveFile;
        private System.Windows.Forms.TableLayoutPanel tbPanel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TextBox tb_ShowLog;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TableLayoutPanel tbPanel3;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.ToolStrip toolStrip2;
        private System.Windows.Forms.ToolStripButton toolStripButton10;
        private System.Windows.Forms.ToolStripButton toolStripButton11;
        private System.Windows.Forms.ToolStripButton toolStripButton12;
        private System.Windows.Forms.ToolStripButton toolStripButton13;
        private System.Windows.Forms.ToolStripButton toolStripButton14;
        private System.Windows.Forms.ToolStripButton toolStripButton15;
        public System.Windows.Forms.ToolStripComboBox toolStripButton16;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.TableLayoutPanel tbPanel5;
        private System.Windows.Forms.Panel panel9;
        private System.Windows.Forms.Panel panel10;
        private System.Windows.Forms.Panel pnlHeadline;
        private System.Windows.Forms.Panel panel12;
        private System.Windows.Forms.Button btnList;
        private System.Windows.Forms.TableLayoutPanel tbPanel4;
        private System.Windows.Forms.StatusStrip MainSS;
        private System.Windows.Forms.ToolStripStatusLabel tsUserType;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel2;
        private System.Windows.Forms.ToolStripStatusLabel tsDiskUR;
        private System.Windows.Forms.ToolStripStatusLabel tsCPUUR;
        private System.Windows.Forms.ToolStripStatusLabel tsRAMUR;
        private System.Windows.Forms.ToolStripStatusLabel tsRunTime;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStripStatusLabel ts_ProjPath;
        private System.Windows.Forms.ToolStripStatusLabel tsSystemTime;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripLabel toolStripLabel6;
        private System.Windows.Forms.ToolStripButton tsbtHome;
        private System.Windows.Forms.ToolStripButton tsbtConfig;
        private System.Windows.Forms.ToolStripButton tsbtVarSet;
        private System.Windows.Forms.ToolStripButton tsbtLogin;
        private System.Windows.Forms.ToolStripButton tsbtOnceRun;
        private System.Windows.Forms.ToolStripButton tsbtCycle;
        private System.Windows.Forms.ToolStripButton tsbtStop;
        private System.Windows.Forms.ToolStripLabel toolStripLabel2;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.Panel panel14;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnMax;
        private System.Windows.Forms.Button btnMin;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel panel16;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Panel panel15;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Panel panel11;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Panel panel17;
        private System.Windows.Forms.Panel panel13;
        private System.Windows.Forms.ContextMenuStrip Files;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem 打开项目ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 保存项目ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 项目另存ToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip View;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem3;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem4;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem5;
        private System.Windows.Forms.ToolStripMenuItem 通讯显示ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 数据显示ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 日志显示ToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip Set;
        private System.Windows.Forms.ToolStripMenuItem 系统设置ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 画布设置ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 参数设置ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 导入ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 导出ToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip Help;
        private System.Windows.Forms.ToolStripMenuItem 关于软件ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 帮助与反馈ToolStripMenuItem;
        private System.Windows.Forms.Panel pnlFrm;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.ToolStripButton toolStripButton2;
        private System.Windows.Forms.ToolStripButton toolStripButton3;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripButton toolStripButton4;
        private System.Windows.Forms.ToolStripButton toolStripButton5;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripMenuItem 退出程序ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 屏幕键盘ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 调试助手ToolStripMenuItem;
    }
}

