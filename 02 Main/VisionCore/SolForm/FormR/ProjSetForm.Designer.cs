namespace VisionCore
{
    partial class ProjSetForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ProjSetForm));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.bt_Enter = new Rex.UI.UIButton();
            this.bt_Close = new Rex.UI.UIButton();
            this.label1 = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.btnClose = new System.Windows.Forms.Button();
            this.lblModName = new System.Windows.Forms.Label();
            this.tb_SolName = new Rex.UI.UITextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.dgv_ProjSet = new Rex.UI.UIDataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewComboBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.pbox_Icon)).BeginInit();
            this.titlepanel.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_ProjSet)).BeginInit();
            this.SuspendLayout();
            // 
            // pbox_Icon
            // 
            this.pbox_Icon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            // 
            // titlepanel
            // 
            this.titlepanel.Dock = System.Windows.Forms.DockStyle.None;
            this.titlepanel.Size = new System.Drawing.Size(498, 32);
            // 
            // titlelabel
            // 
            this.titlelabel.Size = new System.Drawing.Size(74, 21);
            this.titlelabel.Text = "流程设置";
            // 
            // bt_Enter
            // 
            this.bt_Enter.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bt_Enter.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.bt_Enter.FillColor = System.Drawing.Color.CornflowerBlue;
            this.bt_Enter.Font = new System.Drawing.Font("隶书", 12F);
            this.bt_Enter.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            this.bt_Enter.ForeHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            this.bt_Enter.ForePressColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            this.bt_Enter.ForeSelectedColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            this.bt_Enter.Location = new System.Drawing.Point(303, 369);
            this.bt_Enter.MinimumSize = new System.Drawing.Size(1, 1);
            this.bt_Enter.Name = "bt_Enter";
            this.bt_Enter.Radius = 10;
            this.bt_Enter.Size = new System.Drawing.Size(80, 26);
            this.bt_Enter.Style = Rex.UI.UIStyle.Custom;
            this.bt_Enter.TabIndex = 52;
            this.bt_Enter.Text = "确定";
            this.bt_Enter.Click += new System.EventHandler(this.bt_Enter_Click);
            // 
            // bt_Close
            // 
            this.bt_Close.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bt_Close.FillColor = System.Drawing.Color.CornflowerBlue;
            this.bt_Close.Font = new System.Drawing.Font("隶书", 12F);
            this.bt_Close.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            this.bt_Close.ForeHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            this.bt_Close.ForePressColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            this.bt_Close.ForeSelectedColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            this.bt_Close.Location = new System.Drawing.Point(407, 369);
            this.bt_Close.MinimumSize = new System.Drawing.Size(1, 1);
            this.bt_Close.Name = "bt_Close";
            this.bt_Close.Radius = 10;
            this.bt_Close.Size = new System.Drawing.Size(80, 26);
            this.bt_Close.Style = Rex.UI.UIStyle.Custom;
            this.bt_Close.TabIndex = 53;
            this.bt_Close.Text = "关闭";
            this.bt_Close.Click += new System.EventHandler(this.bt_Close_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("隶书", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.ForeColor = System.Drawing.Color.DimGray;
            this.label1.Location = new System.Drawing.Point(3, 375);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 14);
            this.label1.TabIndex = 54;
            this.label1.Text = "项目名称:";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.BackColor = System.Drawing.Color.AliceBlue;
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 93.5743F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 6.425703F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Controls.Add(this.btnClose, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.lblModName, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(498, 32);
            this.tableLayoutPanel1.TabIndex = 56;
            this.tableLayoutPanel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.FrmCCamDebug_MouseDown);
            this.tableLayoutPanel1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.FrmCCamDebug_MouseMove);
            this.tableLayoutPanel1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.FrmCCamDebug_MouseUp);
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
            this.btnClose.Location = new System.Drawing.Point(472, 6);
            this.btnClose.Margin = new System.Windows.Forms.Padding(7, 6, 5, 5);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(21, 21);
            this.btnClose.TabIndex = 1;
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.bt_Close_Click);
            // 
            // lblModName
            // 
            this.lblModName.Dock = System.Windows.Forms.DockStyle.Left;
            this.lblModName.Font = new System.Drawing.Font("隶书", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblModName.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.lblModName.Location = new System.Drawing.Point(3, 0);
            this.lblModName.Name = "lblModName";
            this.lblModName.Padding = new System.Windows.Forms.Padding(2, 0, 0, 0);
            this.lblModName.Size = new System.Drawing.Size(116, 32);
            this.lblModName.TabIndex = 3;
            this.lblModName.Text = "流程设置";
            this.lblModName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // tb_SolName
            // 
            this.tb_SolName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tb_SolName.FillColor = System.Drawing.Color.CornflowerBlue;
            this.tb_SolName.Font = new System.Drawing.Font("华文新魏", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tb_SolName.ForeColor = System.Drawing.Color.White;
            this.tb_SolName.ForeDisableColor = System.Drawing.Color.White;
            this.tb_SolName.Location = new System.Drawing.Point(76, 371);
            this.tb_SolName.Margin = new System.Windows.Forms.Padding(0);
            this.tb_SolName.Maximum = 2147483647D;
            this.tb_SolName.Minimum = -2147483648D;
            this.tb_SolName.MinimumSize = new System.Drawing.Size(1, 1);
            this.tb_SolName.Name = "tb_SolName";
            this.tb_SolName.RectColor = System.Drawing.Color.AliceBlue;
            this.tb_SolName.Size = new System.Drawing.Size(200, 22);
            this.tb_SolName.Style = Rex.UI.UIStyle.Custom;
            this.tb_SolName.TabIndex = 59;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.dgv_ProjSet);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 32);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(498, 331);
            this.panel2.TabIndex = 60;
            // 
            // dgv_ProjSet
            // 
            this.dgv_ProjSet.AllowUserToAddRows = false;
            this.dgv_ProjSet.AllowUserToDeleteRows = false;
            this.dgv_ProjSet.AllowUserToResizeColumns = false;
            this.dgv_ProjSet.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("华文新魏", 11F);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.AliceBlue;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.dgv_ProjSet.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgv_ProjSet.BackgroundColor = System.Drawing.Color.White;
            this.dgv_ProjSet.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgv_ProjSet.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dgv_ProjSet.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.CornflowerBlue;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("微软雅黑", 9F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.CornflowerBlue;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_ProjSet.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgv_ProjSet.ColumnHeadersHeight = 29;
            this.dgv_ProjSet.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2});
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("微软雅黑", 9F);
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.AliceBlue;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv_ProjSet.DefaultCellStyle = dataGridViewCellStyle4;
            this.dgv_ProjSet.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgv_ProjSet.EnableHeadersVisualStyles = false;
            this.dgv_ProjSet.Font = new System.Drawing.Font("微软雅黑", 9F);
            this.dgv_ProjSet.GridColor = System.Drawing.Color.White;
            this.dgv_ProjSet.Location = new System.Drawing.Point(0, 0);
            this.dgv_ProjSet.MultiSelect = false;
            this.dgv_ProjSet.Name = "dgv_ProjSet";
            this.dgv_ProjSet.RectColor = System.Drawing.Color.Gray;
            this.dgv_ProjSet.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("微软雅黑", 9F);
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_ProjSet.RowHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.dgv_ProjSet.RowHeadersVisible = false;
            this.dgv_ProjSet.RowHeadersWidth = 25;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("华文新魏", 11F);
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.AliceBlue;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.dgv_ProjSet.RowsDefaultCellStyle = dataGridViewCellStyle6;
            this.dgv_ProjSet.RowTemplate.Height = 29;
            this.dgv_ProjSet.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dgv_ProjSet.SelectedIndex = -1;
            this.dgv_ProjSet.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_ProjSet.ShowRect = false;
            this.dgv_ProjSet.Size = new System.Drawing.Size(498, 331);
            this.dgv_ProjSet.StripeOddColor = System.Drawing.Color.White;
            this.dgv_ProjSet.Style = Rex.UI.UIStyle.Custom;
            this.dgv_ProjSet.StyleCustomMode = true;
            this.dgv_ProjSet.TabIndex = 53;
            this.dgv_ProjSet.CellPainting += new System.Windows.Forms.DataGridViewCellPaintingEventHandler(this.dgv_CellPainting);
            // 
            // Column1
            // 
            this.Column1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column1.DataPropertyName = "Name";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("华文新魏", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Column1.DefaultCellStyle = dataGridViewCellStyle3;
            this.Column1.FillWeight = 1.340101F;
            this.Column1.HeaderText = "流程名称";
            this.Column1.Name = "Column1";
            this.Column1.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // Column2
            // 
            this.Column2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column2.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.Nothing;
            this.Column2.FillWeight = 1.659899F;
            this.Column2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Column2.HeaderText = "执行方式";
            this.Column2.Items.AddRange(new object[] {
            "主动执行",
            "调用时执行"});
            this.Column2.Name = "Column2";
            this.Column2.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Column2.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // ProjSetForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.AliceBlue;
            this.ClientSize = new System.Drawing.Size(498, 398);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.tb_SolName);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.bt_Close);
            this.Controls.Add(this.bt_Enter);
            this.Font = new System.Drawing.Font("华文新魏", 11F);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(500, 400);
            this.MinimumSize = new System.Drawing.Size(500, 400);
            this.Name = "ProjSetForm";
            this.Title = "流程设置";
            this.TitleSize = new System.Drawing.Size(74, 21);
            this.Load += new System.EventHandler(this.ProjSetForm_Load);
            this.Controls.SetChildIndex(this.titlepanel, 0);
            this.Controls.SetChildIndex(this.bt_Enter, 0);
            this.Controls.SetChildIndex(this.bt_Close, 0);
            this.Controls.SetChildIndex(this.label1, 0);
            this.Controls.SetChildIndex(this.tableLayoutPanel1, 0);
            this.Controls.SetChildIndex(this.tb_SolName, 0);
            this.Controls.SetChildIndex(this.panel2, 0);
            ((System.ComponentModel.ISupportInitialize)(this.pbox_Icon)).EndInit();
            this.titlepanel.ResumeLayout(false);
            this.titlepanel.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_ProjSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Rex.UI.UIButton bt_Enter;
        private Rex.UI.UIButton bt_Close;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Label lblModName;
        private Rex.UI.UITextBox tb_SolName;
        private System.Windows.Forms.Panel panel2;
        private Rex.UI.UIDataGridView dgv_ProjSet;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewComboBoxColumn Column2;
    }
}