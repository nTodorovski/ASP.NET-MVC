using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BookLibrary.Data;
using BookLibrary.Models;
using BookLibrary.Services;
using BookLibrary.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace BookLibrary.Controllers
{
    public class BookController : Controller
    {
        private readonly IBookService _bookService;
        public BookController(IBookService bookService)
        {
            _bookService = bookService;
        }
        public IActionResult Index()
        {
            var books = _bookService.ListAllBooks();
            return View(books);
        }

        public IActionResult Details(int id)
        {
            var book = _bookService.GetBookById(id);
            return View(book);
        }
        
        [HttpGet]
        public IActionResult Edit(int id)
        {
            var foundBook = _bookService.GetBookById(id);
            var book = new EditBookViewModel()
            {
                Id = foundBook.Id,
                Name = foundBook.Name,
                Isbn = foundBook.Isbn,
                Pages = foundBook.Pages,
                Quantity = foundBook.Quantity,
                SelectedAuthor = foundBook.Author,
                SelectedGenre = foundBook.Genre
            };
            _bookService.AddListItemToBook(book);
            return View(book);
        }

        [HttpPost]
        public IActionResult Edit(EditBookViewModel model)
        {
            if (!ModelState.IsValid)
            {
                return View(model);
            }

            Book newBook = _bookService.ChangeToModel(model);
            _bookService.UpdateExistingBook(newBook);
            return RedirectToAction("Index", "Book");
        }
    }
}