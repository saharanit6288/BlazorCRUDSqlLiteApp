using BlazorCRUDSqlLiteApp.Server.Data;
using BlazorCRUDSqlLiteApp.Server.Interfaces;
using BlazorCRUDSqlLiteApp.Shared.Models;
using Microsoft.EntityFrameworkCore;

namespace BlazorCRUDSqlLiteApp.Server.Services
{
    public class UserManager : IUser
    {
        DatabaseContext _dbContext = new();
        public UserManager(DatabaseContext dbContext)
        {
            _dbContext = dbContext;
        }


        public void AddUser(User user)
        {
            try
            {
                _dbContext.Users.Add(user);
                _dbContext.SaveChanges();
            }
            catch { throw; }
        }

        public void DeleteUser(int id)
        {
            try
            {
                User? user = _dbContext.Users.Where(w => w.Userid == id).FirstOrDefault();
                if (user != null)
                {
                    _dbContext.Users.Remove(user);
                    _dbContext.SaveChanges();
                }
                else
                {
                    throw new ArgumentNullException();
                }
            }
            catch { throw; }
        }

        public User GetUserById(int id)
        {
            try
            {
                User? user = _dbContext.Users.Where(w => w.Userid == id).FirstOrDefault();
                if (user != null)
                {
                    return user;
                }
                else
                {
                    throw new ArgumentNullException();
                }
            }
            catch { throw; }
        }

        public List<User> GetUsers()
        {
            try
            {
                return _dbContext.Users.ToList();
            }
            catch { throw; }
        }

        public void UpdateUser(User user)
        {
            try
            {
                _dbContext.Entry(user).State = EntityState.Modified;
                _dbContext.SaveChanges();
            }
            catch { throw; }
        }
    }
}
