using System;
using Temakeria_CRUD.Code.CRUD;

namespace Temakeria_CRUD.Code.Classes
{
    public class Pessoa
    {
        public string Nome { get; private set; }
        public string DataNascimento { get; private set; }
        public string Rg { get; private set; }
        public string Cpf { get; private set; }

        public void adicionaCliente(string nome, string dataNascimento, string rg, string cpf)
        {
            this.Nome = nome;
            this.DataNascimento = dataNascimento;
            this.Rg = rg;
            this.Cpf = cpf;
        }

        public void InserirCliente()
        {
            ConsultaCadastro consultaCadastro = new ConsultaCadastro();
            
            TabelaContato insereTabelaContato = new TabelaContato();
            insereTabelaContato.insereTabelaContato(this.Celular, this.Telefone, this.Email);
            consultaCadastro.consultaCadastro(this.Email, "pesquisa_id_contato");
            int idContato = Convert.ToInt32(consultaCadastro.Id_Contato);

            TabelaPessoa insereCadastroBD = new TabelaPessoa();
            insereCadastroBD.CadastrarBD(this.Nome, this.DataNascimento, this.Rg, this.Cpf, idContato);
        }
    }
}
