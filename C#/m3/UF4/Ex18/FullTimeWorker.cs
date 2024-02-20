using System;


namespace Ex18
{
    public class FullTimeWorker : Worker
    {
        public int HoursWorked { get; set; }
        public FullTimeWorker(string name, double salary_rate, int hoursWorked) : base(name, salary_rate)
        {
            HoursWorked = hoursWorked;
        }
        public override double computePay()
        {
            return Salary_rate * HoursWorked;
        }
    }
}
