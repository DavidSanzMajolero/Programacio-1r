using System;
using System.Collections.Generic;
namespace Activitats
{
    class Program
    {
        public static void Main()
        {
            int id = 123;
            string name = "John";
            DateTime date = new DateTime(1990, 12, 12);
            Employee employee = new Employee(id,name,date);
            Console.WriteLine("Employee's age: " + employee.Age(date));

        }
    }
}