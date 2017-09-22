using Banco.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Banco
{
    public partial class Form1 : Form, IPessoa
    {
        public Form1()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Cadastra um novo cliente
        /// </summary>
        /// <param name="Cliente">objeto pessoa</param>
        public void CadastrarPessoa(Pessoa Cliente)
        {
            ClientesCadastrados.Clientes.Add(Cliente);

            ddlClientes.Items.Clear();

            for (int lintCont = 0; lintCont < ClientesCadastrados.Clientes.Count; lintCont++)
                ddlClientes.Items.Add(ClientesCadastrados.Clientes[lintCont].Nome);

            ddlClientes.SelectedIndex = 0;

            MessageBox.Show($"Cliente: {Cliente.Nome} cadastrado com sucesso!");
        }

        /// <summary>
        /// Calcula a idade do cliente
        /// </summary>
        /// <param name="pintAnoNascimento">Ano de nascimento do cliente</param>
        /// <returns>Idade do cliente</returns>
        public int RecuperaIdade(int pintAnoNascimento)
        {
            var anoAtual = DateTime.Today.Year;
            var lintIdade = anoAtual - pintAnoNascimento;

            return lintIdade;
        }

        private void txtCadastrar_Click(object sender, EventArgs e)
        {
            var Cliente = new Pessoa();
            var lobjRandom = new Random();

            Cliente.IdPessoa = lobjRandom.Next(1, 100);
            Cliente.Nome = txtNome.Text;
            Cliente.DataNascimento = $"{ddlAno.Text}-{ddlMes.Text}-{ddlDia.Text}";
            Cliente.Cpf = txtCpf.Text;
            Cliente.Rg = txtRg.Text;
            Cliente.Idade = RecuperaIdade(Convert.ToInt32(ddlAno.Text));

            CadastrarPessoa(Cliente);
        }
    }
}
