using System;
using HalconDotNet;
using System.Xml.Serialization;
using System.ComponentModel;

namespace RexView
{
    /// <summary>
    /// ROI-Circle��
    /// </summary>
    [Serializable]
    public class ROICircle : ROI
    {
        #region �ֶΡ�����



        /// <summary>
        /// ����
        /// </summary>
        public string PointOrder = "positive";

        /// <summary>
        /// �뾶
        /// </summary>
        public double Radius;

        /// <summary>
        /// ���Ų������Row
        /// </summary>
        public double ScaleRow;

        /// <summary>
        /// ���Ų������Column
        /// </summary>
        public double ScaleCol;

        #endregion

        #region ��ʼ��

        /// <summary>
        /// ��ʼ��
        /// </summary>
        public ROICircle()
        {
            NumHandles = 2;
            ActiveHandleId = 1;
        }

        /// <summary>
        /// ��ʼ��
        /// </summary>
        /// <param name="row"></param>
        /// <param name="col"></param>
        /// <param name="Radius"></param>
        public ROICircle(double row, double col, double Radius, string color)
        {
            CreateCircle(row, col, Radius, color);
        }

        #endregion

        #region ROI�������

        /// <summary>
        /// ����Circle���򼰲������
        /// </summary>
        /// <param name="row">Բ��Row</param>
        /// <param name="col">Բ��Colnum</param>
        /// <param name="Radius">�뾶</param>
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
        /// �����λ�ô�����Circle���򼰲������
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
        /// �ڴ����л���ROI����
        /// </summary>
        /// <param name="window"></param>
        public override void Draw(HWindow window, HObject hObj)
        {
            HTuple width = new HTuple();
            HTuple height = new HTuple();
            HOperatorSet.GetImageSize(hObj, out width, out height);

            //�������
            window.SetColor(Color);
            window.SetDraw("margin");
            window.DispCircle(midR, midC, Radius);
            window.SetDraw("fill");
            window.DispRectangle2(ScaleRow, ScaleCol, 0, (double)width * 0.005, (double)width * 0.005);
            window.DispRectangle2(midR, midC, 0, (double)width * 0.005, (double)width * 0.005);
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
        /// ��ʾ����Ĳ������
        /// </summary>
        /// <param name="window">Halcon����</param>
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
        /// ��ȡROI����
        /// </summary>
        /// <returns></returns>
        public override HRegion GetRegion()
        {
            HRegion region = new HRegion();
            region.GenCircle(midR, midC, Radius);
            return region;
        }

        /// <summary>
        /// ��ȡXLD����
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
        /// ��ȡROI��Ϣ
        /// </summary>
        /// <returns></returns>
        public override HTuple GetModelData()
        {
            return new HTuple(new double[] { midR, midC, Radius });
        }

        /// <summary>
        /// ����ѡ�еĲ������ִ����ز���
        /// </summary>
        /// <param name="newX">���λ�õ�X���꣬�Ǻ��򣬼�Column</param>
        /// <param name="newY">���λ�õ�Y���꣬�����򣬼�Row</param>
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
