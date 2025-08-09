using Rex.UI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using VisionCore;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Plugin.WinDisplay
{
    public partial class WinDisplayForm: FormBase
    {
        #region 字段、属性

        /// <summary>
        /// 模块对象
        /// </summary>
        WinDisplayObj mObj ;

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

        /// <summary>
        /// 初始化
        /// </summary>
        /// <param name="Obj"></param>
        public WinDisplayForm(WinDisplayObj Obj) : base(Obj)
        {
            InitializeComponent();
            mObj = Obj;
        }

        #endregion

        #region 方法-对象保存加载相关

        /// <summary>
        /// 将窗体的值保存到模块对象中
        /// </summary>
        public override void  FormToObj()
        {
            mObj.fontType = cbxFontStye.Text;
            mObj.fontSize = tbFontSize.Value;
            mObj.fontColor= ColorTranslator.ToHtml(cpFontColor.Value);
            mObj.winColor = ColorTranslator.ToHtml(cpFormColor.Value);
            mObj.winMessage = tbxMessage.Text.Trim();
        }

        /// <summary>
        /// 将模块对象中的值加载到窗体中
        /// </summary>
        public override void ObjToForm()
        {
            cbxFontStye.Text = mObj.fontType;
            tbFontSize.Value = mObj.fontSize;
            cpFontColor.Value = ColorTranslator.FromHtml(mObj.fontColor);
            cpFormColor.Value = ColorTranslator.FromHtml(mObj.winColor);
            tbxMessage.Text = mObj.winMessage;
            tbxMessage.ForeColor = cpFontColor.Value;
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

            costTime = timerObj.GetMilliSecond;
            lblTime.Text = "耗时:" + costTime.ToString("F2") + "ms";
        }

        /// <summary>
        /// 保存
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public override void btn_Save_Click(object sender, EventArgs e)
        {
            FormToObj();
        }

        /// <summary>
        /// 取消
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public override void btn_Cancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        #endregion

        #region 事件-窗体控件

        private void WinDisplayForm_Load(object sender, EventArgs e)
        {
            FontFamily[] fontFamilies;
            cbxFontStye.Items.Clear();
            InstalledFontCollection installedFontCollection = new InstalledFontCollection();
            fontFamilies = installedFontCollection.Families;
            int count = fontFamilies.Length;
            for (int j = 0; j < count; ++j)
            {
                cbxFontStye.Items.Add(fontFamilies[j].Name);
            }
        }

        #endregion

        #region 事件-实时执行

        /// <summary>
        /// 改变字体颜色后执行事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="value"></param>
        private void cpFontColor_ValueChanged(object sender, Color value)
        {
            tbxMessage.ForeColor = cpFontColor.Value;
        }

        /// <summary>
        /// 改变字体样式后执行事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cbxFontStye_SelectedIndexChanged(object sender, EventArgs e)
        {
            tbxMessage.Font = new Font(cbxFontStye.Text, tbFontSize.Value, FontStyle.Regular);
        }

        /// <summary>
        /// 改变字体大小后执行事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tbFontSize_ValueChanged(object sender, EventArgs e)
        {
            tbxMessage.Font = new Font(cbxFontStye.Text, tbFontSize.Value, FontStyle.Regular);
        }

        #endregion
    }
}
