using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExemplosHeranca.Figura
{
    public class Quadrado: Figura
    {     
        public double Lado { get; set; }

        public Quadrado(double lado, double area)
          : base(area)
        {
        }

        protected override void Desenhar()
        {
           //codigo do quadrado
        }
      
    }
}
