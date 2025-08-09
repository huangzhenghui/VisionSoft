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
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using VisionCore;
using static System.Net.Mime.MediaTypeNames;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace Plugin.NinePointsCalib
{
    public partial class NinePointsCalibForm : FormBase
    {
        #region 字段、属性

        /// <summary>
        /// 模块对象
        /// </summary>
        NinePointsCalibObj mObj = new NinePointsCalibObj();

        /// <summary>
        /// 标定结果显示窗体对象
        /// </summary>
        CalibResultForm calibResultForm;

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
        public NinePointsCalibForm(NinePointsCalibObj Obj) : base(Obj)
        {
            InitializeComponent();
            mObj = Obj;
        }

        #endregion

        #region 方法-对象保存加载相关

        /// <summary>
        /// 将窗体的值保存到模块对象中
        /// </summary>
        public override void FormToObj()
        {
            //Tab1
            mObj.pointsNum = int.Parse(cbxPointNum.Text.Trim());
            mObj.RMSMin = double.Parse(tbxRMSMin.TextInfo.Trim());
            mObj.RMSMax = double.Parse(tbxRMSMax.TextInfo.Trim());

            mObj.imgColName.Clear();
            mObj.imgRowName.Clear();
            mObj.physicalColName.Clear();
            mObj.physicalRowName.Clear();

            //列表信息
            for (int i = 0; i < int.Parse(cbxPointNum.Text); i++)
            {
                mObj.imgColName.Add(dgv_PointList.Rows[i].Cells[1].Value.ToString());
                mObj.imgRowName.Add(dgv_PointList.Rows[i].Cells[2].Value.ToString());
                mObj.physicalColName.Add(dgv_PointList.Rows[i].Cells[3].Value.ToString());
                mObj.physicalRowName.Add(dgv_PointList.Rows[i].Cells[4].Value.ToString());
            }

            //Tab2
            mObj.savePath = tbxSavePath.Text.Trim();

            mObj.GetData();
        }

        /// <summary>
        /// 将模块对象中的值加载到窗体中
        /// </summary>
        public override void ObjToForm()
        {
            //Tab1
            cbxPointNum.Text = mObj.pointsNum.ToString();
            tbxRMSMin.TextInfo = mObj.RMSMin.ToString();
            tbxRMSMax.TextInfo = mObj.RMSMax.ToString();

            //列表信息
            dgv_PointList.ClearRows();
            for (int i = 0; i < int.Parse(cbxPointNum.Text); i++)
            {
                DataGridViewRow dr = new DataGridViewRow();
                dr.CreateCells(dgv_PointList);
                dr.Height = 27;
                dr.Cells[0].Value = i + 1;

                dr.Cells[0].Value = i + 1;

                if (i < mObj.imgColName.Count)
                {
                    dr.Cells[1].Value = mObj.imgColName[i];
                }
                else
                {
                    dr.Cells[1].Value = "";
                }

                if (i < mObj.imgRowName.Count)
                {
                    dr.Cells[2].Value = mObj.imgRowName[i];
                }
                else
                {
                    dr.Cells[2].Value = "";
                }

                if (i < mObj.physicalColName.Count)
                {
                    dr.Cells[3].Value = mObj.physicalColName[i];
                }
                else
                {
                    dr.Cells[3].Value = "";
                }

                if (i < mObj.physicalRowName.Count)
                {
                    dr.Cells[4].Value = mObj.physicalRowName[i];
                }
                else
                {
                    dr.Cells[4].Value = "";
                }

                dgv_PointList.Rows.Add(dr);//添加的行作为最后一行
            }

            //Tab2
            tbxSavePath.Text = mObj.savePath;
        }

        #endregion

        #region 事件-ComboBox控件

        /// <summary>
        /// 矩阵点数变化
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cbxPointNum_SelectedIndexChanged(object sender, EventArgs e)
        {
            dgv_PointList.ClearRows();
            for (int i = 0; i < int.Parse(cbxPointNum.Text); i++)
            {
                DataGridViewRow dr = new DataGridViewRow();
                dr.CreateCells(dgv_PointList);
                dr.Height = 27;
                dr.Cells[0].Value = i + 1;

                if (i < mObj.imgColName.Count)
                {
                    dr.Cells[1].Value = mObj.imgColName[i];
                }
                else
                {
                    dr.Cells[1].Value = "";
                }

                if (i < mObj.imgRowName.Count)
                {
                    dr.Cells[2].Value = mObj.imgRowName[i];
                }
                else
                {
                    dr.Cells[2].Value = "";
                }

                if (i < mObj.physicalColName.Count)
                {
                    dr.Cells[3].Value = mObj.physicalColName[i];
                }
                else
                {
                    dr.Cells[3].Value = "";
                }

                if (i < mObj.physicalRowName.Count)
                {
                    dr.Cells[4].Value = mObj.physicalRowName[i];
                }
                else
                {
                    dr.Cells[4].Value = "";
                }

                dgv_PointList.Rows.Add(dr);//添加的行作为最后一行
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

            btnShowResult.PerformClick();

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
        /// 保存路径链接
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSavePathLink_Click(object sender, EventArgs e)
        {
            SaveFileDialog fileDialog = new SaveFileDialog();
            fileDialog.Title = "请选择文件";
            fileDialog.Filter = "所有文件(*.*)|*.*";
            if (fileDialog.ShowDialog() == DialogResult.OK)
            {
                tbxSavePath.Text = fileDialog.FileName;
            }
        }

        /// <summary>
        /// 显示标定结果窗体
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnShowResult_Click(object sender, EventArgs e)
        {
            if (calibResultForm == null || calibResultForm.IsDisposed)
            {
                calibResultForm = new CalibResultForm();
            }

            calibResultForm.result = mObj.result;
            calibResultForm.sx = mObj.precisionX;
            calibResultForm.sy = mObj.precisionY;
            calibResultForm.RMS = mObj.RMS;

            Point point = new Point();
            point.X = Location.X + Width;
            point.Y = Location.Y + 1;
            calibResultForm.Location = point;
            calibResultForm.StartPosition = FormStartPosition.Manual;
            calibResultForm.Show();
            calibResultForm.ShowResult();
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
            if (calibResultForm != null)
            {
                Point point = new Point();
                point.X = Location.X + Width;
                point.Y = Location.Y + 1;
                calibResultForm.Location = point;
            }
        }

        /// <summary>
        /// 窗体关闭
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void NinePointsCalibForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (calibResultForm != null)
            {
                calibResultForm.Close();
            }
        }

        #endregion

        #region 事件-DataGridView控件

        /// <summary>
        /// 单元格双击
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dgv_PointList_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            PluginDataLinkForm LikeDataForm = new PluginDataLinkForm(mObj.ProjName, mObj.ModInfo.Name);
            LikeDataForm.dataType = "int" + "|" + "int[]" + "|" + "double" + "|" + "double[]" + "|" + "string" + "|" + "string[]" + "|" + "HTuple";
            LikeDataForm.ShowDialog();
            if (LikeDataForm.m_OutLinkData.Length > 3)
            {
                string[] m_IntStr = LikeDataForm.m_OutLinkData.Split('|');
                dgv_PointList.CurrentCell.Value = m_IntStr[0] + ":" + m_IntStr[1];
            }
        }

        /// <summary>
        /// DataGridView单元格重绘
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dgv_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
        {
            DataGridView dgv = sender as DataGridView;
            var g = e.Graphics;

            if (e.RowIndex < 0)
            {
                if (Enumerable.Range(0, 50).Contains(e.ColumnIndex))
                {
                    Brush bg = new SolidBrush(dgv.ColumnHeadersDefaultCellStyle.BackColor); // 背景色
                    Brush fg = new SolidBrush(dgv.ColumnHeadersDefaultCellStyle.ForeColor); // 前景色

                    //绘制背景色
                    if ((e.PaintParts & DataGridViewPaintParts.Background) == DataGridViewPaintParts.Background)
                        g.FillRectangle(bg, e.CellBounds); // 

                    if ((e.PaintParts & DataGridViewPaintParts.ContentBackground) == DataGridViewPaintParts.ContentBackground)
                        g.FillRectangle(bg, e.CellBounds); // 

                    if ((e.PaintParts & DataGridViewPaintParts.ContentForeground) == DataGridViewPaintParts.ContentForeground)
                    {
                        var col = dgv.Columns[e.ColumnIndex];
                        var text = col?.HeaderText ?? "";
                        var sizeF = g.MeasureString(text, dgv.ColumnHeadersDefaultCellStyle.Font); // 测量绘制列标题文本尺寸
                        var x = e.CellBounds.X + (e.CellBounds.Width - sizeF.Width) / 2f; // 获取 Left
                        var y = e.CellBounds.Y + (e.CellBounds.Height - sizeF.Height) / 1.5f; // 获取 Top

                        g.DrawString(text, dgv.ColumnHeadersDefaultCellStyle.Font, fg, x, y); // 绘制列标题
                    }
                    e.Handled = true;
                }
            }
        }

        #endregion
    }
}
