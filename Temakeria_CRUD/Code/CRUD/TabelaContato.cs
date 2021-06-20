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
        public string Mensagem { get; }

        private const string strInseriTabelaContato = "insert into Contato (celular, telefone, email) " +
                                                "values (@celular, @telefone, @email)";

        public TabelaContato(Contato contato)
        {
            SqlCommand cmd = new SqlCommand();
            Conexao conexaoBD = new Conexao();

            //Comando de insert no Banco de Dados
            cmd.CommandText = strInseriTabelaContato;

            cmd.Parameters.AddWithValue("@celular", contato.Celular);
            cmd.Parameters.AddWithValue("@telefone", contato.Telefone);
            cmd.Parameters.AddWithValue("@email", contato.Email);
            
            this.Mensagem = conexaoBD.executaConexao(cmd);
        }
    }
}
