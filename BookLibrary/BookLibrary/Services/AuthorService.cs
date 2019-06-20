using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BookLibrary.Data;
using BookLibrary.Models;

namespace BookLibrary.Services
{
    public class AuthorService : IAuthorService
    {
        private readonly IAuthorRepository _authorRepository;

        public AuthorService(IAuthorRepository authorRepository)
        {
            _authorRepository = authorRepository;
        }
        public void CreateNew(Author author)
        {
            _authorRepository.CreateNew(author);
        }

        public void DeleteExisting(Author author)
        {
            _authorRepository.DeleteExisting(author);
        }

        public Author GetAuthorById(int id)
        {
            return _authorRepository.GetItemDetails(id);
        }

        public List<Author> ListAll()
        {
            return _authorRepository.ListAll();
        }

        public void UpdateExistingAuthor(Author author)
        {
            _authorRepository.UpdateExisting(author);
        }

        public void CreateAuthor(Author author)
        {
            int nextId = Storage.Authors.Last().Id + 1;
            author.Id = nextId;
            _authorRepository.CreateNew(author);
        }
    }
}
