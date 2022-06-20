using System;
using System.Collections.Generic;
using System.Text;

namespace DezDeJulho
{
    class Program
    {
        static void Main(string[] args)
        {
            PessoaFisica cliente1 = new PessoaFisica("Barbara Zuffo Martins", "44505084833");
            PessoaJuridica cliente2 = new PessoaJuridica("Barbara Zuffo Martins", "44505084833");
            Cabecalho cabecalho1 = new Cabecalho(Guid.NewGuid(), cliente1);
            Cabecalho cabecalho2 = new Cabecalho(Guid.NewGuid(), cliente2);



            List<Produto> produto1 = new List<Produto>()
            {
                new Produto("Pc", 5045, 1),
                new Produto("Tv", 3045, 2),
                new Produto("Game", 5450, 1),
                new Produto("Fogao", 2650, 1),
                new Produto("Sofa", 3500, 1)
            };

            decimal valorTotal = 0;
            foreach (Produto item in produto1)
            {
                valorTotal += item.Preco * item.Quantidade;
            }
            Rodape rodape = new Rodape(valorTotal);

            NotaFiscal nota = new NotaFiscal(cabecalho1, produto1, rodape);
            nota.Imprimir();
        }
    }
}
