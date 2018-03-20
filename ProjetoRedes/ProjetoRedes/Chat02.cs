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
    public partial class Chat02 : Form
    {
        private Pacote pacote;

        public Chat02(Pacote pct)
        {
            InitializeComponent();
            EscondeAsCamadas();
            this.pacote = pct;
        }

        private void Chat02_Load(object sender, EventArgs e)
        {
            Camada1();
        }

        private void Camada1()
        {
            txtExibi.AppendText("CHEGOU NA CAMADA FISICA..." + "\r\n\n");
            txtExibi.AppendText("\r\n\n");
            txtExibi.AppendText("FUNÇÃO: Desempacotou o pacote\r\n\n");
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
        }
    }
}
