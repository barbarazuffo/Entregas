using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace VinteEDoisdeJunho
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Quantos testes serão executados?");
            int n = int.Parse(Console.ReadLine());
            int[,] caso1 = new int[n, 2];
            int[] caso2 = new int[n];
                int soma = 0;

            for (int i = 0; i < n; i++)
            {
                
                for (int j = 0; j < 2; j++)
                {
                    Console.WriteLine($"Digite o valor [{i},{j}]: ");
                    int a = int.Parse(Console.ReadLine());
                    caso1[i, j] = a;
                    
                }
            }
            int c = 0;

            for (int i = 0; i < n; i++)
            {
                int a = caso1[i, 0];
                int b = caso1[i, 1];
                c = caso1[i, 0] + 1;
                soma = 0;
                for (int j = a; j < b; j++)
                {
                    if (c % 2 != 0)
                    {
                        soma += c;
                    }
                    caso2[i] = soma;

                    c += 1;
                }
                
            }
            foreach (int som in caso2)
            {
                Console.WriteLine(som.ToString());
            }
        }
    }
}
