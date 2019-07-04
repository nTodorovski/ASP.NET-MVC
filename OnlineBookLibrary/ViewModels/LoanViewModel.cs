using DataLayer;
using DtoModels;
using Microsoft.AspNetCore.Mvc.Rendering;
using System.Collections.Generic;

namespace ViewModels
{
    public class LoanViewModel
    {
        public List<SelectListItem> Books { get; set; }
        public string SelectedBook { get; set; }

        public LoanViewModel()
        {
            Books = new List<SelectListItem>();
        }
    }
}
