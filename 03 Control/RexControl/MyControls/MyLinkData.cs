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
    public partial class MyLinkData : UserControl
    {
        [Description("链接数据"), Category("自定义")]
        public event EventHandler LinkData;

        [Description("实时执行"), Category("自定义")]
        public event EventHandler RealTimeExe;

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

        public MyLinkData()
        {
            InitializeComponent();
        }

        private void btnLink_Click(object sender, EventArgs e)
        {
            if (LinkData == null) return;
            LinkData(this,e);
            tbxData.Text = TextInfo;
        }

        private void btnDec_Click(object sender, EventArgs e)
        {
            tbxData.Text = "";
        }

        private void btnLink_MouseUp(object sender, MouseEventArgs e)
        {
            if (RealTimeExe != null)
            {
                RealTimeExe(sender, e);
            }
        }

        private void btnDec_MouseUp(object sender, MouseEventArgs e)
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

        private void tbxData_TextChanged(object sender, EventArgs e)
        {
            tbxData.Font = FontStyle;
        }
    }
}
