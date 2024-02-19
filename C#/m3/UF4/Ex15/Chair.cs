using System;

namespace Activitats
{
    public class Chair : Furniture
    {
        public int Legs { get; set; }

        public Chair(string name, string material, string colour, int legs) : base(name, material, colour)
        {
            Legs = legs;
        }

        public override string GetInfo()
        {
            return $"Name: {Name}, Material: {Material}, Colour: {Colour}, Legs: {Legs}";
        }
    }
}
