using CleanArchitecture.Data.Context;
using CleanArchitecture.Domain.IRepositories;
using CleanArchitecture.Domain.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace CleanArchitecture.Data.Repositories
{
    public class BookRepository : IBookRepository
    {

        public LibraryDbContext _libraryDbContext;

        public BookRepository(LibraryDbContext libraryDbContext)
        {
            _libraryDbContext = libraryDbContext;
        }

        public IEnumerable<Book> GetBooks()
        {
            return _libraryDbContext.Books;
        }
    }
}
