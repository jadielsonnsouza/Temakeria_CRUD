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
    class ConsultaCadastro
    {
        public string Mensagem { get; set; }
        public string Nome { get; set; }
        public string DataNascimento { get; set; }
        public string Rg { get; set; }
        public string Cpf { get; set; }

        SqlCommand cmd = new SqlCommand();
        Conexao conexaoBD = new Conexao();

        public ConsultaCadastro(string pesquisar)
        {
            //Comando Select
            cmd.CommandText = "select * from Pessoa where nome = @pesquisar";

            cmd.Parameters.AddWithValue("@pesquisar", pesquisar);

            try
            {
                // conectar com o BD(INSTACIAR CLASSE CONEXAO)
                cmd.Connection = conexaoBD.conectar();

                SqlDataReader leituraDados = cmd.ExecuteReader();
                leituraDados.Read();

                this.Nome = Convert.ToString(leituraDados["Nome"]);
                this.DataNascimento = Convert.ToString(leituraDados["data_nascimento"]);
                this.Rg = Convert.ToString(leituraDados["rg"]);
                this.Cpf = Convert.ToString(leituraDados["cpf"]);

                conexaoBD.desconectar();
            }
            catch (Exception e)
            {
                this.Mensagem = e.Message;
            }
        }
    }
}
