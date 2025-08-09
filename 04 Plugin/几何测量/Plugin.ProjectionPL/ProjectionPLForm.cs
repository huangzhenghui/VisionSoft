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

namespace Plugin.ProjectionPL
{
    public partial class ProjectionPLForm : FormBase
    {
        #region 字段、属性

        /// <summary>
        /// 模块对象
        /// </summary>
        ProjectionPLObj mObj;

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
        public ProjectionPLForm(ProjectionPLObj Obj) : base(Obj)
        {
            InitializeComponent();
            chxShowPoint.ForeColor = Color.FromArgb(100, 100, 100);
            chxShowData.ForeColor = Color.FromArgb(100, 100, 100);
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
            HObject assem, point, line;
            HOperatorSet.GenEmptyObj(out point);
            HOperatorSet.GenEmptyObj(out line);
            HOperatorSet.GenEmptyObj(out assem);

            //绘制点、线
            HOperatorSet.GenCrossContourXld(out point, mObj.pointRow, mObj.pointCol, mObj.pointSize, 0.785398);
            HOperatorSet.GenContourPolygonXld(out line, new HTuple(mObj.beginRow).TupleConcat(mObj.endRow), new HTuple(mObj.beginCol).TupleConcat(mObj.endCol));
            HOperatorSet.ConcatObj(assem, point, out assem);
            HOperatorSet.ConcatObj(assem, line, out assem);
            HOperatorSet.ConcatObj(assem, mObj.projectionPL_Info.pointObj, out assem);
            HOperatorSet.DispObj(assem, mWindowH.HWindowHalconID);
            mWindowH.DispObj(assem, mObj.resultColor);

            //绘制文本
            HTuple text = mObj.prefix + ":" + " X:" + mObj.projectionPL_Info.pointCol.ToString("F4") + " Y:" + mObj.projectionPL_Info.pointRow.ToString("F4");
            ShowTool.SetFont(mWindowH.hControl.HalconWindow, mObj.fontSize, "mono", "false", "false");
            ShowTool.SetMsg(mWindowH.hControl.HalconWindow, text, "image", 5, 5, mObj.resultColor, "false");
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
            mObj.pointColName = ldPointX.TextInfo.Trim();
            mObj.pointRowName = ldPointY.TextInfo.Trim();
            mObj.beginColName = ldBeginX.TextInfo.Trim();
            mObj.beginRowName = ldBeginY.TextInfo.Trim();
            mObj.endColName = ldEndX.TextInfo.Trim();
            mObj.endRowName = ldEndY.TextInfo.Trim();

            mObj.GetData();

            //tab2
            mObj.isShowPoint = chxShowPoint.Checked;
            mObj.isShowData = chxShowData.Checked;
            mObj.X = tbxX.TextInfo.Trim().ToDouble();
            mObj.Y = tbxY.TextInfo.Trim().ToDouble();
            mObj.pointSize = tbxPointSize.TextInfo.Trim().ToInt();
            mObj.fontSize = tbxFontSize.TextInfo.Trim().ToInt();
            mObj.prefix = tbxPrefix.Text.Trim();
            mObj.resultColor = ColorTranslator.ToHtml(cpColor.Value);
        }

        /// <summary>
        /// 将模块对象中的值加载到窗体中
        /// </summary>
        public override void ObjToForm()
        {
            //Tab1
            ldImage.TextInfo = mObj.mImages;
            ldPointX.TextInfo = mObj.pointColName;
            ldPointY.TextInfo = mObj.pointRowName;
            ldBeginX.TextInfo = mObj.beginColName;
            ldBeginY.TextInfo = mObj.beginRowName;
            ldEndX.TextInfo = mObj.endColName;
            ldEndY.TextInfo = mObj.endRowName;

            //Tab2
            chxShowPoint.Checked = mObj.isShowPoint;
            chxShowData.Checked = mObj.isShowData;
            tbxX.TextInfo = mObj.X.ToString();
            tbxY.TextInfo = mObj.Y.ToString();
            tbxPointSize.TextInfo = mObj.pointSize.ToString();
            tbxFontSize.TextInfo = mObj.fontSize.ToString();
            tbxPrefix.Text = mObj.prefix.ToString();
            cpColor.Value = ColorTranslator.FromHtml(mObj.resultColor);
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
                case "ldImage":
                    LikeDataForm.dataType = "RImage";
                    LikeDataForm.ShowDialog();
                    if (LikeDataForm.m_OutLinkData.Length > 3)
                    {
                        string[] m_IntStr = LikeDataForm.m_OutLinkData.Split('|');
                        ldImage.TextInfo = m_IntStr[0] + ":" + m_IntStr[1];
                        mObj.mImages = ldImage.TextInfo.Trim();
                        ShowImage();
                    }
                    break;
                case "ldPointX":
                    LikeDataForm.dataType = "Double";
                    LikeDataForm.ShowDialog();
                    if (LikeDataForm.m_OutLinkData.Length > 3)
                    {
                        string[] m_IntStr = LikeDataForm.m_OutLinkData.Split('|');
                        ldPointX.TextInfo = m_IntStr[0] + ":" + m_IntStr[1];
                    }
                    break;
                case "ldPointY":
                    LikeDataForm.dataType = "Double";
                    LikeDataForm.ShowDialog();
                    if (LikeDataForm.m_OutLinkData.Length > 3)
                    {
                        string[] m_IntStr = LikeDataForm.m_OutLinkData.Split('|');
                        ldPointY.TextInfo = m_IntStr[0] + ":" + m_IntStr[1];
                    }
                    break;
                case "ldBeginX":
                    LikeDataForm.dataType = "Double";
                    LikeDataForm.ShowDialog();
                    if (LikeDataForm.m_OutLinkData.Length > 3)
                    {
                        string[] m_IntStr = LikeDataForm.m_OutLinkData.Split('|');
                        ldBeginX.TextInfo = m_IntStr[0] + ":" + m_IntStr[1];
                    }
                    break;
                case "ldBeginY":
                    LikeDataForm.dataType = "Double";
                    LikeDataForm.ShowDialog();
                    if (LikeDataForm.m_OutLinkData.Length > 3)
                    {
                        string[] m_IntStr = LikeDataForm.m_OutLinkData.Split('|');
                        ldBeginY.TextInfo = m_IntStr[0] + ":" + m_IntStr[1];
                    }
                    break;
                case "ldEndX":
                    LikeDataForm.dataType = "Double";
                    LikeDataForm.ShowDialog();
                    if (LikeDataForm.m_OutLinkData.Length > 3)
                    {
                        string[] m_IntStr = LikeDataForm.m_OutLinkData.Split('|');
                        ldEndX.TextInfo = m_IntStr[0] + ":" + m_IntStr[1];
                    }
                    break;
                case "ldEndY":
                    LikeDataForm.dataType = "Double";
                    LikeDataForm.ShowDialog();
                    if (LikeDataForm.m_OutLinkData.Length > 3)
                    {
                        string[] m_IntStr = LikeDataForm.m_OutLinkData.Split('|');
                        ldEndY.TextInfo = m_IntStr[0] + ":" + m_IntStr[1];
                    }
                    break;
                default:
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
    }
}
