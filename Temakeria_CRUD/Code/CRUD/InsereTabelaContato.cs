using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Temakeria_CRUD.Code.ConexaoBD;

namespace Temakeria_CRUD.Code.CRUD
{
    class InsereTabelaContato
    {
        SqlCommand cmd = new SqlCommand();
        Conexao conexao = new Conexao();

        /*private string strInseriTabelaContato = "insert into Contato (celular, telefone, email) " +
                                                "values (@celular, @telefone, @email)";*/

        public string Mensagem { get; set; }

        public void insereTabelaContato(string celular, string telefone, string email)
        {
            cmd.CommandText = "insert into Contato (celular, telefone, email) " +
                                           "values (@celular, @telefone, @email)";

            cmd.Parameters.AddWithValue("@celular", celular);
            cmd.Parameters.AddWithValue("@telefone", telefone);
            cmd.Parameters.AddWithValue("@email", email);

            try
            {
                //Conecta com o BD
                cmd.Connection = conexao.conectar();

                //executa o comando insert
                cmd.ExecuteNonQuery();

                //Desconecta o BD
                conexao.desconectar();

                //mostra msg de erro ou sucesso
                this.Mensagem = "Cadastrado com Sucesso!";
            }
            catch (SqlException e)
            {

                this.Mensagem = "Erro ao tentar se conectar com o Banco de Dados";
            }
        }
    }
}
