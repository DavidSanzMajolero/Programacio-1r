using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex13
{
    public class SpaceShip : iFlyable
    {
        public BoardComputer BoardComputer { get; set; }
        public NavegationSystem NavegationSystem { get; set; }
        public Rocket Rocket { get; set; }
        public Crew Crew { get; set; }

        public void Pilot()
        {
            Console.WriteLine("Piloted by " + Crew.Name);
        }
    }
}
