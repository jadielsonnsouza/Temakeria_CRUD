using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Temakeria_CRUD.Code.ConexaoBD;

namespace Temakeria_CRUD.Code.CRUD
{
    class TabelaContato
    {

        public int Id_Contato { get; set; }

        private string strInseriTabelaContato = "insert into Contato (celular, telefone, email) " +
                                                "values (@celular, @telefone, @email)";

        public void insereTabelaContato(string celular, string telefone, string email)
        {
            SqlCommand cmd = new SqlCommand();
            Conexao conexaoBD = new Conexao();

            cmd.CommandText = strInseriTabelaContato;
            cmd.Parameters.AddWithValue("@celular", celular);
            cmd.Parameters.AddWithValue("@telefone", telefone);
            cmd.Parameters.AddWithValue("@email", email);            
            conexaoBD.executaConexao(cmd);
        }
    }
}
