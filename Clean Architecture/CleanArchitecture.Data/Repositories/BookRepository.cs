using CleanArchitecture.Data.Context;
using CleanArchitecture.Domain.IRepositories;
using CleanArchitecture.Domain.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

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

        //we can fetch data asynchronously
        public async Task<IEnumerable<Book>> GetBooksAsync()
        {
            return await _libraryDbContext.Books.ToListAsync();
        }
    }
}
