using System;
using Aline.Interface;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Aline.Interface
{
    public partial class Cliente : Form
    {
        public Cliente()
        {
            InitializeComponent();
        }

        private void btnCadastrarClientes_Click(object sender, EventArgs e)
        {
            CadastroCliente Cadastro = new CadastroCliente();
            Cadastro.Show();
            this.Visible = false;
        }

        private void btnConsulta_Click(object sender, EventArgs e)
        {
            Consulta tlConsulta = new Consulta();
            tlConsulta.Show();
            this.Visible = false;
        }

        private void btnRetornar_Click(object sender, EventArgs e)
        {
            Principal tlCliente = new Principal();
            tlCliente.Show();
            this.Dispose();
        }
    }
}
