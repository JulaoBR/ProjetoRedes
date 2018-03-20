using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoRedes
{
    public class Apresentacao
    {
        private Pacote pacote;

        public Apresentacao(Pacote pct)
        {
            this.pacote = pct;
            pacote.camada6 = "Formatação de dados e conversão de caracteres e códigos";
        }

        public Pacote Retorno()
        {
            return pacote;
        }
    }
}
