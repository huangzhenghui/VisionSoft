
namespace Plugin.CreateModel
{
    partial class CreateModelForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CreateModelForm));
            this.uiTabControl1 = new Rex.UI.UITabControl();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.pnl2ModelInfo = new Rex.UI.UITitlePanel();
            this.cbxPrecision = new Rex.UI.MyComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.ldModContour = new RexControl.MyControls.MyLinkData();
            this.label6 = new System.Windows.Forms.Label();
            this.pnl1ModelInfo = new Rex.UI.UITitlePanel();
            this.ldModRegion = new RexControl.MyControls.MyLinkData();
            this.label10 = new System.Windows.Forms.Label();
            this.uiTitlePanel4 = new Rex.UI.UITitlePanel();
            this.cbxFactor = new Rex.UI.MyComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.uiTitlePanel1 = new Rex.UI.UITitlePanel();
            this.ldImage = new RexControl.MyControls.MyLinkData();
            this.label11 = new System.Windows.Forms.Label();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.pnl2Params = new Rex.UI.UITitlePanel();
            this.cbx2Contrast = new Rex.UI.MyComboBox();
            this.lbl2Contrast = new System.Windows.Forms.Label();
            this.tbx2MinContrast = new RexControl.MyControls.MyTextBoxUpDown();
            this.label22 = new System.Windows.Forms.Label();
            this.cbx2Optimization = new Rex.UI.MyComboBox();
            this.label21 = new System.Windows.Forms.Label();
            this.tbx2ScaleStep = new RexControl.MyControls.MyTextBoxUpDownD();
            this.label20 = new System.Windows.Forms.Label();
            this.tbx2ScaleMax = new RexControl.MyControls.MyTextBoxUpDownD();
            this.label19 = new System.Windows.Forms.Label();
            this.tbx2ScaleMin = new RexControl.MyControls.MyTextBoxUpDownD();
            this.label17 = new System.Windows.Forms.Label();
            this.cbx2Metric = new Rex.UI.MyComboBox();
            this.tbx2AngleStep = new RexControl.MyControls.MyTextBoxUpDownD();
            this.tbx2AngleExtent = new RexControl.MyControls.MyTextBoxUpDownD();
            this.tbx2AngleStart = new RexControl.MyControls.MyTextBoxUpDownD();
            this.cbx2NumLevels = new Rex.UI.MyComboBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.pnl1Params = new Rex.UI.UITitlePanel();
            this.cbx1Metric = new Rex.UI.MyComboBox();
            this.tbx1AngleStep = new RexControl.MyControls.MyTextBoxUpDownD();
            this.tbx1AngleExtent = new RexControl.MyControls.MyTextBoxUpDownD();
            this.tbx1AngleStart = new RexControl.MyControls.MyTextBoxUpDownD();
            this.cbx1NumLevels = new Rex.UI.MyComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.uiTitlePanel5 = new Rex.UI.UITitlePanel();
            this.label25 = new System.Windows.Forms.Label();
            this.cpModel = new Rex.UI.UIColorPicker();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.uiTitlePanel8 = new Rex.UI.UITitlePanel();
            this.tbxModelName = new Rex.UI.UITextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.tbxModelPath = new RexControl.MyControls.TextBoxEx();
            this.btnModelPath = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.mWindowH = new RexView.HWindow_HE();
            this.panel_bottom.SuspendLayout();
            this.panel_center.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbox_Icon)).BeginInit();
            this.titlepanel.SuspendLayout();
            this.uiTabControl1.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.pnl2ModelInfo.SuspendLayout();
            this.pnl1ModelInfo.SuspendLayout();
            this.uiTitlePanel4.SuspendLayout();
            this.uiTitlePanel1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.pnl2Params.SuspendLayout();
            this.pnl1Params.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.uiTitlePanel5.SuspendLayout();
            this.tabPage4.SuspendLayout();
            this.uiTitlePanel8.SuspendLayout();
            this.tableLayoutPanel4.SuspendLayout();
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
            this.uiTabControl1.Controls.Add(this.tabPage1);
            this.uiTabControl1.Controls.Add(this.tabPage2);
            this.uiTabControl1.Controls.Add(this.tabPage4);
            this.uiTabControl1.Dock = System.Windows.Forms.DockStyle.Left;
            this.uiTabControl1.DrawMode = System.Windows.Forms.TabDrawMode.OwnerDrawFixed;
            this.uiTabControl1.Font = new System.Drawing.Font("华文新魏", 12F);
            this.uiTabControl1.ItemSize = new System.Drawing.Size(85, 26);
            this.uiTabControl1.Location = new System.Drawing.Point(2, 1);
            this.uiTabControl1.MenuStyle = Rex.UI.UIMenuStyle.Custom;
            this.uiTabControl1.Name = "uiTabControl1";
            this.uiTabControl1.SelectedIndex = 0;
            this.uiTabControl1.Size = new System.Drawing.Size(303, 487);
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
            this.tabPage3.Controls.Add(this.pnl2ModelInfo);
            this.tabPage3.Controls.Add(this.pnl1ModelInfo);
            this.tabPage3.Controls.Add(this.uiTitlePanel4);
            this.tabPage3.Controls.Add(this.uiTitlePanel1);
            this.tabPage3.Font = new System.Drawing.Font("隶书", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tabPage3.Location = new System.Drawing.Point(0, 26);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(303, 461);
            this.tabPage3.TabIndex = 0;
            this.tabPage3.Text = "基本设置1";
            // 
            // pnl2ModelInfo
            // 
            this.pnl2ModelInfo.Controls.Add(this.cbxPrecision);
            this.pnl2ModelInfo.Controls.Add(this.label9);
            this.pnl2ModelInfo.Controls.Add(this.ldModContour);
            this.pnl2ModelInfo.Controls.Add(this.label6);
            this.pnl2ModelInfo.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnl2ModelInfo.FillColor = System.Drawing.Color.White;
            this.pnl2ModelInfo.Font = new System.Drawing.Font("华文新魏", 12F);
            this.pnl2ModelInfo.ForeColor = System.Drawing.Color.White;
            this.pnl2ModelInfo.Location = new System.Drawing.Point(0, 249);
            this.pnl2ModelInfo.Margin = new System.Windows.Forms.Padding(0);
            this.pnl2ModelInfo.MinimumSize = new System.Drawing.Size(1, 1);
            this.pnl2ModelInfo.Name = "pnl2ModelInfo";
            this.pnl2ModelInfo.Padding = new System.Windows.Forms.Padding(3, 25, 3, 0);
            this.pnl2ModelInfo.RadiusSides = Rex.UI.UICornerRadiusSides.None;
            this.pnl2ModelInfo.RectColor = System.Drawing.Color.White;
            this.pnl2ModelInfo.Size = new System.Drawing.Size(303, 121);
            this.pnl2ModelInfo.Style = Rex.UI.UIStyle.Custom;
            this.pnl2ModelInfo.TabIndex = 200;
            this.pnl2ModelInfo.Text = "模板信息";
            this.pnl2ModelInfo.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.pnl2ModelInfo.TextAlignment = System.Drawing.ContentAlignment.BottomCenter;
            this.pnl2ModelInfo.TitleColor = System.Drawing.Color.CornflowerBlue;
            this.pnl2ModelInfo.TitleInterval = 5;
            // 
            // cbxPrecision
            // 
            this.cbxPrecision.BackColor = System.Drawing.Color.AliceBlue;
            this.cbxPrecision.DropDownStyle = Rex.UI.UIDropDownStyle.DropDownList;
            this.cbxPrecision.FillColor = System.Drawing.Color.AliceBlue;
            this.cbxPrecision.Font = new System.Drawing.Font("华文新魏", 11.6F);
            this.cbxPrecision.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.cbxPrecision.ForeDisableColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.cbxPrecision.Items.AddRange(new object[] {
            "像素",
            "亚像素"});
            this.cbxPrecision.Location = new System.Drawing.Point(83, 78);
            this.cbxPrecision.Margin = new System.Windows.Forms.Padding(0);
            this.cbxPrecision.MinimumSize = new System.Drawing.Size(63, 0);
            this.cbxPrecision.Name = "cbxPrecision";
            this.cbxPrecision.Padding = new System.Windows.Forms.Padding(0, 0, 30, 0);
            this.cbxPrecision.Radius = 2;
            this.cbxPrecision.RectColor = System.Drawing.Color.CornflowerBlue;
            this.cbxPrecision.RectDisableColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.cbxPrecision.RectSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.None;
            this.cbxPrecision.Size = new System.Drawing.Size(210, 24);
            this.cbxPrecision.Style = Rex.UI.UIStyle.Custom;
            this.cbxPrecision.StyleCustomMode = true;
            this.cbxPrecision.SymbolDropDown = 61656;
            this.cbxPrecision.SymbolNormal = 61655;
            this.cbxPrecision.TabIndex = 227;
            this.cbxPrecision.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.cbxPrecision.SelectedIndexChanged += new System.EventHandler(this.cbxPrecision_SelectedIndexChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("华文新魏", 11F);
            this.label9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.label9.Location = new System.Drawing.Point(10, 83);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(73, 16);
            this.label9.TabIndex = 197;
            this.label9.Text = "轮廓精度:";
            // 
            // ldModContour
            // 
            this.ldModContour.BackColor = System.Drawing.Color.AliceBlue;
            this.ldModContour.Font = new System.Drawing.Font("华文新魏", 12F);
            this.ldModContour.FontStyle = new System.Drawing.Font("华文新魏", 10.5F);
            this.ldModContour.Location = new System.Drawing.Point(83, 42);
            this.ldModContour.Margin = new System.Windows.Forms.Padding(4, 5, 4, 4);
            this.ldModContour.Name = "ldModContour";
            this.ldModContour.Size = new System.Drawing.Size(210, 24);
            this.ldModContour.TabIndex = 196;
            this.ldModContour.TextInfo = "";
            this.ldModContour.LinkData += new System.EventHandler(this.ldData_LinkData);
            this.ldModContour.RealTimeExe += new System.EventHandler(this.ldData_RealTimeExe);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("华文新魏", 11F);
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.label6.Location = new System.Drawing.Point(10, 47);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(73, 16);
            this.label6.TabIndex = 191;
            this.label6.Text = "模板轮廓:";
            // 
            // pnl1ModelInfo
            // 
            this.pnl1ModelInfo.Controls.Add(this.ldModRegion);
            this.pnl1ModelInfo.Controls.Add(this.label10);
            this.pnl1ModelInfo.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnl1ModelInfo.FillColor = System.Drawing.Color.White;
            this.pnl1ModelInfo.Font = new System.Drawing.Font("华文新魏", 12F);
            this.pnl1ModelInfo.ForeColor = System.Drawing.Color.White;
            this.pnl1ModelInfo.Location = new System.Drawing.Point(0, 166);
            this.pnl1ModelInfo.Margin = new System.Windows.Forms.Padding(0);
            this.pnl1ModelInfo.MinimumSize = new System.Drawing.Size(1, 1);
            this.pnl1ModelInfo.Name = "pnl1ModelInfo";
            this.pnl1ModelInfo.Padding = new System.Windows.Forms.Padding(3, 25, 3, 0);
            this.pnl1ModelInfo.RadiusSides = Rex.UI.UICornerRadiusSides.None;
            this.pnl1ModelInfo.RectColor = System.Drawing.Color.White;
            this.pnl1ModelInfo.Size = new System.Drawing.Size(303, 83);
            this.pnl1ModelInfo.Style = Rex.UI.UIStyle.Custom;
            this.pnl1ModelInfo.TabIndex = 199;
            this.pnl1ModelInfo.Text = "模板信息";
            this.pnl1ModelInfo.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.pnl1ModelInfo.TextAlignment = System.Drawing.ContentAlignment.BottomCenter;
            this.pnl1ModelInfo.TitleColor = System.Drawing.Color.CornflowerBlue;
            this.pnl1ModelInfo.TitleInterval = 5;
            // 
            // ldModRegion
            // 
            this.ldModRegion.BackColor = System.Drawing.Color.AliceBlue;
            this.ldModRegion.Font = new System.Drawing.Font("华文新魏", 12F);
            this.ldModRegion.FontStyle = new System.Drawing.Font("华文新魏", 10.5F);
            this.ldModRegion.Location = new System.Drawing.Point(83, 42);
            this.ldModRegion.Margin = new System.Windows.Forms.Padding(4, 5, 4, 4);
            this.ldModRegion.Name = "ldModRegion";
            this.ldModRegion.Size = new System.Drawing.Size(210, 24);
            this.ldModRegion.TabIndex = 196;
            this.ldModRegion.TextInfo = "";
            this.ldModRegion.LinkData += new System.EventHandler(this.ldData_LinkData);
            this.ldModRegion.RealTimeExe += new System.EventHandler(this.ldData_RealTimeExe);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.Font = new System.Drawing.Font("华文新魏", 11F);
            this.label10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.label10.Location = new System.Drawing.Point(10, 47);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(73, 16);
            this.label10.TabIndex = 191;
            this.label10.Text = "模板区域:";
            // 
            // uiTitlePanel4
            // 
            this.uiTitlePanel4.Controls.Add(this.cbxFactor);
            this.uiTitlePanel4.Controls.Add(this.label8);
            this.uiTitlePanel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.uiTitlePanel4.FillColor = System.Drawing.Color.White;
            this.uiTitlePanel4.Font = new System.Drawing.Font("华文新魏", 12F);
            this.uiTitlePanel4.ForeColor = System.Drawing.Color.White;
            this.uiTitlePanel4.Location = new System.Drawing.Point(0, 83);
            this.uiTitlePanel4.Margin = new System.Windows.Forms.Padding(0);
            this.uiTitlePanel4.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiTitlePanel4.Name = "uiTitlePanel4";
            this.uiTitlePanel4.Padding = new System.Windows.Forms.Padding(3, 25, 3, 0);
            this.uiTitlePanel4.RadiusSides = Rex.UI.UICornerRadiusSides.None;
            this.uiTitlePanel4.RectColor = System.Drawing.Color.White;
            this.uiTitlePanel4.Size = new System.Drawing.Size(303, 83);
            this.uiTitlePanel4.Style = Rex.UI.UIStyle.Custom;
            this.uiTitlePanel4.TabIndex = 197;
            this.uiTitlePanel4.Text = "模板因素";
            this.uiTitlePanel4.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.uiTitlePanel4.TextAlignment = System.Drawing.ContentAlignment.BottomCenter;
            this.uiTitlePanel4.TitleColor = System.Drawing.Color.CornflowerBlue;
            this.uiTitlePanel4.TitleInterval = 5;
            // 
            // cbxFactor
            // 
            this.cbxFactor.BackColor = System.Drawing.Color.AliceBlue;
            this.cbxFactor.DropDownStyle = Rex.UI.UIDropDownStyle.DropDownList;
            this.cbxFactor.FillColor = System.Drawing.Color.AliceBlue;
            this.cbxFactor.Font = new System.Drawing.Font("华文新魏", 11.6F);
            this.cbxFactor.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.cbxFactor.ForeDisableColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.cbxFactor.Items.AddRange(new object[] {
            "相关性",
            "形状"});
            this.cbxFactor.Location = new System.Drawing.Point(83, 42);
            this.cbxFactor.Margin = new System.Windows.Forms.Padding(0);
            this.cbxFactor.MinimumSize = new System.Drawing.Size(63, 0);
            this.cbxFactor.Name = "cbxFactor";
            this.cbxFactor.Padding = new System.Windows.Forms.Padding(0, 0, 30, 0);
            this.cbxFactor.Radius = 2;
            this.cbxFactor.RectColor = System.Drawing.Color.CornflowerBlue;
            this.cbxFactor.RectDisableColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.cbxFactor.RectSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.None;
            this.cbxFactor.Size = new System.Drawing.Size(210, 24);
            this.cbxFactor.Style = Rex.UI.UIStyle.Custom;
            this.cbxFactor.StyleCustomMode = true;
            this.cbxFactor.SymbolDropDown = 61656;
            this.cbxFactor.SymbolNormal = 61655;
            this.cbxFactor.TabIndex = 226;
            this.cbxFactor.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.cbxFactor.SelectedIndexChanged += new System.EventHandler(this.cbxSelect_SelectedIndexChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("华文新魏", 11F);
            this.label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.label8.Location = new System.Drawing.Point(10, 47);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(73, 16);
            this.label8.TabIndex = 191;
            this.label8.Text = "模板因素:";
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
            this.ldImage.FontStyle = new System.Drawing.Font("华文新魏", 10.5F);
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
            this.label11.Location = new System.Drawing.Point(10, 47);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(73, 16);
            this.label11.TabIndex = 191;
            this.label11.Text = "输入图像:";
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.White;
            this.tabPage1.Controls.Add(this.pnl2Params);
            this.tabPage1.Controls.Add(this.pnl1Params);
            this.tabPage1.Location = new System.Drawing.Point(0, 26);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Size = new System.Drawing.Size(303, 461);
            this.tabPage1.TabIndex = 2;
            this.tabPage1.Text = "基本设置2";
            // 
            // pnl2Params
            // 
            this.pnl2Params.Controls.Add(this.cbx2Contrast);
            this.pnl2Params.Controls.Add(this.lbl2Contrast);
            this.pnl2Params.Controls.Add(this.tbx2MinContrast);
            this.pnl2Params.Controls.Add(this.label22);
            this.pnl2Params.Controls.Add(this.cbx2Optimization);
            this.pnl2Params.Controls.Add(this.label21);
            this.pnl2Params.Controls.Add(this.tbx2ScaleStep);
            this.pnl2Params.Controls.Add(this.label20);
            this.pnl2Params.Controls.Add(this.tbx2ScaleMax);
            this.pnl2Params.Controls.Add(this.label19);
            this.pnl2Params.Controls.Add(this.tbx2ScaleMin);
            this.pnl2Params.Controls.Add(this.label17);
            this.pnl2Params.Controls.Add(this.cbx2Metric);
            this.pnl2Params.Controls.Add(this.tbx2AngleStep);
            this.pnl2Params.Controls.Add(this.tbx2AngleExtent);
            this.pnl2Params.Controls.Add(this.tbx2AngleStart);
            this.pnl2Params.Controls.Add(this.cbx2NumLevels);
            this.pnl2Params.Controls.Add(this.label12);
            this.pnl2Params.Controls.Add(this.label13);
            this.pnl2Params.Controls.Add(this.label14);
            this.pnl2Params.Controls.Add(this.label15);
            this.pnl2Params.Controls.Add(this.label16);
            this.pnl2Params.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnl2Params.FillColor = System.Drawing.Color.White;
            this.pnl2Params.Font = new System.Drawing.Font("华文新魏", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.pnl2Params.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            this.pnl2Params.Location = new System.Drawing.Point(0, 236);
            this.pnl2Params.Margin = new System.Windows.Forms.Padding(0);
            this.pnl2Params.MinimumSize = new System.Drawing.Size(1, 1);
            this.pnl2Params.Name = "pnl2Params";
            this.pnl2Params.Padding = new System.Windows.Forms.Padding(0, 30, 0, 0);
            this.pnl2Params.RadiusSides = Rex.UI.UICornerRadiusSides.None;
            this.pnl2Params.RectColor = System.Drawing.Color.White;
            this.pnl2Params.Size = new System.Drawing.Size(303, 457);
            this.pnl2Params.Style = Rex.UI.UIStyle.Custom;
            this.pnl2Params.TabIndex = 46;
            this.pnl2Params.Text = "参数设置";
            this.pnl2Params.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.pnl2Params.TextAlignment = System.Drawing.ContentAlignment.MiddleRight;
            this.pnl2Params.TitleColor = System.Drawing.Color.CornflowerBlue;
            this.pnl2Params.TitleInterval = 5;
            // 
            // cbx2Contrast
            // 
            this.cbx2Contrast.BackColor = System.Drawing.Color.AliceBlue;
            this.cbx2Contrast.DropDownStyle = Rex.UI.UIDropDownStyle.DropDownList;
            this.cbx2Contrast.FillColor = System.Drawing.Color.AliceBlue;
            this.cbx2Contrast.Font = new System.Drawing.Font("华文新魏", 11.6F);
            this.cbx2Contrast.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.cbx2Contrast.ForeDisableColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.cbx2Contrast.Items.AddRange(new object[] {
            "auto",
            "auto_contrast",
            "auto_contrast_hyst",
            "auto_min_size",
            "5",
            "10",
            "15",
            "20",
            "25",
            "30",
            "35",
            "40",
            "45",
            "50",
            "55",
            "60",
            "65",
            "70",
            "75",
            "80",
            "85",
            "90",
            "95",
            "100",
            "110",
            "120",
            "130",
            "140",
            "150",
            "160"});
            this.cbx2Contrast.Location = new System.Drawing.Point(83, 395);
            this.cbx2Contrast.Margin = new System.Windows.Forms.Padding(0);
            this.cbx2Contrast.MinimumSize = new System.Drawing.Size(63, 0);
            this.cbx2Contrast.Name = "cbx2Contrast";
            this.cbx2Contrast.Padding = new System.Windows.Forms.Padding(0, 0, 30, 0);
            this.cbx2Contrast.Radius = 2;
            this.cbx2Contrast.RectColor = System.Drawing.Color.CornflowerBlue;
            this.cbx2Contrast.RectDisableColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.cbx2Contrast.RectSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.None;
            this.cbx2Contrast.Size = new System.Drawing.Size(210, 24);
            this.cbx2Contrast.Style = Rex.UI.UIStyle.Custom;
            this.cbx2Contrast.StyleCustomMode = true;
            this.cbx2Contrast.SymbolDropDown = 61656;
            this.cbx2Contrast.SymbolNormal = 61655;
            this.cbx2Contrast.TabIndex = 238;
            this.cbx2Contrast.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbl2Contrast
            // 
            this.lbl2Contrast.AutoSize = true;
            this.lbl2Contrast.BackColor = System.Drawing.Color.Transparent;
            this.lbl2Contrast.Font = new System.Drawing.Font("华文新魏", 11F);
            this.lbl2Contrast.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.lbl2Contrast.Location = new System.Drawing.Point(10, 401);
            this.lbl2Contrast.Name = "lbl2Contrast";
            this.lbl2Contrast.Size = new System.Drawing.Size(58, 16);
            this.lbl2Contrast.TabIndex = 237;
            this.lbl2Contrast.Text = "对比度:";
            // 
            // tbx2MinContrast
            // 
            this.tbx2MinContrast.BackColor = System.Drawing.Color.White;
            this.tbx2MinContrast.Font = new System.Drawing.Font("华文新魏", 11.2F);
            this.tbx2MinContrast.FontStyle = null;
            this.tbx2MinContrast.Location = new System.Drawing.Point(83, 360);
            this.tbx2MinContrast.Name = "tbx2MinContrast";
            this.tbx2MinContrast.Size = new System.Drawing.Size(210, 25);
            this.tbx2MinContrast.TabIndex = 236;
            this.tbx2MinContrast.TextInfo = "";
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.BackColor = System.Drawing.Color.Transparent;
            this.label22.Font = new System.Drawing.Font("华文新魏", 11F);
            this.label22.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.label22.Location = new System.Drawing.Point(10, 366);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(73, 16);
            this.label22.TabIndex = 235;
            this.label22.Text = "最小对比:";
            // 
            // cbx2Optimization
            // 
            this.cbx2Optimization.BackColor = System.Drawing.Color.AliceBlue;
            this.cbx2Optimization.DropDownStyle = Rex.UI.UIDropDownStyle.DropDownList;
            this.cbx2Optimization.FillColor = System.Drawing.Color.AliceBlue;
            this.cbx2Optimization.Font = new System.Drawing.Font("华文新魏", 11.6F);
            this.cbx2Optimization.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.cbx2Optimization.ForeDisableColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.cbx2Optimization.Items.AddRange(new object[] {
            "auto",
            "no_pregeneration",
            "none",
            "point_reduction_high",
            "point_reduction_low",
            "point_reduction_medium",
            "pregeneration"});
            this.cbx2Optimization.Location = new System.Drawing.Point(83, 292);
            this.cbx2Optimization.Margin = new System.Windows.Forms.Padding(0);
            this.cbx2Optimization.MinimumSize = new System.Drawing.Size(63, 0);
            this.cbx2Optimization.Name = "cbx2Optimization";
            this.cbx2Optimization.Padding = new System.Windows.Forms.Padding(0, 0, 30, 0);
            this.cbx2Optimization.Radius = 2;
            this.cbx2Optimization.RectColor = System.Drawing.Color.CornflowerBlue;
            this.cbx2Optimization.RectDisableColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.cbx2Optimization.RectSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.None;
            this.cbx2Optimization.Size = new System.Drawing.Size(210, 24);
            this.cbx2Optimization.Style = Rex.UI.UIStyle.Custom;
            this.cbx2Optimization.StyleCustomMode = true;
            this.cbx2Optimization.SymbolDropDown = 61656;
            this.cbx2Optimization.SymbolNormal = 61655;
            this.cbx2Optimization.TabIndex = 217;
            this.cbx2Optimization.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.BackColor = System.Drawing.Color.Transparent;
            this.label21.Font = new System.Drawing.Font("华文新魏", 11F);
            this.label21.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.label21.Location = new System.Drawing.Point(10, 296);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(73, 16);
            this.label21.TabIndex = 218;
            this.label21.Text = "优化方法:";
            // 
            // tbx2ScaleStep
            // 
            this.tbx2ScaleStep.Font = new System.Drawing.Font("华文新魏", 11F);
            this.tbx2ScaleStep.FontStyle = null;
            this.tbx2ScaleStep.Location = new System.Drawing.Point(83, 254);
            this.tbx2ScaleStep.Name = "tbx2ScaleStep";
            this.tbx2ScaleStep.Size = new System.Drawing.Size(210, 26);
            this.tbx2ScaleStep.TabIndex = 232;
            this.tbx2ScaleStep.TextInfo = "";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.BackColor = System.Drawing.Color.Transparent;
            this.label20.Font = new System.Drawing.Font("华文新魏", 11F);
            this.label20.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.label20.Location = new System.Drawing.Point(10, 261);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(73, 16);
            this.label20.TabIndex = 231;
            this.label20.Text = "缩放步长:";
            // 
            // tbx2ScaleMax
            // 
            this.tbx2ScaleMax.Font = new System.Drawing.Font("华文新魏", 11F);
            this.tbx2ScaleMax.FontStyle = null;
            this.tbx2ScaleMax.Location = new System.Drawing.Point(83, 220);
            this.tbx2ScaleMax.Name = "tbx2ScaleMax";
            this.tbx2ScaleMax.Size = new System.Drawing.Size(210, 26);
            this.tbx2ScaleMax.TabIndex = 230;
            this.tbx2ScaleMax.TextInfo = "";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.BackColor = System.Drawing.Color.Transparent;
            this.label19.Font = new System.Drawing.Font("华文新魏", 11F);
            this.label19.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.label19.Location = new System.Drawing.Point(10, 226);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(73, 16);
            this.label19.TabIndex = 229;
            this.label19.Text = "最大缩放:";
            // 
            // tbx2ScaleMin
            // 
            this.tbx2ScaleMin.Font = new System.Drawing.Font("华文新魏", 11F);
            this.tbx2ScaleMin.FontStyle = null;
            this.tbx2ScaleMin.Location = new System.Drawing.Point(83, 184);
            this.tbx2ScaleMin.Name = "tbx2ScaleMin";
            this.tbx2ScaleMin.Size = new System.Drawing.Size(210, 26);
            this.tbx2ScaleMin.TabIndex = 228;
            this.tbx2ScaleMin.TextInfo = "";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.BackColor = System.Drawing.Color.Transparent;
            this.label17.Font = new System.Drawing.Font("华文新魏", 11F);
            this.label17.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.label17.Location = new System.Drawing.Point(10, 191);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(73, 16);
            this.label17.TabIndex = 227;
            this.label17.Text = "最小缩放:";
            // 
            // cbx2Metric
            // 
            this.cbx2Metric.BackColor = System.Drawing.Color.AliceBlue;
            this.cbx2Metric.DropDownStyle = Rex.UI.UIDropDownStyle.DropDownList;
            this.cbx2Metric.FillColor = System.Drawing.Color.AliceBlue;
            this.cbx2Metric.Font = new System.Drawing.Font("华文新魏", 11.6F);
            this.cbx2Metric.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.cbx2Metric.ForeDisableColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.cbx2Metric.Items.AddRange(new object[] {
            "ignore_global_polarity",
            "use_polarity"});
            this.cbx2Metric.Location = new System.Drawing.Point(83, 325);
            this.cbx2Metric.Margin = new System.Windows.Forms.Padding(0);
            this.cbx2Metric.MinimumSize = new System.Drawing.Size(63, 0);
            this.cbx2Metric.Name = "cbx2Metric";
            this.cbx2Metric.Padding = new System.Windows.Forms.Padding(0, 0, 30, 0);
            this.cbx2Metric.Radius = 2;
            this.cbx2Metric.RectColor = System.Drawing.Color.CornflowerBlue;
            this.cbx2Metric.RectDisableColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.cbx2Metric.RectSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.None;
            this.cbx2Metric.Size = new System.Drawing.Size(210, 24);
            this.cbx2Metric.Style = Rex.UI.UIStyle.Custom;
            this.cbx2Metric.StyleCustomMode = true;
            this.cbx2Metric.SymbolDropDown = 61656;
            this.cbx2Metric.SymbolNormal = 61655;
            this.cbx2Metric.TabIndex = 206;
            this.cbx2Metric.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // tbx2AngleStep
            // 
            this.tbx2AngleStep.Font = new System.Drawing.Font("华文新魏", 11F);
            this.tbx2AngleStep.FontStyle = null;
            this.tbx2AngleStep.Location = new System.Drawing.Point(83, 150);
            this.tbx2AngleStep.Name = "tbx2AngleStep";
            this.tbx2AngleStep.Size = new System.Drawing.Size(210, 26);
            this.tbx2AngleStep.TabIndex = 226;
            this.tbx2AngleStep.TextInfo = "";
            // 
            // tbx2AngleExtent
            // 
            this.tbx2AngleExtent.Font = new System.Drawing.Font("华文新魏", 11F);
            this.tbx2AngleExtent.FontStyle = null;
            this.tbx2AngleExtent.Location = new System.Drawing.Point(83, 115);
            this.tbx2AngleExtent.Name = "tbx2AngleExtent";
            this.tbx2AngleExtent.Size = new System.Drawing.Size(210, 26);
            this.tbx2AngleExtent.TabIndex = 225;
            this.tbx2AngleExtent.TextInfo = "";
            // 
            // tbx2AngleStart
            // 
            this.tbx2AngleStart.Font = new System.Drawing.Font("华文新魏", 11F);
            this.tbx2AngleStart.FontStyle = null;
            this.tbx2AngleStart.Location = new System.Drawing.Point(83, 80);
            this.tbx2AngleStart.Name = "tbx2AngleStart";
            this.tbx2AngleStart.Size = new System.Drawing.Size(210, 26);
            this.tbx2AngleStart.TabIndex = 224;
            this.tbx2AngleStart.TextInfo = "";
            // 
            // cbx2NumLevels
            // 
            this.cbx2NumLevels.BackColor = System.Drawing.Color.AliceBlue;
            this.cbx2NumLevels.DropDownStyle = Rex.UI.UIDropDownStyle.DropDownList;
            this.cbx2NumLevels.FillColor = System.Drawing.Color.AliceBlue;
            this.cbx2NumLevels.Font = new System.Drawing.Font("华文新魏", 11.6F);
            this.cbx2NumLevels.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.cbx2NumLevels.ForeDisableColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.cbx2NumLevels.Items.AddRange(new object[] {
            "0",
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10"});
            this.cbx2NumLevels.Location = new System.Drawing.Point(83, 46);
            this.cbx2NumLevels.Margin = new System.Windows.Forms.Padding(0);
            this.cbx2NumLevels.MinimumSize = new System.Drawing.Size(63, 0);
            this.cbx2NumLevels.Name = "cbx2NumLevels";
            this.cbx2NumLevels.Padding = new System.Windows.Forms.Padding(0, 0, 30, 0);
            this.cbx2NumLevels.Radius = 2;
            this.cbx2NumLevels.RectColor = System.Drawing.Color.CornflowerBlue;
            this.cbx2NumLevels.RectDisableColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.cbx2NumLevels.RectSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.None;
            this.cbx2NumLevels.Size = new System.Drawing.Size(210, 24);
            this.cbx2NumLevels.Style = Rex.UI.UIStyle.Custom;
            this.cbx2NumLevels.StyleCustomMode = true;
            this.cbx2NumLevels.SymbolDropDown = 61656;
            this.cbx2NumLevels.SymbolNormal = 61655;
            this.cbx2NumLevels.TabIndex = 205;
            this.cbx2NumLevels.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.Color.Transparent;
            this.label12.Font = new System.Drawing.Font("华文新魏", 11F);
            this.label12.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.label12.Location = new System.Drawing.Point(10, 331);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(73, 16);
            this.label12.TabIndex = 216;
            this.label12.Text = "匹配规则:";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.BackColor = System.Drawing.Color.Transparent;
            this.label13.Font = new System.Drawing.Font("华文新魏", 11F);
            this.label13.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.label13.Location = new System.Drawing.Point(10, 156);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(73, 16);
            this.label13.TabIndex = 215;
            this.label13.Text = "角度步长:";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.BackColor = System.Drawing.Color.Transparent;
            this.label14.Font = new System.Drawing.Font("华文新魏", 11F);
            this.label14.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.label14.Location = new System.Drawing.Point(10, 86);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(73, 16);
            this.label14.TabIndex = 206;
            this.label14.Text = "起始角度:";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.BackColor = System.Drawing.Color.Transparent;
            this.label15.Font = new System.Drawing.Font("华文新魏", 11F);
            this.label15.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.label15.Location = new System.Drawing.Point(10, 51);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(73, 16);
            this.label15.TabIndex = 204;
            this.label15.Text = "金字塔层:";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.BackColor = System.Drawing.Color.Transparent;
            this.label16.Font = new System.Drawing.Font("华文新魏", 11F);
            this.label16.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.label16.Location = new System.Drawing.Point(10, 121);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(73, 16);
            this.label16.TabIndex = 208;
            this.label16.Text = "旋转范围:";
            // 
            // pnl1Params
            // 
            this.pnl1Params.Controls.Add(this.cbx1Metric);
            this.pnl1Params.Controls.Add(this.tbx1AngleStep);
            this.pnl1Params.Controls.Add(this.tbx1AngleExtent);
            this.pnl1Params.Controls.Add(this.tbx1AngleStart);
            this.pnl1Params.Controls.Add(this.cbx1NumLevels);
            this.pnl1Params.Controls.Add(this.label4);
            this.pnl1Params.Controls.Add(this.label5);
            this.pnl1Params.Controls.Add(this.label1);
            this.pnl1Params.Controls.Add(this.label18);
            this.pnl1Params.Controls.Add(this.label3);
            this.pnl1Params.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnl1Params.FillColor = System.Drawing.Color.White;
            this.pnl1Params.Font = new System.Drawing.Font("华文新魏", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.pnl1Params.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            this.pnl1Params.Location = new System.Drawing.Point(0, 0);
            this.pnl1Params.Margin = new System.Windows.Forms.Padding(0);
            this.pnl1Params.MinimumSize = new System.Drawing.Size(1, 1);
            this.pnl1Params.Name = "pnl1Params";
            this.pnl1Params.Padding = new System.Windows.Forms.Padding(0, 30, 0, 0);
            this.pnl1Params.RadiusSides = Rex.UI.UICornerRadiusSides.None;
            this.pnl1Params.RectColor = System.Drawing.Color.White;
            this.pnl1Params.Size = new System.Drawing.Size(303, 236);
            this.pnl1Params.Style = Rex.UI.UIStyle.Custom;
            this.pnl1Params.TabIndex = 45;
            this.pnl1Params.Text = "参数设置";
            this.pnl1Params.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.pnl1Params.TextAlignment = System.Drawing.ContentAlignment.MiddleRight;
            this.pnl1Params.TitleColor = System.Drawing.Color.CornflowerBlue;
            this.pnl1Params.TitleInterval = 5;
            // 
            // cbx1Metric
            // 
            this.cbx1Metric.BackColor = System.Drawing.Color.AliceBlue;
            this.cbx1Metric.DropDownStyle = Rex.UI.UIDropDownStyle.DropDownList;
            this.cbx1Metric.FillColor = System.Drawing.Color.AliceBlue;
            this.cbx1Metric.Font = new System.Drawing.Font("华文新魏", 11.6F);
            this.cbx1Metric.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.cbx1Metric.ForeDisableColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.cbx1Metric.Items.AddRange(new object[] {
            "ignore_global_polarity",
            "use_polarity"});
            this.cbx1Metric.Location = new System.Drawing.Point(83, 194);
            this.cbx1Metric.Margin = new System.Windows.Forms.Padding(0);
            this.cbx1Metric.MinimumSize = new System.Drawing.Size(63, 0);
            this.cbx1Metric.Name = "cbx1Metric";
            this.cbx1Metric.Padding = new System.Windows.Forms.Padding(0, 0, 30, 0);
            this.cbx1Metric.Radius = 2;
            this.cbx1Metric.RectColor = System.Drawing.Color.CornflowerBlue;
            this.cbx1Metric.RectDisableColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.cbx1Metric.RectSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.None;
            this.cbx1Metric.Size = new System.Drawing.Size(210, 24);
            this.cbx1Metric.Style = Rex.UI.UIStyle.Custom;
            this.cbx1Metric.StyleCustomMode = true;
            this.cbx1Metric.SymbolDropDown = 61656;
            this.cbx1Metric.SymbolNormal = 61655;
            this.cbx1Metric.TabIndex = 206;
            this.cbx1Metric.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // tbx1AngleStep
            // 
            this.tbx1AngleStep.Font = new System.Drawing.Font("华文新魏", 11F);
            this.tbx1AngleStep.FontStyle = null;
            this.tbx1AngleStep.Location = new System.Drawing.Point(83, 156);
            this.tbx1AngleStep.Name = "tbx1AngleStep";
            this.tbx1AngleStep.Size = new System.Drawing.Size(210, 26);
            this.tbx1AngleStep.TabIndex = 226;
            this.tbx1AngleStep.TextInfo = "";
            // 
            // tbx1AngleExtent
            // 
            this.tbx1AngleExtent.Font = new System.Drawing.Font("华文新魏", 11F);
            this.tbx1AngleExtent.FontStyle = null;
            this.tbx1AngleExtent.Location = new System.Drawing.Point(83, 118);
            this.tbx1AngleExtent.Name = "tbx1AngleExtent";
            this.tbx1AngleExtent.Size = new System.Drawing.Size(210, 26);
            this.tbx1AngleExtent.TabIndex = 225;
            this.tbx1AngleExtent.TextInfo = "";
            // 
            // tbx1AngleStart
            // 
            this.tbx1AngleStart.Font = new System.Drawing.Font("华文新魏", 11F);
            this.tbx1AngleStart.FontStyle = null;
            this.tbx1AngleStart.Location = new System.Drawing.Point(83, 82);
            this.tbx1AngleStart.Name = "tbx1AngleStart";
            this.tbx1AngleStart.Size = new System.Drawing.Size(210, 26);
            this.tbx1AngleStart.TabIndex = 224;
            this.tbx1AngleStart.TextInfo = "";
            // 
            // cbx1NumLevels
            // 
            this.cbx1NumLevels.BackColor = System.Drawing.Color.AliceBlue;
            this.cbx1NumLevels.DropDownStyle = Rex.UI.UIDropDownStyle.DropDownList;
            this.cbx1NumLevels.FillColor = System.Drawing.Color.AliceBlue;
            this.cbx1NumLevels.Font = new System.Drawing.Font("华文新魏", 11.6F);
            this.cbx1NumLevels.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.cbx1NumLevels.ForeDisableColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.cbx1NumLevels.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10"});
            this.cbx1NumLevels.Location = new System.Drawing.Point(83, 46);
            this.cbx1NumLevels.Margin = new System.Windows.Forms.Padding(0);
            this.cbx1NumLevels.MinimumSize = new System.Drawing.Size(63, 0);
            this.cbx1NumLevels.Name = "cbx1NumLevels";
            this.cbx1NumLevels.Padding = new System.Windows.Forms.Padding(0, 0, 30, 0);
            this.cbx1NumLevels.Radius = 2;
            this.cbx1NumLevels.RectColor = System.Drawing.Color.CornflowerBlue;
            this.cbx1NumLevels.RectDisableColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.cbx1NumLevels.RectSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.None;
            this.cbx1NumLevels.Size = new System.Drawing.Size(210, 24);
            this.cbx1NumLevels.Style = Rex.UI.UIStyle.Custom;
            this.cbx1NumLevels.StyleCustomMode = true;
            this.cbx1NumLevels.SymbolDropDown = 61656;
            this.cbx1NumLevels.SymbolNormal = 61655;
            this.cbx1NumLevels.TabIndex = 205;
            this.cbx1NumLevels.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("华文新魏", 11F);
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.label4.Location = new System.Drawing.Point(10, 199);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(73, 16);
            this.label4.TabIndex = 216;
            this.label4.Text = "匹配规则:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("华文新魏", 11F);
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.label5.Location = new System.Drawing.Point(10, 162);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(73, 16);
            this.label5.TabIndex = 215;
            this.label5.Text = "角度步长:";
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
            this.label1.Text = "起始角度:";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.BackColor = System.Drawing.Color.Transparent;
            this.label18.Font = new System.Drawing.Font("华文新魏", 11F);
            this.label18.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.label18.Location = new System.Drawing.Point(10, 51);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(73, 16);
            this.label18.TabIndex = 204;
            this.label18.Text = "金字塔层:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("华文新魏", 11F);
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.label3.Location = new System.Drawing.Point(10, 125);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 16);
            this.label3.TabIndex = 208;
            this.label3.Text = "旋转范围:";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.uiTitlePanel5);
            this.tabPage2.Location = new System.Drawing.Point(0, 26);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Size = new System.Drawing.Size(303, 461);
            this.tabPage2.TabIndex = 3;
            this.tabPage2.Text = "编辑设置";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // uiTitlePanel5
            // 
            this.uiTitlePanel5.Controls.Add(this.label25);
            this.uiTitlePanel5.Controls.Add(this.cpModel);
            this.uiTitlePanel5.Dock = System.Windows.Forms.DockStyle.Top;
            this.uiTitlePanel5.FillColor = System.Drawing.Color.White;
            this.uiTitlePanel5.Font = new System.Drawing.Font("华文新魏", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uiTitlePanel5.ForeColor = System.Drawing.Color.White;
            this.uiTitlePanel5.Location = new System.Drawing.Point(0, 0);
            this.uiTitlePanel5.Margin = new System.Windows.Forms.Padding(0);
            this.uiTitlePanel5.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiTitlePanel5.Name = "uiTitlePanel5";
            this.uiTitlePanel5.Padding = new System.Windows.Forms.Padding(0, 25, 0, 0);
            this.uiTitlePanel5.RadiusSides = Rex.UI.UICornerRadiusSides.None;
            this.uiTitlePanel5.RectColor = System.Drawing.Color.White;
            this.uiTitlePanel5.Size = new System.Drawing.Size(303, 80);
            this.uiTitlePanel5.Style = Rex.UI.UIStyle.Custom;
            this.uiTitlePanel5.TabIndex = 212;
            this.uiTitlePanel5.Text = "编辑设置";
            this.uiTitlePanel5.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.uiTitlePanel5.TitleColor = System.Drawing.Color.CornflowerBlue;
            this.uiTitlePanel5.TitleInterval = 5;
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.BackColor = System.Drawing.Color.Transparent;
            this.label25.Font = new System.Drawing.Font("华文新魏", 11F);
            this.label25.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.label25.Location = new System.Drawing.Point(10, 42);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(73, 16);
            this.label25.TabIndex = 197;
            this.label25.Text = "模板颜色:";
            // 
            // cpModel
            // 
            this.cpModel.DropDownStyle = Rex.UI.UIDropDownStyle.DropDownList;
            this.cpModel.FillColor = System.Drawing.Color.AliceBlue;
            this.cpModel.FillDisableColor = System.Drawing.Color.AliceBlue;
            this.cpModel.Font = new System.Drawing.Font("微软雅黑", 9F);
            this.cpModel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.cpModel.Location = new System.Drawing.Point(88, 38);
            this.cpModel.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cpModel.MinimumSize = new System.Drawing.Size(63, 0);
            this.cpModel.Name = "cpModel";
            this.cpModel.Padding = new System.Windows.Forms.Padding(0, 0, 30, 0);
            this.cpModel.RadiusSides = Rex.UI.UICornerRadiusSides.None;
            this.cpModel.RectColor = System.Drawing.Color.White;
            this.cpModel.RectSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.Bottom;
            this.cpModel.Size = new System.Drawing.Size(203, 23);
            this.cpModel.Style = Rex.UI.UIStyle.Custom;
            this.cpModel.StyleCustomMode = true;
            this.cpModel.TabIndex = 196;
            this.cpModel.Text = "uiColorPicker1";
            this.cpModel.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.cpModel.Value = System.Drawing.Color.MediumAquamarine;
            this.cpModel.ValueChanged += new Rex.UI.UIColorPicker.OnColorChanged(this.cpColor_ValueChanged);
            // 
            // tabPage4
            // 
            this.tabPage4.BackColor = System.Drawing.Color.White;
            this.tabPage4.Controls.Add(this.uiTitlePanel8);
            this.tabPage4.Location = new System.Drawing.Point(0, 26);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Size = new System.Drawing.Size(303, 461);
            this.tabPage4.TabIndex = 1;
            this.tabPage4.Text = "保存设置";
            // 
            // uiTitlePanel8
            // 
            this.uiTitlePanel8.Controls.Add(this.tbxModelName);
            this.uiTitlePanel8.Controls.Add(this.label2);
            this.uiTitlePanel8.Controls.Add(this.tableLayoutPanel4);
            this.uiTitlePanel8.Controls.Add(this.label7);
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
            this.uiTitlePanel8.Size = new System.Drawing.Size(303, 296);
            this.uiTitlePanel8.Style = Rex.UI.UIStyle.Custom;
            this.uiTitlePanel8.TabIndex = 191;
            this.uiTitlePanel8.Text = "保存设置";
            this.uiTitlePanel8.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.uiTitlePanel8.TitleColor = System.Drawing.Color.CornflowerBlue;
            this.uiTitlePanel8.TitleInterval = 5;
            // 
            // tbxModelName
            // 
            this.tbxModelName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbxModelName.FillColor = System.Drawing.Color.AliceBlue;
            this.tbxModelName.FillDisableColor = System.Drawing.Color.AliceBlue;
            this.tbxModelName.Font = new System.Drawing.Font("华文新魏", 11F);
            this.tbxModelName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.tbxModelName.Location = new System.Drawing.Point(86, 44);
            this.tbxModelName.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tbxModelName.Maximum = 2147483647D;
            this.tbxModelName.Minimum = -2147483648D;
            this.tbxModelName.MinimumSize = new System.Drawing.Size(1, 1);
            this.tbxModelName.Name = "tbxModelName";
            this.tbxModelName.Padding = new System.Windows.Forms.Padding(5);
            this.tbxModelName.Radius = 20;
            this.tbxModelName.RadiusSides = Rex.UI.UICornerRadiusSides.None;
            this.tbxModelName.RectColor = System.Drawing.Color.AliceBlue;
            this.tbxModelName.RectSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.Bottom;
            this.tbxModelName.Size = new System.Drawing.Size(200, 23);
            this.tbxModelName.Style = Rex.UI.UIStyle.Custom;
            this.tbxModelName.StyleCustomMode = true;
            this.tbxModelName.TabIndex = 207;
            this.tbxModelName.Watermark = "";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("华文新魏", 11F);
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.label2.Location = new System.Drawing.Point(12, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 16);
            this.label2.TabIndex = 206;
            this.label2.Text = "模板名称:";
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.BackColor = System.Drawing.Color.AliceBlue;
            this.tableLayoutPanel4.ColumnCount = 2;
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 86.76471F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 13.23529F));
            this.tableLayoutPanel4.Controls.Add(this.tbxModelPath, 0, 0);
            this.tableLayoutPanel4.Controls.Add(this.btnModelPath, 1, 0);
            this.tableLayoutPanel4.Location = new System.Drawing.Point(86, 83);
            this.tableLayoutPanel4.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 1;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tableLayoutPanel4.Size = new System.Drawing.Size(200, 25);
            this.tableLayoutPanel4.TabIndex = 202;
            // 
            // tbxModelPath
            // 
            this.tbxModelPath.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbxModelPath.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbxModelPath.Font = new System.Drawing.Font("华文新魏", 10F);
            this.tbxModelPath.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.tbxModelPath.Location = new System.Drawing.Point(3, 3);
            this.tbxModelPath.Multiline = false;
            this.tbxModelPath.Name = "tbxModelPath";
            this.tbxModelPath.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None;
            this.tbxModelPath.Size = new System.Drawing.Size(167, 19);
            this.tbxModelPath.TabIndex = 0;
            this.tbxModelPath.Text = "";
            // 
            // btnModelPath
            // 
            this.btnModelPath.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnModelPath.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnModelPath.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            this.btnModelPath.FlatAppearance.BorderSize = 0;
            this.btnModelPath.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            this.btnModelPath.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            this.btnModelPath.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnModelPath.Image = ((System.Drawing.Image)(resources.GetObject("btnModelPath.Image")));
            this.btnModelPath.Location = new System.Drawing.Point(176, 3);
            this.btnModelPath.Name = "btnModelPath";
            this.btnModelPath.Size = new System.Drawing.Size(21, 19);
            this.btnModelPath.TabIndex = 1;
            this.btnModelPath.UseVisualStyleBackColor = true;
            this.btnModelPath.Click += new System.EventHandler(this.btnModelPath_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("华文新魏", 11F);
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.label7.Location = new System.Drawing.Point(12, 90);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(73, 16);
            this.label7.TabIndex = 201;
            this.label7.Text = "保存路径:";
            // 
            // mWindowH
            // 
            this.mWindowH.BackColor = System.Drawing.Color.Transparent;
            this.mWindowH.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.mWindowH.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mWindowH.DrawModel = false;
            this.mWindowH.Image = null;
            this.mWindowH.Location = new System.Drawing.Point(305, 1);
            this.mWindowH.Margin = new System.Windows.Forms.Padding(5);
            this.mWindowH.Name = "mWindowH";
            this.mWindowH.Padding = new System.Windows.Forms.Padding(1);
            this.mWindowH.Size = new System.Drawing.Size(542, 487);
            this.mWindowH.TabIndex = 21;
            // 
            // CreateModelForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(850, 550);
            this.Name = "CreateModelForm";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.CreateModelForm_FormClosed);
            this.Load += new System.EventHandler(this.CreateModelForm_Load);
            this.LocationChanged += new System.EventHandler(this.CreateModelForm_LocationChanged);
            this.panel_bottom.ResumeLayout(false);
            this.panel_center.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbox_Icon)).EndInit();
            this.titlepanel.ResumeLayout(false);
            this.titlepanel.PerformLayout();
            this.uiTabControl1.ResumeLayout(false);
            this.tabPage3.ResumeLayout(false);
            this.pnl2ModelInfo.ResumeLayout(false);
            this.pnl2ModelInfo.PerformLayout();
            this.pnl1ModelInfo.ResumeLayout(false);
            this.pnl1ModelInfo.PerformLayout();
            this.uiTitlePanel4.ResumeLayout(false);
            this.uiTitlePanel4.PerformLayout();
            this.uiTitlePanel1.ResumeLayout(false);
            this.uiTitlePanel1.PerformLayout();
            this.tabPage1.ResumeLayout(false);
            this.pnl2Params.ResumeLayout(false);
            this.pnl2Params.PerformLayout();
            this.pnl1Params.ResumeLayout(false);
            this.pnl1Params.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.uiTitlePanel5.ResumeLayout(false);
            this.uiTitlePanel5.PerformLayout();
            this.tabPage4.ResumeLayout(false);
            this.uiTitlePanel8.ResumeLayout(false);
            this.uiTitlePanel8.PerformLayout();
            this.tableLayoutPanel4.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Rex.UI.UITabControl uiTabControl1;
        private System.Windows.Forms.TabPage tabPage4;
        private Rex.UI.UITitlePanel uiTitlePanel8;
        private Rex.UI.UITitlePanel pnl1Params;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label7;
        private Rex.UI.MyComboBox cbx1NumLevels;
        private RexControl.MyControls.MyTextBoxUpDownD tbx1AngleExtent;
        private RexControl.MyControls.MyTextBoxUpDownD tbx1AngleStart;
        private RexControl.MyControls.MyTextBoxUpDownD tbx1AngleStep;
        private Rex.UI.MyComboBox cbx1Metric;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
        private RexControl.MyControls.TextBoxEx tbxModelPath;
        private System.Windows.Forms.Button btnModelPath;
        private System.Windows.Forms.TabPage tabPage1;
        private Rex.UI.UITitlePanel pnl2Params;
        private RexControl.MyControls.MyTextBoxUpDownD tbx2ScaleStep;
        private System.Windows.Forms.Label label20;
        private RexControl.MyControls.MyTextBoxUpDownD tbx2ScaleMax;
        private System.Windows.Forms.Label label19;
        private RexControl.MyControls.MyTextBoxUpDownD tbx2ScaleMin;
        private System.Windows.Forms.Label label17;
        private Rex.UI.MyComboBox cbx2Metric;
        private RexControl.MyControls.MyTextBoxUpDownD tbx2AngleStep;
        private RexControl.MyControls.MyTextBoxUpDownD tbx2AngleExtent;
        private RexControl.MyControls.MyTextBoxUpDownD tbx2AngleStart;
        private Rex.UI.MyComboBox cbx2NumLevels;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private Rex.UI.MyComboBox cbx2Optimization;
        private System.Windows.Forms.Label label21;
        private Rex.UI.MyComboBox cbx2Contrast;
        private System.Windows.Forms.Label lbl2Contrast;
        private RexControl.MyControls.MyTextBoxUpDown tbx2MinContrast;
        private System.Windows.Forms.Label label22;
        private Rex.UI.UITextBox tbxModelName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TabPage tabPage2;
        private Rex.UI.UITitlePanel uiTitlePanel5;
        private System.Windows.Forms.Label label25;
        private Rex.UI.UIColorPicker cpModel;
        private System.Windows.Forms.TabPage tabPage3;
        private Rex.UI.UITitlePanel pnl2ModelInfo;
        private Rex.UI.MyComboBox cbxPrecision;
        private System.Windows.Forms.Label label9;
        private RexControl.MyControls.MyLinkData ldModContour;
        private System.Windows.Forms.Label label6;
        private Rex.UI.UITitlePanel pnl1ModelInfo;
        private RexControl.MyControls.MyLinkData ldModRegion;
        private System.Windows.Forms.Label label10;
        private Rex.UI.UITitlePanel uiTitlePanel4;
        private Rex.UI.MyComboBox cbxFactor;
        private System.Windows.Forms.Label label8;
        private Rex.UI.UITitlePanel uiTitlePanel1;
        private RexControl.MyControls.MyLinkData ldImage;
        private System.Windows.Forms.Label label11;
        private RexView.HWindow_HE mWindowH;
    }
}