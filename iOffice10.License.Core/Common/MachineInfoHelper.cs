using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Management;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace iOffice10.License.Core.Common
{
    internal enum WmiType
    {
        Win32_Processor,
        Win32_PerfFormattedData_PerfOS_Memory,
        Win32_PhysicalMemory,
        Win32_NetworkAdapterConfiguration,
        Win32_LogicalDisk
    }
    public class MachineInfoHelper
    {



        static Dictionary<string, ManagementObjectCollection> WmiDict = new Dictionary<string, ManagementObjectCollection>();

        static MachineInfoHelper()
        {
            var names = Enum.GetNames(typeof(WmiType));
            foreach (string name in names)
            {
                WmiDict.Add(name, new ManagementObjectSearcher("SELECT * FROM " + name).Get());
            }
        }

        /// <summary>
        /// 获取硬盘号码
        /// </summary>
        /// <returns></returns>
        public static string GetHardDiskNumber()
        {
            var query = WmiDict[WmiType.Win32_LogicalDisk.ToString()];
            //var collection = query.Get();

            string result = string.Empty;
            foreach (var obj in query)
            {
                result = obj["VolumeSerialNumber"].ToString();
                break;
            }

            return result;
        }

        /// <summary>
        /// 获取CPU号码
        /// </summary>
        /// <returns></returns>
        public static string GetCPUNumber()
        {
            var query = WmiDict[WmiType.Win32_Processor.ToString()];
            //var collection = query.Get();

            string result = string.Empty;
            foreach (var obj in query)
            {
                result = obj["Processorid"].ToString();
                break;
            }

            return result;
        }

        /// <summary>
        /// 获取内存编号
        /// </summary>
        /// <returns></returns>
        public static string GetMemoryNumber()
        {
            var query = WmiDict[WmiType.Win32_PhysicalMemory.ToString()];
            //var collection = query.Get();

            string result = string.Empty;
            foreach (var obj in query)
            {
                result = obj["PartNumber"].ToString();
                break;
            }
            return result;
        }

        /// <summary>
        /// 获取硬盘信息
        /// </summary>
        /// <returns></returns>
        public static string HardDiskInfo()
        {
            DriveInfo[] drives = DriveInfo.GetDrives();
            StringBuilder sr = new StringBuilder();
            foreach (DriveInfo drive in drives)
            {
                if (drive.IsReady)
                {
                    var val1 = (double)drive.TotalSize / 1024 / 1024;
                    var val2 = (double)drive.TotalFreeSpace / 1024 / 1024;
                    sr.AppendFormat("{0}:{2}/{3}MB/{4}MB/{1}%可用;",
                        drive.Name,
                        string.Format("{0:F2}", val2 / val1 * 100),
                        drive.DriveFormat,
                        (long)val1,
                        (long)val2);
                }
            }
            return sr.ToString();
        }

        /// <summary>
        /// 获取操作系统信息
        /// </summary>
        /// <returns></returns>
        public static string OSInfo()
        {
            StringBuilder sr = new StringBuilder();
            sr.AppendFormat("机器名:{0};操作系统:{1};系统文件夹:{2};语言:{3};.NET:{4};当前目录:{5};当前用户:{6};",
                Environment.MachineName,
                Environment.OSVersion,
                Environment.SystemDirectory,
                CultureInfo.InstalledUICulture.EnglishName,
                Environment.Version,
                Environment.CurrentDirectory,
                Environment.UserName);
            return sr.ToString();
        }

        /// <summary>
        /// 获取网卡信息
        /// </summary>
        /// <returns></returns>
        //public static string NetworkInfo()
        //{
        //    StringBuilder sr = new StringBuilder();

        //    string host = Dns.GetHostName();
        //    IPHostEntry ipEntry = Dns.GetHostByName(host);
        //    sr.Append("IPv4:" + ipEntry.AddressList[0] + "/");

        //    sr.Append("IPv6:");
        //    ipEntry = Dns.GetHostEntry(host);
        //    sr.Append("IPv6:" + ipEntry.AddressList[0] + ";");

        //    sr.Append("MAC:");
        //    var query = WmiDict[WmiType.Win32_NetworkAdapterConfiguration.ToString()];
        //    foreach (var obj in query)
        //    {
        //        if (obj["IPEnabled"].ToString() == "True")
        //            sr.Append(obj["MacAddress"] + ";");
        //    }

        //    return sr.ToString();
        //}

        /// <summary>
        /// 获取内存信息
        /// </summary>
        /// <returns></returns>
        public static string MemoryInfo()
        {
            StringBuilder sr = new StringBuilder();
            long capacity = 0;
            var query = WmiDict[WmiType.Win32_PhysicalMemory.ToString()];
            int index = 1;
            foreach (var obj in query)
            {
                sr.Append("内存" + index + "频率:" + obj["ConfiguredClockSpeed"] + ";");
                capacity += Convert.ToInt64(obj["Capacity"]);
                index++;
            }
            sr.Append("总物理内存:");
            sr.Append(capacity / 1024 / 1024 + "MB;");

            query = WmiDict[WmiType.Win32_PerfFormattedData_PerfOS_Memory.ToString()];
            sr.Append("总可用内存:");
            long available = 0;
            foreach (var obj in query)
            {
                available += Convert.ToInt64(obj.Properties["AvailableMBytes"].Value);
            }
            sr.Append(available + "MB;");
            sr.AppendFormat("{0:F2}%可用; ", (double)available / (capacity / 1024 / 1024) * 100);

            return sr.ToString();
        }

        /// <summary>
        /// 获取CPU信息
        /// </summary>
        /// <returns></returns>
        public static string CpuInfo()
        {
            StringBuilder sr = new StringBuilder();

            var query = WmiDict[WmiType.Win32_Processor.ToString()];
            foreach (var obj in query)
            {
                sr.Append("厂商:" + obj["Manufacturer"] + ";");
                sr.Append("产品名称:" + obj["Name"] + ";");
                sr.Append("最大频率:" + obj["MaxClockSpeed"] + ";");
                sr.Append("当前频率:" + obj["CurrentClockSpeed"] + ";");
            }

            return sr.ToString();
        }
        /// <summary>
        /// 获取机器指纹
        /// </summary>
        /// <returns></returns>
        public static string GetMachineFingerprint() {

            //string str = "要加密的内容";
            //byte[] result = Encoding.Default.GetBytes(str);    //tbPass为输入密码的文本框
            //MD5 md5 = new MD5CryptoServiceProvider();
            //byte[] output = md5.ComputeHash(result);
            //string finalstr = BitConverter.ToString(output).Replace("-", "");

            //暂时返回cpu号md5值作为当前机器指纹
            var bytes = Encoding.Default.GetBytes(GetCPUNumber());
            MD5 md5 = new MD5CryptoServiceProvider();
            byte[] md5Hash = md5.ComputeHash(bytes);
            var result = BitConverter.ToString(md5Hash).Replace("-","");
            return result;
        }
    }
}
