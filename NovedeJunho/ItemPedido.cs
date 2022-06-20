using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace NovedeJunho
{
    class ItemPedido
    {
        public string Descricao { get; set; }
        public double ValorUnitario { get; set; }
        public int Quantidade { get; set; }
        public ItemPedido(string descricao, double valorUnitario, int quantidade)
        {
            Descricao = descricao;
            ValorUnitario = valorUnitario;
            Quantidade = quantidade;
        }
    }
}
