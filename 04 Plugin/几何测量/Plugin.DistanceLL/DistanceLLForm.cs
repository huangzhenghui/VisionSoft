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

namespace Plugin.DistanceLL
{
    public partial class DistanceLLForm : FormBase
    {
        #region 字段、属性

        /// <summary>
        /// 模块对象
        /// </summary>
        DistanceLLObj mObj;

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
        public DistanceLLForm(DistanceLLObj Obj) : base(Obj)
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
            HObject line1 = new HObject();
            HObject line2 = new HObject();
            HObject point1 = new HObject();
            HObject point2 = new HObject();
            HObject verline = new HObject();

            //获取HObject
            if (mObj.distanceLL_Info.hObjAssem == null || !mObj.distanceLL_Info.hObjAssem.IsInitialized()) return;
            int num = mObj.distanceLL_Info.hObjAssem.CountObj();
            int len = mObj.beginRowL1.Length;

            HTuple line1Idx = HTuple.TupleGenSequence(1, len, 1);
            HTuple point1Idx = HTuple.TupleGenSequence(len + 2, num, 3);
            HTuple point2Idx = HTuple.TupleGenSequence(len + 3, num, 3);
            HTuple lineIdx = HTuple.TupleGenSequence(len + 4, num, 3);

            HOperatorSet.SelectObj(mObj.distanceLL_Info.hObjAssem, out line1, 1);
            HOperatorSet.SelectObj(mObj.distanceLL_Info.hObjAssem, out line2, len + 1);
            HOperatorSet.SelectObj(mObj.distanceLL_Info.hObjAssem, out point1, point1Idx);
            HOperatorSet.SelectObj(mObj.distanceLL_Info.hObjAssem, out point2, point2Idx);
            HOperatorSet.SelectObj(mObj.distanceLL_Info.hObjAssem, out verline, lineIdx);

            //显示HObject
            if (line1.IsInitialized())
            {
                HOperatorSet.SetLineWidth(mWindowH.HWindowHalconID, 1.45);
                HOperatorSet.SetColor(mWindowH.HWindowHalconID, mObj.line1Color);
                HOperatorSet.DispObj(line1, mWindowH.HWindowHalconID);
                mWindowH.DispObj(line1, mObj.line1Color);
            }

            if (line2.IsInitialized())
            {
                HOperatorSet.SetLineWidth(mWindowH.HWindowHalconID, 1.45);
                HOperatorSet.SetColor(mWindowH.HWindowHalconID, mObj.line2Color);
                HOperatorSet.DispObj(line2, mWindowH.HWindowHalconID);
                mWindowH.DispObj(line2, mObj.line1Color);
            }

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

            if (verline.IsInitialized())
            {
                HOperatorSet.SetLineWidth(mWindowH.HWindowHalconID, 1.45);
                HOperatorSet.SetColor(mWindowH.HWindowHalconID, mObj.resultColor);
                HOperatorSet.DispObj(verline, mWindowH.HWindowHalconID);
                mWindowH.DispObj(verline, mObj.resultColor);
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
                HObject line1 = new HObject();
                HObject line2 = new HObject();

                //加载图像
                if (!ShowImage()) return;

                //生成HObject
                HOperatorSet.SetLineWidth(mWindowH.HWindowHalconID, 1.45);

                for (int i = 0; i < mObj.beginRowL1.Length; i++)
                {
                    HObject lineObj = new HObject();
                    HOperatorSet.GenContourPolygonXld(out lineObj, mObj.beginRowL1.TupleSelect(i).TupleConcat(mObj.endRowL1.TupleSelect(i)), mObj.beginColL1.TupleSelect(i).TupleConcat(mObj.endColL1.TupleSelect(i)));

                    if (!line1.IsInitialized())
                    {
                        line1 = lineObj;
                    }
                    else
                    {
                        HOperatorSet.ConcatObj(line1, lineObj, out line1);
                    }
                }

                HOperatorSet.GenContourPolygonXld(out line2, mObj.beginRowL2.TupleConcat(mObj.endRowL2), mObj.beginColL2.TupleConcat(mObj.endColL2));

                //显示HObject
                if (line1.IsInitialized())
                {
                    HOperatorSet.SetColor(mWindowH.HWindowHalconID, mObj.line1Color);
                    HOperatorSet.DispObj(line1, mWindowH.HWindowHalconID);
                    mWindowH.DispObj(line1, mObj.line1Color);
                }

                if (line2.IsInitialized())
                {
                    HOperatorSet.SetColor(mWindowH.HWindowHalconID, mObj.line2Color);
                    HOperatorSet.DispObj(line2, mWindowH.HWindowHalconID);
                    mWindowH.DispObj(line2, mObj.line2Color);
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
            resultForm.ShowResult(mObj.exeResult, mObj.distanceLL_Info.distAssem);
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
            mObj.strBeginColL1 = ldL1BeginX.TextInfo.Trim();
            mObj.strBeginRowL1 = ldL1BeginY.TextInfo.Trim();
            mObj.strEndColL1 = ldL1EndX.TextInfo.Trim();
            mObj.strEndRowL1 = ldL1EndY.TextInfo.Trim();
            mObj.strBeginColL2 = ldL2BeginX.TextInfo.Trim();
            mObj.strBeginRowL2 = ldL2BeginY.TextInfo.Trim();
            mObj.strEndColL2 = ldL2EndX.TextInfo.Trim();
            mObj.strEndRowL2 = ldL2EndY.TextInfo.Trim();

            //tab2
            mObj.valueMode = (ValueMode)Enum.Parse(typeof(ValueMode), cbxValueMode.Text);
            mObj.isUsePixelPrec = chxUsePiexlPrec.Checked;

            //tab3
            mObj.line1Color = ColorTranslator.ToHtml(cpLine1.Value);
            mObj.line2Color = ColorTranslator.ToHtml(cpLine2.Value);

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
            mObj.point1Color = ColorTranslator.ToHtml(cpPoint1.Value);
            mObj.point2Color = ColorTranslator.ToHtml(cpPoint2.Value);
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
            ldL1BeginX.TextInfo = mObj.strBeginColL1;
            ldL1BeginY.TextInfo = mObj.strBeginRowL1;
            ldL1EndX.TextInfo = mObj.strEndColL1;
            ldL1EndY.TextInfo = mObj.strEndRowL1;
            ldL2BeginX.TextInfo = mObj.strBeginColL2;
            ldL2BeginY.TextInfo = mObj.strBeginRowL2;
            ldL2EndX.TextInfo = mObj.strEndColL2;
            ldL2EndY.TextInfo = mObj.strEndRowL2;

            //tab2
            cbxValueMode.Text = mObj.valueMode.ToString();
            chxUsePiexlPrec.Checked = mObj.isUsePixelPrec;

            //tab3
            cpLine1.Value = ColorTranslator.FromHtml(mObj.line1Color);
            cpLine2.Value = ColorTranslator.FromHtml(mObj.line2Color);

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
            cpPoint1.Value = ColorTranslator.FromHtml(mObj.point1Color);
            cpPoint2.Value = ColorTranslator.FromHtml(mObj.point2Color);
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
        private void DistanceLLForm_Load(object sender, EventArgs e)
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
        private void DistanceLLForm_FormClosed(object sender, FormClosedEventArgs e)
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
        private void DistanceLLForm_LocationChanged(object sender, EventArgs e)
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
                    case "ldL1BeginX":
                        ldL1BeginX.TextInfo = m_IntStr[0] + ":" + m_IntStr[1];
                        break;
                    case "ldL1BeginY":
                        ldL1BeginY.TextInfo = m_IntStr[0] + ":" + m_IntStr[1];
                        break;
                    case "ldL1EndX":
                        ldL1EndX.TextInfo = m_IntStr[0] + ":" + m_IntStr[1];
                        break;
                    case "ldL1EndY":
                        ldL1EndY.TextInfo = m_IntStr[0] + ":" + m_IntStr[1];
                        break;
                    case "ldL2BeginX":
                        ldL2BeginX.TextInfo = m_IntStr[0] + ":" + m_IntStr[1];
                        break;
                    case "ldL2BeginY":
                        ldL2BeginY.TextInfo = m_IntStr[0] + ":" + m_IntStr[1];
                        break;
                    case "ldL2EndX":
                        ldL2EndX.TextInfo = m_IntStr[0] + ":" + m_IntStr[1];
                        break;
                    case "ldL2EndY":
                        ldL2EndY.TextInfo = m_IntStr[0] + ":" + m_IntStr[1];
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
