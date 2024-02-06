using System;

namespace Activitats
{
    public class Wolf : Animal
    {
        public Wolf(int weight, int age, string breed) : base(weight, age, breed) { }

        public override string GetInfo()
        {
            return base.GetInfo();
        }
    }
}
