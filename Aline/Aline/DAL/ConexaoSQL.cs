using System;
using MySql.Data.MySqlClient;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.Data;
using System.Windows.Forms;

namespace Aline.DAL
{
    class ConexaoSQL
    {
        private static MySqlConnection conexao;

        public void ConexaoMySQL()
        {
            Inicializar();
        }

        private void Inicializar()
        {
            if (conexao == null)
            {
                conexao = new MySqlConnection();
                // string de conexão com o MySQL obtida do arquivo App.config
                conexao.ConnectionString = ConfigurationManager.ConnectionStrings["mysql"].ConnectionString;
            }
        }

       
    }
}
