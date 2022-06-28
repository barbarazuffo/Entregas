using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace VinteEUmDeJunho
{
    class OperacaoArquivos : IOperacao
    {
        public List<Funcionario> Funcionarios;
        public List<string> ListaDiretorios;
        public string[] Arquivos { get; set; }
        public string path { get; set; }
        public OperacaoArquivos(string path1)
        {
            path = path1;
            Funcionarios = new List<Funcionario>();
            ListaDiretorios = new List<string>();
            Arquivos = new string[100];
        }
        public List<Funcionario> ListaFuncionarios()
        {
            int i = 0;
            foreach (var item in ListaDiretorios)
            {
                using (StreamReader sr = File.OpenText(item))
                {
                    FileInfo fileInfo = new FileInfo(item);
                         while (!sr.EndOfStream)
                    {
                        fileInfo.OpenText();
                        string line = sr.ReadLine();
                        Arquivos[i] = Path.GetFileName(item);
                        Funcionario funcionario = CriarFuncionario(line, Arquivos[i]);
                        Funcionarios.Add(funcionario);
                        Console.WriteLine(Arquivos[i]);
                MoverArquivoSucesso(Arquivos[i]);

                    }
                    i++;
                }
            }

            
            return Funcionarios;
        }
        public Funcionario CriarFuncionario(string line, string path)
        {
            string[] sep = line.Split(";");
            int Id = int.Parse(sep[0]);
            string Nome = sep[1];
            DateTime Aniversario = DateTime.Parse(sep[2]);
            decimal Salario = decimal.Parse(sep[3]);
            Funcionario funcionario = new Funcionario(Id, Nome, Aniversario, Salario);
            return funcionario;
        }
        public List<string> ListarDiretorios()
        {
            IEnumerable<string> file = Directory.EnumerateFiles(path, "*.txt", SearchOption.AllDirectories);
            foreach (string s in file)
            {
                ListaDiretorios.Add(s); 
            }
            return ListaDiretorios;
        }
        public void MoverArquivoErro(string path1)
        {

            File.Move($"@\"{path1}\"", "C:\\temp\\Entregas\\Entregas\\VinteEUmDeJunho\\arquivo\\Erro", true);
        }

        public void MoverArquivoSucesso(string path1)
        {
            File.Move($"@\"{path1}\"", "C:\\temp\\Entregas\\Entregas\\VinteEUmDeJunho\\arquivo\\Processado", true);
        }


    }
}
