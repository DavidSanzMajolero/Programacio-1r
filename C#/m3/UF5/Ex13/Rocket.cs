using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex13
{
    public class Rocket
    {
        public string Combustion { get; set; }
        public int Propellants { get; set; }

        public Rocket(string combustion, int propellants)
        {
            Combustion = combustion;
            Propellants = propellants;
        }


        public static bool InOrbit()
        {
            return true;
        }
    }
}
