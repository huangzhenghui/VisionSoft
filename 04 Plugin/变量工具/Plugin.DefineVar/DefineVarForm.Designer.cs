namespace Plugin.DefineVar
{
    partial class DefineVarForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DefineVarForm));
            this.button7 = new Rex.UI.UIButton();
            this.button6 = new Rex.UI.UIButton();
            this.button5 = new Rex.UI.UIButton();
            this.uibt_AddInt = new Rex.UI.UIButton();
            this.dgv_VarList = new Rex.UI.UIDataGridView();
            this.uiButton1 = new Rex.UI.UIButton();
            this.uiButton2 = new Rex.UI.UIButton();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel_bottom.SuspendLayout();
            this.panel_center.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbox_Icon)).BeginInit();
            this.titlepanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_VarList)).BeginInit();
            this.SuspendLayout();
            // 
            // panel_bottom
            // 
            this.panel_bottom.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            // 
            // btn_Run
            // 
            this.btn_Run.Click += new System.EventHandler(this.btn_Run_Click);
            // 
            // panel_center
            // 
            this.panel_center.Controls.Add(this.uiButton1);
            this.panel_center.Controls.Add(this.uiButton2);
            this.panel_center.Controls.Add(this.dgv_VarList);
            this.panel_center.Controls.Add(this.button7);
            this.panel_center.Controls.Add(this.button6);
            this.panel_center.Controls.Add(this.button5);
            this.panel_center.Controls.Add(this.uibt_AddInt);
            this.panel_center.Margin = new System.Windows.Forms.Padding(4);
            // 
            // button7
            // 
            this.button7.BackColor = System.Drawing.Color.White;
            this.button7.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button7.FillColor = System.Drawing.Color.CornflowerBlue;
            this.button7.Font = new System.Drawing.Font("隶书", 12F);
            this.button7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            this.button7.ForeHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            this.button7.ForePressColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            this.button7.ForeSelectedColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            this.button7.Location = new System.Drawing.Point(753, 168);
            this.button7.MinimumSize = new System.Drawing.Size(1, 1);
            this.button7.Name = "button7";
            this.button7.Radius = 11;
            this.button7.RectColor = System.Drawing.Color.CornflowerBlue;
            this.button7.RectHoverColor = System.Drawing.Color.CornflowerBlue;
            this.button7.RectPressColor = System.Drawing.Color.CornflowerBlue;
            this.button7.RectSelectedColor = System.Drawing.Color.CornflowerBlue;
            this.button7.Size = new System.Drawing.Size(82, 26);
            this.button7.Style = Rex.UI.UIStyle.Custom;
            this.button7.TabIndex = 44;
            this.button7.Text = "下移";
            this.button7.Click += new System.EventHandler(this.列表操作);
            // 
            // button6
            // 
            this.button6.BackColor = System.Drawing.Color.White;
            this.button6.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button6.FillColor = System.Drawing.Color.CornflowerBlue;
            this.button6.Font = new System.Drawing.Font("隶书", 12F);
            this.button6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            this.button6.ForeHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            this.button6.ForePressColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            this.button6.ForeSelectedColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            this.button6.Location = new System.Drawing.Point(753, 126);
            this.button6.MinimumSize = new System.Drawing.Size(1, 1);
            this.button6.Name = "button6";
            this.button6.Radius = 11;
            this.button6.RectColor = System.Drawing.Color.CornflowerBlue;
            this.button6.RectHoverColor = System.Drawing.Color.CornflowerBlue;
            this.button6.RectPressColor = System.Drawing.Color.CornflowerBlue;
            this.button6.RectSelectedColor = System.Drawing.Color.CornflowerBlue;
            this.button6.Size = new System.Drawing.Size(82, 26);
            this.button6.Style = Rex.UI.UIStyle.Custom;
            this.button6.TabIndex = 43;
            this.button6.Text = "上移";
            this.button6.Click += new System.EventHandler(this.列表操作);
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.White;
            this.button5.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button5.FillColor = System.Drawing.Color.CornflowerBlue;
            this.button5.Font = new System.Drawing.Font("隶书", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            this.button5.ForeHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            this.button5.ForePressColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            this.button5.ForeSelectedColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            this.button5.Location = new System.Drawing.Point(753, 84);
            this.button5.MinimumSize = new System.Drawing.Size(1, 1);
            this.button5.Name = "button5";
            this.button5.Radius = 11;
            this.button5.RectColor = System.Drawing.Color.CornflowerBlue;
            this.button5.RectHoverColor = System.Drawing.Color.CornflowerBlue;
            this.button5.RectPressColor = System.Drawing.Color.CornflowerBlue;
            this.button5.RectSelectedColor = System.Drawing.Color.CornflowerBlue;
            this.button5.Size = new System.Drawing.Size(82, 26);
            this.button5.Style = Rex.UI.UIStyle.Custom;
            this.button5.TabIndex = 42;
            this.button5.Text = "删除";
            this.button5.Click += new System.EventHandler(this.列表操作);
            // 
            // uibt_AddInt
            // 
            this.uibt_AddInt.BackColor = System.Drawing.Color.White;
            this.uibt_AddInt.Cursor = System.Windows.Forms.Cursors.Hand;
            this.uibt_AddInt.FillColor = System.Drawing.Color.CornflowerBlue;
            this.uibt_AddInt.Font = new System.Drawing.Font("隶书", 12F);
            this.uibt_AddInt.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            this.uibt_AddInt.ForeHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            this.uibt_AddInt.ForePressColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            this.uibt_AddInt.ForeSelectedColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            this.uibt_AddInt.Location = new System.Drawing.Point(753, 42);
            this.uibt_AddInt.MinimumSize = new System.Drawing.Size(1, 1);
            this.uibt_AddInt.Name = "uibt_AddInt";
            this.uibt_AddInt.Radius = 11;
            this.uibt_AddInt.RectColor = System.Drawing.Color.CornflowerBlue;
            this.uibt_AddInt.RectHoverColor = System.Drawing.Color.CornflowerBlue;
            this.uibt_AddInt.RectPressColor = System.Drawing.Color.CornflowerBlue;
            this.uibt_AddInt.RectSelectedColor = System.Drawing.Color.CornflowerBlue;
            this.uibt_AddInt.Size = new System.Drawing.Size(82, 26);
            this.uibt_AddInt.Style = Rex.UI.UIStyle.Custom;
            this.uibt_AddInt.TabIndex = 38;
            this.uibt_AddInt.Text = "添加";
            this.uibt_AddInt.Click += new System.EventHandler(this.列表操作);
            // 
            // dgv_VarList
            // 
            this.dgv_VarList.AllowUserToAddRows = false;
            this.dgv_VarList.AllowUserToDeleteRows = false;
            this.dgv_VarList.AllowUserToResizeColumns = false;
            this.dgv_VarList.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.GhostWhite;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("华文新魏", 11F);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.PowderBlue;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.dgv_VarList.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgv_VarList.BackgroundColor = System.Drawing.Color.GhostWhite;
            this.dgv_VarList.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgv_VarList.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dgv_VarList.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.CornflowerBlue;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("隶书", 12F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.CornflowerBlue;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_VarList.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgv_VarList.ColumnHeadersHeight = 25;
            this.dgv_VarList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgv_VarList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column4,
            this.Column6,
            this.Column7,
            this.Column5});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.AliceBlue;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("华文新魏", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.PowderBlue;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv_VarList.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgv_VarList.Dock = System.Windows.Forms.DockStyle.Left;
            this.dgv_VarList.EnableHeadersVisualStyles = false;
            this.dgv_VarList.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.dgv_VarList.GridColor = System.Drawing.Color.AliceBlue;
            this.dgv_VarList.Location = new System.Drawing.Point(1, 1);
            this.dgv_VarList.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dgv_VarList.MultiSelect = false;
            this.dgv_VarList.Name = "dgv_VarList";
            this.dgv_VarList.RectColor = System.Drawing.Color.AliceBlue;
            this.dgv_VarList.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.AliceBlue;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("华文新魏", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.PowderBlue;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_VarList.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dgv_VarList.RowHeadersVisible = false;
            this.dgv_VarList.RowHeadersWidth = 29;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.GhostWhite;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("华文新魏", 11F);
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.PowderBlue;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.dgv_VarList.RowsDefaultCellStyle = dataGridViewCellStyle5;
            this.dgv_VarList.RowTemplate.Height = 29;
            this.dgv_VarList.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dgv_VarList.SelectedIndex = -1;
            this.dgv_VarList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_VarList.ShowRect = false;
            this.dgv_VarList.Size = new System.Drawing.Size(739, 485);
            this.dgv_VarList.StripeEvenColor = System.Drawing.Color.GhostWhite;
            this.dgv_VarList.StripeOddColor = System.Drawing.Color.GhostWhite;
            this.dgv_VarList.Style = Rex.UI.UIStyle.Custom;
            this.dgv_VarList.StyleCustomMode = true;
            this.dgv_VarList.TabIndex = 58;
            this.dgv_VarList.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_VarList_CellDoubleClick);
            this.dgv_VarList.CellPainting += new System.Windows.Forms.DataGridViewCellPaintingEventHandler(this.dgv_CellPainting);
            // 
            // uiButton1
            // 
            this.uiButton1.BackColor = System.Drawing.Color.White;
            this.uiButton1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.uiButton1.FillColor = System.Drawing.Color.CornflowerBlue;
            this.uiButton1.Font = new System.Drawing.Font("隶书", 12F);
            this.uiButton1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            this.uiButton1.ForeHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            this.uiButton1.ForePressColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            this.uiButton1.ForeSelectedColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            this.uiButton1.Location = new System.Drawing.Point(753, 252);
            this.uiButton1.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiButton1.Name = "uiButton1";
            this.uiButton1.Radius = 11;
            this.uiButton1.RectColor = System.Drawing.Color.CornflowerBlue;
            this.uiButton1.RectHoverColor = System.Drawing.Color.CornflowerBlue;
            this.uiButton1.RectPressColor = System.Drawing.Color.CornflowerBlue;
            this.uiButton1.RectSelectedColor = System.Drawing.Color.CornflowerBlue;
            this.uiButton1.Size = new System.Drawing.Size(82, 26);
            this.uiButton1.Style = Rex.UI.UIStyle.Custom;
            this.uiButton1.TabIndex = 60;
            this.uiButton1.Text = "置底";
            this.uiButton1.Click += new System.EventHandler(this.列表操作);
            // 
            // uiButton2
            // 
            this.uiButton2.BackColor = System.Drawing.Color.White;
            this.uiButton2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.uiButton2.FillColor = System.Drawing.Color.CornflowerBlue;
            this.uiButton2.Font = new System.Drawing.Font("隶书", 12F);
            this.uiButton2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            this.uiButton2.ForeHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            this.uiButton2.ForePressColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            this.uiButton2.ForeSelectedColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            this.uiButton2.Location = new System.Drawing.Point(753, 210);
            this.uiButton2.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiButton2.Name = "uiButton2";
            this.uiButton2.Radius = 11;
            this.uiButton2.RectColor = System.Drawing.Color.CornflowerBlue;
            this.uiButton2.RectHoverColor = System.Drawing.Color.CornflowerBlue;
            this.uiButton2.RectPressColor = System.Drawing.Color.CornflowerBlue;
            this.uiButton2.RectSelectedColor = System.Drawing.Color.CornflowerBlue;
            this.uiButton2.Size = new System.Drawing.Size(82, 26);
            this.uiButton2.Style = Rex.UI.UIStyle.Custom;
            this.uiButton2.TabIndex = 59;
            this.uiButton2.Text = "置顶";
            this.uiButton2.Click += new System.EventHandler(this.列表操作);
            // 
            // Column4
            // 
            this.Column4.DataPropertyName = "mDataMode";
            this.Column4.HeaderText = "类型";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            this.Column4.Width = 120;
            // 
            // Column6
            // 
            this.Column6.DataPropertyName = "mDataName";
            this.Column6.HeaderText = "名称";
            this.Column6.Name = "Column6";
            this.Column6.Width = 150;
            // 
            // Column7
            // 
            this.Column7.DataPropertyName = "mDataValue";
            this.Column7.HeaderText = "值";
            this.Column7.Name = "Column7";
            this.Column7.Width = 280;
            // 
            // Column5
            // 
            this.Column5.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column5.DataPropertyName = "mDataTip0";
            this.Column5.HeaderText = "注释";
            this.Column5.Name = "Column5";
            // 
            // DefineVarForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(848, 548);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "DefineVarForm";
            this.panel_bottom.ResumeLayout(false);
            this.panel_center.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbox_Icon)).EndInit();
            this.titlepanel.ResumeLayout(false);
            this.titlepanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_VarList)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private Rex.UI.UIButton button7;
        private Rex.UI.UIButton button6;
        private Rex.UI.UIButton button5;
        private Rex.UI.UIButton uibt_AddInt;
        private Rex.UI.UIDataGridView dgv_VarList;
        private Rex.UI.UIButton uiButton1;
        private Rex.UI.UIButton uiButton2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
    }
}