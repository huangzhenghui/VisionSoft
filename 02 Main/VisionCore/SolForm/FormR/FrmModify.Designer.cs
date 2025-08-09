
namespace VisionCore.SolForm.FormR
{
    partial class FrmModify
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
            this.tbxInfo = new Rex.UI.UITextBox();
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
            this.panel_center.Controls.Add(this.tbxInfo);
            this.panel_center.Controls.Add(this.label3);
            this.panel_center.Size = new System.Drawing.Size(446, 117);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("华文新魏", 11F);
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.label3.Location = new System.Drawing.Point(25, 51);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 16);
            this.label3.TabIndex = 214;
            this.label3.Text = "编辑信息:";
            // 
            // tbxInfo
            // 
            this.tbxInfo.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbxInfo.FillColor = System.Drawing.Color.AliceBlue;
            this.tbxInfo.FillDisableColor = System.Drawing.Color.AliceBlue;
            this.tbxInfo.Font = new System.Drawing.Font("华文新魏", 11F);
            this.tbxInfo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.tbxInfo.Location = new System.Drawing.Point(105, 44);
            this.tbxInfo.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tbxInfo.Maximum = 2147483647D;
            this.tbxInfo.Minimum = -2147483648D;
            this.tbxInfo.MinimumSize = new System.Drawing.Size(1, 1);
            this.tbxInfo.Name = "tbxInfo";
            this.tbxInfo.Padding = new System.Windows.Forms.Padding(5);
            this.tbxInfo.Radius = 20;
            this.tbxInfo.RadiusSides = Rex.UI.UICornerRadiusSides.None;
            this.tbxInfo.RectColor = System.Drawing.Color.AliceBlue;
            this.tbxInfo.RectSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.Bottom;
            this.tbxInfo.Size = new System.Drawing.Size(310, 23);
            this.tbxInfo.Style = Rex.UI.UIStyle.Custom;
            this.tbxInfo.StyleCustomMode = true;
            this.tbxInfo.TabIndex = 215;
            this.tbxInfo.Watermark = "";
            // 
            // FrmModify
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(448, 178);
            this.MaximumSize = new System.Drawing.Size(450, 180);
            this.MinimumSize = new System.Drawing.Size(450, 180);
            this.Name = "FrmModify";
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
        private Rex.UI.UITextBox tbxInfo;
    }
}