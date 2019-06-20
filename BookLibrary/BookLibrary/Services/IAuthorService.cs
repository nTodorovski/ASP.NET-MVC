using BookLibrary.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BookLibrary.Services
{
    public interface IAuthorService
    {
        List<Author> ListAll();
        Author GetItemDetails(int id);
        void CreateNew(Author author);
        void UpdateExisting(Author author);
        void DeleteExisting(Author author);
    }
}
