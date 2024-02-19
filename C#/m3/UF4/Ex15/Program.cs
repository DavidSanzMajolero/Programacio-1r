using System;

namespace Activitats
{
    public class Ex15
    {
        public static void Main()
        {
            Table table = new Table(10, 100, true, "Table", "Wood", "Brown");
            Chair chair = new Chair("Chair", "Metal", "Black", 4);

            Console.WriteLine(table.GetInfo());
            Console.WriteLine(chair.GetInfo());
        }
    }
}
