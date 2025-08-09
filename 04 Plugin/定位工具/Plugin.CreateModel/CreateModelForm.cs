using HalconDotNet;
using MutualTools;
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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace Plugin.CreateModel
{
    public partial class CreateModelForm : FormBase
    {
        #region 字段、属性

        /// <summary>
        /// 模块对象
        /// </summary>
        public CreateModelObj mObj;

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
        public CreateModelForm(CreateModelObj Obj) : base(Obj)
        {
            InitializeComponent();
            mObj = Obj;

            if (cbxFactor.SelectedText == "相关性")
            {
                pnl1ModelInfo.Visible = true;
                pnl2ModelInfo.Visible = false;
                pnl1Params.Visible = true;
                pnl2Params.Visible = false;
            }
            else
            {
                pnl1ModelInfo.Visible = false;
                pnl2ModelInfo.Visible = true;
                pnl1Params.Visible = false;
                pnl2Params.Visible = true;
            }

            if (cbxPrecision.SelectedText == "像素")
            {
                lbl2Contrast.Visible = false;
                cbx2Contrast.Visible = false;
            }
            else
            {
                lbl2Contrast.Visible = true;
                cbx2Contrast.Visible = true;
            }
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
        /// 显示HObject对象
        /// </summary>
        public void ShowHObj() { }

        /// <summary>
        /// 显示输入HObject
        /// </summary>
        public void ShowInputHObj()
        {
            try
            {
                //加载图像
                if (!ShowImage()) return;

                //显示HObject
                switch (mObj.factor)
                {
                    case"相关性":
                        if (mObj.modRegion.IsInitialized())
                        {
                            HOperatorSet.SetColor(mWindowH.HWindowHalconID, mObj.resultColor);
                            HOperatorSet.DispObj(mObj.modRegion, mWindowH.HWindowHalconID);
                            mWindowH.DispObj(mObj.modRegion, mObj.resultColor);
                        }
                        break;
                    case "形状":
                        if (mObj.modContour.IsInitialized())
                        {
                            HOperatorSet.SetColor(mWindowH.HWindowHalconID, mObj.resultColor);
                            HOperatorSet.DispObj(mObj.modContour, mWindowH.HWindowHalconID);
                            mWindowH.DispObj(mObj.modContour, mObj.resultColor);
                        }
                        break;
                }
            }
            catch { }
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

            HTuple info = new HTuple();
            if (mObj.createModel_Info.modelMidR != null && mObj.createModel_Info.modelMidC != null && mObj.createModel_Info.modelAngle != null)
            {
                info = mObj.createModel_Info.modelMidR.TupleConcat(mObj.createModel_Info.modelMidC).TupleConcat(mObj.createModel_Info.modelAngle);
            }

            Point point = new Point();
            point.X = Location.X + Width;
            point.Y = Location.Y + 1;
            resultForm.Location = point;
            resultForm.StartPosition = FormStartPosition.Manual;
            resultForm.ShowResult(mObj.exeResult, info);
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
            mObj.strModRegion = ldModRegion.TextInfo;
            mObj.strModContour = ldModContour.TextInfo;
            mObj.precision = cbxPrecision.Text;

            //Tab2
            HTuple radStart = new HTuple();
            HTuple radExtent = new HTuple();
            HTuple radStep = new HTuple();

            if (mObj.factor == "相关性")
            {
                HOperatorSet.TupleRad(tbx1AngleStart.TextInfo.ToDouble(), out radStart);
                HOperatorSet.TupleRad(tbx1AngleExtent.TextInfo.ToDouble(), out radExtent);
                HOperatorSet.TupleRad(tbx1AngleStep.TextInfo.ToDouble(), out radStep);

                mObj.numLevels = Convert.ToInt32(cbx1NumLevels.Text);
                mObj.angleStart = radStart.D;
                mObj.angleExtent = radExtent.D;
                mObj.angleStep = radStep.D;
                mObj.metric = cbx1Metric.Text;
            }
            else
            {
                HOperatorSet.TupleRad(tbx2AngleStart.TextInfo.ToDouble(), out radStart);
                HOperatorSet.TupleRad(tbx2AngleExtent.TextInfo.ToDouble(), out radExtent);
                HOperatorSet.TupleRad(tbx2AngleStep.TextInfo.ToDouble(), out radStep);

                mObj.numLevels = Convert.ToInt32(cbx1NumLevels.Text);
                mObj.angleStart = radStart.D;
                mObj.angleExtent = radExtent.D;
                mObj.angleStep = radStep.D;
                mObj.metric = cbx2Metric.Text;
                mObj.scaleMin = tbx2ScaleMin.TextInfo.ToDouble();
                mObj.scaleMax = tbx2ScaleMax.TextInfo.ToDouble();
                mObj.scaleStep = tbx2ScaleStep.TextInfo.ToDouble();
                mObj.optimization = cbx2Optimization.Text;
                mObj.minContrast = tbx2MinContrast.TextInfo.ToDouble();
                mObj.contrast = cbx2Contrast.Text;
            }

            //Tab3
            mObj.resultColor = ColorTranslator.ToHtml(cpModel.Value);

            //Tab4
            mObj.modelName = tbxModelName.Text;
            mObj.modelPath = tbxModelPath.Text;

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
            ldModRegion.TextInfo = mObj.strModRegion;
            ldModContour.TextInfo = mObj.strModContour;
            cbxPrecision.Text = mObj.precision;

            //Tab2
            HTuple degStart = new HTuple();
            HTuple degExtent = new HTuple();
            HTuple degStep = new HTuple();

            HOperatorSet.TupleDeg(mObj.angleStart, out degStart);
            HOperatorSet.TupleDeg(mObj.angleExtent, out degExtent);
            HOperatorSet.TupleDeg(mObj.angleStep, out degStep);

            cbx1NumLevels.Text = mObj.numLevels.ToString();
            tbx1AngleStart.TextInfo = degStart.ToString();
            tbx1AngleExtent.TextInfo = degExtent.ToString();
            tbx1AngleStep.TextInfo = degStep.ToString();
            cbx1Metric.Text = mObj.metric;
            cbx2NumLevels.Text = mObj.numLevels.ToString();
            tbx2AngleStart.TextInfo = degStart.ToString();
            tbx2AngleExtent.TextInfo = degExtent.ToString();
            tbx2AngleStep.TextInfo = degStep.ToString();
            cbx2Metric.Text = mObj.metric;
            tbx2ScaleMin.TextInfo = mObj.scaleMin.ToString();
            tbx2ScaleMax.TextInfo = mObj.scaleMax.ToString();
            tbx2ScaleStep.TextInfo = mObj.scaleStep.ToString();
            cbx2Optimization.Text = mObj.optimization;
            tbx2MinContrast.TextInfo = mObj.minContrast.ToString();
            cbx2Contrast.Text = mObj.contrast.ToString();

            //Tab3
            cpModel.Value = ColorTranslator.FromHtml(mObj.resultColor);

            //Tab4
            tbxModelName.Text = mObj.modelName;
            tbxModelPath.Text = mObj.modelPath;
        }

        #endregion

        #region 事件-按钮控件

        /// <summary>
        /// 模板路径连接
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnModelPath_Click(object sender, EventArgs e)
        {
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
        private void CreateModelForm_Load(object sender, EventArgs e)
        {
            ShowInputHObj();
            ShowHObj();
            ShowResult();
        }

        /// <summary>
        /// 窗体关闭
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CreateModelForm_FormClosed(object sender, FormClosedEventArgs e)
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
        private void CreateModelForm_LocationChanged(object sender, EventArgs e)
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

        /// <summary>
        /// 颜色改变重新绘制ROI
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="value"></param>
        private void cpColor_ValueChanged(object sender, Color value)
        {
            FormToObj();
            ShowInputHObj();
        }

        /// <summary>
        /// 模板因素选择
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cbxSelect_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbxFactor.SelectedText == "相关性")
            {
                pnl1ModelInfo.Visible = true;
                pnl2ModelInfo.Visible = false;
                pnl1Params.Visible = true;
                pnl2Params.Visible = false;
            }
            else
            {
                pnl1ModelInfo.Visible = false;
                pnl2ModelInfo.Visible = true;
                pnl1Params.Visible = false;
                pnl2Params.Visible = true;
            }
        }

        /// <summary>
        /// 轮廓精度选择
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cbxPrecision_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbxPrecision.SelectedText == "像素")
            {
                lbl2Contrast.Visible = false;
                cbx2Contrast.Visible = false;
            }
            else
            {
                lbl2Contrast.Visible = true;
                cbx2Contrast.Visible = true;
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

        /// <summary>
        /// 数据链接
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ldData_LinkData(object sender, EventArgs e)
        {
            PluginDataLinkForm LikeDataForm = new PluginDataLinkForm(mObj.ProjName, mObj.ModInfo.Name);
            LikeDataForm.dataType = "HObject";
            LikeDataForm.ShowDialog();
            if (LikeDataForm.m_OutLinkData.Length > 3)
            {
                string[] m_IntStr = LikeDataForm.m_OutLinkData.Split('|');
                MyLinkData myLinkData = sender as MyLinkData;
                switch (myLinkData.Name)
                {
                    case "ldModRegion":
                        ldModRegion.TextInfo = m_IntStr[0] + ":" + m_IntStr[1];
                        break;
                    case "ldModContour":
                        ldModContour.TextInfo = m_IntStr[0] + ":" + m_IntStr[1];
                        break;
                }
            }
            FormToObj();
        }

        /// <summary>
        /// 数据变化实时执行程序
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ldData_RealTimeExe(object sender, EventArgs e)
        {
            MyLinkData myLinkData = sender as MyLinkData;
            FormToObj();
            ShowInputHObj();
        }

        #endregion
    }
}
