using System;


namespace Ex9
{
    public abstract class Papel
    {
        public string Nom { get; set; }
        public string Editorial { get; set; }
        public string Data { get; set; }
        public float Volum { get; set; }
        public int NumPag { get; set; }
        public string Autor { get; set; }
        public string Categoria { get; set; }
        public Papel(string nom, string editorial, string data, float volum, int numPag, string autor, string categoria)
        {
            Nom = nom;
            Editorial = editorial;
            Data = data;
            Volum = volum;
            NumPag = numPag;
            Autor = autor;
            Categoria = categoria;
        }
        public abstract bool Desplç();

        public abstract bool Estripat();

        public virtual string GetInfo()
        {
            return $"Nom: {Nom}, Editorial: {Editorial}, Data: {Data}, Volum: {Volum}, NumPag: {NumPag}, Autor: {Autor}, Categoria: {Categoria}";
        }

    }
}
