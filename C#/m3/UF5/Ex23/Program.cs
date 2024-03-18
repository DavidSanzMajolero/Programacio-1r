using System;
namespace Activitats
{

    public delegate int FibonacciDelegate(int n);

    public class Program
    {
        static void Main()
        {
            FibonacciDelegate fibonacciDelegate = FibonacciCalculator.Fibonacci;

            int position = 5;

            int result = fibonacciDelegate(position);

            Console.WriteLine($"El número Fibonacci de la posició {position} és: {result}");
        }
    }
    public class FibonacciCalculator
    {
        public static int Fibonacci(int n)
        {
            if (n <= 1)
                return n;
            else
                return Fibonacci(n - 1) + Fibonacci(n - 2);
        }
    }
}