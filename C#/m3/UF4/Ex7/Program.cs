using System;
namespace Activitats
{
    public class Program
    {
        public static void Main()
        {
            Wolf wolf = new Wolf(50, 5, "Alaskan");
            Turtle turtle = new Turtle(10, 3, "Sea");
            Iguana iguana = new Iguana(5, 2, "Green");
            Console.WriteLine("Wolf");
            Console.WriteLine(wolf.GetInfo() + "\n" + Food("Meat"));
            Console.WriteLine();
            Console.WriteLine("Turtle");
            Console.WriteLine(turtle.GetInfo()+ "\n" + Food("Lettuce"));
            Console.WriteLine();
            Console.WriteLine("Iguana");
            Console.WriteLine(iguana.GetInfo() +"\n"+ Food("Lettuce"));
        }
        public static string Food(string word)
        {
            return word;
        }
    }
}