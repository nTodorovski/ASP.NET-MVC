using DataLayer;
using DtoModels;
using ViewModels;
using System;
using System.Collections.Generic;

namespace BusinessLayer
{
    public class LoanService : ILoanService
    {
        private readonly IRepository<Loan> _loanRepository;
        private readonly IRepository<Book> _bookRepository;
        private readonly IUserService _userService;

        public LoanService(IRepository<Loan> loanRepository, IRepository<Book> bookRepository, IUserService userService)
        {
            _loanRepository = loanRepository;
            _bookRepository = bookRepository;
            _userService = userService;
        }

        public Loan GetLoanById(int id)
        {
            var loan = _loanRepository.GetById(id);
            return loan;
        }

        public List<Loan> ListAllLoans()
        {
            return _loanRepository.GetAll();
        }

        public void UpdateExistingLoan(Loan loan)
        {
            _loanRepository.Update(loan);
        }

        public void CreateLoan(LoanViewModel model)
        {
            var loan = new Loan();
            var book = _bookRepository.GetById(int.Parse(model.SelectedBook));
            var user = _userService.FindLoggedUser();
            loan.Book = book;
            loan.User = user;
            loan.Status = LoanStatusEnum.Active;
            loan.LoanDate = DateTime.Now;
            user.Loans.Add(loan);
            _userService.UpdateExisting(user);
            _loanRepository.Create(loan);
        }

        public void DeleteExistingLoan(Loan loan)
        {
            _loanRepository.Delete(loan);
        }

        public bool CheckIfBookIsAvailable(string bookId)
        {
            var book = _bookRepository.GetById(int.Parse(bookId));
            if (book.Quantity > 0)
            {
                book.Quantity--;
                return true;
            }
            return false;
        }

        public bool CheckIfUserHasTheBook(string bookId)
        {
            var book = _bookRepository.GetById(int.Parse(bookId));
            var user = _userService.FindLoggedUser();
            foreach (var loan in _loanRepository.GetAll())
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
            foreach (var loan in _loanRepository.GetAll())
            {
                if (loan.User == user)
                {
                    counter++;
                }
            }
            if (counter >= 5)
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
