﻿using System;
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
        public string Mensagem { get; set; }
        public string Nome { get; set; }
        public string DataNascimento { get; set; }
        public string Rg { get; set; }
        public string Cpf { get; set; }
        public string Celular { get; set; }
        public string Telefone { get; set; }
        public string Email { get; set; }
        public int Id_Contato { get; set; }


        string conexaoSql = @"Data Source=DESKTOP-U8NKSVS\SQLEXPRESS;Initial Catalog=Temakeria_CRUD;Integrated Security=True";

        SqlConnection conexaoBD = new SqlConnection();

        public Conexao()
        {
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

        public void executaConexao(SqlCommand cmd)
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
                this.Mensagem = "Cadastrado com Sucesso!";
            }
            catch (SqlException e)
            {
                this.Mensagem = "Erro ao tentar se conectar com o Banco de Dados";
            }
        }

        public void consultaConsultaBD(SqlCommand cmd, string tabela)
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
                this.Mensagem = e.Message;
            }
        }

        private void leituraBD(SqlDataReader leituraDados)
        {
            this.Nome = Convert.ToString(leituraDados["Nome"]);
            this.DataNascimento = Convert.ToString(leituraDados["data_nascimento"]);
            this.Rg = Convert.ToString(leituraDados["rg"]);
            this.Cpf = Convert.ToString(leituraDados["cpf"]);
        }

        private void consultaIdContato(SqlDataReader leituraDados)
        {
            this.Id_Contato = Convert.ToInt32(leituraDados["Id"]);
        }
    }
}
