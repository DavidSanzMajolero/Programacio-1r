using System;
namespace Activitats
{
    public class Ex12
    {
        public static void Main()
        {
            Furniture furniture = new Furniture(10, 100, true, "Table", "Wood", "Brown");
            Console.WriteLine("Weight: " + furniture.Weight);
            Console.WriteLine("Price: " + furniture.Price);
            Console.WriteLine("Set: " + furniture.Set);
            Console.WriteLine("Name: " + furniture.Name);
            Console.WriteLine("Material: " + furniture.Material);
            Console.WriteLine("Colour: " + furniture.Colour);
        }
    }
}