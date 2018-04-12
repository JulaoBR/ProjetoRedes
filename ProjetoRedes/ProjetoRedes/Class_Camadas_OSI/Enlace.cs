using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoRedes
{
    public class Enlace
    {
        private PacoteOSI pacote;

        public Enlace(PacoteOSI pct)
        {
            this.pacote = pct;
            pacote.camada2 = "Responsável pela detecção e correção de erros introduzidos pelo meio de transmissão";
        }

        public PacoteOSI Retorno()
        {
            return pacote;
        }
    }
}
