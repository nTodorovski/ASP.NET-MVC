using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BookLibrary.Models;

namespace BookLibrary.Data
{
    public class LoanRepository : ILoanRepository
    {
        public void CreateNew(Loan loan)
        {
            Storage.Loans.Add(loan);
        }

        public void DeleteExisting(Loan loan)
        {
            Storage.Loans.Remove(loan);
        }

        public Loan GetItemDetails(int id)
        {
            return Storage.Loans.FirstOrDefault(x => x.Id == id);
        }

        public List<Loan> ListAll()
        {
            return Storage.Loans;
        }

        public void UpdateExisting(Loan loan)
        {
            var foundLoan= Storage.Loans.FirstOrDefault(x => x.Id == loan.Id);
            foundLoan = loan;
        }
    }
}
