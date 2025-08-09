
namespace Plugin.FillUpReg
{
    partial class FillUpRegForm
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
            this.pnl1Params = new Rex.UI.UITitlePanel();
            this.ld1Region = new RexControl.MyControls.MyLinkData();
            this.label5 = new System.Windows.Forms.Label();
            this.pnlDynThreshold = new Rex.UI.UITitlePanel();
            this.cbxMode = new Rex.UI.MyComboBox();
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
            this.pnl2Params = new Rex.UI.UITitlePanel();
            this.label4 = new System.Windows.Forms.Label();
            this.ld2Region = new RexControl.MyControls.MyLinkData();
            this.cbx2Feature = new Rex.UI.MyComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tbx2Max = new RexControl.MyControls.MyTextBoxUpDownD();
            this.tbx2Min = new RexControl.MyControls.MyTextBoxUpDownD();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.panel_bottom.SuspendLayout();
            this.panel_center.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbox_Icon)).BeginInit();
            this.titlepanel.SuspendLayout();
            this.uiTabControl1.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.pnl1Params.SuspendLayout();
            this.pnlDynThreshold.SuspendLayout();
            this.pnlImageInfo.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.pnl2Show.SuspendLayout();
            this.pnl2Params.SuspendLayout();
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
            this.tabPage3.Controls.Add(this.pnl2Params);
            this.tabPage3.Controls.Add(this.pnl1Params);
            this.tabPage3.Controls.Add(this.pnlDynThreshold);
            this.tabPage3.Controls.Add(this.pnlImageInfo);
            this.tabPage3.Font = new System.Drawing.Font("隶书", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tabPage3.Location = new System.Drawing.Point(0, 26);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(303, 459);
            this.tabPage3.TabIndex = 0;
            this.tabPage3.Text = "基本设置";
            // 
            // pnl1Params
            // 
            this.pnl1Params.Controls.Add(this.ld1Region);
            this.pnl1Params.Controls.Add(this.label5);
            this.pnl1Params.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnl1Params.FillColor = System.Drawing.Color.White;
            this.pnl1Params.Font = new System.Drawing.Font("华文新魏", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.pnl1Params.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            this.pnl1Params.Location = new System.Drawing.Point(0, 159);
            this.pnl1Params.Margin = new System.Windows.Forms.Padding(0);
            this.pnl1Params.MinimumSize = new System.Drawing.Size(1, 1);
            this.pnl1Params.Name = "pnl1Params";
            this.pnl1Params.Padding = new System.Windows.Forms.Padding(0, 30, 0, 0);
            this.pnl1Params.RadiusSides = Rex.UI.UICornerRadiusSides.None;
            this.pnl1Params.RectColor = System.Drawing.Color.White;
            this.pnl1Params.Size = new System.Drawing.Size(303, 72);
            this.pnl1Params.Style = Rex.UI.UIStyle.Custom;
            this.pnl1Params.TabIndex = 208;
            this.pnl1Params.Text = "参数设置";
            this.pnl1Params.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.pnl1Params.TextAlignment = System.Drawing.ContentAlignment.MiddleRight;
            this.pnl1Params.TitleColor = System.Drawing.Color.CornflowerBlue;
            this.pnl1Params.TitleInterval = 5;
            // 
            // ld1Region
            // 
            this.ld1Region.BackColor = System.Drawing.Color.AliceBlue;
            this.ld1Region.Font = new System.Drawing.Font("华文新魏", 12F);
            this.ld1Region.FontStyle = new System.Drawing.Font("华文新魏", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.ld1Region.Location = new System.Drawing.Point(91, 37);
            this.ld1Region.Margin = new System.Windows.Forms.Padding(4, 5, 4, 4);
            this.ld1Region.Name = "ld1Region";
            this.ld1Region.Size = new System.Drawing.Size(198, 24);
            this.ld1Region.TabIndex = 207;
            this.ld1Region.TextInfo = "";
            this.ld1Region.LinkData += new System.EventHandler(this.ldData_LinkData);
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
            this.label5.Text = "输入区域:";
            // 
            // pnlDynThreshold
            // 
            this.pnlDynThreshold.Controls.Add(this.cbxMode);
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
            this.pnlDynThreshold.Size = new System.Drawing.Size(303, 72);
            this.pnlDynThreshold.Style = Rex.UI.UIStyle.Custom;
            this.pnlDynThreshold.TabIndex = 204;
            this.pnlDynThreshold.Text = "填充设置";
            this.pnlDynThreshold.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.pnlDynThreshold.TextAlignment = System.Drawing.ContentAlignment.BottomCenter;
            this.pnlDynThreshold.TitleColor = System.Drawing.Color.CornflowerBlue;
            this.pnlDynThreshold.TitleInterval = 5;
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
            "孔洞填充",
            "形状填充"});
            this.cbxMode.Location = new System.Drawing.Point(86, 34);
            this.cbxMode.Margin = new System.Windows.Forms.Padding(0);
            this.cbxMode.MinimumSize = new System.Drawing.Size(63, 0);
            this.cbxMode.Name = "cbxMode";
            this.cbxMode.Padding = new System.Windows.Forms.Padding(0, 0, 30, 0);
            this.cbxMode.Radius = 2;
            this.cbxMode.RectColor = System.Drawing.Color.CornflowerBlue;
            this.cbxMode.RectDisableColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.cbxMode.RectSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.None;
            this.cbxMode.Size = new System.Drawing.Size(207, 24);
            this.cbxMode.Style = Rex.UI.UIStyle.Custom;
            this.cbxMode.StyleCustomMode = true;
            this.cbxMode.SymbolDropDown = 61656;
            this.cbxMode.SymbolNormal = 61655;
            this.cbxMode.TabIndex = 234;
            this.cbxMode.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.cbxMode.SelectedIndexChanged += new System.EventHandler(this.cbxSelect_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("华文新魏", 11F);
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.label2.Location = new System.Drawing.Point(12, 39);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 16);
            this.label2.TabIndex = 235;
            this.label2.Text = "填充方式:";
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
            this.ldImage.Location = new System.Drawing.Point(86, 43);
            this.ldImage.Margin = new System.Windows.Forms.Padding(4, 5, 4, 4);
            this.ldImage.Name = "ldImage";
            this.ldImage.Size = new System.Drawing.Size(207, 24);
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
            // pnl2Params
            // 
            this.pnl2Params.Controls.Add(this.tbx2Max);
            this.pnl2Params.Controls.Add(this.tbx2Min);
            this.pnl2Params.Controls.Add(this.label7);
            this.pnl2Params.Controls.Add(this.label8);
            this.pnl2Params.Controls.Add(this.cbx2Feature);
            this.pnl2Params.Controls.Add(this.label3);
            this.pnl2Params.Controls.Add(this.label4);
            this.pnl2Params.Controls.Add(this.ld2Region);
            this.pnl2Params.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnl2Params.FillColor = System.Drawing.Color.White;
            this.pnl2Params.Font = new System.Drawing.Font("华文新魏", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.pnl2Params.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            this.pnl2Params.Location = new System.Drawing.Point(0, 231);
            this.pnl2Params.Margin = new System.Windows.Forms.Padding(0);
            this.pnl2Params.MinimumSize = new System.Drawing.Size(1, 1);
            this.pnl2Params.Name = "pnl2Params";
            this.pnl2Params.Padding = new System.Windows.Forms.Padding(0, 30, 0, 0);
            this.pnl2Params.RadiusSides = Rex.UI.UICornerRadiusSides.None;
            this.pnl2Params.RectColor = System.Drawing.Color.White;
            this.pnl2Params.Size = new System.Drawing.Size(303, 350);
            this.pnl2Params.Style = Rex.UI.UIStyle.Custom;
            this.pnl2Params.TabIndex = 206;
            this.pnl2Params.Text = "参数设置";
            this.pnl2Params.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.pnl2Params.TextAlignment = System.Drawing.ContentAlignment.MiddleRight;
            this.pnl2Params.TitleColor = System.Drawing.Color.CornflowerBlue;
            this.pnl2Params.TitleInterval = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("华文新魏", 11F);
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.label4.Location = new System.Drawing.Point(13, 39);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(73, 16);
            this.label4.TabIndex = 196;
            this.label4.Text = "输入区域:";
            // 
            // ld2Region
            // 
            this.ld2Region.BackColor = System.Drawing.Color.AliceBlue;
            this.ld2Region.Font = new System.Drawing.Font("华文新魏", 12F);
            this.ld2Region.FontStyle = new System.Drawing.Font("华文新魏", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.ld2Region.Location = new System.Drawing.Point(91, 35);
            this.ld2Region.Margin = new System.Windows.Forms.Padding(4, 5, 4, 4);
            this.ld2Region.Name = "ld2Region";
            this.ld2Region.Size = new System.Drawing.Size(202, 24);
            this.ld2Region.TabIndex = 197;
            this.ld2Region.TextInfo = "";
            this.ld2Region.LinkData += new System.EventHandler(this.ldData_LinkData);
            // 
            // cbx2Feature
            // 
            this.cbx2Feature.BackColor = System.Drawing.Color.AliceBlue;
            this.cbx2Feature.DropDownStyle = Rex.UI.UIDropDownStyle.DropDownList;
            this.cbx2Feature.FillColor = System.Drawing.Color.AliceBlue;
            this.cbx2Feature.Font = new System.Drawing.Font("华文新魏", 11.6F);
            this.cbx2Feature.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.cbx2Feature.ForeDisableColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.cbx2Feature.Items.AddRange(new object[] {
            "area",
            "anisometry",
            "compactness",
            "convexity",
            "inner_circle",
            "outer_circle",
            "phi",
            "ra",
            "rb"});
            this.cbx2Feature.Location = new System.Drawing.Point(92, 66);
            this.cbx2Feature.Margin = new System.Windows.Forms.Padding(0);
            this.cbx2Feature.MinimumSize = new System.Drawing.Size(63, 0);
            this.cbx2Feature.Name = "cbx2Feature";
            this.cbx2Feature.Padding = new System.Windows.Forms.Padding(0, 0, 30, 0);
            this.cbx2Feature.Radius = 2;
            this.cbx2Feature.RectColor = System.Drawing.Color.CornflowerBlue;
            this.cbx2Feature.RectDisableColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.cbx2Feature.RectSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.None;
            this.cbx2Feature.Size = new System.Drawing.Size(202, 24);
            this.cbx2Feature.Style = Rex.UI.UIStyle.Custom;
            this.cbx2Feature.StyleCustomMode = true;
            this.cbx2Feature.SymbolDropDown = 61656;
            this.cbx2Feature.SymbolNormal = 61655;
            this.cbx2Feature.TabIndex = 236;
            this.cbx2Feature.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("华文新魏", 11F);
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.label3.Location = new System.Drawing.Point(13, 71);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 16);
            this.label3.TabIndex = 237;
            this.label3.Text = "形状特征:";
            // 
            // tbx2Max
            // 
            this.tbx2Max.Font = new System.Drawing.Font("华文新魏", 11F);
            this.tbx2Max.FontStyle = null;
            this.tbx2Max.Location = new System.Drawing.Point(92, 133);
            this.tbx2Max.Name = "tbx2Max";
            this.tbx2Max.Size = new System.Drawing.Size(203, 26);
            this.tbx2Max.TabIndex = 241;
            this.tbx2Max.TextInfo = "";
            // 
            // tbx2Min
            // 
            this.tbx2Min.Font = new System.Drawing.Font("华文新魏", 11F);
            this.tbx2Min.FontStyle = null;
            this.tbx2Min.Location = new System.Drawing.Point(91, 97);
            this.tbx2Min.Name = "tbx2Min";
            this.tbx2Min.Size = new System.Drawing.Size(204, 26);
            this.tbx2Min.TabIndex = 240;
            this.tbx2Min.TextInfo = "";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("华文新魏", 11F);
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.label7.Location = new System.Drawing.Point(12, 103);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(73, 16);
            this.label7.TabIndex = 238;
            this.label7.Text = "特征下限:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("华文新魏", 11F);
            this.label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.label8.Location = new System.Drawing.Point(12, 140);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(73, 16);
            this.label8.TabIndex = 239;
            this.label8.Text = "特征上限:";
            // 
            // FillUpRegForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(848, 548);
            this.Name = "FillUpRegForm";
            this.Load += new System.EventHandler(this.FillUpRegForm_Load);
            this.panel_bottom.ResumeLayout(false);
            this.panel_center.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbox_Icon)).EndInit();
            this.titlepanel.ResumeLayout(false);
            this.titlepanel.PerformLayout();
            this.uiTabControl1.ResumeLayout(false);
            this.tabPage3.ResumeLayout(false);
            this.pnl1Params.ResumeLayout(false);
            this.pnl1Params.PerformLayout();
            this.pnlDynThreshold.ResumeLayout(false);
            this.pnlDynThreshold.PerformLayout();
            this.pnlImageInfo.ResumeLayout(false);
            this.pnlImageInfo.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.pnl2Show.ResumeLayout(false);
            this.pnl2Show.PerformLayout();
            this.pnl2Params.ResumeLayout(false);
            this.pnl2Params.PerformLayout();
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
        private Rex.UI.MyComboBox cbxDraw;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label1;
        private Rex.UI.UIColorPicker cpColor;
        private Rex.UI.MyComboBox cbxMode;
        private System.Windows.Forms.Label label2;
        private Rex.UI.UITitlePanel pnl1Params;
        private RexControl.MyControls.MyLinkData ld1Region;
        private System.Windows.Forms.Label label5;
        private Rex.UI.UITitlePanel pnl2Params;
        private Rex.UI.MyComboBox cbx2Feature;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private RexControl.MyControls.MyLinkData ld2Region;
        private RexControl.MyControls.MyTextBoxUpDownD tbx2Max;
        private RexControl.MyControls.MyTextBoxUpDownD tbx2Min;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
    }
}