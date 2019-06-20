using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BookLibrary.Data;
using BookLibrary.Models;
using BookLibrary.ViewModels;

namespace BookLibrary.Services
{
    public class LoanService : ILoanService
    {
        private readonly ILoanRepository _loanRepository;
        private readonly IBookRepository _bookRepository;
        private readonly IUserService _userService;

        public LoanService(ILoanRepository loanRepository, IBookRepository bookRepository, IUserService userService)
        {
            _loanRepository = loanRepository;
            _bookRepository = bookRepository;
            _userService = userService;
        }

        public Loan GetLoanById(int id)
        {
            var loan = _loanRepository.GetItemDetails(id);
            return loan;
        }

        public List<Loan> ListAllLoans()
        {
            return _loanRepository.ListAll();
        }

        public void UpdateExistingLoan(Loan loan)
        {
            _loanRepository.UpdateExisting(loan);
        }

        public void CreateLoan(LoanViewModel model)
        {
            int nextId = 0;
            if (Storage.Loans.Count > 0)
            {
                nextId = Storage.Loans.Last().Id + 1;
            }
            var loan = new Loan();
            var book = _bookRepository.GetItemDetails(int.Parse(model.SelectedBook));
            var user = _userService.FindLoggedUser();
            loan.Id = nextId;
            loan.Book = book;
            loan.User = user;
            loan.Status = LoanStatusEnum.Active;
            loan.LoanDate = DateTime.Now;
            _loanRepository.CreateNew(loan);
        }

        public void DeleteExistingLoan(Loan loan)
        {
            _loanRepository.DeleteExisting(loan);
        }

        public bool CheckIfBookIsAvailable(string bookId)
        {
            var book = _bookRepository.GetItemDetails(int.Parse(bookId));
            if(book.Quantity > 0)
            {
                book.Quantity--;
                return true;
            }
            return false;
        }

        public bool CheckIfUserHasTheBook(string bookId)
        {
            var book = _bookRepository.GetItemDetails(int.Parse(bookId));
            var user = _userService.FindLoggedUser();
            foreach (var loan in Storage.Loans)
            {
                if (loan.Book == book && loan.User == user)
                {
                    return true;
                }
            }
            return false;
        }

        public bool LoanedMoreThan5()
        {
            var user = _userService.FindLoggedUser();
            int counter = 0;
            foreach (var loan in Storage.Loans)
            {
                if(loan.User == user)
                {
                    counter++;
                }
            }
            if(counter >= 5)
            {
                return true;
            }
            return false;
        }

        public void ReturnBook(int id)
        {
            Loan loan = GetLoanById(id);
            int PenaltyPerDay = 15;
            loan.FinePaid = 0;

            loan.Status = LoanStatusEnum.Finished;
            TimeSpan t = loan.LoanDate - DateTime.Now;
            if (t.Days > 30)
            {
                loan.FinePaid = (t.Days - 30) * PenaltyPerDay;
            }
            loan.DateReturned = DateTime.Now;
        }
    }
}
