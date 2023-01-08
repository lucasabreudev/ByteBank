using bytebank.Admin.Auth;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bytebank.Admin.Partnership
{
    public class BusinessPartner : IAuthenticable
    {
        public string Login { get; set; }

        public string Password { get; set; }

        public bool Authenticate(string login, string password)
        {
            return this.Login == login && this.Password == password;
        }
    }
}
