using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banco.Interfaces
{
    interface IPessoaAtributos
    {
        int IdPessoa { get; set; }
        string Nome { get; set; }
        int Idade { get; set; }
        string DataNascimento { get; set; }
        string Cpf { get; set; }
        string Rg { get; set; }
    }
}
