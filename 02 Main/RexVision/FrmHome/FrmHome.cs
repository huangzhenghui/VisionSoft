using NPOI.HSSF.UserModel;
using NPOI.POIFS.FileSystem;
using NPOI.SS.UserModel;
using TSIVision.FrmVarR;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using VisionCore;

namespace TSIVision.FrmHomeR
{
    public partial class FrmHome : Form
    {
        #region 字段、属性

    
        public static string fpSettingFile = AppDomain.CurrentDomain.BaseDirectory + @"界面显示设置.xlsx";//界面显示文件路径
      
        #endregion

        #region 初始化

        public FrmHome()
        {
            InitializeComponent();
            FormMain.MainPanel = MainPanel;
        }

        #endregion

        #region 事件-按钮控件




        #endregion

        private void FrmHome_Load(object sender, EventArgs e)
        {

        }
    }
}
