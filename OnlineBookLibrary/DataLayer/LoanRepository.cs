using DtoModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DataLayer
{
    public class LoanRepository : IRepository<Loan>
    {
        private OnlineBookLibraryDbContext _dbContext;
        public LoanRepository(OnlineBookLibraryDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public void Create(Loan obj)
        {
            _dbContext.Loans.Add(obj);
            _dbContext.SaveChanges();
        }

        public void Delete(Loan obj)
        {
            _dbContext.Loans.Remove(obj);
            _dbContext.SaveChanges();
        }

        public List<Loan> GetAll()
        {
            return _dbContext.Loans.ToList();
        }

        public Loan GetById(int id)
        {
            return _dbContext.Loans.FirstOrDefault(x => x.Id == id);
        }

        public void Update(Loan obj)
        {
            _dbContext.Loans.Update(obj);
            _dbContext.SaveChanges();
        }
    }
}
