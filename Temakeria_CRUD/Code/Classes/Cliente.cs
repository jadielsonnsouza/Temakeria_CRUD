using System;
using Temakeria_CRUD.Code.CRUD;

namespace Temakeria_CRUD.Code.Classes
{
    public class Cliente : Pessoa
    {
        public Cliente(string nome, string dataNascimento, string rg, string cpf,
                       string celular, string telefone, string email)
        {
            this.Nome = nome;
            this.DataNascimento = dataNascimento;
            this.Rg = rg;
            this.Cpf = cpf;
            this.Celular = celular;
            this.Telefone = telefone;
            this.Email = email;
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
