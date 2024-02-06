using System;

namespace Activitats
{
    public class Animal
    {
        public Animal(int weight, int age, string breed)
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
        public static string Food(string word)
        {
            return word;
        }
    }
}