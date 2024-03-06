using System;
using System.Collections.Generic;
namespace Activitats
{
    public class Program
    {
        public static void Main()
        {
            Dictionary<string, int> employeeDic = new Dictionary<string, int>();
            employeeDic.Add("David", 13123);
            employeeDic.Add("Eric", 23234);
            employeeDic.Add("Molanito", 21212);
            foreach (var item in employeeDic)
            {
                Console.WriteLine($"{item.Key} {item.Value}");
            }

        }
    }
}