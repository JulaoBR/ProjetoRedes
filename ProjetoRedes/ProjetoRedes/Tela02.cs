using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetoRedes
{
    public partial class Tela02 : Form
    {
        private PacoteOSI pacote;

        public Tela02(PacoteOSI pct)
        {
            InitializeComponent();
            EscondeAsCamadas();
            this.pacote = pct;
        }

        private void Chat02_Load(object sender, EventArgs e)
        {
            btnCamada1.Visible = true;
            Camada1();
        }

        private void Camada1()
        {
            txtExibi.AppendText("CHEGOU NA CAMADA FISICA..." + "\r\n\n");
            txtExibi.AppendText("\r\n\n");
            txtExibi.AppendText("FUNÇÃO: Pacote recebido\r\n\n");
            txtExibi.AppendText("\r\n\n");
            camada1.Visible = true;
        }

        private void Camada2()
        {
            txtExibi.AppendText("CHEGOU NA CAMADA ENLACE..." + "\r\n\n");
            txtExibi.AppendText("\r\n\n");
            txtExibi.AppendText("FUNÇÃO: Pacote recebido\r\n\n");
            txtExibi.AppendText("\r\n\n");
            camada2.Visible = true;
        }

        private void Camada3()
        {
            txtExibi.AppendText("CHEGOU NA CAMADA REDES..." + "\r\n\n");
            txtExibi.AppendText("\r\n\n");
            txtExibi.AppendText("FUNÇÃO: Pacote recebido\r\n\n");
            txtExibi.AppendText("\r\n\n");
            camada3.Visible = true;
        }

        private void Camada4()
        {
            txtExibi.AppendText("CHEGOU NA CAMADA TRANSPORTE..." + "\r\n\n");
            txtExibi.AppendText("\r\n\n");
            txtExibi.AppendText("FUNÇÃO: Pacote recebido\r\n\n");
            txtExibi.AppendText("\r\n\n");
            camada4.Visible = true;
        }

        private void Camada5()
        {
            txtExibi.AppendText("CHEGOU NA CAMADA SESSÃO..." + "\r\n\n");
            txtExibi.AppendText("\r\n\n");
            txtExibi.AppendText("FUNÇÃO: Pacote recebido\r\n\n");
            txtExibi.AppendText("\r\n\n");
            camada5.Visible = true;
        }

        private void Camada6()
        {
            txtExibi.AppendText("CHEGOU NA CAMADA APRESENTAÇÃO..." + "\r\n\n");
            txtExibi.AppendText("\r\n\n");
            txtExibi.AppendText("FUNÇÃO: Pacote recebido\r\n\n");
            txtExibi.AppendText("\r\n\n");
            camada6.Visible = true;
        }

        private void Camada7()
        {
            txtExibi.AppendText("CHEGOU NA CAMADA APLICAÇÃO..." + "\r\n\n");
            txtExibi.AppendText("\r\n\n");
            txtExibi.AppendText("FUNÇÃO: Pacote recebido\r\n\n");
            txtExibi.AppendText("\r\n\n");
            camada7.Visible = true;
        }

        private void EscondeAsCamadas()
        {
            camada1.Visible = false;
            camada2.Visible = false;
            camada3.Visible = false;
            camada4.Visible = false;
            camada5.Visible = false;
            camada6.Visible = false;
            camada7.Visible = false;

            btnCamada1.Visible = false;
            btnCamada2.Visible = false;
            btnCamada3.Visible = false;
            btnCamada4.Visible = false;
            btnCamada5.Visible = false;
            btnCamada6.Visible = false;
            btnCamada7.Visible = false;
        }

        private void btnCamada1_Click(object sender, EventArgs e)
        {
            btnCamada1.Visible = false;
            btnCamada2.Visible = true;
            Camada2();
        }

        private void btnCamada2_Click(object sender, EventArgs e)
        {
            btnCamada2.Visible = false;
            btnCamada3.Visible = true;
            Camada3();
        }

        private void btnCamada3_Click(object sender, EventArgs e)
        {
            btnCamada3.Visible = false;
            btnCamada4.Visible = true;
            Camada4();
        }

        private void btnCamada4_Click(object sender, EventArgs e)
        {
            btnCamada4.Visible = false;
            btnCamada5.Visible = true;
            Camada5();
        }

        private void btnCamada5_Click(object sender, EventArgs e)
        {
            btnCamada5.Visible = false;
            btnCamada6.Visible = true;
            Camada6();
        }

        private void btnCamada6_Click(object sender, EventArgs e)
        {
            btnCamada6.Visible = false;
            btnCamada7.Visible = true;
            Camada7();
        }

        private void btnCamada7_Click(object sender, EventArgs e)
        {
            txtMensagem.Text = pacote.dados;
        }
    }
}
