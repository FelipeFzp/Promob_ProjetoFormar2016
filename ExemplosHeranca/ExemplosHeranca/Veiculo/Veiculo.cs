using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExemplosHeranca.Veiculo
{
    public abstract class Veiculo
    {
        public string Cor { get; set; }

        public string Modelo { get; set; }

        public int Ano { get; set; }

        public abstract int QtdMaxPassageiros { get;  }

        public abstract void Ligar();

        public override string ToString()
        {
            return string.Format("Cor: {0} - Modelo: {1} - Ano: {2}", this.Cor, this.Modelo, this.Ano);
        }

        public override bool Equals(object obj)
        {
            if (obj == null)
                return false;

            var veiculo = obj as Veiculo;

            if (veiculo==null)
                return false;

            return veiculo.Ano == this.Ano &&
                 veiculo.Modelo == this.Modelo &&
                 veiculo.Cor == this.Cor;

        }  
    }
}
