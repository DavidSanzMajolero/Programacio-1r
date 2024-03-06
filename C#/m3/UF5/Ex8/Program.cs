using System;
using System.Collections.Generic;

namespace Activitats
{
    public class Program
    {
        public static void Main()
        {
            List<int> nums = new List<int>
            {
                1,
                2,
                3,
                4,
                5,
                6,
                7,
                8,
                9,
                10
            };
            int sum = 0;
            foreach (int num in nums)
            {
                sum += num;
            }
            Console.WriteLine(sum);
        }
    }
}
