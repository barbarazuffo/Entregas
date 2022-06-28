using System;
using System.Globalization;

namespace VinteEOitoDeJunho
{
    class Program
    {
        static void Main(string[] args)
        {
            decimal x = decimal.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Decompor decompor = new Decompor(x);
            decompor.Checar();
            decompor.Imprimir();
        }
    }
}
