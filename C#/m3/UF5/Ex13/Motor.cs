using System;

namespace Ex13
{
    public class Motor
    {
        public int Code { get; set; }
        public Motor(int code)
        {
            Code = code;
        }
        public static Motor Fabricate()
        {
            Random random = new Random();
            return new Motor(random.Next(100, 999));
        }
        public string Activate(int code, int fuel) { return code == Code ? fuel > 0 ? "Motor activated" : "No fuel" : "Code Error"; }
        public string Stop() {return "Motor stopped";}


    }
}