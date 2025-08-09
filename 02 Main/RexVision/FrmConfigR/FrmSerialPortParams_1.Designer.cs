
namespace TSIVision.FrmConfigR
{
    partial class FrmSerialPortParams_1
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.uiLabel1 = new Rex.UI.UILabel();
            this.uiLabel2 = new Rex.UI.UILabel();
            this.uiLabel3 = new Rex.UI.UILabel();
            this.tbxName = new Rex.UI.UITextBox();
            this.pbxJudge1 = new System.Windows.Forms.PictureBox();
            this.pbxJudge2 = new System.Windows.Forms.PictureBox();
            this.pbxJudge3 = new System.Windows.Forms.PictureBox();
            this.cbxSerialPortNum = new Rex.UI.MyComboBox();
            this.cbxBaudRate = new Rex.UI.MyComboBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbxJudge1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxJudge2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxJudge3)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 4;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 8.484366F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 26.64808F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 54.70026F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10.1673F));
            this.tableLayoutPanel1.Controls.Add(this.uiLabel1, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.uiLabel2, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.uiLabel3, 1, 5);
            this.tableLayoutPanel1.Controls.Add(this.tbxName, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.pbxJudge1, 3, 1);
            this.tableLayoutPanel1.Controls.Add(this.pbxJudge2, 3, 3);
            this.tableLayoutPanel1.Controls.Add(this.pbxJudge3, 3, 5);
            this.tableLayoutPanel1.Controls.Add(this.cbxSerialPortNum, 2, 3);
            this.tableLayoutPanel1.Controls.Add(this.cbxBaudRate, 2, 5);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 8;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10.0042F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.99821F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.49848F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.99821F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.49848F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.99821F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5.002102F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5.002102F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(296, 162);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // uiLabel1
            // 
            this.uiLabel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.uiLabel1.Font = new System.Drawing.Font("华文新魏", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uiLabel1.Location = new System.Drawing.Point(28, 16);
            this.uiLabel1.Name = "uiLabel1";
            this.uiLabel1.Size = new System.Drawing.Size(72, 27);
            this.uiLabel1.Style = Rex.UI.UIStyle.Custom;
            this.uiLabel1.TabIndex = 32;
            this.uiLabel1.Text = "名称:";
            this.uiLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // uiLabel2
            // 
            this.uiLabel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.uiLabel2.Font = new System.Drawing.Font("华文新魏", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uiLabel2.Location = new System.Drawing.Point(28, 66);
            this.uiLabel2.Name = "uiLabel2";
            this.uiLabel2.Size = new System.Drawing.Size(72, 27);
            this.uiLabel2.Style = Rex.UI.UIStyle.Custom;
            this.uiLabel2.TabIndex = 34;
            this.uiLabel2.Text = "串口号:";
            this.uiLabel2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // uiLabel3
            // 
            this.uiLabel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.uiLabel3.Font = new System.Drawing.Font("华文新魏", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uiLabel3.Location = new System.Drawing.Point(28, 116);
            this.uiLabel3.Name = "uiLabel3";
            this.uiLabel3.Size = new System.Drawing.Size(72, 27);
            this.uiLabel3.Style = Rex.UI.UIStyle.Custom;
            this.uiLabel3.TabIndex = 36;
            this.uiLabel3.Text = "波特率:";
            this.uiLabel3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // tbxName
            // 
            this.tbxName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbxName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbxName.FillColor = System.Drawing.Color.AliceBlue;
            this.tbxName.Font = new System.Drawing.Font("华文新魏", 11.5F);
            this.tbxName.ForeColor = System.Drawing.Color.Black;
            this.tbxName.Location = new System.Drawing.Point(103, 16);
            this.tbxName.Margin = new System.Windows.Forms.Padding(0);
            this.tbxName.Maximum = 2147483647D;
            this.tbxName.Minimum = -2147483648D;
            this.tbxName.MinimumSize = new System.Drawing.Size(1, 1);
            this.tbxName.Name = "tbxName";
            this.tbxName.Radius = 13;
            this.tbxName.RectColor = System.Drawing.Color.LavenderBlush;
            this.tbxName.RectSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.None;
            this.tbxName.Size = new System.Drawing.Size(161, 23);
            this.tbxName.Style = Rex.UI.UIStyle.Custom;
            this.tbxName.TabIndex = 74;
            // 
            // pbxJudge1
            // 
            this.pbxJudge1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pbxJudge1.Dock = System.Windows.Forms.DockStyle.Left;
            this.pbxJudge1.Location = new System.Drawing.Point(266, 18);
            this.pbxJudge1.Margin = new System.Windows.Forms.Padding(2, 2, 7, 2);
            this.pbxJudge1.Name = "pbxJudge1";
            this.pbxJudge1.Size = new System.Drawing.Size(20, 23);
            this.pbxJudge1.TabIndex = 75;
            this.pbxJudge1.TabStop = false;
            // 
            // pbxJudge2
            // 
            this.pbxJudge2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pbxJudge2.Dock = System.Windows.Forms.DockStyle.Left;
            this.pbxJudge2.Location = new System.Drawing.Point(266, 68);
            this.pbxJudge2.Margin = new System.Windows.Forms.Padding(2, 2, 7, 2);
            this.pbxJudge2.Name = "pbxJudge2";
            this.pbxJudge2.Size = new System.Drawing.Size(20, 23);
            this.pbxJudge2.TabIndex = 76;
            this.pbxJudge2.TabStop = false;
            // 
            // pbxJudge3
            // 
            this.pbxJudge3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pbxJudge3.Dock = System.Windows.Forms.DockStyle.Left;
            this.pbxJudge3.Location = new System.Drawing.Point(266, 118);
            this.pbxJudge3.Margin = new System.Windows.Forms.Padding(2, 2, 7, 2);
            this.pbxJudge3.Name = "pbxJudge3";
            this.pbxJudge3.Size = new System.Drawing.Size(20, 23);
            this.pbxJudge3.TabIndex = 77;
            this.pbxJudge3.TabStop = false;
            // 
            // cbxSerialPortNum
            // 
            this.cbxSerialPortNum.BackColor = System.Drawing.Color.AliceBlue;
            this.cbxSerialPortNum.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cbxSerialPortNum.DropDownStyle = Rex.UI.UIDropDownStyle.DropDownList;
            this.cbxSerialPortNum.FillColor = System.Drawing.Color.AliceBlue;
            this.cbxSerialPortNum.Font = new System.Drawing.Font("华文新魏", 11.5F);
            this.cbxSerialPortNum.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(49)))), ((int)(((byte)(49)))));
            this.cbxSerialPortNum.ForeDisableColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.cbxSerialPortNum.Location = new System.Drawing.Point(103, 66);
            this.cbxSerialPortNum.Margin = new System.Windows.Forms.Padding(0);
            this.cbxSerialPortNum.MinimumSize = new System.Drawing.Size(63, 0);
            this.cbxSerialPortNum.Name = "cbxSerialPortNum";
            this.cbxSerialPortNum.Padding = new System.Windows.Forms.Padding(0, 0, 30, 0);
            this.cbxSerialPortNum.Radius = 2;
            this.cbxSerialPortNum.RectColor = System.Drawing.Color.CornflowerBlue;
            this.cbxSerialPortNum.RectDisableColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.cbxSerialPortNum.RectSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.None;
            this.cbxSerialPortNum.Size = new System.Drawing.Size(161, 23);
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
            this.cbxBaudRate.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cbxBaudRate.DropDownStyle = Rex.UI.UIDropDownStyle.DropDownList;
            this.cbxBaudRate.FillColor = System.Drawing.Color.AliceBlue;
            this.cbxBaudRate.Font = new System.Drawing.Font("华文新魏", 11.5F);
            this.cbxBaudRate.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(49)))), ((int)(((byte)(49)))));
            this.cbxBaudRate.ForeDisableColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.cbxBaudRate.Items.AddRange(new object[] {
            "2400",
            "4800",
            "9600",
            "19200",
            "38400",
            "57600",
            "115200"});
            this.cbxBaudRate.Location = new System.Drawing.Point(103, 116);
            this.cbxBaudRate.Margin = new System.Windows.Forms.Padding(0);
            this.cbxBaudRate.MinimumSize = new System.Drawing.Size(63, 0);
            this.cbxBaudRate.Name = "cbxBaudRate";
            this.cbxBaudRate.Padding = new System.Windows.Forms.Padding(0, 0, 30, 0);
            this.cbxBaudRate.Radius = 2;
            this.cbxBaudRate.RectColor = System.Drawing.Color.CornflowerBlue;
            this.cbxBaudRate.RectDisableColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.cbxBaudRate.RectSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.None;
            this.cbxBaudRate.Size = new System.Drawing.Size(161, 23);
            this.cbxBaudRate.Style = Rex.UI.UIStyle.Custom;
            this.cbxBaudRate.StyleCustomMode = true;
            this.cbxBaudRate.SymbolDropDown = 61656;
            this.cbxBaudRate.SymbolNormal = 61655;
            this.cbxBaudRate.TabIndex = 282;
            this.cbxBaudRate.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // FrmSerialPortParams_1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LavenderBlush;
            this.ClientSize = new System.Drawing.Size(296, 162);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "FrmSerialPortParams_1";
            this.Text = "FrmSerialPortParams_1";
            this.tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbxJudge1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxJudge2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxJudge3)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        public Rex.UI.UILabel uiLabel1;
        public Rex.UI.UILabel uiLabel2;
        public Rex.UI.UILabel uiLabel3;
        public Rex.UI.UITextBox tbxName;
        public System.Windows.Forms.PictureBox pbxJudge1;
        public System.Windows.Forms.PictureBox pbxJudge2;
        public System.Windows.Forms.PictureBox pbxJudge3;
        public Rex.UI.MyComboBox cbxSerialPortNum;
        public Rex.UI.MyComboBox cbxBaudRate;
        public System.Windows.Forms.Timer timer1;
    }
}