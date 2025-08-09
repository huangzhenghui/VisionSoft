namespace Plugin.IF
{
    partial class IFForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(IFForm));
            this.ldData = new RexControl.MyControls.MyLinkData();
            this.label3 = new System.Windows.Forms.Label();
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
            this.panel_bottom.Size = new System.Drawing.Size(496, 38);
            // 
            // lblTime
            // 
            this.lblTime.Location = new System.Drawing.Point(252, 4);
            this.lblTime.Size = new System.Drawing.Size(125, 30);
            // 
            // btn_Run
            // 
            this.btn_Run.Location = new System.Drawing.Point(390, 4);
            this.btn_Run.Size = new System.Drawing.Size(78, 30);
            this.btn_Run.Click += new System.EventHandler(this.btn_Run_Click);
            // 
            // panel_center
            // 
            this.panel_center.Controls.Add(this.label3);
            this.panel_center.Controls.Add(this.ldData);
            this.panel_center.Margin = new System.Windows.Forms.Padding(4);
            this.panel_center.Size = new System.Drawing.Size(496, 131);
            // 
            // pbox_Icon
            // 
            this.pbox_Icon.Size = new System.Drawing.Size(30, 30);
            // 
            // titlepanel
            // 
            this.titlepanel.Size = new System.Drawing.Size(496, 32);
            // 
            // ldData
            // 
            this.ldData.BackColor = System.Drawing.Color.AliceBlue;
            this.ldData.Font = new System.Drawing.Font("华文新魏", 12F);
            this.ldData.FontStyle = new System.Drawing.Font("华文新魏", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.ldData.Location = new System.Drawing.Point(185, 51);
            this.ldData.Margin = new System.Windows.Forms.Padding(4, 5, 4, 4);
            this.ldData.Name = "ldData";
            this.ldData.Size = new System.Drawing.Size(205, 24);
            this.ldData.TabIndex = 198;
            this.ldData.TextInfo = "";
            this.ldData.LinkData += new System.EventHandler(this.ldData_LinkData);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("华文新魏", 11F);
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.label3.Location = new System.Drawing.Point(96, 58);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(88, 16);
            this.label3.TabIndex = 214;
            this.label3.Text = "bool型数据:";
            // 
            // IFForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(498, 198);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximumSize = new System.Drawing.Size(500, 200);
            this.MinimumSize = new System.Drawing.Size(500, 200);
            this.Name = "IFForm";
            this.panel_bottom.ResumeLayout(false);
            this.panel_center.ResumeLayout(false);
            this.panel_center.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbox_Icon)).EndInit();
            this.titlepanel.ResumeLayout(false);
            this.titlepanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private RexControl.MyControls.MyLinkData ldData;
        private System.Windows.Forms.Label label3;
    }
}