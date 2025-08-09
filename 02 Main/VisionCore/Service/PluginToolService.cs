using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Reflection;
using System.Resources;
using System.Threading;
using System.Windows.Forms;
using VisionCore.Properties;

namespace VisionCore
{
    /// <summary>
    /// 方法插件类
    /// </summary>
    public class PluginToolService
    {
        #region 字段、属性

        /// <summary>
        /// 定义一个资源文件名,资源文件名 = 工程的默认命名空间+文件名(不带扩展名) 
        /// </summary>
        public static string PublicResourceFileName = "Resources";

        /// <summary>
        /// 插件 字典
        /// </summary>
        public static Dictionary<string, PluginsInfo> mPluginDic = new Dictionary<string, PluginsInfo>();

        /// <summary>
        /// 插件 路径
        /// </summary>
        public static readonly string PlugInsDir = Path.Combine(Environment.CurrentDirectory, "Plugins\\");

        #endregion

        #region 方法-插件相关

        /// <summary>
        /// 加载插件(根据特征判断，得到所有方法插件)
        /// </summary>
        public static void InitPlugin()
        {
            if (Directory.Exists(PlugInsDir) == false) return;//判断是否存在
            //判断是否是UI.dll
            foreach (var dllFile in Directory.GetFiles(PlugInsDir, "*.dll"))
            {
                try
                {
                    FileInfo fi = new FileInfo(dllFile);
                    //判断是否是Plugin.xxxxxxx.dll
                    if (!fi.Name.StartsWith("Plugin.") || !fi.Name.EndsWith(".dll")) continue;
                    Assembly assemPlugIn = AppDomain.CurrentDomain.Load(Assembly.LoadFile(fi.FullName).GetName());// 该方法会占用文件 但可以调试
                    //判断是否包含ObjBase
                    foreach (Type type in assemPlugIn.GetTypes())
                    {
                        //是ObjBase的子类
                        if (typeof(ObjBase).IsAssignableFrom(type))
                        {
                            PluginsInfo info = new PluginsInfo();
                            //获取插件信息
                            if (GetPluginInfo(assemPlugIn, type, ref info))
                            {
                                mPluginDic[info.Name] = info;
                            }
                            break;
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString()+ dllFile);
                }
            }
        }

        /// <summary>
        /// 获取插件信息
        /// </summary>
        /// <param name="type"></param>
        /// <returns></returns>
        public static bool GetPluginInfo(Assembly assemPlugIn, Type type, ref PluginsInfo info)
        {
            try
            {
                object[] categoryObjs = type.GetCustomAttributes(typeof(CategoryAttribute), true);
                object[] dispNameObjs = type.GetCustomAttributes(typeof(DisplayNameAttribute), true);
                info.Category = ((CategoryAttribute)categoryObjs[0]).Category;
                info.Name = ((DisplayNameAttribute)dispNameObjs[0]).DisplayName;
                info.ModObjType = type;
                Type[] aa = assemPlugIn.GetTypes();
                foreach (Type tempType in assemPlugIn.GetTypes())
                {
                    if (typeof(FormBase).IsAssignableFrom(tempType))//是Base的子类
                    {
                        try
                        {
                            ResourceManager resource = new ResourceManager(assemPlugIn.FullName.Split(',')[0] + ".Properties.Resources", assemPlugIn);//创建ResourceManager对象
                            if (resource.GetObject("PluginIcon") !=null)
                            {
                                info.IconImage = (Icon)resource.GetObject("PluginIcon");//根据资源名称获取资源，并转型
                            }
                            else
                            {
                                info.IconImage = Resources.图像采集;
                            }                     
                        }
                        catch (Exception ex) { Debug.Write(ex.Message); }
                        return true;
                    }
                }


            }
            catch (Exception ex)
            {
                Debug.Write(ex.Message);
            }
            return false;
        }

        #endregion
    }
}


