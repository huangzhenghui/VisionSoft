namespace Plugin.SendData
{
    partial class SendDataForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SendDataForm));
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tbxEndStr = new Rex.UI.UITextBox();
            this.cbxSelect = new Rex.UI.MyComboBox();
            this.ldContent = new RexControl.MyControls.MyLinkData();
            this.panel_bottom.SuspendLayout();
            this.panel_center.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbox_Icon)).BeginInit();
            this.titlepanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel_bottom
            // 
            this.panel_bottom.Location = new System.Drawing.Point(1, 245);
            this.panel_bottom.Size = new System.Drawing.Size(446, 32);
            // 
            // lblTime
            // 
            this.lblTime.Location = new System.Drawing.Point(208, 4);
            // 
            // btn_Run
            // 
            this.btn_Run.Location = new System.Drawing.Point(346, 4);
            this.btn_Run.Size = new System.Drawing.Size(72, 24);
            this.btn_Run.Click += new System.EventHandler(this.btn_Run_Click);
            // 
            // panel_center
            // 
            this.panel_center.Controls.Add(this.ldContent);
            this.panel_center.Controls.Add(this.cbxSelect);
            this.panel_center.Controls.Add(this.tbxEndStr);
            this.panel_center.Controls.Add(this.label4);
            this.panel_center.Controls.Add(this.label3);
            this.panel_center.Controls.Add(this.label1);
            this.panel_center.Size = new System.Drawing.Size(446, 217);
            // 
            // pbox_Icon
            // 
            this.pbox_Icon.Size = new System.Drawing.Size(30, 30);
            // 
            // titlepanel
            // 
            this.titlepanel.Size = new System.Drawing.Size(256, 32);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("华文新魏", 11F);
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.label3.Location = new System.Drawing.Point(82, 101);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 16);
            this.label3.TabIndex = 14;
            this.label3.Text = "发送内容:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("华文新魏", 11F);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.label1.Location = new System.Drawing.Point(82, 65);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 16);
            this.label1.TabIndex = 12;
            this.label1.Text = "通讯选择:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("华文新魏", 11F);
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.label4.Location = new System.Drawing.Point(82, 137);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(73, 16);
            this.label4.TabIndex = 18;
            this.label4.Text = "结束字符:";
            // 
            // tbxEndStr
            // 
            this.tbxEndStr.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbxEndStr.Font = new System.Drawing.Font("华文新魏", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tbxEndStr.Location = new System.Drawing.Point(157, 132);
            this.tbxEndStr.Margin = new System.Windows.Forms.Padding(0);
            this.tbxEndStr.Maximum = 2147483647D;
            this.tbxEndStr.Minimum = -2147483648D;
            this.tbxEndStr.MinimumSize = new System.Drawing.Size(1, 1);
            this.tbxEndStr.Name = "tbxEndStr";
            this.tbxEndStr.RectColor = System.Drawing.Color.White;
            this.tbxEndStr.Size = new System.Drawing.Size(210, 23);
            this.tbxEndStr.Style = Rex.UI.UIStyle.Custom;
            this.tbxEndStr.TabIndex = 263;
            // 
            // cbxSelect
            // 
            this.cbxSelect.BackColor = System.Drawing.Color.AliceBlue;
            this.cbxSelect.DropDownStyle = Rex.UI.UIDropDownStyle.DropDownList;
            this.cbxSelect.FillColor = System.Drawing.Color.AliceBlue;
            this.cbxSelect.Font = new System.Drawing.Font("华文新魏", 11.6F);
            this.cbxSelect.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.cbxSelect.ForeDisableColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.cbxSelect.Items.AddRange(new object[] {
            "读取",
            "创建"});
            this.cbxSelect.Location = new System.Drawing.Point(157, 60);
            this.cbxSelect.Margin = new System.Windows.Forms.Padding(0);
            this.cbxSelect.MinimumSize = new System.Drawing.Size(63, 0);
            this.cbxSelect.Name = "cbxSelect";
            this.cbxSelect.Padding = new System.Windows.Forms.Padding(0, 0, 30, 0);
            this.cbxSelect.Radius = 2;
            this.cbxSelect.RectColor = System.Drawing.Color.CornflowerBlue;
            this.cbxSelect.RectDisableColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.cbxSelect.RectSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.None;
            this.cbxSelect.Size = new System.Drawing.Size(210, 24);
            this.cbxSelect.Style = Rex.UI.UIStyle.Custom;
            this.cbxSelect.StyleCustomMode = true;
            this.cbxSelect.SymbolDropDown = 61656;
            this.cbxSelect.SymbolNormal = 61655;
            this.cbxSelect.TabIndex = 264;
            this.cbxSelect.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // ldContent
            // 
            this.ldContent.BackColor = System.Drawing.Color.AliceBlue;
            this.ldContent.Font = new System.Drawing.Font("华文新魏", 12F);
            this.ldContent.FontStyle = new System.Drawing.Font("华文新魏", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.ldContent.Location = new System.Drawing.Point(157, 96);
            this.ldContent.Margin = new System.Windows.Forms.Padding(4, 5, 4, 4);
            this.ldContent.Name = "ldContent";
            this.ldContent.Size = new System.Drawing.Size(210, 24);
            this.ldContent.TabIndex = 265;
            this.ldContent.TextInfo = "";
            // 
            // SendDataForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.ClientSize = new System.Drawing.Size(448, 278);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(450, 280);
            this.MinimumSize = new System.Drawing.Size(450, 280);
            this.Name = "SendDataForm";
            this.Load += new System.EventHandler(this.SendDataModForm_Load);
            this.panel_bottom.ResumeLayout(false);
            this.panel_center.ResumeLayout(false);
            this.panel_center.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbox_Icon)).EndInit();
            this.titlepanel.ResumeLayout(false);
            this.titlepanel.PerformLayout();
            this.ResumeLayout(false);

        }
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private Rex.UI.UITextBox tbxEndStr;
        private Rex.UI.MyComboBox cbxSelect;
        private RexControl.MyControls.MyLinkData ldContent;

        #endregion

        //private System.Windows.Forms.GroupBox groupBox1;
        //private System.Windows.Forms.ComboBox comboBox1;
        //private System.Windows.Forms.Label label1;
        //private System.Windows.Forms.Label label4;
        //private System.Windows.Forms.TreeView treeView1;
        //private System.Windows.Forms.TextBox textBox1;
        //private System.Windows.Forms.Label label3;
    }
}