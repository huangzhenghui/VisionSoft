using NPOI.HSSF.UserModel;
using NPOI.POIFS.FileSystem;
using NPOI.SS.UserModel;
using Rex.UI;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MutualTools
{
    public class AnalysisTools
    {
        //DataGridView对象
        public static DataGridView dgv1ProTotal = new DataGridView();
        public static DataGridView dgv2ProTotal = new DataGridView();
        public static DataGridView dgvProDetail = new DataGridView();

        public static DataGridView dgv1AlmTotal = new DataGridView();
        public static DataGridView dgv2AlmTotal = new DataGridView();
        public static DataGridView dgvAlmDetail = new DataGridView();

        //生产总的数据统计(绘图使用)
        public static string[] timeProDay = new string[12];
        public static string[] OKProDay = new string[12];
        public static string[] timeProNight = new string[12];
        public static string[] OKProNight = new string[12];

        //生产详细数据统计(绘图使用)
        public static List<string> itemProDD = new List<string>();
        public static List<string> numProDD = new List<string>();

        //报警总的数据统计(绘图使用)
        public static string[] timeAlmDay = new string[12];
        public static string[] numAlmDay = new string[12];
        public static string[] timeAlmNight = new string[12];
        public static string[] numAlmNight = new string[12];

        //报警详细数据统计(绘图使用)
        public static List<string> itemAlm = new List<string>();
        public static List<string> numAlm = new List<string>();

        /// <summary>
        /// Excel文件读取
        /// </summary>
        /// <param name="filePath">文件路径</param>
        /// <param name="rColumns">需读取的列数</param>
        /// <param name="inquireTime"></param>查询时间
        /// <param name="dayStartTime"></param>白班起始时间
        /// <param name="rValues"></param>读取到的单元格的值
        public static void RExcel(string filePath, int rColumns, DateTime inquireTime, string dayStartTime, out List<string> rValues)
        {
            IWorkbook workbook;
            ISheet sheet;
            string[] requireData;
            DateTime timeStart;
            DateTime timeEnd;
            DateTime timeCompare;

            //读取文件
            rValues = new List<string>();
            if (!File.Exists(filePath))
            {
                return;
            }
            FileStream fs = new FileStream(filePath, FileMode.Open, FileAccess.Read);
            POIFSFileSystem ps = new POIFSFileSystem(fs);

            //根据文件后缀创建workbook对象和sheet对象
            workbook = new HSSFWorkbook(ps);
            sheet = (HSSFSheet)workbook.GetSheetAt(0);
            fs.Close();

            IRow row;
            System.Collections.IEnumerator rows = sheet.GetRowEnumerator();

            Boolean exeSignal = false;//去除第一行标题
            while (rows.MoveNext())
            {
                if (exeSignal)
                {
                    requireData = new string[3];
                    row = (HSSFRow)rows.Current;
                    timeStart = Convert.ToDateTime((inquireTime).ToString().Split()[0] + " " + dayStartTime);
                    timeEnd = timeStart.AddDays(1);
                    timeCompare = Convert.ToDateTime(row.GetCell(0).ToString());
                    int result1 = DateTime.Compare(timeCompare, timeStart);
                    int result2 = DateTime.Compare(timeCompare, timeEnd);

                    if (result1 >= 0 && result2 <= 0)
                    {
                        requireData[0] = row.GetCell(0).ToString();
                        for (int i = 1; i < rColumns; i++)
                        {
                            requireData[i] = row.GetCell(row.LastCellNum - (rColumns - i)).ToString();
                        }
                        rValues.AddRange(requireData);
                    }
                }
                exeSignal = true;
            }
        }

        /// <summary>
        /// 生产统计总的数据处理
        /// </summary>
        /// <param name="rValues">数据数组</param>
        /// <param name="inquireDate">查询时间</param>
        /// <param name="dayStartTime">白班起始时间</param>
        /// <param name="labelHour">label显示小时段</param>
        /// <param name="OKNum">OK数</param>
        /// <param name="NGNum">NG数</param>
        /// <param name="OKRatio">良率</param>
        public static void ProTotalDP(List<string> rValues, DateTime inquireDate, string dayStartTime, out string[] labelHour, out int[] OKNum, out int[] NGNum, out double[] OKRatio)
        {
            int result1, result2;
            OKNum = new int[24];
            NGNum = new int[24];
            OKRatio = new double[24];//良率
            labelHour = new string[24];//显示label
            string[] hourProd = new string[24];//小时分段，24段

            for (int i = 0; i < 24; i++)
            {
                hourProd[i] = Convert.ToDateTime(inquireDate.ToString().Split(' ')[0] + " " + dayStartTime).AddHours(i).ToString("yyyy-MM-dd HH:mm:ss");
                labelHour[i] = hourProd[i].Split(' ')[1].Substring(0, 5) + "-" + Convert.ToDateTime(hourProd[i]).AddHours(1).ToString("yyyy-MM-dd HH:mm:ss").Split(' ')[1].Substring(0, 5);
            }

            for (int i = 0; i < rValues.Count; i = i + 3)
            {
                for (int j = 0; j < 24; j++)
                {
                    result1 = DateTime.Compare(Convert.ToDateTime(rValues[i]), Convert.ToDateTime(hourProd[j]));
                    result2 = DateTime.Compare(Convert.ToDateTime(rValues[i]), Convert.ToDateTime(hourProd[j]).AddHours(1));

                    if (result1 >= 0 && result2 <= 0)
                    {
                        switch (rValues[i + 1])
                        {
                            case "OK":
                                OKNum[j]++;
                                break;

                            case "NG":
                                NGNum[j]++;
                                break;
                        }
                    }
                }
            }

            for (int i = 0; i < 24; i++)
            {
                if ((OKNum[i] + NGNum[i]) > 0)
                {
                    OKRatio[i] = (double)OKNum[i] / (double)(OKNum[i] + NGNum[i]);
                }
                else
                {
                    OKRatio[i] = 0;
                }
            }
        }

        /// <summary>
        /// 生产统计总的数据列表绘制
        /// </summary>
        /// <param name="labelHour">label显示小时段</param>
        /// <param name="OKNum">OK数</param>
        /// <param name="NGNum">NG数</param>
        /// <param name="OKRatio">良率</param>
        public static void ProTotalLC(string[] labelHour, int[] OKNum, int[] NGNum, double[] OKRatio)
        {
            int OKSumDay = 0;
            int NGSumDay = 0;
            int OKSumNight = 0;
            int NGSumNight = 0;
            double OKratioSumDay = 0;
            double OKratioSumNight = 0;
            string[] valuesDay = new string[4];
            string[] valuesNight = new string[4];

            //白班数据处理
            for (int i = 0;  i < 24; i++)
             {
                if (i < 12)
                {
                    valuesDay[0] = labelHour[i];
                    valuesDay[1] = OKNum[i].ToString();
                    valuesDay[2] = NGNum[i].ToString();
                    valuesDay[3] = OKRatio[i].ToString("P");

                    //统计OK总数，NG总数
                    OKSumDay = OKSumDay + Convert.ToInt32(valuesDay[1]);
                    NGSumDay = NGSumDay + Convert.ToInt32(valuesDay[2]);

                    //绘制柱状图
                    timeProDay[i] = valuesDay[0];
                    OKProDay[i] = valuesDay[1];

                    dgv1ProTotal.Rows.Add(valuesDay);
                }
                else
                {
                    valuesNight[0] = labelHour[i];
                    valuesNight[1] = OKNum[i].ToString();
                    valuesNight[2] = NGNum[i].ToString();
                    valuesNight[3] = OKRatio[i].ToString("P");

                    //统计OK总数，NG总数
                    OKSumNight = OKSumNight + Convert.ToInt32(valuesNight[1]);
                    NGSumNight = NGSumNight + Convert.ToInt32(valuesNight[2]);

                    //绘制柱状图
                    timeProNight[i - 12] = valuesNight[0];
                    OKProNight[i - 12] = valuesNight[1];

                    dgv2ProTotal.Rows.Add(valuesNight);
                }
            }

            //统计白班总良率
            if (OKSumDay != 0 || OKSumDay != 0)
            {
                OKratioSumDay = Convert.ToDouble(OKSumDay) / (Convert.ToDouble(OKSumDay) + Convert.ToDouble(NGSumDay));
            }
            else
            {
                OKratioSumDay = 0;
            }

            //白班总计数据输出
            valuesDay[0] = "合计";
            valuesDay[1] = OKSumDay.ToString();
            valuesDay[2] = NGSumDay.ToString();
            valuesDay[3] = OKratioSumDay.ToString("P");
            dgv1ProTotal.Rows.Add(valuesDay);

            //统计夜班总良率
            if (OKSumNight != 0 || OKSumNight != 0)
            {
                OKratioSumNight = Convert.ToDouble(OKSumNight) / (Convert.ToDouble(OKSumNight) + Convert.ToDouble(NGSumNight));
            }
            else
            {
                OKratioSumNight = 0;
            }

            //夜班总计数据输出
            valuesNight[0] = "合计";
            valuesNight[1] = OKSumNight.ToString();
            valuesNight[2] = NGSumNight.ToString();
            valuesNight[3] = OKratioSumNight.ToString("P");
            dgv2ProTotal.Rows.Add(valuesNight);
        }

        /// <summary>
        /// 生产统计详细数据处理
        /// </summary>
        /// <param name="rValues">生产数据</param>
        /// <param name="OKSum">OK总数</param>
        /// <param name="NGSum">NG总数</param>
        /// <param name="NGStyle">NG类型</param>
        /// <param name="everyNGNum">每个NG类型数量</param>
        public static void ProDetailDP(List<string> rValues, out int OKSum, out int NGSum, out List<string> NGStyle, out List<int> everyNGNum)
        {
            OKSum = 0;
            NGSum = 0;
            NGStyle = new List<string>();

            for (int i = 0; i < rValues.Count; i = i + 3)
            {
                if (rValues[i + 1] == "OK")
                {
                    OKSum++;
                }
                else if (rValues[i + 1] == "NG")
                {
                    NGSum++;
                    NGStyle.Add(rValues[i + 2]);
                }
            }

            NGStyle = NGStyle.Distinct().ToList<string>();
            List<string> NGStyleMed = new List<string>();
            everyNGNum = new List<int>();
            for (int i = 0; i < NGStyle.Count; i++)
            {
                NGStyleMed.Add(NGStyle[i]);
                everyNGNum.Add(rValues.Count(x => x.Contains(NGStyleMed[i])));
            }
        }

        /// <summary>
        /// 生产统计详细数据列表绘制
        /// </summary>
        /// <param name="OKSum">OK总数</param>
        /// <param name="NGSum">NG总数</param>
        /// <param name="NGStyle">NG类型</param>
        /// <param name="everyNGNum">每个类型的NG数目</param>
        public static void ProDetailLC(int OKSum, int NGSum, List<string> NGStyle, List<int> everyNGNum)
        {
            //label项编辑
            List<string> label = new List<string>();
            label.Add("总投入数");
            label.Add("OK数");
            label.Add("NG数");
            label.AddRange(NGStyle);
            //value项编辑
            List<string> value = new List<string>();
            string Sum = (OKSum + NGSum).ToString();
            value.Add(Sum);
            value.Add(OKSum.ToString());
            value.Add(NGSum.ToString());
            for (int i = 0; i < everyNGNum.Count; i++)
            {
                value.Add(everyNGNum[i].ToString());
            }

            //ratio项编辑
            List<string> ratio = new List<string>();
            ratio.Add("——");
            if (OKSum != 0 || NGSum != 0)
            {
                ratio.Add((Convert.ToDouble(OKSum) / Convert.ToDouble(OKSum + NGSum)).ToString("P"));
            }
            else
            {
                ratio.Add(0.ToString("P"));
            }

            if (OKSum != 0 || NGSum != 0)
            {
                ratio.Add((Convert.ToDouble(NGSum) / Convert.ToDouble(OKSum + NGSum)).ToString("P"));
            }
            else
            {
                ratio.Add(0.ToString("P"));
            }

            for (int i = 0; i < NGStyle.Count; i++)
            {
                if (OKSum != 0 || NGSum != 0)
                {
                    ratio.Add((everyNGNum[i] / Convert.ToDouble(OKSum + NGSum)).ToString("P"));
                }
                else
                {
                    ratio.Add(0.ToString("P"));
                }
            }

            string[] rowValues = new string[3];

            for (int i = 0; i < (everyNGNum.Count + 3); i++)
            {
                rowValues[0] = label[i];
                rowValues[1] = value[i];
                rowValues[2] = ratio[i];
                dgvProDetail.Rows.Add(rowValues);
            }

            List<string> labelPro = new List<string>();
            List<int> valuePro = new List<int>();
            List<string> labelSort = new List<string>();
            List<int> valueSort = new List<int>();
            for (int i = 3; i < value.Count; i++)
            {
                labelPro.Add(label[i]);
                valuePro.Add(Convert.ToInt32(value[i]));
            }

            //冒泡排序求TOP5
            BubbleSort(labelPro, valuePro, out labelSort, out valueSort);

            itemProDD.Clear();
            numProDD.Clear();

            //将数据赋给静态变量，以绘制饼状图
            for (int i = 0; i < valueSort.Count; i++)
            {
                itemProDD.Add(labelSort[i]);
                numProDD.Add(valueSort[i].ToString());
            }
        }

        /// <summary>
        /// 报警统计总的数据处理数据处理
        /// </summary>
        /// <param name="rValues">数据数组</param>
        /// <param name="inquireDate">查询日期</param>
        /// <param name="dayStartTime">白班起始时间</param>
        /// <param name="labelHour">时间段</param>
        /// <param name="alarmNum">报警数目</param>
        public static void AlmTotalDP(List<string> rValues, DateTime inquireDate, string dayStartTime, out string[] labelHour, out int[] alarmNum)
        {
            int result1, result2;
            alarmNum = new int[24];
            labelHour = new string[24];//显示label
            string[] hourProd = new string[24];//小时分段，24段

            for (int i = 0; i < 24; i++)
            {
                hourProd[i] = Convert.ToDateTime(inquireDate.ToString().Split(' ')[0] + " " + dayStartTime).AddHours(i).ToString("yyyy-MM-dd HH:mm:ss");
                labelHour[i] = hourProd[i].Split(' ')[1].Substring(0, 5) + "-" + Convert.ToDateTime(hourProd[i]).AddHours(1).ToString("yyyy-MM-dd HH:mm:ss").Split(' ')[1].Substring(0, 5);
            }

            for (int i = 0; i < rValues.Count; i = i + 3)
            {
                for (int j = 0; j < 24; j++)
                {
                    result1 = DateTime.Compare(Convert.ToDateTime(rValues[i]), Convert.ToDateTime(hourProd[j]));
                    result2 = DateTime.Compare(Convert.ToDateTime(rValues[i]), Convert.ToDateTime(hourProd[j]).AddHours(1));

                    if (result1 >= 0 && result2 <= 0)
                    {
                        alarmNum[j]++;
                    }
                }
            }
        }

        /// <summary>
        /// 报警统计总的数据列表绘制
        /// </summary>
        /// <param name="labelHour">显示小时段Label</param>
        /// <param name="alarmNum">每小时报警数目</param>
        public static void AlmTotalLC(string[] labelHour, int[] alarmNum)
        {
            int alarmSumDay = 0;
            int alarmSumNight = 0;
            string[] rowValuesDay = new string[2];
            string[] rowValuesNight = new string[2];

            //白班数据处理
            for (int i = 0; i < 24; i++)
            {
                if (i < 12)
                {
                    rowValuesDay[0] = labelHour[i];
                    rowValuesDay[1] = alarmNum[i].ToString();

                    //统计报警总数
                    alarmSumDay = alarmSumDay + Convert.ToInt32(rowValuesDay[1]);

                    //绘制柱状图
                    timeAlmDay[i] = rowValuesDay[0];
                    numAlmDay[i] = rowValuesDay[1];

                    dgv1AlmTotal.Rows.Add(rowValuesDay);
                }
                else
                {
                    rowValuesNight[0] = labelHour[i];
                    rowValuesNight[1] = alarmNum[i].ToString();

                    //统计报警总数
                    alarmSumNight = alarmSumNight + Convert.ToInt32(rowValuesNight[1]);

                    //绘制柱状图
                    timeAlmNight[i - 12] = rowValuesNight[0];
                    numAlmNight[i - 12] = rowValuesNight[1];

                    dgv2AlmTotal.Rows.Add(rowValuesNight);
                }
            }

            //白班总计数据输出
            rowValuesDay[0] = "合计";
            rowValuesDay[1] = alarmSumDay.ToString();
            dgv1AlmTotal.Rows.Add(rowValuesDay);

            //夜班总计数据输出
            rowValuesNight[0] = "合计";
            rowValuesNight[1] = alarmSumNight.ToString();
            dgv2AlmTotal.Rows.Add(rowValuesNight);
        }




        /// <summary>
        /// 报警统计详细数据按班次处理
        /// </summary>
        /// <param name="rValues">数据数组</param>
        /// <param name="alarmStyle">报警类别</param>
        /// <param name="everyAlarmNum">每个报警数目</param>
        /// <param name="alarmRation">每个类型报警所占比例</param>
        public static void AlmDetailDPS(List<string> rValues, out int alarmSum, out List<string> alarmStyle, out List<int> everyAlarmNum, out List<string> alarmRation)
        {
            alarmSum = 0;
            alarmStyle = new List<string>();
            alarmRation = new List<string>();

            //计算总数
            for (int i = 0; i < rValues.Count; i = i + 3)
            {
                alarmSum++;
                alarmStyle.Add(rValues[i + 2]);
            }

            alarmStyle = alarmStyle.Distinct().ToList<string>();
            List<string> NGStyleMed = new List<string>();
            everyAlarmNum = new List<int>();
            for (int i = 0; i < alarmStyle.Count; i++)
            {
                NGStyleMed.Add(alarmStyle[i]);
                everyAlarmNum.Add(rValues.Count(x => x.Contains(NGStyleMed[i])));
                alarmRation.Add((Convert.ToDouble(everyAlarmNum[i]) / Convert.ToDouble(alarmSum)).ToString("P"));
            }
        }

        /// <summary>
        /// 报警统计详细数据按小时处理
        /// </summary>
        /// <param name="rowValues">数据数组</param>
        /// <param name="inquireHour">查询小时</param>
        /// <param name="alarmStyle">报警类型</param>
        /// <param name="everyAlarmNum">每个报警类型的报警数目</param>
        /// <param name="alarmRation">所占比例</param>
        public static void AlmDetailDPH(List<string> rValues, string inquireHour, out int alarmSum, out List<string> alarmStyle, out List<int> everyAlarmNum, out List<string> alarmRation)
        {
            alarmSum = 0;//报警总数
            alarmStyle = new List<string>();//报警类型
            List<string> alarmHour = new List<string>();//该小时的报警集合
            everyAlarmNum = new List<int>();//每种报警类型数目
            alarmRation = new List<string>();//求每种报警类型所占比例

            for (int i = 0; i < rValues.Count; i = i + 3)
            {
                string[] timeSplit = rValues[i].Split(' ');
                inquireHour = inquireHour.Split(':')[0];
                if (timeSplit[1].Split(':')[0] == inquireHour)
                {
                    alarmSum++;
                    alarmHour.Add(rValues[i + 2]);
                }
            }

            //得到报警类型
            alarmStyle = alarmHour.Distinct().ToList<string>();
            List<string> alarmStyleMed = new List<string>();
            //得到每种报警类型的数目
            for (int i = 0; i < alarmStyle.Count; i = i + 1)
            {
                alarmStyleMed.Add(alarmStyle[i]);
            }

            for (int i = 0; i < alarmStyle.Count; i++)
            {
                everyAlarmNum.Add(alarmHour.Count(x => x.Contains(alarmStyleMed[i])));

                //求比例
                if (alarmSum != 0)
                {
                    alarmRation.Add((Convert.ToDouble(everyAlarmNum[i]) / Convert.ToDouble(alarmSum)).ToString("P"));
                }
                else
                {
                    alarmRation.Add(0.ToString("P"));
                }
            }
        }

        /// <summary>
        /// 报警统计详细数据列表绘制(班次)
        /// </summary>
        /// <param name="alarmSum">总报警数</param>
        /// <param name="alarmStyle">报警类型</param>
        /// <param name="everyAlarmNum">每个类型的报警数</param>
        /// <param name="alarmRation">报警比例</param>
        public static void AlmDetailLCS(int alarmSum, List<string> alarmStyle, List<int> everyAlarmNum, List<string> alarmRation)
        {
            //label项编辑
            List<string> label = new List<string>();
            label.Add("总报警数");
            label.AddRange(alarmStyle);

            //value项编辑
            List<string> value = new List<string>();
            string Sum = alarmSum.ToString();
            value.Add(Sum);

            for (int i = 0; i < everyAlarmNum.Count; i++)
            {
                value.Add(everyAlarmNum[i].ToString());
            }

            //ratio项编辑
            List<string> ratio = new List<string>();
            ratio.Add("——");
            ratio.AddRange(alarmRation);

            string[] rowValues = new string[3];
            for (int i = 0; i < (alarmStyle.Count + 1); i++)
            {
                rowValues[0] = label[i];
                rowValues[1] = value[i];
                rowValues[2] = ratio[i];
                dgvAlmDetail.Rows.Add(rowValues);
            }

            List<string> labelPro = new List<string>();
            List<int> valuePro = new List<int>();
            List<string> labelSort = new List<string>();
            List<int> valueSort = new List<int>();
            for (int i = 1; i < value.Count; i++)
            {
                labelPro.Add(label[i]);
                valuePro.Add(Convert.ToInt32(value[i]));
            }

            //冒泡排序求TOP5
            BubbleSort(labelPro, valuePro, out labelSort, out valueSort);

            itemAlm.Clear();
            numAlm.Clear();

            //将数据赋给静态变量，以绘制饼状图
            for (int i = 0; i < valueSort.Count; i++)
            {
                itemAlm.Add(labelSort[i]);
                numAlm.Add(valueSort[i].ToString());
            }
        }

        /// <summary>
        /// 报警统计详细数据列表绘制(小时)
        /// </summary>
        /// <param name="alarmSum"></param>
        /// <param name="alarmStyle"></param>
        /// <param name="everyAlarmNum"></param>
        /// <param name="alarmRation"></param>
        public static void AlmDetailLCH(int alarmSum, List<string> alarmStyle, List<int> everyAlarmNum, List<string> alarmRation)
        {
            //label项编辑
            List<string> label = new List<string>();
            label.Add("总报警数");
            label.AddRange(alarmStyle);

            //value项编辑
            List<string> value = new List<string>();
            string Sum = alarmSum.ToString();
            value.Add(Sum);

            for (int i = 0; i < everyAlarmNum.Count; i++)
            {
                value.Add(everyAlarmNum[i].ToString());
            }

            //ratio项编辑
            List<string> ratio = new List<string>();
            ratio.Add("——");
            ratio.AddRange(alarmRation);

            string[] rowValues = new string[3];
            for (int i = 0; i < (alarmStyle.Count + 1); i++)
            {
                rowValues[0] = label[i];
                rowValues[1] = value[i];
                rowValues[2] = ratio[i];
                dgvAlmDetail.Rows.Add(rowValues);
            }

            List<string> labelPro = new List<string>();
            List<int> valuePro = new List<int>();
            List<string> labelSort = new List<string>();
            List<int> valueSort = new List<int>();
            for (int i = 1; i < value.Count; i++)
            {
                labelPro.Add(label[i]);
                valuePro.Add(Convert.ToInt32(value[i]));
            }

            //冒泡排序求TOP5
            BubbleSort(labelPro, valuePro, out labelSort, out valueSort);

            itemAlm.Clear();
            numAlm.Clear();

            //将数据赋给静态变量，以绘制饼状图
            for (int i = 0; i < valueSort.Count; i++)
            {
                itemAlm.Add(labelSort[i]);
                numAlm.Add(valueSort[i].ToString());
            }
        }

        /// <summary>
        /// 冒泡排序TOP5
        /// </summary>
        /// <param name="label">排序前label</param>
        /// <param name="value">排序前value</param>
        /// <param name="labelSort">排序后label</param>
        /// <param name="valueSort">排序后value</param>
        public static void BubbleSort(List<string> label, List<int> value, out List<string> labelSort, out List<int> valueSort)
        {
            labelSort = new List<string>();
            valueSort = new List<int>();
            int otherSum = 0;

            for (int i = 0; i < value.Count - 1; i++)
            {
                for (int j = 0; j < value.Count - 1 - i; j++)
                {
                    if (value[j] < value[j + 1])
                    {
                        int valueTemp = value[j];
                        value[j] = value[j + 1];
                        value[j + 1] = valueTemp;

                        string labelTemp = label[j];
                        label[j] = label[j + 1];
                        label[j + 1] = labelTemp;
                    }
                }
            }

            if (value.Count <= 5)
            {
                for (int i = 0; i < value.Count; i++)
                {
                    labelSort.Add(label[i]);
                    valueSort.Add(value[i]);
                }
            }
            else
            {
                for (int i = 0; i < 5; i++)
                {
                    labelSort.Add(label[i]);
                    valueSort.Add(value[i]);
                }

                //除TOP5外其余NG项总和统计
                for (int i = 5; i < value.Count; i++)
                {
                    otherSum = otherSum + value[i];
                }
                labelSort.Add("其他");
                valueSort.Add(otherSum);
            }
        }
    }
}
