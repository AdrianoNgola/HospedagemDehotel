using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HospedagemDehotel
{
    public class Reserva
    {
        private List<Pessoa> Hospede { get; set; }
        private Suite Suite { get; set; }
        private int DiasReservados { get; set; }

        public Reserva(int DiasReservados)
        {
            this.DiasReservados = DiasReservados;
        }
        public Reserva()
        {

        }


        public void CadastrarHospedes(List<Pessoa> hospedes)
        {
            int TotalHospede = 0;
            foreach (var item in hospedes)
            {
                TotalHospede++;
            }
                
            if (Suite.Capacidade >= TotalHospede)
            {
                Hospede = hospedes;
            }
            else
            {
              throw new Exception($"Capacidade esgotada! A suite só suporta {Suite.Capacidade} hóspede");
            }
               
            
        }
        public void CadastrarSuite(Suite suite)
        {
            this.Suite = suite;
        }
        public int ObterQuantidadeHospedes()
        {
            int Total= 0;
            foreach (var item in Hospede)
            {
                Total++;

            }
            return Total;
        }
        public decimal CalcularValorDiario()
        {
            decimal ValorTotal = DiasReservados * Suite.Valordiaria;
            decimal Dez = 10;
            decimal Porcentagem = Dez / 100;
            if (DiasReservados >= 10)
            {
               ValorTotal = ValorTotal - ValorTotal * Porcentagem;
            }

            return ValorTotal;
        }
      
       
    }
}
