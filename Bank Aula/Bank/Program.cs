using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank
{
    class Program
    {
        static void Main(string[] args)
        {

            AccountManager manager = new AccountManager(500,3000,5000);

            manager.CacheIn(300, manager.Corrente);
            manager.CacheOut(25, manager.Investimento);

            manager.Sacar(45, manager.Poupanca);

            manager.PrintAccountInformation(manager.Poupanca);        
            



            ////Account conta = new Account(100);
            ////conta.PrintBalance();

            //SavingsAccount poupanca = new SavingsAccount(1000);
            ////conta.PrintBalance();
            ////poupanca.CacheOut(10);
            ////conta.PrintBalance();
            ////poupanca.CacheIn(100);
            ////conta.PrintBalance();

            //SavingsAccount poupanca2 = new SavingsAccount(500);
            //bool igual = poupanca.Equals(poupanca2);

            //poupanca = poupanca2;

            //bool igual2 = poupanca.Equals(poupanca2);

            //poupanca.CacheIn(100);
            //poupanca2.CacheIn(200);


            ////CurrentAccount corrente = new Bank.CurrentAccount();
            ////var value= corrente.TotalAvailable;

            Console.ReadLine();
        }
    }
}
