using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BookLibrary.Models;

namespace BookLibrary.Data
{
    public class AuthorRepository : IAuthorRepository
    {
        public void CreateNew(Author author)
        {
            Storage.Authors.Add(author);
        }

        public void DeleteExisting(Author author)
        {
            Storage.Authors.Remove(author);
        }

        public Author GetItemDetails(int id)
        {
            return Storage.Authors.FirstOrDefault(x => x.Id == id);
        }

        public List<Author> ListAll()
        {
            return Storage.Authors;
        }

        public void UpdateExisting(Author author)
        {
            var foundAuthor = Storage.Authors.FirstOrDefault(x => x.Id == author.Id);
            foundAuthor.Age = author.Age;
            foundAuthor.FirstName = author.FirstName;
            foundAuthor.LastName = author.LastName;
        }
    }
}
