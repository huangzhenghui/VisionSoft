
namespace Plugin.ProcessReg
{
    partial class ProcessRegForm
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
            this.mWindowH = new RexView.HWindow_HE();
            this.uiTabControl1 = new Rex.UI.UITabControl();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.pnlCustomParams = new Rex.UI.UITitlePanel();
            this.ldElement = new RexControl.MyControls.MyLinkData();
            this.label5 = new System.Windows.Forms.Label();
            this.pnlCirCleParams = new Rex.UI.UITitlePanel();
            this.tbxRadius = new RexControl.MyControls.MyTextBoxUpDownD();
            this.label3 = new System.Windows.Forms.Label();
            this.pnlRect1Params = new Rex.UI.UITitlePanel();
            this.tbxHeight = new RexControl.MyControls.MyTextBoxUpDownD();
            this.tbxWidth = new RexControl.MyControls.MyTextBoxUpDownD();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.pnlDynThreshold = new Rex.UI.UITitlePanel();
            this.cbxShape = new Rex.UI.MyComboBox();
            this.ldRegion = new RexControl.MyControls.MyLinkData();
            this.cbxMode = new Rex.UI.MyComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.pnlImageInfo = new Rex.UI.UITitlePanel();
            this.ldImage = new RexControl.MyControls.MyLinkData();
            this.label12 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.pnl2Show = new Rex.UI.UITitlePanel();
            this.label1 = new System.Windows.Forms.Label();
            this.cpColor = new Rex.UI.UIColorPicker();
            this.cbxDraw = new Rex.UI.MyComboBox();
            this.chxShow = new Rex.UI.UICheckBox();
            this.label9 = new System.Windows.Forms.Label();
            this.panel_bottom.SuspendLayout();
            this.panel_center.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbox_Icon)).BeginInit();
            this.titlepanel.SuspendLayout();
            this.uiTabControl1.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.pnlCustomParams.SuspendLayout();
            this.pnlCirCleParams.SuspendLayout();
            this.pnlRect1Params.SuspendLayout();
            this.pnlDynThreshold.SuspendLayout();
            this.pnlImageInfo.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.pnl2Show.SuspendLayout();
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
            this.mWindowH.TabIndex = 20;
            // 
            // uiTabControl1
            // 
            this.uiTabControl1.Controls.Add(this.tabPage3);
            this.uiTabControl1.Controls.Add(this.tabPage2);
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
            this.tabPage3.Controls.Add(this.pnlCustomParams);
            this.tabPage3.Controls.Add(this.pnlCirCleParams);
            this.tabPage3.Controls.Add(this.pnlRect1Params);
            this.tabPage3.Controls.Add(this.pnlDynThreshold);
            this.tabPage3.Controls.Add(this.pnlImageInfo);
            this.tabPage3.Font = new System.Drawing.Font("隶书", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tabPage3.Location = new System.Drawing.Point(0, 26);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(303, 459);
            this.tabPage3.TabIndex = 0;
            this.tabPage3.Text = "基本设置";
            // 
            // pnlCustomParams
            // 
            this.pnlCustomParams.Controls.Add(this.ldElement);
            this.pnlCustomParams.Controls.Add(this.label5);
            this.pnlCustomParams.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlCustomParams.FillColor = System.Drawing.Color.White;
            this.pnlCustomParams.Font = new System.Drawing.Font("华文新魏", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.pnlCustomParams.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            this.pnlCustomParams.Location = new System.Drawing.Point(0, 417);
            this.pnlCustomParams.Margin = new System.Windows.Forms.Padding(0);
            this.pnlCustomParams.MinimumSize = new System.Drawing.Size(1, 1);
            this.pnlCustomParams.Name = "pnlCustomParams";
            this.pnlCustomParams.Padding = new System.Windows.Forms.Padding(0, 30, 0, 0);
            this.pnlCustomParams.RadiusSides = Rex.UI.UICornerRadiusSides.None;
            this.pnlCustomParams.RectColor = System.Drawing.Color.White;
            this.pnlCustomParams.Size = new System.Drawing.Size(303, 72);
            this.pnlCustomParams.Style = Rex.UI.UIStyle.Custom;
            this.pnlCustomParams.TabIndex = 208;
            this.pnlCustomParams.Text = "参数设置";
            this.pnlCustomParams.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.pnlCustomParams.TextAlignment = System.Drawing.ContentAlignment.MiddleRight;
            this.pnlCustomParams.TitleColor = System.Drawing.Color.CornflowerBlue;
            this.pnlCustomParams.TitleInterval = 5;
            // 
            // ldElement
            // 
            this.ldElement.BackColor = System.Drawing.Color.AliceBlue;
            this.ldElement.Font = new System.Drawing.Font("华文新魏", 12F);
            this.ldElement.FontStyle = new System.Drawing.Font("华文新魏", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.ldElement.Location = new System.Drawing.Point(85, 37);
            this.ldElement.Margin = new System.Windows.Forms.Padding(4, 5, 4, 4);
            this.ldElement.Name = "ldElement";
            this.ldElement.Size = new System.Drawing.Size(204, 24);
            this.ldElement.TabIndex = 207;
            this.ldElement.TextInfo = "";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("华文新魏", 11F);
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.label5.Location = new System.Drawing.Point(12, 43);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(73, 16);
            this.label5.TabIndex = 206;
            this.label5.Text = "结构元素:";
            // 
            // pnlCirCleParams
            // 
            this.pnlCirCleParams.Controls.Add(this.tbxRadius);
            this.pnlCirCleParams.Controls.Add(this.label3);
            this.pnlCirCleParams.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlCirCleParams.FillColor = System.Drawing.Color.White;
            this.pnlCirCleParams.Font = new System.Drawing.Font("华文新魏", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.pnlCirCleParams.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            this.pnlCirCleParams.Location = new System.Drawing.Point(0, 342);
            this.pnlCirCleParams.Margin = new System.Windows.Forms.Padding(0);
            this.pnlCirCleParams.MinimumSize = new System.Drawing.Size(1, 1);
            this.pnlCirCleParams.Name = "pnlCirCleParams";
            this.pnlCirCleParams.Padding = new System.Windows.Forms.Padding(0, 30, 0, 0);
            this.pnlCirCleParams.RadiusSides = Rex.UI.UICornerRadiusSides.None;
            this.pnlCirCleParams.RectColor = System.Drawing.Color.White;
            this.pnlCirCleParams.Size = new System.Drawing.Size(303, 75);
            this.pnlCirCleParams.Style = Rex.UI.UIStyle.Custom;
            this.pnlCirCleParams.TabIndex = 207;
            this.pnlCirCleParams.Text = "参数设置";
            this.pnlCirCleParams.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.pnlCirCleParams.TextAlignment = System.Drawing.ContentAlignment.MiddleRight;
            this.pnlCirCleParams.TitleColor = System.Drawing.Color.CornflowerBlue;
            this.pnlCirCleParams.TitleInterval = 5;
            // 
            // tbxRadius
            // 
            this.tbxRadius.Font = new System.Drawing.Font("华文新魏", 11F);
            this.tbxRadius.FontStyle = null;
            this.tbxRadius.Location = new System.Drawing.Point(85, 36);
            this.tbxRadius.Name = "tbxRadius";
            this.tbxRadius.Size = new System.Drawing.Size(208, 26);
            this.tbxRadius.TabIndex = 224;
            this.tbxRadius.TextInfo = "";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("华文新魏", 11F);
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.label3.Location = new System.Drawing.Point(12, 42);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 16);
            this.label3.TabIndex = 206;
            this.label3.Text = "半径:";
            // 
            // pnlRect1Params
            // 
            this.pnlRect1Params.Controls.Add(this.tbxHeight);
            this.pnlRect1Params.Controls.Add(this.tbxWidth);
            this.pnlRect1Params.Controls.Add(this.label7);
            this.pnlRect1Params.Controls.Add(this.label8);
            this.pnlRect1Params.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlRect1Params.FillColor = System.Drawing.Color.White;
            this.pnlRect1Params.Font = new System.Drawing.Font("华文新魏", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.pnlRect1Params.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            this.pnlRect1Params.Location = new System.Drawing.Point(0, 230);
            this.pnlRect1Params.Margin = new System.Windows.Forms.Padding(0);
            this.pnlRect1Params.MinimumSize = new System.Drawing.Size(1, 1);
            this.pnlRect1Params.Name = "pnlRect1Params";
            this.pnlRect1Params.Padding = new System.Windows.Forms.Padding(0, 30, 0, 0);
            this.pnlRect1Params.RadiusSides = Rex.UI.UICornerRadiusSides.None;
            this.pnlRect1Params.RectColor = System.Drawing.Color.White;
            this.pnlRect1Params.Size = new System.Drawing.Size(303, 112);
            this.pnlRect1Params.Style = Rex.UI.UIStyle.Custom;
            this.pnlRect1Params.TabIndex = 205;
            this.pnlRect1Params.Text = "参数设置";
            this.pnlRect1Params.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.pnlRect1Params.TextAlignment = System.Drawing.ContentAlignment.MiddleRight;
            this.pnlRect1Params.TitleColor = System.Drawing.Color.CornflowerBlue;
            this.pnlRect1Params.TitleInterval = 5;
            // 
            // tbxHeight
            // 
            this.tbxHeight.Font = new System.Drawing.Font("华文新魏", 11F);
            this.tbxHeight.FontStyle = null;
            this.tbxHeight.Location = new System.Drawing.Point(85, 72);
            this.tbxHeight.Name = "tbxHeight";
            this.tbxHeight.Size = new System.Drawing.Size(208, 26);
            this.tbxHeight.TabIndex = 225;
            this.tbxHeight.TextInfo = "";
            // 
            // tbxWidth
            // 
            this.tbxWidth.Font = new System.Drawing.Font("华文新魏", 11F);
            this.tbxWidth.FontStyle = null;
            this.tbxWidth.Location = new System.Drawing.Point(85, 36);
            this.tbxWidth.Name = "tbxWidth";
            this.tbxWidth.Size = new System.Drawing.Size(208, 26);
            this.tbxWidth.TabIndex = 224;
            this.tbxWidth.TextInfo = "";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("华文新魏", 11F);
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.label7.Location = new System.Drawing.Point(12, 42);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(28, 16);
            this.label7.TabIndex = 206;
            this.label7.Text = "宽:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("华文新魏", 11F);
            this.label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.label8.Location = new System.Drawing.Point(12, 79);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(28, 16);
            this.label8.TabIndex = 208;
            this.label8.Text = "高:";
            // 
            // pnlDynThreshold
            // 
            this.pnlDynThreshold.Controls.Add(this.cbxShape);
            this.pnlDynThreshold.Controls.Add(this.ldRegion);
            this.pnlDynThreshold.Controls.Add(this.cbxMode);
            this.pnlDynThreshold.Controls.Add(this.label4);
            this.pnlDynThreshold.Controls.Add(this.label18);
            this.pnlDynThreshold.Controls.Add(this.label2);
            this.pnlDynThreshold.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlDynThreshold.FillColor = System.Drawing.Color.White;
            this.pnlDynThreshold.Font = new System.Drawing.Font("华文新魏", 12F);
            this.pnlDynThreshold.ForeColor = System.Drawing.Color.White;
            this.pnlDynThreshold.Location = new System.Drawing.Point(0, 87);
            this.pnlDynThreshold.Margin = new System.Windows.Forms.Padding(0);
            this.pnlDynThreshold.MinimumSize = new System.Drawing.Size(1, 1);
            this.pnlDynThreshold.Name = "pnlDynThreshold";
            this.pnlDynThreshold.Padding = new System.Windows.Forms.Padding(3, 25, 3, 0);
            this.pnlDynThreshold.RadiusSides = Rex.UI.UICornerRadiusSides.None;
            this.pnlDynThreshold.RectColor = System.Drawing.Color.White;
            this.pnlDynThreshold.Size = new System.Drawing.Size(303, 143);
            this.pnlDynThreshold.Style = Rex.UI.UIStyle.Custom;
            this.pnlDynThreshold.TabIndex = 204;
            this.pnlDynThreshold.Text = "处理设置";
            this.pnlDynThreshold.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.pnlDynThreshold.TextAlignment = System.Drawing.ContentAlignment.BottomCenter;
            this.pnlDynThreshold.TitleColor = System.Drawing.Color.CornflowerBlue;
            this.pnlDynThreshold.TitleInterval = 5;
            // 
            // cbxShape
            // 
            this.cbxShape.BackColor = System.Drawing.Color.AliceBlue;
            this.cbxShape.DropDownStyle = Rex.UI.UIDropDownStyle.DropDownList;
            this.cbxShape.FillColor = System.Drawing.Color.AliceBlue;
            this.cbxShape.Font = new System.Drawing.Font("华文新魏", 11.6F);
            this.cbxShape.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.cbxShape.ForeDisableColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.cbxShape.Items.AddRange(new object[] {
            "圆",
            "矩形1",
            "自定义"});
            this.cbxShape.Location = new System.Drawing.Point(85, 104);
            this.cbxShape.Margin = new System.Windows.Forms.Padding(0);
            this.cbxShape.MinimumSize = new System.Drawing.Size(63, 0);
            this.cbxShape.Name = "cbxShape";
            this.cbxShape.Padding = new System.Windows.Forms.Padding(0, 0, 30, 0);
            this.cbxShape.Radius = 2;
            this.cbxShape.RectColor = System.Drawing.Color.CornflowerBlue;
            this.cbxShape.RectDisableColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.cbxShape.RectSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.None;
            this.cbxShape.Size = new System.Drawing.Size(208, 24);
            this.cbxShape.Style = Rex.UI.UIStyle.Custom;
            this.cbxShape.StyleCustomMode = true;
            this.cbxShape.SymbolDropDown = 61656;
            this.cbxShape.SymbolNormal = 61655;
            this.cbxShape.TabIndex = 236;
            this.cbxShape.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.cbxShape.SelectedIndexChanged += new System.EventHandler(this.cbxSelect_SelectedIndexChanged);
            // 
            // ldRegion
            // 
            this.ldRegion.BackColor = System.Drawing.Color.AliceBlue;
            this.ldRegion.Font = new System.Drawing.Font("华文新魏", 12F);
            this.ldRegion.FontStyle = new System.Drawing.Font("华文新魏", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.ldRegion.Location = new System.Drawing.Point(85, 40);
            this.ldRegion.Margin = new System.Windows.Forms.Padding(4, 5, 4, 4);
            this.ldRegion.Name = "ldRegion";
            this.ldRegion.Size = new System.Drawing.Size(208, 24);
            this.ldRegion.TabIndex = 197;
            this.ldRegion.TextInfo = "";
            this.ldRegion.LinkData += new System.EventHandler(this.ldData_LinkData);
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
            "腐蚀",
            "膨胀",
            "开运算",
            "闭运算"});
            this.cbxMode.Location = new System.Drawing.Point(85, 72);
            this.cbxMode.Margin = new System.Windows.Forms.Padding(0);
            this.cbxMode.MinimumSize = new System.Drawing.Size(63, 0);
            this.cbxMode.Name = "cbxMode";
            this.cbxMode.Padding = new System.Windows.Forms.Padding(0, 0, 30, 0);
            this.cbxMode.Radius = 2;
            this.cbxMode.RectColor = System.Drawing.Color.CornflowerBlue;
            this.cbxMode.RectDisableColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.cbxMode.RectSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.None;
            this.cbxMode.Size = new System.Drawing.Size(208, 24);
            this.cbxMode.Style = Rex.UI.UIStyle.Custom;
            this.cbxMode.StyleCustomMode = true;
            this.cbxMode.SymbolDropDown = 61656;
            this.cbxMode.SymbolNormal = 61655;
            this.cbxMode.TabIndex = 234;
            this.cbxMode.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("华文新魏", 11F);
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.label4.Location = new System.Drawing.Point(13, 45);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(73, 16);
            this.label4.TabIndex = 196;
            this.label4.Text = "输入区域:";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.BackColor = System.Drawing.Color.Transparent;
            this.label18.Font = new System.Drawing.Font("华文新魏", 11F);
            this.label18.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.label18.Location = new System.Drawing.Point(13, 109);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(73, 16);
            this.label18.TabIndex = 233;
            this.label18.Text = "元素形状:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("华文新魏", 11F);
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.label2.Location = new System.Drawing.Point(13, 77);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 16);
            this.label2.TabIndex = 235;
            this.label2.Text = "处理方式:";
            // 
            // pnlImageInfo
            // 
            this.pnlImageInfo.Controls.Add(this.ldImage);
            this.pnlImageInfo.Controls.Add(this.label12);
            this.pnlImageInfo.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlImageInfo.FillColor = System.Drawing.Color.White;
            this.pnlImageInfo.Font = new System.Drawing.Font("华文新魏", 12F);
            this.pnlImageInfo.ForeColor = System.Drawing.Color.White;
            this.pnlImageInfo.Location = new System.Drawing.Point(0, 0);
            this.pnlImageInfo.Margin = new System.Windows.Forms.Padding(0);
            this.pnlImageInfo.MinimumSize = new System.Drawing.Size(1, 1);
            this.pnlImageInfo.Name = "pnlImageInfo";
            this.pnlImageInfo.Padding = new System.Windows.Forms.Padding(3, 25, 3, 0);
            this.pnlImageInfo.RadiusSides = Rex.UI.UICornerRadiusSides.None;
            this.pnlImageInfo.RectColor = System.Drawing.Color.White;
            this.pnlImageInfo.Size = new System.Drawing.Size(303, 87);
            this.pnlImageInfo.Style = Rex.UI.UIStyle.Custom;
            this.pnlImageInfo.TabIndex = 201;
            this.pnlImageInfo.Text = "输入图像";
            this.pnlImageInfo.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.pnlImageInfo.TextAlignment = System.Drawing.ContentAlignment.BottomCenter;
            this.pnlImageInfo.TitleColor = System.Drawing.Color.CornflowerBlue;
            this.pnlImageInfo.TitleInterval = 5;
            // 
            // ldImage
            // 
            this.ldImage.BackColor = System.Drawing.Color.AliceBlue;
            this.ldImage.Font = new System.Drawing.Font("华文新魏", 12F);
            this.ldImage.FontStyle = new System.Drawing.Font("华文新魏", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.ldImage.Location = new System.Drawing.Point(85, 43);
            this.ldImage.Margin = new System.Windows.Forms.Padding(4, 5, 4, 4);
            this.ldImage.Name = "ldImage";
            this.ldImage.Size = new System.Drawing.Size(208, 24);
            this.ldImage.TabIndex = 195;
            this.ldImage.TextInfo = "";
            this.ldImage.LinkData += new System.EventHandler(this.ldData_LinkData);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.Color.Transparent;
            this.label12.Font = new System.Drawing.Font("华文新魏", 11F);
            this.label12.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.label12.Location = new System.Drawing.Point(12, 47);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(73, 16);
            this.label12.TabIndex = 191;
            this.label12.Text = "输入图像:";
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.White;
            this.tabPage2.Controls.Add(this.pnl2Show);
            this.tabPage2.Location = new System.Drawing.Point(0, 26);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Size = new System.Drawing.Size(303, 459);
            this.tabPage2.TabIndex = 3;
            this.tabPage2.Text = "显示设置";
            // 
            // pnl2Show
            // 
            this.pnl2Show.Controls.Add(this.label1);
            this.pnl2Show.Controls.Add(this.cpColor);
            this.pnl2Show.Controls.Add(this.cbxDraw);
            this.pnl2Show.Controls.Add(this.chxShow);
            this.pnl2Show.Controls.Add(this.label9);
            this.pnl2Show.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnl2Show.FillColor = System.Drawing.Color.White;
            this.pnl2Show.FillDisableColor = System.Drawing.Color.White;
            this.pnl2Show.Font = new System.Drawing.Font("华文新魏", 12F);
            this.pnl2Show.ForeColor = System.Drawing.Color.White;
            this.pnl2Show.Location = new System.Drawing.Point(0, 0);
            this.pnl2Show.Margin = new System.Windows.Forms.Padding(0);
            this.pnl2Show.MinimumSize = new System.Drawing.Size(1, 1);
            this.pnl2Show.Name = "pnl2Show";
            this.pnl2Show.Padding = new System.Windows.Forms.Padding(0, 35, 0, 0);
            this.pnl2Show.RadiusSides = Rex.UI.UICornerRadiusSides.None;
            this.pnl2Show.RectColor = System.Drawing.Color.White;
            this.pnl2Show.Size = new System.Drawing.Size(303, 179);
            this.pnl2Show.Style = Rex.UI.UIStyle.Custom;
            this.pnl2Show.TabIndex = 193;
            this.pnl2Show.Text = "显示设置";
            this.pnl2Show.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.pnl2Show.TitleColor = System.Drawing.Color.CornflowerBlue;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("华文新魏", 11F);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.label1.Location = new System.Drawing.Point(13, 104);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 16);
            this.label1.TabIndex = 195;
            this.label1.Text = "颜色:";
            // 
            // cpColor
            // 
            this.cpColor.DropDownStyle = Rex.UI.UIDropDownStyle.DropDownList;
            this.cpColor.FillColor = System.Drawing.Color.AliceBlue;
            this.cpColor.FillDisableColor = System.Drawing.Color.AliceBlue;
            this.cpColor.Font = new System.Drawing.Font("微软雅黑", 9F);
            this.cpColor.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.cpColor.Location = new System.Drawing.Point(57, 99);
            this.cpColor.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cpColor.MinimumSize = new System.Drawing.Size(63, 0);
            this.cpColor.Name = "cpColor";
            this.cpColor.Padding = new System.Windows.Forms.Padding(0, 0, 30, 0);
            this.cpColor.RadiusSides = Rex.UI.UICornerRadiusSides.None;
            this.cpColor.RectColor = System.Drawing.Color.White;
            this.cpColor.RectSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.Bottom;
            this.cpColor.Size = new System.Drawing.Size(230, 23);
            this.cpColor.Style = Rex.UI.UIStyle.Custom;
            this.cpColor.StyleCustomMode = true;
            this.cpColor.TabIndex = 194;
            this.cpColor.Text = "uiColorPicker1";
            this.cpColor.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.cpColor.Value = System.Drawing.Color.MediumPurple;
            // 
            // cbxDraw
            // 
            this.cbxDraw.BackColor = System.Drawing.Color.AliceBlue;
            this.cbxDraw.DropDownStyle = Rex.UI.UIDropDownStyle.DropDownList;
            this.cbxDraw.FillColor = System.Drawing.Color.AliceBlue;
            this.cbxDraw.Font = new System.Drawing.Font("华文新魏", 11.6F);
            this.cbxDraw.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.cbxDraw.ForeDisableColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.cbxDraw.Items.AddRange(new object[] {
            "margin",
            "fill"});
            this.cbxDraw.Location = new System.Drawing.Point(57, 66);
            this.cbxDraw.Margin = new System.Windows.Forms.Padding(0);
            this.cbxDraw.MinimumSize = new System.Drawing.Size(63, 0);
            this.cbxDraw.Name = "cbxDraw";
            this.cbxDraw.Padding = new System.Windows.Forms.Padding(0, 0, 30, 0);
            this.cbxDraw.Radius = 2;
            this.cbxDraw.RectColor = System.Drawing.Color.CornflowerBlue;
            this.cbxDraw.RectDisableColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.cbxDraw.RectSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.None;
            this.cbxDraw.Size = new System.Drawing.Size(230, 24);
            this.cbxDraw.Style = Rex.UI.UIStyle.Custom;
            this.cbxDraw.StyleCustomMode = true;
            this.cbxDraw.SymbolDropDown = 61656;
            this.cbxDraw.SymbolNormal = 61655;
            this.cbxDraw.TabIndex = 232;
            this.cbxDraw.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.cbxDraw.SelectedIndexChanged += new System.EventHandler(this.cbxDraw_SelectedIndexChanged);
            // 
            // chxShow
            // 
            this.chxShow.Checked = true;
            this.chxShow.Cursor = System.Windows.Forms.Cursors.Hand;
            this.chxShow.Font = new System.Drawing.Font("华文新魏", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.chxShow.Location = new System.Drawing.Point(13, 38);
            this.chxShow.MinimumSize = new System.Drawing.Size(1, 1);
            this.chxShow.Name = "chxShow";
            this.chxShow.Padding = new System.Windows.Forms.Padding(22, 0, 0, 0);
            this.chxShow.Size = new System.Drawing.Size(108, 21);
            this.chxShow.Style = Rex.UI.UIStyle.Custom;
            this.chxShow.TabIndex = 189;
            this.chxShow.Text = "显示";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("华文新魏", 11F);
            this.label9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.label9.Location = new System.Drawing.Point(13, 71);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(43, 16);
            this.label9.TabIndex = 231;
            this.label9.Text = "形态:";
            // 
            // ProcessRegForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(848, 548);
            this.Name = "ProcessRegForm";
            this.Load += new System.EventHandler(this.ConnectRegForm_Load);
            this.panel_bottom.ResumeLayout(false);
            this.panel_center.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbox_Icon)).EndInit();
            this.titlepanel.ResumeLayout(false);
            this.titlepanel.PerformLayout();
            this.uiTabControl1.ResumeLayout(false);
            this.tabPage3.ResumeLayout(false);
            this.pnlCustomParams.ResumeLayout(false);
            this.pnlCustomParams.PerformLayout();
            this.pnlCirCleParams.ResumeLayout(false);
            this.pnlCirCleParams.PerformLayout();
            this.pnlRect1Params.ResumeLayout(false);
            this.pnlRect1Params.PerformLayout();
            this.pnlDynThreshold.ResumeLayout(false);
            this.pnlDynThreshold.PerformLayout();
            this.pnlImageInfo.ResumeLayout(false);
            this.pnlImageInfo.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.pnl2Show.ResumeLayout(false);
            this.pnl2Show.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private RexView.HWindow_HE mWindowH;
        private Rex.UI.UITabControl uiTabControl1;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TabPage tabPage2;
        private Rex.UI.UITitlePanel pnl2Show;
        private Rex.UI.UICheckBox chxShow;
        private Rex.UI.UITitlePanel pnlImageInfo;
        private RexControl.MyControls.MyLinkData ldImage;
        private System.Windows.Forms.Label label12;
        private Rex.UI.UITitlePanel pnlDynThreshold;
        private RexControl.MyControls.MyLinkData ldRegion;
        private System.Windows.Forms.Label label4;
        private Rex.UI.MyComboBox cbxDraw;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label1;
        private Rex.UI.UIColorPicker cpColor;
        private Rex.UI.UITitlePanel pnlRect1Params;
        private Rex.UI.MyComboBox cbxMode;
        private System.Windows.Forms.Label label18;
        private RexControl.MyControls.MyTextBoxUpDownD tbxHeight;
        private RexControl.MyControls.MyTextBoxUpDownD tbxWidth;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private Rex.UI.MyComboBox cbxShape;
        private System.Windows.Forms.Label label2;
        private Rex.UI.UITitlePanel pnlCustomParams;
        private RexControl.MyControls.MyLinkData ldElement;
        private System.Windows.Forms.Label label5;
        private Rex.UI.UITitlePanel pnlCirCleParams;
        private RexControl.MyControls.MyTextBoxUpDownD tbxRadius;
        private System.Windows.Forms.Label label3;
    }
}