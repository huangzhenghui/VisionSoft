using System;
using HalconDotNet;
using System.Xml.Serialization;
using System.ComponentModel;

namespace RexView
{
    /// <summary>
    /// ROI-Circle类
    /// </summary>
    [Serializable]
    public class ROICircle : ROI
    {
        #region 字段、属性



        /// <summary>
        /// 方向
        /// </summary>
        public string PointOrder = "positive";

        /// <summary>
        /// 半径
        /// </summary>
        public double Radius;

        /// <summary>
        /// 缩放操作句柄Row
        /// </summary>
        public double ScaleRow;

        /// <summary>
        /// 缩放操作句柄Column
        /// </summary>
        public double ScaleCol;

        #endregion

        #region 初始化

        /// <summary>
        /// 初始化
        /// </summary>
        public ROICircle()
        {
            NumHandles = 2;
            ActiveHandleId = 1;
        }

        /// <summary>
        /// 初始化
        /// </summary>
        /// <param name="row"></param>
        /// <param name="col"></param>
        /// <param name="Radius"></param>
        public ROICircle(double row, double col, double Radius, string color)
        {
            CreateCircle(row, col, Radius, color);
        }

        #endregion

        #region ROI操作相关

        /// <summary>
        /// 创建Circle区域及操作句柄
        /// </summary>
        /// <param name="row">圆心Row</param>
        /// <param name="col">圆心Colnum</param>
        /// <param name="Radius">半径</param>
        public override void CreateCircle(double row, double col, double Radius, string color)
        {
            midR = row;
            midC = col;
            this.Radius = Radius;
            ScaleRow = midR;
            ScaleCol = midC + Radius;
            Color = color;
        }

        /// <summary>
        /// 在鼠标位置处创建Circle区域及操作句柄
        /// </summary>
        /// <param name="midX"></param>
        /// <param name="midY"></param>
        public override void CreateROI(double midX, double midY)
        {
            midR = midY;
            midC = midX;
            Radius = 100;
            ScaleRow = midR;
            ScaleCol = midC + Radius;
        }

        /// <summary>
        /// 在窗体中绘制ROI区域
        /// </summary>
        /// <param name="window"></param>
        public override void Draw(HWindow window, HObject hObj)
        {
            HTuple width = new HTuple();
            HTuple height = new HTuple();
            HOperatorSet.GetImageSize(hObj, out width, out height);

            //检测区域
            window.SetColor(Color);
            window.SetDraw("margin");
            window.DispCircle(midR, midC, Radius);
            window.SetDraw("fill");
            window.DispRectangle2(ScaleRow, ScaleCol, 0, (double)width * 0.005, (double)width * 0.005);
            window.DispRectangle2(midR, midC, 0, (double)width * 0.005, (double)width * 0.005);
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

            val[0] = HMisc.DistancePp(x, y, ScaleCol, ScaleRow); 
            val[1] = HMisc.DistancePp(x, y, midC, midR);

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
        public override void DisplayActive(HWindow window,HObject hObj)
        {
            HTuple width = new HTuple();
            HTuple height = new HTuple();
            HOperatorSet.GetImageSize(hObj, out width, out height);

            switch (ActiveHandleId)
            {
                case 0:
                    window.DispRectangle2(ScaleRow, ScaleCol, 0, (double)width * 0.005, (double)width * 0.005);
                    break;
                case 1:
                    window.DispRectangle2(midR, midC, 0, (double)width * 0.005, (double)width * 0.005);
                    break;
            }
        }

        /// <summary>
        /// 获取ROI区域
        /// </summary>
        /// <returns></returns>
        public override HRegion GetRegion()
        {
            HRegion region = new HRegion();
            region.GenCircle(midR, midC, Radius);
            return region;
        }

        /// <summary>
        /// 获取XLD轮廓
        /// </summary>
        /// <returns></returns>
        public override HXLDCont GetXLD()
        {
            ScaleRow = midR;
            ScaleCol = midC + Radius;
            HXLDCont xld = new HXLDCont();
            xld.GenCircleContourXld(midR, midC, Radius, 0, 2*Math.PI, PointOrder, 1.0);
            return xld;
        }

        /// <summary>
        /// 获取ROI信息
        /// </summary>
        /// <returns></returns>
        public override HTuple GetModelData()
        {
            return new HTuple(new double[] { midR, midC, Radius });
        }

        /// <summary>
        /// 根据选中的操作句柄执行相关操作
        /// </summary>
        /// <param name="newX">鼠标位置的X坐标，是横向，即Column</param>
        /// <param name="newY">鼠标位置的Y坐标，是纵向，即Row</param>
        public override void moveByHandle(double newX, double newY)
        {
            HTuple distance;
            double shiftRow, shiftCol;

            switch (ActiveHandleId)
            {
                case 0:
                    ScaleCol = newX;
                    HOperatorSet.DistancePp(new HTuple(ScaleCol), new HTuple(ScaleRow),
                                            new HTuple(midC), new HTuple(midR),
                                            out distance);
                    Radius = distance[0].D;
                    break;
                case 1:
                    shiftRow = midR - newY;
                    shiftCol = midC - newX;

                    midC = newX;
                    midR = newY;

                    ScaleRow -= shiftRow;
                    ScaleCol -= shiftCol;
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
