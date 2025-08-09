
namespace Plugin.PartRectangle
{
    partial class PartRectangleForm
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
            this.pnlDynThreshold = new Rex.UI.UITitlePanel();
            this.label2 = new System.Windows.Forms.Label();
            this.pnl1Params = new Rex.UI.UITitlePanel();
            this.ldRegion = new RexControl.MyControls.MyLinkData();
            this.label5 = new System.Windows.Forms.Label();
            this.pnlImageInfo = new Rex.UI.UITitlePanel();
            this.ldImage = new RexControl.MyControls.MyLinkData();
            this.label12 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.uiTitlePanel8 = new Rex.UI.UITitlePanel();
            this.cbxDraw = new Rex.UI.MyComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.cpColor = new Rex.UI.UIColorPicker();
            this.chxShowResult = new Rex.UI.UICheckBox();
            this.tbxWidth = new RexControl.MyControls.MyTextBoxUpDownD();
            this.tbxHeight = new RexControl.MyControls.MyTextBoxUpDownD();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.panel_bottom.SuspendLayout();
            this.panel_center.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbox_Icon)).BeginInit();
            this.titlepanel.SuspendLayout();
            this.uiTabControl1.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.pnlDynThreshold.SuspendLayout();
            this.pnl1Params.SuspendLayout();
            this.pnlImageInfo.SuspendLayout();
            this.tabPage2.SuspendLayout();
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
            this.tabPage3.Controls.Add(this.tbxHeight);
            this.tabPage3.Controls.Add(this.pnlDynThreshold);
            this.tabPage3.Controls.Add(this.label1);
            this.tabPage3.Controls.Add(this.pnl1Params);
            this.tabPage3.Controls.Add(this.pnlImageInfo);
            this.tabPage3.Font = new System.Drawing.Font("隶书", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tabPage3.Location = new System.Drawing.Point(0, 26);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(303, 459);
            this.tabPage3.TabIndex = 0;
            this.tabPage3.Text = "基本设置";
            // 
            // pnlDynThreshold
            // 
            this.pnlDynThreshold.Controls.Add(this.label3);
            this.pnlDynThreshold.Controls.Add(this.tbxWidth);
            this.pnlDynThreshold.Controls.Add(this.label2);
            this.pnlDynThreshold.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlDynThreshold.FillColor = System.Drawing.Color.White;
            this.pnlDynThreshold.Font = new System.Drawing.Font("华文新魏", 12F);
            this.pnlDynThreshold.ForeColor = System.Drawing.Color.White;
            this.pnlDynThreshold.Location = new System.Drawing.Point(0, 165);
            this.pnlDynThreshold.Margin = new System.Windows.Forms.Padding(0);
            this.pnlDynThreshold.MinimumSize = new System.Drawing.Size(1, 1);
            this.pnlDynThreshold.Name = "pnlDynThreshold";
            this.pnlDynThreshold.Padding = new System.Windows.Forms.Padding(3, 25, 3, 0);
            this.pnlDynThreshold.RadiusSides = Rex.UI.UICornerRadiusSides.None;
            this.pnlDynThreshold.RectColor = System.Drawing.Color.White;
            this.pnlDynThreshold.Size = new System.Drawing.Size(303, 91);
            this.pnlDynThreshold.Style = Rex.UI.UIStyle.Custom;
            this.pnlDynThreshold.TabIndex = 209;
            this.pnlDynThreshold.Text = "参数设置";
            this.pnlDynThreshold.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.pnlDynThreshold.TextAlignment = System.Drawing.ContentAlignment.BottomCenter;
            this.pnlDynThreshold.TitleColor = System.Drawing.Color.CornflowerBlue;
            this.pnlDynThreshold.TitleInterval = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("华文新魏", 11F);
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.label2.Location = new System.Drawing.Point(12, 42);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 16);
            this.label2.TabIndex = 235;
            this.label2.Text = "矩形宽度:";
            // 
            // pnl1Params
            // 
            this.pnl1Params.Controls.Add(this.ldRegion);
            this.pnl1Params.Controls.Add(this.label5);
            this.pnl1Params.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnl1Params.FillColor = System.Drawing.Color.White;
            this.pnl1Params.Font = new System.Drawing.Font("华文新魏", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.pnl1Params.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            this.pnl1Params.Location = new System.Drawing.Point(0, 87);
            this.pnl1Params.Margin = new System.Windows.Forms.Padding(0);
            this.pnl1Params.MinimumSize = new System.Drawing.Size(1, 1);
            this.pnl1Params.Name = "pnl1Params";
            this.pnl1Params.Padding = new System.Windows.Forms.Padding(0, 30, 0, 0);
            this.pnl1Params.RadiusSides = Rex.UI.UICornerRadiusSides.None;
            this.pnl1Params.RectColor = System.Drawing.Color.White;
            this.pnl1Params.Size = new System.Drawing.Size(303, 78);
            this.pnl1Params.Style = Rex.UI.UIStyle.Custom;
            this.pnl1Params.TabIndex = 208;
            this.pnl1Params.Text = "输入区域";
            this.pnl1Params.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.pnl1Params.TextAlignment = System.Drawing.ContentAlignment.MiddleRight;
            this.pnl1Params.TitleColor = System.Drawing.Color.CornflowerBlue;
            this.pnl1Params.TitleInterval = 5;
            // 
            // ldRegion
            // 
            this.ldRegion.BackColor = System.Drawing.Color.AliceBlue;
            this.ldRegion.Font = new System.Drawing.Font("华文新魏", 12F);
            this.ldRegion.FontStyle = new System.Drawing.Font("华文新魏", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.ldRegion.Location = new System.Drawing.Point(86, 37);
            this.ldRegion.Margin = new System.Windows.Forms.Padding(4, 5, 4, 4);
            this.ldRegion.Name = "ldRegion";
            this.ldRegion.Size = new System.Drawing.Size(207, 24);
            this.ldRegion.TabIndex = 207;
            this.ldRegion.TextInfo = "";
            this.ldRegion.LinkData += new System.EventHandler(this.ldData_LinkData);
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
            this.tabPage2.Controls.Add(this.uiTitlePanel8);
            this.tabPage2.Location = new System.Drawing.Point(0, 26);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Size = new System.Drawing.Size(303, 459);
            this.tabPage2.TabIndex = 3;
            this.tabPage2.Text = "显示设置";
            // 
            // uiTitlePanel8
            // 
            this.uiTitlePanel8.Controls.Add(this.cbxDraw);
            this.uiTitlePanel8.Controls.Add(this.label9);
            this.uiTitlePanel8.Controls.Add(this.label7);
            this.uiTitlePanel8.Controls.Add(this.cpColor);
            this.uiTitlePanel8.Controls.Add(this.chxShowResult);
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
            this.uiTitlePanel8.Text = "窗口选择";
            this.uiTitlePanel8.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.uiTitlePanel8.TitleColor = System.Drawing.Color.CornflowerBlue;
            this.uiTitlePanel8.TitleInterval = 5;
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
            this.cbxDraw.Location = new System.Drawing.Point(59, 65);
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
            this.cbxDraw.TabIndex = 237;
            this.cbxDraw.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.cbxDraw.SelectedIndexChanged += new System.EventHandler(this.cbxDraw_SelectedIndexChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("华文新魏", 11F);
            this.label9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.label9.Location = new System.Drawing.Point(13, 70);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(43, 16);
            this.label9.TabIndex = 236;
            this.label9.Text = "形态:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("华文新魏", 11F);
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.label7.Location = new System.Drawing.Point(13, 104);
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
            this.cpColor.Location = new System.Drawing.Point(59, 98);
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
            this.cpColor.TabIndex = 200;
            this.cpColor.Text = "uiColorPicker1";
            this.cpColor.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.cpColor.Value = System.Drawing.Color.DodgerBlue;
            // 
            // chxShowResult
            // 
            this.chxShowResult.BackColor = System.Drawing.Color.White;
            this.chxShowResult.Checked = true;
            this.chxShowResult.Cursor = System.Windows.Forms.Cursors.Hand;
            this.chxShowResult.Font = new System.Drawing.Font("华文新魏", 11F);
            this.chxShowResult.ImageSize = 14;
            this.chxShowResult.Location = new System.Drawing.Point(13, 41);
            this.chxShowResult.MinimumSize = new System.Drawing.Size(1, 1);
            this.chxShowResult.Name = "chxShowResult";
            this.chxShowResult.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.chxShowResult.Size = new System.Drawing.Size(211, 16);
            this.chxShowResult.Style = Rex.UI.UIStyle.Custom;
            this.chxShowResult.TabIndex = 198;
            this.chxShowResult.Text = "显示区域";
            // 
            // tbxWidth
            // 
            this.tbxWidth.Font = new System.Drawing.Font("华文新魏", 11F);
            this.tbxWidth.FontStyle = null;
            this.tbxWidth.Location = new System.Drawing.Point(86, 36);
            this.tbxWidth.Name = "tbxWidth";
            this.tbxWidth.Size = new System.Drawing.Size(207, 24);
            this.tbxWidth.TabIndex = 212;
            this.tbxWidth.TextInfo = "";
            // 
            // tbxHeight
            // 
            this.tbxHeight.Font = new System.Drawing.Font("华文新魏", 11F);
            this.tbxHeight.FontStyle = null;
            this.tbxHeight.Location = new System.Drawing.Point(86, 234);
            this.tbxHeight.Name = "tbxHeight";
            this.tbxHeight.Size = new System.Drawing.Size(207, 24);
            this.tbxHeight.TabIndex = 236;
            this.tbxHeight.TextInfo = "";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("华文新魏", 11F);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.label1.Location = new System.Drawing.Point(12, 240);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 16);
            this.label1.TabIndex = 237;
            this.label1.Text = "矩形宽度:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("华文新魏", 11F);
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.label3.Location = new System.Drawing.Point(12, 75);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 16);
            this.label3.TabIndex = 236;
            this.label3.Text = "矩形高度:";
            // 
            // PartRectangleForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(848, 548);
            this.Name = "PartRectangleForm";
            this.Load += new System.EventHandler(this.ShapeTransForm_Load);
            this.panel_bottom.ResumeLayout(false);
            this.panel_center.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbox_Icon)).EndInit();
            this.titlepanel.ResumeLayout(false);
            this.titlepanel.PerformLayout();
            this.uiTabControl1.ResumeLayout(false);
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.pnlDynThreshold.ResumeLayout(false);
            this.pnlDynThreshold.PerformLayout();
            this.pnl1Params.ResumeLayout(false);
            this.pnl1Params.PerformLayout();
            this.pnlImageInfo.ResumeLayout(false);
            this.pnlImageInfo.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.uiTitlePanel8.ResumeLayout(false);
            this.uiTitlePanel8.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private RexView.HWindow_HE mWindowH;
        private Rex.UI.UITabControl uiTabControl1;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TabPage tabPage2;
        private Rex.UI.UITitlePanel pnlImageInfo;
        private RexControl.MyControls.MyLinkData ldImage;
        private System.Windows.Forms.Label label12;
        private Rex.UI.UITitlePanel pnl1Params;
        private RexControl.MyControls.MyLinkData ldRegion;
        private System.Windows.Forms.Label label5;
        private Rex.UI.UITitlePanel pnlDynThreshold;
        private System.Windows.Forms.Label label2;
        private Rex.UI.UITitlePanel uiTitlePanel8;
        private System.Windows.Forms.Label label7;
        private Rex.UI.UIColorPicker cpColor;
        private Rex.UI.UICheckBox chxShowResult;
        private Rex.UI.MyComboBox cbxDraw;
        private System.Windows.Forms.Label label9;
        private RexControl.MyControls.MyTextBoxUpDownD tbxHeight;
        private System.Windows.Forms.Label label3;
        private RexControl.MyControls.MyTextBoxUpDownD tbxWidth;
        private System.Windows.Forms.Label label1;
    }
}