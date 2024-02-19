using System;
namespace Activitats
{
    public class Mesa : Furniture
    {
        public Mesa(float weight, double price, bool set, string name, string material, string colour) : base(weight, price, set, name, material, colour){}
        public override string GetInfo(float weight, double price, bool set, string name, string material, string colour)
        {
            return "Weight: " + weight + " Price: " + price + " Set: " + set + " Name: " + name + " Material: " + material + " Colour: " + colour;
        }
    }
}
