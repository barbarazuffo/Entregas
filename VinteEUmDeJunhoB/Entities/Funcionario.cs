using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using System.Globalization;

namespace VinteEUmDeJunhoB.Entities
{
    class Funcionario
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public DateTime Nascimento { get; set; }
        public decimal Salario { get; set; }

        public Funcionario(int id, string nome, DateTime nascimento, decimal salario)
        {
            Id = id;
            Nome = nome;
            Nascimento = nascimento;
            Salario = salario;

        }

        public override string ToString()
        {
            return Id.ToString().PadRight(5) + Nome.PadRight(15) + Nascimento.ToString("dd/MM/yyyy").PadRight(15) + Salario.ToString("F2", CultureInfo.InvariantCulture).PadRight(15);
        }
        //public void ArmazenarListaFuncionarios(IArquivos arquivos)
        //{

        //}
    }
}
