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
        public AccountHolder AccountHolder { get; set; }
        public long BankBranch { get; }
        public string AccountNumber { get; }
        public double Balance { get; private set; }

        public double OperationRate { get; private set; }

        public static long TotalAccounts { get; private set; }

        public CurrentAccount(long bankBranch, string accountNumber)
        {
            if (bankBranch == 0)
                throw new ArgumentException("Agência não pode ser igual a 0.", nameof(bankBranch));

            if (accountNumber.Equals("0"))
                throw new ArgumentException("Número da conta não pode ser igual a 0.", nameof(accountNumber));

            this.BankBranch = bankBranch;
            this.AccountNumber = accountNumber;

            OperationRate = 100 / TotalAccounts;
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

        public void MoneyTransfer(double value, CurrentAccount destination)
        {
            VerifyValue(value);

            if (Balance < value)
            {
                throw new Exception("Saldo insuficiente.");
            }
            Withdraw(value);
            destination.Deposit(value);

        }
    }
}