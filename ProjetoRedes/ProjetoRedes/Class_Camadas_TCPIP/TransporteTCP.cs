using ProjetoRedes.Class;

namespace ProjetoRedes.Class_Camadas_TCPIP
{
    public class TransporteTCP
    {
        private PacoteTCP pacote;


        public TransporteTCP(PacoteTCP pct)
        {
            this.pacote = pct;
            pacote.camada3 = "Responável por captar os dados enviados pela camada de aplicação e transforma-los em pacote, para encaminhar para a camada de internet.";
        }

        public PacoteTCP Retorno()
        {
            return pacote;
        }
    }
}
