using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BookLibrary.Models
{
    public class Loan
    {
        public int Id { get; set; }
        public Book Book { get; set; }
        public User User { get; set; }
        public DateTime LoanDate { get; set; }
        public DateTime DateReturned { get; set; }
        public LoanStatusEnum Status { get; set; }
        public int FinePaid { get; set; }

        public Loan(int id, Book book, User user, DateTime loanDate)
        {
            Id = id;
            Book = book;
            User = user;
            LoanDate = loanDate;
            Status = LoanStatusEnum.Active;
        }

        public Loan()
        {

        }
    }
}
