using System;
using System.Collections.Generic;
using DtoModels;
using System.Linq;
using System.Threading.Tasks;
using DataLayer;

namespace ViewModels
{
    public class AuthorViewModel
    {
        public int Id { get; set; }
        public List<Author> AllAuthors { get; set; }
        public List<Book> AllBooks { get; set; }
        public AuthorViewModel()
        {
            AllBooks = new List<Book>();
            AllAuthors = new List<Author>();
        }
    }
}
