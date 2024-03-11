using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex13
{
    public abstract class Crew
    {
        public string Name { get; set; }
        public string Surmane { get; set; }
        public Crew(string name, string surname)
        {
            Name = name;
            Surmane = surname;
        }
    }
}
