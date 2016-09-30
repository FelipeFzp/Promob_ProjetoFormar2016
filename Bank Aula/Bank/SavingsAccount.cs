
namespace Bank
{
    //conta poupança
    public class SavingsAccount: Account, ITaxable, IAccount
    {
        public SavingsAccount(double balanceInitial)
           :base(balanceInitial)
        {

        }

        public override void CacheOut(double value)
        {
            double newValue= (value *(TotalTaxes()/100)) + value;           
            base.CacheOut(newValue);
        }

        public override void PrintAccountInformation()
        {
            base.PrintInformation();
        }

        public double TotalTaxes()
        {
            return 10;
        }

        public void Sacar(double value)
        {
            base.CacheOut(value);
        }
    }
}
