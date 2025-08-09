
namespace Plugin.NinePointsCalib
{
    partial class CalibResultForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CalibResultForm));
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.btnClose = new System.Windows.Forms.Button();
            this.lblModName = new System.Windows.Forms.Label();
            this.label37 = new System.Windows.Forms.Label();
            this.label43 = new System.Windows.Forms.Label();
            this.label42 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.uibt_Close = new Rex.UI.UIButton();
            this.uibt_NO = new Rex.UI.UIButton();
            this.lblPrecisionX = new Rex.UI.UILabel();
            this.lblPrecisionY = new Rex.UI.UILabel();
            this.lblRMS = new Rex.UI.UILabel();
            this.lblResult = new Rex.UI.UISymbolLabel();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.BackColor = System.Drawing.Color.AliceBlue;
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 88.58131F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 11.41868F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Controls.Add(this.btnClose, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.lblModName, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(301, 27);
            this.tableLayoutPanel1.TabIndex = 130;
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
            this.btnClose.Location = new System.Drawing.Point(273, 6);
            this.btnClose.Margin = new System.Windows.Forms.Padding(7, 6, 5, 5);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(23, 16);
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
            this.lblModName.Text = "标定结果";
            this.lblModName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label37
            // 
            this.label37.AutoSize = true;
            this.label37.BackColor = System.Drawing.Color.Transparent;
            this.label37.Font = new System.Drawing.Font("华文新魏", 11F);
            this.label37.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.label37.Location = new System.Drawing.Point(25, 155);
            this.label37.Name = "label37";
            this.label37.Size = new System.Drawing.Size(115, 16);
            this.label37.TabIndex = 138;
            this.label37.Text = "RMS误差(pixel):";
            // 
            // label43
            // 
            this.label43.AutoSize = true;
            this.label43.BackColor = System.Drawing.Color.Transparent;
            this.label43.Font = new System.Drawing.Font("华文新魏", 11F);
            this.label43.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.label43.Location = new System.Drawing.Point(25, 79);
            this.label43.Name = "label43";
            this.label43.Size = new System.Drawing.Size(119, 16);
            this.label43.TabIndex = 132;
            this.label43.Text = "像素当量X(mm):";
            // 
            // label42
            // 
            this.label42.AutoSize = true;
            this.label42.BackColor = System.Drawing.Color.Transparent;
            this.label42.Font = new System.Drawing.Font("华文新魏", 11F);
            this.label42.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.label42.Location = new System.Drawing.Point(25, 117);
            this.label42.Name = "label42";
            this.label42.Size = new System.Drawing.Size(118, 16);
            this.label42.TabIndex = 133;
            this.label42.Text = "像素当量Y(mm):";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.AliceBlue;
            this.panel3.Controls.Add(this.uibt_Close);
            this.panel3.Controls.Add(this.uibt_NO);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel3.Location = new System.Drawing.Point(0, 195);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(301, 35);
            this.panel3.TabIndex = 146;
            // 
            // uibt_Close
            // 
            this.uibt_Close.BackColor = System.Drawing.Color.AliceBlue;
            this.uibt_Close.Cursor = System.Windows.Forms.Cursors.Hand;
            this.uibt_Close.FillColor = System.Drawing.Color.CornflowerBlue;
            this.uibt_Close.FillDisableColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            this.uibt_Close.Font = new System.Drawing.Font("隶书", 11F);
            this.uibt_Close.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            this.uibt_Close.ForeDisableColor = System.Drawing.Color.White;
            this.uibt_Close.ForeHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            this.uibt_Close.ForePressColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            this.uibt_Close.ForeSelectedColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            this.uibt_Close.Location = new System.Drawing.Point(207, 6);
            this.uibt_Close.MinimumSize = new System.Drawing.Size(1, 1);
            this.uibt_Close.Name = "uibt_Close";
            this.uibt_Close.Radius = 11;
            this.uibt_Close.RectColor = System.Drawing.Color.CornflowerBlue;
            this.uibt_Close.Size = new System.Drawing.Size(70, 24);
            this.uibt_Close.Style = Rex.UI.UIStyle.Custom;
            this.uibt_Close.StyleCustomMode = true;
            this.uibt_Close.TabIndex = 127;
            this.uibt_Close.Text = "关闭";
            this.uibt_Close.Click += new System.EventHandler(this.uibt_Close_Click);
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
            // 
            // lblPrecisionX
            // 
            this.lblPrecisionX.BackColor = System.Drawing.Color.AliceBlue;
            this.lblPrecisionX.Font = new System.Drawing.Font("华文新魏", 11F);
            this.lblPrecisionX.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.lblPrecisionX.Location = new System.Drawing.Point(140, 75);
            this.lblPrecisionX.Name = "lblPrecisionX";
            this.lblPrecisionX.Size = new System.Drawing.Size(137, 24);
            this.lblPrecisionX.TabIndex = 147;
            this.lblPrecisionX.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblPrecisionY
            // 
            this.lblPrecisionY.BackColor = System.Drawing.Color.AliceBlue;
            this.lblPrecisionY.Font = new System.Drawing.Font("华文新魏", 11F);
            this.lblPrecisionY.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.lblPrecisionY.Location = new System.Drawing.Point(141, 113);
            this.lblPrecisionY.Name = "lblPrecisionY";
            this.lblPrecisionY.Size = new System.Drawing.Size(137, 24);
            this.lblPrecisionY.TabIndex = 148;
            this.lblPrecisionY.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblRMS
            // 
            this.lblRMS.BackColor = System.Drawing.Color.AliceBlue;
            this.lblRMS.Font = new System.Drawing.Font("华文新魏", 11F);
            this.lblRMS.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.lblRMS.Location = new System.Drawing.Point(141, 151);
            this.lblRMS.Name = "lblRMS";
            this.lblRMS.Size = new System.Drawing.Size(137, 24);
            this.lblRMS.TabIndex = 149;
            this.lblRMS.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblResult
            // 
            this.lblResult.BackColor = System.Drawing.Color.White;
            this.lblResult.Font = new System.Drawing.Font("华文新魏", 11.5F);
            this.lblResult.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(20)))), ((int)(((byte)(50)))));
            this.lblResult.Location = new System.Drawing.Point(26, 48);
            this.lblResult.MinimumSize = new System.Drawing.Size(1, 1);
            this.lblResult.Name = "lblResult";
            this.lblResult.Padding = new System.Windows.Forms.Padding(22, 0, 0, 0);
            this.lblResult.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblResult.Size = new System.Drawing.Size(251, 23);
            this.lblResult.Style = Rex.UI.UIStyle.Custom;
            this.lblResult.Symbol = 61453;
            this.lblResult.SymbolColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(20)))), ((int)(((byte)(50)))));
            this.lblResult.SymbolSize = 18;
            this.lblResult.TabIndex = 150;
            this.lblResult.Text = "标定未执行";
            this.lblResult.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // CalibResultForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(301, 230);
            this.Controls.Add(this.lblResult);
            this.Controls.Add(this.lblRMS);
            this.Controls.Add(this.lblPrecisionY);
            this.Controls.Add(this.lblPrecisionX);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.label37);
            this.Controls.Add(this.label43);
            this.Controls.Add(this.label42);
            this.Controls.Add(this.tableLayoutPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "CalibResultForm";
            this.Text = "CalibResultForm";
            this.TopMost = true;
            this.Shown += new System.EventHandler(this.CalibResultForm_Shown);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Label lblModName;
        private System.Windows.Forms.Label label37;
        private System.Windows.Forms.Label label43;
        private System.Windows.Forms.Label label42;
        private System.Windows.Forms.Panel panel3;
        private Rex.UI.UIButton uibt_Close;
        private Rex.UI.UIButton uibt_NO;
        public Rex.UI.UILabel lblPrecisionX;
        public Rex.UI.UILabel lblPrecisionY;
        public Rex.UI.UILabel lblRMS;
        public Rex.UI.UISymbolLabel lblResult;
    }
}