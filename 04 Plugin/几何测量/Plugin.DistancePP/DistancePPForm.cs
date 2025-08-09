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

namespace Plugin.DistancePP
{
    public partial class DistancePPForm : FormBase
    {
        #region 字段、属性

        /// <summary>
        /// 模块对象
        /// </summary>
        DistancePPObj mObj;

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
        public DistancePPForm(DistancePPObj Obj) : base(Obj)
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
            chxShowHObj.ForeColor = Color.FromArgb(100, 100, 100);
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
            HObject point1 = new HObject();
            HObject point2 = new HObject();
            HObject line = new HObject();

            //获取HObject
            if (mObj.distancePP_Info.hObjAssem == null || !mObj.distancePP_Info.hObjAssem.IsInitialized()) return;
            int num = mObj.distancePP_Info.hObjAssem.CountObj();

            HTuple point1Idx = HTuple.TupleGenSequence(2, (num - 1) / 2 + 1, 1);
            HTuple lineIdx = HTuple.TupleGenSequence((num - 1) / 2 + 2, num, 1);

            HOperatorSet.SelectObj(mObj.distancePP_Info.hObjAssem, out point1, point1Idx);
            HOperatorSet.SelectObj(mObj.distancePP_Info.hObjAssem, out point2, 1);
            HOperatorSet.SelectObj(mObj.distancePP_Info.hObjAssem, out line, lineIdx);

            //显示HObject
            if (point1.IsInitialized())
            {
                HOperatorSet.SetLineWidth(mWindowH.HWindowHalconID, 1.45);
                HOperatorSet.SetColor(mWindowH.HWindowHalconID, mObj.point1Color);
                HOperatorSet.DispObj(point1, mWindowH.HWindowHalconID);
                mWindowH.DispObj(point1, mObj.point1Color);
            }

            if (point2.IsInitialized())
            {
                HOperatorSet.SetLineWidth(mWindowH.HWindowHalconID, 1.45);
                HOperatorSet.SetColor(mWindowH.HWindowHalconID, mObj.point2Color);
                HOperatorSet.DispObj(point2, mWindowH.HWindowHalconID);
                mWindowH.DispObj(point2, mObj.point2Color);
            }

            if (line.IsInitialized())
            {
                HOperatorSet.SetLineWidth(mWindowH.HWindowHalconID, 1.45);
                HOperatorSet.SetColor(mWindowH.HWindowHalconID, mObj.resultColor);
                HOperatorSet.DispObj(line, mWindowH.HWindowHalconID);
                mWindowH.DispObj(line, mObj.resultColor);
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
                HObject point1 = new HObject();
                HObject point2 = new HObject();

                //加载图像
                if (!ShowImage()) return;

                //生成HObject
                HOperatorSet.SetLineWidth(mWindowH.HWindowHalconID, 1.45);
                HOperatorSet.GenCrossContourXld(out point1, mObj.point1Row, mObj.point1Col, mObj.pointSize, 0.785398);
                HOperatorSet.GenCrossContourXld(out point2, mObj.point2Row, mObj.point2Col, mObj.pointSize, 0.785398);

                //显示HObject
                if (point1.IsInitialized())
                {
                    HOperatorSet.SetColor(mWindowH.HWindowHalconID, mObj.point1Color);
                    HOperatorSet.DispObj(point1, mWindowH.HWindowHalconID);
                    mWindowH.DispObj(point1, mObj.point1Color);
                }

                if (point2.IsInitialized())
                {
                    HOperatorSet.SetColor(mWindowH.HWindowHalconID, mObj.point2Color);
                    HOperatorSet.DispObj(point2, mWindowH.HWindowHalconID);
                    mWindowH.DispObj(point2, mObj.point2Color);
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

            Point point = new Point();
            point.X = Location.X + Width;
            point.Y = Location.Y + 1;
            resultForm.Location = point;
            resultForm.StartPosition = FormStartPosition.Manual;
            resultForm.ShowResult(mObj.exeResult, mObj.distancePP_Info.distAssem);
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
            mObj.strPoint1Col = ldPoint1X.TextInfo.Trim();
            mObj.strPoint1Row = ldPoint1Y.TextInfo.Trim();
            mObj.strPoint2Col = ldPoint2X.TextInfo.Trim();
            mObj.strPoint2Row = ldPoint2Y.TextInfo.Trim();

            //tab2
            mObj.isUsePixelPrec = chxUsePiexlPrec.Checked;

            //tab3
            mObj.point1Color = ColorTranslator.ToHtml(cpPoint1.Value);
            mObj.point2Color = ColorTranslator.ToHtml(cpPoint2.Value);

            //tab4
            mObj.isShowData = chxShowData.Checked;
            mObj.isShowReg = chxShowHObj.Checked;
            mObj.X = Convert.ToDouble(tbxX.TextInfo.Trim());
            mObj.Y = Convert.ToDouble(tbxY.TextInfo.Trim());
            mObj.fontSize = Convert.ToInt32(tbxFontSize.TextInfo.Trim());
            mObj.pointSize = Convert.ToInt32(tbxPointSize.TextInfo.Trim());
            mObj.fontType = cbxFontStye.Text.Trim();
            mObj.prefix = tbxPrefix.Text.Trim();
            mObj.fontColor = ColorTranslator.ToHtml(cpFont.Value);
            mObj.resultColor = ColorTranslator.ToHtml(cpVerticalLine.Value);

            mObj.GetData();
        }

        /// <summary>
        /// 将模块对象中的值加载到窗体中
        /// </summary>
        public override void ObjToForm()
        {
            //Tab1
            ldImage.TextInfo = mObj.mImages;
            ldPoint1X.TextInfo = mObj.strPoint1Col;
            ldPoint1Y.TextInfo = mObj.strPoint1Row;
            ldPoint2X.TextInfo = mObj.strPoint2Col;
            ldPoint2Y.TextInfo = mObj.strPoint2Row;

            //tab2
            chxUsePiexlPrec.Checked = mObj.isUsePixelPrec;

            //tab3
            cpPoint1.Value = ColorTranslator.FromHtml(mObj.point1Color);
            cpPoint2.Value = ColorTranslator.FromHtml(mObj.point2Color);

            //tab4
            chxShowData.Checked = mObj.isShowData;
            chxShowHObj.Checked = mObj.isShowReg;
            tbxX.TextInfo = mObj.X.ToString();
            tbxY.TextInfo = mObj.Y.ToString();
            tbxFontSize.TextInfo = mObj.fontSize.ToString();
            tbxPointSize.TextInfo = mObj.pointSize.ToString();
            cbxFontStye.Text = mObj.fontType.ToString();
            tbxPrefix.Text = mObj.prefix;
            cpFont.Value = ColorTranslator.FromHtml(mObj.fontColor);
            cpVerticalLine.Value = ColorTranslator.FromHtml(mObj.resultColor);
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
        private void DistancePPForm_Load(object sender, EventArgs e)
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
                    case "ldPoint1X":
                        ldPoint1X.TextInfo = m_IntStr[0] + ":" + m_IntStr[1];
                        break;
                    case "ldPoint1Y":
                        ldPoint1Y.TextInfo = m_IntStr[0] + ":" + m_IntStr[1];
                        break;
                    case "ldPoint2X":
                        ldPoint2X.TextInfo = m_IntStr[0] + ":" + m_IntStr[1];
                        break;
                    case "ldPoint2Y":
                        ldPoint2Y.TextInfo = m_IntStr[0] + ":" + m_IntStr[1];
                        break;
                    default:
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
