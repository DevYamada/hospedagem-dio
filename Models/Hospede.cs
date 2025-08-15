using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Hospedagem.Models
{
    public class Hospede
    {
        public string Nome { get; set; }
        public string SobreNome { get; set; }

        public Hospede(string nomeCompleto)
        {
            if (!string.IsNullOrWhiteSpace(nomeCompleto) && nomeCompleto.Split(' ').Length > 1)
            {
                var nomePartes = nomeCompleto.Split(' ');

                Nome = nomePartes[0];

                SobreNome = string.Join(" ", nomePartes.Skip(1));
            }
            else
            {
                Nome = nomeCompleto;
                SobreNome = string.Empty;
            }
        }
    }
}
