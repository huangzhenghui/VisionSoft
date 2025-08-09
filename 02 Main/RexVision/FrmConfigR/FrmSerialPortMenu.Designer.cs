
namespace TSIVision.FrmConfigR
{
    partial class FrmSerialPortMenu
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmSerialPortMenu));
            this.panel1 = new System.Windows.Forms.Panel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.btnClose = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.pbxJudge1 = new System.Windows.Forms.PictureBox();
            this.pbxJudge2 = new System.Windows.Forms.PictureBox();
            this.pbxJudge3 = new System.Windows.Forms.PictureBox();
            this.pbxJudge4 = new System.Windows.Forms.PictureBox();
            this.pbxJudge5 = new System.Windows.Forms.PictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.cbxSerialPortNum = new Rex.UI.MyComboBox();
            this.cbxBaudRate = new Rex.UI.MyComboBox();
            this.cbxCheckBits = new Rex.UI.MyComboBox();
            this.cbxDataBits = new Rex.UI.MyComboBox();
            this.cbxStopBits = new Rex.UI.MyComboBox();
            this.panel1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbxJudge1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxJudge2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxJudge3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxJudge4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxJudge5)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.tableLayoutPanel1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(429, 23);
            this.panel1.TabIndex = 65;
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.FrmCCamDebug_MouseDown);
            this.panel1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.FrmCCamDebug_MouseMove);
            this.panel1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.FrmCCamDebug_MouseUp);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Controls.Add(this.btnClose, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(399, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(30, 23);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // btnClose
            // 
            this.btnClose.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnClose.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.btnClose.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Image = ((System.Drawing.Image)(resources.GetObject("btnClose.Image")));
            this.btnClose.Location = new System.Drawing.Point(3, 3);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(24, 17);
            this.btnClose.TabIndex = 0;
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnToolBar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("华文新魏", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.ImageAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.label1.Location = new System.Drawing.Point(86, 133);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 19);
            this.label1.TabIndex = 63;
            this.label1.Text = "波特率:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("华文新魏", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label3.ImageAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.label3.Location = new System.Drawing.Point(86, 85);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 19);
            this.label3.TabIndex = 61;
            this.label3.Text = "串口号:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("华文新魏", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.ImageAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.label2.Location = new System.Drawing.Point(86, 229);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 19);
            this.label2.TabIndex = 67;
            this.label2.Text = "数据位:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("华文新魏", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label4.ImageAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.label4.Location = new System.Drawing.Point(86, 181);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(72, 19);
            this.label4.TabIndex = 65;
            this.label4.Text = "校验位:";
            this.label4.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("华文新魏", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label5.ImageAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.label5.Location = new System.Drawing.Point(86, 277);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(72, 19);
            this.label5.TabIndex = 69;
            this.label5.Text = "停止位:";
            this.label5.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // pbxJudge1
            // 
            this.pbxJudge1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pbxJudge1.Location = new System.Drawing.Point(344, 84);
            this.pbxJudge1.Name = "pbxJudge1";
            this.pbxJudge1.Size = new System.Drawing.Size(20, 20);
            this.pbxJudge1.TabIndex = 74;
            this.pbxJudge1.TabStop = false;
            // 
            // pbxJudge2
            // 
            this.pbxJudge2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pbxJudge2.Location = new System.Drawing.Point(344, 132);
            this.pbxJudge2.Name = "pbxJudge2";
            this.pbxJudge2.Size = new System.Drawing.Size(20, 20);
            this.pbxJudge2.TabIndex = 75;
            this.pbxJudge2.TabStop = false;
            // 
            // pbxJudge3
            // 
            this.pbxJudge3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pbxJudge3.Location = new System.Drawing.Point(344, 180);
            this.pbxJudge3.Name = "pbxJudge3";
            this.pbxJudge3.Size = new System.Drawing.Size(20, 20);
            this.pbxJudge3.TabIndex = 76;
            this.pbxJudge3.TabStop = false;
            // 
            // pbxJudge4
            // 
            this.pbxJudge4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pbxJudge4.Location = new System.Drawing.Point(344, 228);
            this.pbxJudge4.Name = "pbxJudge4";
            this.pbxJudge4.Size = new System.Drawing.Size(20, 20);
            this.pbxJudge4.TabIndex = 77;
            this.pbxJudge4.TabStop = false;
            // 
            // pbxJudge5
            // 
            this.pbxJudge5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pbxJudge5.Location = new System.Drawing.Point(344, 276);
            this.pbxJudge5.Name = "pbxJudge5";
            this.pbxJudge5.Size = new System.Drawing.Size(20, 20);
            this.pbxJudge5.TabIndex = 78;
            this.pbxJudge5.TabStop = false;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // cbxSerialPortNum
            // 
            this.cbxSerialPortNum.BackColor = System.Drawing.Color.AliceBlue;
            this.cbxSerialPortNum.DropDownStyle = Rex.UI.UIDropDownStyle.DropDownList;
            this.cbxSerialPortNum.FillColor = System.Drawing.Color.Navy;
            this.cbxSerialPortNum.Font = new System.Drawing.Font("华文新魏", 13.5F);
            this.cbxSerialPortNum.ForeColor = System.Drawing.Color.White;
            this.cbxSerialPortNum.ForeDisableColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.cbxSerialPortNum.Location = new System.Drawing.Point(163, 81);
            this.cbxSerialPortNum.Margin = new System.Windows.Forms.Padding(0);
            this.cbxSerialPortNum.MinimumSize = new System.Drawing.Size(63, 0);
            this.cbxSerialPortNum.Name = "cbxSerialPortNum";
            this.cbxSerialPortNum.Padding = new System.Windows.Forms.Padding(0, 0, 30, 0);
            this.cbxSerialPortNum.Radius = 13;
            this.cbxSerialPortNum.RectColor = System.Drawing.Color.White;
            this.cbxSerialPortNum.RectDisableColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.cbxSerialPortNum.RectSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.None;
            this.cbxSerialPortNum.Size = new System.Drawing.Size(168, 26);
            this.cbxSerialPortNum.Style = Rex.UI.UIStyle.Custom;
            this.cbxSerialPortNum.StyleCustomMode = true;
            this.cbxSerialPortNum.SymbolDropDown = 61656;
            this.cbxSerialPortNum.SymbolNormal = 61655;
            this.cbxSerialPortNum.TabIndex = 281;
            this.cbxSerialPortNum.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // cbxBaudRate
            // 
            this.cbxBaudRate.BackColor = System.Drawing.Color.AliceBlue;
            this.cbxBaudRate.DropDownStyle = Rex.UI.UIDropDownStyle.DropDownList;
            this.cbxBaudRate.FillColor = System.Drawing.Color.Navy;
            this.cbxBaudRate.Font = new System.Drawing.Font("华文新魏", 13.5F);
            this.cbxBaudRate.ForeColor = System.Drawing.Color.White;
            this.cbxBaudRate.ForeDisableColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.cbxBaudRate.Items.AddRange(new object[] {
            "2400",
            "4800",
            "9600",
            "19200",
            "38400",
            "57600",
            "115200"});
            this.cbxBaudRate.Location = new System.Drawing.Point(163, 129);
            this.cbxBaudRate.Margin = new System.Windows.Forms.Padding(0);
            this.cbxBaudRate.MinimumSize = new System.Drawing.Size(63, 0);
            this.cbxBaudRate.Name = "cbxBaudRate";
            this.cbxBaudRate.Padding = new System.Windows.Forms.Padding(0, 0, 30, 0);
            this.cbxBaudRate.Radius = 13;
            this.cbxBaudRate.RectColor = System.Drawing.Color.White;
            this.cbxBaudRate.RectDisableColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.cbxBaudRate.RectSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.None;
            this.cbxBaudRate.Size = new System.Drawing.Size(168, 26);
            this.cbxBaudRate.Style = Rex.UI.UIStyle.Custom;
            this.cbxBaudRate.StyleCustomMode = true;
            this.cbxBaudRate.SymbolDropDown = 61656;
            this.cbxBaudRate.SymbolNormal = 61655;
            this.cbxBaudRate.TabIndex = 282;
            this.cbxBaudRate.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // cbxCheckBits
            // 
            this.cbxCheckBits.BackColor = System.Drawing.Color.AliceBlue;
            this.cbxCheckBits.DropDownStyle = Rex.UI.UIDropDownStyle.DropDownList;
            this.cbxCheckBits.FillColor = System.Drawing.Color.Navy;
            this.cbxCheckBits.Font = new System.Drawing.Font("华文新魏", 13.5F);
            this.cbxCheckBits.ForeColor = System.Drawing.Color.White;
            this.cbxCheckBits.ForeDisableColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.cbxCheckBits.Items.AddRange(new object[] {
            "None",
            "Odd",
            "Even",
            "Mark",
            "Space"});
            this.cbxCheckBits.Location = new System.Drawing.Point(163, 177);
            this.cbxCheckBits.Margin = new System.Windows.Forms.Padding(0);
            this.cbxCheckBits.MinimumSize = new System.Drawing.Size(63, 0);
            this.cbxCheckBits.Name = "cbxCheckBits";
            this.cbxCheckBits.Padding = new System.Windows.Forms.Padding(0, 0, 30, 0);
            this.cbxCheckBits.Radius = 13;
            this.cbxCheckBits.RectColor = System.Drawing.Color.White;
            this.cbxCheckBits.RectDisableColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.cbxCheckBits.RectSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.None;
            this.cbxCheckBits.Size = new System.Drawing.Size(168, 26);
            this.cbxCheckBits.Style = Rex.UI.UIStyle.Custom;
            this.cbxCheckBits.StyleCustomMode = true;
            this.cbxCheckBits.SymbolDropDown = 61656;
            this.cbxCheckBits.SymbolNormal = 61655;
            this.cbxCheckBits.TabIndex = 283;
            this.cbxCheckBits.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // cbxDataBits
            // 
            this.cbxDataBits.BackColor = System.Drawing.Color.AliceBlue;
            this.cbxDataBits.DropDownStyle = Rex.UI.UIDropDownStyle.DropDownList;
            this.cbxDataBits.FillColor = System.Drawing.Color.Navy;
            this.cbxDataBits.Font = new System.Drawing.Font("华文新魏", 13.5F);
            this.cbxDataBits.ForeColor = System.Drawing.Color.White;
            this.cbxDataBits.ForeDisableColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.cbxDataBits.Items.AddRange(new object[] {
            "5",
            "6",
            "7",
            "8"});
            this.cbxDataBits.Location = new System.Drawing.Point(163, 225);
            this.cbxDataBits.Margin = new System.Windows.Forms.Padding(0);
            this.cbxDataBits.MinimumSize = new System.Drawing.Size(63, 0);
            this.cbxDataBits.Name = "cbxDataBits";
            this.cbxDataBits.Padding = new System.Windows.Forms.Padding(0, 0, 30, 0);
            this.cbxDataBits.Radius = 13;
            this.cbxDataBits.RectColor = System.Drawing.Color.White;
            this.cbxDataBits.RectDisableColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.cbxDataBits.RectSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.None;
            this.cbxDataBits.Size = new System.Drawing.Size(168, 26);
            this.cbxDataBits.Style = Rex.UI.UIStyle.Custom;
            this.cbxDataBits.StyleCustomMode = true;
            this.cbxDataBits.SymbolDropDown = 61656;
            this.cbxDataBits.SymbolNormal = 61655;
            this.cbxDataBits.TabIndex = 284;
            this.cbxDataBits.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // cbxStopBits
            // 
            this.cbxStopBits.BackColor = System.Drawing.Color.AliceBlue;
            this.cbxStopBits.DropDownStyle = Rex.UI.UIDropDownStyle.DropDownList;
            this.cbxStopBits.FillColor = System.Drawing.Color.Navy;
            this.cbxStopBits.Font = new System.Drawing.Font("华文新魏", 13.5F);
            this.cbxStopBits.ForeColor = System.Drawing.Color.White;
            this.cbxStopBits.ForeDisableColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.cbxStopBits.Items.AddRange(new object[] {
            "None",
            "One",
            "Two",
            "OnePointFive"});
            this.cbxStopBits.Location = new System.Drawing.Point(163, 273);
            this.cbxStopBits.Margin = new System.Windows.Forms.Padding(0);
            this.cbxStopBits.MinimumSize = new System.Drawing.Size(63, 0);
            this.cbxStopBits.Name = "cbxStopBits";
            this.cbxStopBits.Padding = new System.Windows.Forms.Padding(0, 0, 30, 0);
            this.cbxStopBits.Radius = 13;
            this.cbxStopBits.RectColor = System.Drawing.Color.White;
            this.cbxStopBits.RectDisableColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.cbxStopBits.RectSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.None;
            this.cbxStopBits.Size = new System.Drawing.Size(168, 26);
            this.cbxStopBits.Style = Rex.UI.UIStyle.Custom;
            this.cbxStopBits.StyleCustomMode = true;
            this.cbxStopBits.SymbolDropDown = 61656;
            this.cbxStopBits.SymbolNormal = 61655;
            this.cbxStopBits.TabIndex = 285;
            this.cbxStopBits.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // FrmSerialPortMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.GhostWhite;
            this.ClientSize = new System.Drawing.Size(429, 373);
            this.Controls.Add(this.cbxStopBits);
            this.Controls.Add(this.cbxDataBits);
            this.Controls.Add(this.cbxCheckBits);
            this.Controls.Add(this.cbxBaudRate);
            this.Controls.Add(this.cbxSerialPortNum);
            this.Controls.Add(this.pbxJudge5);
            this.Controls.Add(this.pbxJudge4);
            this.Controls.Add(this.pbxJudge3);
            this.Controls.Add(this.pbxJudge2);
            this.Controls.Add(this.pbxJudge1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label3);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmSerialPortMenu";
            this.Text = "FrmSerialPortMenu";
            this.TopMost = true;
            this.panel1.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbxJudge1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxJudge2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxJudge3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxJudge4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxJudge5)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Panel panel1;
        public System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        public System.Windows.Forms.Button btnClose;
        public System.Windows.Forms.Label label1;
        public System.Windows.Forms.Label label3;
        public System.Windows.Forms.Label label2;
        public System.Windows.Forms.Label label4;
        public System.Windows.Forms.Label label5;
        public System.Windows.Forms.PictureBox pbxJudge1;
        public System.Windows.Forms.PictureBox pbxJudge2;
        public System.Windows.Forms.PictureBox pbxJudge3;
        public System.Windows.Forms.PictureBox pbxJudge4;
        public System.Windows.Forms.PictureBox pbxJudge5;
        public System.Windows.Forms.Timer timer1;
        public Rex.UI.MyComboBox cbxSerialPortNum;
        public Rex.UI.MyComboBox cbxBaudRate;
        public Rex.UI.MyComboBox cbxCheckBits;
        public Rex.UI.MyComboBox cbxDataBits;
        public Rex.UI.MyComboBox cbxStopBits;
    }
}