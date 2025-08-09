namespace Plugin.For
{
    partial class ForForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ForForm));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.ldForNum = new RexControl.MyControls.MyLinkData();
            this.cbxForMode = new Rex.UI.MyComboBox();
            this.panel_bottom.SuspendLayout();
            this.panel_center.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbox_Icon)).BeginInit();
            this.titlepanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel_bottom
            // 
            this.panel_bottom.Location = new System.Drawing.Point(1, 161);
            this.panel_bottom.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel_bottom.Size = new System.Drawing.Size(498, 38);
            // 
            // lblTime
            // 
            this.lblTime.Location = new System.Drawing.Point(254, 4);
            this.lblTime.Size = new System.Drawing.Size(125, 30);
            // 
            // btn_Run
            // 
            this.btn_Run.Location = new System.Drawing.Point(392, 4);
            this.btn_Run.Size = new System.Drawing.Size(78, 30);
            this.btn_Run.Click += new System.EventHandler(this.btn_Run_Click);
            // 
            // panel_center
            // 
            this.panel_center.Controls.Add(this.cbxForMode);
            this.panel_center.Controls.Add(this.ldForNum);
            this.panel_center.Controls.Add(this.label2);
            this.panel_center.Controls.Add(this.label1);
            this.panel_center.Margin = new System.Windows.Forms.Padding(4);
            this.panel_center.Size = new System.Drawing.Size(498, 133);
            // 
            // pbox_Icon
            // 
            this.pbox_Icon.Size = new System.Drawing.Size(30, 30);
            // 
            // titlepanel
            // 
            this.titlepanel.Size = new System.Drawing.Size(496, 32);
            // 
            // titlelabel
            // 
            this.titlelabel.Font = new System.Drawing.Font("华文新魏", 11F);
            this.titlelabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.titlelabel.Size = new System.Drawing.Size(73, 16);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("华文新魏", 11F);
            this.label1.ForeColor = System.Drawing.Color.DimGray;
            this.label1.Location = new System.Drawing.Point(102, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 16);
            this.label1.TabIndex = 137;
            this.label1.Text = "循环方式:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("华文新魏", 11F);
            this.label2.ForeColor = System.Drawing.Color.DimGray;
            this.label2.Location = new System.Drawing.Point(102, 71);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 16);
            this.label2.TabIndex = 138;
            this.label2.Text = "循环次数:";
            // 
            // ldForNum
            // 
            this.ldForNum.BackColor = System.Drawing.Color.AliceBlue;
            this.ldForNum.Font = new System.Drawing.Font("华文新魏", 12F);
            this.ldForNum.FontStyle = new System.Drawing.Font("华文新魏", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.ldForNum.Location = new System.Drawing.Point(178, 65);
            this.ldForNum.Margin = new System.Windows.Forms.Padding(4, 5, 4, 4);
            this.ldForNum.Name = "ldForNum";
            this.ldForNum.Size = new System.Drawing.Size(214, 24);
            this.ldForNum.TabIndex = 196;
            this.ldForNum.TextInfo = "";
            this.ldForNum.LinkData += new System.EventHandler(this.uiLinkText1_BtnAdd);
            // 
            // cbxForMode
            // 
            this.cbxForMode.BackColor = System.Drawing.Color.AliceBlue;
            this.cbxForMode.DropDownStyle = Rex.UI.UIDropDownStyle.DropDownList;
            this.cbxForMode.FillColor = System.Drawing.Color.AliceBlue;
            this.cbxForMode.Font = new System.Drawing.Font("华文新魏", 11.6F);
            this.cbxForMode.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.cbxForMode.ForeDisableColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.cbxForMode.Items.AddRange(new object[] {
            "有限循环",
            "无限循环"});
            this.cbxForMode.Location = new System.Drawing.Point(178, 32);
            this.cbxForMode.Margin = new System.Windows.Forms.Padding(0);
            this.cbxForMode.MinimumSize = new System.Drawing.Size(63, 0);
            this.cbxForMode.Name = "cbxForMode";
            this.cbxForMode.Padding = new System.Windows.Forms.Padding(0, 0, 30, 0);
            this.cbxForMode.Radius = 2;
            this.cbxForMode.RectColor = System.Drawing.Color.CornflowerBlue;
            this.cbxForMode.RectDisableColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.cbxForMode.RectSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.None;
            this.cbxForMode.Size = new System.Drawing.Size(214, 24);
            this.cbxForMode.Style = Rex.UI.UIStyle.Custom;
            this.cbxForMode.StyleCustomMode = true;
            this.cbxForMode.SymbolDropDown = 61656;
            this.cbxForMode.SymbolNormal = 61655;
            this.cbxForMode.TabIndex = 227;
            this.cbxForMode.Text = "请选择循环方式";
            this.cbxForMode.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.cbxForMode.SelectedIndexChanged += new System.EventHandler(this.cbxForMode_SelectedIndexChanged);
            // 
            // ForForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(500, 200);
            this.Font = new System.Drawing.Font("华文新魏", 11.5F);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximumSize = new System.Drawing.Size(500, 200);
            this.MinimumSize = new System.Drawing.Size(500, 200);
            this.Name = "ForForm";
            this.TitleColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.TitleFont = new System.Drawing.Font("华文新魏", 11F);
            this.TitleSize = new System.Drawing.Size(73, 16);
            this.panel_bottom.ResumeLayout(false);
            this.panel_center.ResumeLayout(false);
            this.panel_center.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbox_Icon)).EndInit();
            this.titlepanel.ResumeLayout(false);
            this.titlepanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private RexControl.MyControls.MyLinkData ldForNum;
        private Rex.UI.MyComboBox cbxForMode;
    }
}