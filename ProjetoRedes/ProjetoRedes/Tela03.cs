using ProjetoRedes.Class;
using ProjetoRedes.Class_Camadas_TCPIP;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace ProjetoRedes
{
    public partial class Tela03 : Form
    {
        PacoteTCP pacote = new PacoteTCP();

        public Tela03()
        {
            InitializeComponent();
        }

        private void Tela03_Load(object sender, EventArgs e)
        {
            btnCamada4.Visible = false;
            btnCamada3.Visible = false;
            btnCamada2.Visible = false;
            btnCamada1.Visible = false;

            camada4.Visible = false;
            camada3.Visible = false;
            camada2.Visible = false;
            camada1.Visible = false;
        }

        private void btnEnviar_Click(object sender, EventArgs e)
        {
            if (txtDados.Text != string.Empty)
            {
                btnCamada4.Visible = true;

                Camada4();

                btnEnviar.Enabled = false;
            }
            else
            {
                MessageBox.Show("Digite alguma coisa", "ATENÇÃO", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                txtDados.Focus();
            }
        }

        private void Camada4()
        {
            pacote.dados = txtDados.Text;

            AplicacaoTCP apl = new AplicacaoTCP(pacote);


            txtExibi.AppendText("CHAMANDO CAMADA DE APLICAÇÃO..." + "\r\n\n");
            txtExibi.AppendText("\r\n\n");
            pacote = apl.Retorno();
            txtExibi.AppendText("INFORMAÇÃO ENVIADA: " + pacote.dados + "\r\n" +
                                "FUNÇÃO: " + pacote.camada4 + "\r\n");
            txtExibi.AppendText("\r\n\n");
            camada4.Visible = true;

        }

        private void Camada3()
        {

            TransporteTCP tra = new TransporteTCP(pacote);


            txtExibi.AppendText("CHAMANDO CAMADA DE TRANSPORTE..." + "\r\n\n");
            txtExibi.AppendText("\r\n\n");
            pacote = tra.Retorno();
            txtExibi.AppendText("INFORMAÇÃO ENVIADA: " + pacote.dados + "\r\n" +
                                "FUNÇÃO: " + pacote.camada3 + "\r\n");
            txtExibi.AppendText("\r\n\n");
            camada3.Visible = true;

        }

        private void Camada2()
        {

            Internet tra = new Internet(pacote);


            txtExibi.AppendText("CHAMANDO CAMADA DE INTERNET..." + "\r\n\n");
            txtExibi.AppendText("\r\n\n");
            pacote = tra.Retorno();
            txtExibi.AppendText("INFORMAÇÃO ENVIADA: " + pacote.dados + "\r\n" +
                                "FUNÇÃO: " + pacote.camada2 + "\r\n");
            txtExibi.AppendText("\r\n\n");
            camada2.Visible = true;

        }

        private void Camada1()
        {

            RedeTCP tra = new RedeTCP(pacote);


            txtExibi.AppendText("CHAMANDO CAMADA DE REDES..." + "\r\n\n");
            txtExibi.AppendText("\r\n\n");
            pacote = tra.Retorno();
            txtExibi.AppendText("INFORMAÇÃO ENVIADA: " + pacote.dados + "\r\n" +
                                "FUNÇÃO: " + pacote.camada1 + "\r\n");
            txtExibi.AppendText("\r\n\n");
            camada1.Visible = true;

        }

        private void btnCamada4_Click(object sender, EventArgs e)
        {
            btnCamada4.Visible = false;
            btnCamada3.Visible = true;
            Camada3();
        }

        private void btnCamada3_Click(object sender, EventArgs e)
        {
            btnCamada3.Visible = false;
            btnCamada2.Visible = true;
            Camada2();
        }

        private void btnCamada2_Click(object sender, EventArgs e)
        {
            btnCamada2.Visible = false;
            btnCamada1.Visible = true;
            Camada1();
        }

        private void btnCamada1_Click(object sender, EventArgs e)
        {
            Enviado();

            Tela04 chat2 = new Tela04(pacote);
            chat2.Show();
            chat2.Location = new Point(800, 50);

            btnCamada1.Visible = false;

            btnCamada1.Visible = false;
        }

        private void Enviado()
        {
            txtExibi.AppendText("<< Pacote enviado para o destinatario >>  \r\n\n");
        }
    }
}
