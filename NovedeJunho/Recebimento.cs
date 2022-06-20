using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace NovedeJunho
{
    class Recebimento
    {
        public double ValorParcela { get; set; }
        public double ValorTotal { get; set; }
        public int Parcela { get; set; }
        public DateTime DataVencimento { get; set; }
        public Pedido Pedido { get; set; }
        public Recebimento(Pedido pedido)
        {
            Pedido = pedido;
            ValorTotal = pedido.TotalizarPedido();
            Pedido.Pagar = Pagamento.AVista;
            pedido.DataDoRecebimento = DateTime.Now;
        }
        public Recebimento(Pedido pedido, int parcela)
        {
            Pedido = pedido;
            Parcela = parcela;
            ValorTotal = pedido.TotalizarPedido();
            ValorParcela = ValorTotal / Parcela;
            pedido.ValorParc = ValorParcela;
            Pedido.Pagar = Pagamento.Parcelado;
            pedido.Parcelas = Parcela;
            pedido.DataDoRecebimento = DateTime.Now;


        }

    }
}
