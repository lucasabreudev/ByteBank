using bytebank.Admin.Auth;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bytebank.Admin.Employees
{
    public abstract class AuthenticableEmployee : Employee, IAuthenticable
    {
        protected AuthenticableEmployee(string taxId, double salary) : base(taxId, salary)
        {
        }

        public string Login { get; set; }
        public string Password { get; set; }

        public bool Authenticate(string login, string password)
        {
            return this.Login == login && this.Password == password;
        }
    }
}
