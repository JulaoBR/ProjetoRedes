using ProjetoRedes.Class;
using System.Windows.Forms;

namespace ProjetoRedes
{
    public partial class Tela04 : Form
    {
        private PacoteTCP pacote = new PacoteTCP();

        public Tela04(PacoteTCP pct)
        {
            InitializeComponent();
            this.pacote = pct;
        }
    }
}
