using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banco.Classes
{
    interface IPessoa
    {
        void CadastrarPessoa(Pessoa Cliente);

        int RecuperaIdade(int pintAnoNascimento);
    }
}
