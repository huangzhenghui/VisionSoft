using Rex.UI;
using RexControl.MyControls;
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

namespace Plugin.For
{
    public partial class ForForm: FormBase
    {
        #region 字段、属性

        /// <summary>
        /// 模块对象
        /// </summary>
        private ForObj mObj ;

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
        public ForForm(ForObj Obj) : base(Obj)
        {
            mObj = Obj;
            InitializeComponent();
        }

        #endregion

        #region 方法-对象保存加载相关

        /// <summary>
        /// 将窗体的值保存到模块对象中
        /// </summary>
        public override void  FormToObj()
        {
            mObj.forMode = (ForMode)cbxForMode.SelectedIndex;
            mObj.strForNum = ldForNum.TextInfo.Trim();
        }

        /// <summary>
        /// 将模块对象中的值加载到窗体中
        /// </summary>
        public override void ObjToForm()
        {
            cbxForMode.SelectedIndex = (int)mObj.forMode;
            ldForNum.TextInfo = mObj.strForNum;
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
            Close();
        }

        /// <summary>
        /// 关闭
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public override void btn_Cancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        #endregion

        #region 事件-ComboBox控件

        /// <summary>
        /// 循环模式更改
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cbxForMode_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (cbxForMode.SelectedText)
            {
                case "有限循环":
                    ldForNum.Enabled = true;
                    break;
                case "无限循环":
                    ldForNum.Enabled = false;
                    break;
            }
        }

        #endregion

        #region 事件-MyLinkData控件

        /// <summary>
        /// 设置循环条件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void uiLinkText1_BtnAdd(object sender, EventArgs e)
        {
            PluginDataLinkForm LikeDataForm = new PluginDataLinkForm(mObj.ProjName, mObj.ModInfo.Name);
            LikeDataForm.ShowDialog();
            if (LikeDataForm.m_OutLinkData.Length > 3)
            {
                string[] m_IntStr = LikeDataForm.m_OutLinkData.Split('|');

                MyLinkData myLinkData = (MyLinkData)sender;
                if (myLinkData != null)
                {
                    switch (myLinkData.Name)
                    {
                        case "ldForNum":
                            ldForNum.TextInfo = m_IntStr[0] + ":" + m_IntStr[1];
                            break;
                    }
                    return;
                }
            }
        }

        #endregion
    }
}
