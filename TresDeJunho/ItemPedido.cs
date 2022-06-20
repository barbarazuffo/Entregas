using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TresDeJunho
{
    class ItemPedido
    {
        

        public string descricao { get; set; }
        public double valor_unitario { get; set; }
        public int quantidade { get; set; }

        public ItemPedido(string descricao, double valor_unitario, int quantidade)
        {
            this.descricao = descricao;
            this.valor_unitario = valor_unitario;
            this.quantidade = quantidade;
        }
    }
}
