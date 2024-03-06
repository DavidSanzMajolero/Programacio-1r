

namespace Activitats
{
    public class Employee
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime Date { get; set; }

        public Employee(int id, string name, DateTime date)
        {
            Id = id;
            Name = name;
            Date = date;
        }
        public int Age(DateTime date)
        {
            return DateTime.Now.Year - date.Year;
        }
    }
}
