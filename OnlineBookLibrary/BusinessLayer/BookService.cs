using DataLayer;
using DtoModels;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BusinessLayer
{
    public class BookService : IBookService
    {
        private readonly IRepository<Book> _bookRepository;
        private readonly IRepository<Author> _authorRepository;


        public BookService(IRepository<Book> bookRepository, IRepository<Author> authorRepository)
        {
            _bookRepository = bookRepository;
            _authorRepository = authorRepository;
        }

        public void Delete(int id)
        {
            var book = GetBookById(id);
            _bookRepository.Delete(book);
        }

        public Book GetBookById(int id)
        {
            return _bookRepository.GetById(id);
        }

        public List<Book> ListAllBooks()
        {
            return _bookRepository.GetAll();
        }

        public void UpdateExistingBook(Book book)
        {
            _bookRepository.Update(book);
        }

        public Book ChangeToModel(EditBookViewModel model)
        {
            var author = _authorRepository.GetAll().FirstOrDefault(x => x.Id.ToString() == model.Author);
            GenreEnum genre = (GenreEnum)Enum.Parse(typeof(GenreEnum), model.Genre);

            Book newBook = new Book();
            newBook.Id = model.Id;
            newBook.Isbn = model.Isbn;
            newBook.Name = model.Name;
            newBook.Pages = model.Pages;
            newBook.Author = author;
            newBook.Quantity = model.Quantity;
            newBook.Genre = genre;

            return newBook;
        }

        public void Create(EditBookViewModel model)
        {
            var author = _authorRepository.GetAll().FirstOrDefault(x => x.Id == int.Parse(model.Author));
            GenreEnum genre = (GenreEnum)Enum.Parse(typeof(GenreEnum), model.Genre);

            Book newBook = new Book();
            newBook.Isbn = model.Isbn;
            newBook.Name = model.Name;
            newBook.Pages = model.Pages;
            newBook.Author = author;
            newBook.Quantity = model.Quantity;
            newBook.Genre = genre;

            _bookRepository.Create(newBook);
        }

        public void AddListItemToBook(EditBookViewModel book)
        {
            foreach (var author in _authorRepository.GetAll())
            {
                if (author == book.SelectedAuthor)
                {
                    book.AllAuthors.Add(new SelectListItem
                    {
                        Text = author.GetFullName(),
                        Value = author.Id.ToString(),
                        Selected = true
                    });
                }
                else
                {
                    book.AllAuthors.Add(new SelectListItem
                    {
                        Text = author.GetFullName(),
                        Value = author.Id.ToString()
                    });
                }
            }

            foreach (string genre in Enum.GetNames(typeof(GenreEnum)))
            {
                if (genre == book.SelectedGenre.ToString())
                {
                    book.AllGenres.Add(new SelectListItem
                    {
                        Text = genre,
                        Value = genre,
                        Selected = true
                    });
                }
                else
                {
                    book.AllGenres.Add(new SelectListItem
                    {
                        Text = genre,
                        Value = genre
                    });
                }
            }
        }
    }
}
