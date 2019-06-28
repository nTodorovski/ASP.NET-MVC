using DataLayer;
using DtoModels;
using Microsoft.AspNetCore.Mvc.Rendering;
using System.Collections.Generic;

namespace ViewModels
{
    public class LoanViewModel
    {
        private readonly IRepository<Book> _bookRepository;

        public LoanViewModel(IRepository<Book> bookRepository)
        {
            _bookRepository = bookRepository;
        }
        public List<SelectListItem> Books { get; set; }
        public string SelectedBook { get; set; }

        public LoanViewModel()
        {
            Books = new List<SelectListItem>();

            foreach (var book in _bookRepository.GetAll())
            {
                Books.Add(new SelectListItem
                {
                    Text = book.Name,
                    Value = book.Id.ToString()
                });
            }
        }
    }
}
