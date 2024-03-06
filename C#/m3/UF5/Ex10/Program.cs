using System;
using System.Collections.Generic;

namespace Activitats
{
    public class Program
    {
        public static void Main()
        {
            string[] strings = new string[] { "david", "arnau", "eric", "asdd" };

            List<string> stringList = new List<string>(strings);

            foreach (string str in stringList)
            {
                Console.WriteLine(str);
            }
        }
    }
}
