using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace NovedeJunho
{
    class Program
    {
        static void Main(string[] args)
        {

            int out1 = 0;
            List<Cliente> clientes = new List<Cliente>();
            Cliente cliente0 = new Cliente(12,"babi");
            List<Pedido> pedidosList = new List<Pedido>();

            while (out1 != 6)
            {
                Console.Clear();

                Console.WriteLine("1 - Cadastrar cliente");
                Console.WriteLine("2 - Criar pedido ");
                Console.WriteLine("3 - Receber pedido(pagamento)");
                Console.WriteLine("4 - Relatório dos pedidos criados");
                Console.WriteLine("6 - Cancelar(desistencia)");
                Console.WriteLine("5 - Sair do sistema");

                int choice = int.Parse(Console.ReadLine());
                //Pedido pedido = new Pedido(0);
                Console.Clear();

                switch (choice)
                {
                
                    case 1:
                        Console.WriteLine("Digite seu nome: ");
                        string name = Console.ReadLine();
                        Console.WriteLine("Digite o seu codigo de cliente:");
                        int codigo = int.Parse(Console.ReadLine());
                        Cliente cliente = new Cliente(codigo, name);
                        clientes.Add(cliente);
                        Console.WriteLine(cliente.ToString());
                        out1 = 1;
                        break;
                    case 2:
                        Console.WriteLine("Digite o seu codigo de cliente:");
                        int y = int.Parse(Console.ReadLine());

                        for (int i = 0; i < clientes.Count; i++)
                        {
                            if (clientes[i].Codigo == y)
                            {
                                Pedido pedido = new Pedido(clientes[i].IniciarPedido());
                                string x = "A";
                                while (x != "F")
                                {
                                    Console.WriteLine("Descrição do produto: ");
                                    string descricao = Console.ReadLine();
                                    Console.WriteLine("Valor: ");
                                    double valor = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                                    Console.WriteLine("Quantidade:");
                                    int quantidade = int.Parse(Console.ReadLine());
                                    ItemPedido itemPedido = new ItemPedido(descricao, valor, quantidade);
                                    pedido.IncluirItem(itemPedido);
                                    Console.WriteLine("Deseja adicionar outro produto? (F-Não/S-Sim)");
                                    x = Console.ReadLine();
                                    Console.Clear();
                                }
                                clientes[i].AddItem(pedido);
                                y = 0;
                                double vaLorTotal = pedido.TotalizarPedido();
                                Console.WriteLine($"O codigo desse pedido é {pedido.CodigoPedido} e o valor é {vaLorTotal}");


                            }
                        }
                        out1 = 2;
                        break;
                    case 3:
                        Console.WriteLine("Digite o seu codigo de cliente:");
                        int cod = int.Parse(Console.ReadLine());
                        Console.WriteLine("Digite o seu codigo do Pedido:");
                        int codPed = int.Parse(Console.ReadLine());
                        for (int i = 0; i < clientes.Count; i++)
                        {
                            if (clientes[i].Codigo == cod)
                            {
                                int indice =  clientes[i].LocalizarPedido(codPed);
                                Console.WriteLine("1 - À vista ");
                                Console.WriteLine("2 - Parcelado");
                                Console.WriteLine("3 - Sair");
                                int choice2 = int.Parse(Console.ReadLine());
                                if (choice2 == 1)
                                {
                                    Recebimento x = new Recebimento(clientes[i].SelecionarPedido(indice));
                                    Console.WriteLine(clientes[i].SelecionarPedido(indice).Pagar);
                                    Situacao sit = Situacao.Pago;
                                    clientes[i].SelecionarPedido(indice).SituacaoAtual(sit);
                                }
                                else if (choice2 == 2)
                                {
                                    Console.WriteLine("Digite a quantidade de parcelas:");
                                    int par = int.Parse(Console.ReadLine());
                                    Recebimento x = new Recebimento(clientes[i].SelecionarPedido(indice), par);
                                    Console.WriteLine(clientes[i].SelecionarPedido(indice).Pagar);
                                    Situacao sit = Situacao.Pago;
                                    clientes[i].SelecionarPedido(indice).SituacaoAtual(sit);
                                }
                                else if (choice2 == 3)
                                {
                                    out1 = 3;
                                    break;
                                }
                            }
                        }
                        out1 = 3;
                        break;
                    case 4:
                        Console.WriteLine("Digite o seu codigo de cliente:");
                        int cod2 = int.Parse(Console.ReadLine());
                        for (int i = 0; i < clientes.Count(); i++)
                        {
                            if (clientes[i].Codigo == cod2)
                            {
                                Console.WriteLine(clientes[i].ToString());
                            }
                        }
                        Console.ReadLine();
                        out1 = 4;
                            break;
                    case 5:
                        Console.WriteLine("Digite o seu codigo de cliente:");
                        int cod1 = int.Parse(Console.ReadLine());
                        Console.WriteLine("Digite o seu codigo do Pedido:");
                        int codPed1 = int.Parse(Console.ReadLine());
                        foreach (Cliente item in clientes)
                        {
                            foreach (Pedido item1 in pedidosList)
                            {
                                if( (item.Codigo == cod1)&&(item1.CodigoPedido == codPed1))
                                        {
                                    item1.SituacaoAtual(Situacao.Cancelado);
                                }
                                    
                            }
                            
                        }
                        out1 = 5;
                        break;
                    case 6:
                        out1 = 6;
                        break;


                }


            }
        }
    }
}
