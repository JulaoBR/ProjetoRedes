using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoRedes
{
    public class Pacote
    {
        //DADOS A SER ENVIADO
        public string dados { get; set; }

        //INFORMAÇÔES DA CAMADA DE APLICAÇÃO
        public string camada7 { get; set; }

        //INFORMAÇÔES DA CAMADA DE APRESENTAÇÃO
        public string camada6 { get; set; }

        //INFORMAÇÕES DA CAMADA DE SESSAO
        public string camada5 { get; set; }

        //INFORMAÇõES DA CAMADA DE TRANSPORTE
        public string camada4 { get; set; }

        //INFORMAÇõES DA CAMADA DE REDE
        public string camada3 { get; set; }

        //INFORMAÇõES DA CAMADA DE ENLACE
        public string camada2 { get; set; }

        //INFORMAÇõES DA CAMADA FISICA
        public string camada1 { get; set; }
    }
}
