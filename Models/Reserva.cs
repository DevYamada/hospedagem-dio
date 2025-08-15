using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Hospedagem.Models;

namespace hospedagem.Models
{
    public class Reserva
    {
        public List<Hospede> Pessoas = new List<Hospede>();
        public Suite Suite { get; set; }
        public int diasReservados { get; set; }

        public Reserva(int DiasReservados)
        {
            diasReservados = DiasReservados;
        }

        public void CadastrarSuite(Suite suite)
        {
            Suite = suite;
        }

        public void CadastrarHospedes(List<Hospede> pessoas)
        {
            if (Pessoas.Count <= Suite.Capacidade)
            {
                Pessoas = pessoas;
            }
            else
            {
                throw new Exception("Capacidade excedida!");
            }
        }

        public int ObterQuantidadeHospedes()
        {
            return Pessoas.Count;
        }


        public decimal ObterValor()
        {
            decimal valor = diasReservados * Suite.ValorDiaria;

            if (diasReservados > 10)
            {
                valor *= 0.9M;
            }

            return valor;
        }
    }
}