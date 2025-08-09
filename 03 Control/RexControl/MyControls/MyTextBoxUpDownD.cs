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
    public partial class MyTextBoxUpDownD : UserControl
    {
        [Description("实时执行"), Category("自定义")]
        public event EventHandler RealTimeExe;

        private Font _fontStyle;
        [Description("字体"), Category("自定义")]
        public Font FontStyle
        {
            get
            {
                return _fontStyle;
            }

            set
            {
                _fontStyle = value;
                tbxData.Font = _fontStyle;
            }
        }

        private string _textInfo;
        [Description("文本信息"), Category("自定义")]
        public string TextInfo
        {
            get
            {
                _textInfo = tbxData.Text;
                return _textInfo;
            }

            set
            {
                _textInfo = value;
                tbxData.Text = _textInfo;
            }
        }

        double tbxValue = 0;

        public MyTextBoxUpDownD()
        {
            InitializeComponent();

            tbxData.FillColor = Color.AliceBlue;
            tbxData.RectColor = Color.AliceBlue;
            tbxData.ForeColor = Color.FromArgb(100, 100, 100);
        }

        private void btnUp_Click(object sender, EventArgs e)
        {
            if (tbxData.Text == "") return;
            tbxValue = double.Parse(tbxData.Text);
            if (tbxValue < 0)
            {
                tbxValue = 0;
                tbxData.Text = "0";
                return;
            }
            tbxValue = tbxValue + 0.1;
            tbxData.Text = tbxValue.ToString();
        }

        private void btnDown_Click(object sender, EventArgs e)
        {
            if (tbxData.Text == "") return;
            tbxValue = double.Parse(tbxData.Text);
            if (tbxValue < 0)
            {
                tbxValue = 0;
                tbxData.Text = "0";
                return;
            }
            tbxValue = tbxValue - 0.1;
            tbxData.Text = tbxValue.ToString();
        }

        private void btnUp_MouseUp(object sender, MouseEventArgs e)
        {
            if (RealTimeExe != null)
            {
                RealTimeExe(sender, e);
            }
        }

        private void btnDown_MouseUp(object sender, MouseEventArgs e)
        {
            if (RealTimeExe != null)
            {
                RealTimeExe(sender, e);
            }
        }

        private void tbxData_KeyUp(object sender, KeyEventArgs e)
        {
            if (RealTimeExe != null)
            {
                RealTimeExe(sender, e);
            }
        }
    }
}
