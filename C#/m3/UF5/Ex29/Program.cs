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

            List<int> list = new List<int> { 1, 2, 3, -4, 5, -6, 7, 8, 9, -10, 2 , 3, 4,5,5,5,5,1 };
            var myLinqQuery2 = from num in list
                              group num by num into g
                              select new { num = g.Key, freq = g.Count() };
            foreach (var num in myLinqQuery2)
            {
                Console.WriteLine("Nombre: " + num.num + " Freqüència: " + num.freq);
            }
            
        }
    }
}