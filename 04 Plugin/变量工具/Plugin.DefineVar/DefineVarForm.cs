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

namespace Plugin.DefineVar
{
    public partial class DefineVarForm : FormBase
    {
        #region 字段、属性

        /// <summary>
        /// 模块对象
        /// </summary>
        DefineVarObj mObj;

        /// <summary>
        /// 添加变量窗体对象
        /// </summary>
        AddVarForm frmAddVar;

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

        public DefineVarForm(DefineVarObj Obj) : base(Obj)
        {
            mObj = Obj;
            InitializeComponent();
            RefreshVarList();
        }

        #endregion

        #region 方法-变量相关

        /// <summary>
        /// 刷新变量列表
        /// </summary>
        private void RefreshVarList()
        {
            if (mObj.mVarList == null) return;
            if (mObj.mVarList.Count == 0) return;
            int index = 0;
            dgv_VarList.Rows.Clear();
            foreach (DataCell data in mObj.mVarList)
            {
                dgv_VarList.Rows.Add();
                string varType = "";
                switch (data.mDataMode)
                {
                    case DataMode.整型:
                        varType = "int";
                        break;
                    case DataMode.整型数组:
                        varType = "int[]";
                        break;
                    case DataMode.双精度:
                        varType = "double";
                        break;
                    case DataMode.双精度数组:
                        varType = "double[]";
                        break;
                    case DataMode.布尔型:
                        varType = "bool";
                        break;
                    case DataMode.布尔型数组:
                        varType = "bool[]";
                        break;
                    case DataMode.字符串:
                        varType = "string";
                        break;
                    case DataMode.字符串数组:
                        varType = "string[]";
                        break;
                    default:
                        break;
                }

                dgv_VarList.Rows[index].Cells[0].Value = varType;
                dgv_VarList.Rows[index].Cells[1].Value = data.mDataName;
                dgv_VarList.Rows[index].Cells[2].Value = data.mDataValue;
                dgv_VarList.Rows[index].Cells[3].Value = data.mDataTip;
                ++index;
            }
        }

        /// <summary>
        /// 添加
        /// </summary>
        /// <param name="dataGridView"></param>
        public void AddDataGridView(string[] info)
        {
            for (int j = 0; j < dgv_VarList.RowCount; j++)
            {
                if (info[1] == dgv_VarList.Rows[j].Cells[1].Value.ToString()) 
                {
                    dgv_VarList.Rows[j].Cells[0].Value = info[0];
                    dgv_VarList.Rows[j].Cells[1].Value = info[1];
                    dgv_VarList.Rows[j].Cells[2].Value = info[2];
                    dgv_VarList.Rows[j].Cells[3].Value = info[3];
                    return;
                }
            }

            DataGridViewRow dr = new DataGridViewRow();
            dr.CreateCells(dgv_VarList);
            dr.Cells[0].Value = info[0];
            dr.Cells[1].Value = info[1];
            dr.Cells[2].Value = info[2];
            dr.Cells[3].Value = info[3];
            dgv_VarList.Rows.Add(dr);//添加的行作为最后一行
        }

        /// <summary>
        /// 上移
        /// </summary>
        /// <param name="dataGridView"></param>
        public void UpDataGridView()
        {
            try
            {
                DataGridViewSelectedRowCollection dgvsrc = dgv_VarList.SelectedRows;//获取选中行的集合
                if (dgvsrc.Count > 0)
                {
                    int index = dgv_VarList.SelectedRows[0].Index;//获取当前选中行的索引
                    if (index > 0)//如果该行不是第一行
                    {
                        DataGridViewRow dgvr = dgv_VarList.Rows[index - dgvsrc.Count];//获取选中行的上一行
                        dgv_VarList.Rows.RemoveAt(index - dgvsrc.Count);//删除原选中行的上一行
                        dgv_VarList.Rows.Insert((index), dgvr);//将选中行的上一行插入到选中行的后面
                        for (int i = 0; i < dgvsrc.Count; i++)//选中移动后的行
                        {
                            dgv_VarList.Rows[index - i - 1].Selected = true;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        /// <summary>
        /// 下移
        /// </summary>
        /// <param name="dataGridView"></param>
        public void DownDataGridView()
        {
            try
            {
                DataGridViewSelectedRowCollection dgvsrc = dgv_VarList.SelectedRows;//获取选中行的集合
                if (dgvsrc.Count > 0)
                {
                    int index = dgv_VarList.SelectedRows[0].Index;//获取当前选中行的索引
                    if (index >= 0 & (dgv_VarList.RowCount - 1) != index)//如果该行不是最后一行
                    {
                        DataGridViewRow dgvr = dgv_VarList.Rows[index + 1];//获取选中行的下一行
                        dgv_VarList.Rows.RemoveAt(index + 1);//删除原选中行的上一行
                        dgv_VarList.Rows.Insert((index + 1 - dgvsrc.Count), dgvr);//将选中行的上一行插入到选中行的后面
                        for (int i = 0; i < dgvsrc.Count; i++)//选中移动后的行
                        {
                            dgv_VarList.Rows[index + 1 - i].Selected = true;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        /// <summary>
        /// 置顶
        /// </summary>
        /// <param name="dataGridView"></param>
        public void TopDataGridView()
        {
            try
            {
                DataGridViewSelectedRowCollection dgvsrc = dgv_VarList.SelectedRows;//获取选中行的集合
                if (dgvsrc.Count > 0)
                {
                    int index = dgv_VarList.SelectedRows[0].Index;//获取当前选中行的索引
                    if (index > 0)//如果该行不是第一行
                    {
                        DataGridViewRow dgvr = dgv_VarList.Rows[index];//获取选中行的上一行
                        dgv_VarList.Rows.RemoveAt(index);//删除原选中行的上一行
                        dgv_VarList.Rows.Insert(0, dgvr);//将选中行的上一行插入到选中行的后面                       
                        for (int i = 0; i < dgv_VarList.Rows.Count; i++)//选中移动后的行
                        {
                            if (i != 0)
                            {
                                dgv_VarList.Rows[i].Selected = false;
                            }
                            else
                            {
                                dgv_VarList.Rows[i].Selected = true;
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        /// <summary>
        /// 置底
        /// </summary>
        /// <param name="dataGridView"></param>
        public void BottomDataGridView()
        {
            try
            {
                DataGridViewSelectedRowCollection dgvsrc = dgv_VarList.SelectedRows;//获取选中行的集合
                if (dgvsrc.Count > 0)
                {
                    int index = dgv_VarList.SelectedRows[0].Index;//获取当前选中行的索引
                    if (index < dgv_VarList.Rows.Count - 1)//如果该行不是第一行
                    {
                        DataGridViewRow dgvr = dgv_VarList.Rows[index];//获取选中行的上一行
                        dgv_VarList.Rows.RemoveAt(index);//删除原选中行的上一行
                        int nCount = dgv_VarList.Rows.Count;
                        dgv_VarList.Rows.Insert(nCount, dgvr);//将选中行的上一行插入到选中行的后面
                        for (int i = 0; i < dgv_VarList.Rows.Count; i++)//选中移动后的行
                        {
                            if (i != dgv_VarList.Rows.Count - 1)
                            {
                                dgv_VarList.Rows[i].Selected = false;
                            }
                            else
                            {
                                dgv_VarList.Rows[i].Selected = true;
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        /// <summary>
        /// 删除
        /// </summary>
        /// <param name="dataGridView"></param>
        public void RemovDataGridView()
        {
            if (dgv_VarList.SelectedRows == null || dgv_VarList.SelectedRows.Count == 0)
            {
                MessageBox.Show("请先选择删除步，单击第一列以选中行");
            }
            else
            {
                if (MessageBox.Show("确定要删除选中步吗？") == System.Windows.Forms.DialogResult.OK)
                {
                    foreach (DataGridViewRow dr in dgv_VarList.SelectedRows)
                    {
                        if (dr.IsNewRow == false)
                        {
                            //如果不是已提交的行，默认情况下在添加一行数据成功后，DataGridView为新建一行作为新数据的插入位置
                            dgv_VarList.Rows.Remove(dr);
                        }
                    }
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
            mObj.mVarList.Clear();
            for (int i = 0; i < dgv_VarList.RowCount; ++i)
            {
                string varType = "";
                switch (dgv_VarList.Rows[i].Cells[0].Value.ToString())
                {
                    case "int":
                        varType = "Int";
                        break;
                    case "int[]":
                        varType = "IntArr";
                        break;
                    case "bool":
                        varType = "Bool";
                        break;
                    case "bool[]":
                        varType = "BoolArr";
                        break;
                    case "double":
                        varType = "Double";
                        break;
                    case "double[]":
                        varType = "DoubleArr";
                        break;
                    case "string":
                        varType = "String";
                        break;
                    case "string[]":
                        varType = "StringArr";
                        break;
                    default:
                        break;
                }

                DataMode type = (DataMode)Enum.Parse(typeof(DataMode), varType);
                string name = dgv_VarList.Rows[i].Cells[1].Value.ToString();
                string value = dgv_VarList.Rows[i].Cells[2].Value.ToString();
                string remark = dgv_VarList.Rows[i].Cells[3].Value.ToString();
                mObj.mVarList.Add(new DataCell(mObj.ModInfo.Name, 0, DataType.单量, type, name, remark, "0", i, value, DataAtrr.全局变量));
            }

            timerObj.Start(); // 启动计时器
            mObj.RunObj();
            timerObj.Stop();  // 停止计时器

            costTime = timerObj.GetMilliSecond;
            lblTime.Text = "耗时:" + costTime.ToString("F2") + "ms";
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

        /// <summary>
        /// 列表操作
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void 列表操作(object sender, EventArgs e)
        {
            UIButton button = sender as UIButton;
            switch (button.Text)
            {
                case "添加":
                    frmAddVar = new AddVarForm(AddDataGridView);
                    frmAddVar.ShowDialog();
                    break;
                case "删除":
                    RemovDataGridView();
                    break;
                case "上移":
                    UpDataGridView();
                    break;
                case "下移":
                    DownDataGridView();
                    break;
                case "置顶":
                    TopDataGridView();
                    break;
                case "置底":
                    BottomDataGridView();
                    break;
            }
        }

        /// <summary>
        /// 双击单元格显示编辑窗体事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dgv_VarList_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            string varType = "";
            int curIndex = dgv_VarList.CurrentCell.RowIndex;
            switch (dgv_VarList.Rows[curIndex].Cells[0].Value.ToString())
            {
                case "int":
                    varType = "Int";
                    break;
                case "int[]":
                    varType = "IntArr";
                    break;
                case "bool":
                    varType = "Bool";
                    break;
                case "bool[]":
                    varType = "BoolArr";
                    break;
                case "double":
                    varType = "Double";
                    break;
                case "double[]":
                    varType = "DoubleArr";
                    break;
                case "string":
                    varType = "String";
                    break;
                case "string[]":
                    varType = "StringArr";
                    break;
                default:
                    break;
            }

            string[] info = new string[4];

            info[0] = varType;
            info[1] = dgv_VarList.Rows[curIndex].Cells[1].Value.ToString();
            info[2] = dgv_VarList.Rows[curIndex].Cells[2].Value.ToString();
            info[3] = dgv_VarList.Rows[curIndex].Cells[3].Value.ToString();

            frmAddVar = new AddVarForm(AddDataGridView, info);
            frmAddVar.ShowDialog();
        }

        #endregion
    }
}
