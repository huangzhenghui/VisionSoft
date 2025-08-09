namespace Plugin.Judge
{
    partial class JudgeForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(JudgeForm));
            this.ldComparison = new RexControl.MyControls.MyLinkData();
            this.ldStd = new RexControl.MyControls.MyLinkData();
            this.cbxRelation = new Rex.UI.MyComboBox();
            this.swLogic = new Rex.UI.UISwitch();
            this.cbxCondition = new Rex.UI.MyComboBox();
            this.panel_bottom.SuspendLayout();
            this.panel_center.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbox_Icon)).BeginInit();
            this.titlepanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel_bottom
            // 
            this.panel_bottom.Location = new System.Drawing.Point(1, 239);
            this.panel_bottom.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel_bottom.Size = new System.Drawing.Size(546, 38);
            // 
            // lblTime
            // 
            this.lblTime.Location = new System.Drawing.Point(302, 4);
            this.lblTime.Size = new System.Drawing.Size(125, 30);
            // 
            // btn_Run
            // 
            this.btn_Run.Location = new System.Drawing.Point(440, 4);
            this.btn_Run.Size = new System.Drawing.Size(78, 30);
            this.btn_Run.Click += new System.EventHandler(this.btn_Run_Click);
            // 
            // panel_center
            // 
            this.panel_center.Controls.Add(this.cbxCondition);
            this.panel_center.Controls.Add(this.swLogic);
            this.panel_center.Controls.Add(this.cbxRelation);
            this.panel_center.Controls.Add(this.ldStd);
            this.panel_center.Controls.Add(this.ldComparison);
            this.panel_center.Margin = new System.Windows.Forms.Padding(4);
            this.panel_center.Size = new System.Drawing.Size(546, 211);
            // 
            // pbox_Icon
            // 
            this.pbox_Icon.Size = new System.Drawing.Size(30, 30);
            // 
            // titlepanel
            // 
            this.titlepanel.Size = new System.Drawing.Size(496, 32);
            // 
            // ldComparison
            // 
            this.ldComparison.BackColor = System.Drawing.Color.AliceBlue;
            this.ldComparison.Font = new System.Drawing.Font("华文新魏", 12F);
            this.ldComparison.FontStyle = new System.Drawing.Font("华文新魏", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.ldComparison.Location = new System.Drawing.Point(172, 99);
            this.ldComparison.Margin = new System.Windows.Forms.Padding(4, 5, 4, 4);
            this.ldComparison.Name = "ldComparison";
            this.ldComparison.Size = new System.Drawing.Size(224, 24);
            this.ldComparison.TabIndex = 197;
            this.ldComparison.TextInfo = "";
            this.ldComparison.LinkData += new System.EventHandler(this.ldData_LinkData);
            // 
            // ldStd
            // 
            this.ldStd.BackColor = System.Drawing.Color.AliceBlue;
            this.ldStd.Font = new System.Drawing.Font("华文新魏", 12F);
            this.ldStd.FontStyle = new System.Drawing.Font("华文新魏", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.ldStd.Location = new System.Drawing.Point(172, 136);
            this.ldStd.Margin = new System.Windows.Forms.Padding(4, 5, 4, 4);
            this.ldStd.Name = "ldStd";
            this.ldStd.Size = new System.Drawing.Size(224, 24);
            this.ldStd.TabIndex = 230;
            this.ldStd.TextInfo = "";
            this.ldStd.LinkData += new System.EventHandler(this.ldData_LinkData);
            // 
            // cbxRelation
            // 
            this.cbxRelation.BackColor = System.Drawing.Color.AliceBlue;
            this.cbxRelation.DropDownStyle = Rex.UI.UIDropDownStyle.DropDownList;
            this.cbxRelation.FillColor = System.Drawing.Color.AliceBlue;
            this.cbxRelation.Font = new System.Drawing.Font("华文新魏", 11.6F);
            this.cbxRelation.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.cbxRelation.ForeDisableColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.cbxRelation.Items.AddRange(new object[] {
            "等于",
            "不等于",
            "大于",
            "大于等于",
            "小于",
            "小于等于",
            "包含",
            "不包含"});
            this.cbxRelation.Location = new System.Drawing.Point(256, 61);
            this.cbxRelation.Margin = new System.Windows.Forms.Padding(0);
            this.cbxRelation.MinimumSize = new System.Drawing.Size(63, 0);
            this.cbxRelation.Name = "cbxRelation";
            this.cbxRelation.Padding = new System.Windows.Forms.Padding(0, 0, 30, 0);
            this.cbxRelation.Radius = 2;
            this.cbxRelation.RectColor = System.Drawing.Color.CornflowerBlue;
            this.cbxRelation.RectDisableColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.cbxRelation.RectSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.None;
            this.cbxRelation.Size = new System.Drawing.Size(140, 24);
            this.cbxRelation.Style = Rex.UI.UIStyle.Custom;
            this.cbxRelation.StyleCustomMode = true;
            this.cbxRelation.SymbolDropDown = 61656;
            this.cbxRelation.SymbolNormal = 61655;
            this.cbxRelation.TabIndex = 238;
            this.cbxRelation.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // swLogic
            // 
            this.swLogic.Active = true;
            this.swLogic.ActiveColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(131)))), ((int)(((byte)(229)))));
            this.swLogic.ActiveText = "与";
            this.swLogic.ButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            this.swLogic.Font = new System.Drawing.Font("华文新魏", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.swLogic.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            this.swLogic.InActiveColor = System.Drawing.Color.LightCoral;
            this.swLogic.InActiveText = "或";
            this.swLogic.Location = new System.Drawing.Point(172, 62);
            this.swLogic.MinimumSize = new System.Drawing.Size(1, 1);
            this.swLogic.Name = "swLogic";
            this.swLogic.Size = new System.Drawing.Size(66, 23);
            this.swLogic.Style = Rex.UI.UIStyle.Custom;
            this.swLogic.TabIndex = 239;
            this.swLogic.Text = "uiSwitch1";
            // 
            // cbxCondition
            // 
            this.cbxCondition.BackColor = System.Drawing.Color.AliceBlue;
            this.cbxCondition.DropDownStyle = Rex.UI.UIDropDownStyle.DropDownList;
            this.cbxCondition.FillColor = System.Drawing.Color.AliceBlue;
            this.cbxCondition.Font = new System.Drawing.Font("华文新魏", 11.6F);
            this.cbxCondition.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.cbxCondition.ForeDisableColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.cbxCondition.Items.AddRange(new object[] {
            "条件1",
            "条件2",
            "条件3",
            "条件4"});
            this.cbxCondition.Location = new System.Drawing.Point(25, 17);
            this.cbxCondition.Margin = new System.Windows.Forms.Padding(0);
            this.cbxCondition.MinimumSize = new System.Drawing.Size(63, 0);
            this.cbxCondition.Name = "cbxCondition";
            this.cbxCondition.Padding = new System.Windows.Forms.Padding(0, 0, 30, 0);
            this.cbxCondition.Radius = 2;
            this.cbxCondition.RectColor = System.Drawing.Color.CornflowerBlue;
            this.cbxCondition.RectDisableColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.cbxCondition.RectSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.None;
            this.cbxCondition.Size = new System.Drawing.Size(78, 24);
            this.cbxCondition.Style = Rex.UI.UIStyle.Custom;
            this.cbxCondition.StyleCustomMode = true;
            this.cbxCondition.SymbolDropDown = 61656;
            this.cbxCondition.SymbolNormal = 61655;
            this.cbxCondition.TabIndex = 239;
            this.cbxCondition.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.cbxCondition.SelectedIndexChanged += new System.EventHandler(this.cbxCondition_SelectedIndexChanged);
            // 
            // JudgeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(548, 278);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximumSize = new System.Drawing.Size(550, 280);
            this.MinimumSize = new System.Drawing.Size(550, 280);
            this.Name = "JudgeForm";
            this.panel_bottom.ResumeLayout(false);
            this.panel_center.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbox_Icon)).EndInit();
            this.titlepanel.ResumeLayout(false);
            this.titlepanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private RexControl.MyControls.MyLinkData ldComparison;
        private RexControl.MyControls.MyLinkData ldStd;
        private Rex.UI.MyComboBox cbxRelation;
        private Rex.UI.UISwitch swLogic;
        private Rex.UI.MyComboBox cbxCondition;
    }
}