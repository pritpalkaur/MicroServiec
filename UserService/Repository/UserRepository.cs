using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using UserService.Database;
using UserService.Database.Entity;

namespace UserService.Repository
{
    public class UserRepository : IUserRepository
    {
        private readonly DatabaseContext _dbContext;
        public UserRepository(DatabaseContext dbContext)
        {
            _dbContext = dbContext;
        }
        public void DeleteUser(int userId)
        {
            var product = _dbContext.Users.Find(userId);
            _dbContext.Users.Remove(product);
            Save();
        }

        public User GetUserByID(int userId)
        {
            return _dbContext.Users.Find(userId);
        }

        public IEnumerable<User> GetUsers()
        {
            return _dbContext.Users.ToList();
        }

        public void InsertUser (User user)
        {
            _dbContext.Add(user);
            Save();
        }

        public void Save()
        {
            _dbContext.SaveChanges();
        }

        public void UpdateUser(User user)
        {
            _dbContext.Entry(user).State = EntityState.Modified;
            Save();
        }
    }
}
