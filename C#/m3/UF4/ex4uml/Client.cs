using System;
namespace UML
{
    public class Client: Persona
    {
        private int codiClient;
        private int tipusClient;

        public int CodiClient
        {
            get { return codiClient; }
            set { codiClient = value; }
        }
        public int TipusClient
        {
            get { return tipusClient; }
            set { tipusClient = value; }
        }
        public Client(string cognom, string nom, int codi, int codiClient, int tipusClient) : base(cognom, nom, codi)
        {
            this.codiClient = codiClient;
            this.tipusClient = tipusClient;
        }
        public static double CalcularDescompte(int tipusClient)
        {
            double descompte = 0;
            if (tipusClient == 1)
            {
                descompte = 0.1;
            }
            else if (tipusClient == 2)
            {
                descompte = 0.2;
            }
            else if (tipusClient == 3)
            {
                descompte = 0.3;
            }

            return descompte;
            
        }
    }
}
