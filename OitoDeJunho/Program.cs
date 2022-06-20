using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace OitoDeJunho
{
    class Program
    {
        static void Main(string[] args)
        {
            string rec = Cliente.Gasolina * 0.6 > Cliente.Alcool ? "Recomenda usar gasolina" : "Recomenda usar alcool";
            Console.WriteLine(rec);
            Console.WriteLine("Digite seu nome: ");
            string name = Console.ReadLine();
            Console.WriteLine("Digite seu CPF: ");
            long cpf = long.Parse(Console.ReadLine());
            Console.WriteLine("Alcool ou Gasolina (A/G): ");
            string choice = Console.ReadLine();
            Console.WriteLine("Valor será Real, Litro ou Completar (R/L/C): ");
            string choice2 = Console.ReadLine();

            Console.WriteLine("Valor : ");
            double valor = double.Parse(Console.ReadLine());
            Cliente cliente = new Cliente(name, cpf, choice);

            if (choice2[0] == 'R')
            {
                double a = cliente.CalcLitros(choice, valor);
                cliente.Litros(a);
                cliente.Valor(valor);

            }
            else if (choice2[0] == 'L')
            {
                double a = cliente.CalcValor(choice, valor);
                cliente.Litros(valor);
                cliente.Valor(a);
            }
            else if (choice2[0] == 'C')
            {
                double a = cliente.CalcLitros(choice, 50);
                cliente.Litros(50);
                cliente.Valor(a);
            }
            else
            {
                Console.WriteLine("Erro");
                Console.WriteLine("Valor será Real, Litro ou Completar (R/L/C): ");
                choice2 = Console.ReadLine();
            }

            Console.WriteLine(cliente);

            Console.ReadKey();

        }
    }
}
