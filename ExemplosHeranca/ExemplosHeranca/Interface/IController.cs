using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExemplosHeranca.Interface
{
    public interface IController
    {
        void Deletar(int id);

        void Insert(Object objeto);

        void Update(Object objeto);

        Object Select(int id);
    }
}
