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
        SqlCommand cmd = new SqlCommand();
        Conexao conexaoBD = new Conexao();

        public string Mensagem { get; }

        private const string strInseriTabelaEndereco = "insert into Endereco (rua, numero, complemento, bairro, cidade, estado) " +
                                                           "values (@rua, @numero, @complemento, @bairro, @cidade, @estado)";

        private const string consultaTabelaEndereco = "select id from endereco " +
                                                      "where rua = @rua " +
                                                      "and numero = @numero " +
                                                      "and complemento = @complemento " +
                                                      "and bairro = @bairro";
        public TabelaEndereco()
        {

        }
        public TabelaEndereco(Endereco endereco)
        {
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

        public int consultaEndereco(string rua, string numero, string complemento, string bairro)
        {

            cmd.CommandText = consultaTabelaEndereco;

            cmd.Parameters.AddWithValue("@rua", rua);
            cmd.Parameters.AddWithValue("@numero", numero);
            cmd.Parameters.AddWithValue("@complemento", complemento);
            cmd.Parameters.AddWithValue("@bairro", bairro);

            SqlDataReader leituraDados = conexaoBD.consultaConsultaBD(cmd);
            int idContato = Convert.ToInt32(leituraDados["id"]);

            return idContato;
        }
    }
}
