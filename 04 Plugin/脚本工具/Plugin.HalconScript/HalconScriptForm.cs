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

namespace Plugin.HalconScript
{
    public partial class HalconScriptForm : FormBase
    {
        #region 字段、属性

        /// <summary>
        /// 模块对象
        /// </summary>
        HalconScriptObj mObj;

        /// <summary>
        /// 计时器
        /// </summary>
        public HTimer timerObj = new HTimer();

        /// <summary>
        /// 耗时
        /// </summary>
        public double costTime = 0;

        /// <summary>
        /// 引擎工具
        /// </summary>
        [NonSerialized]
        public HDevEngine myEngine;

        /// <summary>
        /// HDevProcedureCall变量
        /// </summary>
        HDevProcedureCall procedureCall;

        #endregion

        #region 初始化

        /// <summary>
        /// 初始化
        /// </summary>
        /// <param name="Obj"></param>
        public HalconScriptForm(HalconScriptObj Obj) : base(Obj)
        {
            InitializeComponent();
            tbxScriptPath.RectColor = Color.AliceBlue;
            tbxScriptPath.FillColor = Color.AliceBlue;
            tbxScriptPath.ForeColor = Color.FromArgb(100, 100, 100);
            chxShowReg.ForeColor = Color.FromArgb(100, 100, 100);
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
        /// 显示处理图像
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
            HOperatorSet.SetColored(mWindowH.hControl.HalconWindow, 12);
            if (mObj.halconScript_Info.outputHObject != null)
            {
                //绘制显示图形
                HOperatorSet.DispObj(mObj.halconScript_Info.outputHObject, mWindowH.HWindowHalconID);
                mWindowH.DispObj(mObj.halconScript_Info.outputHObject);
            }

            //绘制文本
            string text = "";
            
            if (mObj.prefix != "")
            {
                text = mObj.prefix + ":" + TypeConvert.HTupleToString(mObj.halconScript_Info.outputHTuple);
            }
            else
            {
                text = TypeConvert.HTupleToString(mObj.halconScript_Info.outputHTuple);
            }

            ShowTool.SetFont(mWindowH.hControl.HalconWindow, mObj.fontSize, mObj.fontType, "false", "false");
            ShowTool.SetMsg(mWindowH.hControl.HalconWindow, text, "window", 10, 10, mObj.resultColor, "false");
        }

        #endregion

        #region 方法-对象保存加载相关

        /// <summary>
        /// 将窗体的值保存到模块对象中
        /// </summary>
        public override void FormToObj()
        {
            HTuple word = new HTuple();

            SetEngine();

            //tab1
            mObj.mImages = ldImage.TextInfo.Trim();
            mObj.scriptType = cbxScriptType.Text;
            mObj.fileRPath = tbxScriptPath.Text.Trim();
            mObj.inputHObjectName = ldInputHObject.TextInfo.Trim();
            mObj.inputHTupleName = ldInputHTuple.TextInfo.Trim();

            //tab3
            mObj.isShowReg = chxShowReg.Checked;
            mObj.isShowData = chxShowData.Checked;
            mObj.X = double.Parse(tbxX.TextInfo.Trim());
            mObj.Y = double.Parse(tbxY.TextInfo.Trim());
            mObj.fontSize = int.Parse(tbxFontSize.TextInfo.Trim());
            mObj.fontType = cbxFontStye.Text;
            mObj.prefix = tbxPrefix.Text.Trim();
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
            cbxScriptType.Text = mObj.scriptType;
            tbxScriptPath.Text = mObj.fileRPath;
            ldInputHObject.TextInfo = mObj.inputHObjectName;
            ldInputHTuple.TextInfo = mObj.inputHTupleName;

            //Tab2
            chxShowReg.Checked = mObj.isShowReg;
            chxShowData.Checked = mObj.isShowData;
            tbxX.TextInfo = mObj.X.ToString();
            tbxY.TextInfo = mObj.Y.ToString();
            tbxFontSize.TextInfo = mObj.fontSize.ToString();
            cbxFontStye.Text = mObj.fontType;
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
                        ShowImage();
                    }
                    break;
                case "ldInputHObject":
                    LikeDataForm.dataType = "HObject";
                    LikeDataForm.ShowDialog();
                    if (LikeDataForm.m_OutLinkData.Length > 3)
                    {
                        string[] m_IntStr = LikeDataForm.m_OutLinkData.Split('|');
                        ldInputHObject.TextInfo = m_IntStr[0] + ":" + m_IntStr[1];
                    }
                    break;
                case "ldInputHTuple":
                    LikeDataForm.dataType = "HTuple";
                    LikeDataForm.ShowDialog();
                    if (LikeDataForm.m_OutLinkData.Length > 3)
                    {
                        string[] m_IntStr = LikeDataForm.m_OutLinkData.Split('|');
                        ldInputHTuple.TextInfo = m_IntStr[0] + ":" + m_IntStr[1];
                    }
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

        /// <summary>
        /// 文件读取路径链接
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnFileRPathLink_Click(object sender, EventArgs e)
        {
            OpenFileDialog fileDialog = new OpenFileDialog();
            fileDialog.Title = "请选择文件";
            fileDialog.Filter = "所有文件(*.*)|*.*|Hdvp文件(*.hdvp)|*.hdvp";
            if (fileDialog.ShowDialog() == DialogResult.OK)
            {
                tbxScriptPath.Text = fileDialog.FileName;
            }
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            try
            {
                string[] strAssem = mObj.fileRPath.Split("\\");
                string folderPath = "";
                for (int i = 0; i < strAssem.Length - 1; i++)
                {
                    if (i == 0)
                    {
                        folderPath = strAssem[0];
                    }
                    else
                    {
                        folderPath = folderPath + "\\" + strAssem[i];
                    }
                }

                string procedurePath = folderPath;
                string procedureName = strAssem[strAssem.Length - 1].Split('.')[0];

                myEngine = new HDevEngine();
                myEngine.SetProcedurePath(procedurePath);
                HDevProcedure procedure = new HDevProcedure(procedureName);
                procedureCall = new HDevProcedureCall(procedure);
                procedureCall.SetInputIconicParamObject("InputHObject", mObj.inputHObject);
                procedureCall.SetInputCtrlParamTuple("InputHTuple", mObj.inputHTuple);
                procedureCall.SetInputCtrlParamTuple("InputMode", "DrawCircle");
                myEngine.StartDebugServer();
            }
            catch{ }
        }

        private void btnExe_Click(object sender, EventArgs e)
        {
            if (procedureCall==null)
            {
                MessageBox.Show("请先载入程序");
                return;
            }

            procedureCall.Execute();//运行函数

        }

        #endregion

        #region 方法-引擎设置

        /// <summary>
        /// 引擎设置
        /// </summary>
        public void SetEngine()
        {
            if (mObj.fileRPath == tbxScriptPath.Text) return;
            string[] strAssem = tbxScriptPath.Text.Trim().Split("\\");
            string folderPath = "";
            for (int i = 0; i < strAssem.Length - 1; i++)
            {
                if (i == 0)
                {
                    folderPath = strAssem[0];
                }
                else
                {
                    folderPath = folderPath + "\\" + strAssem[i];
                }
            }

            string procedurePath = folderPath;

            mObj.myEngine = new HDevEngine();
            mObj.myEngine.SetProcedurePath(procedurePath);
        }

        #endregion
    }
}
