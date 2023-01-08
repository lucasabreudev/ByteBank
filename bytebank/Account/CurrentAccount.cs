using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using bytebank.Holder;

namespace bytebank.Account
{
    public class CurrentAccount
    {
        private long bankBranch;
        public long BankBranch
        {
            get { return this.bankBranch; }
            private set
            {
                if (value > 0)
                {
                    this.bankBranch = value;
                }
            }

        }
        public string Account { get; set; }
        public AccountHolder AccountHolder { get; set; }
        public double Balance { get; private set; }

        public static long TotalAccounts { get; private set; }

        public CurrentAccount(long bankBranch, string account)
        {
            this.BankBranch = bankBranch;
            this.Account = account;
            TotalAccounts++;
        }

        private void VerifyValue(double value)
        {
            if (value <= 0)
            {
                throw new Exception("Valor inválido");
            }
        }

        public void Deposit(double value)
        {
            VerifyValue(value);
            Balance += value;
        }

        public bool Withdraw(double value)
        {
            VerifyValue(value);

            if (value <= Balance)
            {
                Balance -= value;
                return true;
            }
            return false;
        }

        public bool MoneyTransfer(double value, CurrentAccount destination)
        {
            VerifyValue(value);

            if (Balance < value)
            {
                return false;
            }
            Withdraw(value);
            destination.Deposit(value);
            return true;
        }
    }
}