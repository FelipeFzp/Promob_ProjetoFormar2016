using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExemploEnumerador
{
    class Program
    {
        static void Main(string[] args)
        {
            Conta c1 = new Conta(500);
            Console.WriteLine(c1.Operacoes(1, 100));
            Console.WriteLine(c1.Operacoes(eOperations.CashOut, 100));

            Console.ReadKey();

        }
    }
}
