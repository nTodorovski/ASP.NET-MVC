using BookLibrary.Models;
using System.Collections.Generic;
using System.Linq;

namespace BookLibrary.Data
{
    public class BookRepository : IBookRepository
    {
        public void CreateNew(Book book)
        {
            Storage.Books.Add(book);
        }

        public void DeleteExisting(Book book)
        {
            Storage.Books.Remove(book);
        }

        public Book GetItemDetails(int id)
        {
            return Storage.Books.FirstOrDefault(x => x.Id == id);
        }

        public List<Book> ListAll()
        {
            return Storage.Books;
        }

        public void UpdateExisting(Book book)
        {
            var foundBook = Storage.Books.FirstOrDefault(x => x.Id == book.Id);
            foundBook.Isbn = book.Isbn;
            foundBook.Name = book.Name;
            foundBook.Pages = book.Pages;
            foundBook.Quantity = book.Quantity;
            foundBook.Genre = book.Genre;
            foundBook.Author = book.Author;
        }
    }
}
