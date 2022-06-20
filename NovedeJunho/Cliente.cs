using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace NovedeJunho
{
    class Cliente
    {
        public int Codigo { get; set; }
        public string Nome { get; set; }
        private List<Pedido> ListaPedidos { get; set; }
        public Cliente(int codigo, string nome)
        {
            Codigo = codigo;
            Nome = nome;
            ListaPedidos = new List<Pedido>();
        }
        public int IniciarPedido()
        {
           return ListaPedidos.Count() + 1;
            
        }
        public void AddItem(Pedido pedido)
        {
            ListaPedidos.Add(pedido);
        }
        public int LocalizarPedido(int codigo)
        {
            for (int i = 0; i < ListaPedidos.Count(); i++)
            {
                if (ListaPedidos[i].CodigoPedido == codigo)
                {
                    return i;
                }
            }
            
            return 0;
        }
        public Pedido SelecionarPedido(int indice)
        {
            return ListaPedidos[indice];
        }
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            foreach (Pedido item in ListaPedidos)
            {
                sb.AppendLine("Pedido " + item.CodigoPedido.ToString().PadRight(2) + "Cliente: " + Codigo.ToString().PadRight(10) + " Valor Total: " + item.TotalizarPedido().ToString().PadRight(8) + "Data do pedido " + item.DataDoPedido);
                sb.AppendLine("Forma de pagamento: " + item.Pagar.ToString().PadRight(10) + "Situação do pedido: " + item.SituacaoPedido.ToString());
                if (item.Pagar == Pagamento.Parcelado)
                {
                    sb.AppendLine("Valor da parcela".PadLeft(40) + "Parcela".PadLeft(15) + "DataVencimento".PadLeft(25));
                    for (int i = 0; i < item.Parcelas; i++)
                    {
                        sb.AppendLine(item.ValorParc.ToString("F2").PadLeft(40) + (item.Parcelas - i).ToString().PadLeft(15) + (item.DataDoRecebimento.AddMonths(1 + i).ToString().PadLeft(25)));
                    }
                    sb.AppendLine("Itens");
                    sb.AppendLine("Descrição".PadRight(20) + "Valor unitario".PadLeft(40).PadRight(20) + "Quantidade".PadLeft(25));
                    for (int i = 0; i < item.QuantProdutos(); i++)
                    {
                        sb.AppendLine(item.SelecionarProdutos(i).Descricao.ToString().PadRight(20) + item.SelecionarProdutos(i).ValorUnitario.ToString().PadLeft(40) + item.SelecionarProdutos(i).Quantidade.ToString().PadLeft(15));

                    }
                }
                else if (item.Pagar == Pagamento.AVista)
                {
                    sb.AppendLine("Itens");
                    sb.AppendLine("Descrição".PadRight(20) + "Valor unitario".PadLeft(40).PadRight(20) + "Quantidade".PadLeft(25));
                    for (int i = 0; i < item.QuantProdutos(); i++)
                    {
                        sb.AppendLine(item.SelecionarProdutos(i).Descricao.ToString().PadRight(20) + item.SelecionarProdutos(i).ValorUnitario.ToString().PadLeft(40) + item.SelecionarProdutos(i).Quantidade.ToString().PadLeft(15));

                    }
                }
                else
                {
                    break;
                }

                }
                return sb.ToString();
        }
    }
}
