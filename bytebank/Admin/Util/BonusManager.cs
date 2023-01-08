using bytebank.Admin.Employees;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bytebank.Admin.Util
{
    public class BonusManager
    {
        private double totalBonus;

        public void Register(Employee employee)
        {
            totalBonus += employee.GetBonus();
        }

        public double GetTotalBonus()
        {
            return totalBonus;
        }
    }
}
