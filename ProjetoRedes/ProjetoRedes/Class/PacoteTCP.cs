using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoRedes.Class
{
    public class PacoteTCP
    {
        //DADOS A SER ENVIADO
        public string dados { get; set; }

        //NOME DA CAMADA
        public string nome_camada { get; set; }

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
