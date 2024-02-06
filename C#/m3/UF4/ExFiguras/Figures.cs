using System;


namespace ExFiguras
{
    public abstract class Figures
    {
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
        public Figures(float x, float y)
        {
            X = x;
            Y = y;
        }
        public float X { get; set; }
        public float Y { get; set; }



    }
}
