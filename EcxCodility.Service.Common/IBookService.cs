using EcxCodility.Common.Models;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace EcxCodility.Service.Common
{
    public interface IBookService
    {
        IEnumerable<BookDTO> GetAllBooks();
        BookDTO GetBook(Guid id);
        bool BorrowBook(Guid id, string borrower);
        bool ReturnBook(Guid id);
    }
}
