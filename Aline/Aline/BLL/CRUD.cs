using Aline.DAL;
using MySql.Data.MySqlClient;
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
        private ConexaoSQL conexao;
        private string Nome,CPF,Telefone;
        private DateTime Nascimento;


        public void Coleta (string Nome, string CPF, string Telefone, DateTime Nascimento)
        {
            this.Nome = Nome;
            this.CPF = CPF;
            this.Telefone = Telefone;
            this.Nascimento = Nascimento;
        }
        public void Create()
        {

           conexao = new ConexaoSQL();
            String sql = "INSERT INTO PRODUTO (Nome, CPF, Preco,Nascimento) " +
                    "VALUES (" + Nome + ", '" + CPF + "', " + Telefone + ", "+ Nascimento +")";
         
        }
    }
}
