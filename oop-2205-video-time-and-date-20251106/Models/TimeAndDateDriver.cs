using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oop_2205_video_time_and_date_20251106.Models
{
    internal static class TimeAndDateDriver
    {
        public static void Run()
        {
            Console.WriteLine("Time and Date Example");
            ShowAppDetails();
            ShowCurrentDateTime();

        }   

        public static void ShowAppDetails()
        {
             AppConstants.DisplayAppInfo();
          
        }

        public static void ShowCurrentDateTime()
        {
            DateTime now = DateTime.Now;
            Console.WriteLine($"Current Date and Time: {now}");

            DateTime utcNow = DateTime.UtcNow;
            Console.WriteLine($"Current Date and Time: {utcNow}");
        }

    }
}
