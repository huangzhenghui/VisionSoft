
namespace Plugin.HalconScript
{
    partial class HalconScriptForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HalconScriptForm));
            this.uiTabControl1 = new Rex.UI.UITabControl();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.pnl2 = new Rex.UI.UITitlePanel();
            this.ldInputHTuple = new RexControl.MyControls.MyLinkData();
            this.ldInputHObject = new RexControl.MyControls.MyLinkData();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.pnlRect2Params = new Rex.UI.UITitlePanel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.btnPathLink = new System.Windows.Forms.Button();
            this.tbxScriptPath = new Rex.UI.UITextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cbxScriptType = new Rex.UI.MyComboBox();
            this.label18 = new System.Windows.Forms.Label();
            this.uiTitlePanel1 = new Rex.UI.UITitlePanel();
            this.ldImage = new RexControl.MyControls.MyLinkData();
            this.label11 = new System.Windows.Forms.Label();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.uiSymbolLabel1 = new Rex.UI.UISymbolLabel();
            this.btnExe = new Rex.UI.UIButton();
            this.btnLoad = new Rex.UI.UIButton();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.uiTitlePanel8 = new Rex.UI.UITitlePanel();
            this.cbxFontStye = new Rex.UI.MyComboBox();
            this.label4 = new System.Windows.Forms.Label();
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
            this.chxShowReg = new Rex.UI.UICheckBox();
            this.mWindowH = new RexView.HWindow_HE();
            this.panel_bottom.SuspendLayout();
            this.panel_center.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbox_Icon)).BeginInit();
            this.titlepanel.SuspendLayout();
            this.uiTabControl1.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.pnl2.SuspendLayout();
            this.pnlRect2Params.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.uiTitlePanel1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage4.SuspendLayout();
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
            this.tabPage3.Controls.Add(this.pnlRect2Params);
            this.tabPage3.Controls.Add(this.uiTitlePanel1);
            this.tabPage3.Font = new System.Drawing.Font("华文新魏", 12F);
            this.tabPage3.Location = new System.Drawing.Point(0, 26);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(303, 461);
            this.tabPage3.TabIndex = 0;
            this.tabPage3.Text = "基本设置";
            // 
            // pnl2
            // 
            this.pnl2.Controls.Add(this.ldInputHTuple);
            this.pnl2.Controls.Add(this.ldInputHObject);
            this.pnl2.Controls.Add(this.label3);
            this.pnl2.Controls.Add(this.label2);
            this.pnl2.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnl2.FillColor = System.Drawing.Color.White;
            this.pnl2.Font = new System.Drawing.Font("华文新魏", 12F);
            this.pnl2.ForeColor = System.Drawing.Color.White;
            this.pnl2.Location = new System.Drawing.Point(0, 185);
            this.pnl2.Margin = new System.Windows.Forms.Padding(0);
            this.pnl2.MinimumSize = new System.Drawing.Size(1, 1);
            this.pnl2.Name = "pnl2";
            this.pnl2.Padding = new System.Windows.Forms.Padding(3, 25, 3, 0);
            this.pnl2.RadiusSides = Rex.UI.UICornerRadiusSides.None;
            this.pnl2.RectColor = System.Drawing.Color.White;
            this.pnl2.Size = new System.Drawing.Size(303, 237);
            this.pnl2.Style = Rex.UI.UIStyle.Custom;
            this.pnl2.TabIndex = 216;
            this.pnl2.Text = "参数设置";
            this.pnl2.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.pnl2.TextAlignment = System.Drawing.ContentAlignment.BottomCenter;
            this.pnl2.TitleColor = System.Drawing.Color.CornflowerBlue;
            this.pnl2.TitleInterval = 5;
            // 
            // ldInputHTuple
            // 
            this.ldInputHTuple.BackColor = System.Drawing.Color.AliceBlue;
            this.ldInputHTuple.Font = new System.Drawing.Font("华文新魏", 12F);
            this.ldInputHTuple.FontStyle = new System.Drawing.Font("华文新魏", 11.5F);
            this.ldInputHTuple.Location = new System.Drawing.Point(83, 75);
            this.ldInputHTuple.Margin = new System.Windows.Forms.Padding(4, 5, 4, 4);
            this.ldInputHTuple.Name = "ldInputHTuple";
            this.ldInputHTuple.Size = new System.Drawing.Size(210, 24);
            this.ldInputHTuple.TabIndex = 259;
            this.ldInputHTuple.TextInfo = "";
            this.ldInputHTuple.LinkData += new System.EventHandler(this.ldData_LinkData);
            // 
            // ldInputHObject
            // 
            this.ldInputHObject.BackColor = System.Drawing.Color.AliceBlue;
            this.ldInputHObject.Font = new System.Drawing.Font("华文新魏", 12F);
            this.ldInputHObject.FontStyle = new System.Drawing.Font("华文新魏", 11.5F);
            this.ldInputHObject.Location = new System.Drawing.Point(83, 40);
            this.ldInputHObject.Margin = new System.Windows.Forms.Padding(4, 5, 4, 4);
            this.ldInputHObject.Name = "ldInputHObject";
            this.ldInputHObject.Size = new System.Drawing.Size(210, 24);
            this.ldInputHObject.TabIndex = 258;
            this.ldInputHObject.TextInfo = "";
            this.ldInputHObject.LinkData += new System.EventHandler(this.ldData_LinkData);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("华文新魏", 11F);
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.label3.Location = new System.Drawing.Point(10, 79);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 16);
            this.label3.TabIndex = 256;
            this.label3.Text = "输入元组:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("华文新魏", 11F);
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.label2.Location = new System.Drawing.Point(10, 45);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 16);
            this.label2.TabIndex = 212;
            this.label2.Text = "输入对象:";
            // 
            // pnlRect2Params
            // 
            this.pnlRect2Params.Controls.Add(this.tableLayoutPanel2);
            this.pnlRect2Params.Controls.Add(this.label1);
            this.pnlRect2Params.Controls.Add(this.cbxScriptType);
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
            this.pnlRect2Params.Size = new System.Drawing.Size(303, 110);
            this.pnlRect2Params.Style = Rex.UI.UIStyle.Custom;
            this.pnlRect2Params.TabIndex = 215;
            this.pnlRect2Params.Text = "脚本设置";
            this.pnlRect2Params.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.pnlRect2Params.TextAlignment = System.Drawing.ContentAlignment.MiddleRight;
            this.pnlRect2Params.TitleColor = System.Drawing.Color.CornflowerBlue;
            this.pnlRect2Params.TitleInterval = 5;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.BackColor = System.Drawing.Color.AliceBlue;
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 86.76471F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 13.23529F));
            this.tableLayoutPanel2.Controls.Add(this.btnPathLink, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.tbxScriptPath, 0, 0);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(83, 73);
            this.tableLayoutPanel2.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(210, 25);
            this.tableLayoutPanel2.TabIndex = 262;
            // 
            // btnPathLink
            // 
            this.btnPathLink.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnPathLink.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnPathLink.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            this.btnPathLink.FlatAppearance.BorderSize = 0;
            this.btnPathLink.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            this.btnPathLink.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            this.btnPathLink.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPathLink.Image = ((System.Drawing.Image)(resources.GetObject("btnPathLink.Image")));
            this.btnPathLink.Location = new System.Drawing.Point(185, 3);
            this.btnPathLink.Name = "btnPathLink";
            this.btnPathLink.Size = new System.Drawing.Size(22, 19);
            this.btnPathLink.TabIndex = 1;
            this.btnPathLink.UseVisualStyleBackColor = true;
            this.btnPathLink.Click += new System.EventHandler(this.btnFileRPathLink_Click);
            // 
            // tbxScriptPath
            // 
            this.tbxScriptPath.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbxScriptPath.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbxScriptPath.Font = new System.Drawing.Font("华文新魏", 11.5F);
            this.tbxScriptPath.Location = new System.Drawing.Point(0, 2);
            this.tbxScriptPath.Margin = new System.Windows.Forms.Padding(0, 2, 0, 0);
            this.tbxScriptPath.Maximum = 2147483647D;
            this.tbxScriptPath.Minimum = -2147483648D;
            this.tbxScriptPath.MinimumSize = new System.Drawing.Size(1, 1);
            this.tbxScriptPath.Name = "tbxScriptPath";
            this.tbxScriptPath.Size = new System.Drawing.Size(182, 23);
            this.tbxScriptPath.Style = Rex.UI.UIStyle.Custom;
            this.tbxScriptPath.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("华文新魏", 11F);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.label1.Location = new System.Drawing.Point(10, 79);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 16);
            this.label1.TabIndex = 261;
            this.label1.Text = "脚本路径:";
            // 
            // cbxScriptType
            // 
            this.cbxScriptType.BackColor = System.Drawing.Color.AliceBlue;
            this.cbxScriptType.DropDownStyle = Rex.UI.UIDropDownStyle.DropDownList;
            this.cbxScriptType.FillColor = System.Drawing.Color.AliceBlue;
            this.cbxScriptType.Font = new System.Drawing.Font("华文新魏", 11.6F);
            this.cbxScriptType.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.cbxScriptType.ForeDisableColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.cbxScriptType.Items.AddRange(new object[] {
            "Hdvp文件(.hdvp)"});
            this.cbxScriptType.Location = new System.Drawing.Point(83, 38);
            this.cbxScriptType.Margin = new System.Windows.Forms.Padding(0);
            this.cbxScriptType.MinimumSize = new System.Drawing.Size(63, 0);
            this.cbxScriptType.Name = "cbxScriptType";
            this.cbxScriptType.Padding = new System.Windows.Forms.Padding(0, 0, 30, 0);
            this.cbxScriptType.Radius = 2;
            this.cbxScriptType.RectColor = System.Drawing.Color.CornflowerBlue;
            this.cbxScriptType.RectDisableColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.cbxScriptType.RectSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.None;
            this.cbxScriptType.Size = new System.Drawing.Size(210, 24);
            this.cbxScriptType.Style = Rex.UI.UIStyle.Custom;
            this.cbxScriptType.StyleCustomMode = true;
            this.cbxScriptType.SymbolDropDown = 61656;
            this.cbxScriptType.SymbolNormal = 61655;
            this.cbxScriptType.TabIndex = 260;
            this.cbxScriptType.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
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
            this.label18.Text = "脚本类型:";
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
            this.uiTitlePanel1.TabIndex = 214;
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
            this.ldImage.FontStyle = new System.Drawing.Font("华文新魏", 11.5F);
            this.ldImage.Location = new System.Drawing.Point(83, 39);
            this.ldImage.Margin = new System.Windows.Forms.Padding(4, 5, 4, 4);
            this.ldImage.Name = "ldImage";
            this.ldImage.Size = new System.Drawing.Size(210, 24);
            this.ldImage.TabIndex = 216;
            this.ldImage.TextInfo = "";
            this.ldImage.LinkData += new System.EventHandler(this.ldData_LinkData);
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
            this.tabPage1.Controls.Add(this.uiSymbolLabel1);
            this.tabPage1.Controls.Add(this.btnExe);
            this.tabPage1.Controls.Add(this.btnLoad);
            this.tabPage1.Location = new System.Drawing.Point(0, 26);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Size = new System.Drawing.Size(303, 461);
            this.tabPage1.TabIndex = 2;
            this.tabPage1.Text = "调试设置";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // uiSymbolLabel1
            // 
            this.uiSymbolLabel1.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.uiSymbolLabel1.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.uiSymbolLabel1.Location = new System.Drawing.Point(129, 21);
            this.uiSymbolLabel1.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiSymbolLabel1.Name = "uiSymbolLabel1";
            this.uiSymbolLabel1.Padding = new System.Windows.Forms.Padding(28, 0, 0, 0);
            this.uiSymbolLabel1.Size = new System.Drawing.Size(42, 31);
            this.uiSymbolLabel1.Style = Rex.UI.UIStyle.Custom;
            this.uiSymbolLabel1.Symbol = 61816;
            this.uiSymbolLabel1.SymbolColor = System.Drawing.Color.CornflowerBlue;
            this.uiSymbolLabel1.TabIndex = 2;
            // 
            // btnExe
            // 
            this.btnExe.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnExe.FillColor = System.Drawing.Color.CornflowerBlue;
            this.btnExe.Font = new System.Drawing.Font("华文新魏", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnExe.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            this.btnExe.ForeHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            this.btnExe.ForePressColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            this.btnExe.ForeSelectedColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            this.btnExe.Location = new System.Drawing.Point(184, 21);
            this.btnExe.MinimumSize = new System.Drawing.Size(1, 1);
            this.btnExe.Name = "btnExe";
            this.btnExe.Size = new System.Drawing.Size(83, 31);
            this.btnExe.Style = Rex.UI.UIStyle.Custom;
            this.btnExe.TabIndex = 1;
            this.btnExe.Text = "执行程序";
            this.btnExe.Click += new System.EventHandler(this.btnExe_Click);
            // 
            // btnLoad
            // 
            this.btnLoad.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLoad.FillColor = System.Drawing.Color.CornflowerBlue;
            this.btnLoad.Font = new System.Drawing.Font("华文新魏", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnLoad.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            this.btnLoad.ForeHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            this.btnLoad.ForePressColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            this.btnLoad.ForeSelectedColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            this.btnLoad.Location = new System.Drawing.Point(35, 21);
            this.btnLoad.MinimumSize = new System.Drawing.Size(1, 1);
            this.btnLoad.Name = "btnLoad";
            this.btnLoad.Size = new System.Drawing.Size(83, 31);
            this.btnLoad.Style = Rex.UI.UIStyle.Custom;
            this.btnLoad.TabIndex = 0;
            this.btnLoad.Text = "载入程序";
            this.btnLoad.Click += new System.EventHandler(this.btnLoad_Click);
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.uiTitlePanel8);
            this.tabPage4.Location = new System.Drawing.Point(0, 26);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Size = new System.Drawing.Size(303, 461);
            this.tabPage4.TabIndex = 1;
            this.tabPage4.Text = "显示设置";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // uiTitlePanel8
            // 
            this.uiTitlePanel8.Controls.Add(this.cbxFontStye);
            this.uiTitlePanel8.Controls.Add(this.label4);
            this.uiTitlePanel8.Controls.Add(this.chxShowData);
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
            this.uiTitlePanel8.Controls.Add(this.chxShowReg);
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
            this.uiTitlePanel8.Size = new System.Drawing.Size(303, 302);
            this.uiTitlePanel8.Style = Rex.UI.UIStyle.Custom;
            this.uiTitlePanel8.TabIndex = 195;
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
            this.cbxFontStye.Location = new System.Drawing.Point(86, 199);
            this.cbxFontStye.Margin = new System.Windows.Forms.Padding(0);
            this.cbxFontStye.MinimumSize = new System.Drawing.Size(63, 0);
            this.cbxFontStye.Name = "cbxFontStye";
            this.cbxFontStye.Padding = new System.Windows.Forms.Padding(0, 0, 30, 0);
            this.cbxFontStye.Radius = 2;
            this.cbxFontStye.RectColor = System.Drawing.Color.CornflowerBlue;
            this.cbxFontStye.RectDisableColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.cbxFontStye.RectSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.None;
            this.cbxFontStye.Size = new System.Drawing.Size(203, 23);
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
            this.label4.Location = new System.Drawing.Point(14, 204);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(73, 16);
            this.label4.TabIndex = 232;
            this.label4.Text = "字体样式:";
            // 
            // chxShowData
            // 
            this.chxShowData.BackColor = System.Drawing.Color.White;
            this.chxShowData.Checked = true;
            this.chxShowData.Cursor = System.Windows.Forms.Cursors.Hand;
            this.chxShowData.Font = new System.Drawing.Font("华文新魏", 11F);
            this.chxShowData.ImageSize = 14;
            this.chxShowData.Location = new System.Drawing.Point(13, 67);
            this.chxShowData.MinimumSize = new System.Drawing.Size(1, 1);
            this.chxShowData.Name = "chxShowData";
            this.chxShowData.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.chxShowData.Size = new System.Drawing.Size(211, 16);
            this.chxShowData.Style = Rex.UI.UIStyle.Custom;
            this.chxShowData.TabIndex = 231;
            this.chxShowData.Text = "显示数据";
            // 
            // tbxY
            // 
            this.tbxY.Font = new System.Drawing.Font("华文新魏", 11F);
            this.tbxY.FontStyle = null;
            this.tbxY.Location = new System.Drawing.Point(86, 128);
            this.tbxY.Name = "tbxY";
            this.tbxY.Size = new System.Drawing.Size(204, 26);
            this.tbxY.TabIndex = 230;
            this.tbxY.TextInfo = "";
            // 
            // tbxFontSize
            // 
            this.tbxFontSize.BackColor = System.Drawing.Color.White;
            this.tbxFontSize.Font = new System.Drawing.Font("华文新魏", 11.2F);
            this.tbxFontSize.FontStyle = null;
            this.tbxFontSize.Location = new System.Drawing.Point(86, 164);
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
            this.label12.Location = new System.Drawing.Point(14, 171);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(73, 16);
            this.label12.TabIndex = 228;
            this.label12.Text = "字体大小:";
            // 
            // tbxX
            // 
            this.tbxX.Font = new System.Drawing.Font("华文新魏", 11F);
            this.tbxX.FontStyle = null;
            this.tbxX.Location = new System.Drawing.Point(86, 92);
            this.tbxX.Name = "tbxX";
            this.tbxX.Size = new System.Drawing.Size(203, 26);
            this.tbxX.TabIndex = 227;
            this.tbxX.TextInfo = "";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("华文新魏", 11F);
            this.label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.label8.Location = new System.Drawing.Point(14, 136);
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
            this.label10.Location = new System.Drawing.Point(13, 100);
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
            this.tbxPrefix.Location = new System.Drawing.Point(86, 232);
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
            this.label14.Location = new System.Drawing.Point(14, 237);
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
            this.label7.Location = new System.Drawing.Point(14, 270);
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
            this.cpColor.Location = new System.Drawing.Point(86, 265);
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
            // chxShowReg
            // 
            this.chxShowReg.BackColor = System.Drawing.Color.White;
            this.chxShowReg.Checked = true;
            this.chxShowReg.Cursor = System.Windows.Forms.Cursors.Hand;
            this.chxShowReg.Font = new System.Drawing.Font("华文新魏", 11F);
            this.chxShowReg.ImageSize = 14;
            this.chxShowReg.Location = new System.Drawing.Point(13, 41);
            this.chxShowReg.MinimumSize = new System.Drawing.Size(1, 1);
            this.chxShowReg.Name = "chxShowReg";
            this.chxShowReg.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.chxShowReg.Size = new System.Drawing.Size(211, 16);
            this.chxShowReg.Style = Rex.UI.UIStyle.Custom;
            this.chxShowReg.TabIndex = 198;
            this.chxShowReg.Text = "显示区域";
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
            this.mWindowH.TabIndex = 24;
            // 
            // HalconScriptForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(850, 550);
            this.Name = "HalconScriptForm";
            this.panel_bottom.ResumeLayout(false);
            this.panel_center.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbox_Icon)).EndInit();
            this.titlepanel.ResumeLayout(false);
            this.titlepanel.PerformLayout();
            this.uiTabControl1.ResumeLayout(false);
            this.tabPage3.ResumeLayout(false);
            this.pnl2.ResumeLayout(false);
            this.pnl2.PerformLayout();
            this.pnlRect2Params.ResumeLayout(false);
            this.pnlRect2Params.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.uiTitlePanel1.ResumeLayout(false);
            this.uiTitlePanel1.PerformLayout();
            this.tabPage1.ResumeLayout(false);
            this.tabPage4.ResumeLayout(false);
            this.uiTitlePanel8.ResumeLayout(false);
            this.uiTitlePanel8.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private Rex.UI.UITabControl uiTabControl1;
        private System.Windows.Forms.TabPage tabPage4;
        private RexView.HWindow_HE mWindowH;
        private System.Windows.Forms.TabPage tabPage3;
        private Rex.UI.UITitlePanel pnl2;
        private RexControl.MyControls.MyLinkData ldInputHTuple;
        private RexControl.MyControls.MyLinkData ldInputHObject;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private Rex.UI.UITitlePanel pnlRect2Params;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Button btnPathLink;
        private Rex.UI.UITextBox tbxScriptPath;
        private System.Windows.Forms.Label label1;
        private Rex.UI.MyComboBox cbxScriptType;
        private System.Windows.Forms.Label label18;
        private Rex.UI.UITitlePanel uiTitlePanel1;
        private RexControl.MyControls.MyLinkData ldImage;
        private System.Windows.Forms.Label label11;
        private Rex.UI.UITitlePanel uiTitlePanel8;
        private Rex.UI.MyComboBox cbxFontStye;
        private System.Windows.Forms.Label label4;
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
        private Rex.UI.UICheckBox chxShowReg;
        private System.Windows.Forms.TabPage tabPage1;
        private Rex.UI.UIButton btnLoad;
        private Rex.UI.UIButton btnExe;
        private Rex.UI.UISymbolLabel uiSymbolLabel1;
    }
}