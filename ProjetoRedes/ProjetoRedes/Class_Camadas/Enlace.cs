using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoRedes
{
    public class Enlace
    {
        private Pacote pacote;

        public Enlace(Pacote pct)
        {
            this.pacote = pct;
            pacote.camada2 = "Detecção e correção de erros introduzidos pelo meio de transmissão";
        }

        public Pacote Retorno()
        {
            return pacote;
        }
    }
}
