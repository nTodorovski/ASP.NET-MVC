using BookLibrary.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BookLibrary.Data
{
    public interface ILoanRepository
    {
        List<Loan> ListAll();
        Loan GetItemDetails(int id);
        void CreateNew(Loan loan);
        void UpdateExisting(Loan loan);
        void DeleteExisting(Loan loan);
    }
}
