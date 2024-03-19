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

            List<int> list = new List<int> { 1, 2, 3, -4, 5, -6, 7, 8, 9, -10 , 32, 31, 55, 21, 20 , 39, 51};
            var myLinqQuery = from num in list
                              where num >= 20
                              select num;
            foreach (int num in myLinqQuery)
            {
                Console.WriteLine(num + " " + num * num);
            }
        }
    }
}