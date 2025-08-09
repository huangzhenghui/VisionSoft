using System;
using System.Collections.Generic;
using System.ComponentModel;
using HalconDotNet;

namespace RexView
{
    /// <summary>
    ///���ROI����һ������
    /// </summary>    
    [Serializable]
    public class ROI
    {
        #region �ֶΡ�����

        /// <summary>
        /// ROI��ɫ 
        /// </summary>
        [Description("ROI��ɫ")]
        public string Color = "yellow";

        /// <summary>
        /// ����������ɫ 
        /// </summary>
        [Description("ROI��ɫ")]
        public string meaRectColor = "cyan";

        /// <summary> 
        /// ROI����
        /// </summary>
        [Description("ROI����")]
        public ROIType Type;

        /// <summary>
        /// ���ĵ�Row����
        /// </summary>
        [Description("���ĵ�Row")]
        public double midR;

        /// <summary>
        /// ���ĵ�Column����
        /// </summary>
        [Description("���ĵ�Column")]
        public double midC;

        /// <summary>
        /// ���������Ŀ
        /// </summary>
        [Description("���������Ŀ")]
        protected int NumHandles;

        /// <summary>
        /// ����������
        /// </summary>
        [Description("����������")]
        protected int ActiveHandleId;

        /// <summary>
        /// ROI������ʽ
        /// </summary>
        [Description("ROI������ʽ")]
        public HTuple FlagLineStyle;

        /// <summary>
        /// ����Ϊ��ROI��־
        /// </summary>
        [Description("��ROI��־")]
        public const int POSITIVE_FLAG = HWndCtrl.MODE_ROI_POS;

        /// <summary>
        /// ����Ϊ��ROI��־
        /// </summary>
        [Description("��ROI��־")]
        public const int NEGATIVE_FLAG = HWndCtrl.MODE_ROI_NEG;

        /// <summary> 
        /// ��Ƕ���ROIΪ�������򡰸���
        /// </summary>
        [Description("ROI����")]
        protected int OperatorFlag;

        /// <summary> 
        /// "+"��ʽ��ֱ�� 
        /// </summary>
        [Description(" + ��ʽ��ֱ�� ")]
        protected HTuple posOperation = new HTuple();

        /// <summary> 
        /// "-"��ʽ������
        /// </summary>
        [Description(" - ��ʽ��ֱ��")]
        protected HTuple negOperation = new HTuple(new int[] { 2, 2 });

        #endregion

        #region ROI�������

        /// <summary>
        /// ����ֱ��
        /// </summary>
        /// <param name="beginRow"></param>
        /// <param name="beginCol"></param>
        /// <param name="endRow"></param>
        /// <param name="endCol"></param>
        public virtual void CreateLine(double beginRow, double beginCol, double endRow, double endCol) { }

        /// <summary>
        /// ����������
        /// </summary>
        /// <param name="beginRow"></param>
        /// <param name="beginCol"></param>
        /// <param name="endRow"></param>
        /// <param name="endCol"></param>
        public virtual void CreateCoordLine(double beginRow, double beginCol, double endRow, double endCol) { }

        /// <summary>
        /// ����Բ
        /// </summary>
        /// <param name="row"></param>
        /// <param name="col"></param>
        /// <param name="radius"></param>
        public virtual void CreateCircle(double row, double col, double radius, string color) { }

        /// <summary>
        /// ����Բ��
        /// </summary>
        /// <param name="row"></param>
        /// <param name="col"></param>
        /// <param name="radius"></param>
        public virtual void CreateCircleAre(double row, double col, double radius) { }

        /// <summary>
        /// ������Բģ��
        /// </summary>
        /// <param name="row"></param>
        /// <param name="col"></param>
        /// <param name="radius"></param>
        /// <param name="hObj"></param>
        public virtual void CreateFindCircle(double row, double col, double radius, double startAngle, double endAngle, string pointOrder, int rectNum, double length1, double length2, string projectColor, string meaRectColor) { }

        /// <summary>
        /// ��������ģ��
        /// </summary>
        /// <param name="row"></param>
        /// <param name="col"></param>
        /// <param name="radius"></param>
        /// <param name="hObj"></param>
        public virtual void CreateFindLine(double rowBeign, double colBeign, double rowEnd, double colEnd, int rectNum, double length1, double length2, string projectColor, string meaRectColor) { }

        /// <summary>
        /// ��������Rect1
        /// </summary>
        /// <param name="row1"></param>
        /// <param name="col1"></param>
        /// <param name="row2"></param>
        /// <param name="col2"></param>
        public virtual void CreateRectangle1(double row1, double col1, double row2, double col2, string color) { }

        /// <summary>
        /// ��������Rect2
        /// </summary>
        /// <param name="row"></param>
        /// <param name="col"></param>
        /// <param name="phi"></param>
        /// <param name="length1"></param>
        /// <param name="length2"></param>
        public virtual void CreateRectangle2(double row, double col, double phi, double length1, double length2, string color) { }

        /// <summary>
        /// ������
        /// </summary>
        /// <param name="row"></param>
        /// <param name="col"></param>
        public virtual void CreatePoint(double row, double col) { }

        /// <summary>
        /// �����λ�ô���һ���µ�ROI����
        /// </summary>
        public virtual void CreateROI(double midX, double midY) { }

        /// <summary>
        /// ��ROI���Ƶ�Halcon�Ĵ�����
        /// </summary>
        public virtual void Draw(HWindow window, HObject hObj) { }

        /// <summary>
        /// ���������ROI�����������,���ؼ���ľ��ID
        /// </summary>
        /// <param name="x">���X���꣬��Row����</param>
        /// <param name="y">���Y���꣬��Column����</param>
        /// <returns>����ľ��ID</returns>
        public virtual double DistToClosestHandle(double x, double y){return 0.0;}

        /// <summary>
        /// ��ʾ����Ĳ������
        /// </summary>
        /// <param name="window">Halcon����</param>
        public virtual void DisplayActive(HWindow window, HObject hObj) { }

        /// <summary>
        /// ����ѡ�еĲ������ִ����ز���
        /// </summary>
        /// <param name="newX">���λ�õ�X���꣬�Ǻ��򣬼�Column</param>
        /// <param name="newY">���λ�õ�Y���꣬�����򣬼�Row</param>
        public virtual void moveByHandle(double x, double y) { }

        /// <summary>
        /// ��ȡXLD����
        /// </summary>
        /// <returns></returns>
        public virtual HXLDCont GetXLD() { return null; }

        /// <summary>
        /// ��ȡROI����
        /// </summary>
        public virtual HRegion GetRegion(){return null;}

        /// <summary>
        /// �����õ�����
        /// </summary>
        public virtual double GetDistanceFromStartPoint(double row, double col){return 0.0;}

        /// <summary>
        /// ��ȡROI��Ϣ
        /// </summary>
        /// <returns></returns>
        public virtual HTuple GetModelData(){return null;}

        /// <summary>
        /// ��ȡROI����ľ����Ŀ
        /// </summary>
        public int GetNumHandles(){return NumHandles;}

        /// <summary>
        /// ��ȡROI�Ļ���,��������
        /// </summary>
        public int GetActHandleIdx(){return ActiveHandleId;}

        /// <summary>
        /// ��ȡROI������󣬶����ߵ���ʽ��+|- 
        /// </summary>
        public int GetOperatorFlag(){return OperatorFlag;}

        /// <summary>
        /// ����ROI������󣬶����ߵ���ʽ��+|- 
        /// </summary>
        public void SetOperatorFlag(int flag)
        {
            OperatorFlag = flag;
            switch (OperatorFlag)
            {
                case POSITIVE_FLAG:
                    FlagLineStyle = posOperation;
                    break;
                case NEGATIVE_FLAG:
                    FlagLineStyle = negOperation;
                    break;
                default:
                    FlagLineStyle = posOperation;
                    break;
            }
        }

        #endregion
    }
}
