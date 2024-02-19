using System;

namespace Activitats
{
    public class Furniture
    {
        public string Name { get; set; }
        public string Material { get; set; }
        public string Colour { get; set; }

        public Furniture(string name, string material, string colour)
        {
            Name = name;
            Material = material;
            Colour = colour;
        }

        public virtual string GetInfo()
        {
            return $"Name: {Name}, Material: {Material}, Colour: {Colour}";
        }
    }
}
