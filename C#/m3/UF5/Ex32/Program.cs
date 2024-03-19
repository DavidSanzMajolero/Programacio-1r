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
            //Implementa mitjançant LINQ un programa per a mostrar els nombres la freqüència d'un nombre en una llista i  la multiplicació dels nombres amb les seves freqüències.
            int[] numeros = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 1, 2, 3, 4, 5, 6, 7, 8, 9, 1, 2, 3, 4, 5, 6, 7, 8, 9, 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            var query = from num in numeros
                        group num by num into g
                        select new { num = g.Key, freq = g.Count() };
            foreach (var item in query)
            {
                Console.WriteLine("Numero: {0} Freqüència: {1} Multiplicació: {2}", item.num, item.freq, item.num * item.freq);
            }

        }
    }
}