using System;


namespace Ex18
{
    public abstract class Worker
    {
        public string Name { get; set; }
        public double Salary_rate { get; set; }

        public Worker(string name, double salary_rate)
        {
            Name = name;
            Salary_rate = salary_rate;
        }
        public virtual string getName ()
        {
            return Name;
        }
        public virtual double getSalary_rate()
        {
            return Salary_rate;
        }
        public abstract double computePay();
    }
}
