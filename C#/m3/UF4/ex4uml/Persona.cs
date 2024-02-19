using System;


namespace UML
{
    public abstract class Persona
    {
        private string cognom;
        private string nom;
        private int codi;

        public string Cognom
        {
            get { return cognom; }
            set { cognom = value; }
        }
        public string Nom
        {
            get { return nom; }
            set { nom = value; }
        }
        public int Codi
        {
            get { return codi; }
            set { codi = value; }
        }
        public Persona(string cognom, string nom, int codi) 
        {
            this.cognom = cognom;
            this.nom = nom;
            this.codi = codi;
        }
        public virtual string Saludar()
        {
            return "Hola, soc " + nom + " " + cognom;
        }
    }
}
