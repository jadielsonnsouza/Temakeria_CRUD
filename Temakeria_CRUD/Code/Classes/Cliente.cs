﻿using System;
using Temakeria_CRUD.Code.CRUD;

namespace Temakeria_CRUD.Code.Classes
{
    public class Cliente : Pessoa
    {

        /*public Cliente(string nome, DateTime dataNascimento, string rg, string cpf, string rua, 
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
        }*/

        public Cliente(string nome, string dataNascimento, string rg, string cpf)
        {
            this.Nome = nome;
            this.DataNascimento = dataNascimento;
            this.Rg = rg;
            this.Cpf = cpf;
        }

        public void InserirCliente()
        {
            InsereCadastro insereCadastroBD = new InsereCadastro();
            insereCadastroBD.CadastrarBD(this.Nome, this.DataNascimento, this.Rg, this.Cpf);
        }
    }
}
