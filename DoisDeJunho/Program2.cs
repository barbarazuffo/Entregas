using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoisDeJunho
{
    class Program2
    {
        static void NotMain(string[] args)
        {
            /* 2 - Escreva um programa que receba do usuário um vetor com 20 
             * valores inteiros e apresente o maior, o menor e suas respectivas 
             * posições em que os mesmos foram informados. Caso existam números 
             * iguais mostre a posição da primeira ocorrência.
             * 
             */

            int[] vetor = new int[20];

            for (int j = 0; j < 20; j++)
            {
                Console.WriteLine("1 Digite o indice {0}: ", j);
                vetor[j] = int.Parse(Console.ReadLine());
            }

            int indice1 = Array.IndexOf(vetor, vetor.Max());
            int indice2 = Array.IndexOf(vetor, vetor.Min());

            Console.WriteLine("O maior valor é {0}, esta na posição {1} ", vetor.Max(), indice1);
            Console.WriteLine("O menor valor é {0}, esta na posição {1} ", vetor.Min(), indice2);





            Console.ReadKey();


        }
    }
}
