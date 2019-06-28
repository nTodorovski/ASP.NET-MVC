using BookLibrary.ViewModels;
using DataLayer;
using DtoModels;
using System;
using System.Collections.Generic;

namespace Mapper
{
    public static class BookMapper
    {
        public static Book ToModel(this EditBookViewModel model)
        {
            var author = .FirstOrDefault(x => x.Id.ToString() == model.Author);
            GenreEnum genre = (GenreEnum)Enum.Parse(typeof(GenreEnum), model.Genre);

            Book newBook = new Book();
            newBook.Id = model.Id;
            newBook.Isbn = model.Isbn;
            newBook.Name = model.Name;
            newBook.Pages = model.Pages;
            newBook.Author = author;
            newBook.Quantity = model.Quantity;
            newBook.Genre = genre;

            return newBook;
        }
    }
}
