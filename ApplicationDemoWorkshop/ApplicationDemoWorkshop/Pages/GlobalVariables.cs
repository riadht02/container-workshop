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
    }

}
