using System;
namespace Activitats
{
    public class Program
    {
        public static void Main()
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Ship ship = new Ship(23213, "Barcos Requena", "213412A", true, 200);
            Console.WriteLine("Ship");
            Console.WriteLine(ship.GetInfo());
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.Blue;
            Bike bike = new Bike(456456, "Decathlon", "3223A", 2, false);
            Console.WriteLine("Bike");
            Console.WriteLine(bike.GetInfo());
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.Red;
            Truck truck = new Truck(43554, "Ford", "92929A", 6, 3750, true, 7);
            Console.WriteLine("Truck");
            Console.WriteLine(truck.GetInfo());
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.Magenta;
            Turism turism = new Turism(54345, "Ferrari", "43223A", 4, 2100, false, true);
            Console.WriteLine("Turism");
            Console.WriteLine(turism.GetInfo());
            Console.ResetColor();

        }
    }
}