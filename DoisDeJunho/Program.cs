using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoisDeJunho
{
    class Program
    {
        static void NotMain(string[] args)
        {
            /* 1 - Escreva um programa que leia dois vetores com 10 elementos 
             * cada e gere um terceiro vetor de 20 elementos, cujos valores 
             * deverão ser compostos pelos elementos intercalados dos dois 
             * outros vetores. Ao final o programa deverá mostrar os dois 
             * vetores originais e o terceiro vetor com os valores intercalados.
             * 
             */

            int[] vetor1 = new int[10];
            int[] vetor2 = new int[10];
            int[] vetor3 = new int[20];


            for (int j = 0; j < 10; j++)
            {
                Console.WriteLine("1 Digite o indice {0}: ", j);
                vetor1[j] = int.Parse(Console.ReadLine());
            }
            for (int k = 0; k < 10; k++)
            {
                Console.WriteLine("2 Digite o indice {0}: ", k);
                vetor2[k] = int.Parse(Console.ReadLine());
            }
            int m = 0;
            int n = 0;

            for (int l = 0; l < 20; l++)
            {
                if (l % 2 == 0)
                {
                    vetor3[l] = vetor1[m];
                    Console.WriteLine("vet1[M]- " + vetor1[m] + " M- " + m + " Vet3[l]- " + vetor3[l] + " L- " + l);
                    m++;
                }
                else
                {
                    vetor3[l] = vetor2[n];
                    Console.WriteLine("vet1[N]- " + vetor2[n] + " N- " + n + " Vet3[l]- " + vetor3[l] + " L- " + l);
                    n++;
                }
            }
            int a = 0;
            int b = 0;
            int c = 0;

            foreach (var item in vetor1)
            {
                a++;
                Console.WriteLine("Vetor1[{0}] {1}", a, item);
            }
            foreach (var item in vetor2)
            {
                b++;
                Console.WriteLine("Vetor2[{0}] {1}", b, item);
            }
            foreach (var item in vetor3)
            {
                c++;
                Console.WriteLine("Vetor3[{0}] {1}", c, item);
            }




            Console.ReadKey();


        }
    }
}
