using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoisDeJunho
{
    class Program3
    {
        static void Main(string[] args)
        {
            /* 3 - Escreva um programa que leia um vetor de 100 elementos.
             * O programa deve informar a quantidade de números ímpares 
             * existentes no vetor. Os  valores armazenados no vetor serão 
             * informados pelo usuário, ou gerados pelo  computador.
             * 
             */

            int[] vetor = new int[100];

            Random numAleatorio = new Random();
            int valorInteiro = 0;
            for (int j = 0; j < 100; j++)
            {
                valorInteiro= numAleatorio.Next();
                vetor[j] = valorInteiro;
            }
            int impar = 0;
            int par = 0;
            foreach (var item in vetor)
            {
                if ((item % 2) == 0)
                {
                    par++;
                }
                else
                {
                    impar++;
                }
            }
            Console.WriteLine("Tem {0} numeros pares e {1} numeros impares", par, impar);



            Console.ReadKey();


        }
    }
}
