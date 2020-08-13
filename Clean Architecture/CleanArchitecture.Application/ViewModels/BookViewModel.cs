using CleanArchitecture.Domain.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace CleanArchitecture.Application.ViewModels
{
    public class BookViewModel
    {
        //because this will return list of books
        public IEnumerable<Book> Books { get; set; }
    }
}
