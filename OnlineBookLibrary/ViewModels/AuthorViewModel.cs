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
        private readonly IRepository<Book> _bookRepository;
        private readonly IRepository<Author> _authorRepository;

        public AuthorViewModel(IRepository<Book> bookRepository, IRepository<Author> authorRepository)
        {
            _bookRepository = bookRepository;
            _authorRepository = authorRepository;
        }
        public int Id { get; set; }
        public List<Author> AllAuthors { get; set; }
        public List<Book> AllBooks { get; set; }
        public AuthorViewModel()
        {
            AllBooks = new List<Book>();
            foreach (var book in _bookRepository.GetAll())
            {
                AllBooks.Add(book);
            }

            AllAuthors = new List<Author>();
            foreach (var author in _authorRepository.GetAll())
            {
                AllAuthors.Add(author);
            }
        }
    }
}
