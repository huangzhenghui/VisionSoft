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
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using VisionCore;
using static System.Net.Mime.MediaTypeNames;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace Plugin.CreateLine
{
    public partial class CreateLineForm : FormBase
    {
        #region 字段、属性

        /// <summary>
        /// 模块对象
        /// </summary>
        CreateLineObj mObj;

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
        public CreateLineForm(CreateLineObj Obj) : base(Obj)
        {
            InitializeComponent();
            chxShowResult.ForeColor = Color.FromArgb(100, 100, 100);
            mObj = Obj;
        }

        #endregion

        #region 方法-窗口显示相关

        /// <summary>
        /// 窗口显示
        /// </summary>
        protected void FormDisplay()
        {
            ShowImage();
            ShowHObj();
        }

        /// <summary>
        /// 显示图像
        /// </summary>
        public void ShowImage()
        {
            //获取图像
            mObj.mImages = ldImage.TextInfo;
            if (mObj.mImages == null) return;
            mObj.mRImage = (RImage)Var.GetImage(mObj.mSloVar, mObj.mImages);

            //显示图像
            if (mObj.mRImage == null) return;
            mWindowH.HobjectToHimage(mObj.mRImage);
        }

        /// <summary>
        /// 显示HObject对象
        /// </summary>
        public void ShowHObj()
        {
            HObject point, objAssem;
            HOperatorSet.GenEmptyObj(out point);
            HOperatorSet.GenEmptyObj(out objAssem);

            if (mObj.createLine_Info.lineObj != null)
            {
                HOperatorSet.GenCrossContourXld(out point, new HTuple(mObj.beginRow).TupleConcat(mObj.endRow), new HTuple(mObj.beginCol).TupleConcat(mObj.endCol), 15, 0.785398);
                HOperatorSet.ConcatObj(point, mObj.createLine_Info.lineObj, out objAssem);
                HOperatorSet.DispObj(objAssem, mWindowH.HWindowHalconID);
                mWindowH.DispObj(objAssem, mObj.resultColor);
            }
        }

        #endregion

        #region 方法-对象保存加载相关

        /// <summary>
        /// 将窗体的值保存到模块对象中
        /// </summary>
        public override void FormToObj()
        {
            //tab1
            mObj.mImages = ldImage.TextInfo.Trim();
            mObj.lineType = cbxType.Text;
            mObj.strBeginCol = ldBeginX.TextInfo.Trim();
            mObj.strBeginRow = ldBeginY.TextInfo.Trim();
            mObj.strEndCol = ldEndX.TextInfo.Trim();
            mObj.strEndRow = ldEndY.TextInfo.Trim();
            mObj.GetData();

            //tab2
            mObj.isShowReg = chxShowResult.Checked;
            mObj.arrowWidth = tbxArrowWidth.TextInfo.Trim().ToInt();
            mObj.resultColor = ColorTranslator.ToHtml(cpColor.Value);
        }

        /// <summary>
        /// 将模块对象中的值加载到窗体中
        /// </summary>
        public override void ObjToForm()
        {
            //Tab1
            ldImage.TextInfo = mObj.mImages;
            cbxType.Text = mObj.lineType;
            ldBeginX.TextInfo = mObj.strBeginCol;
            ldBeginY.TextInfo = mObj.strBeginRow;
            ldEndX.TextInfo = mObj.strEndCol;
            ldEndY.TextInfo = mObj.strEndRow;

            //Tab2
            chxShowResult.Checked = mObj.isShowReg;
            tbxArrowWidth.TextInfo = mObj.arrowWidth.ToString();
            cpColor.Value = ColorTranslator.FromHtml(mObj.resultColor);
        }

        #endregion

        #region 事件-MyLinkData控件

        /// <summary>
        /// image型数据链接
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ldImage_LinkData(object sender, EventArgs e)
        {
            PluginDataLinkForm LikeDataForm = new PluginDataLinkForm(mObj.ProjName, mObj.ModInfo.Name);
            LikeDataForm.dataType = "RImage";
            LikeDataForm.ShowDialog();
            if (LikeDataForm.m_OutLinkData.Length > 3)
            {
                string[] m_IntStr = LikeDataForm.m_OutLinkData.Split('|');
                ldImage.TextInfo = m_IntStr[0] + ":" + m_IntStr[1];
            }
            mObj.mImages = ldImage.TextInfo.Trim();
            ShowImage();
        }

        /// <summary>
        /// double类型数据链接
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ldDouble_LinkData(object sender, EventArgs e)
        {
            PluginDataLinkForm LikeDataForm = new PluginDataLinkForm(mObj.ProjName, mObj.ModInfo.Name);
            LikeDataForm.dataType = "Double";
            LikeDataForm.ShowDialog();
            if (LikeDataForm.m_OutLinkData.Length > 3)
            {
                string[] m_IntStr = LikeDataForm.m_OutLinkData.Split('|');
                MyLinkData myLinkData = sender as MyLinkData;
                switch (myLinkData.Name)
                {
                    case "ldBeginX":
                        ldBeginX.TextInfo = m_IntStr[0] + ":" + m_IntStr[1];
                        break;
                    case "ldBeginY":
                        ldBeginY.TextInfo = m_IntStr[0] + ":" + m_IntStr[1];
                        break;
                    case "ldEndX":
                        ldEndX.TextInfo = m_IntStr[0] + ":" + m_IntStr[1];
                        break;
                    case "ldEndY":
                        ldEndY.TextInfo = m_IntStr[0] + ":" + m_IntStr[1];
                        break;
                    default:
                        break;
                }
            }
        }

        #endregion

        #region 事件-ComboBox控件

        /// <summary>
        /// 直线类型改变执行事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cbxType_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbxType.SelectedText == "普通")
            {
                lblArrowWidth.Visible = false;
                tbxArrowWidth.Visible = false;
            }
            else
            {
                lblArrowWidth.Visible = true;
                tbxArrowWidth.Visible = true;
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
        /// 窗体加载
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CreateLineForm_Load(object sender, EventArgs e)
        {
            if (cbxType.SelectedText == "普通")
            {
                lblArrowWidth.Visible = false;
                tbxArrowWidth.Visible = false;
            }
            else
            {
                lblArrowWidth.Visible = true;
                tbxArrowWidth.Visible = true;
            }
        }

        #endregion
    }
}
