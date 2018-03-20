using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoRedes
{
    public class Sessao
    {
        private Pacote pacote;

        public Sessao(Pacote pct)
        {
            this.pacote = pct;
            pacote.camada5 = "Negociação e estabelecimento de conexão com outro nó";
        }

        public Pacote Retorno()
        {
            return pacote;
        }
    }
}
