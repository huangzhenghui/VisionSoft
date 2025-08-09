using System;
using HalconDotNet;
using System.Xml.Serialization;
using System.ComponentModel;

namespace RexView
{
    /// <summary>
    /// ROI-Rectangle2��
    /// </summary>
    [Serializable]
    public class ROIRectangle2 : ROI
    {
        #region �ֶΡ�����

        /// <summary>
        /// �Ƕ�(������)
        /// </summary>
        public double phi;

        /// <summary>
        /// ������
        /// </summary>
        public double length1;

        /// <summary>
        /// �̰���
        /// </summary>
        public double length2;

        /// <summary>
        /// ��������任ǰRow��ʼֵ
        /// </summary>
        HTuple rowsInit;

        /// <summary>
        /// Column�任ǰ��ʼֵ
        /// </summary>
        HTuple colsInit;

        /// <summary>
        /// Row�任��ֵ
        /// </summary>
        HTuple rows;

        /// <summary>
        /// Column�任��ֵ
        /// </summary>
        HTuple cols;

        #endregion

        #region ��ʼ��

        /// <summary>
        /// ��ʼ��
        /// </summary>
        public ROIRectangle2()
        {
            NumHandles = 6;		
            ActiveHandleId = 4;
        }

        /// <summary>
        /// ��ʼ��
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

        #region ROI�������

        /// <summary>
        /// ����Rect2���򼰲������
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
        /// �ڴ����л���ROI�������
        /// </summary>
        /// <param name="window">����</param>
        /// <param name="hObj">ͼ��</param>
        public override void Draw(HWindow window, HObject img)
        {
            HTuple width = new HTuple();
            HTuple height = new HTuple();
            HOperatorSet.GetImageSize(img, out width, out height);

            //�������
            window.SetColor(Color);
            window.SetDraw("margin");
            window.DispRectangle2(midR, midC, phi, length1, length2);
            window.SetDraw("fill");

            //��������
            for (int i = 0; i < NumHandles; i++)
            {
                window.DispRectangle2(rows[i].D, cols[i].D, phi, (double)width * 0.005, (double)width * 0.005);
            }
            window.DispArrow(midR, midC, midR - (Math.Sin(phi) * length1 * 1.15), midC + (Math.Cos(phi) * length1 * 1.15), (double)width * 0.001);
        }

        /// <summary>
        /// ���������ROI�����������,���ؼ���ľ��ID
        /// </summary>
        /// <param name="x">���X���꣬��Row����</param>
        /// <param name="y">���Y���꣬��Column����</param>
        /// <returns>����ľ��ID</returns>
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
        /// ��ʾ����Ĳ������
        /// </summary>
        /// <param name="window">Halcon����</param>
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
        /// ��ȡROI����
        /// </summary>
        public override HRegion GetRegion()
        {
            HRegion region = new HRegion();
            region.GenRectangle2(midR, midC, phi, length1, length2);
            return region;
        }

        /// <summary>
        /// ��ȡXLD����
        /// </summary>
        /// <returns></returns>
        public override HXLDCont GetXLD()
        {
            HXLDCont xld = new HXLDCont();
            xld.GenRectangle2ContourXld(midR, midC, phi, length1, length2);
            return xld;
        }

        /// <summary>
        /// ��ȡROI��Ϣ
        /// </summary>
        /// <returns></returns>
        public override HTuple GetModelData()
        {
            return new HTuple(new double[] { midR, midC, phi, length1, length2 });
        }

        /// <summary>
        /// ����ѡ�еĲ������ִ����ز���
        /// </summary>
        /// <param name="newX">���λ�õ�X���꣬�Ǻ��򣬼�Column</param>
        /// <param name="newY">���λ�õ�Y���꣬�����򣬼�Row</param>
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
        /// ���²������λ��
        /// </summary>
        private void updateHandlePos()
        {
            HTuple hHom2D = new HTuple();

            //����2D����
            HOperatorSet.HomMat2dIdentity(out hHom2D);

            //ƽ��
            HOperatorSet.HomMat2dTranslate(hHom2D, midR, midC, out hHom2D);

            //��ת
            HOperatorSet.HomMat2dRotateLocal(hHom2D, phi, out hHom2D);

            //����
            HOperatorSet.HomMat2dScaleLocal(hHom2D, length2, length1, out hHom2D);

            //ִ��
            HOperatorSet.AffineTransPoint2d(hHom2D, rowsInit, colsInit, out rows, out cols);
        }

        /// <summary>
        /// ǳ����
        /// </summary>
        /// <returns></returns>
        public object Clone()
        {
            return MemberwiseClone();
        }

        #endregion
    }
}
