using System;

namespace Activitats
{
    public class Table : Furniture
    {
        public int Weight { get; set; }
        public int Price { get; set; }
        public bool Set { get; set; }

        public Table(int weight, int price, bool set, string name, string material, string colour) : base(name, material, colour)
        {
            Weight = weight;
            Price = price;
            Set = set;
        }

        public override string GetInfo()
        {
            return $"Name: {Name}, Material: {Material}, Colour: {Colour}, Weight: {Weight}, Price: {Price}, Set: {Set}";
        }
    }
}
