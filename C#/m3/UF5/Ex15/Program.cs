using System;
using System.Text.RegularExpressions;
namespace Activitats
{
    public class Program
    {
        public static void Main()
        {
            Regex regex = new Regex(@"^[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,}$");
            string email;
            do
            {
                Console.WriteLine("Introdueix el teu email: ");
                email = Console.ReadLine();
            } while (!regex.IsMatch(email));
        }
    }
}