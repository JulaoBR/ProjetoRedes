using ProjetoRedes.Class;
using System;
using System.Windows.Forms;

namespace ProjetoRedes
{
    public partial class Tela04 : Form
    {
        private PacoteTCP pacote = new PacoteTCP();

        public Tela04(PacoteTCP pct)
        {
            InitializeComponent();
            this.pacote = pct;
        }

        private void Tela04_Load_1(object sender, EventArgs e)
        {
            btnCamada4.Visible = false;
            btnCamada3.Visible = false;
            btnCamada2.Visible = false;
            btnCamada1.Visible = false;

            camada4.Visible = false;
            camada3.Visible = false;
            camada2.Visible = false;
            camada1.Visible = false;

            btnCamada1.Visible = true;
            Camada1();
        }

        private void Camada1()
        {
            txtExibi.AppendText("CHEGOU NA CAMADA ACESSO À REDE..." + "\r\n\n");
            txtExibi.AppendText("\r\n\n");
            txtExibi.AppendText("FUNÇÃO: Pacote recebido\r\n\n");
            txtExibi.AppendText("\r\n\n");
            camada1.Visible = true;
        }

        private void Camada2()
        {
            txtExibi.AppendText("CHEGOU NA CAMADA INTERNET..." + "\r\n\n");
            txtExibi.AppendText("\r\n\n");
            txtExibi.AppendText("FUNÇÃO: Pacote recebido\r\n\n");
            txtExibi.AppendText("\r\n\n");
            camada2.Visible = true;
        }

        private void Camada3()
        {
            txtExibi.AppendText("CHEGOU NA CAMADA TRANSPORTE..." + "\r\n\n");
            txtExibi.AppendText("\r\n\n");
            txtExibi.AppendText("FUNÇÃO: Pacote recebido\r\n\n");
            txtExibi.AppendText("\r\n\n");
            camada3.Visible = true;
        }

        private void Camada4()
        {
            txtExibi.AppendText("CHEGOU NA CAMADA APLICAÇÃO..." + "\r\n\n");
            txtExibi.AppendText("\r\n\n");
            txtExibi.AppendText("FUNÇÃO: Pacote recebido\r\n\n");
            txtExibi.AppendText("\r\n\n");
            camada4.Visible = true;
        }

        private void btnCamada1_Click_1(object sender, EventArgs e)
        {
            btnCamada1.Visible = false;
            btnCamada2.Visible = true;
            Camada2();
        }

        private void btnCamada2_Click_1(object sender, EventArgs e)
        {
            btnCamada2.Visible = false;
            btnCamada3.Visible = true;
            Camada3();
        }

        private void btnCamada3_Click_1(object sender, EventArgs e)
        {
            btnCamada3.Visible = false;
            btnCamada4.Visible = true;
            Camada4();
        }

        private void btnCamada4_Click_1(object sender, EventArgs e)
        {
            txtDados.Text = pacote.dados;
        }
    }
}
