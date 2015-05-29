using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AssetsAccounting.DataAccess.Models;

namespace AssetsAccounting.DataAccess.Services
{
    public class UserService : IUserService
    {
        public User Authenticate(string username, string pass)
        {
            using (var context = new AssetsAccountingContext())
            {
                return context.Users.FirstOrDefault(x => x.Username.Equals(username) && x.Password.Equals(pass));
            }
        }
    }
}
