
namespace ProjetoRedes
{
    public class PacoteOSI
    {
        //DADOS A SER ENVIADO
        public string dados { get; set; }
        
        //NOME DA CAMADA
        public string nome_camada { get; set; }

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
