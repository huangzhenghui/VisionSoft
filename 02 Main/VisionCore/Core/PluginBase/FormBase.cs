using DockContrl;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace VisionCore
{
    /// <summary>
    /// UI基类
    /// </summary>
    public partial class FormBase : DockForm
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
        /// 界面-对应模块 
        /// </summary>
        public ObjBase ObjBase { get; set; }

        /// <summary>
        /// 备份-取消还原
        /// </summary>
        private ObjBase ObjBaseBack;

        #endregion

        #region 初始化

        public FormBase() : base()
        {
            InitializeComponent();
        }

        public FormBase(ObjBase mObj) 
        {
            ObjBase = mObj;
            InitializeComponent();
        }

        #endregion

        #region 事件-实现窗体移动功能

        /// <summary>
        /// 获取鼠标按下时坐标
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FormBase_MouseDown(object sender, MouseEventArgs e)
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
        private void FormBase_MouseMove(object sender, MouseEventArgs e)
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
        private void FormBase_MouseUp(object sender, MouseEventArgs e)
        {
            if (leftFlag)
            {
                leftFlag = false;
            }
        }

        #endregion

        #region 事件-窗体控件

        /// <summary>
        /// 窗体加载
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FormBase_Load(object sender, EventArgs e)
        {
            if (ObjBase == null) return;
            Tools.SetWindowRegion(this, 8 * 1);
            Tools.SetWindowRegion(pbox_Icon, 8 * 2);
            pbox_Icon.Image = ObjBase.Icon;
            Text = ObjBase.ModInfo.Name;
            Title = ObjBase.ModInfo.Name;
            lblModName.Text= ObjBase.ModInfo.Name;
            ObjBaseBack = CloneObject.DeepCopy(ObjBase);
            ObjToForm();
            FormToObj();
        }

        /// <summary>
        /// 模块数据加载至界面
        /// </summary>
        public virtual void ObjToForm(){}

        /// <summary>
        /// 界面数据加载至模块
        /// </summary>
        public virtual void FormToObj(){}

        #endregion

        #region 事件-按钮控件

        /// <summary>
        /// 执行
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public virtual void btn_Run_Click(object sender, EventArgs e) { }

        /// <summary>
        /// 保存
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public virtual void btn_Save_Click(object sender, EventArgs e) {}

        /// <summary>
        /// 取消
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public virtual void btn_Cancel_Click(object sender, EventArgs e)
        {
            ObjBase = ObjBaseBack;
            Close();
        }

        #endregion
    }
}
