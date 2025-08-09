using Ookii.Dialogs.WinForms;
using Rex.UI;
using RexHelps;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using VisionCore;

namespace Plugin.SetVar
{
    public partial class SetVarForm : FormBase
    {
        #region 字段、属性

        /// <summary>
        /// 模块对象
        /// </summary>
        SetVarObj mObj;

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

        public SetVarForm(SetVarObj Obj) : base(Obj)
        {
            mObj = Obj;
            InitializeComponent();
        }

        #endregion

        #region 方法-变量相关

        /// <summary>
        /// 列表操作
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void uibt_Click(object sender, EventArgs e)
        {
            int setrow = 0;
            int index = dgv_File.CurrentRow != null ? dgv_File.CurrentRow.Index : 0;
            UIButton btn = sender as UIButton;
            switch (btn.Text)
            {
                case "添加":
                    dgv_Add(dgv_File.RowCount);
                    break;
                case "删除":
                    dgv_Remov(index);
                    break;
                case "上移":
                    dgv_Up(index);
                    setrow = index - 1;
                    break;
                case "下移":
                    dgv_Down(index);
                    setrow = index + 1;
                    break;
                case "置顶":
                    dgv_Top(index);
                    setrow = 0;
                    break;
                case "置底":
                    dgv_Bottom(index);
                    setrow = dgv_File.Rows.Count - 1;
                    break;
            }
            dgv_File.DataSource = mObj.mChar_Info.ToArray();
            dgv_File.BindingContext[dgv_File.DataSource].Position = setrow;
        }

        /// <summary>
        /// 添加
        /// </summary>
        /// <param name="index"></param>
        private void dgv_Add(int index)
        {
            PluginDataLinkForm LikeDataForm = new PluginDataLinkForm(mObj.ProjName, mObj.ModInfo.Name);
            LikeDataForm.dataType = "整型" + "|" + "整型数组" + "|" + "双精度" + "|" + "双精度数组" + "|" + "布尔型" + "|" + "布尔型数组" + "|" + "字符串" + "|" + "字符串数组" + "|" + "HTuple";
            LikeDataForm.ShowDialog();
            string[] m_IntStr = LikeDataForm.m_OutLinkData.Split('|');
            if (m_IntStr[0] == " " || m_IntStr[1] == " ") return;
            mObj.mChar_Info.Add(new Char_Info(m_IntStr[0] + ":" + m_IntStr[1], "", "乘", "", ""));
        }

        /// <summary>
        /// 去除
        /// </summary>
        /// <param name="index"></param>
        private void dgv_Remov(int index)
        {
            mObj.mChar_Info.RemoveAt(index);
        }

        /// <summary>
        /// 上移
        /// </summary>
        /// <param name="index"></param>
        private void dgv_Up(int index)
        {
            if (index < 1) { return; }
            var temp = mObj.mChar_Info[index];
            mObj.mChar_Info[index] = mObj.mChar_Info[index - 1];
            mObj.mChar_Info[index - 1] = temp;
        }

        /// <summary>
        /// 下移
        /// </summary>
        /// <param name="index"></param>
        private void dgv_Down(int index)
        {
            if (index < 0 || mObj.mChar_Info.Count < 2 || (mObj.mChar_Info.Count - 1) <= index) { return; }
            var temp = mObj.mChar_Info[index];
            mObj.mChar_Info[index] = mObj.mChar_Info[index + 1];
            mObj.mChar_Info[index + 1] = temp;
        }

        /// <summary>
        /// 置顶
        /// </summary>
        /// <param name="index"></param>
        private void dgv_Top(int index)
        {
            var temp = mObj.mChar_Info[index];
            mObj.mChar_Info[index] = mObj.mChar_Info[0];
            mObj.mChar_Info[0] = temp;
        }

        /// <summary>
        /// 置底
        /// </summary>
        /// <param name="index"></param>
        private void dgv_Bottom(int index)
        {
            var temp = mObj.mChar_Info[index];
            mObj.mChar_Info[index] = mObj.mChar_Info[dgv_File.Rows.Count - 1];
            mObj.mChar_Info[dgv_File.Rows.Count - 1] = temp;
        }

        #endregion

        #region 方法-对象保存加载相关

        /// <summary>
        /// 将窗体的值保存到模块对象中
        /// </summary>
        public override void FormToObj()
        {
            mObj.mChar_Info.Clear();
            for (int i = 0; i < dgv_File.RowCount; ++i)
            {
                string name = dgv_File.Rows[i].Cells[0].Value.ToString();
                string link1 = dgv_File.Rows[i].Cells[1].Value.ToString();
                string mchar = dgv_File.Rows[i].Cells[2].Value.ToString();
                string link2 = dgv_File.Rows[i].Cells[3].Value.ToString();
                string resut = dgv_File.Rows[i].Cells[4].Value.ToString();
                mObj.mChar_Info.Add(new Char_Info(name, link1,mchar, link2, resut));
            }
        }

        /// <summary>
        /// 将模块对象中的值加载到窗体中
        /// </summary>
        public override void ObjToForm()
        {
            dgv_File.DataSource = mObj.mChar_Info.ToArray();
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

        #endregion

        #region 事件-DataGridView控件

        /// <summary>
        /// 双击链接变量
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dgv_File_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            int mSelectRow = dgv_File.CurrentRow.Index;
            int mSelectCol = dgv_File.CurrentCell.ColumnIndex;

            if (mSelectCol == 0)
            {
                PluginDataLinkForm LikeDataForm = new PluginDataLinkForm(mObj.ProjName, mObj.ModInfo.Name);
                LikeDataForm.dataType = "整型" + "|" + "整型数组" + "|" + "双精度" + "|" + "双精度数组" + "|" + "布尔型" + "|" + "布尔型数组" + "|" + "字符串" + "|" + "字符串数组" + "|" + "HTuple";
                LikeDataForm.ShowDialog();
                if (LikeDataForm.m_OutLinkData.Length > 3)
                {
                    string[] m_IntStr = LikeDataForm.m_OutLinkData.Split('|');
                    mObj.mChar_Info[mSelectRow].Name = m_IntStr[0] + ":" + m_IntStr[1];
                    ObjToForm();
                }
            }
            else if (mSelectCol == 1)
            {
                PluginDataLinkForm LikeDataForm = new PluginDataLinkForm(mObj.ProjName, mObj.ModInfo.Name);
                LikeDataForm.dataType = "整型" + "|" + "整型数组" + "|" + "双精度" + "|" + "双精度数组" + "|" + "布尔型" + "|" + "布尔型数组" + "|" + "字符串" + "|" + "字符串数组" + "|" + "HTuple";
                LikeDataForm.ShowDialog();
                if (LikeDataForm.m_OutLinkData.Length > 3)
                {
                    string[] m_IntStr = LikeDataForm.m_OutLinkData.Split('|');
                    mObj.mChar_Info[mSelectRow].Link1 = m_IntStr[0] + ":" + m_IntStr[1];
                    ObjToForm();
                }
            }
            else if (mSelectCol == 3)
            {
                if (dgv_File.Rows[mSelectRow].Cells[2].Value.ToString() != "赋值")
                {
                    PluginDataLinkForm LikeDataForm = new PluginDataLinkForm(mObj.ProjName, mObj.ModInfo.Name);
                    LikeDataForm.dataType = "整型" + "|" + "整型数组" + "|" + "双精度" + "|" + "双精度数组" + "|" + "布尔型" + "|" + "布尔型数组" + "|" + "字符串" + "|" + "字符串数组" + "|" + "HTuple";
                    LikeDataForm.ShowDialog();
                    if (LikeDataForm.m_OutLinkData.Length > 3)
                    {
                        string[] m_IntStr = LikeDataForm.m_OutLinkData.Split('|');
                        mObj.mChar_Info[mSelectRow].Link2 = m_IntStr[0] + ":" + m_IntStr[1];
                        ObjToForm();
                    }
                }
            }
        }

        /// <summary>
        /// DataGridView单元格重绘
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dgv_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
        {
            UIDataGridView dgv = sender as UIDataGridView;
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

        private void dgv_File_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if (dgv_File.CurrentCell == null) return;
            int mSelectRow = dgv_File.CurrentCell.RowIndex;

            switch (dgv_File.Rows[mSelectRow].Cells[2].Value)
            {
                case "赋值":
                    dgv_File.Rows[mSelectRow].Cells[3].Value = "——";
                    dgv_File.Rows[mSelectRow].Cells[4].Value = "——";
                    dgv_File.Rows[mSelectRow].Cells[3].ReadOnly = true;
                    dgv_File.Rows[mSelectRow].Cells[4].ReadOnly = true;
                    break;
                default:
                    dgv_File.Rows[mSelectRow].Cells[3].ReadOnly = false;
                    dgv_File.Rows[mSelectRow].Cells[4].ReadOnly = true;
                    break;
            }
        }

        private void SetVarForm_Load(object sender, EventArgs e)
        {
            if (dgv_File.CurrentCell == null) return;
            int mSelectRow = dgv_File.CurrentCell.RowIndex;

            switch (dgv_File.Rows[mSelectRow].Cells[2].Value)
            {
                case "赋值":
                    dgv_File.Rows[mSelectRow].Cells[3].Value = "——";
                    dgv_File.Rows[mSelectRow].Cells[4].Value = "——";
                    dgv_File.Rows[mSelectRow].Cells[3].ReadOnly = true;
                    dgv_File.Rows[mSelectRow].Cells[4].ReadOnly = true;
                    break;
                default:
                    dgv_File.Rows[mSelectRow].Cells[3].ReadOnly = false;
                    dgv_File.Rows[mSelectRow].Cells[4].ReadOnly = true;
                    break;
            }
        }
    }
}
