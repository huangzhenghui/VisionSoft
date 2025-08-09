namespace Plugin.CreateROI
{
    partial class CreateROIForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CreateROIForm));
            this.label1 = new Rex.UI.UILabel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.bt_Color1 = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.bt_Draw1 = new System.Windows.Forms.Button();
            this.cmb_CurrentImg = new System.Windows.Forms.ComboBox();
            this.label12 = new System.Windows.Forms.Label();
            this.uiTabControl1 = new Rex.UI.UITabControl();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.pnlCircleParams = new Rex.UI.UITitlePanel();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.ldCircleCenterX = new RexControl.MyControls.MyLinkData();
            this.ldCircleRadius = new RexControl.MyControls.MyLinkData();
            this.ldCircleCenterY = new RexControl.MyControls.MyLinkData();
            this.label3 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.pnlRect2Params = new Rex.UI.UITitlePanel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.ldRect2Length2 = new RexControl.MyControls.MyLinkData();
            this.ldRect2CenterX = new RexControl.MyControls.MyLinkData();
            this.ldRect2Length1 = new RexControl.MyControls.MyLinkData();
            this.lblPhi = new System.Windows.Forms.Label();
            this.ldRect2Phi = new RexControl.MyControls.MyLinkData();
            this.lblLength2 = new System.Windows.Forms.Label();
            this.ldRect2CenterY = new RexControl.MyControls.MyLinkData();
            this.lblLength1 = new System.Windows.Forms.Label();
            this.lblCenterX = new System.Windows.Forms.Label();
            this.lblCenterY = new System.Windows.Forms.Label();
            this.pnlImage = new Rex.UI.UITitlePanel();
            this.label18 = new System.Windows.Forms.Label();
            this.cbxROIShape = new Rex.UI.MyComboBox();
            this.uiTitlePanel1 = new Rex.UI.UITitlePanel();
            this.ldImage = new RexControl.MyControls.MyLinkData();
            this.label11 = new System.Windows.Forms.Label();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.uiTitlePanel2 = new Rex.UI.UITitlePanel();
            this.label2 = new System.Windows.Forms.Label();
            this.cpResultColor = new Rex.UI.UIColorPicker();
            this.chxShowROI = new Rex.UI.UICheckBox();
            this.uiTitlePanel3 = new Rex.UI.UITitlePanel();
            this.label7 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.cpROIEditColor = new Rex.UI.UIColorPicker();
            this.cbxInterfaceMode = new Rex.UI.MyComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.mWindowH = new RexView.HWindow_HE();
            this.btnFitImg = new Rex.UI.UISymbolButton();
            this.panel_bottom.SuspendLayout();
            this.panel_center.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbox_Icon)).BeginInit();
            this.titlepanel.SuspendLayout();
            this.panel1.SuspendLayout();
            this.uiTabControl1.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.pnlCircleParams.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.pnlRect2Params.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.pnlImage.SuspendLayout();
            this.uiTitlePanel1.SuspendLayout();
            this.tabPage4.SuspendLayout();
            this.uiTitlePanel2.SuspendLayout();
            this.uiTitlePanel3.SuspendLayout();
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
            this.panel_center.Controls.Add(this.mWindowH);
            this.panel_center.Controls.Add(this.uiTabControl1);
            this.panel_center.Margin = new System.Windows.Forms.Padding(4);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(10, 91);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 17);
            this.label1.Style = Rex.UI.UIStyle.Custom;
            this.label1.TabIndex = 143;
            this.label1.Text = "参考坐标:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.bt_Color1);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.bt_Draw1);
            this.panel1.Controls.Add(this.cmb_CurrentImg);
            this.panel1.Controls.Add(this.label12);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(322, 441);
            this.panel1.TabIndex = 0;
            // 
            // bt_Color1
            // 
            this.bt_Color1.Location = new System.Drawing.Point(0, 0);
            this.bt_Color1.Name = "bt_Color1";
            this.bt_Color1.Size = new System.Drawing.Size(75, 23);
            this.bt_Color1.TabIndex = 0;
            // 
            // label6
            // 
            this.label6.Location = new System.Drawing.Point(0, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(100, 23);
            this.label6.TabIndex = 1;
            // 
            // bt_Draw1
            // 
            this.bt_Draw1.Location = new System.Drawing.Point(0, 0);
            this.bt_Draw1.Name = "bt_Draw1";
            this.bt_Draw1.Size = new System.Drawing.Size(75, 23);
            this.bt_Draw1.TabIndex = 2;
            // 
            // cmb_CurrentImg
            // 
            this.cmb_CurrentImg.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_CurrentImg.FormattingEnabled = true;
            this.cmb_CurrentImg.Location = new System.Drawing.Point(85, 26);
            this.cmb_CurrentImg.Name = "cmb_CurrentImg";
            this.cmb_CurrentImg.Size = new System.Drawing.Size(149, 20);
            this.cmb_CurrentImg.TabIndex = 34;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(28, 29);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(65, 12);
            this.label12.TabIndex = 35;
            this.label12.Text = "当前图像：";
            // 
            // uiTabControl1
            // 
            this.uiTabControl1.Controls.Add(this.tabPage3);
            this.uiTabControl1.Controls.Add(this.tabPage4);
            this.uiTabControl1.Dock = System.Windows.Forms.DockStyle.Left;
            this.uiTabControl1.DrawMode = System.Windows.Forms.TabDrawMode.OwnerDrawFixed;
            this.uiTabControl1.Font = new System.Drawing.Font("华文新魏", 12F);
            this.uiTabControl1.ItemSize = new System.Drawing.Size(85, 26);
            this.uiTabControl1.Location = new System.Drawing.Point(1, 1);
            this.uiTabControl1.MenuStyle = Rex.UI.UIMenuStyle.Custom;
            this.uiTabControl1.Name = "uiTabControl1";
            this.uiTabControl1.Padding = new System.Drawing.Point(3, 3);
            this.uiTabControl1.SelectedIndex = 0;
            this.uiTabControl1.Size = new System.Drawing.Size(303, 485);
            this.uiTabControl1.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.uiTabControl1.Style = Rex.UI.UIStyle.Custom;
            this.uiTabControl1.TabBackColor = System.Drawing.Color.White;
            this.uiTabControl1.TabIndex = 17;
            this.uiTabControl1.TabSelectedColor = System.Drawing.Color.White;
            this.uiTabControl1.TabSelectedForeColor = System.Drawing.Color.CornflowerBlue;
            this.uiTabControl1.TabSelectedHighColor = System.Drawing.Color.White;
            this.uiTabControl1.TabUnSelectedForeColor = System.Drawing.Color.Silver;
            // 
            // tabPage3
            // 
            this.tabPage3.BackColor = System.Drawing.Color.White;
            this.tabPage3.Controls.Add(this.pnlCircleParams);
            this.tabPage3.Controls.Add(this.pnlRect2Params);
            this.tabPage3.Controls.Add(this.pnlImage);
            this.tabPage3.Controls.Add(this.uiTitlePanel1);
            this.tabPage3.Font = new System.Drawing.Font("隶书", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tabPage3.Location = new System.Drawing.Point(0, 26);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(303, 459);
            this.tabPage3.TabIndex = 0;
            this.tabPage3.Text = "基本设置";
            // 
            // pnlCircleParams
            // 
            this.pnlCircleParams.Controls.Add(this.tableLayoutPanel3);
            this.pnlCircleParams.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlCircleParams.FillColor = System.Drawing.Color.White;
            this.pnlCircleParams.Font = new System.Drawing.Font("华文新魏", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.pnlCircleParams.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            this.pnlCircleParams.Location = new System.Drawing.Point(0, 368);
            this.pnlCircleParams.Margin = new System.Windows.Forms.Padding(0);
            this.pnlCircleParams.MinimumSize = new System.Drawing.Size(1, 1);
            this.pnlCircleParams.Name = "pnlCircleParams";
            this.pnlCircleParams.Padding = new System.Windows.Forms.Padding(0, 30, 0, 0);
            this.pnlCircleParams.RadiusSides = Rex.UI.UICornerRadiusSides.None;
            this.pnlCircleParams.RectColor = System.Drawing.Color.White;
            this.pnlCircleParams.Size = new System.Drawing.Size(303, 144);
            this.pnlCircleParams.Style = Rex.UI.UIStyle.Custom;
            this.pnlCircleParams.TabIndex = 44;
            this.pnlCircleParams.Text = "区域参数";
            this.pnlCircleParams.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.pnlCircleParams.TextAlignment = System.Drawing.ContentAlignment.MiddleRight;
            this.pnlCircleParams.TitleColor = System.Drawing.Color.CornflowerBlue;
            this.pnlCircleParams.TitleInterval = 5;
            this.pnlCircleParams.Visible = false;
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 2;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 27.39274F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 72.60726F));
            this.tableLayoutPanel3.Controls.Add(this.ldCircleCenterX, 1, 0);
            this.tableLayoutPanel3.Controls.Add(this.ldCircleRadius, 1, 2);
            this.tableLayoutPanel3.Controls.Add(this.ldCircleCenterY, 1, 1);
            this.tableLayoutPanel3.Controls.Add(this.label3, 0, 1);
            this.tableLayoutPanel3.Controls.Add(this.label8, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.label4, 0, 2);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(0, 30);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 3;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(303, 114);
            this.tableLayoutPanel3.TabIndex = 0;
            // 
            // ldCircleCenterX
            // 
            this.ldCircleCenterX.BackColor = System.Drawing.Color.AliceBlue;
            this.ldCircleCenterX.Font = new System.Drawing.Font("华文新魏", 11F);
            this.ldCircleCenterX.FontStyle = new System.Drawing.Font("华文新魏", 10.5F);
            this.ldCircleCenterX.Location = new System.Drawing.Point(85, 9);
            this.ldCircleCenterX.Margin = new System.Windows.Forms.Padding(2, 9, 4, 4);
            this.ldCircleCenterX.Name = "ldCircleCenterX";
            this.ldCircleCenterX.Size = new System.Drawing.Size(211, 23);
            this.ldCircleCenterX.TabIndex = 196;
            this.ldCircleCenterX.TextInfo = "";
            this.ldCircleCenterX.LinkData += new System.EventHandler(this.ldData_LinkData);
            this.ldCircleCenterX.RealTimeExe += new System.EventHandler(this.ldData_RealTimeExe);
            // 
            // ldCircleRadius
            // 
            this.ldCircleRadius.BackColor = System.Drawing.Color.AliceBlue;
            this.ldCircleRadius.Font = new System.Drawing.Font("华文新魏", 11F);
            this.ldCircleRadius.FontStyle = new System.Drawing.Font("华文新魏", 10.5F);
            this.ldCircleRadius.Location = new System.Drawing.Point(85, 85);
            this.ldCircleRadius.Margin = new System.Windows.Forms.Padding(2, 9, 4, 4);
            this.ldCircleRadius.Name = "ldCircleRadius";
            this.ldCircleRadius.Size = new System.Drawing.Size(211, 23);
            this.ldCircleRadius.TabIndex = 198;
            this.ldCircleRadius.TextInfo = "";
            this.ldCircleRadius.LinkData += new System.EventHandler(this.ldData_LinkData);
            this.ldCircleRadius.RealTimeExe += new System.EventHandler(this.ldData_RealTimeExe);
            // 
            // ldCircleCenterY
            // 
            this.ldCircleCenterY.BackColor = System.Drawing.Color.AliceBlue;
            this.ldCircleCenterY.Font = new System.Drawing.Font("华文新魏", 11F);
            this.ldCircleCenterY.FontStyle = new System.Drawing.Font("华文新魏", 10.5F);
            this.ldCircleCenterY.Location = new System.Drawing.Point(85, 47);
            this.ldCircleCenterY.Margin = new System.Windows.Forms.Padding(2, 9, 4, 4);
            this.ldCircleCenterY.Name = "ldCircleCenterY";
            this.ldCircleCenterY.Size = new System.Drawing.Size(211, 23);
            this.ldCircleCenterY.TabIndex = 197;
            this.ldCircleCenterY.TextInfo = "";
            this.ldCircleCenterY.LinkData += new System.EventHandler(this.ldData_LinkData);
            this.ldCircleCenterY.RealTimeExe += new System.EventHandler(this.ldData_RealTimeExe);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("华文新魏", 11F);
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.label3.Location = new System.Drawing.Point(6, 51);
            this.label3.Margin = new System.Windows.Forms.Padding(6, 13, 3, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 16);
            this.label3.TabIndex = 193;
            this.label3.Text = "中心点-Y:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("华文新魏", 11F);
            this.label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.label8.Location = new System.Drawing.Point(6, 13);
            this.label8.Margin = new System.Windows.Forms.Padding(6, 13, 3, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(73, 16);
            this.label8.TabIndex = 192;
            this.label8.Text = "中心点-X:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("华文新魏", 11F);
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.label4.Location = new System.Drawing.Point(6, 89);
            this.label4.Margin = new System.Windows.Forms.Padding(6, 13, 3, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(43, 16);
            this.label4.TabIndex = 194;
            this.label4.Text = "半径:";
            // 
            // pnlRect2Params
            // 
            this.pnlRect2Params.Controls.Add(this.tableLayoutPanel2);
            this.pnlRect2Params.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlRect2Params.FillColor = System.Drawing.Color.White;
            this.pnlRect2Params.Font = new System.Drawing.Font("华文新魏", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.pnlRect2Params.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            this.pnlRect2Params.Location = new System.Drawing.Point(0, 155);
            this.pnlRect2Params.Margin = new System.Windows.Forms.Padding(0);
            this.pnlRect2Params.MinimumSize = new System.Drawing.Size(1, 1);
            this.pnlRect2Params.Name = "pnlRect2Params";
            this.pnlRect2Params.Padding = new System.Windows.Forms.Padding(0, 30, 0, 0);
            this.pnlRect2Params.RadiusSides = Rex.UI.UICornerRadiusSides.None;
            this.pnlRect2Params.RectColor = System.Drawing.Color.White;
            this.pnlRect2Params.Size = new System.Drawing.Size(303, 213);
            this.pnlRect2Params.Style = Rex.UI.UIStyle.Custom;
            this.pnlRect2Params.TabIndex = 43;
            this.pnlRect2Params.Text = "区域参数";
            this.pnlRect2Params.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.pnlRect2Params.TextAlignment = System.Drawing.ContentAlignment.MiddleRight;
            this.pnlRect2Params.TitleColor = System.Drawing.Color.CornflowerBlue;
            this.pnlRect2Params.TitleInterval = 5;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 27.39274F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 72.60726F));
            this.tableLayoutPanel2.Controls.Add(this.ldRect2Length2, 1, 4);
            this.tableLayoutPanel2.Controls.Add(this.ldRect2CenterX, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.ldRect2Length1, 1, 3);
            this.tableLayoutPanel2.Controls.Add(this.lblPhi, 0, 2);
            this.tableLayoutPanel2.Controls.Add(this.ldRect2Phi, 1, 2);
            this.tableLayoutPanel2.Controls.Add(this.lblLength2, 0, 4);
            this.tableLayoutPanel2.Controls.Add(this.ldRect2CenterY, 1, 1);
            this.tableLayoutPanel2.Controls.Add(this.lblLength1, 0, 3);
            this.tableLayoutPanel2.Controls.Add(this.lblCenterX, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.lblCenterY, 0, 1);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(0, 30);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 5;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(303, 183);
            this.tableLayoutPanel2.TabIndex = 0;
            // 
            // ldRect2Length2
            // 
            this.ldRect2Length2.BackColor = System.Drawing.Color.AliceBlue;
            this.ldRect2Length2.Font = new System.Drawing.Font("华文新魏", 11F);
            this.ldRect2Length2.FontStyle = new System.Drawing.Font("华文新魏", 10.5F);
            this.ldRect2Length2.Location = new System.Drawing.Point(85, 153);
            this.ldRect2Length2.Margin = new System.Windows.Forms.Padding(2, 9, 4, 4);
            this.ldRect2Length2.Name = "ldRect2Length2";
            this.ldRect2Length2.Size = new System.Drawing.Size(211, 23);
            this.ldRect2Length2.TabIndex = 202;
            this.ldRect2Length2.TextInfo = "";
            this.ldRect2Length2.LinkData += new System.EventHandler(this.ldData_LinkData);
            this.ldRect2Length2.RealTimeExe += new System.EventHandler(this.ldData_RealTimeExe);
            // 
            // ldRect2CenterX
            // 
            this.ldRect2CenterX.BackColor = System.Drawing.Color.AliceBlue;
            this.ldRect2CenterX.Font = new System.Drawing.Font("华文新魏", 11F);
            this.ldRect2CenterX.FontStyle = new System.Drawing.Font("华文新魏", 10.5F);
            this.ldRect2CenterX.Location = new System.Drawing.Point(85, 9);
            this.ldRect2CenterX.Margin = new System.Windows.Forms.Padding(2, 9, 4, 4);
            this.ldRect2CenterX.Name = "ldRect2CenterX";
            this.ldRect2CenterX.Size = new System.Drawing.Size(211, 23);
            this.ldRect2CenterX.TabIndex = 196;
            this.ldRect2CenterX.TextInfo = "";
            this.ldRect2CenterX.LinkData += new System.EventHandler(this.ldData_LinkData);
            this.ldRect2CenterX.RealTimeExe += new System.EventHandler(this.ldData_RealTimeExe);
            // 
            // ldRect2Length1
            // 
            this.ldRect2Length1.BackColor = System.Drawing.Color.AliceBlue;
            this.ldRect2Length1.Font = new System.Drawing.Font("华文新魏", 11F);
            this.ldRect2Length1.FontStyle = new System.Drawing.Font("华文新魏", 10.5F);
            this.ldRect2Length1.Location = new System.Drawing.Point(85, 117);
            this.ldRect2Length1.Margin = new System.Windows.Forms.Padding(2, 9, 4, 4);
            this.ldRect2Length1.Name = "ldRect2Length1";
            this.ldRect2Length1.Size = new System.Drawing.Size(211, 23);
            this.ldRect2Length1.TabIndex = 201;
            this.ldRect2Length1.TextInfo = "";
            this.ldRect2Length1.LinkData += new System.EventHandler(this.ldData_LinkData);
            this.ldRect2Length1.RealTimeExe += new System.EventHandler(this.ldData_RealTimeExe);
            // 
            // lblPhi
            // 
            this.lblPhi.AutoSize = true;
            this.lblPhi.BackColor = System.Drawing.Color.Transparent;
            this.lblPhi.Font = new System.Drawing.Font("华文新魏", 11F);
            this.lblPhi.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.lblPhi.Location = new System.Drawing.Point(6, 85);
            this.lblPhi.Margin = new System.Windows.Forms.Padding(6, 13, 3, 0);
            this.lblPhi.Name = "lblPhi";
            this.lblPhi.Size = new System.Drawing.Size(43, 16);
            this.lblPhi.TabIndex = 194;
            this.lblPhi.Text = "角度:";
            // 
            // ldRect2Phi
            // 
            this.ldRect2Phi.BackColor = System.Drawing.Color.AliceBlue;
            this.ldRect2Phi.Font = new System.Drawing.Font("华文新魏", 11F);
            this.ldRect2Phi.FontStyle = new System.Drawing.Font("华文新魏", 10.5F);
            this.ldRect2Phi.Location = new System.Drawing.Point(85, 81);
            this.ldRect2Phi.Margin = new System.Windows.Forms.Padding(2, 9, 4, 4);
            this.ldRect2Phi.Name = "ldRect2Phi";
            this.ldRect2Phi.Size = new System.Drawing.Size(211, 23);
            this.ldRect2Phi.TabIndex = 198;
            this.ldRect2Phi.TextInfo = "";
            this.ldRect2Phi.LinkData += new System.EventHandler(this.ldData_LinkData);
            this.ldRect2Phi.RealTimeExe += new System.EventHandler(this.ldData_RealTimeExe);
            // 
            // lblLength2
            // 
            this.lblLength2.AutoSize = true;
            this.lblLength2.BackColor = System.Drawing.Color.Transparent;
            this.lblLength2.Font = new System.Drawing.Font("华文新魏", 11F);
            this.lblLength2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.lblLength2.Location = new System.Drawing.Point(6, 157);
            this.lblLength2.Margin = new System.Windows.Forms.Padding(6, 13, 3, 0);
            this.lblLength2.Name = "lblLength2";
            this.lblLength2.Size = new System.Drawing.Size(58, 16);
            this.lblLength2.TabIndex = 200;
            this.lblLength2.Text = "短半轴:";
            // 
            // ldRect2CenterY
            // 
            this.ldRect2CenterY.BackColor = System.Drawing.Color.AliceBlue;
            this.ldRect2CenterY.Font = new System.Drawing.Font("华文新魏", 11F);
            this.ldRect2CenterY.FontStyle = new System.Drawing.Font("华文新魏", 10.5F);
            this.ldRect2CenterY.Location = new System.Drawing.Point(85, 45);
            this.ldRect2CenterY.Margin = new System.Windows.Forms.Padding(2, 9, 4, 4);
            this.ldRect2CenterY.Name = "ldRect2CenterY";
            this.ldRect2CenterY.Size = new System.Drawing.Size(211, 23);
            this.ldRect2CenterY.TabIndex = 197;
            this.ldRect2CenterY.TextInfo = "";
            this.ldRect2CenterY.LinkData += new System.EventHandler(this.ldData_LinkData);
            this.ldRect2CenterY.RealTimeExe += new System.EventHandler(this.ldData_RealTimeExe);
            // 
            // lblLength1
            // 
            this.lblLength1.AutoSize = true;
            this.lblLength1.BackColor = System.Drawing.Color.Transparent;
            this.lblLength1.Font = new System.Drawing.Font("华文新魏", 11F);
            this.lblLength1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.lblLength1.Location = new System.Drawing.Point(6, 121);
            this.lblLength1.Margin = new System.Windows.Forms.Padding(6, 13, 3, 0);
            this.lblLength1.Name = "lblLength1";
            this.lblLength1.Size = new System.Drawing.Size(58, 16);
            this.lblLength1.TabIndex = 199;
            this.lblLength1.Text = "长半轴:";
            // 
            // lblCenterX
            // 
            this.lblCenterX.AutoSize = true;
            this.lblCenterX.BackColor = System.Drawing.Color.Transparent;
            this.lblCenterX.Font = new System.Drawing.Font("华文新魏", 11F);
            this.lblCenterX.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.lblCenterX.Location = new System.Drawing.Point(6, 13);
            this.lblCenterX.Margin = new System.Windows.Forms.Padding(6, 13, 3, 0);
            this.lblCenterX.Name = "lblCenterX";
            this.lblCenterX.Size = new System.Drawing.Size(73, 16);
            this.lblCenterX.TabIndex = 192;
            this.lblCenterX.Text = "中心点-X:";
            // 
            // lblCenterY
            // 
            this.lblCenterY.AutoSize = true;
            this.lblCenterY.BackColor = System.Drawing.Color.Transparent;
            this.lblCenterY.Font = new System.Drawing.Font("华文新魏", 11F);
            this.lblCenterY.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.lblCenterY.Location = new System.Drawing.Point(6, 49);
            this.lblCenterY.Margin = new System.Windows.Forms.Padding(6, 13, 3, 0);
            this.lblCenterY.Name = "lblCenterY";
            this.lblCenterY.Size = new System.Drawing.Size(72, 16);
            this.lblCenterY.TabIndex = 193;
            this.lblCenterY.Text = "中心点-Y:";
            // 
            // pnlImage
            // 
            this.pnlImage.Controls.Add(this.label18);
            this.pnlImage.Controls.Add(this.cbxROIShape);
            this.pnlImage.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlImage.FillColor = System.Drawing.Color.White;
            this.pnlImage.Font = new System.Drawing.Font("华文新魏", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.pnlImage.ForeColor = System.Drawing.Color.White;
            this.pnlImage.Location = new System.Drawing.Point(0, 83);
            this.pnlImage.Margin = new System.Windows.Forms.Padding(0);
            this.pnlImage.MinimumSize = new System.Drawing.Size(1, 1);
            this.pnlImage.Name = "pnlImage";
            this.pnlImage.Padding = new System.Windows.Forms.Padding(0, 25, 0, 0);
            this.pnlImage.RadiusSides = Rex.UI.UICornerRadiusSides.None;
            this.pnlImage.RectColor = System.Drawing.Color.White;
            this.pnlImage.Size = new System.Drawing.Size(303, 72);
            this.pnlImage.Style = Rex.UI.UIStyle.Custom;
            this.pnlImage.TabIndex = 17;
            this.pnlImage.Text = "区域形状";
            this.pnlImage.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.pnlImage.TitleColor = System.Drawing.Color.CornflowerBlue;
            this.pnlImage.TitleInterval = 5;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.BackColor = System.Drawing.Color.Transparent;
            this.label18.Font = new System.Drawing.Font("华文新魏", 11F);
            this.label18.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.label18.Location = new System.Drawing.Point(6, 44);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(73, 16);
            this.label18.TabIndex = 203;
            this.label18.Text = "区域形状:";
            // 
            // cbxROIShape
            // 
            this.cbxROIShape.BackColor = System.Drawing.Color.AliceBlue;
            this.cbxROIShape.DropDownStyle = Rex.UI.UIDropDownStyle.DropDownList;
            this.cbxROIShape.FillColor = System.Drawing.Color.AliceBlue;
            this.cbxROIShape.Font = new System.Drawing.Font("华文新魏", 11.6F);
            this.cbxROIShape.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.cbxROIShape.ForeDisableColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.cbxROIShape.Items.AddRange(new object[] {
            "矩形",
            "圆形"});
            this.cbxROIShape.Location = new System.Drawing.Point(81, 39);
            this.cbxROIShape.Margin = new System.Windows.Forms.Padding(0);
            this.cbxROIShape.MinimumSize = new System.Drawing.Size(63, 0);
            this.cbxROIShape.Name = "cbxROIShape";
            this.cbxROIShape.Padding = new System.Windows.Forms.Padding(0, 0, 30, 0);
            this.cbxROIShape.Radius = 2;
            this.cbxROIShape.RectColor = System.Drawing.Color.CornflowerBlue;
            this.cbxROIShape.RectDisableColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.cbxROIShape.RectSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.None;
            this.cbxROIShape.Size = new System.Drawing.Size(214, 24);
            this.cbxROIShape.Style = Rex.UI.UIStyle.Custom;
            this.cbxROIShape.StyleCustomMode = true;
            this.cbxROIShape.SymbolDropDown = 61656;
            this.cbxROIShape.SymbolNormal = 61655;
            this.cbxROIShape.TabIndex = 203;
            this.cbxROIShape.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.cbxROIShape.SelectedIndexChanged += new System.EventHandler(this.ROI_ValueChanged);
            // 
            // uiTitlePanel1
            // 
            this.uiTitlePanel1.Controls.Add(this.ldImage);
            this.uiTitlePanel1.Controls.Add(this.label11);
            this.uiTitlePanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.uiTitlePanel1.FillColor = System.Drawing.Color.White;
            this.uiTitlePanel1.Font = new System.Drawing.Font("华文新魏", 12F);
            this.uiTitlePanel1.ForeColor = System.Drawing.Color.White;
            this.uiTitlePanel1.Location = new System.Drawing.Point(0, 0);
            this.uiTitlePanel1.Margin = new System.Windows.Forms.Padding(0);
            this.uiTitlePanel1.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiTitlePanel1.Name = "uiTitlePanel1";
            this.uiTitlePanel1.Padding = new System.Windows.Forms.Padding(3, 25, 3, 0);
            this.uiTitlePanel1.RadiusSides = Rex.UI.UICornerRadiusSides.None;
            this.uiTitlePanel1.RectColor = System.Drawing.Color.White;
            this.uiTitlePanel1.Size = new System.Drawing.Size(303, 83);
            this.uiTitlePanel1.Style = Rex.UI.UIStyle.Custom;
            this.uiTitlePanel1.TabIndex = 14;
            this.uiTitlePanel1.Text = "输入图像";
            this.uiTitlePanel1.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.uiTitlePanel1.TextAlignment = System.Drawing.ContentAlignment.BottomCenter;
            this.uiTitlePanel1.TitleColor = System.Drawing.Color.CornflowerBlue;
            this.uiTitlePanel1.TitleInterval = 5;
            // 
            // ldImage
            // 
            this.ldImage.BackColor = System.Drawing.Color.AliceBlue;
            this.ldImage.Font = new System.Drawing.Font("华文新魏", 12F);
            this.ldImage.FontStyle = new System.Drawing.Font("华文新魏", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.ldImage.Location = new System.Drawing.Point(82, 43);
            this.ldImage.Margin = new System.Windows.Forms.Padding(4, 5, 4, 4);
            this.ldImage.Name = "ldImage";
            this.ldImage.Size = new System.Drawing.Size(213, 24);
            this.ldImage.TabIndex = 195;
            this.ldImage.TextInfo = "";
            this.ldImage.LinkData += new System.EventHandler(this.ldImage_LinkData);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.Transparent;
            this.label11.Font = new System.Drawing.Font("华文新魏", 11F);
            this.label11.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.label11.Location = new System.Drawing.Point(6, 47);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(73, 16);
            this.label11.TabIndex = 191;
            this.label11.Text = "输入图像:";
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.uiTitlePanel2);
            this.tabPage4.Controls.Add(this.uiTitlePanel3);
            this.tabPage4.Location = new System.Drawing.Point(0, 26);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Size = new System.Drawing.Size(303, 459);
            this.tabPage4.TabIndex = 1;
            this.tabPage4.Text = "显示设置";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // uiTitlePanel2
            // 
            this.uiTitlePanel2.Controls.Add(this.label2);
            this.uiTitlePanel2.Controls.Add(this.cpResultColor);
            this.uiTitlePanel2.Controls.Add(this.chxShowROI);
            this.uiTitlePanel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.uiTitlePanel2.FillColor = System.Drawing.Color.White;
            this.uiTitlePanel2.FillDisableColor = System.Drawing.Color.White;
            this.uiTitlePanel2.Font = new System.Drawing.Font("华文新魏", 12F);
            this.uiTitlePanel2.ForeColor = System.Drawing.Color.White;
            this.uiTitlePanel2.Location = new System.Drawing.Point(0, 143);
            this.uiTitlePanel2.Margin = new System.Windows.Forms.Padding(0);
            this.uiTitlePanel2.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiTitlePanel2.Name = "uiTitlePanel2";
            this.uiTitlePanel2.Padding = new System.Windows.Forms.Padding(0, 35, 0, 0);
            this.uiTitlePanel2.RadiusSides = Rex.UI.UICornerRadiusSides.None;
            this.uiTitlePanel2.RectColor = System.Drawing.Color.White;
            this.uiTitlePanel2.Size = new System.Drawing.Size(303, 98);
            this.uiTitlePanel2.Style = Rex.UI.UIStyle.Custom;
            this.uiTitlePanel2.TabIndex = 207;
            this.uiTitlePanel2.Text = "显示设置";
            this.uiTitlePanel2.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.uiTitlePanel2.TitleColor = System.Drawing.Color.CornflowerBlue;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("华文新魏", 11F);
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.label2.Location = new System.Drawing.Point(9, 69);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 16);
            this.label2.TabIndex = 197;
            this.label2.Text = "颜色选择:";
            // 
            // cpResultColor
            // 
            this.cpResultColor.DropDownStyle = Rex.UI.UIDropDownStyle.DropDownList;
            this.cpResultColor.FillColor = System.Drawing.Color.AliceBlue;
            this.cpResultColor.FillDisableColor = System.Drawing.Color.AliceBlue;
            this.cpResultColor.Font = new System.Drawing.Font("微软雅黑", 9F);
            this.cpResultColor.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.cpResultColor.Location = new System.Drawing.Point(87, 65);
            this.cpResultColor.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cpResultColor.MinimumSize = new System.Drawing.Size(63, 0);
            this.cpResultColor.Name = "cpResultColor";
            this.cpResultColor.Padding = new System.Windows.Forms.Padding(0, 0, 30, 0);
            this.cpResultColor.RadiusSides = Rex.UI.UICornerRadiusSides.None;
            this.cpResultColor.RectColor = System.Drawing.Color.White;
            this.cpResultColor.RectSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.Bottom;
            this.cpResultColor.Size = new System.Drawing.Size(202, 23);
            this.cpResultColor.Style = Rex.UI.UIStyle.Custom;
            this.cpResultColor.StyleCustomMode = true;
            this.cpResultColor.TabIndex = 196;
            this.cpResultColor.Text = "uiColorPicker1";
            this.cpResultColor.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.cpResultColor.Value = System.Drawing.Color.MediumAquamarine;
            // 
            // chxShowROI
            // 
            this.chxShowROI.BackColor = System.Drawing.Color.White;
            this.chxShowROI.Checked = true;
            this.chxShowROI.Cursor = System.Windows.Forms.Cursors.Hand;
            this.chxShowROI.Font = new System.Drawing.Font("华文新魏", 11F);
            this.chxShowROI.ImageSize = 14;
            this.chxShowROI.Location = new System.Drawing.Point(10, 38);
            this.chxShowROI.MinimumSize = new System.Drawing.Size(1, 1);
            this.chxShowROI.Name = "chxShowROI";
            this.chxShowROI.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.chxShowROI.Size = new System.Drawing.Size(211, 16);
            this.chxShowROI.Style = Rex.UI.UIStyle.Custom;
            this.chxShowROI.TabIndex = 195;
            this.chxShowROI.Text = "显示区域";
            // 
            // uiTitlePanel3
            // 
            this.uiTitlePanel3.Controls.Add(this.btnFitImg);
            this.uiTitlePanel3.Controls.Add(this.label7);
            this.uiTitlePanel3.Controls.Add(this.label16);
            this.uiTitlePanel3.Controls.Add(this.cpROIEditColor);
            this.uiTitlePanel3.Controls.Add(this.cbxInterfaceMode);
            this.uiTitlePanel3.Controls.Add(this.label5);
            this.uiTitlePanel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.uiTitlePanel3.FillColor = System.Drawing.Color.White;
            this.uiTitlePanel3.Font = new System.Drawing.Font("华文新魏", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uiTitlePanel3.ForeColor = System.Drawing.Color.White;
            this.uiTitlePanel3.Location = new System.Drawing.Point(0, 0);
            this.uiTitlePanel3.Margin = new System.Windows.Forms.Padding(0);
            this.uiTitlePanel3.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiTitlePanel3.Name = "uiTitlePanel3";
            this.uiTitlePanel3.Padding = new System.Windows.Forms.Padding(0, 25, 0, 0);
            this.uiTitlePanel3.RadiusSides = Rex.UI.UICornerRadiusSides.None;
            this.uiTitlePanel3.RectColor = System.Drawing.Color.White;
            this.uiTitlePanel3.Size = new System.Drawing.Size(303, 143);
            this.uiTitlePanel3.Style = Rex.UI.UIStyle.Custom;
            this.uiTitlePanel3.TabIndex = 206;
            this.uiTitlePanel3.Text = "编辑设置";
            this.uiTitlePanel3.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.uiTitlePanel3.TitleColor = System.Drawing.Color.CornflowerBlue;
            this.uiTitlePanel3.TitleInterval = 5;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("华文新魏", 11F);
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.label7.Location = new System.Drawing.Point(10, 109);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(73, 16);
            this.label7.TabIndex = 234;
            this.label7.Text = "适应图像:";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.BackColor = System.Drawing.Color.Transparent;
            this.label16.Font = new System.Drawing.Font("华文新魏", 11F);
            this.label16.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.label16.Location = new System.Drawing.Point(10, 78);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(73, 16);
            this.label16.TabIndex = 197;
            this.label16.Text = "颜色选择:";
            // 
            // cpROIEditColor
            // 
            this.cpROIEditColor.DropDownStyle = Rex.UI.UIDropDownStyle.DropDownList;
            this.cpROIEditColor.FillColor = System.Drawing.Color.AliceBlue;
            this.cpROIEditColor.FillDisableColor = System.Drawing.Color.AliceBlue;
            this.cpROIEditColor.Font = new System.Drawing.Font("微软雅黑", 9F);
            this.cpROIEditColor.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.cpROIEditColor.Location = new System.Drawing.Point(88, 74);
            this.cpROIEditColor.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cpROIEditColor.MinimumSize = new System.Drawing.Size(63, 0);
            this.cpROIEditColor.Name = "cpROIEditColor";
            this.cpROIEditColor.Padding = new System.Windows.Forms.Padding(0, 0, 30, 0);
            this.cpROIEditColor.RadiusSides = Rex.UI.UICornerRadiusSides.None;
            this.cpROIEditColor.RectColor = System.Drawing.Color.White;
            this.cpROIEditColor.RectSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.Bottom;
            this.cpROIEditColor.Size = new System.Drawing.Size(202, 23);
            this.cpROIEditColor.Style = Rex.UI.UIStyle.Custom;
            this.cpROIEditColor.StyleCustomMode = true;
            this.cpROIEditColor.TabIndex = 196;
            this.cpROIEditColor.Text = "uiColorPicker1";
            this.cpROIEditColor.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.cpROIEditColor.Value = System.Drawing.Color.MediumAquamarine;
            this.cpROIEditColor.ValueChanged += new Rex.UI.UIColorPicker.OnColorChanged(this.cpColor_ValueChanged);
            // 
            // cbxInterfaceMode
            // 
            this.cbxInterfaceMode.BackColor = System.Drawing.Color.AliceBlue;
            this.cbxInterfaceMode.DropDownStyle = Rex.UI.UIDropDownStyle.DropDownList;
            this.cbxInterfaceMode.FillColor = System.Drawing.Color.AliceBlue;
            this.cbxInterfaceMode.Font = new System.Drawing.Font("华文新魏", 11F);
            this.cbxInterfaceMode.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.cbxInterfaceMode.ForeDisableColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.cbxInterfaceMode.Items.AddRange(new object[] {
            "编辑状态",
            "运行结果"});
            this.cbxInterfaceMode.Location = new System.Drawing.Point(86, 40);
            this.cbxInterfaceMode.Margin = new System.Windows.Forms.Padding(0);
            this.cbxInterfaceMode.MinimumSize = new System.Drawing.Size(63, 0);
            this.cbxInterfaceMode.Name = "cbxInterfaceMode";
            this.cbxInterfaceMode.Padding = new System.Windows.Forms.Padding(0, 0, 30, 0);
            this.cbxInterfaceMode.Radius = 2;
            this.cbxInterfaceMode.RectColor = System.Drawing.Color.CornflowerBlue;
            this.cbxInterfaceMode.RectDisableColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.cbxInterfaceMode.RectSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.None;
            this.cbxInterfaceMode.Size = new System.Drawing.Size(203, 23);
            this.cbxInterfaceMode.Style = Rex.UI.UIStyle.Custom;
            this.cbxInterfaceMode.StyleCustomMode = true;
            this.cbxInterfaceMode.SymbolDropDown = 61656;
            this.cbxInterfaceMode.SymbolNormal = 61655;
            this.cbxInterfaceMode.TabIndex = 233;
            this.cbxInterfaceMode.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.cbxInterfaceMode.SelectedValueChanged += new System.EventHandler(this.cbxInterfaceMode_SelectedValueChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("华文新魏", 11F);
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.label5.Location = new System.Drawing.Point(10, 44);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(73, 16);
            this.label5.TabIndex = 232;
            this.label5.Text = "界面模式:";
            // 
            // mWindowH
            // 
            this.mWindowH.BackColor = System.Drawing.Color.Transparent;
            this.mWindowH.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.mWindowH.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mWindowH.DrawModel = false;
            this.mWindowH.Image = null;
            this.mWindowH.Location = new System.Drawing.Point(304, 1);
            this.mWindowH.Margin = new System.Windows.Forms.Padding(5);
            this.mWindowH.Name = "mWindowH";
            this.mWindowH.Padding = new System.Windows.Forms.Padding(1);
            this.mWindowH.Size = new System.Drawing.Size(541, 485);
            this.mWindowH.TabIndex = 18;
            // 
            // btnFitImg
            // 
            this.btnFitImg.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnFitImg.Font = new System.Drawing.Font("华文新魏", 12F);
            this.btnFitImg.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            this.btnFitImg.ForeHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            this.btnFitImg.ForePressColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            this.btnFitImg.ForeSelectedColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            this.btnFitImg.Location = new System.Drawing.Point(88, 106);
            this.btnFitImg.MinimumSize = new System.Drawing.Size(1, 1);
            this.btnFitImg.Name = "btnFitImg";
            this.btnFitImg.Size = new System.Drawing.Size(202, 21);
            this.btnFitImg.Style = Rex.UI.UIStyle.Custom;
            this.btnFitImg.Symbol = 61732;
            this.btnFitImg.TabIndex = 208;
            this.btnFitImg.Text = "执行";
            this.btnFitImg.Click += new System.EventHandler(this.btnFitImg_Click);
            // 
            // CreateROIForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(848, 548);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "CreateROIForm";
            this.Load += new System.EventHandler(this.CreateROIForm_Load);
            this.panel_bottom.ResumeLayout(false);
            this.panel_center.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbox_Icon)).EndInit();
            this.titlepanel.ResumeLayout(false);
            this.titlepanel.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.uiTabControl1.ResumeLayout(false);
            this.tabPage3.ResumeLayout(false);
            this.pnlCircleParams.ResumeLayout(false);
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel3.PerformLayout();
            this.pnlRect2Params.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.pnlImage.ResumeLayout(false);
            this.pnlImage.PerformLayout();
            this.uiTitlePanel1.ResumeLayout(false);
            this.uiTitlePanel1.PerformLayout();
            this.tabPage4.ResumeLayout(false);
            this.uiTitlePanel2.ResumeLayout(false);
            this.uiTitlePanel2.PerformLayout();
            this.uiTitlePanel3.ResumeLayout(false);
            this.uiTitlePanel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        protected System.Windows.Forms.ComboBox cmb_CurrentImg;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Button bt_Draw1;
        private System.Windows.Forms.Button bt_Color1;
        private System.Windows.Forms.Label label6;
        private Rex.UI.UILabel label1;
        private Rex.UI.UITabControl uiTabControl1;
        private System.Windows.Forms.TabPage tabPage3;
        private Rex.UI.UITitlePanel pnlRect2Params;
        private Rex.UI.UITitlePanel pnlImage;
        private Rex.UI.UITitlePanel uiTitlePanel1;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label lblPhi;
        private System.Windows.Forms.Label lblCenterY;
        private System.Windows.Forms.Label lblCenterX;
        private RexControl.MyControls.MyLinkData ldImage;
        private RexControl.MyControls.MyLinkData ldRect2Phi;
        private RexControl.MyControls.MyLinkData ldRect2CenterY;
        private RexControl.MyControls.MyLinkData ldRect2CenterX;
        private RexView.HWindow_HE mWindowH;
        private RexControl.MyControls.MyLinkData ldRect2Length2;
        private RexControl.MyControls.MyLinkData ldRect2Length1;
        private System.Windows.Forms.Label lblLength2;
        private System.Windows.Forms.Label lblLength1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Label label16;
        private Rex.UI.UIColorPicker cpROIEditColor;
        private Rex.UI.UITitlePanel pnlCircleParams;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private RexControl.MyControls.MyLinkData ldCircleCenterX;
        private RexControl.MyControls.MyLinkData ldCircleRadius;
        private RexControl.MyControls.MyLinkData ldCircleCenterY;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label4;
        private Rex.UI.MyComboBox cbxROIShape;
        private System.Windows.Forms.Label label18;
        private Rex.UI.UITitlePanel uiTitlePanel2;
        private System.Windows.Forms.Label label2;
        private Rex.UI.UIColorPicker cpResultColor;
        private Rex.UI.UICheckBox chxShowROI;
        private Rex.UI.UITitlePanel uiTitlePanel3;
        private Rex.UI.MyComboBox cbxInterfaceMode;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label7;
        private Rex.UI.UISymbolButton btnFitImg;
    }
}