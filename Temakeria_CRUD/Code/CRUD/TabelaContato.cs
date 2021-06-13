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
        SqlCommand cmd = new SqlCommand();
        Conexao conexaoBD = new Conexao();

        public int Id_Contato { get; set; }

        private string strInseriTabelaContato = "insert into Contato (celular, telefone, email) " +
                                                "values (@celular, @telefone, @email)";

        public void insereTabelaContato(string celular, string telefone, string email)
        {
            cmd.CommandText = strInseriTabelaContato;

            cmd.Parameters.AddWithValue("@celular", celular);
            cmd.Parameters.AddWithValue("@telefone", telefone);
            cmd.Parameters.AddWithValue("@email", email);
            consultaIdTabelaContato(celular, telefone, email);
            conexaoBD.executaConexao(cmd);
        }

        private void consultaIdTabelaContato(string celular, string telefone, string email)
        {
            cmd.CommandText = "select * from Contato where nome = @celular and telefone = @telefone and email = @email";
            cmd.Parameters.AddWithValue("@celular", celular);
            cmd.Parameters.AddWithValue("@telefone", telefone);
            cmd.Parameters.AddWithValue("@email", email);
            conexaoBD.consultaConsultaBD(cmd, "consulta_tabela_contato");
            retornaString(conexaoBD);
        }

        private void retornaString(Conexao conexaoBD)
        {
            this.Id_Contato = conexaoBD.Id_Contato;
        }
    }
}
