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
    public partial class Login : Form
    {
        string usuario="aline", senha="1234";
        public Login()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (usuario == txtUsuario.Text && senha == txtSenha.Text)
            {
                MessageBox.Show("Login realizado com sucesso", "mensagem",MessageBoxButtons.OK,MessageBoxIcon.Information);
                this.Visible = false;
                Principal pr = new Principal();
                pr.Show();
            }
            else
            {
                MessageBox.Show("Informações incorretas", "mensagem",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txtUsuario.Text = "";
            txtSenha.Text = "";
        }
    }
}
