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

namespace Plugin.Judge
{
    public partial class JudgeForm: FormBase
    {
        #region 字段、属性

        /// <summary>
        /// 模块对象
        /// </summary>
        private JudgeObj mObj ;

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

        public JudgeForm(JudgeObj Obj) : base(Obj)
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
            switch (cbxCondition.SelectedIndex)
            {
                case 0:
                    mObj.funcType1 = (FuncType)(cbxRelation.SelectedIndex);
                    mObj.funcData1Med = ldComparison.TextInfo;
                    mObj.funcStd1Med = ldStd.TextInfo;
                    break;
                case 1:
                    mObj.funcType2 = (FuncType)(cbxRelation.SelectedIndex);
                    mObj.funcData2Med = ldComparison.TextInfo;
                    mObj.funcStd2Med = ldStd.TextInfo;
                    break;
                case 2:
                    mObj.funcType3 = (FuncType)(cbxRelation.SelectedIndex);
                    mObj.funcData3Med = ldComparison.TextInfo;
                    mObj.funcStd3Med = ldStd.TextInfo;
                    break;
                case 3:
                    mObj.funcType4 = (FuncType)(cbxRelation.SelectedIndex);
                    mObj.funcData4Med = ldComparison.TextInfo;
                    mObj.funcStd4Med = ldStd.TextInfo;
                    break;
            }
        }

        /// <summary>
        /// 将模块对象中的值加载到窗体中
        /// </summary>
        public override void ObjToForm()
        {
            switch (cbxCondition.SelectedIndex)
            {
                case 0:
                    cbxCondition.SelectedIndex = 0;
                    cbxRelation.SelectedIndex = (int)mObj.funcType1;
                    ldComparison.TextInfo = mObj.funcData1Med;
                    ldStd.TextInfo = mObj.funcStd1Med;
                    break;
                case 1:
                    cbxCondition.SelectedIndex = 1;
                    cbxRelation.SelectedIndex = (int)mObj.funcType2;
                    ldComparison.TextInfo = mObj.funcData2Med;
                    ldStd.TextInfo = mObj.funcStd2Med;
                    break;
                case 2:
                    cbxCondition.SelectedIndex = 2;
                    cbxRelation.SelectedIndex = (int)mObj.funcType3;
                    ldComparison.TextInfo = mObj.funcData3Med;
                    ldStd.TextInfo = mObj.funcStd3Med;
                    break;
                case 3:
                    cbxCondition.SelectedIndex = 3;
                    cbxRelation.SelectedIndex = (int)mObj.funcType4;
                    ldComparison.TextInfo = mObj.funcData4Med;
                    ldStd.TextInfo = mObj.funcStd4Med;
                    break;
                default:
                    cbxCondition.SelectedIndex = 0;
                    cbxRelation.SelectedIndex = (int)mObj.funcType1;
                    ldComparison.TextInfo = mObj.funcData1Med;
                    ldStd.TextInfo = mObj.funcStd1Med;
                    break;
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
            FormToObj();

            timerObj.Start(); // 启动计时器
            mObj.RunObj();
            timerObj.Stop();  // 停止计时器

            ObjToForm();

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
            this.Close();
        }

        #endregion

        #region 事件-MyLinkData控件

        /// <summary>
        /// LinkData控件数据链接
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ldData_LinkData(object sender, EventArgs e)
        {
            MyLinkData myLinkData = sender as MyLinkData;
            PluginDataLinkForm LikeDataForm = new PluginDataLinkForm(mObj.ProjName, mObj.ModInfo.Name);
            switch (myLinkData.Name)
            {
                case "ldComparison":
                    LikeDataForm.dataType = "Double" + "|" + "Double[]" + "String" + "|" + "String[]" + "Int" + "|" + "Int[]" + "Bool" + "|" + "Bool[]";
                    LikeDataForm.ShowDialog();
                    if (LikeDataForm.m_OutLinkData.Length > 3)
                    {
                        string[] m_IntStr = LikeDataForm.m_OutLinkData.Split('|');
                        ldComparison.TextInfo = m_IntStr[0] + ":" + m_IntStr[1];
                    }
                    break;
                case "ldStd":
                    LikeDataForm.dataType = "Double" + "|" + "Double[]" + "String" + "|" + "String[]" + "Int" + "|" + "Int[]" + "Bool" + "|" + "Bool[]";
                    LikeDataForm.ShowDialog();
                    if (LikeDataForm.m_OutLinkData.Length > 3)
                    {
                        string[] m_IntStr = LikeDataForm.m_OutLinkData.Split('|');
                        ldStd.TextInfo = m_IntStr[0] + ":" + m_IntStr[1];
                    }
                    break;
            }
        }

        #endregion

        #region 事件-ComboBox控件

        /// <summary>
        /// 条件选择改变事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cbxCondition_SelectedIndexChanged(object sender, EventArgs e)
        {
            ObjToForm();
        }

        #endregion
    }
}
