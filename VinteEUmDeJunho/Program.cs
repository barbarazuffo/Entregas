using System;
using System.IO;
using System.Text;
using System.Globalization;

namespace VinteEUmDeJunho
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                OperacaoArquivos x = new OperacaoArquivos(@"C:\temp\Entregas\Entregas\VinteEUmDeJunho\arquivo");
                x.ListarDiretorios();
                x.ListaFuncionarios();
                foreach (var item in x.Funcionarios)
                {
                    Console.WriteLine(item);
                }
            }
            catch(Exception e)
            {
                Console.WriteLine("An error occured");
                Console.WriteLine(e.Message);
            }
        }
    }
}
