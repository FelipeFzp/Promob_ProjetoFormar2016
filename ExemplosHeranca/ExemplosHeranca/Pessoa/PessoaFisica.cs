using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExemplosHeranca.Pessoa
{
    public class PessoaFisica: Pessoa
    {
        public string CPF { get; set; }

        public PessoaFisica(string nome, string endereco, string cpf)
            :base(nome, endereco)
        {
            this.CPF = cpf;           
        }
    }
}
