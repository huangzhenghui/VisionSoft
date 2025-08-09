
namespace Plugin.ShowLog
{
    partial class ShowLogForm
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
            this.label3 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.cbxLogLevel = new Rex.UI.MyComboBox();
            this.ldLogInfo = new RexControl.MyControls.MyLinkData();
            this.panel_bottom.SuspendLayout();
            this.panel_center.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbox_Icon)).BeginInit();
            this.titlepanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel_bottom
            // 
            this.panel_bottom.Location = new System.Drawing.Point(1, 145);
            this.panel_bottom.Size = new System.Drawing.Size(446, 32);
            // 
            // lblTime
            // 
            this.lblTime.Location = new System.Drawing.Point(202, 4);
            // 
            // btn_Run
            // 
            this.btn_Run.Location = new System.Drawing.Point(340, 4);
            this.btn_Run.Click += new System.EventHandler(this.btn_Run_Click);
            // 
            // panel_center
            // 
            this.panel_center.Controls.Add(this.cbxLogLevel);
            this.panel_center.Controls.Add(this.label18);
            this.panel_center.Controls.Add(this.ldLogInfo);
            this.panel_center.Controls.Add(this.label3);
            this.panel_center.Size = new System.Drawing.Size(446, 117);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("华文新魏", 11F);
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.label3.Location = new System.Drawing.Point(80, 70);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 16);
            this.label3.TabIndex = 215;
            this.label3.Text = "日志内容:";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.BackColor = System.Drawing.Color.Transparent;
            this.label18.Font = new System.Drawing.Font("华文新魏", 11F);
            this.label18.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.label18.Location = new System.Drawing.Point(80, 36);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(73, 16);
            this.label18.TabIndex = 261;
            this.label18.Text = "日志等级:";
            // 
            // cbxLogLevel
            // 
            this.cbxLogLevel.BackColor = System.Drawing.Color.AliceBlue;
            this.cbxLogLevel.DropDownStyle = Rex.UI.UIDropDownStyle.DropDownList;
            this.cbxLogLevel.FillColor = System.Drawing.Color.AliceBlue;
            this.cbxLogLevel.Font = new System.Drawing.Font("华文新魏", 11.6F);
            this.cbxLogLevel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.cbxLogLevel.ForeDisableColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.cbxLogLevel.Items.AddRange(new object[] {
            "调试",
            "提示",
            "警告",
            "错误",
            "异常"});
            this.cbxLogLevel.Location = new System.Drawing.Point(151, 31);
            this.cbxLogLevel.Margin = new System.Windows.Forms.Padding(0);
            this.cbxLogLevel.MinimumSize = new System.Drawing.Size(63, 0);
            this.cbxLogLevel.Name = "cbxLogLevel";
            this.cbxLogLevel.Padding = new System.Windows.Forms.Padding(0, 0, 30, 0);
            this.cbxLogLevel.Radius = 2;
            this.cbxLogLevel.RectColor = System.Drawing.Color.CornflowerBlue;
            this.cbxLogLevel.RectDisableColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.cbxLogLevel.RectSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.None;
            this.cbxLogLevel.Size = new System.Drawing.Size(210, 24);
            this.cbxLogLevel.Style = Rex.UI.UIStyle.Custom;
            this.cbxLogLevel.StyleCustomMode = true;
            this.cbxLogLevel.SymbolDropDown = 61656;
            this.cbxLogLevel.SymbolNormal = 61655;
            this.cbxLogLevel.TabIndex = 262;
            this.cbxLogLevel.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // ldLogInfo
            // 
            this.ldLogInfo.BackColor = System.Drawing.Color.AliceBlue;
            this.ldLogInfo.Font = new System.Drawing.Font("华文新魏", 12F);
            this.ldLogInfo.FontStyle = new System.Drawing.Font("华文新魏", 11.5F);
            this.ldLogInfo.Location = new System.Drawing.Point(151, 65);
            this.ldLogInfo.Margin = new System.Windows.Forms.Padding(4, 5, 4, 4);
            this.ldLogInfo.Name = "ldLogInfo";
            this.ldLogInfo.Size = new System.Drawing.Size(210, 24);
            this.ldLogInfo.TabIndex = 259;
            this.ldLogInfo.TextInfo = "";
            this.ldLogInfo.LinkData += new System.EventHandler(this.ldHObject_LinkData);
            // 
            // ShowLogForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(448, 178);
            this.MaximumSize = new System.Drawing.Size(450, 180);
            this.MinimumSize = new System.Drawing.Size(450, 180);
            this.Name = "ShowLogForm";
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
        private RexControl.MyControls.MyLinkData ldLogInfo;
        private Rex.UI.MyComboBox cbxLogLevel;
        private System.Windows.Forms.Label label18;
    }
}