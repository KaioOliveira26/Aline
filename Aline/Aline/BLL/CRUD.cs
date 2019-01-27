using Aline.DAL;
using System.Data.SqlClient;
using System;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Aline.BLL
{
    class CRUD
    {
        private ConexaoSQL con = new ConexaoSQL();
        private SqlDataAdapter dataAdapter;

        public void NewUser (string name, string cpf, string phone, DateTime birthday)
        {
            string query;
            query = "INSERT INTO users (user_name, user_cpf, user_phone, birthday, creation_date) " +
                    "VALUES ('" + name + "', '" + cpf + "', '" + phone + "', '" + birthday.ToString("yyy-MM-dd") + "', '" + DateTime.Now.ToString("yyy-MM-dd") + "');";

            con.Query(query);
        }

        public SqlDataReader Query(string query)
        {
            con = new ConexaoSQL();

            return con.Query(query);
        }

        public SqlDataReader GetUsers(int from, int to)
        {
            con = new ConexaoSQL();

            string query;
            query = "SELECT * FROM users limit(" + from + ", " + to + ")";
            SqlDataReader data = con.Query(query);

            return data;
        }

        public string getDate(DateTime date)
        {
            string new_date = date.Year.ToString() + "-" + date.Month.ToString("mm") + "-" + date.Day.ToString();
            return new_date;
        }

        public DataTable FillDataGrid(string selectCommand, DataGridView dataGridView1)
        {
            DataTable table = new DataTable();
            try
            {
                string connectionString = con.connectionString;

                // Create a new data adapter based on the specified query.
                dataAdapter = new SqlDataAdapter(selectCommand, connectionString);

                // Create a command builder to generate SQL update, insert, and
                // delete commands based on selectCommand. These are used to
                // update the database.
                SqlCommandBuilder commandBuilder = new SqlCommandBuilder(dataAdapter);

                // Populate a new data table and bind it to the BindingSource.
                table.Locale = System.Globalization.CultureInfo.InvariantCulture;
                dataAdapter.Fill(table);
            }
            catch (SqlException e)
            {
                Console.WriteLine(e.Message);
            }

            return table;     
        }

        /*
        public void Create()
        {
            SqlDataReader data = 

            while (data.Read())
            {
                
            }
        }*/
    }
}