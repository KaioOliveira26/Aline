using Aline.DAL;
using System.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Aline.BLL
{
    class CRUD
    {
        private ConexaoSQL con;

        public void NewUser (string name, string cpf, string phone, DateTime birthday)
        {
            con = new ConexaoSQL();

            string query = "INSERT INTO users (user_name, user_cpf, user_phone, birthday, creation_date) " +
                    "VALUES ('" + name + "', '" + cpf + "', '" + phone + "', '" + birthday.ToString("yyy-MM-dd") + "', '" + DateTime.Now.ToString("yyy-MM-dd") + "');";

            con.Query(query);
        }

        public string getDate(DateTime date)
        {
            string new_date = date.Year.ToString() + "-" + date.Month.ToString("mm") + "-" + date.Day.ToString();
            return new_date;
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