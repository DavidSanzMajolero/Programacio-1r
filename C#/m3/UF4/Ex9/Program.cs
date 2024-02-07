using System;
namespace Ex9
{
    public class Program
    {

        public static void Main()
        {
            Llibre llibre = new Llibre("El Quijote", "Editorial", "01/01/1605", 1.5f, 200, "Cervantes", "Novela");
            Revista revista = new Revista("Pepe", "Editorial", "01/01/1981", 0.5f, 100, "Varios", "Divulgación");
            Diari diari = new Diari("El País", "Editorial", "01/01/1981", 0.5f, 100, "Varios", "Divulgación");
            Console.Write("Llibre: ");
            Console.WriteLine(llibre.GetInfo()+"\n"+ llibre.Desplç()+"\n"+!llibre.Estripat());
            Console.WriteLine();
            Console.Write("Revista: ");
            Console.WriteLine(revista.GetInfo() + "\n" + revista.Desplç() + "\n" + revista.Estripat());
            Console.WriteLine();
            Console.Write("Diari: ");
            Console.WriteLine(diari.GetInfo() + "\n" + diari.Desplç() + "\n" + diari.Estripat());

        }
    }
}