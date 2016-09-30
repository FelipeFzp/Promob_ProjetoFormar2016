using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExemplosHeranca.Figura
{
    public class Circulo: Figura
    {
        public double Raio { get; set; }

        public Circulo(double area, double raio) 
            : base(area)
        {
            this.Raio = raio;
        }

        protected override void Desenhar()
        {
            //código para desenhar o circulo
        }      
    }
}
