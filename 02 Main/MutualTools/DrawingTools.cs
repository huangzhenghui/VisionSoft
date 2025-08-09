using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms.DataVisualization.Charting;

namespace MutualTools
{
    public class DrawingTools
    {
        static Boolean legendState = false;

        /// <summary>
        /// 柱状图绘制
        /// </summary>
        /// <param name="chartObj"></param>
        /// <param name="label"></param>
        /// <param name="value"></param>
        public static void DrawBarChart(Chart chartObj, string[] label, string[] value)
        {
            chartObj.Series.Clear();
            Series series1 = new Series();

            //将系列添加到图表
            chartObj.Series.Add(series1);

            //修改图像名称
            series1.Name = "";

            //控件背景
            chartObj.BackColor = Color.Transparent;

            //图表区背景
            chartObj.ChartAreas[0].BackColor = Color.Transparent;
            chartObj.ChartAreas[0].BorderColor = Color.Transparent;

            //X轴标签间距   ！！！！！下面四句的设置能保证X轴标签完全显示出来！！！！
            chartObj.ChartAreas[0].AxisX.Interval = 1;
            chartObj.ChartAreas[0].AxisX.IntervalOffset = 1;  //设置X轴坐标偏移为1
            chartObj.ChartAreas[0].AxisX.LabelStyle.Angle = -90; //标签显示角度反向45°，也可设置为90°

            //X轴间隔大小随变量数量变化
            chartObj.ChartAreas[0].AxisX.IntervalAutoMode = IntervalAutoMode.VariableCount;

            //设置Y轴间隔
            chartObj.ChartAreas[0].AxisY.Interval = 200;

            //设置Y轴的最大值最小值
            chartObj.ChartAreas[0].AxisY.Minimum = 0;
            chartObj.ChartAreas[0].AxisY.Maximum = 1000;

            //确定标签显示是否带有偏移量           
            chartObj.ChartAreas[0].AxisX.TitleFont = new Font("华文新魏", 14f, FontStyle.Regular);
            chartObj.ChartAreas[0].AxisX.TitleForeColor = Color.White;

            //X坐标轴颜色
            chartObj.ChartAreas[0].AxisX.LineColor = ColorTranslator.FromHtml("#38587a");
            chartObj.ChartAreas[0].AxisX.LabelStyle.ForeColor = Color.Black;
            chartObj.ChartAreas[0].AxisX.LabelStyle.Font = new Font("华文新魏", 10f, FontStyle.Regular);

            //X轴网格线条
            chartObj.ChartAreas[0].AxisX.MajorGrid.Enabled = false;
            chartObj.ChartAreas[0].AxisX.MajorGrid.LineColor = ColorTranslator.FromHtml("#2c4c6d");

            //Y坐标轴颜色
            chartObj.ChartAreas[0].AxisY.LineColor = ColorTranslator.FromHtml("#38587a");
            chartObj.ChartAreas[0].AxisY.LabelStyle.ForeColor = Color.Black;
            chartObj.ChartAreas[0].AxisY.LabelStyle.Font = new Font("华文新魏", 10f, FontStyle.Regular);

            //Y轴网格线条
            chartObj.ChartAreas[0].AxisY.MajorGrid.Enabled = false;
            chartObj.ChartAreas[0].AxisY.MajorGrid.LineColor = ColorTranslator.FromHtml("#2c4c6d");

            //辅助Y轴的线
            chartObj.ChartAreas[0].AxisY2.LineColor = Color.Transparent;
            chartObj.ChartAreas[0].BackGradientStyle = GradientStyle.TopBottom;

            chartObj.Series[0].XValueType = ChartValueType.String;//设置X轴上的值类型
            chartObj.Series[0].Label = "#VAL";//设置显示X、Y的值    
            chartObj.Series[0].LabelForeColor = Color.Black;
            chartObj.Series[0].ToolTip = "#VALX:#VAL";//鼠标移动到对应点显示数值
            chartObj.Series[0].ChartType = SeriesChartType.Column;//图类型(柱状图)

            //设置数据点的颜色
            chartObj.Series[0].Color = Color.Lime;
            chartObj.Series[0].IsValueShownAsLabel = true;
            chartObj.Series[0].LabelForeColor = Color.Black;

            //设置数据点自定义属性
            chartObj.Series[0].CustomProperties = "DrawingStyle = Cylinder";
            chartObj.ChartAreas[0].AxisX.ScaleBreakStyle.Enabled = false;
            chartObj.ChartAreas[0].AxisY.ScaleBreakStyle.Enabled = false;

            //白班绑定数据
            int[] array = new int[value.Length];
            for (int i = 0; i < value.Length; i++)
            {
                array[i] = int.Parse(value[i]);
            }
            chartObj.Series[0].Points.DataBindXY(label, array);

            //设置Series对象的调色板
            chartObj.Series[0].Palette = ChartColorPalette.Bright;
        }

        /// <summary>
        /// 饼状图绘制
        /// </summary>
        /// <param name="chartObj"></param>
        /// <param name="label"></param>
        /// <param name="value"></param>
        public static void DrawPieChart(Chart chartObj, List<string> label, List<string> value)
        {
            chartObj.Series.Clear();
            Series series1 = new Series();
            Legend legend = null;

            //将系列添加到图表
            chartObj.Series.Add(series1);

            //修改图像名称
            series1.Name = "产能";

            //控件背景
            chartObj.BackColor = Color.Transparent;

            //图表区背景
            chartObj.ChartAreas[0].BackColor = Color.Transparent;
            chartObj.ChartAreas[0].BorderColor = Color.Transparent;

            if (legend == null)
            {
                legend = new Legend("#VALX");
            }

            //显示设置
            chartObj.ChartAreas[0].BackGradientStyle = GradientStyle.None;
            chartObj.Series[0].LegendText = legend.Name;
            chartObj.Series[0].XValueType = ChartValueType.String;//设置X轴上的值类型
            chartObj.Series[0].Label = "#PERCENT";//设置显示X Y的值    
            chartObj.Series[0].LabelForeColor = Color.White;
            chartObj.Series[0].ToolTip = "#VALX:#VAL";//鼠标移动到对应点显示数值
            chartObj.Series[0].ChartType = SeriesChartType.Pie; //图类型(饼图)
            chartObj.Series[0].Color = Color.Lime;
            chartObj.Series[0].IsValueShownAsLabel = true;
            chartObj.Series[0].LabelForeColor = Color.Black;
            chartObj.Series[0].CustomProperties = "PieLineColor= Black,PieLabelStyle = Outside,DrawingStyle = Cylinder";//数据点属性设置
            chartObj.Series[0].IsValueShownAsLabel = true;
            chartObj.Legends[0].Position.Auto = true;
            if (legendState == false)
            {
                chartObj.Legends.Add(legend);
                legendState = true;
            }

            //绑定数据
            int[] array = new int[value.Count];
            for (int i = 0; i < value.Count; i++)
            {
                array[i] = int.Parse(value[i]);
            }
            chartObj.Series[0].Points.DataBindXY(label, array);

            //绑定颜色
            chartObj.Series[0].Palette = ChartColorPalette.Pastel;
        }
    }
}
