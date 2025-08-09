
namespace TSIVision.FrmConfigR
{
    partial class FrmConfigCam
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmConfigCam));
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnAdd = new Rex.UI.UIButton();
            this.btnRemove = new Rex.UI.UIButton();
            this.cbxCamSelect = new Rex.UI.UIComboBox();
            this.cbxCamType = new Rex.UI.UIComboBox();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.uiPnl = new Rex.UI.UIPanel();
            this.dgvCamList = new Rex.UI.UIDataGridView();
            this.m_DeviceID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.m_SerialNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.m_CameraIP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.m_ExposureTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.m_Gain = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.m_width = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.m_Height = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.m_bConnected = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1 = new System.Windows.Forms.Panel();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.btnPageChange = new Rex.UI.UIButton();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.uiPnl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCamList)).BeginInit();
            this.panel1.SuspendLayout();
            this.tableLayoutPanel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel3, 0, 2);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 4;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 2.999943F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15.33224F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 72.28801F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 9.379821F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1065, 643);
            this.tableLayoutPanel1.TabIndex = 48;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 10;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 17.39045F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.21595F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 4.196321F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.77547F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.94638F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 8.619864F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 1.495283F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 8.619864F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 13.20023F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 6.54017F));
            this.tableLayoutPanel2.Controls.Add(this.label3, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.label4, 3, 0);
            this.tableLayoutPanel2.Controls.Add(this.btnAdd, 5, 1);
            this.tableLayoutPanel2.Controls.Add(this.btnRemove, 7, 1);
            this.tableLayoutPanel2.Controls.Add(this.cbxCamSelect, 3, 2);
            this.tableLayoutPanel2.Controls.Add(this.cbxCamType, 1, 2);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 22);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 3;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 45.88127F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 2.999929F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 51.1188F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(1059, 92);
            this.tableLayoutPanel2.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label3.Font = new System.Drawing.Font("华文新魏", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label3.ImageAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.label3.Location = new System.Drawing.Point(187, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(123, 42);
            this.label3.TabIndex = 40;
            this.label3.Text = "相机型号:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label4.Font = new System.Drawing.Font("华文新魏", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label4.Location = new System.Drawing.Point(360, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(129, 42);
            this.label4.TabIndex = 42;
            this.label4.Text = "相机选择:";
            this.label4.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // btnAdd
            // 
            this.btnAdd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAdd.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnAdd.FillColor = System.Drawing.Color.Navy;
            this.btnAdd.FillHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(55)))), ((int)(((byte)(130)))));
            this.btnAdd.FillPressColor = System.Drawing.Color.CadetBlue;
            this.btnAdd.Font = new System.Drawing.Font("华文新魏", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnAdd.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            this.btnAdd.ForeHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            this.btnAdd.ForePressColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            this.btnAdd.ForeSelectedColor = System.Drawing.Color.Black;
            this.btnAdd.Location = new System.Drawing.Point(653, 45);
            this.btnAdd.MinimumSize = new System.Drawing.Size(1, 1);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Radius = 15;
            this.btnAdd.RectColor = System.Drawing.Color.Transparent;
            this.btnAdd.RectHoverColor = System.Drawing.Color.Lavender;
            this.btnAdd.RectPressColor = System.Drawing.Color.Honeydew;
            this.btnAdd.RectSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.None;
            this.tableLayoutPanel2.SetRowSpan(this.btnAdd, 2);
            this.btnAdd.Size = new System.Drawing.Size(85, 38);
            this.btnAdd.Style = Rex.UI.UIStyle.Custom;
            this.btnAdd.TabIndex = 0;
            this.btnAdd.Text = "添加";
            this.btnAdd.Click += new System.EventHandler(this.btn_Click);
            // 
            // btnRemove
            // 
            this.btnRemove.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRemove.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnRemove.FillColor = System.Drawing.Color.Navy;
            this.btnRemove.FillHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(55)))), ((int)(((byte)(130)))));
            this.btnRemove.FillPressColor = System.Drawing.Color.CadetBlue;
            this.btnRemove.Font = new System.Drawing.Font("华文新魏", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnRemove.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            this.btnRemove.ForeHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            this.btnRemove.ForePressColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            this.btnRemove.ForeSelectedColor = System.Drawing.Color.Black;
            this.btnRemove.Location = new System.Drawing.Point(759, 45);
            this.btnRemove.MinimumSize = new System.Drawing.Size(1, 1);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Radius = 15;
            this.btnRemove.RectColor = System.Drawing.Color.Transparent;
            this.btnRemove.RectHoverColor = System.Drawing.Color.Lavender;
            this.btnRemove.RectPressColor = System.Drawing.Color.Honeydew;
            this.btnRemove.RectSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.None;
            this.tableLayoutPanel2.SetRowSpan(this.btnRemove, 2);
            this.btnRemove.Size = new System.Drawing.Size(85, 38);
            this.btnRemove.Style = Rex.UI.UIStyle.Custom;
            this.btnRemove.TabIndex = 51;
            this.btnRemove.Text = "删除";
            this.btnRemove.Click += new System.EventHandler(this.btn_Click);
            // 
            // cbxCamSelect
            // 
            this.cbxCamSelect.Dock = System.Windows.Forms.DockStyle.Top;
            this.cbxCamSelect.DropDownStyle = Rex.UI.UIDropDownStyle.DropDownList;
            this.cbxCamSelect.FillColor = System.Drawing.Color.Navy;
            this.cbxCamSelect.Font = new System.Drawing.Font("华文新魏", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.cbxCamSelect.ForeColor = System.Drawing.Color.White;
            this.cbxCamSelect.Location = new System.Drawing.Point(360, 50);
            this.cbxCamSelect.Margin = new System.Windows.Forms.Padding(3, 6, 3, 3);
            this.cbxCamSelect.MinimumSize = new System.Drawing.Size(63, 0);
            this.cbxCamSelect.Name = "cbxCamSelect";
            this.cbxCamSelect.Padding = new System.Windows.Forms.Padding(0, 0, 30, 0);
            this.cbxCamSelect.Radius = 15;
            this.cbxCamSelect.RectColor = System.Drawing.Color.White;
            this.cbxCamSelect.Size = new System.Drawing.Size(129, 27);
            this.cbxCamSelect.Style = Rex.UI.UIStyle.Custom;
            this.cbxCamSelect.StyleCustomMode = true;
            this.cbxCamSelect.TabIndex = 54;
            this.cbxCamSelect.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // cbxCamType
            // 
            this.cbxCamType.Dock = System.Windows.Forms.DockStyle.Top;
            this.cbxCamType.DropDownStyle = Rex.UI.UIDropDownStyle.DropDownList;
            this.cbxCamType.FillColor = System.Drawing.Color.Navy;
            this.cbxCamType.Font = new System.Drawing.Font("华文新魏", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.cbxCamType.ForeColor = System.Drawing.Color.White;
            this.cbxCamType.Location = new System.Drawing.Point(187, 50);
            this.cbxCamType.Margin = new System.Windows.Forms.Padding(3, 6, 3, 3);
            this.cbxCamType.MinimumSize = new System.Drawing.Size(63, 0);
            this.cbxCamType.Name = "cbxCamType";
            this.cbxCamType.Padding = new System.Windows.Forms.Padding(0, 0, 30, 0);
            this.cbxCamType.Radius = 15;
            this.cbxCamType.RectColor = System.Drawing.Color.White;
            this.cbxCamType.Size = new System.Drawing.Size(123, 27);
            this.cbxCamType.Style = Rex.UI.UIStyle.Custom;
            this.cbxCamType.StyleCustomMode = true;
            this.cbxCamType.TabIndex = 55;
            this.cbxCamType.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.cbxCamType.SelectedIndexChanged += new System.EventHandler(this.cbxCamType_SelectedIndexChanged);
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 3;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 4.766402F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 90.47169F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 4.761905F));
            this.tableLayoutPanel3.Controls.Add(this.uiPnl, 1, 0);
            this.tableLayoutPanel3.Controls.Add(this.panel1, 2, 0);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(3, 120);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 1;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(1059, 458);
            this.tableLayoutPanel3.TabIndex = 3;
            // 
            // uiPnl
            // 
            this.uiPnl.Controls.Add(this.dgvCamList);
            this.uiPnl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.uiPnl.FillColor = System.Drawing.Color.Lavender;
            this.uiPnl.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.uiPnl.Location = new System.Drawing.Point(54, 3);
            this.uiPnl.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.uiPnl.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiPnl.Name = "uiPnl";
            this.uiPnl.Padding = new System.Windows.Forms.Padding(2);
            this.uiPnl.Radius = 15;
            this.uiPnl.RectColor = System.Drawing.Color.Lavender;
            this.uiPnl.Size = new System.Drawing.Size(950, 452);
            this.uiPnl.Style = Rex.UI.UIStyle.Custom;
            this.uiPnl.TabIndex = 7;
            this.uiPnl.Text = null;
            // 
            // dgvCamList
            // 
            this.dgvCamList.AllowUserToAddRows = false;
            this.dgvCamList.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Lavender;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("华文新魏", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.AliceBlue;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black;
            this.dgvCamList.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvCamList.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvCamList.BackgroundColor = System.Drawing.Color.Lavender;
            this.dgvCamList.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.Lavender;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("华文新魏", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Navy;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.Lavender;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Navy;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvCamList.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvCamList.ColumnHeadersHeight = 25;
            this.dgvCamList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.m_DeviceID,
            this.m_SerialNo,
            this.m_CameraIP,
            this.m_ExposureTime,
            this.m_Gain,
            this.m_width,
            this.m_Height,
            this.m_bConnected});
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("华文新魏", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(200)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvCamList.DefaultCellStyle = dataGridViewCellStyle5;
            this.dgvCamList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvCamList.EnableHeadersVisualStyles = false;
            this.dgvCamList.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.dgvCamList.GridColor = System.Drawing.Color.Lavender;
            this.dgvCamList.Location = new System.Drawing.Point(2, 2);
            this.dgvCamList.MultiSelect = false;
            this.dgvCamList.Name = "dgvCamList";
            this.dgvCamList.ReadOnly = true;
            this.dgvCamList.RectColor = System.Drawing.Color.Lavender;
            this.dgvCamList.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle6.Font = new System.Drawing.Font("隶书", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvCamList.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.dgvCamList.RowHeadersVisible = false;
            this.dgvCamList.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.Lavender;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("华文新魏", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.AliceBlue;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.Color.Black;
            this.dgvCamList.RowsDefaultCellStyle = dataGridViewCellStyle7;
            this.dgvCamList.RowTemplate.DefaultCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.dgvCamList.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.Color.Lavender;
            this.dgvCamList.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("华文新魏", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.dgvCamList.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.Black;
            this.dgvCamList.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.Azure;
            this.dgvCamList.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.Black;
            this.dgvCamList.RowTemplate.Height = 29;
            this.dgvCamList.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvCamList.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dgvCamList.SelectedIndex = -1;
            this.dgvCamList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvCamList.ShowGridLine = true;
            this.dgvCamList.Size = new System.Drawing.Size(946, 448);
            this.dgvCamList.StripeEvenColor = System.Drawing.Color.Lavender;
            this.dgvCamList.StripeOddColor = System.Drawing.Color.Lavender;
            this.dgvCamList.Style = Rex.UI.UIStyle.Custom;
            this.dgvCamList.StyleCustomMode = true;
            this.dgvCamList.TabIndex = 33;
            this.dgvCamList.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvCamList_CellClick);
            this.dgvCamList.CellPainting += new System.Windows.Forms.DataGridViewCellPaintingEventHandler(this.dgv_CellPainting);
            this.dgvCamList.MouseDown += new System.Windows.Forms.MouseEventHandler(this.dgvCamList_MouseDown);
            this.dgvCamList.MouseUp += new System.Windows.Forms.MouseEventHandler(this.dgvCamList_MouseUp);
            // 
            // m_DeviceID
            // 
            this.m_DeviceID.DataPropertyName = "mCamName";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.m_DeviceID.DefaultCellStyle = dataGridViewCellStyle3;
            this.m_DeviceID.FillWeight = 73.19897F;
            this.m_DeviceID.HeaderText = "名称";
            this.m_DeviceID.Name = "m_DeviceID";
            this.m_DeviceID.ReadOnly = true;
            // 
            // m_SerialNo
            // 
            this.m_SerialNo.DataPropertyName = "mSerialNo";
            this.m_SerialNo.FillWeight = 74.57155F;
            this.m_SerialNo.HeaderText = "序列号";
            this.m_SerialNo.Name = "m_SerialNo";
            this.m_SerialNo.ReadOnly = true;
            // 
            // m_CameraIP
            // 
            this.m_CameraIP.DataPropertyName = "mCameraIP";
            this.m_CameraIP.FillWeight = 75.62124F;
            this.m_CameraIP.HeaderText = "地址";
            this.m_CameraIP.Name = "m_CameraIP";
            this.m_CameraIP.ReadOnly = true;
            // 
            // m_ExposureTime
            // 
            this.m_ExposureTime.DataPropertyName = "mExposeTime";
            this.m_ExposureTime.FillWeight = 77.28852F;
            this.m_ExposureTime.HeaderText = "曝光";
            this.m_ExposureTime.Name = "m_ExposureTime";
            this.m_ExposureTime.ReadOnly = true;
            // 
            // m_Gain
            // 
            this.m_Gain.DataPropertyName = "mGain";
            this.m_Gain.FillWeight = 79.75676F;
            this.m_Gain.HeaderText = "增益";
            this.m_Gain.Name = "m_Gain";
            this.m_Gain.ReadOnly = true;
            // 
            // m_width
            // 
            this.m_width.DataPropertyName = "mWidth";
            this.m_width.FillWeight = 77.94662F;
            this.m_width.HeaderText = "图像宽度";
            this.m_width.Name = "m_width";
            this.m_width.ReadOnly = true;
            // 
            // m_Height
            // 
            this.m_Height.DataPropertyName = "mHeight";
            this.m_Height.FillWeight = 75.87342F;
            this.m_Height.HeaderText = "图像高度";
            this.m_Height.Name = "m_Height";
            this.m_Height.ReadOnly = true;
            // 
            // m_bConnected
            // 
            this.m_bConnected.DataPropertyName = "mConnected";
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.m_bConnected.DefaultCellStyle = dataGridViewCellStyle4;
            this.m_bConnected.FillWeight = 77.65366F;
            this.m_bConnected.HeaderText = "状态";
            this.m_bConnected.Name = "m_bConnected";
            this.m_bConnected.ReadOnly = true;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.tableLayoutPanel4);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(1008, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(51, 458);
            this.panel1.TabIndex = 8;
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.ColumnCount = 2;
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 56.86274F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 43.13726F));
            this.tableLayoutPanel4.Controls.Add(this.btnPageChange, 0, 1);
            this.tableLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel4.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 3;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 42F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 48F));
            this.tableLayoutPanel4.Size = new System.Drawing.Size(51, 458);
            this.tableLayoutPanel4.TabIndex = 0;
            // 
            // btnPageChange
            // 
            this.btnPageChange.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnPageChange.BackgroundImage")));
            this.btnPageChange.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnPageChange.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPageChange.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnPageChange.FillColor = System.Drawing.Color.Transparent;
            this.btnPageChange.FillHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(55)))), ((int)(((byte)(130)))));
            this.btnPageChange.FillPressColor = System.Drawing.Color.CadetBlue;
            this.btnPageChange.Font = new System.Drawing.Font("华文新魏", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnPageChange.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            this.btnPageChange.ForeHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            this.btnPageChange.ForePressColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            this.btnPageChange.ForeSelectedColor = System.Drawing.Color.Black;
            this.btnPageChange.Location = new System.Drawing.Point(3, 195);
            this.btnPageChange.MinimumSize = new System.Drawing.Size(1, 1);
            this.btnPageChange.Name = "btnPageChange";
            this.btnPageChange.Radius = 15;
            this.btnPageChange.RectColor = System.Drawing.Color.Transparent;
            this.btnPageChange.RectHoverColor = System.Drawing.Color.Lavender;
            this.btnPageChange.RectPressColor = System.Drawing.Color.Honeydew;
            this.btnPageChange.RectSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.None;
            this.btnPageChange.Size = new System.Drawing.Size(22, 39);
            this.btnPageChange.Style = Rex.UI.UIStyle.Custom;
            this.btnPageChange.TabIndex = 1;
            this.btnPageChange.Click += new System.EventHandler(this.btn_Click);
            // 
            // timer1
            // 
            this.timer1.Interval = 200;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // FrmConfigCam
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1065, 643);
            this.Controls.Add(this.tableLayoutPanel1);
            this.DoubleBuffered = true;
            this.Name = "FrmConfigCam";
            this.Text = "FrmConfigCam";
            this.Load += new System.EventHandler(this.FrmConfigCam_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.tableLayoutPanel3.ResumeLayout(false);
            this.uiPnl.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCamList)).EndInit();
            this.panel1.ResumeLayout(false);
            this.tableLayoutPanel4.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private Rex.UI.UIButton btnAdd;
        private Rex.UI.UIButton btnRemove;
        private Rex.UI.UIComboBox cbxCamSelect;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private Rex.UI.UIPanel uiPnl;
        private Rex.UI.UIComboBox cbxCamType;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
        private Rex.UI.UIButton btnPageChange;
        private Rex.UI.UIDataGridView dgvCamList;
        private System.Windows.Forms.DataGridViewTextBoxColumn m_DeviceID;
        private System.Windows.Forms.DataGridViewTextBoxColumn m_SerialNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn m_CameraIP;
        private System.Windows.Forms.DataGridViewTextBoxColumn m_ExposureTime;
        private System.Windows.Forms.DataGridViewTextBoxColumn m_Gain;
        private System.Windows.Forms.DataGridViewTextBoxColumn m_width;
        private System.Windows.Forms.DataGridViewTextBoxColumn m_Height;
        private System.Windows.Forms.DataGridViewTextBoxColumn m_bConnected;
        private System.Windows.Forms.Timer timer1;
    }
}