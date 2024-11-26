using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HospedagemDehotel
{
       public class Suite
    {
        public string TipoSuite { get; set; }
        public int Capacidade { get; set; }
        public decimal Valordiaria { get; set; }

        public Suite(string tipo, int capacidade, decimal valordia)
        {
            this.TipoSuite = tipo;
            this.Capacidade = capacidade;
            this.Valordiaria = valordia;
        }
        public Suite()
        {


        }
    }
}
