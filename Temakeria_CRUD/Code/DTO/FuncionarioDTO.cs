using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Temakeria_CRUD.Code.DTO
{
    public class FuncionarioDTO
    {
        /*
         *BLL = Business Logic Layer
         *DAL = Data Access Layer
         *UI = User Interface
         *DTO = Data Transfer Object 
         */

        private int _id;
        private string _nome;
        private string _endereco;
        private string _email;
        private string _cidade;
        private string _estado;
        private string senha;

        public int Id { get => _id; set => _id = value; }
        public string Nome { get => _nome; set => _nome = value; }
        public string Endereco { get => _endereco; set => _endereco = value; }
        public string Email { get => _email; set => _email = value; }
        public string Cidade { get => _cidade; set => _cidade = value; }
        public string Estado { get => _estado; set => _estado = value; }
        public string Senha { get => senha; set => senha = value; }
    }
}
