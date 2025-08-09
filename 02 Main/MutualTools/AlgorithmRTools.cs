using HalconDotNet;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MutualTools
{
    public class AlgorithmRTools
    {
        /// <summary>
        /// 计算RMS误差
        /// </summary>
        /// <param name="hom2d"></param>
        /// <param name="img_Row"></param>
        /// <param name="img_Col"></param>
        /// <param name="robot_Row"></param>
        /// <param name="robot_Col"></param>
        /// <returns></returns>
        public static double CalRMS(HTuple hom2d, HTuple img_Row, HTuple img_Col, HTuple robot_Row, HTuple robot_Col)
        {
            try
            {
                double count = 0;
                for (int i = 0; i < img_Row.Length; i++)
                {
                    HTuple hom2dInvert = new HTuple();
                    HTuple tempRow = new HTuple();
                    HTuple tempCol = new HTuple();
                    HOperatorSet.HomMat2dInvert(hom2d, out hom2dInvert);
                    HOperatorSet.AffineTransPoint2d(hom2dInvert, robot_Row[i].D, robot_Col[i].D, out tempRow, out tempCol);
                    double dis = HMisc.DistancePp(tempRow, tempCol, img_Row[i], img_Col[i]);
                    count = count + dis * dis;
                }

                double RMS = Math.Sqrt(count / img_Row.Length);
                return RMS;
            }
            catch
            {
                return -1;
            }
        }
    }
}
