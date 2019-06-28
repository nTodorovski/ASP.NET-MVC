using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BusinessLayer;
using DtoModels;
using Microsoft.AspNetCore.Mvc;
using ViewModels;

namespace OnlineBookLibrary.Controllers
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

        [HttpGet]
        public IActionResult Create()
        {
            var book = new EditBookViewModel();
            _bookService.AddListItemToBook(book);
            return View(book);
        }

        [HttpPost]
        public IActionResult Create(EditBookViewModel editBook)
        {
            if (!ModelState.IsValid)
            {
                return View(editBook);
            }
            _bookService.Create(editBook);
            return RedirectToAction("Index", "Book");
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

        [HttpGet]
        public IActionResult Delete(int id)
        {
            _bookService.Delete(id);
            return RedirectToAction("Index", "Book");
        }
    }
}