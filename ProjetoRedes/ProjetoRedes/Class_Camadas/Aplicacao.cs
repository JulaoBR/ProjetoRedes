using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoRedes
{
    public class Aplicacao 
    {
        private Pacote pacote;


        public Aplicacao(Pacote pct)
        {
            this.pacote = pct;
            pacote.protololos = "HTTP,FTP, ETC";
        }

        public Pacote Retorno()
        {
            return pacote;

        }
    }
}
