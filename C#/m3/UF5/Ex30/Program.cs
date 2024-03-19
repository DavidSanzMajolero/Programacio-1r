    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    namespace Activitats
    {
        public class Program
        {
            public static void Main()
            {
                string cadena = "Hola, que ase?";
                foreach (char c in cadena)
                {
                    var myLinQuery = from x in cadena
                                     where x == c
                                     select x;

                    int timesChar = myLinQuery.Count();
                    Console.WriteLine(c + " " + "Frequencia " + timesChar);
                }
            }
        }
    }