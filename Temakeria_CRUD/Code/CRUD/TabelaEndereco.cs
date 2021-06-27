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
                                                      "and bairro = @bairro " +
                                                      "and cidade = @cidade " +
                                                      "and estado = @estado";

        public TabelaEndereco()
        {

        }

        public TabelaEndereco(Endereco endereco)
        {
            //Comando de insert no Banco de Dados
            cmd.CommandText = strInseriTabelaEndereco;
            this.Mensagem = conexaoBD.executaConexao(adicionaParametros(cmd, endereco));
            consultaEndereco(endereco);
        }

        public void consultaEndereco(Endereco endereco)
        {
            cmd.CommandText = consultaTabelaEndereco;
            SqlDataReader leituraDados = conexaoBD.consultaConsultaBD(cmd);
            endereco.IdEndereco = Convert.ToInt32(leituraDados["id"]);
        }

        private SqlCommand adicionaParametros(SqlCommand cmd, Endereco endereco)
        {
            cmd.Parameters.AddWithValue("@rua", endereco.Rua);
            cmd.Parameters.AddWithValue("@numero", endereco.Numero);
            cmd.Parameters.AddWithValue("@complemento", endereco.Complemento);
            cmd.Parameters.AddWithValue("@bairro", endereco.Bairro);
            cmd.Parameters.AddWithValue("@cidade", endereco.Cidade);
            cmd.Parameters.AddWithValue("@estado", endereco.Estado);

            return cmd;
        }

        public void leituraTabelaEndereco(Endereco endereco, SqlDataReader leituraDados)
        {
            endereco.Rua = Convert.ToString(leituraDados["rua"]);
            endereco.Numero = Convert.ToString(leituraDados["numero"]);
            endereco.Complemento = Convert.ToString(leituraDados["complemento"]);
            endereco.Bairro = Convert.ToString(leituraDados["bairro"]);
            endereco.Cidade = Convert.ToString(leituraDados["cidade"]);
            endereco.Estado = Convert.ToString(leituraDados["estado"]);
        }
    }
}
