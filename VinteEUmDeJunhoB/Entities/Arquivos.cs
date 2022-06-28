using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace VinteEUmDeJunhoB.Entities
{
    class Arquivos : IArquivos
    {
        public string Caminho { get; set; }
        public List<Funcionario> Funcionarios;
        public List<string> Diretorios;

        public Arquivos(string caminho)
        {
            Caminho = caminho;
            Funcionarios = new List<Funcionario>();
            Diretorios = new List<string>();
        }

        public List<Funcionario> ListarFuncionarios()
        {
            foreach (string file in Diretorios)
            {
                string file1 = Caminho + "\\" + file;
                try
                {
                    using (StreamReader srFuncionarios = File.OpenText(file1))
                    {
                        while (!srFuncionarios.EndOfStream)
                        {
                            string[] funcionario0 = srFuncionarios.ReadLine().Split(";");
                            int Id = int.Parse(funcionario0[0]);
                            string Nome = funcionario0[1];
                            DateTime Nascimento = DateTime.Parse(funcionario0[2]);
                            decimal Salario = decimal.Parse(funcionario0[3]);
                            Funcionario funcionario = new Funcionario(Id, Nome, Nascimento, Salario);
                            Funcionarios.Add(funcionario);
                        }
                    }
                    MoverArquivoSucesso(file);
                }
                catch (FormatException e)
                {
                    MoverArquivoErro(file);
                    Console.WriteLine("Format Error");
                    Console.WriteLine(e.Message);
                }
            }
            return Funcionarios;
        }

        public List<string> ListarDiretorios()
        {
            IEnumerable<string> files = Directory.EnumerateFiles(Caminho, "*.IBMDOTNET", SearchOption.AllDirectories);
            foreach (string file in files)
            {
                Diretorios.Add(Path.GetFileName(file));
            }
            return Diretorios;
        }

        public void MoverArquivoErro(string file)
        {
            string file2 = Caminho + "\\Erro\\" + file;
            File.Move(Caminho, file2, true);
        }

        public void MoverArquivoSucesso(string file)
        {
            string file2 = Caminho + "\\Valido\\" + file;
            string file3 = Caminho + "\\" + file;
            File.Move(file3, file2, true);
        }
        public override string ToString()
        {
            Console.WriteLine("Id".PadRight(5) + "Nome".PadRight(15) + "Nascimento".PadRight(15) + "Salario.".PadRight(15));
            foreach (Funcionario item in Funcionarios)
            {
                Console.WriteLine(item);
            }
            return " ";
        }
        //public void ChecarDados(string caminhofile)
        //{
        //    try
        //    {
        //        using (StreamReader srFuncionarios = File.OpenText(caminhofile))
        //        {
        //            while (!srFuncionarios.EndOfStream) 
        //            {
        //                string[] funcionario0 = srFuncionarios.ReadLine().Split(";");
        //                int Id = int.Parse(funcionario0[0]);
        //                string Nome = funcionario0[1];
        //                DateTime Nascimento = DateTime.Parse(funcionario0[2]);
        //                decimal Salario = decimal.Parse(funcionario0[3]);
        //                Funcionario funcionario = new Funcionario(Id, Nome, Nascimento, Salario);
        //                Funcionarios.Add(funcionario);
        //            }
        //        }
        //        MoverArquivoSucesso();
        //    }
        //    catch (FormatException e)
        //    {
        //        MoverArquivoErro();
        //        Console.WriteLine("Format Error");
        //        Console.WriteLine(e.Message);
        //    }

        //}
    }
}
