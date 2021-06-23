using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Temakeria_CRUD.Code.CRUD;

namespace Temakeria_CRUD.Code.Classes
{
    class Contato
    {
        TabelaContato tabelaConsulta = new TabelaContato();
        public string Telefone { get; private set; }
        public string Celular { get; private set; }
        public string Email { get; private set; }
        public int IdContato { get; private set; }

        public void adicionaContato(string telefone,
                                    string celular,
                                    string email)
        {
            this.Telefone = telefone;
            this.Celular = celular;
            this.Email = email;            
        }
        public void consultaIdContato()
        {
            this.IdContato = tabelaConsulta.consultaContato(this.Telefone, this.Celular, this.Email);
        }
    }
}
