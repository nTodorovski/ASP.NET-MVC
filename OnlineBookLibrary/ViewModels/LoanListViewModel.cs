using DataLayer;
using DtoModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ViewModels
{
    public class LoanListViewModel
    {
        private readonly IRepository<Loan> _loanRepository;
        public LoanListViewModel(IRepository<Loan> loanRepository)
        {
            _loanRepository = loanRepository;
        }
        public List<Loan> AllLoans { get; set; }

        public LoanListViewModel()
        {
            AllLoans = new List<Loan>();
            foreach (var loan in _loanRepository.GetAll())
            {
                AllLoans.Add(loan);
            }
        }
    }
}
