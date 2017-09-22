using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banco.Classes
{
    public class Conta : Pessoa, IConta
    {
        int TipoConta { get; set; }
        Pessoa ClienteConta { get; set; }

        public Conta(string Nome) 
            : base(Nome)
        {
            ClienteConta.Nome = Nome;
        }

        public void CadastrarConta(Pessoa Cliente)
        {
            throw new NotImplementedException();
        }
    }
}
