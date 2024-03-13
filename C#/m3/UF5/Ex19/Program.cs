using System;
namespace Activitats
{
    public class Program
    {
        public delegate double MyDelegate(int a, int b);
        public static void Main()
        {
            MyDelegate power = Helper.Exponent;
            int x = Convert.ToInt32(Console.ReadLine());
            int y = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine(power(x,y));

        }
    }
}