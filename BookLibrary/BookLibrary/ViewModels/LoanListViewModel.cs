using BookLibrary.Data;
using BookLibrary.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BookLibrary.ViewModels
{
    public class LoanListViewModel
    {
        public List<Loan> AllLoans { get; set; }

        public LoanListViewModel()
        {
            AllLoans = new List<Loan>();
            foreach (var loan in Storage.Loans)
            {
                AllLoans.Add(loan);
            }
        }
    }
}
