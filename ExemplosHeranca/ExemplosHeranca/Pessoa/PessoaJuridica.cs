using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExemplosHeranca.Pessoa
{
    public class PessoaJuridica: Pessoa
    {
        public string CNPJ { get; set; }

        public PessoaJuridica(string nome, string endereco, string cnpj)
            : base(nome, endereco)
        {
            this.CNPJ = cnpj;
        }

        public PessoaJuridica(string nome)
            : base(nome)
        {

        }
    }
}
