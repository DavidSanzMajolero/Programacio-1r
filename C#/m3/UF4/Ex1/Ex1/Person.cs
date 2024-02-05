using System;


namespace Ex1
{
    public class Person
    {
        private string name;
        private string surname;
        private int age;
        private int id;

        public string Name 
        { 
            get { return name; } 
            set { name = value; }
        }
        public string Surname
        {
            get { return surname; }
            set { surname = value; }
        }
        public int Age 
        { 
            get { return age; } 
            set {  age = value; } 
        }
        public int Id
        {
            get { return id; }
            set { id = value; }
        }
    }
}
