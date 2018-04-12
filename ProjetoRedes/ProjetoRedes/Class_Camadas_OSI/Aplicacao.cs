using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoRedes
{
    public class Aplicacao 
    {
        private PacoteOSI pacote;


        public Aplicacao(PacoteOSI pct)
        {
            this.pacote = pct;
            pacote.camada7 = "Responsável pela transferência de arquivos, terminal virtual, e-mail";
        }

        public PacoteOSI Retorno()
        {
            return pacote;
        }
    }
}
