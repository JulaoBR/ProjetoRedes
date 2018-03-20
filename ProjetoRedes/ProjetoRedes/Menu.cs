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

        public Menu()
        {
            InitializeComponent();
        }

        private void btnIniciar_Click(object sender, EventArgs e)
        {
            
            chat1.Show();
            chat1.Location = new Point(100, 50);  
        }

    }
}
