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

namespace Temakeria_CRUD.Code.UI
{
    public partial class AddPessoa : Form
    {
        public AddPessoa()
        {
            InitializeComponent();

            txt_Nome.Enabled = false;
            msk_Telefone.Enabled = false;
            msk_Celular.Enabled = false;
            txt_Email.Enabled = false;
            txt_Endereco.Enabled = false;
            msk_dataNascimento.Enabled = false;
            txt_Numero.Enabled = false;
            txt_Bairro.Enabled = false;
            txt_RG.Enabled = false;
            txt_CPF.Enabled = false;
        }

        private void btn_Cadastrar_Click(object sender, EventArgs e)
        {
            txt_Nome.Enabled = true;
            msk_Telefone.Enabled = false;
            msk_Celular.Enabled = false;
            txt_Email.Enabled = false;
            txt_Endereco.Enabled = false;
            msk_dataNascimento.Enabled = true;
            txt_Numero.Enabled = false;
            txt_Bairro.Enabled = false;
            txt_RG.Enabled = true;
            txt_CPF.Enabled = true;
        }

        private void btn_Salvar_Click(object sender, EventArgs e)
        {
            Cliente cliente = new Cliente(txt_Nome.Text, msk_dataNascimento.Text, txt_RG.Text, txt_CPF.Text);
            cliente.InserirCliente();
        }
    }
}
