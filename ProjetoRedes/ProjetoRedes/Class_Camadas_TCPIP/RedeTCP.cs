using ProjetoRedes.Class;

namespace ProjetoRedes.Class_Camadas_TCPIP
{
    public class RedeTCP
    {
        private PacoteTCP pacote;


        public RedeTCP(PacoteTCP pct)
        {
            this.pacote = pct;
            pacote.camada1 = "Funções aqui";
        }

        public PacoteTCP Retorno()
        {
            return pacote;
        }
    }
}
