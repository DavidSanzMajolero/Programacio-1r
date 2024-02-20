using System;
namespace Ex18
{
    public class Program
    {
        public static void Main()
        {
            FullTimeWorker ftw = new FullTimeWorker("Pepe", 10, 40);
            HourlyWorker hw = new HourlyWorker("Pepa", 10, 40);
            Console.WriteLine("Full Time Worker: " + ftw.getName() + " " + ftw.computePay());
            Console.WriteLine("Hourly Worker: " + hw.getName() + " " + hw.computePay());
        }
    }
}