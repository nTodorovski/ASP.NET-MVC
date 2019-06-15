using BookLibrary.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BookLibrary.Data
{
    public interface IBookRepository
    {
        List<Book> ListAll();
        Book GetItemDetails(int id);
        void CreateNew(Book book);
        void UpdateExisting(Book book);
        void DeleteExisting(Book book);
    }
}
