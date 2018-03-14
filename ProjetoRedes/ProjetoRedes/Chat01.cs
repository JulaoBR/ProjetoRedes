using System;
using System.Windows.Forms;
using System.Timers;

namespace ProjetoRedes
{
    public partial class Chat01 : Form
    {

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
            Aplicacao apl = new Aplicacao();
            Apresentacao apr = new Apresentacao();

            txtExibi.AppendText("CHAMANDO CAMADA DE APLICAÇÃO..." + "\r\n\n");
            txtExibi.AppendText(apl.Inicia() + "\r\n");
            camada7.Visible = true;

            timer1_Tick(sender, e);

            txtExibi.AppendText("CHAMANDO CAMADA DE APRESENTACAO..." + "\r\n\n");
            txtExibi.AppendText(apr.Retorno() + "\r\n");
            camada6.Visible = true;
        }


        private void timer1_Tick(object sender, EventArgs e)
        {
           
        }
    }
}
