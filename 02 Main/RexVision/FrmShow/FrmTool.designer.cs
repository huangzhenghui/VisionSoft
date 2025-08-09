using VisionCore;

namespace TSIVision
{
    partial class FrmTool
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmTool));
            this.ModTree1 = new VisionCore.ModTree();
            this.SuspendLayout();
            // 
            // ModTree1
            // 
            this.ModTree1.AllowDrop = true;
            this.ModTree1.AutoScroll = true;
            this.ModTree1.BackColor = System.Drawing.Color.White;
            this.ModTree1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ModTree1.Font = new System.Drawing.Font("隶书", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.ModTree1.ForeColor = System.Drawing.Color.White;
            this.ModTree1.Indent = 19;
            this.ModTree1.Location = new System.Drawing.Point(0, 0);
            this.ModTree1.Margin = new System.Windows.Forms.Padding(0, 2, 2, 2);
            this.ModTree1.Name = "ModTree1";
            this.ModTree1.SelectedNode = null;
            this.ModTree1.Size = new System.Drawing.Size(212, 606);
            this.ModTree1.TabIndex = 0;
            // 
            // FrmTool
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(212, 606);
            this.Controls.Add(this.ModTree1);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.ForeColor = System.Drawing.Color.CadetBlue;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.HideOnClose = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "FrmTool";
            this.Opacity = 0.5D;
            this.Text = "工具箱";
            this.Load += new System.EventHandler(this.FrmModTree_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private ModTree ModTree1;
    }
}