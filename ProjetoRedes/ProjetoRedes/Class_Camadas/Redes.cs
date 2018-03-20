using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoRedes
{
    public class Redes
    {
        private Pacote pacote;
        public Redes(Pacote pct)
        {
            this.pacote = pct;
            pacote.camada3 = "Roteamento de pacotes através de uma ou várias redes";
        }

        public Pacote Retorno()
        {
            return pacote;
        }
    }
}
