using BookLibrary.Models;
using BookLibrary.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BookLibrary.Services
{
    public interface IBookService
    {
        List<Book> ListAllBooks();
        Book GetBookById(int id);
        Book ChangeToModel(EditBookViewModel model);
        void CreateNewBook(Book book);
        void UpdateExistingBook(Book book);
        void DeleteExistingBook(Book book);
        void AddListItemToBook(EditBookViewModel book);
    }
}
