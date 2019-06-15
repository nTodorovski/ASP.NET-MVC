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
        public LoanStatusEnum Status { get; set; }

        public Loan(int id, Book book, User user, DateTime loanDate)
        {
            Id = id;
            Book = book;
            User = user;
            LoanDate = loanDate;
            Status = LoanStatusEnum.Active;
        }

        public int ReturnBook()
        {
            int PenaltyPerDay = 30;
            int fine = 0;
            Status = LoanStatusEnum.Finished;
            TimeSpan t = LoanDate - DateTime.Now;
            if (t.Days > 30)
            {
                fine = (t.Days - 30) * PenaltyPerDay;
            }

            return fine;
        }
    }
}
