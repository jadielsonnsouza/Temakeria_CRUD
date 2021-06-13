using System;
using System.Data.SqlClient;
using Temakeria_CRUD.Code.ConexaoBD;

namespace Temakeria_CRUD.Code.CRUD
{
    public class TabelaPessoa
    {
        SqlCommand cmd = new SqlCommand();
        Conexao conexaoBD = new Conexao();
        public int Id_Contato { get; set; }

        private string strInseriTabelaPessoa = "insert into Pessoa (nome, data_nascimento, rg, cpf, id_contato) " +
                                                           "values (@nome, @data_nascimento, @rg, @cpf, @id_contato";

        public void CadastrarBD(string nome, string dataNascimento, string rg, string cpf, int id_Contato)
        {

            //Comando de insert no Banco de Dados
            cmd.CommandText = strInseriTabelaPessoa;

            cmd.Parameters.AddWithValue("@nome", nome);
            cmd.Parameters.AddWithValue("@data_nascimento", dataNascimento);
            cmd.Parameters.AddWithValue("@rg", rg);
            cmd.Parameters.AddWithValue("@cpf", cpf);
            //cmd.Parameters.AddWithValue("@id_endereco", null);
            cmd.Parameters.AddWithValue("@id_contato", id_Contato);

            conexaoBD.executaConexao(cmd);
        }
    }
}
