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

namespace Plugin.FindModel
{
    public partial class FindModelForm : FormBase
    {
        #region 字段、属性

        /// <summary>
        /// 模块对象
        /// </summary>
        FindModelObj mObj;

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
        ResultForm resultForm;

        #endregion

        #region 初始化

        /// <summary>
        /// 初始化
        /// </summary>
        /// <param name="Obj"></param>
        public FindModelForm(FindModelObj Obj) : base(Obj)
        {
            InitializeComponent();
            mObj = Obj;

            chxShow.ForeColor = Color.FromArgb(100, 100, 100);

            if (cbxFactor.SelectedText == "相关性")
            {
                pnl1Params.Visible = true;
                pnl2Params.Visible = false;
            }
            else
            {
                pnl1Params.Visible = false;
                pnl2Params.Visible = true;
            }
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
            ShowResult();
        }

        /// <summary>
        /// 显示图像
        /// </summary>
        public bool ShowImage()
        {
            //获取图像
            mObj.mImages = ldImage.TextInfo;
            if (mObj.mImages == "") return false;
            mObj.mRImage = (RImage)Var.GetImage(mObj.mSloVar, mObj.mImages);

            //显示图像
            if (mObj.mRImage == null || !mObj.mRImage.IsInitialized()) return false;
            mWindowH.HobjectToHimage(mObj.mRImage);

            //设置可绘制区域的大小
            HOperatorSet.SetSystem("width", 20000);
            HOperatorSet.SetSystem("height", 20000);

            return true;
        }

        /// <summary>
        /// 显示输出HObject对象
        /// </summary>
        public void ShowOutputHObj()
        {
            //声明变量
            HObject resultObj = new HObject();

            //获取HObject
            if (mObj.findModel_Info.resultObj == null || !mObj.findModel_Info.resultObj.IsInitialized()) return;
            resultObj = mObj.findModel_Info.resultObj;

            //显示HObject
            HOperatorSet.SetLineWidth(mWindowH.HWindowHalconID, 1.45);
            HOperatorSet.SetColored(mWindowH.HWindowHalconID, 12);
            HOperatorSet.DispObj(resultObj, mWindowH.HWindowHalconID);
            mWindowH.DispObj(resultObj);
        }

        /// <summary>
        /// 显示输入HObject
        /// </summary>
        public void ShowInputHObj()
        {
            try
            {
                //声明变量
                HObject modelObj = new HObject();

                //加载图像
                if (!ShowImage()) return;

                //显示HObject对象
                switch (mObj.factor)
                {
                    case"相关性":
                        HOperatorSet.GetNccModelRegion(out modelObj, mObj.modelHandle);
                        break;
                    case "形状":
                        HOperatorSet.GetShapeModelContours(out modelObj, mObj.modelHandle, 1);
                        break;
                }

                if (modelObj.IsInitialized())
                {
                    HOperatorSet.SetColored(mWindowH.HWindowHalconID, 12);
                    HOperatorSet.DispObj(modelObj, mWindowH.HWindowHalconID);
                    mWindowH.DispObj(modelObj);
                }
            }
            catch { }
        }

        /// <summary>
        /// 显示HObject对象
        /// </summary>
        public void ShowHObj()
        {
            if (mObj.findModel_Info.resultObj != null && mObj.findModel_Info.resultObj.IsInitialized())
            {
                ShowOutputHObj();
            }
            else
            {
                ShowInputHObj();
            }
        }

        /// <summary>
        /// 显示结果窗体
        /// </summary>
        public void ShowResult()
        {
            if (resultForm == null || resultForm.IsDisposed)
            {
                resultForm = new ResultForm();
            }

            Point point = new Point();
            point.X = Location.X + Width;
            point.Y = Location.Y + 1;
            resultForm.Location = point;
            resultForm.StartPosition = FormStartPosition.Manual;
            resultForm.ShowResult(mObj.exeResult, mObj.findModel_Info.resultNum);
            resultForm.Show();
        }

        #endregion

        #region 方法-对象保存加载相关

        /// <summary>
        /// 将窗体的值保存到模块对象中
        /// </summary>
        public override void FormToObj()
        {
            //Tab1
            mObj.mImages = ldImage.TextInfo.Trim();
            mObj.factor = cbxFactor.Text;
            mObj.modelPath = tbxModelPath.Text;

            //Tab2
            HTuple radStart = new HTuple();
            HTuple radExtent = new HTuple();

            if (mObj.factor == "相关性")
            {
                HOperatorSet.TupleRad(Convert.ToDouble(tbx1AngleStart.TextInfo.Trim()), out radStart);
                HOperatorSet.TupleRad(Convert.ToDouble(tbx1AngleExtent.TextInfo.Trim()), out radExtent);

                mObj.numLevels = Convert.ToInt32(cbx1NumLevels.Text);
                mObj.angleStart = radStart.D;
                mObj.angleExtent = radExtent.D;
                mObj.minScore = Convert.ToDouble(tbx1MinScore.TextInfo.Trim());
                mObj.numMatches = Convert.ToInt32(tbx1NumMatches.TextInfo.Trim());
                mObj.maxOverlap = Convert.ToDouble(tbx1MaxOverlap.TextInfo.Trim());

                if (cbx1Precision.Text == "亚像素")
                {
                    mObj.isSubPixel = "true";
                }
                else
                {
                    mObj.isSubPixel = "false";
                }
            }
            else
            {
                HOperatorSet.TupleRad(Convert.ToDouble(tbx2AngleStart.TextInfo.Trim()), out radStart);
                HOperatorSet.TupleRad(Convert.ToDouble(tbx2AngleExtent.TextInfo.Trim()), out radExtent);

                mObj.numLevels = Convert.ToInt32(cbx2NumLevels.Text);
                mObj.angleStart = radStart.D;
                mObj.angleExtent = radExtent.D;
                mObj.scaleMin = Convert.ToDouble(tbx2ScaleMin.TextInfo.Trim());
                mObj.scaleMax = Convert.ToDouble(tbx2ScaleMax.TextInfo.Trim());
                mObj.minScore = Convert.ToDouble(tbx2MinScore.TextInfo.Trim());
                mObj.numMatches = Convert.ToInt32(tbx2NumMatches.TextInfo.Trim());
                mObj.greediness = Convert.ToDouble(tbx2Greediness.TextInfo.Trim());
                mObj.interAlgo = cbx2InterAlgo.Text;
            }

            //Tab3
            mObj.isShowReg = chxShow.Checked;
            mObj.resultColor = ColorTranslator.ToHtml(cpColor.Value);

            mObj.GetData();
        }

        /// <summary>
        /// 将模块对象中的值加载到窗体中
        /// </summary>
        public override void ObjToForm()
        {
            //Tab1
            ldImage.TextInfo = mObj.mImages;
            cbxFactor.Text = mObj.factor;
            tbxModelPath.Text = mObj.modelPath;

            //Tab2
            HTuple degStart = new HTuple();
            HTuple degExtent = new HTuple();

            HOperatorSet.TupleDeg(mObj.angleStart, out degStart);
            HOperatorSet.TupleDeg(mObj.angleExtent, out degExtent);

            cbx1NumLevels.Text = mObj.numLevels.ToString();
            tbx1AngleStart.TextInfo = degStart.ToString();
            tbx1AngleExtent.TextInfo = degExtent.ToString();
            tbx1MinScore.TextInfo = mObj.minScore.ToString();
            tbx1NumMatches.TextInfo = mObj.numMatches.ToString();
            tbx1MaxOverlap.TextInfo = mObj.maxOverlap.ToString();

            if (mObj.isSubPixel == "true")
            {
                cbx1Precision.Text = "亚像素";
            }
            else
            {
                cbx1Precision.Text = "像素";
            }

            cbx2NumLevels.Text = mObj.numLevels.ToString();
            tbx2AngleStart.TextInfo = degStart.ToString();
            tbx2AngleExtent.TextInfo = degExtent.ToString();
            tbx2ScaleMin.TextInfo = mObj.scaleMin.ToString();
            tbx2ScaleMax.TextInfo = mObj.scaleMax.ToString();
            tbx2MinScore.TextInfo = mObj.minScore.ToString();
            tbx2NumMatches.TextInfo = mObj.numMatches.ToString();
            tbx2Greediness.TextInfo = mObj.greediness.ToString();
            cbx2InterAlgo.Text = mObj.interAlgo.ToString();

            //Tab3
            chxShow.Checked = mObj.isShowReg;
            cpColor.Value = ColorTranslator.FromHtml(mObj.resultColor);
        }

        #endregion

        #region 事件-按钮控件

        /// <summary>
        /// 模板路径链接
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnModelPathLink_Click(object sender, EventArgs e)
        {
            /// <summary>
            /// 文件对话框
            /// </summary>
            OpenFileDialog fileDialog = new OpenFileDialog();
            fileDialog.Multiselect = true;
            fileDialog.Title = "请选择文件";
            fileDialog.Filter = "所有文件(*.*)|*.*";
            if (fileDialog.ShowDialog() == DialogResult.OK)
            {
                tbxModelPath.Text = fileDialog.FileName;
            }
        }

        /// <summary>
        /// 执行
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public override void btn_Run_Click(object sender, EventArgs e)
        {
            timerObj.Start(); // 启动计时器

            FormToObj();
            mObj.RunObj();
            ObjToForm();
            FormDisplay();

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

        /// <summary>
        /// 窗体加载
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FindModelForm_Load(object sender, EventArgs e)
        {
            ShowImage();
            ShowHObj();
            ShowResult();
        }

        /// <summary>
        /// 窗体关闭
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FindModelForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (resultForm != null)
            {
                resultForm.Close();
            }
        }

        /// <summary>
        /// 窗体位置改变
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FindModelForm_LocationChanged(object sender, EventArgs e)
        {
            if (resultForm != null)
            {
                Point point = new Point();
                point.X = Location.X + Width;
                point.Y = Location.Y + 1;
                resultForm.Location = point;
            }
        }

        #endregion

        #region 事件-ComboBox控件

        private void cbxSelect_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbxFactor.SelectedText == "相关性")
            {
                pnl1Params.Visible = true;
                pnl2Params.Visible = false;
            }
            else
            {
                pnl1Params.Visible = false;
                pnl2Params.Visible = true;
            }
        }

        #endregion

        #region 事件-MyLinkData控件

        /// <summary>
        /// 图像链接
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
            ShowInputHObj();
            ShowHObj();
        }

        #endregion
    }
}
