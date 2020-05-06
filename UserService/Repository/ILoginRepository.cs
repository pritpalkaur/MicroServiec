using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using UserService.Database.Entity;

namespace UserService.Repository
{
    public interface ILoginRepository
    {
        User Authenticate(string username, string password);
        IEnumerable<User> GetAll();
    }
}
