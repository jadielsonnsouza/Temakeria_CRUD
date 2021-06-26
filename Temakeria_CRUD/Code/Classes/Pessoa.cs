using System;

namespace Temakeria_CRUD.Code.Classes
{
    public class Pessoa
    {
        public string Nome { get; set; }
        public string DataNascimento { get; set; }
        public string Rg { get; set; }
        public string Cpf { get; set; }
        public int IdEndereco { get; private set; }
        public int IdContato { get; private set; }
        public int IdTipoPessoa { get; private set; }
        public string Genero { get; private set; }
        public string Pesquisa { get; private set; }

        public void adicionaCliente(string nome,
                                    string dataNascimento,
                                    string rg,
                                    string cpf,
                                    int id_endereco,
                                    int id_contato,
                                    int id_tipo_pessoa,
                                    string genero)
        {
            this.Nome = nome;
            this.DataNascimento = dataNascimento;
            this.Rg = rg;
            this.Cpf = cpf;
            this.IdEndereco = id_endereco;
            this.IdContato = id_contato;
            this.IdTipoPessoa = id_tipo_pessoa;
            this.Genero = genero;
        }

        public void consultaCliente(string pesquisa)
        {
            this.Pesquisa = pesquisa;
        }
    }
}
