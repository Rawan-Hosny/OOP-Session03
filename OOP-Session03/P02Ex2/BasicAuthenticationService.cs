using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Session03.P02Ex2
{
    internal class BasicAuthenticationService: IAuthenticationService
    {
        public bool AuthenticateUser(string userName, string password)
        {
            if (userName == "Rawan" && password == "rawan0012") return true;
            if (userName == "Omnnia" && password == "mona0044") return true;
            else return false;

        }

        public bool AuthorizeUser(string userName, string Role)
        {
            if (userName == "Mansour" && Role == "PHP") return true;
            if (userName == "Sara" && Role == "fRONT") return true;
            else return false;
        }
    }
}
