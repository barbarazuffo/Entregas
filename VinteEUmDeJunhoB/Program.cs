using System;
using System.IO;
using System.Globalization;
using VinteEUmDeJunhoB.Entities;
using System.Collections.Generic;

namespace VinteEUmDeJunhoB
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Digite o Diretório desejado: ");
                string sourcePath = Console.ReadLine();
                Arquivos arquivos = new Arquivos(sourcePath);
                arquivos.ListarDiretorios();
                arquivos.ListarFuncionarios();
                Console.WriteLine(arquivos.ToString());

            }
            catch(IOException e)
            {
                Console.WriteLine("An eerror occurred");
                Console.WriteLine(e.Message);
            }
        }
    }
}
