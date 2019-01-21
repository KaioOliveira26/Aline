using System;
using Aline.Interface;
using Aline.BLL;
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
    public partial class CadastroCliente : Form
    {
        
        public CadastroCliente()
        {
            InitializeComponent();
        }
        
        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txtCPF.Text = "";
            txtNome.Text = "";
            txtTelefone.Text = "";
            dtpNascimento.Value=DateTime.Now;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Cliente tlCliente = new Cliente();
            tlCliente.Show();
            this.Dispose();
        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {

        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            CRUD cadastro = new CRUD();
            cadastro.Coleta(txtNome.Text, txtCPF.Text, txtTelefone.Text, dtpNascimento.Value);
            cadastro.Create();
        }
    }
}
