using System;
using System.Windows.Forms;

namespace Aline
{
    public partial class Tarefa : Form
    {
        public Tarefa()
        {
            InitializeComponent();
        }

        private void btnRetornar_Click(object sender, EventArgs e)
        {
            Principal tlCliente = new Principal();
            tlCliente.Show();
            this.Dispose();
        }

        private void btnAdicionarTarefa_Click(object sender, EventArgs e)
        {
            CadastroTarefa tlAdicionarTarefa = new CadastroTarefa();
            tlAdicionarTarefa.Show();
            this.Visible = false;
        }
    }
}
