using System;
using System.Windows.Forms;
using System.Timers;
using System.Drawing;

namespace ProjetoRedes
{
    public partial class Chat01 : Form
    {
        Pacote pacote = new Pacote();

        public Chat01()
        {
            InitializeComponent();
        }

        private void Chat01_Load(object sender, EventArgs e)
        {
            camada1.Visible = false;
            camada2.Visible = false;
            camada3.Visible = false;
            camada4.Visible = false;
            camada5.Visible = false;
            camada6.Visible = false;
            camada7.Visible = false;
        }

        private void btnEnviar_Click(object sender, EventArgs e)
        {
            if (txtDados.Text != string.Empty)
            {

                Camada7();
                Camada6();
                Camada5();
                Camada4();
                Camada3();
                Camada2();
                Camada1();

                Enviado();

                Chat02 chat2 = new Chat02(pacote);
                chat2.Show();
                chat2.Location = new Point(1050, 50);

                btnEnviar.Enabled = false;
            }
            else
            {
                MessageBox.Show("Digite alguma coisa","ATENÇÃO", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                txtDados.Focus();
            }
        }

        private void Camada7()
        {
            pacote.dados = txtDados.Text;
            Apresentacao aps = new Apresentacao(pacote);


            txtExibi.AppendText("CHAMANDO CAMADA DE APRESENTAÇÃO..." + "\r\n\n");
            txtExibi.AppendText("\r\n\n");
            pacote = aps.Retorno();
            txtExibi.AppendText("INFORMAÇÃO ENVIADA: " + pacote.dados + "\r\n" +
                                "FUNÇÃO: " + pacote.camada6 + "\r\n");
            txtExibi.AppendText("\r\n\n");
            camada6.Visible = true;
            Aplicacao apl = new Aplicacao(pacote);


            txtExibi.AppendText("CHAMANDO CAMADA DE APLICAÇÃO..." + "\r\n\n");
            txtExibi.AppendText("\r\n\n");
            pacote = apl.Retorno();
            txtExibi.AppendText("INFORMAÇÃO ENVIADA: " + pacote.dados + "\r\n" + 
                                "FUNÇÃO: " + pacote.camada7 + "\r\n");
            txtExibi.AppendText("\r\n\n");
            camada7.Visible = true;

        }

        private void Camada6()
        {
            Apresentacao aps = new Apresentacao(pacote);


            txtExibi.AppendText("CHAMANDO CAMADA DE APRESENTAÇÃO..." + "\r\n\n");
            txtExibi.AppendText("\r\n\n");
            pacote = aps.Retorno();
            txtExibi.AppendText("INFORMAÇÃO ENVIADA: " + pacote.dados + "\r\n" +
                                "FUNÇÃO: " + pacote.camada6 + "\r\n");
            txtExibi.AppendText("\r\n\n");
            camada6.Visible = true;
        }

        private void Camada5()
        {
            Transporte tra = new Transporte(pacote);


            txtExibi.AppendText("CHAMANDO CAMADA DE TRANSPORTE..." + "\r\n\n");
            txtExibi.AppendText("\r\n\n");
            pacote = tra.Retorno();
            txtExibi.AppendText("INFORMAÇÃO ENVIADA: " + pacote.dados + "\r\n" +
                                "FUNÇÃO: " + pacote.camada5 + "\r\n");
            txtExibi.AppendText("\r\n\n");
            camada5.Visible = true;
        }

        private void Camada4()
        {
            Sessao ses = new Sessao(pacote);


            txtExibi.AppendText("CHAMANDO CAMADA DE SESSÃO..." + "\r\n\n");
            txtExibi.AppendText("\r\n\n");
            pacote = ses.Retorno();
            txtExibi.AppendText("INFORMAÇÃO ENVIADA: " + pacote.dados + "\r\n" +
                                "FUNÇÃO: " + pacote.camada4 + "\r\n");
            txtExibi.AppendText("\r\n\n");
            camada4.Visible = true;
        }

        private void Camada3()
        {
            Redes red = new Redes(pacote);


            txtExibi.AppendText("CHAMANDO CAMADA DE REDES..." + "\r\n\n");
            txtExibi.AppendText("\r\n\n");
            pacote = red.Retorno();
            txtExibi.AppendText("INFORMAÇÃO ENVIADA: " + pacote.dados + "\r\n" +
                                "FUNÇÃO: " + pacote.camada3 + "\r\n");
            txtExibi.AppendText("\r\n\n");
            camada3.Visible = true;
        }

        private void Camada2()
        {
            Enlace enl = new Enlace(pacote);


            txtExibi.AppendText("CHAMANDO CAMADA DE ENLACE..." + "\r\n\n");
            txtExibi.AppendText("\r\n\n");
            pacote = enl.Retorno();
            txtExibi.AppendText("INFORMAÇÃO ENVIADA: " + pacote.dados + "\r\n" +
                                "FUNÇÃO: " + pacote.camada2 + "\r\n");
            txtExibi.AppendText("\r\n\n");
            camada2.Visible = true;
        }

        private void Camada1()
        {
            Fisica aps = new Fisica(pacote);


            txtExibi.AppendText("CHAMANDO CAMADA DE FISICA..." + "\r\n\n");
            txtExibi.AppendText("\r\n\n");
            pacote = aps.Retorno();
            txtExibi.AppendText("INFORMAÇÃO ENVIADA: " + pacote.dados + "\r\n" +
                                "FUNÇÃO: " + pacote.camada1 + "\r\n");
            txtExibi.AppendText("\r\n\n");
            camada1.Visible = true;
        }

        private void Enviado()
        {
            txtExibi.AppendText("<< Pacote enviado para o destinatario >>  \r\n\n");
        }


        private void timer1_Tick(object sender, EventArgs e)
        {

        }

    }
}
