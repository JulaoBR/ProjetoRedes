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

        Tela01 chat1 = new Tela01();

        public Menu()
        {
            InitializeComponent();
        }

        private void btnIniciar_Click(object sender, EventArgs e)
        {
            
            chat1.Show();
            chat1.Location = new Point(200, 50);  
        }

    }
}
