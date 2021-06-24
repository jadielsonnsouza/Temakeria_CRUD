using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Temakeria_CRUD.Code.UI;

namespace Temakeria_CRUD
{
    public partial class wf_temakeria : Form
    {
        public wf_temakeria()
        {
            InitializeComponent();
        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void cadastroClienteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Chama o formulário de cadastro AddPessoa
            AddPessoa adicionaPessoa = new AddPessoa(1);
            adicionaPessoa.ShowDialog();
        }

        private void cadastroFuncionarioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Chama o formulário de cadastro AddPessoa
            AddPessoa adicionaPessoa = new AddPessoa(2);
            adicionaPessoa.ShowDialog();
        }
    }
}
