using System;
using System.ComponentModel.DataAnnotations;

namespace EcxCodility.Models
{
    public class BookViewModel
    {
        public Guid Id { get; set; }
        public string Author { get; set; }
        public string Title { get; set; }
        public string Genre { get; set; }
        public string Price { get; set; }
        public string Description { get; set; }
        public string Borrower { get; set; }

        [Display(Name = "Borrowed")]
        public bool IsBorrowed { get; set; }
    }
}
