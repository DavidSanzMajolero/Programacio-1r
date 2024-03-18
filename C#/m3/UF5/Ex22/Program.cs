using System;
namespace Activitats
{
    public class Program
    {
        public delegate double MyDelegate(int x);
        public static void Main()
        {
            MyDelegate num = EvenOdd;
            int x = Convert.ToInt32(Console.ReadLine());
            if (num(x) == 5)
            {
                Console.WriteLine("El número es impar");
            }
            else
            {
                Console.WriteLine(num(x));
            }
        }
        public static double EvenOdd(int x)
        {
            if (x % 2 == 0)
            {
                return x * 2;
            }
            else
            {
                return 5;
            }
        }

    }
}