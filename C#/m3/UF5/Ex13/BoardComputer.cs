using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex13
{
    public class BoardComputer
    {
        public AI AI { get; set; }
        public BoardComputer(AI ai)
        {
            AI = ai;
        }
    }
}
