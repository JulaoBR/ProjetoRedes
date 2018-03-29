using ProjetoRedes.Class;

namespace ProjetoRedes.Class_Camadas_TCPIP
{
    public class Internet
    {
        private PacoteTCP pacote;


        public Internet(PacoteTCP pct)
        {
            this.pacote = pct;
            pacote.camada2 = "Funções aqui";
        }

        public PacoteTCP Retorno()
        {
            return pacote;
        }
    }
}
