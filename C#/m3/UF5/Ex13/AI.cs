using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex13
{
    public class AI
    {
        public bool IsFunctional { get; set; }
        public AI (bool isFunctional)
        {
            IsFunctional = isFunctional;
        }
        public string VerifySystem()
        {
            return "System is functional";
        }
    }
}
