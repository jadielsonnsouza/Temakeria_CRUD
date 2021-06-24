using System;
using System.Data.SqlClient;
using Temakeria_CRUD.Code.Classes;
using Temakeria_CRUD.Code.ConexaoBD;

namespace Temakeria_CRUD.Code.CRUD
{
    public class TabelaPessoa
    {
        public string Mensagem { get; }

        private const string strInseriTabelaPessoa = "insert into Pessoa (nome, data_nascimento, rg, cpf, id_endereco, id_contato, id_tipo_pessoa, genero) " +
                                                           "values (@nome, @data_nascimento, @rg, @cpf, @id_endereco, @id_contato, @id_tipo_pessoa, @genero)";

        public TabelaPessoa(Pessoa pessoa)
        {
            SqlCommand cmd = new SqlCommand();
            Conexao conexaoBD = new Conexao();

            //Comando de insert no Banco de Dados
            cmd.CommandText = strInseriTabelaPessoa;

            cmd.Parameters.AddWithValue("@nome", pessoa.Nome);
            cmd.Parameters.AddWithValue("@data_nascimento", pessoa.DataNascimento);
            cmd.Parameters.AddWithValue("@rg", pessoa.Rg);
            cmd.Parameters.AddWithValue("@cpf", pessoa.Cpf);
            cmd.Parameters.AddWithValue("@id_endereco", pessoa.IdEndereco);
            cmd.Parameters.AddWithValue("@id_contato", pessoa.IdContato);
            cmd.Parameters.AddWithValue("@id_tipo_pessoa", pessoa.IdTipoPessoa);
            cmd.Parameters.AddWithValue("@genero", pessoa.Genero);

            this.Mensagem = conexaoBD.executaConexao(cmd);
        }

        
    }
}
