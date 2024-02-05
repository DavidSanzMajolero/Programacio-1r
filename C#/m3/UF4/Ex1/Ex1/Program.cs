using System;
namespace Ex1
{
    public class Program
    {
        public static void Main()
        {
            Person person = new Person();
            person.Name = "Karles ";
            person.Surname = "Toráh ";
            person.Age = 20;
            person.Id = 123;

            Console.WriteLine(person.Name + person.Surname + person.Age + " " + person.Id);

        }
    }
}
