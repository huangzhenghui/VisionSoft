namespace Plugin.CaptureImage
{
    partial class CaptureImageForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CaptureImageForm));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.OpenImage = new System.Windows.Forms.OpenFileDialog();
            this.uiTabControl1 = new Rex.UI.UITabControl();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.pnlCam = new Rex.UI.UITitlePanel();
            this.cbxSelectCam = new Rex.UI.MyComboBox();
            this.label15 = new System.Windows.Forms.Label();
            this.pnlCatalog = new Rex.UI.UITitlePanel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.tbxFolderPath = new RexControl.MyControls.TextBoxEx();
            this.btnFolderPath = new System.Windows.Forms.Button();
            this.dgvImage = new Rex.UI.UIDataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.chxForRead = new Rex.UI.UICheckBox();
            this.pnlImage = new Rex.UI.UITitlePanel();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.tbxImagePath = new RexControl.MyControls.TextBoxEx();
            this.btnImagePath = new System.Windows.Forms.Button();
            this.uiTitlePanel2 = new Rex.UI.UITitlePanel();
            this.rbCam = new Rex.UI.UIRadioButton();
            this.rbFolder = new Rex.UI.UIRadioButton();
            this.rbImage = new Rex.UI.UIRadioButton();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.uiTitlePanel4 = new Rex.UI.UITitlePanel();
            this.chxUsePiexlPrec = new Rex.UI.UICheckBox();
            this.ldPiexlPrec = new RexControl.MyControls.MyLinkData();
            this.lblPixelProc = new System.Windows.Forms.Label();
            this.uiTitlePanel3 = new Rex.UI.UITitlePanel();
            this.cbxImgProcMode = new Rex.UI.MyComboBox();
            this.label11 = new System.Windows.Forms.Label();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.uiTitlePanel5 = new Rex.UI.UITitlePanel();
            this.btnZeroIdx = new Rex.UI.UISymbolButton();
            this.label13 = new System.Windows.Forms.Label();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.uiTitlePanel1 = new Rex.UI.UITitlePanel();
            this.cbxFontStye = new Rex.UI.MyComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.chxShowData = new Rex.UI.UICheckBox();
            this.tbxY = new RexControl.MyControls.MyTextBoxUpDownD();
            this.tbxFontSize = new RexControl.MyControls.MyTextBoxUpDown();
            this.label12 = new System.Windows.Forms.Label();
            this.tbxX = new RexControl.MyControls.MyTextBoxUpDownD();
            this.label8 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.tbxPrefix = new Rex.UI.UITextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.cpColor = new Rex.UI.UIColorPicker();
            this.uiTitlePanel8 = new Rex.UI.UITitlePanel();
            this.cbxSelectScreen = new Rex.UI.MyComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.mWindowH = new RexView.HWindow_HE();
            this.panel_bottom.SuspendLayout();
            this.panel_center.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbox_Icon)).BeginInit();
            this.titlepanel.SuspendLayout();
            this.uiTabControl1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.pnlCam.SuspendLayout();
            this.pnlCatalog.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvImage)).BeginInit();
            this.pnlImage.SuspendLayout();
            this.tableLayoutPanel4.SuspendLayout();
            this.uiTitlePanel2.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.uiTitlePanel4.SuspendLayout();
            this.uiTitlePanel3.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.uiTitlePanel5.SuspendLayout();
            this.tabPage4.SuspendLayout();
            this.uiTitlePanel1.SuspendLayout();
            this.uiTitlePanel8.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_Run
            // 
            this.btn_Run.Click += new System.EventHandler(this.btn_Run_Click);
            // 
            // panel_center
            // 
            this.panel_center.Controls.Add(this.mWindowH);
            this.panel_center.Controls.Add(this.uiTabControl1);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label1.Location = new System.Drawing.Point(14, 122);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 17);
            this.label1.TabIndex = 40;
            this.label1.Text = "测量标定:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label3.Location = new System.Drawing.Point(14, 35);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 17);
            this.label3.TabIndex = 11;
            this.label3.Text = "选择相机:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label4.Location = new System.Drawing.Point(34, 99);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 17);
            this.label4.TabIndex = 185;
            this.label4.Text = "大小:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label2.Location = new System.Drawing.Point(34, 159);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 17);
            this.label2.TabIndex = 181;
            this.label2.Text = "颜色:";
            // 
            // OpenImage
            // 
            this.OpenImage.FileName = "OpenImage";
            // 
            // uiTabControl1
            // 
            this.uiTabControl1.Controls.Add(this.tabPage2);
            this.uiTabControl1.Controls.Add(this.tabPage1);
            this.uiTabControl1.Controls.Add(this.tabPage3);
            this.uiTabControl1.Controls.Add(this.tabPage4);
            this.uiTabControl1.Dock = System.Windows.Forms.DockStyle.Left;
            this.uiTabControl1.DrawMode = System.Windows.Forms.TabDrawMode.OwnerDrawFixed;
            this.uiTabControl1.Font = new System.Drawing.Font("华文新魏", 12F);
            this.uiTabControl1.ItemSize = new System.Drawing.Size(85, 26);
            this.uiTabControl1.Location = new System.Drawing.Point(2, 1);
            this.uiTabControl1.MenuStyle = Rex.UI.UIMenuStyle.Custom;
            this.uiTabControl1.Name = "uiTabControl1";
            this.uiTabControl1.Padding = new System.Drawing.Point(3, 3);
            this.uiTabControl1.SelectedIndex = 0;
            this.uiTabControl1.Size = new System.Drawing.Size(303, 487);
            this.uiTabControl1.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.uiTabControl1.Style = Rex.UI.UIStyle.Custom;
            this.uiTabControl1.TabBackColor = System.Drawing.Color.White;
            this.uiTabControl1.TabIndex = 16;
            this.uiTabControl1.TabSelectedColor = System.Drawing.Color.White;
            this.uiTabControl1.TabSelectedForeColor = System.Drawing.Color.CornflowerBlue;
            this.uiTabControl1.TabSelectedHighColor = System.Drawing.Color.White;
            this.uiTabControl1.TabUnSelectedForeColor = System.Drawing.Color.Silver;
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.White;
            this.tabPage2.Controls.Add(this.pnlCam);
            this.tabPage2.Controls.Add(this.pnlCatalog);
            this.tabPage2.Controls.Add(this.pnlImage);
            this.tabPage2.Controls.Add(this.uiTitlePanel2);
            this.tabPage2.Font = new System.Drawing.Font("隶书", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tabPage2.Location = new System.Drawing.Point(0, 26);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Size = new System.Drawing.Size(303, 461);
            this.tabPage2.TabIndex = 0;
            this.tabPage2.Text = "基本设置";
            // 
            // pnlCam
            // 
            this.pnlCam.BackColor = System.Drawing.Color.White;
            this.pnlCam.Controls.Add(this.cbxSelectCam);
            this.pnlCam.Controls.Add(this.label15);
            this.pnlCam.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlCam.FillColor = System.Drawing.Color.White;
            this.pnlCam.Font = new System.Drawing.Font("华文新魏", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.pnlCam.ForeColor = System.Drawing.Color.White;
            this.pnlCam.Location = new System.Drawing.Point(0, 444);
            this.pnlCam.Margin = new System.Windows.Forms.Padding(0);
            this.pnlCam.MinimumSize = new System.Drawing.Size(1, 1);
            this.pnlCam.Name = "pnlCam";
            this.pnlCam.Padding = new System.Windows.Forms.Padding(0, 35, 0, 0);
            this.pnlCam.RadiusSides = Rex.UI.UICornerRadiusSides.None;
            this.pnlCam.RectColor = System.Drawing.Color.White;
            this.pnlCam.Size = new System.Drawing.Size(303, 73);
            this.pnlCam.Style = Rex.UI.UIStyle.Custom;
            this.pnlCam.StyleCustomMode = true;
            this.pnlCam.TabIndex = 45;
            this.pnlCam.Text = "相机模式";
            this.pnlCam.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.pnlCam.TitleColor = System.Drawing.Color.CornflowerBlue;
            this.pnlCam.TitleInterval = 5;
            // 
            // cbxSelectCam
            // 
            this.cbxSelectCam.BackColor = System.Drawing.Color.AliceBlue;
            this.cbxSelectCam.DropDownStyle = Rex.UI.UIDropDownStyle.DropDownList;
            this.cbxSelectCam.FillColor = System.Drawing.Color.AliceBlue;
            this.cbxSelectCam.Font = new System.Drawing.Font("华文新魏", 11F);
            this.cbxSelectCam.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.cbxSelectCam.ForeDisableColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.cbxSelectCam.Items.AddRange(new object[] {
            "None",
            "1号屏显示",
            "2号屏显示",
            "3号屏显示",
            "4号屏显示",
            "5号屏显示",
            "6号屏显示",
            "7号屏显示",
            "8号屏显示",
            "9号屏显示"});
            this.cbxSelectCam.Location = new System.Drawing.Point(83, 35);
            this.cbxSelectCam.Margin = new System.Windows.Forms.Padding(0);
            this.cbxSelectCam.MinimumSize = new System.Drawing.Size(61, 0);
            this.cbxSelectCam.Name = "cbxSelectCam";
            this.cbxSelectCam.Padding = new System.Windows.Forms.Padding(0, 0, 30, 0);
            this.cbxSelectCam.Radius = 2;
            this.cbxSelectCam.RectColor = System.Drawing.Color.CornflowerBlue;
            this.cbxSelectCam.RectDisableColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.cbxSelectCam.RectSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.None;
            this.cbxSelectCam.Size = new System.Drawing.Size(207, 23);
            this.cbxSelectCam.Style = Rex.UI.UIStyle.Custom;
            this.cbxSelectCam.StyleCustomMode = true;
            this.cbxSelectCam.SymbolDropDown = 61656;
            this.cbxSelectCam.SymbolNormal = 61655;
            this.cbxSelectCam.TabIndex = 203;
            this.cbxSelectCam.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.BackColor = System.Drawing.Color.Transparent;
            this.label15.Font = new System.Drawing.Font("华文新魏", 11F);
            this.label15.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.label15.Location = new System.Drawing.Point(9, 39);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(73, 16);
            this.label15.TabIndex = 38;
            this.label15.Text = "相机选择:";
            // 
            // pnlCatalog
            // 
            this.pnlCatalog.Controls.Add(this.tableLayoutPanel2);
            this.pnlCatalog.Controls.Add(this.dgvImage);
            this.pnlCatalog.Controls.Add(this.chxForRead);
            this.pnlCatalog.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlCatalog.FillColor = System.Drawing.Color.White;
            this.pnlCatalog.Font = new System.Drawing.Font("华文新魏", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.pnlCatalog.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            this.pnlCatalog.Location = new System.Drawing.Point(0, 125);
            this.pnlCatalog.Margin = new System.Windows.Forms.Padding(0);
            this.pnlCatalog.MinimumSize = new System.Drawing.Size(1, 1);
            this.pnlCatalog.Name = "pnlCatalog";
            this.pnlCatalog.Padding = new System.Windows.Forms.Padding(0, 35, 0, 0);
            this.pnlCatalog.RadiusSides = Rex.UI.UICornerRadiusSides.None;
            this.pnlCatalog.RectColor = System.Drawing.Color.White;
            this.pnlCatalog.Size = new System.Drawing.Size(303, 319);
            this.pnlCatalog.Style = Rex.UI.UIStyle.Custom;
            this.pnlCatalog.TabIndex = 43;
            this.pnlCatalog.Text = "文件目录";
            this.pnlCatalog.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.pnlCatalog.TextAlignment = System.Drawing.ContentAlignment.MiddleRight;
            this.pnlCatalog.TitleColor = System.Drawing.Color.CornflowerBlue;
            this.pnlCatalog.TitleInterval = 5;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.BackColor = System.Drawing.Color.AliceBlue;
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 89.18919F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10.81081F));
            this.tableLayoutPanel2.Controls.Add(this.tbxFolderPath, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.btnFolderPath, 1, 0);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(74, 31);
            this.tableLayoutPanel2.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 23F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(222, 23);
            this.tableLayoutPanel2.TabIndex = 17;
            // 
            // tbxFolderPath
            // 
            this.tbxFolderPath.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbxFolderPath.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbxFolderPath.Font = new System.Drawing.Font("华文新魏", 10F);
            this.tbxFolderPath.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.tbxFolderPath.Location = new System.Drawing.Point(3, 3);
            this.tbxFolderPath.Multiline = false;
            this.tbxFolderPath.Name = "tbxFolderPath";
            this.tbxFolderPath.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None;
            this.tbxFolderPath.Size = new System.Drawing.Size(192, 17);
            this.tbxFolderPath.TabIndex = 0;
            this.tbxFolderPath.Text = "";
            // 
            // btnFolderPath
            // 
            this.btnFolderPath.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnFolderPath.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnFolderPath.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            this.btnFolderPath.FlatAppearance.BorderSize = 0;
            this.btnFolderPath.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            this.btnFolderPath.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            this.btnFolderPath.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFolderPath.Image = ((System.Drawing.Image)(resources.GetObject("btnFolderPath.Image")));
            this.btnFolderPath.Location = new System.Drawing.Point(201, 3);
            this.btnFolderPath.Name = "btnFolderPath";
            this.btnFolderPath.Size = new System.Drawing.Size(18, 17);
            this.btnFolderPath.TabIndex = 1;
            this.btnFolderPath.UseVisualStyleBackColor = true;
            this.btnFolderPath.Click += new System.EventHandler(this.cliAreaBtn_Click);
            // 
            // dgvImage
            // 
            this.dgvImage.AllowUserToAddRows = false;
            this.dgvImage.AllowUserToDeleteRows = false;
            this.dgvImage.AllowUserToResizeColumns = false;
            this.dgvImage.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("华文新魏", 9.5F);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.LightCyan;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.dgvImage.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvImage.BackgroundColor = System.Drawing.Color.White;
            this.dgvImage.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.AliceBlue;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("华文新魏", 11F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvImage.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvImage.ColumnHeadersHeight = 25;
            this.dgvImage.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("华文新魏", 9.5F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.AliceBlue;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvImage.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvImage.EnableHeadersVisualStyles = false;
            this.dgvImage.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.dgvImage.GridColor = System.Drawing.Color.White;
            this.dgvImage.Location = new System.Drawing.Point(0, 58);
            this.dgvImage.MultiSelect = false;
            this.dgvImage.Name = "dgvImage";
            this.dgvImage.ReadOnly = true;
            this.dgvImage.RectColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("华文新魏", 11F);
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvImage.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvImage.RowHeadersVisible = false;
            this.dgvImage.RowHeadersWidth = 25;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("华文新魏", 9.5F);
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.LightCyan;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.dgvImage.RowsDefaultCellStyle = dataGridViewCellStyle5;
            this.dgvImage.RowTemplate.Height = 35;
            this.dgvImage.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dgvImage.SelectedIndex = -1;
            this.dgvImage.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvImage.ShowGridLine = true;
            this.dgvImage.Size = new System.Drawing.Size(303, 261);
            this.dgvImage.StripeOddColor = System.Drawing.Color.White;
            this.dgvImage.Style = Rex.UI.UIStyle.Custom;
            this.dgvImage.StyleCustomMode = true;
            this.dgvImage.TabIndex = 50;
            this.dgvImage.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvImage_CellClick);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.FillWeight = 1F;
            this.dataGridViewTextBoxColumn1.HeaderText = "索引";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewTextBoxColumn1.Width = 44;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn2.FillWeight = 2F;
            this.dataGridViewTextBoxColumn2.HeaderText = "名称";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            this.dataGridViewTextBoxColumn2.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // chxForRead
            // 
            this.chxForRead.BackColor = System.Drawing.Color.White;
            this.chxForRead.Checked = true;
            this.chxForRead.Cursor = System.Windows.Forms.Cursors.Hand;
            this.chxForRead.Font = new System.Drawing.Font("华文新魏", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.chxForRead.ImageSize = 14;
            this.chxForRead.Location = new System.Drawing.Point(9, 36);
            this.chxForRead.MinimumSize = new System.Drawing.Size(1, 1);
            this.chxForRead.Name = "chxForRead";
            this.chxForRead.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.chxForRead.Size = new System.Drawing.Size(62, 16);
            this.chxForRead.Style = Rex.UI.UIStyle.Custom;
            this.chxForRead.TabIndex = 16;
            this.chxForRead.Text = "循环";
            // 
            // pnlImage
            // 
            this.pnlImage.Controls.Add(this.tableLayoutPanel4);
            this.pnlImage.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlImage.FillColor = System.Drawing.Color.White;
            this.pnlImage.Font = new System.Drawing.Font("华文新魏", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.pnlImage.ForeColor = System.Drawing.Color.White;
            this.pnlImage.Location = new System.Drawing.Point(0, 63);
            this.pnlImage.Margin = new System.Windows.Forms.Padding(0);
            this.pnlImage.MinimumSize = new System.Drawing.Size(1, 1);
            this.pnlImage.Name = "pnlImage";
            this.pnlImage.Padding = new System.Windows.Forms.Padding(0, 25, 0, 0);
            this.pnlImage.RadiusSides = Rex.UI.UICornerRadiusSides.None;
            this.pnlImage.RectColor = System.Drawing.Color.White;
            this.pnlImage.Size = new System.Drawing.Size(303, 62);
            this.pnlImage.Style = Rex.UI.UIStyle.Custom;
            this.pnlImage.TabIndex = 17;
            this.pnlImage.Text = "图像路径";
            this.pnlImage.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.pnlImage.TitleColor = System.Drawing.Color.CornflowerBlue;
            this.pnlImage.TitleInterval = 5;
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.BackColor = System.Drawing.Color.AliceBlue;
            this.tableLayoutPanel4.ColumnCount = 2;
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 91.00346F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 8.99654F));
            this.tableLayoutPanel4.Controls.Add(this.tbxImagePath, 0, 0);
            this.tableLayoutPanel4.Controls.Add(this.btnImagePath, 1, 0);
            this.tableLayoutPanel4.Location = new System.Drawing.Point(9, 33);
            this.tableLayoutPanel4.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 1;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 23F));
            this.tableLayoutPanel4.Size = new System.Drawing.Size(287, 23);
            this.tableLayoutPanel4.TabIndex = 1;
            this.tableLayoutPanel4.Paint += new System.Windows.Forms.PaintEventHandler(this.tableLayoutPanel4_Paint);
            // 
            // tbxImagePath
            // 
            this.tbxImagePath.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbxImagePath.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbxImagePath.Font = new System.Drawing.Font("华文新魏", 10F);
            this.tbxImagePath.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.tbxImagePath.Location = new System.Drawing.Point(3, 3);
            this.tbxImagePath.Multiline = false;
            this.tbxImagePath.Name = "tbxImagePath";
            this.tbxImagePath.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None;
            this.tbxImagePath.Size = new System.Drawing.Size(255, 17);
            this.tbxImagePath.TabIndex = 0;
            this.tbxImagePath.Text = "";
            // 
            // btnImagePath
            // 
            this.btnImagePath.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnImagePath.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnImagePath.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            this.btnImagePath.FlatAppearance.BorderSize = 0;
            this.btnImagePath.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            this.btnImagePath.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            this.btnImagePath.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnImagePath.Image = ((System.Drawing.Image)(resources.GetObject("btnImagePath.Image")));
            this.btnImagePath.Location = new System.Drawing.Point(264, 3);
            this.btnImagePath.Name = "btnImagePath";
            this.btnImagePath.Size = new System.Drawing.Size(20, 17);
            this.btnImagePath.TabIndex = 1;
            this.btnImagePath.UseVisualStyleBackColor = true;
            this.btnImagePath.Click += new System.EventHandler(this.cliAreaBtn_Click);
            // 
            // uiTitlePanel2
            // 
            this.uiTitlePanel2.Controls.Add(this.rbCam);
            this.uiTitlePanel2.Controls.Add(this.rbFolder);
            this.uiTitlePanel2.Controls.Add(this.rbImage);
            this.uiTitlePanel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.uiTitlePanel2.FillColor = System.Drawing.Color.White;
            this.uiTitlePanel2.Font = new System.Drawing.Font("华文新魏", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uiTitlePanel2.ForeColor = System.Drawing.Color.White;
            this.uiTitlePanel2.Location = new System.Drawing.Point(0, 0);
            this.uiTitlePanel2.Margin = new System.Windows.Forms.Padding(0);
            this.uiTitlePanel2.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiTitlePanel2.Name = "uiTitlePanel2";
            this.uiTitlePanel2.Padding = new System.Windows.Forms.Padding(3, 25, 3, 0);
            this.uiTitlePanel2.RadiusSides = Rex.UI.UICornerRadiusSides.None;
            this.uiTitlePanel2.RectColor = System.Drawing.Color.White;
            this.uiTitlePanel2.Size = new System.Drawing.Size(303, 63);
            this.uiTitlePanel2.Style = Rex.UI.UIStyle.Custom;
            this.uiTitlePanel2.TabIndex = 14;
            this.uiTitlePanel2.Text = "采集模式";
            this.uiTitlePanel2.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.uiTitlePanel2.TextAlignment = System.Drawing.ContentAlignment.BottomCenter;
            this.uiTitlePanel2.TitleColor = System.Drawing.Color.CornflowerBlue;
            this.uiTitlePanel2.TitleInterval = 5;
            // 
            // rbCam
            // 
            this.rbCam.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rbCam.Font = new System.Drawing.Font("华文新魏", 11F);
            this.rbCam.Location = new System.Drawing.Point(209, 35);
            this.rbCam.MinimumSize = new System.Drawing.Size(1, 1);
            this.rbCam.Name = "rbCam";
            this.rbCam.Padding = new System.Windows.Forms.Padding(22, 0, 0, 0);
            this.rbCam.Size = new System.Drawing.Size(87, 20);
            this.rbCam.Style = Rex.UI.UIStyle.Custom;
            this.rbCam.TabIndex = 2;
            this.rbCam.Text = "相机采集";
            this.rbCam.ValueChanged += new Rex.UI.UIRadioButton.OnValueChanged(this.rb_ValueChanged);
            // 
            // rbFolder
            // 
            this.rbFolder.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rbFolder.Font = new System.Drawing.Font("华文新魏", 11F);
            this.rbFolder.Location = new System.Drawing.Point(109, 35);
            this.rbFolder.MinimumSize = new System.Drawing.Size(1, 1);
            this.rbFolder.Name = "rbFolder";
            this.rbFolder.Padding = new System.Windows.Forms.Padding(22, 0, 0, 0);
            this.rbFolder.Size = new System.Drawing.Size(87, 20);
            this.rbFolder.Style = Rex.UI.UIStyle.Custom;
            this.rbFolder.TabIndex = 1;
            this.rbFolder.Text = "文件目录";
            this.rbFolder.ValueChanged += new Rex.UI.UIRadioButton.OnValueChanged(this.rb_ValueChanged);
            // 
            // rbImage
            // 
            this.rbImage.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rbImage.Font = new System.Drawing.Font("华文新魏", 11F);
            this.rbImage.Location = new System.Drawing.Point(9, 35);
            this.rbImage.MinimumSize = new System.Drawing.Size(1, 1);
            this.rbImage.Name = "rbImage";
            this.rbImage.Padding = new System.Windows.Forms.Padding(22, 0, 0, 0);
            this.rbImage.Size = new System.Drawing.Size(87, 20);
            this.rbImage.Style = Rex.UI.UIStyle.Custom;
            this.rbImage.TabIndex = 0;
            this.rbImage.Text = "指定图像";
            this.rbImage.ValueChanged += new Rex.UI.UIRadioButton.OnValueChanged(this.rb_ValueChanged);
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.uiTitlePanel4);
            this.tabPage1.Controls.Add(this.uiTitlePanel3);
            this.tabPage1.Location = new System.Drawing.Point(0, 26);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Size = new System.Drawing.Size(450, 244);
            this.tabPage1.TabIndex = 2;
            this.tabPage1.Text = "处理设置";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // uiTitlePanel4
            // 
            this.uiTitlePanel4.Controls.Add(this.chxUsePiexlPrec);
            this.uiTitlePanel4.Controls.Add(this.ldPiexlPrec);
            this.uiTitlePanel4.Controls.Add(this.lblPixelProc);
            this.uiTitlePanel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.uiTitlePanel4.FillColor = System.Drawing.Color.White;
            this.uiTitlePanel4.Font = new System.Drawing.Font("华文新魏", 12F);
            this.uiTitlePanel4.ForeColor = System.Drawing.Color.White;
            this.uiTitlePanel4.Location = new System.Drawing.Point(0, 74);
            this.uiTitlePanel4.Margin = new System.Windows.Forms.Padding(0);
            this.uiTitlePanel4.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiTitlePanel4.Name = "uiTitlePanel4";
            this.uiTitlePanel4.Padding = new System.Windows.Forms.Padding(3, 25, 3, 0);
            this.uiTitlePanel4.RadiusSides = Rex.UI.UICornerRadiusSides.None;
            this.uiTitlePanel4.RectColor = System.Drawing.Color.White;
            this.uiTitlePanel4.Size = new System.Drawing.Size(450, 113);
            this.uiTitlePanel4.Style = Rex.UI.UIStyle.Custom;
            this.uiTitlePanel4.TabIndex = 216;
            this.uiTitlePanel4.Text = "像素当量";
            this.uiTitlePanel4.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.uiTitlePanel4.TextAlignment = System.Drawing.ContentAlignment.BottomCenter;
            this.uiTitlePanel4.TitleColor = System.Drawing.Color.CornflowerBlue;
            this.uiTitlePanel4.TitleInterval = 5;
            // 
            // chxUsePiexlPrec
            // 
            this.chxUsePiexlPrec.BackColor = System.Drawing.Color.White;
            this.chxUsePiexlPrec.Checked = true;
            this.chxUsePiexlPrec.Cursor = System.Windows.Forms.Cursors.Hand;
            this.chxUsePiexlPrec.Font = new System.Drawing.Font("华文新魏", 11F);
            this.chxUsePiexlPrec.ImageSize = 14;
            this.chxUsePiexlPrec.Location = new System.Drawing.Point(10, 35);
            this.chxUsePiexlPrec.MinimumSize = new System.Drawing.Size(1, 1);
            this.chxUsePiexlPrec.Name = "chxUsePiexlPrec";
            this.chxUsePiexlPrec.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.chxUsePiexlPrec.Size = new System.Drawing.Size(211, 31);
            this.chxUsePiexlPrec.Style = Rex.UI.UIStyle.Custom;
            this.chxUsePiexlPrec.TabIndex = 237;
            this.chxUsePiexlPrec.Text = "启用像素当量";
            this.chxUsePiexlPrec.ValueChanged += new Rex.UI.UICheckBox.OnValueChanged(this.chxUsePiexlPrec_ValueChanged);
            // 
            // ldPiexlPrec
            // 
            this.ldPiexlPrec.BackColor = System.Drawing.Color.AliceBlue;
            this.ldPiexlPrec.Font = new System.Drawing.Font("华文新魏", 11F);
            this.ldPiexlPrec.FontStyle = new System.Drawing.Font("华文新魏", 10.5F);
            this.ldPiexlPrec.Location = new System.Drawing.Point(87, 72);
            this.ldPiexlPrec.Margin = new System.Windows.Forms.Padding(2, 9, 4, 4);
            this.ldPiexlPrec.Name = "ldPiexlPrec";
            this.ldPiexlPrec.Size = new System.Drawing.Size(204, 23);
            this.ldPiexlPrec.TabIndex = 236;
            this.ldPiexlPrec.TextInfo = "";
            this.ldPiexlPrec.LinkData += new System.EventHandler(this.ldData_LinkData);
            // 
            // lblPixelProc
            // 
            this.lblPixelProc.AutoSize = true;
            this.lblPixelProc.BackColor = System.Drawing.Color.Transparent;
            this.lblPixelProc.Font = new System.Drawing.Font("华文新魏", 11F);
            this.lblPixelProc.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.lblPixelProc.Location = new System.Drawing.Point(10, 76);
            this.lblPixelProc.Name = "lblPixelProc";
            this.lblPixelProc.Size = new System.Drawing.Size(73, 16);
            this.lblPixelProc.TabIndex = 235;
            this.lblPixelProc.Text = "像素当量:";
            // 
            // uiTitlePanel3
            // 
            this.uiTitlePanel3.Controls.Add(this.cbxImgProcMode);
            this.uiTitlePanel3.Controls.Add(this.label11);
            this.uiTitlePanel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.uiTitlePanel3.FillColor = System.Drawing.Color.White;
            this.uiTitlePanel3.Font = new System.Drawing.Font("华文新魏", 12F);
            this.uiTitlePanel3.ForeColor = System.Drawing.Color.White;
            this.uiTitlePanel3.Location = new System.Drawing.Point(0, 0);
            this.uiTitlePanel3.Margin = new System.Windows.Forms.Padding(0);
            this.uiTitlePanel3.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiTitlePanel3.Name = "uiTitlePanel3";
            this.uiTitlePanel3.Padding = new System.Windows.Forms.Padding(3, 25, 3, 0);
            this.uiTitlePanel3.RadiusSides = Rex.UI.UICornerRadiusSides.None;
            this.uiTitlePanel3.RectColor = System.Drawing.Color.White;
            this.uiTitlePanel3.Size = new System.Drawing.Size(450, 74);
            this.uiTitlePanel3.Style = Rex.UI.UIStyle.Custom;
            this.uiTitlePanel3.TabIndex = 215;
            this.uiTitlePanel3.Text = "图像处理";
            this.uiTitlePanel3.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.uiTitlePanel3.TextAlignment = System.Drawing.ContentAlignment.BottomCenter;
            this.uiTitlePanel3.TitleColor = System.Drawing.Color.CornflowerBlue;
            this.uiTitlePanel3.TitleInterval = 5;
            // 
            // cbxImgProcMode
            // 
            this.cbxImgProcMode.BackColor = System.Drawing.Color.AliceBlue;
            this.cbxImgProcMode.DropDownStyle = Rex.UI.UIDropDownStyle.DropDownList;
            this.cbxImgProcMode.FillColor = System.Drawing.Color.AliceBlue;
            this.cbxImgProcMode.Font = new System.Drawing.Font("华文新魏", 11F);
            this.cbxImgProcMode.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.cbxImgProcMode.ForeDisableColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.cbxImgProcMode.Items.AddRange(new object[] {
            "无",
            "旋转90度",
            "旋转180度",
            "旋转270度",
            "X镜像",
            "Y镜像"});
            this.cbxImgProcMode.Location = new System.Drawing.Point(86, 40);
            this.cbxImgProcMode.Margin = new System.Windows.Forms.Padding(0);
            this.cbxImgProcMode.MinimumSize = new System.Drawing.Size(63, 0);
            this.cbxImgProcMode.Name = "cbxImgProcMode";
            this.cbxImgProcMode.Padding = new System.Windows.Forms.Padding(0, 0, 30, 0);
            this.cbxImgProcMode.Radius = 2;
            this.cbxImgProcMode.RectColor = System.Drawing.Color.CornflowerBlue;
            this.cbxImgProcMode.RectDisableColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.cbxImgProcMode.RectSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.None;
            this.cbxImgProcMode.Size = new System.Drawing.Size(203, 23);
            this.cbxImgProcMode.Style = Rex.UI.UIStyle.Custom;
            this.cbxImgProcMode.StyleCustomMode = true;
            this.cbxImgProcMode.SymbolDropDown = 61656;
            this.cbxImgProcMode.SymbolNormal = 61655;
            this.cbxImgProcMode.TabIndex = 234;
            this.cbxImgProcMode.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.Transparent;
            this.label11.Font = new System.Drawing.Font("华文新魏", 11F);
            this.label11.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.label11.Location = new System.Drawing.Point(10, 45);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(73, 16);
            this.label11.TabIndex = 191;
            this.label11.Text = "图像变换:";
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.uiTitlePanel5);
            this.tabPage3.Location = new System.Drawing.Point(0, 26);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(450, 244);
            this.tabPage3.TabIndex = 3;
            this.tabPage3.Text = "编辑设置";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // uiTitlePanel5
            // 
            this.uiTitlePanel5.Controls.Add(this.btnZeroIdx);
            this.uiTitlePanel5.Controls.Add(this.label13);
            this.uiTitlePanel5.Dock = System.Windows.Forms.DockStyle.Top;
            this.uiTitlePanel5.FillColor = System.Drawing.Color.White;
            this.uiTitlePanel5.Font = new System.Drawing.Font("华文新魏", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uiTitlePanel5.ForeColor = System.Drawing.Color.White;
            this.uiTitlePanel5.Location = new System.Drawing.Point(0, 0);
            this.uiTitlePanel5.Margin = new System.Windows.Forms.Padding(0);
            this.uiTitlePanel5.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiTitlePanel5.Name = "uiTitlePanel5";
            this.uiTitlePanel5.Padding = new System.Windows.Forms.Padding(0, 25, 0, 0);
            this.uiTitlePanel5.RadiusSides = Rex.UI.UICornerRadiusSides.None;
            this.uiTitlePanel5.RectColor = System.Drawing.Color.White;
            this.uiTitlePanel5.Size = new System.Drawing.Size(450, 84);
            this.uiTitlePanel5.Style = Rex.UI.UIStyle.Custom;
            this.uiTitlePanel5.TabIndex = 209;
            this.uiTitlePanel5.Text = "编辑设置";
            this.uiTitlePanel5.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.uiTitlePanel5.TitleColor = System.Drawing.Color.CornflowerBlue;
            this.uiTitlePanel5.TitleInterval = 5;
            // 
            // btnZeroIdx
            // 
            this.btnZeroIdx.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnZeroIdx.Font = new System.Drawing.Font("华文新魏", 12F);
            this.btnZeroIdx.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            this.btnZeroIdx.ForeHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            this.btnZeroIdx.ForePressColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            this.btnZeroIdx.ForeSelectedColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            this.btnZeroIdx.Location = new System.Drawing.Point(87, 40);
            this.btnZeroIdx.MinimumSize = new System.Drawing.Size(1, 1);
            this.btnZeroIdx.Name = "btnZeroIdx";
            this.btnZeroIdx.Size = new System.Drawing.Size(204, 21);
            this.btnZeroIdx.Style = Rex.UI.UIStyle.Custom;
            this.btnZeroIdx.Symbol = 61732;
            this.btnZeroIdx.TabIndex = 208;
            this.btnZeroIdx.Text = "执行";
            this.btnZeroIdx.Click += new System.EventHandler(this.btnZeroIdx_Click);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.BackColor = System.Drawing.Color.Transparent;
            this.label13.Font = new System.Drawing.Font("华文新魏", 11F);
            this.label13.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.label13.Location = new System.Drawing.Point(11, 43);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(73, 16);
            this.label13.TabIndex = 234;
            this.label13.Text = "适应图像:";
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.uiTitlePanel1);
            this.tabPage4.Controls.Add(this.uiTitlePanel8);
            this.tabPage4.Location = new System.Drawing.Point(0, 26);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Size = new System.Drawing.Size(450, 244);
            this.tabPage4.TabIndex = 1;
            this.tabPage4.Text = "显示设置";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // uiTitlePanel1
            // 
            this.uiTitlePanel1.Controls.Add(this.cbxFontStye);
            this.uiTitlePanel1.Controls.Add(this.label5);
            this.uiTitlePanel1.Controls.Add(this.chxShowData);
            this.uiTitlePanel1.Controls.Add(this.tbxY);
            this.uiTitlePanel1.Controls.Add(this.tbxFontSize);
            this.uiTitlePanel1.Controls.Add(this.label12);
            this.uiTitlePanel1.Controls.Add(this.tbxX);
            this.uiTitlePanel1.Controls.Add(this.label8);
            this.uiTitlePanel1.Controls.Add(this.label10);
            this.uiTitlePanel1.Controls.Add(this.tbxPrefix);
            this.uiTitlePanel1.Controls.Add(this.label14);
            this.uiTitlePanel1.Controls.Add(this.label7);
            this.uiTitlePanel1.Controls.Add(this.cpColor);
            this.uiTitlePanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.uiTitlePanel1.FillColor = System.Drawing.Color.White;
            this.uiTitlePanel1.Font = new System.Drawing.Font("华文新魏", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uiTitlePanel1.ForeColor = System.Drawing.Color.White;
            this.uiTitlePanel1.Location = new System.Drawing.Point(0, 62);
            this.uiTitlePanel1.Margin = new System.Windows.Forms.Padding(0);
            this.uiTitlePanel1.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiTitlePanel1.Name = "uiTitlePanel1";
            this.uiTitlePanel1.Padding = new System.Windows.Forms.Padding(0, 25, 0, 0);
            this.uiTitlePanel1.RadiusSides = Rex.UI.UICornerRadiusSides.None;
            this.uiTitlePanel1.RectColor = System.Drawing.Color.White;
            this.uiTitlePanel1.Size = new System.Drawing.Size(450, 395);
            this.uiTitlePanel1.Style = Rex.UI.UIStyle.Custom;
            this.uiTitlePanel1.TabIndex = 196;
            this.uiTitlePanel1.Text = "显示设置";
            this.uiTitlePanel1.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.uiTitlePanel1.TitleColor = System.Drawing.Color.CornflowerBlue;
            this.uiTitlePanel1.TitleInterval = 5;
            // 
            // cbxFontStye
            // 
            this.cbxFontStye.BackColor = System.Drawing.Color.AliceBlue;
            this.cbxFontStye.DropDownStyle = Rex.UI.UIDropDownStyle.DropDownList;
            this.cbxFontStye.FillColor = System.Drawing.Color.AliceBlue;
            this.cbxFontStye.Font = new System.Drawing.Font("华文新魏", 11F);
            this.cbxFontStye.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.cbxFontStye.ForeDisableColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.cbxFontStye.Location = new System.Drawing.Point(81, 177);
            this.cbxFontStye.Margin = new System.Windows.Forms.Padding(0);
            this.cbxFontStye.MinimumSize = new System.Drawing.Size(63, 0);
            this.cbxFontStye.Name = "cbxFontStye";
            this.cbxFontStye.Padding = new System.Windows.Forms.Padding(0, 0, 30, 0);
            this.cbxFontStye.Radius = 2;
            this.cbxFontStye.RectColor = System.Drawing.Color.CornflowerBlue;
            this.cbxFontStye.RectDisableColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.cbxFontStye.RectSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.None;
            this.cbxFontStye.Size = new System.Drawing.Size(204, 23);
            this.cbxFontStye.Style = Rex.UI.UIStyle.Custom;
            this.cbxFontStye.StyleCustomMode = true;
            this.cbxFontStye.SymbolDropDown = 61656;
            this.cbxFontStye.SymbolNormal = 61655;
            this.cbxFontStye.TabIndex = 233;
            this.cbxFontStye.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("华文新魏", 11F);
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.label5.Location = new System.Drawing.Point(8, 181);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(73, 16);
            this.label5.TabIndex = 232;
            this.label5.Text = "字体样式:";
            // 
            // chxShowData
            // 
            this.chxShowData.BackColor = System.Drawing.Color.White;
            this.chxShowData.Checked = true;
            this.chxShowData.Cursor = System.Windows.Forms.Cursors.Hand;
            this.chxShowData.Font = new System.Drawing.Font("华文新魏", 11F);
            this.chxShowData.ImageSize = 14;
            this.chxShowData.Location = new System.Drawing.Point(10, 34);
            this.chxShowData.MinimumSize = new System.Drawing.Size(1, 1);
            this.chxShowData.Name = "chxShowData";
            this.chxShowData.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.chxShowData.Size = new System.Drawing.Size(211, 31);
            this.chxShowData.Style = Rex.UI.UIStyle.Custom;
            this.chxShowData.TabIndex = 231;
            this.chxShowData.Text = "显示数据";
            // 
            // tbxY
            // 
            this.tbxY.Font = new System.Drawing.Font("华文新魏", 11F);
            this.tbxY.FontStyle = null;
            this.tbxY.Location = new System.Drawing.Point(81, 106);
            this.tbxY.Name = "tbxY";
            this.tbxY.Size = new System.Drawing.Size(204, 26);
            this.tbxY.TabIndex = 230;
            this.tbxY.TextInfo = "";
            // 
            // tbxFontSize
            // 
            this.tbxFontSize.BackColor = System.Drawing.Color.White;
            this.tbxFontSize.Font = new System.Drawing.Font("华文新魏", 11.5F);
            this.tbxFontSize.FontStyle = null;
            this.tbxFontSize.Location = new System.Drawing.Point(81, 142);
            this.tbxFontSize.Name = "tbxFontSize";
            this.tbxFontSize.Size = new System.Drawing.Size(204, 25);
            this.tbxFontSize.TabIndex = 229;
            this.tbxFontSize.TextInfo = "";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.Color.Transparent;
            this.label12.Font = new System.Drawing.Font("华文新魏", 11F);
            this.label12.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.label12.Location = new System.Drawing.Point(8, 148);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(73, 16);
            this.label12.TabIndex = 228;
            this.label12.Text = "字体大小:";
            // 
            // tbxX
            // 
            this.tbxX.Font = new System.Drawing.Font("华文新魏", 11F);
            this.tbxX.FontStyle = null;
            this.tbxX.Location = new System.Drawing.Point(81, 70);
            this.tbxX.Name = "tbxX";
            this.tbxX.Size = new System.Drawing.Size(204, 26);
            this.tbxX.TabIndex = 227;
            this.tbxX.TextInfo = "";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("华文新魏", 11F);
            this.label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.label8.Location = new System.Drawing.Point(8, 112);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(52, 16);
            this.label8.TabIndex = 225;
            this.label8.Text = "位置Y:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.Font = new System.Drawing.Font("华文新魏", 11F);
            this.label10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.label10.Location = new System.Drawing.Point(8, 76);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(53, 16);
            this.label10.TabIndex = 224;
            this.label10.Text = "位置X:";
            // 
            // tbxPrefix
            // 
            this.tbxPrefix.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbxPrefix.FillColor = System.Drawing.Color.AliceBlue;
            this.tbxPrefix.FillDisableColor = System.Drawing.Color.AliceBlue;
            this.tbxPrefix.Font = new System.Drawing.Font("华文新魏", 11F);
            this.tbxPrefix.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.tbxPrefix.Location = new System.Drawing.Point(81, 210);
            this.tbxPrefix.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tbxPrefix.Maximum = 2147483647D;
            this.tbxPrefix.Minimum = -2147483648D;
            this.tbxPrefix.MinimumSize = new System.Drawing.Size(1, 1);
            this.tbxPrefix.Name = "tbxPrefix";
            this.tbxPrefix.Padding = new System.Windows.Forms.Padding(5);
            this.tbxPrefix.Radius = 20;
            this.tbxPrefix.RadiusSides = Rex.UI.UICornerRadiusSides.None;
            this.tbxPrefix.RectColor = System.Drawing.Color.AliceBlue;
            this.tbxPrefix.RectSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.Bottom;
            this.tbxPrefix.Size = new System.Drawing.Size(204, 23);
            this.tbxPrefix.Style = Rex.UI.UIStyle.Custom;
            this.tbxPrefix.StyleCustomMode = true;
            this.tbxPrefix.TabIndex = 205;
            this.tbxPrefix.Watermark = "";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.BackColor = System.Drawing.Color.Transparent;
            this.label14.Font = new System.Drawing.Font("华文新魏", 11F);
            this.label14.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.label14.Location = new System.Drawing.Point(8, 213);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(73, 16);
            this.label14.TabIndex = 204;
            this.label14.Text = "信息前缀:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("华文新魏", 11F);
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.label7.Location = new System.Drawing.Point(8, 246);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(73, 16);
            this.label7.TabIndex = 201;
            this.label7.Text = "字体颜色:";
            // 
            // cpColor
            // 
            this.cpColor.DropDownStyle = Rex.UI.UIDropDownStyle.DropDownList;
            this.cpColor.FillColor = System.Drawing.Color.AliceBlue;
            this.cpColor.FillDisableColor = System.Drawing.Color.AliceBlue;
            this.cpColor.Font = new System.Drawing.Font("微软雅黑", 9F);
            this.cpColor.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.cpColor.Location = new System.Drawing.Point(81, 243);
            this.cpColor.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cpColor.MinimumSize = new System.Drawing.Size(63, 0);
            this.cpColor.Name = "cpColor";
            this.cpColor.Padding = new System.Windows.Forms.Padding(0, 0, 30, 0);
            this.cpColor.RadiusSides = Rex.UI.UICornerRadiusSides.None;
            this.cpColor.RectColor = System.Drawing.Color.White;
            this.cpColor.RectSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.Bottom;
            this.cpColor.Size = new System.Drawing.Size(204, 23);
            this.cpColor.Style = Rex.UI.UIStyle.Custom;
            this.cpColor.StyleCustomMode = true;
            this.cpColor.TabIndex = 200;
            this.cpColor.Text = "uiColorPicker1";
            this.cpColor.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.cpColor.Value = System.Drawing.Color.DodgerBlue;
            // 
            // uiTitlePanel8
            // 
            this.uiTitlePanel8.Controls.Add(this.cbxSelectScreen);
            this.uiTitlePanel8.Controls.Add(this.label9);
            this.uiTitlePanel8.Dock = System.Windows.Forms.DockStyle.Top;
            this.uiTitlePanel8.FillColor = System.Drawing.Color.White;
            this.uiTitlePanel8.Font = new System.Drawing.Font("华文新魏", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uiTitlePanel8.ForeColor = System.Drawing.Color.White;
            this.uiTitlePanel8.Location = new System.Drawing.Point(0, 0);
            this.uiTitlePanel8.Margin = new System.Windows.Forms.Padding(0);
            this.uiTitlePanel8.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiTitlePanel8.Name = "uiTitlePanel8";
            this.uiTitlePanel8.Padding = new System.Windows.Forms.Padding(0, 25, 0, 0);
            this.uiTitlePanel8.RadiusSides = Rex.UI.UICornerRadiusSides.None;
            this.uiTitlePanel8.RectColor = System.Drawing.Color.White;
            this.uiTitlePanel8.Size = new System.Drawing.Size(450, 62);
            this.uiTitlePanel8.Style = Rex.UI.UIStyle.Custom;
            this.uiTitlePanel8.TabIndex = 190;
            this.uiTitlePanel8.Text = "窗口选择";
            this.uiTitlePanel8.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.uiTitlePanel8.TitleColor = System.Drawing.Color.CornflowerBlue;
            this.uiTitlePanel8.TitleInterval = 5;
            // 
            // cbxSelectScreen
            // 
            this.cbxSelectScreen.BackColor = System.Drawing.Color.AliceBlue;
            this.cbxSelectScreen.DropDownStyle = Rex.UI.UIDropDownStyle.DropDownList;
            this.cbxSelectScreen.FillColor = System.Drawing.Color.AliceBlue;
            this.cbxSelectScreen.Font = new System.Drawing.Font("华文新魏", 11F);
            this.cbxSelectScreen.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.cbxSelectScreen.ForeDisableColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.cbxSelectScreen.Items.AddRange(new object[] {
            "None",
            "1号屏显示",
            "2号屏显示",
            "3号屏显示",
            "4号屏显示",
            "5号屏显示",
            "6号屏显示",
            "7号屏显示",
            "8号屏显示",
            "9号屏显示"});
            this.cbxSelectScreen.Location = new System.Drawing.Point(80, 33);
            this.cbxSelectScreen.Margin = new System.Windows.Forms.Padding(0);
            this.cbxSelectScreen.MinimumSize = new System.Drawing.Size(63, 0);
            this.cbxSelectScreen.Name = "cbxSelectScreen";
            this.cbxSelectScreen.Padding = new System.Windows.Forms.Padding(0, 0, 30, 0);
            this.cbxSelectScreen.Radius = 2;
            this.cbxSelectScreen.RectColor = System.Drawing.Color.CornflowerBlue;
            this.cbxSelectScreen.RectDisableColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.cbxSelectScreen.RectSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.None;
            this.cbxSelectScreen.Size = new System.Drawing.Size(205, 23);
            this.cbxSelectScreen.Style = Rex.UI.UIStyle.Custom;
            this.cbxSelectScreen.StyleCustomMode = true;
            this.cbxSelectScreen.SymbolDropDown = 61656;
            this.cbxSelectScreen.SymbolNormal = 61655;
            this.cbxSelectScreen.TabIndex = 202;
            this.cbxSelectScreen.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("华文新魏", 11F);
            this.label9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.label9.Location = new System.Drawing.Point(6, 38);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(73, 16);
            this.label9.TabIndex = 38;
            this.label9.Text = "屏幕编号:";
            // 
            // mWindowH
            // 
            this.mWindowH.BackColor = System.Drawing.Color.Transparent;
            this.mWindowH.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.mWindowH.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mWindowH.DrawModel = false;
            this.mWindowH.Font = new System.Drawing.Font("华文新魏", 12.5F);
            this.mWindowH.Image = null;
            this.mWindowH.Location = new System.Drawing.Point(305, 1);
            this.mWindowH.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.mWindowH.Name = "mWindowH";
            this.mWindowH.Padding = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.mWindowH.Size = new System.Drawing.Size(542, 487);
            this.mWindowH.TabIndex = 17;
            // 
            // CaptureImageForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(850, 550);
            this.Font = new System.Drawing.Font("华文新魏", 11F);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "CaptureImageForm";
            this.Load += new System.EventHandler(this.CameraForm_Load);
            this.panel_bottom.ResumeLayout(false);
            this.panel_center.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbox_Icon)).EndInit();
            this.titlepanel.ResumeLayout(false);
            this.titlepanel.PerformLayout();
            this.uiTabControl1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.pnlCam.ResumeLayout(false);
            this.pnlCam.PerformLayout();
            this.pnlCatalog.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvImage)).EndInit();
            this.pnlImage.ResumeLayout(false);
            this.tableLayoutPanel4.ResumeLayout(false);
            this.uiTitlePanel2.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.uiTitlePanel4.ResumeLayout(false);
            this.uiTitlePanel4.PerformLayout();
            this.uiTitlePanel3.ResumeLayout(false);
            this.uiTitlePanel3.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.uiTitlePanel5.ResumeLayout(false);
            this.uiTitlePanel5.PerformLayout();
            this.tabPage4.ResumeLayout(false);
            this.uiTitlePanel1.ResumeLayout(false);
            this.uiTitlePanel1.PerformLayout();
            this.uiTitlePanel8.ResumeLayout(false);
            this.uiTitlePanel8.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.OpenFileDialog OpenImage;
        private Rex.UI.UITabControl uiTabControl1;
        private System.Windows.Forms.TabPage tabPage2;
        private Rex.UI.UITitlePanel pnlCatalog;
        private Rex.UI.UIDataGridView dgvImage;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private Rex.UI.UICheckBox chxForRead;
        private Rex.UI.UITitlePanel pnlImage;
        private Rex.UI.UITitlePanel uiTitlePanel2;
        private Rex.UI.UIRadioButton rbCam;
        private Rex.UI.UIRadioButton rbFolder;
        private Rex.UI.UIRadioButton rbImage;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
        private RexControl.MyControls.TextBoxEx tbxImagePath;
        private System.Windows.Forms.Button btnImagePath;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private RexControl.MyControls.TextBoxEx tbxFolderPath;
        private System.Windows.Forms.Button btnFolderPath;
        private Rex.UI.UITitlePanel uiTitlePanel8;
        private System.Windows.Forms.Label label9;
        private RexView.HWindow_HE mWindowH;
        private Rex.UI.MyComboBox cbxSelectScreen;
        private Rex.UI.UITitlePanel pnlCam;
        private Rex.UI.MyComboBox cbxSelectCam;
        private System.Windows.Forms.Label label15;
        private Rex.UI.UITitlePanel uiTitlePanel1;
        private Rex.UI.MyComboBox cbxFontStye;
        private System.Windows.Forms.Label label5;
        private Rex.UI.UICheckBox chxShowData;
        private RexControl.MyControls.MyTextBoxUpDownD tbxY;
        private RexControl.MyControls.MyTextBoxUpDown tbxFontSize;
        private System.Windows.Forms.Label label12;
        private RexControl.MyControls.MyTextBoxUpDownD tbxX;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label10;
        private Rex.UI.UITextBox tbxPrefix;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label7;
        private Rex.UI.UIColorPicker cpColor;
        private System.Windows.Forms.TabPage tabPage1;
        private Rex.UI.UITitlePanel uiTitlePanel3;
        private System.Windows.Forms.Label label11;
        private Rex.UI.MyComboBox cbxImgProcMode;
        private Rex.UI.UITitlePanel uiTitlePanel4;
        private RexControl.MyControls.MyLinkData ldPiexlPrec;
        private System.Windows.Forms.Label lblPixelProc;
        private Rex.UI.UICheckBox chxUsePiexlPrec;
        private System.Windows.Forms.TabPage tabPage3;
        private Rex.UI.UITitlePanel uiTitlePanel5;
        private Rex.UI.UISymbolButton btnZeroIdx;
        private System.Windows.Forms.Label label13;
    }
}