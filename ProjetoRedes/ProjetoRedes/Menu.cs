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
    public partial class Menu : Form
    {

        public Menu()
        {
            InitializeComponent();
        }

        private void btnIniciar_Click(object sender, EventArgs e)
        {
            Tela01 chat1 = new Tela01();
            chat1.Show();
            chat1.Location = new Point(200, 50);  
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Tela03 chat3 = new Tela03();
            chat3.Show();
            chat3.Location = new Point(200, 50);
        }
    }
}
