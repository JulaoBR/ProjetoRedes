using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoRedes
{
    public class Transporte
    {
        private Pacote pacote;

        public Transporte(Pacote pct)
        {
            this.pacote = pct;
            pacote.camada4 = "Meios e métodos para a entrega de dados ponta-a-ponta";
        }

        public Pacote Retorno()
        {
            return pacote;
        }
    }
}
