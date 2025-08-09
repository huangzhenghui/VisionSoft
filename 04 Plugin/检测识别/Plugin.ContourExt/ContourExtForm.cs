using HalconDotNet;
using Plugin.CreateROI;
using Rex.UI;
using RexConst;
using RexControl.MyControls;
using RexView;
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

namespace Plugin.ContourExt
{
    public partial class ContourExtForm : FormBase
    {
        #region 字段、属性

        /// <summary>
        /// 模块对象
        /// </summary>
        ContourExtObj mObj = new ContourExtObj();

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
        public ContourExtForm(ContourExtObj Obj) : base(Obj)
        {
            InitializeComponent();
            mObj = Obj;

            chxShowContour.ForeColor = Color.FromArgb(100, 100, 100);
        }

        #endregion

        #region 方法-窗体显示相关

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
            HObject contours = new HObject();

            //获取HObject
            if (mObj.mRImage == null || !mObj.mRImage.IsInitialized()) return;
            if (mObj.contourExt_Info.contourObj == null || !mObj.contourExt_Info.contourObj.IsInitialized()) return;
            contours = mObj.contourExt_Info.contourObj;

            //显示HObject
            HOperatorSet.SetLineWidth(mWindowH.HWindowHalconID, 1.45);
            HOperatorSet.SetColored(mWindowH.HWindowHalconID, 12);
            HOperatorSet.DispObj(contours, mWindowH.HWindowHalconID);
            mWindowH.DispObj(contours);
        }

        /// <summary>
        /// 显示输入HObject
        /// </summary>
        public void ShowInputHObj() { }

        /// <summary>
        /// 显示HObject对象
        /// </summary>
        public void ShowHObj()
        {
            if (mObj.contourExt_Info.contourObj != null && mObj.contourExt_Info.contourObj.IsInitialized())
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
            resultForm.ShowResult(mObj.exeResult, mObj.contourExt_Info.contourNum);
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
            mObj.filter = cbxFilter.Text;
            mObj.alpha = Convert.ToDouble(tbxAlpha.TextInfo.Trim());
            mObj.low = Convert.ToInt32(tbxLow.TextInfo.Trim());
            mObj.high = Convert.ToInt32(tbxHigh.TextInfo.Trim());

            //tab3
            mObj.isShowReg = chxShowContour.Checked;
            mObj.resultColor = ColorTranslator.ToHtml(cpContour.Value);

            mObj.GetData();
        }

        /// <summary>
        /// 将模块对象中的值加载到窗体中
        /// </summary>
        public override void ObjToForm()
        {
            ldImage.TextInfo = mObj.mImages;
            cbxFilter.Text = mObj.filter;
            tbxAlpha.TextInfo = mObj.alpha.ToString();
            tbxLow.TextInfo = mObj.low.ToString();
            tbxHigh.TextInfo = mObj.high.ToString();
            chxShowContour.Checked = mObj.isShowReg;
            cpContour.Value = ColorTranslator.FromHtml(mObj.resultColor);
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
        /// <summary>
        /// 窗体加载
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ContourExtForm_Load(object sender, EventArgs e)
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
        private void ContourExtForm_FormClosed(object sender, FormClosedEventArgs e)
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
        private void ContourExtForm_LocationChanged(object sender, EventArgs e)
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

            ShowImage();
            ShowInputHObj();
            ShowOutputHObj();
        }

        #endregion
    }
}
