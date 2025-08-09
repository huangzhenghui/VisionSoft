using HalconDotNet;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DockContrl;
using VisionCore;

using System.Reflection;
using RexView;
using RexConst;

namespace VisionCore
{
    /// <summary>
    /// 数据回传委托
    /// </summary>
    /// <param name="str"></param>
    public delegate void AddVarText(string str);

    /// <summary>
    /// 数据链接窗体
    /// </summary>
    public partial class PluginDataLinkForm : DockForm
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
        /// 连接的数据类型
        /// </summary>
        public string dataType = "";

        /// <summary>
        /// 数据链接-模块名称
        /// </summary>
        public string m_ModName = string.Empty;

        /// <summary>
        /// 数据链接-变量名称
        /// </summary>
        public string m_DataName = string.Empty;

        /// <summary>
        /// 返回数据
        /// </summary>
        public string m_OutLinkData { get; private set; } = string.Empty;

        /// <summary>
        /// 模块输出数据列表
        /// </summary>
        private List<DataCell> mVarList = new List<DataCell>();

        private List<ModInfo> modInfoList = new List<ModInfo>();

        #endregion

        #region 初始化

        /// <summary>
        /// 初始化
        /// </summary>
        /// <param name="ProjName">项目名称</param>
        /// <param name="ModName">模块名称</param>
        public PluginDataLinkForm(string ProjName, string ModName)
        {
            try
            {
                Set_MinMax();
                InitializeComponent();
                m_ModName = ModName;
                Proj mProj = Sol.mSol.mProjList.FirstOrDefault(c => c.mProjInfo.Name == ProjName);

                //全局变量
                foreach (DataCell Var in mProj.mSysVar)
                {
                    TreeNode TreeNode_A = new TreeNode(Var.mModName);
                    TreeNode TreeNode_B = null;
                    foreach (TreeNode m_Nodes in tre_ModList.Nodes)
                    {
                        if (TreeNode_A.Text == m_Nodes.Text)
                        {
                            TreeNode_B = m_Nodes;
                        }
                    }
                    if (TreeNode_B == null)
                    {
                        TreeNode TreeNode_C = new TreeNode(Var.mModName);
                        tre_ModList.Nodes.Add(TreeNode_C);
                    }
                }

                //模块单元
                if (mProj.mObjBase.Count == 0) return;
                foreach (ObjBase Obj in mProj.mObjBase)
                {
                    mVarList = Obj.mSloVar;
                }

                //检测新加入的节点是否与已存在的节点重名，如果不重名则加入
                for (int i = 0; i < mVarList.Count; i++)
                {
                    if (mVarList[i].mModName != mProj.mObjBase[mProj.mObjBase.Count - 1].ModInfo.Name)
                    {
                        TreeNode TreeNode_A = new TreeNode(mVarList[i].mModName);
                        TreeNode TreeNode_B = null;
                        foreach (TreeNode m_Nodes in tre_ModList.Nodes)
                        {
                            if (TreeNode_A.Text == m_Nodes.Text)
                            {
                                TreeNode_B = m_Nodes;
                            }
                        }
                        if (TreeNode_B == null)
                        {
                            TreeNode TreeNode_C = new TreeNode(mVarList[i].mModName);
                            tre_ModList.Nodes.Add(TreeNode_C);
                        }
                    }
                }
            }
            catch (Exception ex) 
            { 
                MessageBox.Show(ex.Message); 
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

        #region 事件-按钮控件

        /// <summary>
        /// 确定
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_OK_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        /// <summary>
        /// 取消
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_NO_Click(object sender, EventArgs e)
        {
            m_OutLinkData = " | ";
            this.Close();
        }

        /// <summary>
        /// 关闭
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        #endregion

        #region 事件-结构树控件

        /// <summary>选择模块后，在列表中列出该模块的相应类型的变量</summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tre_ModList_AfterSelect(object sender, TreeViewEventArgs e)
        {
            try
            {
                //根据模块名称前两个字来获取列表数据("全局"、"数据"、"变量")或从模块列表中获取相应名称的模块
                DataCell mDataCell = new DataCell();
                m_DataName = tre_ModList.SelectedNode.Text;
                if (m_DataName.Length < 4) return;
                switch (m_DataName.Substring(0, 4))
                {
                    case "全局变量":
                        {
                            List<DataCell> mAllData = Sol.mSol.mSysVar.FindAll(c => c.mModName.ToString() == m_DataName);
                            dgv_VarList.Rows.Clear();
                            int m = 0;
                            string typeInfo = "";
                            for (int i = 0; i < mAllData.Count; ++i)
                            {
                                string[] typeAssem = dataType.Split('|');
                                for (int p = 0; p < typeAssem.Length; p++)
                                {
                                    switch (mAllData[i].mDataMode)
                                    {
                                        case DataMode.整型:
                                            typeInfo = "int";
                                            break;
                                        case DataMode.整型数组:
                                            typeInfo = "int[]";
                                            break;
                                        case DataMode.双精度:
                                            typeInfo = "double";
                                            break;
                                        case DataMode.双精度数组:
                                            typeInfo = "double[]";
                                            break;
                                        case DataMode.布尔型:
                                            typeInfo = "bool";
                                            break;
                                        case DataMode.布尔型数组:
                                            typeInfo = "bool[]";
                                            break;
                                        case DataMode.字符串:
                                            typeInfo = "string";
                                            break;
                                        case DataMode.字符串数组:
                                            typeInfo = "string[]";
                                            break;
                                    }

                                    if (mAllData[i].mDataMode.ToString() == typeAssem[p])
                                    {
                                        dgv_VarList.Rows.Add();
                                        dgv_VarList.Rows[m].Cells[0].Value = typeInfo;
                                        dgv_VarList.Rows[m].Cells[1].Value = mAllData[i].mDataName;
                                        dgv_VarList.Rows[m].Cells[2].Value = mAllData[i].mDataValue;
                                        m++;
                                    }
                                }
                            }
                            dgv_VarList.SelectedIndex = 0;
                            return;
                        }
                    case "变量定义":
                        {
                            List<DataCell> mAllData = mVarList.FindAll(c => c.mModName.ToString() == m_DataName);
                            dgv_VarList.Rows.Clear();
                            for (int i = 0; i < mAllData.Count; ++i)
                            {
                                dgv_VarList.Rows.Add();
                                dgv_VarList.Rows[i].Cells[0].Value = mAllData[i].mDataMode;
                                dgv_VarList.Rows[i].Cells[1].Value = mAllData[i].mDataName;
                                dgv_VarList.Rows[i].Cells[2].Value = mAllData[i].mDataValue;
                            }
                            dgv_VarList.SelectedIndex = 0;
                            return;
                        }
                    default:
                        mDataCell = mVarList.First(c => c.mModName.ToString() == m_DataName);
                        break;
                }

                //获取字段属性，用于列表显示
                Dictionary<string, object> FieldList = null;
                switch (mDataCell.mDataMode)
                {
                    case DataMode.图像采集:
                        FieldList = Var.GetField(new CaptureImage_Info());
                        break;
                    case DataMode.图像增强:
                        FieldList = Var.GetField(new EmphasisImage_Info());
                        break;
                    case DataMode.灰度缩放:
                        FieldList = Var.GetField(new ScaleGray_Info());
                        break;
                    case DataMode.掩膜抠图:
                        FieldList = Var.GetField(new ReduceImage_Info());
                        break;
                    case DataMode.图像剪切:
                        FieldList = Var.GetField(new CropImage_Info());
                        break;
                    case DataMode.创建区域:
                        FieldList = Var.GetField(new CreateROI_Info());
                        break;
                    case DataMode.找圆工具:
                        FieldList = Var.GetField(new FindCircle_Info());
                        break;
                    case DataMode.找线工具:
                        FieldList = Var.GetField(new FindLine_Info());
                        break;
                    case DataMode.轮廓提取:
                        FieldList = Var.GetField(new ContourExt_Info());
                        break;
                    case DataMode.轮廓筛选:
                        FieldList = Var.GetField(new ContourSel_Info());
                        break;
                    case DataMode.创建模板:
                        FieldList = Var.GetField(new CreateModel_Info());
                        break;
                    case DataMode.查找模板:
                        FieldList = Var.GetField(new FindModel_Info());
                        break;
                    case DataMode.阈值分割:
                        FieldList = Var.GetField(new ThresholdSeg_Info());
                        break;
                    case DataMode.区域连通:
                        FieldList = Var.GetField(new ConnectReg_Info());
                        break;
                    case DataMode.区域填充:
                        FieldList = Var.GetField(new FillUpReg_Info());
                        break;
                    case DataMode.区域筛选:
                        FieldList = Var.GetField(new RegionSel_Info());
                        break;
                    case DataMode.区域处理:
                        FieldList = Var.GetField(new ProcessReg_Info());
                        break;
                    case DataMode.区域排序:
                        FieldList = Var.GetField(new SortReg_Info());
                        break;
                    case DataMode.区域运算:
                        FieldList = Var.GetField(new OperateReg_Info());
                        break;
                    case DataMode.外接区域:
                        FieldList = Var.GetField(new ExternalReg_Info());
                        break;
                    case DataMode.内接区域:
                        FieldList = Var.GetField(new InternalReg_Info());
                        break;
                    case DataMode.区域信息:
                        FieldList = Var.GetField(new RegionInfo_Info());
                        break;
                    case DataMode.形状转换:
                        FieldList = Var.GetField(new ShapeTrans_Info());
                        break;
                    case DataMode.等分矩形:
                        FieldList = Var.GetField(new PartRectangle_Info());
                        break;
                    case DataMode.对象选择:
                        FieldList = Var.GetField(new HObjectSel_Info());
                        break;
                    case DataMode.点点距离:
                        FieldList = Var.GetField(new DistancePP_Info());
                        break;
                    case DataMode.点线距离:
                        FieldList = Var.GetField(new DistancePL_Info());
                        break;
                    case DataMode.线线距离:
                        FieldList = Var.GetField(new DistanceLL_Info());
                        break;
                    case DataMode.线线交点:
                        FieldList = Var.GetField(new IntersectLL_Info());
                        break;
                    case DataMode.直线构建:
                        FieldList = Var.GetField(new CreateLine_Info());
                        break;
                    case DataMode.条件判断:
                        FieldList = Var.GetField(new Judge_Info());
                        break;
                    case DataMode.读一维码:
                        FieldList = Var.GetField(new ReadBarcode_Info());
                        break;
                    case DataMode.读二维码:
                        FieldList = Var.GetField(new ReadQRCode_Info());
                        break;
                    case DataMode.元组工具:
                        FieldList = Var.GetField(new HTupleTool_Info());
                        break;
                    case DataMode.文件读取:
                        FieldList = Var.GetField(new ReadFile_Info());
                        break;
                    case DataMode.仿射变换:
                        FieldList = Var.GetField(new AffineTrans_Info());
                        break;
                    case DataMode.拟合圆弧:
                        FieldList = Var.GetField(new FitCircle_Info());
                        break;
                    default:
                        FieldList = new Dictionary<string, object> { };
                        break;
                }

                //根据设定的数据类型来在列表中显示该类型的数据变量(列出类的对象)
                dgv_VarList.Rows.Clear();
                int j = 0;

                //根据设定的数据类型来在列表中显示该类型的数据变量(列出类的字段)
                foreach (KeyValuePair<string, object> item in FieldList)
                {
                    string[] typeAssem = dataType.Split('|');
                    for (int i = 0; i < typeAssem.Length; i++)
                    {
                        if (item.Value.ToString() == typeAssem[i])
                        {
                            dgv_VarList.Rows.Add();
                            dgv_VarList.Rows[j].Cells[0].Value = item.Value;
                            dgv_VarList.Rows[j].Cells[1].Value = item.Key;
                            string ReadStr = mDataCell.mDataAtrr == DataAtrr.系统变量 ? Var.GetLinkData(Sol.mSol.mSysVar, m_DataName + ":" + item.Key) : Var.GetLinkData(mVarList, m_DataName + ":" + item.Key);
                            ReadStr = ReadStr.Replace("|", "").Replace(m_DataName, "").Replace(item.Key, "");
                            dgv_VarList.Rows[j].Cells[2].Value = ReadStr;
                            j++;
                        }
                    }
                }
                dgv_VarList.SelectedIndex = 0;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
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

        /// <summary>
        /// 选中的单元格序列号改变事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="index"></param>
        private void dgv_VarList_SelectIndexChange(object sender, int index)
        {
            m_OutLinkData = m_DataName + "|" + dgv_VarList.Rows[dgv_VarList.SelectedIndex].Cells[1].Value.ToString() + "|" + dgv_VarList.Rows[dgv_VarList.SelectedIndex].Cells[2].Value.ToString();
        }

        /// <summary>
        /// 双击单元格事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dgv_VarList_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            m_OutLinkData = m_DataName + "|" + dgv_VarList.Rows[dgv_VarList.SelectedIndex].Cells[1].Value.ToString() + "|" + dgv_VarList.Rows[dgv_VarList.SelectedIndex].Cells[2].Value.ToString();
            Close();
        }

        #endregion
    }
}
