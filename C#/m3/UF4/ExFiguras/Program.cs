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
            float area = Figures.Area(triangle.Base, triangle.Height);
            Console.WriteLine("Triangle Area: " + area);
            Square square = new Square();
            square.Side = 3;
            area = Figures.Area(square.Side);
            Console.WriteLine("Square Area: " + area);
            Cercle cercle = new Cercle();
            cercle.Radi = 5;
            area = Figures.AreaRad(cercle.Radi);
            Console.WriteLine("Cercle Area  " + area);

        }

    }
}