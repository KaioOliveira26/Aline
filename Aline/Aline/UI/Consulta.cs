using System;
using Aline.BLL;
using System.Data.SqlClient;
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
    public partial class Consulta : Form
    {
        CRUD controller = new CRUD();

        public Consulta()
        {
            InitializeComponent();
        }

        private void btnRetornar_Click(object sender, EventArgs e)
        {
            Cliente tlCliente = new Cliente();
            tlCliente.Show();
            this.Dispose();
        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {

        }

        private void Consulta_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'alineEventsDataSet.users' table. You can move, or remove it, as needed.
            this.usersTableAdapter.Fill(this.alineEventsDataSet.users);
        }

        private void name_filter_check_CheckedChanged(object sender, EventArgs e)
        {
            name_filter.Enabled = !name_filter.Enabled;
            dataGridView1.column
        }

        private void cpf_filter_check_CheckedChanged(object sender, EventArgs e)
        {
            cpf_filter.Enabled = !cpf_filter.Enabled;
        }

        private void birthday_filter_check_CheckedChanged(object sender, EventArgs e)
        {
            birthday_filter.Enabled = !birthday_filter.Enabled;
        }

        private void creation_date_filter_check_CheckedChanged(object sender, EventArgs e)
        {
            creation_date_filter.Enabled = !creation_date_filter.Enabled;
        }
    }
}