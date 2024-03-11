﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex13
{
    public class LandingSystem
    {
        public ExpertSystem ExpertSystem { get; set; }
        public LandingSystem(ExpertSystem expertSystem)
        {
            ExpertSystem = expertSystem;
        }
        public string Landing() { return "SpaceShip landed successfully"; }

    }
}
