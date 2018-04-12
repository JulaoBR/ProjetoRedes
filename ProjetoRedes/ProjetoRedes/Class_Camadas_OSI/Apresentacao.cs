using ProjetoRedes.Class;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoRedes
{
    public class Apresentacao
    {
        private PacoteOSI pacote;

        public Apresentacao(PacoteOSI pct)
        {
            this.pacote = pct;
            pacote.camada6 = "Responsável pela formatação de dados e conversão de caracteres e códigos";
        }

        public PacoteOSI Retorno()
        {
            return pacote;
        }
    }
}
