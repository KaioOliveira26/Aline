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
        CRUD controller = new CRUD();

        public CadastroCliente()
        {
            InitializeComponent();
            cleanForm();
        }
        
        private void btnLimpar_Click(object sender, EventArgs e)
        {
            cleanForm();
        }

        private void cleanForm()
        {
            txtCPF.Text = "";
            txtNome.Text = "";
            txtTelefone.Text = "";
            dtpNascimento.Value = DateTime.Now;
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
            controller.NewUser(txtNome.Text, txtCPF.Text, txtTelefone.Text, dtpNascimento.Value);
            DialogResult dialogOk = MessageBox.Show("Cadastro de " + txtNome.Text + " realizado com sucesso!", "Cadastro Realizado!", MessageBoxButtons.OK);
            if(dialogOk == DialogResult.OK)
            {
                DialogResult dialogYesNo = MessageBox.Show("Deseja cadastrar outro usuário?", "Deseja Cadastrar outros usuários?", MessageBoxButtons.YesNo);
                if(dialogYesNo == DialogResult.Yes)
                {
                    cleanForm();
                }
                else if(dialogYesNo == DialogResult.No)
                {
                    Principal main = new Principal();
                    main.Show();
                    this.Dispose();
                }
            }
        }
    }
}