using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Rex.UI;

using VisionCore;

namespace TSIVision.FrmConfigR
{
    public delegate void SetCamearDg(CamerasBase mCamear, EComOperate type);
    public partial class FrmConfigCam : Form
    {
        #region 字段、属性

        /// <summary>
        /// 相机参数窗体对象
        /// </summary>
        public static FrmCCamParams frmCCamParams = new FrmCCamParams();

        /// <summary>
        /// 当前相机
        /// </summary>
        public CamerasBase mCamerasBase=new CamerasBase();

        /// <summary>
        /// 相机列表
        /// </summary>
        public static List<CamerasBase> mCamerasList=new List<CamerasBase>();

        /// <summary>
        /// 相机参数列表
        /// </summary>
        public List<CamerasInfo> CamInfoList;

        /// <summary>
        /// 品牌列表
        /// </summary>
        private List<string> TypeList = PluginCamService.cPluginDic.Keys.ToList();

        /// <summary>
        /// 窗体加载不触发事件 
        /// </summary>
        public bool mLoading = false;

        /// <summary>
        /// 相机设置触发事件
        /// </summary>
        public static event SetCamearDg SetCamearEvent;

        /// <summary>
        /// DataGridView选中行的索引号
        /// </summary>
        public int dgvCurCellIndex;

        #endregion

        #region 初始化
        public FrmConfigCam()
        {
            InitializeComponent();
        }

        #endregion

        #region 方法-防止窗体闪烁

        /// <summary>
        /// 重写CreateParams方法，以防止窗体闪烁
        /// </summary>
        protected override CreateParams CreateParams
        {
            get
            {
                CreateParams paras = base.CreateParams;
                paras.ExStyle |= 0x02000000;
                return paras;
            }
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

        #endregion

        #region 方法-相机相关

        /// <summary>
        /// 添加相机
        /// </summary>
        public void AddCam()
        {
            if (cbxCamSelect.SelectedIndex < 0) { return; }
            int index = mCamerasList.FindIndex(c => c.mSerialNo == cbxCamSelect.SelectedItem.ToString());
            if (index >= 0)
            {
                MessageBox.Show("该设备已经添加列表");
                return;
            }
            //根据选中的插件 new一个 模块
            PluginsInfo m_PluginsInfo = PluginCamService.cPluginDic[TypeList[cbxCamType.SelectedIndex]];
            CamerasBase ModObj = (CamerasBase)m_PluginsInfo.ModObjType.Assembly.CreateInstance(m_PluginsInfo.ModObjType.FullName);
           
            //根据选中的相机将对应参数从列表中取出
            ModObj.camInfo = CamInfoList[cbxCamSelect.SelectedIndex];

            //将相机参数赋给变量，以便于在DataGridView中显示
            ModObj.mCamName = ModObj.camInfo.m_CamName;
            ModObj.mSerialNo = ModObj.camInfo.m_SerialNO;
            ModObj.mCameraIP = ModObj.camInfo.m_CameraIP;
            ModObj.mExposeTime = ModObj.camInfo.m_ExposureTime;
            ModObj.mGain = ModObj.camInfo.m_Gain;
            ModObj.mWidth = ModObj.camInfo.m_Width;
            ModObj.mHeight = ModObj.camInfo.m_Height;
            ModObj.mConnected = ModObj.camInfo.m_Connected;

            mCamerasList.Add(ModObj);
            dgvCamList.DataSource = mCamerasList.ToList();
            SetCamearEvent(ModObj, EComOperate.Add);
        }

        /// <summary>
        /// 移除相机
        /// </summary>
        public void RemoveCam()
        {
            if (mCamerasBase == null) { return; }
            mCamerasBase.DisConnectDev();
            CamerasBase RemovCamera = mCamerasList.Find(c => c.mSerialNo == mCamerasBase.mSerialNo);
            SetCamearEvent(RemovCamera, EComOperate.Remove);
            mCamerasList.Remove(RemovCamera);
            dgvCamList.DataSource = mCamerasList.ToList();
        }

        /// <summary>
        /// 根据DataGridView选择相机设置
        /// </summary>
        private void DgvCamSelect()
        {
            if (dgvCamList.CurrentCell == null) { return; }
            mCamerasBase = mCamerasList[dgvCurCellIndex];
            CamerasBase.mCamerasBase = mCamerasBase;
            FrmCCamDebug.dgvCamList = dgvCamList;
            CamerasBase.mCamerasList = mCamerasList;
        }

        #endregion

        #region 事件-按钮控件

        private void btn_Click(object sender, EventArgs e)
        {
            UIButton btn = sender as UIButton;
            switch (btn.Name)
            {
                case "btnAdd":
                    AddCam();
                    break;
                case "btnPageChange":
                    DgvCamSelect();
                    if (mCamerasBase==null)
                    {
                        MessageBox.Show("请选择相机！");
                        return;
                    }
                    FrmCCamDebug frmCCamDebug = new FrmCCamDebug();
                    frmCCamDebug.Location = new Point(uiPnl.Width/2-150, uiPnl.Height/2);
                    frmCCamDebug.StartPosition = FormStartPosition.Manual;
                    frmCCamDebug.ShowDialog();
                    break;
                case "btnRemove":
                    RemoveCam();
                    break;
                default:
                    break;
            }
        }

        #endregion

        #region 事件-窗体控件

        /// <summary>
        /// 相机配置界面加载
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FrmConfigCam_Load(object sender, EventArgs e)
        {
            dgvCamList.AutoGenerateColumns = false;
            cbxCamType.DataSource = TypeList.ToList();
            mCamerasList = Sol.mSol.mCamerasList;
            dgvCamList.DataSource = mCamerasList.ToList();
            timer1.Enabled = true;
            mLoading = true;
        }

        #endregion

        #region 事件-ComboBox控件根据选中相机类型更新相机

        /// <summary>
        /// ComboBox选中的相机类型发生变化所执行的事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cbxCamType_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbxCamType.SelectedIndex < 0) { return; }
            PluginsInfo pluginsInfo = PluginCamService.cPluginDic[TypeList[cbxCamType.SelectedIndex]];
            CamerasBase ModObj = (CamerasBase)pluginsInfo.ModObjType.Assembly.CreateInstance(pluginsInfo.ModObjType.FullName);
            CamInfoList = ModObj.SearchCameras();
            cbxCamSelect.Text = "";
            cbxCamSelect.Items.Clear();
            foreach (CamerasInfo info in CamInfoList)
            {
                //将相机序列号放于ComboBox中，以便于选择
                cbxCamSelect.Items.Add(info.m_SerialNO);
            }
        }

        #endregion

        #region 事件-DataGridView控件

        /// <summary>
        /// 相机列表选中相机所执行的事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dgvCamList_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DgvCamSelect();
            dgvCurCellIndex = dgvCamList.CurrentCell.RowIndex;
        }

        /// <summary>
        /// 鼠标按下界面不刷新
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dgvCamList_MouseDown(object sender, MouseEventArgs e)
        {
            timer1.Enabled = false;
        }

        /// <summary>
        /// 鼠标抬起界面恢复刷新
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dgvCamList_MouseUp(object sender, MouseEventArgs e)
        {
            timer1.Enabled = true;
        }

        #endregion

        #region 事件-DataGridView控件单元格重绘

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
                        var x = e.CellBounds.X + (e.CellBounds.Width - sizeF.Width) / 2.05f; // 获取 Left
                        var y = e.CellBounds.Y + (e.CellBounds.Height - sizeF.Height) / 3f; // 获取 Top

                        g.DrawString(text, dgv.ColumnHeadersDefaultCellStyle.Font, fg, x, y); // 绘制列标题
                    }
                    e.Handled = true;
                }
            }
        }

        #endregion

        #region 事件-Timer控件

        /// <summary>
        /// 刷新DataGridView数据
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void timer1_Tick(object sender, EventArgs e)
        {
            dgvCamList.AutoGenerateColumns = false;
            dgvCamList.DataSource = mCamerasList.ToList();
            if (dgvCamList.RowCount != 0)
            {
                dgvCamList.Rows[dgvCurCellIndex].Selected = true;
            }
        }

        #endregion
    }
}
