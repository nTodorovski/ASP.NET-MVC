using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace DtoModels
{
    public class Book : IEntity
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public string Isbn { get; set; }
        [Required]
        [StringLength(70)]
        public string Name { get; set; }
        public GenreEnum Genre { get; set; }
        [Required]
        public Author Author { get; set; }
        public int AuthorId { get; set; }
        public int Pages { get; set; }
        [Required]
        public int Quantity { get; set; }


        public void IncreaseQuantity(int additionalQuantity)
        {
            Quantity += additionalQuantity;
        }

        public void RemoveCopy()
        {
            Quantity -= 1;
        }

        public Book(string isbn, string name, GenreEnum genre, int pages, int quantity)
        {
            Isbn = isbn;
            Name = name;
            Genre = genre;
            Pages = pages;
            Quantity = quantity;
        }

        public Book()
        {

        }
    }
}
