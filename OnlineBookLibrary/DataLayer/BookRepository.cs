using DtoModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DataLayer
{
    public class BookRepository : IRepository<Book>
    {
        private OnlineBookLibraryDbContext _dbContext;
        public BookRepository(OnlineBookLibraryDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public void Create(Book obj)
        {
            _dbContext.Books.Add(obj);
            _dbContext.SaveChanges();
        }

        public void Delete(Book obj)
        {
            _dbContext.Books.Remove(obj);
            _dbContext.SaveChanges();
        }

        public List<Book> GetAll()
        {
            return _dbContext.Books.ToList();
        }

        public Book GetById(int id)
        {
            return _dbContext.Books.FirstOrDefault(x => x.Id == id);
        }

        public void Update(Book obj)
        {
            _dbContext.Books.Update(obj);
            _dbContext.SaveChanges();
        }
    }
}
