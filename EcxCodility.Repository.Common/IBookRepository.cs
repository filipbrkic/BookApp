using EcxCodility.Common.Models;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace EcxCodility.Repository.Common
{
    public interface IBookRepository
    {
        IEnumerable<BookDTO> GetAll();
        bool Update(IEnumerable<BookDTO> bookDTO);
    }
}
