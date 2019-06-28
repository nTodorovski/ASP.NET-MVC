using System;
using System.Collections.Generic;
using System.Text;
using DataLayer;
using DtoModels;
using Microsoft.EntityFrameworkCore;

namespace BusinessLayer
{
    public class AuthorService : IAuthorService
    {
        private readonly IRepository<Author> _authorRepository;

        public AuthorService(IRepository<Author> authorRepository)
        {
            _authorRepository = authorRepository;
        }
        public void CreateNew(Author author)
        {
            _authorRepository.Create(author);
        }

        public void DeleteExisting(Author author)
        {
            _authorRepository.Delete(author);
        }

        public Author GetAuthorById(int id)
        {
            return _authorRepository.GetById(id);
        }

        public List<Author> ListAll()
        {
            return _authorRepository.GetAll();
        }

        public void UpdateExistingAuthor(Author author)
        {
            _authorRepository.Update(author);
        }
    }
}
