
namespace Plugin.ReadQRCode
{
    partial class ReadQRCodeForm
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
            this.uiTabControl1 = new Rex.UI.UITabControl();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.pnlRect2Params = new Rex.UI.UITitlePanel();
            this.cbxRobustness = new Rex.UI.MyComboBox();
            this.cbxPolarity = new Rex.UI.MyComboBox();
            this.cbxCodeType = new Rex.UI.MyComboBox();
            this.cbxMode = new Rex.UI.MyComboBox();
            this.tbxTimeOut = new Rex.UI.UITextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.uiTitlePanel1 = new Rex.UI.UITitlePanel();
            this.ldImage = new RexControl.MyControls.MyLinkData();
            this.label11 = new System.Windows.Forms.Label();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.uiTitlePanel8 = new Rex.UI.UITitlePanel();
            this.cbxFontStye = new Rex.UI.MyComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.chxShowData = new Rex.UI.UICheckBox();
            this.tbxY = new RexControl.MyControls.MyTextBoxUpDownD();
            this.tbxFontSize = new RexControl.MyControls.MyTextBoxUpDown();
            this.label12 = new System.Windows.Forms.Label();
            this.tbxX = new RexControl.MyControls.MyTextBoxUpDownD();
            this.label8 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.tbxPrefix = new Rex.UI.UITextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.cpColor = new Rex.UI.UIColorPicker();
            this.chxShowReg = new Rex.UI.UICheckBox();
            this.mWindowH = new RexView.HWindow_HE();
            this.panel_bottom.SuspendLayout();
            this.panel_center.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbox_Icon)).BeginInit();
            this.titlepanel.SuspendLayout();
            this.uiTabControl1.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.pnlRect2Params.SuspendLayout();
            this.uiTitlePanel1.SuspendLayout();
            this.tabPage4.SuspendLayout();
            this.uiTitlePanel8.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_Run
            // 
            this.btn_Run.Click += new System.EventHandler(this.btn_Run_Click);
            // 
            // panel_center
            // 
            this.panel_center.Controls.Add(this.mWindowH);
            this.panel_center.Controls.Add(this.uiTabControl1);
            // 
            // uiTabControl1
            // 
            this.uiTabControl1.Controls.Add(this.tabPage3);
            this.uiTabControl1.Controls.Add(this.tabPage4);
            this.uiTabControl1.Dock = System.Windows.Forms.DockStyle.Left;
            this.uiTabControl1.DrawMode = System.Windows.Forms.TabDrawMode.OwnerDrawFixed;
            this.uiTabControl1.Font = new System.Drawing.Font("华文新魏", 12F);
            this.uiTabControl1.ItemSize = new System.Drawing.Size(85, 26);
            this.uiTabControl1.Location = new System.Drawing.Point(1, 1);
            this.uiTabControl1.MenuStyle = Rex.UI.UIMenuStyle.Custom;
            this.uiTabControl1.Name = "uiTabControl1";
            this.uiTabControl1.SelectedIndex = 0;
            this.uiTabControl1.Size = new System.Drawing.Size(303, 485);
            this.uiTabControl1.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.uiTabControl1.Style = Rex.UI.UIStyle.Custom;
            this.uiTabControl1.TabBackColor = System.Drawing.Color.White;
            this.uiTabControl1.TabIndex = 19;
            this.uiTabControl1.TabSelectedColor = System.Drawing.Color.White;
            this.uiTabControl1.TabSelectedForeColor = System.Drawing.Color.CornflowerBlue;
            this.uiTabControl1.TabSelectedHighColor = System.Drawing.Color.White;
            this.uiTabControl1.TabUnSelectedForeColor = System.Drawing.Color.Silver;
            // 
            // tabPage3
            // 
            this.tabPage3.BackColor = System.Drawing.Color.White;
            this.tabPage3.Controls.Add(this.pnlRect2Params);
            this.tabPage3.Controls.Add(this.uiTitlePanel1);
            this.tabPage3.Font = new System.Drawing.Font("隶书", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tabPage3.Location = new System.Drawing.Point(0, 26);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(303, 459);
            this.tabPage3.TabIndex = 0;
            this.tabPage3.Text = "基本设置";
            // 
            // pnlRect2Params
            // 
            this.pnlRect2Params.Controls.Add(this.cbxRobustness);
            this.pnlRect2Params.Controls.Add(this.cbxPolarity);
            this.pnlRect2Params.Controls.Add(this.cbxCodeType);
            this.pnlRect2Params.Controls.Add(this.cbxMode);
            this.pnlRect2Params.Controls.Add(this.tbxTimeOut);
            this.pnlRect2Params.Controls.Add(this.label2);
            this.pnlRect2Params.Controls.Add(this.label5);
            this.pnlRect2Params.Controls.Add(this.label1);
            this.pnlRect2Params.Controls.Add(this.label18);
            this.pnlRect2Params.Controls.Add(this.label3);
            this.pnlRect2Params.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlRect2Params.FillColor = System.Drawing.Color.White;
            this.pnlRect2Params.Font = new System.Drawing.Font("华文新魏", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.pnlRect2Params.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            this.pnlRect2Params.Location = new System.Drawing.Point(0, 83);
            this.pnlRect2Params.Margin = new System.Windows.Forms.Padding(0);
            this.pnlRect2Params.MinimumSize = new System.Drawing.Size(1, 1);
            this.pnlRect2Params.Name = "pnlRect2Params";
            this.pnlRect2Params.Padding = new System.Windows.Forms.Padding(0, 30, 0, 0);
            this.pnlRect2Params.RadiusSides = Rex.UI.UICornerRadiusSides.None;
            this.pnlRect2Params.RectColor = System.Drawing.Color.White;
            this.pnlRect2Params.Size = new System.Drawing.Size(303, 354);
            this.pnlRect2Params.Style = Rex.UI.UIStyle.Custom;
            this.pnlRect2Params.TabIndex = 204;
            this.pnlRect2Params.Text = "参数设置";
            this.pnlRect2Params.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.pnlRect2Params.TextAlignment = System.Drawing.ContentAlignment.MiddleRight;
            this.pnlRect2Params.TitleColor = System.Drawing.Color.CornflowerBlue;
            this.pnlRect2Params.TitleInterval = 5;
            // 
            // cbxRobustness
            // 
            this.cbxRobustness.BackColor = System.Drawing.Color.AliceBlue;
            this.cbxRobustness.DropDownStyle = Rex.UI.UIDropDownStyle.DropDownList;
            this.cbxRobustness.FillColor = System.Drawing.Color.AliceBlue;
            this.cbxRobustness.Font = new System.Drawing.Font("华文新魏", 11.6F);
            this.cbxRobustness.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.cbxRobustness.ForeDisableColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.cbxRobustness.Items.AddRange(new object[] {
            "low",
            "high"});
            this.cbxRobustness.Location = new System.Drawing.Point(83, 153);
            this.cbxRobustness.Margin = new System.Windows.Forms.Padding(0);
            this.cbxRobustness.MinimumSize = new System.Drawing.Size(63, 0);
            this.cbxRobustness.Name = "cbxRobustness";
            this.cbxRobustness.Padding = new System.Windows.Forms.Padding(0, 0, 30, 0);
            this.cbxRobustness.Radius = 2;
            this.cbxRobustness.RectColor = System.Drawing.Color.CornflowerBlue;
            this.cbxRobustness.RectDisableColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.cbxRobustness.RectSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.None;
            this.cbxRobustness.Size = new System.Drawing.Size(210, 24);
            this.cbxRobustness.Style = Rex.UI.UIStyle.Custom;
            this.cbxRobustness.StyleCustomMode = true;
            this.cbxRobustness.SymbolDropDown = 61656;
            this.cbxRobustness.SymbolNormal = 61655;
            this.cbxRobustness.TabIndex = 258;
            this.cbxRobustness.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // cbxPolarity
            // 
            this.cbxPolarity.BackColor = System.Drawing.Color.AliceBlue;
            this.cbxPolarity.DropDownStyle = Rex.UI.UIDropDownStyle.DropDownList;
            this.cbxPolarity.FillColor = System.Drawing.Color.AliceBlue;
            this.cbxPolarity.Font = new System.Drawing.Font("华文新魏", 11.6F);
            this.cbxPolarity.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.cbxPolarity.ForeDisableColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.cbxPolarity.Items.AddRange(new object[] {
            "dark_on_light",
            "light_on_dark",
            "any"});
            this.cbxPolarity.Location = new System.Drawing.Point(83, 117);
            this.cbxPolarity.Margin = new System.Windows.Forms.Padding(0);
            this.cbxPolarity.MinimumSize = new System.Drawing.Size(63, 0);
            this.cbxPolarity.Name = "cbxPolarity";
            this.cbxPolarity.Padding = new System.Windows.Forms.Padding(0, 0, 30, 0);
            this.cbxPolarity.Radius = 2;
            this.cbxPolarity.RectColor = System.Drawing.Color.CornflowerBlue;
            this.cbxPolarity.RectDisableColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.cbxPolarity.RectSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.None;
            this.cbxPolarity.Size = new System.Drawing.Size(210, 24);
            this.cbxPolarity.Style = Rex.UI.UIStyle.Custom;
            this.cbxPolarity.StyleCustomMode = true;
            this.cbxPolarity.SymbolDropDown = 61656;
            this.cbxPolarity.SymbolNormal = 61655;
            this.cbxPolarity.TabIndex = 257;
            this.cbxPolarity.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // cbxCodeType
            // 
            this.cbxCodeType.BackColor = System.Drawing.Color.AliceBlue;
            this.cbxCodeType.DropDownStyle = Rex.UI.UIDropDownStyle.DropDownList;
            this.cbxCodeType.FillColor = System.Drawing.Color.AliceBlue;
            this.cbxCodeType.Font = new System.Drawing.Font("华文新魏", 11.6F);
            this.cbxCodeType.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.cbxCodeType.ForeDisableColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.cbxCodeType.Items.AddRange(new object[] {
            "QR Code",
            "Aztec Code",
            "Data Matrix ECC 200",
            "DotCode",
            "GS1 Aztec Code",
            "GS1 DataMatrix",
            "GS1 DotCode",
            "GS1 QR Code",
            "Micro QR Code",
            "PDF417"});
            this.cbxCodeType.Location = new System.Drawing.Point(83, 81);
            this.cbxCodeType.Margin = new System.Windows.Forms.Padding(0);
            this.cbxCodeType.MinimumSize = new System.Drawing.Size(63, 0);
            this.cbxCodeType.Name = "cbxCodeType";
            this.cbxCodeType.Padding = new System.Windows.Forms.Padding(0, 0, 30, 0);
            this.cbxCodeType.Radius = 2;
            this.cbxCodeType.RectColor = System.Drawing.Color.CornflowerBlue;
            this.cbxCodeType.RectDisableColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.cbxCodeType.RectSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.None;
            this.cbxCodeType.Size = new System.Drawing.Size(210, 24);
            this.cbxCodeType.Style = Rex.UI.UIStyle.Custom;
            this.cbxCodeType.StyleCustomMode = true;
            this.cbxCodeType.SymbolDropDown = 61656;
            this.cbxCodeType.SymbolNormal = 61655;
            this.cbxCodeType.TabIndex = 257;
            this.cbxCodeType.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // cbxMode
            // 
            this.cbxMode.BackColor = System.Drawing.Color.AliceBlue;
            this.cbxMode.DropDownStyle = Rex.UI.UIDropDownStyle.DropDownList;
            this.cbxMode.FillColor = System.Drawing.Color.AliceBlue;
            this.cbxMode.Font = new System.Drawing.Font("华文新魏", 11.6F);
            this.cbxMode.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.cbxMode.ForeDisableColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.cbxMode.Items.AddRange(new object[] {
            "standard_recognition",
            "enhanced_recognition",
            "maximum_recognition"});
            this.cbxMode.Location = new System.Drawing.Point(83, 45);
            this.cbxMode.Margin = new System.Windows.Forms.Padding(0);
            this.cbxMode.MinimumSize = new System.Drawing.Size(63, 0);
            this.cbxMode.Name = "cbxMode";
            this.cbxMode.Padding = new System.Windows.Forms.Padding(0, 0, 30, 0);
            this.cbxMode.Radius = 2;
            this.cbxMode.RectColor = System.Drawing.Color.CornflowerBlue;
            this.cbxMode.RectDisableColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.cbxMode.RectSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.None;
            this.cbxMode.Size = new System.Drawing.Size(210, 24);
            this.cbxMode.Style = Rex.UI.UIStyle.Custom;
            this.cbxMode.StyleCustomMode = true;
            this.cbxMode.SymbolDropDown = 61656;
            this.cbxMode.SymbolNormal = 61655;
            this.cbxMode.TabIndex = 256;
            this.cbxMode.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // tbxTimeOut
            // 
            this.tbxTimeOut.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbxTimeOut.Font = new System.Drawing.Font("华文新魏", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tbxTimeOut.Location = new System.Drawing.Point(83, 189);
            this.tbxTimeOut.Margin = new System.Windows.Forms.Padding(0);
            this.tbxTimeOut.Maximum = 2147483647D;
            this.tbxTimeOut.Minimum = -2147483648D;
            this.tbxTimeOut.MinimumSize = new System.Drawing.Size(1, 1);
            this.tbxTimeOut.Name = "tbxTimeOut";
            this.tbxTimeOut.Size = new System.Drawing.Size(210, 23);
            this.tbxTimeOut.Style = Rex.UI.UIStyle.Custom;
            this.tbxTimeOut.TabIndex = 255;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("华文新魏", 11F);
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.label2.Location = new System.Drawing.Point(10, 195);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 16);
            this.label2.TabIndex = 219;
            this.label2.Text = "超时时长:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("华文新魏", 11F);
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.label5.Location = new System.Drawing.Point(10, 160);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(73, 16);
            this.label5.TabIndex = 215;
            this.label5.Text = "稳定性能:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("华文新魏", 11F);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.label1.Location = new System.Drawing.Point(10, 88);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 16);
            this.label1.TabIndex = 206;
            this.label1.Text = "类型选择:";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.BackColor = System.Drawing.Color.Transparent;
            this.label18.Font = new System.Drawing.Font("华文新魏", 11F);
            this.label18.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.label18.Location = new System.Drawing.Point(10, 52);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(73, 16);
            this.label18.TabIndex = 204;
            this.label18.Text = "读码模式:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("华文新魏", 11F);
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.label3.Location = new System.Drawing.Point(10, 124);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 16);
            this.label3.TabIndex = 208;
            this.label3.Text = "极性选择:";
            // 
            // uiTitlePanel1
            // 
            this.uiTitlePanel1.Controls.Add(this.ldImage);
            this.uiTitlePanel1.Controls.Add(this.label11);
            this.uiTitlePanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.uiTitlePanel1.FillColor = System.Drawing.Color.White;
            this.uiTitlePanel1.Font = new System.Drawing.Font("华文新魏", 12F);
            this.uiTitlePanel1.ForeColor = System.Drawing.Color.White;
            this.uiTitlePanel1.Location = new System.Drawing.Point(0, 0);
            this.uiTitlePanel1.Margin = new System.Windows.Forms.Padding(0);
            this.uiTitlePanel1.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiTitlePanel1.Name = "uiTitlePanel1";
            this.uiTitlePanel1.Padding = new System.Windows.Forms.Padding(3, 25, 3, 0);
            this.uiTitlePanel1.RadiusSides = Rex.UI.UICornerRadiusSides.None;
            this.uiTitlePanel1.RectColor = System.Drawing.Color.White;
            this.uiTitlePanel1.Size = new System.Drawing.Size(303, 83);
            this.uiTitlePanel1.Style = Rex.UI.UIStyle.Custom;
            this.uiTitlePanel1.TabIndex = 14;
            this.uiTitlePanel1.Text = "输入图像";
            this.uiTitlePanel1.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.uiTitlePanel1.TextAlignment = System.Drawing.ContentAlignment.BottomCenter;
            this.uiTitlePanel1.TitleColor = System.Drawing.Color.CornflowerBlue;
            this.uiTitlePanel1.TitleInterval = 5;
            // 
            // ldImage
            // 
            this.ldImage.BackColor = System.Drawing.Color.AliceBlue;
            this.ldImage.Font = new System.Drawing.Font("华文新魏", 12F);
            this.ldImage.FontStyle = new System.Drawing.Font("华文新魏", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.ldImage.Location = new System.Drawing.Point(83, 43);
            this.ldImage.Margin = new System.Windows.Forms.Padding(4, 5, 4, 4);
            this.ldImage.Name = "ldImage";
            this.ldImage.Size = new System.Drawing.Size(210, 24);
            this.ldImage.TabIndex = 195;
            this.ldImage.TextInfo = "";
            this.ldImage.LinkData += new System.EventHandler(this.ldImage_LinkData);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.Transparent;
            this.label11.Font = new System.Drawing.Font("华文新魏", 11F);
            this.label11.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.label11.Location = new System.Drawing.Point(10, 48);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(73, 16);
            this.label11.TabIndex = 191;
            this.label11.Text = "输入图像:";
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.uiTitlePanel8);
            this.tabPage4.Location = new System.Drawing.Point(0, 26);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Size = new System.Drawing.Size(303, 459);
            this.tabPage4.TabIndex = 1;
            this.tabPage4.Text = "显示设置";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // uiTitlePanel8
            // 
            this.uiTitlePanel8.Controls.Add(this.cbxFontStye);
            this.uiTitlePanel8.Controls.Add(this.label4);
            this.uiTitlePanel8.Controls.Add(this.chxShowData);
            this.uiTitlePanel8.Controls.Add(this.tbxY);
            this.uiTitlePanel8.Controls.Add(this.tbxFontSize);
            this.uiTitlePanel8.Controls.Add(this.label12);
            this.uiTitlePanel8.Controls.Add(this.tbxX);
            this.uiTitlePanel8.Controls.Add(this.label8);
            this.uiTitlePanel8.Controls.Add(this.label10);
            this.uiTitlePanel8.Controls.Add(this.tbxPrefix);
            this.uiTitlePanel8.Controls.Add(this.label14);
            this.uiTitlePanel8.Controls.Add(this.label7);
            this.uiTitlePanel8.Controls.Add(this.cpColor);
            this.uiTitlePanel8.Controls.Add(this.chxShowReg);
            this.uiTitlePanel8.Dock = System.Windows.Forms.DockStyle.Top;
            this.uiTitlePanel8.FillColor = System.Drawing.Color.White;
            this.uiTitlePanel8.Font = new System.Drawing.Font("华文新魏", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uiTitlePanel8.ForeColor = System.Drawing.Color.White;
            this.uiTitlePanel8.Location = new System.Drawing.Point(0, 0);
            this.uiTitlePanel8.Margin = new System.Windows.Forms.Padding(0);
            this.uiTitlePanel8.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiTitlePanel8.Name = "uiTitlePanel8";
            this.uiTitlePanel8.Padding = new System.Windows.Forms.Padding(0, 25, 0, 0);
            this.uiTitlePanel8.RadiusSides = Rex.UI.UICornerRadiusSides.None;
            this.uiTitlePanel8.RectColor = System.Drawing.Color.White;
            this.uiTitlePanel8.Size = new System.Drawing.Size(303, 430);
            this.uiTitlePanel8.Style = Rex.UI.UIStyle.Custom;
            this.uiTitlePanel8.TabIndex = 192;
            this.uiTitlePanel8.Text = "显示设置";
            this.uiTitlePanel8.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.uiTitlePanel8.TitleColor = System.Drawing.Color.CornflowerBlue;
            this.uiTitlePanel8.TitleInterval = 5;
            // 
            // cbxFontStye
            // 
            this.cbxFontStye.BackColor = System.Drawing.Color.AliceBlue;
            this.cbxFontStye.DropDownStyle = Rex.UI.UIDropDownStyle.DropDownList;
            this.cbxFontStye.FillColor = System.Drawing.Color.AliceBlue;
            this.cbxFontStye.Font = new System.Drawing.Font("华文新魏", 11F);
            this.cbxFontStye.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.cbxFontStye.ForeDisableColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.cbxFontStye.Location = new System.Drawing.Point(86, 199);
            this.cbxFontStye.Margin = new System.Windows.Forms.Padding(0);
            this.cbxFontStye.MinimumSize = new System.Drawing.Size(63, 0);
            this.cbxFontStye.Name = "cbxFontStye";
            this.cbxFontStye.Padding = new System.Windows.Forms.Padding(0, 0, 30, 0);
            this.cbxFontStye.Radius = 2;
            this.cbxFontStye.RectColor = System.Drawing.Color.CornflowerBlue;
            this.cbxFontStye.RectDisableColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.cbxFontStye.RectSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.None;
            this.cbxFontStye.Size = new System.Drawing.Size(203, 23);
            this.cbxFontStye.Style = Rex.UI.UIStyle.Custom;
            this.cbxFontStye.StyleCustomMode = true;
            this.cbxFontStye.SymbolDropDown = 61656;
            this.cbxFontStye.SymbolNormal = 61655;
            this.cbxFontStye.TabIndex = 233;
            this.cbxFontStye.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("华文新魏", 11F);
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.label4.Location = new System.Drawing.Point(14, 204);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(73, 16);
            this.label4.TabIndex = 232;
            this.label4.Text = "字体样式:";
            // 
            // chxShowData
            // 
            this.chxShowData.BackColor = System.Drawing.Color.White;
            this.chxShowData.Checked = true;
            this.chxShowData.Cursor = System.Windows.Forms.Cursors.Hand;
            this.chxShowData.Font = new System.Drawing.Font("华文新魏", 11F);
            this.chxShowData.ImageSize = 14;
            this.chxShowData.Location = new System.Drawing.Point(13, 67);
            this.chxShowData.MinimumSize = new System.Drawing.Size(1, 1);
            this.chxShowData.Name = "chxShowData";
            this.chxShowData.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.chxShowData.Size = new System.Drawing.Size(211, 16);
            this.chxShowData.Style = Rex.UI.UIStyle.Custom;
            this.chxShowData.TabIndex = 231;
            this.chxShowData.Text = "显示数据";
            // 
            // tbxY
            // 
            this.tbxY.Font = new System.Drawing.Font("华文新魏", 11F);
            this.tbxY.FontStyle = null;
            this.tbxY.Location = new System.Drawing.Point(86, 128);
            this.tbxY.Name = "tbxY";
            this.tbxY.Size = new System.Drawing.Size(204, 26);
            this.tbxY.TabIndex = 230;
            this.tbxY.TextInfo = "";
            // 
            // tbxFontSize
            // 
            this.tbxFontSize.BackColor = System.Drawing.Color.White;
            this.tbxFontSize.FontStyle = null;
            this.tbxFontSize.Location = new System.Drawing.Point(86, 164);
            this.tbxFontSize.Name = "tbxFontSize";
            this.tbxFontSize.Size = new System.Drawing.Size(204, 25);
            this.tbxFontSize.TabIndex = 229;
            this.tbxFontSize.TextInfo = "";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.Color.Transparent;
            this.label12.Font = new System.Drawing.Font("华文新魏", 11F);
            this.label12.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.label12.Location = new System.Drawing.Point(14, 171);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(73, 16);
            this.label12.TabIndex = 228;
            this.label12.Text = "字体大小:";
            // 
            // tbxX
            // 
            this.tbxX.Font = new System.Drawing.Font("华文新魏", 11F);
            this.tbxX.FontStyle = null;
            this.tbxX.Location = new System.Drawing.Point(86, 92);
            this.tbxX.Name = "tbxX";
            this.tbxX.Size = new System.Drawing.Size(203, 26);
            this.tbxX.TabIndex = 227;
            this.tbxX.TextInfo = "";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("华文新魏", 11F);
            this.label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.label8.Location = new System.Drawing.Point(14, 136);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(52, 16);
            this.label8.TabIndex = 225;
            this.label8.Text = "位置Y:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.Font = new System.Drawing.Font("华文新魏", 11F);
            this.label10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.label10.Location = new System.Drawing.Point(13, 100);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(53, 16);
            this.label10.TabIndex = 224;
            this.label10.Text = "位置X:";
            // 
            // tbxPrefix
            // 
            this.tbxPrefix.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbxPrefix.FillColor = System.Drawing.Color.AliceBlue;
            this.tbxPrefix.FillDisableColor = System.Drawing.Color.AliceBlue;
            this.tbxPrefix.Font = new System.Drawing.Font("华文新魏", 11F);
            this.tbxPrefix.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.tbxPrefix.Location = new System.Drawing.Point(86, 232);
            this.tbxPrefix.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tbxPrefix.Maximum = 2147483647D;
            this.tbxPrefix.Minimum = -2147483648D;
            this.tbxPrefix.MinimumSize = new System.Drawing.Size(1, 1);
            this.tbxPrefix.Name = "tbxPrefix";
            this.tbxPrefix.Padding = new System.Windows.Forms.Padding(5);
            this.tbxPrefix.Radius = 20;
            this.tbxPrefix.RadiusSides = Rex.UI.UICornerRadiusSides.None;
            this.tbxPrefix.RectColor = System.Drawing.Color.AliceBlue;
            this.tbxPrefix.RectSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.Bottom;
            this.tbxPrefix.Size = new System.Drawing.Size(204, 23);
            this.tbxPrefix.Style = Rex.UI.UIStyle.Custom;
            this.tbxPrefix.StyleCustomMode = true;
            this.tbxPrefix.TabIndex = 205;
            this.tbxPrefix.Watermark = "";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.BackColor = System.Drawing.Color.Transparent;
            this.label14.Font = new System.Drawing.Font("华文新魏", 11F);
            this.label14.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.label14.Location = new System.Drawing.Point(14, 237);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(43, 16);
            this.label14.TabIndex = 204;
            this.label14.Text = "前缀:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("华文新魏", 11F);
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.label7.Location = new System.Drawing.Point(14, 270);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(43, 16);
            this.label7.TabIndex = 201;
            this.label7.Text = "颜色:";
            // 
            // cpColor
            // 
            this.cpColor.DropDownStyle = Rex.UI.UIDropDownStyle.DropDownList;
            this.cpColor.FillColor = System.Drawing.Color.AliceBlue;
            this.cpColor.FillDisableColor = System.Drawing.Color.AliceBlue;
            this.cpColor.Font = new System.Drawing.Font("微软雅黑", 9F);
            this.cpColor.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.cpColor.Location = new System.Drawing.Point(86, 265);
            this.cpColor.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cpColor.MinimumSize = new System.Drawing.Size(63, 0);
            this.cpColor.Name = "cpColor";
            this.cpColor.Padding = new System.Windows.Forms.Padding(0, 0, 30, 0);
            this.cpColor.RadiusSides = Rex.UI.UICornerRadiusSides.None;
            this.cpColor.RectColor = System.Drawing.Color.White;
            this.cpColor.RectSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.Bottom;
            this.cpColor.Size = new System.Drawing.Size(204, 23);
            this.cpColor.Style = Rex.UI.UIStyle.Custom;
            this.cpColor.StyleCustomMode = true;
            this.cpColor.TabIndex = 200;
            this.cpColor.Text = "uiColorPicker1";
            this.cpColor.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.cpColor.Value = System.Drawing.Color.DodgerBlue;
            // 
            // chxShowReg
            // 
            this.chxShowReg.BackColor = System.Drawing.Color.White;
            this.chxShowReg.Checked = true;
            this.chxShowReg.Cursor = System.Windows.Forms.Cursors.Hand;
            this.chxShowReg.Font = new System.Drawing.Font("华文新魏", 11F);
            this.chxShowReg.ImageSize = 14;
            this.chxShowReg.Location = new System.Drawing.Point(13, 41);
            this.chxShowReg.MinimumSize = new System.Drawing.Size(1, 1);
            this.chxShowReg.Name = "chxShowReg";
            this.chxShowReg.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.chxShowReg.Size = new System.Drawing.Size(211, 16);
            this.chxShowReg.Style = Rex.UI.UIStyle.Custom;
            this.chxShowReg.TabIndex = 198;
            this.chxShowReg.Text = "显示区域";
            // 
            // mWindowH
            // 
            this.mWindowH.BackColor = System.Drawing.Color.Transparent;
            this.mWindowH.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.mWindowH.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mWindowH.DrawModel = false;
            this.mWindowH.Image = null;
            this.mWindowH.Location = new System.Drawing.Point(304, 1);
            this.mWindowH.Margin = new System.Windows.Forms.Padding(5);
            this.mWindowH.Name = "mWindowH";
            this.mWindowH.Padding = new System.Windows.Forms.Padding(1);
            this.mWindowH.Size = new System.Drawing.Size(541, 485);
            this.mWindowH.TabIndex = 21;
            // 
            // ReadQRCodeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(848, 548);
            this.Name = "ReadQRCodeForm";
            this.Load += new System.EventHandler(this.ReadBarcodeForm_Load);
            this.panel_bottom.ResumeLayout(false);
            this.panel_center.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbox_Icon)).EndInit();
            this.titlepanel.ResumeLayout(false);
            this.titlepanel.PerformLayout();
            this.uiTabControl1.ResumeLayout(false);
            this.tabPage3.ResumeLayout(false);
            this.pnlRect2Params.ResumeLayout(false);
            this.pnlRect2Params.PerformLayout();
            this.uiTitlePanel1.ResumeLayout(false);
            this.uiTitlePanel1.PerformLayout();
            this.tabPage4.ResumeLayout(false);
            this.uiTitlePanel8.ResumeLayout(false);
            this.uiTitlePanel8.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private Rex.UI.UITabControl uiTabControl1;
        private System.Windows.Forms.TabPage tabPage3;
        private Rex.UI.UITitlePanel uiTitlePanel1;
        private RexControl.MyControls.MyLinkData ldImage;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TabPage tabPage4;
        private Rex.UI.UITitlePanel pnlRect2Params;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private Rex.UI.UITextBox tbxTimeOut;
        private Rex.UI.UITitlePanel uiTitlePanel8;
        private Rex.UI.UICheckBox chxShowData;
        private RexControl.MyControls.MyTextBoxUpDownD tbxY;
        private RexControl.MyControls.MyTextBoxUpDown tbxFontSize;
        private System.Windows.Forms.Label label12;
        private RexControl.MyControls.MyTextBoxUpDownD tbxX;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label10;
        private Rex.UI.UITextBox tbxPrefix;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label7;
        private Rex.UI.UIColorPicker cpColor;
        private Rex.UI.UICheckBox chxShowReg;
        private Rex.UI.MyComboBox cbxFontStye;
        private System.Windows.Forms.Label label4;
        private Rex.UI.MyComboBox cbxRobustness;
        private Rex.UI.MyComboBox cbxPolarity;
        private Rex.UI.MyComboBox cbxCodeType;
        private Rex.UI.MyComboBox cbxMode;
        private RexView.HWindow_HE mWindowH;
    }
}