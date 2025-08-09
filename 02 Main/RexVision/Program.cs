
using System;
using System.Threading;
using System.Windows.Forms;
using VisionCore;
namespace TSIVision
{
    static class Program
    {
        /// <summary>
        /// 应用程序的主入口点。
        /// </summary>
        [STAThread]
        static void Main()
        {
            using (Mutex m = new Mutex(true, "Global\\" + Application.ProductName, out bool createNew))
            {
                if (createNew)
                {
                    Application.EnableVisualStyles();
                    Application.SetCompatibleTextRenderingDefault(false);

                    //注册日志系统
                    Log.RegisterLog();

                    //加载插件
                    PluginCamService.InitPlugin();
                    PluginToolService.InitPlugin();
                    
                    //运行程序
                    Application.Run(new FormMain());
                }
                else
                {
                    MessageBox.Show("程序已运行!");
                    Thread.Sleep(500);
                }
            }
        }
    }
}
