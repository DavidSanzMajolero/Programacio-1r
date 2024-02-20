using System;

namespace Ex18
{
    public class HourlyWorker : Worker
    {
        public int HoursWorked { get; set; }
        public HourlyWorker(string name, double salary_rate, int hoursWorked) : base(name, salary_rate)
        {
            HoursWorked = hoursWorked;
        }
        public override double computePay()
        {
            return Salary_rate * HoursWorked;
        }
    }
}
