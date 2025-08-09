
namespace Plugin.ThresholdSeg
{
    partial class ThresholdSegForm
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
            this.pnlVarThreshold = new Rex.UI.UITitlePanel();
            this.cbx3RegFeature = new Rex.UI.MyComboBox();
            this.tbx3StdDevScale = new RexControl.MyControls.MyTextBoxUpDownD();
            this.label13 = new System.Windows.Forms.Label();
            this.tbx3AbsThreshold = new RexControl.MyControls.MyTextBoxUpDown();
            this.label14 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.tbx3Mask3Height = new RexControl.MyControls.MyTextBoxUpDown();
            this.label6 = new System.Windows.Forms.Label();
            this.tbx3MaskWidth = new RexControl.MyControls.MyTextBoxUpDown();
            this.label11 = new System.Windows.Forms.Label();
            this.pnlDynThreshold = new Rex.UI.UITitlePanel();
            this.cbx2RegFeature = new Rex.UI.MyComboBox();
            this.ld2FilterImage = new RexControl.MyControls.MyLinkData();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tbx2Offset = new RexControl.MyControls.MyTextBoxUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.pnlThreshold = new Rex.UI.UITitlePanel();
            this.ld1ThresholdMax = new RexControl.MyControls.MyLinkData();
            this.ld1ThresholdMin = new RexControl.MyControls.MyLinkData();
            this.label10 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.uiTitlePanel1 = new Rex.UI.UITitlePanel();
            this.cbxMode = new Rex.UI.MyComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.pnlImageInfo = new Rex.UI.UITitlePanel();
            this.ldImage = new RexControl.MyControls.MyLinkData();
            this.label12 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.pnl2Show = new Rex.UI.UITitlePanel();
            this.cbxDraw = new Rex.UI.MyComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.cpColor = new Rex.UI.UIColorPicker();
            this.chxShow = new Rex.UI.UICheckBox();
            this.panel_bottom.SuspendLayout();
            this.panel_center.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbox_Icon)).BeginInit();
            this.titlepanel.SuspendLayout();
            this.uiTabControl1.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.pnlVarThreshold.SuspendLayout();
            this.pnlDynThreshold.SuspendLayout();
            this.pnlThreshold.SuspendLayout();
            this.uiTitlePanel1.SuspendLayout();
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
            this.tabPage3.Controls.Add(this.pnlVarThreshold);
            this.tabPage3.Controls.Add(this.pnlDynThreshold);
            this.tabPage3.Controls.Add(this.pnlThreshold);
            this.tabPage3.Controls.Add(this.uiTitlePanel1);
            this.tabPage3.Controls.Add(this.pnlImageInfo);
            this.tabPage3.Font = new System.Drawing.Font("隶书", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tabPage3.Location = new System.Drawing.Point(0, 26);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(303, 459);
            this.tabPage3.TabIndex = 0;
            this.tabPage3.Text = "基本设置";
            // 
            // pnlVarThreshold
            // 
            this.pnlVarThreshold.Controls.Add(this.cbx3RegFeature);
            this.pnlVarThreshold.Controls.Add(this.tbx3StdDevScale);
            this.pnlVarThreshold.Controls.Add(this.label13);
            this.pnlVarThreshold.Controls.Add(this.tbx3AbsThreshold);
            this.pnlVarThreshold.Controls.Add(this.label14);
            this.pnlVarThreshold.Controls.Add(this.label5);
            this.pnlVarThreshold.Controls.Add(this.tbx3Mask3Height);
            this.pnlVarThreshold.Controls.Add(this.label6);
            this.pnlVarThreshold.Controls.Add(this.tbx3MaskWidth);
            this.pnlVarThreshold.Controls.Add(this.label11);
            this.pnlVarThreshold.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlVarThreshold.FillColor = System.Drawing.Color.White;
            this.pnlVarThreshold.Font = new System.Drawing.Font("华文新魏", 12F);
            this.pnlVarThreshold.ForeColor = System.Drawing.Color.White;
            this.pnlVarThreshold.Location = new System.Drawing.Point(0, 431);
            this.pnlVarThreshold.Margin = new System.Windows.Forms.Padding(0);
            this.pnlVarThreshold.MinimumSize = new System.Drawing.Size(1, 1);
            this.pnlVarThreshold.Name = "pnlVarThreshold";
            this.pnlVarThreshold.Padding = new System.Windows.Forms.Padding(3, 25, 3, 0);
            this.pnlVarThreshold.RadiusSides = Rex.UI.UICornerRadiusSides.None;
            this.pnlVarThreshold.RectColor = System.Drawing.Color.White;
            this.pnlVarThreshold.Size = new System.Drawing.Size(303, 228);
            this.pnlVarThreshold.Style = Rex.UI.UIStyle.Custom;
            this.pnlVarThreshold.TabIndex = 205;
            this.pnlVarThreshold.Text = "参数设置";
            this.pnlVarThreshold.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.pnlVarThreshold.TextAlignment = System.Drawing.ContentAlignment.BottomCenter;
            this.pnlVarThreshold.TitleColor = System.Drawing.Color.CornflowerBlue;
            this.pnlVarThreshold.TitleInterval = 5;
            // 
            // cbx3RegFeature
            // 
            this.cbx3RegFeature.BackColor = System.Drawing.Color.AliceBlue;
            this.cbx3RegFeature.DropDownStyle = Rex.UI.UIDropDownStyle.DropDownList;
            this.cbx3RegFeature.FillColor = System.Drawing.Color.AliceBlue;
            this.cbx3RegFeature.Font = new System.Drawing.Font("华文新魏", 11.6F);
            this.cbx3RegFeature.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.cbx3RegFeature.ForeDisableColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.cbx3RegFeature.Items.AddRange(new object[] {
            "dark",
            "equal",
            "light",
            "not_equal"});
            this.cbx3RegFeature.Location = new System.Drawing.Point(85, 183);
            this.cbx3RegFeature.Margin = new System.Windows.Forms.Padding(0);
            this.cbx3RegFeature.MinimumSize = new System.Drawing.Size(63, 0);
            this.cbx3RegFeature.Name = "cbx3RegFeature";
            this.cbx3RegFeature.Padding = new System.Windows.Forms.Padding(0, 0, 30, 0);
            this.cbx3RegFeature.Radius = 2;
            this.cbx3RegFeature.RectColor = System.Drawing.Color.CornflowerBlue;
            this.cbx3RegFeature.RectDisableColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.cbx3RegFeature.RectSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.None;
            this.cbx3RegFeature.Size = new System.Drawing.Size(208, 24);
            this.cbx3RegFeature.Style = Rex.UI.UIStyle.Custom;
            this.cbx3RegFeature.StyleCustomMode = true;
            this.cbx3RegFeature.SymbolDropDown = 61656;
            this.cbx3RegFeature.SymbolNormal = 61655;
            this.cbx3RegFeature.TabIndex = 230;
            this.cbx3RegFeature.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // tbx3StdDevScale
            // 
            this.tbx3StdDevScale.Font = new System.Drawing.Font("华文新魏", 11F);
            this.tbx3StdDevScale.FontStyle = null;
            this.tbx3StdDevScale.Location = new System.Drawing.Point(85, 110);
            this.tbx3StdDevScale.Name = "tbx3StdDevScale";
            this.tbx3StdDevScale.Size = new System.Drawing.Size(210, 26);
            this.tbx3StdDevScale.TabIndex = 226;
            this.tbx3StdDevScale.TextInfo = "";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.BackColor = System.Drawing.Color.Transparent;
            this.label13.Font = new System.Drawing.Font("华文新魏", 11F);
            this.label13.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.label13.Location = new System.Drawing.Point(12, 188);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(73, 16);
            this.label13.TabIndex = 207;
            this.label13.Text = "区域特征:";
            // 
            // tbx3AbsThreshold
            // 
            this.tbx3AbsThreshold.BackColor = System.Drawing.Color.White;
            this.tbx3AbsThreshold.FontStyle = null;
            this.tbx3AbsThreshold.Location = new System.Drawing.Point(85, 146);
            this.tbx3AbsThreshold.Name = "tbx3AbsThreshold";
            this.tbx3AbsThreshold.Size = new System.Drawing.Size(208, 25);
            this.tbx3AbsThreshold.TabIndex = 194;
            this.tbx3AbsThreshold.TextInfo = "";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.BackColor = System.Drawing.Color.Transparent;
            this.label14.Font = new System.Drawing.Font("华文新魏", 11F);
            this.label14.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.label14.Location = new System.Drawing.Point(12, 116);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(73, 16);
            this.label14.TabIndex = 225;
            this.label14.Text = "方差因子:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("华文新魏", 11F);
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.label5.Location = new System.Drawing.Point(12, 151);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(73, 16);
            this.label5.TabIndex = 195;
            this.label5.Text = "平均差值:";
            // 
            // tbx3Mask3Height
            // 
            this.tbx3Mask3Height.BackColor = System.Drawing.Color.White;
            this.tbx3Mask3Height.FontStyle = null;
            this.tbx3Mask3Height.Location = new System.Drawing.Point(85, 75);
            this.tbx3Mask3Height.Name = "tbx3Mask3Height";
            this.tbx3Mask3Height.Size = new System.Drawing.Size(208, 25);
            this.tbx3Mask3Height.TabIndex = 192;
            this.tbx3Mask3Height.TextInfo = "";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("华文新魏", 11F);
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.label6.Location = new System.Drawing.Point(12, 81);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(73, 16);
            this.label6.TabIndex = 193;
            this.label6.Text = "掩模高度:";
            // 
            // tbx3MaskWidth
            // 
            this.tbx3MaskWidth.BackColor = System.Drawing.Color.White;
            this.tbx3MaskWidth.FontStyle = null;
            this.tbx3MaskWidth.Location = new System.Drawing.Point(85, 40);
            this.tbx3MaskWidth.Name = "tbx3MaskWidth";
            this.tbx3MaskWidth.Size = new System.Drawing.Size(208, 25);
            this.tbx3MaskWidth.TabIndex = 21;
            this.tbx3MaskWidth.TextInfo = "";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.Transparent;
            this.label11.Font = new System.Drawing.Font("华文新魏", 11F);
            this.label11.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.label11.Location = new System.Drawing.Point(12, 46);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(73, 16);
            this.label11.TabIndex = 191;
            this.label11.Text = "掩模宽度:";
            // 
            // pnlDynThreshold
            // 
            this.pnlDynThreshold.Controls.Add(this.cbx2RegFeature);
            this.pnlDynThreshold.Controls.Add(this.ld2FilterImage);
            this.pnlDynThreshold.Controls.Add(this.label4);
            this.pnlDynThreshold.Controls.Add(this.label2);
            this.pnlDynThreshold.Controls.Add(this.tbx2Offset);
            this.pnlDynThreshold.Controls.Add(this.label3);
            this.pnlDynThreshold.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlDynThreshold.FillColor = System.Drawing.Color.White;
            this.pnlDynThreshold.Font = new System.Drawing.Font("华文新魏", 12F);
            this.pnlDynThreshold.ForeColor = System.Drawing.Color.White;
            this.pnlDynThreshold.Location = new System.Drawing.Point(0, 284);
            this.pnlDynThreshold.Margin = new System.Windows.Forms.Padding(0);
            this.pnlDynThreshold.MinimumSize = new System.Drawing.Size(1, 1);
            this.pnlDynThreshold.Name = "pnlDynThreshold";
            this.pnlDynThreshold.Padding = new System.Windows.Forms.Padding(3, 25, 3, 0);
            this.pnlDynThreshold.RadiusSides = Rex.UI.UICornerRadiusSides.None;
            this.pnlDynThreshold.RectColor = System.Drawing.Color.White;
            this.pnlDynThreshold.Size = new System.Drawing.Size(303, 147);
            this.pnlDynThreshold.Style = Rex.UI.UIStyle.Custom;
            this.pnlDynThreshold.TabIndex = 204;
            this.pnlDynThreshold.Text = "参数设置";
            this.pnlDynThreshold.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.pnlDynThreshold.TextAlignment = System.Drawing.ContentAlignment.BottomCenter;
            this.pnlDynThreshold.TitleColor = System.Drawing.Color.CornflowerBlue;
            this.pnlDynThreshold.TitleInterval = 5;
            // 
            // cbx2RegFeature
            // 
            this.cbx2RegFeature.BackColor = System.Drawing.Color.AliceBlue;
            this.cbx2RegFeature.DropDownStyle = Rex.UI.UIDropDownStyle.DropDownList;
            this.cbx2RegFeature.FillColor = System.Drawing.Color.AliceBlue;
            this.cbx2RegFeature.Font = new System.Drawing.Font("华文新魏", 11.6F);
            this.cbx2RegFeature.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.cbx2RegFeature.ForeDisableColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.cbx2RegFeature.Items.AddRange(new object[] {
            "dark",
            "equal",
            "light",
            "not_equal"});
            this.cbx2RegFeature.Location = new System.Drawing.Point(85, 110);
            this.cbx2RegFeature.Margin = new System.Windows.Forms.Padding(0);
            this.cbx2RegFeature.MinimumSize = new System.Drawing.Size(63, 0);
            this.cbx2RegFeature.Name = "cbx2RegFeature";
            this.cbx2RegFeature.Padding = new System.Windows.Forms.Padding(0, 0, 30, 0);
            this.cbx2RegFeature.Radius = 2;
            this.cbx2RegFeature.RectColor = System.Drawing.Color.CornflowerBlue;
            this.cbx2RegFeature.RectDisableColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.cbx2RegFeature.RectSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.None;
            this.cbx2RegFeature.Size = new System.Drawing.Size(208, 24);
            this.cbx2RegFeature.Style = Rex.UI.UIStyle.Custom;
            this.cbx2RegFeature.StyleCustomMode = true;
            this.cbx2RegFeature.SymbolDropDown = 61656;
            this.cbx2RegFeature.SymbolNormal = 61655;
            this.cbx2RegFeature.TabIndex = 229;
            this.cbx2RegFeature.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // ld2FilterImage
            // 
            this.ld2FilterImage.BackColor = System.Drawing.Color.AliceBlue;
            this.ld2FilterImage.Font = new System.Drawing.Font("华文新魏", 12F);
            this.ld2FilterImage.FontStyle = new System.Drawing.Font("华文新魏", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.ld2FilterImage.Location = new System.Drawing.Point(85, 40);
            this.ld2FilterImage.Margin = new System.Windows.Forms.Padding(4, 5, 4, 4);
            this.ld2FilterImage.Name = "ld2FilterImage";
            this.ld2FilterImage.Size = new System.Drawing.Size(208, 24);
            this.ld2FilterImage.TabIndex = 197;
            this.ld2FilterImage.TextInfo = "";
            this.ld2FilterImage.LinkData += new System.EventHandler(this.ldImage_LinkData);
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
            this.label4.Text = "滤波图像:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("华文新魏", 11F);
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.label2.Location = new System.Drawing.Point(12, 116);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 16);
            this.label2.TabIndex = 193;
            this.label2.Text = "区域特征:";
            // 
            // tbx2Offset
            // 
            this.tbx2Offset.BackColor = System.Drawing.Color.White;
            this.tbx2Offset.FontStyle = null;
            this.tbx2Offset.Location = new System.Drawing.Point(85, 74);
            this.tbx2Offset.Name = "tbx2Offset";
            this.tbx2Offset.Size = new System.Drawing.Size(208, 25);
            this.tbx2Offset.TabIndex = 21;
            this.tbx2Offset.TextInfo = "";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("华文新魏", 11F);
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.label3.Location = new System.Drawing.Point(12, 80);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 16);
            this.label3.TabIndex = 191;
            this.label3.Text = "阈值偏差:";
            // 
            // pnlThreshold
            // 
            this.pnlThreshold.Controls.Add(this.ld1ThresholdMax);
            this.pnlThreshold.Controls.Add(this.ld1ThresholdMin);
            this.pnlThreshold.Controls.Add(this.label10);
            this.pnlThreshold.Controls.Add(this.label8);
            this.pnlThreshold.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlThreshold.FillColor = System.Drawing.Color.White;
            this.pnlThreshold.Font = new System.Drawing.Font("华文新魏", 12F);
            this.pnlThreshold.ForeColor = System.Drawing.Color.White;
            this.pnlThreshold.Location = new System.Drawing.Point(0, 169);
            this.pnlThreshold.Margin = new System.Windows.Forms.Padding(0);
            this.pnlThreshold.MinimumSize = new System.Drawing.Size(1, 1);
            this.pnlThreshold.Name = "pnlThreshold";
            this.pnlThreshold.Padding = new System.Windows.Forms.Padding(3, 25, 3, 0);
            this.pnlThreshold.RadiusSides = Rex.UI.UICornerRadiusSides.None;
            this.pnlThreshold.RectColor = System.Drawing.Color.White;
            this.pnlThreshold.Size = new System.Drawing.Size(303, 115);
            this.pnlThreshold.Style = Rex.UI.UIStyle.Custom;
            this.pnlThreshold.TabIndex = 203;
            this.pnlThreshold.Text = "参数设置";
            this.pnlThreshold.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.pnlThreshold.TextAlignment = System.Drawing.ContentAlignment.BottomCenter;
            this.pnlThreshold.TitleColor = System.Drawing.Color.CornflowerBlue;
            this.pnlThreshold.TitleInterval = 5;
            // 
            // ld1ThresholdMax
            // 
            this.ld1ThresholdMax.BackColor = System.Drawing.Color.AliceBlue;
            this.ld1ThresholdMax.Font = new System.Drawing.Font("华文新魏", 12F);
            this.ld1ThresholdMax.FontStyle = new System.Drawing.Font("华文新魏", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.ld1ThresholdMax.Location = new System.Drawing.Point(85, 78);
            this.ld1ThresholdMax.Margin = new System.Windows.Forms.Padding(4, 5, 4, 4);
            this.ld1ThresholdMax.Name = "ld1ThresholdMax";
            this.ld1ThresholdMax.Size = new System.Drawing.Size(208, 24);
            this.ld1ThresholdMax.TabIndex = 199;
            this.ld1ThresholdMax.TextInfo = "";
            this.ld1ThresholdMax.LinkData += new System.EventHandler(this.ldDouble_LinkData);
            // 
            // ld1ThresholdMin
            // 
            this.ld1ThresholdMin.BackColor = System.Drawing.Color.AliceBlue;
            this.ld1ThresholdMin.Font = new System.Drawing.Font("华文新魏", 12F);
            this.ld1ThresholdMin.FontStyle = new System.Drawing.Font("华文新魏", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.ld1ThresholdMin.Location = new System.Drawing.Point(85, 41);
            this.ld1ThresholdMin.Margin = new System.Windows.Forms.Padding(4, 5, 4, 4);
            this.ld1ThresholdMin.Name = "ld1ThresholdMin";
            this.ld1ThresholdMin.Size = new System.Drawing.Size(208, 24);
            this.ld1ThresholdMin.TabIndex = 198;
            this.ld1ThresholdMin.TextInfo = "";
            this.ld1ThresholdMin.LinkData += new System.EventHandler(this.ldDouble_LinkData);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.Font = new System.Drawing.Font("华文新魏", 11F);
            this.label10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.label10.Location = new System.Drawing.Point(12, 84);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(73, 16);
            this.label10.TabIndex = 193;
            this.label10.Text = "阈值上限:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("华文新魏", 11F);
            this.label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.label8.Location = new System.Drawing.Point(12, 47);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(73, 16);
            this.label8.TabIndex = 191;
            this.label8.Text = "阈值下限:";
            // 
            // uiTitlePanel1
            // 
            this.uiTitlePanel1.Controls.Add(this.cbxMode);
            this.uiTitlePanel1.Controls.Add(this.label7);
            this.uiTitlePanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.uiTitlePanel1.FillColor = System.Drawing.Color.White;
            this.uiTitlePanel1.Font = new System.Drawing.Font("华文新魏", 12F);
            this.uiTitlePanel1.ForeColor = System.Drawing.Color.White;
            this.uiTitlePanel1.Location = new System.Drawing.Point(0, 87);
            this.uiTitlePanel1.Margin = new System.Windows.Forms.Padding(0);
            this.uiTitlePanel1.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiTitlePanel1.Name = "uiTitlePanel1";
            this.uiTitlePanel1.Padding = new System.Windows.Forms.Padding(3, 25, 3, 0);
            this.uiTitlePanel1.RadiusSides = Rex.UI.UICornerRadiusSides.None;
            this.uiTitlePanel1.RectColor = System.Drawing.Color.White;
            this.uiTitlePanel1.Size = new System.Drawing.Size(303, 82);
            this.uiTitlePanel1.Style = Rex.UI.UIStyle.Custom;
            this.uiTitlePanel1.TabIndex = 202;
            this.uiTitlePanel1.Text = "模式选择";
            this.uiTitlePanel1.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.uiTitlePanel1.TextAlignment = System.Drawing.ContentAlignment.BottomCenter;
            this.uiTitlePanel1.TitleColor = System.Drawing.Color.CornflowerBlue;
            this.uiTitlePanel1.TitleInterval = 5;
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
            "普通",
            "动态",
            "局部"});
            this.cbxMode.Location = new System.Drawing.Point(85, 41);
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
            this.cbxMode.TabIndex = 228;
            this.cbxMode.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.cbxMode.SelectedIndexChanged += new System.EventHandler(this.cbxSelect_SelectedIndexChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("华文新魏", 11F);
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.label7.Location = new System.Drawing.Point(12, 46);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(73, 16);
            this.label7.TabIndex = 227;
            this.label7.Text = "模式选择:";
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
            this.ldImage.LinkData += new System.EventHandler(this.ldImage_LinkData);
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
            this.pnl2Show.Controls.Add(this.cbxDraw);
            this.pnl2Show.Controls.Add(this.label1);
            this.pnl2Show.Controls.Add(this.label9);
            this.pnl2Show.Controls.Add(this.cpColor);
            this.pnl2Show.Controls.Add(this.chxShow);
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
            this.cbxDraw.Location = new System.Drawing.Point(59, 66);
            this.cbxDraw.Margin = new System.Windows.Forms.Padding(0);
            this.cbxDraw.MinimumSize = new System.Drawing.Size(63, 0);
            this.cbxDraw.Name = "cbxDraw";
            this.cbxDraw.Padding = new System.Windows.Forms.Padding(0, 0, 30, 0);
            this.cbxDraw.Radius = 2;
            this.cbxDraw.RectColor = System.Drawing.Color.CornflowerBlue;
            this.cbxDraw.RectDisableColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.cbxDraw.RectSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.None;
            this.cbxDraw.Size = new System.Drawing.Size(233, 24);
            this.cbxDraw.Style = Rex.UI.UIStyle.Custom;
            this.cbxDraw.StyleCustomMode = true;
            this.cbxDraw.SymbolDropDown = 61656;
            this.cbxDraw.SymbolNormal = 61655;
            this.cbxDraw.TabIndex = 230;
            this.cbxDraw.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.cbxDraw.SelectedIndexChanged += new System.EventHandler(this.cbxDraw_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("华文新魏", 11F);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.label1.Location = new System.Drawing.Point(13, 108);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 16);
            this.label1.TabIndex = 193;
            this.label1.Text = "颜色:";
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
            this.label9.TabIndex = 229;
            this.label9.Text = "形态:";
            // 
            // cpColor
            // 
            this.cpColor.DropDownStyle = Rex.UI.UIDropDownStyle.DropDownList;
            this.cpColor.FillColor = System.Drawing.Color.AliceBlue;
            this.cpColor.FillDisableColor = System.Drawing.Color.AliceBlue;
            this.cpColor.Font = new System.Drawing.Font("微软雅黑", 9F);
            this.cpColor.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.cpColor.Location = new System.Drawing.Point(59, 103);
            this.cpColor.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cpColor.MinimumSize = new System.Drawing.Size(63, 0);
            this.cpColor.Name = "cpColor";
            this.cpColor.Padding = new System.Windows.Forms.Padding(0, 0, 30, 0);
            this.cpColor.RadiusSides = Rex.UI.UICornerRadiusSides.None;
            this.cpColor.RectColor = System.Drawing.Color.White;
            this.cpColor.RectSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.Bottom;
            this.cpColor.Size = new System.Drawing.Size(233, 23);
            this.cpColor.Style = Rex.UI.UIStyle.Custom;
            this.cpColor.StyleCustomMode = true;
            this.cpColor.TabIndex = 192;
            this.cpColor.Text = "uiColorPicker1";
            this.cpColor.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.cpColor.Value = System.Drawing.Color.MediumPurple;
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
            this.chxShow.Text = "显示区域";
            // 
            // ThresholdSegForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(848, 548);
            this.Name = "ThresholdSegForm";
            this.Load += new System.EventHandler(this.ThresholdSegForm_Load);
            this.panel_bottom.ResumeLayout(false);
            this.panel_center.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbox_Icon)).EndInit();
            this.titlepanel.ResumeLayout(false);
            this.titlepanel.PerformLayout();
            this.uiTabControl1.ResumeLayout(false);
            this.tabPage3.ResumeLayout(false);
            this.pnlVarThreshold.ResumeLayout(false);
            this.pnlVarThreshold.PerformLayout();
            this.pnlDynThreshold.ResumeLayout(false);
            this.pnlDynThreshold.PerformLayout();
            this.pnlThreshold.ResumeLayout(false);
            this.pnlThreshold.PerformLayout();
            this.uiTitlePanel1.ResumeLayout(false);
            this.uiTitlePanel1.PerformLayout();
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
        private System.Windows.Forms.Label label1;
        private Rex.UI.UIColorPicker cpColor;
        private Rex.UI.UITitlePanel uiTitlePanel1;
        private Rex.UI.UITitlePanel pnlImageInfo;
        private RexControl.MyControls.MyLinkData ldImage;
        private System.Windows.Forms.Label label12;
        private Rex.UI.UITitlePanel pnlVarThreshold;
        private RexControl.MyControls.MyTextBoxUpDown tbx3AbsThreshold;
        private System.Windows.Forms.Label label5;
        private RexControl.MyControls.MyTextBoxUpDown tbx3Mask3Height;
        private System.Windows.Forms.Label label6;
        private RexControl.MyControls.MyTextBoxUpDown tbx3MaskWidth;
        private System.Windows.Forms.Label label11;
        private Rex.UI.UITitlePanel pnlDynThreshold;
        private RexControl.MyControls.MyLinkData ld2FilterImage;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private RexControl.MyControls.MyTextBoxUpDown tbx2Offset;
        private System.Windows.Forms.Label label3;
        private Rex.UI.UITitlePanel pnlThreshold;
        private RexControl.MyControls.MyLinkData ld1ThresholdMax;
        private RexControl.MyControls.MyLinkData ld1ThresholdMin;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label8;
        private Rex.UI.MyComboBox cbxMode;
        private System.Windows.Forms.Label label7;
        private Rex.UI.MyComboBox cbx3RegFeature;
        private RexControl.MyControls.MyTextBoxUpDownD tbx3StdDevScale;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private Rex.UI.MyComboBox cbx2RegFeature;
        private Rex.UI.MyComboBox cbxDraw;
        private System.Windows.Forms.Label label9;
    }
}