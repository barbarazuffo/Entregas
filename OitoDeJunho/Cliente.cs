using System;
using System.Collections.Generic;
using System.Text;

namespace OitoDeJunho
{
    class Cliente
    {
        public string Nome { get; set; }
        public long CPF { get; set; }
        public string Choice { get; set; }
        public static double Gasolina = 7.21;
        public static double Alcool = 5.60;
        public double Qnt { get; set; }
        public double Val { get; set; }

        public Cliente(string nome, long cpf, string choice)
        {
            Nome = nome;
            CPF = cpf;
            Choice = choice;
        }
        public double Litros(double valor)
        {
            Qnt = valor;
            return valor;
        }
        public double Valor(double valor)
        {
            Val = valor;
            return valor;
        }
        public double CalcLitros(string tipo, double valor)
        {
            if (tipo[0] == 'A')
            {
                return valor / Alcool;
            }
            if (tipo[0] == 'G')
            {
                return valor / Gasolina;
            }
            else
            {
                Console.WriteLine("Valor incorreto digite novamente (A/G): ");
                double valor2 = double.Parse(Console.ReadLine());
                return CalcLitros(tipo, valor2);
                
            }
        }
        public double CalcValor(string tipo, double litros)
        {
            if (tipo[0] == 'A')
            {
                return litros * Alcool;
            }
            if (tipo[0] == 'G')
            {
                return litros * Gasolina;
            }
            else
            {
                Console.WriteLine("Valor incorreto digite novamente (A/G): ");
                double valor2 = double.Parse(Console.ReadLine());
                return CalcValor(tipo, valor2);
            }
        }
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("Posto de Combustivel IBM");
            sb.AppendLine($"Cliente: {Nome.ToUpper().Trim()}");
            sb.Append($"CPF: {CPF.ToString()}");
            sb.AppendLine($"Tipo de combustivel: {Choice}");
            sb.AppendLine($"Quantidade Litros: [{Qnt.ToString()}]");
            sb.AppendLine($"Valor Total Pago: [{Val.ToString()}]");
            return sb.ToString();

        }
    }
}
