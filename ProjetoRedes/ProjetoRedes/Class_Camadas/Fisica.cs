using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoRedes
{
    public class Fisica
    {
        private Pacote pacote;
        public Fisica(Pacote pct)
        {
            this.pacote = pct;
            pacote.camada1 = "Transmissão dos bits através do meio de transmissão";
        }

        public Pacote Retorno()
        {
            return pacote;
        }
    }
}
