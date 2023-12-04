using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp4
{
    public class UserRepository
    {
        public static List<User> Users = new List<User>()
        {
            new User()
            {
                Login = "admin",
                Password = "admin"
            },
        };
    }
}
