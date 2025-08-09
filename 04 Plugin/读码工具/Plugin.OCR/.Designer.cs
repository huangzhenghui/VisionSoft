
namespace Plugin.OCR
{
    partial class OCRForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(OCRForm));
            this.uiTabControl1 = new Rex.UI.UITabControl();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.pnl2 = new Rex.UI.UITitlePanel();
            this.ldCharacterReg = new RexControl.MyControls.MyLinkData();
            this.tbxCharacterName = new Rex.UI.UITextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.tbxFileCPath = new RexControl.MyControls.TextBoxEx();
            this.btnFilePath2Link = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.pnl1 = new Rex.UI.UITitlePanel();
            this.tableLayoutPanel6 = new System.Windows.Forms.TableLayoutPanel();
            this.tbxFileRPath = new RexControl.MyControls.TextBoxEx();
            this.btnFilePath1Link = new System.Windows.Forms.Button();
            this.label29 = new System.Windows.Forms.Label();
            this.pnlRect2Params = new Rex.UI.UITitlePanel();
            this.cbxFileSource = new Rex.UI.MyComboBox();
            this.label18 = new System.Windows.Forms.Label();
            this.uiTitlePanel1 = new Rex.UI.UITitlePanel();
            this.ldImage = new RexControl.MyControls.MyLinkData();
            this.label11 = new System.Windows.Forms.Label();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.uiTitlePanel2 = new Rex.UI.UITitlePanel();
            this.ldProcIReg = new RexControl.MyControls.MyLinkData();
            this.ldProcImage = new RexControl.MyControls.MyLinkData();
            this.label6 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.uiTitlePanel3 = new Rex.UI.UITitlePanel();
            this.chxDelFile = new Rex.UI.UICheckBox();
            this.uiTitlePanel8 = new Rex.UI.UITitlePanel();
            this.cbxFontStye = new Rex.UI.MyComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.chxShow = new Rex.UI.UICheckBox();
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
            this.mWindowH = new RexView.HWindow_HE();
            this.panel_bottom.SuspendLayout();
            this.panel_center.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbox_Icon)).BeginInit();
            this.titlepanel.SuspendLayout();
            this.uiTabControl1.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.pnl2.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.pnl1.SuspendLayout();
            this.tableLayoutPanel6.SuspendLayout();
            this.pnlRect2Params.SuspendLayout();
            this.uiTitlePanel1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.uiTitlePanel2.SuspendLayout();
            this.tabPage4.SuspendLayout();
            this.uiTitlePanel3.SuspendLayout();
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
            // uiTabControl1
            // 
            this.uiTabControl1.Controls.Add(this.tabPage3);
            this.uiTabControl1.Controls.Add(this.tabPage1);
            this.uiTabControl1.Controls.Add(this.tabPage4);
            this.uiTabControl1.Dock = System.Windows.Forms.DockStyle.Left;
            this.uiTabControl1.DrawMode = System.Windows.Forms.TabDrawMode.OwnerDrawFixed;
            this.uiTabControl1.Font = new System.Drawing.Font("华文新魏", 12F);
            this.uiTabControl1.ItemSize = new System.Drawing.Size(85, 26);
            this.uiTabControl1.Location = new System.Drawing.Point(2, 1);
            this.uiTabControl1.MenuStyle = Rex.UI.UIMenuStyle.Custom;
            this.uiTabControl1.Name = "uiTabControl1";
            this.uiTabControl1.SelectedIndex = 0;
            this.uiTabControl1.Size = new System.Drawing.Size(303, 487);
            this.uiTabControl1.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.uiTabControl1.Style = Rex.UI.UIStyle.Custom;
            this.uiTabControl1.TabBackColor = System.Drawing.Color.White;
            this.uiTabControl1.TabIndex = 19;
            this.uiTabControl1.TabSelectedColor = System.Drawing.Color.White;
            this.uiTabControl1.TabSelectedForeColor = System.Drawing.Color.CornflowerBlue;
            this.uiTabControl1.TabSelectedHighColor = System.Drawing.Color.White;
            this.uiTabControl1.TabUnSelectedForeColor = System.Drawing.Color.Silver;
            // 
            // tabPage3
            // 
            this.tabPage3.BackColor = System.Drawing.Color.White;
            this.tabPage3.Controls.Add(this.pnl2);
            this.tabPage3.Controls.Add(this.pnl1);
            this.tabPage3.Controls.Add(this.pnlRect2Params);
            this.tabPage3.Controls.Add(this.uiTitlePanel1);
            this.tabPage3.Font = new System.Drawing.Font("华文新魏", 12F);
            this.tabPage3.Location = new System.Drawing.Point(0, 26);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(303, 461);
            this.tabPage3.TabIndex = 0;
            this.tabPage3.Text = "训练设置";
            // 
            // pnl2
            // 
            this.pnl2.Controls.Add(this.ldCharacterReg);
            this.pnl2.Controls.Add(this.tbxCharacterName);
            this.pnl2.Controls.Add(this.label3);
            this.pnl2.Controls.Add(this.label2);
            this.pnl2.Controls.Add(this.tableLayoutPanel2);
            this.pnl2.Controls.Add(this.label1);
            this.pnl2.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnl2.FillColor = System.Drawing.Color.White;
            this.pnl2.Font = new System.Drawing.Font("华文新魏", 12F);
            this.pnl2.ForeColor = System.Drawing.Color.White;
            this.pnl2.Location = new System.Drawing.Point(0, 222);
            this.pnl2.Margin = new System.Windows.Forms.Padding(0);
            this.pnl2.MinimumSize = new System.Drawing.Size(1, 1);
            this.pnl2.Name = "pnl2";
            this.pnl2.Padding = new System.Windows.Forms.Padding(3, 25, 3, 0);
            this.pnl2.RadiusSides = Rex.UI.UICornerRadiusSides.None;
            this.pnl2.RectColor = System.Drawing.Color.White;
            this.pnl2.Size = new System.Drawing.Size(303, 237);
            this.pnl2.Style = Rex.UI.UIStyle.Custom;
            this.pnl2.TabIndex = 213;
            this.pnl2.Text = "参数设置";
            this.pnl2.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.pnl2.TextAlignment = System.Drawing.ContentAlignment.BottomCenter;
            this.pnl2.TitleColor = System.Drawing.Color.CornflowerBlue;
            this.pnl2.TitleInterval = 5;
            // 
            // ldCharacterReg
            // 
            this.ldCharacterReg.BackColor = System.Drawing.Color.AliceBlue;
            this.ldCharacterReg.Font = new System.Drawing.Font("华文新魏", 12F);
            this.ldCharacterReg.FontStyle = new System.Drawing.Font("华文新魏", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.ldCharacterReg.Location = new System.Drawing.Point(83, 70);
            this.ldCharacterReg.Margin = new System.Windows.Forms.Padding(4, 5, 4, 4);
            this.ldCharacterReg.Name = "ldCharacterReg";
            this.ldCharacterReg.Size = new System.Drawing.Size(210, 24);
            this.ldCharacterReg.TabIndex = 258;
            this.ldCharacterReg.TextInfo = "";
            this.ldCharacterReg.LinkData += new System.EventHandler(this.ldHObject_LinkData);
            // 
            // tbxCharacterName
            // 
            this.tbxCharacterName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbxCharacterName.Font = new System.Drawing.Font("华文新魏", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tbxCharacterName.Location = new System.Drawing.Point(83, 105);
            this.tbxCharacterName.Margin = new System.Windows.Forms.Padding(0);
            this.tbxCharacterName.Maximum = 2147483647D;
            this.tbxCharacterName.Minimum = -2147483648D;
            this.tbxCharacterName.MinimumSize = new System.Drawing.Size(1, 1);
            this.tbxCharacterName.Name = "tbxCharacterName";
            this.tbxCharacterName.Size = new System.Drawing.Size(210, 23);
            this.tbxCharacterName.Style = Rex.UI.UIStyle.Custom;
            this.tbxCharacterName.TabIndex = 257;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("华文新魏", 11F);
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.label3.Location = new System.Drawing.Point(10, 109);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 16);
            this.label3.TabIndex = 256;
            this.label3.Text = "字符名称:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("华文新魏", 11F);
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.label2.Location = new System.Drawing.Point(10, 75);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 16);
            this.label2.TabIndex = 212;
            this.label2.Text = "字符区域:";
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.BackColor = System.Drawing.Color.AliceBlue;
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 86.76471F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 13.23529F));
            this.tableLayoutPanel2.Controls.Add(this.tbxFileCPath, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.btnFilePath2Link, 1, 0);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(83, 36);
            this.tableLayoutPanel2.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(210, 25);
            this.tableLayoutPanel2.TabIndex = 211;
            // 
            // tbxFileCPath
            // 
            this.tbxFileCPath.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbxFileCPath.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbxFileCPath.Font = new System.Drawing.Font("华文新魏", 11.5F);
            this.tbxFileCPath.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.tbxFileCPath.Location = new System.Drawing.Point(3, 3);
            this.tbxFileCPath.Multiline = false;
            this.tbxFileCPath.Name = "tbxFileCPath";
            this.tbxFileCPath.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None;
            this.tbxFileCPath.Size = new System.Drawing.Size(176, 19);
            this.tbxFileCPath.TabIndex = 2;
            this.tbxFileCPath.Text = "";
            // 
            // btnFilePath2Link
            // 
            this.btnFilePath2Link.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnFilePath2Link.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnFilePath2Link.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            this.btnFilePath2Link.FlatAppearance.BorderSize = 0;
            this.btnFilePath2Link.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            this.btnFilePath2Link.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            this.btnFilePath2Link.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFilePath2Link.Image = ((System.Drawing.Image)(resources.GetObject("btnFilePath2Link.Image")));
            this.btnFilePath2Link.Location = new System.Drawing.Point(185, 3);
            this.btnFilePath2Link.Name = "btnFilePath2Link";
            this.btnFilePath2Link.Size = new System.Drawing.Size(22, 19);
            this.btnFilePath2Link.TabIndex = 1;
            this.btnFilePath2Link.UseVisualStyleBackColor = true;
            this.btnFilePath2Link.Click += new System.EventHandler(this.btnFileCPathLink_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("华文新魏", 11F);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.label1.Location = new System.Drawing.Point(10, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 16);
            this.label1.TabIndex = 191;
            this.label1.Text = "文件路径:";
            // 
            // pnl1
            // 
            this.pnl1.Controls.Add(this.tableLayoutPanel6);
            this.pnl1.Controls.Add(this.label29);
            this.pnl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnl1.FillColor = System.Drawing.Color.White;
            this.pnl1.Font = new System.Drawing.Font("华文新魏", 12F);
            this.pnl1.ForeColor = System.Drawing.Color.White;
            this.pnl1.Location = new System.Drawing.Point(0, 148);
            this.pnl1.Margin = new System.Windows.Forms.Padding(0);
            this.pnl1.MinimumSize = new System.Drawing.Size(1, 1);
            this.pnl1.Name = "pnl1";
            this.pnl1.Padding = new System.Windows.Forms.Padding(3, 25, 3, 0);
            this.pnl1.RadiusSides = Rex.UI.UICornerRadiusSides.None;
            this.pnl1.RectColor = System.Drawing.Color.White;
            this.pnl1.Size = new System.Drawing.Size(303, 74);
            this.pnl1.Style = Rex.UI.UIStyle.Custom;
            this.pnl1.TabIndex = 212;
            this.pnl1.Text = "参数设置";
            this.pnl1.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.pnl1.TextAlignment = System.Drawing.ContentAlignment.BottomCenter;
            this.pnl1.TitleColor = System.Drawing.Color.CornflowerBlue;
            this.pnl1.TitleInterval = 5;
            // 
            // tableLayoutPanel6
            // 
            this.tableLayoutPanel6.BackColor = System.Drawing.Color.AliceBlue;
            this.tableLayoutPanel6.ColumnCount = 2;
            this.tableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 86.76471F));
            this.tableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 13.23529F));
            this.tableLayoutPanel6.Controls.Add(this.tbxFileRPath, 0, 0);
            this.tableLayoutPanel6.Controls.Add(this.btnFilePath1Link, 1, 0);
            this.tableLayoutPanel6.Location = new System.Drawing.Point(83, 37);
            this.tableLayoutPanel6.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel6.Name = "tableLayoutPanel6";
            this.tableLayoutPanel6.RowCount = 1;
            this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tableLayoutPanel6.Size = new System.Drawing.Size(210, 25);
            this.tableLayoutPanel6.TabIndex = 211;
            // 
            // tbxFileRPath
            // 
            this.tbxFileRPath.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbxFileRPath.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbxFileRPath.Font = new System.Drawing.Font("华文新魏", 11.5F);
            this.tbxFileRPath.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.tbxFileRPath.Location = new System.Drawing.Point(3, 3);
            this.tbxFileRPath.Multiline = false;
            this.tbxFileRPath.Name = "tbxFileRPath";
            this.tbxFileRPath.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None;
            this.tbxFileRPath.Size = new System.Drawing.Size(176, 19);
            this.tbxFileRPath.TabIndex = 2;
            this.tbxFileRPath.Text = "";
            // 
            // btnFilePath1Link
            // 
            this.btnFilePath1Link.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnFilePath1Link.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnFilePath1Link.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            this.btnFilePath1Link.FlatAppearance.BorderSize = 0;
            this.btnFilePath1Link.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            this.btnFilePath1Link.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            this.btnFilePath1Link.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFilePath1Link.Image = ((System.Drawing.Image)(resources.GetObject("btnFilePath1Link.Image")));
            this.btnFilePath1Link.Location = new System.Drawing.Point(185, 3);
            this.btnFilePath1Link.Name = "btnFilePath1Link";
            this.btnFilePath1Link.Size = new System.Drawing.Size(22, 19);
            this.btnFilePath1Link.TabIndex = 1;
            this.btnFilePath1Link.UseVisualStyleBackColor = true;
            this.btnFilePath1Link.Click += new System.EventHandler(this.btnFileRPathLink_Click);
            // 
            // label29
            // 
            this.label29.AutoSize = true;
            this.label29.BackColor = System.Drawing.Color.Transparent;
            this.label29.Font = new System.Drawing.Font("华文新魏", 11F);
            this.label29.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.label29.Location = new System.Drawing.Point(10, 42);
            this.label29.Name = "label29";
            this.label29.Size = new System.Drawing.Size(73, 16);
            this.label29.TabIndex = 191;
            this.label29.Text = "文件路径:";
            // 
            // pnlRect2Params
            // 
            this.pnlRect2Params.Controls.Add(this.cbxFileSource);
            this.pnlRect2Params.Controls.Add(this.label18);
            this.pnlRect2Params.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlRect2Params.FillColor = System.Drawing.Color.White;
            this.pnlRect2Params.Font = new System.Drawing.Font("华文新魏", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.pnlRect2Params.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            this.pnlRect2Params.Location = new System.Drawing.Point(0, 75);
            this.pnlRect2Params.Margin = new System.Windows.Forms.Padding(0);
            this.pnlRect2Params.MinimumSize = new System.Drawing.Size(1, 1);
            this.pnlRect2Params.Name = "pnlRect2Params";
            this.pnlRect2Params.Padding = new System.Windows.Forms.Padding(0, 30, 0, 0);
            this.pnlRect2Params.RadiusSides = Rex.UI.UICornerRadiusSides.None;
            this.pnlRect2Params.RectColor = System.Drawing.Color.White;
            this.pnlRect2Params.Size = new System.Drawing.Size(303, 73);
            this.pnlRect2Params.Style = Rex.UI.UIStyle.Custom;
            this.pnlRect2Params.TabIndex = 204;
            this.pnlRect2Params.Text = "文件来源";
            this.pnlRect2Params.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.pnlRect2Params.TextAlignment = System.Drawing.ContentAlignment.MiddleRight;
            this.pnlRect2Params.TitleColor = System.Drawing.Color.CornflowerBlue;
            this.pnlRect2Params.TitleInterval = 5;
            // 
            // cbxFileSource
            // 
            this.cbxFileSource.BackColor = System.Drawing.Color.AliceBlue;
            this.cbxFileSource.DropDownStyle = Rex.UI.UIDropDownStyle.DropDownList;
            this.cbxFileSource.FillColor = System.Drawing.Color.AliceBlue;
            this.cbxFileSource.Font = new System.Drawing.Font("华文新魏", 11.6F);
            this.cbxFileSource.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.cbxFileSource.ForeDisableColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.cbxFileSource.Items.AddRange(new object[] {
            "读取",
            "创建"});
            this.cbxFileSource.Location = new System.Drawing.Point(83, 36);
            this.cbxFileSource.Margin = new System.Windows.Forms.Padding(0);
            this.cbxFileSource.MinimumSize = new System.Drawing.Size(63, 0);
            this.cbxFileSource.Name = "cbxFileSource";
            this.cbxFileSource.Padding = new System.Windows.Forms.Padding(0, 0, 30, 0);
            this.cbxFileSource.Radius = 2;
            this.cbxFileSource.RectColor = System.Drawing.Color.CornflowerBlue;
            this.cbxFileSource.RectDisableColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.cbxFileSource.RectSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.None;
            this.cbxFileSource.Size = new System.Drawing.Size(210, 24);
            this.cbxFileSource.Style = Rex.UI.UIStyle.Custom;
            this.cbxFileSource.StyleCustomMode = true;
            this.cbxFileSource.SymbolDropDown = 61656;
            this.cbxFileSource.SymbolNormal = 61655;
            this.cbxFileSource.TabIndex = 260;
            this.cbxFileSource.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.cbxFileSource.SelectedIndexChanged += new System.EventHandler(this.cbxFileSource_SelectedIndexChanged);
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.BackColor = System.Drawing.Color.Transparent;
            this.label18.Font = new System.Drawing.Font("华文新魏", 11F);
            this.label18.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.label18.Location = new System.Drawing.Point(10, 44);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(73, 16);
            this.label18.TabIndex = 204;
            this.label18.Text = "文件来源:";
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
            this.uiTitlePanel1.Size = new System.Drawing.Size(303, 75);
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
            this.ldImage.Location = new System.Drawing.Point(83, 39);
            this.ldImage.Margin = new System.Windows.Forms.Padding(4, 5, 4, 4);
            this.ldImage.Name = "ldImage";
            this.ldImage.Size = new System.Drawing.Size(210, 24);
            this.ldImage.TabIndex = 216;
            this.ldImage.TextInfo = "";
            this.ldImage.LinkData += new System.EventHandler(this.ldImage_LinkData);
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
            this.label11.Text = "输入图像:";
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.uiTitlePanel2);
            this.tabPage1.Location = new System.Drawing.Point(0, 26);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Size = new System.Drawing.Size(303, 461);
            this.tabPage1.TabIndex = 2;
            this.tabPage1.Text = "识别设置";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // uiTitlePanel2
            // 
            this.uiTitlePanel2.Controls.Add(this.ldProcIReg);
            this.uiTitlePanel2.Controls.Add(this.ldProcImage);
            this.uiTitlePanel2.Controls.Add(this.label6);
            this.uiTitlePanel2.Controls.Add(this.label9);
            this.uiTitlePanel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.uiTitlePanel2.FillColor = System.Drawing.Color.White;
            this.uiTitlePanel2.Font = new System.Drawing.Font("华文新魏", 12F);
            this.uiTitlePanel2.ForeColor = System.Drawing.Color.White;
            this.uiTitlePanel2.Location = new System.Drawing.Point(0, 0);
            this.uiTitlePanel2.Margin = new System.Windows.Forms.Padding(0);
            this.uiTitlePanel2.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiTitlePanel2.Name = "uiTitlePanel2";
            this.uiTitlePanel2.Padding = new System.Windows.Forms.Padding(3, 25, 3, 0);
            this.uiTitlePanel2.RadiusSides = Rex.UI.UICornerRadiusSides.None;
            this.uiTitlePanel2.RectColor = System.Drawing.Color.White;
            this.uiTitlePanel2.Size = new System.Drawing.Size(303, 419);
            this.uiTitlePanel2.Style = Rex.UI.UIStyle.Custom;
            this.uiTitlePanel2.TabIndex = 214;
            this.uiTitlePanel2.Text = "参数设置";
            this.uiTitlePanel2.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.uiTitlePanel2.TextAlignment = System.Drawing.ContentAlignment.BottomCenter;
            this.uiTitlePanel2.TitleColor = System.Drawing.Color.CornflowerBlue;
            this.uiTitlePanel2.TitleInterval = 5;
            // 
            // ldProcIReg
            // 
            this.ldProcIReg.BackColor = System.Drawing.Color.AliceBlue;
            this.ldProcIReg.Font = new System.Drawing.Font("华文新魏", 12F);
            this.ldProcIReg.FontStyle = new System.Drawing.Font("华文新魏", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.ldProcIReg.Location = new System.Drawing.Point(84, 71);
            this.ldProcIReg.Margin = new System.Windows.Forms.Padding(4, 5, 4, 4);
            this.ldProcIReg.Name = "ldProcIReg";
            this.ldProcIReg.Size = new System.Drawing.Size(210, 24);
            this.ldProcIReg.TabIndex = 216;
            this.ldProcIReg.TextInfo = "";
            this.ldProcIReg.LinkData += new System.EventHandler(this.ldHObject_LinkData);
            // 
            // ldProcImage
            // 
            this.ldProcImage.BackColor = System.Drawing.Color.AliceBlue;
            this.ldProcImage.Font = new System.Drawing.Font("华文新魏", 12F);
            this.ldProcImage.FontStyle = new System.Drawing.Font("华文新魏", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.ldProcImage.Location = new System.Drawing.Point(84, 38);
            this.ldProcImage.Margin = new System.Windows.Forms.Padding(4, 5, 4, 4);
            this.ldProcImage.Name = "ldProcImage";
            this.ldProcImage.Size = new System.Drawing.Size(210, 24);
            this.ldProcImage.TabIndex = 215;
            this.ldProcImage.TextInfo = "";
            this.ldProcImage.LinkData += new System.EventHandler(this.ldImage_LinkData);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("华文新魏", 11F);
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.label6.Location = new System.Drawing.Point(10, 78);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(73, 16);
            this.label6.TabIndex = 212;
            this.label6.Text = "字符区域:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("华文新魏", 11F);
            this.label9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.label9.Location = new System.Drawing.Point(10, 45);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(73, 16);
            this.label9.TabIndex = 191;
            this.label9.Text = "输入图像:";
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.uiTitlePanel3);
            this.tabPage4.Controls.Add(this.uiTitlePanel8);
            this.tabPage4.Location = new System.Drawing.Point(0, 26);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Size = new System.Drawing.Size(303, 461);
            this.tabPage4.TabIndex = 1;
            this.tabPage4.Text = "显示设置";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // uiTitlePanel3
            // 
            this.uiTitlePanel3.Controls.Add(this.chxDelFile);
            this.uiTitlePanel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.uiTitlePanel3.FillColor = System.Drawing.Color.White;
            this.uiTitlePanel3.FillDisableColor = System.Drawing.Color.White;
            this.uiTitlePanel3.Font = new System.Drawing.Font("华文新魏", 12F);
            this.uiTitlePanel3.ForeColor = System.Drawing.Color.White;
            this.uiTitlePanel3.Location = new System.Drawing.Point(0, 280);
            this.uiTitlePanel3.Margin = new System.Windows.Forms.Padding(0);
            this.uiTitlePanel3.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiTitlePanel3.Name = "uiTitlePanel3";
            this.uiTitlePanel3.Padding = new System.Windows.Forms.Padding(0, 35, 0, 0);
            this.uiTitlePanel3.RadiusSides = Rex.UI.UICornerRadiusSides.None;
            this.uiTitlePanel3.RectColor = System.Drawing.Color.White;
            this.uiTitlePanel3.Size = new System.Drawing.Size(303, 73);
            this.uiTitlePanel3.Style = Rex.UI.UIStyle.Custom;
            this.uiTitlePanel3.TabIndex = 235;
            this.uiTitlePanel3.Text = "保存设置";
            this.uiTitlePanel3.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.uiTitlePanel3.TitleColor = System.Drawing.Color.CornflowerBlue;
            // 
            // chxDelFile
            // 
            this.chxDelFile.Checked = true;
            this.chxDelFile.Cursor = System.Windows.Forms.Cursors.Hand;
            this.chxDelFile.Font = new System.Drawing.Font("华文新魏", 11F);
            this.chxDelFile.Location = new System.Drawing.Point(10, 38);
            this.chxDelFile.MinimumSize = new System.Drawing.Size(1, 1);
            this.chxDelFile.Name = "chxDelFile";
            this.chxDelFile.Padding = new System.Windows.Forms.Padding(22, 0, 0, 0);
            this.chxDelFile.Size = new System.Drawing.Size(227, 21);
            this.chxDelFile.Style = Rex.UI.UIStyle.Custom;
            this.chxDelFile.TabIndex = 189;
            this.chxDelFile.Text = "保存";
            // 
            // uiTitlePanel8
            // 
            this.uiTitlePanel8.Controls.Add(this.cbxFontStye);
            this.uiTitlePanel8.Controls.Add(this.label4);
            this.uiTitlePanel8.Controls.Add(this.chxShow);
            this.uiTitlePanel8.Controls.Add(this.tbxY);
            this.uiTitlePanel8.Controls.Add(this.tbxFontSize);
            this.uiTitlePanel8.Controls.Add(this.label12);
            this.uiTitlePanel8.Controls.Add(this.tbxX);
            this.uiTitlePanel8.Controls.Add(this.label8);
            this.uiTitlePanel8.Controls.Add(this.label10);
            this.uiTitlePanel8.Controls.Add(this.tbxPrefix);
            this.uiTitlePanel8.Controls.Add(this.label14);
            this.uiTitlePanel8.Controls.Add(this.label7);
            this.uiTitlePanel8.Controls.Add(this.cpColor);
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
            this.uiTitlePanel8.Size = new System.Drawing.Size(303, 280);
            this.uiTitlePanel8.Style = Rex.UI.UIStyle.Custom;
            this.uiTitlePanel8.TabIndex = 201;
            this.uiTitlePanel8.Text = "显示设置";
            this.uiTitlePanel8.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.uiTitlePanel8.TitleColor = System.Drawing.Color.CornflowerBlue;
            this.uiTitlePanel8.TitleInterval = 5;
            // 
            // cbxFontStye
            // 
            this.cbxFontStye.BackColor = System.Drawing.Color.AliceBlue;
            this.cbxFontStye.DropDownStyle = Rex.UI.UIDropDownStyle.DropDownList;
            this.cbxFontStye.FillColor = System.Drawing.Color.AliceBlue;
            this.cbxFontStye.Font = new System.Drawing.Font("华文新魏", 11F);
            this.cbxFontStye.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.cbxFontStye.ForeDisableColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.cbxFontStye.Location = new System.Drawing.Point(79, 170);
            this.cbxFontStye.Margin = new System.Windows.Forms.Padding(0);
            this.cbxFontStye.MinimumSize = new System.Drawing.Size(63, 0);
            this.cbxFontStye.Name = "cbxFontStye";
            this.cbxFontStye.Padding = new System.Windows.Forms.Padding(0, 0, 30, 0);
            this.cbxFontStye.Radius = 2;
            this.cbxFontStye.RectColor = System.Drawing.Color.CornflowerBlue;
            this.cbxFontStye.RectDisableColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.cbxFontStye.RectSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.None;
            this.cbxFontStye.Size = new System.Drawing.Size(210, 23);
            this.cbxFontStye.Style = Rex.UI.UIStyle.Custom;
            this.cbxFontStye.StyleCustomMode = true;
            this.cbxFontStye.SymbolDropDown = 61656;
            this.cbxFontStye.SymbolNormal = 61655;
            this.cbxFontStye.TabIndex = 233;
            this.cbxFontStye.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("华文新魏", 11F);
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.label4.Location = new System.Drawing.Point(8, 175);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(73, 16);
            this.label4.TabIndex = 232;
            this.label4.Text = "字体样式:";
            // 
            // chxShow
            // 
            this.chxShow.BackColor = System.Drawing.Color.White;
            this.chxShow.Checked = true;
            this.chxShow.Cursor = System.Windows.Forms.Cursors.Hand;
            this.chxShow.Font = new System.Drawing.Font("华文新魏", 11F);
            this.chxShow.ImageSize = 14;
            this.chxShow.Location = new System.Drawing.Point(10, 38);
            this.chxShow.MinimumSize = new System.Drawing.Size(1, 1);
            this.chxShow.Name = "chxShow";
            this.chxShow.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.chxShow.Size = new System.Drawing.Size(211, 16);
            this.chxShow.Style = Rex.UI.UIStyle.Custom;
            this.chxShow.TabIndex = 231;
            this.chxShow.Text = "显示";
            // 
            // tbxY
            // 
            this.tbxY.Font = new System.Drawing.Font("华文新魏", 11F);
            this.tbxY.FontStyle = null;
            this.tbxY.Location = new System.Drawing.Point(79, 99);
            this.tbxY.Name = "tbxY";
            this.tbxY.Size = new System.Drawing.Size(211, 26);
            this.tbxY.TabIndex = 230;
            this.tbxY.TextInfo = "";
            // 
            // tbxFontSize
            // 
            this.tbxFontSize.BackColor = System.Drawing.Color.White;
            this.tbxFontSize.Font = new System.Drawing.Font("华文新魏", 11.2F);
            this.tbxFontSize.FontStyle = null;
            this.tbxFontSize.Location = new System.Drawing.Point(79, 135);
            this.tbxFontSize.Name = "tbxFontSize";
            this.tbxFontSize.Size = new System.Drawing.Size(211, 25);
            this.tbxFontSize.TabIndex = 229;
            this.tbxFontSize.TextInfo = "";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.Color.Transparent;
            this.label12.Font = new System.Drawing.Font("华文新魏", 11F);
            this.label12.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.label12.Location = new System.Drawing.Point(8, 142);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(73, 16);
            this.label12.TabIndex = 228;
            this.label12.Text = "字体大小:";
            // 
            // tbxX
            // 
            this.tbxX.Font = new System.Drawing.Font("华文新魏", 11F);
            this.tbxX.FontStyle = null;
            this.tbxX.Location = new System.Drawing.Point(79, 63);
            this.tbxX.Name = "tbxX";
            this.tbxX.Size = new System.Drawing.Size(210, 26);
            this.tbxX.TabIndex = 227;
            this.tbxX.TextInfo = "";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("华文新魏", 11F);
            this.label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.label8.Location = new System.Drawing.Point(8, 107);
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
            this.label10.Location = new System.Drawing.Point(8, 71);
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
            this.tbxPrefix.Location = new System.Drawing.Point(79, 203);
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
            this.tbxPrefix.Size = new System.Drawing.Size(211, 23);
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
            this.label14.Location = new System.Drawing.Point(8, 208);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(43, 16);
            this.label14.TabIndex = 204;
            this.label14.Text = "前缀:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("华文新魏", 11F);
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.label7.Location = new System.Drawing.Point(8, 241);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(43, 16);
            this.label7.TabIndex = 201;
            this.label7.Text = "颜色:";
            // 
            // cpColor
            // 
            this.cpColor.DropDownStyle = Rex.UI.UIDropDownStyle.DropDownList;
            this.cpColor.FillColor = System.Drawing.Color.AliceBlue;
            this.cpColor.FillDisableColor = System.Drawing.Color.AliceBlue;
            this.cpColor.Font = new System.Drawing.Font("微软雅黑", 9F);
            this.cpColor.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.cpColor.Location = new System.Drawing.Point(79, 236);
            this.cpColor.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cpColor.MinimumSize = new System.Drawing.Size(63, 0);
            this.cpColor.Name = "cpColor";
            this.cpColor.Padding = new System.Windows.Forms.Padding(0, 0, 30, 0);
            this.cpColor.RadiusSides = Rex.UI.UICornerRadiusSides.None;
            this.cpColor.RectColor = System.Drawing.Color.White;
            this.cpColor.RectSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.Bottom;
            this.cpColor.Size = new System.Drawing.Size(211, 23);
            this.cpColor.Style = Rex.UI.UIStyle.Custom;
            this.cpColor.StyleCustomMode = true;
            this.cpColor.TabIndex = 200;
            this.cpColor.Text = "uiColorPicker1";
            this.cpColor.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.cpColor.Value = System.Drawing.Color.DodgerBlue;
            // 
            // mWindowH
            // 
            this.mWindowH.BackColor = System.Drawing.Color.Transparent;
            this.mWindowH.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.mWindowH.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mWindowH.DrawModel = false;
            this.mWindowH.Image = null;
            this.mWindowH.Location = new System.Drawing.Point(305, 1);
            this.mWindowH.Margin = new System.Windows.Forms.Padding(5);
            this.mWindowH.Name = "mWindowH";
            this.mWindowH.Padding = new System.Windows.Forms.Padding(1);
            this.mWindowH.Size = new System.Drawing.Size(542, 487);
            this.mWindowH.TabIndex = 23;
            // 
            // OCRForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(850, 550);
            this.Name = "OCRForm";
            this.Load += new System.EventHandler(this.OCRForm_Load);
            this.panel_bottom.ResumeLayout(false);
            this.panel_center.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbox_Icon)).EndInit();
            this.titlepanel.ResumeLayout(false);
            this.titlepanel.PerformLayout();
            this.uiTabControl1.ResumeLayout(false);
            this.tabPage3.ResumeLayout(false);
            this.pnl2.ResumeLayout(false);
            this.pnl2.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.pnl1.ResumeLayout(false);
            this.pnl1.PerformLayout();
            this.tableLayoutPanel6.ResumeLayout(false);
            this.pnlRect2Params.ResumeLayout(false);
            this.pnlRect2Params.PerformLayout();
            this.uiTitlePanel1.ResumeLayout(false);
            this.uiTitlePanel1.PerformLayout();
            this.tabPage1.ResumeLayout(false);
            this.uiTitlePanel2.ResumeLayout(false);
            this.uiTitlePanel2.PerformLayout();
            this.tabPage4.ResumeLayout(false);
            this.uiTitlePanel3.ResumeLayout(false);
            this.uiTitlePanel8.ResumeLayout(false);
            this.uiTitlePanel8.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private Rex.UI.UITabControl uiTabControl1;
        private System.Windows.Forms.TabPage tabPage3;
        private Rex.UI.UITitlePanel uiTitlePanel1;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TabPage tabPage4;
        private Rex.UI.UITitlePanel pnlRect2Params;
        private Rex.UI.UITitlePanel pnl1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel6;
        private System.Windows.Forms.Button btnFilePath1Link;
        private System.Windows.Forms.Label label29;
        private Rex.UI.UITitlePanel pnl2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Button btnFilePath2Link;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private Rex.UI.UITextBox tbxCharacterName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TabPage tabPage1;
        private Rex.UI.UITitlePanel uiTitlePanel2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label9;
        private RexControl.MyControls.MyLinkData ldProcIReg;
        private RexControl.MyControls.MyLinkData ldProcImage;
        private Rex.UI.UITitlePanel uiTitlePanel3;
        private Rex.UI.UICheckBox chxDelFile;
        private Rex.UI.UITitlePanel uiTitlePanel8;
        private Rex.UI.MyComboBox cbxFontStye;
        private System.Windows.Forms.Label label4;
        private Rex.UI.UICheckBox chxShow;
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
        private RexControl.MyControls.TextBoxEx tbxFileCPath;
        private RexControl.MyControls.TextBoxEx tbxFileRPath;
        private RexControl.MyControls.MyLinkData ldCharacterReg;
        private RexControl.MyControls.MyLinkData ldImage;
        private RexView.HWindow_HE mWindowH;
        private System.Windows.Forms.Label label18;
        private Rex.UI.MyComboBox cbxFileSource;
    }
}