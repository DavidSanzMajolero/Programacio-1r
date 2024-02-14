using System;

namespace OOPVisita
{
    public class Visita
    {
        private string propietario;
        private string paciente;
        private DateTime fecha;
        private string motivo;

        public string Propietario
        {
            get { return propietario; }
            set { propietario = value; }
        }
        public string Paciente
        {
            get { return paciente; }
            set { paciente = value; }
        }
        public DateTime Fecha
        {
            get { return fecha; }
            set { fecha = value; }
        }
        public string Motivo
        {
            get { return motivo; }
            set { motivo = value; }
        }

        public Visita(string propietario, string paciente, DateTime fecha, string motivo)
        {
            Propietario = propietario;
            Paciente = paciente;
            Fecha = fecha;
            Motivo = motivo;
        }

        public virtual void GetInfo()
        {
            Console.WriteLine(" --------------------------------------------------");
            Console.WriteLine("| Propietario | Paciente | Fecha       | Motivo    |");
            Console.WriteLine("---------------------------------------------------");
            Console.WriteLine($"| {Propietario,-11} | {Paciente,-8} | {Fecha,-11:d} | {Motivo,-9} |");
            Console.WriteLine(" --------------------------------------------------");
            Console.WriteLine($"| {Propietario,-11} | {Paciente,-8} | {Fecha,-11:d} | {Motivo,-9} |");
            Console.WriteLine(" --------------------------------------------------");
            Console.WriteLine($"| {Propietario,-11} | {Paciente,-8} | {Fecha,-11:d} | {Motivo,-9} |");
            Console.WriteLine(" --------------------------------------------------");
            Console.WriteLine($"| {Propietario,-11} | {Paciente,-8} | {Fecha,-11:d} | {Motivo,-9} |");
            Console.WriteLine(" --------------------------------------------------");
        }
    }
}

