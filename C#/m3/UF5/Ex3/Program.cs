﻿using System;

namespace Activitats
{
    public class Program
    {
        public static void Main()
        {
            Console.WriteLine("Day: ");
            int day = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Month: ");
            int month = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Year: ");
            int year = Convert.ToInt32(Console.ReadLine());
            DateTime dateUser = new DateTime(year, month, day);
            //Console.WriteLine(dateUser);
            s
            DateTime dateNow = DateTime.Now;
            //Console.WriteLine(dateNow);

            TimeSpan difference = dateNow - dateUser;
            Console.WriteLine($"The difference in days is: {difference.Days}");

        }
    }
}
