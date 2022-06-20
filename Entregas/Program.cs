using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entregas
{
    class Program
    {
        static void Main(string[] args)
        {

            /*
             * ~~~~~~ AULA 01/05 ~~~~~~ 
             * -- MODIFICADORES DE ACESSO
             * 
             * - Public
             * O membro ou o tipo podem ser acessados por qualquer outro lugar, 
             * classes e subclasses fora e dentro do assembly(projeto)
             * 
             * - Protected Internal
             * O membro ou tipo só não pode ser acessado por classes fora do projeto
             * mas subclasses fora do prejeto consegue acessar
             * 
             * - Internal
             * O membro ou tipo só pode ser acessado se estiver no mesmo projeto
             * 
             * - Protected
             * O membro ou tipo só pode ser acessado pela própria classe ou por 
             * subclasses fora ou dentro do projeto, outras classes não conseguem acessa-los
             * 
             * - Private Protected
             * O membro ou tipo só é acessado pela própria classe ou subclasses do proprio projeto
             * 
             * - Private
             * O membro ou tipo só é acessado pela própria classe
             */
            Conta conta = new Conta("Barbara", 500);
            Console.WriteLine(conta.mostrarSaldo());

            conta.Saldo = 10000;
            Console.WriteLine(conta.mostrarSaldo());
            Console.ReadKey();
        }
    }
}
