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
    class TabelaEndereco
    {
        public string Mensagem { get; }

        private const string strInseriTabelaEndereco = "insert into Endereco (rua, numero, complemento, bairro, cidade, estado) " +
                                                           "values (@rua, @numero, @complemento, @bairro, @cidade, @estado)";

        public TabelaEndereco(Endereco endereco)
        {
            SqlCommand cmd = new SqlCommand();
            Conexao conexaoBD = new Conexao();

            //Comando de insert no Banco de Dados
            cmd.CommandText = strInseriTabelaEndereco;

            cmd.Parameters.AddWithValue("@rua", endereco.Rua);
            cmd.Parameters.AddWithValue("@numero", endereco.Numero);
            cmd.Parameters.AddWithValue("@complemento", endereco.Complemento);
            cmd.Parameters.AddWithValue("@bairro", endereco.Bairro);
            cmd.Parameters.AddWithValue("@cidade", endereco.Cidade);
            cmd.Parameters.AddWithValue("@estado", endereco.Estado);

            this.Mensagem = conexaoBD.executaConexao(cmd);
        }
    }
}
