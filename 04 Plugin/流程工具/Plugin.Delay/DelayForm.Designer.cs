namespace Plugin.Delay
{
    partial class DelayForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DelayForm));
            this.label1 = new Rex.UI.UILabel();
            this.tbxDelay = new RexControl.MyControls.MyTextBoxUpDown();
            this.panel_bottom.SuspendLayout();
            this.panel_center.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbox_Icon)).BeginInit();
            this.titlepanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel_bottom
            // 
            this.panel_bottom.Location = new System.Drawing.Point(1, 159);
            this.panel_bottom.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel_bottom.Size = new System.Drawing.Size(396, 38);
            // 
            // lblTime
            // 
            this.lblTime.Location = new System.Drawing.Point(152, 4);
            this.lblTime.Size = new System.Drawing.Size(125, 30);
            // 
            // btn_Run
            // 
            this.btn_Run.Location = new System.Drawing.Point(290, 4);
            this.btn_Run.Size = new System.Drawing.Size(78, 30);
            this.btn_Run.Click += new System.EventHandler(this.btn_Run_Click);
            // 
            // panel_center
            // 
            this.panel_center.Controls.Add(this.tbxDelay);
            this.panel_center.Controls.Add(this.label1);
            this.panel_center.Margin = new System.Windows.Forms.Padding(4);
            this.panel_center.Size = new System.Drawing.Size(396, 131);
            // 
            // pbox_Icon
            // 
            this.pbox_Icon.Size = new System.Drawing.Size(30, 30);
            // 
            // titlepanel
            // 
            this.titlepanel.Size = new System.Drawing.Size(296, 32);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("华文新魏", 11F);
            this.label1.Location = new System.Drawing.Point(57, 53);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 16);
            this.label1.TabIndex = 4;
            this.label1.Text = "延时时间(ms):";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // tbxDelay
            // 
            this.tbxDelay.BackColor = System.Drawing.Color.White;
            this.tbxDelay.Font = new System.Drawing.Font("华文新魏", 11.6F);
            this.tbxDelay.FontStyle = null;
            this.tbxDelay.Location = new System.Drawing.Point(157, 48);
            this.tbxDelay.Name = "tbxDelay";
            this.tbxDelay.Size = new System.Drawing.Size(191, 26);
            this.tbxDelay.TabIndex = 5;
            this.tbxDelay.TextInfo = "";
            // 
            // DelayForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(398, 198);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximumSize = new System.Drawing.Size(400, 200);
            this.MinimumSize = new System.Drawing.Size(400, 200);
            this.Name = "DelayForm";
            this.panel_bottom.ResumeLayout(false);
            this.panel_center.ResumeLayout(false);
            this.panel_center.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbox_Icon)).EndInit();
            this.titlepanel.ResumeLayout(false);
            this.titlepanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private Rex.UI.UILabel label1;
        private RexControl.MyControls.MyTextBoxUpDown tbxDelay;
    }
}