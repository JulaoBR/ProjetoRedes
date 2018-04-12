using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoRedes
{
    public class Sessao
    {
        private PacoteOSI pacote;

        public Sessao(PacoteOSI pct)
        {
            this.pacote = pct;
            pacote.camada5 = "Responsável pela negociação e estabelecimento de conexão com outro nó";
        }

        public PacoteOSI Retorno()
        {
            return pacote;
        }
    }
}
