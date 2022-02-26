using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.User
{
    public class UserModel: Base
    {
        public string UserName { get; set; }
        public string Password { get; set; }
        public string EmailAdress { get; set; }
        public string Role { get; set; }
        public string Surname { get; set; }
        public string GivenName { get; set; }
    }
}
