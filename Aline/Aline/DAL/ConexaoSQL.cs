using System;
using System.Data.SqlClient;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Windows.Forms;

namespace Aline.DAL
{
    class ConexaoSQL
    {
        private static SqlConnection connection;
        public string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Desenvolvimento\Kaio\Aline\Aline\Aline\Aline\Database\AlineEvents.mdf;Integrated Security=True";

        public ConexaoSQL()
        {
            Inicializar();
        }

        private void Inicializar()
        {
            if (connection == null)
            {
                connection = new SqlConnection();
                // string de conexão com o MySQL obtida do arquivo App.config
                connection.ConnectionString = connectionString;
            }
        }

        public SqlDataReader Query(string query)
        {
            connection.Open();
            SqlCommand command = new SqlCommand(query, connection);
            SqlDataReader data = command.ExecuteReader();
            connection.Close();
            return data;
        }
    }
}
