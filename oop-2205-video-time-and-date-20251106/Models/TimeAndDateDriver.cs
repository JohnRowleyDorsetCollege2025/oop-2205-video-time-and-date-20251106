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

            ShowFormattedDateTime(DateTime.Now);
            ShowDateTimeComponents(DateTime.Now);
            int daysToEvent = DaysUntilNextChristmas();
            Console.WriteLine($"Days until next Christmas: {daysToEvent}");

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

        public static void ShowFormattedDateTime(DateTime dateTime)
        {
            Console.WriteLine($"Short Date: {dateTime.ToShortDateString()}");
            Console.WriteLine($"Long Date: {dateTime.ToLongDateString()}");
            Console.WriteLine($"Short Time: {dateTime.ToShortTimeString()}");
            Console.WriteLine($"Long Time: {dateTime.ToLongTimeString()}");
            Console.WriteLine($"Custom Format: {dateTime.ToString("yyyy-MM-dd HH:mm:ss")}");
        }   

        public static void ShowDateTimeComponents(DateTime dateTime)
        {
            Console.WriteLine($"Year: {dateTime.Year}");
            Console.WriteLine($"Month: {dateTime.Month}");
            Console.WriteLine($"Day: {dateTime.Day}");
            Console.WriteLine($"Hour: {dateTime.Hour}");
            Console.WriteLine($"Minute: {dateTime.Minute}");
            Console.WriteLine($"Second: {dateTime.Second}");
        }

        public static int DaysUntilNextChristmas()
        {
            DateTime today = DateTime.Today;
            DateTime nextChristmas = new DateTime(today.Year, 12, 25);
            if (today > nextChristmas)
            {
                nextChristmas = nextChristmas.AddYears(1);
            }
            TimeSpan difference = nextChristmas - today;
            return difference.Days;
        }


    }
}
