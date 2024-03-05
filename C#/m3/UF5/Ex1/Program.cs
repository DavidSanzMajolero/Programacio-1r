using System;
using System.Collections.Generic;
namespace Activitats
{
    class Program
    {
        public static void Main()
        {
            List<Book> books = new List<Book>
            {
                new Book(1, "Don Quijote", 20),
                new Book(2, "El Quijote", 3010),
                new Book(3, "El Quijote", 424400),
                new Book(4, "El Quijote", 500),
                new Book(5, "El Quijote", 6050),

            };
            foreach (Book book in books)
            {
                Console.WriteLine(book);
            }
            books.Sort();
            Console.WriteLine("**********************************************************************************");
            foreach (Book book in books)
            {
                Console.WriteLine(book);
            }
        }
    }
}


