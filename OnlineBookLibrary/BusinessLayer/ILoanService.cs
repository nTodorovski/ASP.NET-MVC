using DtoModels;
using ViewModels;
using System.Collections.Generic;

namespace BusinessLayer
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
