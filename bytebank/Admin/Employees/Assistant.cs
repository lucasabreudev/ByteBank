using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bytebank.Admin.Employees
{
    public class Assistant : Employee
    {
        public Assistant(string taxId, double salary) : base(taxId, salary)
        {
        }

        public override double GetBonus()
        {
            return Salary * 0.2;
        }

        public override void IncreaseSalary()
        {
            Salary *= 1.1;
        }
    }
}
