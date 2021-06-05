using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace Temakeria_CRUD.Code.Conexao
{
    class Conexao
    {
        string conexaoSql = @"Data Source=DESKTOP-U8NKSVS\SQLEXPRESS;Initial Catalog=Temakeria_CRUD;Integrated Security=True";

        SqlConnection conexaoBD = new SqlConnection();

        public Conexao()
        {
            conexaoBD.ConnectionString = conexaoSql;
        }

        //Método que abre conexao com o BD
        public SqlConnection conectar()
        {
            if (conexaoBD.State == ConnectionState.Closed)
            {
                conexaoBD.Open();
            }
            return conexaoBD;
        }

        //Método que fecha a conexao com o BD
        public void desconectar()
        {
            if (conexaoBD.State == ConnectionState.Open)
            {
                conexaoBD.Close();
            }
        }
    }
}
