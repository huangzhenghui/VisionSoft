
namespace TSIVision.FrmConfigR
{
    partial class FrmServerMenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmServerMenu));
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.btnClose = new System.Windows.Forms.Button();
            this.pbxJudge2 = new System.Windows.Forms.PictureBox();
            this.pbxJudge1 = new System.Windows.Forms.PictureBox();
            this.tbxLocalPort = new Rex.UI.UITextBox();
            this.tbxLocalIP = new Sunny.UI.UIIPTextBox();
            this.panel1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbxJudge2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxJudge1)).BeginInit();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("华文新魏", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label3.ImageAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.label3.Location = new System.Drawing.Point(80, 69);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(107, 19);
            this.label3.TabIndex = 41;
            this.label3.Text = "本地IP地址:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("华文新魏", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.ImageAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.label1.Location = new System.Drawing.Point(80, 119);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(110, 19);
            this.label1.TabIndex = 57;
            this.label1.Text = "本地端口号:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.tableLayoutPanel1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(453, 23);
            this.panel1.TabIndex = 60;
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
            this.tableLayoutPanel1.Location = new System.Drawing.Point(424, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(29, 23);
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
            this.btnClose.Size = new System.Drawing.Size(23, 17);
            this.btnClose.TabIndex = 0;
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnToolBar_Click);
            // 
            // pbxJudge2
            // 
            this.pbxJudge2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pbxJudge2.Location = new System.Drawing.Point(375, 118);
            this.pbxJudge2.Name = "pbxJudge2";
            this.pbxJudge2.Size = new System.Drawing.Size(22, 22);
            this.pbxJudge2.TabIndex = 62;
            this.pbxJudge2.TabStop = false;
            // 
            // pbxJudge1
            // 
            this.pbxJudge1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pbxJudge1.Location = new System.Drawing.Point(375, 68);
            this.pbxJudge1.Name = "pbxJudge1";
            this.pbxJudge1.Size = new System.Drawing.Size(22, 22);
            this.pbxJudge1.TabIndex = 61;
            this.pbxJudge1.TabStop = false;
            // 
            // tbxLocalPort
            // 
            this.tbxLocalPort.BackColor = System.Drawing.Color.White;
            this.tbxLocalPort.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbxLocalPort.FillColor = System.Drawing.Color.Navy;
            this.tbxLocalPort.FillDisableColor = System.Drawing.Color.Navy;
            this.tbxLocalPort.Font = new System.Drawing.Font("华文新魏", 12.5F);
            this.tbxLocalPort.ForeColor = System.Drawing.Color.White;
            this.tbxLocalPort.Location = new System.Drawing.Point(194, 116);
            this.tbxLocalPort.Margin = new System.Windows.Forms.Padding(4, 7, 2, 3);
            this.tbxLocalPort.Maximum = 2147483647D;
            this.tbxLocalPort.Minimum = -2147483648D;
            this.tbxLocalPort.MinimumSize = new System.Drawing.Size(1, 1);
            this.tbxLocalPort.Name = "tbxLocalPort";
            this.tbxLocalPort.Radius = 13;
            this.tbxLocalPort.RectColor = System.Drawing.Color.Navy;
            this.tbxLocalPort.Size = new System.Drawing.Size(168, 25);
            this.tbxLocalPort.Style = Rex.UI.UIStyle.Custom;
            this.tbxLocalPort.TabIndex = 58;
            this.tbxLocalPort.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbxInputNum_KeyPress);
            // 
            // tbxLocalIP
            // 
            this.tbxLocalIP.BackColor = System.Drawing.Color.White;
            this.tbxLocalIP.FillColor = System.Drawing.Color.Navy;
            this.tbxLocalIP.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            this.tbxLocalIP.Font = new System.Drawing.Font("华文新魏", 12.5F);
            this.tbxLocalIP.ForeColor = System.Drawing.Color.White;
            this.tbxLocalIP.Location = new System.Drawing.Point(194, 66);
            this.tbxLocalIP.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tbxLocalIP.MinimumSize = new System.Drawing.Size(1, 1);
            this.tbxLocalIP.Name = "tbxLocalIP";
            this.tbxLocalIP.Padding = new System.Windows.Forms.Padding(1);
            this.tbxLocalIP.Radius = 13;
            this.tbxLocalIP.RectColor = System.Drawing.Color.Navy;
            this.tbxLocalIP.ShowText = false;
            this.tbxLocalIP.Size = new System.Drawing.Size(168, 25);
            this.tbxLocalIP.Style = Sunny.UI.UIStyle.Custom;
            this.tbxLocalIP.TabIndex = 0;
            this.tbxLocalIP.Text = "0.0.0.0";
            this.tbxLocalIP.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            this.tbxLocalIP.Value = ((System.Net.IPAddress)(resources.GetObject("tbxLocalIP.Value")));
            this.tbxLocalIP.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            // 
            // FrmServerMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.GhostWhite;
            this.ClientSize = new System.Drawing.Size(453, 200);
            this.Controls.Add(this.tbxLocalIP);
            this.Controls.Add(this.pbxJudge2);
            this.Controls.Add(this.pbxJudge1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.tbxLocalPort);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label3);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmServerMenu";
            this.Text = "FrmServerMenu";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.FrmServerMenu_Load);
            this.panel1.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbxJudge2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxJudge1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Label label3;
        public System.Windows.Forms.Label label1;
        public System.Windows.Forms.Panel panel1;
        public System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        public System.Windows.Forms.Button btnClose;
        public System.Windows.Forms.PictureBox pbxJudge2;
        public System.Windows.Forms.PictureBox pbxJudge1;
        public Rex.UI.UITextBox tbxLocalPort;
        public Sunny.UI.UIIPTextBox tbxLocalIP;
    }
}