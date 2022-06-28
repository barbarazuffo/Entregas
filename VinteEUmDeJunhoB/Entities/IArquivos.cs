using System;
using System.Collections.Generic;
using System.Text;

namespace VinteEUmDeJunhoB.Entities
{
    interface IArquivos
    {
        List<string> ListarDiretorios();
        List<Funcionario> ListarFuncionarios();
        void MoverArquivoSucesso(string arq);
        void MoverArquivoErro(string arq);
    }
}
