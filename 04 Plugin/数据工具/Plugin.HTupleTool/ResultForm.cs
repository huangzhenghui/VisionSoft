using HalconDotNet;
using MutualTools;
using Rex.UI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using VisionCore.Core.PluginBase;

namespace Plugin.HTupleTool
{
    public partial class ResultForm : FrmResult
    {
        #region 初始化

        /// <summary>
        /// 初始化
        /// </summary>
        public ResultForm()
        {
            InitializeComponent();
            tbxResult.Style = UIStyle.Blue;
            tbxResult.FillColor = Color.AliceBlue;
            tbxResult.RectColor = Color.AliceBlue;
        }

        #endregion

        #region 方法-窗体相关

        /// <summary>
        /// 结果显示
        /// </summary>
        public void ShowResult(string result, HTuple hTuple)
        {
            switch (result)
            {
                case "模块未执行":
                    lblResult.ForeColor = Color.LightSalmon;
                    lblResult.SymbolColor = Color.LightSalmon;
                    lblResult.Symbol = 61736;
                    lblResult.Text = "模块未执行";
                    break;
                case "执行成功":
                    lblResult.ForeColor = Color.LightSeaGreen;
                    lblResult.SymbolColor = Color.LightSeaGreen;
                    lblResult.Symbol = 61452;
                    lblResult.Text = "执行成功";
                    break;
                case "执行失败":
                    lblResult.ForeColor = Color.FromArgb(245, 20, 50);
                    lblResult.SymbolColor = Color.FromArgb(245, 20, 50);
                    lblResult.Symbol = 61453;
                    lblResult.Text = "执行失败";
                    break;
            }

            tbxResult.TextAlignment = ContentAlignment.TopLeft;

            HTuple info = new HTuple();
            string str = TypeConvert.HTupleToString(hTuple);
            HTuple strAssem = str.Split(',');
            for (int i = 0; i < strAssem.Length; i++)
            {
                if (i == 0)
                {
                    info = strAssem[i];
                }
                else
                {
                    info = info + "\r\n" + strAssem[i];
                }
            }

            tbxResult.Text = info;
        }

        #endregion
    }
}
