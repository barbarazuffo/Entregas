using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TresDeJunho
{
    class Pedido
    {/*
             * e métodos para incluir item no pedido e para totalizar o pedido – 
             * este, retorna um valor Double com o total de todos os itens da lista.Inclua também
             * um construtor em “Pedido” para instanciar uma nova lista na propriedade criada.
             * Crie um programa em que seja possível informar vários itens de um pedido.O usuário
             * informa descrição, valor e quantidade.O programa pergunta se deseja inserir novo 
             * pedido. Se sim, usuário pode incluir novo pedido. Se não, o programa exibe o total 
             * do pedido.
             */
        private List<ItemPedido> _lista;

        public List<ItemPedido> Lista
        {
            get
            {
                return _lista;
            }
            set
            {
                if (value != null)
                    _lista = value;
            }
        }

    }
}
