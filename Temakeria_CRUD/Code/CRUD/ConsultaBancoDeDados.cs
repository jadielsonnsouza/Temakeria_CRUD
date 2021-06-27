using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Temakeria_CRUD.Code.Classes;
using Temakeria_CRUD.Code.ConexaoBD;

namespace Temakeria_CRUD.Code.CRUD
{
    class ConsultaBancoDeDados
    {
        public ConsultaBancoDeDados(Pessoa pessoa)
        {
            TabelaPessoa tabelaPessoa = new TabelaPessoa();
            tabelaPessoa.consultaPessoa(pessoa);
        }
    }
}
