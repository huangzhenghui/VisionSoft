
namespace Plugin.DistancePl
{
    partial class ResultForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ResultForm));
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.btnClose = new System.Windows.Forms.Button();
            this.lblModName = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.uibt_Close = new Rex.UI.UIButton();
            this.tbxResult = new Rex.UI.UITextBox();
            this.lblResult = new Rex.UI.UISymbolLabel();
            this.label43 = new System.Windows.Forms.Label();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.BackColor = System.Drawing.Color.AliceBlue;
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 92.05956F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 7.940447F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Controls.Add(this.btnClose, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.lblModName, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(403, 27);
            this.tableLayoutPanel1.TabIndex = 132;
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
            this.btnClose.Location = new System.Drawing.Point(378, 6);
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
            this.lblModName.Text = "执行结果";
            this.lblModName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.AliceBlue;
            this.panel3.Controls.Add(this.uibt_Close);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel3.Location = new System.Drawing.Point(0, 305);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(403, 35);
            this.panel3.TabIndex = 148;
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
            this.uibt_Close.Location = new System.Drawing.Point(305, 6);
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
            // tbxResult
            // 
            this.tbxResult.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbxResult.BackColor = System.Drawing.Color.AliceBlue;
            this.tbxResult.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbxResult.FillColor = System.Drawing.Color.AliceBlue;
            this.tbxResult.Font = new System.Drawing.Font("华文新魏", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tbxResult.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.tbxResult.Location = new System.Drawing.Point(109, 77);
            this.tbxResult.Margin = new System.Windows.Forms.Padding(0);
            this.tbxResult.Maximum = 2147483647D;
            this.tbxResult.Minimum = -2147483648D;
            this.tbxResult.MinimumSize = new System.Drawing.Size(1, 1);
            this.tbxResult.Multiline = true;
            this.tbxResult.Name = "tbxResult";
            this.tbxResult.RadiusSides = Rex.UI.UICornerRadiusSides.None;
            this.tbxResult.RectColor = System.Drawing.Color.AliceBlue;
            this.tbxResult.Size = new System.Drawing.Size(254, 208);
            this.tbxResult.Style = Rex.UI.UIStyle.Custom;
            this.tbxResult.TabIndex = 157;
            // 
            // lblResult
            // 
            this.lblResult.BackColor = System.Drawing.Color.White;
            this.lblResult.Font = new System.Drawing.Font("华文新魏", 11.5F);
            this.lblResult.ForeColor = System.Drawing.Color.LightSalmon;
            this.lblResult.Location = new System.Drawing.Point(34, 46);
            this.lblResult.MinimumSize = new System.Drawing.Size(1, 1);
            this.lblResult.Name = "lblResult";
            this.lblResult.Padding = new System.Windows.Forms.Padding(22, 0, 0, 0);
            this.lblResult.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblResult.Size = new System.Drawing.Size(118, 23);
            this.lblResult.Style = Rex.UI.UIStyle.Custom;
            this.lblResult.Symbol = 61736;
            this.lblResult.SymbolColor = System.Drawing.Color.LightSalmon;
            this.lblResult.SymbolSize = 18;
            this.lblResult.TabIndex = 156;
            this.lblResult.Text = "模块未执行";
            this.lblResult.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label43
            // 
            this.label43.AutoSize = true;
            this.label43.BackColor = System.Drawing.Color.Transparent;
            this.label43.Font = new System.Drawing.Font("华文新魏", 11F);
            this.label43.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.label43.Location = new System.Drawing.Point(35, 77);
            this.label43.Name = "label43";
            this.label43.Size = new System.Drawing.Size(73, 16);
            this.label43.TabIndex = 155;
            this.label43.Text = "执行结果:";
            // 
            // ResultForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(403, 340);
            this.Controls.Add(this.tbxResult);
            this.Controls.Add(this.lblResult);
            this.Controls.Add(this.label43);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ResultForm";
            this.Text = "ResultForm";
            this.TopMost = true;
            this.tableLayoutPanel1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Label lblModName;
        private System.Windows.Forms.Panel panel3;
        private Rex.UI.UIButton uibt_Close;
        private Rex.UI.UITextBox tbxResult;
        public Rex.UI.UISymbolLabel lblResult;
        private System.Windows.Forms.Label label43;
    }
}