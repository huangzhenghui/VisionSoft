
namespace Plugin.ContourExt
{
    partial class ContourExtForm
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
            this.tbxAlpha = new RexControl.MyControls.MyTextBoxUpDownD();
            this.tbxHigh = new RexControl.MyControls.MyTextBoxUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tbxLow = new RexControl.MyControls.MyTextBoxUpDown();
            this.cbxFilter = new Rex.UI.MyComboBox();
            this.label18 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.uiTitlePanel1 = new Rex.UI.UITitlePanel();
            this.ldImage = new RexControl.MyControls.MyLinkData();
            this.label11 = new System.Windows.Forms.Label();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.uiTitlePanel3 = new Rex.UI.UITitlePanel();
            this.label22 = new System.Windows.Forms.Label();
            this.cpContour = new Rex.UI.UIColorPicker();
            this.chxShowContour = new Rex.UI.UICheckBox();
            this.panel_bottom.SuspendLayout();
            this.panel_center.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbox_Icon)).BeginInit();
            this.titlepanel.SuspendLayout();
            this.uiTabControl1.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.pnlRect2Params.SuspendLayout();
            this.uiTitlePanel1.SuspendLayout();
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
            this.pnlRect2Params.Controls.Add(this.tbxAlpha);
            this.pnlRect2Params.Controls.Add(this.tbxHigh);
            this.pnlRect2Params.Controls.Add(this.label4);
            this.pnlRect2Params.Controls.Add(this.label1);
            this.pnlRect2Params.Controls.Add(this.tbxLow);
            this.pnlRect2Params.Controls.Add(this.cbxFilter);
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
            this.pnlRect2Params.TabIndex = 43;
            this.pnlRect2Params.Text = "参数设置";
            this.pnlRect2Params.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.pnlRect2Params.TextAlignment = System.Drawing.ContentAlignment.MiddleRight;
            this.pnlRect2Params.TitleColor = System.Drawing.Color.CornflowerBlue;
            this.pnlRect2Params.TitleInterval = 5;
            // 
            // tbxAlpha
            // 
            this.tbxAlpha.Font = new System.Drawing.Font("华文新魏", 11F);
            this.tbxAlpha.FontStyle = null;
            this.tbxAlpha.Location = new System.Drawing.Point(84, 82);
            this.tbxAlpha.Name = "tbxAlpha";
            this.tbxAlpha.Size = new System.Drawing.Size(209, 24);
            this.tbxAlpha.TabIndex = 211;
            this.tbxAlpha.TextInfo = "";
            // 
            // tbxHigh
            // 
            this.tbxHigh.BackColor = System.Drawing.Color.White;
            this.tbxHigh.Font = new System.Drawing.Font("华文新魏", 11.2F);
            this.tbxHigh.FontStyle = null;
            this.tbxHigh.Location = new System.Drawing.Point(83, 156);
            this.tbxHigh.Name = "tbxHigh";
            this.tbxHigh.Size = new System.Drawing.Size(210, 24);
            this.tbxHigh.TabIndex = 209;
            this.tbxHigh.TextInfo = "";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("华文新魏", 11F);
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.label4.Location = new System.Drawing.Point(10, 162);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(73, 16);
            this.label4.TabIndex = 210;
            this.label4.Text = "阈值上限:";
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
            this.label1.Text = "滤波参数:";
            // 
            // tbxLow
            // 
            this.tbxLow.BackColor = System.Drawing.Color.White;
            this.tbxLow.Font = new System.Drawing.Font("华文新魏", 11.2F);
            this.tbxLow.FontStyle = null;
            this.tbxLow.Location = new System.Drawing.Point(83, 119);
            this.tbxLow.Name = "tbxLow";
            this.tbxLow.Size = new System.Drawing.Size(210, 24);
            this.tbxLow.TabIndex = 207;
            this.tbxLow.TextInfo = "";
            // 
            // cbxFilter
            // 
            this.cbxFilter.BackColor = System.Drawing.Color.AliceBlue;
            this.cbxFilter.DropDownStyle = Rex.UI.UIDropDownStyle.DropDownList;
            this.cbxFilter.FillColor = System.Drawing.Color.AliceBlue;
            this.cbxFilter.Font = new System.Drawing.Font("华文新魏", 11.6F);
            this.cbxFilter.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.cbxFilter.ForeDisableColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.cbxFilter.Items.AddRange(new object[] {
            "canny",
            "canny_junctions",
            "deriche1",
            "deriche1_junctions",
            "deriche2",
            "deriche2_junctions",
            "lanser1",
            "lanser1_junctions",
            "lanser2",
            "lanser2_junctions",
            "mshen",
            "mshen_junctions",
            "shen",
            "shen_junctions",
            "sobel",
            "sobel_fast",
            "sobel_junctions"});
            this.cbxFilter.Location = new System.Drawing.Point(83, 45);
            this.cbxFilter.Margin = new System.Windows.Forms.Padding(0);
            this.cbxFilter.MinimumSize = new System.Drawing.Size(63, 0);
            this.cbxFilter.Name = "cbxFilter";
            this.cbxFilter.Padding = new System.Windows.Forms.Padding(0, 0, 30, 0);
            this.cbxFilter.Radius = 2;
            this.cbxFilter.RectColor = System.Drawing.Color.CornflowerBlue;
            this.cbxFilter.RectDisableColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.cbxFilter.RectSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.None;
            this.cbxFilter.Size = new System.Drawing.Size(210, 24);
            this.cbxFilter.Style = Rex.UI.UIStyle.Custom;
            this.cbxFilter.StyleCustomMode = true;
            this.cbxFilter.SymbolDropDown = 61656;
            this.cbxFilter.SymbolNormal = 61655;
            this.cbxFilter.TabIndex = 203;
            this.cbxFilter.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
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
            this.label18.Text = "边缘算法:";
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
            this.label3.Text = "阈值下限:";
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
            this.uiTitlePanel3.Controls.Add(this.chxShowContour);
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
            this.uiTitlePanel3.TabIndex = 213;
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
            // chxShowContour
            // 
            this.chxShowContour.BackColor = System.Drawing.Color.White;
            this.chxShowContour.Checked = true;
            this.chxShowContour.Cursor = System.Windows.Forms.Cursors.Hand;
            this.chxShowContour.Font = new System.Drawing.Font("华文新魏", 11F);
            this.chxShowContour.ImageSize = 14;
            this.chxShowContour.Location = new System.Drawing.Point(10, 38);
            this.chxShowContour.MinimumSize = new System.Drawing.Size(1, 1);
            this.chxShowContour.Name = "chxShowContour";
            this.chxShowContour.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.chxShowContour.Size = new System.Drawing.Size(211, 31);
            this.chxShowContour.Style = Rex.UI.UIStyle.Custom;
            this.chxShowContour.TabIndex = 234;
            this.chxShowContour.Text = "显示轮廓";
            // 
            // ContourExtForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(850, 550);
            this.Name = "ContourExtForm";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.ContourExtForm_FormClosed);
            this.Load += new System.EventHandler(this.ContourExtForm_Load);
            this.LocationChanged += new System.EventHandler(this.ContourExtForm_LocationChanged);
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
            this.uiTitlePanel3.ResumeLayout(false);
            this.uiTitlePanel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private RexView.HWindow_HE mWindowH;
        private Rex.UI.UITabControl uiTabControl1;
        private System.Windows.Forms.TabPage tabPage3;
        private Rex.UI.UITitlePanel pnlRect2Params;
        private Rex.UI.UITitlePanel uiTitlePanel1;
        private RexControl.MyControls.MyLinkData ldImage;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TabPage tabPage4;
        private Rex.UI.MyComboBox cbxFilter;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label1;
        private RexControl.MyControls.MyTextBoxUpDown tbxHigh;
        private System.Windows.Forms.Label label4;
        private RexControl.MyControls.MyTextBoxUpDown tbxLow;
        private System.Windows.Forms.Label label3;
        private RexControl.MyControls.MyTextBoxUpDownD tbxAlpha;
        private Rex.UI.UITitlePanel uiTitlePanel3;
        private System.Windows.Forms.Label label22;
        private Rex.UI.UIColorPicker cpContour;
        private Rex.UI.UICheckBox chxShowContour;
    }
}