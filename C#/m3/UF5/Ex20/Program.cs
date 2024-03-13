using System;
namespace Activitats
{
    public class Program
    {
        public delegate double MyDelegate(int x);
        public static void Main()
        {
            MyDelegate number = Square;
            int x = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(number(x));
        }
        public static double Square(int x)
        {
            return Math.Sqrt(x);
        }
    }
}