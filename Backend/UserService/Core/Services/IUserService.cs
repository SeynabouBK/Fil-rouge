using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UserService.Core.Services
{
    public interface IUserService
    {
        bool RegisterUser(string username, string email, string password, string role);
    }
}
