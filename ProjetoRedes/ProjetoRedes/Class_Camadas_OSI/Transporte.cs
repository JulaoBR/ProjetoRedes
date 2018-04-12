using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoRedes
{
    public class Transporte
    {
        private PacoteOSI pacote;

        public Transporte(PacoteOSI pct)
        {
            this.pacote = pct;
            pacote.camada4 = "Responsável pelos meios e métodos para a entrega de dados ponta-a-ponta";
        }

        public PacoteOSI Retorno()
        {
            return pacote;
        }
    }
}
