using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExemplosHeranca.Pessoa
{
    public class Pessoa
    {

        #region Properties
        public string Nome { get; private set; }

        public string Endereco { get; private set; }

        #endregion

        #region Construtor
        public Pessoa(string nome, string endereco)
            : this(nome)
        {
            this.Endereco = endereco;
        }

        public Pessoa(string nome)
        {
            this.Nome = nome;
        }

        #endregion

    }
}
