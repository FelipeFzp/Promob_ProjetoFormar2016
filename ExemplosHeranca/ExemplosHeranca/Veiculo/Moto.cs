using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExemplosHeranca.Veiculo
{
    public class Moto : Veiculo
    {  
        public override int QtdMaxPassageiros
        {
            get
            {
                return 2;
            }
        }      

      
        public override void Ligar()
        {
            //codigo ligar moto            
        }
    }
}
