
namespace Plugin.NinePointsCalib
{
    partial class NinePointsCalibForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NinePointsCalibForm));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            this.uiTabControl1 = new Rex.UI.UITabControl();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.pnl2 = new Rex.UI.UITitlePanel();
            this.label4 = new System.Windows.Forms.Label();
            this.tbxRMSMax = new RexControl.MyControls.MyTextBoxUpDownD();
            this.tbxRMSMin = new RexControl.MyControls.MyTextBoxUpDownD();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cbxPointNum = new Rex.UI.MyComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.uiTitlePanel2 = new Rex.UI.UITitlePanel();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.tbxSavePath = new RexControl.MyControls.TextBoxEx();
            this.btnSavePathLink = new System.Windows.Forms.Button();
            this.label14 = new System.Windows.Forms.Label();
            this.dgv_PointList = new Rex.UI.UIDataGridView();
            this.Index = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RobotY = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnShowResult = new Rex.UI.UISymbolButton();
            this.panel_bottom.SuspendLayout();
            this.panel_center.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbox_Icon)).BeginInit();
            this.titlepanel.SuspendLayout();
            this.uiTabControl1.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.pnl2.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.uiTitlePanel2.SuspendLayout();
            this.tableLayoutPanel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_PointList)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_Run
            // 
            this.btn_Run.Click += new System.EventHandler(this.btn_Run_Click);
            // 
            // panel_center
            // 
            this.panel_center.Controls.Add(this.btnShowResult);
            this.panel_center.Controls.Add(this.dgv_PointList);
            this.panel_center.Controls.Add(this.uiTabControl1);
            // 
            // uiTabControl1
            // 
            this.uiTabControl1.Controls.Add(this.tabPage3);
            this.uiTabControl1.Controls.Add(this.tabPage2);
            this.uiTabControl1.Dock = System.Windows.Forms.DockStyle.Left;
            this.uiTabControl1.DrawMode = System.Windows.Forms.TabDrawMode.OwnerDrawFixed;
            this.uiTabControl1.Font = new System.Drawing.Font("华文新魏", 12F);
            this.uiTabControl1.ItemSize = new System.Drawing.Size(85, 26);
            this.uiTabControl1.Location = new System.Drawing.Point(1, 1);
            this.uiTabControl1.Margin = new System.Windows.Forms.Padding(0);
            this.uiTabControl1.MenuStyle = Rex.UI.UIMenuStyle.Custom;
            this.uiTabControl1.Name = "uiTabControl1";
            this.uiTabControl1.Padding = new System.Drawing.Point(3, 3);
            this.uiTabControl1.SelectedIndex = 0;
            this.uiTabControl1.Size = new System.Drawing.Size(303, 485);
            this.uiTabControl1.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.uiTabControl1.Style = Rex.UI.UIStyle.Custom;
            this.uiTabControl1.TabBackColor = System.Drawing.Color.White;
            this.uiTabControl1.TabIndex = 20;
            this.uiTabControl1.TabSelectedColor = System.Drawing.Color.White;
            this.uiTabControl1.TabSelectedForeColor = System.Drawing.Color.CornflowerBlue;
            this.uiTabControl1.TabSelectedHighColor = System.Drawing.Color.White;
            this.uiTabControl1.TabUnSelectedForeColor = System.Drawing.Color.Silver;
            // 
            // tabPage3
            // 
            this.tabPage3.BackColor = System.Drawing.Color.White;
            this.tabPage3.Controls.Add(this.pnl2);
            this.tabPage3.Font = new System.Drawing.Font("隶书", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tabPage3.Location = new System.Drawing.Point(0, 26);
            this.tabPage3.Margin = new System.Windows.Forms.Padding(0);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(303, 459);
            this.tabPage3.TabIndex = 0;
            this.tabPage3.Text = "矩阵设置";
            // 
            // pnl2
            // 
            this.pnl2.Controls.Add(this.label4);
            this.pnl2.Controls.Add(this.tbxRMSMax);
            this.pnl2.Controls.Add(this.tbxRMSMin);
            this.pnl2.Controls.Add(this.label2);
            this.pnl2.Controls.Add(this.label3);
            this.pnl2.Controls.Add(this.cbxPointNum);
            this.pnl2.Controls.Add(this.label1);
            this.pnl2.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnl2.FillColor = System.Drawing.Color.White;
            this.pnl2.Font = new System.Drawing.Font("华文新魏", 12F);
            this.pnl2.ForeColor = System.Drawing.Color.White;
            this.pnl2.Location = new System.Drawing.Point(0, 0);
            this.pnl2.Margin = new System.Windows.Forms.Padding(0);
            this.pnl2.MinimumSize = new System.Drawing.Size(1, 1);
            this.pnl2.Name = "pnl2";
            this.pnl2.Padding = new System.Windows.Forms.Padding(3, 25, 3, 0);
            this.pnl2.RadiusSides = Rex.UI.UICornerRadiusSides.None;
            this.pnl2.RectColor = System.Drawing.Color.White;
            this.pnl2.Size = new System.Drawing.Size(303, 403);
            this.pnl2.Style = Rex.UI.UIStyle.Custom;
            this.pnl2.TabIndex = 213;
            this.pnl2.Text = "参数设置";
            this.pnl2.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.pnl2.TextAlignment = System.Drawing.ContentAlignment.BottomCenter;
            this.pnl2.TitleColor = System.Drawing.Color.CornflowerBlue;
            this.pnl2.TitleInterval = 5;
            // 
            // label4
            // 
            this.label4.ForeColor = System.Drawing.Color.LightSalmon;
            this.label4.Location = new System.Drawing.Point(20, 174);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(261, 22);
            this.label4.TabIndex = 267;
            this.label4.Text = "注:RMS只有在误差范围以内才保存矩阵";
            // 
            // tbxRMSMax
            // 
            this.tbxRMSMax.Font = new System.Drawing.Font("华文新魏", 11F);
            this.tbxRMSMax.FontStyle = null;
            this.tbxRMSMax.Location = new System.Drawing.Point(83, 105);
            this.tbxRMSMax.Name = "tbxRMSMax";
            this.tbxRMSMax.Size = new System.Drawing.Size(208, 26);
            this.tbxRMSMax.TabIndex = 266;
            this.tbxRMSMax.TextInfo = "";
            // 
            // tbxRMSMin
            // 
            this.tbxRMSMin.Font = new System.Drawing.Font("华文新魏", 11F);
            this.tbxRMSMin.FontStyle = null;
            this.tbxRMSMin.Location = new System.Drawing.Point(83, 71);
            this.tbxRMSMin.Name = "tbxRMSMin";
            this.tbxRMSMin.Size = new System.Drawing.Size(208, 26);
            this.tbxRMSMin.TabIndex = 265;
            this.tbxRMSMin.TextInfo = "";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("华文新魏", 11F);
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.label2.Location = new System.Drawing.Point(10, 79);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 16);
            this.label2.TabIndex = 264;
            this.label2.Text = "误差下限:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("华文新魏", 11F);
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.label3.Location = new System.Drawing.Point(10, 113);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 16);
            this.label3.TabIndex = 262;
            this.label3.Text = "误差上限:";
            // 
            // cbxPointNum
            // 
            this.cbxPointNum.BackColor = System.Drawing.Color.AliceBlue;
            this.cbxPointNum.DropDownStyle = Rex.UI.UIDropDownStyle.DropDownList;
            this.cbxPointNum.FillColor = System.Drawing.Color.AliceBlue;
            this.cbxPointNum.FillDisableColor = System.Drawing.Color.Silver;
            this.cbxPointNum.Font = new System.Drawing.Font("华文新魏", 11.6F);
            this.cbxPointNum.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.cbxPointNum.ForeDisableColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.cbxPointNum.Items.AddRange(new object[] {
            "4",
            "9",
            "16"});
            this.cbxPointNum.Location = new System.Drawing.Point(83, 39);
            this.cbxPointNum.Margin = new System.Windows.Forms.Padding(0);
            this.cbxPointNum.MinimumSize = new System.Drawing.Size(63, 0);
            this.cbxPointNum.Name = "cbxPointNum";
            this.cbxPointNum.Padding = new System.Windows.Forms.Padding(0, 0, 30, 0);
            this.cbxPointNum.Radius = 2;
            this.cbxPointNum.RectColor = System.Drawing.Color.CornflowerBlue;
            this.cbxPointNum.RectDisableColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.cbxPointNum.RectSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.None;
            this.cbxPointNum.Size = new System.Drawing.Size(208, 24);
            this.cbxPointNum.Style = Rex.UI.UIStyle.Custom;
            this.cbxPointNum.StyleCustomMode = true;
            this.cbxPointNum.SymbolDropDown = 61656;
            this.cbxPointNum.SymbolNormal = 61655;
            this.cbxPointNum.TabIndex = 257;
            this.cbxPointNum.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.cbxPointNum.SelectedIndexChanged += new System.EventHandler(this.cbxPointNum_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("华文新魏", 11F);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.label1.Location = new System.Drawing.Point(10, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 16);
            this.label1.TabIndex = 191;
            this.label1.Text = "矩阵点数:";
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.White;
            this.tabPage2.Controls.Add(this.uiTitlePanel2);
            this.tabPage2.Location = new System.Drawing.Point(0, 26);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Size = new System.Drawing.Size(303, 459);
            this.tabPage2.TabIndex = 3;
            this.tabPage2.Text = "保存设置";
            // 
            // uiTitlePanel2
            // 
            this.uiTitlePanel2.Controls.Add(this.tableLayoutPanel4);
            this.uiTitlePanel2.Controls.Add(this.label14);
            this.uiTitlePanel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.uiTitlePanel2.FillColor = System.Drawing.Color.White;
            this.uiTitlePanel2.FillDisableColor = System.Drawing.Color.White;
            this.uiTitlePanel2.Font = new System.Drawing.Font("华文新魏", 12F);
            this.uiTitlePanel2.ForeColor = System.Drawing.Color.White;
            this.uiTitlePanel2.Location = new System.Drawing.Point(0, 0);
            this.uiTitlePanel2.Margin = new System.Windows.Forms.Padding(0);
            this.uiTitlePanel2.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiTitlePanel2.Name = "uiTitlePanel2";
            this.uiTitlePanel2.Padding = new System.Windows.Forms.Padding(0, 35, 0, 0);
            this.uiTitlePanel2.RadiusSides = Rex.UI.UICornerRadiusSides.None;
            this.uiTitlePanel2.RectColor = System.Drawing.Color.White;
            this.uiTitlePanel2.Size = new System.Drawing.Size(303, 99);
            this.uiTitlePanel2.Style = Rex.UI.UIStyle.Custom;
            this.uiTitlePanel2.TabIndex = 197;
            this.uiTitlePanel2.Text = "保存设置";
            this.uiTitlePanel2.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.uiTitlePanel2.TitleColor = System.Drawing.Color.CornflowerBlue;
            this.uiTitlePanel2.TitleInterval = 6;
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.BackColor = System.Drawing.Color.AliceBlue;
            this.tableLayoutPanel4.ColumnCount = 2;
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 86.76471F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 13.23529F));
            this.tableLayoutPanel4.Controls.Add(this.tbxSavePath, 0, 0);
            this.tableLayoutPanel4.Controls.Add(this.btnSavePathLink, 1, 0);
            this.tableLayoutPanel4.Location = new System.Drawing.Point(86, 37);
            this.tableLayoutPanel4.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 1;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tableLayoutPanel4.Size = new System.Drawing.Size(203, 25);
            this.tableLayoutPanel4.TabIndex = 203;
            // 
            // tbxSavePath
            // 
            this.tbxSavePath.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbxSavePath.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbxSavePath.Font = new System.Drawing.Font("华文新魏", 10F);
            this.tbxSavePath.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.tbxSavePath.Location = new System.Drawing.Point(3, 3);
            this.tbxSavePath.Multiline = false;
            this.tbxSavePath.Name = "tbxSavePath";
            this.tbxSavePath.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None;
            this.tbxSavePath.Size = new System.Drawing.Size(170, 19);
            this.tbxSavePath.TabIndex = 0;
            this.tbxSavePath.Text = "";
            // 
            // btnSavePathLink
            // 
            this.btnSavePathLink.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSavePathLink.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnSavePathLink.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            this.btnSavePathLink.FlatAppearance.BorderSize = 0;
            this.btnSavePathLink.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            this.btnSavePathLink.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            this.btnSavePathLink.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSavePathLink.Image = ((System.Drawing.Image)(resources.GetObject("btnSavePathLink.Image")));
            this.btnSavePathLink.Location = new System.Drawing.Point(179, 3);
            this.btnSavePathLink.Name = "btnSavePathLink";
            this.btnSavePathLink.Size = new System.Drawing.Size(21, 19);
            this.btnSavePathLink.TabIndex = 1;
            this.btnSavePathLink.UseVisualStyleBackColor = true;
            this.btnSavePathLink.Click += new System.EventHandler(this.btnSavePathLink_Click);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.BackColor = System.Drawing.Color.Transparent;
            this.label14.Font = new System.Drawing.Font("华文新魏", 11F);
            this.label14.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.label14.Location = new System.Drawing.Point(10, 43);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(73, 16);
            this.label14.TabIndex = 193;
            this.label14.Text = "保存路径:";
            // 
            // dgv_PointList
            // 
            this.dgv_PointList.AllowUserToAddRows = false;
            this.dgv_PointList.AllowUserToDeleteRows = false;
            this.dgv_PointList.AllowUserToResizeColumns = false;
            this.dgv_PointList.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(251)))), ((int)(((byte)(251)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("华文新魏", 11F);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.GhostWhite;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.dgv_PointList.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgv_PointList.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_PointList.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(251)))), ((int)(((byte)(251)))));
            this.dgv_PointList.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgv_PointList.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dgv_PointList.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.CornflowerBlue;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("华文新魏", 11.5F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.CornflowerBlue;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_PointList.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgv_PointList.ColumnHeadersHeight = 24;
            this.dgv_PointList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgv_PointList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Index,
            this.Column4,
            this.Column6,
            this.Column7,
            this.RobotY});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(251)))), ((int)(((byte)(251)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("华文新魏", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.GhostWhite;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv_PointList.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgv_PointList.Dock = System.Windows.Forms.DockStyle.Left;
            this.dgv_PointList.EnableHeadersVisualStyles = false;
            this.dgv_PointList.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.dgv_PointList.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(251)))), ((int)(((byte)(251)))));
            this.dgv_PointList.Location = new System.Drawing.Point(304, 1);
            this.dgv_PointList.Margin = new System.Windows.Forms.Padding(0);
            this.dgv_PointList.MultiSelect = false;
            this.dgv_PointList.Name = "dgv_PointList";
            this.dgv_PointList.RectColor = System.Drawing.Color.White;
            this.dgv_PointList.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(251)))), ((int)(((byte)(251)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("华文新魏", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.PowderBlue;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_PointList.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dgv_PointList.RowHeadersVisible = false;
            this.dgv_PointList.RowHeadersWidth = 29;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(251)))), ((int)(((byte)(251)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("华文新魏", 11F);
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.GhostWhite;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.dgv_PointList.RowsDefaultCellStyle = dataGridViewCellStyle5;
            this.dgv_PointList.RowTemplate.Height = 30;
            this.dgv_PointList.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dgv_PointList.SelectedIndex = -1;
            this.dgv_PointList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_PointList.ShowRect = false;
            this.dgv_PointList.Size = new System.Drawing.Size(519, 485);
            this.dgv_PointList.StripeEvenColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(251)))), ((int)(((byte)(251)))));
            this.dgv_PointList.StripeOddColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(251)))), ((int)(((byte)(251)))));
            this.dgv_PointList.Style = Rex.UI.UIStyle.Custom;
            this.dgv_PointList.StyleCustomMode = true;
            this.dgv_PointList.TabIndex = 59;
            this.dgv_PointList.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_PointList_CellDoubleClick);
            this.dgv_PointList.CellPainting += new System.Windows.Forms.DataGridViewCellPaintingEventHandler(this.dgv_CellPainting);
            // 
            // Index
            // 
            this.Index.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Index.FillWeight = 55.83753F;
            this.Index.HeaderText = "序号";
            this.Index.Name = "Index";
            // 
            // Column4
            // 
            this.Column4.DataPropertyName = "ImageX";
            this.Column4.FillWeight = 111.0405F;
            this.Column4.HeaderText = "图像坐标X";
            this.Column4.Name = "Column4";
            // 
            // Column6
            // 
            this.Column6.DataPropertyName = "ImageY";
            this.Column6.FillWeight = 111.0405F;
            this.Column6.HeaderText = "图像坐标Y";
            this.Column6.Name = "Column6";
            // 
            // Column7
            // 
            this.Column7.DataPropertyName = "RobotX";
            this.Column7.FillWeight = 111.0405F;
            this.Column7.HeaderText = "机械坐标X";
            this.Column7.Name = "Column7";
            // 
            // RobotY
            // 
            this.RobotY.FillWeight = 111.0405F;
            this.RobotY.HeaderText = "机械坐标Y";
            this.RobotY.Name = "RobotY";
            // 
            // btnShowResult
            // 
            this.btnShowResult.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnShowResult.FillColor = System.Drawing.Color.White;
            this.btnShowResult.FillDisableColor = System.Drawing.Color.White;
            this.btnShowResult.FillHoverColor = System.Drawing.Color.White;
            this.btnShowResult.FillPressColor = System.Drawing.Color.White;
            this.btnShowResult.FillSelectedColor = System.Drawing.Color.White;
            this.btnShowResult.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.btnShowResult.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.btnShowResult.ForeDisableColor = System.Drawing.Color.CornflowerBlue;
            this.btnShowResult.ForeHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(130)))), ((int)(((byte)(190)))), ((int)(((byte)(255)))));
            this.btnShowResult.ForePressColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(109)))), ((int)(((byte)(180)))));
            this.btnShowResult.ForeSelectedColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(109)))), ((int)(((byte)(180)))));
            this.btnShowResult.Location = new System.Drawing.Point(826, 216);
            this.btnShowResult.MinimumSize = new System.Drawing.Size(1, 1);
            this.btnShowResult.Name = "btnShowResult";
            this.btnShowResult.RadiusSides = Rex.UI.UICornerRadiusSides.None;
            this.btnShowResult.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.btnShowResult.RectDisableColor = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.btnShowResult.RectHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.btnShowResult.RectPressColor = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.btnShowResult.RectSelectedColor = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.btnShowResult.RectSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.None;
            this.btnShowResult.Size = new System.Drawing.Size(14, 39);
            this.btnShowResult.Style = Rex.UI.UIStyle.Custom;
            this.btnShowResult.StyleCustomMode = true;
            this.btnShowResult.Symbol = 61524;
            this.btnShowResult.TabIndex = 145;
            this.btnShowResult.TipsColor = System.Drawing.Color.White;
            this.btnShowResult.Click += new System.EventHandler(this.btnShowResult_Click);
            // 
            // NinePointsCalibForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(848, 548);
            this.Name = "NinePointsCalibForm";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.NinePointsCalibForm_FormClosed);
            this.LocationChanged += new System.EventHandler(this.NinePointsCalibForm_LocationChanged);
            this.panel_bottom.ResumeLayout(false);
            this.panel_center.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbox_Icon)).EndInit();
            this.titlepanel.ResumeLayout(false);
            this.titlepanel.PerformLayout();
            this.uiTabControl1.ResumeLayout(false);
            this.tabPage3.ResumeLayout(false);
            this.pnl2.ResumeLayout(false);
            this.pnl2.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.uiTitlePanel2.ResumeLayout(false);
            this.uiTitlePanel2.PerformLayout();
            this.tableLayoutPanel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_PointList)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private Rex.UI.UITabControl uiTabControl1;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TabPage tabPage2;
        private Rex.UI.UITitlePanel uiTitlePanel2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
        private RexControl.MyControls.TextBoxEx tbxSavePath;
        private System.Windows.Forms.Button btnSavePathLink;
        private System.Windows.Forms.Label label14;
        private Rex.UI.UIDataGridView dgv_PointList;
        private System.Windows.Forms.DataGridViewTextBoxColumn Index;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.DataGridViewTextBoxColumn RobotY;
        private Rex.UI.UITitlePanel pnl2;
        private Rex.UI.MyComboBox cbxPointNum;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private RexControl.MyControls.MyTextBoxUpDownD tbxRMSMax;
        private RexControl.MyControls.MyTextBoxUpDownD tbxRMSMin;
        private System.Windows.Forms.Label label4;
        private Rex.UI.UISymbolButton btnShowResult;
    }
}