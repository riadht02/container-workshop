using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Diagnostics;

namespace ApplicationDemoWorkshop.Pages
{
    public class GlobalVariables
    {
        public static int SessionCount = 0;
        public static string hostname = Environment.MachineName;
        public static string osver = Environment.OSVersion.ToString();

        public static string GetCpuUsageForProcess()
        {
            var startTime = DateTime.UtcNow;
            var startCpuUsage = Process.GetCurrentProcess().TotalProcessorTime;
            Task.Delay(500).Wait();

            var endTime = DateTime.UtcNow;
            var endCpuUsage = Process.GetCurrentProcess().TotalProcessorTime;
            var cpuUsedMs = (endCpuUsage - startCpuUsage).TotalMilliseconds;
            var totalMsPassed = (endTime - startTime).TotalMilliseconds;
            var cpuUsageTotal = cpuUsedMs / (Environment.ProcessorCount * totalMsPassed);
            return string.Format("{0:P2}", cpuUsageTotal * 100) ;
        }
    }

   

}
