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
using System.Drawing.Text;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using VisionCore;
using static System.Net.Mime.MediaTypeNames;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace Plugin.FitCircle
{
    public partial class FitCircleForm : FormBase
    {
        #region 字段、属性

        /// <summary>
        /// 模块对象
        /// </summary>
        FitCircleObj mObj;

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
        public FitCircleForm(FitCircleObj Obj) : base(Obj)
        {
            InitializeComponent();
            mObj = Obj;

            btnClearResult.FillColor = Color.AliceBlue;
            btnClearResult.RectColor = Color.AliceBlue;
            btnClearResult.ForeColor = Color.FromArgb(100, 100, 100);
            btnClearResult.ForeHoverColor = Color.FromArgb(100, 100, 100);
            btnClearResult.ForePressColor = Color.FromArgb(100, 100, 100);
            btnClearResult.FillHoverColor = Color.LightBlue;
            btnClearResult.FillPressColor = Color.LightBlue;
            btnClearResult.RectPressColor = Color.LightBlue;
            btnClearResult.RectHoverColor = Color.LightBlue;
            chxUsePiexlPrec.ForeColor = Color.FromArgb(100, 100, 100);
            chxShowData.ForeColor = Color.FromArgb(100, 100, 100);
            chxShowCircle.ForeColor = Color.FromArgb(100, 100, 100);
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
        /// 显示HObject对象
        /// </summary>
        public void ShowHObj()
        {
            //声明变量
            HObject circle = new HObject();

            //获取HObject
            if (mObj.fitCircle_Info.circleObj == null || !mObj.fitCircle_Info.circleObj.IsInitialized()) return;
            circle = mObj.fitCircle_Info.circleObj;

            //显示HObject
            if (circle.IsInitialized())
            {
                HOperatorSet.SetLineWidth(mWindowH.HWindowHalconID, 1.45);
                HOperatorSet.SetColor(mWindowH.HWindowHalconID, mObj.resultColor);
                HOperatorSet.DispObj(circle, mWindowH.HWindowHalconID);
                mWindowH.DispObj(circle, mObj.resultColor);
            }
        }

        /// <summary>
        /// 显示输入HObject
        /// </summary>
        public void ShowInputHObj()
        {
            try
            {
                //声明变量
                HObject point = new HObject();

                //加载图像
                if (!ShowImage()) return;

                //生成HObject
                HOperatorSet.SetLineWidth(mWindowH.HWindowHalconID, 1.45);
                HOperatorSet.GenCrossContourXld(out point, mObj.pointRow, mObj.pointCol, mObj.pointSize, 0.785398);

                //显示HObject
                if (point.IsInitialized())
                {
                    HOperatorSet.SetColor(mWindowH.HWindowHalconID, mObj.pointColor);
                    HOperatorSet.DispObj(point, mWindowH.HWindowHalconID);
                    mWindowH.DispObj(point, mObj.pointColor);
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
            if (mObj.fitCircle_Info.circleCenterRow != null && mObj.fitCircle_Info.circleCenterCol != null && mObj.fitCircle_Info.circleRadius != null)
            {
                info = mObj.fitCircle_Info.circleCenterRow.TupleConcat(mObj.fitCircle_Info.circleCenterCol).TupleConcat(mObj.fitCircle_Info.circleRadius);
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
            //tab1
            mObj.mImages = ldImage.TextInfo.Trim();
            mObj.strPointCol = ldPointX.TextInfo.Trim();
            mObj.strPointRow = ldPointY.TextInfo.Trim();

            //tab2
            mObj.drawCircleMode = (DrawCircleMode)Enum.Parse(typeof(DrawCircleMode), cbxDrawMode.Text);
            mObj.isUsePixelPrec = chxUsePiexlPrec.Checked;

            //tab3
            mObj.pointColor = ColorTranslator.ToHtml(cpPoint.Value);

            //tab4
            mObj.isShowData = chxShowData.Checked;
            mObj.isShowReg = chxShowCircle.Checked;
            mObj.X = Convert.ToDouble(tbxX.TextInfo.Trim());
            mObj.Y = Convert.ToDouble(tbxY.TextInfo.Trim());
            mObj.fontSize = Convert.ToInt32(tbxFontSize.TextInfo.Trim());
            mObj.pointSize = Convert.ToInt32(tbxPointSize.TextInfo.Trim());
            mObj.fontType = cbxFontStye.Text.Trim();
            mObj.prefix = tbxPrefix.Text.Trim();
            mObj.fontColor = ColorTranslator.ToHtml(cpFont.Value);
            mObj.resultColor = ColorTranslator.ToHtml(cpCircle.Value);

            mObj.GetData();
        }

        /// <summary>
        /// 将模块对象中的值加载到窗体中
        /// </summary>
        public override void ObjToForm()
        {
            //Tab1
            ldImage.TextInfo = mObj.mImages;
            ldPointX.TextInfo = mObj.strPointCol;
            ldPointY.TextInfo = mObj.strPointRow;

            //tab2
            cbxDrawMode.Text = mObj.drawCircleMode.ToString();
            chxUsePiexlPrec.Checked = mObj.isUsePixelPrec;

            //tab3
            cpPoint.Value = ColorTranslator.FromHtml(mObj.pointColor);

            //tab4
            chxShowData.Checked = mObj.isShowData;
            chxShowCircle.Checked = mObj.isShowReg;
            tbxX.TextInfo = mObj.X.ToString();
            tbxY.TextInfo = mObj.Y.ToString();
            tbxFontSize.TextInfo = mObj.fontSize.ToString();
            tbxPointSize.TextInfo = mObj.pointSize.ToString();
            cbxFontStye.Text = mObj.fontType.ToString();
            tbxPrefix.Text = mObj.prefix;
            cpFont.Value = ColorTranslator.FromHtml(mObj.fontColor);
            cpCircle.Value = ColorTranslator.FromHtml(mObj.resultColor);
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

        /// <summary>
        /// 清除结果
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnClearResult_Click(object sender, EventArgs e)
        {
            ShowInputHObj();
            resultForm.ShowResult("模块未执行", "");
        }

        #endregion

        #region 事件-窗体控件

        /// <summary>
        /// 窗体加载
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FitCircleForm_Load(object sender, EventArgs e)
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

            ShowInputHObj();
            ShowHObj();
            ShowResult();
        }

        /// <summary>
        /// 窗体关闭
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void DistancePPForm_FormClosed(object sender, FormClosedEventArgs e)
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
        private void DistancePPForm_LocationChanged(object sender, EventArgs e)
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
            LikeDataForm.dataType = "int" + "|" + "double" + "|" + "HTuple";
            LikeDataForm.ShowDialog();
            if (LikeDataForm.m_OutLinkData.Length > 3)
            {
                string[] m_IntStr = LikeDataForm.m_OutLinkData.Split('|');
                MyLinkData myLinkData = sender as MyLinkData;
                switch (myLinkData.Name)
                {
                    case "ldPointX":
                        ldPointX.TextInfo = m_IntStr[0] + ":" + m_IntStr[1];
                        break;
                    case "ldPointY":
                        ldPointY.TextInfo = m_IntStr[0] + ":" + m_IntStr[1];
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
