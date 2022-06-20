using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace SeteDeJunho
{
    class Program
    {
        static void NotMain(string[] args)
        {
            List<Produto> produtosTecnologia = new List<Produto>();


            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("Digite o Produto ");
                string p = Console.ReadLine();
                Console.WriteLine("Digite o Valor ");
                decimal v = decimal.Parse(Console.ReadLine());
                Produto prod = new Produto(p, v);
                produtosTecnologia.Add(prod);
            }
            Console.WriteLine("----------");
            foreach (Produto item in produtosTecnologia)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("----------");
            List<Produto> prod2 = produtosTecnologia.OrderBy(k => k.Preco).ToList();
            for (int i = prod2.Count - 1; i >= 0; i--)
            {
                Console.WriteLine(prod2[i]);
            }

            int localizar = produtosTecnologia.FindIndex(z => z.Nome.ToUpper() == "MOUSE LOGITECH");
            if (localizar == -1)
            {
                Console.WriteLine("O produto não foi encontrado");
            }
            else
            {
                Console.WriteLine("O produto está na posição " + localizar);
            }

            Produto pos = new Produto("Mouse", 45);
            produtosTecnologia.Insert(5, pos);
            Console.WriteLine("----------");
            foreach (Produto item in produtosTecnologia)
            {
                Console.WriteLine(item);
            }
            Produto pos1 = new Produto("pc", 4521);
            produtosTecnologia.Add(pos1);
            Console.WriteLine("----------");
            foreach (Produto item in produtosTecnologia)
            {
                Console.WriteLine(item);
            }

            int x = produtosTecnologia.Count();
            Console.WriteLine("Temos " + x + " produtos na lista");

            Console.WriteLine("----------");

            List<Produto> a = produtosTecnologia.FindAll(y => y.Nome.ToUpper()[0] == 'A');
            foreach (Produto item in a)
            {
                Console.WriteLine(item);
            }
            produtosTecnologia.RemoveAt(8);
            Console.WriteLine("----------");

            foreach (Produto item in produtosTecnologia)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("acabou");
            Console.ReadKey();

        }
    }
}
