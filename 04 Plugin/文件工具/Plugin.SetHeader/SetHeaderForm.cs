using HalconDotNet;
using Plugin.CreateROI;
using Rex.UI;
using RexConst;
using RexControl.MyControls;
using RexView;
using RexView.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using VisionCore;
using static System.Net.Mime.MediaTypeNames;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace Plugin.SetHeader
{
    public partial class SetHeaderForm : FormBase
    {
        #region 字段、属性

        /// <summary>
        /// 模块对象
        /// </summary>
        SetHeaderObj mObj;

        /// <summary>
        /// 信息列表
        /// </summary>
        public List<SetHeader_Info> info = new List<SetHeader_Info>();

        /// <summary>
        /// 计时器
        /// </summary>
        public HTimer timerObj = new HTimer();

        /// <summary>
        /// 耗时
        /// </summary>
        public double costTime = 0;

        #endregion

        #region 初始化

        /// <summary>
        /// 初始化
        /// </summary>
        /// <param name="Obj"></param>
        public SetHeaderForm(SetHeaderObj Obj) : base(Obj)
        {
            InitializeComponent();

            mObj = Obj;
            info.Add(mObj.setHeader_Info);
            dgvHeader.DataSource = info.ToArray();
        }

        #endregion

        #region 方法-对象保存加载相关

        /// <summary>
        /// 将窗体的值保存到模块对象中
        /// </summary>
        public override void FormToObj()
        {
            string[] str = new string[100];
            int j = 0;
            for (int i = 0; i < str.Length; i++)
            {
                j = i + 1;
                str[i] = "Title" + j;
            }

            for (int i = 0; i < str.Length; i++)
            {
                mObj.setHeader_Info.GetType().GetProperty(str[i]).SetValue(mObj.setHeader_Info, dgvHeader.Rows[0].Cells[i].Value);
            }
        }

        /// <summary>
        /// 将模块对象中的值加载到窗体中
        /// </summary>
        public override void ObjToForm()
        {
            string[] str = new string[100];
            int j = 0;
            for (int i = 0; i < str.Length; i++)
            {
                j = i + 1;
                str[i] = "Title" + j;
            }

            for (int i = 0; i < str.Length; i++)
            {
                if (dgvHeader.Rows[0].Cells[i].Value != null)
                {
                    dgvHeader.Rows[0].Cells[i].Value = mObj.setHeader_Info.GetType().GetProperty(str[i]).GetValue(mObj.setHeader_Info);
                }
            }
        }

        #endregion

        #region 事件-按钮控件

        /// <summary>
        /// 执行
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public override void btn_Run_Click(object sender, EventArgs e)
        {
            FormToObj();

            timerObj.Start(); // 启动计时器
            mObj.RunObj();
            timerObj.Stop();  // 停止计时器

            ObjToForm();

            costTime = timerObj.GetMilliSecond;
            lblTime.Text = "耗时:" + costTime.ToString("F2") + "ms";
        }

        /// <summary>
        /// 保存
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public override void btn_Save_Click(object sender, EventArgs e)
        {
            FormToObj();
        }

        /// <summary>
        /// 取消
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public override void btn_Cancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        #endregion

        #region 事件-DataGridView控件

        /// <summary>
        /// DataGridView单元格重绘
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dgv_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
        {
            DataGridView dgv = sender as DataGridView;
            var g = e.Graphics;

            if (e.RowIndex < 0)
            {
                if (Enumerable.Range(0, 50).Contains(e.ColumnIndex))
                {
                    Brush bg = new SolidBrush(dgv.ColumnHeadersDefaultCellStyle.BackColor); // 背景色
                    Brush fg = new SolidBrush(dgv.ColumnHeadersDefaultCellStyle.ForeColor); // 前景色

                    //绘制背景色
                    if ((e.PaintParts & DataGridViewPaintParts.Background) == DataGridViewPaintParts.Background)
                        g.FillRectangle(bg, e.CellBounds); // 

                    if ((e.PaintParts & DataGridViewPaintParts.ContentBackground) == DataGridViewPaintParts.ContentBackground)
                        g.FillRectangle(bg, e.CellBounds); // 

                    if ((e.PaintParts & DataGridViewPaintParts.ContentForeground) == DataGridViewPaintParts.ContentForeground)
                    {
                        var col = dgv.Columns[e.ColumnIndex];
                        var text = col?.HeaderText ?? "";
                        var sizeF = g.MeasureString(text, dgv.ColumnHeadersDefaultCellStyle.Font); // 测量绘制列标题文本尺寸
                        var x = e.CellBounds.X + (e.CellBounds.Width - sizeF.Width) / 2.02f; // 获取 Left
                        var y = e.CellBounds.Y + (e.CellBounds.Height - sizeF.Height) / 1.3f; // 获取 Top

                        g.DrawString(text, dgv.ColumnHeadersDefaultCellStyle.Font, fg, x, y); // 绘制列标题
                    }
                    e.Handled = true;
                }
            }
        }

        #endregion
    }
}
