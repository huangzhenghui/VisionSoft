
namespace TSIVision.FrmConfigR
{
    partial class FrmMbsDebug
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMbsDebug));
            this.panel1 = new System.Windows.Forms.Panel();
            this.uiLabel1 = new Rex.UI.UILabel();
            this.tbxSend = new Rex.UI.UITextBox();
            this.btnClear = new Rex.UI.UIButton();
            this.btnSend = new Rex.UI.UIButton();
            this.uiLabel2 = new Rex.UI.UILabel();
            this.tbxReceive = new Rex.UI.UITextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.btnClose = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.LavenderBlush;
            this.panel1.Controls.Add(this.uiLabel1);
            this.panel1.Controls.Add(this.tbxSend);
            this.panel1.Controls.Add(this.btnClear);
            this.panel1.Controls.Add(this.btnSend);
            this.panel1.Controls.Add(this.uiLabel2);
            this.panel1.Controls.Add(this.tbxReceive);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(669, 577);
            this.panel1.TabIndex = 3;
            // 
            // uiLabel1
            // 
            this.uiLabel1.Font = new System.Drawing.Font("华文新魏", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uiLabel1.Location = new System.Drawing.Point(64, 338);
            this.uiLabel1.Name = "uiLabel1";
            this.uiLabel1.Size = new System.Drawing.Size(126, 26);
            this.uiLabel1.Style = Rex.UI.UIStyle.Custom;
            this.uiLabel1.TabIndex = 33;
            this.uiLabel1.Text = "发送区：";
            this.uiLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // tbxSend
            // 
            this.tbxSend.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbxSend.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbxSend.FillColor = System.Drawing.Color.MintCream;
            this.tbxSend.Font = new System.Drawing.Font("华文新魏", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tbxSend.Location = new System.Drawing.Point(67, 374);
            this.tbxSend.Margin = new System.Windows.Forms.Padding(0);
            this.tbxSend.Maximum = 2147483647D;
            this.tbxSend.Minimum = -2147483648D;
            this.tbxSend.MinimumSize = new System.Drawing.Size(1, 1);
            this.tbxSend.Multiline = true;
            this.tbxSend.Name = "tbxSend";
            this.tbxSend.RadiusSides = Rex.UI.UICornerRadiusSides.None;
            this.tbxSend.RectColor = System.Drawing.Color.MintCream;
            this.tbxSend.Size = new System.Drawing.Size(554, 120);
            this.tbxSend.Style = Rex.UI.UIStyle.Custom;
            this.tbxSend.TabIndex = 32;
            // 
            // btnClear
            // 
            this.btnClear.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClear.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(131)))), ((int)(((byte)(229)))));
            this.btnClear.FillHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(55)))), ((int)(((byte)(130)))));
            this.btnClear.FillPressColor = System.Drawing.Color.CadetBlue;
            this.btnClear.Font = new System.Drawing.Font("华文新魏", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnClear.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            this.btnClear.ForeHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            this.btnClear.ForePressColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            this.btnClear.ForeSelectedColor = System.Drawing.Color.Black;
            this.btnClear.Location = new System.Drawing.Point(527, 518);
            this.btnClear.MinimumSize = new System.Drawing.Size(1, 1);
            this.btnClear.Name = "btnClear";
            this.btnClear.Radius = 15;
            this.btnClear.RectColor = System.Drawing.Color.Transparent;
            this.btnClear.RectHoverColor = System.Drawing.Color.Lavender;
            this.btnClear.RectPressColor = System.Drawing.Color.Honeydew;
            this.btnClear.RectSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.None;
            this.btnClear.Size = new System.Drawing.Size(94, 32);
            this.btnClear.Style = Rex.UI.UIStyle.Custom;
            this.btnClear.TabIndex = 31;
            this.btnClear.Text = "清空";
            this.btnClear.Click += new System.EventHandler(this.cliAreaBtn_Click);
            // 
            // btnSend
            // 
            this.btnSend.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSend.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(131)))), ((int)(((byte)(229)))));
            this.btnSend.FillHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(55)))), ((int)(((byte)(130)))));
            this.btnSend.FillPressColor = System.Drawing.Color.CadetBlue;
            this.btnSend.Font = new System.Drawing.Font("华文新魏", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnSend.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            this.btnSend.ForeHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            this.btnSend.ForePressColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            this.btnSend.ForeSelectedColor = System.Drawing.Color.Black;
            this.btnSend.Location = new System.Drawing.Point(408, 518);
            this.btnSend.MinimumSize = new System.Drawing.Size(1, 1);
            this.btnSend.Name = "btnSend";
            this.btnSend.Radius = 15;
            this.btnSend.RectColor = System.Drawing.Color.Transparent;
            this.btnSend.RectHoverColor = System.Drawing.Color.Lavender;
            this.btnSend.RectPressColor = System.Drawing.Color.Honeydew;
            this.btnSend.RectSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.None;
            this.btnSend.Size = new System.Drawing.Size(94, 32);
            this.btnSend.Style = Rex.UI.UIStyle.Custom;
            this.btnSend.TabIndex = 30;
            this.btnSend.Text = "发送";
            this.btnSend.Click += new System.EventHandler(this.cliAreaBtn_Click);
            // 
            // uiLabel2
            // 
            this.uiLabel2.Font = new System.Drawing.Font("华文新魏", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uiLabel2.Location = new System.Drawing.Point(64, 40);
            this.uiLabel2.Name = "uiLabel2";
            this.uiLabel2.Size = new System.Drawing.Size(126, 26);
            this.uiLabel2.TabIndex = 29;
            this.uiLabel2.Text = "接收区：";
            this.uiLabel2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // tbxReceive
            // 
            this.tbxReceive.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbxReceive.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbxReceive.FillColor = System.Drawing.Color.MintCream;
            this.tbxReceive.Font = new System.Drawing.Font("华文新魏", 10F);
            this.tbxReceive.Location = new System.Drawing.Point(67, 76);
            this.tbxReceive.Margin = new System.Windows.Forms.Padding(0);
            this.tbxReceive.Maximum = 2147483647D;
            this.tbxReceive.Minimum = -2147483648D;
            this.tbxReceive.MinimumSize = new System.Drawing.Size(1, 1);
            this.tbxReceive.Multiline = true;
            this.tbxReceive.Name = "tbxReceive";
            this.tbxReceive.RadiusSides = Rex.UI.UICornerRadiusSides.None;
            this.tbxReceive.RectColor = System.Drawing.Color.MintCream;
            this.tbxReceive.Size = new System.Drawing.Size(554, 249);
            this.tbxReceive.Style = Rex.UI.UIStyle.Custom;
            this.tbxReceive.TabIndex = 27;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.tableLayoutPanel1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Padding = new System.Windows.Forms.Padding(0, 0, 2, 0);
            this.panel2.Size = new System.Drawing.Size(669, 26);
            this.panel2.TabIndex = 25;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 95.94189F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 4.0581F));
            this.tableLayoutPanel1.Controls.Add(this.btnClose, 1, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(667, 26);
            this.tableLayoutPanel1.TabIndex = 0;
            this.tableLayoutPanel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Frm_MouseDown);
            this.tableLayoutPanel1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Frm_MouseMove);
            this.tableLayoutPanel1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Frm_MouseUp);
            // 
            // btnClose
            // 
            this.btnClose.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnClose.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnClose.FlatAppearance.BorderColor = System.Drawing.Color.LavenderBlush;
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.FlatAppearance.MouseDownBackColor = System.Drawing.Color.GhostWhite;
            this.btnClose.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LavenderBlush;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Image = ((System.Drawing.Image)(resources.GetObject("btnClose.Image")));
            this.btnClose.Location = new System.Drawing.Point(646, 5);
            this.btnClose.Margin = new System.Windows.Forms.Padding(7, 5, 5, 5);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(16, 16);
            this.btnClose.TabIndex = 1;
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.toolbarBtn_Click);
            // 
            // FrmMbsDebug
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LavenderBlush;
            this.ClientSize = new System.Drawing.Size(669, 577);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmMbsDebug";
            this.Text = "FrmMbsDebug";
            this.TopMost = true;
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private Rex.UI.UILabel uiLabel1;
        private Rex.UI.UITextBox tbxSend;
        private Rex.UI.UIButton btnClear;
        private Rex.UI.UIButton btnSend;
        private Rex.UI.UILabel uiLabel2;
        private Rex.UI.UITextBox tbxReceive;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button btnClose;
    }
}