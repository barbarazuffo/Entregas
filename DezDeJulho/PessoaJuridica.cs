using System;
using System.Collections.Generic;
using System.Text;

namespace DezDeJulho
{
    class PessoaJuridica : Cliente
    {
        public string Cnpj { get; set; }

        public PessoaJuridica(string nome, string cnpj) : base(nome)
        {
            Cnpj = cnpj;
        }
    }
}
