using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Rex.UI
{
    public partial class MyTimeItem : UIDropDownItem
    {
        private UILine uiLine1;
        public UISymbolButton s1;
        public UISymbolButton m1;
        public UISymbolButton h1;
        public UISymbolButton s2;
        public UISymbolButton m2;
        public UISymbolButton h2;
        public UISymbolButton btnOK;
        public UISymbolButton btnCancel;
        private UILabel hc;
        private UILabel mc;
        private UILabel sc;
        private UILabel st;
        private UILabel mt;
        private UILabel ht;
        private UILabel sb;
        private UILabel mb;
        private UILabel hb;
        private UILine uiLine2;
        private DateTime time;
        private int hour;
        private int minute;
        private int second;

        public DateTime Time
        {
            get
            {
                return this.time;
            }
            set
            {
                this.time = value;
                this.Hour = this.time.Hour;
                this.Minute = this.time.Minute;
                this.Second = this.time.Second;
                this.ShowOther();
            }
        }

        public int Hour
        {
            get
            {
                return this.hour;
            }
            set
            {
                this.hour = value;
                this.hc.Text = this.hour.ToString();
            }
        }

        public int Minute
        {
            get
            {
                return this.minute;
            }
            set
            {
                this.minute = value;
                this.mc.Text = this.minute.ToString();
            }
        }

        public int Second
        {
            get
            {
                return this.second;
            }
            set
            {
                this.second = value;
                this.sc.Text = this.second.ToString();
            }
        }

        public MyTimeItem()
        {
            this.InitializeComponent();
            this.MouseWheel += new MouseEventHandler(this.UITimeItem_MouseWheel);
        }

        private void UITimeItem_MouseWheel(object sender, MouseEventArgs e)
        {
            if (e.Delta < 0)
            {
                if (new Rectangle(this.ht.Left, this.ht.Top, this.ht.Width, this.hb.Bottom - this.ht.Top).Contains(e.X, e.Y))
                    this.h2.PerformClick();
                else if (new Rectangle(this.mt.Left, this.mt.Top, this.ht.Width, this.hb.Bottom - this.ht.Top).Contains(e.X, e.Y))
                {
                    this.m2.PerformClick();
                }
                else
                {
                    if (!new Rectangle(this.st.Left, this.st.Top, this.ht.Width, this.hb.Bottom - this.ht.Top).Contains(e.X, e.Y))
                        return;
                    this.s2.PerformClick();
                }
            }
            else
            {
                if (e.Delta <= 0)
                    return;
                if (new Rectangle(this.ht.Left, this.ht.Top, this.ht.Width, this.hb.Bottom - this.ht.Top).Contains(e.X, e.Y))
                    this.h1.PerformClick();
                else if (new Rectangle(this.mt.Left, this.mt.Top, this.ht.Width, this.hb.Bottom - this.ht.Top).Contains(e.X, e.Y))
                    this.m1.PerformClick();
                else if (new Rectangle(this.st.Left, this.st.Top, this.ht.Width, this.hb.Bottom - this.ht.Top).Contains(e.X, e.Y))
                    this.s1.PerformClick();
            }
        }

        private void ShowOther()
        {
            this.ht.Text = MathEx.Mod(this.hour - 1 + 24, 24).ToString();
            this.hb.Text = MathEx.Mod(this.hour + 1 + 24, 24).ToString();
            this.mt.Text = MathEx.Mod(this.minute - 1 + 60, 60).ToString();
            this.mb.Text = MathEx.Mod(this.minute + 1 + 60, 60).ToString();
            this.st.Text = MathEx.Mod(this.second - 1 + 60, 60).ToString();
            this.sb.Text = MathEx.Mod(this.second + 1 + 60, 60).ToString();
        }

        private void h1_Click(object sender, EventArgs e)
        {
            this.Hour = MathEx.Mod(this.Hour - 1 + 24, 24);
            this.ShowOther();
        }

        private void m1_Click(object sender, EventArgs e)
        {
            this.Minute = MathEx.Mod(this.Minute - 1 + 60, 60);
            this.ShowOther();
        }

        private void s1_Click(object sender, EventArgs e)
        {
            this.Second = MathEx.Mod(this.Second - 1 + 60, 60);
            this.ShowOther();
        }

        private void h2_Click(object sender, EventArgs e)
        {
            this.Hour = MathEx.Mod(this.Hour + 1 + 24, 24);
            this.ShowOther();
        }

        private void m2_Click(object sender, EventArgs e)
        {
            this.Minute = MathEx.Mod(this.Minute + 1 + 60, 60);
            this.ShowOther();
        }

        private void s2_Click(object sender, EventArgs e)
        {
            this.Second = MathEx.Mod(this.Second + 1 + 60, 60);
            this.ShowOther();
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            DateTime dateTime = DateTime.MinValue;
            int year = dateTime.Year;
            dateTime = DateTime.MinValue;
            int month = dateTime.Month;
            dateTime = DateTime.MinValue;
            int day = dateTime.Day;
            int hour = this.Hour;
            int minute = this.Minute;
            int second = this.Second;
            this.time = new DateTime(year, month, day, hour, minute, second);
            this.DoValueChanged((object)this, (object)this.time);
            this.CloseParent();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.CloseParent();
        }

        public override void SetStyle(UIBaseStyle style)
        {
            base.SetStyle(style);
            this.btnOK.SetStyleColor(style);
            this.btnCancel.SetStyleColor(style);
        }

        public override void SetRectColor(Color color)
        {
            base.SetRectColor(color);
            this.RectColor = color;
            this.h1.ForeColor = this.h2.ForeColor = color;
            this.m1.ForeColor = this.m2.ForeColor = color;
            this.s1.ForeColor = this.s2.ForeColor = color;
        }

        private void hc_DoubleClick(object sender, EventArgs e)
        {
            this.Hour = 0;
            this.Minute = 0;
            this.Second = 0;
            this.ShowOther();
        }

        private void mc_DoubleClick(object sender, EventArgs e)
        {
            this.Minute = 0;
            this.Second = 0;
            this.ShowOther();
        }

        private void sc_DoubleClick(object sender, EventArgs e)
        {
            this.Second = 0;
            this.ShowOther();
        }

    }
}
