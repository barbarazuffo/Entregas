using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace NovedeJunho
{
    class Pedido
    {
        public int CodigoPedido { get; set; }
        public DateTime DataDoPedido { get; set; }
        public DateTime DataDoRecebimento { get; set; }
        public DateTime DataDoCancelamento { get; set; }
        public Cliente Cliente { get; set; }
        private List<ItemPedido> Pedido0 { get; set; } 
        public Situacao SituacaoPedido { get; set; }
        public Pagamento Pagar { get; set; }
        public int Parcelas { get; set; }
        public double ValorParc { get; set; }
        public Pedido(int codigo)
        {
            Pedido0 = new List<ItemPedido>();
            CodigoPedido = codigo;
            SituacaoPedido = Situacao.Novo ;
            DataDoPedido = DateTime.Now;
            //DataDotRecebimento = dataDotRecebimento;
            //DataDoCancelamento = dataDoCancelamento;
        }
        
        public void IncluirItem(ItemPedido item)
        {
            Pedido0.Add(item);
        }
        public double TotalizarPedido()
        {
            double sum = 0;
            foreach (ItemPedido item in Pedido0)
            {
                sum += item.Quantidade * item.ValorUnitario;
            }
            return sum;
        }
        public void SituacaoAtual(Situacao situacao)
        {
            SituacaoPedido = situacao;
        }
        public void PagamentoTipo(Pagamento pagamento)
        {
            Pagar = pagamento;
        }
        public int QuantProdutos()
        {
            return Pedido0.Count();
        }
        public ItemPedido SelecionarProdutos(int indice)
        {
            return Pedido0[indice];
        }
        
    }
}
