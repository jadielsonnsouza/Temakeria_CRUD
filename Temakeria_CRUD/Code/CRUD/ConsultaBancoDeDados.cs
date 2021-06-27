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
        SqlCommand cmd = new SqlCommand();
        Conexao conexaoBD = new Conexao();

        private const string consultaBancoDeDados = "select" +
                                                        " p.nome, p.data_nascimento, p.rg, p.cpf, p.genero," +
                                                        " c.celular, c.telefone, c.email," +
                                                        " e.rua, e.numero, e.complemento, e.bairro, e.cidade, e.estado " +
                                                    "from Pessoa as p " +
                                                    "left join Contato as c on p.id_contato = c.id " +
                                                    "left join Endereco as e on p.id_endereco = e.id " +
                                                    "where p.nome = @pesquisa";

        public ConsultaBancoDeDados(Pessoa pessoa, Endereco endereco, Contato contato)
        {
            TabelaPessoa consultaPessoa = new TabelaPessoa();
            TabelaEndereco consultaEndereco = new TabelaEndereco();
            TabelaContato consultaContato = new TabelaContato();

            //Comando de insert no Banco de Dados
            cmd.CommandText = consultaBancoDeDados;
            cmd.Parameters.AddWithValue("@pesquisa", pessoa.Pesquisa);

            SqlDataReader leituraDados = conexaoBD.consultaConsultaBD(cmd);
            consultaPessoa.leituraTabelaPessoa(pessoa, leituraDados);
            consultaEndereco.leituraTabelaEndereco(endereco, leituraDados);
            consultaContato.leituraTabelaContato(contato, leituraDados);
        }
    }
}
