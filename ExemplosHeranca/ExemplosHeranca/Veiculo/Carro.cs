using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExemplosHeranca.Veiculo
{
    public class Carro : Veiculo
    {
        private int _qtd;
        public override int QtdMaxPassageiros
        {
            get
            {
                return _qtd;
            }
        }

        public Carro(int qtdMaxPassageiros)
        {
            _qtd = qtdMaxPassageiros;
        }

        public override void Ligar()
        {
           
        }

        public override string ToString()
        {
            return string.Format("Cor: {0} - Modelo: {1} - Ano: {2} - Qtd. Pass.: {3}", this.Cor, this.Modelo, this.Ano, this.QtdMaxPassageiros);
        }
    }
}
