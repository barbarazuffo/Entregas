using System;
using System.Collections.Generic;
using System.Text;

namespace QuinzeDeJunho
{
    abstract class Calculadora
    {
        public decimal Valor1 { get; set; }
        public decimal Valor2 { get; set; }
        public decimal Valor3 { get; set; }

        public Calculadora(decimal valor1, decimal valor2)
        {
            Valor1 = valor1;
            Valor2 = valor2;
        }
        public decimal Soma()
        {
            Valor3 = Valor1 + Valor2;
            return Valor1 + Valor2;
        }
        public decimal Subtracao()
        {
            Valor3 = Valor1 - Valor2;
            return Valor1 - Valor2;
        }
        public decimal Divisao()
        {
            Valor3 = Valor1 / Valor2;
            return Valor1 / Valor2;
        }
        public decimal Multiplicacao()
        {
            Valor3 = Valor1 * Valor2;
            return Valor1 * Valor2;
        }
        public override string ToString()
        {
            return Valor3.ToString();
        }

    }
}
