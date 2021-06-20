using System;

namespace Temakeria_CRUD.Code.Classes
{
    public class Pessoa
    {
        public string Nome { get; private set; }
        public string DataNascimento { get; private set; }
        public string Rg { get; private set; }
        public string Cpf { get; private set; }
        public object Genero { get; private set; }

        public void adicionaCliente(string nome,
                                    string dataNascimento,
                                    string rg,
                                    string cpf,
                                    string genero)
        {
            this.Nome = nome;
            this.DataNascimento = dataNascimento;
            this.Rg = rg;
            this.Cpf = cpf;
            this.Genero = genero;
        }
    }
}
