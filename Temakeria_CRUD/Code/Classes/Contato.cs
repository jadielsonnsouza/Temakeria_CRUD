using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Temakeria_CRUD.Code.Classes
{
    class Contato
    {
        public string Telefone { get; private set; }
        public string Celular { get; private set; }
        public string Email { get; private set; }

        public void adicionaContato(string telefone, string celular, string email)
        {
            this.Telefone = telefone;
            this.Celular = celular;
            this.Email = email;
        }
    }
}
