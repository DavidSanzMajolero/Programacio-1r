using System;

namespace Activitats
{
    public class Furniture
    {
        private float weight;
        private double price;
        private bool set;
        private string name, material, colour;

        public float Weight
        {
            get { return weight; }
            set { weight = value; }
        }
        public double Price
        {
            get { return price; }
            set { price = value; }
        }
        public bool Set
        {
            get { return set; }
            set { set = value; }
        }
        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        public string Material
        {
            get { return material; }
            set { material = value; }
        }
        public string Colour
        {
            get { return colour; }
            set { colour = value; }
        }
        public Furniture(float weight, double price, bool set, string name, string material, string colour)
        {
            Weight = weight;
            Price = price;
            Set = set;
            Name = name;
            Material = material;
            Colour = colour;
        }
    }
}
