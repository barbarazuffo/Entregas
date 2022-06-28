using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;
namespace VinteETresDeJunho
{
    class Carro
    {
        public string Modelo { get; set; }
        public int Ano { get; set; }
        public Carro(string modelo, int ano)
        {
            Modelo = modelo;
            Ano = ano;
        }

        public int CompareTo(object obj)
        {
            if (!(obj is Carro))
            {
                throw new ArgumentException("Comparing error: argument is not an Product");
            }
            Carro other = obj as Carro;
            return Ano.CompareTo(other.Ano); //-1, 0, 1
        }

        public override string ToString()
        {
            return Modelo
                + ", "
                + Ano.ToString();
        }
    }
}
