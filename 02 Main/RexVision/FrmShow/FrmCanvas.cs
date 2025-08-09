using RexConst;
using RexForm;
using System.Windows.Forms;
using WeifenLuo.WinFormsUI.Docking;

namespace TSIVision
{
    /// <summary>
    /// 图像显示窗口
    /// </summary>
    public partial class FrmCanvas : DockContent
    {
        #region 初始化

        /// <summary>
        /// 初始化
        /// </summary>
        public FrmCanvas()
        {
            InitializeComponent();
            AutoScaleMode = AutoScaleMode.Font;
            canvasView1.ViewMode = ViewMode.One;
        }

        #endregion

        #region 方法-图像显示相关

        /// <summary>
        /// 设置图像窗口数量
        /// </summary>
        /// <param name="num"></param>
        public void SetViewMode(int num)
        {
            if (num > 9) { return; }
            this.canvasView1.ViewMode = (RexForm.ViewMode) num;
        }

        /// <summary>
        /// 显示图像
        /// </summary>
        /// <param name="Image"></param>
        public void ScreenShow(RImage Image)
        {
            canvasView1.Show(Image);
        }

        /// <summary>
        /// 清空窗口
        /// </summary>
        public void ScreenClear()
        {
            canvasView1.Clear();
        }

        #endregion
    }
}
