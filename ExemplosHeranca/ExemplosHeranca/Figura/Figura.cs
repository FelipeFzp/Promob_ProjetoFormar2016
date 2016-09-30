using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExemplosHeranca.Figura
{
    public abstract class Figura : IFigura
    {

        public double Area { get; set; }

        public string Texto { get; set; }

        public string Cor
        {
            get
            {
                throw new NotImplementedException();
            }

            set
            {
                throw new NotImplementedException();
            }
        }

        public Figura(double area)
        {
            this.Area = area;
        }

        protected abstract void Desenhar();

        public string Mensagem()
        {
            throw new NotImplementedException();
        }

        public void DesenharFigura()
        {
            throw new NotImplementedException();
        }

        //public void DesenharFigura()
        //{
        //    Desenhar();
        //}
    }
}
