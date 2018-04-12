using ProjetoRedes.Class;

namespace ProjetoRedes.Class_Camadas_TCPIP
{
    public class RedeTCP
    {
        private PacoteTCP pacote;


        public RedeTCP(PacoteTCP pct)
        {
            this.pacote = pct;
            pacote.camada1 = "Responsável por enviar o datagrama recebido da camada de internet em forma de quadro atraveés da rede.";
        }

        public PacoteTCP Retorno()
        {
            return pacote;
        }
    }
}
