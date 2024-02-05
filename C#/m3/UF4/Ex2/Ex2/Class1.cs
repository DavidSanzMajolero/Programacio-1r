using System;
using System.ComponentModel.DataAnnotations;


namespace Ex2
{
    internal class Class1
    {
        private string color;
        private string number;

        public Card(string color, string number)
        {
            this.color = SetColor(color);
            this.number = SetNumber(number);
        }
        public string GetColor()
        {
            return this.color;
        }
        public string GetNumber()
        {
            return this.number;
        }
        public void SetColor(string color)
        {
            this.color = color;
        }
        public void SetNumber(string number)
        {
            this.number = number;
        }
    }
}
