 using RexConst;
using RexForm;
using System;
using System.IO;
using System.Windows.Forms;
using VisionCore;
using WeifenLuo.WinFormsUI.Docking;

namespace TSIVision
{
    /// <summary>主窗体</summary>
    public partial class FrmShow : Form
    {
        #region 字段、属性

        private FrmTool mFrmToolView = null;//工具显示窗体
        private FrmProj mFrmProjView = null;//流程显示窗体
        private FrmData mFrmDataView = null;//数据显示窗体
        private FrmLog mFrmLogView = null;//日志显示窗体
        private FrmCanvas mFrmCanvasView = null;//图像显示窗体
        private FrmNet mFrmNetView = null;//通讯显示窗体
        private string m_DockPath = string.Empty;//Dockpanel配置路径
        private DeserializeDockContent mDockContent;//声明获取指定窗体的委托

        #endregion

        #region 初始化

        public FrmShow()
        {
            InitializeComponent();
        }

        #endregion

        #region 方法-窗体相关

        /// <summary>
        /// 获得指定的窗体
        /// </summary>
        /// <param name="persistString"></param>
        /// <returns></returns>
        private IDockContent GetContentFromPersistString(string persistString)
        {
            if (persistString == typeof(FrmTool).ToString())
                return mFrmToolView;
            else if (persistString == typeof(FrmProj).ToString())
                return mFrmProjView;
            else if (persistString == typeof(FrmCanvas).ToString())
                return mFrmCanvasView;
            else if (persistString == typeof(FrmNet).ToString())
                return mFrmNetView;
            else if (persistString == typeof(FrmData).ToString())
                return mFrmDataView;
            else if (persistString == typeof(FrmLog).ToString())
                return mFrmLogView;
            else
                return null;
        }

        /// <summary>
        /// 读取Xml配置文件来加载动态窗体
        /// </summary>
        public void InitDockPanel()
        {
            try
            {
                if (File.Exists(m_DockPath))
                {
                    MainDockPanel.LoadFromXml(m_DockPath, mDockContent);
                }
                else
                {
                    MessageBox.Show("动态窗体配置文件不存在！");
                }
            }
            catch (Exception)
            {
                MessageBox.Show("动态窗体配置文件加载失败！");
            }
        }

        /// <summary>
        /// 创建流程栏
        /// </summary>
        public void SetProj()
        {
            mFrmProjView.SetSol();
        }

        /// <summary>
        /// 相机窗口设置
        /// </summary>
        /// <param name="num">相机窗口数量</param>
        public void CanvasSet(int num)
        {
            if (mFrmCanvasView == null) { mFrmCanvasView = new FrmCanvas(); }
            mFrmCanvasView.SetViewMode(num);
        }

        /// <summary>
        /// 布局显示
        /// </summary>
        /// <param name="UiName"></param>
        public void ShowUI(string UiName)
        {
            switch (UiName)
            {
                case "保存布局":
                    MainDockPanel.SaveAsXml(m_DockPath);
                    break;
                case "工具显示":
                    if (mFrmToolView == null) { mFrmToolView = new FrmTool(); }
                    mFrmToolView.Show(MainDockPanel, DockState.DockLeft);
                    break;
                case "流程显示":
                    if (mFrmProjView == null) { mFrmProjView = new FrmProj(); }
                    mFrmProjView.Show(MainDockPanel, DockState.DockLeft);
                    break;
                case "图像显示":
                    if (mFrmCanvasView == null) { mFrmCanvasView = new FrmCanvas(); }
                    mFrmCanvasView.Show(MainDockPanel, DockState.Document);
                    break;
                case "通讯显示":
                    if (mFrmNetView == null) { mFrmNetView = new FrmNet(); }
                    mFrmNetView.Show(MainDockPanel, DockState.Document);
                    break;
                case "数据显示":
                    if (mFrmDataView == null) { mFrmDataView = new FrmData(); }
                    mFrmDataView.Show(MainDockPanel, DockState.DockBottom);
                    break;
                case "日志显示":
                    if (mFrmLogView == null) { mFrmLogView = new FrmLog(); }
                    mFrmLogView.Show(MainDockPanel, DockState.DockBottom);
                    break;
            }
        }

        /// <summary>
        /// 相机窗口图像显示
        /// </summary>
        /// <param name="Image"></param>
        public void ScreenShow(RImage Image)
        {
            mFrmCanvasView.ScreenShow(Image);
        }

        /// <summary>
        /// 清空图像窗口
        /// </summary>
        public void ScreenClear()
        {
            mFrmCanvasView.ScreenClear();
        }

        #endregion

        /// <summary>
        /// 清空日志窗口
        /// </summary>
        public void LogClear()
        {
            mFrmLogView.richTextBox_log.Clear();
        }

        #region 事件-窗体控件

        /// <summary>
        /// FrmShow窗体(放置DokPanel的窗体)加载
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FrmShow_Load(object sender, EventArgs e)
        {
            try
            {
                mFrmToolView = new FrmTool();
                mFrmProjView = new FrmProj();
                mFrmCanvasView = new FrmCanvas();
                mFrmNetView = new FrmNet();
                mFrmDataView = new FrmData();
                mFrmLogView = new FrmLog();
            }
            catch (Exception ex)
            {
                Log.Error("FrmShow_Load:" + ex.Message);
            }
            mDockContent = new DeserializeDockContent(GetContentFromPersistString);
            MainDockPanel.Visible = true;
            m_DockPath = Path.Combine(Path.GetDirectoryName(Application.ExecutablePath), "DockPanel.config");
            InitDockPanel();
        }

        /// <summary>
        /// 主窗体关闭后将dockpanel信息保存于xml文件中
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FrmShow_FormClosed(object sender, FormClosedEventArgs e)
        {
            MainDockPanel.SaveAsXml(m_DockPath);
        }

        #endregion
    }
}
