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
                                                    "and telefone = @telefone " +
                                                    "and email = @email";

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

        public int consultaContato(string telefone, string celular, string email)
        {
            cmd.CommandText = consultaTabelaContato;

            cmd.Parameters.AddWithValue("@celular", celular);
            cmd.Parameters.AddWithValue("@telefone", telefone);
            cmd.Parameters.AddWithValue("@email", email);

            SqlDataReader leituraDados = conexaoBD.consultaConsultaBD(cmd);
            int idContato = Convert.ToInt32(leituraDados["id"]);

            return idContato;
        }
    }
}
