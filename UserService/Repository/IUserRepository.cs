using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using UserService.Database.Entity;

namespace UserService.Repository
{
    public interface IUserRepository
    {
        IEnumerable<User> GetUsers();
        User GetUserByID(int user);
        void InsertUser(User user);
        void DeleteUser(int userId);
        void UpdateUser(User user);
        void Save();
    }
}
