using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExemploEnumerador
{
    class Conta
    {
        double Saldo { get; set; }

        public Conta(double saldo)
        {
            this.Saldo = saldo;
        }

        public string Operacoes(eOperations op,double value)
        {
            switch (op)
            {
                case eOperations.CashIn:
                    CashIn(value);
                    return Saldo.ToString();
                case eOperations.CashOut:
                    CashOut(value);
                    return Saldo.ToString();
                default:
                    return "Operação Inválida";
            }
        }

        public void CashIn(double value)
        {
            this.Saldo += value;
        }

        public void CashOut(double value)
        {
            this.Saldo -= value;
        }

        public override string ToString()
        {
            return $"Saldo Atual:{Saldo:c}";
        }
    }
}
