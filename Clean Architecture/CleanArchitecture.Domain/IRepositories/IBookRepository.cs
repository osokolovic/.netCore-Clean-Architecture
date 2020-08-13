using CleanArchitecture.Domain.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace CleanArchitecture.Domain.IRepositories
{
    public interface IBookRepository
    {
        IEnumerable<Book> GetBooks();
    }
}
