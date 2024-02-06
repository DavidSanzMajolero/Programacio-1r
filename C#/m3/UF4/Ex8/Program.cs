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
            Console.WriteLine(wolf.GetInfo() + "\n" + Animal.Food("Meat"));
            Console.WriteLine();
            Console.WriteLine("Turtle");
            Console.WriteLine(turtle.GetInfo() + "\n" + Animal.Food("Lettuce"));
            Console.WriteLine();
            Console.WriteLine("Iguana");
            Console.WriteLine(iguana.GetInfo() + "\n" + Animal.Food("Lettuce"));
        }

    }
}