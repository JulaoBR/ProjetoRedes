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

        Chat01 chat1 = new Chat01();
        Chat02 chat2 = new Chat02();

        public Menu()
        {
            InitializeComponent();
        }

        private void btnIniciar_Click(object sender, EventArgs e)
        {
            
            chat1.Show();
            chat1.Location = new Point(100, 50);  
            chat2.Show();
            chat2.Location = new Point(1050, 50);
        }

        private void btnFinalizar_Click(object sender, EventArgs e)
        {
            chat1.Hide();
            chat2.Hide();
        }
    }
}
