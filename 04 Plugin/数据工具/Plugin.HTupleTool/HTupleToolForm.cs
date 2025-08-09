using HalconDotNet;
using Plugin.CreateROI;
using Rex.UI;
using RexConst;
using RexControl.MyControls;
using RexView;
using RexView.Model;
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
using static System.Net.Mime.MediaTypeNames;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace Plugin.HTupleTool
{
    public partial class HTupleToolForm : FormBase
    {
        #region 字段、属性

        /// <summary>
        /// 模块对象
        /// </summary>
        HTupleToolObj mObj;

        /// <summary>
        /// 计时器
        /// </summary>
        public HTimer timerObj = new HTimer();

        /// <summary>
        /// 耗时
        /// </summary>
        public double costTime = 0;

        /// <summary>
        /// 运算结果显示窗体对象
        /// </summary>
        ResultForm operateResultForm;

        #endregion

        #region 初始化

        /// <summary>
        /// 初始化
        /// </summary>
        /// <param name="Obj"></param>
        public HTupleToolForm(HTupleToolObj Obj) : base(Obj)
        {
            InitializeComponent();
            mObj = Obj;

            switch (mObj.operateMode)
            {
                case "元素选择":
                case "移除":
                    pnl1.Visible = false;
                    pnl2.Visible = false;
                    pnl3.Visible = false;
                    pnl4.Visible = true;
                    break;
                case "元组求和":
                case "元组求差":
                case "元组求积":
                case "元组求商":
                case "集合":
                case "并集":
                case "差集":
                case "交集":
                case "判断元组相等":
                case "判断元素相等":
                case "位置查找":
                case "最小元素(2个元组)":
                case "最大元素(2个元组)":
                    pnl1.Visible = false;
                    pnl2.Visible = true;
                    pnl3.Visible = false;
                    pnl4.Visible = false;
                    break;
                case "插入":
                case "替换":
                    pnl1.Visible = false;
                    pnl2.Visible = false;
                    pnl3.Visible = true;
                    pnl4.Visible = false;
                    break;
                default:
                    pnl1.Visible = true;
                    pnl2.Visible = false;
                    pnl3.Visible = false;
                    pnl4.Visible = false;
                    break;
            }

            ShowResult();
        }

        #endregion

        #region 方法-窗口显示相关

        /// <summary>
        /// 窗口显示
        /// </summary>
        protected void FormDisplay()
        {
            ShowResult();
        }

        /// <summary>
        /// 显示结果
        /// </summary>
        public void ShowResult()
        {
            if (operateResultForm == null || operateResultForm.IsDisposed)
            {
                operateResultForm = new ResultForm();
            }

            Point point = new Point();
            point.X = Location.X + Width;
            point.Y = Location.Y + 1;
            operateResultForm.Location = point;
            operateResultForm.StartPosition = FormStartPosition.Manual;
            operateResultForm.ShowResult(mObj.exeResult, mObj.hTupleTool_Info.result);
            operateResultForm.Show();
        }

        #endregion

        #region 方法-对象保存加载相关

        /// <summary>
        /// 将窗体的值保存到模块对象中
        /// </summary>
        public override void FormToObj()
        {
            if (pnl1.Visible)
            {
                mObj.operateMode = cbx1Operate.Text;
                mObj.strElem1 = ld1Elem.TextInfo.Trim();
            }
            else if(pnl2.Visible)
            {
                mObj.operateMode = cbx2Operate.Text;
                mObj.strElem1 = ld2Elem1.TextInfo.Trim();
                mObj.strElem2 = ld2Elem2.TextInfo.Trim();
            }
            else if (pnl3.Visible)
            {
                mObj.operateMode = cbx3Operate.Text;
                mObj.strElem1 = ld3Elem1.TextInfo.Trim();
                mObj.strElem2 = ld3Elem2.TextInfo.Trim();
                mObj.strIdx = ld3Idx.TextInfo.Trim();
            }
            else
            {
                mObj.operateMode = cbx4Operate.Text;
                mObj.strElem1 = ld4Elem.TextInfo.Trim();
                mObj.strIdx = ld4Idx.TextInfo.Trim();
            }

            mObj.GetData();
        }

        /// <summary>
        /// 将模块对象中的值加载到窗体中
        /// </summary>
        public override void ObjToForm()
        {
            cbx1Operate.Text = mObj.operateMode;
            cbx2Operate.Text = mObj.operateMode;
            cbx3Operate.Text = mObj.operateMode;
            cbx4Operate.Text = mObj.operateMode;

            ld1Elem.TextInfo = mObj.strElem1;
            ld2Elem1.TextInfo = mObj.strElem1;
            ld3Elem1.TextInfo = mObj.strElem1;
            ld4Elem.TextInfo = mObj.strElem1;

            ld2Elem2.TextInfo = mObj.strElem2;
            ld3Elem2.TextInfo = mObj.strElem2;

            ld3Idx.TextInfo = mObj.strIdx;
            ld4Idx.TextInfo = mObj.strIdx;
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
                case "ld1Elem":
                case "ld2Elem1":
                case "ld3Elem1":
                case "ld4Elem":
                    LikeDataForm.dataType = "int" + "|" + "int[]" + "|" + "double" + "|" + "double[]" + "|" + "HTuple";
                    LikeDataForm.ShowDialog();
                    if (LikeDataForm.m_OutLinkData.Length > 3)
                    {
                        string[] m_IntStr = LikeDataForm.m_OutLinkData.Split('|');
                        ld1Elem.TextInfo = m_IntStr[0] + ":" + m_IntStr[1];
                        ld2Elem1.TextInfo = m_IntStr[0] + ":" + m_IntStr[1];
                        ld3Elem1.TextInfo = m_IntStr[0] + ":" + m_IntStr[1];
                        ld4Elem.TextInfo = m_IntStr[0] + ":" + m_IntStr[1];
                    }
                    break;
                case "ld3dex":
                case "ld4dex":
                    LikeDataForm.dataType = "int" + "|" + "int[]" + "|" + "HTuple";
                    LikeDataForm.ShowDialog();
                    if (LikeDataForm.m_OutLinkData.Length > 3)
                    {
                        string[] m_IntStr = LikeDataForm.m_OutLinkData.Split('|');
                        ld3Idx.TextInfo = m_IntStr[0] + ":" + m_IntStr[1];
                        ld4Idx.TextInfo = m_IntStr[0] + ":" + m_IntStr[1];
                    }
                    break;
                case "ld2Elem2":
                case "ld3Elem2":
                    LikeDataForm.dataType = "int" + "|" + "int[]" + "|" + "double" + "|" + "double[]" + "|" + "HTuple";
                    LikeDataForm.ShowDialog();
                    if (LikeDataForm.m_OutLinkData.Length > 3)
                    {
                        string[] m_IntStr = LikeDataForm.m_OutLinkData.Split('|');
                        ld2Elem2.TextInfo = m_IntStr[0] + ":" + m_IntStr[1];
                        ld3Elem2.TextInfo = m_IntStr[0] + ":" + m_IntStr[1];
                    }
                    break;
            }
        }

        #endregion

        #region 事件-ComboBox控件

        /// <summary>
        /// 运算方式选中值改变
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cbxOperateMode_SelectedIndexChanged(object sender, EventArgs e)
        {
            MyComboBox cbx = sender as MyComboBox;
            switch (cbx.Text)
            {
                case "元素选择":
                case "移除":
                    pnl1.Visible = false;
                    pnl2.Visible = false;
                    pnl3.Visible = false;
                    pnl4.Visible = true;
                    break;
                case "元组求和":
                case "元组求差":
                case "元组求积":
                case "元组求商":
                case "集合":
                case "并集":
                case "差集":
                case "交集":
                case "判断元组相等":
                case "判断元素相等":
                case "位置查找":
                case "最小元素(2个元组)":
                case "最大元素(2个元组)":
                    pnl1.Visible = false;
                    pnl2.Visible = true;
                    pnl3.Visible = false;
                    pnl4.Visible = false;
                    break;
                case "插入":
                case "替换":
                    pnl1.Visible = false;
                    pnl2.Visible = false;
                    pnl3.Visible = true;
                    pnl4.Visible = false;
                    break;
                default:
                    pnl1.Visible = true;
                    pnl2.Visible = false;
                    pnl3.Visible = false;
                    pnl4.Visible = false;
                    break;
            }

            mObj.operateMode = cbx.Text;
            ObjToForm();
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
            FormDisplay();

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

        /// <summary>
        /// 窗体位置改变
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void NinePointsCalibForm_LocationChanged(object sender, EventArgs e)
        {
            if (operateResultForm != null)
            {
                Point point = new Point();
                point.X = Location.X + Width;
                point.Y = Location.Y + 1;
                operateResultForm.Location = point;
            }
        }

        /// <summary>
        /// 窗体关闭
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void NinePointsCalibForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (operateResultForm != null)
            {
                operateResultForm.Close();
            }
        }

        #endregion
    }
}
