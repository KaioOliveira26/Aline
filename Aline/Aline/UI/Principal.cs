using Aline.Interface;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Aline
{
    public partial class Principal : Form
    {
        public Principal() => InitializeComponent();

        private void btnCliente_Click(object sender, EventArgs e)
        {
            Cliente tlCliente = new Cliente();
            tlCliente.Show();
            this.Dispose();
        }

        private void btnTarefa_Click(object sender, EventArgs e)
        {
            Tarefa tlTarefa = new Tarefa();
            tlTarefa.Show();
            this.Dispose();
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
