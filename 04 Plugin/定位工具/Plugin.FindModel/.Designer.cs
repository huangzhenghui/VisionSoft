
namespace Plugin.FindModel
{
    partial class FindModelForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FindModelForm));
            this.mWindowH = new RexView.HWindow_HE();
            this.uiTabControl1 = new Rex.UI.UITabControl();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.pnl1ModelInfo = new Rex.UI.UITitlePanel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.tbxModelPath = new RexControl.MyControls.TextBoxEx();
            this.btnModelPathLink = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.uiTitlePanel4 = new Rex.UI.UITitlePanel();
            this.cbxFactor = new Rex.UI.MyComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.uiTitlePanel1 = new Rex.UI.UITitlePanel();
            this.ldImage = new RexControl.MyControls.MyLinkData();
            this.label11 = new System.Windows.Forms.Label();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.pnl2Params = new Rex.UI.UITitlePanel();
            this.tbx2NumMatches = new RexControl.MyControls.MyTextBoxUpDown();
            this.tbx2Greediness = new RexControl.MyControls.MyTextBoxUpDownD();
            this.cbx2InterAlgo = new Rex.UI.MyComboBox();
            this.label21 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.tbx2MinScore = new RexControl.MyControls.MyTextBoxUpDownD();
            this.label19 = new System.Windows.Forms.Label();
            this.tbx2ScaleMax = new RexControl.MyControls.MyTextBoxUpDownD();
            this.label17 = new System.Windows.Forms.Label();
            this.tbx2ScaleMin = new RexControl.MyControls.MyTextBoxUpDownD();
            this.tbx2AngleExtent = new RexControl.MyControls.MyTextBoxUpDownD();
            this.tbx2AngleStart = new RexControl.MyControls.MyTextBoxUpDownD();
            this.cbx2NumLevels = new Rex.UI.MyComboBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.pnl1Params = new Rex.UI.UITitlePanel();
            this.tbx1MinScore = new RexControl.MyControls.MyTextBoxUpDown();
            this.cbx1NumLevels = new Rex.UI.MyComboBox();
            this.label18 = new System.Windows.Forms.Label();
            this.cbx1Precision = new Rex.UI.MyComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.tbx1MaxOverlap = new RexControl.MyControls.MyTextBoxUpDownD();
            this.label4 = new System.Windows.Forms.Label();
            this.tbx1NumMatches = new RexControl.MyControls.MyTextBoxUpDown();
            this.label6 = new System.Windows.Forms.Label();
            this.tbx1AngleExtent = new RexControl.MyControls.MyTextBoxUpDownD();
            this.tbx1AngleStart = new RexControl.MyControls.MyTextBoxUpDownD();
            this.label5 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.uiTitlePanel7 = new Rex.UI.UITitlePanel();
            this.label2 = new System.Windows.Forms.Label();
            this.chxShow = new Rex.UI.UICheckBox();
            this.cpColor = new Rex.UI.UIColorPicker();
            this.panel_bottom.SuspendLayout();
            this.panel_center.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbox_Icon)).BeginInit();
            this.titlepanel.SuspendLayout();
            this.uiTabControl1.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.pnl1ModelInfo.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.uiTitlePanel4.SuspendLayout();
            this.uiTitlePanel1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.pnl2Params.SuspendLayout();
            this.pnl1Params.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.uiTitlePanel7.SuspendLayout();
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
            this.mWindowH.Location = new System.Drawing.Point(305, 1);
            this.mWindowH.Margin = new System.Windows.Forms.Padding(5);
            this.mWindowH.Name = "mWindowH";
            this.mWindowH.Padding = new System.Windows.Forms.Padding(1);
            this.mWindowH.Size = new System.Drawing.Size(542, 487);
            this.mWindowH.TabIndex = 20;
            // 
            // uiTabControl1
            // 
            this.uiTabControl1.Controls.Add(this.tabPage3);
            this.uiTabControl1.Controls.Add(this.tabPage1);
            this.uiTabControl1.Controls.Add(this.tabPage2);
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
            // pnl1ModelInfo
            // 
            this.pnl1ModelInfo.Controls.Add(this.tableLayoutPanel2);
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
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.BackColor = System.Drawing.Color.AliceBlue;
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 86.76471F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 13.23529F));
            this.tableLayoutPanel2.Controls.Add(this.tbxModelPath, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.btnModelPathLink, 1, 0);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(83, 41);
            this.tableLayoutPanel2.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(210, 25);
            this.tableLayoutPanel2.TabIndex = 203;
            // 
            // tbxModelPath
            // 
            this.tbxModelPath.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbxModelPath.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbxModelPath.Font = new System.Drawing.Font("华文新魏", 10F);
            this.tbxModelPath.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.tbxModelPath.Location = new System.Drawing.Point(3, 5);
            this.tbxModelPath.Margin = new System.Windows.Forms.Padding(3, 5, 3, 3);
            this.tbxModelPath.Multiline = false;
            this.tbxModelPath.Name = "tbxModelPath";
            this.tbxModelPath.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None;
            this.tbxModelPath.Size = new System.Drawing.Size(176, 17);
            this.tbxModelPath.TabIndex = 0;
            this.tbxModelPath.Text = "";
            // 
            // btnModelPathLink
            // 
            this.btnModelPathLink.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnModelPathLink.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnModelPathLink.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            this.btnModelPathLink.FlatAppearance.BorderSize = 0;
            this.btnModelPathLink.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            this.btnModelPathLink.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            this.btnModelPathLink.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnModelPathLink.Image = ((System.Drawing.Image)(resources.GetObject("btnModelPathLink.Image")));
            this.btnModelPathLink.Location = new System.Drawing.Point(185, 3);
            this.btnModelPathLink.Name = "btnModelPathLink";
            this.btnModelPathLink.Size = new System.Drawing.Size(22, 19);
            this.btnModelPathLink.TabIndex = 1;
            this.btnModelPathLink.UseVisualStyleBackColor = true;
            this.btnModelPathLink.Click += new System.EventHandler(this.btnModelPathLink_Click);
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
            this.label10.Text = "模板路径:";
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
            this.pnl2Params.Controls.Add(this.tbx2NumMatches);
            this.pnl2Params.Controls.Add(this.tbx2Greediness);
            this.pnl2Params.Controls.Add(this.cbx2InterAlgo);
            this.pnl2Params.Controls.Add(this.label21);
            this.pnl2Params.Controls.Add(this.label20);
            this.pnl2Params.Controls.Add(this.tbx2MinScore);
            this.pnl2Params.Controls.Add(this.label19);
            this.pnl2Params.Controls.Add(this.tbx2ScaleMax);
            this.pnl2Params.Controls.Add(this.label17);
            this.pnl2Params.Controls.Add(this.tbx2ScaleMin);
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
            this.pnl2Params.Location = new System.Drawing.Point(0, 285);
            this.pnl2Params.Margin = new System.Windows.Forms.Padding(0);
            this.pnl2Params.MinimumSize = new System.Drawing.Size(1, 1);
            this.pnl2Params.Name = "pnl2Params";
            this.pnl2Params.Padding = new System.Windows.Forms.Padding(0, 30, 0, 0);
            this.pnl2Params.RadiusSides = Rex.UI.UICornerRadiusSides.None;
            this.pnl2Params.RectColor = System.Drawing.Color.White;
            this.pnl2Params.Size = new System.Drawing.Size(303, 366);
            this.pnl2Params.Style = Rex.UI.UIStyle.Custom;
            this.pnl2Params.TabIndex = 46;
            this.pnl2Params.Text = "参数设置";
            this.pnl2Params.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.pnl2Params.TextAlignment = System.Drawing.ContentAlignment.MiddleRight;
            this.pnl2Params.TitleColor = System.Drawing.Color.CornflowerBlue;
            this.pnl2Params.TitleInterval = 5;
            // 
            // tbx2NumMatches
            // 
            this.tbx2NumMatches.BackColor = System.Drawing.Color.White;
            this.tbx2NumMatches.Font = new System.Drawing.Font("华文新魏", 11F);
            this.tbx2NumMatches.FontStyle = null;
            this.tbx2NumMatches.Location = new System.Drawing.Point(83, 254);
            this.tbx2NumMatches.Name = "tbx2NumMatches";
            this.tbx2NumMatches.Size = new System.Drawing.Size(210, 26);
            this.tbx2NumMatches.TabIndex = 241;
            this.tbx2NumMatches.TextInfo = "";
            // 
            // tbx2Greediness
            // 
            this.tbx2Greediness.Font = new System.Drawing.Font("华文新魏", 11F);
            this.tbx2Greediness.FontStyle = null;
            this.tbx2Greediness.Location = new System.Drawing.Point(83, 287);
            this.tbx2Greediness.Name = "tbx2Greediness";
            this.tbx2Greediness.Size = new System.Drawing.Size(210, 26);
            this.tbx2Greediness.TabIndex = 240;
            this.tbx2Greediness.TextInfo = "";
            // 
            // cbx2InterAlgo
            // 
            this.cbx2InterAlgo.BackColor = System.Drawing.Color.AliceBlue;
            this.cbx2InterAlgo.DropDownStyle = Rex.UI.UIDropDownStyle.DropDownList;
            this.cbx2InterAlgo.FillColor = System.Drawing.Color.AliceBlue;
            this.cbx2InterAlgo.Font = new System.Drawing.Font("华文新魏", 11.6F);
            this.cbx2InterAlgo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.cbx2InterAlgo.ForeDisableColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.cbx2InterAlgo.Items.AddRange(new object[] {
            "least_squares",
            "least_squares_high",
            "least_squares_very_high",
            "interpolation",
            "max_deformation 1",
            "max_deformation 2",
            "max_deformation 3",
            "max_deformation 4",
            "max_deformation 5",
            "max_deformation 6"});
            this.cbx2InterAlgo.Location = new System.Drawing.Point(83, 322);
            this.cbx2InterAlgo.Margin = new System.Windows.Forms.Padding(0);
            this.cbx2InterAlgo.MinimumSize = new System.Drawing.Size(63, 0);
            this.cbx2InterAlgo.Name = "cbx2InterAlgo";
            this.cbx2InterAlgo.Padding = new System.Windows.Forms.Padding(0, 0, 30, 0);
            this.cbx2InterAlgo.Radius = 2;
            this.cbx2InterAlgo.RectColor = System.Drawing.Color.CornflowerBlue;
            this.cbx2InterAlgo.RectDisableColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.cbx2InterAlgo.RectSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.None;
            this.cbx2InterAlgo.Size = new System.Drawing.Size(210, 24);
            this.cbx2InterAlgo.Style = Rex.UI.UIStyle.Custom;
            this.cbx2InterAlgo.StyleCustomMode = true;
            this.cbx2InterAlgo.SymbolDropDown = 61656;
            this.cbx2InterAlgo.SymbolNormal = 61655;
            this.cbx2InterAlgo.TabIndex = 239;
            this.cbx2InterAlgo.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.BackColor = System.Drawing.Color.Transparent;
            this.label21.Font = new System.Drawing.Font("华文新魏", 11F);
            this.label21.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.label21.Location = new System.Drawing.Point(10, 328);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(73, 16);
            this.label21.TabIndex = 218;
            this.label21.Text = "插值算法:";
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
            this.label20.Text = "匹配数量:";
            // 
            // tbx2MinScore
            // 
            this.tbx2MinScore.Font = new System.Drawing.Font("华文新魏", 11F);
            this.tbx2MinScore.FontStyle = null;
            this.tbx2MinScore.Location = new System.Drawing.Point(83, 220);
            this.tbx2MinScore.Name = "tbx2MinScore";
            this.tbx2MinScore.Size = new System.Drawing.Size(210, 26);
            this.tbx2MinScore.TabIndex = 230;
            this.tbx2MinScore.TextInfo = "";
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
            this.label19.Text = "最小分数:";
            // 
            // tbx2ScaleMax
            // 
            this.tbx2ScaleMax.Font = new System.Drawing.Font("华文新魏", 11F);
            this.tbx2ScaleMax.FontStyle = null;
            this.tbx2ScaleMax.Location = new System.Drawing.Point(83, 184);
            this.tbx2ScaleMax.Name = "tbx2ScaleMax";
            this.tbx2ScaleMax.Size = new System.Drawing.Size(210, 26);
            this.tbx2ScaleMax.TabIndex = 228;
            this.tbx2ScaleMax.TextInfo = "";
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
            this.label17.Text = "最大缩放:";
            // 
            // tbx2ScaleMin
            // 
            this.tbx2ScaleMin.Font = new System.Drawing.Font("华文新魏", 11F);
            this.tbx2ScaleMin.FontStyle = null;
            this.tbx2ScaleMin.Location = new System.Drawing.Point(83, 150);
            this.tbx2ScaleMin.Name = "tbx2ScaleMin";
            this.tbx2ScaleMin.Size = new System.Drawing.Size(210, 26);
            this.tbx2ScaleMin.TabIndex = 226;
            this.tbx2ScaleMin.TextInfo = "";
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
            this.label12.Location = new System.Drawing.Point(10, 293);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(73, 16);
            this.label12.TabIndex = 216;
            this.label12.Text = "贪婪程度:";
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
            this.label13.Text = "最小缩放:";
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
            this.pnl1Params.Controls.Add(this.tbx1MinScore);
            this.pnl1Params.Controls.Add(this.cbx1NumLevels);
            this.pnl1Params.Controls.Add(this.label18);
            this.pnl1Params.Controls.Add(this.cbx1Precision);
            this.pnl1Params.Controls.Add(this.label9);
            this.pnl1Params.Controls.Add(this.tbx1MaxOverlap);
            this.pnl1Params.Controls.Add(this.label4);
            this.pnl1Params.Controls.Add(this.tbx1NumMatches);
            this.pnl1Params.Controls.Add(this.label6);
            this.pnl1Params.Controls.Add(this.tbx1AngleExtent);
            this.pnl1Params.Controls.Add(this.tbx1AngleStart);
            this.pnl1Params.Controls.Add(this.label5);
            this.pnl1Params.Controls.Add(this.label1);
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
            this.pnl1Params.Size = new System.Drawing.Size(303, 285);
            this.pnl1Params.Style = Rex.UI.UIStyle.Custom;
            this.pnl1Params.TabIndex = 45;
            this.pnl1Params.Text = "参数设置";
            this.pnl1Params.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.pnl1Params.TextAlignment = System.Drawing.ContentAlignment.MiddleRight;
            this.pnl1Params.TitleColor = System.Drawing.Color.CornflowerBlue;
            this.pnl1Params.TitleInterval = 5;
            // 
            // tbx1MinScore
            // 
            this.tbx1MinScore.BackColor = System.Drawing.Color.White;
            this.tbx1MinScore.Font = new System.Drawing.Font("华文新魏", 11F);
            this.tbx1MinScore.FontStyle = null;
            this.tbx1MinScore.Location = new System.Drawing.Point(83, 141);
            this.tbx1MinScore.Name = "tbx1MinScore";
            this.tbx1MinScore.Size = new System.Drawing.Size(210, 26);
            this.tbx1MinScore.TabIndex = 21;
            this.tbx1MinScore.TextInfo = "";
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
            this.cbx1NumLevels.Location = new System.Drawing.Point(83, 38);
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
            this.cbx1NumLevels.TabIndex = 234;
            this.cbx1NumLevels.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.BackColor = System.Drawing.Color.Transparent;
            this.label18.Font = new System.Drawing.Font("华文新魏", 11F);
            this.label18.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.label18.Location = new System.Drawing.Point(10, 43);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(73, 16);
            this.label18.TabIndex = 233;
            this.label18.Text = "金字塔层:";
            // 
            // cbx1Precision
            // 
            this.cbx1Precision.BackColor = System.Drawing.Color.AliceBlue;
            this.cbx1Precision.DropDownStyle = Rex.UI.UIDropDownStyle.DropDownList;
            this.cbx1Precision.FillColor = System.Drawing.Color.AliceBlue;
            this.cbx1Precision.Font = new System.Drawing.Font("华文新魏", 11.6F);
            this.cbx1Precision.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.cbx1Precision.ForeDisableColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.cbx1Precision.Items.AddRange(new object[] {
            "像素",
            "亚像素"});
            this.cbx1Precision.Location = new System.Drawing.Point(83, 244);
            this.cbx1Precision.Margin = new System.Windows.Forms.Padding(0);
            this.cbx1Precision.MinimumSize = new System.Drawing.Size(63, 0);
            this.cbx1Precision.Name = "cbx1Precision";
            this.cbx1Precision.Padding = new System.Windows.Forms.Padding(0, 0, 30, 0);
            this.cbx1Precision.Radius = 2;
            this.cbx1Precision.RectColor = System.Drawing.Color.CornflowerBlue;
            this.cbx1Precision.RectDisableColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.cbx1Precision.RectSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.None;
            this.cbx1Precision.Size = new System.Drawing.Size(210, 24);
            this.cbx1Precision.Style = Rex.UI.UIStyle.Custom;
            this.cbx1Precision.StyleCustomMode = true;
            this.cbx1Precision.SymbolDropDown = 61656;
            this.cbx1Precision.SymbolNormal = 61655;
            this.cbx1Precision.TabIndex = 232;
            this.cbx1Precision.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("华文新魏", 11F);
            this.label9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.label9.Location = new System.Drawing.Point(10, 249);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(73, 16);
            this.label9.TabIndex = 231;
            this.label9.Text = "轮廓精度:";
            // 
            // tbx1MaxOverlap
            // 
            this.tbx1MaxOverlap.Font = new System.Drawing.Font("华文新魏", 11F);
            this.tbx1MaxOverlap.FontStyle = null;
            this.tbx1MaxOverlap.Location = new System.Drawing.Point(83, 211);
            this.tbx1MaxOverlap.Name = "tbx1MaxOverlap";
            this.tbx1MaxOverlap.Size = new System.Drawing.Size(210, 26);
            this.tbx1MaxOverlap.TabIndex = 230;
            this.tbx1MaxOverlap.TextInfo = "";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("华文新魏", 11F);
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.label4.Location = new System.Drawing.Point(10, 218);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(73, 16);
            this.label4.TabIndex = 229;
            this.label4.Text = "最大重叠:";
            // 
            // tbx1NumMatches
            // 
            this.tbx1NumMatches.BackColor = System.Drawing.Color.White;
            this.tbx1NumMatches.Font = new System.Drawing.Font("华文新魏", 11F);
            this.tbx1NumMatches.FontStyle = null;
            this.tbx1NumMatches.Location = new System.Drawing.Point(83, 177);
            this.tbx1NumMatches.Name = "tbx1NumMatches";
            this.tbx1NumMatches.Size = new System.Drawing.Size(210, 26);
            this.tbx1NumMatches.TabIndex = 228;
            this.tbx1NumMatches.TextInfo = "";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("华文新魏", 11F);
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.label6.Location = new System.Drawing.Point(10, 184);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(73, 16);
            this.label6.TabIndex = 227;
            this.label6.Text = "匹配数量:";
            // 
            // tbx1AngleExtent
            // 
            this.tbx1AngleExtent.Font = new System.Drawing.Font("华文新魏", 11F);
            this.tbx1AngleExtent.FontStyle = null;
            this.tbx1AngleExtent.Location = new System.Drawing.Point(83, 105);
            this.tbx1AngleExtent.Name = "tbx1AngleExtent";
            this.tbx1AngleExtent.Size = new System.Drawing.Size(210, 26);
            this.tbx1AngleExtent.TabIndex = 225;
            this.tbx1AngleExtent.TextInfo = "";
            // 
            // tbx1AngleStart
            // 
            this.tbx1AngleStart.Font = new System.Drawing.Font("华文新魏", 11F);
            this.tbx1AngleStart.FontStyle = null;
            this.tbx1AngleStart.Location = new System.Drawing.Point(83, 69);
            this.tbx1AngleStart.Name = "tbx1AngleStart";
            this.tbx1AngleStart.Size = new System.Drawing.Size(210, 26);
            this.tbx1AngleStart.TabIndex = 224;
            this.tbx1AngleStart.TextInfo = "";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("华文新魏", 11F);
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.label5.Location = new System.Drawing.Point(10, 149);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(73, 16);
            this.label5.TabIndex = 215;
            this.label5.Text = "最小分数:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("华文新魏", 11F);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.label1.Location = new System.Drawing.Point(10, 75);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 16);
            this.label1.TabIndex = 206;
            this.label1.Text = "起始角度:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("华文新魏", 11F);
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.label3.Location = new System.Drawing.Point(10, 112);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 16);
            this.label3.TabIndex = 208;
            this.label3.Text = "旋转范围:";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.uiTitlePanel7);
            this.tabPage2.Location = new System.Drawing.Point(0, 26);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Size = new System.Drawing.Size(303, 461);
            this.tabPage2.TabIndex = 3;
            this.tabPage2.Text = "显示设置";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // uiTitlePanel7
            // 
            this.uiTitlePanel7.Controls.Add(this.label2);
            this.uiTitlePanel7.Controls.Add(this.chxShow);
            this.uiTitlePanel7.Controls.Add(this.cpColor);
            this.uiTitlePanel7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.uiTitlePanel7.FillColor = System.Drawing.Color.White;
            this.uiTitlePanel7.FillDisableColor = System.Drawing.Color.White;
            this.uiTitlePanel7.Font = new System.Drawing.Font("华文新魏", 12F);
            this.uiTitlePanel7.ForeColor = System.Drawing.Color.White;
            this.uiTitlePanel7.Location = new System.Drawing.Point(0, 0);
            this.uiTitlePanel7.Margin = new System.Windows.Forms.Padding(0);
            this.uiTitlePanel7.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiTitlePanel7.Name = "uiTitlePanel7";
            this.uiTitlePanel7.Padding = new System.Windows.Forms.Padding(0, 35, 0, 0);
            this.uiTitlePanel7.RadiusSides = Rex.UI.UICornerRadiusSides.None;
            this.uiTitlePanel7.RectColor = System.Drawing.Color.White;
            this.uiTitlePanel7.Size = new System.Drawing.Size(303, 461);
            this.uiTitlePanel7.Style = Rex.UI.UIStyle.Custom;
            this.uiTitlePanel7.TabIndex = 192;
            this.uiTitlePanel7.Text = "显示设置";
            this.uiTitlePanel7.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.uiTitlePanel7.TitleColor = System.Drawing.Color.CornflowerBlue;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("华文新魏", 11F);
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.label2.Location = new System.Drawing.Point(10, 72);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 16);
            this.label2.TabIndex = 191;
            this.label2.Text = "结果颜色:";
            // 
            // chxShow
            // 
            this.chxShow.Checked = true;
            this.chxShow.Cursor = System.Windows.Forms.Cursors.Hand;
            this.chxShow.Font = new System.Drawing.Font("华文新魏", 11F);
            this.chxShow.Location = new System.Drawing.Point(10, 40);
            this.chxShow.MinimumSize = new System.Drawing.Size(1, 1);
            this.chxShow.Name = "chxShow";
            this.chxShow.Padding = new System.Windows.Forms.Padding(22, 0, 0, 0);
            this.chxShow.Size = new System.Drawing.Size(144, 21);
            this.chxShow.Style = Rex.UI.UIStyle.Custom;
            this.chxShow.TabIndex = 189;
            this.chxShow.Text = "显示结果";
            // 
            // cpColor
            // 
            this.cpColor.DropDownStyle = Rex.UI.UIDropDownStyle.DropDownList;
            this.cpColor.FillColor = System.Drawing.Color.AliceBlue;
            this.cpColor.FillDisableColor = System.Drawing.Color.AliceBlue;
            this.cpColor.Font = new System.Drawing.Font("微软雅黑", 9F);
            this.cpColor.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.cpColor.Location = new System.Drawing.Point(90, 67);
            this.cpColor.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cpColor.MinimumSize = new System.Drawing.Size(63, 0);
            this.cpColor.Name = "cpColor";
            this.cpColor.Padding = new System.Windows.Forms.Padding(0, 0, 30, 0);
            this.cpColor.RadiusSides = Rex.UI.UICornerRadiusSides.None;
            this.cpColor.RectColor = System.Drawing.Color.White;
            this.cpColor.RectSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.Bottom;
            this.cpColor.Size = new System.Drawing.Size(190, 23);
            this.cpColor.Style = Rex.UI.UIStyle.Custom;
            this.cpColor.StyleCustomMode = true;
            this.cpColor.TabIndex = 182;
            this.cpColor.Text = "uiColorPicker1";
            this.cpColor.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.cpColor.Value = System.Drawing.Color.MediumPurple;
            // 
            // FindModelForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(850, 550);
            this.Name = "FindModelForm";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FindModelForm_FormClosed);
            this.Load += new System.EventHandler(this.FindModelForm_Load);
            this.LocationChanged += new System.EventHandler(this.FindModelForm_LocationChanged);
            this.panel_bottom.ResumeLayout(false);
            this.panel_center.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbox_Icon)).EndInit();
            this.titlepanel.ResumeLayout(false);
            this.titlepanel.PerformLayout();
            this.uiTabControl1.ResumeLayout(false);
            this.tabPage3.ResumeLayout(false);
            this.pnl1ModelInfo.ResumeLayout(false);
            this.pnl1ModelInfo.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
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
            this.uiTitlePanel7.ResumeLayout(false);
            this.uiTitlePanel7.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private RexView.HWindow_HE mWindowH;
        private Rex.UI.UITabControl uiTabControl1;
        private System.Windows.Forms.TabPage tabPage3;
        private Rex.UI.UITitlePanel uiTitlePanel1;
        private RexControl.MyControls.MyLinkData ldImage;
        private System.Windows.Forms.Label label11;
        private Rex.UI.UITitlePanel pnl1Params;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private RexControl.MyControls.MyTextBoxUpDownD tbx1AngleExtent;
        private RexControl.MyControls.MyTextBoxUpDownD tbx1AngleStart;
        private Rex.UI.UITitlePanel pnl1ModelInfo;
        private System.Windows.Forms.Label label10;
        private Rex.UI.UITitlePanel uiTitlePanel4;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TabPage tabPage1;
        private Rex.UI.UITitlePanel pnl2Params;
        private System.Windows.Forms.Label label20;
        private RexControl.MyControls.MyTextBoxUpDownD tbx2MinScore;
        private System.Windows.Forms.Label label19;
        private RexControl.MyControls.MyTextBoxUpDownD tbx2ScaleMax;
        private System.Windows.Forms.Label label17;
        private RexControl.MyControls.MyTextBoxUpDownD tbx2ScaleMin;
        private RexControl.MyControls.MyTextBoxUpDownD tbx2AngleExtent;
        private RexControl.MyControls.MyTextBoxUpDownD tbx2AngleStart;
        private Rex.UI.MyComboBox cbx2NumLevels;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private Rex.UI.MyComboBox cbxFactor;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private RexControl.MyControls.TextBoxEx tbxModelPath;
        private System.Windows.Forms.Button btnModelPathLink;
        private Rex.UI.MyComboBox cbx1NumLevels;
        private System.Windows.Forms.Label label18;
        private Rex.UI.MyComboBox cbx1Precision;
        private System.Windows.Forms.Label label9;
        private RexControl.MyControls.MyTextBoxUpDownD tbx1MaxOverlap;
        private System.Windows.Forms.Label label4;
        private RexControl.MyControls.MyTextBoxUpDown tbx1NumMatches;
        private System.Windows.Forms.Label label6;
        private RexControl.MyControls.MyTextBoxUpDownD tbx2Greediness;
        private Rex.UI.MyComboBox cbx2InterAlgo;
        private System.Windows.Forms.TabPage tabPage2;
        private Rex.UI.UITitlePanel uiTitlePanel7;
        private System.Windows.Forms.Label label2;
        private Rex.UI.UICheckBox chxShow;
        private Rex.UI.UIColorPicker cpColor;
        private RexControl.MyControls.MyTextBoxUpDown tbx2NumMatches;
        private RexControl.MyControls.MyTextBoxUpDown tbx1MinScore;
    }
}