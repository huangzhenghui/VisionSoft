using System;
using HalconDotNet;
using System.Xml.Serialization;
using System.ComponentModel;

namespace RexView
{
    /// <summary>
    /// ROI-Rectangle2类
    /// </summary>
    [Serializable]
    public class ROIRectangle2 : ROI
    {
        #region 字段、属性

        /// <summary>
        /// 角度(弧度制)
        /// </summary>
        public double phi;

        /// <summary>
        /// 长半轴
        /// </summary>
        public double length1;

        /// <summary>
        /// 短半轴
        /// </summary>
        public double length2;

        /// <summary>
        /// 操作句柄变换前Row初始值
        /// </summary>
        HTuple rowsInit;

        /// <summary>
        /// Column变换前初始值
        /// </summary>
        HTuple colsInit;

        /// <summary>
        /// Row变换后值
        /// </summary>
        HTuple rows;

        /// <summary>
        /// Column变换后值
        /// </summary>
        HTuple cols;

        #endregion

        #region 初始化

        /// <summary>
        /// 初始化
        /// </summary>
        public ROIRectangle2()
        {
            NumHandles = 6;		
            ActiveHandleId = 4;
        }

        /// <summary>
        /// 初始化
        /// </summary>
        /// <param name="row"></param>
        /// <param name="col"></param>
        /// <param name="phi"></param>
        /// <param name="length1"></param>
        /// <param name="length2"></param>
        public ROIRectangle2(double row, double col, double phi, double length1, double length2, string color)
        {
            CreateRectangle2(row, col, phi, length1, length2, color);
        }

        #endregion

        #region ROI操作相关

        /// <summary>
        /// 创建Rect2区域及操作句柄
        /// </summary>
        /// <param name="row"></param>
        /// <param name="col"></param>
        /// <param name="phi"></param>
        /// <param name="length1"></param>
        /// <param name="length2"></param>
        public override void CreateRectangle2(double row, double col, double phi, double length1, double length2, string color)
        {
            midR = row;
            midC = col;
            this.length1 = length1;
            this.length2 = length2;
            this.phi = phi;
            Color = color;
            rowsInit = new HTuple(new double[] { -1.0, -1.0, 1.0, 1.0, 0.0, 0.0 });
            colsInit = new HTuple(new double[] { -1.0, 1.0, -1.0, 1.0, 0.0, 0.6 });

            updateHandlePos();
        }

        /// <summary>
        /// 在窗体中绘制ROI操作句柄
        /// </summary>
        /// <param name="window">窗体</param>
        /// <param name="hObj">图像</param>
        public override void Draw(HWindow window, HObject img)
        {
            HTuple width = new HTuple();
            HTuple height = new HTuple();
            HOperatorSet.GetImageSize(img, out width, out height);

            //检测区域
            window.SetColor(Color);
            window.SetDraw("margin");
            window.DispRectangle2(midR, midC, phi, length1, length2);
            window.SetDraw("fill");

            //操作区域
            for (int i = 0; i < NumHandles; i++)
            {
                window.DispRectangle2(rows[i].D, cols[i].D, phi, (double)width * 0.005, (double)width * 0.005);
            }
            window.DispArrow(midR, midC, midR - (Math.Sin(phi) * length1 * 1.15), midC + (Math.Cos(phi) * length1 * 1.15), (double)width * 0.001);
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

            for (int i = 0; i < NumHandles; i++)
                val[i] = HMisc.DistancePp(y, x, rows[i].D, cols[i].D);

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

            window.DispRectangle2(rows[ActiveHandleId].D, cols[ActiveHandleId].D, phi, (double)width * 0.005, (double)width * 0.005);

            if (ActiveHandleId == 5)
            {
                window.DispArrow(midR, midC, midR - (Math.Sin(phi) * length1 * 1.15), midC + (Math.Cos(phi) * length1 * 1.15), (double)width * 0.001);
            }
        }

        /// <summary>
        /// 获取ROI区域
        /// </summary>
        public override HRegion GetRegion()
        {
            HRegion region = new HRegion();
            region.GenRectangle2(midR, midC, phi, length1, length2);
            return region;
        }

        /// <summary>
        /// 获取XLD轮廓
        /// </summary>
        /// <returns></returns>
        public override HXLDCont GetXLD()
        {
            HXLDCont xld = new HXLDCont();
            xld.GenRectangle2ContourXld(midR, midC, phi, length1, length2);
            return xld;
        }

        /// <summary>
        /// 获取ROI信息
        /// </summary>
        /// <returns></returns>
        public override HTuple GetModelData()
        {
            return new HTuple(new double[] { midR, midC, phi, length1, length2 });
        }

        /// <summary>
        /// 根据选中的操作句柄执行相关操作
        /// </summary>
        /// <param name="newX">鼠标位置的X坐标，是横向，即Column</param>
        /// <param name="newY">鼠标位置的Y坐标，是纵向，即Row</param>
        public override void moveByHandle(double newX, double newY)
        {
            double vRow, vCol;

            switch (ActiveHandleId)
            {
                case 0:
                case 1:
                case 2:
                case 3:
                    HTuple l2;
                    double distPP = Math.Sqrt((newX - midC) * (newX - midC) + (newY - midR) * (newY - midR));
                    HOperatorSet.DistancePl(newY, newX, midR, midC, rows[5], cols[5], out l2);
                    length2 = l2;
                    length1 = Math.Sqrt(distPP * distPP - length2 * length2);
                    break;
                case 4:
                    midR = newY;
                    midC = newX;
                    break;
                case 5:
                    vRow = newY - rows[4].D;
                    vCol = newX - cols[4].D;
                    phi = Math.Atan2(-vRow,vCol);
                    break;
            }
            updateHandlePos();
        }

        /// <summary>
        /// 更新操作句柄位置
        /// </summary>
        private void updateHandlePos()
        {
            HTuple hHom2D = new HTuple();

            //声明2D矩阵
            HOperatorSet.HomMat2dIdentity(out hHom2D);

            //平移
            HOperatorSet.HomMat2dTranslate(hHom2D, midR, midC, out hHom2D);

            //旋转
            HOperatorSet.HomMat2dRotateLocal(hHom2D, phi, out hHom2D);

            //缩放
            HOperatorSet.HomMat2dScaleLocal(hHom2D, length2, length1, out hHom2D);

            //执行
            HOperatorSet.AffineTransPoint2d(hHom2D, rowsInit, colsInit, out rows, out cols);
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
