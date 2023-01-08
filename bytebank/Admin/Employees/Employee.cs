using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bytebank.Admin.Employees
{
    public abstract class Employee
    {
        public long Id { get; set; }
        public string Name { get; set; }
        public string TaxId { get; private set; }
        public double Salary { get; protected set; }
        public static int TotalEmployee { get; private set; }

        public Employee(string taxId, double salary)
        {
            TaxId = taxId;
            Salary = salary;
            TotalEmployee++;
        }

        public abstract double GetBonus();
        public abstract void IncreaseSalary();

    }
}
