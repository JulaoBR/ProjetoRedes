using System;
using System.Windows.Forms;
using System.Timers;

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

            Camada7();
      
        }

        private void Camada7()
        {
            pacote.dados = txtDados.Text;
            Aplicacao apl = new Aplicacao(pacote);

            txtExibi.AppendText("CHAMANDO CAMADA DE APLICAÇÃO..." + "\r\n\n");
            pacote = apl.Retorno();
            txtExibi.AppendText("INFORMAÇÃO: " + pacote.dados + "\r\n" + 
                                "PROTOLOS: " + pacote.protololos + "\r\n");
            camada7.Visible = true;

        }

        private void Camada6()
        {

        }

        private void Camada5()
        {

        }

        private void Camada4()
        {

        }

        private void Camada3()
        {

        }

        private void Camada2()
        {

        }

        private void Camada1()
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
           
        }
    }
}
