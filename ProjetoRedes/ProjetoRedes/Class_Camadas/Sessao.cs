using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoRedes
{
    public class Sessao
    {
        //SOBE PARA CAMADA 6
        Apresentacao apr = new Apresentacao();
        //DESCE A CAMADA 4
        Transporte tra = new Transporte();


        //CONSTRUTOR DA CLASSE
        public Sessao()
        {

        }
    }
}
