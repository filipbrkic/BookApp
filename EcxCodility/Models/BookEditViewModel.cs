using System;
using System.ComponentModel.DataAnnotations;

namespace EcxCodility.Models
{
    public class BookEditViewModel
    {
        public Guid Id { get; set; }
        public string Borrower { get; set; }

    }
}
