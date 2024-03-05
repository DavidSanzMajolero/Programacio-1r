using System;
using System.Data;

namespace Activitats
{
    public class Program
    {
        public static void Main()
        {
            DateTime date = DateTime.Now;
            Console.WriteLine("Today is " + GetDayOfWeek(date));

        }
        public static string GetDayOfWeek(DateTime date)
        {
            return date.DayOfWeek.ToString();
        }
    }
}
