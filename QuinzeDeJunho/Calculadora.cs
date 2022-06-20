using System;
using System.Collections.Generic;
using System.Text;

namespace QuinzeDeJunho
{
    abstract class Calculadora
    {
        public double Valor1 { get; set; }
        public double Valor2 { get; set; }
        public double Valor3 { get; set; }

        public Calculadora(double valor1, double valor2)
        {
            Valor1 = valor1;
            Valor2 = valor2;
        }
        public double Soma()
        {
            Valor3 = Valor1 + Valor2;
            return Valor1 + Valor2;
        }
        public double Subtracao()
        {
            Valor3 = Valor1 - Valor2;
            return Valor1 - Valor2;
        }
        public double Divisao()
        {
            Valor3 = Valor1 / Valor2;
            return Valor1 / Valor2;
        }
        public double Multiplicacao()
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
