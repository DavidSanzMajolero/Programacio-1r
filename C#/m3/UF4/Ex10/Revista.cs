using System;
namespace Ex10

{
    public class Revista : Papel
    {
        public Revista(string nom, string editorial, string data, float volum, int numPag, string autor, string categoria) : base(nom, editorial, data, volum, numPag, autor, categoria) { }
        public override bool Desplç()
        {
            return true;
        }
        public override bool Estripat()
        {
            return false;
        }
        public override string GetInfo()
        {
            return $"Nom: {Nom}, Editorial: {Editorial}, Data: {Data}, Volum: {Volum}, NumPag: {NumPag}, Autor: {Autor}, Categoria: {Categoria}";
        }
    }
}
