using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text.RegularExpressions;
using D2D = SharpDX.Direct2D1;
using DXGI = SharpDX.DXGI;
using System.Threading;
using System.Windows.Forms;
using SharpDX;
using System.Drawing;
using gCursorLib;
using VisionCore.SolForm.FormR;
using System.Linq;

namespace VisionCore
{
    [Flags]
    public enum UnitFlowMode
    {
        DisplayJudgeIcon = 1,
        DisplayTerminator = 4,
        HiddenUnit = 2,
        IconButtonDisable = 0x10,
        NGUnitSearchEnabled = 0x20,
        TreeViewDisable = 8
    }

    /// <summary>
    /// 模块控件类
    /// </summary>
    public partial class ModFlow : UserControl
    {
        #region 委托  

        public delegate void beginInvokeDelegate();
        public delegate void ItemButtonClickHandle(ModFlowItem item);
        public delegate void SelectedItemChangeHandle(ModFlowItem item);
        public delegate void ItemButtonDoubleClickHandle(ModFlowItem item);
        public delegate void ItemDragDropHandl(ModFlowItem from, ModFlowItem to);
        public delegate int WndProcDelegate(IntPtr hwnd, uint msg, IntPtr wParam, IntPtr lParam);

        #endregion

        #region 事件

        /// <summary>
        /// 当前的鼠标信息,由于拖拽造成不响应鼠标事件,在timer中定时触发
        /// </summary>
        private MouseEventArgs mMoseArgs;

        /// <summary>
        /// 拖拽时候的模块源,创建模块时候的源头要重新new一个模块
        /// </summary>
        public ModFlowItem mUiFrom;

        /// <summary>
        /// 模块按钮按单击事件
        /// </summary>
        public event ItemButtonClickHandle ItemButtonClick;

        /// <summary>
        /// 当前模块修改
        /// </summary>
        public event SelectedItemChangeHandle SelectedItemChange;

        /// <summary>
        /// 模块按钮按单击事件
        /// </summary>
        public event ItemButtonDoubleClickHandle ItemButtonDoubleClick;

        #endregion

        #region 字段

        /// <summary>
        /// 创建一个同步基元
        /// </summary>
        private static Mutex Mutexs = new Mutex();

        /// <summary>
        /// 流程对象
        /// </summary>
        private Proj mProj;

        /// <summary>
        /// 画布图像,所有自绘图像都是在此处绘制后贴在控件上
        /// </summary>
        private Bitmap mBuff;

        /// <summary>
        /// 模块单元的高度
        /// </summary>
        private int mItemHeight = 40;

        /// <summary>
        /// 选择模块是否修改
        /// </summary>
        private bool mIsChangeSelectItem;

        /// <summary>
        /// 模块树结构
        /// </summary>
        private TreeView mTreeView;

        /// <summary>
        /// 是否多选
        /// </summary>
        public bool mIsMultiSelect;

        /// <summary>
        /// 当前鼠标所在模块名称
        /// </summary>
        private string mCurModName;

        /// <summary>
        /// 运行状态禁用部分功能
        /// </summary>
        public bool UseAble = true;

        /// <summary>
        /// 拖拽允许
        /// </summary>
        public bool mItemDragEnabled;

        /// <summary>
        /// 鼠标当前模块
        /// </summary>
        private ModFlowItem mMouseOverItem;

        /// <summary>
        /// 之前选中模块
        /// </summary>
        private ModFlowItem mBeforeSelectItem;

        /// <summary>
        /// 当前选中的ModFlowItem
        /// </summary>
        private ModFlowItem mIsNowSelectedItem;

        /// <summary>
        /// 编辑窗口
        /// </summary>
        public FrmModify frmModify;

        public MouseEventArgs mouseEventArgs;

        private D2D.Factory factory;
        private D2D.RenderTarget _renderTarget;//d2d 要画的目标对象
        private int move;
        private int tick_count;

        /// <summary>
        /// 用于流程刷新的序号
        /// </summary>
        private int sfcIndex = -1;

        /// <summary>
        /// 鼠标拖拽丢放的位置
        /// </summary>
        private Point mMouseUpPos;

        /// <summary>
        /// 鼠标按下时候的位置
        /// </summary>
        private Point mMouseDownPos;

        /// <summary>
        /// 单元模块模式
        /// </summary>
        private UnitFlowMode mMode;

        /// <summary> 
        /// 注释文本
        /// </summary>
        protected TextBox mNoteText = new TextBox() { BorderStyle = BorderStyle.None };

        /// <summary>
        /// 用于保存是否展开的状态 用key作为容器,刷新前清除容器,需要保证键值唯一
        /// </summary>
        private Dictionary<string, bool> mNodesStatusDic = new Dictionary<string, bool>();

        #endregion

        #region 属性
        /// <summary>
        /// 模块高度
        /// </summary>
        public int ItemHeight
        {
            get
            {
                return mItemHeight;
            }
            set
            {
                mItemHeight = Math.Max(value, 5);
                VscrollBar.SmallChange = mItemHeight;
                Refresh();
                EnsureVisible(SelectItem.ModNo);
            }
        }

        /// <summary>
        /// 是否刷新
        /// </summary>
        public bool RefreshEnabled { get; set; } = true;

        /// <summary>
        /// 模块类型
        /// </summary>
        public UnitFlowMode Mode
        {
            get
            {
                return mMode;
            }
            set
            {
                mMode = value;
                if ((mMode & UnitFlowMode.NGUnitSearchEnabled) != 0)
                {
                    VscrollBar.Top = 0;
                    VscrollBar.Height = base.Height;
                }
                else
                {
                    VscrollBar.Top = 0;
                    VscrollBar.Height = base.Height;
                }
            }
        }

        /// <summary>
        /// 流程信息
        /// </summary>
        public ProjInfo ProjInfo
        {
            get { return mProj.mProjInfo; }
            set
            {
                mProj.mProjInfo = value;
                foreach (ModInfo info in mProj.mModInfo)
                {
                    info.State = ModState.None;
                }
            }
        }
        public ModFlowItem SelectItem
        {
            get
            {
                if ((mBeforeSelectItem != null) && mBeforeSelectItem.IsSelected)
                {
                    return mBeforeSelectItem;
                }
                return null;
            }
        }
        private TreeNodeCollection Nodes
        {
            get
            {
                if (mTreeView == null)
                {
                    return null;
                }
                return mTreeView.Nodes;
            }
        }
        public List<ModFlowItem> SelectedItemArray
        {
            get
            {
                List<ModFlowItem> lst = new List<ModFlowItem>();
                if (mIsMultiSelect)
                {
                    GetSelectedItems(Nodes, ref lst);
                    return lst;
                }
                if (mBeforeSelectItem != null)
                {
                    lst.Add(mBeforeSelectItem);
                }
                return lst;
            }
        }

        #endregion

        #region 初始化

        /// <summary>
        /// 初始化
        /// </summary>
        /// <param name="Proj"></param>
        public ModFlow(Proj Proj)
        {
            InitializeComponent();
            SetStyle(ControlStyles.UserPaint, true);
            SetStyle(ControlStyles.AllPaintingInWmPaint, true); // 禁止擦除背景.
            SetStyle(ControlStyles.DoubleBuffer, true); // 双缓冲
            mProj = Proj;
            mTreeView = new TreeView();
            Mode = Mode | UnitFlowMode.DisplayJudgeIcon;
            Mode = Mode | UnitFlowMode.DisplayTerminator;
            mItemDragEnabled = true;
            Proj.mChangeEvent += ChangeEvents;
            mNoteText.VisibleChanged += new EventHandler((s, e) =>
            {
                if (mNoteText.Visible == false)
                {
                    if (mIsNowSelectedItem != null && mIsNowSelectedItem.mModInfo.Remarks != mNoteText.Text.Trim())
                    {
                        mIsNowSelectedItem.mModInfo.Remarks = mNoteText.Text.Trim();
                        mProj.ChangeMod(mIsNowSelectedItem.mModInfo);
                    }
                }
            });
            mNoteText.LostFocus += new EventHandler((s, e) => { mNoteText.Visible = false; });
            mNoteText.KeyDown += new KeyEventHandler((s, e) => { if (e.KeyData == Keys.Enter) { mNoteText.Visible = false; } });
            
            //D2D
            factory = new D2D.Factory();
            var pixelFormat = new D2D.PixelFormat(DXGI.Format.B8G8R8A8_UNorm, D2D.AlphaMode.Ignore);
            var hwndRenderTargetProperties = new D2D.HwndRenderTargetProperties();
            hwndRenderTargetProperties.Hwnd = Handle;
            hwndRenderTargetProperties.PixelSize = new Size2((int)Width, (int)Height);
            var renderTargetProperties = new D2D.RenderTargetProperties(D2D.RenderTargetType.Default, pixelFormat, 96, 96, D2D.RenderTargetUsage.None, D2D.FeatureLevel.Level_DEFAULT);
            _renderTarget = new D2D.WindowRenderTarget(factory, renderTargetProperties, hwndRenderTargetProperties);
        }

        #endregion

        #region 方法-模块相关

        /// <summary>
        /// 获取结构树的展开状态
        /// </summary>
        private void GetTreeNodesStatus(TreeNodeCollection nodes)
        {
            try
            {
                mNodesStatusDic.Clear();
                foreach (TreeNode node in nodes)
                {
                    if (node.IsExpanded || mCurModName == node.Text)//当鼠标位置的模块是折叠的 由于新加,则展开
                    {
                        mNodesStatusDic.Add(node.FullPath, true);
                    }
                    GetTreeNodesStatus(node.Nodes);
                }
            }
            catch { }
        }

        /// <summary>
        /// 设置结构树状态
        /// </summary>
        private void SetTreeNodesStatus(TreeNodeCollection nodes)
        {
            if (自动折叠ToolStripMenuItem.Checked)
            {
                foreach (TreeNode node in nodes)
                {
                    node.Expand();
                    node.ExpandAll();
                    SetTreeNodesStatus(node.Nodes);
                }
            }
            else
            {
                foreach (TreeNode node in nodes)
                {
                    node.Collapse();
                    SetTreeNodesStatus(node.Nodes);
                }
            }
        }

        /// <summary>
        /// 检测当前模块存在子模块,子模块均选中
        /// </summary>
        /// <param name="u"></param>
        private void CheckedItem(ModFlowItem u)
        {
            if (u != null)
            {
                u.Checked = true;
                if (u.Nodes.Count > 0)
                {
                    foreach (ModFlowItem item in u.Nodes)
                    {
                        CheckedItem(item);
                    }
                }
            }
        }

        /// <summary>
        /// 取消当前单元及所有子单元的选中状态
        /// </summary>
        /// <param name="u"></param>
        private void UnCheckedItem(ModFlowItem u)
        {
            if (u != null)
            {
                for (TreeNode node = u.Parent; node != null; node = node.Parent)
                {
                    ((ModFlowItem)node).Checked = false;
                }
                u.Checked = false;
                if (u.Nodes.Count > 0)
                {
                    foreach (ModFlowItem item in u.Nodes)
                    {
                        UnCheckedItem(item);
                    }
                }
            }
        }

        public void EnsureVisible(int UnitNo)
        {
            ModFlowItem mModItem = GetUnitFlowItem(UnitNo);
            ModFlowItem mModItems = mModItem;
            if (mModItem != null)
            {
                int num = VscrollBar.Value;
                bool flag = RefreshEnabled;
                RefreshEnabled = false;
                while ((mModItems = mModItems.Parent) != null)
                {
                    if (!mModItems.IsExpanded)
                    {
                        mModItems.Expand();
                        EnsureVisible(UnitNo);
                        RefreshEnabled = flag;
                        return;
                    }
                }

                if (mModItem.Top < 0)
                {
                    num += mModItem.Top;
                }
                else if ((mModItem.Top + mItemHeight) > VscrollBar.Height)
                {
                    num += (mModItem.Top + (mItemHeight * 2)) - VscrollBar.Height;
                }
                num = Math.Min(VscrollBar.Maximum, Math.Max(0, num));
                num -= num % ItemHeight;
                VscrollBar.Value = num;
                RefreshEnabled = flag;
            }
        }

        /// <summary>
        /// 获取最后一个节点
        /// </summary>
        /// <param name="Nodes"></param>
        /// <returns></returns>
        private ModFlowItem GetLastNode(TreeNodeCollection Nodes)
        {
            ModFlowItem item = null;
            if (Nodes.Count > 0)
            {
                item = (ModFlowItem)Nodes[Nodes.Count - 1];
                if (item.Nodes.Count > 0)
                {
                    item = GetLastNode(Nodes[Nodes.Count - 1].Nodes);
                }
            }
            return item;
        }

        private ModFlowItem GetUnitFlowItem(int unitNo)
        {
            return GetUnitFlowItem(Nodes, unitNo);
        }

        private ModFlowItem GetUnitFlowItem(TreeNodeCollection Nodes, int unitno)
        {
            if (Nodes != null)
            {
                foreach (ModFlowItem item in Nodes)
                {
                    ModFlowItem item2;
                    if (item.ModNo == unitno)
                    {
                        return item;
                    }
                    if ((item.Nodes.Count > 0) && ((item2 = GetUnitFlowItem(item.Nodes, unitno)) != null))
                    {
                        return item2;
                    }
                }
            }
            return null;
        }

        private ModFlowItem GetSelectedItems(TreeNodeCollection Nodes, ref List<ModFlowItem> ar)
        {
            ModFlowItem selectedItems = null;
            foreach (ModFlowItem item2 in Nodes)
            {
                if (item2.Checked)
                {
                    ar.Add(item2);
                }
                else if (item2.Nodes.Count > 0)
                {
                    selectedItems = GetSelectedItems(item2.Nodes, ref ar);
                }
                if (selectedItems != null)
                {
                    return selectedItems;
                }
            }
            return selectedItems;
        }

        /// <summary>
        /// 选择模块
        /// </summary>
        /// <param name="Nodes"></param>
        /// <param name="selectno"></param>
        /// <returns></returns>
        private bool ItemSelect(TreeNodeCollection Nodes, int selectno)
        {
            foreach (ModFlowItem item in Nodes)
            {
                if (item.ModNo == selectno)
                {
                    item.IsSelected = true;
                    mBeforeSelectItem = item;
                    return true;
                }
                if ((item.Nodes.Count > 0) && ItemSelect(item.Nodes, selectno))
                {
                    return true;
                }
            }
            return false;
        }

        /// <summary>
        /// 显示注释行
        /// </summary>
        public void ShowTextBox(ModFlowItem item)
        {
            Rectangle rect = new Rectangle(item.RemarksPoint.X + 3, item.RemarksPoint.Y + 2, item.Width - 110 - (VscrollBar.Visible == true ? VscrollBar.Width : 0), 13);
            mNoteText.Height = 10;
            mNoteText.Parent = this;
            mNoteText.Bounds = rect;
            mNoteText.Multiline = false;
            mNoteText.Visible = true;
            if (item.mModInfo.Remarks != "")
            {
                mNoteText.Text = item.mModInfo.Remarks;
            }
            else
            {
                mNoteText.Text = "注释";
            }

            mNoteText.Focus();
            mNoteText.SelectAll();
        }

        /// <summary>
        /// 拖拽模块
        /// </summary>
        /// <param name="item"></param>
        private void ItemSelectDrag(ModFlowItem item)
        {
            if (mItemDragEnabled)
            {
                ModFlowItem.dragList = true;
                ModFlowItem.mDragFromUnitNo = item.ModNo;
                Cursor = Cursors.Hand;
            }
            UnSelectAllNode(Nodes);
            item.IsSelected = true;
            if (PluginToolService.mPluginDic.ContainsKey(mUiFrom.mModInfo.Name))
            {
                gCursor1.gText = mUiFrom.mModInfo.Name;
                gCursor1.gEffect = gCursor.eEffect.Move;
                if (PluginToolService.mPluginDic[mUiFrom.mModInfo.Name].IconImage != null)
                { gCursor1.gImage = PluginToolService.mPluginDic[mUiFrom.mModInfo.Name].IconImage.ToBitmap(); }
                gCursor1.gType = gCursor.eType.Both;
                gCursor1.MakeCursor();
            }
        }

        private void UnCheckedAllNode(TreeNodeCollection Nodes)
        {
            foreach (ModFlowItem item in Nodes)
            {
                item.Checked = false;
                if (item.Nodes.Count > 0)
                {
                    UnCheckedAllNode(item.Nodes);
                }
            }
        }

        private void UnSelectAllNode(TreeNodeCollection Nodes)
        {
            foreach (ModFlowItem item in Nodes)
            {
                item.IsSelected = false;
                if (item.Nodes.Count > 0)
                {//取消全选
                    UnSelectAllNode(item.Nodes);
                }
            }
            mBeforeSelectItem = null;
        }

        /// <summary>
        /// 拖拽停止
        /// </summary>
        private void DragInNewStop()
        {
            if (ModFlowItem.dragInNew)
            {
                ModFlowItem.dragInNew = false;
                mBeforeSelectItem = null;
            }
        }

        /// <summary>
        /// 更新模块列表显示
        /// </summary>
        public void ShowRef()
        {
            ChangeEvents(null, null);
        }

        /// <summary>
        /// 修改模块名称
        /// </summary>
        /// <param name="modName"></param>
        public void ModifyModName(string modName)
        {
            List<string> nameList = mProj.mObjBase.Select(c => c.ModInfo.Name).ToList();
            int idx = nameList.FindIndex(c => c == modName);
            if (idx > -1)
            {
                MessageBox.Show("模块名称不可重复!");
                return;
            }

            mUiFrom.mModInfo.Name = modName;
        }

        /// <summary>
        /// 修改模块注释
        /// </summary>
        /// <param name="modNote"></param>
        public void ModifyModNote(string modNote)
        {
            mUiFrom.mModInfo.Remarks = modNote;
        }

        #endregion

        #region 事件-模块控件

        /// <summary>
        /// 模块修改事件
        /// </summary>
        private void ChangeEvents(object sender, EventArgs e)
        {
            sfcIndex = -1;
            Mutexs.WaitOne();
            mNodesStatusDic.Clear();
            GetTreeNodesStatus(Nodes);
            Nodes.Clear();
            List<ModInfo> mModInfoDic = mProj.mModInfo;
            Stack<ModFlowItem> s_ParentItemStack = new Stack<ModFlowItem>();//将父节点放入栈容器 
            foreach (ModInfo info in mModInfoDic)
            {
                sfcIndex++;
                ModFlowItem NodeItem = new ModFlowItem(info, sfcIndex);
                if (/*info.Name == "条件分支" && */info.Name.StartsWith("结束")) // 是结束则 取消栈里对应的if
                {
                    s_ParentItemStack.Pop();
                }
                else if (/*info.Name == "条件分支" && */info.Name.StartsWith("否则"))
                {
                    s_ParentItemStack.Pop();
                }
                else if (/*info.Name == "条件分支" && */info.Name.StartsWith("循环结束"))
                {
                    s_ParentItemStack.Pop();
                }
                if (s_ParentItemStack.Count > 0)
                {
                    ModFlowItem parentItem = s_ParentItemStack.Peek();
                    parentItem.Nodes.Add(NodeItem);
                }
                else
                {
                    Nodes.Add(NodeItem);//根目录
                }
                //判断当前节点是否是父节点开始
                if (/*info.Plugin == "条件分支" && */info.Name.StartsWith("如果"))//还需要判断那其他父节点开始
                {
                    s_ParentItemStack.Push(NodeItem);
                }
                else if (/*info.Plugin == "条件分支" && */info.Name.StartsWith("否则"))
                {
                    s_ParentItemStack.Push(NodeItem);
                }
                else if (info.Plugin == "文件夹" && Regex.IsMatch(info.Name, "文件夹[0-9]*$"))//文件夹 开始
                {
                    s_ParentItemStack.Push(NodeItem);
                }
                else if (info.Plugin == "文件夹结束" && Regex.IsMatch(info.Name, "文件夹结束[0-9]*$"))   //文件夹结束也放入到文件夹中
                {
                    s_ParentItemStack.Pop();
                }
                else if (info.Plugin == "循环开始" && Regex.IsMatch(info.Name, "循环开始[0-9]*$"))//文件夹 开始
                {
                    s_ParentItemStack.Push(NodeItem);
                }
                else if (info.Plugin == "循环结束" && Regex.IsMatch(info.Name, "循环结束[0-9]*$"))   //文件夹结束也放入到文件夹中
                {
                    //s_ParentItemStack.Pop();
                }
            }
            SetTreeNodesStatus(Nodes);
            Mutexs.ReleaseMutex();
            Invoke(new beginInvokeDelegate(Refresh));
        }

        /// <summary>TODO:
        /// 获取当前鼠标位置的模块 
        /// </summary>
        /// <param name="Nodes"></param>
        private ModFlowItem GetNodeFromPosition(TreeNodeCollection Nodes, MouseEventArgs e)
        {
            ModFlowItem nodeFromPosition = GetNodeFromPositionIteration(Nodes, e);
            if (nodeFromPosition == null)
            {
                nodeFromPosition = GetLastNode(Nodes);
            }
            return nodeFromPosition;
        }

        private ModFlowItem GetNodeFromPositionIteration(TreeNodeCollection Nodes, MouseEventArgs e)
        {
            ModFlowItem nodeFromPosition = null;
            foreach (ModFlowItem item2 in Nodes)
            {
                int num = item2.Top + VscrollBar.Top;
                if (((num < e.Y) && ((num + mItemHeight) > e.Y)) && ((item2.Left < e.X) && (e.X < base.Width)))
                {
                    return item2;
                }
                if ((item2.UnitType == UnitType.Folder) && item2.IsExpanded)
                {
                    nodeFromPosition = GetNodeFromPositionIteration(item2.Nodes, e);
                }
                if (nodeFromPosition != null)
                {
                    return nodeFromPosition;
                }
            }
            return nodeFromPosition;
        }

        private void VscrollBar_ValueChanged(object sender, EventArgs e)
        {
            base.SuspendLayout();
            int num = VscrollBar.Value;
            num -= num % ItemHeight;
            VscrollBar.Value = num;
            base.ResumeLayout(false);
            base.Refresh();
        }

        /// <summary>
        /// 鼠标滚动事件
        /// </summary>
        /// <param name="e"></param>
        protected override void OnMouseWheel(MouseEventArgs e)
        {
            mNoteText.Visible = false;
            if (((base.Visible) && (VscrollBar.Visible)))
            {
                if (e.Delta > 0)
                {
                    if (VscrollBar.Value - mItemHeight >= VscrollBar.Minimum)
                    {
                        VscrollBar.Value -= mItemHeight;
                    }
                }
                if (e.Delta < 0)
                {
                    if (VscrollBar.Value + Height < VscrollBar.Maximum)
                    {
                        VscrollBar.Value += mItemHeight;
                    }
                }
            }
            base.OnMouseWheel(e);
        }

        /// <summary>
        /// 鼠标按下事件
        /// </summary>
        /// <param name="e"></param>
        protected override void OnMouseDown(MouseEventArgs e)
        {
            if (UseAble == false) return;
            timer_refresh.Enabled = true;
            mNoteText.Visible = false;
            mMouseDownPos = new Point(e.X, e.Y);
            mouseEventArgs = e;
            mUiFrom = mIsNowSelectedItem = GetNodeFromPosition(mTreeView.Nodes, e);
            if (mIsNowSelectedItem != null)
            {
                ModFlowItem.mDragToUnitNo = -1;
                switch (mIsNowSelectedItem.HitCheck(e))
                {
                    case CheckArea.Space:
                        ItemSelectDrag(mIsNowSelectedItem);
                        break;
                    case CheckArea.Icon:
                        if ((mMode & UnitFlowMode.IconButtonDisable) == 0)
                        {
                            mIsNowSelectedItem.Click = true;
                        }
                        UnSelectAllNode(Nodes);
                        break;
                    case CheckArea.Remarks:
                        ItemSelectDrag(mIsNowSelectedItem);
                        break;
                    case CheckArea.MultiSelect:
                        if (!mIsMultiSelect)
                        {
                            if (mItemDragEnabled)
                            {
                                ModFlowItem.dragList = true;
                            }
                            break;
                        }
                        if (!mIsNowSelectedItem.Checked)
                        {
                            CheckedItem(mIsNowSelectedItem);
                            break;
                        }
                        UnCheckedItem(mIsNowSelectedItem);
                        UnSelectAllNode(Nodes);
                        mIsNowSelectedItem.IsSelected = true;
                        break;
                    default:
                        break;
                }
                mIsChangeSelectItem = false;
                if (mIsNowSelectedItem.IsSelected)
                {
                    //判断现在的选择单元是否修改
                    if (mIsNowSelectedItem != mBeforeSelectItem)
                    {
                        mIsChangeSelectItem = true;
                    }
                    mBeforeSelectItem = mIsNowSelectedItem;
                }
                Refresh();
                move = 0;
                mMoseArgs = e;
            }
            base.OnMouseDown(e);
        }

        /// <summary>
        /// 鼠标移动事件
        /// </summary>
        /// <param name="e"></param>
        protected override void OnMouseMove(MouseEventArgs e)
        {
            if (UseAble == false) return;
            //Debug.WriteLine("鼠标位置触发" +e.X);图像采集
            Point curDownPos = new Point(e.X, e.Y);//当前位置
            if (ModFlowItem.dragList && Math.Abs(mMouseDownPos.Y - curDownPos.Y) > 15)
            {
                Cursor.Current = gCursor1.gCursor;
            }
            if (ModFlowItem.dragList || ModFlowItem.dragInNew)
            {
                ModFlowItem mModFlowItem = null;
                if (e != null)
                {
                    mModFlowItem = GetNodeFromPosition(mTreeView.Nodes, e);
                }
                bool drag = ModFlowItem.dragList;
                if (mModFlowItem != null)
                {
                    //Log.Debug("获取到鼠标目标位置模块 编号"+ mModFlowItem.Text);
                    ModFlowItem.mDragToUnitNo = mModFlowItem.ModNo;
                    if (((mUiFrom != null) && (mUiFrom.UnitType == UnitType.Folder)) && ((mModFlowItem.ModNo >= mUiFrom.ModNo) && (mModFlowItem.ModNo <= mUiFrom.last_unitno)))
                    {
                        ModFlowItem.dragList = false;
                    }
                }
                else
                {
                    ModFlowItem.dragList = false;
                }
                mMoseArgs = e;
                if (e.Y < (VscrollBar.Top + mItemHeight))
                {
                    move = -mItemHeight;
                }
                else if (e.Y > (base.Height - mItemHeight))
                {
                    move = mItemHeight;
                }
                else
                {
                    move = 0;
                }
                Refresh();
                ModFlowItem.dragList = drag;
                if (mModFlowItem != null)
                {
                    if (mMouseOverItem != mModFlowItem)
                    {
                        tick_count = 0;
                    }
                    if (tick_count > 3)
                    {
                        mModFlowItem.Expand();
                        Refresh();
                        mMouseOverItem = null;
                        return;
                    }
                    mMouseOverItem = mModFlowItem;
                }
            }
            base.OnMouseMove(e);
        }

        /// <summary>
        /// 双击模块事件
        /// </summary>
        protected override void OnMouseDoubleClick(MouseEventArgs e)
        {
            try
            {
                注释编辑ToolStripMenuItem.Checked = false;
                if (UseAble == false) return;
                ModFlowItem MousePos = GetNodeFromPosition(mTreeView.Nodes, e);  //获取当前鼠标位置的模块
                if (MousePos != null)
                {
                    string NextStr = MousePos.NextNode != null ? MousePos.NextNode.Text : "123";
                    bool showObj = 注释编辑ToolStripMenuItem.Checked & MousePos.HitCheck(e) == CheckArea.Space;
                    if (!showObj)
                    {
                        ItemButtonDoubleClick?.Invoke(MousePos);
                        if (MousePos.mModInfo.Name.StartsWith("结束") & Regex.IsMatch(MousePos.mModInfo.Name, "结束[0-9]*$"))
                        {
                            PluginsInfo mPluginsInfoB = PluginToolService.mPluginDic["否则"];
                            ObjBase mObjBaseB = (ObjBase)mPluginsInfoB.ModObjType.Assembly.CreateInstance(mPluginsInfoB.ModObjType.FullName);
                            mObjBaseB.ModInfo.Plugin = mPluginsInfoB.Name;
                            mProj.AddModObj(MousePos.mModInfo.Name, mObjBaseB.ModInfo, false);
                        }
                        else
                        {
                            if (!MousePos.mModInfo.Name.StartsWith("文件夹") & !MousePos.mModInfo.Name.StartsWith("循环结束"))
                            {
                                //根据名称获取对应的ObjBase
                                ObjBase mObjBase = mProj.GetObjBase(MousePos.mModInfo.Name);
                                mObjBase.Icon = PluginToolService.mPluginDic[MousePos.mModInfo.Plugin].IconImage.ToBitmap();
                                mObjBase.RunForm(mObjBase);
                            }
                        }
                    }
                }
                base.OnMouseDoubleClick(e);
            }
            catch (Exception ex)
            {
                Log.Fatal(ex.Message);
            }
        }

        /// <summary>
        /// 创建模块
        /// </summary>
        /// <param name="e"></param>
        /// OnMouseUp图像采集
        protected override void OnMouseUp(MouseEventArgs e)
        {
            if (UseAble == false) return;
            timer_refresh.Enabled = false;
            //获取当前鼠标位置的模块(为放置位置的前一个模块)
            ModFlowItem MousePos = GetNodeFromPosition(mTreeView.Nodes, e);
            if ((ModFlowItem.dragList || ModFlowItem.dragInNew) && mUiFrom != null) //拖拽过程中
            {
                //完全新建的情况(列表中不存在任何模块)
                if (MousePos == null)
                {
                    mProj.AddModObj(null, mUiFrom.mModInfo, true);
                }
                //移动模块和新建模块(列表中存在其他模块)情况
                else
                {
                    if (MousePos.ModNo != mUiFrom.ModNo)
                    {
                        mCurModName = MousePos.mModInfo.Name;
                        bool isNext = true;
                        //移动模块
                        if (mUiFrom.ModNo != -1)//-1表示新建
                        {
                            mProj.ChangePos(mUiFrom.mModInfo.Name, mCurModName, isNext, null, null);
                        }
                        //新建模块
                        else
                        {
                            mProj.AddModObj(mCurModName, mUiFrom.mModInfo, isNext);
                        }
                    }
                }
            }
            ModFlowItem.dragList = false;
            ModFlowItem.dragInNew = false;
            if (MousePos != null)
            {
                if (mIsChangeSelectItem)
                {
                    SelectedItemChange?.Invoke(mBeforeSelectItem);
                    EnsureVisible(SelectItem.ModNo);
                }
                if (MousePos.HitCheck(e) == CheckArea.Icon)
                {
                    if (MousePos.UnitType == UnitType.Folder)
                    {
                        MousePos.Toggle();
                    }
                    else if (((mUiFrom != null) && (mUiFrom.ModNo == MousePos.ModNo)) && (mUiFrom.Click && ((ItemButtonClick != null) & (MousePos.ToString() != (MousePos.ModNo.ToString() + ".")))))
                    {
                        mUiFrom.Click = false;
                        Refresh();
                        ItemButtonClick(MousePos);
                    }
                }
            }
            mIsChangeSelectItem = false;
            if (mUiFrom != null)
            {
                mUiFrom.Click = false;
            }
            mUiFrom = null;
            Cursor = Cursors.Default;
            Refresh();
            base.OnMouseUp(e);
        }

        /// <summary>
        /// 运行刷新
        /// </summary>
        /// <param name="e"></param>
        protected override void OnPaint(PaintEventArgs e)
        {
            List<Proj> sProjList = Sol.mSol.mProjList;
            try
            {
                if (mBuff != null)
                {
                    int num;
                    int num4 = 0;
                    int top = num = -VscrollBar.Value;
                    int left = 0;
                    ModFlowItem.mCheckLable = mIsMultiSelect;
                    ModFlowItem.FlowHeight = Height;
                    ModFlowItem.ControlWidth = base.Width - (VscrollBar.Visible ? VscrollBar.Width : 0);
                    using (Graphics graphics = Graphics.FromImage(mBuff))
                    {
                        graphics.FillRectangle(new SolidBrush(Color.White), new Rectangle(0, 0, base.Width, VscrollBar.Height));
                        Sol.mDrawModFlag = true;
                        Mutexs.WaitOne();
                        string mSpaceKey = "";
                        if (Width > 160)
                        {
                            for (int i = 0; i < Width - 190; i = i + 7)
                            {
                                mSpaceKey = mSpaceKey + " ";
                            }
                        }

                        if (Nodes.Count !=0)
                        {
                            Pen pen = new Pen(Color.Navy, 1.5f);
                            graphics.DrawLine(pen, left + num + 9, top, 118, top);//上边缘
                        }

                        foreach (ModFlowItem item in Nodes)
                        {
                            if (item != null) 
                            {
                                item.PaintItem(item,graphics, ref left, ref top, Width, mItemHeight, 0, mSpaceKey, ref num4, false);
                            }
                        }
                        Mutexs.ReleaseMutex();
                        Sol.mDrawModSign.Set();
                        Sol.mDrawModFlag = false;
                        if (RefreshEnabled)
                        {
                            using (Pen pen2 = new Pen(Color.Navy, 1.5f))
                            {
                                e.Graphics.DrawImage(mBuff, 0, VscrollBar.Top);
                            }
                        }
                    }
                    if ((top + VscrollBar.Value) < VscrollBar.Height)
                    {
                        VscrollBar.Value = 0;
                        VscrollBar.Visible = false;
                    }
                    else
                    {
                        VscrollBar.Visible = true;
                    }
                    VscrollBar.Maximum = Math.Max((top - num) + mItemHeight, 0);
                    VscrollBar.LargeChange = VscrollBar.Height;
                    VscrollBar.SmallChange = mItemHeight;
                    base.OnPaint(e);
                }
            }
            catch (OutOfMemoryException exception)
            {
                SharedClass.ExceptionOutOfMemory(exception);
            }
        }

        protected override void OnResize(EventArgs e)
        {
            base.OnResize(e);
            if (mBuff != null)
            {
                mBuff.Dispose();
            }
            mBuff = new Bitmap(Math.Max(base.Width, 1), Math.Max(base.Height, 1));
            RefreshEnabled = true;
            Refresh();
        }

        /// <summary>
        /// 拖拽进入
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ModelFlow_DragEnter(object sender, DragEventArgs e)
        {
            Debug.WriteLine("ModelFlow_DragEnter 拖拽进入");
            if (e.Data.GetDataPresent(DataFormats.Text))
            {
                string ModPluginName = (string)e.Data.GetData(typeof(string));
                string name = "NoName";
                e.Effect = DragDropEffects.All;
                ModInfo infoTmp = new ModInfo()
                {
                    Name = name,
                    Plugin = ModPluginName,
                    Enable = true
                };
                ModFlowItem item3 = new ModFlowItem(infoTmp, -1);
                ModFlowItem.dragInNew = true;
                ModFlowItem.mDragFromUnitNo = -1;
                mUiFrom = item3;
                mBeforeSelectItem = item3;
            }
            else
            {
                e.Effect = DragDropEffects.None;
            }
        }

        /// <summary>
        /// 拖拽离开
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ModelFlow_DragLeave(object sender, EventArgs e)
        {
            Debug.WriteLine("ModelFlow_DragLeave 拖拽离开");
            DragInNewStop();
        }

        /// <summary>
        /// 拖拽松开-丢下则创建
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ModFlow_DragDrop(object sender, DragEventArgs e)
        {
            if (UseAble == false) return;
            timer_refresh.Enabled = false;
            Point p = new Point(e.X, e.Y);
            mMouseUpPos = PointToClient(p);
            mMoseArgs = new MouseEventArgs(MouseButtons, 0, mMouseUpPos.X, mMouseUpPos.Y, 0);
            OnMouseUp(mMoseArgs);
        }

        /// <summary>
        /// 拖拽滑动-拖动的时候鼠标滑动
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ModFlow_DragOver(object sender, DragEventArgs e)
        {
            timer_refresh.Enabled = true;
            Point p = new Point(e.X, e.Y);
            Point curr = PointToClient(p);
            mMoseArgs = new MouseEventArgs(MouseButtons, 0, curr.X, curr.Y, 0);
            OnMouseMove(mMoseArgs);
        }

        private void 右键_Opening(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (UseAble == false)
            {
                e.Cancel = true;
                return;
            }
            if (SelectItem == null) { return; }
            禁用ToolStripMenuItem.Checked = false;
            禁用ToolStripMenuItem.Enabled = true;
            删除选中ToolStripMenuItem.Enabled = true;
            if (SelectItem.mModInfo.Name.Contains("结束"))
            {
                禁用ToolStripMenuItem.Enabled = false;
                删除选中ToolStripMenuItem.Enabled = false;
            }
            if (SelectItem.mModInfo.Name.Contains("否则"))
            {
                禁用ToolStripMenuItem.Enabled = false;
            }
            if (!SelectItem.mModInfo.Enable)
            {
                禁用ToolStripMenuItem.Checked = true;
            }
        }

        private void 禁用ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SelectItem.mModInfo.Enable = SelectItem.mModInfo.Enable ? false : true;
            mProj.ChangeMod(SelectItem.mModInfo);
        }

        private void 自动折叠ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            自动折叠ToolStripMenuItem.Checked = 自动折叠ToolStripMenuItem.Checked == true ? false : true;
            SetTreeNodesStatus(Nodes);
            ChangeEvents(null, null);
        }

        private void 注释编辑ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            mUiFrom = mIsNowSelectedItem = GetNodeFromPosition(mTreeView.Nodes, mouseEventArgs);
            frmModify = new FrmModify("注释编辑", ModifyModNote, "注释");
            frmModify.ShowDialog();
        }

        private void 删除选中ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (SelectItem == null) { return; }
            DialogResult dr = MessageBox.Show($"确定要删除模块 [{SelectItem.mModInfo.Name}] 吗？", "提示", MessageBoxButtons.OKCancel, MessageBoxIcon.Stop);
            if (dr == DialogResult.OK)
            {
                if (mBeforeSelectItem != null)
                {
                    mProj.RemovMod(mBeforeSelectItem.mModInfo.Name);
                }
            }
        }

        private void 修改名称ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            mUiFrom = mIsNowSelectedItem = GetNodeFromPosition(mTreeView.Nodes, mouseEventArgs);
            frmModify = new FrmModify("名称编辑", ModifyModName, "名称");
            frmModify.ShowDialog();
        }

        private void ModFlow_Mouse_Click(object sender, MouseEventArgs e)
        {
            if (UseAble == false) return;
            mMouseDownPos = new Point(e.X, e.Y);
            if (mIsNowSelectedItem != null)
            {
                ModFlowItem.mDragToUnitNo = -1;
                if (mIsNowSelectedItem.HitCheck(e) == CheckArea.Remarks)
                {
                    //选中注释
                    if (mIsNowSelectedItem.IsSelected == true && mNoteText.Visible == false & 注释编辑ToolStripMenuItem.Checked)//选中之后再点击 就弹出texbox
                    {
                        ShowTextBox(mIsNowSelectedItem);
                    }
                }
            }
        }

        private void timer_VscrollBar_Tick(object sender, EventArgs e)
        {
            if (move != 0)
            {
                VscrollBar.Value = Math.Max(0, Math.Min((int)(VscrollBar.Maximum - (base.Height / 2)), (int)(VscrollBar.Value + move)));
            }
        }

        private void ModFlow_Scroll(object sender, ScrollEventArgs e)
        {
            base.OnPaint(null);
        }

        #endregion
    }
}
