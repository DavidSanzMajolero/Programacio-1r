using System;
using System.Collections.Generic;
using System.Linq;

namespace Activitats
{
    class Program
    {
        public static void Main()
        {
            DateTime bdEmployeeOne = new DateTime(1990, 12, 12);
            DateTime hdEmployeeOne = new DateTime(2012, 12, 12);
            DateTime bdEmployeeTwo = new DateTime(1995, 12, 12);
            DateTime hdEmployeeTwo = new DateTime(2015, 12, 12);
            DateTime bdEmployeeThree = new DateTime(1990, 12, 12);
            DateTime hdEmployeeThree = new DateTime(2013, 12, 12);
            DateTime bdEmployeeFour = new DateTime(1995, 12, 12);
            DateTime hdEmployeeFour = new DateTime(2005, 12, 12);
            DateTime bdEmployeeFive = new DateTime(1990, 12, 12);
            DateTime hdEmployeeFive = new DateTime(2021, 12, 12);
            DateTime bdEmployeeSix = new DateTime(1995, 12, 12);
            DateTime hdEmployeeSix = new DateTime(2024, 12, 12);
            DateTime bdEmployeeSeven = new DateTime(1990, 12, 12);
            DateTime hdEmployeeSeven = new DateTime(2019, 12, 12);
            DateTime bdEmployeeEight = new DateTime(1995, 12, 12);
            DateTime hdEmployeeEight = new DateTime(2018, 12, 12);
            DateTime bdEmployeeNine = new DateTime(1990, 12, 12);
            DateTime hdEmployeeNine = new DateTime(2017, 12, 12);
            DateTime bdEmployeeTen = new DateTime(1995, 12, 12);
            DateTime hdEmployeeTen = new DateTime(2016, 12, 12);

            List<Employee> employees = new List<Employee>
            {
                new Employee("Pepa", "Sanz", "346", bdEmployeeSix, hdEmployeeSix, 6500, 12),
                new Employee("Pepa", "Sanz", "346", bdEmployeeSeven, hdEmployeeSeven, 4500, 12),
                new Employee("Pepa", "Sanz", "346", bdEmployeeEight, hdEmployeeEight, 1300, 12),
                new Employee("Pepa", "Sanz", "346", bdEmployeeNine, hdEmployeeNine, 2570, 12),
                new Employee("Pepa", "Sanz", "346", bdEmployeeTen, hdEmployeeTen, 2880, 12),
            };

            List<SalesEmployee> salesEmployees = new List<SalesEmployee>
            {
                new SalesEmployee("David", "Sanz", "343", bdEmployeeOne, hdEmployeeOne, 1280, 12, 2),
                new SalesEmployee("Pepe", "Sanz", "344", bdEmployeeTwo, hdEmployeeTwo, 2330, 12, 2),
                new SalesEmployee("Molano", "Sanz", "345", bdEmployeeThree, hdEmployeeThree, 3300, 12, 2),
                new SalesEmployee("Requenita", "Sanz", "346", bdEmployeeFour, hdEmployeeFour, 2230, 12, 2),
                new SalesEmployee("Erikson Mohamed III", "Sanz", "346", bdEmployeeFive, hdEmployeeFive, 2399, 12, 2),
            };

            // Ordenar empleats per antiguitat descendent
            employees = employees.OrderByDescending(emp => emp.HireDate).ToList();
            salesEmployees = salesEmployees.OrderByDescending(emp => emp.HireDate).ToList();

            // Mostrar empleats
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Employees:");
            Console.ForegroundColor = ConsoleColor.Blue;
            foreach (Employee employee in employees)
            {
                Console.WriteLine(employee.ToString());
                Console.WriteLine();
            }

            // Mostrar empleats de venda
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Sales Employees:");
            Console.ForegroundColor = ConsoleColor.Yellow;
            foreach (SalesEmployee salesEmployee in salesEmployees)
            {
                Console.WriteLine(salesEmployee.ToString());
                Console.WriteLine();
            }
            Console.ResetColor();
        }
    }
}
