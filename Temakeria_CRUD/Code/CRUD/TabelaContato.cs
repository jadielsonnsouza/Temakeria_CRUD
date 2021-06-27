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
            this.Mensagem = conexaoBD.executaConexao(adicionaParametros(cmd, contato));
            consultaContato(contato);
        }
        public void consultaContato(Contato contato)
        {
            cmd.CommandText = consultaTabelaContato;
            SqlDataReader leituraDados = conexaoBD.consultaConsultaBD(cmd);
            contato.IdContato = Convert.ToInt32(leituraDados["id"]);
        }

        private SqlCommand adicionaParametros(SqlCommand cmd, Contato contato)
        {
            cmd.Parameters.AddWithValue("@celular", contato.Celular);
            cmd.Parameters.AddWithValue("@telefone", contato.Telefone);
            cmd.Parameters.AddWithValue("@email", contato.Email);

            return cmd;
        }

        public void leituraTabelaContato(Contato contato, SqlDataReader leituraDados)
        {
            contato.Email = Convert.ToString(leituraDados["email"]);
            contato.Celular = Convert.ToString(leituraDados["celular"]);
            contato.Telefone = Convert.ToString(leituraDados["telefone"]);
        }
    }
}
