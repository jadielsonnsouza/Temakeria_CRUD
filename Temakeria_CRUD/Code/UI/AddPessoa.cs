using System;
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
            Cliente cliente = new Cliente(txt_Nome.Text, msk_dataNascimento.Text, txt_RG.Text, txt_CPF.Text,
                                          txt_Celular.Text, txt_Telefone.Text, txt_Email.Text);
            cliente.InserirCliente();
        }

        private void btn_Buscar_Click(object sender, EventArgs e)
        {
            ConsultaCadastro consultaCadastro = new ConsultaCadastro();
            consultaCadastro.consultaCadastro(txt_Pesquisar.Text);
            habilitaTextBox();
            txt_Nome.Text = Convert.ToString(consultaCadastro.Nome);
            msk_dataNascimento.Text = Convert.ToString(consultaCadastro.DataNascimento);
            txt_RG.Text = Convert.ToString(consultaCadastro.Rg);
            txt_CPF.Text = Convert.ToString(consultaCadastro.Cpf);
        }
        private void btn_Limpar_Click(object sender, EventArgs e)
        {
            txt_Pesquisar.Text = string.Empty;
            txt_Nome.Text = string.Empty;
            txt_Telefone.Text = string.Empty;
            txt_Celular.Text = string.Empty;
            txt_Email.Text = string.Empty;
            txt_Endereco.Text = string.Empty;
            msk_dataNascimento.Text = string.Empty;
            txt_Numero.Text = string.Empty;
            txt_Bairro.Text = string.Empty;
            txt_RG.Text = string.Empty;
            txt_CPF.Text = string.Empty;

            desabilitaTetBox();
        }

        private void habilitaTextBox()
        {
            txt_Pesquisar.Enabled = false;
            txt_Nome.Enabled = true;
            txt_Telefone.Enabled = true;
            txt_Celular.Enabled = true;
            txt_Email.Enabled = true;
            txt_Endereco.Enabled = false;
            msk_dataNascimento.Enabled = true;
            txt_Numero.Enabled = false;
            txt_Bairro.Enabled = false;
            txt_RG.Enabled = true;
            txt_CPF.Enabled = true;
        }

        private void desabilitaTetBox()
        {
            txt_Pesquisar.Enabled = true;
            txt_Nome.Enabled = false;
            txt_Telefone.Enabled = false;
            txt_Celular.Enabled = false;
            txt_Email.Enabled = false;
            txt_Endereco.Enabled = false;
            msk_dataNascimento.Enabled = false;
            txt_Numero.Enabled = false;
            txt_Bairro.Enabled = false;
            txt_RG.Enabled = false;
            txt_CPF.Enabled = false;
        }
    }
}
