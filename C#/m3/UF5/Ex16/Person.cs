using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Activitats
{
    public class Person
    {
        public string Name { get; set; }
        public int YearsOld { get; set; }
        public Person(string name, int yearsOld)
        {
            Name = name;
            YearsOld = yearsOld;
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();

            sb.Append("Nom: ");
            sb.Append(Name);
            sb.Append("\tEdat: ");
            sb.Append(YearsOld);

            return sb.ToString();
        }
    }
}
