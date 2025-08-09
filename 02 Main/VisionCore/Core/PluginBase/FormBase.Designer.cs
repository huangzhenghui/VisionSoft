namespace VisionCore
{
    partial class FormBase
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormBase));
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.lblModName = new System.Windows.Forms.Label();
            this.panel6 = new System.Windows.Forms.Panel();
            this.panel8 = new System.Windows.Forms.Panel();
            this.btnSave = new System.Windows.Forms.Button();
            this.panel7 = new System.Windows.Forms.Panel();
            this.btnClose = new System.Windows.Forms.Button();
            this.panel_bottom = new System.Windows.Forms.Panel();
            this.lblTime = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.btn_Run = new Rex.UI.UIButton();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel_center = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.pbox_Icon)).BeginInit();
            this.titlepanel.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel6.SuspendLayout();
            this.panel8.SuspendLayout();
            this.panel7.SuspendLayout();
            this.panel_bottom.SuspendLayout();
            this.SuspendLayout();
            // 
            // pbox_Icon
            // 
            this.pbox_Icon.Location = new System.Drawing.Point(1, 1);
            this.pbox_Icon.Margin = new System.Windows.Forms.Padding(0);
            this.pbox_Icon.Size = new System.Drawing.Size(30, 20);
            this.pbox_Icon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            // 
            // titlepanel
            // 
            this.titlepanel.BackColor = System.Drawing.Color.Transparent;
            this.titlepanel.Dock = System.Windows.Forms.DockStyle.None;
            this.titlepanel.Location = new System.Drawing.Point(1, 1);
            this.titlepanel.Margin = new System.Windows.Forms.Padding(1);
            this.titlepanel.Padding = new System.Windows.Forms.Padding(1);
            this.titlepanel.Size = new System.Drawing.Size(846, 22);
            // 
            // titlelabel
            // 
            this.titlelabel.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.titlelabel.Location = new System.Drawing.Point(36, 7);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.BackColor = System.Drawing.Color.AliceBlue;
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 80.02364F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 19.97636F));
            this.tableLayoutPanel1.Controls.Add(this.lblModName, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.panel6, 1, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(1, 1);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(848, 27);
            this.tableLayoutPanel1.TabIndex = 11;
            this.tableLayoutPanel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.FormBase_MouseDown);
            this.tableLayoutPanel1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.FormBase_MouseMove);
            this.tableLayoutPanel1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.FormBase_MouseUp);
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
            this.lblModName.Text = "TSVision";
            this.lblModName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.panel8);
            this.panel6.Controls.Add(this.panel7);
            this.panel6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel6.Location = new System.Drawing.Point(678, 0);
            this.panel6.Margin = new System.Windows.Forms.Padding(0);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(170, 27);
            this.panel6.TabIndex = 4;
            // 
            // panel8
            // 
            this.panel8.Controls.Add(this.btnSave);
            this.panel8.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel8.Location = new System.Drawing.Point(116, 0);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(26, 27);
            this.panel8.TabIndex = 1;
            // 
            // btnSave
            // 
            this.btnSave.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnSave.FlatAppearance.BorderColor = System.Drawing.Color.AliceBlue;
            this.btnSave.FlatAppearance.BorderSize = 0;
            this.btnSave.FlatAppearance.MouseDownBackColor = System.Drawing.Color.AliceBlue;
            this.btnSave.FlatAppearance.MouseOverBackColor = System.Drawing.Color.AliceBlue;
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.Image = ((System.Drawing.Image)(resources.GetObject("btnSave.Image")));
            this.btnSave.Location = new System.Drawing.Point(0, 0);
            this.btnSave.Margin = new System.Windows.Forms.Padding(4, 1, 10, 1);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(26, 27);
            this.btnSave.TabIndex = 2;
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btn_Save_Click);
            // 
            // panel7
            // 
            this.panel7.Controls.Add(this.btnClose);
            this.panel7.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel7.Location = new System.Drawing.Point(142, 0);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(28, 27);
            this.panel7.TabIndex = 0;
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
            this.btnClose.Location = new System.Drawing.Point(0, 0);
            this.btnClose.Margin = new System.Windows.Forms.Padding(7, 6, 5, 5);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(28, 27);
            this.btnClose.TabIndex = 1;
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btn_Cancel_Click);
            // 
            // panel_bottom
            // 
            this.panel_bottom.BackColor = System.Drawing.Color.AliceBlue;
            this.panel_bottom.Controls.Add(this.lblTime);
            this.panel_bottom.Controls.Add(this.panel5);
            this.panel_bottom.Controls.Add(this.btn_Run);
            this.panel_bottom.Controls.Add(this.panel4);
            this.panel_bottom.Controls.Add(this.panel2);
            this.panel_bottom.Controls.Add(this.panel3);
            this.panel_bottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel_bottom.Location = new System.Drawing.Point(1, 517);
            this.panel_bottom.Name = "panel_bottom";
            this.panel_bottom.Size = new System.Drawing.Size(848, 32);
            this.panel_bottom.TabIndex = 13;
            // 
            // lblTime
            // 
            this.lblTime.Dock = System.Windows.Forms.DockStyle.Right;
            this.lblTime.Font = new System.Drawing.Font("隶书", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblTime.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.lblTime.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblTime.Location = new System.Drawing.Point(604, 4);
            this.lblTime.Name = "lblTime";
            this.lblTime.Size = new System.Drawing.Size(125, 24);
            this.lblTime.TabIndex = 1;
            this.lblTime.Text = "耗时：未知";
            this.lblTime.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // panel5
            // 
            this.panel5.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel5.Location = new System.Drawing.Point(729, 4);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(13, 24);
            this.panel5.TabIndex = 21;
            // 
            // btn_Run
            // 
            this.btn_Run.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Run.Dock = System.Windows.Forms.DockStyle.Right;
            this.btn_Run.FillColor = System.Drawing.Color.CornflowerBlue;
            this.btn_Run.Font = new System.Drawing.Font("隶书", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn_Run.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            this.btn_Run.ForeHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            this.btn_Run.ForePressColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            this.btn_Run.ForeSelectedColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            this.btn_Run.Location = new System.Drawing.Point(742, 4);
            this.btn_Run.Margin = new System.Windows.Forms.Padding(3, 5, 3, 15);
            this.btn_Run.MinimumSize = new System.Drawing.Size(1, 1);
            this.btn_Run.Name = "btn_Run";
            this.btn_Run.Radius = 11;
            this.btn_Run.RectColor = System.Drawing.Color.CornflowerBlue;
            this.btn_Run.Size = new System.Drawing.Size(78, 24);
            this.btn_Run.Style = Rex.UI.UIStyle.Custom;
            this.btn_Run.TabIndex = 20;
            this.btn_Run.Text = "执行";
            // 
            // panel4
            // 
            this.panel4.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel4.Location = new System.Drawing.Point(820, 4);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(28, 24);
            this.panel4.TabIndex = 19;
            // 
            // panel2
            // 
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Margin = new System.Windows.Forms.Padding(0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(848, 4);
            this.panel2.TabIndex = 13;
            // 
            // panel3
            // 
            this.panel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel3.Location = new System.Drawing.Point(0, 28);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(848, 4);
            this.panel3.TabIndex = 14;
            // 
            // panel_center
            // 
            this.panel_center.BackColor = System.Drawing.Color.White;
            this.panel_center.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_center.Location = new System.Drawing.Point(1, 28);
            this.panel_center.Margin = new System.Windows.Forms.Padding(0);
            this.panel_center.Name = "panel_center";
            this.panel_center.Padding = new System.Windows.Forms.Padding(2, 1, 1, 1);
            this.panel_center.Size = new System.Drawing.Size(848, 489);
            this.panel_center.TabIndex = 14;
            // 
            // FormBase
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(850, 550);
            this.Controls.Add(this.panel_center);
            this.Controls.Add(this.panel_bottom);
            this.Controls.Add(this.tableLayoutPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(850, 550);
            this.MinimumSize = new System.Drawing.Size(850, 550);
            this.Name = "FormBase";
            this.Padding = new System.Windows.Forms.Padding(1);
            this.TitleBarBackColor = System.Drawing.Color.Transparent;
            this.TitleColor = System.Drawing.SystemColors.ActiveCaption;
            this.Load += new System.EventHandler(this.FormBase_Load);
            this.Controls.SetChildIndex(this.titlepanel, 0);
            this.Controls.SetChildIndex(this.tableLayoutPanel1, 0);
            this.Controls.SetChildIndex(this.panel_bottom, 0);
            this.Controls.SetChildIndex(this.panel_center, 0);
            ((System.ComponentModel.ISupportInitialize)(this.pbox_Icon)).EndInit();
            this.titlepanel.ResumeLayout(false);
            this.titlepanel.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.panel6.ResumeLayout(false);
            this.panel8.ResumeLayout(false);
            this.panel7.ResumeLayout(false);
            this.panel_bottom.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button btnClose;
        public System.Windows.Forms.Label lblModName;
        public  System.Windows.Forms.Panel panel_bottom;
        public  System.Windows.Forms.Label lblTime;
        public Rex.UI.UIButton btn_Run;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        public System.Windows.Forms.Panel panel_center;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.Panel panel7;
    }
}