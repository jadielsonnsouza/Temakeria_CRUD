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
        public string Telefone { get; set; }
        public string Celular { get; set; }
        public string Email { get; set; }
        public int IdContato { get; set; }

        public void adicionaContato(string telefone,
                                    string celular,
                                    string email)
        {
            this.Telefone = telefone;
            this.Celular = celular;
            this.Email = email;            
        }
        //public int consultaIdContato()
        //{
        //    this.IdContato = tabelaConsulta.consultaContato(this.Telefone, this.Celular, this.Email);
        //    return this.IdContato;
        //}
    }
}
