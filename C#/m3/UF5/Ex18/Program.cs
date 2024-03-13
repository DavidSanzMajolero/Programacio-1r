using System;
namespace Activitats
{
    public class Program
    {
        public static void Main()
        {

            List<int> llista = new List<int> { 1, 5, 3, 2, 4 };

            Comparison<int> comp = (int a, int b) => a.CompareTo(b);

            llista.Sort(comp);

            foreach (int i in llista)
            {
                Console.WriteLine(i);
            }
       
        }
    }
}