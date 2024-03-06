using System;
using System.Text.RegularExpressions;

namespace Activitats
{
    public class Program
    {
        public static void Main()
        {
            //a
            string input = "Hello123"; 
            Regex regex = new Regex("^[a-zA-Z0-9]+$");
            if (regex.IsMatch(input)) Console.WriteLine("La cadena conté només caràcters alfanumèrics (a-z, A-Z, 0-9).");
            else Console.WriteLine("La cadena conté altres caràcters que no són alfanumèrics (a-z, A-Z, 0-9).");

            //b
            string input2 = "abbbbb";
            Regex regex2 = new Regex("ab*");
            if (regex2.IsMatch(input2)) Console.WriteLine("La cadena conté una a seguida de zero o més b's.");
            else Console.WriteLine("La cadena no conté una a seguida de zero o més b's.");

            //c
            string input3 = "aabbb";
            Regex regex3 = new Regex("ab{2,3}");
            if (regex3.IsMatch(input3)) Console.WriteLine("La cadena conté una a seguida de dos o tres b's.");
            else Console.WriteLine("La cadena no conté una a seguida de dos o tres b's.");

            //d
            string input4 = "hola_mundo";
            Regex regex4 = new Regex("[a-z]+_[a-z]+");
            if (regex4.IsMatch(input4)) Console.WriteLine("La cadena conté una seqüència de lletres minúscules unides amb un guió baix.");
            else Console.WriteLine("La cadena no conté una seqüència de lletres minúscules unides amb un guió baix.");



        }
    }
}
