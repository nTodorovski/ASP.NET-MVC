using DtoModels;
using System;
using System.Collections.Generic;
using System.Text;

namespace BusinessLayer
{
    public interface IAuthorService
    {
        List<Author> ListAll();
        Author GetAuthorById(int id);
        void CreateNew(Author author);
        void UpdateExistingAuthor(Author author);
        void DeleteExisting(Author author);
    }
}
