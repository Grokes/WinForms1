using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp4
{
    public interface IUserRepository
    {
        List<User> GetUsers();
        void Create(User user);
    }
}
