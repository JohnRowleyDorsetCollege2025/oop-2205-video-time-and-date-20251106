using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oop_2205_video_time_and_date_20251106.Models
{
    internal static class AppConstants
    {
        public const string AppName = "Time and Date Example";  
        public const string Version = "1.0.0";

        internal static void DisplayAppInfo()
        {
            Console.WriteLine(AppConstants.AppName);
            Console.WriteLine(AppConstants.Version);
        }
    }
}
