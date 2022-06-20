using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace DezDeJulho
{
    class Cabecalho
    {
        public Guid NumeroNota { get; set; }
        public Cliente Cliente { get; set; }

        public Cabecalho(Guid numeroNota, Cliente cliente)
        {
            NumeroNota = numeroNota;
            Cliente = cliente;
        }
    }
}
