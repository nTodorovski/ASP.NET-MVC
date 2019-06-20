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

        public Author GetItemDetails(int id)
        {
            return _authorRepository.GetItemDetails(id);
        }

        public List<Author> ListAll()
        {
            return _authorRepository.ListAll();
        }

        public void UpdateExisting(Author author)
        {
            _authorRepository.UpdateExisting(author);
        }
    }
}
