using System;
using System.Collections.Generic;

namespace Activitats
{
    public class Program
    {
        public static void Main()
        {
            List<int> numbers = new List<int> { 10, 20, 30, 40, 50, 60, 70, 80, 90, 100 };
            int specificValue = 50;
            numbers.RemoveAll(num => num > specificValue);

            Console.WriteLine("Llista després d'eliminar els elements majors que el valor específic:");
            foreach (int num in numbers)
            {
                Console.WriteLine(num);
            }
        }
    }
}
