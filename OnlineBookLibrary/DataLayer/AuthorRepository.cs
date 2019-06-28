using DtoModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DataLayer
{
    public class AuthorRepository : IRepository<Author>
    {
        private OnlineBookLibraryDbContext _dbContext;
        public AuthorRepository(OnlineBookLibraryDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public void Create(Author obj)
        {
            _dbContext.Authors.Add(obj);
            _dbContext.SaveChanges();
        }

        public void Delete(Author obj)
        {
            _dbContext.Authors.Remove(obj);
            _dbContext.SaveChanges();
        }

        public List<Author> GetAll()
        {
            return _dbContext.Authors.ToList();
        }

        public Author GetById(int id)
        {
            return _dbContext.Authors.FirstOrDefault(x => x.Id == id);
        }

        public void Update(Author obj)
        {
            _dbContext.Authors.Update(obj);
            _dbContext.SaveChanges();
        }
    }
}
