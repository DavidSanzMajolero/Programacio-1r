using System;

namespace Activitats
{
    public class Turtle : Animal
    {
        public Turtle(int weight, int age, string breed) : base(weight, age, breed) { }

        public override string GetInfo()
        {
            return base.GetInfo();
        }
    }
}
