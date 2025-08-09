
namespace TSIVision.FrmConfigR
{
    partial class FrmSerialPortParams
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmSerialPortParams));
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnNo = new Rex.UI.UIRadioButton();
            this.btnYes = new Rex.UI.UIRadioButton();
            this.lblMsg = new Rex.UI.UISymbolLabel();
            this.uiGroupBox1 = new Rex.UI.UIGroupBox();
            this.pbxJudge5 = new System.Windows.Forms.PictureBox();
            this.pbxJudge4 = new System.Windows.Forms.PictureBox();
            this.cbxReceiveMode = new Rex.UI.MyComboBox();
            this.cbxSendMode = new Rex.UI.MyComboBox();
            this.uiLabel5 = new Rex.UI.UILabel();
            this.uiLabel4 = new Rex.UI.UILabel();
            this.lbConnState = new Rex.UI.UILedBulb();
            this.swOpen = new Rex.UI.UISwitch();
            this.page2 = new System.Windows.Forms.Button();
            this.uiGroupBox3 = new Rex.UI.UIGroupBox();
            this.pnlParams = new System.Windows.Forms.Panel();
            this.btnPageChange = new Rex.UI.UIButton();
            this.page1 = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.panel1.SuspendLayout();
            this.uiGroupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbxJudge5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxJudge4)).BeginInit();
            this.uiGroupBox3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.LavenderBlush;
            this.panel1.Controls.Add(this.btnNo);
            this.panel1.Controls.Add(this.btnYes);
            this.panel1.Controls.Add(this.lblMsg);
            this.panel1.Controls.Add(this.uiGroupBox1);
            this.panel1.Controls.Add(this.lbConnState);
            this.panel1.Controls.Add(this.swOpen);
            this.panel1.Controls.Add(this.page2);
            this.panel1.Controls.Add(this.uiGroupBox3);
            this.panel1.Controls.Add(this.btnPageChange);
            this.panel1.Controls.Add(this.page1);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(479, 522);
            this.panel1.TabIndex = 1;
            // 
            // btnNo
            // 
            this.btnNo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnNo.Font = new System.Drawing.Font("华文新魏", 11F);
            this.btnNo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.btnNo.ImageSize = 13;
            this.btnNo.Location = new System.Drawing.Point(376, 60);
            this.btnNo.MinimumSize = new System.Drawing.Size(1, 1);
            this.btnNo.Name = "btnNo";
            this.btnNo.Padding = new System.Windows.Forms.Padding(19, 0, 0, 0);
            this.btnNo.Size = new System.Drawing.Size(69, 19);
            this.btnNo.Style = Rex.UI.UIStyle.Custom;
            this.btnNo.TabIndex = 281;
            this.btnNo.Text = "取消";
            this.btnNo.Visible = false;
            this.btnNo.Click += new System.EventHandler(this.btnNo_Click);
            // 
            // btnYes
            // 
            this.btnYes.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnYes.Font = new System.Drawing.Font("华文新魏", 11F);
            this.btnYes.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.btnYes.ImageSize = 13;
            this.btnYes.Location = new System.Drawing.Point(376, 38);
            this.btnYes.MinimumSize = new System.Drawing.Size(1, 1);
            this.btnYes.Name = "btnYes";
            this.btnYes.Padding = new System.Windows.Forms.Padding(19, 0, 0, 0);
            this.btnYes.Size = new System.Drawing.Size(69, 21);
            this.btnYes.Style = Rex.UI.UIStyle.Custom;
            this.btnYes.TabIndex = 280;
            this.btnYes.Text = "替换";
            this.btnYes.Visible = false;
            this.btnYes.Click += new System.EventHandler(this.btnYes_Click);
            // 
            // lblMsg
            // 
            this.lblMsg.Font = new System.Drawing.Font("华文新魏", 14F);
            this.lblMsg.ForeColor = System.Drawing.Color.LightSalmon;
            this.lblMsg.Location = new System.Drawing.Point(240, 40);
            this.lblMsg.MinimumSize = new System.Drawing.Size(1, 1);
            this.lblMsg.Name = "lblMsg";
            this.lblMsg.Padding = new System.Windows.Forms.Padding(32, 0, 0, 0);
            this.lblMsg.Size = new System.Drawing.Size(130, 41);
            this.lblMsg.Style = Rex.UI.UIStyle.Custom;
            this.lblMsg.SymbolColor = System.Drawing.Color.LightSalmon;
            this.lblMsg.SymbolSize = 28;
            this.lblMsg.TabIndex = 279;
            this.lblMsg.Text = "未初始化";
            this.lblMsg.Visible = false;
            // 
            // uiGroupBox1
            // 
            this.uiGroupBox1.Controls.Add(this.pbxJudge5);
            this.uiGroupBox1.Controls.Add(this.pbxJudge4);
            this.uiGroupBox1.Controls.Add(this.cbxReceiveMode);
            this.uiGroupBox1.Controls.Add(this.cbxSendMode);
            this.uiGroupBox1.Controls.Add(this.uiLabel5);
            this.uiGroupBox1.Controls.Add(this.uiLabel4);
            this.uiGroupBox1.FillColor = System.Drawing.Color.LavenderBlush;
            this.uiGroupBox1.Font = new System.Drawing.Font("华文新魏", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uiGroupBox1.Location = new System.Drawing.Point(96, 303);
            this.uiGroupBox1.Margin = new System.Windows.Forms.Padding(0);
            this.uiGroupBox1.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiGroupBox1.Name = "uiGroupBox1";
            this.uiGroupBox1.Padding = new System.Windows.Forms.Padding(0, 32, 0, 0);
            this.uiGroupBox1.Radius = 15;
            this.uiGroupBox1.RectColor = System.Drawing.Color.LightSteelBlue;
            this.uiGroupBox1.Size = new System.Drawing.Size(297, 138);
            this.uiGroupBox1.Style = Rex.UI.UIStyle.Custom;
            this.uiGroupBox1.TabIndex = 278;
            this.uiGroupBox1.Text = "数据设置";
            // 
            // pbxJudge5
            // 
            this.pbxJudge5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pbxJudge5.Location = new System.Drawing.Point(269, 89);
            this.pbxJudge5.Name = "pbxJudge5";
            this.pbxJudge5.Size = new System.Drawing.Size(20, 20);
            this.pbxJudge5.TabIndex = 284;
            this.pbxJudge5.TabStop = false;
            // 
            // pbxJudge4
            // 
            this.pbxJudge4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pbxJudge4.Location = new System.Drawing.Point(269, 47);
            this.pbxJudge4.Name = "pbxJudge4";
            this.pbxJudge4.Size = new System.Drawing.Size(20, 20);
            this.pbxJudge4.TabIndex = 283;
            this.pbxJudge4.TabStop = false;
            // 
            // cbxReceiveMode
            // 
            this.cbxReceiveMode.BackColor = System.Drawing.Color.LavenderBlush;
            this.cbxReceiveMode.DropDownStyle = Rex.UI.UIDropDownStyle.DropDownList;
            this.cbxReceiveMode.FillColor = System.Drawing.Color.AliceBlue;
            this.cbxReceiveMode.Font = new System.Drawing.Font("华文新魏", 11.5F);
            this.cbxReceiveMode.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(49)))), ((int)(((byte)(49)))));
            this.cbxReceiveMode.ForeDisableColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.cbxReceiveMode.Items.AddRange(new object[] {
            "字符",
            "十六进制"});
            this.cbxReceiveMode.Location = new System.Drawing.Point(104, 87);
            this.cbxReceiveMode.Margin = new System.Windows.Forms.Padding(0);
            this.cbxReceiveMode.MinimumSize = new System.Drawing.Size(63, 0);
            this.cbxReceiveMode.Name = "cbxReceiveMode";
            this.cbxReceiveMode.Padding = new System.Windows.Forms.Padding(0, 0, 30, 0);
            this.cbxReceiveMode.Radius = 2;
            this.cbxReceiveMode.RectColor = System.Drawing.Color.CornflowerBlue;
            this.cbxReceiveMode.RectDisableColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.cbxReceiveMode.RectSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.None;
            this.cbxReceiveMode.Size = new System.Drawing.Size(162, 23);
            this.cbxReceiveMode.Style = Rex.UI.UIStyle.Custom;
            this.cbxReceiveMode.StyleCustomMode = true;
            this.cbxReceiveMode.SymbolDropDown = 61656;
            this.cbxReceiveMode.SymbolNormal = 61655;
            this.cbxReceiveMode.TabIndex = 279;
            this.cbxReceiveMode.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // cbxSendMode
            // 
            this.cbxSendMode.BackColor = System.Drawing.Color.LavenderBlush;
            this.cbxSendMode.DropDownStyle = Rex.UI.UIDropDownStyle.DropDownList;
            this.cbxSendMode.FillColor = System.Drawing.Color.AliceBlue;
            this.cbxSendMode.Font = new System.Drawing.Font("华文新魏", 11.5F);
            this.cbxSendMode.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(49)))), ((int)(((byte)(49)))));
            this.cbxSendMode.ForeDisableColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.cbxSendMode.Items.AddRange(new object[] {
            "字符",
            "十六进制"});
            this.cbxSendMode.Location = new System.Drawing.Point(104, 46);
            this.cbxSendMode.Margin = new System.Windows.Forms.Padding(0);
            this.cbxSendMode.MinimumSize = new System.Drawing.Size(63, 0);
            this.cbxSendMode.Name = "cbxSendMode";
            this.cbxSendMode.Padding = new System.Windows.Forms.Padding(0, 0, 30, 0);
            this.cbxSendMode.Radius = 10;
            this.cbxSendMode.RectColor = System.Drawing.Color.CornflowerBlue;
            this.cbxSendMode.RectDisableColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.cbxSendMode.RectSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.None;
            this.cbxSendMode.Size = new System.Drawing.Size(162, 23);
            this.cbxSendMode.Style = Rex.UI.UIStyle.Custom;
            this.cbxSendMode.StyleCustomMode = true;
            this.cbxSendMode.SymbolDropDown = 61656;
            this.cbxSendMode.SymbolNormal = 61655;
            this.cbxSendMode.TabIndex = 280;
            this.cbxSendMode.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // uiLabel5
            // 
            this.uiLabel5.Font = new System.Drawing.Font("华文新魏", 12F);
            this.uiLabel5.Location = new System.Drawing.Point(14, 86);
            this.uiLabel5.Name = "uiLabel5";
            this.uiLabel5.Size = new System.Drawing.Size(101, 27);
            this.uiLabel5.Style = Rex.UI.UIStyle.Custom;
            this.uiLabel5.TabIndex = 278;
            this.uiLabel5.Text = "接收方式:";
            this.uiLabel5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // uiLabel4
            // 
            this.uiLabel4.Font = new System.Drawing.Font("华文新魏", 12F);
            this.uiLabel4.Location = new System.Drawing.Point(14, 48);
            this.uiLabel4.Name = "uiLabel4";
            this.uiLabel4.Size = new System.Drawing.Size(101, 21);
            this.uiLabel4.Style = Rex.UI.UIStyle.Custom;
            this.uiLabel4.TabIndex = 277;
            this.uiLabel4.Text = "发送方式:";
            this.uiLabel4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbConnState
            // 
            this.lbConnState.Color = System.Drawing.Color.Crimson;
            this.lbConnState.Location = new System.Drawing.Point(181, 47);
            this.lbConnState.Name = "lbConnState";
            this.lbConnState.Size = new System.Drawing.Size(29, 25);
            this.lbConnState.TabIndex = 42;
            this.lbConnState.Text = "uiLedBulb1";
            // 
            // swOpen
            // 
            this.swOpen.ActiveColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(131)))), ((int)(((byte)(229)))));
            this.swOpen.ButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            this.swOpen.Font = new System.Drawing.Font("华文新魏", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.swOpen.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            this.swOpen.Location = new System.Drawing.Point(96, 47);
            this.swOpen.MinimumSize = new System.Drawing.Size(1, 1);
            this.swOpen.Name = "swOpen";
            this.swOpen.Size = new System.Drawing.Size(66, 25);
            this.swOpen.Style = Rex.UI.UIStyle.Custom;
            this.swOpen.TabIndex = 40;
            this.swOpen.Text = "uiSwitch1";
            this.swOpen.ValueChanged += new Rex.UI.UISwitch.OnValueChanged(this.swConnect_ValueChanged);
            this.swOpen.Click += new System.EventHandler(this.swOpen_Click);
            // 
            // page2
            // 
            this.page2.FlatAppearance.BorderColor = System.Drawing.Color.LavenderBlush;
            this.page2.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LavenderBlush;
            this.page2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LavenderBlush;
            this.page2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.page2.Image = ((System.Drawing.Image)(resources.GetObject("page2.Image")));
            this.page2.Location = new System.Drawing.Point(253, 258);
            this.page2.Name = "page2";
            this.page2.Size = new System.Drawing.Size(19, 28);
            this.page2.TabIndex = 39;
            this.page2.UseVisualStyleBackColor = true;
            this.page2.Click += new System.EventHandler(this.btnParamsPage_Click);
            // 
            // uiGroupBox3
            // 
            this.uiGroupBox3.Controls.Add(this.pnlParams);
            this.uiGroupBox3.FillColor = System.Drawing.Color.LavenderBlush;
            this.uiGroupBox3.Font = new System.Drawing.Font("华文新魏", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uiGroupBox3.Location = new System.Drawing.Point(96, 78);
            this.uiGroupBox3.Margin = new System.Windows.Forms.Padding(0);
            this.uiGroupBox3.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiGroupBox3.Name = "uiGroupBox3";
            this.uiGroupBox3.Padding = new System.Windows.Forms.Padding(3, 28, 3, 3);
            this.uiGroupBox3.Radius = 15;
            this.uiGroupBox3.RectColor = System.Drawing.Color.LightSteelBlue;
            this.uiGroupBox3.Size = new System.Drawing.Size(297, 175);
            this.uiGroupBox3.Style = Rex.UI.UIStyle.Custom;
            this.uiGroupBox3.TabIndex = 31;
            this.uiGroupBox3.Text = "连接设置";
            // 
            // pnlParams
            // 
            this.pnlParams.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlParams.Location = new System.Drawing.Point(3, 28);
            this.pnlParams.Name = "pnlParams";
            this.pnlParams.Size = new System.Drawing.Size(291, 144);
            this.pnlParams.TabIndex = 0;
            // 
            // btnPageChange
            // 
            this.btnPageChange.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnPageChange.BackgroundImage")));
            this.btnPageChange.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnPageChange.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPageChange.FillColor = System.Drawing.Color.Transparent;
            this.btnPageChange.FillHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(55)))), ((int)(((byte)(130)))));
            this.btnPageChange.FillPressColor = System.Drawing.Color.CadetBlue;
            this.btnPageChange.Font = new System.Drawing.Font("华文新魏", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnPageChange.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            this.btnPageChange.ForeHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            this.btnPageChange.ForePressColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            this.btnPageChange.ForeSelectedColor = System.Drawing.Color.Black;
            this.btnPageChange.Location = new System.Drawing.Point(230, 458);
            this.btnPageChange.MinimumSize = new System.Drawing.Size(1, 1);
            this.btnPageChange.Name = "btnPageChange";
            this.btnPageChange.Radius = 15;
            this.btnPageChange.RectColor = System.Drawing.Color.Transparent;
            this.btnPageChange.RectHoverColor = System.Drawing.Color.Lavender;
            this.btnPageChange.RectPressColor = System.Drawing.Color.Honeydew;
            this.btnPageChange.RectSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.None;
            this.btnPageChange.Size = new System.Drawing.Size(28, 34);
            this.btnPageChange.Style = Rex.UI.UIStyle.Custom;
            this.btnPageChange.TabIndex = 30;
            this.btnPageChange.Click += new System.EventHandler(this.btnPageChange_Click);
            // 
            // page1
            // 
            this.page1.FlatAppearance.BorderColor = System.Drawing.Color.LavenderBlush;
            this.page1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LavenderBlush;
            this.page1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LavenderBlush;
            this.page1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.page1.Image = ((System.Drawing.Image)(resources.GetObject("page1.Image")));
            this.page1.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.page1.Location = new System.Drawing.Point(227, 258);
            this.page1.Name = "page1";
            this.page1.Size = new System.Drawing.Size(20, 28);
            this.page1.TabIndex = 38;
            this.page1.UseVisualStyleBackColor = true;
            this.page1.Click += new System.EventHandler(this.btnParamsPage_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.tableLayoutPanel1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Padding = new System.Windows.Forms.Padding(0, 0, 2, 0);
            this.panel2.Size = new System.Drawing.Size(479, 26);
            this.panel2.TabIndex = 25;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 88.4696F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 5.450734F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 5.870021F));
            this.tableLayoutPanel1.Controls.Add(this.btnClose, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.btnSave, 1, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(477, 26);
            this.tableLayoutPanel1.TabIndex = 0;
            this.tableLayoutPanel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.FrmCCamDebug_MouseDown);
            this.tableLayoutPanel1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.FrmCCamDebug_MouseMove);
            this.tableLayoutPanel1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.FrmCCamDebug_MouseUp);
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.LavenderBlush;
            this.btnClose.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnClose.FlatAppearance.BorderColor = System.Drawing.Color.LavenderBlush;
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.FlatAppearance.MouseDownBackColor = System.Drawing.Color.WhiteSmoke;
            this.btnClose.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LavenderBlush;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Image = ((System.Drawing.Image)(resources.GetObject("btnClose.Image")));
            this.btnClose.Location = new System.Drawing.Point(455, 6);
            this.btnClose.Margin = new System.Windows.Forms.Padding(7, 6, 5, 5);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(17, 15);
            this.btnClose.TabIndex = 1;
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnToolBar_Click);
            // 
            // btnSave
            // 
            this.btnSave.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnSave.FlatAppearance.BorderColor = System.Drawing.Color.LavenderBlush;
            this.btnSave.FlatAppearance.BorderSize = 0;
            this.btnSave.FlatAppearance.MouseDownBackColor = System.Drawing.Color.GhostWhite;
            this.btnSave.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LavenderBlush;
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.Image = ((System.Drawing.Image)(resources.GetObject("btnSave.Image")));
            this.btnSave.Location = new System.Drawing.Point(426, 4);
            this.btnSave.Margin = new System.Windows.Forms.Padding(4, 4, 3, 4);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(19, 18);
            this.btnSave.TabIndex = 2;
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnToolBar_Click);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 50;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // FrmSerialPortParams
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(479, 522);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmSerialPortParams";
            this.Text = "FrmSerialPortParams";
            this.LocationChanged += new System.EventHandler(this.FrmSerialPortParams_LocationChanged);
            this.panel1.ResumeLayout(false);
            this.uiGroupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbxJudge5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxJudge4)).EndInit();
            this.uiGroupBox3.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private Rex.UI.UIGroupBox uiGroupBox3;
        private Rex.UI.UIButton btnPageChange;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button page1;
        private System.Windows.Forms.Button page2;
        private System.Windows.Forms.Panel pnlParams;
        private Rex.UI.UISwitch swOpen;
        private Rex.UI.UILedBulb lbConnState;
        private System.Windows.Forms.Timer timer1;
        private Rex.UI.UIGroupBox uiGroupBox1;
        private System.Windows.Forms.PictureBox pbxJudge5;
        private System.Windows.Forms.PictureBox pbxJudge4;
        private Rex.UI.MyComboBox cbxReceiveMode;
        private Rex.UI.MyComboBox cbxSendMode;
        private Rex.UI.UILabel uiLabel5;
        private Rex.UI.UILabel uiLabel4;
        private Rex.UI.UISymbolLabel lblMsg;
        private Rex.UI.UIRadioButton btnYes;
        private Rex.UI.UIRadioButton btnNo;
    }
}