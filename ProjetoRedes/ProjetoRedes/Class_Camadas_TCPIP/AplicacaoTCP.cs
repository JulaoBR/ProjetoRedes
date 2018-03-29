using ProjetoRedes.Class;

namespace ProjetoRedes.Class_Camadas_TCPIP
{
    public class AplicacaoTCP
    {
        private PacoteTCP pacote;


        public AplicacaoTCP(PacoteTCP pct)
        {
            this.pacote = pct;
            pacote.camada4 = "Funções aqui";
        }

        public PacoteTCP Retorno()
        {
            return pacote;
        }
    }
}
