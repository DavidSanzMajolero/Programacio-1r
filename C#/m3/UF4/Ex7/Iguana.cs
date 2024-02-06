using System;
namespace Activitats
{
    public class Iguana
    {
        public Iguana(int weight, int age, string breed)
        {
            Weight = weight;
            Age = age;
            Breed = breed;
        }
        public int Weight { get; set; }
        public string Breed { get; set; }
        public int Age { get; set; }
        public virtual string GetInfo()
        {
            return $"Weight: {Weight}\nAge: {Age}\nBreed: {Breed}";
        }

    }
}
