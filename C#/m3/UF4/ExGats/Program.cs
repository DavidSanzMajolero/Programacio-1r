using Clinica;
using OOPVisita;
using System.ComponentModel;

namespace OOPVista
{
    class Program
    {
        static void Main()
        {

            string motiuUrgencia = "Fimosis";

            DateTime fecha = new DateTime(2024, 2, 13);
            Visita visita = new Visita("51250429F", "Arnau", fecha, motiuUrgencia);
            Pacient pacient = new Pacient("Arnau", "Siames", 18, false, "51250429F", "Arnau", fecha, motiuUrgencia);
            Propietari propietari = new Propietari("51250429F", "Eric", "Requenita Jimenez", 666666666, "51250429F", "Arnau", fecha, motiuUrgencia);
            Console.ForegroundColor = ConsoleColor.Green;
            visita.GetInfo();


        }
    }
}