using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BookLibrary.Models
{
    public class Book
    {
        public int Id{ get; set; }
        public string Isbn { get; set; }
        public string Name { get; set; }
        public GenreEnum Genre { get; set; }
        public Author Author { get; set; }
        public int Pages { get; set; }
        public int Quantity { get; set; }


        public void IncreaseQuantity(int additionalQuantity)
        {
            Quantity += additionalQuantity;
        }

        public void RemoveCopy()
        {
            Quantity -= 1;
        }

        public Book(int id, string isbn, string name, GenreEnum genre, Author author, int pages, int quantity)
        {
            Id = id;
            Isbn = isbn;
            Name = name;
            Genre = genre;
            Author = author;
            Pages = pages;
            Quantity = quantity;
        }

        public Book()
        {

        }
    }
}
