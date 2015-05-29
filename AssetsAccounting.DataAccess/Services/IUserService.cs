using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AssetsAccounting.DataAccess.Models;

namespace AssetsAccounting.DataAccess.Services
{
    public interface IUserService
    {
        User Authenticate(string user, string pass);
    }
}
