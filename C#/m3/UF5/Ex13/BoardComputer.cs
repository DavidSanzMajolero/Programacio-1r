using System;

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
