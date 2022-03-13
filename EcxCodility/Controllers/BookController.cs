using AutoMapper;
using EcxCodility.Models;
using EcxCodility.Service.Common;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;

namespace EcxCodility.Controllers
{
    public class BookController : Controller
    {
        private readonly IMapper mapper;
        private readonly IBookService bookService;

        public BookController(IMapper mapper, IBookService bookService)
        {
            this.mapper = mapper;
            this.bookService = bookService;
        }

        public ActionResult Books()
        {
            var result =  bookService.GetAllBooks();
            return View(mapper.Map<IEnumerable<BookViewModel>>(result));
        }

        // GET
        [HttpGet]
        public ActionResult BorrowBook(Guid id)
        {
            var book = bookService.GetBook(id);
            return View(mapper.Map<BookEditViewModel>(book));
        }

        // POST
        [HttpPost]
        public ActionResult BorrowBook(BookEditViewModel bookEditViewModel)
        {
            _ = bookService.BorrowBook(bookEditViewModel.Id, bookEditViewModel.Borrower);
            return RedirectToAction("Books");
        }

        // GET
        public ActionResult ReturnBook(Guid id)
        {
            var book = bookService.ReturnBook(id);
            return RedirectToAction("Books");
        }
    }
}
