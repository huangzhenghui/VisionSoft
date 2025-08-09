using log4net;
using log4net.Appender;
using log4net.Core;
using log4net.Layout;
using log4net.Repository.Hierarchy;
using NPOI.HSSF.UserModel;
using NPOI.POIFS.FileSystem;
using NPOI.SS.UserModel;
using RexHelps;
using System;
using System.Configuration;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace VisionCore
{
    public class Log
    {
        #region 字段、属性

        /// <summary>
        /// 系统日志路径
        /// </summary>
        static string sysLogPath;

        /// <summary>
        /// 配置文件
        /// </summary>
        static XmlDocument xmlDoc;

        #endregion

        #region 方法-日志写入

        /// <summary>
        /// 日志记录
        /// </summary>
        private static ILog log4Net = LogManager.GetLogger("logLogger");

        /// <summary>
        /// 模块参数修改记录
        /// </summary>
        private static readonly ILog LogModify = LogManager.GetLogger("modifyLogger");

        /// <summary>
        /// 初始化注册RichTextBox
        /// </summary>
        public static void RegisterLog()
        {
            RIni mRini = new RIni(Application.StartupPath + "\\Config.ini");//配置文件地址
            string rootLogPath = mRini.ReadValue("Config", "mSaveLogPath", "");
            sysLogPath = rootLogPath + "\\系统日志\\"; //系统日志保存地址
            string xmlpath = Application.StartupPath + "\\log4net.config";

            LoadXml(xmlpath);
            WriteXml(ModifyInfo.保存地址, sysLogPath);
            SaveXml(xmlpath);

            log4net.Config.XmlConfigurator.ConfigureAndWatch(new FileInfo(Application.StartupPath + "\\log4net.config"));
        }

        /// <summary>
        /// 初始化
        /// </summary>
        public static void InitializeRichTextBox(RichTextBox RichTextBoxLog)
        {
            if (RichTextBoxLog == null) return;
            var LogPattern = "%d{yyyy-MM-dd HH:mm:ss} %-5p %m%n";
            var LogListAppender = new TextBoxBaseAppender();
            LogListAppender.RichTextBoxLog = RichTextBoxLog;
            LogListAppender.Layout = new PatternLayout(LogPattern);
            log4net.Config.BasicConfigurator.Configure(LogListAppender);
        }

        /// <summary>
        /// 记录模块参数变更记录  用于记录额外的一些重要记录,比如关键参数修改记录-->记录在log/modify文件下
        /// </summary>
        public static void ModParamModify(string str)
        {
            LogModify.Info(str);
        }

        /// <summary>
        /// 调试
        /// </summary>
        public static void Debug(string str)
        {
            log4Net.Debug(str);
        }

        /// <summary>
        /// 提示
        /// </summary>
        public static void Info(string str)
        {
            log4Net.Info(str);
        }

        /// <summary>
        /// 警告
        /// </summary>
        public static void Warn(string str)
        {
            log4Net.Warn(str);
        }

        /// <summary>
        /// 错误
        /// </summary>
        public static void Error(string str) // error为关键字
        {
            log4Net.Error(str);
        }

        /// <summary>
        /// 异常
        /// </summary>
        public static void Fatal(string str)
        {
            log4Net.Fatal(str);
        }

        /// <summary>
        /// 更新日志等级-Debug,Info,Warn,Error,Fatal
        /// </summary>
        public static void UpLogLevel(LogLevel logLevel)
        {
            try
            {
                Level level = Level.Debug;//log4net 自带的类
                switch (logLevel)
                {
                    case LogLevel.Debug:
                        {
                            level = Level.Debug;
                            break;
                        }
                    case LogLevel.Info:
                        {
                            level = Level.Info;
                            break;
                        }
                    case LogLevel.Warn:
                        {
                            level = Level.Warn;
                            break;
                        }
                    case LogLevel.Error:
                        {
                            level = Level.Error;
                            break;
                        }
                    case LogLevel.Fatal:
                        {
                            level = Level.Fatal;
                            break;
                        }
                    default:
                        {
                            level = Level.Debug;
                            break;
                        }
                }

                ((Hierarchy)LogManager.GetRepository()).Root.Level = level;
                ((Hierarchy)LogManager.GetRepository()).RaiseConfigurationChanged(EventArgs.Empty);
            }
            catch (Exception ex)
            {
                Log.Error("Log:" + ex.Message);
                throw;
            }

        }

        #endregion

        #region 方法-日志操作

        /// <summary>
        /// 删除指定日期前的日志
        /// </summary>
        public static void DeleteLog(int dayNum)
        {
            Task.Run(() =>
            {
                try
                {
                    DateTime tempDate;
                    DirectoryInfo dir = new DirectoryInfo(GetFolder());
                    FileInfo[] fileInfo = dir.GetFiles();
                    // 遍历
                    foreach (FileInfo NextFile in fileInfo)
                    {
                        tempDate = NextFile.LastWriteTime;
                        int days = (DateTime.Now - tempDate).Days;
                        if (days > dayNum) File.Delete(NextFile.FullName);
                    }
                }
                catch (Exception ex)
                {
                    Error("Log:" + ex.Message);
                }
            });
        }

        /// <summary>
        /// 获取日志存储文件夹
        /// </summary>
        private static string GetFolder()
        {
            var repository = LogManager.GetRepository();
            var appenders = repository.GetAppenders();
            var targetApder = appenders.First(p => p.Name == "LogFile") as RollingFileAppender;
            return Path.GetDirectoryName(targetApder.File);
        }

        #endregion

        #region 方法-Config配置文件操作

        /// <summary>
        /// 修改配置文件枚举
        /// </summary>
        public enum ModifyInfo 
        { 
            保存地址,
            保存天数
        }

        /// <summary>
        /// 加载配置文件
        /// </summary>
        /// <param name="path"></param>
        public static void LoadXml(string filePath)
        {
            xmlDoc = new ConfigXmlDocument();
            xmlDoc.Load(filePath);
        }

        /// <summary>
        /// 修改配置文件
        /// </summary>
        public static void WriteXml(ModifyInfo modifyInfo,string value)
        {
            XmlNodeList nodelList = xmlDoc.ChildNodes[1].ChildNodes[1].ChildNodes[1].ChildNodes;
            switch (modifyInfo)
            {
                case ModifyInfo.保存地址:
                    nodelList[1].Attributes[1].Value = value;
                    break;
                case ModifyInfo.保存天数:
                    nodelList[5].Attributes[1].Value = value;
                    break;
            }
        }

        /// <summary>
        /// 保存配置文件
        /// </summary>
        /// <param name="filePath"></param>
        public static void SaveXml(string filePath)
        {
            xmlDoc.Save(filePath);
        }

        #endregion
    }
}
