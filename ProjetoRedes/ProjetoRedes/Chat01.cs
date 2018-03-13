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
            
        }
    }
}
