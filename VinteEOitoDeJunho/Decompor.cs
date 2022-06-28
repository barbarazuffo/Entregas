using System;
using System.Collections.Generic;
using System.Text;

namespace VinteEOitoDeJunho
{
    class Decompor
    {
        public decimal Valor { get; set; }
        public decimal[] ValorAtual { get; set; }
        public decimal[] Notas { get; set; }
        public int[] NotasVerif { get; set; }


        public Decompor(decimal valor)
        {
            Valor = valor;
            ValorAtual = new decimal[13];
            Notas = new decimal[12];
            NotasVerif = new int[12];
            ValorAtual[0] = valor;
            Notas[0] = 100.00m;
            Notas[1] = 50.00m;
            Notas[2] = 20.00m;
            Notas[3] = 10.00m;
            Notas[4] = 5.00m;
            Notas[5] = 2.00m;
            Notas[6] = 1.00m;
            Notas[7] = 0.50m;
            Notas[8] = 0.25m;
            Notas[9] = 0.10m;
            Notas[10] = 0.05m;
            Notas[11] = 0.01m;
        }
        public int[] Checar()
        {
            int x = 0;
            for (int i = 0; i < 12; i++)
            {
                ValorAtual[i+1] = ValorAtual[i] % Notas[i];
                NotasVerif[i] = Convert.ToInt32(Math.Truncate(ValorAtual[i] / Notas[i]));
            }
            return NotasVerif;
        } 
        public void Imprimir()
        {
            int i = 0;
            Console.WriteLine("Notas: ");
            for (int j = 0; j < 6; j++)
            {
                Console.WriteLine(NotasVerif[i] + " nota(s) de R$" + Notas[i]);
                i++;
            }
            Console.WriteLine("Moedas: ");
            for (int k = 5; k < 12; k++)
            {
                Console.WriteLine(NotasVerif[i] + " nota(s) de R$" + Notas[i]);
                i++;
            }
        }
    }
}
