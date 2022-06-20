using System;
using System.Collections.Generic;
using System.Text;

namespace QuinzeDeJunho
{
    class Calculo : Calculadora
    {
        public double Valor1 { get; set; }
        public double Valor2 { get; set; }
        public int Select { get; set; }
        public Calculo(double valor1, double valor2) : base(valor1, valor2)
        {
        }
    }
}
