using EcxCodility.Common.Models;
using EcxCodility.Repository.Common;
using EcxCodility.Service.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EcxCodility.Service
{
    public class BookService : IBookService
    {
        private readonly IBookRepository bookrepository;

        public BookService(IBookRepository bookrepository)
        {
            this.bookrepository = bookrepository;
        }

        public IEnumerable<BookDTO> GetAllBooks()
        {
            return bookrepository.GetAll();
        }

        public BookDTO GetBook(Guid id)
        {
            var books = bookrepository.GetAll();
            return books.FirstOrDefault(x=>x.Id == id);
        }

        public bool BorrowBook(Guid id, string borrower)
        {
            var books = bookrepository.GetAll();
            var book = books.FirstOrDefault(x => x.Id == id);
            book.Borrower = borrower;
            book.IsBorrowed = true;
            return bookrepository.Update(books);
        }

        public bool ReturnBook(Guid id)
        {
            var books = bookrepository.GetAll();
            var book = books.FirstOrDefault(x => x.Id == id);
            book.Borrower = String.Empty;
            book.IsBorrowed = false;
            return bookrepository.Update(books);
        }
    }
}
