
namespace Plugin.DistanceLL
{
    partial class ResultForm
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
            this.lblResult = new Rex.UI.UISymbolLabel();
            this.label43 = new System.Windows.Forms.Label();
            this.tbxResult = new Rex.UI.UITextBox();
            this.SuspendLayout();
            // 
            // lblResult
            // 
            this.lblResult.BackColor = System.Drawing.Color.White;
            this.lblResult.Font = new System.Drawing.Font("华文新魏", 11.5F);
            this.lblResult.ForeColor = System.Drawing.Color.LightSalmon;
            this.lblResult.Location = new System.Drawing.Point(34, 46);
            this.lblResult.MinimumSize = new System.Drawing.Size(1, 1);
            this.lblResult.Name = "lblResult";
            this.lblResult.Padding = new System.Windows.Forms.Padding(22, 0, 0, 0);
            this.lblResult.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblResult.Size = new System.Drawing.Size(118, 23);
            this.lblResult.Style = Rex.UI.UIStyle.Custom;
            this.lblResult.Symbol = 61736;
            this.lblResult.SymbolColor = System.Drawing.Color.LightSalmon;
            this.lblResult.SymbolSize = 18;
            this.lblResult.TabIndex = 162;
            this.lblResult.Text = "模块未执行";
            this.lblResult.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label43
            // 
            this.label43.AutoSize = true;
            this.label43.BackColor = System.Drawing.Color.Transparent;
            this.label43.Font = new System.Drawing.Font("华文新魏", 11F);
            this.label43.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.label43.Location = new System.Drawing.Point(35, 77);
            this.label43.Name = "label43";
            this.label43.Size = new System.Drawing.Size(73, 16);
            this.label43.TabIndex = 163;
            this.label43.Text = "执行结果:";
            // 
            // tbxResult
            // 
            this.tbxResult.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbxResult.BackColor = System.Drawing.Color.AliceBlue;
            this.tbxResult.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbxResult.FillColor = System.Drawing.Color.AliceBlue;
            this.tbxResult.Font = new System.Drawing.Font("华文新魏", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tbxResult.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.tbxResult.Location = new System.Drawing.Point(109, 77);
            this.tbxResult.Margin = new System.Windows.Forms.Padding(0);
            this.tbxResult.Maximum = 2147483647D;
            this.tbxResult.Minimum = -2147483648D;
            this.tbxResult.MinimumSize = new System.Drawing.Size(1, 1);
            this.tbxResult.Multiline = true;
            this.tbxResult.Name = "tbxResult";
            this.tbxResult.RadiusSides = Rex.UI.UICornerRadiusSides.None;
            this.tbxResult.RectColor = System.Drawing.Color.AliceBlue;
            this.tbxResult.Size = new System.Drawing.Size(254, 208);
            this.tbxResult.Style = Rex.UI.UIStyle.Custom;
            this.tbxResult.TabIndex = 164;
            // 
            // ResultForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(403, 340);
            this.Controls.Add(this.tbxResult);
            this.Controls.Add(this.label43);
            this.Controls.Add(this.lblResult);
            this.Name = "ResultForm";
            this.Text = "ResultForm";
            this.Controls.SetChildIndex(this.lblResult, 0);
            this.Controls.SetChildIndex(this.label43, 0);
            this.Controls.SetChildIndex(this.tbxResult, 0);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public Rex.UI.UISymbolLabel lblResult;
        private System.Windows.Forms.Label label43;
        private Rex.UI.UITextBox tbxResult;
    }
}