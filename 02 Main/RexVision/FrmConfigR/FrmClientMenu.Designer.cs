
namespace TSIVision.FrmConfigR
{
    partial class FrmClientMenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmClientMenu));
            this.panel1 = new System.Windows.Forms.Panel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tbxAimPort = new Rex.UI.UITextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tbxAimIP = new Sunny.UI.UIIPTextBox();
            this.pbxJudge2 = new System.Windows.Forms.PictureBox();
            this.pbxJudge1 = new System.Windows.Forms.PictureBox();
            this.btnClose = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbxJudge2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxJudge1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.tableLayoutPanel1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(453, 23);
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
            this.tableLayoutPanel1.Controls.Add(this.btnClose, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(424, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(29, 23);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // tbxAimPort
            // 
            this.tbxAimPort.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbxAimPort.FillColor = System.Drawing.Color.Navy;
            this.tbxAimPort.Font = new System.Drawing.Font("华文新魏", 12.5F);
            this.tbxAimPort.ForeColor = System.Drawing.Color.White;
            this.tbxAimPort.Location = new System.Drawing.Point(194, 116);
            this.tbxAimPort.Margin = new System.Windows.Forms.Padding(4, 7, 2, 3);
            this.tbxAimPort.Maximum = 2147483647D;
            this.tbxAimPort.Minimum = -2147483648D;
            this.tbxAimPort.MinimumSize = new System.Drawing.Size(1, 1);
            this.tbxAimPort.Name = "tbxAimPort";
            this.tbxAimPort.Radius = 13;
            this.tbxAimPort.RectColor = System.Drawing.Color.Navy;
            this.tbxAimPort.Size = new System.Drawing.Size(168, 25);
            this.tbxAimPort.Style = Rex.UI.UIStyle.Custom;
            this.tbxAimPort.TabIndex = 64;
            this.tbxAimPort.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbxInputNum_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("华文新魏", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.ImageAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.label1.Location = new System.Drawing.Point(80, 119);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(110, 19);
            this.label1.TabIndex = 63;
            this.label1.Text = "目标端口号:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("华文新魏", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label3.ImageAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.label3.Location = new System.Drawing.Point(80, 69);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(107, 19);
            this.label3.TabIndex = 61;
            this.label3.Text = "目标IP地址:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // tbxAimIP
            // 
            this.tbxAimIP.BackColor = System.Drawing.Color.White;
            this.tbxAimIP.FillColor = System.Drawing.Color.Navy;
            this.tbxAimIP.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            this.tbxAimIP.Font = new System.Drawing.Font("华文新魏", 12.5F);
            this.tbxAimIP.ForeColor = System.Drawing.Color.White;
            this.tbxAimIP.Location = new System.Drawing.Point(194, 66);
            this.tbxAimIP.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tbxAimIP.MinimumSize = new System.Drawing.Size(1, 1);
            this.tbxAimIP.Name = "tbxAimIP";
            this.tbxAimIP.Padding = new System.Windows.Forms.Padding(1);
            this.tbxAimIP.Radius = 13;
            this.tbxAimIP.RectColor = System.Drawing.Color.Navy;
            this.tbxAimIP.ShowText = false;
            this.tbxAimIP.Size = new System.Drawing.Size(168, 25);
            this.tbxAimIP.Style = Sunny.UI.UIStyle.Custom;
            this.tbxAimIP.TabIndex = 0;
            this.tbxAimIP.Text = "0.0.0.0";
            this.tbxAimIP.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            this.tbxAimIP.Value = ((System.Net.IPAddress)(resources.GetObject("tbxAimIP.Value")));
            this.tbxAimIP.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            // 
            // pbxJudge2
            // 
            this.pbxJudge2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pbxJudge2.Location = new System.Drawing.Point(375, 118);
            this.pbxJudge2.Name = "pbxJudge2";
            this.pbxJudge2.Size = new System.Drawing.Size(22, 22);
            this.pbxJudge2.TabIndex = 67;
            this.pbxJudge2.TabStop = false;
            // 
            // pbxJudge1
            // 
            this.pbxJudge1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pbxJudge1.Location = new System.Drawing.Point(375, 68);
            this.pbxJudge1.Name = "pbxJudge1";
            this.pbxJudge1.Size = new System.Drawing.Size(22, 22);
            this.pbxJudge1.TabIndex = 66;
            this.pbxJudge1.TabStop = false;
            // 
            // btnClose
            // 
            this.btnClose.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnClose.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.btnClose.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Image = ((System.Drawing.Image)(resources.GetObject("btnClose.Image")));
            this.btnClose.Location = new System.Drawing.Point(4, 3);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(22, 17);
            this.btnClose.TabIndex = 0;
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnToolBar_Click);
            // 
            // FrmClientMenu
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.GhostWhite;
            this.ClientSize = new System.Drawing.Size(453, 200);
            this.Controls.Add(this.tbxAimIP);
            this.Controls.Add(this.pbxJudge2);
            this.Controls.Add(this.pbxJudge1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.tbxAimPort);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label3);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmClientMenu";
            this.Text = "FrmClientMenu";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.FrmClientMenu_Load);
            this.panel1.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbxJudge2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxJudge1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Panel panel1;
        public System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        public System.Windows.Forms.Button btnClose;
        public Rex.UI.UITextBox tbxAimPort;
        public System.Windows.Forms.Label label1;
        public System.Windows.Forms.Label label3;
        public System.Windows.Forms.PictureBox pbxJudge2;
        public System.Windows.Forms.PictureBox pbxJudge1;
        public Sunny.UI.UIIPTextBox tbxAimIP;
    }
}