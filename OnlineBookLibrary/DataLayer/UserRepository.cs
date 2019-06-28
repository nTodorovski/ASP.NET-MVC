using DtoModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DataLayer
{
    public class UserRepository : IRepository<User>
    {
        private OnlineBookLibraryDbContext _dbContext;
        public UserRepository(OnlineBookLibraryDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public void Create(User obj)
        {
            _dbContext.Users.Add(obj);
            _dbContext.SaveChanges();
        }

        public void Delete(User obj)
        {
            _dbContext.Users.Remove(obj);
            _dbContext.SaveChanges();
        }

        public List<User> GetAll()
        {
            return _dbContext.Users.ToList();
        }

        public User GetById(int id)
        {
            return _dbContext.Users.FirstOrDefault(x => x.Id == id);
        }

        public void Update(User obj)
        {
            _dbContext.Users.Update(obj);
            _dbContext.SaveChanges();
        }
    }
}
