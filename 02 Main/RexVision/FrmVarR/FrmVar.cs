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

namespace TSIVision.FrmVarR
{
    public partial class FrmVar : Form
    {
        #region 字段、属性

        public FrmAddVar frmAddVar;
        public static List<DataCell> dataVarColl = new List<DataCell>();//泛型用来存放数据变量信息
        public static List<CtrlVar> ctrlVarColl = new List<CtrlVar>();//泛型用来存放控件变量信息
        public static List<Label> labels = new List<Label>();

        #endregion

        #region 初始化

        /// <summary>
        /// 初始化
        /// </summary>
        public FrmVar()
        {
            InitializeComponent();
        }

        #endregion

        #region 方法-窗体操作相关

        /// <summary>
        /// 刷新变量界面
        /// </summary>
        public void RefreshVarList()
        {
            //赋值
            dataVarColl = Sol.mSol.mSysVar;
            ctrlVarColl = Sol.mSol.ctrlVarColl;

            //刷新数据变量
            if (dataVarColl != null)
            {
                if (dataVarColl.Count != 0)
                {
                    int index1 = 0;
                    string dataType = "";
                    dgvDataVar.Rows.Clear();
                    foreach (DataCell data in dataVarColl)
                    {
                        dgvDataVar.Rows.Add();
                        switch (data.mDataMode)
                        {
                            case DataMode.整型:
                                dataType = "int";
                                break;
                            case DataMode.整型数组:
                                dataType = "int[]";
                                break;
                            case DataMode.双精度:
                                dataType = "double";
                                break;
                            case DataMode.双精度数组:
                                dataType = "double[]";
                                break;
                            case DataMode.布尔型:
                                dataType = "bool";
                                break;
                            case DataMode.布尔型数组:
                                dataType = "bool[]";
                                break;
                            case DataMode.字符串:
                                dataType = "string";
                                break;
                            case DataMode.字符串数组:
                                dataType = "string[]";
                                break;
                        }
                        dgvDataVar.Rows[index1].Cells[0].Value = dataType;
                        dgvDataVar.Rows[index1].Cells[1].Value = data.mDataName;
                        dgvDataVar.Rows[index1].Cells[2].Value = data.mDataInit;
                        dgvDataVar.Rows[index1].Cells[3].Value = data.mDataTip;
                        ++index1;
                    }
                }
                else
                {
                    dgvDataVar.ClearRows();
                }
            }

            if (ctrlVarColl != null)
            {
               
            }
        }

        #endregion

        #region 方法-按钮操作相关

        /// <summary>
        /// 添加数据变量
        /// </summary>
        /// <param name="tsMenuItem"></param>
        private void AddDataGridView()
        {
            frmAddVar = new FrmAddVar(AddDataVar);
            frmAddVar.Location = new Point(Screen.PrimaryScreen.WorkingArea.Width / 2 - frmAddVar.Width - 125, Screen.PrimaryScreen.WorkingArea.Height / 2 - 200);
            frmAddVar.dispSite = "left";
            frmAddVar.ShowDialog();
        }

        /// <summary>
        /// 添加控件变量
        /// </summary>
        /// <param name="tsMenuItem"></param>
        private void AddCtrlVar()
        {
           
            frmAddVar.Location = new Point(Screen.PrimaryScreen.WorkingArea.Width / 2 + frmAddVar.Width - 200, Screen.PrimaryScreen.WorkingArea.Height / 2 - 200);
            frmAddVar.dispSite = "right";
            frmAddVar.ShowDialog();
        }

        /// <summary>
        /// 删除变量
        /// </summary>
        /// <param name="dataGridView"></param>
        public static void RemovDataGridView(DataGridView dataGridView)
        {
            if (dataGridView.SelectedRows == null || dataGridView.SelectedRows.Count == 0)
            {
                MessageBox.Show("请先选择删除步，单击第一列以选中行");
            }
            else
            {
                if (MessageBox.Show("确定要删除选中步吗？") == DialogResult.OK)
                {
                    int index = dataGridView.SelectedRows[0].Index;//获取当前选中行的索引

                    dataGridView.Rows.RemoveAt(index);

                    switch (dataGridView.Name)
                    {
                        case "dgvDataVar":
                            dataVarColl.RemoveAt(index);
                            break;
                        case "dgvCtrlVar":
                            ctrlVarColl.RemoveAt(index);
                            DrawCtrls();
                            break;
                    }
                }
            }
        }

        /// <summary>
        /// 上移变量
        /// </summary>
        /// <param name="dataGridView"></param>
        public static void UpDataGridView(DataGridView dataGridView)
        {
            try
            {
                DataGridViewSelectedRowCollection dgvsrc = dataGridView.SelectedRows;//获取选中行的集合
                if (dgvsrc.Count > 0)
                {
                    int index = dataGridView.SelectedRows[0].Index;//获取当前选中行的索引
                    if (index > 0)//如果该行不是第一行
                    {
                        DataGridViewRow dgvr = dataGridView.Rows[index - dgvsrc.Count];//获取选中行的上一行
                        dataGridView.Rows.RemoveAt(index - dgvsrc.Count);//删除原选中行的上一行
                        dataGridView.Rows.Insert((index), dgvr);//将选中行的上一行插入到选中行的后面

                        for (int i = 0; i < dgvsrc.Count; i++)//选中移动后的行
                        {
                            dataGridView.Rows[index - i - 1].Selected = true;
                        }

                        switch (dataGridView.Name)
                        {
                            case "dgvDataVar":
                                DataCell dataCell = dataVarColl[index];
                                dataVarColl.RemoveAt(index);
                                dataVarColl.Insert(index - 1, dataCell);
                                break;
                            case "dgvCtrlVar":
                                CtrlVar ctrlVar = ctrlVarColl[index];
                                ctrlVarColl.RemoveAt(index);
                                ctrlVarColl.Insert(index - 1, ctrlVar);
                                DrawCtrls();
                                break;
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
        /// 变量下移
        /// </summary>
        /// <param name="dataGridView"></param>
        public static void DownDataGridView(DataGridView dataGridView)
        {
            try
            {
                DataGridViewSelectedRowCollection dgvsrc = dataGridView.SelectedRows;//获取选中行的集合
                if (dgvsrc.Count > 0)
                {
                    int index = dataGridView.SelectedRows[0].Index;//获取当前选中行的索引
                    if (index >= 0 & (dataGridView.RowCount - 1) != index)//如果该行不是最后一行
                    {
                        DataGridViewRow dgvr = dataGridView.Rows[index + 1];//获取选中行的下一行
                        dataGridView.Rows.RemoveAt(index + 1);//删除原选中行的上一行
                        dataGridView.Rows.Insert((index + 1 - dgvsrc.Count), dgvr);//将选中行的上一行插入到选中行的后面

                        for (int i = 0; i < dgvsrc.Count; i++)//选中移动后的行
                        {
                            dataGridView.Rows[index + 1 - i].Selected = true;
                        }

                        switch (dataGridView.Name)
                        {
                            case "dgvDataVar":
                                DataCell dataCell = dataVarColl[index];
                                dataVarColl.RemoveAt(index);
                                dataVarColl.Insert(index + 1, dataCell);
                                break;
                            case "dgvCtrlVar":
                                CtrlVar ctrlVar = ctrlVarColl[index];
                                ctrlVarColl.RemoveAt(index);
                                ctrlVarColl.Insert(index + 1, ctrlVar);
                                DrawCtrls();
                                break;
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
        /// 置顶变量
        /// </summary>
        /// <param name="dataGridView"></param>
        public static void TopDataGridView(DataGridView dataGridView)
        {
            try
            {
                DataGridViewSelectedRowCollection dgvsrc = dataGridView.SelectedRows;//获取选中行的集合
                if (dgvsrc.Count > 0)
                {
                    int index = dataGridView.SelectedRows[0].Index;//获取当前选中行的索引
                    if (index > 0)//如果该行不是第一行
                    {
                        DataGridViewRow dgvr = dataGridView.Rows[index];//获取选中行的上一行
                        dataGridView.Rows.RemoveAt(index);//删除原选中行的上一行
                        dataGridView.Rows.Insert(0, dgvr);//将选中行的上一行插入到选中行的后面                       
                        for (int i = 0; i < dataGridView.Rows.Count; i++)//选中移动后的行
                        {
                            if (i != 0)
                            {
                                dataGridView.Rows[i].Selected = false;
                            }
                            else
                            {
                                dataGridView.Rows[i].Selected = true;
                            }
                        }

                        switch (dataGridView.Name)
                        {
                            case "dgvDataVar":
                                DataCell dataCell = dataVarColl[index];
                                dataVarColl.RemoveAt(index);
                                dataVarColl.Insert(0, dataCell);
                                break;
                            case "dgvCtrlVar":
                                CtrlVar ctrlVar = ctrlVarColl[index];
                                ctrlVarColl.RemoveAt(index);
                                ctrlVarColl.Insert(0, ctrlVar);
                                DrawCtrls();
                                break;
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
        /// 置底变量
        /// </summary>
        /// <param name="dataGridView"></param>
        public static void BottomDataGridView(DataGridView dataGridView)
        {
            try
            {
                DataGridViewSelectedRowCollection dgvsrc = dataGridView.SelectedRows;//获取选中行的集合
                if (dgvsrc.Count > 0)
                {
                    int index = dataGridView.SelectedRows[0].Index;//获取当前选中行的索引
                    if (index < dataGridView.Rows.Count - 1)//如果该行不是第一行
                    {
                        DataGridViewRow dgvr = dataGridView.Rows[index];//获取选中行的上一行
                        dataGridView.Rows.RemoveAt(index);//删除原选中行的上一行
                        int nCount = dataGridView.Rows.Count;
                        dataGridView.Rows.Insert(nCount, dgvr);//将选中行的上一行插入到选中行的后面
                        for (int i = 0; i < dataGridView.Rows.Count; i++)//选中移动后的行
                        {
                            if (i != dataGridView.Rows.Count - 1)
                            {
                                dataGridView.Rows[i].Selected = false;
                            }
                            else
                            {
                                dataGridView.Rows[i].Selected = true;
                            }
                        }

                        switch (dataGridView.Name)
                        {
                            case "dgvDataVar":
                                DataCell dataCell = dataVarColl[index];
                                dataVarColl.RemoveAt(index);
                                dataVarColl.Insert(dataGridView.Rows.Count - 1, dataCell);
                                break;
                            case "dgvCtrlVar":
                                CtrlVar ctrlVar = ctrlVarColl[index];
                                ctrlVarColl.RemoveAt(index);
                                ctrlVarColl.Insert(dataGridView.Rows.Count - 1, ctrlVar);
                                DrawCtrls();
                                break;
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
        /// 保存控件变量
        /// </summary>
        public static void DrawCtrls()
        {
        
            labels.Clear();

            //绘制监控控件
            foreach (CtrlVar item in ctrlVarColl)
            {
                switch (item.CtrlType)
                {
                    case "执行监控控件":
                        DynDrawCtrls(item.CtrlType, item.CtrlName, item.CtrlValueInit, 6);
                        break;
                    case "数据监控控件":
                        DynDrawCtrls(item.CtrlType, item.CtrlName, item.CtrlValueInit, 4);
                        break;
                    case "线程监控控件":
                        DynDrawCtrls(item.CtrlType, item.CtrlName, item.CtrlValueInit, 6);
                        break;
                    default:
                        break;
                }
            }
        }

        #endregion

        #region 事件-按钮控件

        /// <summary>
        /// 数据变量菜单的操作
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tsmiDataVar_Click(object sender, EventArgs e)
        {
            ToolStripMenuItem tsmiDataVar = sender as ToolStripMenuItem;
            switch (tsmiDataVar.Text)
            {
                case "添加变量":
                    AddDataGridView();
                    break;
                case "删除变量":
                    RemovDataGridView(dgvDataVar);
                    break;
                case "上移变量":
                    UpDataGridView(dgvDataVar);
                    break;
                case "下移变量":
                    DownDataGridView(dgvDataVar);
                    break;
                case "置顶变量":
                    TopDataGridView(dgvDataVar);
                    break;
                case "置底变量":
                    BottomDataGridView(dgvDataVar);
                    break;
            }
        }

        /// <summary>
        /// 控件变量菜单的操作
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tsmiCtrlVar_Click(object sender, EventArgs e)
        {
         
        }

        /// <summary>
        /// 动态绘制监控控件
        /// </summary>
        /// <param name="type"></param>
        /// <param name="name"></param>
        /// <param name="tip"></param>
        /// <param name="ispageChange"></param>
        public static void DynDrawCtrls(string type, string name, string value, int ispageChange)
        {
            Label lblItem = new Label();
            lblItem.Text = name + ":";
            lblItem.BackColor = Color.FromArgb(224, 224, 224);
            lblItem.Dock = DockStyle.Fill;
            lblItem.Font = new Font("隶书", 13);
            lblItem.Margin = new Padding(0, 0, 0, 1);
            lblItem.TextAlign = ContentAlignment.MiddleCenter;

            Label lblValue = new Label();
            lblValue.Name = name;
            lblValue.Text = value;
            lblValue.BackColor = Color.Lavender;
            lblValue.Dock = DockStyle.Fill;
            lblValue.Font = new Font("隶书", 13);
            lblValue.Margin = new Padding(2, 0, 2, 1);
            lblValue.TextAlign = ContentAlignment.MiddleCenter;

            labels.Add(lblValue);

         
        }

        #endregion

        #region 事件-窗体控件

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
                        var x = e.CellBounds.X + (e.CellBounds.Width - sizeF.Width) / 2.08f; // 获取 Left
                        var y = e.CellBounds.Y + (e.CellBounds.Height - sizeF.Height) / 1.3f; // 获取 Top

                        g.DrawString(text, dgv.ColumnHeadersDefaultCellStyle.Font, fg, x, y); // 绘制列标题
                    }
                    e.Handled = true;
                }
            }
        }

        /// <summary>
        /// 刷新变量界面
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FrmVar_Load(object sender, EventArgs e)
        {
            RefreshVarList();
        }

        #endregion

        #region 方法-变量相关

        /// <summary>
        /// 添加数据变量
        /// </summary>
        /// <param name="dataGridView"></param>
        public void AddDataVar(string[] info)
        {
            //如果原先存在则修改值
            for (int j = 0; j < dgvDataVar.RowCount; j++)
            {
                if (info[1] == dgvDataVar.Rows[j].Cells[1].Value.ToString())
                {
                    dgvDataVar.Rows[j].Cells[0].Value = info[0];
                    dgvDataVar.Rows[j].Cells[1].Value = info[1];
                    dgvDataVar.Rows[j].Cells[2].Value = info[2];
                    dgvDataVar.Rows[j].Cells[3].Value = info[3];

                    DataMode varType = new DataMode();
                    switch (info[0])
                    {
                        case "int":
                            varType = DataMode.整型;
                            break;
                        case "int[]":
                            varType = DataMode.整型数组;
                            break;
                        case "double":
                            varType = DataMode.双精度;
                            break;
                        case "double[]":
                            varType = DataMode.双精度数组;
                            break;
                        case "bool":
                            varType = DataMode.布尔型;
                            break;
                        case "bool[]":
                            varType = DataMode.布尔型数组;
                            break;
                        case "string":
                            varType = DataMode.字符串;
                            break;
                        case "string[]":
                            varType = DataMode.字符串数组;
                            break;
                    }

                    DataCell dataCell = dataVarColl[j];
                    dataCell.mDataMode = varType;
                    dataCell.mDataName = info[1];
                    dataCell.mDataValue = info[2];
                    dataCell.mDataInit = info[2];
                    dataCell.mDataTip = info[3];
                    dataVarColl.RemoveAt(j);
                    dataVarColl.Insert(j, dataCell);
                    return;
                }
            }

            //如果原先不存在则新建
            DataGridViewRow dr = new DataGridViewRow();
            dr.CreateCells(dgvDataVar);
            dr.Cells[0].Value = info[0];
            dr.Cells[1].Value = info[1];
            dr.Cells[2].Value = info[2];
            dr.Cells[3].Value = info[3];
            dgvDataVar.Rows.Add(dr);//添加的行作为最后一行
            dgvDataVar.Rows[dgvDataVar.RowCount - 1].Height = 29;

            DataMode type = new DataMode();
            switch (info[0])
            {
                case "int":
                    type = DataMode.整型;
                    break;
                case "int[]":
                    type = DataMode.整型数组;
                    break;
                case "double":
                    type = DataMode.双精度;
                    break;
                case "double[]":
                    type = DataMode.双精度数组;
                    break;
                case "bool":
                    type = DataMode.布尔型;
                    break;
                case "bool[]":
                    type = DataMode.布尔型数组;
                    break;
                case "string":
                    type = DataMode.字符串;
                    break;
                case "string[]":
                    type = DataMode.字符串数组;
                    break;
            }

            string name = info[1];
            string valueInit = info[2];
            string value = info[2];
            string remark = info[3];
            dataVarColl.Add(new DataCell("全局变量", 0, DataType.单量, type, name, remark, valueInit, 1, value, DataAtrr.全局变量));
        }

        /// <summary>
        /// 添加控件变量
        /// </summary>
        /// <param name="dataGridView"></param>
  

        #endregion

        #region 事件-DataGridView控件

        /// <summary>
        /// 双击单元格编辑数据变量
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dgvDataVar_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            string[] info = new string[4];
            int curIndex = dgvDataVar.CurrentCell.RowIndex;
            info[0] = dgvDataVar.Rows[curIndex].Cells[0].Value.ToString();
            info[1] = dgvDataVar.Rows[curIndex].Cells[1].Value.ToString();
            info[2] = dgvDataVar.Rows[curIndex].Cells[2].Value.ToString();
            info[3] = dgvDataVar.Rows[curIndex].Cells[3].Value.ToString();

            frmAddVar = new FrmAddVar(AddDataVar, info);
            frmAddVar.dispSite = "left";
            frmAddVar.Location = new Point(Screen.PrimaryScreen.WorkingArea.Width / 2 - frmAddVar.Width - 125, Screen.PrimaryScreen.WorkingArea.Height / 2 - 200);
            frmAddVar.ShowDialog();
        }

        /// <summary>
        /// 双击单元格编辑控件变量
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dgvCtrlVar_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            string[] info = new string[4];
         
            frmAddVar.dispSite = "right";
            frmAddVar.Location = new Point(Screen.PrimaryScreen.WorkingArea.Width / 2 + frmAddVar.Width - 200, Screen.PrimaryScreen.WorkingArea.Height / 2 - 200);
            frmAddVar.ShowDialog();
        }

        #endregion

        private void pnlCtrlVar_Click(object sender, EventArgs e)
        {

        }
    }
}
