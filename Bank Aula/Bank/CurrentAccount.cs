using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank
{
    //conta corrente
    public class CurrentAccount: Account
    {
        public double Overdraft { get; set; }

        public override double TotalAvailable
        {
            get
            {
                 return CalculeTotalAvailable();
            }
        }

        public CurrentAccount(double balanceInitial)
            :base(balanceInitial)            
        {

        }

        private double CalculeTotalAvailable()
        {
            return base.Balance + this.Overdraft;
        }

        public override void PrintAccountInformation()
        {
            base.PrintInformation();
        }
    }
}
