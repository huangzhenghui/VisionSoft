
namespace Plugin.ContourSel
{
    partial class ContourSelForm
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
            this.pnlRect2Params = new Rex.UI.UITitlePanel();
            this.tbxMin = new RexControl.MyControls.MyTextBoxUpDownD();
            this.label1 = new System.Windows.Forms.Label();
            this.tbxMax = new RexControl.MyControls.MyTextBoxUpDown();
            this.cbxShape = new Rex.UI.MyComboBox();
            this.label18 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.uiTitlePanel2 = new Rex.UI.UITitlePanel();
            this.ldContour = new RexControl.MyControls.MyLinkData();
            this.label4 = new System.Windows.Forms.Label();
            this.uiTitlePanel1 = new Rex.UI.UITitlePanel();
            this.ldImage = new RexControl.MyControls.MyLinkData();
            this.label11 = new System.Windows.Forms.Label();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.uiTitlePanel5 = new Rex.UI.UITitlePanel();
            this.btnClearResult = new Rex.UI.UISymbolButton();
            this.label20 = new System.Windows.Forms.Label();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.uiTitlePanel3 = new Rex.UI.UITitlePanel();
            this.label22 = new System.Windows.Forms.Label();
            this.cpContour = new Rex.UI.UIColorPicker();
            this.chxShowHObj = new Rex.UI.UICheckBox();
            this.panel_bottom.SuspendLayout();
            this.panel_center.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbox_Icon)).BeginInit();
            this.titlepanel.SuspendLayout();
            this.uiTabControl1.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.pnlRect2Params.SuspendLayout();
            this.uiTitlePanel2.SuspendLayout();
            this.uiTitlePanel1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.uiTitlePanel5.SuspendLayout();
            this.tabPage4.SuspendLayout();
            this.uiTitlePanel3.SuspendLayout();
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
            this.tabPage3.Controls.Add(this.pnlRect2Params);
            this.tabPage3.Controls.Add(this.uiTitlePanel2);
            this.tabPage3.Controls.Add(this.uiTitlePanel1);
            this.tabPage3.Font = new System.Drawing.Font("隶书", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tabPage3.Location = new System.Drawing.Point(0, 26);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(303, 461);
            this.tabPage3.TabIndex = 0;
            this.tabPage3.Text = "基本设置";
            // 
            // pnlRect2Params
            // 
            this.pnlRect2Params.Controls.Add(this.tbxMin);
            this.pnlRect2Params.Controls.Add(this.label1);
            this.pnlRect2Params.Controls.Add(this.tbxMax);
            this.pnlRect2Params.Controls.Add(this.cbxShape);
            this.pnlRect2Params.Controls.Add(this.label18);
            this.pnlRect2Params.Controls.Add(this.label3);
            this.pnlRect2Params.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlRect2Params.FillColor = System.Drawing.Color.White;
            this.pnlRect2Params.Font = new System.Drawing.Font("华文新魏", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.pnlRect2Params.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            this.pnlRect2Params.Location = new System.Drawing.Point(0, 166);
            this.pnlRect2Params.Margin = new System.Windows.Forms.Padding(0);
            this.pnlRect2Params.MinimumSize = new System.Drawing.Size(1, 1);
            this.pnlRect2Params.Name = "pnlRect2Params";
            this.pnlRect2Params.Padding = new System.Windows.Forms.Padding(0, 30, 0, 0);
            this.pnlRect2Params.RadiusSides = Rex.UI.UICornerRadiusSides.None;
            this.pnlRect2Params.RectColor = System.Drawing.Color.White;
            this.pnlRect2Params.Size = new System.Drawing.Size(303, 181);
            this.pnlRect2Params.Style = Rex.UI.UIStyle.Custom;
            this.pnlRect2Params.TabIndex = 45;
            this.pnlRect2Params.Text = "参数设置";
            this.pnlRect2Params.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.pnlRect2Params.TextAlignment = System.Drawing.ContentAlignment.MiddleRight;
            this.pnlRect2Params.TitleColor = System.Drawing.Color.CornflowerBlue;
            this.pnlRect2Params.TitleInterval = 5;
            // 
            // tbxMin
            // 
            this.tbxMin.Font = new System.Drawing.Font("华文新魏", 11F);
            this.tbxMin.FontStyle = null;
            this.tbxMin.Location = new System.Drawing.Point(84, 82);
            this.tbxMin.Name = "tbxMin";
            this.tbxMin.Size = new System.Drawing.Size(209, 24);
            this.tbxMin.TabIndex = 211;
            this.tbxMin.TextInfo = "";
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
            this.label1.Text = "特征下限:";
            // 
            // tbxMax
            // 
            this.tbxMax.BackColor = System.Drawing.Color.White;
            this.tbxMax.Font = new System.Drawing.Font("华文新魏", 11.2F);
            this.tbxMax.FontStyle = null;
            this.tbxMax.Location = new System.Drawing.Point(83, 119);
            this.tbxMax.Name = "tbxMax";
            this.tbxMax.Size = new System.Drawing.Size(210, 24);
            this.tbxMax.TabIndex = 207;
            this.tbxMax.TextInfo = "";
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
            "anisometry",
            "anisometry_points",
            "area",
            "area_points",
            "bulkiness",
            "circularity",
            "column",
            "column1",
            "column2",
            "column_points",
            "compactness",
            "contlength",
            "convexity",
            "height",
            "max_diameter",
            "moments_m02",
            "moments_m02_points",
            "moments_m11",
            "moments_m11_points",
            "moments_m20",
            "moments_m20_points",
            "orientation",
            "orientation_points",
            "outer_radius",
            "phi",
            "phi_points",
            "ra",
            "ra_points",
            "ratio",
            "rb",
            "rb_points",
            "rect2_len1",
            "rect2_len2",
            "rect2_phi",
            "rectangularity",
            "row",
            "row1",
            "row2",
            "row_points",
            "struct_factor",
            "width"});
            this.cbxShape.Location = new System.Drawing.Point(83, 45);
            this.cbxShape.Margin = new System.Windows.Forms.Padding(0);
            this.cbxShape.MinimumSize = new System.Drawing.Size(63, 0);
            this.cbxShape.Name = "cbxShape";
            this.cbxShape.Padding = new System.Windows.Forms.Padding(0, 0, 30, 0);
            this.cbxShape.Radius = 2;
            this.cbxShape.RectColor = System.Drawing.Color.CornflowerBlue;
            this.cbxShape.RectDisableColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.cbxShape.RectSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.None;
            this.cbxShape.Size = new System.Drawing.Size(210, 24);
            this.cbxShape.Style = Rex.UI.UIStyle.Custom;
            this.cbxShape.StyleCustomMode = true;
            this.cbxShape.SymbolDropDown = 61656;
            this.cbxShape.SymbolNormal = 61655;
            this.cbxShape.TabIndex = 203;
            this.cbxShape.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
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
            this.label18.Text = "筛选特征:";
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
            this.label3.Text = "特征上限:";
            // 
            // uiTitlePanel2
            // 
            this.uiTitlePanel2.Controls.Add(this.ldContour);
            this.uiTitlePanel2.Controls.Add(this.label4);
            this.uiTitlePanel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.uiTitlePanel2.FillColor = System.Drawing.Color.White;
            this.uiTitlePanel2.Font = new System.Drawing.Font("华文新魏", 12F);
            this.uiTitlePanel2.ForeColor = System.Drawing.Color.White;
            this.uiTitlePanel2.Location = new System.Drawing.Point(0, 83);
            this.uiTitlePanel2.Margin = new System.Windows.Forms.Padding(0);
            this.uiTitlePanel2.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiTitlePanel2.Name = "uiTitlePanel2";
            this.uiTitlePanel2.Padding = new System.Windows.Forms.Padding(3, 25, 3, 0);
            this.uiTitlePanel2.RadiusSides = Rex.UI.UICornerRadiusSides.None;
            this.uiTitlePanel2.RectColor = System.Drawing.Color.White;
            this.uiTitlePanel2.Size = new System.Drawing.Size(303, 83);
            this.uiTitlePanel2.Style = Rex.UI.UIStyle.Custom;
            this.uiTitlePanel2.TabIndex = 44;
            this.uiTitlePanel2.Text = "输入轮廓";
            this.uiTitlePanel2.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.uiTitlePanel2.TextAlignment = System.Drawing.ContentAlignment.BottomCenter;
            this.uiTitlePanel2.TitleColor = System.Drawing.Color.CornflowerBlue;
            this.uiTitlePanel2.TitleInterval = 5;
            // 
            // ldContour
            // 
            this.ldContour.BackColor = System.Drawing.Color.AliceBlue;
            this.ldContour.Font = new System.Drawing.Font("华文新魏", 12F);
            this.ldContour.FontStyle = new System.Drawing.Font("华文新魏", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.ldContour.Location = new System.Drawing.Point(83, 43);
            this.ldContour.Margin = new System.Windows.Forms.Padding(4, 5, 4, 4);
            this.ldContour.Name = "ldContour";
            this.ldContour.Size = new System.Drawing.Size(210, 24);
            this.ldContour.TabIndex = 195;
            this.ldContour.TextInfo = "";
            this.ldContour.LinkData += new System.EventHandler(this.ldData_LinkData);
            this.ldContour.RealTimeExe += new System.EventHandler(this.ldData_RealTimeExe);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("华文新魏", 11F);
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.label4.Location = new System.Drawing.Point(10, 47);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(73, 16);
            this.label4.TabIndex = 191;
            this.label4.Text = "输入轮廓:";
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
            this.tabPage1.Controls.Add(this.uiTitlePanel5);
            this.tabPage1.Location = new System.Drawing.Point(0, 26);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Size = new System.Drawing.Size(303, 461);
            this.tabPage1.TabIndex = 2;
            this.tabPage1.Text = "编辑设置";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // uiTitlePanel5
            // 
            this.uiTitlePanel5.Controls.Add(this.btnClearResult);
            this.uiTitlePanel5.Controls.Add(this.label20);
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
            this.uiTitlePanel5.Size = new System.Drawing.Size(303, 77);
            this.uiTitlePanel5.Style = Rex.UI.UIStyle.Custom;
            this.uiTitlePanel5.TabIndex = 212;
            this.uiTitlePanel5.Text = "编辑设置";
            this.uiTitlePanel5.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.uiTitlePanel5.TitleColor = System.Drawing.Color.CornflowerBlue;
            this.uiTitlePanel5.TitleInterval = 5;
            // 
            // btnClearResult
            // 
            this.btnClearResult.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClearResult.Font = new System.Drawing.Font("华文新魏", 12F);
            this.btnClearResult.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            this.btnClearResult.ForeHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            this.btnClearResult.ForePressColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            this.btnClearResult.ForeSelectedColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            this.btnClearResult.Location = new System.Drawing.Point(89, 39);
            this.btnClearResult.MinimumSize = new System.Drawing.Size(1, 1);
            this.btnClearResult.Name = "btnClearResult";
            this.btnClearResult.Size = new System.Drawing.Size(202, 21);
            this.btnClearResult.Style = Rex.UI.UIStyle.Custom;
            this.btnClearResult.Symbol = 61732;
            this.btnClearResult.TabIndex = 208;
            this.btnClearResult.Text = "执行";
            this.btnClearResult.Click += new System.EventHandler(this.btnClearResult_Click);
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.BackColor = System.Drawing.Color.Transparent;
            this.label20.Font = new System.Drawing.Font("华文新魏", 11F);
            this.label20.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.label20.Location = new System.Drawing.Point(10, 42);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(73, 16);
            this.label20.TabIndex = 234;
            this.label20.Text = "清除结果:";
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.uiTitlePanel3);
            this.tabPage4.Location = new System.Drawing.Point(0, 26);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Size = new System.Drawing.Size(303, 461);
            this.tabPage4.TabIndex = 1;
            this.tabPage4.Text = "显示设置";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // uiTitlePanel3
            // 
            this.uiTitlePanel3.Controls.Add(this.label22);
            this.uiTitlePanel3.Controls.Add(this.cpContour);
            this.uiTitlePanel3.Controls.Add(this.chxShowHObj);
            this.uiTitlePanel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.uiTitlePanel3.FillColor = System.Drawing.Color.White;
            this.uiTitlePanel3.Font = new System.Drawing.Font("华文新魏", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uiTitlePanel3.ForeColor = System.Drawing.Color.White;
            this.uiTitlePanel3.Location = new System.Drawing.Point(0, 0);
            this.uiTitlePanel3.Margin = new System.Windows.Forms.Padding(0);
            this.uiTitlePanel3.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiTitlePanel3.Name = "uiTitlePanel3";
            this.uiTitlePanel3.Padding = new System.Windows.Forms.Padding(0, 25, 0, 0);
            this.uiTitlePanel3.RadiusSides = Rex.UI.UICornerRadiusSides.None;
            this.uiTitlePanel3.RectColor = System.Drawing.Color.White;
            this.uiTitlePanel3.Size = new System.Drawing.Size(303, 356);
            this.uiTitlePanel3.Style = Rex.UI.UIStyle.Custom;
            this.uiTitlePanel3.TabIndex = 212;
            this.uiTitlePanel3.Text = "显示设置";
            this.uiTitlePanel3.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.uiTitlePanel3.TitleColor = System.Drawing.Color.CornflowerBlue;
            this.uiTitlePanel3.TitleInterval = 5;
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.BackColor = System.Drawing.Color.Transparent;
            this.label22.Font = new System.Drawing.Font("华文新魏", 11F);
            this.label22.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.label22.Location = new System.Drawing.Point(12, 78);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(73, 16);
            this.label22.TabIndex = 246;
            this.label22.Text = "轮廓颜色:";
            // 
            // cpContour
            // 
            this.cpContour.DropDownStyle = Rex.UI.UIDropDownStyle.DropDownList;
            this.cpContour.FillColor = System.Drawing.Color.AliceBlue;
            this.cpContour.FillDisableColor = System.Drawing.Color.AliceBlue;
            this.cpContour.Font = new System.Drawing.Font("微软雅黑", 9F);
            this.cpContour.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.cpContour.Location = new System.Drawing.Point(92, 75);
            this.cpContour.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cpContour.MinimumSize = new System.Drawing.Size(63, 0);
            this.cpContour.Name = "cpContour";
            this.cpContour.Padding = new System.Windows.Forms.Padding(0, 0, 30, 0);
            this.cpContour.RadiusSides = Rex.UI.UICornerRadiusSides.None;
            this.cpContour.RectColor = System.Drawing.Color.White;
            this.cpContour.RectSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.Bottom;
            this.cpContour.Size = new System.Drawing.Size(193, 23);
            this.cpContour.Style = Rex.UI.UIStyle.Custom;
            this.cpContour.StyleCustomMode = true;
            this.cpContour.TabIndex = 245;
            this.cpContour.Text = "uiColorPicker3";
            this.cpContour.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.cpContour.Value = System.Drawing.Color.DodgerBlue;
            // 
            // chxShowHObj
            // 
            this.chxShowHObj.BackColor = System.Drawing.Color.White;
            this.chxShowHObj.Checked = true;
            this.chxShowHObj.Cursor = System.Windows.Forms.Cursors.Hand;
            this.chxShowHObj.Font = new System.Drawing.Font("华文新魏", 11F);
            this.chxShowHObj.ImageSize = 14;
            this.chxShowHObj.Location = new System.Drawing.Point(10, 38);
            this.chxShowHObj.MinimumSize = new System.Drawing.Size(1, 1);
            this.chxShowHObj.Name = "chxShowHObj";
            this.chxShowHObj.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.chxShowHObj.Size = new System.Drawing.Size(211, 31);
            this.chxShowHObj.Style = Rex.UI.UIStyle.Custom;
            this.chxShowHObj.TabIndex = 234;
            this.chxShowHObj.Text = "显示轮廓";
            // 
            // ContourSelForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(850, 550);
            this.Name = "ContourSelForm";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.ContourSelForm_FormClosed);
            this.Load += new System.EventHandler(this.ContourSelForm_Load);
            this.LocationChanged += new System.EventHandler(this.ContourSelForm_LocationChanged);
            this.panel_bottom.ResumeLayout(false);
            this.panel_center.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbox_Icon)).EndInit();
            this.titlepanel.ResumeLayout(false);
            this.titlepanel.PerformLayout();
            this.uiTabControl1.ResumeLayout(false);
            this.tabPage3.ResumeLayout(false);
            this.pnlRect2Params.ResumeLayout(false);
            this.pnlRect2Params.PerformLayout();
            this.uiTitlePanel2.ResumeLayout(false);
            this.uiTitlePanel2.PerformLayout();
            this.uiTitlePanel1.ResumeLayout(false);
            this.uiTitlePanel1.PerformLayout();
            this.tabPage1.ResumeLayout(false);
            this.uiTitlePanel5.ResumeLayout(false);
            this.uiTitlePanel5.PerformLayout();
            this.tabPage4.ResumeLayout(false);
            this.uiTitlePanel3.ResumeLayout(false);
            this.uiTitlePanel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private RexView.HWindow_HE mWindowH;
        private Rex.UI.UITabControl uiTabControl1;
        private System.Windows.Forms.TabPage tabPage3;
        private Rex.UI.UITitlePanel uiTitlePanel1;
        private RexControl.MyControls.MyLinkData ldImage;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TabPage tabPage4;
        private Rex.UI.UITitlePanel pnlRect2Params;
        private RexControl.MyControls.MyTextBoxUpDownD tbxMin;
        private System.Windows.Forms.Label label1;
        private RexControl.MyControls.MyTextBoxUpDown tbxMax;
        private Rex.UI.MyComboBox cbxShape;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label3;
        private Rex.UI.UITitlePanel uiTitlePanel2;
        private RexControl.MyControls.MyLinkData ldContour;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TabPage tabPage1;
        private Rex.UI.UITitlePanel uiTitlePanel5;
        private Rex.UI.UISymbolButton btnClearResult;
        private System.Windows.Forms.Label label20;
        private Rex.UI.UITitlePanel uiTitlePanel3;
        private System.Windows.Forms.Label label22;
        private Rex.UI.UIColorPicker cpContour;
        private Rex.UI.UICheckBox chxShowHObj;
    }
}