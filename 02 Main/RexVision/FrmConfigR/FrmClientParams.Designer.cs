
namespace TSIVision.FrmConfigR
{
    partial class FrmClientParams
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmClientParams));
            this.pnl1 = new System.Windows.Forms.Panel();
            this.uiGroupBox1 = new Rex.UI.UIGroupBox();
            this.cbxEndData = new Rex.UI.MyComboBox();
            this.cbxReceiveMode = new Rex.UI.MyComboBox();
            this.cbxSendMode = new Rex.UI.MyComboBox();
            this.uiLabel7 = new Rex.UI.UILabel();
            this.uiLabel5 = new Rex.UI.UILabel();
            this.uiLabel4 = new Rex.UI.UILabel();
            this.btnNo = new Rex.UI.UIRadioButton();
            this.btnYes = new Rex.UI.UIRadioButton();
            this.lblMsg = new Rex.UI.UISymbolLabel();
            this.lbConnState = new Rex.UI.UILedBulb();
            this.swOpen = new Rex.UI.UISwitch();
            this.uiGroupBox3 = new Rex.UI.UIGroupBox();
            this.tbxAimPort = new Rex.UI.UITextBox();
            this.uiLabel3 = new Rex.UI.UILabel();
            this.tbxAimIP = new Rex.UI.UITextBox();
            this.uiLabel2 = new Rex.UI.UILabel();
            this.tbxName = new Rex.UI.UITextBox();
            this.uiLabel1 = new Rex.UI.UILabel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.pbxJudge6 = new System.Windows.Forms.PictureBox();
            this.pbxJudge5 = new System.Windows.Forms.PictureBox();
            this.pbxJudge4 = new System.Windows.Forms.PictureBox();
            this.pbxJudge3 = new System.Windows.Forms.PictureBox();
            this.pbxJudge2 = new System.Windows.Forms.PictureBox();
            this.pbxJudge1 = new System.Windows.Forms.PictureBox();
            this.btnPageChange = new Rex.UI.UIButton();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.pnl1.SuspendLayout();
            this.uiGroupBox1.SuspendLayout();
            this.uiGroupBox3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbxJudge6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxJudge5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxJudge4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxJudge3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxJudge2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxJudge1)).BeginInit();
            this.SuspendLayout();
            // 
            // pnl1
            // 
            this.pnl1.BackColor = System.Drawing.Color.LavenderBlush;
            this.pnl1.Controls.Add(this.uiGroupBox1);
            this.pnl1.Controls.Add(this.btnNo);
            this.pnl1.Controls.Add(this.btnYes);
            this.pnl1.Controls.Add(this.lblMsg);
            this.pnl1.Controls.Add(this.lbConnState);
            this.pnl1.Controls.Add(this.swOpen);
            this.pnl1.Controls.Add(this.uiGroupBox3);
            this.pnl1.Controls.Add(this.btnPageChange);
            this.pnl1.Controls.Add(this.panel2);
            this.pnl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnl1.Location = new System.Drawing.Point(0, 0);
            this.pnl1.Name = "pnl1";
            this.pnl1.Size = new System.Drawing.Size(479, 522);
            this.pnl1.TabIndex = 1;
            // 
            // uiGroupBox1
            // 
            this.uiGroupBox1.Controls.Add(this.pbxJudge6);
            this.uiGroupBox1.Controls.Add(this.pbxJudge5);
            this.uiGroupBox1.Controls.Add(this.pbxJudge4);
            this.uiGroupBox1.Controls.Add(this.cbxEndData);
            this.uiGroupBox1.Controls.Add(this.cbxReceiveMode);
            this.uiGroupBox1.Controls.Add(this.cbxSendMode);
            this.uiGroupBox1.Controls.Add(this.uiLabel7);
            this.uiGroupBox1.Controls.Add(this.uiLabel5);
            this.uiGroupBox1.Controls.Add(this.uiLabel4);
            this.uiGroupBox1.FillColor = System.Drawing.Color.LavenderBlush;
            this.uiGroupBox1.Font = new System.Drawing.Font("华文新魏", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uiGroupBox1.Location = new System.Drawing.Point(96, 278);
            this.uiGroupBox1.Margin = new System.Windows.Forms.Padding(0);
            this.uiGroupBox1.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiGroupBox1.Name = "uiGroupBox1";
            this.uiGroupBox1.Padding = new System.Windows.Forms.Padding(0, 32, 0, 0);
            this.uiGroupBox1.Radius = 15;
            this.uiGroupBox1.RectColor = System.Drawing.Color.LightSteelBlue;
            this.uiGroupBox1.Size = new System.Drawing.Size(297, 170);
            this.uiGroupBox1.Style = Rex.UI.UIStyle.Custom;
            this.uiGroupBox1.TabIndex = 276;
            this.uiGroupBox1.Text = "数据设置";
            // 
            // cbxEndData
            // 
            this.cbxEndData.BackColor = System.Drawing.Color.LavenderBlush;
            this.cbxEndData.DropDownStyle = Rex.UI.UIDropDownStyle.DropDownList;
            this.cbxEndData.FillColor = System.Drawing.Color.AliceBlue;
            this.cbxEndData.Font = new System.Drawing.Font("华文新魏", 11.5F);
            this.cbxEndData.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(49)))), ((int)(((byte)(49)))));
            this.cbxEndData.ForeDisableColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.cbxEndData.Items.AddRange(new object[] {
            "\\r",
            "\\n",
            "\\r\\n"});
            this.cbxEndData.Location = new System.Drawing.Point(112, 42);
            this.cbxEndData.Margin = new System.Windows.Forms.Padding(0);
            this.cbxEndData.MinimumSize = new System.Drawing.Size(63, 0);
            this.cbxEndData.Name = "cbxEndData";
            this.cbxEndData.Padding = new System.Windows.Forms.Padding(0, 0, 30, 0);
            this.cbxEndData.Radius = 10;
            this.cbxEndData.RectColor = System.Drawing.Color.CornflowerBlue;
            this.cbxEndData.RectDisableColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.cbxEndData.RectSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.None;
            this.cbxEndData.Size = new System.Drawing.Size(154, 23);
            this.cbxEndData.Style = Rex.UI.UIStyle.Custom;
            this.cbxEndData.StyleCustomMode = true;
            this.cbxEndData.SymbolDropDown = 61656;
            this.cbxEndData.SymbolNormal = 61655;
            this.cbxEndData.TabIndex = 281;
            this.cbxEndData.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
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
            this.cbxReceiveMode.Location = new System.Drawing.Point(112, 123);
            this.cbxReceiveMode.Margin = new System.Windows.Forms.Padding(0);
            this.cbxReceiveMode.MinimumSize = new System.Drawing.Size(63, 0);
            this.cbxReceiveMode.Name = "cbxReceiveMode";
            this.cbxReceiveMode.Padding = new System.Windows.Forms.Padding(0, 0, 30, 0);
            this.cbxReceiveMode.Radius = 10;
            this.cbxReceiveMode.RectColor = System.Drawing.Color.CornflowerBlue;
            this.cbxReceiveMode.RectDisableColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.cbxReceiveMode.RectSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.None;
            this.cbxReceiveMode.Size = new System.Drawing.Size(154, 23);
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
            this.cbxSendMode.Location = new System.Drawing.Point(112, 82);
            this.cbxSendMode.Margin = new System.Windows.Forms.Padding(0);
            this.cbxSendMode.MinimumSize = new System.Drawing.Size(63, 0);
            this.cbxSendMode.Name = "cbxSendMode";
            this.cbxSendMode.Padding = new System.Windows.Forms.Padding(0, 0, 30, 0);
            this.cbxSendMode.Radius = 10;
            this.cbxSendMode.RectColor = System.Drawing.Color.CornflowerBlue;
            this.cbxSendMode.RectDisableColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.cbxSendMode.RectSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.None;
            this.cbxSendMode.Size = new System.Drawing.Size(154, 23);
            this.cbxSendMode.Style = Rex.UI.UIStyle.Custom;
            this.cbxSendMode.StyleCustomMode = true;
            this.cbxSendMode.SymbolDropDown = 61656;
            this.cbxSendMode.SymbolNormal = 61655;
            this.cbxSendMode.TabIndex = 280;
            this.cbxSendMode.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // uiLabel7
            // 
            this.uiLabel7.Font = new System.Drawing.Font("华文新魏", 12F);
            this.uiLabel7.Location = new System.Drawing.Point(14, 40);
            this.uiLabel7.Name = "uiLabel7";
            this.uiLabel7.Size = new System.Drawing.Size(101, 27);
            this.uiLabel7.Style = Rex.UI.UIStyle.Custom;
            this.uiLabel7.TabIndex = 276;
            this.uiLabel7.Text = "结束字符:";
            this.uiLabel7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // uiLabel5
            // 
            this.uiLabel5.Font = new System.Drawing.Font("华文新魏", 12F);
            this.uiLabel5.Location = new System.Drawing.Point(14, 122);
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
            this.uiLabel4.Location = new System.Drawing.Point(14, 84);
            this.uiLabel4.Name = "uiLabel4";
            this.uiLabel4.Size = new System.Drawing.Size(101, 21);
            this.uiLabel4.Style = Rex.UI.UIStyle.Custom;
            this.uiLabel4.TabIndex = 277;
            this.uiLabel4.Text = "发送方式:";
            this.uiLabel4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
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
            this.btnNo.TabIndex = 45;
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
            this.btnYes.TabIndex = 44;
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
            this.lblMsg.TabIndex = 43;
            this.lblMsg.Text = "未初始化";
            this.lblMsg.Visible = false;
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
            this.swOpen.TabIndex = 38;
            this.swOpen.Text = "uiSwitch1";
            this.swOpen.ValueChanged += new Rex.UI.UISwitch.OnValueChanged(this.swConnect_ValueChanged);
            this.swOpen.Click += new System.EventHandler(this.swOpen_Click);
            // 
            // uiGroupBox3
            // 
            this.uiGroupBox3.Controls.Add(this.pbxJudge3);
            this.uiGroupBox3.Controls.Add(this.pbxJudge2);
            this.uiGroupBox3.Controls.Add(this.pbxJudge1);
            this.uiGroupBox3.Controls.Add(this.tbxAimPort);
            this.uiGroupBox3.Controls.Add(this.uiLabel3);
            this.uiGroupBox3.Controls.Add(this.tbxAimIP);
            this.uiGroupBox3.Controls.Add(this.uiLabel2);
            this.uiGroupBox3.Controls.Add(this.tbxName);
            this.uiGroupBox3.Controls.Add(this.uiLabel1);
            this.uiGroupBox3.FillColor = System.Drawing.Color.LavenderBlush;
            this.uiGroupBox3.Font = new System.Drawing.Font("华文新魏", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uiGroupBox3.Location = new System.Drawing.Point(96, 84);
            this.uiGroupBox3.Margin = new System.Windows.Forms.Padding(0);
            this.uiGroupBox3.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiGroupBox3.Name = "uiGroupBox3";
            this.uiGroupBox3.Padding = new System.Windows.Forms.Padding(0, 32, 0, 0);
            this.uiGroupBox3.Radius = 15;
            this.uiGroupBox3.RectColor = System.Drawing.Color.LightSteelBlue;
            this.uiGroupBox3.Size = new System.Drawing.Size(297, 175);
            this.uiGroupBox3.Style = Rex.UI.UIStyle.Custom;
            this.uiGroupBox3.TabIndex = 31;
            this.uiGroupBox3.Text = "连接设置";
            // 
            // tbxAimPort
            // 
            this.tbxAimPort.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbxAimPort.Font = new System.Drawing.Font("华文新魏", 11.5F);
            this.tbxAimPort.Location = new System.Drawing.Point(112, 128);
            this.tbxAimPort.Margin = new System.Windows.Forms.Padding(0);
            this.tbxAimPort.Maximum = 2147483647D;
            this.tbxAimPort.Minimum = -2147483648D;
            this.tbxAimPort.MinimumSize = new System.Drawing.Size(1, 1);
            this.tbxAimPort.Name = "tbxAimPort";
            this.tbxAimPort.Radius = 10;
            this.tbxAimPort.Size = new System.Drawing.Size(154, 23);
            this.tbxAimPort.Style = Rex.UI.UIStyle.Custom;
            this.tbxAimPort.TabIndex = 30;
            this.tbxAimPort.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbxInputNum_KeyPress);
            // 
            // uiLabel3
            // 
            this.uiLabel3.Font = new System.Drawing.Font("华文新魏", 12F);
            this.uiLabel3.Location = new System.Drawing.Point(14, 127);
            this.uiLabel3.Name = "uiLabel3";
            this.uiLabel3.Size = new System.Drawing.Size(100, 22);
            this.uiLabel3.Style = Rex.UI.UIStyle.Custom;
            this.uiLabel3.TabIndex = 29;
            this.uiLabel3.Text = "目标端口号:";
            this.uiLabel3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // tbxAimIP
            // 
            this.tbxAimIP.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbxAimIP.Font = new System.Drawing.Font("华文新魏", 11.5F);
            this.tbxAimIP.Location = new System.Drawing.Point(112, 87);
            this.tbxAimIP.Margin = new System.Windows.Forms.Padding(0);
            this.tbxAimIP.Maximum = 2147483647D;
            this.tbxAimIP.Minimum = -2147483648D;
            this.tbxAimIP.MinimumSize = new System.Drawing.Size(1, 1);
            this.tbxAimIP.Name = "tbxAimIP";
            this.tbxAimIP.Radius = 10;
            this.tbxAimIP.Size = new System.Drawing.Size(154, 23);
            this.tbxAimIP.Style = Rex.UI.UIStyle.Custom;
            this.tbxAimIP.TabIndex = 28;
            this.tbxAimIP.Click += new System.EventHandler(this.tbxAimIP_Click);
            this.tbxAimIP.KeyUp += new System.Windows.Forms.KeyEventHandler(this.tbxAimIP_KeyUp);
            this.tbxAimIP.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbxInputNumAndDot_KeyPress);
            // 
            // uiLabel2
            // 
            this.uiLabel2.Font = new System.Drawing.Font("华文新魏", 12F);
            this.uiLabel2.Location = new System.Drawing.Point(14, 88);
            this.uiLabel2.Name = "uiLabel2";
            this.uiLabel2.Size = new System.Drawing.Size(91, 22);
            this.uiLabel2.Style = Rex.UI.UIStyle.Custom;
            this.uiLabel2.TabIndex = 27;
            this.uiLabel2.Text = "目标IP地址:";
            this.uiLabel2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // tbxName
            // 
            this.tbxName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbxName.Font = new System.Drawing.Font("华文新魏", 11.5F);
            this.tbxName.Location = new System.Drawing.Point(112, 46);
            this.tbxName.Margin = new System.Windows.Forms.Padding(0);
            this.tbxName.Maximum = 2147483647D;
            this.tbxName.Minimum = -2147483648D;
            this.tbxName.MinimumSize = new System.Drawing.Size(1, 1);
            this.tbxName.Name = "tbxName";
            this.tbxName.Radius = 10;
            this.tbxName.Size = new System.Drawing.Size(154, 23);
            this.tbxName.Style = Rex.UI.UIStyle.Custom;
            this.tbxName.TabIndex = 26;
            // 
            // uiLabel1
            // 
            this.uiLabel1.Font = new System.Drawing.Font("华文新魏", 12F);
            this.uiLabel1.Location = new System.Drawing.Point(14, 44);
            this.uiLabel1.Name = "uiLabel1";
            this.uiLabel1.Size = new System.Drawing.Size(100, 27);
            this.uiLabel1.Style = Rex.UI.UIStyle.Custom;
            this.uiLabel1.TabIndex = 25;
            this.uiLabel1.Text = "设备名称:";
            this.uiLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
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
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 5;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // pbxJudge6
            // 
            this.pbxJudge6.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pbxJudge6.Location = new System.Drawing.Point(269, 125);
            this.pbxJudge6.Name = "pbxJudge6";
            this.pbxJudge6.Size = new System.Drawing.Size(20, 20);
            this.pbxJudge6.TabIndex = 284;
            this.pbxJudge6.TabStop = false;
            // 
            // pbxJudge5
            // 
            this.pbxJudge5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pbxJudge5.Location = new System.Drawing.Point(269, 83);
            this.pbxJudge5.Name = "pbxJudge5";
            this.pbxJudge5.Size = new System.Drawing.Size(20, 20);
            this.pbxJudge5.TabIndex = 283;
            this.pbxJudge5.TabStop = false;
            // 
            // pbxJudge4
            // 
            this.pbxJudge4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pbxJudge4.Location = new System.Drawing.Point(269, 44);
            this.pbxJudge4.Name = "pbxJudge4";
            this.pbxJudge4.Size = new System.Drawing.Size(20, 20);
            this.pbxJudge4.TabIndex = 282;
            this.pbxJudge4.TabStop = false;
            // 
            // pbxJudge3
            // 
            this.pbxJudge3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pbxJudge3.Location = new System.Drawing.Point(269, 130);
            this.pbxJudge3.Name = "pbxJudge3";
            this.pbxJudge3.Size = new System.Drawing.Size(20, 20);
            this.pbxJudge3.TabIndex = 36;
            this.pbxJudge3.TabStop = false;
            // 
            // pbxJudge2
            // 
            this.pbxJudge2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pbxJudge2.Location = new System.Drawing.Point(269, 89);
            this.pbxJudge2.Name = "pbxJudge2";
            this.pbxJudge2.Size = new System.Drawing.Size(20, 20);
            this.pbxJudge2.TabIndex = 35;
            this.pbxJudge2.TabStop = false;
            // 
            // pbxJudge1
            // 
            this.pbxJudge1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pbxJudge1.Location = new System.Drawing.Point(269, 47);
            this.pbxJudge1.Name = "pbxJudge1";
            this.pbxJudge1.Size = new System.Drawing.Size(20, 20);
            this.pbxJudge1.TabIndex = 34;
            this.pbxJudge1.TabStop = false;
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
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.LavenderBlush;
            this.btnClose.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnClose.FlatAppearance.BorderColor = System.Drawing.Color.LavenderBlush;
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LavenderBlush;
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
            this.btnSave.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LavenderBlush;
            this.btnSave.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LavenderBlush;
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.Image = ((System.Drawing.Image)(resources.GetObject("btnSave.Image")));
            this.btnSave.Location = new System.Drawing.Point(426, 1);
            this.btnSave.Margin = new System.Windows.Forms.Padding(4, 1, 3, 1);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(19, 24);
            this.btnSave.TabIndex = 2;
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnToolBar_Click);
            this.btnSave.MouseLeave += new System.EventHandler(this.btnSave_MouseLeave);
            // 
            // FrmClientParams
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(479, 522);
            this.Controls.Add(this.pnl1);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmClientParams";
            this.Text = "FrmClientParams";
            this.LocationChanged += new System.EventHandler(this.FrmClientParams_LocationChanged);
            this.pnl1.ResumeLayout(false);
            this.uiGroupBox1.ResumeLayout(false);
            this.uiGroupBox3.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbxJudge6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxJudge5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxJudge4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxJudge3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxJudge2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxJudge1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnl1;
        private Rex.UI.UIGroupBox uiGroupBox3;
        private Rex.UI.UITextBox tbxAimPort;
        private Rex.UI.UILabel uiLabel3;
        private Rex.UI.UITextBox tbxAimIP;
        private Rex.UI.UILabel uiLabel2;
        private Rex.UI.UITextBox tbxName;
        private Rex.UI.UILabel uiLabel1;
        private Rex.UI.UIButton btnPageChange;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.PictureBox pbxJudge3;
        private System.Windows.Forms.PictureBox pbxJudge2;
        private System.Windows.Forms.PictureBox pbxJudge1;
        private Rex.UI.UISwitch swOpen;
        private Rex.UI.UILedBulb lbConnState;
        private System.Windows.Forms.Timer timer1;
        private Rex.UI.UISymbolLabel lblMsg;
        private Rex.UI.UIRadioButton btnYes;
        private Rex.UI.UIRadioButton btnNo;
        private Rex.UI.UIGroupBox uiGroupBox1;
        private Rex.UI.MyComboBox cbxEndData;
        private Rex.UI.MyComboBox cbxReceiveMode;
        private Rex.UI.MyComboBox cbxSendMode;
        private Rex.UI.UILabel uiLabel7;
        private Rex.UI.UILabel uiLabel5;
        private Rex.UI.UILabel uiLabel4;
        private System.Windows.Forms.PictureBox pbxJudge6;
        private System.Windows.Forms.PictureBox pbxJudge5;
        private System.Windows.Forms.PictureBox pbxJudge4;
    }
}