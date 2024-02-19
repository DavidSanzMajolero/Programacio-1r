using System;
namespace Activitats
{
    public class Ex15
    {
        public static void Main()
        {
            Mesa mesa = new Mesa(10, 100, true, "Table", "Wood", "Brown");
            Console.WriteLine(mesa.GetInfo(mesa.Weight, mesa.Price, mesa.Set, mesa.Name, mesa.Material, mesa.Colour));
        }
    }
}