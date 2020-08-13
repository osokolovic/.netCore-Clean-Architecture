using CleanArchitecture.Application.ViewModels;
using System;
using System.Collections.Generic;
using System.Text;

namespace CleanArchitecture.Application.Interfaces
{
    public interface IBookService
    {
        //when implemented will return list of books
        //it only knows for viewmodel, not for model.
        //we are abstracting the core entitty by doing this.
        public BookViewModel GetBooks();
    }
}
