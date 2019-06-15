using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BookLibrary.Data;
using BookLibrary.Models;
using BookLibrary.ViewModels;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace BookLibrary.Services
{
    public class BookService : IBookService
    {

        private readonly IBookRepository _bookRepository;

        public BookService(IBookRepository bookRepository)
        {
            _bookRepository = bookRepository;
        }

        public void CreateNewBook(Book book)
        {
            _bookRepository.CreateNew(book);
        }

        public void DeleteExistingBook(Book book)
        {
            _bookRepository.DeleteExisting(book);
        }

        public Book GetBookById(int id)
        {
            return _bookRepository.GetItemDetails(id);
        }

        public List<Book> ListAllBooks()
        {
            return _bookRepository.ListAll();
        }

        public void UpdateExistingBook(Book book)
        {
            _bookRepository.UpdateExisting(book);
        }

        public Book ChangeToModel(EditBookViewModel model)
        {
            var author = Storage.Authors.FirstOrDefault(x => x.Id == model.Author);
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

        public void AddListItemToBook(EditBookViewModel book)
        {
            foreach (var author in Storage.Authors)
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
                if(genre == book.SelectedGenre.ToString())
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
        //public void LoanBook(Book book)
        //{

        //}

        //public int ReturnBook(Loan loan)
        //{
        //    int PenaltyPerDay = 30;
        //    int fine = 0;

        //    loan.Status = LoanStatusEnum.Finished;
        //    TimeSpan t = loan.LoanDate - DateTime.Now;
        //    if (t.Days > 30)
        //    {
        //        fine = (t.Days - 30) * PenaltyPerDay;
        //    }

        //    return fine;
        //}
    }
}
