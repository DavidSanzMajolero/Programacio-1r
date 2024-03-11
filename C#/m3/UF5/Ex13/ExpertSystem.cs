using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex13
{
    public class ExpertSystem
    {
        public float TakeoffAngle { get; set; }
        public ExpertSystem(float takeoffAngle)
        {
            TakeoffAngle = takeoffAngle;
        }
        public float Angle() { return TakeoffAngle; }



    }
}
