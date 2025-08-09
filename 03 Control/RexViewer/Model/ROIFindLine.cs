using HalconDotNet;
using NPOI.SS.Formula.Functions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RexView.Model
{
    public class ROIFindLine:ROI
    {
        #region 字段、属性

        /// <summary>
        /// 投影线起始点Row
        /// </summary>
        public double rowBegin;

        /// <summary>
        /// 投影线起始点Col
        /// </summary>
        public double colBegin;

        /// <summary>
        /// 投影线终止点Row
        /// </summary>
        public double rowEnd;

        /// <summary>
        /// 投影线终止点Col
        /// </summary>
        public double colEnd;

        /// <summary>
        /// 投影线中点Row
        /// </summary>
        public double rowMid;

        /// <summary>
        /// 投影线中点Col
        /// </summary>
        public double colMid;

        /// <summary>
        /// 测量矩形数量
        /// </summary>
        public int rectNum;

        /// <summary>
        /// 测量矩形Row坐标
        /// </summary>
        public double[] rowCenter;

        /// <summary>
        /// 测量矩形Column坐标
        /// </summary>
        public double[] colCenter;

        /// <summary>
        /// 测量矩形角度
        /// </summary>
        public double[] phi;

        /// <summary>
        /// 测量矩形length1
        /// </summary>
        public double length1;

        /// <summary>
        /// 测量矩形length2
        /// </summary>
        public double length2;

        /// <summary>
        /// 直线角度
        /// </summary>
        HTuple phiLine;

        #endregion

        #region 初始化

        /// <summary>
        /// 初始化
        /// </summary>
        public ROIFindLine()
        {
            NumHandles = 3; 
            ActiveHandleId = 2;
        }

        /// <summary>
        /// 初始化
        /// </summary>
        /// <param name="beginRow"></param>
        /// <param name="beginCol"></param>
        /// <param name="endRow"></param>
        /// <param name="endCol"></param>
        public ROIFindLine(double beginRow, double beginCol, double endRow, double endCol, int rectNum, double length1, double length2, string projectColor, string meaRectColor)
        {
            CreateFindLine(beginRow, beginCol, endRow, endCol, rectNum, length1, length2, projectColor, meaRectColor);
        }

        /// <summary>
        /// 初始化-创建找线
        /// </summary>
        /// <param name="beginRow"></param>
        /// <param name="beginCol"></param>
        /// <param name="endRow"></param>
        /// <param name="endCol"></param>
        public override void CreateFindLine(double beginRow, double beginCol, double endRow, double endCol, int rectNum, double length1, double length2, string projectColor, string meaRectColor)
        {
            rowBegin = beginRow;
            colBegin = beginCol;
            rowEnd = endRow;
            colEnd = endCol;
            rowMid = (rowBegin + rowEnd) / 2;
            colMid = (colBegin + colEnd) / 2;
            this.rectNum = rectNum;
            this.length1 = length1;
            this.length2 = length2;
            Color = projectColor;
            this.meaRectColor = meaRectColor;

            rowCenter = new double[rectNum];
            colCenter = new double[rectNum];
            phi = new double[rectNum];

            HTuple distance = new HTuple();
            HOperatorSet.DistancePp(rowBegin, colBegin, rowEnd, colEnd, out distance);
            double interval = (distance.D - 2 * length2) / (rowCenter.Length - 1);
            double p = Math.Atan2(-(rowEnd - rowBegin), colEnd - colBegin);
            for (int i = 0; i < rowCenter.Length; i++)
            {
                rowCenter[i] = (rowBegin - length2 * Math.Sin(p)) - i * interval * Math.Sin(p);
                colCenter[i] = (colBegin + length2 * Math.Cos(p)) + i * interval * Math.Cos(p);
                phi[i] = p + Math.PI / 2;
            }
        }

        #endregion

        #region ROI操作相关

        /// <summary>
        /// 在鼠标位置处创建ROI
        /// </summary>
        /// 
        public override void CreateROI(double X, double Y)
        {
            rowBegin = Y;
            colBegin = X;
            rowEnd = Y + 100;
            colEnd = X + 100;
        }

        /// <summary>
        /// 在Halcon窗口绘制ROI
        /// </summary>
        public override void Draw(HWindow window, HObject img)
        {
            HTuple width = new HTuple();
            HTuple height = new HTuple();
            HTuple angle1 = new HTuple();
            double k1 = 0, row = 0, col = 0, k = 0, b = 0;

            HObject rectObj = new HObject();

            HOperatorSet.GetImageSize(img, out width, out height);

            window.SetLineWidth(1.45);
            window.SetColor(meaRectColor);
            window.SetDraw("margin");
            for (int i = 0; i < rowCenter.Length; i++)
            {
                HOperatorSet.GenRectangle2ContourXld(out rectObj, rowCenter[i], colCenter[i], phi[i], length1, length2);
                window.DispXld(new HXLD(rectObj));
            }

            HOperatorSet.AngleLx(rowBegin, colBegin, rowEnd, colEnd, out phiLine);

            window.SetColor(Color);
            window.SetDraw("fill");
            window.DispLine(rowBegin, colBegin, rowEnd, colEnd);

            window.DispRectangle2(rowBegin, colBegin, phiLine.D, (double)width * 0.004, (double)width * 0.004);
            window.DispRectangle2(rowEnd, colEnd, phiLine.D, (double)width * 0.004, (double)width * 0.004);
            window.DispRectangle2(rowMid, colMid, phiLine.D, (double)width * 0.004, (double)width * 0.004);

            //绘制搜索方向
            window.SetColor(Color);
            window.SetDraw("fill");
            HOperatorSet.AngleLx(rowBegin, colBegin, rowEnd, colEnd, out angle1);
            k1 = Math.Tan(angle1);
            k = Math.Tan(angle1 - Math.PI / 2);
            b = -rowMid - k * colMid;

            if (k1 < -1.225E-16 || k1 > 1.225E-16)
            {
                if (angle1 > 0 && angle1 < (Math.PI / 4))
                {
                    row = rowMid + 100;
                    col = (-row - b) / k;
                }
                else if (angle1 > (Math.PI / 4) && angle1 < (Math.PI * 3 / 4))
                {
                    col = colMid + 100;
                    row = -(k * col + b);
                }
                else if (angle1 > (Math.PI * 3 / 4) && angle1 < Math.PI)
                {
                    row = rowMid - 100;
                    col = (-row - b) / k;
                }
                else if (angle1 > -Math.PI && angle1 <= -(Math.PI * 3 / 4))
                {
                    row = rowMid - 100;
                    col = (-row - b) / k;
                }
                else if (angle1 > -(Math.PI * 3 / 4) && angle1 <= -(Math.PI / 4))
                {
                    col = colMid - 100;
                    row = -(k * col + b);
                }
                else if (angle1 > -(Math.PI / 4) && angle1 < 0)
                {
                    row = rowMid + 100;
                    col = (-row - b) / k;
                }

                window.DispArrow(rowMid, colMid, row, col, (double)width * 0.001);
            }
            else
            {
                if (colBegin < colEnd)
                {
                    row = rowMid + 100;
                }
                else
                {
                    row = rowMid - 100;
                }

                col = colMid;
                window.DispArrow(rowMid, colMid, row, col, (double)width * 0.001);
            }
        }

        /// <summary>
        /// 获取ROI信息
        /// </summary> 
        public override HTuple GetModelData()
        {
            HTuple info = new HTuple();
            info.Append(rowBegin);
            info.Append(colBegin);
            info.Append(rowEnd);
            info.Append(colEnd);
            info.Append(rectNum);
            info.Append(length1);
            info.Append(length2);

            return info;
        }

        /// <summary>
        /// 计算鼠标与ROI操作句柄距离,返回激活的句柄ID
        /// </summary>
        /// <param name="x">鼠标X坐标，即Row方向</param>
        /// <param name="y">鼠标Y坐标，即Column方向</param>
        /// <returns>激活的句柄ID</returns>
        public override double DistToClosestHandle(double x, double y)
        {
            double max = 10000;
            double[] val = new double[NumHandles];

            val[0] = HMisc.DistancePp(x, y, colBegin, rowBegin); 
            val[1] = HMisc.DistancePp(x, y, colEnd, rowEnd); 
            val[2] = HMisc.DistancePp(x, y, colMid, rowMid); 

            for (int i = 0; i < NumHandles; i++)
            {
                if (val[i] < max)
                {
                    max = val[i];
                    ActiveHandleId = i;
                }
            }

            return val[ActiveHandleId];
        }

        /// <summary>
        /// 显示激活的操作句柄
        /// </summary>
        /// <param name="window">Halcon窗口</param>
        public override void DisplayActive(HWindow window, HObject img)
        {
            HTuple width = new HTuple();
            HTuple height = new HTuple();
            HOperatorSet.GetImageSize(img, out width, out height);

            switch (ActiveHandleId)
            {
                case 0:
                    window.DispRectangle2(rowBegin, colBegin, phiLine.D, (double)width * 0.004, (double)width * 0.004);
                    break;
                case 1:
                    window.DispRectangle2(rowEnd, colEnd, phiLine.D, (double)width * 0.004, (double)width * 0.004);
                    break;
                case 2:
                    window.DispRectangle2(rowMid, colMid, phiLine.D, (double)width * 0.004, (double)width * 0.004);
                    break;
            }
        }

        /// <summary>
        /// 根据选中的操作句柄执行相关操作
        /// </summary>
        /// <param name="newX">鼠标位置的X坐标，是横向，即Column</param>
        /// <param name="newY">鼠标位置的Y坐标，是纵向，即Row</param>
        public override void moveByHandle(double newX, double newY)
        {
            double diffR, diffC;
            HTuple distance;
            HTuple row, col;
            double interval;
            double p;
            List<double> rowAssem = new List<double>();
            List<double> colAssem = new List<double>();

            try
            {
                switch (ActiveHandleId)
                {
                    case 0:
                        rowBegin = newY;
                        colBegin = newX;

                        rowMid = (rowBegin + rowEnd) / 2;
                        colMid = (colBegin + colEnd) / 2;

                        p = Math.Atan2(-(rowEnd - rowBegin), colEnd - colBegin);
                        HOperatorSet.DistancePp(rowBegin, colBegin, rowEnd, colEnd, out distance);
                        interval = (distance.D - 2 * length2) / (rowCenter.Length - 1);

                        for (int i = 0; i < rowCenter.Length; i++)
                        {
                            row = (rowBegin - length2 * Math.Sin(p)) - i * interval * Math.Sin(p);
                            col = (colBegin + length2 * Math.Cos(p)) + i * interval * Math.Cos(p);
                            rowCenter[i] = row;
                            colCenter[i] = col;
                            phi[i] = p + Math.PI / 2;
                        }
                        break;
                    case 1:
                        rowEnd = newY;
                        colEnd = newX;

                        rowMid = (rowBegin + rowEnd) / 2;
                        colMid = (colBegin + colEnd) / 2;

                        p = Math.Atan2(-(rowEnd - rowBegin), colEnd - colBegin);
                        HOperatorSet.DistancePp(rowBegin, colBegin, rowEnd, colEnd, out distance);
                        interval = (distance.D - 2 * length2) / (rowCenter.Length - 1);

                        for (int i = 0; i < rowCenter.Length; i++)
                        {
                            row = (rowEnd + length2 * Math.Sin(p)) + i * interval * Math.Sin(p);
                            col = (colEnd - length2 * Math.Cos(p)) - i * interval * Math.Cos(p);
                            rowCenter[i] = row;
                            colCenter[i] = col;
                            phi[i] = p + Math.PI / 2;
                        }
                        break;
                    case 2:
                        diffR = newY - rowMid;
                        diffC = newX - colMid;

                        rowMid = newY;
                        colMid = newX;

                        rowBegin = rowBegin + diffR;
                        colBegin = colBegin + diffC;
                        rowEnd = rowEnd + diffR;
                        colEnd = colEnd + diffC;

                        for (int i = 0; i < rowCenter.Length; i++)
                        {
                            rowCenter[i] = rowCenter[i] + diffR;
                            colCenter[i] = colCenter[i] + diffC;
                        }
                        break;
                }
            }
            catch(Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
       }

        public object Clone()
        {
            return this.MemberwiseClone();
        }

        #endregion
    }
}
