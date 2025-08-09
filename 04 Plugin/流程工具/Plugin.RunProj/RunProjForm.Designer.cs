
namespace Plugin.RunProj
{
    partial class RunProjForm
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
            this.cbxProj = new Rex.UI.MyComboBox();
            this.label3 = new System.Windows.Forms.Label();
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
            this.panel_center.Controls.Add(this.cbxProj);
            this.panel_center.Controls.Add(this.label3);
            this.panel_center.Size = new System.Drawing.Size(446, 117);
            // 
            // pbox_Icon
            // 
            this.pbox_Icon.Size = new System.Drawing.Size(30, 174);
            // 
            // titlepanel
            // 
            this.titlepanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.titlepanel.Size = new System.Drawing.Size(446, 176);
            // 
            // cbxProj
            // 
            this.cbxProj.BackColor = System.Drawing.Color.AliceBlue;
            this.cbxProj.DropDownStyle = Rex.UI.UIDropDownStyle.DropDownList;
            this.cbxProj.FillColor = System.Drawing.Color.AliceBlue;
            this.cbxProj.Font = new System.Drawing.Font("华文新魏", 11F);
            this.cbxProj.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.cbxProj.ForeDisableColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.cbxProj.Location = new System.Drawing.Point(149, 41);
            this.cbxProj.Margin = new System.Windows.Forms.Padding(0);
            this.cbxProj.MinimumSize = new System.Drawing.Size(63, 0);
            this.cbxProj.Name = "cbxProj";
            this.cbxProj.Padding = new System.Windows.Forms.Padding(0, 0, 30, 0);
            this.cbxProj.Radius = 2;
            this.cbxProj.RectColor = System.Drawing.Color.CornflowerBlue;
            this.cbxProj.RectDisableColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.cbxProj.RectSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.None;
            this.cbxProj.Size = new System.Drawing.Size(213, 23);
            this.cbxProj.Style = Rex.UI.UIStyle.Custom;
            this.cbxProj.StyleCustomMode = true;
            this.cbxProj.SymbolDropDown = 61656;
            this.cbxProj.SymbolNormal = 61655;
            this.cbxProj.TabIndex = 214;
            this.cbxProj.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("华文新魏", 11F);
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.label3.Location = new System.Drawing.Point(73, 46);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 16);
            this.label3.TabIndex = 213;
            this.label3.Text = "流程选择:";
            // 
            // RunProjForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(448, 178);
            this.Font = new System.Drawing.Font("隶书", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.MaximumSize = new System.Drawing.Size(450, 180);
            this.MinimumSize = new System.Drawing.Size(450, 180);
            this.Name = "RunProjForm";
            this.panel_bottom.ResumeLayout(false);
            this.panel_center.ResumeLayout(false);
            this.panel_center.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbox_Icon)).EndInit();
            this.titlepanel.ResumeLayout(false);
            this.titlepanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Rex.UI.MyComboBox cbxProj;
        private System.Windows.Forms.Label label3;
    }
}