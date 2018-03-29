using ProjetoRedes.Class;

namespace ProjetoRedes.Class_Camadas_TCPIP
{
    public class TransporteTCP
    {
        private PacoteTCP pacote;


        public TransporteTCP(PacoteTCP pct)
        {
            this.pacote = pct;
            pacote.camada3 = "Funções aqui";
        }

        public PacoteTCP Retorno()
        {
            return pacote;
        }
    }
}
