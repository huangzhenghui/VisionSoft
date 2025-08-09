using Rex.UI;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MutualTools
{
    public class FrmRTools
    {
        /// <summary>
        /// 加载窗体
        /// </summary>
        /// <param name="form">需加载的窗体</param>
        /// <param name="panel">目标panel</param>
        public static void ShowFrm(Panel panel, Form form)
        {
            panel.Controls.Clear();
            form.TopLevel = false;
            form.FormBorderStyle = FormBorderStyle.None;
            form.Dock = DockStyle.Fill;
            panel.Controls.Add(form);
            form.Show();
        }

        /// <summary>
        /// 设置所有控件双缓存绘制，以防止闪烁
        /// </summary>
        /// <param name="fatherControl"></param>
        public static void SetDoubleBuffer(Control fatherControl)
        {
            foreach (Control control in fatherControl.Controls)
            {
                control.DoubleBuffered(true);
            }
        }
    }
}
