﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Temakeria_CRUD.Code.Classes
{
    class Cliente : Pessoa
    {
        public Cliente(string nome, DateTime dataNascimento, string rg, string cpf, string rua, 
                       string numero, string complemento, string bairro, string cidade, string estado,
                       string celular, string telefone, string email)
        {
            this.Nome = nome;
            this.DataNascimento = dataNascimento;
            this.Rg = rg;
            this.Cpf = cpf;
            this.Rua = rua;
            this.NumeroCasa = numero;
            this.Complemento = complemento;
            this.Bairro = bairro;
            this.Cidade = cidade;
            this.Estado = estado;
            this.Celular = celular;
            this.Telefone = telefone;
            this.Email = email;
        }
    }
}
