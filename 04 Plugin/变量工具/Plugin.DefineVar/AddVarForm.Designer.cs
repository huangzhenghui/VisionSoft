
namespace Plugin.DefineVar
{
    partial class AddVarForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddVarForm));
            this.panel2 = new System.Windows.Forms.Panel();
            this.tbxComment = new Rex.UI.UITextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tbxValue = new Rex.UI.UITextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tbxVarName = new Rex.UI.UITextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.uibt_OK = new Rex.UI.UIButton();
            this.uibt_NO = new Rex.UI.UIButton();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.btnClose = new System.Windows.Forms.Button();
            this.lblModName = new System.Windows.Forms.Label();
            this.cbxVarType = new Rex.UI.MyComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbox_Icon)).BeginInit();
            this.titlepanel.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pbox_Icon
            // 
            this.pbox_Icon.Size = new System.Drawing.Size(30, 573);
            // 
            // titlepanel
            // 
            this.titlepanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.titlepanel.Size = new System.Drawing.Size(451, 573);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.Add(this.tbxComment);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.tbxValue);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.tbxVarName);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.cbxVarType);
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Controls.Add(this.tableLayoutPanel1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(451, 573);
            this.panel2.TabIndex = 126;
            // 
            // tbxComment
            // 
            this.tbxComment.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbxComment.FillColor = System.Drawing.Color.AliceBlue;
            this.tbxComment.FillDisableColor = System.Drawing.Color.AliceBlue;
            this.tbxComment.Font = new System.Drawing.Font("华文新魏", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tbxComment.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.tbxComment.ForeDisableColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.tbxComment.Location = new System.Drawing.Point(67, 352);
            this.tbxComment.Margin = new System.Windows.Forms.Padding(0);
            this.tbxComment.Maximum = 2147483647D;
            this.tbxComment.Minimum = -2147483648D;
            this.tbxComment.MinimumSize = new System.Drawing.Size(1, 1);
            this.tbxComment.Multiline = true;
            this.tbxComment.Name = "tbxComment";
            this.tbxComment.RectColor = System.Drawing.Color.White;
            this.tbxComment.RectDisableColor = System.Drawing.Color.White;
            this.tbxComment.Size = new System.Drawing.Size(329, 127);
            this.tbxComment.Style = Rex.UI.UIStyle.Custom;
            this.tbxComment.TabIndex = 198;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("华文新魏", 11F);
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.label4.Location = new System.Drawing.Point(64, 324);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(43, 16);
            this.label4.TabIndex = 197;
            this.label4.Text = "注释:";
            // 
            // tbxValue
            // 
            this.tbxValue.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbxValue.FillColor = System.Drawing.Color.AliceBlue;
            this.tbxValue.FillDisableColor = System.Drawing.Color.AliceBlue;
            this.tbxValue.Font = new System.Drawing.Font("华文新魏", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tbxValue.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.tbxValue.ForeDisableColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.tbxValue.Location = new System.Drawing.Point(67, 180);
            this.tbxValue.Margin = new System.Windows.Forms.Padding(0);
            this.tbxValue.Maximum = 2147483647D;
            this.tbxValue.Minimum = -2147483648D;
            this.tbxValue.MinimumSize = new System.Drawing.Size(1, 1);
            this.tbxValue.Multiline = true;
            this.tbxValue.Name = "tbxValue";
            this.tbxValue.RectColor = System.Drawing.Color.White;
            this.tbxValue.Size = new System.Drawing.Size(329, 127);
            this.tbxValue.Style = Rex.UI.UIStyle.Custom;
            this.tbxValue.TabIndex = 196;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("华文新魏", 11F);
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.label3.Location = new System.Drawing.Point(64, 152);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 16);
            this.label3.TabIndex = 195;
            this.label3.Text = "变量值:";
            // 
            // tbxVarName
            // 
            this.tbxVarName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbxVarName.FillColor = System.Drawing.Color.AliceBlue;
            this.tbxVarName.FillDisableColor = System.Drawing.Color.AliceBlue;
            this.tbxVarName.Font = new System.Drawing.Font("华文新魏", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tbxVarName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.tbxVarName.ForeDisableColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.tbxVarName.Location = new System.Drawing.Point(140, 107);
            this.tbxVarName.Margin = new System.Windows.Forms.Padding(0);
            this.tbxVarName.Maximum = 2147483647D;
            this.tbxVarName.Minimum = -2147483648D;
            this.tbxVarName.MinimumSize = new System.Drawing.Size(1, 1);
            this.tbxVarName.Name = "tbxVarName";
            this.tbxVarName.RectColor = System.Drawing.Color.AliceBlue;
            this.tbxVarName.Size = new System.Drawing.Size(207, 23);
            this.tbxVarName.Style = Rex.UI.UIStyle.Custom;
            this.tbxVarName.TabIndex = 194;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("华文新魏", 11F);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.label1.Location = new System.Drawing.Point(64, 112);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 16);
            this.label1.TabIndex = 193;
            this.label1.Text = "变量名称:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("华文新魏", 11F);
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.label2.Location = new System.Drawing.Point(64, 72);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 16);
            this.label2.TabIndex = 192;
            this.label2.Text = "变量类型:";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.AliceBlue;
            this.panel3.Controls.Add(this.uibt_OK);
            this.panel3.Controls.Add(this.uibt_NO);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel3.Location = new System.Drawing.Point(0, 531);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(451, 42);
            this.panel3.TabIndex = 131;
            // 
            // uibt_OK
            // 
            this.uibt_OK.BackColor = System.Drawing.Color.AliceBlue;
            this.uibt_OK.Cursor = System.Windows.Forms.Cursors.Hand;
            this.uibt_OK.FillColor = System.Drawing.Color.CornflowerBlue;
            this.uibt_OK.FillDisableColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            this.uibt_OK.Font = new System.Drawing.Font("隶书", 12F);
            this.uibt_OK.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            this.uibt_OK.ForeDisableColor = System.Drawing.Color.White;
            this.uibt_OK.ForeHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            this.uibt_OK.ForePressColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            this.uibt_OK.ForeSelectedColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            this.uibt_OK.Location = new System.Drawing.Point(273, 8);
            this.uibt_OK.MinimumSize = new System.Drawing.Size(1, 1);
            this.uibt_OK.Name = "uibt_OK";
            this.uibt_OK.Radius = 11;
            this.uibt_OK.RectColor = System.Drawing.Color.CornflowerBlue;
            this.uibt_OK.Size = new System.Drawing.Size(70, 26);
            this.uibt_OK.Style = Rex.UI.UIStyle.Custom;
            this.uibt_OK.StyleCustomMode = true;
            this.uibt_OK.TabIndex = 127;
            this.uibt_OK.Text = "确认";
            this.uibt_OK.Click += new System.EventHandler(this.uibt_OK_Click);
            // 
            // uibt_NO
            // 
            this.uibt_NO.BackColor = System.Drawing.Color.AliceBlue;
            this.uibt_NO.Cursor = System.Windows.Forms.Cursors.Hand;
            this.uibt_NO.FillColor = System.Drawing.Color.CornflowerBlue;
            this.uibt_NO.FillDisableColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            this.uibt_NO.Font = new System.Drawing.Font("隶书", 12F);
            this.uibt_NO.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            this.uibt_NO.ForeDisableColor = System.Drawing.Color.White;
            this.uibt_NO.ForeHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            this.uibt_NO.ForePressColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            this.uibt_NO.ForeSelectedColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            this.uibt_NO.Location = new System.Drawing.Point(369, 8);
            this.uibt_NO.MinimumSize = new System.Drawing.Size(1, 1);
            this.uibt_NO.Name = "uibt_NO";
            this.uibt_NO.Radius = 11;
            this.uibt_NO.RectColor = System.Drawing.Color.CornflowerBlue;
            this.uibt_NO.Size = new System.Drawing.Size(70, 26);
            this.uibt_NO.Style = Rex.UI.UIStyle.Custom;
            this.uibt_NO.StyleCustomMode = true;
            this.uibt_NO.TabIndex = 128;
            this.uibt_NO.Text = "取消";
            this.uibt_NO.Click += new System.EventHandler(this.uibt_NO_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.BackColor = System.Drawing.Color.AliceBlue;
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 93.02789F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 6.972112F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Controls.Add(this.btnClose, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.lblModName, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(451, 27);
            this.tableLayoutPanel1.TabIndex = 129;
            this.tableLayoutPanel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.FrmAddVar_MouseDown);
            this.tableLayoutPanel1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.FrmAddVar_MouseMove);
            this.tableLayoutPanel1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.FrmAddVar_MouseUp);
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.AliceBlue;
            this.btnClose.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnClose.FlatAppearance.BorderColor = System.Drawing.Color.AliceBlue;
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.FlatAppearance.MouseDownBackColor = System.Drawing.Color.AliceBlue;
            this.btnClose.FlatAppearance.MouseOverBackColor = System.Drawing.Color.AliceBlue;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Image = ((System.Drawing.Image)(resources.GetObject("btnClose.Image")));
            this.btnClose.Location = new System.Drawing.Point(426, 6);
            this.btnClose.Margin = new System.Windows.Forms.Padding(7, 6, 5, 5);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(20, 16);
            this.btnClose.TabIndex = 1;
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // lblModName
            // 
            this.lblModName.Dock = System.Windows.Forms.DockStyle.Left;
            this.lblModName.Font = new System.Drawing.Font("隶书", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblModName.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.lblModName.Location = new System.Drawing.Point(3, 0);
            this.lblModName.Name = "lblModName";
            this.lblModName.Padding = new System.Windows.Forms.Padding(2, 0, 0, 0);
            this.lblModName.Size = new System.Drawing.Size(116, 27);
            this.lblModName.TabIndex = 3;
            this.lblModName.Text = "添加变量";
            this.lblModName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // cbxVarType
            // 
            this.cbxVarType.BackColor = System.Drawing.Color.White;
            this.cbxVarType.DropDownStyle = Rex.UI.UIDropDownStyle.DropDownList;
            this.cbxVarType.FillColor = System.Drawing.Color.AliceBlue;
            this.cbxVarType.FillDisableColor = System.Drawing.Color.AliceBlue;
            this.cbxVarType.Font = new System.Drawing.Font("华文新魏", 11.5F);
            this.cbxVarType.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.cbxVarType.ForeDisableColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.cbxVarType.Items.AddRange(new object[] {
            "int",
            "int[]",
            "double",
            "double[]",
            "bool",
            "bool[]",
            "string",
            "string[]"});
            this.cbxVarType.Location = new System.Drawing.Point(140, 67);
            this.cbxVarType.Margin = new System.Windows.Forms.Padding(0);
            this.cbxVarType.MinimumSize = new System.Drawing.Size(63, 0);
            this.cbxVarType.Name = "cbxVarType";
            this.cbxVarType.Padding = new System.Windows.Forms.Padding(0, 0, 30, 0);
            this.cbxVarType.Radius = 2;
            this.cbxVarType.RectColor = System.Drawing.Color.CornflowerBlue;
            this.cbxVarType.RectDisableColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.cbxVarType.RectSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.None;
            this.cbxVarType.Size = new System.Drawing.Size(207, 23);
            this.cbxVarType.Style = Rex.UI.UIStyle.Custom;
            this.cbxVarType.StyleCustomMode = true;
            this.cbxVarType.SymbolDropDown = 61656;
            this.cbxVarType.SymbolNormal = 61655;
            this.cbxVarType.TabIndex = 132;
            this.cbxVarType.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // FrmAddVar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(451, 573);
            this.Controls.Add(this.panel2);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmAddVar";
            this.Opacity = 0.9D;
            this.Controls.SetChildIndex(this.titlepanel, 0);
            this.Controls.SetChildIndex(this.panel2, 0);
            ((System.ComponentModel.ISupportInitialize)(this.pbox_Icon)).EndInit();
            this.titlepanel.ResumeLayout(false);
            this.titlepanel.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private Rex.UI.UIButton uibt_OK;
        private Rex.UI.UIButton uibt_NO;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Label lblModName;
        private Rex.UI.MyComboBox cbxVarType;
        private System.Windows.Forms.Label label2;
        private Rex.UI.UITextBox tbxVarName;
        private System.Windows.Forms.Label label1;
        private Rex.UI.UITextBox tbxComment;
        private System.Windows.Forms.Label label4;
        private Rex.UI.UITextBox tbxValue;
        private System.Windows.Forms.Label label3;
    }
}