
namespace Plugin.SaveImage
{
    partial class SaveImageForm
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
            this.tbxImgName = new Rex.UI.UITextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.tbxFileName = new Rex.UI.UITextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cbxStoreFormat = new Rex.UI.MyComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.ldImage = new RexControl.MyControls.MyLinkData();
            this.label11 = new System.Windows.Forms.Label();
            this.cbxImgType = new Rex.UI.MyComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.panel_bottom.SuspendLayout();
            this.panel_center.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbox_Icon)).BeginInit();
            this.titlepanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel_bottom
            // 
            this.panel_bottom.Location = new System.Drawing.Point(1, 295);
            this.panel_bottom.Size = new System.Drawing.Size(521, 32);
            // 
            // lblTime
            // 
            this.lblTime.Location = new System.Drawing.Point(277, 4);
            // 
            // btn_Run
            // 
            this.btn_Run.Location = new System.Drawing.Point(415, 4);
            this.btn_Run.Click += new System.EventHandler(this.btn_Run_Click);
            // 
            // panel_center
            // 
            this.panel_center.Controls.Add(this.tbxImgName);
            this.panel_center.Controls.Add(this.label6);
            this.panel_center.Controls.Add(this.tbxFileName);
            this.panel_center.Controls.Add(this.label1);
            this.panel_center.Controls.Add(this.cbxStoreFormat);
            this.panel_center.Controls.Add(this.label2);
            this.panel_center.Controls.Add(this.ldImage);
            this.panel_center.Controls.Add(this.label11);
            this.panel_center.Controls.Add(this.cbxImgType);
            this.panel_center.Controls.Add(this.label3);
            this.panel_center.Size = new System.Drawing.Size(521, 267);
            // 
            // tbxImgName
            // 
            this.tbxImgName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbxImgName.FillColor = System.Drawing.Color.AliceBlue;
            this.tbxImgName.FillDisableColor = System.Drawing.Color.AliceBlue;
            this.tbxImgName.Font = new System.Drawing.Font("华文新魏", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tbxImgName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.tbxImgName.ForeDisableColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.tbxImgName.Location = new System.Drawing.Point(195, 152);
            this.tbxImgName.Margin = new System.Windows.Forms.Padding(0);
            this.tbxImgName.Maximum = 2147483647D;
            this.tbxImgName.Minimum = -2147483648D;
            this.tbxImgName.MinimumSize = new System.Drawing.Size(1, 1);
            this.tbxImgName.Name = "tbxImgName";
            this.tbxImgName.RectColor = System.Drawing.Color.AliceBlue;
            this.tbxImgName.Size = new System.Drawing.Size(211, 23);
            this.tbxImgName.Style = Rex.UI.UIStyle.Custom;
            this.tbxImgName.TabIndex = 255;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("华文新魏", 11F);
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.label6.Location = new System.Drawing.Point(119, 158);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(73, 16);
            this.label6.TabIndex = 254;
            this.label6.Text = "图像名称:";
            // 
            // tbxFileName
            // 
            this.tbxFileName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbxFileName.FillColor = System.Drawing.Color.AliceBlue;
            this.tbxFileName.FillDisableColor = System.Drawing.Color.AliceBlue;
            this.tbxFileName.Font = new System.Drawing.Font("华文新魏", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tbxFileName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.tbxFileName.ForeDisableColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.tbxFileName.Location = new System.Drawing.Point(195, 118);
            this.tbxFileName.Margin = new System.Windows.Forms.Padding(0);
            this.tbxFileName.Maximum = 2147483647D;
            this.tbxFileName.Minimum = -2147483648D;
            this.tbxFileName.MinimumSize = new System.Drawing.Size(1, 1);
            this.tbxFileName.Name = "tbxFileName";
            this.tbxFileName.RectColor = System.Drawing.Color.AliceBlue;
            this.tbxFileName.Size = new System.Drawing.Size(211, 23);
            this.tbxFileName.Style = Rex.UI.UIStyle.Custom;
            this.tbxFileName.TabIndex = 253;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("华文新魏", 11F);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.label1.Location = new System.Drawing.Point(119, 123);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 16);
            this.label1.TabIndex = 252;
            this.label1.Text = "文件夹名:";
            // 
            // cbxStoreFormat
            // 
            this.cbxStoreFormat.BackColor = System.Drawing.Color.AliceBlue;
            this.cbxStoreFormat.DropDownStyle = Rex.UI.UIDropDownStyle.DropDownList;
            this.cbxStoreFormat.FillColor = System.Drawing.Color.AliceBlue;
            this.cbxStoreFormat.Font = new System.Drawing.Font("华文新魏", 11.6F);
            this.cbxStoreFormat.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.cbxStoreFormat.ForeDisableColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.cbxStoreFormat.Items.AddRange(new object[] {
            "jpg",
            "png",
            "bmp",
            "tiff"});
            this.cbxStoreFormat.Location = new System.Drawing.Point(195, 186);
            this.cbxStoreFormat.Margin = new System.Windows.Forms.Padding(0);
            this.cbxStoreFormat.MinimumSize = new System.Drawing.Size(63, 0);
            this.cbxStoreFormat.Name = "cbxStoreFormat";
            this.cbxStoreFormat.Padding = new System.Windows.Forms.Padding(0, 0, 30, 0);
            this.cbxStoreFormat.Radius = 2;
            this.cbxStoreFormat.RectColor = System.Drawing.Color.CornflowerBlue;
            this.cbxStoreFormat.RectDisableColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.cbxStoreFormat.RectSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.None;
            this.cbxStoreFormat.Size = new System.Drawing.Size(211, 24);
            this.cbxStoreFormat.Style = Rex.UI.UIStyle.Custom;
            this.cbxStoreFormat.StyleCustomMode = true;
            this.cbxStoreFormat.SymbolDropDown = 61656;
            this.cbxStoreFormat.SymbolNormal = 61655;
            this.cbxStoreFormat.TabIndex = 251;
            this.cbxStoreFormat.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("华文新魏", 11F);
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.label2.Location = new System.Drawing.Point(119, 192);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 16);
            this.label2.TabIndex = 250;
            this.label2.Text = "存储格式:";
            // 
            // ldImage
            // 
            this.ldImage.BackColor = System.Drawing.Color.AliceBlue;
            this.ldImage.Font = new System.Drawing.Font("华文新魏", 12F);
            this.ldImage.FontStyle = new System.Drawing.Font("华文新魏", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.ldImage.Location = new System.Drawing.Point(195, 84);
            this.ldImage.Margin = new System.Windows.Forms.Padding(4, 5, 4, 4);
            this.ldImage.Name = "ldImage";
            this.ldImage.Size = new System.Drawing.Size(211, 24);
            this.ldImage.TabIndex = 249;
            this.ldImage.TextInfo = "";
            this.ldImage.LinkData += new System.EventHandler(this.ldImage_LinkData);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.Transparent;
            this.label11.Font = new System.Drawing.Font("华文新魏", 11F);
            this.label11.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.label11.Location = new System.Drawing.Point(119, 90);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(73, 16);
            this.label11.TabIndex = 248;
            this.label11.Text = "输入图像:";
            // 
            // cbxImgType
            // 
            this.cbxImgType.BackColor = System.Drawing.Color.AliceBlue;
            this.cbxImgType.DropDownStyle = Rex.UI.UIDropDownStyle.DropDownList;
            this.cbxImgType.FillColor = System.Drawing.Color.AliceBlue;
            this.cbxImgType.Font = new System.Drawing.Font("华文新魏", 11.6F);
            this.cbxImgType.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.cbxImgType.ForeDisableColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.cbxImgType.Items.AddRange(new object[] {
            "原图",
            "截图"});
            this.cbxImgType.Location = new System.Drawing.Point(195, 49);
            this.cbxImgType.Margin = new System.Windows.Forms.Padding(0);
            this.cbxImgType.MinimumSize = new System.Drawing.Size(63, 0);
            this.cbxImgType.Name = "cbxImgType";
            this.cbxImgType.Padding = new System.Windows.Forms.Padding(0, 0, 30, 0);
            this.cbxImgType.Radius = 2;
            this.cbxImgType.RectColor = System.Drawing.Color.CornflowerBlue;
            this.cbxImgType.RectDisableColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.cbxImgType.RectSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.None;
            this.cbxImgType.Size = new System.Drawing.Size(211, 24);
            this.cbxImgType.Style = Rex.UI.UIStyle.Custom;
            this.cbxImgType.StyleCustomMode = true;
            this.cbxImgType.SymbolDropDown = 61656;
            this.cbxImgType.SymbolNormal = 61655;
            this.cbxImgType.TabIndex = 247;
            this.cbxImgType.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("华文新魏", 11F);
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.label3.Location = new System.Drawing.Point(119, 55);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 16);
            this.label3.TabIndex = 246;
            this.label3.Text = "图像样式:";
            // 
            // SaveImageForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(523, 328);
            this.MaximumSize = new System.Drawing.Size(525, 330);
            this.MinimumSize = new System.Drawing.Size(525, 330);
            this.Name = "SaveImageForm";
            this.panel_bottom.ResumeLayout(false);
            this.panel_center.ResumeLayout(false);
            this.panel_center.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbox_Icon)).EndInit();
            this.titlepanel.ResumeLayout(false);
            this.titlepanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Rex.UI.UITextBox tbxImgName;
        private System.Windows.Forms.Label label6;
        private Rex.UI.UITextBox tbxFileName;
        private System.Windows.Forms.Label label1;
        private Rex.UI.MyComboBox cbxStoreFormat;
        private System.Windows.Forms.Label label2;
        private RexControl.MyControls.MyLinkData ldImage;
        private System.Windows.Forms.Label label11;
        private Rex.UI.MyComboBox cbxImgType;
        private System.Windows.Forms.Label label3;
    }
}