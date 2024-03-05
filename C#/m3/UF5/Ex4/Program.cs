using System;
using System.Data;

namespace Activitats
{
    public class Program
    {
        public static void Main()
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Day: ");
            int day = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Month: ");
            int month = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Year: ");
            int year = Convert.ToInt32(Console.ReadLine());
            DateTime dateUser = new DateTime(year, month, day);

            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("Day: ");
            int day2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Month: ");
            int month2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Year: ");
            int year2 = Convert.ToInt32(Console.ReadLine());
            DateTime dateUser2 = new DateTime(year2, month2, day2);

            Console.ForegroundColor = ConsoleColor.Red;
            TimeSpan difference = dateUser2 - dateUser;
            if (difference.Days > 0) Console.WriteLine("First date is before the second date");
            else Console.WriteLine("First date is after the second date");
            Console.ResetColor();

        }
    }
}
