using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banco.Classes
{
    public class Pessoa
    {
        public int IdPessoa { get; set; }
        public string Nome { get; set; }
        public int Idade { get; set; }
        public string DataNascimento { get; set; }
        public string Cpf { get; set; }
        public string Rg { get; set; }

        public Pessoa()
        {

        }

        public Pessoa(string Nome)
        {
            this.Nome = Nome;
        }
    }

    public static class ClientesCadastrados
    {
        public static List<Pessoa> Clientes { get; set; } = new List<Pessoa>();
    }
}
