using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.User
{
    public class UserLogin: Base
    {
        public string UserName { get; set; }
        public string Password { get; set; }
    }
}
