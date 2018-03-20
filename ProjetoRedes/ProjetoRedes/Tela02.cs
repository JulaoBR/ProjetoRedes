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
        private Pacote pacote;

        public Tela02(Pacote pct)
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

        }

        private void Camada3()
        {

        }

        private void Camada4()
        {

        }

        private void Camada5()
        {

        }

        private void Camada6()
        {

        }

        private void Camada7()
        {

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
        }

        private void btnCamada2_Click(object sender, EventArgs e)
        {
            btnCamada2.Visible = false;
            btnCamada3.Visible = true;
        }

        private void btnCamada3_Click(object sender, EventArgs e)
        {
            btnCamada3.Visible = false;
            btnCamada4.Visible = true;
        }

        private void btnCamada4_Click(object sender, EventArgs e)
        {
            btnCamada4.Visible = false;
            btnCamada5.Visible = true;
        }

        private void btnCamada5_Click(object sender, EventArgs e)
        {
            btnCamada5.Visible = false;
            btnCamada6.Visible = true;
        }

        private void btnCamada6_Click(object sender, EventArgs e)
        {
            btnCamada6.Visible = false;
            btnCamada7.Visible = true;
        }
    }
}
