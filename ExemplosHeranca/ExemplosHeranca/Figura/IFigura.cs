using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExemplosHeranca.Figura
{
    public interface IFigura: IDesenhar, ICor
    {
        double Area { get; set; } //propriedade

        string Mensagem();

      
    }
}
