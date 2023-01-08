using bytebank.Admin.Auth;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bytebank.Admin.Employees
{
    public class Director : AuthenticableEmployee
    {
        public Director(string taxId, double salary) : base(taxId, salary)
        {

        }

        public override double GetBonus()
        {
            return Salary * 0.5;
        }

        public override void IncreaseSalary()
        {
            Salary *= 1.15;
        }
    }
}
