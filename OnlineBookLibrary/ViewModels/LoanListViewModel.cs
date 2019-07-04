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
        public List<Loan> AllLoans { get; set; }

        public LoanListViewModel()
        {
            AllLoans = new List<Loan>();
        }
    }
}
