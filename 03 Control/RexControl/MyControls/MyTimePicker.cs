using Rex.UI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RexControl.MyControls
{
    [ToolboxItem(true)]
    [DefaultProperty("Value")]
    [DefaultEvent("ValueChanged")]
    public partial class MyTimePicker : DropControl
    {
        public  MyTimeItem item = new MyTimeItem();
        private string timeFormat = "HH:mm:ss";

        [Description("选中时间")]
        [Category("Rex")]
        public DateTime Value
        {
            get
            {
                return this.item.Time;
            }
            set
            {
                this.Text = value.ToString(this.timeFormat);
                this.item.Time = value;
            }
        }

        [Description("时间格式化掩码")]
        [Category("Rex")]
        [DefaultValue("HH:mm:ss")]
        public string TimeFormat
        {
            get
            {
                return this.timeFormat;
            }
            set
            {
                this.timeFormat = value;
                this.Text = this.Value.ToString(this.timeFormat);
                this.MaxLength = this.timeFormat.Length;
            }
        }

        public event UITimePicker.OnDateTimeChanged ValueChanged;

        public MyTimePicker()
        {
            this.InitializeComponent();
            this.Value = DateTime.Now;
            this.EditorLostFocus += new EventHandler(this.UIDatePicker_LostFocus);
            this.TextChanged += new EventHandler(this.UIDatePicker_TextChanged);
            this.MaxLength = 8;
        }

        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // edit
            // 
            this.edit.BackColor = System.Drawing.Color.Navy;
            this.edit.Size = new System.Drawing.Size(177, 22);
            // 
            // MyTimePicker
            // 
            this.BackColor = System.Drawing.Color.White;
            this.FillColor = System.Drawing.Color.Navy;
            this.Name = "MyTimePicker";
            this.Padding = new System.Windows.Forms.Padding(0, 0, 30, 0);
            this.RectColor = System.Drawing.Color.White;
            this.Size = new System.Drawing.Size(207, 29);
            this.SymbolDropDown = 61555;
            this.SymbolNormal = 61555;
            this.ButtonClick += new System.EventHandler(this.UITimePicker_ButtonClick);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void UIDatePicker_TextChanged(object sender, EventArgs e)
        {
            if (this.Text.Length != this.MaxLength)
                return;
            try
            {
                this.Value = StringEx.ToDateTime(DateTimeEx.DateString(DateTime.Now, true) + " " + this.Text, "yyyy-MM-dd " + this.timeFormat);
            }
            catch
            {
                this.Value = DateTime.Now.Date;
            }
        }

        private void UIDatePicker_LostFocus(object sender, EventArgs e)
        {
            try
            {
                this.Value = StringEx.ToDateTime(DateTimeEx.DateString(DateTime.Now, true) + " " + this.Text, "yyyy-MM-dd " + this.timeFormat);
            }
            catch
            {
                this.Value = DateTime.Now.Date;
            }
        }

        protected override void ItemForm_ValueChanged(object sender, object value)
        {
            this.Value = (DateTime)value;
            this.Text = this.Value.ToString(this.timeFormat);
            this.Invalidate();
            // ISSUE: reference to a compiler-generated field
            UITimePicker.OnDateTimeChanged onDateTimeChanged = this.ValueChanged;
            if (onDateTimeChanged == null)
                return;
            DateTime dateTime = this.Value;
            onDateTimeChanged((object)this, dateTime);
        }

        protected override void CreateInstance()
        {
            this.ItemForm = new UIDropDown((UIDropDownItem)this.item);
        }

        private void UITimePicker_ButtonClick(object sender, EventArgs e)
        {
            item.btnOK.FillColor = Color.Navy;
            item.btnCancel.FillColor = Color.Navy;
            item.h1.ForeColor = Color.Navy;
            item.h2.ForeColor = Color.Navy;
            item.s1.ForeColor = Color.Navy;
            item.s2.ForeColor = Color.Navy;
            item.m1.ForeColor = Color.Navy;
            item.m2.ForeColor = Color.Navy;

            item.Time = Value;
            ItemForm.Show(this);
        }

        public delegate void OnDateTimeChanged(object sender, DateTime value);
    }
}
