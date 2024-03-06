namespace Activitats
{
    public class SalesEmployee : Employee
    {
        public float Commission { get; set; }

        public SalesEmployee(string name, string surname, string code, DateTime birthDate, DateTime hireDate, float monthSalary, int payments, float commission) : base (name, surname, code, birthDate, hireDate, monthSalary, payments)
        {
            Commission = commission;
        }

        public override string GetFullName()
        {
            return Name + " " + Surname;
        }
        public override string InvertedFullName()
        {
            return Surname + ", " + Name;
        }
        public override int Age()
        {
            int age = DateTime.Now.Year - BirthDate.Year;
            if (DateTime.Now.DayOfYear < BirthDate.DayOfYear) age = age - 1;
            return age;
        }
        public override int Seniority()
        {
            int seniority = DateTime.Now.Year - HireDate.Year;
            if (DateTime.Now.DayOfYear < HireDate.DayOfYear) seniority = seniority - 1;
            return seniority;
        }
        public override float AnnualSalary()
        {
            return MonthlySalary * Payments;
        }
        public override string ToString()
        {
            return $"Code: {Code}\nFirstName: {Name}\nSurname: {Surname}\nFull name: {GetFullName()}\nReverse name: {InvertedFullName()}\nAge: {Age()}\nSeniority: {Seniority()}\nAnnual Salary: {AnnualSalary()}\nCommission: {Commission}";
        }

    }
}
