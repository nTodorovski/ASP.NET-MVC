using BookLibrary.Models;
using Microsoft.AspNetCore.Mvc.Rendering;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace BookLibrary.ViewModels
{
    public class EditBookViewModel
    {
        public int Id { get; set; }
        public string Isbn { get; set; }
        [Required]
        [MinLength(3, ErrorMessage = "Please insert more than 3 char")]
        public string Name { get; set; }
        [Required]
        public string Genre { get; set; }
        public List<SelectListItem> AllGenres { get; set; }
        [Required]
        public string Author { get; set; }
        public List<SelectListItem> AllAuthors { get; set; }
        public int Pages { get; set; }
        public int Quantity { get; set; }
        public Author SelectedAuthor { get; set; }
        public GenreEnum SelectedGenre { get; set; }

        public EditBookViewModel()
        {
            AllAuthors = new List<SelectListItem>();
            AllGenres = new List<SelectListItem>();
        }
    }
}
