using DockContrl;
using System;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using static VisionCore.Core.Project.ProjDelegate;

namespace VisionCore
{
    public partial class ProjSetForm : DockForm
    {
        #region 字段、属性

        /// <summary>
        /// 鼠标是否为左键
        /// </summary>
        private bool leftFlag;

        /// <summary>
        /// 鼠标移动位置变量
        /// </summary>
        private Point mouseOff;

        /// <summary>
        /// 关联的工程类
        /// </summary>
        private Sol mSol;

        /// <summary>
        /// 流程信息更改
        /// </summary>
        public bool mChangName=false;

        /// <summary>
        /// 流程名称列表
        /// </summary>
        public string[] SolNameArry;

        #endregion

        #region 初始化

        /// <summary>
        /// 初始化
        /// </summary>
        /// <param name="Sol_"></param>
        public ProjSetForm(Sol Sol_)
        {
            mSol = Sol_;
            InitializeComponent();
            SolNameArry = mSol.GetNameList().ToArray();
            dgv_ProjSet.ColumnHeadersDefaultCellStyle.Font = new Font("隶书", 12, FontStyle.Regular);
            dgv_ProjSet.DefaultCellStyle.Font = new Font("隶书", 12, FontStyle.Regular);
                }

        #endregion

        #region 事件-按钮控件

        /// <summary>
        /// 确认
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void bt_Enter_Click(object sender, EventArgs e)
        {
            try
            {
                for (int i = 0; i < dgv_ProjSet.RowCount; ++i)
                {
                    Proj mProj = mSol.mProjList.Find(c => c.mProjInfo.Index == i);
                    mProj.mProjInfo.Name = dgv_ProjSet.Rows[i].Cells[0].Value.ToString();
                    string mEnum = dgv_ProjSet.Rows[i].Cells[1].Value.ToString();
                    mProj.mRunType = (RunType)Enum.Parse(typeof(RunType), mEnum);

                    SolNameArry[i] = dgv_ProjSet.Rows[i].Cells[0].Value.ToString();
                }
                mSol.SetProjName(SolNameArry);
                mSol.Name = tb_SolName.Text;
                deliverySolName(mSol.Name);
                mChangName = true;
                Close();
            }
            catch{ }
        }

        /// <summary>
        /// 关闭
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void bt_Close_Click(object sender, EventArgs e)
        {
            mChangName = false;
            Close();
        }

        #endregion

        #region 事件-窗体控件

        /// <summary>
        /// 窗体加载
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ProjSetForm_Load(object sender, EventArgs e)
        {
            int index = 0;
            tb_SolName.Text = mSol.Name;
            foreach (Proj proj in mSol.mProjList)
            {
                dgv_ProjSet.AddRow();
                dgv_ProjSet.Rows[index].Cells[0].Value = proj.mProjInfo.Name;
                dgv_ProjSet.Rows[index].Cells[1].Value = proj.mRunType.ToString();
                ++index;
            }
        }

        #endregion

        #region 事件-实现窗体移动功能

        /// <summary>
        /// 获取鼠标按下时坐标
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FrmCCamDebug_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                mouseOff = new Point(e.X, e.Y);//获得当前鼠标的坐标
                leftFlag = true;
            }
        }

        /// <summary>
        /// 将窗体跟随鼠标移动
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FrmCCamDebug_MouseMove(object sender, MouseEventArgs e)
        {
            if (leftFlag)
            {
                Point mouseSet = Control.MousePosition;//获得移动后鼠标的坐标
                mouseSet.Offset(-mouseOff.X, -mouseOff.Y);//设置移动后的位置
                Location = mouseSet;
            }
        }

        /// <summary>
        /// 鼠标抬起将标志位置为false
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FrmCCamDebug_MouseUp(object sender, MouseEventArgs e)
        {
            if (leftFlag)
            {
                leftFlag = false;
            }
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
                        var x = e.CellBounds.X + (e.CellBounds.Width - sizeF.Width) / 2f; // 获取 Left
                        var y = e.CellBounds.Y + (e.CellBounds.Height - sizeF.Height) / 3f; // 获取 Top

                        g.DrawString(text, dgv.ColumnHeadersDefaultCellStyle.Font, fg, x, y); // 绘制列标题
                    }
                    e.Handled = true;
                }
            }
        }

        #endregion
    }
}
