using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using Uc.BookStore.Models;
using Uc.BookStore.Repository;

namespace Uc.BookStore.Controllers
{
    public class BookController : Controller
    {
        private readonly BookRepository _bookRepository= null;

        public BookController()
        { 
            _bookRepository= new BookRepository();
        }
        public List<BookModel> GetAllBooks()
        {
            return _bookRepository.GetAllBooks();
        }

        public BookModel GetBook(int id)
        {
            return _bookRepository.GetBookById(id);
        }

        public List<BookModel>SearchBooks(string bookName, string authorName)
        {
            return _bookRepository.SearchBook(bookName, authorName);
        }
    }
}
