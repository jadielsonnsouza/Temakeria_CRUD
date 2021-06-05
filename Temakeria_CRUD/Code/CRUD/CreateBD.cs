using System;
using System.Data.SqlClient;
using Temakeria_CRUD.Code.ConexaoBD;

namespace Temakeria_CRUD.Code.CRUD
{
    public class CreateBD
    {
        SqlCommand cmd = new SqlCommand();
        Conexao conexao = new Conexao();
        public string mensagem = "";

        public void CadastrarBD(string nome, DateTime dataNascimento, string rg, string cpf, string rua,
                       string numero, string complemento, string bairro, string cidade, string estado,
                       string celular, string telefone, string email)
        {
            //Comando de insert no Banco de Dados
            cmd.CommandText = "insert into Pessoa (nome, data_nascimento, rg, cpf) " +
                                           "values (@nome, @data_nascimento, @rg, @cpf)";

            cmd.Parameters.AddWithValue("@nome", nome);
            cmd.Parameters.AddWithValue("@data_nascimento", dataNascimento);
            cmd.Parameters.AddWithValue("@rg", rg);
            cmd.Parameters.AddWithValue("@cpf", cpf);

            try
            {
                //Conecta com o BD
                cmd.Connection = conexao.conectar();

                //executa o comando insert
                cmd.ExecuteNonQuery();

                //Desconecta o BD
                conexao.desconectar();

                //mostra msg de erro ou sucesso
                this.mensagem = "Cadastrado com Sucesso!";
            }
            catch (SqlException e)
            {
                this.mensagem = "Erro ao tentar se conectar com o Banco de Dados";
            }
        }
    }
}
