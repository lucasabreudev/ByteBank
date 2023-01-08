using bytebank.Admin.Employees;
using bytebank.Admin.Partnership;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bytebank.Admin.Auth
{
    public class Authentication
    {
        public bool Login(IAuthenticable auth, string login, string password)
        {
            bool authenticated = auth.Authenticate(login, password);

            return authenticated;
        }
    }
}
