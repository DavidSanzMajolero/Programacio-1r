using System;
using System.IO;


namespace FileHandling
{
    public class Program
    {
        public static void Main()
        {
            string file = "";
            Console.WriteLine("Enter file name: ");
            file = Console.ReadLine();
            Console.WriteLine("Number of characters in the file: " + Count(file));
        }
        public static int Count(string file)
        {
            int count = 0;
            for (int i = 0; i < file.Length; i++)
            {
                count ++;
            }
            return count;
        }
    }
}