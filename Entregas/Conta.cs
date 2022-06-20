using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entregas
{
    class Conta
    {
        public string Titular { get; set; }
        private decimal _saldo;

        public Conta(string titular, decimal saldo)
        {
            Titular = titular;
            _saldo = saldo;
        }
        public decimal Saldo
        {
            get
            {
                return _saldo;
            }
            set
            {
                if (value != null)
                    _saldo = value;
            }
        }
        protected decimal exibirSaldo()
        {
            return _saldo;
        }
        public decimal mostrarSaldo()
        {
            return exibirSaldo();
        }

        internal void processar()
        {

        }


    }
}
