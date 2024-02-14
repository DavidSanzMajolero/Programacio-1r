using System;
using System.ComponentModel;

namespace OOPVisita
{
    internal class Propietari : Visita
    {
        private string dni;
        private string nom;
        private string cognoms;
        private int telefon;

        public string Dni
        {
            get { return dni; }
            set { dni = value; }
        }

        public string Nom
        {
            get { return nom; }
            set { nom = value; }
        }
        public string Cognoms
        {
            get { return cognoms; }
            set { cognoms = value; }
        }
        public int Telefon
        {
            get { return telefon; }
            set { telefon = value; }
        }

        public Propietari (string dni, string nom, string cognoms, int telefon, string propietari, string pacient, DateTime data, string motiu) : base(propietari, pacient, data, motiu)
        {
            Dni = dni;
            Nom = nom;
            Cognoms = cognoms;
            Telefon = telefon;
        }

        /*public override string GetInfo()
        {
            return "Visita: " + Propietari + " Pacient: " + Pacient + " Data: " + Data + " Motiu: " + Motiu;
        }*/
    }
}