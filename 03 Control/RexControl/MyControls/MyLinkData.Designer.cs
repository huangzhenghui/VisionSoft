
namespace RexControl.MyControls
{
    partial class MyLinkData
    {
        /// <summary> 
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region 组件设计器生成的代码

        /// <summary> 
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MyLinkData));
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.btnLink = new System.Windows.Forms.Button();
            this.btnDec = new System.Windows.Forms.Button();
            this.tbxData = new RexControl.MyControls.TextBoxEx();
            this.tableLayoutPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.BackColor = System.Drawing.Color.AliceBlue;
            this.tableLayoutPanel2.ColumnCount = 3;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 76.95313F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 11.71875F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 11.32813F));
            this.tableLayoutPanel2.Controls.Add(this.btnLink, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.tbxData, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.btnDec, 2, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel2.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(256, 29);
            this.tableLayoutPanel2.TabIndex = 197;
            // 
            // btnLink
            // 
            this.btnLink.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnLink.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnLink.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            this.btnLink.FlatAppearance.BorderSize = 0;
            this.btnLink.FlatAppearance.MouseDownBackColor = System.Drawing.Color.SkyBlue;
            this.btnLink.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            this.btnLink.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLink.Image = ((System.Drawing.Image)(resources.GetObject("btnLink.Image")));
            this.btnLink.Location = new System.Drawing.Point(199, 3);
            this.btnLink.Margin = new System.Windows.Forms.Padding(3, 3, 0, 3);
            this.btnLink.Name = "btnLink";
            this.btnLink.Size = new System.Drawing.Size(26, 23);
            this.btnLink.TabIndex = 2;
            this.btnLink.UseVisualStyleBackColor = true;
            this.btnLink.Click += new System.EventHandler(this.btnLink_Click);
            this.btnLink.MouseUp += new System.Windows.Forms.MouseEventHandler(this.btnLink_MouseUp);
            // 
            // btnDec
            // 
            this.btnDec.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnDec.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnDec.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            this.btnDec.FlatAppearance.BorderSize = 0;
            this.btnDec.FlatAppearance.MouseDownBackColor = System.Drawing.Color.SkyBlue;
            this.btnDec.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            this.btnDec.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDec.Image = ((System.Drawing.Image)(resources.GetObject("btnDec.Image")));
            this.btnDec.Location = new System.Drawing.Point(227, 3);
            this.btnDec.Margin = new System.Windows.Forms.Padding(2, 3, 0, 3);
            this.btnDec.Name = "btnDec";
            this.btnDec.Size = new System.Drawing.Size(29, 23);
            this.btnDec.TabIndex = 1;
            this.btnDec.UseVisualStyleBackColor = true;
            this.btnDec.Click += new System.EventHandler(this.btnDec_Click);
            this.btnDec.MouseUp += new System.Windows.Forms.MouseEventHandler(this.btnDec_MouseUp);
            // 
            // tbxData
            // 
            this.tbxData.BackColor = System.Drawing.Color.AliceBlue;
            this.tbxData.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbxData.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbxData.Font = new System.Drawing.Font("华文新魏", 11.5F);
            this.tbxData.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.tbxData.Location = new System.Drawing.Point(3, 5);
            this.tbxData.Margin = new System.Windows.Forms.Padding(3, 5, 3, 3);
            this.tbxData.Multiline = false;
            this.tbxData.Name = "tbxData";
            this.tbxData.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None;
            this.tbxData.Size = new System.Drawing.Size(190, 21);
            this.tbxData.TabIndex = 0;
            this.tbxData.Text = "";
            this.tbxData.TextChanged += new System.EventHandler(this.tbxData_TextChanged);
            this.tbxData.KeyUp += new System.Windows.Forms.KeyEventHandler(this.tbxData_KeyUp);
            // 
            // MyLinkData
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.AliceBlue;
            this.Controls.Add(this.tableLayoutPanel2);
            this.Font = new System.Drawing.Font("华文新魏", 11.5F);
            this.Name = "MyLinkData";
            this.Size = new System.Drawing.Size(256, 29);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        public TextBoxEx tbxData;
        public System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        public System.Windows.Forms.Button btnLink;
        public System.Windows.Forms.Button btnDec;
    }
}
