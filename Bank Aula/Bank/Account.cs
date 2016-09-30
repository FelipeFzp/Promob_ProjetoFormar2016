using System;
using System.Collections.Generic;

namespace Bank
{
    public abstract class Account
    {
        public double Balance { get; private set; }

        public DateTime LastChange { get; set; }

        public virtual double TotalAvailable { get; }
       
        public List<double> History { get; private set; }

        public eTipoCartao TipoCartao { get; private set; }
       

        public Account(double balanceInitial)
        {
            History = new List<double>();

            // Balance += balanceInitial;
            Credit(balanceInitial);
        }

        public abstract void PrintAccountInformation();

        //public void UpdateBalance(double valueCredit, double valueDebit)
        //{
        //    Credit(valueCredit);
        //    Debit(valueDebit);
        //}

        public void PrintBalance()
        {
            string mensagem = FormatTotalDescription();
            Console.WriteLine(mensagem);
        }
      

        private void Credit(double credit)
        {
            Balance += credit;
            History.Add(credit);
            //this.Balance = this.Balance + credit;
        }

        private void Debit(double debit)
        {
            Balance -= debit;
            History.Add(-debit);
            //this.Balance = this.Balance - debit;
        }

        private string FormatTotalDescription()
        {
            string mensagem= string.Format("Saldo é R$ {0}", this.Balance); ;
            return mensagem;
        }

        public void CacheIn(double value)
        {            
            Credit(value);
           
        }

        public virtual void CacheOut(double value)
        {
            Debit(value);       
        }

        protected void PrintInformation()
        {
            int count = 0;
            foreach (var h in History)
            {
                count++;
                
                Console.WriteLine(string.Format("Movimentação {1} : R$ {0}", h, count));
            }
        }
    
    }
}
