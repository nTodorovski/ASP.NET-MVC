using BookLibrary.Models;
using BookLibrary.ViewModels;
using System.Collections.Generic;

namespace BookLibrary.Services
{
    public interface IBookService
    {
        List<Book> ListAllBooks();
        Book GetBookById(int id);
        Book ChangeToModel(EditBookViewModel model);
        void UpdateExistingBook(Book book);
        void Delete(int id);
        void AddListItemToBook(EditBookViewModel book);
        void Create(EditBookViewModel model);
    }
}
