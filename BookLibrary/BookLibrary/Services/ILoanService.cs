using BookLibrary.Models;
using BookLibrary.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BookLibrary.Services
{
    public interface ILoanService
    {
        List<Loan> ListAllLoans();
        Loan GetLoanById(int id);
        void UpdateExistingLoan(Loan loan);
        void DeleteExistingLoan(Loan loan);
        void CreateLoan(LoanViewModel model);
        bool CheckIfBookIsAvailable(string bookId);
        bool CheckIfUserHasTheBook(string bookId);
        bool LoanedMoreThan5();
        void ReturnBook(int id);
    }
}
