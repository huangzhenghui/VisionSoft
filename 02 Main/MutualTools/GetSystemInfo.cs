using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace MutualTools
{
    public class GetSystemInfo
    {
        [DllImport("kernel32")]
        private static extern void GlobalMemoryStatus(ref StorageInfo memibfo);

        public struct StorageInfo //此处全是以字节为单位
        {
            public uint dwLength;//长度
            public uint dwMemoryLoad;//内存使用率
            public uint dwTotalPhys;//总物理内存
            public uint dwAvailPhys;//可用物理内存
            public uint dwTotalPageFile;//交换文件总大小
            public uint dwAvailPageFile;//可用交换文件大小
            public uint dwTotalVirtual;//总虚拟内存
            public uint dwAvailVirtual;//可用虚拟内存大小
        }

        /// <summary>
        /// 获取CPU利用率
        /// </summary>
        /// <returns></returns>
        public static string GetCPUUR()
        {
            PerformanceCounter pc = new PerformanceCounter("Processor", "% Processor Time", "_Total", true);
            pc.NextValue().ToString();
            Thread.Sleep(1000);
            return pc.NextValue().ToString("0")+"%";
        }

        /// <summary>
        /// 获取内存利用率
        /// </summary>
        /// <returns></returns>
        public static string GetRAMUR()
        {
            StorageInfo memInfor = new StorageInfo();
            GlobalMemoryStatus(ref memInfor);
            return memInfor.dwMemoryLoad.ToString()+"%";
        }

        /// <summary>
        /// 获取磁盘利用率
        /// </summary>
        /// <param name="diskName"></param>
        /// <returns></returns>
        public static string GetDiskUR(string diskName)
        {
            string diskUR = "";
            diskName = diskName + ":\\";
            DriveInfo[] drives = DriveInfo.GetDrives();
            foreach (DriveInfo drive in drives)
            {
                if (drive.Name == diskName)
                {
                    diskUR = ((float)(drive.TotalSize - drive.TotalFreeSpace) / (float)drive.TotalSize).ToString("P");
                }
            }
            return diskUR;
        }

        /// <summary>
        /// 获取系统时间
        /// </summary>
        /// <returns></returns>
        public static string GetSystemTime()
        {
            string time = DateTime.Now.ToLocalTime().ToString();
            return time;
        }
    }
}
