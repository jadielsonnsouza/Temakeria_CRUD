﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Temakeria_CRUD.Code.Classes;
using Temakeria_CRUD.Code.ConexaoBD;
using Temakeria_CRUD.Code.CRUD;

namespace Temakeria_CRUD.Code.UI
{
    public partial class AddPessoa : Form
    {

        public AddPessoa()
        {
            InitializeComponent();

            desabilitaTetBox();
        }
        private void btn_Cadastrar_Click(object sender, EventArgs e)
        {
            habilitaTextBox();
        }
        private void btn_Salvar_Click(object sender, EventArgs e)
        {
            /*Cria o objeto do tipo Contato e chama método da classe tabela contato 
             * para add um contato no BD e retorna o id do contato pelo método consultaIdContato()
             * para realizar o relacionamento na tabela pessoa;
             */
            Contato contato = new Contato();
            contato.adicionaContato(txt_Telefone.Text,
                                    txt_Celular.Text,
                                    txt_Email.Text);
            TabelaContato insereTabelaContato = new TabelaContato(contato);
            int id_contato = contato.consultaIdContato();

            /*Cria o objeto do tipo Endereco e chama método da classe tabela endereco 
             * para add uma endereco no BD e retorna o id do endereco pelo método consultaIdEndereco()
             * para realizar o relacionamento na tabela pessoa;
             */
            Endereco endereco = new Endereco();
            endereco.adicionaEndereco(txt_Endereco.Text,
                                      txt_Numero.Text,
                                      txt_Complemento.Text,
                                      txt_Bairro.Text,
                                      txt_Cidade.Text,
                                      cmb_Estado.Text);
            TabelaEndereco insereTabelaEndereco = new TabelaEndereco(endereco);
            int id_endereco = endereco.consultaIdEndereco();

            /*Cria o objeto do tipo pessoa e chama método da classe tabela pessoa 
             * para add uma pessoa no BD
             */
            Pessoa pessoa = new Pessoa();
            pessoa.adicionaCliente(txt_Nome.Text,
                                   dtp_DataNascimento.Text,
                                   txt_RG.Text,
                                   txt_CPF.Text,
                                   id_endereco,
                                   id_contato,
                                   genero());
            TabelaPessoa inseretabelaPessoa = new TabelaPessoa(pessoa);

                       

            

            Limpar();
        }
        private void btn_Buscar_Click(object sender, EventArgs e)
        {
            /*ConsultaCadastro consultaCadastro = new ConsultaCadastro();
            consultaCadastro.consultaCadastro(txt_Pesquisar.Text, "pesquisa_usuario");
            habilitaTextBox();
            txt_Nome.Text = Convert.ToString(consultaCadastro.Nome);
            msk_dataNascimento.Text = Convert.ToString(consultaCadastro.DataNascimento);
            txt_RG.Text = Convert.ToString(consultaCadastro.Rg);
            txt_CPF.Text = Convert.ToString(consultaCadastro.Cpf);*/
        }
        private void btn_Limpar_Click(object sender, EventArgs e)
        {
            Limpar();

            desabilitaTetBox();
        }
        private void habilitaTextBox()
        {
            txt_Pesquisar.Enabled = false;

            txt_Nome.Enabled = true;
            dtp_DataNascimento.Enabled = true;
            txt_RG.Enabled = true;
            txt_CPF.Enabled = true;
            rdb_Masculino.Enabled = true;
            rdb_Feminino.Enabled = true;
            rdb_Outros.Enabled = true;
;
            txt_Email.Enabled = true;
            txt_Telefone.Enabled = true;
            txt_Celular.Enabled = true;

            txt_Endereco.Enabled = true;
            txt_Numero.Enabled = true;
            txt_Complemento.Enabled = true;
            txt_Bairro.Enabled = true;
            txt_Cidade.Enabled = true;
            cmb_Estado.Enabled = true;
        }
        private void desabilitaTetBox()
        {
            txt_Pesquisar.Enabled = true;

            txt_Nome.Enabled = false;
            dtp_DataNascimento.Enabled = false;
            txt_RG.Enabled = false;
            txt_CPF.Enabled = false;
            rdb_Masculino.Enabled = false;
            rdb_Feminino.Enabled = false;
            rdb_Outros.Enabled = false;

            txt_Email.Enabled = false;
            txt_Telefone.Enabled = false;
            txt_Celular.Enabled = false;
            
            txt_Endereco.Enabled = false;
            txt_Numero.Enabled = false;
            txt_Complemento.Enabled = false;
            txt_Bairro.Enabled = false;
            txt_Cidade.Enabled = false;
            cmb_Estado.Enabled = false;
            
        }
        private string genero()
        {
            string genero = "";
            bool generoMasculino = rdb_Masculino.Checked;
            bool generoFeminino = rdb_Feminino.Checked;
            bool generoOutros = rdb_Outros.Checked;

            if (generoMasculino == true)
            {
                genero = "Masculino";
            }
            else if (generoFeminino == true)
            {
                genero = "Feminino";
            }
            else
            {
                genero = "Outros";
            }
            return genero;
        }
        private void Limpar()
        {
            txt_Pesquisar.Text = string.Empty;

            txt_Nome.Text = string.Empty;
            dtp_DataNascimento.Text = string.Empty;
            txt_RG.Text = string.Empty;
            txt_CPF.Text = string.Empty;
            rdb_Masculino.Checked = false;
            rdb_Feminino.Checked = false;
            rdb_Outros.Checked = false;

            txt_Email.Text = string.Empty;
            txt_Telefone.Text = string.Empty;
            txt_Celular.Text = string.Empty;

            txt_Endereco.Text = string.Empty;
            txt_Numero.Text = string.Empty;
            txt_Complemento.Text = string.Empty;
            txt_Bairro.Text = string.Empty;
            txt_Cidade.Text = string.Empty;
            cmb_Estado.Text = string.Empty;
        }
    }
}
