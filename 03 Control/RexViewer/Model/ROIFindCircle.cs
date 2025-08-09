using HalconDotNet;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RexView.Model
{
    public class ROIFindCircle:ROI
    {
        #region 字段、属性

        /// <summary>
        /// 投影圆起始角度(弧度)
        /// </summary>
        public double startAngle;

        /// <summary>
        /// 投影圆终止角度(弧度)
        /// </summary>
        public double endAngle;

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
        /// 投影圆中点Row
        /// </summary>
        public double rowMid;

        /// <summary>
        /// 投影圆中点Col
        /// </summary>
        public double colMid;

        /// <summary>
        /// 半径
        /// </summary>
        public double radius;

        /// <summary>
        /// 方向
        /// </summary>
        public string pointOrder;

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
        /// 起始点与第一个测量矩形的角度间距
        /// </summary>
        public double gap;

        #endregion

        #region 初始化

        /// <summary>
        /// 初始化
        /// </summary>
        public ROIFindCircle()
        {
            NumHandles = 4;
            ActiveHandleId = 1;
        }

        /// <summary>
        /// 初始化
        /// </summary>
        /// <param name="row"></param>
        /// <param name="col"></param>
        /// <param name="Radius"></param>
        public ROIFindCircle(double row, double col, double Radius, double startAngle, double endAngle, string pointOrder, int rectNum, double length1,double length2, string projectColor, string meaRectColor)
        {
            CreateFindCircle(row, col, Radius, startAngle, endAngle, pointOrder, rectNum, length1, length2, projectColor, meaRectColor);
        }

        #endregion

        #region ROI操作相关

        /// <summary>
        /// 初始化-创建找圆
        /// </summary>
        /// <param name="row"></param>
        /// <param name="col"></param>
        /// <param name="radius"></param>
        /// <param name="startAngle"></param>
        /// <param name="endAngle"></param>
        /// <param name="pointOrder"></param>
        /// <param name="rowCenter"></param>
        /// <param name="colCenter"></param>
        /// <param name="phi"></param>
        /// <param name="length1"></param>
        /// <param name="length2"></param>
        /// <param name="projectColor"></param>
        /// <param name="meaRectColor"></param>
        public override void CreateFindCircle(double row, double col, double radius, double startAngle, double endAngle, string pointOrder, int rectNum, double length1, double length2, string projectColor, string meaRectColor)
        {
            midR = row;
            midC = col;
            this.radius = radius;
            this.startAngle = startAngle;
            this.endAngle = endAngle;
            this.pointOrder = pointOrder;
            this.rectNum = rectNum;
            this.length1 = length1;
            this.length2 = length2;
            Color = projectColor;
            this.meaRectColor = meaRectColor;
            rowBegin = midR - radius * Math.Sin(startAngle);
            colBegin = midC + radius * Math.Cos(startAngle);
            rowEnd = midR - radius * Math.Sin(endAngle);
            colEnd = midC + radius * Math.Cos(endAngle);
            rowMid = midR - radius * Math.Sin(startAngle + (endAngle - startAngle) / 2);
            colMid = midC + radius * Math.Cos(startAngle + (endAngle - startAngle) / 2);
            gap = Math.Asin(length2 / radius);

            rowCenter = new double[rectNum];
            colCenter = new double[rectNum];
            phi = new double[rectNum];
            double interval = (endAngle - startAngle - 2 * gap) / (rectNum - 1);
            for (int i = 0; i < rectNum; i++)
            {
                rowCenter[i] = midR - radius * Math.Sin(startAngle + gap + i * interval);
                colCenter[i] = midC + radius * Math.Cos(startAngle + gap + i * interval);
                phi[i] = Math.Atan(-(rowCenter[i] - midR) / (colCenter[i] - midC));
            }
        }

        /// <summary>
        /// 在Halcon窗口绘制ROI
        /// </summary>
        /// <param name="window"></param>
        public override void Draw(HWindow window, HObject img)
        {
            HTuple width = new HTuple();
            HTuple height = new HTuple();
            HTuple isOverlap = new HTuple();

            HObject rectObj = new HObject();
            HObject circleXld = new HObject();
            HObject lineXld = new HObject();

            HOperatorSet.GetImageSize(img, out width, out height);

            window.SetLineWidth(1.45);
            window.SetColor(meaRectColor);
            window.SetDraw("margin");
            for (int i = 0; i < rowCenter.Length; i++)
            {
                HOperatorSet.GenRectangle2ContourXld(out rectObj, rowCenter[i], colCenter[i], phi[i], length1, length2);
                window.DispXld(new HXLD(rectObj));
            }

            window.SetColor(Color);
            window.SetDraw("margin");
            HOperatorSet.GenCircleContourXld(out circleXld, midR, midC, radius, startAngle, endAngle, pointOrder, 1.0);
            window.DispXld(new HXLD(circleXld));

            double searchEndRow = midR - (radius + 100) * Math.Sin(startAngle + (endAngle - startAngle) / 2);
            double searchEndCol = midC + (radius + 100) * Math.Cos(startAngle + (endAngle - startAngle) / 2);

            window.SetColor(Color);
            window.SetDraw("fill");
            window.DispRectangle2(midR, midC, startAngle + (endAngle - startAngle) / 2, (double)width * 0.004, (double)width * 0.004);
            window.DispRectangle2(rowBegin, colBegin, startAngle, (double)width * 0.004, (double)width * 0.004);
            window.DispRectangle2(rowEnd, colEnd, endAngle, (double)width * 0.004, (double)width * 0.004);
            window.DispRectangle2(rowMid, colMid, startAngle + (endAngle - startAngle) / 2, (double)width * 0.004, (double)width * 0.004);

            window.DispLine(midR, midC, rowBegin, colBegin);
            window.DispLine(midR, midC, rowEnd, colEnd);
            window.DispArrow(midR, midC, (double)searchEndRow, (double)searchEndCol, (double)width * 0.001);
        }

        /// <summary>
        /// 获取ROI信息
        /// </summary> 
        public override HTuple GetModelData()
        {
            HTuple info = new HTuple();
            info.Append(midR);
            info.Append(midC);
            info.Append(radius);
            info.Append(startAngle);
            info.Append(endAngle);
            info.Append(pointOrder);
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

            val[0] = HMisc.DistancePp(x, y, midC, midR);
            val[1] = HMisc.DistancePp(x, y, colBegin, rowBegin);
            val[2] = HMisc.DistancePp(x, y, colEnd, rowEnd);
            val[3] = HMisc.DistancePp(x, y, colMid, rowMid);

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
                    window.DispRectangle2(midR, midC, startAngle + (endAngle - startAngle) / 2, (double)width * 0.004, (double)width * 0.004);
                    break;
                case 1:
                    window.DispRectangle2(rowBegin, colBegin, startAngle, (double)width * 0.004, (double)width * 0.004);
                    break;
                case 2:
                    window.DispRectangle2(rowEnd, colEnd, endAngle, (double)width * 0.004, (double)width * 0.004);
                    break;
                case 3:
                    window.DispRectangle2(rowMid, colMid, startAngle + (endAngle - startAngle) / 2, (double)width * 0.004, (double)width * 0.004);
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
            double interval;
            HTuple angle = new HTuple();
            HTuple firstRectA = new HTuple();
            HTuple mat2D = new HTuple();
            HTuple rowRotate = new HTuple();
            HTuple colRotate = new HTuple();

            switch (ActiveHandleId)
            {
                case 0:
                    diffR = newY - midR;
                    diffC = newX - midC;

                    midR = newY;
                    midC = newX;

                    rowBegin = rowBegin + diffR;
                    colBegin = colBegin + diffC;
                    rowEnd = rowEnd + diffR;
                    colEnd = colEnd + diffC;
                    rowMid = rowMid + diffR;
                    colMid = colMid + diffC;

                    for (int i = 0; i < rowCenter.Length; i++)
                    {
                        rowCenter[i] = rowCenter[i] + diffR;
                        colCenter[i] = colCenter[i] + diffC;
                    }
                    break;
                case 1:
                    HOperatorSet.AngleLx(midR, midC, newY, newX, out angle);
                    if (angle < 0) angle = angle + 2 * Math.PI;
                    HOperatorSet.VectorAngleToRigid(midR, midC, 0, midR, midC, angle - startAngle, out mat2D);
                    HOperatorSet.AffineTransPoint2d(mat2D, rowBegin, colBegin, out rowRotate, out colRotate);
                    if (angle > endAngle) angle = angle - 2 * Math.PI;
                    startAngle = angle;
                    if (endAngle - startAngle >= 2 * Math.PI) endAngle = endAngle - 2 * Math.PI;
                    rowBegin = rowRotate;
                    colBegin = colRotate;
                    rowMid = midR - radius * Math.Sin(startAngle + (endAngle - startAngle) / 2);
                    colMid = midC + radius * Math.Cos(startAngle + (endAngle - startAngle) / 2);
                    gap = Math.Asin(length2 / radius);
                    interval = (endAngle - startAngle - 2 * gap) / (rowCenter.Length - 1);
                    for (int i = 0; i < rowCenter.Length; i++)
                    {
                        rowCenter[i] = midR - radius * Math.Sin(startAngle + gap + i * interval);
                        colCenter[i] = midC + radius * Math.Cos(startAngle + gap + i * interval);
                        phi[i] = Math.Atan(-(rowCenter[i] - midR) / (colCenter[i] - midC));
                    }
                    break;
                case 2:
                    HOperatorSet.AngleLx(midR, midC, newY, newX, out angle);
                    if (angle < 0) angle = angle + 2 * Math.PI;
                    HOperatorSet.VectorAngleToRigid(midR, midC, 0, midR, midC, angle - endAngle, out mat2D);
                    HOperatorSet.AffineTransPoint2d(mat2D, rowEnd, colEnd, out rowRotate, out colRotate);
                    if (angle < startAngle) angle = angle + 2 * Math.PI;
                    endAngle = angle;
                    if (endAngle - startAngle >= 2 * Math.PI) endAngle = endAngle - 2 * Math.PI;
                    rowEnd = rowRotate;
                    colEnd = colRotate;
                    rowMid = midR - radius * Math.Sin(startAngle + (endAngle - startAngle) / 2);
                    colMid = midC + radius * Math.Cos(startAngle + (endAngle - startAngle) / 2);
                    gap = Math.Asin(length2 / radius);
                    interval = (endAngle - startAngle - 2 * gap) / (rowCenter.Length - 1);
                    for (int i = 0; i < rowCenter.Length; i++)
                    {
                        rowCenter[i] = midR - radius * Math.Sin(startAngle + gap + i * interval);
                        colCenter[i] = midC + radius * Math.Cos(startAngle + gap + i * interval);
                        phi[i] = Math.Atan(-(rowCenter[i] - midR) / (colCenter[i] - midC));
                    }
                    break;
                case 3:
                    HTuple projRow = new HTuple();
                    HTuple projCol = new HTuple();

                    HOperatorSet.ProjectionPl(newY, newX, midR, midC, rowMid, colMid, out projRow, out projCol);
                    double r = Math.Sqrt((midR - projRow) * (midR - projRow) + (midC - projCol) * (midC - projCol));
                    double rMid = midR - r * Math.Sin(startAngle + (endAngle - startAngle) / 2);
                    double cMid = midC + r * Math.Cos(startAngle + (endAngle - startAngle) / 2);
                    if (rMid == projRow && cMid == projCol)
                    {
                        radius = r;
                        rowBegin = midR - radius * Math.Sin(startAngle);
                        colBegin = midC + radius * Math.Cos(startAngle);
                        rowEnd = midR - radius * Math.Sin(endAngle);
                        colEnd = midC + radius * Math.Cos(endAngle);
                        rowMid = rMid;
                        colMid = cMid;
                        gap = Math.Asin(length2 / radius);
                        interval = (endAngle - startAngle - 2 * gap) / (rowCenter.Length - 1);
                        for (int i = 0; i < rowCenter.Length; i++)
                        {
                            rowCenter[i] = midR - radius * Math.Sin(startAngle + gap + i * interval);
                            colCenter[i] = midC + radius * Math.Cos(startAngle + gap + i * interval);
                            phi[i] = Math.Atan(-(rowCenter[i] - midR) / (colCenter[i] - midC));
                        }
                    }
                    break;
            }
        }

        /// <summary>
        /// 浅拷贝
        /// </summary>
        /// <returns></returns>
        public object Clone()
        {
            return MemberwiseClone();
        }

        #endregion
    }
}
