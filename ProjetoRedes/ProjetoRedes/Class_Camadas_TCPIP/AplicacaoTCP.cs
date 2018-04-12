using ProjetoRedes.Class;

namespace ProjetoRedes.Class_Camadas_TCPIP
{
    public class AplicacaoTCP
    {
        private PacoteTCP pacote;


        public AplicacaoTCP(PacoteTCP pct)
        {
            this.pacote = pct;
            pacote.camada4 = "Responsável por realizar a comunicação entre os aplicativos e os protocolos de transporte";
        }

        public PacoteTCP Retorno()
        {
            return pacote;
        }
    }
}
