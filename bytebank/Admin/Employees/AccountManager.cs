using bytebank.Admin.Auth;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bytebank.Admin.Employees
{
    public class AccountManager : AuthenticableEmployee
    {
        public AccountManager(string taxId, double salary) : base(taxId, salary)
        {
        }
        public override double GetBonus()
        {
            return Salary * 0.25;
        }

        public override void IncreaseSalary()
        {
            Salary *= 0.05;
        }
    }
}
