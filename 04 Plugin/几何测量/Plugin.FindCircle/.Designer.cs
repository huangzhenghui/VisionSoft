
namespace Plugin.FindCircle
{
    partial class FindCircleForm
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
            this.mWindowH = new RexView.HWindow_HE();
            this.uiTabControl1 = new Rex.UI.UITabControl();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.pnlRect2Params = new Rex.UI.UITitlePanel();
            this.ldEndAngle = new RexControl.MyControls.MyLinkData();
            this.ldStartAngle = new RexControl.MyControls.MyLinkData();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.tbxLength2 = new RexControl.MyControls.MyTextBoxUpDown();
            this.tbxLength1 = new RexControl.MyControls.MyTextBoxUpDown();
            this.tbxSigma = new RexControl.MyControls.MyTextBoxUpDownD();
            this.tbxContrast = new RexControl.MyControls.MyTextBoxUpDown();
            this.label8 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.ldCenterX = new RexControl.MyControls.MyLinkData();
            this.ldRadius = new RexControl.MyControls.MyLinkData();
            this.ldCenterY = new RexControl.MyControls.MyLinkData();
            this.label1 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.uiTitlePanel1 = new Rex.UI.UITitlePanel();
            this.ldImage = new RexControl.MyControls.MyLinkData();
            this.label11 = new System.Windows.Forms.Label();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.uiTitlePanel4 = new Rex.UI.UITitlePanel();
            this.label23 = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.tbxUpLimit = new Rex.UI.UITextBox();
            this.lblSign = new Rex.UI.UISymbolLabel();
            this.tbxLowLimit = new Rex.UI.UITextBox();
            this.label25 = new System.Windows.Forms.Label();
            this.uiTitlePanel2 = new Rex.UI.UITitlePanel();
            this.tbxMeasureNum = new RexControl.MyControls.MyTextBoxUpDown();
            this.cbxTransition = new Rex.UI.MyComboBox();
            this.cbxSelect = new Rex.UI.MyComboBox();
            this.label14 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.uiTitlePanel3 = new Rex.UI.UITitlePanel();
            this.label2 = new System.Windows.Forms.Label();
            this.cpMeasureRect = new Rex.UI.UIColorPicker();
            this.btnFitImg = new Rex.UI.UISymbolButton();
            this.label10 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.cpProjection = new Rex.UI.UIColorPicker();
            this.cbxInterfaceMode = new Rex.UI.MyComboBox();
            this.label13 = new System.Windows.Forms.Label();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.uiTitlePanel8 = new Rex.UI.UITitlePanel();
            this.tbxPointSize = new Rex.UI.UITextBox();
            this.label26 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.cpCircle = new Rex.UI.UIColorPicker();
            this.cpPoint = new Rex.UI.UIColorPicker();
            this.chxShowCircle = new Rex.UI.UICheckBox();
            this.chxShowPoint = new Rex.UI.UICheckBox();
            this.panel_bottom.SuspendLayout();
            this.panel_center.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbox_Icon)).BeginInit();
            this.titlepanel.SuspendLayout();
            this.uiTabControl1.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.pnlRect2Params.SuspendLayout();
            this.uiTitlePanel1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.uiTitlePanel4.SuspendLayout();
            this.uiTitlePanel2.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.uiTitlePanel3.SuspendLayout();
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
            this.mWindowH.TabIndex = 20;
            // 
            // uiTabControl1
            // 
            this.uiTabControl1.Controls.Add(this.tabPage3);
            this.uiTabControl1.Controls.Add(this.tabPage1);
            this.uiTabControl1.Controls.Add(this.tabPage2);
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
            this.tabPage3.Controls.Add(this.pnlRect2Params);
            this.tabPage3.Controls.Add(this.uiTitlePanel1);
            this.tabPage3.Font = new System.Drawing.Font("隶书", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tabPage3.Location = new System.Drawing.Point(0, 26);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(303, 461);
            this.tabPage3.TabIndex = 0;
            this.tabPage3.Text = "基本设置1";
            // 
            // pnlRect2Params
            // 
            this.pnlRect2Params.Controls.Add(this.ldEndAngle);
            this.pnlRect2Params.Controls.Add(this.ldStartAngle);
            this.pnlRect2Params.Controls.Add(this.label15);
            this.pnlRect2Params.Controls.Add(this.label16);
            this.pnlRect2Params.Controls.Add(this.tbxLength2);
            this.pnlRect2Params.Controls.Add(this.tbxLength1);
            this.pnlRect2Params.Controls.Add(this.tbxSigma);
            this.pnlRect2Params.Controls.Add(this.tbxContrast);
            this.pnlRect2Params.Controls.Add(this.label8);
            this.pnlRect2Params.Controls.Add(this.label4);
            this.pnlRect2Params.Controls.Add(this.label5);
            this.pnlRect2Params.Controls.Add(this.label6);
            this.pnlRect2Params.Controls.Add(this.ldCenterX);
            this.pnlRect2Params.Controls.Add(this.ldRadius);
            this.pnlRect2Params.Controls.Add(this.ldCenterY);
            this.pnlRect2Params.Controls.Add(this.label1);
            this.pnlRect2Params.Controls.Add(this.label18);
            this.pnlRect2Params.Controls.Add(this.label3);
            this.pnlRect2Params.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlRect2Params.FillColor = System.Drawing.Color.White;
            this.pnlRect2Params.Font = new System.Drawing.Font("华文新魏", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.pnlRect2Params.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            this.pnlRect2Params.Location = new System.Drawing.Point(0, 83);
            this.pnlRect2Params.Margin = new System.Windows.Forms.Padding(0);
            this.pnlRect2Params.MinimumSize = new System.Drawing.Size(1, 1);
            this.pnlRect2Params.Name = "pnlRect2Params";
            this.pnlRect2Params.Padding = new System.Windows.Forms.Padding(0, 30, 0, 0);
            this.pnlRect2Params.RadiusSides = Rex.UI.UICornerRadiusSides.None;
            this.pnlRect2Params.RectColor = System.Drawing.Color.White;
            this.pnlRect2Params.Size = new System.Drawing.Size(303, 374);
            this.pnlRect2Params.Style = Rex.UI.UIStyle.Custom;
            this.pnlRect2Params.TabIndex = 45;
            this.pnlRect2Params.Text = "参数设置1";
            this.pnlRect2Params.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.pnlRect2Params.TextAlignment = System.Drawing.ContentAlignment.MiddleRight;
            this.pnlRect2Params.TitleColor = System.Drawing.Color.CornflowerBlue;
            this.pnlRect2Params.TitleInterval = 5;
            // 
            // ldEndAngle
            // 
            this.ldEndAngle.BackColor = System.Drawing.Color.AliceBlue;
            this.ldEndAngle.Font = new System.Drawing.Font("华文新魏", 11F);
            this.ldEndAngle.FontStyle = new System.Drawing.Font("华文新魏", 10.5F);
            this.ldEndAngle.Location = new System.Drawing.Point(83, 185);
            this.ldEndAngle.Margin = new System.Windows.Forms.Padding(2, 9, 4, 4);
            this.ldEndAngle.Name = "ldEndAngle";
            this.ldEndAngle.Size = new System.Drawing.Size(212, 23);
            this.ldEndAngle.TabIndex = 233;
            this.ldEndAngle.TextInfo = "";
            this.ldEndAngle.LinkData += new System.EventHandler(this.ldData_LinkData);
            this.ldEndAngle.RealTimeExe += new System.EventHandler(this.ldData_RealTimeExe);
            // 
            // ldStartAngle
            // 
            this.ldStartAngle.BackColor = System.Drawing.Color.AliceBlue;
            this.ldStartAngle.Font = new System.Drawing.Font("华文新魏", 11F);
            this.ldStartAngle.FontStyle = new System.Drawing.Font("华文新魏", 10.5F);
            this.ldStartAngle.Location = new System.Drawing.Point(83, 150);
            this.ldStartAngle.Margin = new System.Windows.Forms.Padding(2, 9, 4, 4);
            this.ldStartAngle.Name = "ldStartAngle";
            this.ldStartAngle.Size = new System.Drawing.Size(211, 23);
            this.ldStartAngle.TabIndex = 232;
            this.ldStartAngle.TextInfo = "";
            this.ldStartAngle.LinkData += new System.EventHandler(this.ldData_LinkData);
            this.ldStartAngle.RealTimeExe += new System.EventHandler(this.ldData_RealTimeExe);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.BackColor = System.Drawing.Color.Transparent;
            this.label15.Font = new System.Drawing.Font("华文新魏", 11F);
            this.label15.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.label15.Location = new System.Drawing.Point(11, 155);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(73, 16);
            this.label15.TabIndex = 230;
            this.label15.Text = "起始角度:";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.BackColor = System.Drawing.Color.Transparent;
            this.label16.Font = new System.Drawing.Font("华文新魏", 11F);
            this.label16.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.label16.Location = new System.Drawing.Point(11, 191);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(73, 16);
            this.label16.TabIndex = 231;
            this.label16.Text = "终止角度:";
            // 
            // tbxLength2
            // 
            this.tbxLength2.BackColor = System.Drawing.Color.White;
            this.tbxLength2.Font = new System.Drawing.Font("华文新魏", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tbxLength2.FontStyle = new System.Drawing.Font("华文新魏", 10.6F);
            this.tbxLength2.Location = new System.Drawing.Point(83, 257);
            this.tbxLength2.Name = "tbxLength2";
            this.tbxLength2.Size = new System.Drawing.Size(211, 25);
            this.tbxLength2.TabIndex = 229;
            this.tbxLength2.TextInfo = "";
            this.tbxLength2.RealTimeExe += new System.EventHandler(this.ldData_RealTimeExe);
            // 
            // tbxLength1
            // 
            this.tbxLength1.BackColor = System.Drawing.Color.White;
            this.tbxLength1.Font = new System.Drawing.Font("华文新魏", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tbxLength1.FontStyle = new System.Drawing.Font("华文新魏", 10.6F);
            this.tbxLength1.Location = new System.Drawing.Point(83, 221);
            this.tbxLength1.Name = "tbxLength1";
            this.tbxLength1.Size = new System.Drawing.Size(211, 25);
            this.tbxLength1.TabIndex = 228;
            this.tbxLength1.TextInfo = "";
            this.tbxLength1.RealTimeExe += new System.EventHandler(this.ldData_RealTimeExe);
            // 
            // tbxSigma
            // 
            this.tbxSigma.Font = new System.Drawing.Font("华文新魏", 11F);
            this.tbxSigma.FontStyle = null;
            this.tbxSigma.Location = new System.Drawing.Point(83, 294);
            this.tbxSigma.Name = "tbxSigma";
            this.tbxSigma.Size = new System.Drawing.Size(211, 26);
            this.tbxSigma.TabIndex = 223;
            this.tbxSigma.TextInfo = "";
            this.tbxSigma.RealTimeExe += new System.EventHandler(this.ldData_RealTimeExe);
            // 
            // tbxContrast
            // 
            this.tbxContrast.BackColor = System.Drawing.Color.White;
            this.tbxContrast.Font = new System.Drawing.Font("华文新魏", 11.2F);
            this.tbxContrast.FontStyle = null;
            this.tbxContrast.Location = new System.Drawing.Point(83, 331);
            this.tbxContrast.Name = "tbxContrast";
            this.tbxContrast.Size = new System.Drawing.Size(211, 25);
            this.tbxContrast.TabIndex = 222;
            this.tbxContrast.TextInfo = "";
            this.tbxContrast.RealTimeExe += new System.EventHandler(this.ldData_RealTimeExe);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("华文新魏", 11F);
            this.label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.label8.Location = new System.Drawing.Point(11, 335);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(58, 16);
            this.label8.TabIndex = 221;
            this.label8.Text = "对比度:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("华文新魏", 11F);
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.label4.Location = new System.Drawing.Point(11, 263);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 16);
            this.label4.TabIndex = 216;
            this.label4.Text = "短半轴:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("华文新魏", 11F);
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.label5.Location = new System.Drawing.Point(11, 227);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(58, 16);
            this.label5.TabIndex = 215;
            this.label5.Text = "长半轴:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("华文新魏", 11F);
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.label6.Location = new System.Drawing.Point(11, 299);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(73, 16);
            this.label6.TabIndex = 217;
            this.label6.Text = "平滑系数:";
            // 
            // ldCenterX
            // 
            this.ldCenterX.BackColor = System.Drawing.Color.AliceBlue;
            this.ldCenterX.Font = new System.Drawing.Font("华文新魏", 11F);
            this.ldCenterX.FontStyle = new System.Drawing.Font("华文新魏", 10.5F);
            this.ldCenterX.Location = new System.Drawing.Point(83, 43);
            this.ldCenterX.Margin = new System.Windows.Forms.Padding(2, 9, 4, 4);
            this.ldCenterX.Name = "ldCenterX";
            this.ldCenterX.Size = new System.Drawing.Size(210, 23);
            this.ldCenterX.TabIndex = 212;
            this.ldCenterX.TextInfo = "";
            this.ldCenterX.LinkData += new System.EventHandler(this.ldData_LinkData);
            this.ldCenterX.RealTimeExe += new System.EventHandler(this.ldData_RealTimeExe);
            // 
            // ldRadius
            // 
            this.ldRadius.BackColor = System.Drawing.Color.AliceBlue;
            this.ldRadius.Font = new System.Drawing.Font("华文新魏", 11F);
            this.ldRadius.FontStyle = new System.Drawing.Font("华文新魏", 10.5F);
            this.ldRadius.Location = new System.Drawing.Point(83, 115);
            this.ldRadius.Margin = new System.Windows.Forms.Padding(2, 9, 4, 4);
            this.ldRadius.Name = "ldRadius";
            this.ldRadius.Size = new System.Drawing.Size(211, 23);
            this.ldRadius.TabIndex = 214;
            this.ldRadius.TextInfo = "";
            this.ldRadius.LinkData += new System.EventHandler(this.ldData_LinkData);
            this.ldRadius.RealTimeExe += new System.EventHandler(this.ldData_RealTimeExe);
            // 
            // ldCenterY
            // 
            this.ldCenterY.BackColor = System.Drawing.Color.AliceBlue;
            this.ldCenterY.Font = new System.Drawing.Font("华文新魏", 11F);
            this.ldCenterY.FontStyle = new System.Drawing.Font("华文新魏", 10.5F);
            this.ldCenterY.Location = new System.Drawing.Point(83, 79);
            this.ldCenterY.Margin = new System.Windows.Forms.Padding(2, 9, 4, 4);
            this.ldCenterY.Name = "ldCenterY";
            this.ldCenterY.Size = new System.Drawing.Size(210, 23);
            this.ldCenterY.TabIndex = 213;
            this.ldCenterY.TextInfo = "";
            this.ldCenterY.LinkData += new System.EventHandler(this.ldData_LinkData);
            this.ldCenterY.RealTimeExe += new System.EventHandler(this.ldData_RealTimeExe);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("华文新魏", 11F);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.label1.Location = new System.Drawing.Point(10, 83);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 16);
            this.label1.TabIndex = 206;
            this.label1.Text = "中心点-Y:";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.BackColor = System.Drawing.Color.Transparent;
            this.label18.Font = new System.Drawing.Font("华文新魏", 11F);
            this.label18.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.label18.Location = new System.Drawing.Point(10, 47);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(73, 16);
            this.label18.TabIndex = 204;
            this.label18.Text = "中心点-X:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("华文新魏", 11F);
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.label3.Location = new System.Drawing.Point(10, 120);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 16);
            this.label3.TabIndex = 208;
            this.label3.Text = "半径:";
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
            this.ldImage.Location = new System.Drawing.Point(83, 43);
            this.ldImage.Margin = new System.Windows.Forms.Padding(4, 5, 4, 4);
            this.ldImage.Name = "ldImage";
            this.ldImage.Size = new System.Drawing.Size(210, 24);
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
            this.label11.Location = new System.Drawing.Point(10, 47);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(73, 16);
            this.label11.TabIndex = 191;
            this.label11.Text = "输入图像:";
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.White;
            this.tabPage1.Controls.Add(this.uiTitlePanel4);
            this.tabPage1.Controls.Add(this.uiTitlePanel2);
            this.tabPage1.Location = new System.Drawing.Point(0, 26);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Size = new System.Drawing.Size(303, 461);
            this.tabPage1.TabIndex = 2;
            this.tabPage1.Text = "基本设置2";
            // 
            // uiTitlePanel4
            // 
            this.uiTitlePanel4.Controls.Add(this.label23);
            this.uiTitlePanel4.Controls.Add(this.label22);
            this.uiTitlePanel4.Controls.Add(this.label21);
            this.uiTitlePanel4.Controls.Add(this.tbxUpLimit);
            this.uiTitlePanel4.Controls.Add(this.lblSign);
            this.uiTitlePanel4.Controls.Add(this.tbxLowLimit);
            this.uiTitlePanel4.Controls.Add(this.label25);
            this.uiTitlePanel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.uiTitlePanel4.FillColor = System.Drawing.Color.White;
            this.uiTitlePanel4.Font = new System.Drawing.Font("华文新魏", 11.5F);
            this.uiTitlePanel4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            this.uiTitlePanel4.Location = new System.Drawing.Point(0, 146);
            this.uiTitlePanel4.Margin = new System.Windows.Forms.Padding(0);
            this.uiTitlePanel4.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiTitlePanel4.Name = "uiTitlePanel4";
            this.uiTitlePanel4.Padding = new System.Windows.Forms.Padding(0, 30, 0, 0);
            this.uiTitlePanel4.RadiusSides = Rex.UI.UICornerRadiusSides.None;
            this.uiTitlePanel4.RectColor = System.Drawing.Color.White;
            this.uiTitlePanel4.Size = new System.Drawing.Size(303, 180);
            this.uiTitlePanel4.Style = Rex.UI.UIStyle.Custom;
            this.uiTitlePanel4.TabIndex = 49;
            this.uiTitlePanel4.Text = "点位设置";
            this.uiTitlePanel4.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.uiTitlePanel4.TextAlignment = System.Drawing.ContentAlignment.MiddleRight;
            this.uiTitlePanel4.TitleColor = System.Drawing.Color.CornflowerBlue;
            this.uiTitlePanel4.TitleInterval = 5;
            // 
            // label23
            // 
            this.label23.ForeColor = System.Drawing.Color.LightSalmon;
            this.label23.Location = new System.Drawing.Point(9, 90);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(142, 22);
            this.label23.TabIndex = 268;
            this.label23.Text = "注:点位为升序";
            // 
            // label22
            // 
            this.label22.Font = new System.Drawing.Font("华文新魏", 12F);
            this.label22.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.label22.Location = new System.Drawing.Point(268, 42);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(27, 21);
            this.label22.TabIndex = 208;
            this.label22.Text = "%";
            // 
            // label21
            // 
            this.label21.Font = new System.Drawing.Font("华文新魏", 12F);
            this.label21.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.label21.Location = new System.Drawing.Point(148, 42);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(26, 21);
            this.label21.TabIndex = 207;
            this.label21.Text = "%";
            // 
            // tbxUpLimit
            // 
            this.tbxUpLimit.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbxUpLimit.Font = new System.Drawing.Font("华文新魏", 11F);
            this.tbxUpLimit.Location = new System.Drawing.Point(208, 38);
            this.tbxUpLimit.Margin = new System.Windows.Forms.Padding(0);
            this.tbxUpLimit.Maximum = 2147483647D;
            this.tbxUpLimit.Minimum = -2147483648D;
            this.tbxUpLimit.MinimumSize = new System.Drawing.Size(1, 1);
            this.tbxUpLimit.Name = "tbxUpLimit";
            this.tbxUpLimit.Radius = 10;
            this.tbxUpLimit.Size = new System.Drawing.Size(60, 23);
            this.tbxUpLimit.Style = Rex.UI.UIStyle.Custom;
            this.tbxUpLimit.TabIndex = 206;
            this.tbxUpLimit.Text = "0";
            this.tbxUpLimit.Type = Rex.UI.UITextBox.UIEditType.Integer;
            // 
            // lblSign
            // 
            this.lblSign.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.lblSign.Location = new System.Drawing.Point(170, 36);
            this.lblSign.MinimumSize = new System.Drawing.Size(1, 1);
            this.lblSign.Name = "lblSign";
            this.lblSign.Padding = new System.Windows.Forms.Padding(28, 0, 0, 0);
            this.lblSign.Size = new System.Drawing.Size(30, 29);
            this.lblSign.Style = Rex.UI.UIStyle.Custom;
            this.lblSign.Symbol = 61566;
            this.lblSign.TabIndex = 21;
            // 
            // tbxLowLimit
            // 
            this.tbxLowLimit.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbxLowLimit.Font = new System.Drawing.Font("华文新魏", 11F);
            this.tbxLowLimit.Location = new System.Drawing.Point(85, 38);
            this.tbxLowLimit.Margin = new System.Windows.Forms.Padding(0);
            this.tbxLowLimit.Maximum = 2147483647D;
            this.tbxLowLimit.Minimum = -2147483648D;
            this.tbxLowLimit.MinimumSize = new System.Drawing.Size(1, 1);
            this.tbxLowLimit.Name = "tbxLowLimit";
            this.tbxLowLimit.Radius = 10;
            this.tbxLowLimit.Size = new System.Drawing.Size(60, 23);
            this.tbxLowLimit.Style = Rex.UI.UIStyle.Custom;
            this.tbxLowLimit.TabIndex = 205;
            this.tbxLowLimit.Text = "0";
            this.tbxLowLimit.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.tbxLowLimit.Type = Rex.UI.UITextBox.UIEditType.Integer;
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.BackColor = System.Drawing.Color.Transparent;
            this.label25.Font = new System.Drawing.Font("华文新魏", 11F);
            this.label25.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.label25.Location = new System.Drawing.Point(9, 42);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(73, 16);
            this.label25.TabIndex = 204;
            this.label25.Text = "点位选择:";
            // 
            // uiTitlePanel2
            // 
            this.uiTitlePanel2.Controls.Add(this.tbxMeasureNum);
            this.uiTitlePanel2.Controls.Add(this.cbxTransition);
            this.uiTitlePanel2.Controls.Add(this.cbxSelect);
            this.uiTitlePanel2.Controls.Add(this.label14);
            this.uiTitlePanel2.Controls.Add(this.label17);
            this.uiTitlePanel2.Controls.Add(this.label19);
            this.uiTitlePanel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.uiTitlePanel2.FillColor = System.Drawing.Color.White;
            this.uiTitlePanel2.Font = new System.Drawing.Font("华文新魏", 11.5F);
            this.uiTitlePanel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            this.uiTitlePanel2.Location = new System.Drawing.Point(0, 0);
            this.uiTitlePanel2.Margin = new System.Windows.Forms.Padding(0);
            this.uiTitlePanel2.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiTitlePanel2.Name = "uiTitlePanel2";
            this.uiTitlePanel2.Padding = new System.Windows.Forms.Padding(0, 30, 0, 0);
            this.uiTitlePanel2.RadiusSides = Rex.UI.UICornerRadiusSides.None;
            this.uiTitlePanel2.RectColor = System.Drawing.Color.White;
            this.uiTitlePanel2.Size = new System.Drawing.Size(303, 146);
            this.uiTitlePanel2.Style = Rex.UI.UIStyle.Custom;
            this.uiTitlePanel2.TabIndex = 48;
            this.uiTitlePanel2.Text = "参数设置2";
            this.uiTitlePanel2.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.uiTitlePanel2.TextAlignment = System.Drawing.ContentAlignment.MiddleRight;
            this.uiTitlePanel2.TitleColor = System.Drawing.Color.CornflowerBlue;
            this.uiTitlePanel2.TitleInterval = 5;
            // 
            // tbxMeasureNum
            // 
            this.tbxMeasureNum.BackColor = System.Drawing.Color.White;
            this.tbxMeasureNum.Font = new System.Drawing.Font("华文新魏", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tbxMeasureNum.FontStyle = new System.Drawing.Font("华文新魏", 10.6F);
            this.tbxMeasureNum.Location = new System.Drawing.Point(85, 109);
            this.tbxMeasureNum.Name = "tbxMeasureNum";
            this.tbxMeasureNum.Size = new System.Drawing.Size(210, 25);
            this.tbxMeasureNum.TabIndex = 230;
            this.tbxMeasureNum.TextInfo = "";
            this.tbxMeasureNum.RealTimeExe += new System.EventHandler(this.ldData_RealTimeExe);
            // 
            // cbxTransition
            // 
            this.cbxTransition.BackColor = System.Drawing.Color.AliceBlue;
            this.cbxTransition.DropDownStyle = Rex.UI.UIDropDownStyle.DropDownList;
            this.cbxTransition.FillColor = System.Drawing.Color.AliceBlue;
            this.cbxTransition.Font = new System.Drawing.Font("华文新魏", 11.6F);
            this.cbxTransition.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.cbxTransition.ForeDisableColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.cbxTransition.Items.AddRange(new object[] {
            "all",
            "positive",
            "negative"});
            this.cbxTransition.Location = new System.Drawing.Point(85, 73);
            this.cbxTransition.Margin = new System.Windows.Forms.Padding(0);
            this.cbxTransition.MinimumSize = new System.Drawing.Size(63, 0);
            this.cbxTransition.Name = "cbxTransition";
            this.cbxTransition.Padding = new System.Windows.Forms.Padding(0, 0, 30, 0);
            this.cbxTransition.Radius = 2;
            this.cbxTransition.RectColor = System.Drawing.Color.CornflowerBlue;
            this.cbxTransition.RectDisableColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.cbxTransition.RectSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.None;
            this.cbxTransition.Size = new System.Drawing.Size(210, 24);
            this.cbxTransition.Style = Rex.UI.UIStyle.Custom;
            this.cbxTransition.StyleCustomMode = true;
            this.cbxTransition.SymbolDropDown = 61656;
            this.cbxTransition.SymbolNormal = 61655;
            this.cbxTransition.TabIndex = 226;
            this.cbxTransition.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // cbxSelect
            // 
            this.cbxSelect.BackColor = System.Drawing.Color.AliceBlue;
            this.cbxSelect.DropDownStyle = Rex.UI.UIDropDownStyle.DropDownList;
            this.cbxSelect.FillColor = System.Drawing.Color.AliceBlue;
            this.cbxSelect.Font = new System.Drawing.Font("华文新魏", 11.6F);
            this.cbxSelect.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.cbxSelect.ForeDisableColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.cbxSelect.Items.AddRange(new object[] {
            "all",
            "first",
            "last"});
            this.cbxSelect.Location = new System.Drawing.Point(85, 37);
            this.cbxSelect.Margin = new System.Windows.Forms.Padding(0);
            this.cbxSelect.MinimumSize = new System.Drawing.Size(63, 0);
            this.cbxSelect.Name = "cbxSelect";
            this.cbxSelect.Padding = new System.Windows.Forms.Padding(0, 0, 30, 0);
            this.cbxSelect.Radius = 2;
            this.cbxSelect.RectColor = System.Drawing.Color.CornflowerBlue;
            this.cbxSelect.RectDisableColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.cbxSelect.RectSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.None;
            this.cbxSelect.Size = new System.Drawing.Size(210, 24);
            this.cbxSelect.Style = Rex.UI.UIStyle.Custom;
            this.cbxSelect.StyleCustomMode = true;
            this.cbxSelect.SymbolDropDown = 61656;
            this.cbxSelect.SymbolNormal = 61655;
            this.cbxSelect.TabIndex = 225;
            this.cbxSelect.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.BackColor = System.Drawing.Color.Transparent;
            this.label14.Font = new System.Drawing.Font("华文新魏", 11F);
            this.label14.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.label14.Location = new System.Drawing.Point(9, 115);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(73, 16);
            this.label14.TabIndex = 216;
            this.label14.Text = "矩形数量:";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.BackColor = System.Drawing.Color.Transparent;
            this.label17.Font = new System.Drawing.Font("华文新魏", 11F);
            this.label17.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.label17.Location = new System.Drawing.Point(9, 78);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(73, 16);
            this.label17.TabIndex = 206;
            this.label17.Text = "明暗变化:";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.BackColor = System.Drawing.Color.Transparent;
            this.label19.Font = new System.Drawing.Font("华文新魏", 11F);
            this.label19.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.label19.Location = new System.Drawing.Point(9, 42);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(73, 16);
            this.label19.TabIndex = 204;
            this.label19.Text = "先后选择:";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.uiTitlePanel3);
            this.tabPage2.Location = new System.Drawing.Point(0, 26);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Size = new System.Drawing.Size(303, 461);
            this.tabPage2.TabIndex = 3;
            this.tabPage2.Text = "编辑设置";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // uiTitlePanel3
            // 
            this.uiTitlePanel3.Controls.Add(this.label2);
            this.uiTitlePanel3.Controls.Add(this.cpMeasureRect);
            this.uiTitlePanel3.Controls.Add(this.btnFitImg);
            this.uiTitlePanel3.Controls.Add(this.label10);
            this.uiTitlePanel3.Controls.Add(this.label12);
            this.uiTitlePanel3.Controls.Add(this.cpProjection);
            this.uiTitlePanel3.Controls.Add(this.cbxInterfaceMode);
            this.uiTitlePanel3.Controls.Add(this.label13);
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
            this.uiTitlePanel3.Size = new System.Drawing.Size(303, 185);
            this.uiTitlePanel3.Style = Rex.UI.UIStyle.Custom;
            this.uiTitlePanel3.TabIndex = 210;
            this.uiTitlePanel3.Text = "编辑设置";
            this.uiTitlePanel3.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.uiTitlePanel3.TitleColor = System.Drawing.Color.CornflowerBlue;
            this.uiTitlePanel3.TitleInterval = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("华文新魏", 11F);
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.label2.Location = new System.Drawing.Point(10, 112);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 16);
            this.label2.TabIndex = 235;
            this.label2.Text = "矩形颜色:";
            // 
            // cpMeasureRect
            // 
            this.cpMeasureRect.DropDownStyle = Rex.UI.UIDropDownStyle.DropDownList;
            this.cpMeasureRect.FillColor = System.Drawing.Color.AliceBlue;
            this.cpMeasureRect.FillDisableColor = System.Drawing.Color.AliceBlue;
            this.cpMeasureRect.Font = new System.Drawing.Font("微软雅黑", 9F);
            this.cpMeasureRect.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.cpMeasureRect.Location = new System.Drawing.Point(86, 108);
            this.cpMeasureRect.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cpMeasureRect.MinimumSize = new System.Drawing.Size(63, 0);
            this.cpMeasureRect.Name = "cpMeasureRect";
            this.cpMeasureRect.Padding = new System.Windows.Forms.Padding(0, 0, 30, 0);
            this.cpMeasureRect.RadiusSides = Rex.UI.UICornerRadiusSides.None;
            this.cpMeasureRect.RectColor = System.Drawing.Color.White;
            this.cpMeasureRect.RectSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.Bottom;
            this.cpMeasureRect.Size = new System.Drawing.Size(203, 23);
            this.cpMeasureRect.Style = Rex.UI.UIStyle.Custom;
            this.cpMeasureRect.StyleCustomMode = true;
            this.cpMeasureRect.TabIndex = 197;
            this.cpMeasureRect.Text = "uiColorPicker1";
            this.cpMeasureRect.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.cpMeasureRect.Value = System.Drawing.Color.MediumAquamarine;
            this.cpMeasureRect.ValueChanged += new Rex.UI.UIColorPicker.OnColorChanged(this.cpColor_ValueChanged);
            // 
            // btnFitImg
            // 
            this.btnFitImg.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnFitImg.Font = new System.Drawing.Font("华文新魏", 12F);
            this.btnFitImg.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            this.btnFitImg.ForeHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            this.btnFitImg.ForePressColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            this.btnFitImg.ForeSelectedColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            this.btnFitImg.Location = new System.Drawing.Point(86, 142);
            this.btnFitImg.MinimumSize = new System.Drawing.Size(1, 1);
            this.btnFitImg.Name = "btnFitImg";
            this.btnFitImg.Size = new System.Drawing.Size(204, 21);
            this.btnFitImg.Style = Rex.UI.UIStyle.Custom;
            this.btnFitImg.Symbol = 61732;
            this.btnFitImg.TabIndex = 208;
            this.btnFitImg.Text = "执行";
            this.btnFitImg.Click += new System.EventHandler(this.btnFitImg_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.Font = new System.Drawing.Font("华文新魏", 11F);
            this.label10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.label10.Location = new System.Drawing.Point(10, 145);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(73, 16);
            this.label10.TabIndex = 234;
            this.label10.Text = "适应图像:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.Color.Transparent;
            this.label12.Font = new System.Drawing.Font("华文新魏", 11F);
            this.label12.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.label12.Location = new System.Drawing.Point(10, 78);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(73, 16);
            this.label12.TabIndex = 197;
            this.label12.Text = "投影颜色:";
            // 
            // cpProjection
            // 
            this.cpProjection.DropDownStyle = Rex.UI.UIDropDownStyle.DropDownList;
            this.cpProjection.FillColor = System.Drawing.Color.AliceBlue;
            this.cpProjection.FillDisableColor = System.Drawing.Color.AliceBlue;
            this.cpProjection.Font = new System.Drawing.Font("微软雅黑", 9F);
            this.cpProjection.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.cpProjection.Location = new System.Drawing.Point(86, 74);
            this.cpProjection.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cpProjection.MinimumSize = new System.Drawing.Size(63, 0);
            this.cpProjection.Name = "cpProjection";
            this.cpProjection.Padding = new System.Windows.Forms.Padding(0, 0, 30, 0);
            this.cpProjection.RadiusSides = Rex.UI.UICornerRadiusSides.None;
            this.cpProjection.RectColor = System.Drawing.Color.White;
            this.cpProjection.RectSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.Bottom;
            this.cpProjection.Size = new System.Drawing.Size(203, 23);
            this.cpProjection.Style = Rex.UI.UIStyle.Custom;
            this.cpProjection.StyleCustomMode = true;
            this.cpProjection.TabIndex = 196;
            this.cpProjection.Text = "uiColorPicker1";
            this.cpProjection.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.cpProjection.Value = System.Drawing.Color.MediumAquamarine;
            this.cpProjection.ValueChanged += new Rex.UI.UIColorPicker.OnColorChanged(this.cpColor_ValueChanged);
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
            this.cbxInterfaceMode.SelectedIndexChanged += new System.EventHandler(this.cbxInterfaceMode_SelectedValueChanged);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.BackColor = System.Drawing.Color.Transparent;
            this.label13.Font = new System.Drawing.Font("华文新魏", 11F);
            this.label13.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.label13.Location = new System.Drawing.Point(10, 44);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(73, 16);
            this.label13.TabIndex = 232;
            this.label13.Text = "界面模式:";
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
            this.uiTitlePanel8.Controls.Add(this.tbxPointSize);
            this.uiTitlePanel8.Controls.Add(this.label26);
            this.uiTitlePanel8.Controls.Add(this.label9);
            this.uiTitlePanel8.Controls.Add(this.label7);
            this.uiTitlePanel8.Controls.Add(this.cpCircle);
            this.uiTitlePanel8.Controls.Add(this.cpPoint);
            this.uiTitlePanel8.Controls.Add(this.chxShowCircle);
            this.uiTitlePanel8.Controls.Add(this.chxShowPoint);
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
            this.uiTitlePanel8.Size = new System.Drawing.Size(303, 316);
            this.uiTitlePanel8.Style = Rex.UI.UIStyle.Custom;
            this.uiTitlePanel8.TabIndex = 210;
            this.uiTitlePanel8.Text = "显示设置";
            this.uiTitlePanel8.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.uiTitlePanel8.TitleColor = System.Drawing.Color.CornflowerBlue;
            this.uiTitlePanel8.TitleInterval = 5;
            // 
            // tbxPointSize
            // 
            this.tbxPointSize.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbxPointSize.Font = new System.Drawing.Font("华文新魏", 11.5F);
            this.tbxPointSize.Location = new System.Drawing.Point(86, 100);
            this.tbxPointSize.Margin = new System.Windows.Forms.Padding(0);
            this.tbxPointSize.Maximum = 2147483647D;
            this.tbxPointSize.Minimum = -2147483648D;
            this.tbxPointSize.MinimumSize = new System.Drawing.Size(1, 1);
            this.tbxPointSize.Name = "tbxPointSize";
            this.tbxPointSize.Radius = 10;
            this.tbxPointSize.Size = new System.Drawing.Size(203, 23);
            this.tbxPointSize.Style = Rex.UI.UIStyle.Custom;
            this.tbxPointSize.TabIndex = 231;
            this.tbxPointSize.Text = "0";
            this.tbxPointSize.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.tbxPointSize.Type = Rex.UI.UITextBox.UIEditType.Integer;
            // 
            // label26
            // 
            this.label26.AutoSize = true;
            this.label26.BackColor = System.Drawing.Color.Transparent;
            this.label26.Font = new System.Drawing.Font("华文新魏", 11F);
            this.label26.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.label26.Location = new System.Drawing.Point(10, 106);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(73, 16);
            this.label26.TabIndex = 230;
            this.label26.Text = "点位大小:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("华文新魏", 11F);
            this.label9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.label9.Location = new System.Drawing.Point(10, 173);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(73, 16);
            this.label9.TabIndex = 203;
            this.label9.Text = "圆弧颜色:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("华文新魏", 11F);
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.label7.Location = new System.Drawing.Point(10, 140);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(73, 16);
            this.label7.TabIndex = 201;
            this.label7.Text = "点位颜色:";
            // 
            // cpCircle
            // 
            this.cpCircle.DropDownStyle = Rex.UI.UIDropDownStyle.DropDownList;
            this.cpCircle.FillColor = System.Drawing.Color.AliceBlue;
            this.cpCircle.FillDisableColor = System.Drawing.Color.AliceBlue;
            this.cpCircle.Font = new System.Drawing.Font("微软雅黑", 9F);
            this.cpCircle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.cpCircle.Location = new System.Drawing.Point(86, 170);
            this.cpCircle.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cpCircle.MinimumSize = new System.Drawing.Size(63, 0);
            this.cpCircle.Name = "cpCircle";
            this.cpCircle.Padding = new System.Windows.Forms.Padding(0, 0, 30, 0);
            this.cpCircle.RadiusSides = Rex.UI.UICornerRadiusSides.None;
            this.cpCircle.RectColor = System.Drawing.Color.White;
            this.cpCircle.RectSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.Bottom;
            this.cpCircle.Size = new System.Drawing.Size(203, 23);
            this.cpCircle.Style = Rex.UI.UIStyle.Custom;
            this.cpCircle.StyleCustomMode = true;
            this.cpCircle.TabIndex = 202;
            this.cpCircle.Text = "uiColorPicker1";
            this.cpCircle.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.cpCircle.Value = System.Drawing.Color.DarkOrchid;
            // 
            // cpPoint
            // 
            this.cpPoint.DropDownStyle = Rex.UI.UIDropDownStyle.DropDownList;
            this.cpPoint.FillColor = System.Drawing.Color.AliceBlue;
            this.cpPoint.FillDisableColor = System.Drawing.Color.AliceBlue;
            this.cpPoint.Font = new System.Drawing.Font("微软雅黑", 9F);
            this.cpPoint.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.cpPoint.Location = new System.Drawing.Point(86, 135);
            this.cpPoint.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cpPoint.MinimumSize = new System.Drawing.Size(63, 0);
            this.cpPoint.Name = "cpPoint";
            this.cpPoint.Padding = new System.Windows.Forms.Padding(0, 0, 30, 0);
            this.cpPoint.RadiusSides = Rex.UI.UICornerRadiusSides.None;
            this.cpPoint.RectColor = System.Drawing.Color.White;
            this.cpPoint.RectSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.Bottom;
            this.cpPoint.Size = new System.Drawing.Size(203, 23);
            this.cpPoint.Style = Rex.UI.UIStyle.Custom;
            this.cpPoint.StyleCustomMode = true;
            this.cpPoint.TabIndex = 200;
            this.cpPoint.Text = "uiColorPicker1";
            this.cpPoint.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.cpPoint.Value = System.Drawing.Color.DarkOrchid;
            // 
            // chxShowCircle
            // 
            this.chxShowCircle.BackColor = System.Drawing.Color.White;
            this.chxShowCircle.Checked = true;
            this.chxShowCircle.Cursor = System.Windows.Forms.Cursors.Hand;
            this.chxShowCircle.Font = new System.Drawing.Font("华文新魏", 11F);
            this.chxShowCircle.ImageSize = 14;
            this.chxShowCircle.Location = new System.Drawing.Point(13, 73);
            this.chxShowCircle.MinimumSize = new System.Drawing.Size(1, 1);
            this.chxShowCircle.Name = "chxShowCircle";
            this.chxShowCircle.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.chxShowCircle.Size = new System.Drawing.Size(211, 16);
            this.chxShowCircle.Style = Rex.UI.UIStyle.Custom;
            this.chxShowCircle.TabIndex = 199;
            this.chxShowCircle.Text = "显示圆弧";
            // 
            // chxShowPoint
            // 
            this.chxShowPoint.BackColor = System.Drawing.Color.White;
            this.chxShowPoint.Checked = true;
            this.chxShowPoint.Cursor = System.Windows.Forms.Cursors.Hand;
            this.chxShowPoint.Font = new System.Drawing.Font("华文新魏", 11F);
            this.chxShowPoint.ImageSize = 14;
            this.chxShowPoint.Location = new System.Drawing.Point(13, 45);
            this.chxShowPoint.MinimumSize = new System.Drawing.Size(1, 1);
            this.chxShowPoint.Name = "chxShowPoint";
            this.chxShowPoint.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.chxShowPoint.Size = new System.Drawing.Size(211, 16);
            this.chxShowPoint.Style = Rex.UI.UIStyle.Custom;
            this.chxShowPoint.TabIndex = 198;
            this.chxShowPoint.Text = "显示点位";
            // 
            // FindCircleForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(850, 550);
            this.Name = "FindCircleForm";
            this.Load += new System.EventHandler(this.FindCircleForm_Load);
            this.panel_bottom.ResumeLayout(false);
            this.panel_center.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbox_Icon)).EndInit();
            this.titlepanel.ResumeLayout(false);
            this.titlepanel.PerformLayout();
            this.uiTabControl1.ResumeLayout(false);
            this.tabPage3.ResumeLayout(false);
            this.pnlRect2Params.ResumeLayout(false);
            this.pnlRect2Params.PerformLayout();
            this.uiTitlePanel1.ResumeLayout(false);
            this.uiTitlePanel1.PerformLayout();
            this.tabPage1.ResumeLayout(false);
            this.uiTitlePanel4.ResumeLayout(false);
            this.uiTitlePanel4.PerformLayout();
            this.uiTitlePanel2.ResumeLayout(false);
            this.uiTitlePanel2.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.uiTitlePanel3.ResumeLayout(false);
            this.uiTitlePanel3.PerformLayout();
            this.tabPage4.ResumeLayout(false);
            this.uiTitlePanel8.ResumeLayout(false);
            this.uiTitlePanel8.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private RexView.HWindow_HE mWindowH;
        private Rex.UI.UITabControl uiTabControl1;
        private System.Windows.Forms.TabPage tabPage3;
        private Rex.UI.UITitlePanel uiTitlePanel1;
        private RexControl.MyControls.MyLinkData ldImage;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TabPage tabPage4;
        private Rex.UI.UITitlePanel pnlRect2Params;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label3;
        private RexControl.MyControls.MyLinkData ldCenterX;
        private RexControl.MyControls.MyLinkData ldRadius;
        private RexControl.MyControls.MyLinkData ldCenterY;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TabPage tabPage1;
        private RexControl.MyControls.MyTextBoxUpDown tbxContrast;
        private RexControl.MyControls.MyTextBoxUpDownD tbxSigma;
        private Rex.UI.UITitlePanel uiTitlePanel8;
        private Rex.UI.UITextBox tbxPointSize;
        private System.Windows.Forms.Label label26;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label7;
        private Rex.UI.UIColorPicker cpCircle;
        private Rex.UI.UIColorPicker cpPoint;
        private Rex.UI.UICheckBox chxShowCircle;
        private Rex.UI.UICheckBox chxShowPoint;
        private Rex.UI.UITitlePanel uiTitlePanel4;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Label label21;
        private Rex.UI.UITextBox tbxUpLimit;
        private Rex.UI.UISymbolLabel lblSign;
        private Rex.UI.UITextBox tbxLowLimit;
        private System.Windows.Forms.Label label25;
        private Rex.UI.UITitlePanel uiTitlePanel2;
        private RexControl.MyControls.MyTextBoxUpDown tbxMeasureNum;
        private Rex.UI.MyComboBox cbxTransition;
        private Rex.UI.MyComboBox cbxSelect;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label19;
        private RexControl.MyControls.MyTextBoxUpDown tbxLength2;
        private RexControl.MyControls.MyTextBoxUpDown tbxLength1;
        private RexControl.MyControls.MyLinkData ldEndAngle;
        private RexControl.MyControls.MyLinkData ldStartAngle;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TabPage tabPage2;
        private Rex.UI.UITitlePanel uiTitlePanel3;
        private System.Windows.Forms.Label label2;
        private Rex.UI.UIColorPicker cpMeasureRect;
        private Rex.UI.UISymbolButton btnFitImg;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label12;
        private Rex.UI.UIColorPicker cpProjection;
        private Rex.UI.MyComboBox cbxInterfaceMode;
        private System.Windows.Forms.Label label13;
    }
}