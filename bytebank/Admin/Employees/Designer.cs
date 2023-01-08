using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bytebank.Admin.Employees
{
    public class Designer : Employee
    {
        public Designer(string taxId, double salary) : base(taxId, salary)
        {
        }

        public override double GetBonus()
        {
            return Salary * 0.17;
        }

        public override void IncreaseSalary()
        {
            Salary *= 1.11;
        }
    }
}
