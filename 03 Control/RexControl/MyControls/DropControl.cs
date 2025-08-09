// Decompiled with JetBrains decompiler
// Type: Rex.UI.UIDropControl
// Assembly: RexUI, Version=2.2.8.0, Culture=neutral, PublicKeyToken=null
// MVID: 7B692304-90C7-4106-B5F4-59B900FD7D6E
// Assembly location: C:\Users\MECHREVO\Desktop\RexUI.dll

using System;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace Rex.UI
{
    [ToolboxItem(false)]
    public class DropControl : UIPanel
    {
        private int symbolNormal = 61703;
        private int dropSymbol = 61703;
        private UIDropDownStyle _dropDownStyle = UIDropDownStyle.DropDown;
        protected readonly DropControl.TextBoxEx edit = new DropControl.TextBoxEx();
        private IContainer components = (IContainer)null;
        private UIDropDown itemForm;

        [DefaultValue(61702)]
        [Description("下拉框显示时字体图标")]
        [Category("Rex")]
        public int SymbolDropDown { get; set; } = 61702;

        [DefaultValue(null)]
        [Description("水印文字")]
        [Category("Rex")]
        public string Watermark
        {
            get
            {
                return this.edit.Watermark;
            }
            set
            {
                this.edit.Watermark = value;
            }
        }

        protected UIDropDown ItemForm
        {
            get
            {
                if (this.itemForm == null)
                {
                    this.CreateInstance();
                    if (this.itemForm != null)
                    {
                        this.itemForm.ValueChanged += new UIDropDown.OnValueChanged(this.ItemForm_ValueChanged);
                        this.itemForm.VisibleChanged += new EventHandler(this.ItemForm_VisibleChanged);
                    }
                }
                return this.itemForm;
            }
            set
            {
                this.itemForm = value;
            }
        }

        [Browsable(false)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public bool DroppedDown
        {
            get
            {
                if (this.itemForm != null)
                    return this.itemForm.Visible;
                return false;
            }
        }

        [DefaultValue(61703)]
        [Description("正常显示时字体图标")]
        [Category("Rex")]
        public int SymbolNormal
        {
            get
            {
                return this.symbolNormal;
            }
            set
            {
                this.symbolNormal = value;
                this.dropSymbol = value;
            }
        }

        [DefaultValue(UIDropDownStyle.DropDown)]
        [Description("下拉框显示样式")]
        [Category("Rex")]
        public UIDropDownStyle DropDownStyle
        {
            get
            {
                return this._dropDownStyle;
            }
            set
            {
                if (this._dropDownStyle == value)
                    return;
                this._dropDownStyle = value;
                this.edit.Visible = value == UIDropDownStyle.DropDown;
                this.Invalidate();
            }
        }

        [DefaultValue('\0')]
        [Description("m")]
        [Category("Rex")]
        public char PasswordChar
        {
            get
            {
                return this.edit.PasswordChar;
            }
            set
            {
                this.edit.PasswordChar = value;
            }
        }

        [DefaultValue(false)]
        public bool ReadOnly
        {
            get
            {
                return this.edit.ReadOnly;
            }
            set
            {
                this.edit.ReadOnly = value;
                this.edit.BackColor = Color.FromArgb(235, 243, (int)byte.MaxValue);
            }
        }

        [Category("文字")]
        [Browsable(true)]
        [DefaultValue("")]
        public override string Text
        {
            get
            {
                return this.edit.Text;
            }
            set
            {
                this.edit.Text = value;
            }
        }

        public bool IsEmpty
        {
            get
            {
                return this.edit.Text == "";
            }
        }

        [DefaultValue(32767)]
        public int MaxLength
        {
            get
            {
                return this.edit.MaxLength;
            }
            set
            {
                this.edit.MaxLength = Math.Max(value, 1);
            }
        }

        [Browsable(false)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public int SelectionLength
        {
            get
            {
                return this.edit.SelectionLength;
            }
            set
            {
                this.edit.SelectionLength = value;
            }
        }

        [Browsable(false)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public int SelectionStart
        {
            get
            {
                return this.edit.SelectionStart;
            }
            set
            {
                this.edit.SelectionStart = value;
            }
        }

        public event EventHandler EditorLostFocus;

        public new event KeyEventHandler KeyDown;

        public new event KeyEventHandler KeyUp;

        public new event KeyPressEventHandler KeyPress;

        [Browsable(true)]
        public new event EventHandler TextChanged;

        public event EventHandler DoEnter;

        public event EventHandler ButtonClick;

        public DropControl()
        {
            this.InitializeComponent();
            this.edit.Font = UIFontColor.Font;
            this.edit.Left = 3;
            this.edit.Top = 3;
            this.edit.Text = string.Empty;
            this.edit.ForeColor = UIFontColor.Primary;
            this.edit.BorderStyle = BorderStyle.None;
            this.edit.TextChanged += new EventHandler(this.EditTextChanged);
            this.edit.KeyDown += new KeyEventHandler(this.EditOnKeyDown);
            this.edit.KeyUp += new KeyEventHandler(this.EditOnKeyUp);
            this.edit.KeyPress += new KeyPressEventHandler(this.EditOnKeyPress);
            this.edit.LostFocus += new EventHandler(this.Edit_LostFocus);
            this.edit.Invalidate();
            this.Controls.Add((Control)this.edit);
            this.TextAlignment = ContentAlignment.MiddleLeft;
            this.fillColor = Color.FromArgb(235, 243, (int)byte.MaxValue);
            this.edit.BackColor = Color.FromArgb(235, 243, (int)byte.MaxValue);
        }

        private void Edit_LostFocus(object sender, EventArgs e)
        {
            // ISSUE: reference to a compiler-generated field
            EventHandler eventHandler = this.EditorLostFocus;
            if (eventHandler == null)
                return;
            object sender1 = sender;
            EventArgs e1 = e;
            eventHandler(sender1, e1);
        }

        private void EditOnKeyPress(object sender, KeyPressEventArgs e)
        {
            // ISSUE: reference to a compiler-generated field
            KeyPressEventHandler pressEventHandler = this.KeyPress;
            if (pressEventHandler == null)
                return;
            object sender1 = sender;
            KeyPressEventArgs e1 = e;
            pressEventHandler(sender1, e1);
        }

        private void EditOnKeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Return)
            {
                // ISSUE: reference to a compiler-generated field
                EventHandler eventHandler = this.DoEnter;
                if (eventHandler != null)
                {
                    object sender1 = sender;
                    KeyEventArgs keyEventArgs = e;
                    eventHandler(sender1, (EventArgs)keyEventArgs);
                }
            }
            // ISSUE: reference to a compiler-generated field
            KeyEventHandler keyEventHandler = this.KeyDown;
            if (keyEventHandler == null)
                return;
            object sender2 = sender;
            KeyEventArgs e1 = e;
            keyEventHandler(sender2, e1);
        }

        private void EditOnKeyUp(object sender, KeyEventArgs e)
        {
            // ISSUE: reference to a compiler-generated field
            KeyEventHandler keyEventHandler = this.KeyUp;
            if (keyEventHandler == null)
                return;
            object sender1 = sender;
            KeyEventArgs e1 = e;
            keyEventHandler(sender1, e1);
        }

        private void ItemForm_VisibleChanged(object sender, EventArgs e)
        {
            this.dropSymbol = this.SymbolNormal;
            if (this.DroppedDown)
                this.dropSymbol = this.SymbolDropDown;
            this.Invalidate();
        }

        protected virtual void CreateInstance()
        {
        }

        protected virtual void ItemForm_ValueChanged(object sender, object value)
        {
        }

        protected virtual int CalcItemFormHeight()
        {
            return 200;
        }

        protected override void OnTextChanged(EventArgs e)
        {
            base.OnTextChanged(e);
            this.edit.Text = this.Text;
            this.Invalidate();
        }

        private void EditTextChanged(object s, EventArgs e)
        {
            this.Text = this.edit.Text;
            // ISSUE: reference to a compiler-generated field
            EventHandler eventHandler = this.TextChanged;
            if (eventHandler != null)
            {
                object sender = s;
                EventArgs e1 = e;
                eventHandler(sender, e1);
            }
            this.Invalidate();
        }

        protected override void OnFontChanged(EventArgs e)
        {
            base.OnFontChanged(e);
            this.edit.Font = this.Font;
            this.Invalidate();
        }

        protected override void OnSizeChanged(EventArgs e)
        {
            this.SizeChange();
        }

        private void SizeChange()
        {
            TextBox textBox = new TextBox();
            textBox.Font = this.edit.Font;
            textBox.Invalidate();
            this.Height = textBox.Height;
            textBox.Dispose();
            this.edit.Top = (this.Height - this.edit.Height) / 2;
            this.edit.Left = 3;
            this.edit.Width = this.Width - 30;
        }

        protected override void OnPaintFore(Graphics g, GraphicsPath path)
        {
            this.SizeChange();
            if (this.edit.Visible)
                return;
            base.OnPaintFore(g, path);
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            this.Padding = new Padding(0, 0, 30, 0);
            GDIEx.FillRoundRectangle(e.Graphics, this.GetFillColor(), new Rectangle(this.Width - 27, this.edit.Top, 25, this.edit.Height), this.Radius, true);
            Color rectColor = this.GetRectColor();
            SizeF fontImageSize = FontImageHelper.GetFontImageSize(e.Graphics, this.dropSymbol, 24);
            FontImageHelper.DrawFontImage(e.Graphics, this.dropSymbol, 24, rectColor, (float)(this.Width - 28) + (float)(12.0 - (double)fontImageSize.Width / 2.0), (float)(((double)this.Height - (double)fontImageSize.Height) / 2.0), 0, 0);
        }

        protected override void OnGotFocus(EventArgs e)
        {
            base.OnGotFocus(e);
            this.edit.Focus();
        }

        public void Clear()
        {
            this.edit.Clear();
        }

        protected override void OnMouseDown(MouseEventArgs e)
        {
            this.ActiveControl = (Control)this.edit;
        }

        public override void SetStyleColor(UIBaseStyle uiColor)
        {
            base.SetStyleColor(uiColor);
            if (UIStyleHelper.IsCustom(uiColor))
                return;
            this.foreColor = uiColor.DropDownControlColor;
            this.edit.BackColor = this.fillColor = Color.FromArgb(235, 243, (int)byte.MaxValue);
            this.Invalidate();
        }

        protected override void AfterSetFillColor(Color color)
        {
            base.AfterSetFillColor(color);
            this.edit.BackColor = this.fillColor;
        }

        protected override void AfterSetForeColor(Color color)
        {
            base.AfterSetForeColor(color);
            this.edit.ForeColor = this.foreColor;
        }

        protected override void OnClick(EventArgs e)
        {
            if (this.ReadOnly)
                return;
            if (this.ItemForm != null)
            {
                this.ItemForm.SetRectColor(this.rectColor);
                this.ItemForm.SetFillColor(this.fillColor);
                this.ItemForm.SetForeColor(this.foreColor);
                this.ItemForm.SetStyle(UIStyles.ActiveStyleColor);
            }
            // ISSUE: reference to a compiler-generated field
            EventHandler eventHandler = this.ButtonClick;
            if (eventHandler != null)
            {
                EventArgs e1 = e;
                eventHandler((object)this, e1);
            }
        }

        public void Select(int start, int length)
        {
            this.edit.Select(start, length);
        }

        public void SelectAll()
        {
            this.edit.SelectAll();
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing && this.components != null)
                this.components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // DropControl
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.Font = new System.Drawing.Font("华文新魏", 11.8F);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.ForeDisableColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.MinimumSize = new System.Drawing.Size(63, 0);
            this.Name = "DropControl";
            this.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.RectSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.None;
            this.Size = new System.Drawing.Size(213, 34);
            this.Style = Rex.UI.UIStyle.Custom;
            this.StyleCustomMode = true;
            this.ResumeLayout(false);

        }

        protected class TextBoxEx : TextBox
        {
            private string watermark;

            [DefaultValue(null)]
            public string Watermark
            {
                get
                {
                    return this.watermark;
                }
                set
                {
                    this.watermark = value;
                    DropControl.TextBoxEx.SendMessage(this.Handle, 5377, (int)IntPtr.Zero, value);
                }
            }

            [DllImport("user32.dll", CharSet = CharSet.Auto)]
            private static extern IntPtr SendMessage(IntPtr hWnd, int msg, int wParam, string lParam);
        }
    }
}
