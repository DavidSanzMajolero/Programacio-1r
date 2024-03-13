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
        public SpaceShip (BoardComputer boardComputer, NavegationSystem navegationSystem, Rocket rocket, Crew crew)
        {
            BoardComputer = boardComputer;
            NavegationSystem = navegationSystem;
            Rocket = rocket;
            Crew = crew;
        }

        public override string ToString()
        {
            return "Piloted by " + this.Crew;
        }

        public void Pilot()
        {
            Console.WriteLine("ASd");
        }
    }
}
