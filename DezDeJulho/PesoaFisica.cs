using System;
using System.Collections.Generic;
using System.Text;

namespace DezDeJulho
{
    class PessoaFisica : Cliente
    {
        public string Cpf { get; set; }

        public PessoaFisica(string nome, string cpf): base(nome)
        {
            Cpf = cpf;
        }

    }
}
