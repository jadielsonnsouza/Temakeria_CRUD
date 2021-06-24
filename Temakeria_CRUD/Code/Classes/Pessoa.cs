using System;

namespace Temakeria_CRUD.Code.Classes
{
    public class Pessoa
    {
        public string Nome { get; private set; }
        public string DataNascimento { get; private set; }
        public string Rg { get; private set; }
        public string Cpf { get; private set; }
        public int IdContato { get; private set; }
        public string Genero { get; private set; }

        public void adicionaCliente(string nome,
                                    string dataNascimento,
                                    string rg,
                                    string cpf,
                                    int id_contato,
                                    string genero)
        {
            this.Nome = nome;
            this.DataNascimento = dataNascimento;
            this.Rg = rg;
            this.Cpf = cpf;
            this.IdContato = id_contato;
            this.Genero = genero;
        }
    }
}
