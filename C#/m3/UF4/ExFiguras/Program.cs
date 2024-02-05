using System;
namespace ExFiguras
{
    public class Program
    {
        public static void Main()
        {
            Triangle triangle = new Triangle();
            triangle.Base = 10;
            triangle.Height = 5;
            float area = Area(triangle.Base, triangle.Height);
            Console.WriteLine("Triangle Area: " + area);
            Square square = new Square();
            square.Side = 3;
            area = Area(square.Side);
            Console.WriteLine("Square Area: " + area);
            Cercle cercle = new Cercle();
            cercle.Radi = 5;
            area = AreaRad(cercle.Radi);
            Console.WriteLine("Cercle Area: " + area);

        }
        public static float Area(float fBase, float height)
        {
            return (fBase * height) / 2;
        }
        public static float Area(float side)
        {
            return side * side;
        }
        public static float AreaRad(float radi)
        {
            return (float)Math.PI * radi * radi;
        }
    }
}