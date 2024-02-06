using System;

namespace Activitats
{
    public class Iguana : Animal
    {
        public Iguana(int weight, int age, string breed) : base(weight, age, breed) { }

        public override string GetInfo()
        {
            return base.GetInfo();
        }
    }
}
