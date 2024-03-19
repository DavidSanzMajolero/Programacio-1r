using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
namespace Activitats
{
    public class Program
    {
        public static void Main()
        {
            string[] daysWeek = new string[] { "Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday", "Sunday" };
            var days = from day in daysWeek
                       select day;
            foreach (var day in days)
            {
                Console.WriteLine(day);
            }
        }
    }
}