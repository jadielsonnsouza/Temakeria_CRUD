using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Temakeria_CRUD.Code.Classes
{
    class Endereco
    {
        public string Rua { get; private set; }
        public string Numero { get; private set; }
        public string Bairro { get; private set; }

        public void adicionaEndereco(string rua, string numero, string bairro)
        {
            this.Rua = rua;
            this.Numero = numero;
            this.Bairro = bairro;
        }
    }
}
