
namespace Plugin.ReadFile
{
    partial class ReadFileForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ReadFileForm));
            this.label3 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.cbxFileType = new Rex.UI.MyComboBox();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.tbxFilePath = new RexControl.MyControls.TextBoxEx();
            this.btnFilePath = new System.Windows.Forms.Button();
            this.panel_bottom.SuspendLayout();
            this.panel_center.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbox_Icon)).BeginInit();
            this.titlepanel.SuspendLayout();
            this.tableLayoutPanel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel_bottom
            // 
            this.panel_bottom.Location = new System.Drawing.Point(1, 147);
            this.panel_bottom.Size = new System.Drawing.Size(448, 32);
            // 
            // lblTime
            // 
            this.lblTime.Location = new System.Drawing.Point(204, 4);
            // 
            // btn_Run
            // 
            this.btn_Run.Location = new System.Drawing.Point(342, 4);
            this.btn_Run.Click += new System.EventHandler(this.btn_Run_Click);
            // 
            // panel_center
            // 
            this.panel_center.Controls.Add(this.tableLayoutPanel4);
            this.panel_center.Controls.Add(this.cbxFileType);
            this.panel_center.Controls.Add(this.label18);
            this.panel_center.Controls.Add(this.label3);
            this.panel_center.Size = new System.Drawing.Size(448, 119);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("华文新魏", 11F);
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.label3.Location = new System.Drawing.Point(80, 70);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 16);
            this.label3.TabIndex = 215;
            this.label3.Text = "文件路径:";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.BackColor = System.Drawing.Color.Transparent;
            this.label18.Font = new System.Drawing.Font("华文新魏", 11F);
            this.label18.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.label18.Location = new System.Drawing.Point(80, 36);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(73, 16);
            this.label18.TabIndex = 261;
            this.label18.Text = "文件类型:";
            // 
            // cbxFileType
            // 
            this.cbxFileType.BackColor = System.Drawing.Color.AliceBlue;
            this.cbxFileType.DropDownStyle = Rex.UI.UIDropDownStyle.DropDownList;
            this.cbxFileType.FillColor = System.Drawing.Color.AliceBlue;
            this.cbxFileType.Font = new System.Drawing.Font("华文新魏", 11.6F);
            this.cbxFileType.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.cbxFileType.ForeDisableColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.cbxFileType.Items.AddRange(new object[] {
            "T_HTuple"});
            this.cbxFileType.Location = new System.Drawing.Point(151, 31);
            this.cbxFileType.Margin = new System.Windows.Forms.Padding(0);
            this.cbxFileType.MinimumSize = new System.Drawing.Size(63, 0);
            this.cbxFileType.Name = "cbxFileType";
            this.cbxFileType.Padding = new System.Windows.Forms.Padding(0, 0, 30, 0);
            this.cbxFileType.Radius = 2;
            this.cbxFileType.RectColor = System.Drawing.Color.CornflowerBlue;
            this.cbxFileType.RectDisableColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.cbxFileType.RectSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.None;
            this.cbxFileType.Size = new System.Drawing.Size(210, 24);
            this.cbxFileType.Style = Rex.UI.UIStyle.Custom;
            this.cbxFileType.StyleCustomMode = true;
            this.cbxFileType.SymbolDropDown = 61656;
            this.cbxFileType.SymbolNormal = 61655;
            this.cbxFileType.TabIndex = 262;
            this.cbxFileType.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.BackColor = System.Drawing.Color.AliceBlue;
            this.tableLayoutPanel4.ColumnCount = 2;
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 86.76471F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 13.23529F));
            this.tableLayoutPanel4.Controls.Add(this.tbxFilePath, 0, 0);
            this.tableLayoutPanel4.Controls.Add(this.btnFilePath, 1, 0);
            this.tableLayoutPanel4.Location = new System.Drawing.Point(151, 64);
            this.tableLayoutPanel4.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 1;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tableLayoutPanel4.Size = new System.Drawing.Size(210, 25);
            this.tableLayoutPanel4.TabIndex = 263;
            // 
            // tbxFilePath
            // 
            this.tbxFilePath.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbxFilePath.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbxFilePath.Font = new System.Drawing.Font("华文新魏", 10F);
            this.tbxFilePath.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.tbxFilePath.Location = new System.Drawing.Point(3, 3);
            this.tbxFilePath.Multiline = false;
            this.tbxFilePath.Name = "tbxFilePath";
            this.tbxFilePath.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None;
            this.tbxFilePath.Size = new System.Drawing.Size(176, 19);
            this.tbxFilePath.TabIndex = 0;
            this.tbxFilePath.Text = "";
            // 
            // btnFilePath
            // 
            this.btnFilePath.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnFilePath.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnFilePath.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            this.btnFilePath.FlatAppearance.BorderSize = 0;
            this.btnFilePath.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            this.btnFilePath.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            this.btnFilePath.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFilePath.Image = ((System.Drawing.Image)(resources.GetObject("btnFilePath.Image")));
            this.btnFilePath.Location = new System.Drawing.Point(185, 3);
            this.btnFilePath.Name = "btnFilePath";
            this.btnFilePath.Size = new System.Drawing.Size(22, 19);
            this.btnFilePath.TabIndex = 1;
            this.btnFilePath.UseVisualStyleBackColor = true;
            this.btnFilePath.Click += new System.EventHandler(this.btnFilePath_Click);
            // 
            // ReadFileForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(450, 180);
            this.MaximumSize = new System.Drawing.Size(450, 180);
            this.MinimumSize = new System.Drawing.Size(450, 180);
            this.Name = "ReadFileForm";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.ReadFileForm_FormClosed);
            this.Load += new System.EventHandler(this.ReadFileForm_Load);
            this.LocationChanged += new System.EventHandler(this.ReadFileForm_LocationChanged);
            this.panel_bottom.ResumeLayout(false);
            this.panel_center.ResumeLayout(false);
            this.panel_center.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbox_Icon)).EndInit();
            this.titlepanel.ResumeLayout(false);
            this.titlepanel.PerformLayout();
            this.tableLayoutPanel4.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private Rex.UI.MyComboBox cbxFileType;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
        private RexControl.MyControls.TextBoxEx tbxFilePath;
        private System.Windows.Forms.Button btnFilePath;
    }
}