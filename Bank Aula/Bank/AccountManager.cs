using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank
{
    public class AccountManager
    {
        public CurrentAccount Corrente { get; set; }

        public SavingsAccount Poupanca { get; set; }

        public InvestimentAccount Investimento { get; set; }

        public AccountManager(double initialCurrent, double initialSavings, double initialInvestiment)
        {
            LoadAccounts(initialCurrent, initialSavings, initialInvestiment);
        }

        private void LoadAccounts(double initialCurrent, double initialSavings, double initialInvestiment)
        {
            Corrente = new CurrentAccount(initialCurrent);
            Poupanca = new SavingsAccount(initialSavings);
            Investimento = new InvestimentAccount(initialInvestiment);
        }

        public void CacheIn(double value, Account account)
        {
            account.CacheIn(value);
        }

        public void CacheOut(double value, Account account)
        {
            account.CacheOut(value);
        }

        public void PrintAccountInformation(Account account)
        {
            account.PrintAccountInformation();
        }

        public void Sacar(double value, IAccount account)
        {
            account.Sacar(value);
        }

    }
}
