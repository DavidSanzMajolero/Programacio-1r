using System;
using System.IO;


namespace FileHandling
{
    public class Program
    {
        public static void Main()
        {
            string file = "";
            do
            {
                Console.WriteLine("Enter file name: ");
                file = Console.ReadLine();

            } while (!Verify(file));
            FileHandling(file);
        }

        public static void FileHandling(string file)
        {
            string path = Path.GetFullPath("..\\..\\..\\files\\" + file);
            if (!File.Exists(path))
            {
                Console.WriteLine("Insert text");
                string createText = Console.ReadLine() + Environment.NewLine;
                File.WriteAllText(path, createText);
                Console.WriteLine("Insert text");
                string appendText = Console.ReadLine() + Environment.NewLine;
                File.AppendAllText(path, appendText);
            }
            else
            {
                Console.WriteLine("Insert text");
                string createText = Console.ReadLine() + Environment.NewLine;
                File.WriteAllText(path, createText);
                Console.WriteLine("Insert text");
                string appendText = Console.ReadLine() + Environment.NewLine;
                File.AppendAllText(path, appendText);
            }
        }
        public static bool Verify(string file)
        {
            return file.EndsWith(".txt");
        }
    }
}