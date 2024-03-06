using System;

namespace Activitats
{
    public class Employee
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Code { get; set; }
        public DateTime BirthDate { get; set; }
        public DateTime HireDate { get; set; }
        public float MonthlySalary { get; set; }
        public int Payments { get; set; }


        private static int employeeCount = 0;

        public Employee(string name, string surname, string code, DateTime birthDate, DateTime hireDate, float monthSalary = 1800, int payments = 14)
        {
            Name = name;
            Surname = surname;
            Code = code;
            BirthDate = birthDate;
            HireDate = hireDate;
            MonthlySalary = monthSalary;
            Payments = payments;
            employeeCount++;
        }

        public static int EmployeeCount
        {
            get { return employeeCount; }
        }
        public virtual string GetFullName()
        {
            return Name + " " + Surname;
        }
        public virtual string InvertedFullName()
        {
            return Surname + ", " + Name;
        }
        public virtual int Age( )
        {
            int age = DateTime.Now.Year - BirthDate.Year;
            if (DateTime.Now.DayOfYear < BirthDate.DayOfYear) age = age - 1;
            return age;
        }
        public virtual int Seniority()
        {
            int seniority = DateTime.Now.Year - HireDate.Year;
            if (DateTime.Now.DayOfYear < HireDate.DayOfYear) seniority = seniority - 1;
            return seniority;
        }
        public virtual float AnnualSalary()
        {
            return MonthlySalary * Payments;
        }
        public override string ToString()
        {
            return $"Code: {Code}\nFirstName: {Name}\nSurname: {Surname}\nFull name: {GetFullName()}\nReverse name: {InvertedFullName()}\nAge: {Age()}\nSeniority: {Seniority()}\nAnnual Salary: {AnnualSalary()}"; 
        }
    }
}
