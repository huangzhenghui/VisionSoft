namespace VisionCore
{
    partial class PluginDataLinkForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PluginDataLinkForm));
            this.panel2 = new System.Windows.Forms.Panel();
            this.dgv_VarList = new Rex.UI.UIDataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tre_ModList = new Rex.UI.UITreeView();
            this.panel3 = new System.Windows.Forms.Panel();
            this.uibt_OK = new Rex.UI.UIButton();
            this.uibt_NO = new Rex.UI.UIButton();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.btnClose = new System.Windows.Forms.Button();
            this.lblModName = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pbox_Icon)).BeginInit();
            this.titlepanel.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_VarList)).BeginInit();
            this.panel3.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pbox_Icon
            // 
            this.pbox_Icon.Image = global::VisionCore.Properties.Resources.bianliang;
            this.pbox_Icon.Size = new System.Drawing.Size(30, 508);
            // 
            // titlepanel
            // 
            this.titlepanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.titlepanel.Size = new System.Drawing.Size(678, 508);
            // 
            // titlelabel
            // 
            this.titlelabel.Font = new System.Drawing.Font("隶书", 12F);
            this.titlelabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.titlelabel.Location = new System.Drawing.Point(36, 8);
            this.titlelabel.Size = new System.Drawing.Size(72, 16);
            this.titlelabel.Text = "模块列表";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.dgv_VarList);
            this.panel2.Controls.Add(this.tre_ModList);
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Controls.Add(this.tableLayoutPanel1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(678, 508);
            this.panel2.TabIndex = 125;
            // 
            // dgv_VarList
            // 
            this.dgv_VarList.AllowUserToAddRows = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.AliceBlue;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("华文新魏", 11F);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.SkyBlue;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.dgv_VarList.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgv_VarList.BackgroundColor = System.Drawing.Color.GhostWhite;
            this.dgv_VarList.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgv_VarList.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dgv_VarList.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.CornflowerBlue;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("隶书", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.CornflowerBlue;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_VarList.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgv_VarList.ColumnHeadersHeight = 30;
            this.dgv_VarList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgv_VarList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.AliceBlue;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("华文新魏", 11F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv_VarList.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgv_VarList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgv_VarList.EnableHeadersVisualStyles = false;
            this.dgv_VarList.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.dgv_VarList.GridColor = System.Drawing.Color.AliceBlue;
            this.dgv_VarList.Location = new System.Drawing.Point(187, 27);
            this.dgv_VarList.Name = "dgv_VarList";
            this.dgv_VarList.ReadOnly = true;
            this.dgv_VarList.RectColor = System.Drawing.Color.AliceBlue;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(160)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("微软雅黑", 12F);
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_VarList.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dgv_VarList.RowHeadersVisible = false;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.AliceBlue;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("华文新魏", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.SkyBlue;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.dgv_VarList.RowsDefaultCellStyle = dataGridViewCellStyle5;
            this.dgv_VarList.RowTemplate.Height = 29;
            this.dgv_VarList.SelectedIndex = -1;
            this.dgv_VarList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_VarList.ShowRect = false;
            this.dgv_VarList.Size = new System.Drawing.Size(491, 439);
            this.dgv_VarList.StripeEvenColor = System.Drawing.Color.AliceBlue;
            this.dgv_VarList.StripeOddColor = System.Drawing.Color.AliceBlue;
            this.dgv_VarList.Style = Rex.UI.UIStyle.Custom;
            this.dgv_VarList.StyleCustomMode = true;
            this.dgv_VarList.TabIndex = 133;
            this.dgv_VarList.SelectIndexChange += new Rex.UI.UIDataGridView.OnSelectIndexChange(this.dgv_VarList_SelectIndexChange);
            this.dgv_VarList.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_VarList_CellDoubleClick);
            this.dgv_VarList.CellPainting += new System.Windows.Forms.DataGridViewCellPaintingEventHandler(this.dgv_CellPainting);
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "Type";
            this.Column1.FillWeight = 88F;
            this.Column1.HeaderText = "类型";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "Name";
            this.Column2.FillWeight = 88F;
            this.Column2.HeaderText = "名称";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            this.Column2.Width = 200;
            // 
            // Column3
            // 
            this.Column3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column3.DataPropertyName = "Result";
            this.Column3.HeaderText = "值";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // tre_ModList
            // 
            this.tre_ModList.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.tre_ModList.Dock = System.Windows.Forms.DockStyle.Left;
            this.tre_ModList.FillColor = System.Drawing.Color.White;
            this.tre_ModList.FillDisableColor = System.Drawing.Color.White;
            this.tre_ModList.Font = new System.Drawing.Font("华文新魏", 11F);
            this.tre_ModList.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.tre_ModList.ForeDisableColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.tre_ModList.Location = new System.Drawing.Point(0, 27);
            this.tre_ModList.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tre_ModList.MinimumSize = new System.Drawing.Size(1, 1);
            this.tre_ModList.Name = "tre_ModList";
            this.tre_ModList.RadiusSides = Rex.UI.UICornerRadiusSides.None;
            this.tre_ModList.RectColor = System.Drawing.Color.AliceBlue;
            this.tre_ModList.RectDisableColor = System.Drawing.Color.AliceBlue;
            this.tre_ModList.SelectedNode = null;
            this.tre_ModList.Size = new System.Drawing.Size(187, 439);
            this.tre_ModList.Style = Rex.UI.UIStyle.Custom;
            this.tre_ModList.StyleCustomMode = true;
            this.tre_ModList.TabIndex = 132;
            this.tre_ModList.Text = null;
            this.tre_ModList.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.tre_ModList_AfterSelect);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.AliceBlue;
            this.panel3.Controls.Add(this.uibt_OK);
            this.panel3.Controls.Add(this.uibt_NO);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel3.Location = new System.Drawing.Point(0, 466);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(678, 42);
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
            this.uibt_OK.ForeHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.uibt_OK.ForePressColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.uibt_OK.ForeSelectedColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.uibt_OK.Location = new System.Drawing.Point(494, 8);
            this.uibt_OK.MinimumSize = new System.Drawing.Size(1, 1);
            this.uibt_OK.Name = "uibt_OK";
            this.uibt_OK.Radius = 11;
            this.uibt_OK.RectColor = System.Drawing.Color.CornflowerBlue;
            this.uibt_OK.Size = new System.Drawing.Size(70, 26);
            this.uibt_OK.Style = Rex.UI.UIStyle.Custom;
            this.uibt_OK.StyleCustomMode = true;
            this.uibt_OK.TabIndex = 127;
            this.uibt_OK.Text = "确认";
            this.uibt_OK.Click += new System.EventHandler(this.btn_OK_Click);
            // 
            // uibt_NO
            // 
            this.uibt_NO.BackColor = System.Drawing.Color.AliceBlue;
            this.uibt_NO.Cursor = System.Windows.Forms.Cursors.Hand;
            this.uibt_NO.FillColor = System.Drawing.Color.CornflowerBlue;
            this.uibt_NO.FillDisableColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            this.uibt_NO.Font = new System.Drawing.Font("隶书", 12F);
            this.uibt_NO.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            this.uibt_NO.ForeHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.uibt_NO.ForePressColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.uibt_NO.ForeSelectedColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.uibt_NO.Location = new System.Drawing.Point(590, 8);
            this.uibt_NO.MinimumSize = new System.Drawing.Size(1, 1);
            this.uibt_NO.Name = "uibt_NO";
            this.uibt_NO.Radius = 11;
            this.uibt_NO.RectColor = System.Drawing.Color.CornflowerBlue;
            this.uibt_NO.Size = new System.Drawing.Size(70, 26);
            this.uibt_NO.Style = Rex.UI.UIStyle.Custom;
            this.uibt_NO.StyleCustomMode = true;
            this.uibt_NO.TabIndex = 128;
            this.uibt_NO.Text = "取消";
            this.uibt_NO.Click += new System.EventHandler(this.btn_NO_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.BackColor = System.Drawing.Color.AliceBlue;
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 96.21758F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 3.782411F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Controls.Add(this.btnClose, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.lblModName, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(678, 27);
            this.tableLayoutPanel1.TabIndex = 129;
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
            this.btnClose.Location = new System.Drawing.Point(659, 6);
            this.btnClose.Margin = new System.Windows.Forms.Padding(7, 6, 5, 5);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(14, 16);
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
            this.lblModName.Text = "MTSVision";
            this.lblModName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // PluginDataLinkForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.AliceBlue;
            this.ClientSize = new System.Drawing.Size(678, 508);
            this.Controls.Add(this.panel2);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(680, 510);
            this.MinimumSize = new System.Drawing.Size(680, 510);
            this.Name = "PluginDataLinkForm";
            this.Opacity = 0.9D;
            this.Title = "模块列表";
            this.TitleColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.TitleFont = new System.Drawing.Font("隶书", 12F);
            this.TitleSize = new System.Drawing.Size(72, 16);
            this.TopMost = true;
            this.Controls.SetChildIndex(this.titlepanel, 0);
            this.Controls.SetChildIndex(this.panel2, 0);
            ((System.ComponentModel.ISupportInitialize)(this.pbox_Icon)).EndInit();
            this.titlepanel.ResumeLayout(false);
            this.titlepanel.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_VarList)).EndInit();
            this.panel3.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private Rex.UI.UIButton uibt_OK;
        private Rex.UI.UIButton uibt_NO;
        private Rex.UI.UIDataGridView dgv_VarList;
        private Rex.UI.UITreeView tre_ModList;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Label lblModName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
    }
}