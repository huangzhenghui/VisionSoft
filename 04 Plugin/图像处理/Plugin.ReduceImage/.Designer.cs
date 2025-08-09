
namespace Plugin.ReduceImage
{
    partial class ReduceImageForm
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
            this.pnl1ModelInfo = new Rex.UI.UITitlePanel();
            this.ldRegion = new RexControl.MyControls.MyLinkData();
            this.label10 = new System.Windows.Forms.Label();
            this.uiTitlePanel1 = new Rex.UI.UITitlePanel();
            this.ldImage = new RexControl.MyControls.MyLinkData();
            this.label11 = new System.Windows.Forms.Label();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.pnl1Show = new Rex.UI.UITitlePanel();
            this.cbxSelectScreen = new Rex.UI.MyComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.chxShow = new Rex.UI.UICheckBox();
            this.panel_bottom.SuspendLayout();
            this.panel_center.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbox_Icon)).BeginInit();
            this.titlepanel.SuspendLayout();
            this.uiTabControl1.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.pnl1ModelInfo.SuspendLayout();
            this.uiTitlePanel1.SuspendLayout();
            this.tabPage4.SuspendLayout();
            this.pnl1Show.SuspendLayout();
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
            this.tabPage3.Controls.Add(this.pnl1ModelInfo);
            this.tabPage3.Controls.Add(this.uiTitlePanel1);
            this.tabPage3.Font = new System.Drawing.Font("隶书", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tabPage3.Location = new System.Drawing.Point(0, 26);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(303, 461);
            this.tabPage3.TabIndex = 0;
            this.tabPage3.Text = "基本设置";
            // 
            // pnl1ModelInfo
            // 
            this.pnl1ModelInfo.Controls.Add(this.ldRegion);
            this.pnl1ModelInfo.Controls.Add(this.label10);
            this.pnl1ModelInfo.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnl1ModelInfo.FillColor = System.Drawing.Color.White;
            this.pnl1ModelInfo.Font = new System.Drawing.Font("华文新魏", 12F);
            this.pnl1ModelInfo.ForeColor = System.Drawing.Color.White;
            this.pnl1ModelInfo.Location = new System.Drawing.Point(0, 83);
            this.pnl1ModelInfo.Margin = new System.Windows.Forms.Padding(0);
            this.pnl1ModelInfo.MinimumSize = new System.Drawing.Size(1, 1);
            this.pnl1ModelInfo.Name = "pnl1ModelInfo";
            this.pnl1ModelInfo.Padding = new System.Windows.Forms.Padding(3, 25, 3, 0);
            this.pnl1ModelInfo.RadiusSides = Rex.UI.UICornerRadiusSides.None;
            this.pnl1ModelInfo.RectColor = System.Drawing.Color.White;
            this.pnl1ModelInfo.Size = new System.Drawing.Size(303, 118);
            this.pnl1ModelInfo.Style = Rex.UI.UIStyle.Custom;
            this.pnl1ModelInfo.TabIndex = 200;
            this.pnl1ModelInfo.Text = "参数设置";
            this.pnl1ModelInfo.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.pnl1ModelInfo.TextAlignment = System.Drawing.ContentAlignment.BottomCenter;
            this.pnl1ModelInfo.TitleColor = System.Drawing.Color.CornflowerBlue;
            this.pnl1ModelInfo.TitleInterval = 5;
            // 
            // ldRegion
            // 
            this.ldRegion.BackColor = System.Drawing.Color.AliceBlue;
            this.ldRegion.Font = new System.Drawing.Font("华文新魏", 12F);
            this.ldRegion.FontStyle = new System.Drawing.Font("华文新魏", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.ldRegion.Location = new System.Drawing.Point(83, 42);
            this.ldRegion.Margin = new System.Windows.Forms.Padding(4, 5, 4, 4);
            this.ldRegion.Name = "ldRegion";
            this.ldRegion.Size = new System.Drawing.Size(210, 24);
            this.ldRegion.TabIndex = 196;
            this.ldRegion.TextInfo = "";
            this.ldRegion.LinkData += new System.EventHandler(this.ldHObject_LinkData);
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
            this.label10.Text = "输入区域:";
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
            this.uiTitlePanel1.TabIndex = 46;
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
            this.tabPage4.Controls.Add(this.pnl1Show);
            this.tabPage4.Location = new System.Drawing.Point(0, 26);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Size = new System.Drawing.Size(303, 461);
            this.tabPage4.TabIndex = 1;
            this.tabPage4.Text = "显示设置";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // pnl1Show
            // 
            this.pnl1Show.Controls.Add(this.cbxSelectScreen);
            this.pnl1Show.Controls.Add(this.label9);
            this.pnl1Show.Controls.Add(this.chxShow);
            this.pnl1Show.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnl1Show.FillColor = System.Drawing.Color.White;
            this.pnl1Show.FillDisableColor = System.Drawing.Color.White;
            this.pnl1Show.Font = new System.Drawing.Font("华文新魏", 12F);
            this.pnl1Show.ForeColor = System.Drawing.Color.White;
            this.pnl1Show.Location = new System.Drawing.Point(0, 0);
            this.pnl1Show.Margin = new System.Windows.Forms.Padding(0);
            this.pnl1Show.MinimumSize = new System.Drawing.Size(1, 1);
            this.pnl1Show.Name = "pnl1Show";
            this.pnl1Show.Padding = new System.Windows.Forms.Padding(0, 35, 0, 0);
            this.pnl1Show.RadiusSides = Rex.UI.UICornerRadiusSides.None;
            this.pnl1Show.RectColor = System.Drawing.Color.White;
            this.pnl1Show.Size = new System.Drawing.Size(303, 108);
            this.pnl1Show.Style = Rex.UI.UIStyle.Custom;
            this.pnl1Show.TabIndex = 197;
            this.pnl1Show.Text = "显示设置";
            this.pnl1Show.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.pnl1Show.TitleColor = System.Drawing.Color.CornflowerBlue;
            // 
            // cbxSelectScreen
            // 
            this.cbxSelectScreen.BackColor = System.Drawing.Color.AliceBlue;
            this.cbxSelectScreen.DropDownStyle = Rex.UI.UIDropDownStyle.DropDownList;
            this.cbxSelectScreen.FillColor = System.Drawing.Color.AliceBlue;
            this.cbxSelectScreen.Font = new System.Drawing.Font("华文新魏", 11F);
            this.cbxSelectScreen.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.cbxSelectScreen.ForeDisableColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.cbxSelectScreen.Items.AddRange(new object[] {
            "None",
            "1号屏显示",
            "2号屏显示",
            "3号屏显示",
            "4号屏显示",
            "5号屏显示",
            "6号屏显示",
            "7号屏显示",
            "8号屏显示",
            "9号屏显示"});
            this.cbxSelectScreen.Location = new System.Drawing.Point(89, 68);
            this.cbxSelectScreen.Margin = new System.Windows.Forms.Padding(0);
            this.cbxSelectScreen.MinimumSize = new System.Drawing.Size(63, 0);
            this.cbxSelectScreen.Name = "cbxSelectScreen";
            this.cbxSelectScreen.Padding = new System.Windows.Forms.Padding(0, 0, 30, 0);
            this.cbxSelectScreen.Radius = 2;
            this.cbxSelectScreen.RectColor = System.Drawing.Color.CornflowerBlue;
            this.cbxSelectScreen.RectDisableColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.cbxSelectScreen.RectSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.None;
            this.cbxSelectScreen.Size = new System.Drawing.Size(203, 23);
            this.cbxSelectScreen.Style = Rex.UI.UIStyle.Custom;
            this.cbxSelectScreen.StyleCustomMode = true;
            this.cbxSelectScreen.SymbolDropDown = 61656;
            this.cbxSelectScreen.SymbolNormal = 61655;
            this.cbxSelectScreen.TabIndex = 204;
            this.cbxSelectScreen.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("华文新魏", 11F);
            this.label9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.label9.Location = new System.Drawing.Point(13, 73);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(73, 16);
            this.label9.TabIndex = 203;
            this.label9.Text = "屏幕编号:";
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
            // ReduceImageForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(850, 550);
            this.Name = "ReduceImageForm";
            this.panel_bottom.ResumeLayout(false);
            this.panel_center.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbox_Icon)).EndInit();
            this.titlepanel.ResumeLayout(false);
            this.titlepanel.PerformLayout();
            this.uiTabControl1.ResumeLayout(false);
            this.tabPage3.ResumeLayout(false);
            this.pnl1ModelInfo.ResumeLayout(false);
            this.pnl1ModelInfo.PerformLayout();
            this.uiTitlePanel1.ResumeLayout(false);
            this.uiTitlePanel1.PerformLayout();
            this.tabPage4.ResumeLayout(false);
            this.pnl1Show.ResumeLayout(false);
            this.pnl1Show.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private RexView.HWindow_HE mWindowH;
        private Rex.UI.UITabControl uiTabControl1;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TabPage tabPage4;
        private Rex.UI.UITitlePanel uiTitlePanel1;
        private RexControl.MyControls.MyLinkData ldImage;
        private System.Windows.Forms.Label label11;
        private Rex.UI.UITitlePanel pnl1ModelInfo;
        private RexControl.MyControls.MyLinkData ldRegion;
        private System.Windows.Forms.Label label10;
        private Rex.UI.UITitlePanel pnl1Show;
        private Rex.UI.MyComboBox cbxSelectScreen;
        private System.Windows.Forms.Label label9;
        private Rex.UI.UICheckBox chxShow;
    }
}