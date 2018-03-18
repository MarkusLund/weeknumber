using System;
using System.Globalization;

namespace weeknumber
{
    class Program
    {
        static void Main(string[] args)
        {
            var weekNumber = GetIso8601WeekOfYear(DateTime.Now).ToString();
            Console.WriteLine($"Current week number: {weekNumber}");
        }

        // Code written by il_guru (https://stackoverflow.com/questions/11154673/get-the-correct-week-number-of-a-given-date)
        public static int GetIso8601WeekOfYear(DateTime time)
        {
            DayOfWeek day = CultureInfo.InvariantCulture.Calendar.GetDayOfWeek(time);
            if (day >= DayOfWeek.Monday && day <= DayOfWeek.Wednesday)
            {
                time = time.AddDays(3);
            }
            return CultureInfo.InvariantCulture.Calendar.GetWeekOfYear(time, CalendarWeekRule.FirstFourDayWeek, DayOfWeek.Monday);
        }
    }
}
