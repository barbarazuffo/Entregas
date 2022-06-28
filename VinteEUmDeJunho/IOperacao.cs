using System;
using System.Collections.Generic;
using System.Text;

namespace VinteEUmDeJunho
{
    interface IOperacao
    {
        List<string> ListarDiretorios();
        List<Funcionario> ListaFuncionarios();
        void MoverArquivoSucesso(string path);
        void MoverArquivoErro(string path);
    }
}
