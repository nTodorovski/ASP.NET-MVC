using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace DtoModels
{
    public class Loan : IEntity
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        [Required]
        public Book Book { get; set; }
        [Required]
        public User User { get; set; }
        [Required]
        public DateTime LoanDate { get; set; }
        public DateTime DateReturned { get; set; }
        public LoanStatusEnum Status { get; set; }
        public int FinePaid { get; set; }

        public Loan(Book book, User user, DateTime loanDate)
        {
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
