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
using VisionCore;
using VisionCore.Core.Project;
using WeifenLuo.WinFormsUI.Docking;
using MutualTools;

namespace TSIVision
{
    /// <summary>
    /// 数据显示窗口
    /// </summary>
    public partial class FrmData : DockContent
    {
        #region 字段、属性

        /// <summary>
        /// 新一列
        /// </summary>
        DataGridViewRow dr;

        #endregion

        #region 初始化

        /// <summary>
        /// 初始化
        /// </summary>
        public FrmData()
        {
            InitializeComponent();
            ProjDelegate.deliveryHeader += LoadHeader;
            ProjDelegate.deliveryData += LoadData;
            ProjDelegate.dgvAddRow += AddRow;
        }

        #endregion

        #region 方法-界面更新

        /// <summary>
        /// 加载表头
        /// </summary>
        /// <param name="setHeader_Info"></param>
        public void LoadHeader(SetHeader_Info setHeader_Info)
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
                dgvData.Columns[i].HeaderCell.Value = setHeader_Info.GetType().GetProperty(str[i]).GetValue(setHeader_Info);
            }
        }

        /// <summary>
        /// 加载数据
        /// </summary>
        /// <param name="setHeader_Info"></param>
        public void LoadData(ShowData_Info showData_Info)
        {
            string[] str = new string[100];
            int j = 0;
            for (int i = 0; i < str.Length; i++)
            {
                j = i + 1;
                str[i] = "Data" + j;
            }

            dr = new DataGridViewRow();
            dr.CreateCells(dgvData);
            for (int i = 0; i < str.Length; i++)
            {
                dr.Cells[i].Value = showData_Info.GetType().GetProperty(str[i]).GetValue(showData_Info);
            }
            Invoke(ProjDelegate.dgvAddRow);
        }

        /// <summary>
        /// 添加行作为最后一行
        /// </summary>
        public void AddRow()
        {
            dgvData.Rows.Add(dr);
            dgvData.FirstDisplayedScrollingRowIndex = dgvData.RowCount - 1;
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

        #region 事件-ContextMenuStrip控件

        /// <summary>
        /// 清空列表
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void 清空列表ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            dgvData.Rows.Clear();
        }

        private void 数据导出ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ExportTools.ExcelExportCheck(dgvData);
        }

        #endregion
    }
}
