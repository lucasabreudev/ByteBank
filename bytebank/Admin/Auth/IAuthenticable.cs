using bytebank.Admin.Employees;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bytebank.Admin.Auth
{
    public interface IAuthenticable
    {
        public bool Authenticate(string login, string password);
    }
}
