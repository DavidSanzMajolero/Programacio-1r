using System;

namespace Ex3
{
    public class Class1
    {
        private int price;
        private string brand, color;

        private int Price
        {
            get { return price; }
            set { price = value; }
        }
        public string Brand
        {
            get { return brand; }
            set { brand = value; }
        }
        public string Color
        {
            get { return color; }
            set { color = value; }
        }
        public Bicycle (int _price, string _brand, string _color)
        {
            this.Price = _price;
            this.Brand = _brand;
            this.Color = _color;
        }
    }
}
