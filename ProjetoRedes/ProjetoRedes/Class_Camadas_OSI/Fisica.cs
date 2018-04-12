using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoRedes
{
    public class Fisica
    {
        private PacoteOSI pacote;
        public Fisica(PacoteOSI pct)
        {
            this.pacote = pct;
            pacote.camada1 = "Responsável pela transmissão dos bits através do meio de transmissão";
        }

        public PacoteOSI Retorno()
        {
            return pacote;
        }
    }
}
