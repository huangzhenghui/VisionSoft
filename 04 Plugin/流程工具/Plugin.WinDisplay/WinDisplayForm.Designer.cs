namespace Plugin.WinDisplay
{
    partial class WinDisplayForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(WinDisplayForm));
            this.label2 = new System.Windows.Forms.Label();
            this.cpFontColor = new Rex.UI.UIColorPicker();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tbxMessage = new Rex.UI.UITextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.cpFormColor = new Rex.UI.UIColorPicker();
            this.cbxFontStye = new Rex.UI.MyComboBox();
            this.tbFontSize = new Rex.UI.UITrackBar();
            this.panel_bottom.SuspendLayout();
            this.panel_center.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbox_Icon)).BeginInit();
            this.titlepanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel_bottom
            // 
            this.panel_bottom.Location = new System.Drawing.Point(1, 329);
            this.panel_bottom.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel_bottom.Size = new System.Drawing.Size(596, 38);
            // 
            // lblTime
            // 
            this.lblTime.Location = new System.Drawing.Point(352, 4);
            this.lblTime.Size = new System.Drawing.Size(125, 30);
            // 
            // btn_Run
            // 
            this.btn_Run.Location = new System.Drawing.Point(490, 4);
            this.btn_Run.Size = new System.Drawing.Size(78, 30);
            this.btn_Run.Click += new System.EventHandler(this.btn_Run_Click);
            // 
            // panel_center
            // 
            this.panel_center.Controls.Add(this.tbFontSize);
            this.panel_center.Controls.Add(this.cbxFontStye);
            this.panel_center.Controls.Add(this.label5);
            this.panel_center.Controls.Add(this.cpFormColor);
            this.panel_center.Controls.Add(this.tbxMessage);
            this.panel_center.Controls.Add(this.label4);
            this.panel_center.Controls.Add(this.label1);
            this.panel_center.Controls.Add(this.label3);
            this.panel_center.Controls.Add(this.label2);
            this.panel_center.Controls.Add(this.cpFontColor);
            this.panel_center.Margin = new System.Windows.Forms.Padding(4);
            this.panel_center.Size = new System.Drawing.Size(596, 301);
            // 
            // pbox_Icon
            // 
            this.pbox_Icon.Size = new System.Drawing.Size(30, 30);
            // 
            // titlepanel
            // 
            this.titlepanel.Size = new System.Drawing.Size(296, 32);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("华文新魏", 11F);
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.label2.Location = new System.Drawing.Point(46, 98);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 16);
            this.label2.TabIndex = 195;
            this.label2.Text = "字体颜色:";
            // 
            // cpFontColor
            // 
            this.cpFontColor.DropDownStyle = Rex.UI.UIDropDownStyle.DropDownList;
            this.cpFontColor.FillColor = System.Drawing.Color.AliceBlue;
            this.cpFontColor.FillDisableColor = System.Drawing.Color.AliceBlue;
            this.cpFontColor.Font = new System.Drawing.Font("微软雅黑", 9F);
            this.cpFontColor.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.cpFontColor.Location = new System.Drawing.Point(122, 94);
            this.cpFontColor.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cpFontColor.MinimumSize = new System.Drawing.Size(63, 0);
            this.cpFontColor.Name = "cpFontColor";
            this.cpFontColor.Padding = new System.Windows.Forms.Padding(0, 0, 30, 0);
            this.cpFontColor.RadiusSides = Rex.UI.UICornerRadiusSides.None;
            this.cpFontColor.RectColor = System.Drawing.Color.White;
            this.cpFontColor.RectSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.Bottom;
            this.cpFontColor.Size = new System.Drawing.Size(213, 23);
            this.cpFontColor.Style = Rex.UI.UIStyle.Custom;
            this.cpFontColor.StyleCustomMode = true;
            this.cpFontColor.TabIndex = 194;
            this.cpFontColor.Text = "uiColorPicker1";
            this.cpFontColor.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.cpFontColor.Value = System.Drawing.Color.MediumPurple;
            this.cpFontColor.ValueChanged += new Rex.UI.UIColorPicker.OnColorChanged(this.cpFontColor_ValueChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("华文新魏", 11F);
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.label3.Location = new System.Drawing.Point(46, 30);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 16);
            this.label3.TabIndex = 196;
            this.label3.Text = "字体样式:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("华文新魏", 11F);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.label1.Location = new System.Drawing.Point(46, 64);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 16);
            this.label1.TabIndex = 207;
            this.label1.Text = "字体大小:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("华文新魏", 11F);
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.label4.Location = new System.Drawing.Point(46, 162);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(73, 16);
            this.label4.TabIndex = 208;
            this.label4.Text = "弹窗内容:";
            // 
            // tbxMessage
            // 
            this.tbxMessage.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbxMessage.FillColor = System.Drawing.Color.AliceBlue;
            this.tbxMessage.FillDisableColor = System.Drawing.Color.AliceBlue;
            this.tbxMessage.Font = new System.Drawing.Font("华文新魏", 11F);
            this.tbxMessage.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.tbxMessage.Location = new System.Drawing.Point(49, 186);
            this.tbxMessage.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tbxMessage.Maximum = 2147483647D;
            this.tbxMessage.Minimum = -2147483648D;
            this.tbxMessage.MinimumSize = new System.Drawing.Size(1, 1);
            this.tbxMessage.Multiline = true;
            this.tbxMessage.Name = "tbxMessage";
            this.tbxMessage.Padding = new System.Windows.Forms.Padding(5);
            this.tbxMessage.Radius = 20;
            this.tbxMessage.RadiusSides = Rex.UI.UICornerRadiusSides.None;
            this.tbxMessage.RectColor = System.Drawing.Color.AliceBlue;
            this.tbxMessage.RectSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.Bottom;
            this.tbxMessage.Size = new System.Drawing.Size(491, 94);
            this.tbxMessage.Style = Rex.UI.UIStyle.Custom;
            this.tbxMessage.StyleCustomMode = true;
            this.tbxMessage.TabIndex = 207;
            this.tbxMessage.Watermark = "";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("华文新魏", 11F);
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.label5.Location = new System.Drawing.Point(46, 132);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(73, 16);
            this.label5.TabIndex = 211;
            this.label5.Text = "窗体颜色:";
            // 
            // cpFormColor
            // 
            this.cpFormColor.DropDownStyle = Rex.UI.UIDropDownStyle.DropDownList;
            this.cpFormColor.FillColor = System.Drawing.Color.AliceBlue;
            this.cpFormColor.FillDisableColor = System.Drawing.Color.AliceBlue;
            this.cpFormColor.Font = new System.Drawing.Font("微软雅黑", 9F);
            this.cpFormColor.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.cpFormColor.Location = new System.Drawing.Point(122, 129);
            this.cpFormColor.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cpFormColor.MinimumSize = new System.Drawing.Size(63, 0);
            this.cpFormColor.Name = "cpFormColor";
            this.cpFormColor.Padding = new System.Windows.Forms.Padding(0, 0, 30, 0);
            this.cpFormColor.RadiusSides = Rex.UI.UICornerRadiusSides.None;
            this.cpFormColor.RectColor = System.Drawing.Color.White;
            this.cpFormColor.RectSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.Bottom;
            this.cpFormColor.Size = new System.Drawing.Size(213, 23);
            this.cpFormColor.Style = Rex.UI.UIStyle.Custom;
            this.cpFormColor.StyleCustomMode = true;
            this.cpFormColor.TabIndex = 210;
            this.cpFormColor.Text = "uiColorPicker1";
            this.cpFormColor.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.cpFormColor.Value = System.Drawing.Color.MediumPurple;
            // 
            // cbxFontStye
            // 
            this.cbxFontStye.BackColor = System.Drawing.Color.AliceBlue;
            this.cbxFontStye.DropDownStyle = Rex.UI.UIDropDownStyle.DropDownList;
            this.cbxFontStye.FillColor = System.Drawing.Color.AliceBlue;
            this.cbxFontStye.Font = new System.Drawing.Font("华文新魏", 11F);
            this.cbxFontStye.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.cbxFontStye.ForeDisableColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.cbxFontStye.Location = new System.Drawing.Point(122, 24);
            this.cbxFontStye.Margin = new System.Windows.Forms.Padding(0);
            this.cbxFontStye.MinimumSize = new System.Drawing.Size(63, 0);
            this.cbxFontStye.Name = "cbxFontStye";
            this.cbxFontStye.Padding = new System.Windows.Forms.Padding(0, 0, 30, 0);
            this.cbxFontStye.Radius = 2;
            this.cbxFontStye.RectColor = System.Drawing.Color.CornflowerBlue;
            this.cbxFontStye.RectDisableColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.cbxFontStye.RectSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.None;
            this.cbxFontStye.Size = new System.Drawing.Size(213, 23);
            this.cbxFontStye.Style = Rex.UI.UIStyle.Custom;
            this.cbxFontStye.StyleCustomMode = true;
            this.cbxFontStye.SymbolDropDown = 61656;
            this.cbxFontStye.SymbolNormal = 61655;
            this.cbxFontStye.TabIndex = 212;
            this.cbxFontStye.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.cbxFontStye.SelectedIndexChanged += new System.EventHandler(this.cbxFontStye_SelectedIndexChanged);
            // 
            // tbFontSize
            // 
            this.tbFontSize.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.tbFontSize.Location = new System.Drawing.Point(122, 59);
            this.tbFontSize.Maximum = 25;
            this.tbFontSize.MinimumSize = new System.Drawing.Size(1, 1);
            this.tbFontSize.Name = "tbFontSize";
            this.tbFontSize.Size = new System.Drawing.Size(213, 22);
            this.tbFontSize.TabIndex = 213;
            this.tbFontSize.Text = "uiTrackBar1";
            this.tbFontSize.ValueChanged += new System.EventHandler(this.tbFontSize_ValueChanged);
            // 
            // WinDisplayForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(598, 368);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximumSize = new System.Drawing.Size(600, 370);
            this.MinimumSize = new System.Drawing.Size(560, 370);
            this.Name = "WinDisplayForm";
            this.Load += new System.EventHandler(this.WinDisplayForm_Load);
            this.panel_bottom.ResumeLayout(false);
            this.panel_center.ResumeLayout(false);
            this.panel_center.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbox_Icon)).EndInit();
            this.titlepanel.ResumeLayout(false);
            this.titlepanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private Rex.UI.UIColorPicker cpFontColor;
        private Rex.UI.UITextBox tbxMessage;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
        private Rex.UI.UIColorPicker cpFormColor;
        private Rex.UI.MyComboBox cbxFontStye;
        private Rex.UI.UITrackBar tbFontSize;
    }
}