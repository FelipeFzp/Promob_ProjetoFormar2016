using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank
{
    public class InvestimentAccount : Account, ITaxable
    {
        public InvestimentAccount(double balanceInitial) 
            : base(balanceInitial)
        {
        }

        public override void PrintAccountInformation()
        {
            base.PrintInformation();
        }

        public double TotalTaxes()
        {
            throw new NotImplementedException();
        }
    }
}
