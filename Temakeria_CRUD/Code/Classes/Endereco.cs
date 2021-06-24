using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Temakeria_CRUD.Code.CRUD;

namespace Temakeria_CRUD.Code.Classes
{
    class Endereco
    {
        TabelaEndereco tabelaConsulta = new TabelaEndereco();
        public string Rua { get; private set; }
        public string Numero { get; private set; }
        public string Complemento { get; private set; }
        public string Bairro { get; private set; }
        public string Cidade { get; private set; }
        public string Estado { get; private set; }
        public int IdEndereco { get; private set; }

        public void adicionaEndereco(string rua,
                                     string numero,
                                     string complemento,
                                     string bairro,
                                     string cidade,
                                     string estado)
        {
            this.Rua = rua;
            this.Numero = numero;
            this.Complemento = complemento;
            this.Bairro = bairro;
            this.Cidade = cidade;
            this.Estado = estado;
        }

        public int consultaIdEndereco()
        {
            this.IdEndereco = tabelaConsulta.consultaEndereco(this.Rua, this.Numero, this.Complemento, this.Bairro);
            return this.IdEndereco;
        }
    }
}
