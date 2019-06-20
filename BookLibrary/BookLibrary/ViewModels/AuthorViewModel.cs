using BookLibrary.Data;
using BookLibrary.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BookLibrary.ViewModels
{
    public class AuthorViewModel
    {
        public int Id { get; set; }
        public List<Author> AllAuthors { get; set; }
        public List<Book> AllBooks { get; set; }
        public AuthorViewModel()
        {
            AllBooks = new List<Book>();
            foreach (var book in Storage.Books)
            {
                AllBooks.Add(book);
            }

            AllAuthors = new List<Author>();
            foreach (var author in Storage.Authors)
            {
                AllAuthors.Add(author);
            }
        }
    }
}
