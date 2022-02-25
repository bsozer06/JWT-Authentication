using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace UI.Models
{
    public class UserConstants
    {
        public static List<UserModel> Users = new List<UserModel>()
        {
            new UserModel()
            {
                UserName="burhan_admin",
                EmailAdress="bsozer@gmail.com",
                Password="123456",
                GivenName="Burhan",
                Surname="Sozer",
                Role="Administration"
            },
            new UserModel()
            {
                UserName="orhan_seller",
                EmailAdress="bxxxx@gmail.com",
                Password="123456",
                GivenName="Orhan",
                Surname="Atmaca",
                Role="Seller"
            }
        };
    }
}
