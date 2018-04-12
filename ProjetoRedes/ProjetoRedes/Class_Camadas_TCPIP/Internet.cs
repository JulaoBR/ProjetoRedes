using ProjetoRedes.Class;

namespace ProjetoRedes.Class_Camadas_TCPIP
{
    public class Internet
    {
        private PacoteTCP pacote;


        public Internet(PacoteTCP pct)
        {
            this.pacote = pct;
            pacote.camada2 = "Responável por dividir os dados em pacotes (datagrama) e envia-los para a camada de interface. Essa camada roteia os pacotes adicionando informações sobre o caminho à ser percorrido.";
        }

        public PacoteTCP Retorno()
        {
            return pacote;
        }
    }
}
