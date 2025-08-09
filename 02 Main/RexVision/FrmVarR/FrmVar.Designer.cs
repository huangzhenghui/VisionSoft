
namespace TSIVision.FrmVarR
{
    partial class FrmVar
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.pnlDataVar = new Rex.UI.UITitlePanel();
            this.dgvDataVar = new Rex.UI.UIDataGridView();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.添加变量ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.删除变量ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.上移ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.下移ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.置顶变量ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.置底变量ToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip2 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem6 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem7 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem8 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem9 = new System.Windows.Forms.ToolStripMenuItem();
            this.置底变量ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.pnlDataVar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDataVar)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.contextMenuStrip2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 90F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 1, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(4);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 7.449999F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 87.37F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5.179999F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1427, 761);
            this.tableLayoutPanel1.TabIndex = 2;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 1;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.Controls.Add(this.pnlDataVar, 0, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(71, 56);
            this.tableLayoutPanel2.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(1284, 664);
            this.tableLayoutPanel2.TabIndex = 0;
            // 
            // pnlDataVar
            // 
            this.pnlDataVar.Controls.Add(this.dgvDataVar);
            this.pnlDataVar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlDataVar.FillColor = System.Drawing.Color.Lavender;
            this.pnlDataVar.Font = new System.Drawing.Font("华文新魏", 14.5F);
            this.pnlDataVar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            this.pnlDataVar.Location = new System.Drawing.Point(0, 0);
            this.pnlDataVar.Margin = new System.Windows.Forms.Padding(0);
            this.pnlDataVar.MinimumSize = new System.Drawing.Size(1, 1);
            this.pnlDataVar.Name = "pnlDataVar";
            this.pnlDataVar.Padding = new System.Windows.Forms.Padding(0, 28, 0, 0);
            this.pnlDataVar.Radius = 8;
            this.pnlDataVar.RectColor = System.Drawing.Color.Transparent;
            this.pnlDataVar.Size = new System.Drawing.Size(1284, 664);
            this.pnlDataVar.Style = Rex.UI.UIStyle.Custom;
            this.pnlDataVar.TabIndex = 2;
            this.pnlDataVar.Text = "数据变量";
            this.pnlDataVar.TitleColor = System.Drawing.Color.Navy;
            this.pnlDataVar.TitleHeight = 28;
            // 
            // dgvDataVar
            // 
            this.dgvDataVar.AllowUserToAddRows = false;
            this.dgvDataVar.AllowUserToDeleteRows = false;
            this.dgvDataVar.AllowUserToResizeColumns = false;
            this.dgvDataVar.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Lavender;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("华文新魏", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.DimGray;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.AliceBlue;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.DimGray;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvDataVar.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvDataVar.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvDataVar.BackgroundColor = System.Drawing.Color.Lavender;
            this.dgvDataVar.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dgvDataVar.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.Lavender;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("华文新魏", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Navy;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.Lavender;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Navy;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvDataVar.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvDataVar.ColumnHeadersHeight = 29;
            this.dgvDataVar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvDataVar.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column4,
            this.Column6,
            this.Column7,
            this.Column5});
            this.dgvDataVar.ContextMenuStrip = this.contextMenuStrip1;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.Lavender;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("华文新魏", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.Lavender;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvDataVar.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvDataVar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvDataVar.EnableHeadersVisualStyles = false;
            this.dgvDataVar.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.dgvDataVar.GridColor = System.Drawing.Color.Lavender;
            this.dgvDataVar.Location = new System.Drawing.Point(0, 28);
            this.dgvDataVar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dgvDataVar.MultiSelect = false;
            this.dgvDataVar.Name = "dgvDataVar";
            this.dgvDataVar.RectColor = System.Drawing.Color.Lavender;
            this.dgvDataVar.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.Lavender;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("华文新魏", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.Navy;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.LightSteelBlue;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.Navy;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvDataVar.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvDataVar.RowHeadersVisible = false;
            this.dgvDataVar.RowHeadersWidth = 24;
            this.dgvDataVar.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.Lavender;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("华文新魏", 12.5F);
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.DimGray;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.AliceBlue;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.DimGray;
            this.dgvDataVar.RowsDefaultCellStyle = dataGridViewCellStyle5;
            this.dgvDataVar.RowTemplate.Height = 29;
            this.dgvDataVar.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dgvDataVar.SelectedIndex = -1;
            this.dgvDataVar.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDataVar.Size = new System.Drawing.Size(1284, 636);
            this.dgvDataVar.StripeEvenColor = System.Drawing.Color.Lavender;
            this.dgvDataVar.StripeOddColor = System.Drawing.Color.Lavender;
            this.dgvDataVar.Style = Rex.UI.UIStyle.Custom;
            this.dgvDataVar.StyleCustomMode = true;
            this.dgvDataVar.TabIndex = 58;
            this.dgvDataVar.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDataVar_CellDoubleClick);
            this.dgvDataVar.CellPainting += new System.Windows.Forms.DataGridViewCellPaintingEventHandler(this.dgv_CellPainting);
            // 
            // Column4
            // 
            this.Column4.DataPropertyName = "mDataMode";
            this.Column4.HeaderText = "类型";
            this.Column4.MinimumWidth = 6;
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            this.Column4.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // Column6
            // 
            this.Column6.DataPropertyName = "mDataName";
            this.Column6.HeaderText = "名称";
            this.Column6.MinimumWidth = 6;
            this.Column6.Name = "Column6";
            this.Column6.ReadOnly = true;
            this.Column6.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // Column7
            // 
            this.Column7.DataPropertyName = "mDataValue";
            this.Column7.HeaderText = "初始值";
            this.Column7.MinimumWidth = 6;
            this.Column7.Name = "Column7";
            this.Column7.ReadOnly = true;
            this.Column7.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // Column5
            // 
            this.Column5.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column5.DataPropertyName = "mDataTip0";
            this.Column5.HeaderText = "注释";
            this.Column5.MinimumWidth = 6;
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            this.Column5.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.BackColor = System.Drawing.Color.White;
            this.contextMenuStrip1.Font = new System.Drawing.Font("隶书", 12F);
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.添加变量ToolStripMenuItem,
            this.删除变量ToolStripMenuItem,
            this.上移ToolStripMenuItem,
            this.下移ToolStripMenuItem,
            this.置顶变量ToolStripMenuItem,
            this.置底变量ToolStripMenuItem1});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(159, 148);
            // 
            // 添加变量ToolStripMenuItem
            // 
            this.添加变量ToolStripMenuItem.BackColor = System.Drawing.Color.Lavender;
            this.添加变量ToolStripMenuItem.Name = "添加变量ToolStripMenuItem";
            this.添加变量ToolStripMenuItem.Size = new System.Drawing.Size(158, 24);
            this.添加变量ToolStripMenuItem.Text = "添加变量";
            this.添加变量ToolStripMenuItem.Click += new System.EventHandler(this.tsmiDataVar_Click);
            // 
            // 删除变量ToolStripMenuItem
            // 
            this.删除变量ToolStripMenuItem.BackColor = System.Drawing.Color.Lavender;
            this.删除变量ToolStripMenuItem.Name = "删除变量ToolStripMenuItem";
            this.删除变量ToolStripMenuItem.Size = new System.Drawing.Size(158, 24);
            this.删除变量ToolStripMenuItem.Text = "删除变量";
            this.删除变量ToolStripMenuItem.Click += new System.EventHandler(this.tsmiDataVar_Click);
            // 
            // 上移ToolStripMenuItem
            // 
            this.上移ToolStripMenuItem.BackColor = System.Drawing.Color.Lavender;
            this.上移ToolStripMenuItem.Name = "上移ToolStripMenuItem";
            this.上移ToolStripMenuItem.Size = new System.Drawing.Size(158, 24);
            this.上移ToolStripMenuItem.Text = "上移变量";
            this.上移ToolStripMenuItem.Click += new System.EventHandler(this.tsmiDataVar_Click);
            // 
            // 下移ToolStripMenuItem
            // 
            this.下移ToolStripMenuItem.BackColor = System.Drawing.Color.Lavender;
            this.下移ToolStripMenuItem.Name = "下移ToolStripMenuItem";
            this.下移ToolStripMenuItem.Size = new System.Drawing.Size(158, 24);
            this.下移ToolStripMenuItem.Text = "下移变量";
            this.下移ToolStripMenuItem.Click += new System.EventHandler(this.tsmiDataVar_Click);
            // 
            // 置顶变量ToolStripMenuItem
            // 
            this.置顶变量ToolStripMenuItem.BackColor = System.Drawing.Color.Lavender;
            this.置顶变量ToolStripMenuItem.Name = "置顶变量ToolStripMenuItem";
            this.置顶变量ToolStripMenuItem.Size = new System.Drawing.Size(158, 24);
            this.置顶变量ToolStripMenuItem.Text = "置顶变量";
            this.置顶变量ToolStripMenuItem.Click += new System.EventHandler(this.tsmiDataVar_Click);
            // 
            // 置底变量ToolStripMenuItem1
            // 
            this.置底变量ToolStripMenuItem1.BackColor = System.Drawing.Color.Lavender;
            this.置底变量ToolStripMenuItem1.Name = "置底变量ToolStripMenuItem1";
            this.置底变量ToolStripMenuItem1.Size = new System.Drawing.Size(158, 24);
            this.置底变量ToolStripMenuItem1.Text = "置底变量";
            this.置底变量ToolStripMenuItem1.Click += new System.EventHandler(this.tsmiDataVar_Click);
            // 
            // contextMenuStrip2
            // 
            this.contextMenuStrip2.BackColor = System.Drawing.Color.White;
            this.contextMenuStrip2.Font = new System.Drawing.Font("隶书", 12F);
            this.contextMenuStrip2.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1,
            this.toolStripMenuItem6,
            this.toolStripMenuItem7,
            this.toolStripMenuItem8,
            this.toolStripMenuItem9,
            this.置底变量ToolStripMenuItem});
            this.contextMenuStrip2.Name = "contextMenuStrip1";
            this.contextMenuStrip2.ShowCheckMargin = true;
            this.contextMenuStrip2.ShowImageMargin = false;
            this.contextMenuStrip2.Size = new System.Drawing.Size(159, 148);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.BackColor = System.Drawing.Color.Lavender;
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(158, 24);
            this.toolStripMenuItem1.Text = "添加变量";
            this.toolStripMenuItem1.Click += new System.EventHandler(this.tsmiCtrlVar_Click);
            // 
            // toolStripMenuItem6
            // 
            this.toolStripMenuItem6.BackColor = System.Drawing.Color.Lavender;
            this.toolStripMenuItem6.Name = "toolStripMenuItem6";
            this.toolStripMenuItem6.Size = new System.Drawing.Size(158, 24);
            this.toolStripMenuItem6.Text = "删除变量";
            this.toolStripMenuItem6.Click += new System.EventHandler(this.tsmiCtrlVar_Click);
            // 
            // toolStripMenuItem7
            // 
            this.toolStripMenuItem7.BackColor = System.Drawing.Color.Lavender;
            this.toolStripMenuItem7.Name = "toolStripMenuItem7";
            this.toolStripMenuItem7.Size = new System.Drawing.Size(158, 24);
            this.toolStripMenuItem7.Text = "上移变量";
            this.toolStripMenuItem7.Click += new System.EventHandler(this.tsmiCtrlVar_Click);
            // 
            // toolStripMenuItem8
            // 
            this.toolStripMenuItem8.BackColor = System.Drawing.Color.Lavender;
            this.toolStripMenuItem8.Name = "toolStripMenuItem8";
            this.toolStripMenuItem8.Size = new System.Drawing.Size(158, 24);
            this.toolStripMenuItem8.Text = "下移变量";
            this.toolStripMenuItem8.Click += new System.EventHandler(this.tsmiCtrlVar_Click);
            // 
            // toolStripMenuItem9
            // 
            this.toolStripMenuItem9.BackColor = System.Drawing.Color.Lavender;
            this.toolStripMenuItem9.Name = "toolStripMenuItem9";
            this.toolStripMenuItem9.Size = new System.Drawing.Size(158, 24);
            this.toolStripMenuItem9.Text = "置顶变量";
            this.toolStripMenuItem9.Click += new System.EventHandler(this.tsmiCtrlVar_Click);
            // 
            // 置底变量ToolStripMenuItem
            // 
            this.置底变量ToolStripMenuItem.BackColor = System.Drawing.Color.Lavender;
            this.置底变量ToolStripMenuItem.Name = "置底变量ToolStripMenuItem";
            this.置底变量ToolStripMenuItem.Size = new System.Drawing.Size(158, 24);
            this.置底变量ToolStripMenuItem.Text = "置底变量";
            this.置底变量ToolStripMenuItem.Click += new System.EventHandler(this.tsmiCtrlVar_Click);
            // 
            // FrmVar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1427, 761);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FrmVar";
            this.Text = "FrmVar";
            this.Load += new System.EventHandler(this.FrmVar_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.pnlDataVar.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDataVar)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.contextMenuStrip2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private Rex.UI.UITitlePanel pnlDataVar;
        private Rex.UI.UIDataGridView dgvDataVar;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 添加变量ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 删除变量ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 上移ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 下移ToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip2;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem6;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem7;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem8;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem9;
        private System.Windows.Forms.ToolStripMenuItem 置顶变量ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 置底变量ToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem 置底变量ToolStripMenuItem;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
    }
}