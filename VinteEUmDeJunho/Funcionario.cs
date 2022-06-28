using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace VinteEUmDeJunho
{
    class Funcionario 
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public DateTime Nascimento { get; set; }
        public decimal Salario { get; set; }
        public List<Funcionario> Funcionarios { get; set; }

        public Funcionario(int id, string nome, DateTime nascimento, decimal salario)
        {
            Id = id;
            Nome = nome;
            Nascimento = nascimento;
            Salario = salario;
            Funcionarios = new List<Funcionario>();
        }
        public List<Funcionario> AdicionarFuncionarios()
        {
            return Funcionarios;
        }
        public override string ToString()
        {
            return Id.ToString().PadRight(3) + Nome.ToString().PadRight(15) + Nascimento.ToString("dd/MM/yyyy").PadRight(12) + Salario.ToString().PadRight(15);
        }

    }
}
