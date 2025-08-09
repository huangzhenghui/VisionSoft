using System;
using System.Windows.Forms;
using VisionCore;
using WeifenLuo.WinFormsUI.Docking;

namespace TSIVision
{
    /// <summary>
    /// 工具箱
    /// </summary>
    public partial class FrmTool : DockContent
    {
        public FrmTool()
        {
            InitializeComponent();
        }

        private void FrmModTree_Load(object sender, EventArgs e)
        {
           ModTree1.Init(PluginToolService.mPluginDic);
        }
    }
}
