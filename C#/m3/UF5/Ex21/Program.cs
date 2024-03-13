using System;
namespace Activitats
{
    public class Program
    {
        public delegate double MyDelegate(int[] x);
        public static void Main()
        {
            MyDelegate num = Average;
            int[] x =  [ 5,4,4,4,4,5,8,1 ];
            Console.WriteLine(num(x));
        }
        public static double Average(int[] x)
        {
            int result = 0;
            for (int i = 0; i < x.Length; i++)
            {
                result += x[i];
            }
            return result / x.Length;
        }
    }
}