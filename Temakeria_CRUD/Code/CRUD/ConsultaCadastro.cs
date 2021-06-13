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
        public string Celular { get; set; }
        public string Telefone { get; set; }
        public string Email { get; set; }
        public int Id_Contato { get; set; }

        public void consultaCadastro(string pesquisar, string tipoPesquisa)
        {
            SqlCommand cmd = new SqlCommand();
            Conexao conexaoBD = new Conexao();

            switch (tipoPesquisa)
            {
                case "pesquisa_usuario":
                    //Comando Select
                    cmd.CommandText = "select * from Pessoa where nome = @pesquisar";
                    cmd.Parameters.AddWithValue("@pesquisar", pesquisar);
                    conexaoBD.consultaConsultaBD(cmd, "consulta_cadastro");
                    retornaString(conexaoBD, "pesquisa_usuario");
                    break;

                case "pesquisa_id_contato":
                    //Comando Select
                    cmd.CommandText = "select * from Contato where email = @email";
                    cmd.Parameters.AddWithValue("@email", pesquisar);
                    conexaoBD.consultaConsultaBD(cmd, "consulta_tabela_contato");
                    retornaString(conexaoBD, "idContato");
                    break;
            }
            
        }

        private void retornaString(Conexao conexaoBD, string tipoPesquisa)
        {
            if (tipoPesquisa == "pesquisa_usuario")
            {
                this.Nome = conexaoBD.Nome;
                this.DataNascimento = conexaoBD.DataNascimento;
                this.Rg = conexaoBD.Rg;
                this.Cpf = conexaoBD.Cpf;
                this.Celular = conexaoBD.Celular;
                this.Telefone = conexaoBD.Telefone;
                this.Email = conexaoBD.Email;
            } 
            else if(tipoPesquisa == "idContato")
            {
                this.Id_Contato = conexaoBD.Id_Contato;
            }
        }
    }
}
