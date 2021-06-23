using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using Temakeria_CRUD.Code.CRUD;

namespace Temakeria_CRUD.Code.ConexaoBD
{
    public class Conexao
    {
        SqlConnection conexaoBD = new SqlConnection();

        public Conexao()
        {
            string conexaoSql = @"Data Source=DESKTOP-U8NKSVS\SQLEXPRESS;Initial Catalog=Temakeria_CRUD;Integrated Security=True";
            conexaoBD.ConnectionString = conexaoSql;
        }
        //Método que abre conexao com o BD
        private SqlConnection conectar()
        {
            if (conexaoBD.State == ConnectionState.Closed)
            {
                conexaoBD.Open();
            }
            return conexaoBD;
        }
        //Método que fecha a conexao com o BD
        private void desconectar()
        {
            if (conexaoBD.State == ConnectionState.Open)
            {
                conexaoBD.Close();
            }
        }                
        public string executaConexao(SqlCommand cmd)
        {
            try
            {
                //Conecta com o BD
                cmd.Connection = conectar();

                //executa o comando insert
                cmd.ExecuteNonQuery();

                //Desconecta o BD
                desconectar();

                //mostra msg de erro ou sucesso
                return "Cadastrado com Sucesso!";
            }
            catch (SqlException)
            {
                return "Erro ao tentar se conectar com o Banco de Dados";
            }
        }

        public SqlDataReader consultaConsultaBD(SqlCommand cmd)
        {
            try
            {
                // conectar com o BD(INSTACIAR CLASSE CONEXAO)
                cmd.Connection = conectar();

                SqlDataReader leituraDados = cmd.ExecuteReader();
                leituraDados.Read();

                return leituraDados;
            }
            catch (Exception)
            {
                throw;
            }
        }

        /*public void consultaConsultaBD(SqlCommand cmd, string tabela)
        {
            try
            {
                // conectar com o BD(INSTACIAR CLASSE CONEXAO)
                cmd.Connection = conectar();

                SqlDataReader leituraDados = cmd.ExecuteReader();
                leituraDados.Read();

                switch (tabela)
                {
                    case "consulta_cadastro":
                        leituraBD(leituraDados);
                        break;
                    case "consulta_tabela_contato":
                        consultaIdContato(leituraDados);
                        break;
                }

                desconectar();
            }
            catch (Exception e)
            {
                //this.Mensagem = e.Message;
            }
        }

        private void leituraBD(SqlDataReader leituraDados)
        {
            this.Nome = Convert.ToString(leituraDados["Nome"]);
            this.DataNascimento = Convert.ToString(leituraDados["data_nascimento"]);
            this.Rg = Convert.ToString(leituraDados["rg"]);
            this.Cpf = Convert.ToString(leituraDados["cpf"]);
        }*/

        
    }
}
