using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Temakeria_CRUD.Code.Classes;
using Temakeria_CRUD.Code.ConexaoBD;

namespace Temakeria_CRUD.Code.CRUD
{
    class TabelaContato
    {
        SqlCommand cmd = new SqlCommand();
        Conexao conexaoBD = new Conexao();

        public string Mensagem { get; }

        private const string inseriTabelaContato = "insert into Contato (celular, telefone, email) " +
                                                   "values (@celular, @telefone, @email)";

        private const string consultaTabelaContato = "select id from contato " +
                                                    "where celular = @celular " +
                                                    "and telefone = @telefone ";

        public TabelaContato()
        {

        }
        public TabelaContato(Contato contato)
        {
            //Comando de insert no Banco de Dados
            cmd.CommandText = inseriTabelaContato;

            cmd.Parameters.AddWithValue("@celular", contato.Celular);
            cmd.Parameters.AddWithValue("@telefone", contato.Telefone);
            cmd.Parameters.AddWithValue("@email", contato.Email);
            
            this.Mensagem = conexaoBD.executaConexao(cmd);
        }

        public int consultaContato(Contato contato)
        {
            cmd.CommandText = consultaTabelaContato;

            cmd.Parameters.AddWithValue("@celular", contato.Celular);
            cmd.Parameters.AddWithValue("@telefone", contato.Telefone);

            SqlDataReader leituraDados = conexaoBD.consultaConsultaBD(cmd);
            int idContato = consultaIdContato(leituraDados);

            return idContato;
        }

        private int consultaIdContato(SqlDataReader leituraDados)
        {
            return Convert.ToInt32(leituraDados["Id"]);
        }
    }
}
