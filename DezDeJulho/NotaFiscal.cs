using System;
using System.Collections.Generic;
using System.Text;

namespace DezDeJulho
{
    class NotaFiscal
    {
        public Cabecalho Cabecalho { get; set; }
        public List<Produto> Produto { get; set; }
        public Rodape Rodape { get; set; }

        public NotaFiscal(Cabecalho cabecalho, List<Produto> produto, Rodape rodape)
        {
            Cabecalho = cabecalho;
            Produto = produto;
            Rodape = rodape;
        }

        public void Imprimir()
        {
            Console.WriteLine("******************** NOTA FISCAL DE SAIDA ********************\r\n\r\n\r\n");
            Console.WriteLine($"Número: {Cabecalho.NumeroNota}");
            Console.WriteLine($"Cliente: {(Cabecalho.Cliente)}");
            if (Cabecalho.Cliente is PessoaFisica)
            {
                Console.WriteLine($"CPF: {(Cabecalho.Cliente as PessoaFisica).Cpf}\r\n\r\n\r\n");
            }
            else
            {
                Console.WriteLine($"CPF: {(Cabecalho.Cliente as PessoaJuridica).Cnpj}\r\n\r\n\r\n");
            }
            string a1 = "Produto";
            string a2 = "Quantidade";
            string a3 = "Preço";

            Console.WriteLine($"{a1.PadRight(20)}{a2.PadRight(20)}{a3.PadRight(20)}");
            foreach (Produto item in Produto)
            {
                Console.WriteLine($"{item.Nome.PadRight(25)}{item.Quantidade.ToString().PadRight(15)}R$ {item.Preco.ToString("F2").PadRight(17)}");
            }
            Console.WriteLine("\r\n\r\n");
            Console.WriteLine($"Total da Nota Fiscal : R$ {Rodape.ValorTotal.ToString("F2")}\r\n\r\n\r\n");

            Console.WriteLine("**************************************************************\r\n\r\n\r\n");

        }
    }
}
